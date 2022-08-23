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
	[XafDisplayName("Nguồn gen giống vật nuôi")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class NguonGenGiongVatNuoi : BaseObject {
		public NguonGenGiongVatNuoi(Session session) : base(session) { }

		// Property region
		#region Properties

		string ten;
		[XafDisplayName("Tên"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string Ten {
			get => ten;
			set => SetPropertyValue(nameof(Ten), ref ten, value);
		}

		string mota;
		[XafDisplayName("Mô tả"), ToolTip("")]
		public string MoTa {
			get => mota;
			set => SetPropertyValue(nameof(MoTa), ref mota, value);
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