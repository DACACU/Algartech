using Microsoft.EntityFrameworkCore;
using Algartech.Models;
using Algartech.Repository.Contratos;
using System.Linq.Expressions;

namespace Algartech.Repository.Implementacion
{
    public class RolRepositorio : IRolRepositorio
    {
        private readonly DBAlgartechVentaContext _dbContext;

        public RolRepositorio(DBAlgartechVentaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Rol>> Lista()
        {
            try
            {
                return await _dbContext.Rols.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
