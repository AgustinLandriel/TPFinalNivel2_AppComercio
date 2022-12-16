
namespace presentacion
{
    partial class frmArticulo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.PictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.textFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBuscarFiltro = new System.Windows.Forms.Button();
            this.lblValidarCampo = new System.Windows.Forms.Label();
            this.lblValidarCriterio = new System.Windows.Forms.Label();
            this.lblValidarFiltro = new System.Windows.Forms.Label();
            this.btnReestablecerFiltro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(27, 178);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(646, 159);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // PictureBoxArticulo
            // 
            this.PictureBoxArticulo.Location = new System.Drawing.Point(719, 105);
            this.PictureBoxArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBoxArticulo.Name = "PictureBoxArticulo";
            this.PictureBoxArticulo.Size = new System.Drawing.Size(309, 315);
            this.PictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxArticulo.TabIndex = 1;
            this.PictureBoxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(252, 496);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(362, 496);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 32);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(473, 496);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblLista
            // 
            this.lblLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLista.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(12, 92);
            this.lblLista.Name = "lblLista";
            this.lblLista.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.lblLista.Size = new System.Drawing.Size(286, 70);
            this.lblLista.TabIndex = 4;
            this.lblLista.Text = "Lista de articulos";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.Location = new System.Drawing.Point(130, 496);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(103, 32);
            this.btnVerDetalle.TabIndex = 5;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(411, 145);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(105, 17);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Busqueda rápida:";
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(522, 141);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(151, 21);
            this.textBuscar.TabIndex = 7;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // textFiltroAvanzado
            // 
            this.textFiltroAvanzado.Enabled = false;
            this.textFiltroAvanzado.Location = new System.Drawing.Point(451, 398);
            this.textFiltroAvanzado.Name = "textFiltroAvanzado";
            this.textFiltroAvanzado.Size = new System.Drawing.Size(127, 22);
            this.textFiltroAvanzado.TabIndex = 11;
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(91, 395);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(101, 25);
            this.cboxCampo.TabIndex = 12;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio.Enabled = false;
            this.cboxCriterio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(270, 395);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(107, 25);
            this.cboxCriterio.TabIndex = 13;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(213, 403);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(51, 17);
            this.lblCriterio.TabIndex = 14;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(399, 403);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(39, 17);
            this.lblFiltro.TabIndex = 15;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(21, 402);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(64, 17);
            this.lblCampo.TabIndex = 16;
            this.lblCampo.Text = "Filtrar por:";
            // 
            // btnBuscarFiltro
            // 
            this.btnBuscarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFiltro.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFiltro.Location = new System.Drawing.Point(601, 392);
            this.btnBuscarFiltro.Name = "btnBuscarFiltro";
            this.btnBuscarFiltro.Size = new System.Drawing.Size(86, 29);
            this.btnBuscarFiltro.TabIndex = 17;
            this.btnBuscarFiltro.Text = "Buscar";
            this.btnBuscarFiltro.UseVisualStyleBackColor = true;
            this.btnBuscarFiltro.Click += new System.EventHandler(this.textBuscarFiltro_Click);
            // 
            // lblValidarCampo
            // 
            this.lblValidarCampo.AutoSize = true;
            this.lblValidarCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidarCampo.ForeColor = System.Drawing.Color.Red;
            this.lblValidarCampo.Location = new System.Drawing.Point(24, 423);
            this.lblValidarCampo.Name = "lblValidarCampo";
            this.lblValidarCampo.Size = new System.Drawing.Size(111, 16);
            this.lblValidarCampo.TabIndex = 18;
            this.lblValidarCampo.Text = "* Seleccione el campo";
            this.lblValidarCampo.Visible = false;
            // 
            // lblValidarCriterio
            // 
            this.lblValidarCriterio.AutoSize = true;
            this.lblValidarCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidarCriterio.ForeColor = System.Drawing.Color.Red;
            this.lblValidarCriterio.Location = new System.Drawing.Point(213, 423);
            this.lblValidarCriterio.Name = "lblValidarCriterio";
            this.lblValidarCriterio.Size = new System.Drawing.Size(100, 16);
            this.lblValidarCriterio.TabIndex = 19;
            this.lblValidarCriterio.Text = "* Seleccione criterio";
            this.lblValidarCriterio.Visible = false;
            // 
            // lblValidarFiltro
            // 
            this.lblValidarFiltro.AutoSize = true;
            this.lblValidarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidarFiltro.ForeColor = System.Drawing.Color.Red;
            this.lblValidarFiltro.Location = new System.Drawing.Point(399, 423);
            this.lblValidarFiltro.Name = "lblValidarFiltro";
            this.lblValidarFiltro.Size = new System.Drawing.Size(72, 16);
            this.lblValidarFiltro.TabIndex = 20;
            this.lblValidarFiltro.Text = "* Ingrese filtro";
            this.lblValidarFiltro.Visible = false;
            // 
            // btnReestablecerFiltro
            // 
            this.btnReestablecerFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReestablecerFiltro.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecerFiltro.Location = new System.Drawing.Point(581, 437);
            this.btnReestablecerFiltro.Name = "btnReestablecerFiltro";
            this.btnReestablecerFiltro.Size = new System.Drawing.Size(133, 29);
            this.btnReestablecerFiltro.TabIndex = 21;
            this.btnReestablecerFiltro.Text = "Reestablecer filtro";
            this.btnReestablecerFiltro.UseVisualStyleBackColor = true;
            this.btnReestablecerFiltro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 25);
            this.button2.TabIndex = 22;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 565);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReestablecerFiltro);
            this.Controls.Add(this.lblValidarFiltro);
            this.Controls.Add(this.lblValidarCriterio);
            this.Controls.Add(this.lblValidarCampo);
            this.Controls.Add(this.btnBuscarFiltro);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboxCriterio);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.textFiltroAvanzado);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.PictureBoxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Comercio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox PictureBoxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.TextBox textFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnBuscarFiltro;
        private System.Windows.Forms.Label lblValidarCampo;
        private System.Windows.Forms.Label lblValidarCriterio;
        private System.Windows.Forms.Label lblValidarFiltro;
        private System.Windows.Forms.Button btnReestablecerFiltro;
        private System.Windows.Forms.Button button2;
    }
}

