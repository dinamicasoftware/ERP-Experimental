﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dinamica.erp.wcf.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreFantasia { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
    }
}