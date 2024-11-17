using CadastroDeEventos.Models;

namespace CadastroDeEventos.Views
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private async void OnCadastrarEvento(object sender, EventArgs e)
        {
            var evento = BindingContext as Evento;
            if (evento != null)
            {
                await Navigation.PushAsync(new ResumoPage(evento));
            }
        }
    }
}

