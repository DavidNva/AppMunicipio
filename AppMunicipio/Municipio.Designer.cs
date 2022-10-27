namespace AppMunicipio
{
    partial class Frm_Municipio
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
            this.dgvMunicipio = new System.Windows.Forms.DataGridView();
            this.btnInsertarMun = new System.Windows.Forms.Button();
            this.txtIDMunicipio = new System.Windows.Forms.TextBox();
            this.txtNombreMunicipio = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblIDMunicipio = new System.Windows.Forms.Label();
            this.lblNombreMunicipio = new System.Windows.Forms.Label();
            this.lblDireccionMun = new System.Windows.Forms.Label();
            this.lblCodigoPostalMun = new System.Windows.Forms.Label();
            this.btnEliminarMun = new System.Windows.Forms.Button();
            this.btnActualizarMun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMunicipio
            // 
            this.dgvMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipio.Location = new System.Drawing.Point(20, 223);
            this.dgvMunicipio.Name = "dgvMunicipio";
            this.dgvMunicipio.Size = new System.Drawing.Size(462, 150);
            this.dgvMunicipio.TabIndex = 0;
            // 
            // btnInsertarMun
            // 
            this.btnInsertarMun.Location = new System.Drawing.Point(115, 169);
            this.btnInsertarMun.Name = "btnInsertarMun";
            this.btnInsertarMun.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarMun.TabIndex = 2;
            this.btnInsertarMun.Text = "Insertar";
            this.btnInsertarMun.UseVisualStyleBackColor = true;
            this.btnInsertarMun.Click += new System.EventHandler(this.btnInsertarMun_Click);
            // 
            // txtIDMunicipio
            // 
            this.txtIDMunicipio.Location = new System.Drawing.Point(115, 15);
            this.txtIDMunicipio.Name = "txtIDMunicipio";
            this.txtIDMunicipio.Size = new System.Drawing.Size(335, 20);
            this.txtIDMunicipio.TabIndex = 3;
            // 
            // txtNombreMunicipio
            // 
            this.txtNombreMunicipio.Location = new System.Drawing.Point(115, 49);
            this.txtNombreMunicipio.Name = "txtNombreMunicipio";
            this.txtNombreMunicipio.Size = new System.Drawing.Size(335, 20);
            this.txtNombreMunicipio.TabIndex = 4;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(115, 115);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(335, 20);
            this.txtCodigoPostal.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 78);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(335, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblIDMunicipio
            // 
            this.lblIDMunicipio.AutoSize = true;
            this.lblIDMunicipio.Location = new System.Drawing.Point(17, 21);
            this.lblIDMunicipio.Name = "lblIDMunicipio";
            this.lblIDMunicipio.Size = new System.Drawing.Size(64, 13);
            this.lblIDMunicipio.TabIndex = 7;
            this.lblIDMunicipio.Text = "IdMunicipio:";
            // 
            // lblNombreMunicipio
            // 
            this.lblNombreMunicipio.AutoSize = true;
            this.lblNombreMunicipio.Location = new System.Drawing.Point(17, 56);
            this.lblNombreMunicipio.Name = "lblNombreMunicipio";
            this.lblNombreMunicipio.Size = new System.Drawing.Size(95, 13);
            this.lblNombreMunicipio.TabIndex = 8;
            this.lblNombreMunicipio.Text = "Nombre Municipio:";
            // 
            // lblDireccionMun
            // 
            this.lblDireccionMun.AutoSize = true;
            this.lblDireccionMun.Location = new System.Drawing.Point(17, 85);
            this.lblDireccionMun.Name = "lblDireccionMun";
            this.lblDireccionMun.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionMun.TabIndex = 9;
            this.lblDireccionMun.Text = "Dirección:";
            // 
            // lblCodigoPostalMun
            // 
            this.lblCodigoPostalMun.AutoSize = true;
            this.lblCodigoPostalMun.Location = new System.Drawing.Point(17, 118);
            this.lblCodigoPostalMun.Name = "lblCodigoPostalMun";
            this.lblCodigoPostalMun.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPostalMun.TabIndex = 10;
            this.lblCodigoPostalMun.Text = "CódigoPostal:";
            // 
            // btnEliminarMun
            // 
            this.btnEliminarMun.Location = new System.Drawing.Point(361, 169);
            this.btnEliminarMun.Name = "btnEliminarMun";
            this.btnEliminarMun.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarMun.TabIndex = 11;
            this.btnEliminarMun.Text = "Eliminar";
            this.btnEliminarMun.UseVisualStyleBackColor = true;
            this.btnEliminarMun.Click += new System.EventHandler(this.btnEliminarMun_Click);
            // 
            // btnActualizarMun
            // 
            this.btnActualizarMun.Location = new System.Drawing.Point(224, 169);
            this.btnActualizarMun.Name = "btnActualizarMun";
            this.btnActualizarMun.Size = new System.Drawing.Size(87, 23);
            this.btnActualizarMun.TabIndex = 12;
            this.btnActualizarMun.Text = "Actualizar";
            this.btnActualizarMun.UseVisualStyleBackColor = true;
            this.btnActualizarMun.Click += new System.EventHandler(this.btnActualizarMun_Click);
            // 
            // Frm_Municipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 382);
            this.Controls.Add(this.btnActualizarMun);
            this.Controls.Add(this.btnEliminarMun);
            this.Controls.Add(this.lblCodigoPostalMun);
            this.Controls.Add(this.lblDireccionMun);
            this.Controls.Add(this.lblNombreMunicipio);
            this.Controls.Add(this.lblIDMunicipio);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreMunicipio);
            this.Controls.Add(this.txtIDMunicipio);
            this.Controls.Add(this.btnInsertarMun);
            this.Controls.Add(this.dgvMunicipio);
            this.MaximizeBox = false;
            this.Name = "Frm_Municipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipios";
            this.Load += new System.EventHandler(this.Frm_Municipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMunicipio;
        private System.Windows.Forms.Button btnInsertarMun;
        private System.Windows.Forms.TextBox txtIDMunicipio;
        private System.Windows.Forms.TextBox txtNombreMunicipio;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblIDMunicipio;
        private System.Windows.Forms.Label lblNombreMunicipio;
        private System.Windows.Forms.Label lblDireccionMun;
        private System.Windows.Forms.Label lblCodigoPostalMun;
        private System.Windows.Forms.Button btnEliminarMun;
        private System.Windows.Forms.Button btnActualizarMun;
    }
}

