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

namespace presentacion
{
    public partial class frmArticulo : Form
    {
        //Atributos

        //Articulo articulo = null;
        private List<Articulo> listaArticulo = new List<Articulo>();
        private NegocioArticulo negocioArticulo = new NegocioArticulo();

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
                dgvArticulos.Columns["id"].Visible = false;
                dgvArticulos.Columns["urlimagen"].Visible = false;
                dgvArticulos.Columns["Marca"].Visible = false;
                dgvArticulos.Columns["Categoria"].Visible = false;

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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo frmAltaArticulo = new frmAltaArticulo();
            frmAltaArticulo.ShowDialog();
            cargarArticulos();
        }
    }
}
