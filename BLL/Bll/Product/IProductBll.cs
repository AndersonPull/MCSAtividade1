using System.Collections.Generic;
using Model = Contract.Models.Product;

namespace BLL.Bll.Product
{
    public interface IProductBll
    {
        List<Model.Product> GetAll(string storeName);
    }
}
