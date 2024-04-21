namespace dquimbitaT3.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario ingresado:  "+usuario;
	}
}