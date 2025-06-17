namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();

        // Isso garante que o cabe�alho n�o aparece ao abrir a p�gina
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
