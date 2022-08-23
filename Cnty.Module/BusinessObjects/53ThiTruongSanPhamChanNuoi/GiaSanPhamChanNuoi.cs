using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[DefaultClassOptions]
	[XafDefaultProperty(nameof(SanPhamChanNuoi))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Thông tin về giá SPCN")]
	[NavigationItem(R.MenuThiTruongSanPham)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	//[ListViewFilter("Từ ngày", "[NgayNhapGia]=true")]
	//[ListViewFilter("Đến ngày", "[CoGiayChungNhanKhong]=true", Index = 1)]
	public class GiaSanPhamChanNuoi : BaseObject {
		public GiaSanPhamChanNuoi(Session session) : base(session) { }


		// Property region
		#region Properties

		SanPhamChanNuoi sanPhamChanNuoi;
		[XafDisplayName("Sản phẩm chăn nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public SanPhamChanNuoi SanPhamChanNuoi {
			get => sanPhamChanNuoi;
			set => SetPropertyValue(nameof(SanPhamChanNuoi), ref sanPhamChanNuoi, value);
		}

		DonViTinhSanPhamChanNuoi donViTinh;
		[XafDisplayName("Đơn vị tính"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public DonViTinhSanPhamChanNuoi DonViTinh {
			get => donViTinh;
			set => SetPropertyValue(nameof(DonViTinh), ref donViTinh, value);
		}

		long gia;
		[XafDisplayName("Giá"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public long Gia {
			get => gia;
			set => SetPropertyValue(nameof(Gia), ref gia, value);
		}

		DateTime ngayNhapGia;
		[XafDisplayName("Ngày nhập giá"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public DateTime NgayNhapGia {
			get => ngayNhapGia;
			set => SetPropertyValue(nameof(NgayNhapGia), ref ngayNhapGia, value);
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