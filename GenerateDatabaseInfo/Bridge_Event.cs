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
    
    public partial class Bridge_Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bridge_Event()
        {
            this.Fact_Unit_Log = new HashSet<Fact_Unit_Log>();
        }
    
        public int Id { get; set; }
        public int Dim_Unit_TypeId { get; set; }
        public int Dim_EventId { get; set; }
    
        public virtual Dim_Unit_Type Dim_Unit_Type { get; set; }
        public virtual Dim_Event Dim_Event { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fact_Unit_Log> Fact_Unit_Log { get; set; }
    }
}
