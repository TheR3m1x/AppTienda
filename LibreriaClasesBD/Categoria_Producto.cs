﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesBD
{
    public class Categoria_Producto
    {
        public int id_categoria { get; set; }
        public string nombre_categoria { get; set; }
        public string descripcion { get; set; }
	    public bool activo { get; set; }
    }
}
