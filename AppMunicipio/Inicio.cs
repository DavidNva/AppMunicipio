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
    public partial class Inicio : Form
    {
        SqlConnection cnVivienda;
        SqlCommand cmdVivienda;
        SqlParameter paVivienda;
        DataSet dsVivienda;
        SqlDataAdapter daVivienda;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            MostrarPedidoActual();
        }
        private void MostrarPedidoActual()
        {
            cnVivienda = new SqlConnection();
            cnVivienda.ConnectionString = Program.cadena;
            cnVivienda.Open();
            if (dsVivienda == null)
            {
                dsVivienda = new DataSet();

            }
            if (daVivienda == null)
            {//Selecciona la vista creada en el script de sql para unir persona, vivienda y municipio con un INNER JOIN
                daVivienda = new SqlDataAdapter("SELECT * FROM V_PrestamoCompleto", cnVivienda);
                dsVivienda.Clear();//Limpia el data set
                daVivienda.Fill(dsVivienda, "Vivienda");
                dgvPedidosActuales.DataSource = dsVivienda;
                dgvPedidosActuales.DataMember = "Vivienda";
                dsVivienda = null;
                daVivienda = null;
                cnVivienda.Close();
            }
        }

        private void btnInsertarMunicipio_Click(object sender, EventArgs e)
        {
            Frm_Municipio mun = new Frm_Municipio();
            mun.Show();
        }

        private void btnInsertarVivienda_Click(object sender, EventArgs e)
        {
            Vivienda viv = new Vivienda();
            viv.Show();
        }

        private void btnInsertarPersona_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per.Show();
        }

        private void btnInsertarPedidoVivienda_Click(object sender, EventArgs e)
        {
            PerPropVivienda perViv = new PerPropVivienda();
            perViv.Show();
        }
    }
}
