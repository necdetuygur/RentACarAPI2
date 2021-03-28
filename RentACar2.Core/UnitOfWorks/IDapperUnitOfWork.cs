using System;
using System.Data;

namespace RentACar2.Core.UnitOfWorks
{
    public interface IDapperUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        IsolationLevel IsolationLevel { get; }
        void Commit();
    }
}
