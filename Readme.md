<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128594329/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1396)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Detail.cs](./CS/WinSample.Module/Detail.cs) (VB: [Detail.vb](./VB/WinSample.Module/Detail.vb))
* [Master.cs](./CS/WinSample.Module/Master.cs) (VB: [Master.vb](./VB/WinSample.Module/Master.vb))
* [MyReportParametersObject.cs](./CS/WinSample.Module/MyReportParametersObject.cs) (VB: [MyReportParametersObject.vb](./VB/WinSample.Module/MyReportParametersObject.vb))
* **[Script.txt](./CS/WinSample.Module/Script.txt) (VB: [Script.txt](./VB/WinSample.Module/Script.txt))**
<!-- default file list end -->
# How to use custom ReportParametersObject to filter detail reports ( DetailReportBand )


<p>This example demonstrates how to show a filter dialog that can filter a detail report before showing the report preview. For this purpose, a custom ReportParametersObject - <strong>MyReportParametersObject</strong> - is created and assigned to the report. This class contains two properties - StartDate and EndDate. They are not used in the MyReportParametersObject.GetCriteria method, because it is required to filter the detail report, not the master one. The filtering is performed in the <strong>BeforePrint</strong> script of the detail report band (see <strong>Script.txt</strong>). The MyReportParametersObject is accessed via the <strong>XafReport.ReportParametersObject</strong> property, and values of its StartDate and EndDate properties are used to create a FilterString for the detail report.<br />The example uses the legacy <strong>Reports Module</strong>. The same approach can be used for the <strong>Reports V2 Module</strong>, but the Report Parameters Object should be created and associated with your report in accordance to the <a href="https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113594.aspx">Data Filtering in Reports V2</a> topic. Also, the object should be accessed in report scripts in a different way - see <a href="https://documentation.devexpress.com/eXpressAppFramework/CustomDocument114451.aspx">How to: Access the Report Parameters Object in Report Scripts</a>.</p>
<p><strong>See Also:</strong><br /> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2778"><u>Filter Report Data Source via the ParametersObjectType Property</u></a><br /> <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument2615"><u>Scripting Overview</u></a></p>

<br/>


