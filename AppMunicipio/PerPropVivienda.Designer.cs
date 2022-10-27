namespace AppMunicipio
{
    partial class PerPropVivienda
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
            this.btnActualizarPVivienda = new System.Windows.Forms.Button();
            this.btnEliminarPVivienda = new System.Windows.Forms.Button();
            this.lblCodigoPostalMun = new System.Windows.Forms.Label();
            this.lblDireccionMun = new System.Windows.Forms.Label();
            this.lblNombreMunicipio = new System.Windows.Forms.Label();
            this.lblIDMunicipio = new System.Windows.Forms.Label();
            this.txtIDPersona = new System.Windows.Forms.TextBox();
            this.txtIDVivienda = new System.Windows.Forms.TextBox();
            this.txtIDPVivienda = new System.Windows.Forms.TextBox();
            this.btnInsertarPVivienda = new System.Windows.Forms.Button();
            this.dgvPVivienda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioPredio = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPVivienda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarPVivienda
            // 
            this.btnActualizarPVivienda.Location = new System.Drawing.Point(258, 184);
            this.btnActualizarPVivienda.Name = "btnActualizarPVivienda";
            this.btnActualizarPVivienda.Size = new System.Drawing.Size(87, 23);
            this.btnActualizarPVivienda.TabIndex = 25;
            this.btnActualizarPVivienda.Text = "Actualizar";
            this.btnActualizarPVivienda.UseVisualStyleBackColor = true;
            this.btnActualizarPVivienda.Click += new System.EventHandler(this.btnActualizarPVivienda_Click);
            // 
            // btnEliminarPVivienda
            // 
            this.btnEliminarPVivienda.Location = new System.Drawing.Point(395, 184);
            this.btnEliminarPVivienda.Name = "btnEliminarPVivienda";
            this.btnEliminarPVivienda.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarPVivienda.TabIndex = 24;
            this.btnEliminarPVivienda.Text = "Eliminar";
            this.btnEliminarPVivienda.UseVisualStyleBackColor = true;
            this.btnEliminarPVivienda.Click += new System.EventHandler(this.btnEliminarPVivienda_Click);
            // 
            // lblCodigoPostalMun
            // 
            this.lblCodigoPostalMun.AutoSize = true;
            this.lblCodigoPostalMun.Location = new System.Drawing.Point(21, 119);
            this.lblCodigoPostalMun.Name = "lblCodigoPostalMun";
            this.lblCodigoPostalMun.Size = new System.Drawing.Size(68, 13);
            this.lblCodigoPostalMun.TabIndex = 23;
            this.lblCodigoPostalMun.Text = "Fecha Pago:";
            // 
            // lblDireccionMun
            // 
            this.lblDireccionMun.AutoSize = true;
            this.lblDireccionMun.Location = new System.Drawing.Point(21, 86);
            this.lblDireccionMun.Name = "lblDireccionMun";
            this.lblDireccionMun.Size = new System.Drawing.Size(63, 13);
            this.lblDireccionMun.TabIndex = 22;
            this.lblDireccionMun.Text = "ID Persona:";
            // 
            // lblNombreMunicipio
            // 
            this.lblNombreMunicipio.AutoSize = true;
            this.lblNombreMunicipio.Location = new System.Drawing.Point(21, 57);
            this.lblNombreMunicipio.Name = "lblNombreMunicipio";
            this.lblNombreMunicipio.Size = new System.Drawing.Size(65, 13);
            this.lblNombreMunicipio.TabIndex = 21;
            this.lblNombreMunicipio.Text = "ID Vivienda:";
            // 
            // lblIDMunicipio
            // 
            this.lblIDMunicipio.AutoSize = true;
            this.lblIDMunicipio.Location = new System.Drawing.Point(21, 22);
            this.lblIDMunicipio.Name = "lblIDMunicipio";
            this.lblIDMunicipio.Size = new System.Drawing.Size(73, 13);
            this.lblIDMunicipio.TabIndex = 20;
            this.lblIDMunicipio.Text = "Id P Vivienda:";
            // 
            // txtIDPersona
            // 
            this.txtIDPersona.Location = new System.Drawing.Point(156, 79);
            this.txtIDPersona.Name = "txtIDPersona";
            this.txtIDPersona.Size = new System.Drawing.Size(335, 20);
            this.txtIDPersona.TabIndex = 18;
            // 
            // txtIDVivienda
            // 
            this.txtIDVivienda.Location = new System.Drawing.Point(156, 50);
            this.txtIDVivienda.Name = "txtIDVivienda";
            this.txtIDVivienda.Size = new System.Drawing.Size(335, 20);
            this.txtIDVivienda.TabIndex = 17;
            // 
            // txtIDPVivienda
            // 
            this.txtIDPVivienda.Location = new System.Drawing.Point(156, 16);
            this.txtIDPVivienda.Name = "txtIDPVivienda";
            this.txtIDPVivienda.Size = new System.Drawing.Size(335, 20);
            this.txtIDPVivienda.TabIndex = 16;
            // 
            // btnInsertarPVivienda
            // 
            this.btnInsertarPVivienda.Location = new System.Drawing.Point(149, 184);
            this.btnInsertarPVivienda.Name = "btnInsertarPVivienda";
            this.btnInsertarPVivienda.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarPVivienda.TabIndex = 15;
            this.btnInsertarPVivienda.Text = "Insertar";
            this.btnInsertarPVivienda.UseVisualStyleBackColor = true;
            this.btnInsertarPVivienda.Click += new System.EventHandler(this.btnInsertarPVivienda_Click);
            // 
            // dgvPVivienda
            // 
            this.dgvPVivienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPVivienda.Location = new System.Drawing.Point(24, 233);
            this.dgvPVivienda.Name = "dgvPVivienda";
            this.dgvPVivienda.Size = new System.Drawing.Size(544, 150);
            this.dgvPVivienda.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Precio Predio:";
            // 
            // txtPrecioPredio
            // 
            this.txtPrecioPredio.Location = new System.Drawing.Point(156, 142);
            this.txtPrecioPredio.Name = "txtPrecioPredio";
            this.txtPrecioPredio.Size = new System.Drawing.Size(335, 20);
            this.txtPrecioPredio.TabIndex = 26;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(156, 113);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(335, 20);
            this.dtpFechaPago.TabIndex = 28;
            // 
            // PerPropVivienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 398);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioPredio);
            this.Controls.Add(this.btnActualizarPVivienda);
            this.Controls.Add(this.btnEliminarPVivienda);
            this.Controls.Add(this.lblCodigoPostalMun);
            this.Controls.Add(this.lblDireccionMun);
            this.Controls.Add(this.lblNombreMunicipio);
            this.Controls.Add(this.lblIDMunicipio);
            this.Controls.Add(this.txtIDPersona);
            this.Controls.Add(this.txtIDVivienda);
            this.Controls.Add(this.txtIDPVivienda);
            this.Controls.Add(this.btnInsertarPVivienda);
            this.Controls.Add(this.dgvPVivienda);
            this.MaximizeBox = false;
            this.Name = "PerPropVivienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerPropVivienda";
            this.Load += new System.EventHandler(this.PerPropVivienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPVivienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarPVivienda;
        private System.Windows.Forms.Button btnEliminarPVivienda;
        private System.Windows.Forms.Label lblCodigoPostalMun;
        private System.Windows.Forms.Label lblDireccionMun;
        private System.Windows.Forms.Label lblNombreMunicipio;
        private System.Windows.Forms.Label lblIDMunicipio;
        private System.Windows.Forms.TextBox txtIDPersona;
        private System.Windows.Forms.TextBox txtIDVivienda;
        private System.Windows.Forms.TextBox txtIDPVivienda;
        private System.Windows.Forms.Button btnInsertarPVivienda;
        private System.Windows.Forms.DataGridView dgvPVivienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioPredio;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
    }
}