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
    public class ExecutionListsController : Controller
    {
        private LifecycleManagementEntities db = new LifecycleManagementEntities();

        // GET: ExecutionLists
        public ActionResult Index()
        {
            return View(db.ExecutionLists.ToList());
        }

        // GET: ExecutionLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExecutionList executionList = db.ExecutionLists.Find(id);
            if (executionList == null)
            {
                return HttpNotFound();
            }
            return View(executionList);
        }

        // GET: ExecutionLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExecutionLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lcmID,currentServerName,cmo,newServerName,fmo,status,status27Date,notes,waveNum,grouping,CRQ_CHG_WO,CRQ_CHG_WOStatus,HandoverDate,region,country,site,siteComments,appName,appOwner,monsantoPM,atosPM,escalationNotes,personContacted,contactedDate,serialNum,pmNotes,environment,supportGroupCmdb,operatingSystem,skyfall,skyfallNum,skyfallIndex,atosTeamID,decomType,decomStartDate,retirementCrq,retirementChg,retirementWo,decomData,forecastedStatusDate,cabApprovalDate,database,java,middleware,citrix,lcmWeek,platforms,complianceAssetID,screamTest,serverInCorral,corralPlannedDisposition,AppTeamTurnoverDate,managedBy,currentOsVersion,futureOsVersion,dateEnteredCorral,followupMonth,transformation,afqOsVersion,fiscalYear,ResourceID,CreatedDate,ModifiedDate,CreatedBy,ModifiedBy,NZEVOverlap,ServerRequiresOSLicense,NumCores,NumProcessors,NZEVRemediationPlanned,ISOExceptionNumber,COGSupported,LcmType")] ExecutionList executionList)
        {
            if (ModelState.IsValid)
            {
                db.ExecutionLists.Add(executionList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(executionList);
        }

        // GET: ExecutionLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExecutionList executionList = db.ExecutionLists.Find(id);
            if (executionList == null)
            {
                return HttpNotFound();
            }
            return View(executionList);
        }

        // POST: ExecutionLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lcmID,currentServerName,cmo,newServerName,fmo,status,status27Date,notes,waveNum,grouping,CRQ_CHG_WO,CRQ_CHG_WOStatus,HandoverDate,region,country,site,siteComments,appName,appOwner,monsantoPM,atosPM,escalationNotes,personContacted,contactedDate,serialNum,pmNotes,environment,supportGroupCmdb,operatingSystem,skyfall,skyfallNum,skyfallIndex,atosTeamID,decomType,decomStartDate,retirementCrq,retirementChg,retirementWo,decomData,forecastedStatusDate,cabApprovalDate,database,java,middleware,citrix,lcmWeek,platforms,complianceAssetID,screamTest,serverInCorral,corralPlannedDisposition,AppTeamTurnoverDate,managedBy,currentOsVersion,futureOsVersion,dateEnteredCorral,followupMonth,transformation,afqOsVersion,fiscalYear,ResourceID,CreatedDate,ModifiedDate,CreatedBy,ModifiedBy,NZEVOverlap,ServerRequiresOSLicense,NumCores,NumProcessors,NZEVRemediationPlanned,ISOExceptionNumber,COGSupported,LcmType")] ExecutionList executionList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(executionList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(executionList);
        }

        // GET: ExecutionLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExecutionList executionList = db.ExecutionLists.Find(id);
            if (executionList == null)
            {
                return HttpNotFound();
            }
            return View(executionList);
        }

        // POST: ExecutionLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExecutionList executionList = db.ExecutionLists.Find(id);
            db.ExecutionLists.Remove(executionList);
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
