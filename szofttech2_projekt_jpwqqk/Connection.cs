//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace szofttech2_projekt_jpwqqk
{
    using System;
    using System.Collections.Generic;
    
    public partial class Connection
    {
        public int connect_id { get; set; }
        public int person_id { get; set; }
        public int contact_id { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual Person Person { get; set; }
    }
}
