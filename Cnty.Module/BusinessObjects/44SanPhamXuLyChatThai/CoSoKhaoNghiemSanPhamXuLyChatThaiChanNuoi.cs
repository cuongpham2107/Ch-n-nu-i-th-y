using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(CoSoKhaoNghiem))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Cơ sở khảo nghiệm sản phẩm xử lý chất thải chăn nuôi")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class CoSoKhaoNghiemSanPhamXuLyChatThaiChanNuoi : BaseObject {
		public CoSoKhaoNghiemSanPhamXuLyChatThaiChanNuoi(Session session) : base(session) { }

		CosoSanxuat coSoKhaoNghiem;
		[XafDisplayName("Cơ sở khảo nghiệm"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CoSoKhaoNghiem {
			get => coSoKhaoNghiem;
			set => SetPropertyValue(nameof(CoSoKhaoNghiem), ref coSoKhaoNghiem, value);
		}

		[XafDisplayName("Email")]
		[PersistentAlias("")]
		public string Email => CoSoKhaoNghiem?.Email;

		[XafDisplayName("Địa chỉ")]
		[PersistentAlias("")]
		public string DiaChi => CoSoKhaoNghiem?.Diachi;

		[XafDisplayName("Số điện thoại")]
		[PersistentAlias("")]
		public string SoDienThoai => CoSoKhaoNghiem?.SoDienThoai;
	}
}