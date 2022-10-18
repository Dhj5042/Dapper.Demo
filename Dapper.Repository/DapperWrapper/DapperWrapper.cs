using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.DapperWrapper
{
    public class DapperWrapper : IDapperWrapper
    {
        private readonly IConfiguration _configuration;

        #region Constructions
        public DapperWrapper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion
        
        private IDbConnection GetConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public List<T> GetData<T>(string commandText)
        {
            List<T> result;

            // get connection
            using IDbConnection dbConnection = GetConnection();

            if (dbConnection.State == ConnectionState.Closed)
                dbConnection.Open();

            try
            {
                   result = dbConnection.Query<T>(commandText).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

            return result;
        }

        public Task<int> AddData(string commandText,object values)
        {
            Task<int> result;

            // get connection
            using IDbConnection dbConnection = GetConnection();

            if (dbConnection.State == ConnectionState.Closed)
                dbConnection.Open();

            try
            {
                result = dbConnection.ExecuteAsync(commandText,values);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

            return result;
        }
    }
}
