using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<quarto> lista_quartos = new List<quarto>
        {
            new quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.00,
                ValorDiariaCrianca = 55.00
            },
            new quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.00,
                ValorDiariaCrianca = 40.00
            },
            new quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 500.00,
                ValorDiariaCrianca = 25.00
            },
            new quarto()
            {
                Descricao = "Suíte Básica",
                ValorDiariaAdulto = 25.00,
                ValorDiariaCrianca = 12.50
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
            //MainPage = new NavigationPage(new MainPage());

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}
