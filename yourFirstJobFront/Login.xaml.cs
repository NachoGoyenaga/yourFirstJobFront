using yourFirstJobFront.Entidades.Request; 
using yourFirstJobFront.Utilitarios
namespace yourFirstJobFront;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void btnIngresar_Clicked(object sender, EventArgs e)
    {
        try
        {
            ReqLogin req = new ReqLogin();

            req.correoElectronico = txtCorreo.Text;
            req.password = txtPassword.Text;

            var jsonContent = new StringContent(JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json");

            HttpClient httpClient = new HttpClient();

            var response = await httpClient.PostAsync(laURL + "/api/usuario/login", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                ResLogin res = new ResLogin();

                res = JsonConvert.DeserializeObject<ResLogin>(responseContent);

                if (res.result)
                {

                    Sesion.usuarioSesion.id = res.usuario.id;
                    Sesion.usuarioSesion.correoElectronico = res.usuario.correoElectronico;
                    Sesion.usuarioSesion.nombre = res.usuario.nombre;
                    Sesion.usuarioSesion.apellidos = res.usuario.apellidos;

                    Navigation.PushAsync(new MainPage());

                }
                else
                {
                    await DisplayAlert("Incorrecto", "�Usuario o contrase�a incorrecto!", "Aceptar");
                }
            }
            else
            {
                await DisplayAlert("No se encontr� el backend", "Error en la conexi�n con el EndPoint", "Aceptar");
            }

        }
        catch (Exception ex)
        {
            await DisplayAlert("Error interno", "Error en la aplicaci�n: " + ex.StackTrace.ToString(), "Aceptar");
        }
    }
}