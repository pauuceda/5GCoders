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
    
    public partial class Sectors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sectors()
        {
            this.Planets = new HashSet<Planets>();
        }
    
        public int idSector { get; set; }
        public string CodeSector { get; set; }
        public string DescSector { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> idRegion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Planets> Planets { get; set; }
        public virtual Regions Regions { get; set; }
    }
}
