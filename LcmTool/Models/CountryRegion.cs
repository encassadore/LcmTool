//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LcmTool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CountryRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CountryRegion()
        {
            this.ExecutionList_new = new HashSet<ExecutionList_new>();
        }
    
        public int countryRegionID { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExecutionList_new> ExecutionList_new { get; set; }
    }
}