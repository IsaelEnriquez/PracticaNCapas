using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.DAL.Repositorio
{
    public interface IGenericRepository<T>where T: class
    {
        Task<bool> Insertar (T modelo);
        Task<bool> Actualizar(T modelo);
        Task<T> Obtener(int Id);
        Task<bool> Eliminar(int Id);
        Task<IQueryable<T>> ObtenerTodo();
    }
}
