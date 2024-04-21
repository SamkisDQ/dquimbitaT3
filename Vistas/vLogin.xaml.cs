namespace dquimbitaT3.Vistas;

public partial class vLogin : ContentPage
{	
	string[] user = { "Samkis","Diego","admin"};
    string[] pass = { "Samkis123", "Diego123", "Admin123" };
    public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string clave = txtClave.Text;
		bool verificar = false;
        for (int i = 0; i < user.Length; i++)
        {
            if (user[i] == usuario && pass[i] == clave)
            {
                verificar = true;
                break; // Termina el bucle si se encuentra una coincidencia
            }
        }
        if (verificar)
        {
            Navigation.PushAsync(new vPrincipal(usuario));
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o clave incorrecta", "cerrar");
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
    }
}