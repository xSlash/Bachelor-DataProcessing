//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenerateDatabaseInfo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fact_Unit_Data_L
    {
        public int Id { get; set; }
        public int Bridge_UnitId { get; set; }
        public int On { get; set; }
        public int Off { get; set; }
    
        public virtual Bridge_Unit_L Bridge_Unit { get; set; }
    }
}
