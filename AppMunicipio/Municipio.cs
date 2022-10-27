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
    public partial class Frm_Municipio : Form
    {
        SqlConnection cnMunicipio;
        SqlCommand cmdMunicipio;
        SqlParameter  paMunicipio;
        DataSet dsMunicipio;
        SqlDataAdapter daMunicipio;

        public Frm_Municipio()
        {
            InitializeComponent();
            
        }

        private void Frm_Municipio_Load(object sender, EventArgs e)
        {
            MostrarMunicipios();
        }
        private void MostrarMunicipios()
        {
            cnMunicipio = new SqlConnection();
            cnMunicipio.ConnectionString = Program.cadena;
            cnMunicipio.Open();
            if (dsMunicipio == null)
            {
                dsMunicipio = new DataSet();

            }
            if (daMunicipio == null)
            {
                daMunicipio = new SqlDataAdapter("SELECT * FROM Municipio", cnMunicipio);
                dsMunicipio.Clear();//Limpia el data set
                daMunicipio.Fill(dsMunicipio, "Municipio");
                dgvMunicipio.DataSource = dsMunicipio;
                dgvMunicipio.DataMember = "Municipio";
                dsMunicipio = null;
                daMunicipio = null;
                cnMunicipio.Close();
            }
        }
        private void btnConsultarMun_Click(object sender, EventArgs e)
        {
            cnMunicipio = new SqlConnection();
            cnMunicipio.ConnectionString = Program.cadena;
            cnMunicipio.Open();
            if(dsMunicipio == null)
            {
                dsMunicipio = new DataSet();

            }
            if(daMunicipio == null)
            {
                daMunicipio = new SqlDataAdapter("SELECT * FROM Municipio",cnMunicipio);
                dsMunicipio.Clear();//Limpia el data set
                daMunicipio.Fill(dsMunicipio,"Municipio");
                dgvMunicipio.DataSource = dsMunicipio;
                dgvMunicipio.DataMember = "Municipio";
                dsMunicipio = null;
                daMunicipio = null;
                cnMunicipio.Close();
            }
        }

        private void btnInsertarMun_Click(object sender, EventArgs e)
        {
            try { 
            cnMunicipio = new SqlConnection();
            cnMunicipio.ConnectionString = Program.cadena;
            cnMunicipio.Open();
            cmdMunicipio = new SqlCommand();
            cmdMunicipio.CommandText = "sp_Insert_Municipio";
            cmdMunicipio.CommandType = CommandType.StoredProcedure;
            cmdMunicipio.Parameters.Clear();

            paMunicipio = new SqlParameter();
            paMunicipio.ParameterName = "@IDMunicipio";
            paMunicipio.SqlDbType = SqlDbType.Int;
            paMunicipio.Size = 4;
            paMunicipio.Value = Convert.ToInt32(txtIDMunicipio.Text);
            paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
            cmdMunicipio.Parameters.Add(paMunicipio);

            paMunicipio = new SqlParameter();
            paMunicipio.ParameterName = "@NombreMunicipio";
            paMunicipio.SqlDbType = SqlDbType.Char;
            paMunicipio.Size = 50;
            paMunicipio.Value = txtNombreMunicipio.Text;
            paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
            cmdMunicipio.Parameters.Add(paMunicipio);

            paMunicipio = new SqlParameter();
            paMunicipio.ParameterName = "@Direccion";
            paMunicipio.SqlDbType = SqlDbType.Char;
            paMunicipio.Size = 50;
            paMunicipio.Value = txtDireccion.Text;
            paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
            cmdMunicipio.Parameters.Add(paMunicipio);

            paMunicipio = new SqlParameter();
            paMunicipio.ParameterName = "@CodPostalMun";
            paMunicipio.SqlDbType = SqlDbType.Char;
            paMunicipio.Size = 50;
            paMunicipio.Value = txtCodigoPostal.Text;
            paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
            cmdMunicipio.Parameters.Add(paMunicipio);

            

            cmdMunicipio.Connection = cnMunicipio;

            int i = cmdMunicipio.ExecuteNonQuery();

            if (i != 0)
            {

                MessageBox.Show("Datos ingresados correctamente", "Insertar Municipio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarMunicipios();
            }
            else
            {
                MessageBox.Show("Corriga sus datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }   
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message, "Error a la insertar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                cnMunicipio.Close();
            }
             
        }

        private void btnActualizarMun_Click(object sender, EventArgs e)
        {
            try
            {
                cnMunicipio = new SqlConnection();
                cnMunicipio.ConnectionString = Program.cadena;
                cnMunicipio.Open();
                cmdMunicipio = new SqlCommand();
                cmdMunicipio.CommandText = "sp_Update_Municipio";
                cmdMunicipio.CommandType = CommandType.StoredProcedure;
                cmdMunicipio.Parameters.Clear();

                paMunicipio = new SqlParameter();
                paMunicipio.ParameterName = "@IDMunicipio";
                paMunicipio.SqlDbType = SqlDbType.Int;
                paMunicipio.Size = 4;
                paMunicipio.Value = Convert.ToInt32(txtIDMunicipio.Text);
                paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdMunicipio.Parameters.Add(paMunicipio);

                paMunicipio = new SqlParameter();
                paMunicipio.ParameterName = "@NombreMunicipio";
                paMunicipio.SqlDbType = SqlDbType.Char;
                paMunicipio.Size = 50;
                paMunicipio.Value = txtNombreMunicipio.Text;
                paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdMunicipio.Parameters.Add(paMunicipio);

                paMunicipio = new SqlParameter();
                paMunicipio.ParameterName = "@Direccion";
                paMunicipio.SqlDbType = SqlDbType.Char;
                paMunicipio.Size = 50;
                paMunicipio.Value = txtDireccion.Text;
                paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdMunicipio.Parameters.Add(paMunicipio);

                paMunicipio = new SqlParameter();
                paMunicipio.ParameterName = "@CodPostalMun";
                paMunicipio.SqlDbType = SqlDbType.Char;
                paMunicipio.Size = 50;
                paMunicipio.Value = txtCodigoPostal.Text;
                paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdMunicipio.Parameters.Add(paMunicipio);



                cmdMunicipio.Connection = cnMunicipio;

                int i = cmdMunicipio.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("Datos actualizados correctamente", "Actualizados Municipio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMunicipios();
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
                cnMunicipio.Close();
            }
        }

        private void btnEliminarMun_Click(object sender, EventArgs e)
        {
            try
            {
                cnMunicipio = new SqlConnection();
                cnMunicipio.ConnectionString = Program.cadena;
                cnMunicipio.Open();
                cmdMunicipio = new SqlCommand();
                cmdMunicipio.CommandText = "sp_Delete_Municipio";
                cmdMunicipio.CommandType = CommandType.StoredProcedure;
                cmdMunicipio.Parameters.Clear();

                paMunicipio = new SqlParameter();
                paMunicipio.ParameterName = "@IDMunicipio";
                paMunicipio.SqlDbType = SqlDbType.Int;
                paMunicipio.Size = 4;
                paMunicipio.Value = Convert.ToInt32(txtIDMunicipio.Text);
                paMunicipio.Direction = ParameterDirection.Input;//Porque es de dato de entrada
                cmdMunicipio.Parameters.Add(paMunicipio);

                cmdMunicipio.Connection = cnMunicipio;

                int i = cmdMunicipio.ExecuteNonQuery();

                if (i != 0)
                {

                    MessageBox.Show("El dato se eliminó correctamente", "Eliminar Municipio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMunicipios();
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
                cnMunicipio.Close();
            }
        }
    }
}
