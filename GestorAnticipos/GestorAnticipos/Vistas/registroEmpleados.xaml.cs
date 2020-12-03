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
    public partial class registroEmpleados : ContentPage
    {
        public registroEmpleados()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrEmpty(txtSalario.Text))
                {
                    DisplayAlert("Error", "Llene los campos", "Continuar");
                    txtNombre.Focus();
                    return;
                }
                else
                {
                    Empleados tablaEmpleados = new Datos.Empleados()
                    {
                        nombre = (txtNombre.Text),
                        cargo = txtCargo.Text,
                        salario = double.Parse(txtSalario.Text)
                    };
                    App.Data.insertEmpleados(tablaEmpleados);
                    DisplayAlert("Listo", "Se ha registrado con exito", "Aceptar");
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}