using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_ADO.DAL.UOW
{
    public interface IConnection : IDisposable
    {
        //bool _hasConnection { get; set; }
        IDbTransaction _transaction { get; set; }
        IDbConnection _connection { get; set; }
        IDbCommand CreateCommand();
        //void SaveChanges();
        //void Dispose();
    }
}
