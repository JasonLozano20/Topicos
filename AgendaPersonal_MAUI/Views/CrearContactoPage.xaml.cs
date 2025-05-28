namespace AgendaPersonal_MAUI.Views;
using AgendaPersonal_MAUI.Datos;
using AgendaPersonal_MAUI.Models;
using AgendaPersonal_MAUI.ViewModels;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;

public partial class CrearContactoPage : ContentPage
{
	private readonly ContactoDataBase _db;
	private Contacto contacto;

	public CrearContactoPage() : this(null) 
	{
	}
	public CrearContactoPage(Contacto contacto)
	{
        InitializeComponent();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "agenda.db");
        _db = new ContactoDataBase(dbPath);

        this.contacto = contacto ?? new Contacto();
        if (contacto != null)
		{
			nombreEntry.Text = contacto.Nombre;
			telefonoEntry.Text = contacto.Telefono;
			CorreoEmpty.Text = contacto.Correo;
			direccionEmpty.Text = contacto.Direccion;
		}
	}
	private async void OnGuardarClicked(object sender, EventArgs e)
	{
        if (contacto == null) 
        {
            await DisplayAlert("Error", "El contacto no existe", "OK");
            return;
        }
        if (string.IsNullOrEmpty(nombreEntry.Text) ||
			string.IsNullOrEmpty(telefonoEntry.Text) ||
			string.IsNullOrEmpty(CorreoEmpty.Text) ||
			string.IsNullOrEmpty(direccionEmpty.Text))
		{
			await DisplayAlert("Campos requeridos", "Es necesario llenar todos los campos","ok");
		}
		contacto.Nombre = nombreEntry.Text;
		contacto.Telefono = telefonoEntry.Text;
		contacto.Correo = CorreoEmpty.Text;
		contacto.Direccion = direccionEmpty.Text;
		

        try
        {
			
            await _db.GuardarContactoAsync(contacto);
     //      ObservableCollection<Contacto> contactos = new ObservableCollection<Contacto>();
	    //   contactos.Clear();
		   //await _db.ObtenerContactosAsync();
           await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"No se pudo guardar: {ex.Message}", "OK");
        }
		

    }
}
