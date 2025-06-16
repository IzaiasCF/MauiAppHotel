namespace MauiAppHotel;

public partial class SobrePage : ContentPage
{
	public SobrePage()
	{
		InitializeComponent();

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}