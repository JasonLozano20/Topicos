using AgendaPersonal_MAUI.ViewModels;

namespace AgendaPersonal_MAUI.Views
{
    public partial class ContactosPage : ContentPage
    {
        public ContactosPage()
        {
            InitializeComponent();
            BindingContext = new ContactosViewModel();
        }
    }
}
