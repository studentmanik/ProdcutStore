using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.Model;

namespace ProductStore.DAL
{
    class ProductGatway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["StoreConString"].ConnectionString;
        public bool GetProductCodeByCode(string productCode)
        {
            

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "select * from ProductStore where ProductCode='" + productCode + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            bool isProductExist = false;
            
            SqlDataReader aReader = command.ExecuteReader();
            isProductExist= aReader.Read();
            aReader.Close();
            connection.Close();
            return isProductExist;
        }

        public int Insert(Product aProduct)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("INSERT INTO ProductStore VALUES('{0}', '{1}', '{2}')", aProduct.ProductDescription, aProduct.Quantity, aProduct.ProductCode);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;

           
        }

        public List<Product> GetProduct()
        {
            SqlConnection connection = new SqlConnection(connectionString);

           string query = "SELECT * FROM ProductStore";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product anProduct = new Product();
                anProduct.Id =int.Parse(reader["Id"].ToString());
                anProduct.ProductCode = reader["ProductCode"].ToString();
                anProduct.ProductDescription = reader["ProductDescription"].ToString();
                anProduct.Quantity = int.Parse(reader["ProductQuantity"].ToString());
                

                products.Add(anProduct);
            }
            reader.Close();
            connection.Close();
            return products;
        }
    }
}
