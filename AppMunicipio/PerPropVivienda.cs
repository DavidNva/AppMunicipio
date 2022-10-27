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
    public partial class PerPropVivienda : Form
    {
        SqlConnection cnPVivienda;
        SqlCommand cmdPVivienda;
        SqlParameter paPVivienda;
        DataSet dsPVivienda;
        SqlDataAdapter daPVivienda;
        public PerPropVivienda()
        {
            InitializeComponent();
        }

        private void PerPropVivienda_Load(object sender, EventArgs e)
        {
            MostrarPVivienda();
        }
        private void MostrarPVivienda()
        {
            cnPVivienda = new SqlConnection();
            cnPVivienda.ConnectionString = Program.cadena;
            cnPVivienda.Open();
            if (dsPVivienda == null)
            {
                dsPVivienda = new DataSet();

            }
            if (daPVivienda == null)
            {
                daPVivienda = new SqlDataAdapter("SELECT * FROM PerPropVivienda", cnPVivienda);
                dsPVivienda.Clear();//Limpia el data set
                daPVivienda.Fill(dsPVivienda, "PerPropVivienda");
                dgvPVivienda.DataSource = dsPVivienda;
                dgvPVivienda.DataMember = "PerPropVivienda";
                dsPVivienda = null;
                daPVivienda = null;
                cnPVivienda.Close();
            }
        }

        private void btnInsertarPVivienda_Click(object sender, EventArgs e)
        {
            try
            {
                cnPVivienda = new SqlConnection();
                cnPVivienda.ConnectionString = Program.cadena;
                cnPVivienda.Open();
                cmdPVivienda = new SqlCommand();
                cmdPVivienda.CommandText = "sp_Insert_perPropVivienda";
                cmdPVivienda.CommandType = CommandType.StoredProcedure;
                cmdPVivienda.Parameters.Clear();

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@IDPerPropVivienda";
                paPVivienda.SqlDbType = SqlDbType.Int;
                paPVivienda.Size = 4;
                paPVivienda.Value = Convert.ToInt32(txtIDPVivienda.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@ID_Vivienda";
                paPVivienda.SqlDbType = SqlDbType.Int;
                paPVivienda.Size = 4;
                paPVivienda.Value = Convert.ToInt32(txtIDVivienda.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@ID_Persona";
                paPVivienda.SqlDbType = SqlDbType.Int;
                paPVivienda.Size = 4;
                paPVivienda.Value = Convert.ToInt32(txtIDPersona.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@FechaPago";
                paPVivienda.SqlDbType = SqlDbType.DateTime;
                //paPVivienda.Size = 50;
                paPVivienda.Value = dtpFechaPago.Text;
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@PrecioPredio";
                paPVivienda.SqlDbType = SqlDbType.Money;
                paPVivienda.Size = 20;
                paPVivienda.Value = Convert.ToInt32(txtPrecioPredio.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                cmdPVivienda.Connection = cnPVivienda;

                int i = cmdPVivienda.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos ingresados correctamente", "Insertar Vivienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPVivienda();
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
                cnPVivienda.Close();
            }
        }

        private void btnActualizarPVivienda_Click(object sender, EventArgs e)
        {
            try
            {
                cnPVivienda = new SqlConnection();
                cnPVivienda.ConnectionString = Program.cadena;
                cnPVivienda.Open();
                cmdPVivienda = new SqlCommand();
                cmdPVivienda.CommandText = "sp_Update_perPropVivienda";
                cmdPVivienda.CommandType = CommandType.StoredProcedure;
                cmdPVivienda.Parameters.Clear();

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@IDPerPropVivienda";
                paPVivienda.SqlDbType = SqlDbType.Int;
                paPVivienda.Size = 4;
                paPVivienda.Value = Convert.ToInt32(txtIDPVivienda.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@ID_Vivienda";
                paPVivienda.SqlDbType = SqlDbType.Int;
                paPVivienda.Size = 4;
                paPVivienda.Value = Convert.ToInt32(txtIDVivienda.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@ID_Persona";
                paPVivienda.SqlDbType = SqlDbType.Int;
                paPVivienda.Size = 4;
                paPVivienda.Value = Convert.ToInt32(txtIDPersona.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@FechaPago";
                paPVivienda.SqlDbType = SqlDbType.DateTime;
                //paPVivienda.Size = 50;
                paPVivienda.Value = dtpFechaPago.Text;
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@PrecioPredio";
                paPVivienda.SqlDbType = SqlDbType.Money;
                paPVivienda.Size = 20;
                paPVivienda.Value = Convert.ToInt32(txtPrecioPredio.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                cmdPVivienda.Connection = cnPVivienda;

                int i = cmdPVivienda.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos actualizados correctamente", "Actualizar Vivienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPVivienda();
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
                cnPVivienda.Close();
            }
        }

        private void btnEliminarPVivienda_Click(object sender, EventArgs e)
        {
            try
            {
                cnPVivienda = new SqlConnection();
                cnPVivienda.ConnectionString = Program.cadena;
                cnPVivienda.Open();
                cmdPVivienda = new SqlCommand();
                cmdPVivienda.CommandText = "sp_Delete_perPropVivienda";
                cmdPVivienda.CommandType = CommandType.StoredProcedure;
                cmdPVivienda.Parameters.Clear();

                paPVivienda = new SqlParameter();
                paPVivienda.ParameterName = "@IDPerPropVivienda";
                paPVivienda.SqlDbType = SqlDbType.Int;
                paPVivienda.Size = 4;
                paPVivienda.Value = Convert.ToInt32(txtIDPVivienda.Text);
                paPVivienda.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdPVivienda.Parameters.Add(paPVivienda);

                cmdPVivienda.Connection = cnPVivienda;

                int i = cmdPVivienda.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos eliminados correctamente", "Eliminar Vivienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPVivienda();
                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnPVivienda.Close();
            }
        }
    }
}
