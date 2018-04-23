using System;

using DevExpress.Xpo;

using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Reports;
using DevExpress.Xpo.DB;
using DevExpress.ExpressApp;

namespace WinSample.Module {
    [NonPersistent]
    public class MyReportParametersObject : ReportParametersObjectBase {
        public MyReportParametersObject(IObjectSpace objectSpace, Type reportDataType) : base(objectSpace, reportDataType) { }
        public override DevExpress.Data.Filtering.CriteriaOperator GetCriteria() {
            return null;
        }
        public override SortProperty[] GetSorting() {
            return new SortProperty[] { new SortProperty("MasterName", SortingDirection.Ascending) };
        }
        private DateTime _StartDate;
        [Index(0)]
        public DateTime StartDate {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        private DateTime _EndDate;
        [Index(1)]
        public DateTime EndDate {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
    }

}
