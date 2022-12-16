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


                datos.setQuery(@"select a.id,IdMarca,IdCategoria,a.codigo,a.nombre,a.descripcion,a.imagenurl,c.Descripcion as [Categoria],
                                m.Descripcion as [Marca],a.precio
                                from ARTICULOS as a
                                inner join CATEGORIAS as c
                                on(IdCategoria = c.Id)
                                inner join MARCAS as m
                                on(IdMarca = m.Id)");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["id"];

                    if (!(datos.Lector["codigo"] is DBNull))
                    aux.Codigo = (string)datos.Lector["codigo"];
                    
                    if (!(datos.Lector["nombre"] is DBNull))
                     aux.Nombre = (string)datos.Lector["nombre"];
                    
                    if (!(datos.Lector["descripcion"] is DBNull))
                    aux.Descripcion = (string)datos.Lector["descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Marca.NombreMarca = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.NombreCategoria = (string)datos.Lector["Categoria"];

                    if(!(datos.Lector["imagenurl"] is DBNull))          //Si un campo de la BD ES nulo, no lo trae. Si NO lo es, lo trae.
                     aux.UrlImagen = (string)datos.Lector["imagenurl"];

                    if (!(datos.Lector["precio"] is DBNull))
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

        public List<Categoria> mostrarCategorias()
        {
            try
            {
                //Lista de categorias
                List<Categoria> listaCategorias = new List<Categoria>();

                //Me devuelvo el id y nombre de categorias

                string consulta = "SELECT id,descripcion from CATEGORIAS";
                datos.setQuery(consulta);
                datos.EjecutarLectura();

                //Leo la consulta almacenada en la propiedad Lector
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCategoria = (int)datos.Lector["id"];
                    aux.NombreCategoria = (string)datos.Lector["descripcion"];

                    listaCategorias.Add(aux);
                }

                return listaCategorias;
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
        public List<Marca> mostrarMarcas()
        {
            try
            {
                //Lista de marcas
                List<Marca> listaMarcas = new List<Marca>();

                //Me devuelvo el id y nombre de marcas

                string consulta = "SELECT id,descripcion from MARCAS";
                datos.setQuery(consulta);
                datos.EjecutarLectura();

                //Leo la consulta almacenada en la propiedad Lector
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IdMarca = (int)datos.Lector["id"];
                    aux.NombreMarca = (string)datos.Lector["descripcion"];

                    listaMarcas.Add(aux);
                }

                return listaMarcas;
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
        public void AgregarArticulos( Articulo articulo)
        {
            try
            {
                string consulta = "INSERT INTO ARTICULOS (codigo,nombre,descripcion,imagenurl,precio,idMarca,IdCategoria) values (@codigo,@nombre,@descripcion,@imagenurl,@precio,@marca,@categoria)";
                datos.setParametros("@codigo",articulo.Codigo);
                datos.setParametros("@nombre", articulo.Nombre);
                datos.setParametros("@descripcion", articulo.Descripcion);
                datos.setParametros("@imagenurl", articulo.UrlImagen);
                datos.setParametros("@precio", articulo.Precio);
                datos.setParametros("@marca", articulo.Marca.IdMarca);
                datos.setParametros("@categoria", articulo.Categoria.IdCategoria);
                datos.setQuery(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ModificarArticulo(Articulo articulo)
        {
            try
            {
                string consulta = "UPDATE ARTICULOS set codigo = @codigo,nombre = @nombre,descripcion=@descripcion,imagenurl = @imagenurl,precio=@precio,idMarca=@idMarca,idCategoria = @idCategoria WHERE id=@id";
                datos.setParametros("@id", articulo.Id);
                datos.setParametros("@codigo", articulo.Codigo);
                datos.setParametros("@nombre", articulo.Nombre);
                datos.setParametros("@descripcion", articulo.Descripcion);
                datos.setParametros("@imagenurl", articulo.UrlImagen);
                datos.setParametros("@precio", articulo.Precio);
                datos.setParametros("@idMarca", articulo.Marca.IdMarca);
                datos.setParametros("@idCategoria", articulo.Categoria.IdCategoria);
                datos.setQuery(consulta);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void EliminarArticulo (int id)
        {
            try
            {
                string consulta = "DELETE FROM ARTICULOS Where id = @id";
                datos.setParametros("@id", id);
                datos.setQuery(consulta);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
