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
	[XafDefaultProperty(nameof(DonViTinh))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Đơn vị tính SPCN")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class DonViTinhSanPhamChanNuoi : BaseObject {
		public DonViTinhSanPhamChanNuoi(Session session) : base(session) { }


		// Property region
		#region Properties

		[XafDisplayName("Đơn vị tính"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string DonViTinh { get; set; }

		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}
}