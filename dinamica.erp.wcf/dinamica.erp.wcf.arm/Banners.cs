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
    
    public partial class Banners
    {
        public int Banners1 { get; set; }
        public string Título { get; set; }
        public byte[] Imagen { get; set; }
        public Nullable<bool> Banner_vertical { get; set; }
        public Nullable<bool> Mostrar_en_portada { get; set; }
        public Nullable<int> Categoría { get; set; }
        public string Link { get; set; }
    
        public virtual Categorías Categorías { get; set; }
    }
}
