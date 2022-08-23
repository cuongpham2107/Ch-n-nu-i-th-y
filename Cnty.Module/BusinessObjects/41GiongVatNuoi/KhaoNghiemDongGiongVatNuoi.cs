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
	[XafDefaultProperty(nameof(CosoSanxuat))]
	[ImageName("BO_Contact")]
	[XafDisplayName("CS khảo nghiệm dòng giống vật nuôi")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class KhaoNghiemDongGiongVatNuoi : BaseObject {
		public KhaoNghiemDongGiongVatNuoi(Session session) : base(session) { }


		// Property region
		#region Properties
		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở khảo nghiệm"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		//[Association("CosoSanxuat-KhaoNghiemDongGiongVatNuois")]
		public CosoSanxuat CosoSanxuat {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoSanxuat), ref cosoSanxuat, value);
		}

		Giong giong;
		[XafDisplayName("Giống"), ToolTip("")]
		public Giong Giong {
			get => giong;
			set => SetPropertyValue(nameof(Giong), ref giong, value);
		}

		bool duocGiaoThucHienKiemDinh;
		[XafDisplayName("Được giao thực hiện kiểm định"), ToolTip("")]
		public bool DuocGiaoThucHienKiemDinh {
			get => duocGiaoThucHienKiemDinh;
			set => SetPropertyValue(nameof(DuocGiaoThucHienKiemDinh), ref duocGiaoThucHienKiemDinh, value);
		}

		int soLuongToiDaKhaoNghiemDuoc;
		[XafDisplayName("Số lượng khảo nghiệm"), ToolTip("")]
		public int SoLuongToiDaKhaoNghiemDuoc {
			get => soLuongToiDaKhaoNghiemDuoc;
			set => SetPropertyValue(nameof(SoLuongToiDaKhaoNghiemDuoc), ref soLuongToiDaKhaoNghiemDuoc, value);
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