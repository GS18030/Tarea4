using System;
using System.Collections.Generic;
using System.Text;

namespace GestorAnticipos.Datos
{
    class ConsultaEmpleados
    {
        public ConsultaEmpleados()
        {

        }

        /*
         * Metodo para obtener todos los empleados de la tabla
         * */
        public List<Empleados> getEmpleados()
        {
            return App.Data.db.Table<Empleados>().ToList();
        }

        /*
         * Metodo para buscar un elemento en la tabla emplados
         * */

        public List<Empleados> getEmpleadosSearch(string nombre)
        {
            List<Empleados> lis = App.Data.db.Query<Empleados>("SELECT * FROM Empleados WHERE nombre LIKE '%" + nombre + "%'");
            return lis;
        }

    }
}
