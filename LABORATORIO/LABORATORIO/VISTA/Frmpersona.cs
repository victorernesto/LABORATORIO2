using LABORATORIO.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORIO.VISTA
{
    public partial class Frmpersona : Form
    {
        public Frmpersona()
        {
            InitializeComponent();
        }

        private void Frmpersona_Load(object sender, EventArgs e)
        {
            Clspersona clspersona = new Clspersona();
            var person = clspersona.listafinal();
            foreach (var interar in person)
            {
                CUADROLIST.Rows.Add(interar.idpersona,interar.nombrePersona,interar.edadPersona,interar.descripcionPersona);


            }
        }
    }
}
