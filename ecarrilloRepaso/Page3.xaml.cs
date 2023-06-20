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
    public partial class Page3 : ContentPage
    {
        public Page3( string usuario, double dato, string alumno)
        {
            InitializeComponent();

            lbUsuario.Text = "Usuario Conectado" + usuario;
            txtDato.Text = dato.ToString();
            txtEstudiante.Text = alumno;
        }
    }
}