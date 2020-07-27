using BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
    public class Clase
    {

        private Class1 objetocd = new Class1();



        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();




        public void Insertar(string nombre, String tipo, String region)
        {
            objetocd.Insertar(nombre, tipo, region);


        }

        public void Eliminiar(String Id)
        {

            objetocd.Eliminar(Convert.ToInt32(Id));

        }

        public void Editar(int Id, string Nombre, string tipo, string region, string foto)
        {

            objetocd.Editar(Id, Nombre,tipo,region,foto);

        }

        public DataTable mostrar()
        {

            DataTable tabla = new DataTable();  
            tabla = objetocd.Mostrar();
            return tabla;
        }
    }

}
