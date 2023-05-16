using Algartech.Models;

namespace Algartech.Repository.Contratos
{
    public interface ICategoriaRepositorio
    {
        Task<List<Categoria>> Lista();
    }
}
