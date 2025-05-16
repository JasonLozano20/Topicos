namespace AgendaPersonal_MAUI
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void IrListaContactos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ContactosPage());
        }
        private async void IrCrearContacto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.CrearContactoPage());
        }

        private async void IrConfiguracion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ConfiguracionPage());
        }

    }
}
