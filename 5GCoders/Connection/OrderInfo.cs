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
    
    public partial class OrderInfo
    {
        public short idOrderInfo { get; set; }
        public short idOrder { get; set; }
        public short idAgency { get; set; }
        public short idOperationalArea { get; set; }
    
        public virtual Agencies Agencies { get; set; }
        public virtual OperationalAreas OperationalAreas { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
