using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace GestorAnticipos.Datos
{
    public class Anticipos
    {
        [PrimaryKey, AutoIncrement]
        public int idAnticipo { get; set; }
        public double monto { get; set; }
        public string fechaEntrega { get; set; } = DateTime.MinValue.ToString();

    }
}

