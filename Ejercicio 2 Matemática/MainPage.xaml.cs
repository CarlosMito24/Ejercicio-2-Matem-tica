namespace Ejercicio_2_Matemática;

///<Summary>
///<Createddate> 2022/06/16 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/16 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
        if (!string.IsNullOrEmpty(Numero1.Text) && !string.IsNullOrEmpty(Numero2.Text))
		{
			double primero, segundo, totalsuma, cuadrado, total;
			primero = Convert.ToDouble(Numero1.Text);
			segundo = Convert.ToDouble(Numero2.Text);
			totalsuma = primero + segundo;
			cuadrado = totalsuma * totalsuma;
			total = cuadrado / 2;
			Fintotal.Text = Convert.ToString(total);
		}
        else
        {
            DisplayAlert("Error", "Introduce todos los números", "Ok");
        }
    }
}