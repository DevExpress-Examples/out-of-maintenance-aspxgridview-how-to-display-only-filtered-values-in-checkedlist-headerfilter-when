<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to display only filtered values in CheckedList HeaderFilter when a filter is applied to a column
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4853/)**
<!-- run online end -->


<p>According to ASPxGridView design, when the CheckedList HeaderFilter is displayed for a column with a filter applied, it displays all possible column values in the CheckedList. This example illustrates how to overcome this behavior and always display only filtered values in the CheckedList. </p><p>In this example the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_HeaderFilterFillItemstopic"><u>ASPxGridView.HeaderFilterFillItems</u></a>  event handler is used to get all available unique column values by iterating through <strong>all</strong> ASPxGridView rows and removing unnecessary items from the  <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridViewHeaderFilterEventArgs_Valuestopic"><u>e.Values</u></a> collection.</p><p><strong>Note</strong> that this approach would not work if the server-mode binding is used. In this case, get all available unique column values directly from your database server.</p>

<br/>


