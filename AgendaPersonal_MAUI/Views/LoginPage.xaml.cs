using System.Threading.Tasks;

namespace AgendaPersonal_MAUI.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        Application.Current.Quit();
        return true;
    }
    private async void TapGestureRecognizerPwd_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RecuperarContrasenaPage());
    }
    private async void TapGestureRecognizerReg_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistroPage());
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (IsCredentialCorrect(Username.Text, Password.Text))
        {
            Preferences.Set("UsuarioActual", Username.Text.Trim());
            await SecureStorage.SetAsync("hasAuth", "true");
            
            
            Application.Current.MainPage = new AppShell();
            await Shell.Current.GoToAsync("//MainPage");
        }
        else
        {
            Preferences.Remove("UsuarioActual");
            await DisplayAlert("Login failed", "Username or password if invalid", "Try again");
        }
    }


    bool IsCredentialCorrect(string username, string password)
    {
        return Username.Text == "admin" && Password.Text == "1234";
    }

    
}