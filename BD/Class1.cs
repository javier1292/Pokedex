using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Class1
    {//para la imagen debes añadirla a la base de datos como una ruta (localizacion)

        private Bdconexion Conexion = new Bdconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void Insertar(string nombre, String tipo, String region)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into pokemon values ('" + nombre + "','" + tipo + "','" + region + "')";

            comando.ExecuteNonQuery();

        }


        public void Eliminar(int Id)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "Eliminar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id", Id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int Id, string Nombre,string tipo,string region,string foto)
        {

            SqlCommand comando = new SqlCommand();


            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "Editar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id",Id);
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@foto", foto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();




        }
        public DataTable Mostrar()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from pokemon " ;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }

    }
}
