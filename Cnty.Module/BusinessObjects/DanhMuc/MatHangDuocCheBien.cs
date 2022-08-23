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
	[XafDefaultProperty(nameof(TenMatHang))]
	[ImageName("BO_Contact")]
	//Cho 4.2 Cơ sở chế biến sản phẩm chăn nuôi
	[XafDisplayName("Sản phẩm chăn nuôi được chế biến")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class MatHangDuocCheBien : BaseObject {
		public MatHangDuocCheBien(Session session) : base(session) { }


		// Property region
		#region Properties

		string tenMatHang;
		[XafDisplayName("Tên mặt hàng"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenMatHang {
			get => tenMatHang;
			set => SetPropertyValue(nameof(TenMatHang), ref tenMatHang, value);
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