using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(CoSoChanNuoi))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Điều kiện chăn nuôi của TC/CN chăn nuôi")]
	[NavigationItem(R.MenuCoSoChanNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class TCCNCN_DieuKienChanNuoi : BaseObject {
		public TCCNCN_DieuKienChanNuoi(Session session) : base(session) { }

		CosoSanxuat coSoChanNuoi;
		[XafDisplayName("Cơ sở chăn nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CoSoChanNuoi {
			get => coSoChanNuoi;
			set => SetPropertyValue(nameof(CoSoChanNuoi), ref coSoChanNuoi, value);
		}

		bool benhDichDuocGiamSat;
		[XafDisplayName("Bệnh dịch được giám sát"), ToolTip("")]
		public bool BenhDichDuocGiamSat {
			get => benhDichDuocGiamSat;
			set => SetPropertyValue(nameof(BenhDichDuocGiamSat), ref benhDichDuocGiamSat, value);
		}

		string bienPhapBaoDamAnToanSinhHoc;
		[XafDisplayName("Biện pháp đảm bảo an toàn sinh học"), ToolTip("")]
		public string BienPhapBaoDamAnToanSinhHoc {
			get => bienPhapBaoDamAnToanSinhHoc;
			set => SetPropertyValue(nameof(BienPhapBaoDamAnToanSinhHoc), ref bienPhapBaoDamAnToanSinhHoc, value);
		}

		bool keKhaiHoatDongChanNuoi;
		[XafDisplayName("Kê khai hoạt động chăn nuôi"), ToolTip("")]
		public bool KeKhaiHoatDongChanNuoi {
			get => keKhaiHoatDongChanNuoi;
			set => SetPropertyValue(nameof(KeKhaiHoatDongChanNuoi), ref keKhaiHoatDongChanNuoi, value);
		}

		double khoangCachAnToan;
		[XafDisplayName("Khoảng cách an toàn"), ToolTip("")]
		public double KhoangCachAnToan {
			get => khoangCachAnToan;
			set => SetPropertyValue(nameof(KhoangCachAnToan), ref khoangCachAnToan, value);
		}

		string matDoChanNuoi;
		[XafDisplayName("Mật độ chăn nuôi"), ToolTip("")]
		public string MatDoChanNuoi {
			get => matDoChanNuoi;
			set => SetPropertyValue(nameof(MatDoChanNuoi), ref matDoChanNuoi, value);
		}

		string quyMoChanNuoi;
		[XafDisplayName("Quy mô chăn nuôi"), ToolTip("")]
		public string QuyMoChanNuoi {
			get => quyMoChanNuoi;
			set => SetPropertyValue(nameof(QuyMoChanNuoi), ref quyMoChanNuoi, value);
		}
	}
	
}