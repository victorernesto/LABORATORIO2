using LABORATORIO.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO.SERVICE
{
    interface Ipersonas
    {
        void guardar(persona persona);

        List<persona> listofDataofTablepersona();


    }
}
