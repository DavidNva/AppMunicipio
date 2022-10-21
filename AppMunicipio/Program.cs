using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMunicipio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static string cadena = @"Data Source=LIBERO\DAVIDSQL;Initial Catalog=MunicipioSP;Integrated Security=True";
        
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Municipio());
            Application.Run(new Persona());
            
        }
    }
}
