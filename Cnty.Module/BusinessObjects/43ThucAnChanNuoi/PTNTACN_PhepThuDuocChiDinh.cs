using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(PhongThuNghiem))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Phép thử được chỉ định cho phòng thử nghiệm TĂCN")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class PTNTACN_PhepThuDuocChiDinh : BaseObject {
		public PTNTACN_PhepThuDuocChiDinh(Session session) : base(session) { }

		PhongThuNghiemTACN phongThuNghiem;
		[XafDisplayName("Phòng thử nghiệm"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public PhongThuNghiemTACN PhongThuNghiem {
			get => phongThuNghiem;
			set => SetPropertyValue(nameof(PhongThuNghiem), ref phongThuNghiem, value);
		}

		PhepThuThucAnChanNuoi phepThu;
		[XafDisplayName("Phép thử"), ToolTip("")]
		public PhepThuThucAnChanNuoi PhepThu {
			get => phepThu;
			set => SetPropertyValue(nameof(PhepThu), ref phepThu, value);
		}

		CoQuanQuanLy coQuanChiDinh;
		[XafDisplayName("Cơ quan chỉ định"), ToolTip("")]
		public CoQuanQuanLy CoQuanChiDinh {
			get => coQuanChiDinh;
			set => SetPropertyValue(nameof(CoQuanChiDinh), ref coQuanChiDinh, value);
		}

		DateTime ngayChiDinh;
		[XafDisplayName("Ngày chỉ định"), ToolTip("")]
		public DateTime NgayChiDinh {
			get => ngayChiDinh;
			set => SetPropertyValue(nameof(NgayChiDinh), ref ngayChiDinh, value);
		}

		DateTime ngayHetHan;
		[XafDisplayName("Ngày hết hạn"), ToolTip("")]
		public DateTime NgayHetHan {
			get => ngayHetHan;
			set => SetPropertyValue(nameof(NgayHetHan), ref ngayHetHan, value);
		}


	}
}