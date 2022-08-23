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
	[XafDefaultProperty(nameof(TenDieuUoc))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Điều ước quốc tế")]
	[NavigationItem(R.MenuThiTruongSanPham)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class DieuUocQuocTe : BaseObject {
		public DieuUocQuocTe(Session session) : base(session) { }


		// Property region
		#region Properties

		NhomDieuUoc nhomDieuUoc;
		[XafDisplayName("Nhóm điều ước"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public NhomDieuUoc NhomDieuUoc {
			get => nhomDieuUoc;
			set => SetPropertyValue(nameof(NhomDieuUoc), ref nhomDieuUoc, value);
		}

		string kyHieu;
		[XafDisplayName("Ký hiệu"), ToolTip("")]
		public string KyHieu {
			get => kyHieu;
			set => SetPropertyValue(nameof(KyHieu), ref kyHieu, value);
		}

		string tenDieuUoc;
		[XafDisplayName("Tên điều ước"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenDieuUoc {
			get => tenDieuUoc;
			set => SetPropertyValue(nameof(TenDieuUoc), ref tenDieuUoc, value);
		}

		string moTa;
		[XafDisplayName("Mô tả"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string MoTa {
			get => moTa;
			set => SetPropertyValue(nameof(MoTa), ref moTa, value);
		}

		QuocGia nuocApDung;
		[XafDisplayName("Nước áp dụng"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public QuocGia NuocApDung {
			get => nuocApDung;
			set => SetPropertyValue(nameof(nuocApDung), ref nuocApDung, value);
		}
		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}

	public enum NhomDieuUoc
	{
		[XafDisplayName("Hiệp định về việc áp dụng các biện pháp kiểm dịch động vật (SPS) và các cam kết thương mại")] HIEP_DINH_SPS_VA_CAC_CAM_KET_THUONG_MAI,
		[XafDisplayName("Hiệp định về việc áp dụng hàng rào kỹ thuật với thương mại (TPT)")] HIEP_DINH_TPT,
		[XafDisplayName("Văn bản quy định về biện pháp kiểm dịch động vật (SPS) và hàng hàng rào kỹ thuật với thương mại (TPT)")] VAN_BAN_SPS_VA_HANG_RAO_TPT,
	}
}