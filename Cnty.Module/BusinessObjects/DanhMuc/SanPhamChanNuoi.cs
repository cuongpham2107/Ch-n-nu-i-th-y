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
	[XafDefaultProperty(nameof(TenSanPham))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Sản phẩm chăn nuôi")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class SanPhamChanNuoi : BaseObject {
		public SanPhamChanNuoi(Session session) : base(session) { }


		// Property region
		#region Properties

		string tenSanPham;
		[XafDisplayName("Tên sản phẩm"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenSanPham {
			get => tenSanPham;
			set => SetPropertyValue(nameof(TenSanPham), ref tenSanPham, value);
		}

		string moTa;
		[XafDisplayName("Mô tả"), ToolTip("")]
		////[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
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

	public enum NhomSanPhamChanNuoi
    {
		[XafDisplayName("Con giống, sản phẩm giống vật nuôi")] CON_GIONG_SAN_PHAM_GIONG_VAT_NUOI,
		[XafDisplayName("Thức ăn chăn nuôi hỗn hợp")] THUC_AN_CHAN_NUOI_HON_HOP,
		[XafDisplayName("Nguyên liệu thức ăn chăn nuôi chính")] NGUYEN_LIEU_THUC_AN_CHAN_NUOI_CHINH,
		[XafDisplayName("Sản phẩm chăn nuôi chính")] THUC_PHAM_CHAN_NUOI_CHINH,
	}
}