using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestorAnticipos.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListadoEmpleados : ContentPage
    {
        private ObservableCollection<Datos.Empleados> listaEmpleados;

        public ObservableCollection<Datos.Empleados> ListEmpleados
        {
            get { return listaEmpleados; }
            set { listaEmpleados = value; }

        }


        public ListadoEmpleados()
        {
            InitializeComponent();

            listaEmpleados = new ObservableCollection<Datos.Empleados>();

            listarEmpleados();
        }

        public void listarEmpleados()
        {
            Datos.ConsultaEmpleados consulta = new Datos.ConsultaEmpleados();
            var data = consulta.getEmpleados();

            foreach (var item in data)
            {
                Datos.Empleados empleado = new Datos.Empleados()
                {
                    nombre = item.nombre,
                    cargo = item.cargo,
                    salario = item.salario
                };

                ListEmpleados.Add(empleado);
            }

            listVEmpleados.ItemsSource = ListEmpleados;
        }

        private void buscador_TextChanged(object sender, TextChangedEventArgs e)
        {
            listaEmpleados = new ObservableCollection<Datos.Empleados>();
            Datos.ConsultaEmpleados consulta = new Datos.ConsultaEmpleados();
            var data = consulta.getEmpleadosSearch(buscador.Text);

            foreach (var item in data)
            {
                Datos.Empleados empleado = new Datos.Empleados()
                {
                    nombre = item.nombre,
                    cargo = item.cargo,
                    salario = item.salario
                };
                ListEmpleados.Add(empleado);
            }
            listVEmpleados.ItemsSource = ListEmpleados;

        }

        /*protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = App.Data.getEmpleados();
        }*/


    }
}