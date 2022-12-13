
namespace presentacion
{
    partial class frmVerDetalle
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.lblDetalleDescripcion = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.pboxDetalleImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDetalleImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(128, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DETALLE DEL PRODUCTO";
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetalleNombre.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleNombre.Location = new System.Drawing.Point(130, 113);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(74, 21);
            this.lblDetalleNombre.TabIndex = 3;
            this.lblDetalleNombre.Text = "Nombre";
            // 
            // lblDetalleDescripcion
            // 
            this.lblDetalleDescripcion.AutoSize = true;
            this.lblDetalleDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetalleDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDescripcion.Location = new System.Drawing.Point(130, 190);
            this.lblDetalleDescripcion.Name = "lblDetalleDescripcion";
            this.lblDetalleDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDetalleDescripcion.TabIndex = 4;
            this.lblDetalleDescripcion.Text = "Descripcion";
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetalleMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleMarca.Location = new System.Drawing.Point(130, 153);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(53, 20);
            this.lblDetalleMarca.TabIndex = 5;
            this.lblDetalleMarca.Text = "Marca";
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetallePrecio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallePrecio.Location = new System.Drawing.Point(130, 228);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(59, 21);
            this.lblDetallePrecio.TabIndex = 6;
            this.lblDetallePrecio.Text = "Precio";
            // 
            // pboxDetalleImagen
            // 
            this.pboxDetalleImagen.Location = new System.Drawing.Point(325, 91);
            this.pboxDetalleImagen.Name = "pboxDetalleImagen";
            this.pboxDetalleImagen.Size = new System.Drawing.Size(183, 188);
            this.pboxDetalleImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDetalleImagen.TabIndex = 7;
            this.pboxDetalleImagen.TabStop = false;
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(592, 306);
            this.Controls.Add(this.pboxDetalleImagen);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.lblDetalleMarca);
            this.Controls.Add(this.lblDetalleDescripcion);
            this.Controls.Add(this.lblDetalleNombre);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmVerDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle producto";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDetalleImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.Label lblDetalleDescripcion;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.PictureBox pboxDetalleImagen;
    }
}