using Cnty.Module.BusinessObjects;
using DevExpress.Blazor;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Grid;
using DevExpress.ExpressApp.Blazor.Editors.Grid.Models;
using DevExpress.ExpressApp.DC;
using System;
using System.Linq;

namespace Cnty.Module.Controllers {

	public class GiaSanPhamChanNuoi_ListViewController : ViewController<ListView> {
		public GiaSanPhamChanNuoi_ListViewController() {
			TargetObjectType = typeof(GiaSanPhamChanNuoi);
			CreateReport();
		}

		protected override void OnViewControlsCreated() {
			base.OnViewControlsCreated();
			SetListViewDefault();
		}

		void SetListViewDefault() {
			if (View.Editor is GridListEditor gridListEditor) {
				var gridAdapter = gridListEditor?.GetDataGridAdapter();
				if (gridAdapter != null) {
					gridAdapter.DataGridModel.ColumnResizeMode = DataGridColumnResizeMode.NextColumn;

					gridAdapter.DataGridModel.ShowGroupPanel = true;
					gridAdapter.DataGridModel.ShowFilterRow = true;
					gridAdapter.DataGridModel.ShowGroupedColumns = true;
					foreach (var col in gridListEditor.Columns)
						col.GroupIndex = -1;
				}
			}
		}

		void SetGroupSummary() {
			if (View.Editor is GridListEditor gridListEditor) {
				base.OnViewControlsCreated();
				var gridAdapter = gridListEditor.GetDataGridAdapter();
				if (gridAdapter != null) {
					foreach (var col in gridListEditor.Columns)
						col.GroupIndex = -1;

					var min = new DxDataGridSummaryItemModel {
						SummaryType = SummaryItemType.Min,
						Field = nameof(GiaSanPhamChanNuoi.Gia),
						DisplayFormat = "Giá thấp nhất: {0}"
					};

					var max = new DxDataGridSummaryItemModel {
						SummaryType = SummaryItemType.Max,
						Field = nameof(GiaSanPhamChanNuoi.Gia),
						DisplayFormat = "Giá cao nhất: {0}"
					};

					var avg = new DxDataGridSummaryItemModel {
						SummaryType = SummaryItemType.Avg,
						Field = nameof(GiaSanPhamChanNuoi.Gia),
						DisplayFormat = "Giá trung bình: {0}"
					};

					gridAdapter.DataGridModel.ColumnResizeMode = DataGridColumnResizeMode.NextColumn;
					gridAdapter.DataGridModel.ShowGroupPanel = true;
					gridAdapter.DataGridModel.ShowFilterRow = true;
					gridAdapter.DataGridModel.ShowGroupedColumns = true;

					gridAdapter.GroupSummary.Clear();
					gridAdapter.GroupSummary.Add(new BlazorGridSummaryItem(min));
					gridAdapter.GroupSummary.Add(new BlazorGridSummaryItem(max));
					gridAdapter.GroupSummary.Add(new BlazorGridSummaryItem(avg));

					//gridListEditor.Columns[0].GroupIndex = 0;
				}
			}
		}

		private void CreateReport() {

			var action = new PopupWindowShowAction(this, $"{typeof(GiaSanPhamChanNuoi).Name}-GetDataInTimePeriod", "Edit") {
				Caption = "Thống kê", SelectionDependencyType = SelectionDependencyType.Independent
			};
			action.CustomizePopupWindowParams += (s, e) => {				
				IObjectSpace os = Application.CreateObjectSpace();
				var view = Application.CreateDetailView(os, new TimePeriodParameter());
				e.View = view;
			};
			action.Execute += (s, e) => {				
				var popupData = e.PopupWindowViewCurrentObject as TimePeriodParameter;
				var criteria = View.CollectionSource.Criteria;
				criteria.Clear();
				criteria.Add("001", new BinaryOperator(nameof(GiaSanPhamChanNuoi.NgayNhapGia), popupData.StartDate, BinaryOperatorType.GreaterOrEqual));
				criteria.Add("002", new BinaryOperator(nameof(GiaSanPhamChanNuoi.NgayNhapGia), popupData.EndDate, BinaryOperatorType.LessOrEqual));

				SetGroupSummary();//Application.LogOff();
			};
		}
	}

	[DomainComponent]
	public class TimePeriodParameter
	{
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
