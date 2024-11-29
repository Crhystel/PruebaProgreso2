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
        //recarga.NumeroTelefono = crhysvelasco_entr1.Text;

    }

    private void Buton2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VelascoCGrid());

    }
}

//public partial class RecargaPage : ContentPage
//{
//    private const string FileName = "SantiagoCordova.txt";

//    public RecargaPage()
//    {
//        InitializeComponent();
//        CargarUltimaRecarga();
//    }

//    private async void OnRecargarClicked(object sender, EventArgs e)
//    {
//        string numero = scordova_entry_phone.Text;
//        string nombre = scordova_entry_name.Text;

//        if (!string.IsNullOrWhiteSpace(numero) && !string.IsNullOrWhiteSpace(nombre))
//        {
//            string recarga = $"Nombre: {nombre}, Teléfono: {numero}, Fecha: {DateTime.Now}";
//            string filePath = Path.Combine(FileSystem.AppDataDirectory, FileName);

//            File.WriteAllText(filePath, recarga);

//            await DisplayAlert("Éxito", "Recarga realizada correctamente", "OK");
//            CargarUltimaRecarga();
//            LimpiarCampos();
//        }
//        else
//        {
//            await DisplayAlert("Error", "Por favor completa todos los campos.", "OK");
//        }
//    }

//    private void CargarUltimaRecarga()
//    {
//        string filePath = Path.Combine(FileSystem.AppDataDirectory, FileName);
//        if (File.Exists(filePath))
//        {
//            string ultimaRecarga = File.ReadAllText(filePath);
//            scordova_label_ultimaRecarga.Text = $"Última recarga: {ultimaRecarga}";
//        }
//    }

//    private void LimpiarCampos()
//    {
//        scordova_entry_phone.Text = string.Empty;
//        scordova_entry_name.Text = string.Empty;
//    }
//}
