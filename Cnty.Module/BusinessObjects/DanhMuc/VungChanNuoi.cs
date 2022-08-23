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
	[XafDefaultProperty(nameof(TenVung))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Vùng chăn nuôi")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class VungChanNuoi : BaseObject {
		public VungChanNuoi(Session session) : base(session) { }


		// Property region
		#region Properties

		string tenVung;
		[XafDisplayName("Tên vùng"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenVung {
			get => tenVung;
			set => SetPropertyValue(nameof(TenVung), ref tenVung, value);
		}

		string diaChi;
		[XafDisplayName("Địa chỉ"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string DiaChi {
			get => diaChi;
			set => SetPropertyValue(nameof(DiaChi), ref diaChi, value);
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