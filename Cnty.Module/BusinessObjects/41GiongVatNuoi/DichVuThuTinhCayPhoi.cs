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
	//Điều 4.1c
	[XafDisplayName("TC/CN làm dịch vụ thụ tinh, cấy phôi")]
	[NavigationItem(R.MenuGiongVatNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class DichVuThuTinhCayPhoi : BaseObject {
		public DichVuThuTinhCayPhoi(Session session) : base(session) { }


		// Property region
		#region Properties
		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở sản xuất"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		//[Association("CosoSanxuat-DichVuThuTinhCayPhois")]
		public CosoSanxuat CosoSanxuat {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoSanxuat), ref cosoSanxuat, value);
		}

		DichVu dichVu;
		[XafDisplayName("Dịch vụ"), ToolTip("")]
		public DichVu DichVu {
			get => dichVu;
			set => SetPropertyValue(nameof(DichVu), ref dichVu, value);
		}

		string soLieuTinhPhoiDuocPhoiCayTrongMotNam;
		[XafDisplayName("Số liệu tinh phôi được cấy trong một năm"), ToolTip("")]
		public string SoLieuTinhPhoiDuocPhoiCayTrongMotNam {
			get => soLieuTinhPhoiDuocPhoiCayTrongMotNam;
			set => SetPropertyValue(nameof(SoLieuTinhPhoiDuocPhoiCayTrongMotNam), ref soLieuTinhPhoiDuocPhoiCayTrongMotNam, value);
		}
		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}

	public enum DichVu {
		[XafDisplayName("Thụ tinh nhân tạo")] ThuTinhNhanTao,
		[XafDisplayName("Cấy truyền phôi giống")] CayTruyenPhoiGiong,
	}
}