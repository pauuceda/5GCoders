//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class MilitaryCamps
    {
        public int idMilitaryCamp { get; set; }
        public string CodeCamp { get; set; }
        public string DescCamp { get; set; }
        public Nullable<int> idPlanet { get; set; }
    
        public virtual Planets Planets { get; set; }
    }
}