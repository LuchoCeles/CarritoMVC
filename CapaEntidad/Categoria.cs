﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        public int IdCategorio { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
