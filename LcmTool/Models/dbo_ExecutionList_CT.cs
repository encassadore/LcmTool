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
    
    public partial class dbo_ExecutionList_CT
    {
        public byte[] C___start_lsn { get; set; }
        public byte[] C___end_lsn { get; set; }
        public byte[] C___seqval { get; set; }
        public int C___operation { get; set; }
        public byte[] C___update_mask { get; set; }
        public Nullable<int> lcmID { get; set; }
        public string currentServerName { get; set; }
        public string cmo { get; set; }
        public string newServerName { get; set; }
        public string fmo { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> status27Date { get; set; }
        public string notes { get; set; }
        public string waveNum { get; set; }
        public string grouping { get; set; }
        public string CRQ_CHG_WO { get; set; }
        public string CRQ_CHG_WOStatus { get; set; }
        public Nullable<System.DateTime> HandoverDate { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string site { get; set; }
        public string siteComments { get; set; }
        public string appName { get; set; }
        public string appOwner { get; set; }
        public string monsantoPM { get; set; }
        public string atosPM { get; set; }
        public string escalationNotes { get; set; }
        public string personContacted { get; set; }
        public Nullable<System.DateTime> contactedDate { get; set; }
        public string serialNum { get; set; }
        public string pmNotes { get; set; }
        public string environment { get; set; }
        public string supportGroupCmdb { get; set; }
        public string operatingSystem { get; set; }
        public string skyfall { get; set; }
        public Nullable<int> skyfallNum { get; set; }
        public Nullable<decimal> skyfallIndex { get; set; }
        public string atosTeamID { get; set; }
        public string decomType { get; set; }
        public Nullable<System.DateTime> decomStartDate { get; set; }
        public string retirementCrq { get; set; }
        public string retirementChg { get; set; }
        public string retirementWo { get; set; }
        public string decomData { get; set; }
        public Nullable<System.DateTime> forecastedStatusDate { get; set; }
        public Nullable<System.DateTime> cabApprovalDate { get; set; }
        public string database { get; set; }
        public string java { get; set; }
        public string middleware { get; set; }
        public string citrix { get; set; }
        public Nullable<int> lcmWeek { get; set; }
        public string platforms { get; set; }
        public string complianceAssetID { get; set; }
        public string screamTest { get; set; }
        public string serverInCorral { get; set; }
        public string corralPlannedDisposition { get; set; }
        public Nullable<System.DateTime> AppTeamTurnoverDate { get; set; }
        public string managedBy { get; set; }
        public string currentOsVersion { get; set; }
        public string futureOsVersion { get; set; }
        public Nullable<System.DateTime> dateEnteredCorral { get; set; }
        public string followupMonth { get; set; }
        public string transformation { get; set; }
        public string afqOsVersion { get; set; }
        public Nullable<int> fiscalYear { get; set; }
        public Nullable<int> ResourceID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> C___command_id { get; set; }
    }
}
