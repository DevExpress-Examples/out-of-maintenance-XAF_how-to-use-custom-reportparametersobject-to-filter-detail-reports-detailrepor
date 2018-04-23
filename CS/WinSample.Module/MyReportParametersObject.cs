using System;

using DevExpress.Xpo;

using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Reports;
using DevExpress.Xpo.DB;

namespace WinSample.Module {
    [NonPersistent]
    public class MyReportParametersObject : ReportParametersObjectBase {
        public MyReportParametersObject(Session session) : base(session) { }
        public override DevExpress.Data.Filtering.CriteriaOperator GetCriteria() {
            return null;
        }
        public override SortingCollection GetSorting() {
            SortingCollection sorting = new SortingCollection();
            sorting.Add(new SortProperty("MasterName", SortingDirection.Ascending));
            return sorting;
        }
        private DateTime _StartDate;
        [Index(0)]
        public DateTime StartDate {
            get { return _StartDate; }
            set { SetPropertyValue("StartDate", ref _StartDate, value); }
        }
        private DateTime _EndDate;
        [Index(1)]
        public DateTime EndDate {
            get { return _EndDate; }
            set { SetPropertyValue("EndDate", ref _EndDate, value); }
        }
    }

}
