﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftIV_Poo_Clases12_19.Clases
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }
        public abstract string SalvarElMundo();

        public virtual string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la Tierra.";
        }
    }
}
