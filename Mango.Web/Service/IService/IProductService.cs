﻿using Mango.Web.Models;

namespace Mango.Web.Service.IService
{


    public interface IProductService
    {
        //Task<ResponseDto?> GetProductAsync(string couponCode);
        Task<ResponseDto?> GetAllProductsAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductsAsync(ProductDto productDto);
        Task<ResponseDto?> UpdateProductAsync(ProductDto productDto);
        Task<ResponseDto?> DeleteProductAsync(int id);

    }

}
