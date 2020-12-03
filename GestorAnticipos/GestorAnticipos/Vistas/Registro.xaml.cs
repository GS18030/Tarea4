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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    DisplayAlert("Error", "Llene los campos", "Continuar");
                    txtMonto.Focus();
                    return;
                }
                else
                {
                    Anticipos tablaAnticipos = new Datos.Anticipos()
                    {
                        monto = double.Parse(txtMonto.Text),
                        fechaEntrega = pickerFecha.Date.ToShortDateString()
                    };
                    App.Data.insertAnticipos(tablaAnticipos);
                    DisplayAlert("Listo", "Se ha registrado con exito", "Aceptar");
                }
   
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void btnVer_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}