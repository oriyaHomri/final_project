//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class CollectionVaad
    {
        public int IdCollectionVaad { get; set; }
        public string Details { get; set; }
        public string Amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> DatePayed { get; set; }
        public Nullable<int> IdTenant { get; set; }
        public Nullable<int> IdFrequency { get; set; }
    
        public virtual Tenants Tenants { get; set; }
        public virtual Frequencies Frequencies { get; set; }
    }
}