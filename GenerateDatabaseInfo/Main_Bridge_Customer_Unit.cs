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
    
    public partial class Main_Bridge_Customer_Unit
    {
        public int Id { get; set; }
        public int Main_Dim_UnitId { get; set; }
        public int Main_Dim_CustomerId { get; set; }
    
        public virtual Main_Dim_Unit Main_Dim_Unit { get; set; }
        public virtual Main_Dim_Customer Main_Dim_Customer { get; set; }
    }
}
