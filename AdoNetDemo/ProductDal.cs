using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            //Read(), gelen kayıtları satır satır okumak için kullanılır, okuyabildiğin sürece döngüde kal
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();

            return products;
        }

        //Günümüzde DataTable neredeyse kullanılmadığını hatta kullanılmaması gerektiğini söyleyebiliriz
        //Bellek açısından pahalı bir nesnedir, serileştirme özelliği yoktur
        //Profesyonel iş hayatında ya hiç kullanılmaz ya da belli bir seviyeye kadar kullanılır
        //Data Access Layer'da kulanılıp sonra daha kullanışlı nesnelere çevirilirler
        public DataTable GetAll2()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            _connection.Close();

            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id",
                _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("delete from Products where Id=@id",
                _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
