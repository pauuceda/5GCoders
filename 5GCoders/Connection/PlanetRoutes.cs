//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Connection
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanetRoutes
    {
        public int idPlanetRoute { get; set; }
        public Nullable<int> idPlanet { get; set; }
        public Nullable<int> idRoute { get; set; }
    
        public virtual Planets Planets { get; set; }
        public virtual Routes Routes { get; set; }
    }
}
