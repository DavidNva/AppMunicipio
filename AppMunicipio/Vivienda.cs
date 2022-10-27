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
    public partial class Vivienda : Form
    {
        SqlConnection cnVivienda;
        SqlCommand cmdVivienda;
        SqlParameter paVivienda;
        DataSet dsVivienda;
        SqlDataAdapter daVivienda;
        public Vivienda()
        {
            InitializeComponent();
        }

        private void Vivienda_Load(object sender, EventArgs e)
        {
            MostrarVivienda();
            txtIDVivienda.Focus();
        }
        private void MostrarVivienda()
        {
            cnVivienda = new SqlConnection();
            cnVivienda.ConnectionString = Program.cadena;
            cnVivienda.Open();
            if (dsVivienda == null)
            {
                dsVivienda = new DataSet();

            }
            if (daVivienda == null)
            {
                daVivienda = new SqlDataAdapter("SELECT * FROM Vivienda", cnVivienda);
                dsVivienda.Clear();//Limpia el data set
                daVivienda.Fill(dsVivienda, "Vivienda");
                dgvVivienda.DataSource = dsVivienda;
                dgvVivienda.DataMember = "Vivienda";
                dsVivienda = null;
                daVivienda = null;
                cnVivienda.Close();
            }
        }

        private void btnInsertarVivienda_Click(object sender, EventArgs e)
        {
            try
            {
                cnVivienda = new SqlConnection();
                cnVivienda.ConnectionString = Program.cadena;
                cnVivienda.Open();
                cmdVivienda = new SqlCommand();
                cmdVivienda.CommandText = "sp_Insert_Vivienda";
                cmdVivienda.CommandType = CommandType.StoredProcedure;
                cmdVivienda.Parameters.Clear();

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@IDVivienda";
                paVivienda.SqlDbType = SqlDbType.Int;
                paVivienda.Size = 4;
                paVivienda.Value = Convert.ToInt32(txtIDVivienda.Text);
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@NumVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtNumVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@NombreCalleVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtCalleVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                //Vivienda
                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@DireccionVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtDireccionVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@N_Int_Vivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 5;
                paVivienda.Value = txtNumInteriorVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@N_Ext_Vivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 5;
                paVivienda.Value = txtNumExteriorVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@ColoniaVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtColoniaVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@EstadoVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtEdoVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@CodigoPostalVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtCodPostalVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                cmdVivienda.Connection = cnVivienda;

                int i = cmdVivienda.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos ingresados correctamente", "Insertar Vivienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarVivienda();
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
                cnVivienda.Close();
            }
        }

        private void btnActualizarVivienda_Click(object sender, EventArgs e)
        {
            try
            {
                cnVivienda = new SqlConnection();
                cnVivienda.ConnectionString = Program.cadena;
                cnVivienda.Open();
                cmdVivienda = new SqlCommand();
                cmdVivienda.CommandText = "sp_Update_Vivienda";
                cmdVivienda.CommandType = CommandType.StoredProcedure;
                cmdVivienda.Parameters.Clear();

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@IDVivienda";
                paVivienda.SqlDbType = SqlDbType.Int;
                paVivienda.Size = 4;
                paVivienda.Value = Convert.ToInt32(txtIDVivienda.Text);
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@NumVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtNumVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@NombreCalleVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtCalleVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                //Vivienda
                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@DireccionVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtDireccionVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@N_Int_Vivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 5;
                paVivienda.Value = txtNumInteriorVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@N_Ext_Vivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 5;
                paVivienda.Value = txtNumExteriorVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@ColoniaVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtColoniaVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@EstadoVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtEdoVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@CodigoPostalVivienda";
                paVivienda.SqlDbType = SqlDbType.Char;
                paVivienda.Size = 50;
                paVivienda.Value = txtCodPostalVivienda.Text;
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                cmdVivienda.Connection = cnVivienda;

                int i = cmdVivienda.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos actualizados correctamente", "Actualizar Vivienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarVivienda();
                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error a la actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnVivienda.Close();
            }
        }

        private void btnEliminarVivienda_Click(object sender, EventArgs e)
        {
            try
            {
                cnVivienda = new SqlConnection();
                cnVivienda.ConnectionString = Program.cadena;
                cnVivienda.Open();
                cmdVivienda = new SqlCommand();
                cmdVivienda.CommandText = "sp_Delete_Vivienda";
                cmdVivienda.CommandType = CommandType.StoredProcedure;
                cmdVivienda.Parameters.Clear();

                paVivienda = new SqlParameter();
                paVivienda.ParameterName = "@IDVivienda";
                paVivienda.SqlDbType = SqlDbType.Int;
                paVivienda.Size = 4;
                paVivienda.Value = Convert.ToInt32(txtIDVivienda.Text);
                paVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdVivienda.Parameters.Add(paVivienda);

                cmdVivienda.Connection = cnVivienda;

                int i = cmdVivienda.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos eliminados correctamente", "Eliminar Vivienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarVivienda();
                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error a la eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnVivienda.Close();
            }
        }
    }
}
