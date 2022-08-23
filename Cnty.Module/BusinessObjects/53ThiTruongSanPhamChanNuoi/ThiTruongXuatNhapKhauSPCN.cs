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
	[XafDefaultProperty(nameof(SanPhamChanNuoi))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Thị trường xuất nhập khẩu SPCN")]
	[NavigationItem(R.MenuThiTruongSanPham)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class ThiTruongXuatNhapKhauSPCN : BaseObject {
		public ThiTruongXuatNhapKhauSPCN(Session session) : base(session) { }


		// Property region
		#region Properties

		QuocGia quocGia;
		[XafDisplayName("Nước"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public QuocGia QuocGia {
			get => quocGia;
			set => SetPropertyValue(nameof(QuocGia), ref quocGia, value);
		}

		XuatNhapKhau xuatNhapKhau;
		[XafDisplayName("Thị trường"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public XuatNhapKhau XuatNhapKhau {
			get => xuatNhapKhau;
			set => SetPropertyValue(nameof(XuatNhapKhau), ref xuatNhapKhau, value);
		}

		SanPhamChanNuoi sanPhamChanNuoi;
		[XafDisplayName("Sản phẩm chăn nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public SanPhamChanNuoi SanPhamChanNuoi {
			get => sanPhamChanNuoi;
			set => SetPropertyValue(nameof(SanPhamChanNuoi), ref sanPhamChanNuoi, value);
		}

		int soLuong;
		[XafDisplayName("Số lượng"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public int SoLuong {
			get => soLuong;
			set => SetPropertyValue(nameof(SoLuong), ref soLuong, value);
		}

		string quyCach;
		[XafDisplayName("Quy cách"), ToolTip("")]
		public string QuyCach {
			get => quyCach;
			set => SetPropertyValue(nameof(QuyCach), ref quyCach, value);
		}

		string giaTriXuatNhapKhau;
		[XafDisplayName("Giá trị xuất nhập khẩu"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string GiaTriXuatNhapKhau {
			get => giaTriXuatNhapKhau;
			set => SetPropertyValue(nameof(GiaTriXuatNhapKhau), ref giaTriXuatNhapKhau, value);
		}

		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}

	public enum XuatNhapKhau
	{
		[XafDisplayName("Xuất khẩu")] XUAT_KHAU,
		[XafDisplayName("Nhập khẩu")] NHAP_KHAU,
	}

}