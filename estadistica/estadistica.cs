﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estadistica
{
    class estadistica
    {
        public double  suma = 0;

        public double media(string[] serie)
        { 
    foreach(string valor in serie) {
        suma +=int.Parse (valor);
        }
       return suma / serie.Length ;
   
}
        public double estandar(string[] serie)
            {
            double media_aritmetica = media(serie),
                suma = 0,
                estandar = 0;
            foreach(String valor in serie ){
                suma += Math.Pow(double.Parse(valor) - media_aritmetica, 2);
        }
            return suma / serie.Length;
        }
            public double tipica(string[]serie)
        { 
            return Math.Sqrt(estandar(serie));
        }

        }

        }
    








}
}
