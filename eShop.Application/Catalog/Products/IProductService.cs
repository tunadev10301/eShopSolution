using eShop.Application.Catalog.ProductImages;
using eShop.ViewModels.Catalog.ProductImages;
using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int id);
        Task<ProductViewModal> GetById(int id, string languageId);
        Task<bool> UpdatePrice(int ProductId, decimal newPrice);
        Task<bool> UpdateStock(int ProductId, int addedQuantity);
        Task AddViewcount(int ProductId);
        Task<PagedResult<ProductViewModal>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<ProductImageViewModal> GetImageById(int imageId);
        Task<List<ProductImageViewModal>> GetListImages(int productId);
        Task<PagedResult<ProductViewModal>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
