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
    
    public partial class EventLog1
    {
        public int EventID { get; set; }
        public int ServerID { get; set; }
        public string EventType { get; set; }
        public Nullable<int> LifecycleStatusID { get; set; }
        public byte[] TimeStamped { get; set; }
        public string InitiatedBy { get; set; }
        public Nullable<System.DateTime> Date_Time { get; set; }
    }
}
