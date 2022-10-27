namespace AppMunicipio
{
    partial class Persona
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
            this.btnActualizarPersona = new System.Windows.Forms.Button();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.lblCodigoPostalMun = new System.Windows.Forms.Label();
            this.lblDireccionMun = new System.Windows.Forms.Label();
            this.lblNombreMunicipio = new System.Windows.Forms.Label();
            this.lblIDMunicipio = new System.Windows.Forms.Label();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.txtIDPersona = new System.Windows.Forms.TextBox();
            this.btnInsertarPersona = new System.Windows.Forms.Button();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtNumExterior = new System.Windows.Forms.TextBox();
            this.txtNumInterior = new System.Windows.Forms.TextBox();
            this.txtNombreCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtClaveMun = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_FecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbEdoCivil = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIDVivienda = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtID_Persona_Foreign = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarPersona
            // 
            this.btnActualizarPersona.Location = new System.Drawing.Point(390, 263);
            this.btnActualizarPersona.Name = "btnActualizarPersona";
            this.btnActualizarPersona.Size = new System.Drawing.Size(87, 23);
            this.btnActualizarPersona.TabIndex = 25;
            this.btnActualizarPersona.Text = "Actualizar";
            this.btnActualizarPersona.UseVisualStyleBackColor = true;
            this.btnActualizarPersona.Click += new System.EventHandler(this.btnActualizarPersona_Click);
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.Location = new System.Drawing.Point(512, 263);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarPersona.TabIndex = 24;
            this.btnEliminarPersona.Text = "Eliminar";
            this.btnEliminarPersona.UseVisualStyleBackColor = true;
            this.btnEliminarPersona.Click += new System.EventHandler(this.btnEliminarPersona_Click);
            // 
            // lblCodigoPostalMun
            // 
            this.lblCodigoPostalMun.AutoSize = true;
            this.lblCodigoPostalMun.Location = new System.Drawing.Point(6, 91);
            this.lblCodigoPostalMun.Name = "lblCodigoPostalMun";
            this.lblCodigoPostalMun.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoPostalMun.TabIndex = 23;
            this.lblCodigoPostalMun.Text = "Apellido Materno:";
            // 
            // lblDireccionMun
            // 
            this.lblDireccionMun.AutoSize = true;
            this.lblDireccionMun.Location = new System.Drawing.Point(8, 65);
            this.lblDireccionMun.Name = "lblDireccionMun";
            this.lblDireccionMun.Size = new System.Drawing.Size(87, 13);
            this.lblDireccionMun.TabIndex = 22;
            this.lblDireccionMun.Text = "Apellido Paterno:";
            // 
            // lblNombreMunicipio
            // 
            this.lblNombreMunicipio.AutoSize = true;
            this.lblNombreMunicipio.Location = new System.Drawing.Point(6, 39);
            this.lblNombreMunicipio.Name = "lblNombreMunicipio";
            this.lblNombreMunicipio.Size = new System.Drawing.Size(89, 13);
            this.lblNombreMunicipio.TabIndex = 21;
            this.lblNombreMunicipio.Text = "Nombre Persona:";
            // 
            // lblIDMunicipio
            // 
            this.lblIDMunicipio.AutoSize = true;
            this.lblIDMunicipio.Location = new System.Drawing.Point(6, 12);
            this.lblIDMunicipio.Name = "lblIDMunicipio";
            this.lblIDMunicipio.Size = new System.Drawing.Size(58, 13);
            this.lblIDMunicipio.TabIndex = 20;
            this.lblIDMunicipio.Text = "IdPersona:";
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(95, 88);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(162, 20);
            this.txtAMaterno.TabIndex = 19;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(95, 62);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(162, 20);
            this.txtAPaterno.TabIndex = 18;
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(95, 36);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(162, 20);
            this.txtNombrePersona.TabIndex = 17;
            // 
            // txtIDPersona
            // 
            this.txtIDPersona.Location = new System.Drawing.Point(95, 10);
            this.txtIDPersona.Name = "txtIDPersona";
            this.txtIDPersona.Size = new System.Drawing.Size(95, 20);
            this.txtIDPersona.TabIndex = 16;
            // 
            // btnInsertarPersona
            // 
            this.btnInsertarPersona.Location = new System.Drawing.Point(293, 263);
            this.btnInsertarPersona.Name = "btnInsertarPersona";
            this.btnInsertarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarPersona.TabIndex = 15;
            this.btnInsertarPersona.Text = "Insertar";
            this.btnInsertarPersona.UseVisualStyleBackColor = true;
            this.btnInsertarPersona.Click += new System.EventHandler(this.btnInsertarPersona_Click);
            // 
            // dgvPersona
            // 
            this.dgvPersona.AllowUserToResizeColumns = false;
            this.dgvPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersona.Location = new System.Drawing.Point(12, 292);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(1229, 246);
            this.dgvPersona.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "# Exterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "# Interior:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Calle:";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(95, 201);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(95, 20);
            this.txtCodPostal.TabIndex = 29;
            // 
            // txtNumExterior
            // 
            this.txtNumExterior.Location = new System.Drawing.Point(95, 172);
            this.txtNumExterior.Name = "txtNumExterior";
            this.txtNumExterior.Size = new System.Drawing.Size(95, 20);
            this.txtNumExterior.TabIndex = 28;
            // 
            // txtNumInterior
            // 
            this.txtNumInterior.Location = new System.Drawing.Point(95, 144);
            this.txtNumInterior.Name = "txtNumInterior";
            this.txtNumInterior.Size = new System.Drawing.Size(95, 20);
            this.txtNumInterior.TabIndex = 27;
            // 
            // txtNombreCalle
            // 
            this.txtNombreCalle.Location = new System.Drawing.Point(95, 115);
            this.txtNombreCalle.Name = "txtNombreCalle";
            this.txtNombreCalle.Size = new System.Drawing.Size(162, 20);
            this.txtNombreCalle.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Colonia:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(95, 227);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(162, 20);
            this.txtColonia.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Estatura:";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(709, 71);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(95, 20);
            this.txtEstatura.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "EstadoCivil:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Fecha Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(378, 167);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(95, 20);
            this.txtEdad.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "RFC:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Teléfono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Pais:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Clave Municipio:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(378, 140);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(155, 20);
            this.txtRFC.TabIndex = 39;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(378, 114);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 38;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(378, 88);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(155, 20);
            this.txtPais.TabIndex = 37;
            // 
            // txtClaveMun
            // 
            this.txtClaveMun.Location = new System.Drawing.Point(378, 12);
            this.txtClaveMun.Name = "txtClaveMun";
            this.txtClaveMun.Size = new System.Drawing.Size(95, 20);
            this.txtClaveMun.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(648, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "Sueldo:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(648, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Peso:";
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(709, 147);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(184, 20);
            this.txtCURP.TabIndex = 56;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(709, 123);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(184, 20);
            this.txtSueldo.TabIndex = 55;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(709, 97);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(184, 20);
            this.txtPeso.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(648, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "CURP:";
            // 
            // dtp_FecNacimiento
            // 
            this.dtp_FecNacimiento.Location = new System.Drawing.Point(378, 198);
            this.dtp_FecNacimiento.Name = "dtp_FecNacimiento";
            this.dtp_FecNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_FecNacimiento.TabIndex = 61;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(709, 18);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 62;
            // 
            // cmbEdoCivil
            // 
            this.cmbEdoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEdoCivil.FormattingEnabled = true;
            this.cmbEdoCivil.Location = new System.Drawing.Point(709, 45);
            this.cmbEdoCivil.Name = "cmbEdoCivil";
            this.cmbEdoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmbEdoCivil.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(283, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Clave Vivienda:";
            // 
            // txtIDVivienda
            // 
            this.txtIDVivienda.Location = new System.Drawing.Point(378, 38);
            this.txtIDVivienda.Name = "txtIDVivienda";
            this.txtIDVivienda.Size = new System.Drawing.Size(95, 20);
            this.txtIDVivienda.TabIndex = 64;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(283, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "Clave Persona:";
            // 
            // txtID_Persona_Foreign
            // 
            this.txtID_Persona_Foreign.Location = new System.Drawing.Point(378, 64);
            this.txtID_Persona_Foreign.Name = "txtID_Persona_Foreign";
            this.txtID_Persona_Foreign.Size = new System.Drawing.Size(95, 20);
            this.txtID_Persona_Foreign.TabIndex = 66;
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 550);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtID_Persona_Foreign);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIDVivienda);
            this.Controls.Add(this.cmbEdoCivil);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtp_FecNacimiento);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtCURP);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtClaveMun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtNumExterior);
            this.Controls.Add(this.txtNumInterior);
            this.Controls.Add(this.txtNombreCalle);
            this.Controls.Add(this.btnActualizarPersona);
            this.Controls.Add(this.btnEliminarPersona);
            this.Controls.Add(this.lblCodigoPostalMun);
            this.Controls.Add(this.lblDireccionMun);
            this.Controls.Add(this.lblNombreMunicipio);
            this.Controls.Add(this.lblIDMunicipio);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtNombrePersona);
            this.Controls.Add(this.txtIDPersona);
            this.Controls.Add(this.btnInsertarPersona);
            this.Controls.Add(this.dgvPersona);
            this.MaximizeBox = false;
            this.Name = "Persona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarPersona;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.Label lblCodigoPostalMun;
        private System.Windows.Forms.Label lblDireccionMun;
        private System.Windows.Forms.Label lblNombreMunicipio;
        private System.Windows.Forms.Label lblIDMunicipio;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.TextBox txtIDPersona;
        private System.Windows.Forms.Button btnInsertarPersona;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtNumExterior;
        private System.Windows.Forms.TextBox txtNumInterior;
        private System.Windows.Forms.TextBox txtNombreCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtClaveMun;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtp_FecNacimiento;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbEdoCivil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDVivienda;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtID_Persona_Foreign;
    }
}