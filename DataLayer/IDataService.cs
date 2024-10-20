﻿using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IDataService
    {
        IList<Category> GetCategories();
        Category? GetCategory(int id);
        IList<Product> GetProducts();
        Product? GetProduct(int id);
        Category CreateCategory(string name, string description);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);

        IList<ProductSearchModel> GetProductByName(string search);
        IList<Category> GetCategoriesByName(string name);
    }
}