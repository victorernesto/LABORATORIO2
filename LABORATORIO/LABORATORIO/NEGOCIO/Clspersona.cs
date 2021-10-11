using LABORATORIO.DATA;
using LABORATORIO.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORIO.NEGOCIO
{
    class Clspersona : ClsRpersona
    {
        public void GUARDADON(persona pers)
        {
            if (pers.edadPersona < 18)
            {
                MessageBox.Show("LA PERSONA ES MENOR DE EDAD " +
                    "\n NO SE PUEDE REGISTRAR");
            }
            else
            {
                guardar(pers);
            }
        }
    }
}
