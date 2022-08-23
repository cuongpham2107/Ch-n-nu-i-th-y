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
	[XafDefaultProperty(nameof(VungChanNuoi))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Vùng chăn nuôi an toàn dịch bệnh")]
	[NavigationItem(R.MenuPhongChongDichBenh)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class VungChanNuoiAnToanDichBenh : BaseObject {
		public VungChanNuoiAnToanDichBenh(Session session) : base(session) { }


		// Property region
		#region Properties

		VungChanNuoi vungChanNuoi;
		[XafDisplayName("Vùng chăn nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public VungChanNuoi VungChanNuoi {
			get => vungChanNuoi;
			set => SetPropertyValue(nameof(VungChanNuoi), ref vungChanNuoi, value);
		}

		LoaiVatNuoi vatNuoi;
		[XafDisplayName("Đối tượng vật nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public LoaiVatNuoi VatNuoi {
			get => vatNuoi;
			set => SetPropertyValue(nameof(VatNuoi), ref vatNuoi, value);
		}

		string quyMoChanNuoi;
		[XafDisplayName("Quy mô chăn nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string QuyMoChanNuoi {
			get => quyMoChanNuoi;
			set => SetPropertyValue(nameof(QuyMoChanNuoi), ref quyMoChanNuoi, value);
		}

		BenhDich benhDichDuocChungNhan;
		[XafDisplayName("Bệnh (dịch) được chứng nhận"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public BenhDich BenhDichDuocChungNhan {
			get => benhDichDuocChungNhan;
			set => SetPropertyValue(nameof(BenhDichDuocChungNhan), ref benhDichDuocChungNhan, value);
		}

		string bienPhapKiemSoatAnToanSinhHoc;
		[XafDisplayName("Biện pháp kiểm soát an toàn sinh học"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string BienPhapKiemSoatAnToanSinhHoc {
			get => bienPhapKiemSoatAnToanSinhHoc;
			set => SetPropertyValue(nameof(BienPhapKiemSoatAnToanSinhHoc), ref bienPhapKiemSoatAnToanSinhHoc, value);
		}

		string soGiayChungNhan;
		[XafDisplayName("Số giấy chứng nhận"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string SoGiayChungNhan {
			get => soGiayChungNhan;
			set => SetPropertyValue(nameof(SoGiayChungNhan), ref soGiayChungNhan, value);
		}

		DateTime ngayCap;
		[XafDisplayName("Ngày cấp"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public DateTime NgayCap {
			get => ngayCap;
			set => SetPropertyValue(nameof(NgayCap), ref ngayCap, value);
		}

		DateTime? biThuHoiNgay;
		[XafDisplayName("Đã bị thu hồi giấy CN ngày"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public DateTime? BiThuHoiNgay {
			get => biThuHoiNgay;
			set => SetPropertyValue(nameof(BiThuHoiNgay), ref biThuHoiNgay, value);
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