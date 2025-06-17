namespace MauiAppHotel;

public partial class SobrePage : ContentPage
{
    public SobrePage()
    {
        InitializeComponent();

        // For�ar ocultar NavigationBar via C#
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Voltar para a p�gina anterior
        await Navigation.PopAsync();
    }
}
