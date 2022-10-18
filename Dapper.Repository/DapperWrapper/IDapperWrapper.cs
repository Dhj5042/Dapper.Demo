using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.DapperWrapper
{
    public interface IDapperWrapper
    {
        List<T> GetData<T>(string commandText);
        Task<int> AddData(string commandText,object values);
    }
}
