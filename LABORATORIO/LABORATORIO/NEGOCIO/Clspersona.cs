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
        public persona GUARDADON(persona pers)
        {
            guardar(pers);
            return null;
        }
           public List<persona> listafinal()
            {
            var list = listofDataofTablepersona();
            return list;

            }
        
        
    }
}
