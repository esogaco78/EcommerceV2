using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Dapper;
using EcommerceV2.Models;

namespace EcommerceV2.Controllers
{
    public class DataAccess
    {
        public void InsertUser(string email, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("EcommerceV2")))
            {
                var user = new User { Email = email, Password = password };
                var users = new List<User>();
                users.Add(user);

                connection.Execute("EcommerceV2.dbo.Users_Insert @Email, @Password", users);
            }
        }
    }
}