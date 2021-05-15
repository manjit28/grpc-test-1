// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: product.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Product {
  public static partial class ProductService
  {
    static readonly string __ServiceName = "product.ProductService";

    static readonly grpc::Marshaller<global::Product.CreateProductRequest> __Marshaller_product_CreateProductRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.CreateProductRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.CreateProductResponse> __Marshaller_product_CreateProductResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.CreateProductResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.GetProductRequest> __Marshaller_product_GetProductRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.GetProductRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.GetProductResponse> __Marshaller_product_GetProductResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.GetProductResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.UpdateProductRequest> __Marshaller_product_UpdateProductRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.UpdateProductRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.UpdateProductResponse> __Marshaller_product_UpdateProductResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.UpdateProductResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.DeleteProductRequest> __Marshaller_product_DeleteProductRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.DeleteProductRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.DeleteProductRepsponse> __Marshaller_product_DeleteProductRepsponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.DeleteProductRepsponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.GetAllProductsRequest> __Marshaller_product_GetAllProductsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.GetAllProductsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Product.GetAllProductsResponse> __Marshaller_product_GetAllProductsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Product.GetAllProductsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Product.CreateProductRequest, global::Product.CreateProductResponse> __Method_CreateProduct = new grpc::Method<global::Product.CreateProductRequest, global::Product.CreateProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateProduct",
        __Marshaller_product_CreateProductRequest,
        __Marshaller_product_CreateProductResponse);

    static readonly grpc::Method<global::Product.GetProductRequest, global::Product.GetProductResponse> __Method_GetProduct = new grpc::Method<global::Product.GetProductRequest, global::Product.GetProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProduct",
        __Marshaller_product_GetProductRequest,
        __Marshaller_product_GetProductResponse);

    static readonly grpc::Method<global::Product.UpdateProductRequest, global::Product.UpdateProductResponse> __Method_UpdateProduct = new grpc::Method<global::Product.UpdateProductRequest, global::Product.UpdateProductResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateProduct",
        __Marshaller_product_UpdateProductRequest,
        __Marshaller_product_UpdateProductResponse);

    static readonly grpc::Method<global::Product.DeleteProductRequest, global::Product.DeleteProductRepsponse> __Method_DeleteProduct = new grpc::Method<global::Product.DeleteProductRequest, global::Product.DeleteProductRepsponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteProduct",
        __Marshaller_product_DeleteProductRequest,
        __Marshaller_product_DeleteProductRepsponse);

    static readonly grpc::Method<global::Product.GetAllProductsRequest, global::Product.GetAllProductsResponse> __Method_GetAllProducts = new grpc::Method<global::Product.GetAllProductsRequest, global::Product.GetAllProductsResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllProducts",
        __Marshaller_product_GetAllProductsRequest,
        __Marshaller_product_GetAllProductsResponse);

    static readonly grpc::Method<global::Product.CreateProductRequest, global::Product.CreateProductResponse> __Method_CreateProducts = new grpc::Method<global::Product.CreateProductRequest, global::Product.CreateProductResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "CreateProducts",
        __Marshaller_product_CreateProductRequest,
        __Marshaller_product_CreateProductResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Product.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductService</summary>
    [grpc::BindServiceMethod(typeof(ProductService), "BindService")]
    public abstract partial class ProductServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Product.CreateProductResponse> CreateProduct(global::Product.CreateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Product.GetProductResponse> GetProduct(global::Product.GetProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Product.UpdateProductResponse> UpdateProduct(global::Product.UpdateProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Product.DeleteProductRepsponse> DeleteProduct(global::Product.DeleteProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllProducts(global::Product.GetAllProductsRequest request, grpc::IServerStreamWriter<global::Product.GetAllProductsResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task CreateProducts(grpc::IAsyncStreamReader<global::Product.CreateProductRequest> requestStream, grpc::IServerStreamWriter<global::Product.CreateProductResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProductService</summary>
    public partial class ProductServiceClient : grpc::ClientBase<ProductServiceClient>
    {
      /// <summary>Creates a new client for ProductService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProductServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProductServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProductServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProductServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Product.CreateProductResponse CreateProduct(global::Product.CreateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Product.CreateProductResponse CreateProduct(global::Product.CreateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateProduct, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Product.CreateProductResponse> CreateProductAsync(global::Product.CreateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Product.CreateProductResponse> CreateProductAsync(global::Product.CreateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateProduct, null, options, request);
      }
      public virtual global::Product.GetProductResponse GetProduct(global::Product.GetProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Product.GetProductResponse GetProduct(global::Product.GetProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProduct, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Product.GetProductResponse> GetProductAsync(global::Product.GetProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Product.GetProductResponse> GetProductAsync(global::Product.GetProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProduct, null, options, request);
      }
      public virtual global::Product.UpdateProductResponse UpdateProduct(global::Product.UpdateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Product.UpdateProductResponse UpdateProduct(global::Product.UpdateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateProduct, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Product.UpdateProductResponse> UpdateProductAsync(global::Product.UpdateProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Product.UpdateProductResponse> UpdateProductAsync(global::Product.UpdateProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateProduct, null, options, request);
      }
      public virtual global::Product.DeleteProductRepsponse DeleteProduct(global::Product.DeleteProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Product.DeleteProductRepsponse DeleteProduct(global::Product.DeleteProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteProduct, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Product.DeleteProductRepsponse> DeleteProductAsync(global::Product.DeleteProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Product.DeleteProductRepsponse> DeleteProductAsync(global::Product.DeleteProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteProduct, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Product.GetAllProductsResponse> GetAllProducts(global::Product.GetAllProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllProducts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Product.GetAllProductsResponse> GetAllProducts(global::Product.GetAllProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllProducts, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Product.CreateProductRequest, global::Product.CreateProductResponse> CreateProducts(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateProducts(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Product.CreateProductRequest, global::Product.CreateProductResponse> CreateProducts(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_CreateProducts, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ProductServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ProductServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateProduct, serviceImpl.CreateProduct)
          .AddMethod(__Method_GetProduct, serviceImpl.GetProduct)
          .AddMethod(__Method_UpdateProduct, serviceImpl.UpdateProduct)
          .AddMethod(__Method_DeleteProduct, serviceImpl.DeleteProduct)
          .AddMethod(__Method_GetAllProducts, serviceImpl.GetAllProducts)
          .AddMethod(__Method_CreateProducts, serviceImpl.CreateProducts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Product.CreateProductRequest, global::Product.CreateProductResponse>(serviceImpl.CreateProduct));
      serviceBinder.AddMethod(__Method_GetProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Product.GetProductRequest, global::Product.GetProductResponse>(serviceImpl.GetProduct));
      serviceBinder.AddMethod(__Method_UpdateProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Product.UpdateProductRequest, global::Product.UpdateProductResponse>(serviceImpl.UpdateProduct));
      serviceBinder.AddMethod(__Method_DeleteProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Product.DeleteProductRequest, global::Product.DeleteProductRepsponse>(serviceImpl.DeleteProduct));
      serviceBinder.AddMethod(__Method_GetAllProducts, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Product.GetAllProductsRequest, global::Product.GetAllProductsResponse>(serviceImpl.GetAllProducts));
      serviceBinder.AddMethod(__Method_CreateProducts, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Product.CreateProductRequest, global::Product.CreateProductResponse>(serviceImpl.CreateProducts));
    }

  }
}
#endregion
