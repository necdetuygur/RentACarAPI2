using RentACar2.Core.Repositories;
using RentACar2.Core.Services;
using RentACar2.Core.UnitOfWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentACar2.Service.Services
{
    public class DapperService<TEntity> : IDapperService<TEntity> where TEntity : class
    {
        private readonly IDapperUnitOfWork _uow;
        private readonly IDapperRepository<TEntity> _dapperRepository;
        public DapperService(IDapperUnitOfWork uow, IDapperRepository<TEntity> dapperRepository)
        {
            _uow = uow;
            _dapperRepository = dapperRepository;
        }

        public void Execute(string sql, object param = null)
        {
            _dapperRepository.Execute(sql, param);
        }

        public async Task ExecuteAsync(string sql, object param = null)
        {
            await _dapperRepository.ExecuteAsync(sql, param);
        }

        public IEnumerable<TEntity> Query(string sql, object param = null)
        {
            return _dapperRepository.Query(sql, param);
        }

        public async Task<IEnumerable<TEntity>> QueryAsync(string sql, object param = null)
        {
            return await _dapperRepository.QueryAsync(sql, param);
        }

        public TEntity QueryFirst(string sql, object param = null)
        {
            return _dapperRepository.QueryFirst(sql, param);
        }

        public async Task<TEntity> QueryFirstAsync(string sql, object param = null)
        {
            return await _dapperRepository.QueryFirstAsync(sql, param);
        }

        public TEntity QueryFirstOrDefault(string sql, object param = null)
        {
            return _dapperRepository.QueryFirstOrDefault(sql, param);
        }

        public async Task<TEntity> QueryFirstOrDefaultAsync(string sql, object param = null)
        {
            return await _dapperRepository.QueryFirstOrDefaultAsync(sql, param);
        }

        public TEntity QuerySingle(string sql, object param = null)
        {
            return _dapperRepository.QuerySingle(sql, param);
        }

        public async Task<TEntity> QuerySingleAsync(string sql, object param = null)
        {
            return await _dapperRepository.QuerySingleAsync(sql, param);
        }

        public TEntity QuerySingleOrDefault(string sql, object param = null)
        {
            return QuerySingleOrDefault(sql, param);
        }

        public async Task<TEntity> QuerySingleOrDefaultAsync(string sql, object param = null)
        {
            return await QuerySingleOrDefaultAsync(sql, param);
        }
    }
}
