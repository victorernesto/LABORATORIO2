using LABORATORIO.DATA;
using LABORATORIO.NEGOCIO;
using LABORATORIO.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona prn = new persona();
            prn.nombrePersona = txtnombre.Text;
            prn.descripcionPersona = txtdescipcion.Text;
            prn.edadPersona = int.Parse(txtedad.Text);
            Clspersona clspersona = new Clspersona();
            clspersona.GUARDADON(prn);
            clspersona.guardar(prn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmpersona frmpersona = new Frmpersona();
            frmpersona.Show();
            


         

        }
    }
}
