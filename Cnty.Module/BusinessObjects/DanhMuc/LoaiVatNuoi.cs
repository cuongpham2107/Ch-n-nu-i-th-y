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
	[XafDefaultProperty(nameof(TenVatNuoi))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Loại vật nuôi")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class LoaiVatNuoi : BaseObject {
		public LoaiVatNuoi(Session session) : base(session) { }

		// Property region
		#region Properties

		string tenVatNuoi;
		[XafDisplayName("Loại vật nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenVatNuoi {
			get => tenVatNuoi;
			set => SetPropertyValue(nameof(TenVatNuoi), ref tenVatNuoi, value);
		}

		string moTa;
		[XafDisplayName("Mô tả"), ToolTip("")]
		public string MoTa {
			get => moTa;
			set => SetPropertyValue(nameof(MoTa), ref moTa, value);
		}

		#endregion

	}
}