using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Util
{
    public partial class Form1 : Form
    {
        [
            DllImport("ODBCCP32.dll")
        ]
        private static extern bool SQLConfigDataSource(IntPtr parent, int request, string driver, string attributes);
        string title, opcion, attributes;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLaCaballada.BackColor = Color.LightGray;
            btnMercadoInterno.BackColor = Color.LightGray;
            btnQuintoCuarto.BackColor = Color.LightGray;
            btnPatagonia.BackColor = Color.LightGray;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLaCaballada_Click(object sender, EventArgs e)
        {
            opcion = "LC";
            attributes = "DSN=Trazpro\0SERVER=10.26.32.9\0Database=Trazpro\0TRUSTED_CONNECTION=No\0";
            if (do_work(opcion, attributes))
                btnLaCaballada.BackColor = Color.Green;
            else
                btnLaCaballada.BackColor = Color.Red;
        }

        private void btnMercadoInterno_Click_1(object sender, EventArgs e)
        {
            opcion = "MI";
            attributes = "DSN=Trazpro\0SERVER=10.26.64.33\0Database=Trazpro\0TRUSTED_CONNECTION=No\0";
            if (do_work(opcion, attributes))
                btnMercadoInterno.BackColor = Color.Green;
            else
                btnMercadoInterno.BackColor = Color.Red;
        }

        private void btnQuintoCuarto_Click(object sender, EventArgs e)
        {
            opcion = "QC";
            attributes = "DSN=Trazpro\0SERVER=10.6.0.10\0Database=Trazpro\0TRUSTED_CONNECTION=No\0";
            if (do_work(opcion, attributes))
                btnQuintoCuarto.BackColor = Color.Green;
            else
                btnQuintoCuarto.BackColor = Color.Red;
        }

        private void btnPatagonia_Click(object sender, EventArgs e)
        {
            opcion = "PA";
            attributes = "DSN=Trazpro\0SERVER=10.6.16.12\0Database=Trazpro\0TRUSTED_CONNECTION=No\0";
            if (do_work(opcion, attributes))
                btnPatagonia.BackColor = Color.Green;
            else
                btnPatagonia.BackColor = Color.Red;
        }

        private bool do_work(string op, string atts)
        {
            switch (op)
            { 
                case "LC":
                    title = "La Caballada";
                    break;
                case "MI":
                    title = "Mercado Interno";
                    break;
                case "QC":
                    title = "Quinto Cuarto";
                    break;
                case "PA":
                    title = "Patagonia";
                    break;
            }

            btnLaCaballada.BackColor = Color.LightGray;
            btnMercadoInterno.BackColor = Color.LightGray;
            btnQuintoCuarto.BackColor = Color.LightGray;
            btnPatagonia.BackColor = Color.LightGray;

            if (SQLConfigDataSource((IntPtr)0, 2, "SQL Native Client", atts))
                return true;
            else
                return SQLConfigDataSource((IntPtr)0, 1, "SQL Native Client", atts);
        }
    }
}
