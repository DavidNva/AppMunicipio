namespace AppMunicipio
{
    partial class Frm_Prueba
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
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbEdoCivil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(75, 52);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 0;
            // 
            // cmbEdoCivil
            // 
            this.cmbEdoCivil.FormattingEnabled = true;
            this.cmbEdoCivil.Location = new System.Drawing.Point(241, 52);
            this.cmbEdoCivil.Name = "cmbEdoCivil";
            this.cmbEdoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmbEdoCivil.TabIndex = 1;
            // 
            // Frm_Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 366);
            this.Controls.Add(this.cmbEdoCivil);
            this.Controls.Add(this.cmbSexo);
            this.Name = "Frm_Prueba";
            this.Text = "Frm_Prueba";
            this.Load += new System.EventHandler(this.Frm_Prueba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbEdoCivil;
    }
}