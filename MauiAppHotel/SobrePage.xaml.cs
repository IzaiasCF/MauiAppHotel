namespace MauiAppHotel;

public partial class SobrePage : ContentPage
{
    public SobrePage()
    {
        InitializeComponent();

        // Forçar ocultar NavigationBar via C#
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Voltar para a página anterior
        await Navigation.PopAsync();
    }
}
