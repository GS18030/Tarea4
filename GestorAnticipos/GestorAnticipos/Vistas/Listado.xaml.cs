using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GestorAnticipos.Datos;

namespace GestorAnticipos.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listado : ContentPage
    {
        public Listado()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaDatos.ItemsSource = App.Data.getAnticipos();
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}