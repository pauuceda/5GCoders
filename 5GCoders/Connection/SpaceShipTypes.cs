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
    
    public partial class SpaceShipTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpaceShipTypes()
        {
            this.SpaceShips = new HashSet<SpaceShips>();
        }
    
        public int idSpaceShipType { get; set; }
        public string CodeSpaceShipType { get; set; }
        public string DescSpaceShipType { get; set; }
        public Nullable<int> idFiliation { get; set; }
        public Nullable<int> idSpaceShipCategory { get; set; }
    
        public virtual Filiations Filiations { get; set; }
        public virtual SpaceShipCategories SpaceShipCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpaceShips> SpaceShips { get; set; }
    }
}
