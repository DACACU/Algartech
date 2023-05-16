using Microsoft.EntityFrameworkCore;
using Algartech.Models;
using Algartech.Repository.Contratos;

namespace Algartech.Repository.Implementacion
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly DBAlgartechVentaContext _dbContext;

        public CategoriaRepositorio(DBAlgartechVentaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Categoria>> Lista()
        {
            try
            {
                return await _dbContext.Categoria.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
