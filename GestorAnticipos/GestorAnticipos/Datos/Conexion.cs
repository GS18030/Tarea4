using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace GestorAnticipos.Datos
{
    public class Conexion
    { 
        public SQLiteConnection db;

        /*
         * Crea conexion de base de datos 
         * */
        public Conexion(string dbPath)
        {
            db = new SQLite.SQLiteConnection(dbPath);
            db.CreateTable<Empleados>();
            db.CreateTable<Anticipos>();
        }

        public List<Anticipos> getAnticipos()
        {
            return db.Table<Anticipos>().ToList();
        }


        public int insertEmpleados(Empleados tbl)
        {
            if (tbl.idEmpleado != 0)
            {
                return db.Update(tbl);
            }
            else
            {
                return db.Insert(tbl);
            }
        }

        public int insertAnticipos(Anticipos tblA)
        {
            if (tblA.idAnticipo != 0)
            {
                return db.Update(tblA);
            }
            else
            {
                return db.Insert(tblA);
            }
        }

        /*
        public List<consulta> lista()
        {
            var lis = db.Query<consulta>("SELECT Nombre, t.prueba FROM Tabla, tabla3 t WHERE tabla.tabla3 = t.id").ToList();
            return lis;
        }*/

        /*
         * Funcion para la eliminar
         * return int 
         * parameto objeto tipo tabla 
         * */
        public int DeleteRegistro(Empleados tbl)
        {
            return db.Delete(tbl);
        }

    }
}
