using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
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
        public static string CategoryLimitExceded = "Category limit has been exceded!";
        public static string AuthorizationDenied = "Authorization denied!";
        internal static string UserRegistered = "User registered.";
        internal static string UserNotFound = "User not found!";
        internal static string PasswordError = "Wrong password!";
        internal static string SuccessfulLogin = "Login successfully.";
        internal static string UserAlreadyExists = "User is already exist!";
        internal static string AccessTokenCreated = "Access Token created";
    }
}
