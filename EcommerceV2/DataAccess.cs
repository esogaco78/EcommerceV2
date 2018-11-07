using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Dapper;
using EcommerceV2.Models;
using System.Data.SqlClient;
using EcommerceV2.Helpers;

namespace EcommerceV2
{
    public class DataAccess
    {
        public void InsertUser(string email, string password)
        {
            using (IDbConnection connection = new SqlConnection(DataBaseHelper.ConnectionValue("EcommerceV2")))
            {
                var user = new User { Email = email, Password = password };
                var users = new List<User>();
                users.Add(user);

                connection.Execute("EcommerceV2.dbo.Users_Insert @Email, @Password", users);
            }
        }

        public List<string> SelectAllUserEmails()
        {
            using (IDbConnection connection = new SqlConnection(DataBaseHelper.ConnectionValue("EcommerceV2")))
            {
                var emails = connection.Query<string>("EcommerceV2.dbo.Users_SelectAllEmails").ToList();

                return emails;
            }
        }

        public List<Product> SelectAllComputerProducts()
        {
            using (IDbConnection connection = new SqlConnection(DataBaseHelper.ConnectionValue("EcommerceV2")))
            {
                List<Product> computerProducts = connection.Query<Product>("EcommerceV2.dbo.Product_SelectAllComputers").ToList();

                return computerProducts;
            }
        }

        public List<Product> SelectAllVideoGames()
        {
            using (IDbConnection connection = new SqlConnection(DataBaseHelper.ConnectionValue("EcommerceV2")))
            {
                List<Product> videoGameProducts = connection.Query<Product>("EcommerceV2.dbo.Product_SelectAllVideoGames").ToList();

                return videoGameProducts;
            }
        }

        public List<Product> SelectAllTVs()
        {
            using (IDbConnection connection = new SqlConnection(DataBaseHelper.ConnectionValue("EcommerceV2")))
            {
                List<Product> tvProducts = connection.Query<Product>("EcommerceV2.dbo.Product_SelectAllTVs").ToList();

                return tvProducts;
            }
        }

        public Product SelectProductById(int productId)
        {
            using (IDbConnection connection = new SqlConnection(DataBaseHelper.ConnectionValue("EcommerceV2")))
            {
                string sql = "EXEC EcommerceV2.dbo.Product_SelectById @ProductId = " + productId.ToString();
                List<Product> products = connection.Query<Product>(sql).ToList();

                Product product = null;
                foreach (Product p in products) product = p;

                return product;
            }
        }

    }
}