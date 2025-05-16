using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaPersonal_MAUI.Models;

namespace AgendaPersonal_MAUI.ViewModels
{
    public class ContactosViewModel
    {
        public ObservableCollection<Contacto> Contactos { get; set; }

        public ContactosViewModel()
        {
             Contactos = new ObservableCollection<Contacto>
            {
                new Contacto { Nombre = "Juan Perez", Telefono = "6462512524", Correo = "juan@outlok.com", Direccion = "Calle 1" },
                new Contacto { Nombre = "Jose Valdez", Telefono = "6641252145", Correo = "Jose@hotmail.com", Direccion = "Calle 2" },
                new Contacto { Nombre = "Luis Torres", Telefono = "6467515462", Correo = "luis@gmail.com", Direccion = "Calle 3" }
            };
        }
    }
}
