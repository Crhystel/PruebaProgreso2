using PruebaProgreso2.Interfaces;
using PruebaProgreso2.Models;
using PruebaProgreso2.Repositories;

namespace PruebaProgreso2;

public partial class VelascoCRecarga : ContentPage
{
    public Recarga recarga;
    IRecarga _recargaRepository;
    public List<Recarga> recargaList;
    //public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "CrhystelVelasco.txt");
    public VelascoCRecarga()
	{
		InitializeComponent();
        recarga= new Recarga();
        BindingContext= recarga;
        _recargaRepository= new RecargaRepository();
       
	}

  
    private void Buton1_Clicked(object sender, EventArgs e)
    {
        var nuevaRecarga = new Recarga
        {
            Nombre = crysvelasco_entry2.Text,
            NumeroTelefono = crysvelasco_entry1.Text,
            MensajeResultado = "Recarga exitosa"
        };

        if (_recargaRepository.CrearRecarga(nuevaRecarga))
        {
            crhysvelasco_label3.Text = "Recarga guardada con éxito.";
            CargarRecargas();
        }
        else
        {
            crhysvelasco_label3.Text = "Error al guardar la recarga.";
        }


    }
    private void CargarRecargas()
    {
        
        var recargas = _recargaRepository.DevuelveListRecarga();

       
        var recargasTexto = string.Join("\n", recargas.Select(r => $"{r.Nombre} - {r.NumeroTelefono}"));

        crhysvelasco_label3.Text = recargasTexto;
    }
    private void Buton2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VelascoCGrid());

    }
}


