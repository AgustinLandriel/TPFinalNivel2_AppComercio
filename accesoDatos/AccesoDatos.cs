using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace accesoDatos
{
    public class AccesoDatos
    {
        //Atributos

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //Set de Lector
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //Constructor
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security = true;");
            comando = new SqlCommand();
        }

        //Métodos

        public void setQuery(string consulta)
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setParametros (string variable,object valor)
        {
            comando.Parameters.AddWithValue(variable, valor);
        }
        public void EjecutarLectura()
        {
            comando.Connection = conexion; //Establesco conexion del comando a la BD.

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader(); //Almaceno la consulta
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //Me ejecuta la accion,insert,update,delete,etc
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();

            conexion.Close();
        }
    }
}
