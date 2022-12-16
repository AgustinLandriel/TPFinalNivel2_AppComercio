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
using accesoDatos;
using negocio;


namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        //Atributos

        Articulo articulo = null;
        NegocioArticulo negocio = new NegocioArticulo();
        AccesoDatos datos = new AccesoDatos();

        //Métodos
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
            lblTitleAlta.Text = "Modificar artículo";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si no existe el articulo, lo creo.
                if (articulo == null)
                    articulo = new Articulo();

                //Oculto los labels obligatorios
                OcultarLabelsObligatorios();

                //Validar campos nulos o vacios
                if (!validarCamposObligatorios())
                {
                    return;
                }

                //Validar campo nombre
                if (!ValidarString(textNombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede tener numeros.");
                    return;
                }

                //Validar Campo Precio
                if (ValidarString(textPrecio.Text))
                {
                    MessageBox.Show("El campo Precio solo acepta decimal.");
                    return;
                }

                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = textNombre.Text;
                articulo.Descripcion = textDescripcion.Text;
                articulo.UrlImagen = textUrl.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(textPrecio.Text);


                if (articulo.Id != 0) //Si el ID es distinto a 0 es porque ya existe el articulo
                {
                   negocio.ModificarArticulo(articulo);
                    MessageBox.Show(articulo.Nombre + " ha sido modificado correctamente.");
                }
                else
                {
                   negocio.AgregarArticulos(articulo);
                   MessageBox.Show(articulo.Nombre + " ha sido agregado correctamente.");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                
                cboMarca.DataSource = negocio.mostrarMarcas();
                cboCategoria.DataSource = negocio.mostrarCategorias();
               

                //Value = key | display = valor
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "NombreMarca";

                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "NombreCategoria";

                //Sobreescribo los datos del articulo si se modifica
                if (articulo != null)
                {
                    textCodigo.Text = articulo.Codigo;
                    textNombre.Text = articulo.Nombre;
                    textDescripcion.Text = articulo.Descripcion;
                    textUrl.Text = articulo.UrlImagen;
                    cargarImagen(textUrl.Text);
                    textPrecio.Text = articulo.Precio.ToString();
                    cboCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    cboMarca.SelectedValue = articulo.Marca.IdMarca;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void textUrl_Leave(object sender, EventArgs e)
        {
            try
            {
                pboxArticulo.Load(textUrl.Text);
            }
            catch (Exception)
            {

                pboxArticulo.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
        private void cargarImagen(string url)
        {
            try
            {
                pboxArticulo.Load(url);
            }
            catch (Exception)
            {

                pboxArticulo.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private bool ValidarString(string cadena)
        {
            foreach (var item in cadena)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }

            return true;
        }

        private bool validarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(textCodigo.Text))
            {
                lblCompletarCod.Visible = true;
                return false;
            }
            else if (string.IsNullOrEmpty(textNombre.Text))
            {
                lblCompletarNombre.Visible = true;
                return false;
            }
            else if (string.IsNullOrEmpty(textDescripcion.Text))
            {
                lblCompletarDesc.Visible = true;
                return false;
            }
            else if (string.IsNullOrEmpty(textPrecio.Text)) {
                lblCompletarPrecio.Visible = true;
                return false;
            }

            return true;
        }

        private void OcultarLabelsObligatorios()
        {
            lblCompletarCod.Visible = false;
            lblCompletarNombre.Visible = false;
            lblCompletarDesc.Visible = false;
            lblCompletarPrecio.Visible = false;
        }

    }
}
