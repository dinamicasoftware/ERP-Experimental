//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dinamica.erp.wcf.arm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Imágenes
    {
        public int id { get; set; }
        public string Alt { get; set; }
        public byte[] Imagen { get; set; }
        public int Articulo { get; set; }
    
        public virtual Artículos Artículos { get; set; }
    }
}
