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
	[XafDefaultProperty(nameof(CoSoNhapKhau))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Cơ sở nhập khẩu TĂCN - Sản lượng TĂCN nhập khẩu")]
	[NavigationItem(R.MenuThucAn)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class ThucAnChanNuoiNhapKhau : BaseObject {
		public ThucAnChanNuoiNhapKhau(Session session) : base(session) { }


		// Property region
		#region Properties

		CosoSanxuat coSoNhapKhau;
		[XafDisplayName("Cơ sở nhập khẩu"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CoSoNhapKhau {
			get => coSoNhapKhau;
			set => SetPropertyValue(nameof(CoSoNhapKhau), ref coSoNhapKhau, value);
		}

		string kimNgachNhapKhau;
		[XafDisplayName("Kim nghạch nhập khẩu"), ToolTip("")]
		public string KimNgachNhapKhau {
			get => kimNgachNhapKhau;
			set => SetPropertyValue(nameof(KimNgachNhapKhau), ref kimNgachNhapKhau, value);
		}

		string khoiLuongNhapKhau;
		[XafDisplayName("Khối lượng nhập khẩu"), ToolTip("")]
		public string KhoiLuongNhapKhau {
			get => khoiLuongNhapKhau;
			set => SetPropertyValue(nameof(KhoiLuongNhapKhau), ref khoiLuongNhapKhau, value);
		}

		string nguonGocXuatXu;
		[XafDisplayName("Nguồn gốc xuất xứ"), ToolTip("")]
		public string NguonGocXuatXu {
			get => nguonGocXuatXu;
			set => SetPropertyValue(nameof(NguonGocXuatXu), ref nguonGocXuatXu, value);
		}

		ThucAnChanNuoi thucAnChanNuoiNhapKhau;
		[XafDisplayName("Thức ăn chăn nuôi nhập khẩu"), ToolTip("")]
		public ThucAnChanNuoi ThucAnChanNuoi {
			get => thucAnChanNuoiNhapKhau;
			set => SetPropertyValue(nameof(ThucAnChanNuoiNhapKhau), ref thucAnChanNuoiNhapKhau, value);
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