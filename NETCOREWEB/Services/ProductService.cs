using NETCOREWEB.Models;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace NETCOREWEB.Services
{
    public class ProductService : IProductService
    {
        private string _connectionString = "Data Source=RDS 엔드포인트;Initial Catalog=데이터베이스명;User ID=유저아이디;Password=패스워드입력";
        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var Params = new
                {
                    CATEGORY = 2
                };

                products = connection.Query<Product>("dbo.SP_GET_PRODUCTLIST" , param : Params , commandType : CommandType.StoredProcedure).AsList();
            }

            return products;
        }
    }
}
