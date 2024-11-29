using PruebaProgreso2.Models;

namespace PruebaProgreso2;

public partial class VelascoCRecarga : ContentPage
{
    public Recarga recarga;
    public string FileName = "CrhystelVelasco.txt";
    public VelascoCRecarga()
	{
		InitializeComponent();
        recarga= new Recarga();
        BindingContext= recarga;
	}

  
    private void Buton1_Clicked(object sender, EventArgs e)
    {
        
    }

    private void Buton2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VelascoCGrid());

    }
}


