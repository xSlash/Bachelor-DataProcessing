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
    
    public partial class Bridge_Unit_L
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bridge_Unit_L()
        {
            this.Fact_Unit_Log = new HashSet<Fact_Unit_Log_L>();
            this.Fact_Unit_Data = new HashSet<Fact_Unit_Data_L>();
        }
    
        public int Id { get; set; }
        public int Dim_UnitId { get; set; }
        public int Dim_Unit_TypeId { get; set; }
        public int Dim_LocationId { get; set; }
    
        public virtual Dim_Unit_L Dim_Unit { get; set; }
        public virtual Dim_Unit_Type_L Dim_Unit_Type { get; set; }
        public virtual Dim_Location_L Dim_Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fact_Unit_Log_L> Fact_Unit_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fact_Unit_Data_L> Fact_Unit_Data { get; set; }
    }
}
