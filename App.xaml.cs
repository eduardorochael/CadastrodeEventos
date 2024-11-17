using CadastroDeEventos.Views;

namespace CadastroDeEventos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Define a página inicial como a página de cadastro
        MainPage = new NavigationPage(new CadastroPage());
    }
}