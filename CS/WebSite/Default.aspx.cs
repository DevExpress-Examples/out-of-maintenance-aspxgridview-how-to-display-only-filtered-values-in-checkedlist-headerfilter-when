using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void gvProducts_HeaderFilterFillItems(object sender, DevExpress.Web.ASPxGridViewHeaderFilterEventArgs e) {
        ASPxGridView gridView = sender as ASPxGridView;
        List<FilterValue> result = new List<FilterValue>();

        HashSet<object> columnValues = new HashSet<object>();
        for (int i = 0; i < gridView.VisibleRowCount; i++) {
            columnValues.Add(gridView.GetRowValues(i, e.Column.FieldName).ToString());
        }

        e.Values.RemoveAll(filterValue => !columnValues.Contains(filterValue.Value));
    }
}