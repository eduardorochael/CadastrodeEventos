using CadastroDeEventos.Models;

namespace CadastroDeEventos.Views
{
    public partial class ResumoPage : ContentPage
    {
        public ResumoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}