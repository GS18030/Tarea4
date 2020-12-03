using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GestorAnticipos.Vistas;
using GestorAnticipos.Datos;
using System.IO;

namespace GestorAnticipos
{
    public partial class App : Application
    {
        static Conexion data;

        public static Conexion Data
        {
            get
            {
                if (data == null)
                {
                    data = new Conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "basedatos.db3"));
                }
                return data;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new Tabbed();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
