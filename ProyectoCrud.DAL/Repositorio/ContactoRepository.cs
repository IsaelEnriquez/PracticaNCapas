using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCrud.DAL.DataContext;
using ProyectoCrud.Models;

namespace ProyectoCrud.DAL.Repositorio
{
    public class ContactoRepository : IGenericRepository<Contacto>
    {
        private readonly DbcrudcoreContext _dbContext;
        public ContactoRepository(DbcrudcoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Actualizar(Contacto modelo)
        {
            _dbContext.Contactos.Update(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Contacto model = _dbContext.Contactos.First(c=>c.IdContacto == id);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Contacto modelo)
        {
            _dbContext.Contactos.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Contacto> Obtener(int id)
        {
            return await _dbContext.Contactos.FindAsync(id);           
        }

        public async Task<IQueryable<Contacto>> ObtenerTodo(int id)
        {
            IQueryable<Contacto> queryContacto = _dbContext.Contactos;
            return queryContacto;
        }
    }
}
