//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circus.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Perfomance_Report2
    {
        public int ID { get; set; }
        public Nullable<int> ID_Perfomance2 { get; set; }
        public Nullable<int> ID_Report2 { get; set; }
    
        public virtual Perfomance Perfomance { get; set; }
        public virtual Report2 Report2 { get; set; }
    }
}
