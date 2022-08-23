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
	[XafDisplayName("TC/CN SX tinh, phôi, ấu trùng, cơ sở ấp trứng")]
	[NavigationItem(R.MenuGiongVatNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class TinhPhoiAuTrungCoSoApTrung : BaseObject {
		public TinhPhoiAuTrungCoSoApTrung(Session session) : base(session) { }


		// Property region
		#region Properties
		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở sản xuất"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		//[Association("CosoSanxuat-SanXuatTinhPhoiAuTrungCoSoApTrungs")]
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

		string quyMo;
		[XafDisplayName("Quy mô"), ToolTip("")]
		public string QuyMo {
			get => quyMo;
			set => SetPropertyValue(nameof(QuyMo), ref quyMo, value);
		}

		SanPhamTinhPhoi sanPham;
		[XafDisplayName("Sản phẩm"), ToolTip("")]
		public SanPhamTinhPhoi SanPham {
			get => sanPham;
			set => SetPropertyValue(nameof(SanPham), ref sanPham, value);
		}
		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}

	public enum SanPhamTinhPhoi {
		[XafDisplayName("Tinh")] Tinh = 0,
		[XafDisplayName("Phôi")] Phoi = 1,
		[XafDisplayName("Ấu trùng")] AuTrung = 2,
		[XafDisplayName("Cơ sở ấp trứng")] CoSoApTrung = 3
	}
}