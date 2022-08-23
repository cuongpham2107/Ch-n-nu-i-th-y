using DevExpress.Blazor;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Blazor.Editors.Grid;
using Microsoft.JSInterop;
using System;
using System.Linq;

namespace Cnty.Module.Controllers {
    public class AllViewController : ViewController<View>
    {
        //public AllViewController()
        //{
        //    TargetObjectType = typeof(ViewController);
        //    if (Application != null)
        //        Application.LoggingOff += Application_LoggingOff;
        //}

        //private void Application_LoggingOff(object sender, LoggingOffEventArgs e)
        //{
        //    //throw new NotImplementedException();
        //    var js = (IJSRuntime)((BlazorApplication)Application).ServiceProvider.GetService(typeof(IJSRuntime));
        //    js.InvokeVoidAsync("window.location.replace", "https://devexpress.com");
        //}

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();

            //if (View.Editor is GridListEditor gridListEditor) {
            //	var gridAdapter = gridListEditor.GetDataGridAdapter();
            //	if (gridAdapter != null) {
            //		gridAdapter.DataGridModel.ColumnResizeMode = DataGridColumnResizeMode.NextColumn;
            //		gridAdapter.DataGridModel.ShowGroupPanel = true;
            //		gridAdapter.DataGridModel.ShowFilterRow = true;
            //		gridAdapter.DataGridModel.ShowGroupedColumns = true;
            //		//gridAdapter.DataGridModel.DataNavigationMode = DevExpress.Blazor.DataGridNavigationMode.VirtualScrolling;
            //	}
            //}
        }
    }
}
