namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();

        // Isso garante que o cabeçalho não aparece ao abrir a página
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Ok");
        }
    }
}
