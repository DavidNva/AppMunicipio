using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AppMunicipio
{
    public partial class Persona : Form
    {
        SqlConnection cnPersona;
        SqlCommand cmdPersona;
        SqlParameter paPersona;
        DataSet dsPersona;
        SqlDataAdapter daPersona;
        
        public Persona()
        {
            InitializeComponent();
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            MostrarPersonas();
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            //---------
            cmbEdoCivil.Items.Add("S");
            cmbEdoCivil.Items.Add("C");
            cmbEdoCivil.Items.Add("U");
            cmbEdoCivil.Items.Add("V");
            cmbEdoCivil.Items.Add("D");
        }

        private void btnConsultarPersona_Click(object sender, EventArgs e)
        {
            cnPersona = new SqlConnection();
            cnPersona.ConnectionString = Program.cadena; 
            cnPersona.Open();
            if (dsPersona == null)
            {
                dsPersona = new DataSet();

            }
            if (daPersona == null)
            {
                daPersona = new SqlDataAdapter("SELECT * FROM Persona", cnPersona);
                dsPersona.Clear();//Limpia el data set
                daPersona.Fill(dsPersona, "Persona");
                dgvPersona.DataSource = dsPersona;
                dgvPersona.DataMember = "Persona";
                dsPersona = null;
                daPersona = null;
                cnPersona.Close();
            }
        }
        
        private void MostrarPersonas()
        {
            cnPersona = new SqlConnection();
            cnPersona.ConnectionString = Program.cadena;
            cnPersona.Open();
            if (dsPersona == null)
            {
                dsPersona = new DataSet();

            }
            if (daPersona == null)
            {
                daPersona = new SqlDataAdapter("SELECT * FROM Persona", cnPersona);
                dsPersona.Clear();//Limpia el data set
                daPersona.Fill(dsPersona, "Persona");
                dgvPersona.DataSource = dsPersona;
                dgvPersona.DataMember = "Persona";
                dsPersona = null;
                daPersona = null;
                cnPersona.Close();
            }
        }

        private void btnInsertarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                cnPersona = new SqlConnection();
                cnPersona.ConnectionString = Program.cadena;
                cnPersona.Open();
                cmdPersona = new SqlCommand();
                cmdPersona.CommandText = "sp_Insert_Persona";
                cmdPersona.CommandType = CommandType.StoredProcedure;
                cmdPersona.Parameters.Clear();

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@IDPersona";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtIDPersona.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@NombrePersona";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtNombrePersona.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@A_Paterno";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtAPaterno.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@A_Materno";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtAMaterno.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@NombreCalle";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtNombreCalle.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@N_Int";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 5;
                paPersona.Value = txtNumInterior.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@N_Ext";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 5;
                paPersona.Value = txtNumExterior.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@CodigoPostal";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 5;
                paPersona.Value = txtCodPostal.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Colonia";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 30;
                paPersona.Value = txtColonia.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@ID_Municipio";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtClaveMun.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@ID_Vivienda";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtIDVivienda.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@ID_Persona";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtID_Persona_Foreign.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Pais";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtPais.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Telefono";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 17;
                paPersona.Value = txtTelefono.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@RFC";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 10;
                paPersona.Value = txtRFC.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Edad";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 3;
                paPersona.Value = Convert.ToInt32(txtEdad.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);
                
                paPersona = new SqlParameter();
                paPersona.ParameterName = "@FechaNacimiento";
                paPersona.SqlDbType = SqlDbType.Date;
                //paPersona.Size = 3;
                paPersona.Value = dtp_FecNacimiento.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);
                
                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Sexo";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 1;
                paPersona.Value = cmbSexo.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@EstadoCivil";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 1;
                paPersona.Value = cmbEdoCivil.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Estatura";
                paPersona.SqlDbType = SqlDbType.Decimal;
                paPersona.Size = 3;
                paPersona.Value = Convert.ToDecimal(txtEstatura.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Peso";
                paPersona.SqlDbType = SqlDbType.Decimal;
                paPersona.Size = 3;
                paPersona.Value = Convert.ToDouble(txtPeso.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Sueldo";
                paPersona.SqlDbType = SqlDbType.Money;
                paPersona.Size = 8;
                paPersona.Value = Convert.ToDouble(txtSueldo.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@CURP";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 18;
                paPersona.Value = txtCURP.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                cmdPersona.Connection = cnPersona;

                int i = cmdPersona.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos ingresados correctamente", "Insertar Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPersonas();

                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error a la insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnPersona.Close();
            }
        }

        private void btnActualizarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                cnPersona = new SqlConnection();
                cnPersona.ConnectionString = Program.cadena;
                cnPersona.Open();
                cmdPersona = new SqlCommand();
                cmdPersona.CommandText = "sp_Update_Persona";
                cmdPersona.CommandType = CommandType.StoredProcedure;
                cmdPersona.Parameters.Clear();

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@IDPersona";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtIDPersona.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@NombrePersona";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtNombrePersona.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@A_Paterno";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtAPaterno.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@A_Materno";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtAMaterno.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@NombreCalle";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtNombreCalle.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@N_Int";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 5;
                paPersona.Value = txtNumInterior.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@N_Ext";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 5;
                paPersona.Value = txtNumExterior.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@CodigoPostal";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 5;
                paPersona.Value = txtCodPostal.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Colonia";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 30;
                paPersona.Value = txtColonia.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@ID_Municipio";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtClaveMun.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@ID_Vivienda";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtIDVivienda.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@ID_Persona";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtID_Persona_Foreign.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Pais";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 50;
                paPersona.Value = txtPais.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Telefono";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 17;
                paPersona.Value = txtTelefono.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@RFC";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 10;
                paPersona.Value = txtRFC.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Edad";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 3;
                paPersona.Value = Convert.ToInt32(txtEdad.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@FechaNacimiento";
                paPersona.SqlDbType = SqlDbType.Date;
                //paPersona.Size = 3;
                paPersona.Value = dtp_FecNacimiento.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Sexo";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 1;
                paPersona.Value = cmbSexo.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@EstadoCivil";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 1;
                paPersona.Value = cmbEdoCivil.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Estatura";
                paPersona.SqlDbType = SqlDbType.Decimal;
                paPersona.Size = 3;
                paPersona.Value = Convert.ToDecimal(txtEstatura.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Peso";
                paPersona.SqlDbType = SqlDbType.Decimal;
                paPersona.Size = 3;
                paPersona.Value = Convert.ToDouble(txtPeso.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@Sueldo";
                paPersona.SqlDbType = SqlDbType.Money;
                paPersona.Size = 8;
                paPersona.Value = Convert.ToDouble(txtSueldo.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@CURP";
                paPersona.SqlDbType = SqlDbType.Char;
                paPersona.Size = 18;
                paPersona.Value = txtCURP.Text;
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);

                cmdPersona.Connection = cnPersona;

                int i = cmdPersona.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos actualizados correctamente", "Actualizar Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPersonas();
                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnPersona.Close();
            }
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                cnPersona = new SqlConnection();
                cnPersona.ConnectionString = Program.cadena;
                cnPersona.Open();
                cmdPersona = new SqlCommand();
                cmdPersona.CommandText = "sp_Delete_Persona";
                cmdPersona.CommandType = CommandType.StoredProcedure;
                cmdPersona.Parameters.Clear();

                paPersona = new SqlParameter();
                paPersona.ParameterName = "@IDPersona";
                paPersona.SqlDbType = SqlDbType.Int;
                paPersona.Size = 4;
                paPersona.Value = Convert.ToInt32(txtIDPersona.Text);
                paPersona.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPersona.Parameters.Add(paPersona);


                cmdPersona.Connection = cnPersona;

                int i = cmdPersona.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("El dato se eliminó correctamente", "Eliminar Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPersonas();
                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnPersona.Close();
            }
        }
    
    }
}
