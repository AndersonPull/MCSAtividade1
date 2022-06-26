using System;
using System.Collections.Generic;
using System.Linq;
using Model = Contract.Models.Product;

namespace BLL.Bll.Product.Implementation
{
    public class ProductBll : IProductBll
    {
        public ProductBll(){}

        public List<Model.Product> GetAll(string storeName)
        {
            List<Model.Product> Products = new List<Model.Product>();
            var paulistaStore = "Paulista";
            var morumbiStore = "Morumbi";

            var beef = new Model.Item { ItemId = Guid.NewGuid(), Name = "beef" };
            var pork = new Model.Item { ItemId = Guid.NewGuid(), Name = "pork" };
            var mustard = new Model.Item { ItemId = Guid.NewGuid(), Name = "mustard" };
            var ketchup = new Model.Item { ItemId = Guid.NewGuid(), Name = "ketchup" };
            var bread = new Model.Item { ItemId = Guid.NewGuid(), Name = "bread" };
            var wBread = new Model.Item { ItemId = Guid.NewGuid(), Name = "whole bread" };

            Products = new List<Model.Product>()
            {
                new Model.Product { ProductId = Guid.NewGuid(), Name = "Darth Bacon",
                    Image = "hamb1.png", StoreName = paulistaStore,
                    Items = new List<Model.Item> {beef, ketchup, bread }
                },
                new Model.Product { ProductId = Guid.NewGuid(), Name = "Cap. Spork",
                    Image = "hamb2.png", StoreName = paulistaStore,
                    Items = new List<Model.Item> { pork, mustard, wBread }
                },
                new Model.Product { ProductId = Guid.NewGuid(), Name = "Beef Turner",
                    Image = "hamb3.png", StoreName = morumbiStore,
                    Items = new List<Model.Item> {beef, mustard, bread }
                }
            };

            var productsByStore = Products.Where(product =>
                product.StoreName == storeName).ToList();

            return productsByStore;
        }
    }
}
