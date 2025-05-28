using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaPersonal_MAUI.Datos;
using AgendaPersonal_MAUI.Models;
using AgendaPersonal_MAUI.Views;

namespace AgendaPersonal_MAUI.ViewModels
{
    public class ContactosViewModel : BindableObject
    {
        private readonly ContactoDataBase _db;
        public ObservableCollection<Contacto> Contactos { get; } = new ObservableCollection<Contacto>();

        public Command CargarContactosCommand { get; }
        public Command AgregarContactoCommand { get; }

        public ContactosViewModel()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "agenda.db");
            _db = new ContactoDataBase(dbPath);

            CargarContactosCommand = new Command(async () => await CargarContactos());
            AgregarContactoCommand = new Command(async () => await AgregarContacto());



            Task.Run(async () => await CargarContactos());
        }

        private async Task CargarContactos()
        {
            Contactos.Clear();
            var contactos = await _db.ObtenerContactosAsync();

            MainThread.BeginInvokeOnMainThread(() =>
            {
                foreach (var contacto in contactos)
                {
                    Contactos.Add(contacto);
                }
            });
        }
        public async Task EliminarContacto(Contacto contacto)
        {
            try
            {
                await _db.EliminarContactoAsync(contacto);
                Contactos.Remove(contacto);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar: {ex.Message}");
            }
        }
        //public async Task EditarContacto(Contacto contacto)
        //{
        //    try
        //    {
        //        await _db.EditarContactoAsync(contacto);
        //        Contactos.Add(contacto);
                
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error al editar: {ex.Message}");
        //    }
        //}
        private async Task AgregarContacto()
        {
            
        }
    }
}

