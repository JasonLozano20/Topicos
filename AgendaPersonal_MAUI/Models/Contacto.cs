using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace AgendaPersonal_MAUI.Models
{
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string? Nombre { get; set; } 
        public string? Telefono { get; set; } 
        public string? Correo { get; set; } 
        public string? Direccion { get; set; } 

        public bool activo { get; set; }
    }

}
