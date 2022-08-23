using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(ToChuc))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Phạm vi tổ chức chứng nhận TĂCN")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class TCChungNhanTACN_PhamViDuocChiDinh : BaseObject {
		public TCChungNhanTACN_PhamViDuocChiDinh(Session session) : base(session) { }

		ToChucChungNhanHopQuy toChuc;
		[XafDisplayName("Tổ chức"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public ToChucChungNhanHopQuy ToChuc {
			get => toChuc;
			set => SetPropertyValue(nameof(ToChuc), ref toChuc, value);
		}

		CoQuanQuanLy coQuanChiDinh;
		[XafDisplayName("Cơ quan chỉ định"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
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

		DateTime biThuHoiNgay;
		[XafDisplayName("Ngày thu hồi"), ToolTip("")]
		public DateTime BiThuHoiNgay {
			get => biThuHoiNgay;
			set => SetPropertyValue(nameof(BiThuHoiNgay), ref biThuHoiNgay, value);
		}

		string phamVi;
		[XafDisplayName("Phạm vi"), ToolTip("")]
		public string PhamVi {
			get => phamVi;
			set => SetPropertyValue(nameof(PhamVi), ref phamVi, value);
		}
	}
}