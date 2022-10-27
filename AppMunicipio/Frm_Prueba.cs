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
    public partial class Frm_Prueba : Form
    {
        SqlConnection cnPersona;
        SqlCommand cmdPersona;
        SqlParameter paPersona;
        DataSet dsPersona;
        SqlDataAdapter daPersona;
        public Frm_Prueba()
        {
            InitializeComponent();
        }

        private void Frm_Prueba_Load(object sender, EventArgs e)
        {
            //MostrarPersonas();
            try
            {
                
                //cmbSexo.Items.Add("M");
                //cmbSexo.Items.Add("F");
                ////--------- 
                //cmbEdoCivil.Items.Add("S");
                //cmbEdoCivil.Items.Add("C");
                //cmbEdoCivil.Items.Add("U");
                //cmbEdoCivil.Items.Add("V");
                //cmbEdoCivil.Items.Add("D");


                cnPersona = new SqlConnection();
                cnPersona.ConnectionString = Program.cadena;
                cnPersona.Open();
                dsPersona = new DataSet();
                daPersona = new SqlDataAdapter("SELECT NombreMunicipio FROM Municipio", cnPersona);
                dsPersona.Clear();//Limpia el data set
                daPersona.Fill(dsPersona, "Municipio");
                cmbSexo.DataSource = dsPersona;
                cmbSexo.DisplayMember = "Municipio.NombreMunicipio";
                dsPersona = null;
                daPersona = null;
                cnPersona.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                //dgvPersona.DataSource = dsPersona;
                //dgvPersona.DataMember = "Persona";
                dsPersona = null;
                daPersona = null;
                cnPersona.Close();
            }
        }
    }
}
