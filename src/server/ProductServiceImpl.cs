using Product;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Product.ProductService;
using System.Linq;

namespace server
{
    class ProductEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    //Service implementation
    public class ProductServiceImpl : ProductServiceBase
    {
        //just static collection for testing
        List<ProductEntity> _ProductsDataStore = new List<ProductEntity>()
        { new ProductEntity{Id = "product1", Name = "Product One", Description = "Product One Description" },
         new ProductEntity{Id = "product2", Name = "Product Two", Description = "Product Two Description" },
         new ProductEntity { Id = "product3", Name = "Product Three", Description = "Product Three Description" }
        };

        public override Task<CreateProductResponse> CreateProduct(CreateProductRequest request, ServerCallContext context)
        {
            var Product = request.Product;

            Product.Id = (new Random()).Next().ToString();

            _ProductsDataStore.Add(new ProductEntity()
            {
                Id = request.Product?.Id,
                Name = request.Product?.Name,
                Description = request.Product?.Description
            });

            return Task.FromResult(new CreateProductResponse()
            {
                Product = Product
            });
        }

        public override async Task<GetProductResponse> GetProduct(GetProductRequest request, ServerCallContext context)
        {
            var productId = request.ProductId;

            if (productId == null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid product id to GetProduct"));

            var result = _ProductsDataStore.FirstOrDefault(predicate => predicate.Id == productId);

            if (result == null)
                throw new RpcException(new Status(StatusCode.NotFound, $"The Product id {productId} wasn't found"));

            Product.Product Product = new Product.Product()
            {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description
            };
            return await Task.FromResult(new GetProductResponse() { Product = Product });
        }

        public override async Task<UpdateProductResponse> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        {
            var productId = request.Product?.Id;

            if (productId == null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid product id to UpdateProduct"));

            var result = _ProductsDataStore.FirstOrDefault(predicate => predicate.Id == productId);

            if (result == null)
                throw new RpcException(new Status(StatusCode.NotFound, $"The Product id {productId} wasn't found"));

            result.Name = request.Product?.Name;
            result.Description = request.Product?.Description;

            //just test, return same product
            return await Task.FromResult(new UpdateProductResponse() { Product = request.Product });
        }

        //Bi directional streaming
        public override async Task CreateProducts(IAsyncStreamReader<CreateProductRequest> requestStream, 
            IServerStreamWriter<CreateProductResponse> responseStream,
            ServerCallContext context)
        {
            var rnd = new Random();
            while (await requestStream.MoveNext())
            {
                var product = requestStream.Current.Product;
                Console.WriteLine("Got product:" + product);
                product.Id = rnd.Next(1000,100000).ToString();
                _ProductsDataStore.Add(new ProductEntity()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description
                });
                System.Threading.Thread.Sleep(2000);
                await responseStream.WriteAsync(new CreateProductResponse()
                {
                    Product = product
                });
            }

            Console.WriteLine("Products saved");
        }

        public override async Task<DeleteProductRepsponse> DeleteProduct(DeleteProductRequest request, ServerCallContext context)
        {
            var productId = request.ProductId;

            if (productId == null)
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid product id to DeleteProduct"));

            var result = _ProductsDataStore.FirstOrDefault(predicate => predicate.Id == productId);

            if (result == null)
                throw new RpcException(new Status(StatusCode.NotFound, $"The Product id {productId} wasn't found"));

            //remove from data store at this point
            return await Task.FromResult(new DeleteProductRepsponse() { Status = "Deleted" });

        }

        public override async Task GetAllProducts(GetAllProductsRequest request, IServerStreamWriter<GetAllProductsResponse> responseStream, ServerCallContext context)
        {
            var rnd = new Random();
            foreach (var item in _ProductsDataStore)
            {
                System.Threading.Thread.Sleep(rnd.Next(500,1500));
                await responseStream.WriteAsync(new GetAllProductsResponse()
                {
                    Product = new Product.Product()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                    }
                }) ;
            }
        }
    }
}
