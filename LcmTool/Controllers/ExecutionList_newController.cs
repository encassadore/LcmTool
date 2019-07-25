using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LcmTool.Models;

namespace LcmTool.Controllers
{
    public class ExecutionList_newController : Controller
    {
        private LifecycleManagementEntities db = new LifecycleManagementEntities();

        // GET: ExecutionList_new
        public ActionResult Index()
        {
            var executionList_new = db.ExecutionList_new.Include(e => e.CorralPlannedDisposition).Include(e => e.CountryRegion).Include(e => e.DatabaseType).Include(e => e.DecomType).Include(e => e.Department).Include(e => e.Environment).Include(e => e.Grouping).Include(e => e.OperatingSystem).Include(e => e.Resource).Include(e => e.ServerInCorral).Include(e => e.Site).Include(e => e.StatusType).Include(e => e.SupportGroupCmdb).Include(e => e.WorkOrder);
            return View(executionList_new.ToList());
        }

        // GET: ExecutionList_new/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExecutionList_new executionList_new = db.ExecutionList_new.Find(id);
            if (executionList_new == null)
            {
                return HttpNotFound();
            }
            return View(executionList_new);
        }

        // GET: ExecutionList_new/Create
        public ActionResult Create()
        {
            ViewBag.plannedDispositionID = new SelectList(db.CorralPlannedDispositions, "plannedDispositionID", "name");
            ViewBag.countryRegionID = new SelectList(db.CountryRegions, "countryRegionID", "region");
            ViewBag.databaseTypeID = new SelectList(db.DatabaseTypes, "databaseTypeID", "name");
            ViewBag.decomTypeID = new SelectList(db.DecomTypes, "decomTypeID", "name");
            ViewBag.AtosTeamID = new SelectList(db.Departments, "AtosTeamID", "Department1");
            ViewBag.environmentID = new SelectList(db.Environments, "environmentID", "name");
            ViewBag.groupingID = new SelectList(db.Groupings, "groupingID", "name");
            ViewBag.operatingSystemID = new SelectList(db.OperatingSystems, "operatingSystemID", "name");
            ViewBag.resourceID = new SelectList(db.Resources, "ResourceID", "FirstName");
            ViewBag.serverInCorral_ID = new SelectList(db.ServerInCorrals, "serverInCorral_ID", "name");
            ViewBag.siteID = new SelectList(db.Sites, "siteID", "name");
            ViewBag.statusID = new SelectList(db.StatusTypes, "statusID", "status");
            ViewBag.supportGroupID = new SelectList(db.SupportGroupCmdbs, "supportGroupID", "name");
            ViewBag.workOrderID = new SelectList(db.WorkOrders, "workOrderID", "workOrderID");
            return View();
        }

        // POST: ExecutionList_new/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lcmID,resourceID,statusID,groupingID,workOrderID,WO_StatusID,currentServerName,cmo,newServerName,fmo,status27Date,notes,waveNum,handoverDate,region,country,siteID,siteComments,appName,appOwner,monsantoPM,atosPM,escalationNotes,personContacted,contactedDate,serialNum,pmNotes,environmentID,supportGroupID,operatingSystemID,skyfall,skyfallNum,skyfall_index,AtosTeamID,decomTypeID,decomStartDate,retirementCrq,retirementChg,retirementWo,j_data_decom_only,forecastedStatusDate,cabApprovalDate,databaseTypeID,java,middleware,citrix,lcmWeek,platforms,complianceAssetID,screamTeast,serverInCorral_ID,plannedDispositionID,AppTeamTurnoverDate,managedBy,currentOsVersion,futureOsVersion,dateEnteredCorral,followupMonth,transformation,afqOsVersion,fiscalYear,NZEV_Overlap,serverRequiresOsLicense,NumCores,NumProcessors,NZEV_Remediation_Planned,ISO_Exception_Number,COG_Supported,countryRegionID,CreatedDate,ModifiedDate,CreatedBy,ModifiedBy")] ExecutionList_new executionList_new)
        {
            if (ModelState.IsValid)
            {
                db.ExecutionList_new.Add(executionList_new);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.plannedDispositionID = new SelectList(db.CorralPlannedDispositions, "plannedDispositionID", "name", executionList_new.plannedDispositionID);
            ViewBag.countryRegionID = new SelectList(db.CountryRegions, "countryRegionID", "region", executionList_new.countryRegionID);
            ViewBag.databaseTypeID = new SelectList(db.DatabaseTypes, "databaseTypeID", "name", executionList_new.databaseTypeID);
            ViewBag.decomTypeID = new SelectList(db.DecomTypes, "decomTypeID", "name", executionList_new.decomTypeID);
            ViewBag.AtosTeamID = new SelectList(db.Departments, "AtosTeamID", "Department1", executionList_new.AtosTeamID);
            ViewBag.environmentID = new SelectList(db.Environments, "environmentID", "name", executionList_new.environmentID);
            ViewBag.groupingID = new SelectList(db.Groupings, "groupingID", "name", executionList_new.groupingID);
            ViewBag.operatingSystemID = new SelectList(db.OperatingSystems, "operatingSystemID", "name", executionList_new.operatingSystemID);
            ViewBag.resourceID = new SelectList(db.Resources, "ResourceID", "FirstName", executionList_new.resourceID);
            ViewBag.serverInCorral_ID = new SelectList(db.ServerInCorrals, "serverInCorral_ID", "name", executionList_new.serverInCorral_ID);
            ViewBag.siteID = new SelectList(db.Sites, "siteID", "name", executionList_new.siteID);
            ViewBag.statusID = new SelectList(db.StatusTypes, "statusID", "status", executionList_new.statusID);
            ViewBag.supportGroupID = new SelectList(db.SupportGroupCmdbs, "supportGroupID", "name", executionList_new.supportGroupID);
            ViewBag.workOrderID = new SelectList(db.WorkOrders, "workOrderID", "workOrderID", executionList_new.workOrderID);
            return View(executionList_new);
        }

        // GET: ExecutionList_new/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExecutionList_new executionList_new = db.ExecutionList_new.Find(id);
            if (executionList_new == null)
            {
                return HttpNotFound();
            }
            ViewBag.plannedDispositionID = new SelectList(db.CorralPlannedDispositions, "plannedDispositionID", "name", executionList_new.plannedDispositionID);
            ViewBag.countryRegionID = new SelectList(db.CountryRegions, "countryRegionID", "region", executionList_new.countryRegionID);
            ViewBag.databaseTypeID = new SelectList(db.DatabaseTypes, "databaseTypeID", "name", executionList_new.databaseTypeID);
            ViewBag.decomTypeID = new SelectList(db.DecomTypes, "decomTypeID", "name", executionList_new.decomTypeID);
            ViewBag.AtosTeamID = new SelectList(db.Departments, "AtosTeamID", "Department1", executionList_new.AtosTeamID);
            ViewBag.environmentID = new SelectList(db.Environments, "environmentID", "name", executionList_new.environmentID);
            ViewBag.groupingID = new SelectList(db.Groupings, "groupingID", "name", executionList_new.groupingID);
            ViewBag.operatingSystemID = new SelectList(db.OperatingSystems, "operatingSystemID", "name", executionList_new.operatingSystemID);
            ViewBag.resourceID = new SelectList(db.Resources, "ResourceID", "FirstName", executionList_new.resourceID);
            ViewBag.serverInCorral_ID = new SelectList(db.ServerInCorrals, "serverInCorral_ID", "name", executionList_new.serverInCorral_ID);
            ViewBag.siteID = new SelectList(db.Sites, "siteID", "name", executionList_new.siteID);
            ViewBag.statusID = new SelectList(db.StatusTypes, "statusID", "status", executionList_new.statusID);
            ViewBag.supportGroupID = new SelectList(db.SupportGroupCmdbs, "supportGroupID", "name", executionList_new.supportGroupID);
            ViewBag.workOrderID = new SelectList(db.WorkOrders, "workOrderID", "workOrderID", executionList_new.workOrderID);
            return View(executionList_new);
        }

        // POST: ExecutionList_new/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lcmID,resourceID,statusID,groupingID,workOrderID,WO_StatusID,currentServerName,cmo,newServerName,fmo,status27Date,notes,waveNum,handoverDate,region,country,siteID,siteComments,appName,appOwner,monsantoPM,atosPM,escalationNotes,personContacted,contactedDate,serialNum,pmNotes,environmentID,supportGroupID,operatingSystemID,skyfall,skyfallNum,skyfall_index,AtosTeamID,decomTypeID,decomStartDate,retirementCrq,retirementChg,retirementWo,j_data_decom_only,forecastedStatusDate,cabApprovalDate,databaseTypeID,java,middleware,citrix,lcmWeek,platforms,complianceAssetID,screamTeast,serverInCorral_ID,plannedDispositionID,AppTeamTurnoverDate,managedBy,currentOsVersion,futureOsVersion,dateEnteredCorral,followupMonth,transformation,afqOsVersion,fiscalYear,NZEV_Overlap,serverRequiresOsLicense,NumCores,NumProcessors,NZEV_Remediation_Planned,ISO_Exception_Number,COG_Supported,countryRegionID,CreatedDate,ModifiedDate,CreatedBy,ModifiedBy")] ExecutionList_new executionList_new)
        {
            if (ModelState.IsValid)
            {
                db.Entry(executionList_new).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.plannedDispositionID = new SelectList(db.CorralPlannedDispositions, "plannedDispositionID", "name", executionList_new.plannedDispositionID);
            ViewBag.countryRegionID = new SelectList(db.CountryRegions, "countryRegionID", "region", executionList_new.countryRegionID);
            ViewBag.databaseTypeID = new SelectList(db.DatabaseTypes, "databaseTypeID", "name", executionList_new.databaseTypeID);
            ViewBag.decomTypeID = new SelectList(db.DecomTypes, "decomTypeID", "name", executionList_new.decomTypeID);
            ViewBag.AtosTeamID = new SelectList(db.Departments, "AtosTeamID", "Department1", executionList_new.AtosTeamID);
            ViewBag.environmentID = new SelectList(db.Environments, "environmentID", "name", executionList_new.environmentID);
            ViewBag.groupingID = new SelectList(db.Groupings, "groupingID", "name", executionList_new.groupingID);
            ViewBag.operatingSystemID = new SelectList(db.OperatingSystems, "operatingSystemID", "name", executionList_new.operatingSystemID);
            ViewBag.resourceID = new SelectList(db.Resources, "ResourceID", "FirstName", executionList_new.resourceID);
            ViewBag.serverInCorral_ID = new SelectList(db.ServerInCorrals, "serverInCorral_ID", "name", executionList_new.serverInCorral_ID);
            ViewBag.siteID = new SelectList(db.Sites, "siteID", "name", executionList_new.siteID);
            ViewBag.statusID = new SelectList(db.StatusTypes, "statusID", "status", executionList_new.statusID);
            ViewBag.supportGroupID = new SelectList(db.SupportGroupCmdbs, "supportGroupID", "name", executionList_new.supportGroupID);
            ViewBag.workOrderID = new SelectList(db.WorkOrders, "workOrderID", "workOrderID", executionList_new.workOrderID);
            return View(executionList_new);
        }

        // GET: ExecutionList_new/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExecutionList_new executionList_new = db.ExecutionList_new.Find(id);
            if (executionList_new == null)
            {
                return HttpNotFound();
            }
            return View(executionList_new);
        }

        // POST: ExecutionList_new/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExecutionList_new executionList_new = db.ExecutionList_new.Find(id);
            db.ExecutionList_new.Remove(executionList_new);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
