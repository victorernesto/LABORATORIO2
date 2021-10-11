﻿using LABORATORIO.DATA;
using LABORATORIO.SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORIO.REPOSITORY
{
    class ClsRpersona : Ipersonas
    {
        public void guardar(persona persona)
        {
           using(almacendepersonasEntities conexiombd = new almacendepersonasEntities())
            {
                try
                {
                    persona per = new persona();
                    per.nombrePersona = persona.nombrePersona;
                    per.edadPersona = persona.edadPersona;
                    per.descripcionPersona = persona.descripcionPersona;
                  
                    conexiombd.persona.Add(per);
                    conexiombd.SaveChanges();
                    MessageBox.Show("SE GUARDO CON EXITO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OCURRIO UN ERROR");
                }
            }

        }

        public List<persona> listofDataofTablepersona()
        {
            using (almacendepersonasEntities conexiombd = new almacendepersonasEntities())
            {
                List<persona> lista = conexiombd.persona.ToList();

                return lista;
            }

               
        }
    }
}
