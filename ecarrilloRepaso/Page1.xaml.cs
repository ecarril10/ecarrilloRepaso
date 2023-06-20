using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ecarrilloRepaso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btInicio_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contrasena = "2023";

            if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena) 
            {
                Navigation.PushAsync(new Page2(usuario));


            }
            else
            {
                DisplayAlert("ERROR", "USUARIO/CONTRASEÑA INCORRECTOS", "CERAR");
            }

        }

        private void btCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}