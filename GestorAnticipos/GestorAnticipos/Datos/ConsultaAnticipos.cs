using System;
using System.Collections.Generic;
using System.Text;

namespace GestorAnticipos.Datos
{
    class ConsultaAnticipos
    {

        public List<Anticipos> getAnticipos()
        {
            return App.Data.db.Table<Anticipos>().ToList();
        }

        public int DeleteAnticipo(Anticipos tbl)
        {
            return App.Data.db.Delete(tbl);
        }

    }
}
