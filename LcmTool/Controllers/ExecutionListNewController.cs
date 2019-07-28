﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using LcmTool.Models;

namespace LcmTool.Controllers
{
    public class ExecutionListNewController : Controller
    {
        private LifecycleManagementEntities db = new LifecycleManagementEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExecutionList_new_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<ExecutionList_new> executionlist_new = db.ExecutionList_new;
            DataSourceResult result = executionlist_new.ToDataSourceResult(request, executionList_new => new {
                lcmID = executionList_new.lcmID,
                WO_StatusID = executionList_new.WO_StatusID,
                currentServerName = executionList_new.currentServerName,
                cmo = executionList_new.cmo,
                newServerName = executionList_new.newServerName,
                fmo = executionList_new.fmo,
                status27Date = executionList_new.status27Date,
                notes = executionList_new.notes,
                waveNum = executionList_new.waveNum,
                handoverDate = executionList_new.handoverDate,
                region = executionList_new.region,
                country = executionList_new.country,
                siteComments = executionList_new.siteComments,
                appName = executionList_new.appName,
                appOwner = executionList_new.appOwner,
                monsantoPM = executionList_new.monsantoPM,
                atosPM = executionList_new.atosPM,
                escalationNotes = executionList_new.escalationNotes,
                personContacted = executionList_new.personContacted,
                contactedDate = executionList_new.contactedDate,
                serialNum = executionList_new.serialNum,
                pmNotes = executionList_new.pmNotes,
                skyfall = executionList_new.skyfall,
                skyfallNum = executionList_new.skyfallNum,
                skyfall_index = executionList_new.skyfall_index,
                decomStartDate = executionList_new.decomStartDate,
                retirementCrq = executionList_new.retirementCrq,
                retirementChg = executionList_new.retirementChg,
                retirementWo = executionList_new.retirementWo,
                j_data_decom_only = executionList_new.j_data_decom_only,
                forecastedStatusDate = executionList_new.forecastedStatusDate,
                cabApprovalDate = executionList_new.cabApprovalDate,
                java = executionList_new.java,
                middleware = executionList_new.middleware,
                citrix = executionList_new.citrix,
                lcmWeek = executionList_new.lcmWeek,
                platforms = executionList_new.platforms,
                complianceAssetID = executionList_new.complianceAssetID,
                screamTeast = executionList_new.screamTeast,
                AppTeamTurnoverDate = executionList_new.AppTeamTurnoverDate,
                managedBy = executionList_new.managedBy,
                currentOsVersion = executionList_new.currentOsVersion,
                futureOsVersion = executionList_new.futureOsVersion,
                dateEnteredCorral = executionList_new.dateEnteredCorral,
                followupMonth = executionList_new.followupMonth,
                transformation = executionList_new.transformation,
                afqOsVersion = executionList_new.afqOsVersion,
                fiscalYear = executionList_new.fiscalYear,
                NZEV_Overlap = executionList_new.NZEV_Overlap,
                serverRequiresOsLicense = executionList_new.serverRequiresOsLicense,
                NumCores = executionList_new.NumCores,
                NumProcessors = executionList_new.NumProcessors,
                NZEV_Remediation_Planned = executionList_new.NZEV_Remediation_Planned,
                ISO_Exception_Number = executionList_new.ISO_Exception_Number,
                COG_Supported = executionList_new.COG_Supported,
                CreatedDate = executionList_new.CreatedDate,
                ModifiedDate = executionList_new.ModifiedDate,
                CreatedBy = executionList_new.CreatedBy,
                ModifiedBy = executionList_new.ModifiedBy,
            });

            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ExecutionList_new_Create([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ExecutionList_new> executionlist_new)
        {
            var entities = new List<ExecutionList_new>();
            if (executionlist_new != null && ModelState.IsValid)
            {
                foreach(var executionList_new in executionlist_new)
                {
                    var entity = new ExecutionList_new
                    {
                            WO_StatusID = executionList_new.WO_StatusID,
                            currentServerName = executionList_new.currentServerName,
                            cmo = executionList_new.cmo,
                            newServerName = executionList_new.newServerName,
                            fmo = executionList_new.fmo,
                            status27Date = executionList_new.status27Date,
                            notes = executionList_new.notes,
                            waveNum = executionList_new.waveNum,
                            handoverDate = executionList_new.handoverDate,
                            region = executionList_new.region,
                            country = executionList_new.country,
                            siteComments = executionList_new.siteComments,
                            appName = executionList_new.appName,
                            appOwner = executionList_new.appOwner,
                            monsantoPM = executionList_new.monsantoPM,
                            atosPM = executionList_new.atosPM,
                            escalationNotes = executionList_new.escalationNotes,
                            personContacted = executionList_new.personContacted,
                            contactedDate = executionList_new.contactedDate,
                            serialNum = executionList_new.serialNum,
                            pmNotes = executionList_new.pmNotes,
                            skyfall = executionList_new.skyfall,
                            skyfallNum = executionList_new.skyfallNum,
                            skyfall_index = executionList_new.skyfall_index,
                            decomStartDate = executionList_new.decomStartDate,
                            retirementCrq = executionList_new.retirementCrq,
                            retirementChg = executionList_new.retirementChg,
                            retirementWo = executionList_new.retirementWo,
                            j_data_decom_only = executionList_new.j_data_decom_only,
                            forecastedStatusDate = executionList_new.forecastedStatusDate,
                            cabApprovalDate = executionList_new.cabApprovalDate,
                            java = executionList_new.java,
                            middleware = executionList_new.middleware,
                            citrix = executionList_new.citrix,
                            lcmWeek = executionList_new.lcmWeek,
                            platforms = executionList_new.platforms,
                            complianceAssetID = executionList_new.complianceAssetID,
                            screamTeast = executionList_new.screamTeast,
                            AppTeamTurnoverDate = executionList_new.AppTeamTurnoverDate,
                            managedBy = executionList_new.managedBy,
                            currentOsVersion = executionList_new.currentOsVersion,
                            futureOsVersion = executionList_new.futureOsVersion,
                            dateEnteredCorral = executionList_new.dateEnteredCorral,
                            followupMonth = executionList_new.followupMonth,
                            transformation = executionList_new.transformation,
                            afqOsVersion = executionList_new.afqOsVersion,
                            fiscalYear = executionList_new.fiscalYear,
                            NZEV_Overlap = executionList_new.NZEV_Overlap,
                            serverRequiresOsLicense = executionList_new.serverRequiresOsLicense,
                            NumCores = executionList_new.NumCores,
                            NumProcessors = executionList_new.NumProcessors,
                            NZEV_Remediation_Planned = executionList_new.NZEV_Remediation_Planned,
                            ISO_Exception_Number = executionList_new.ISO_Exception_Number,
                            COG_Supported = executionList_new.COG_Supported,
                            CreatedDate = executionList_new.CreatedDate,
                            ModifiedDate = executionList_new.ModifiedDate,
                            CreatedBy = executionList_new.CreatedBy,
                            ModifiedBy = executionList_new.ModifiedBy,
                    };

                    db.ExecutionList_new.Add(entity);
                    entities.Add(entity);
                }
                db.SaveChanges();
            }

            return Json(entities.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ExecutionList_new_Update([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ExecutionList_new> executionlist_new)
        {
            var entities = new List<ExecutionList_new>();
            if (executionlist_new != null && ModelState.IsValid)
            {
                foreach(var executionList_new in executionlist_new)
                {
                    var entity = new ExecutionList_new
                    {
                        lcmID = executionList_new.lcmID,
                        WO_StatusID = executionList_new.WO_StatusID,
                        currentServerName = executionList_new.currentServerName,
                        cmo = executionList_new.cmo,
                        newServerName = executionList_new.newServerName,
                        fmo = executionList_new.fmo,
                        status27Date = executionList_new.status27Date,
                        notes = executionList_new.notes,
                        waveNum = executionList_new.waveNum,
                        handoverDate = executionList_new.handoverDate,
                        region = executionList_new.region,
                        country = executionList_new.country,
                        siteComments = executionList_new.siteComments,
                        appName = executionList_new.appName,
                        appOwner = executionList_new.appOwner,
                        monsantoPM = executionList_new.monsantoPM,
                        atosPM = executionList_new.atosPM,
                        escalationNotes = executionList_new.escalationNotes,
                        personContacted = executionList_new.personContacted,
                        contactedDate = executionList_new.contactedDate,
                        serialNum = executionList_new.serialNum,
                        pmNotes = executionList_new.pmNotes,
                        skyfall = executionList_new.skyfall,
                        skyfallNum = executionList_new.skyfallNum,
                        skyfall_index = executionList_new.skyfall_index,
                        decomStartDate = executionList_new.decomStartDate,
                        retirementCrq = executionList_new.retirementCrq,
                        retirementChg = executionList_new.retirementChg,
                        retirementWo = executionList_new.retirementWo,
                        j_data_decom_only = executionList_new.j_data_decom_only,
                        forecastedStatusDate = executionList_new.forecastedStatusDate,
                        cabApprovalDate = executionList_new.cabApprovalDate,
                        java = executionList_new.java,
                        middleware = executionList_new.middleware,
                        citrix = executionList_new.citrix,
                        lcmWeek = executionList_new.lcmWeek,
                        platforms = executionList_new.platforms,
                        complianceAssetID = executionList_new.complianceAssetID,
                        screamTeast = executionList_new.screamTeast,
                        AppTeamTurnoverDate = executionList_new.AppTeamTurnoverDate,
                        managedBy = executionList_new.managedBy,
                        currentOsVersion = executionList_new.currentOsVersion,
                        futureOsVersion = executionList_new.futureOsVersion,
                        dateEnteredCorral = executionList_new.dateEnteredCorral,
                        followupMonth = executionList_new.followupMonth,
                        transformation = executionList_new.transformation,
                        afqOsVersion = executionList_new.afqOsVersion,
                        fiscalYear = executionList_new.fiscalYear,
                        NZEV_Overlap = executionList_new.NZEV_Overlap,
                        serverRequiresOsLicense = executionList_new.serverRequiresOsLicense,
                        NumCores = executionList_new.NumCores,
                        NumProcessors = executionList_new.NumProcessors,
                        NZEV_Remediation_Planned = executionList_new.NZEV_Remediation_Planned,
                        ISO_Exception_Number = executionList_new.ISO_Exception_Number,
                        COG_Supported = executionList_new.COG_Supported,
                        CreatedDate = executionList_new.CreatedDate,
                        ModifiedDate = executionList_new.ModifiedDate,
                        CreatedBy = executionList_new.CreatedBy,
                        ModifiedBy = executionList_new.ModifiedBy,
                    };

                    entities.Add(entity);
                    db.ExecutionList_new.Attach(entity);
                    db.Entry(entity).State = EntityState.Modified;                        
                }
                db.SaveChanges();
            }

            return Json(entities.ToDataSourceResult(request, ModelState));
        } 

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ExecutionList_new_Destroy([DataSourceRequest]DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<ExecutionList_new> executionlist_new)
        {
            var entities = new List<ExecutionList_new>();
            if (ModelState.IsValid)
            {
                foreach(var executionList_new in executionlist_new)
                {
                    var entity = new ExecutionList_new
                    {
                        lcmID = executionList_new.lcmID,
                        WO_StatusID = executionList_new.WO_StatusID,
                        currentServerName = executionList_new.currentServerName,
                        cmo = executionList_new.cmo,
                        newServerName = executionList_new.newServerName,
                        fmo = executionList_new.fmo,
                        status27Date = executionList_new.status27Date,
                        notes = executionList_new.notes,
                        waveNum = executionList_new.waveNum,
                        handoverDate = executionList_new.handoverDate,
                        region = executionList_new.region,
                        country = executionList_new.country,
                        siteComments = executionList_new.siteComments,
                        appName = executionList_new.appName,
                        appOwner = executionList_new.appOwner,
                        monsantoPM = executionList_new.monsantoPM,
                        atosPM = executionList_new.atosPM,
                        escalationNotes = executionList_new.escalationNotes,
                        personContacted = executionList_new.personContacted,
                        contactedDate = executionList_new.contactedDate,
                        serialNum = executionList_new.serialNum,
                        pmNotes = executionList_new.pmNotes,
                        skyfall = executionList_new.skyfall,
                        skyfallNum = executionList_new.skyfallNum,
                        skyfall_index = executionList_new.skyfall_index,
                        decomStartDate = executionList_new.decomStartDate,
                        retirementCrq = executionList_new.retirementCrq,
                        retirementChg = executionList_new.retirementChg,
                        retirementWo = executionList_new.retirementWo,
                        j_data_decom_only = executionList_new.j_data_decom_only,
                        forecastedStatusDate = executionList_new.forecastedStatusDate,
                        cabApprovalDate = executionList_new.cabApprovalDate,
                        java = executionList_new.java,
                        middleware = executionList_new.middleware,
                        citrix = executionList_new.citrix,
                        lcmWeek = executionList_new.lcmWeek,
                        platforms = executionList_new.platforms,
                        complianceAssetID = executionList_new.complianceAssetID,
                        screamTeast = executionList_new.screamTeast,
                        AppTeamTurnoverDate = executionList_new.AppTeamTurnoverDate,
                        managedBy = executionList_new.managedBy,
                        currentOsVersion = executionList_new.currentOsVersion,
                        futureOsVersion = executionList_new.futureOsVersion,
                        dateEnteredCorral = executionList_new.dateEnteredCorral,
                        followupMonth = executionList_new.followupMonth,
                        transformation = executionList_new.transformation,
                        afqOsVersion = executionList_new.afqOsVersion,
                        fiscalYear = executionList_new.fiscalYear,
                        NZEV_Overlap = executionList_new.NZEV_Overlap,
                        serverRequiresOsLicense = executionList_new.serverRequiresOsLicense,
                        NumCores = executionList_new.NumCores,
                        NumProcessors = executionList_new.NumProcessors,
                        NZEV_Remediation_Planned = executionList_new.NZEV_Remediation_Planned,
                        ISO_Exception_Number = executionList_new.ISO_Exception_Number,
                        COG_Supported = executionList_new.COG_Supported,
                        CreatedDate = executionList_new.CreatedDate,
                        ModifiedDate = executionList_new.ModifiedDate,
                        CreatedBy = executionList_new.CreatedBy,
                        ModifiedBy = executionList_new.ModifiedBy,
                    };

                    entities.Add(entity);
                    db.ExecutionList_new.Attach(entity);
                    db.ExecutionList_new.Remove(entity);
                }
                db.SaveChanges();
            }

            return Json(entities.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
