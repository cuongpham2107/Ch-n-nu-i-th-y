using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(TenSanPham))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Sản phẩm xử lý chất thải chăn nuôi")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class SanPhamXuLyChatThaiChanNuoi : BaseObject {
		public SanPhamXuLyChatThaiChanNuoi(Session session) : base(session) { }

		string tenSanPham;
		[XafDisplayName("Tên sản phẩm"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenSanPham {
			get => tenSanPham;
			set => SetPropertyValue(nameof(TenSanPham), ref tenSanPham, value);
		}

		string moTa;
		[XafDisplayName("Mô tả"), ToolTip("")]
		public string MoTa {
			get => moTa;
			set => SetPropertyValue(nameof(MoTa), ref moTa, value);
		}
	}
}