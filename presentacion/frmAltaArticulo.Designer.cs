
namespace presentacion
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitleAlta = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pboxArticulo = new System.Windows.Forms.PictureBox();
            this.lblValidarCampo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCompletarCod = new System.Windows.Forms.Label();
            this.lblCompletarDesc = new System.Windows.Forms.Label();
            this.lblCompletarNombre = new System.Windows.Forms.Label();
            this.lblCompletarPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleAlta
            // 
            this.lblTitleAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleAlta.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAlta.Location = new System.Drawing.Point(179, 21);
            this.lblTitleAlta.Name = "lblTitleAlta";
            this.lblTitleAlta.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.lblTitleAlta.Size = new System.Drawing.Size(292, 66);
            this.lblTitleAlta.TabIndex = 10;
            this.lblTitleAlta.Text = "Ingresar artículo";
            this.lblTitleAlta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(139, 115);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 20);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(144, 359);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 20);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.Location = new System.Drawing.Point(110, 240);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(86, 20);
            this.lblUrlImagen.TabIndex = 14;
            this.lblUrlImagen.Text = "URL imágen:";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(112, 196);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(84, 20);
            this.lblDescripción.TabIndex = 13;
            this.lblDescripción.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(135, 156);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Categoria:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(147, 280);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(49, 20);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Arial", 8.25F);
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(206, 280);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 22);
            this.cboMarca.TabIndex = 5;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Arial", 8.25F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(206, 320);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 22);
            this.cboCategoria.TabIndex = 6;
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(206, 117);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(121, 20);
            this.textCodigo.TabIndex = 1;
            // 
            // textUrl
            // 
            this.textUrl.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textUrl.Location = new System.Drawing.Point(207, 240);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(121, 20);
            this.textUrl.TabIndex = 4;
            this.textUrl.Leave += new System.EventHandler(this.textUrl_Leave);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textDescripcion.Location = new System.Drawing.Point(206, 198);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(121, 20);
            this.textDescripcion.TabIndex = 3;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textNombre.Location = new System.Drawing.Point(206, 158);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(121, 20);
            this.textNombre.TabIndex = 2;
            // 
            // textPrecio
            // 
            this.textPrecio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textPrecio.Location = new System.Drawing.Point(206, 361);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(121, 20);
            this.textPrecio.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAceptar.Location = new System.Drawing.Point(232, 441);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 36);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F);
            this.button2.Location = new System.Drawing.Point(361, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pboxArticulo
            // 
            this.pboxArticulo.Location = new System.Drawing.Point(444, 107);
            this.pboxArticulo.Name = "pboxArticulo";
            this.pboxArticulo.Size = new System.Drawing.Size(227, 266);
            this.pboxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxArticulo.TabIndex = 17;
            this.pboxArticulo.TabStop = false;
            // 
            // lblValidarCampo
            // 
            this.lblValidarCampo.AutoSize = true;
            this.lblValidarCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValidarCampo.ForeColor = System.Drawing.Color.Red;
            this.lblValidarCampo.Location = new System.Drawing.Point(12, 417);
            this.lblValidarCampo.Name = "lblValidarCampo";
            this.lblValidarCampo.Size = new System.Drawing.Size(121, 14);
            this.lblValidarCampo.TabIndex = 19;
            this.lblValidarCampo.Text = "* Campo obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(131, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(120, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(102, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(136, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(120, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(136, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "*";
            // 
            // lblCompletarCod
            // 
            this.lblCompletarCod.AutoSize = true;
            this.lblCompletarCod.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletarCod.ForeColor = System.Drawing.Color.Red;
            this.lblCompletarCod.Location = new System.Drawing.Point(333, 122);
            this.lblCompletarCod.Name = "lblCompletarCod";
            this.lblCompletarCod.Size = new System.Drawing.Size(60, 15);
            this.lblCompletarCod.TabIndex = 26;
            this.lblCompletarCod.Text = "Completar";
            this.lblCompletarCod.Visible = false;
            // 
            // lblCompletarDesc
            // 
            this.lblCompletarDesc.AutoSize = true;
            this.lblCompletarDesc.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletarDesc.ForeColor = System.Drawing.Color.Red;
            this.lblCompletarDesc.Location = new System.Drawing.Point(333, 201);
            this.lblCompletarDesc.Name = "lblCompletarDesc";
            this.lblCompletarDesc.Size = new System.Drawing.Size(60, 15);
            this.lblCompletarDesc.TabIndex = 27;
            this.lblCompletarDesc.Text = "Completar";
            this.lblCompletarDesc.Visible = false;
            // 
            // lblCompletarNombre
            // 
            this.lblCompletarNombre.AutoSize = true;
            this.lblCompletarNombre.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletarNombre.ForeColor = System.Drawing.Color.Red;
            this.lblCompletarNombre.Location = new System.Drawing.Point(333, 161);
            this.lblCompletarNombre.Name = "lblCompletarNombre";
            this.lblCompletarNombre.Size = new System.Drawing.Size(60, 15);
            this.lblCompletarNombre.TabIndex = 28;
            this.lblCompletarNombre.Text = "Completar";
            this.lblCompletarNombre.Visible = false;
            // 
            // lblCompletarPrecio
            // 
            this.lblCompletarPrecio.AutoSize = true;
            this.lblCompletarPrecio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletarPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblCompletarPrecio.Location = new System.Drawing.Point(336, 364);
            this.lblCompletarPrecio.Name = "lblCompletarPrecio";
            this.lblCompletarPrecio.Size = new System.Drawing.Size(60, 15);
            this.lblCompletarPrecio.TabIndex = 30;
            this.lblCompletarPrecio.Text = "Completar";
            this.lblCompletarPrecio.Visible = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 501);
            this.Controls.Add(this.lblCompletarPrecio);
            this.Controls.Add(this.lblCompletarNombre);
            this.Controls.Add(this.lblCompletarDesc);
            this.Controls.Add(this.lblCompletarCod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValidarCampo);
            this.Controls.Add(this.pboxArticulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitleAlta);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleAlta;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pboxArticulo;
        private System.Windows.Forms.Label lblValidarCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCompletarCod;
        private System.Windows.Forms.Label lblCompletarDesc;
        private System.Windows.Forms.Label lblCompletarNombre;
        private System.Windows.Forms.Label lblCompletarPrecio;
    }
}