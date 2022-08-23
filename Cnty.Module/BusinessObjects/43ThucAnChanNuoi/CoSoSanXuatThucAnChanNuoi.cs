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
	[XafDisplayName("Cơ sở sản xuất TĂCN")]
	[NavigationItem(R.MenuThucAn)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class CoSoSanXuatThucAnChanNuoi : BaseObject {
		public CoSoSanXuatThucAnChanNuoi(Session session) : base(session) { }

		// Property region
		#region Properties

		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở sản xuất"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CosoSanxuat {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoSanxuat), ref cosoSanxuat, value);
		}

		CoQuanQuanLy coQuanCapGiayChungNhan;
		[XafDisplayName("Cơ quan cấp giấy chứng nhận"), ToolTip("")]
		public CoQuanQuanLy CoQuanCapGiayChungNhan {
			get => coQuanCapGiayChungNhan;
			set => SetPropertyValue(nameof(CoQuanCapGiayChungNhan), ref coQuanCapGiayChungNhan, value);
		}

		string soGiayChungNhan;
		[XafDisplayName("Số giấy chứng nhận"), ToolTip("")]
		public string SoGiayChungNhan {
			get => soGiayChungNhan;
			set => SetPropertyValue(nameof(SoGiayChungNhan), ref soGiayChungNhan, value);
		}

		DateTime ngayCap;
		[XafDisplayName("Ngày cấp"), ToolTip("")]
		public DateTime NgayCap {
			get => ngayCap;
			set => SetPropertyValue(nameof(NgayCap), ref ngayCap, value);
		}

		string congSuatThietKe;
		[XafDisplayName("Công suất thiết kế"), ToolTip("")]
		public string CongSuatThietKe {
			get => congSuatThietKe;
			set => SetPropertyValue(nameof(CongSuatThietKe), ref congSuatThietKe, value);
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