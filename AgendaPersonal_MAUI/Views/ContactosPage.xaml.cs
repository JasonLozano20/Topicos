using AgendaPersonal_MAUI.ViewModels;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using AgendaPersonal_MAUI.Datos;
using AgendaPersonal_MAUI.Models;

namespace AgendaPersonal_MAUI.Views
{

    public partial class ContactosPage : ContentPage
    {
        private readonly ContactoDataBase _db;
       
        public ContactosPage()
        {
            InitializeComponent();
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "agenda.db");
            _db = new ContactoDataBase(dbPath);
            BindingContext = new ContactosViewModel();
            
        }
        private async void OnEliminarContacto(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var contacto = (Contacto)button.BindingContext;
            if (contacto == null) return;

            bool confirmar = await DisplayAlert(
                "Confirmar", $"¿Eliminar a {contacto.Nombre}?", "Sí","No"); 

            if (confirmar)
            {
                try
                {
                    //await _db.EliminarContactoAsync(contacto);
                    var viewModel = (ContactosViewModel)BindingContext;
                    await viewModel.EliminarContacto(contacto);
                    // var itemsSource = collectionView.ItemsSource as ObservableCollection<Contacto>;
                    //itemsSource?.Remove(contacto); 
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", $"No se pudo eliminar: {ex.Message}", "OK");
                }
            }
        }
        private async void OnEditarContacto(object sender, EventArgs args)
        {
            var button = (Button)sender;
            var contacto = (Contacto) button.BindingContext;
            
            //Console.WriteLine($"Editando contacto ID: {contacto.Id}");
            
            //var viewModel = (ContactosViewModel)BindingContext;
            //await viewModel.EditarContacto(contacto);
            await Navigation.PushAsync(new CrearContactoPage(contacto));

        }
    }
}