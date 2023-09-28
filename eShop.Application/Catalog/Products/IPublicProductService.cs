using EShop.ViewModels.Catalog.Products;
using EShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModal>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        //Task<List<ProductViewModal>> GetAll(string languageId);
    }
}
