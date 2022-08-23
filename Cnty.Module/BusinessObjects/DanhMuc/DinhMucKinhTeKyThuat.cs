using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[DefaultClassOptions]
	[XafDefaultProperty(nameof(Ten))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Định mức kinh tế kỹ thuật")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class DinhMucKinhTeKyThuat : BaseObject {
		public DinhMucKinhTeKyThuat(Session session) : base(session) { }

		// Property region
		#region Properties
		string ten;
		[XafDisplayName("Tên gọi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string Ten {
			get => ten;
			set => SetPropertyValue(nameof(Ten), ref ten, value);
		}

		string moTa;
		[XafDisplayName("Mô tả"), ToolTip("")]
		public string MoTa {
			get => moTa;
			set => SetPropertyValue(nameof(MoTa), ref moTa, value);
		}
		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}
}