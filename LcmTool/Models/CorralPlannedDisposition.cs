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
    
    public partial class CorralPlannedDisposition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CorralPlannedDisposition()
        {
            this.ExecutionList_new = new HashSet<ExecutionList_new>();
        }
    
        public int plannedDispositionID { get; set; }
        public string name { get; set; }
        public System.DateTime modifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExecutionList_new> ExecutionList_new { get; set; }
    }
}
