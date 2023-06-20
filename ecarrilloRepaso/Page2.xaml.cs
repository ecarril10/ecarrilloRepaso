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
    public partial class Page2 : ContentPage
    {
        String usuario1;
        public Page2( string usuario)
        {
            InitializeComponent();

            lbUsuario.Text = "Usuario Conectado: " + usuario;
            usuario1 = usuario;
        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                double dato = Convert.ToDouble(txtDato.Text);

                if (dato > 100)
                {
                    DisplayAlert("ERROR", "EL DATO NO ESTA EN EL RANGO ADMITIDO", "CERAR");
                    txtDato.Text = "";
                }
            }
            catch (Exception ex)
            {
                //DisplayAlert("ERROR", ex.Message, "CERAR");
          
            }

        }

        private void btAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtDato.Text);
            string alumno = pkAlumno.Items[pkAlumno.SelectedIndex];

            Navigation.PushAsync(new Page3(usuario1, dato, alumno));

        }
    }
}