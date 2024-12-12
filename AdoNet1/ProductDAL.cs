    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using Microsoft.Data.SqlClient;

namespace AdoNet1
{
    public class ProductDAL
    {
        public List<Product> GetAll()
        {
            var _connection = SqlConnectionController();

            SqlCommand cmd =new  SqlCommand("Select *from product1",_connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product _products = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    name = reader["name"].ToString(),
                    stok = Convert.ToInt32(reader["stock"]),
                    price = Convert.ToDecimal(reader["price"])




                };
                products.Add(_products);

            }
            


            reader.Close();
            _connection.Close();
            return products;




            return products;
        }

        private static SqlConnection SqlConnectionController()
        {
            SqlConnection _connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=new;Integrated Security=True;");

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

            return _connection;
        }

        public void add(Product product)
        {
            SqlConnection _connection = SqlConnectionController();
            SqlCommand cmd = new SqlCommand("Insert into product1 values (@name,@price,@stock)", _connection);
            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@stock", product.stok);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            SqlConnection _connection = SqlConnectionController();
            SqlCommand cmd = new SqlCommand("Update product1 set price=@price,stock=@stock where Id=@ID", _connection);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@stock", product.stok);
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.ExecuteNonQuery();
        }

        public int GetByID(int id)
        {
            SqlConnection _connection = SqlConnectionController();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM product1 WHERE ID = @ID", _connection);
            cmd.Parameters.AddWithValue("@ID", id);
            var result = cmd.ExecuteScalar();
            int count = Convert.ToInt32(result);

            return count;
        }
        public void Delete(int id)
        {
            SqlConnection _connection = SqlConnectionController();
            SqlCommand cmd = new SqlCommand("DELETE FROM product1 WHERE Id = @Id", _connection);
            cmd.Parameters.AddWithValue("@Id",id);
            cmd.ExecuteNonQuery();
        }


    } 
    }
