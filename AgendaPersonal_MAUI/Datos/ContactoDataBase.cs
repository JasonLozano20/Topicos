using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaPersonal_MAUI.Models;
using SQLite;

namespace AgendaPersonal_MAUI.Datos
{
    public class ContactoDataBase
    {
        private readonly SQLiteAsyncConnection _db;
       
        public ContactoDataBase(string dbPath)
        {
            if (_db is not null)
                return;

            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Contacto>().Wait();
        }

        public Task<List<Contacto>> ObtenerContactosAsync() => _db.Table<Contacto>().ToListAsync();


        public async Task<List<Contacto>> GetItemsActivosAsync()
        { 
            return await _db.Table<Contacto>().Where(t => t.activo).ToListAsync();
        }
        public async Task<Contacto> GetItemAsync(int id)
        {
            return await _db.Table<Contacto>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
        private async Task Init()
        {
            try
            {
                if (_db?.TableMappings?.Any(m => m.MappedType.Name == nameof(Contacto)) == true)
                    return;

                await _db.CreateTableAsync<Contacto>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al inicializar DB: {ex.Message}");
                throw; 
            }
        }
        public async Task<int> GuardarContactoAsync(Contacto contacto)
        {
            await Init();
            return (contacto.Id != 0) ? await _db.UpdateAsync(contacto) : await _db.InsertAsync(contacto);
        } //=> contacto.Id != 0 ? _db.UpdateAsync(contacto) : _db.InsertAsync(contacto);
        public Task<int> EliminarContactoAsync(Contacto contacto) => _db.DeleteAsync(contacto);
        //public Task<int> EditarContactoAsync(Contacto contacto) => _db.UpdateAsync(contacto);
    }
}
