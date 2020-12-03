using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace GestorAnticipos.Datos
{
    public class Empleados
    {

        [PrimaryKey, AutoIncrement]
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }

    }
}
