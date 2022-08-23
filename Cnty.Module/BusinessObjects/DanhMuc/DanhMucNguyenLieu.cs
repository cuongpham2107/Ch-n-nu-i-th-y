using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(Ten))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	//Điều 4hi
	[XafDisplayName("Nguyên liệu sử dụng trong TĂCN")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class DanhMucNguyenLieu : BaseObject {
		public DanhMucNguyenLieu(Session session) : base(session) { }

		string ten;
		[XafDisplayName("Tên"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string Ten {
			get => ten;
			set => SetPropertyValue(nameof(Ten), ref ten, value);
		}

		PhanLoaiNguyenLieu phanLoai;
		[XafDisplayName("Phân loại"), ToolTip("")]
		public PhanLoaiNguyenLieu PhanLoai {
			get => phanLoai;
			set => SetPropertyValue(nameof(PhanLoai), ref phanLoai, value);
		}

		string ghiChu;
		[XafDisplayName("Ghi chú"), ToolTip("")]
		public string GhiChu {
			get => ghiChu;
			set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
		}

		bool camSuDung;
		[XafDisplayName("Cấm sử dụng"), ToolTip("")]
		public bool CamSuDung {
			get => camSuDung;
			set => SetPropertyValue(nameof(CamSuDung), ref camSuDung, value);
		}
	}

	public enum PhanLoaiNguyenLieu {
		[XafDisplayName("Hóa chất")] HOA_CHAT,
		[XafDisplayName("Sản phẩm sinh học")] SAN_PHAM_SINH_HOC,
		[XafDisplayName("Vi sinh vật")] VI_SINH_VAT,
		[XafDisplayName("Khác")] KHAC,
	}
}