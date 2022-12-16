using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using accesoDatos;

namespace presentacion
{
    public partial class frmArticulo : Form
    {
        //Atributos

        //Articulo articulo = null;
        private List<Articulo> listaArticulo = new List<Articulo>();
        private NegocioArticulo negocioArticulo = new NegocioArticulo();
        private AccesoDatos datos = new AccesoDatos();
        //Constructores
        public frmArticulo()
        {
            InitializeComponent();
        }

        //Metodos
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cargarArticulos();
                cboxCampo.Items.Add("Precio");
                cboxCampo.Items.Add("Marca");
                cboxCampo.Items.Add("Nombre");

            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
        }

        public void cargarArticulos()
        {
            try
            {
                listaArticulo = negocioArticulo.mostrarArticulos();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                PictureBoxArticulo.Load(listaArticulo[0].UrlImagen); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string url)
        {
            try
            {
                PictureBoxArticulo.Load(url);
            }
            catch (Exception)
            {

                PictureBoxArticulo.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["id"].Visible = false;
            dgvArticulos.Columns["urlimagen"].Visible = false;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
           

            //Si la grilla tiene datos, selecciona el articulo.
            if (dgvArticulos.CurrentRow != null)
            {
                try
                {
                  Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                  cargarImagen(seleccionado.UrlImagen);

                }
                catch (NullReferenceException ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo();
            frmAltaArticulo.ShowDialog();
            cargarArticulos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo frmModificarArticulo = new frmAltaArticulo(seleccionado);
            frmModificarArticulo.ShowDialog();
            cargarArticulos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro de eliminar este producto?","Eliminando producto",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            if(resultado == DialogResult.Yes)
            {
                try
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocioArticulo.EliminarArticulo(seleccionado.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }
            }

            cargarArticulos();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();

            try
            {
                string filtro = textBuscar.Text;

                //Funcion lambda que me filtra por nombre y marca. La guardo en una lista nueva filtrada.
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Marca.NombreMarca.ToLower().Contains(filtro.ToLower()));

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxCampo.SelectedItem == "Precio")
            {
                textFiltroAvanzado.Enabled = true;
                cboxCriterio.Enabled = true;
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Mayor a");
                cboxCriterio.Items.Add("Menor a");
                cboxCriterio.Items.Add("Igual a");

            } else if(cboxCampo.SelectedItem == "Marca")
            {
                cboxCriterio.Enabled = true;
                textFiltroAvanzado.Enabled = true;
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Coincide con");
                cboxCriterio.Items.Add("Empieza con");
                cboxCriterio.Items.Add("Termina con");
            }
            else
            {
                cboxCriterio.Enabled = true;
                textFiltroAvanzado.Enabled = true;
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Coincide con");
                cboxCriterio.Items.Add("Empieza con");
                cboxCriterio.Items.Add("Termina con");
            }
        }

        private void textBuscarFiltro_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();

            try
            {
                //Oculto los labels obligatorios para el usuario
                OcultarLabelsObligatorios();

                //Valido que cada campo este seleccionado 
                if (!validarCamposObligatorios())
                {
                    return;
                }

                //Valido que cuando se elija Precio, acepte SOLO numeros
                if(!ValidarNumero() && cboxCampo.SelectedItem == "Precio")
                {
                    MessageBox.Show("Ingrese un número para filtrar");
                    return;
                }

                //Valido para Marca y Nombre que solo acepte string
                if (ValidarNumero() && (cboxCampo.SelectedItem == "Marca" || cboxCampo.SelectedItem == "Nombre"))
                {
                    MessageBox.Show("No se aceptan numeros\n\nIngrese un Nombre o Marca para filtrar.");
                    return;
                }

                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = textFiltroAvanzado.Text;

                listaFiltrada = BusquedaFiltrada(campo, criterio, filtro);

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private bool validarCamposObligatorios()
        {
            if (cboxCampo.SelectedIndex == -1)
            {
                lblValidarCampo.Visible = true;
                return false;
            }
            else if (cboxCriterio.SelectedIndex == -1)
            {
                lblValidarCriterio.Visible = true;
                return false;
            }
            else if(string.IsNullOrEmpty(textFiltroAvanzado.Text))
            {
                lblValidarFiltro.Visible = true;
                return false;
            }

            return true;
        }

        private bool ValidarNumero()
        {
            foreach (var item in textFiltroAvanzado.Text)
            {
                if (!char.IsDigit(item))
                {
                    return false;
                }
            }

            return true;
        }
        private List<Articulo> BusquedaFiltrada(string campo, string criterio, string filtro)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();

            try
            {
                string consulta = @"select a.id,IdMarca,IdCategoria,a.codigo,a.nombre,a.descripcion,a.imagenurl,c.Descripcion as [Categoria],
                                m.Descripcion as [Marca],a.precio
                                from ARTICULOS as a
                                inner join CATEGORIAS as c
                                on(IdCategoria = c.Id)
                                inner join MARCAS as m
                                on(IdMarca = m.Id) WHERE ";

                //Si seleccionan este campo..
                if(campo == "Precio")
                {
                    //Selecciono el criterio 
                    switch (criterio)
                    {
                        case "Igual a":
                            consulta += "a.precio = " + filtro;break;
                        case "Mayor a":
                            consulta += "a.precio > " + filtro;break;
                        default://Menor a
                            consulta += "a.precio < " + filtro; break;
                    }
                } else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Coincide con":
                            consulta += "m.descripcion LIKE '%" + filtro + "%'"; break; //Like '%filtro%'
                        case "Empieza con":
                            consulta += "m.descripcion  LIKE'" + filtro + "%'";  break; //Like 'filtro%'
                        default: //Termina con
                            consulta += "m.descripcion  LIKE'%" + filtro + "'"; break; //like '%filtro'
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Coincide con":
                            consulta += "a.nombre  LIKE '%" + filtro + "%'"; break; //Like '%filtro%'
                        case "Empieza con":
                            consulta += "a.nombre  LIKE'" + filtro + "%'"; break; //Like 'filtro%'
                        default: //Termina con
                            consulta += "a.nombre  LIKE'%" + filtro + "'"; break; //like '%filtro'
                    }
                }

                // --------Ejecuto la consulta ya filtrada  ------

                datos.setQuery(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Marca.NombreMarca = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.NombreCategoria = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["imagenurl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["imagenurl"];
                    aux.Precio = (decimal)datos.Lector["precio"];

                    listaFiltrada.Add(aux);
                }

                return listaFiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmVerDetalle frmVerDetalle = new frmVerDetalle(seleccionado);
            frmVerDetalle.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Reestablezco los filtros y la grilla
            cboxCampo.SelectedIndex = -1;
            cboxCriterio.SelectedIndex = -1;
            cboxCriterio.Items.Clear();
            cboxCriterio.Enabled = false;
            textFiltroAvanzado.Text = "";
            textFiltroAvanzado.Enabled = false;
            OcultarLabelsObligatorios();
            cargarArticulos();
        }

        private void OcultarLabelsObligatorios()
        {
            lblValidarCampo.Visible = false;
            lblValidarCriterio.Visible = false;
            lblValidarFiltro.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBuscar.Text = ""; //Pongo el texto de busqueda rapida en vacio asi me devuelve toda la lista.
        }
    }
}
