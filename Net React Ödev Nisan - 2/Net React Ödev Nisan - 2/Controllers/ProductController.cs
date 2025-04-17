using Microsoft.AspNetCore.Mvc;
using Net_React_Ödev_Nisan___2.Models;
using System.Data.SqlClient;

namespace Net_React_Ödev_Nisan___2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<Product>();
            using (var conn = GetConnection())
            {
                NewMethod(conn);
                var cmd = new SqlCommand("SELECT * FROM Products", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()!,
                        Price = (decimal)reader["Price"],
                        Stock = (int)reader["Stock"]
                    });
                }
            }
            return Ok(products);

            static void NewMethod(SqlConnection conn)
            {
                conn.Open();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product? product = null;
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Products WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    product = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()!,
                        Price = (decimal)reader["Price"],
                        Stock = (int)reader["Stock"]
                    };
                }
            }
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Products (Name, Price, Stock) VALUES (@name, @price, @stock)", conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();
            }
            return Ok("Ürün eklendi.");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE Products SET Name=@name, Price=@price, Stock=@stock WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0) return NotFound();
            }
            return Ok("Ürün güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Products WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                var rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0) return NotFound();
            }
            return Ok("Ürün silindi.");
        }
    }
}