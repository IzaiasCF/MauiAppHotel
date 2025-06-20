﻿using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte SuperLuxo",
                ValorDiariaAdulto = 110.00,
                ValorDiariaCrianca = 55.00
             },

             new Quarto()
             {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.00,
                ValorDiariaCrianca = 40.00
             },

            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.00,
                ValorDiariaCrianca = 25.00
             },

            new Quarto()
            {
                Descricao = "Suíte Básica",
                ValorDiariaAdulto = 25.00,
                ValorDiariaCrianca = 12.50
             }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
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
