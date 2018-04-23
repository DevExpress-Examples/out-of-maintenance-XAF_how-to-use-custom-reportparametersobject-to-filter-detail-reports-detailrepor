using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Reports;
using DevExpress.ExpressApp;

namespace WinSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(DevExpress.ExpressApp.IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateReport("MasterDetailsReport");
        }
        private void CreateReport(string reportName) {
            ReportData reportdata = Session.FindObject<ReportData>(new BinaryOperator("Name", reportName));
            if (reportdata == null) {
                reportdata = new ReportData(Session);
                XafReport rep = new XafReport();
                rep.ReportName = reportName;
                rep.ObjectSpace = new ObjectSpace(new UnitOfWork(Session.DataLayer), XafTypesInfo.Instance);
                rep.LoadLayout(GetType().Assembly.GetManifestResourceStream(
                   "WinSample.Module.EmbeddedReports." + reportName + ".repx"));
                reportdata.SaveXtraReport(rep);
                reportdata.Save();
            }
        }
    }
}
