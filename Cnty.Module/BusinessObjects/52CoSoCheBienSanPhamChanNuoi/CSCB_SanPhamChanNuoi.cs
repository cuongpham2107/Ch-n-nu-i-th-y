using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(CoSoCheBien))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Cơ sở chế biến SPCN")]
	[NavigationItem(R.MenuCoSoChanNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class CSCB_SanPhamChanNuoi : BaseObject {
		public CSCB_SanPhamChanNuoi(Session session) : base(session) { }

		CosoSanxuat coSoCheBien;
		[XafDisplayName("Cơ sở chế biến"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CoSoCheBien {
			get => coSoCheBien;
			set => SetPropertyValue(nameof(CoSoCheBien), ref coSoCheBien, value);
		}

		string congSuat;
		[XafDisplayName("Công suất"), ToolTip("")]
		public string CongSuat {
			get => congSuat;
			set => SetPropertyValue(nameof(CongSuat), ref congSuat, value);
		}

		MatHangDuocCheBien matHang;
		[XafDisplayName("Mặt hàng"), ToolTip("")]
		public MatHangDuocCheBien MatHang
		{
			get => matHang;
			set => SetPropertyValue(nameof(MatHang), ref matHang, value);
		}

		string chungLoai;
		[XafDisplayName("Chủng loại chế biên"), ToolTip("")]
		public string ChungLoai{
			get => chungLoai;
			set => SetPropertyValue(nameof(ChungLoai), ref chungLoai, value);
		}

		string nguonGocNguyenLieu;
		[XafDisplayName("Nguồn gốc nguyên liệu"), ToolTip("")]
		public string NguonGocNguyenLieu {
			get => nguonGocNguyenLieu;
			set => SetPropertyValue(nameof(NguonGocNguyenLieu), ref nguonGocNguyenLieu, value);
		}

		int soLuongNLTMTrongNuoc;
		[XafDisplayName("Số lượng NLTM trong nước"), ToolTip("")]
		public int SoLuongNLTMTrongNuoc {
			get => soLuongNLTMTrongNuoc;
			set => SetPropertyValue(nameof(SoLuongNLTMTrongNuoc), ref soLuongNLTMTrongNuoc, value);
		}

		int soLuongNLTMNhapKhau;
		[XafDisplayName("Số lượng NLTM nhập khẩu"), ToolTip("")]
		public int SoLuongNLTMNhapKhau{
			get => soLuongNLTMNhapKhau;
			set => SetPropertyValue(nameof(SoLuongNLTMNhapKhau), ref soLuongNLTMNhapKhau, value);
		}

		string sanLuongCheBien;
		[XafDisplayName("Sản lượng chế biến"), ToolTip("")]
		public string SanLuongCheBien {
			get => sanLuongCheBien;
			set => SetPropertyValue(nameof(SanLuongCheBien), ref sanLuongCheBien, value);
		}

		int giaTriXuatKhau;
		[XafDisplayName("Giá trị xuất khẩu"), ToolTip("")]
		public int GiaTriXuatKhau {
			get => giaTriXuatKhau;
			set => SetPropertyValue(nameof(GiaTriXuatKhau), ref giaTriXuatKhau, value);
		}

		ThiTruongTieuThu thiTruongTieuThu;
		[XafDisplayName("Thị trường tiêu thụ"), ToolTip("")]
		public ThiTruongTieuThu ThiTruongTieuThu {
			get => thiTruongTieuThu;
			set => SetPropertyValue(nameof(ThiTruongTieuThu), ref thiTruongTieuThu, value);
		}
	}
	public enum ThiTruongTieuThu
	{
		[XafDisplayName("Nội địa")] NOI_DIA,
		[XafDisplayName("Xuất khẩu")] XUAT_KHAU,
	}
}