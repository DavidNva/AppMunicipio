namespace AppMunicipio
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarMunicipio = new System.Windows.Forms.Button();
            this.btnInsertarVivienda = new System.Windows.Forms.Button();
            this.btnInsertarPersona = new System.Windows.Forms.Button();
            this.btnInsertarPedidoVivienda = new System.Windows.Forms.Button();
            this.dgvPedidosActuales = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosActuales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "App Municipios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Qué deseas hacer?";
            // 
            // btnInsertarMunicipio
            // 
            this.btnInsertarMunicipio.BackColor = System.Drawing.Color.White;
            this.btnInsertarMunicipio.Location = new System.Drawing.Point(32, 166);
            this.btnInsertarMunicipio.Name = "btnInsertarMunicipio";
            this.btnInsertarMunicipio.Size = new System.Drawing.Size(227, 35);
            this.btnInsertarMunicipio.TabIndex = 2;
            this.btnInsertarMunicipio.Text = "Ver/Insertar Municipio";
            this.btnInsertarMunicipio.UseVisualStyleBackColor = false;
            this.btnInsertarMunicipio.Click += new System.EventHandler(this.btnInsertarMunicipio_Click);
            // 
            // btnInsertarVivienda
            // 
            this.btnInsertarVivienda.BackColor = System.Drawing.Color.White;
            this.btnInsertarVivienda.Location = new System.Drawing.Point(32, 210);
            this.btnInsertarVivienda.Name = "btnInsertarVivienda";
            this.btnInsertarVivienda.Size = new System.Drawing.Size(227, 35);
            this.btnInsertarVivienda.TabIndex = 3;
            this.btnInsertarVivienda.Text = "Ver/Insertar Vivienda";
            this.btnInsertarVivienda.UseVisualStyleBackColor = false;
            this.btnInsertarVivienda.Click += new System.EventHandler(this.btnInsertarVivienda_Click);
            // 
            // btnInsertarPersona
            // 
            this.btnInsertarPersona.BackColor = System.Drawing.Color.White;
            this.btnInsertarPersona.Location = new System.Drawing.Point(32, 251);
            this.btnInsertarPersona.Name = "btnInsertarPersona";
            this.btnInsertarPersona.Size = new System.Drawing.Size(227, 35);
            this.btnInsertarPersona.TabIndex = 4;
            this.btnInsertarPersona.Text = "Ver/Insertar Persona";
            this.btnInsertarPersona.UseVisualStyleBackColor = false;
            this.btnInsertarPersona.Click += new System.EventHandler(this.btnInsertarPersona_Click);
            // 
            // btnInsertarPedidoVivienda
            // 
            this.btnInsertarPedidoVivienda.BackColor = System.Drawing.Color.White;
            this.btnInsertarPedidoVivienda.Location = new System.Drawing.Point(32, 292);
            this.btnInsertarPedidoVivienda.Name = "btnInsertarPedidoVivienda";
            this.btnInsertarPedidoVivienda.Size = new System.Drawing.Size(227, 35);
            this.btnInsertarPedidoVivienda.TabIndex = 5;
            this.btnInsertarPedidoVivienda.Text = "Ver/Insertar Pedido Vivienda";
            this.btnInsertarPedidoVivienda.UseVisualStyleBackColor = false;
            this.btnInsertarPedidoVivienda.Click += new System.EventHandler(this.btnInsertarPedidoVivienda_Click);
            // 
            // dgvPedidosActuales
            // 
            this.dgvPedidosActuales.AllowUserToResizeColumns = false;
            this.dgvPedidosActuales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidosActuales.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidosActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosActuales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedidosActuales.Location = new System.Drawing.Point(295, 131);
            this.dgvPedidosActuales.Name = "dgvPedidosActuales";
            this.dgvPedidosActuales.Size = new System.Drawing.Size(444, 233);
            this.dgvPedidosActuales.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "Pedidos Actuales";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(751, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPedidosActuales);
            this.Controls.Add(this.btnInsertarPedidoVivienda);
            this.Controls.Add(this.btnInsertarPersona);
            this.Controls.Add(this.btnInsertarVivienda);
            this.Controls.Add(this.btnInsertarMunicipio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosActuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarMunicipio;
        private System.Windows.Forms.Button btnInsertarVivienda;
        private System.Windows.Forms.Button btnInsertarPersona;
        private System.Windows.Forms.Button btnInsertarPedidoVivienda;
        private System.Windows.Forms.DataGridView dgvPedidosActuales;
        private System.Windows.Forms.Label label3;
    }
}