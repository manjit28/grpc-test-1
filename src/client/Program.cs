using Grpc.Core;
using Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Channel channel = new Channel("localhost", 50052, ChannelCredentials.Insecure);

            await channel.ConnectAsync().ContinueWith((task) =>
            {
                if (task.Status == TaskStatus.RanToCompletion)
                    Console.WriteLine("The client connected successfully");
            });

            var client = new ProductService.ProductServiceClient(channel);
            //Product.Product product;


            //Test various operations
            int choice = -1;
            while (choice != 9)
            {
                choice = GetChoice();
                switch (choice)
                {
                    case 9:
                        break;
                    case 0:
                        //Create new product
                        var p1 = CreateProduct(client);
                        break;
                    case 1:
                        //Create new product
                        var p2 = GetProduct(client, "product1");
                        break;
                    case 2:
                        //update product
                        var p3 = GetProduct(client, "product1");
                        UpdateProduct(client, p3.Product);
                        break;
                    case 3:
                        //delete product
                        var p4 = GetProduct(client, "product1");
                        DeleteProduct(client, p4.Product);
                        break;
                    case 4:
                        //get all products
                        await ListProduct(client);
                        break;
                    case 5:
                        //Test Bidirectional streaming
                        // test setup with one second delay at client for sending each record 
                        // and two second delay at server side before saving
                        await CreateProducts(client);
                        break;
                    default:
                        break;
                }
            }

            //test rpc exception
            //GetProduct(client, "-1");
            Console.ReadKey();
            channel.ShutdownAsync().Wait();
        }

        private static int GetChoice()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select Test to do (number and return):");
            Console.WriteLine("0 : Create Product");
            Console.WriteLine("1 : Get Product");
            Console.WriteLine("2 : Update Product");
            Console.WriteLine("3 : Delete Product");
            Console.WriteLine("4 : Get All Products (server streaming)");
            Console.WriteLine("5 : Create Multiple Products (bidirectional streaming)");
            Console.WriteLine("9 : End Test");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        private static Product.Product CreateProduct(ProductService.ProductServiceClient client)
        {
            var response = client.CreateProduct(new CreateProductRequest()
            {
                Product = new Product.Product()
                {
                    Name = "Product X",
                    Description = "Product X Description"
                }
            });

            Console.WriteLine("The Product " + response.Product.Id + " was created !");

            return response.Product;
        }

        private async static Task CreateProducts(ProductService.ProductServiceClient client)
        {

            var products = new List<Product.Product>
            {
                new Product.Product() {Name = "Product X1", Description = "Product X1 Description" },
                new Product.Product() {Name = "Product X2", Description = "Product X2 Description" },
                new Product.Product() {Name = "Product X3", Description = "Product X3 Description" },
                new Product.Product() {Name = "Product X4", Description = "Product X4 Description" }

            };
            using (var call = client.CreateProducts())
            {
                var requestStream = call.RequestStream;
                var responseStream = call.ResponseStream;

                var responseTask = Task.Run(async () =>
                {
                    while (await responseStream.MoveNext())
                    {
                        Console.WriteLine("Saved: " + responseStream.Current.Product);
                    }
                });

                foreach (var product in products)
                {
                    await requestStream.WriteAsync(new CreateProductRequest() { Product = product });
                    System.Threading.Thread.Sleep(1000);
                }
                await call.RequestStream.CompleteAsync();
                await responseTask;
            }
        }

        private static GetProductResponse GetProduct(ProductService.ProductServiceClient client, string id)
        {
            try
            {
                var response = client.GetProduct(new GetProductRequest()
                {
                    ProductId = id
                });

                Console.WriteLine(response.Product.ToString());

                return response;
            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
                //just log and continue;
                Console.ReadKey();
                return null;
            }
        }
        private static void UpdateProduct(ProductService.ProductServiceClient client, Product.Product Product)
        {
            try
            {
                var response = client.UpdateProduct(new UpdateProductRequest()
                {
                    Product = Product
                });

                Console.WriteLine(response.Product.ToString());
            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
            }
        }
        private static void DeleteProduct(ProductService.ProductServiceClient client, Product.Product Product)
        {
            try
            {
                var response = client.DeleteProduct(new DeleteProductRequest() { ProductId = Product.Id });

                Console.WriteLine("The Product with id " + Product.Id + " was deleted");
            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
            }
        }
        private static async Task ListProduct(ProductService.ProductServiceClient client)
        {
            var response = client.GetAllProducts(new GetAllProductsRequest() { });

            while (await response.ResponseStream.MoveNext())
            {
                Console.WriteLine(response.ResponseStream.Current.Product.ToString());
            }
        }
    }
}
