//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fact_Unit_LogSet
    {
        public int Id { get; set; }
        public int Bridge_UnitId { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int Bridge_EventId { get; set; }
    
        public virtual Bridge_EventSet Bridge_EventSet { get; set; }
        public virtual Bridge_UnitSet Bridge_UnitSet { get; set; }
    }
}
