using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    //static demek newlenmeyecek demektir.
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Invalid Product name!";
        public static string MaintenanceTime = "System is under maintenance";
        public static string ProductsListed = "Products are listed";
        public static string ProductInCategoryProblem = "Category can contain at most 10 products!";
        public static string ProductUpdated = "Product Updated";
        public static string ProductNameAlreadyExists = "There is already a product with same name!";
        internal static string CategoryLimitExceded = "Category limit has been exceded!";
    }
}
