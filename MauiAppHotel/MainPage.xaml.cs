
namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ContratacaoHospedagem());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SobrePage());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "Ok");
            }
        }
    }
}
