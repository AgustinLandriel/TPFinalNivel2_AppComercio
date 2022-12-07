using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using accesoDatos;
using System.Windows.Forms;

namespace negocio
{
    public class NegocioArticulo
    {
        //Atributos
        AccesoDatos datos = new AccesoDatos();


        //Métodos
        public List<Articulo> mostrarArticulos()
        {
            try
            {
                List<Articulo> listaArticulos = new List<Articulo>();


                datos.setQuery("SELECT id,codigo,nombre,descripcion,imagenurl,precio from ARTICULOS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                    aux.UrlImagen = (string)datos.Lector["imagenurl"];
                    aux.Precio = (decimal)datos.Lector["precio"];

                    listaArticulos.Add(aux);
                }

                return listaArticulos;
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
