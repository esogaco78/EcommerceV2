using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Dapper;
using EcommerceV2.Models;
using System.Data.SqlClient;
using EcommerceV2.Controllers;

namespace EcommerceV2
{
    public class DataAccess
    {
        public void InsertUser(string email, string password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("EcommerceV2")))
            {
                var user = new User { Email = email, Password = password };
                var users = new List<User>();
                users.Add(user);

                connection.Execute("EcommerceV2.dbo.Users_Insert @Email, @Password", users);
            }
        }

        public IEnumerable<string> SelectAllUserEmails()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("EcommerceV2")))
            {
                var emails = connection.Query<string>("EcommerceV2.dbo.Users_SelectAllEmails");

                return emails;
            }
        }
    }
}