using Microsoft.Data.SqlClient;
using System;

namespace StudentViolationApplication.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase()
        {
            _connectionString = "_connectionString = \"Data Source=LAPTOP-JUE9K85K\\\\SQLEXPRESS;Initial Catalog=StudentViolationDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;\";\r\n";


        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
