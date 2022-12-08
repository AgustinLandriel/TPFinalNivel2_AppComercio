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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si no existe el articulo, lo creo.
            if (articulo == null)
                articulo = new Articulo();
            try
            {

                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = textNombre.Text;
                articulo.Descripcion = textDescripcion.Text;
                articulo.UrlImagen = textUrl.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(cboPrecio.Text);

                negocio.AgregarArticulos(articulo);

                Close();
            }
            catch (Exception)
            {

                throw;
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
    }
}
