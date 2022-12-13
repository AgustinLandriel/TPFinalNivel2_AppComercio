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
namespace presentacion
{
    public partial class frmVerDetalle : Form
    {
        private Articulo articulo;

        public frmVerDetalle()
        {
            InitializeComponent();
        }

        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lblDetalleNombre.Text = articulo.Nombre;
                lblDetalleDescripcion.Text = articulo.Descripcion;
                lblDetalleMarca.Text = articulo.Marca.NombreMarca;
                lblDetallePrecio.Text = "$" + articulo.Precio.ToString();
                CargarImagenDetalle(articulo.UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagenDetalle(string url)
        {
            try
            {
                pboxDetalleImagen.Load(url);
            }
            catch (Exception)
            {

                pboxDetalleImagen.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
    }
}
