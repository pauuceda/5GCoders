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
    
    public partial class DefinedRoutes
    {
        public int idDefinedRoute { get; set; }
        public Nullable<int> idPlanetOri { get; set; }
        public Nullable<int> idPlanetDest { get; set; }
        public Nullable<int> idRoute { get; set; }
        public string RouteMap { get; set; }
    
        public virtual Routes Routes { get; set; }
    }
}
