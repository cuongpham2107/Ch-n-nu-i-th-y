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
	[XafDefaultProperty(nameof(CosoBaoton))]
	[ImageName("BO_Contact")]
	[XafDisplayName("TC/CN bảo tồn nguồn gen giống vật nuôi")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class BaoTonNguonGenGionVatNuoi : BaseObject {
		public BaoTonNguonGenGionVatNuoi(Session session) : base(session) { }


		// Property region
		#region Properties

		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở bảo tồn"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CosoBaoton {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoBaoton), ref cosoSanxuat, value);
		}

		NguonGenGiongVatNuoi nguonGen;
		[XafDisplayName("Nguồn gen"), ToolTip("")]
		public NguonGenGiongVatNuoi NguonGen {
			get => nguonGen;
			set => SetPropertyValue(nameof(NguonGen), ref nguonGen, value);
		}

		string diaDiemBaoTon;
		[XafDisplayName("Địa điểm bảo tồn"), ToolTip("")]
		public string DiaDiemBaoTon {
			get => diaDiemBaoTon;
			set => SetPropertyValue(nameof(DiaDiemBaoTon), ref diaDiemBaoTon, value);
		}

		string phuongThucBaoTon;
		[XafDisplayName("Phương thức bảo tồn"), ToolTip("")]
		public string PhuongThucBaoTon {
			get => phuongThucBaoTon;
			set => SetPropertyValue(nameof(PhuongThucBaoTon), ref phuongThucBaoTon, value);
		}

		int soLuong;
		[XafDisplayName("Số lượng"), ToolTip("")]
		public int SoLuong {
			get => soLuong;
			set => SetPropertyValue(nameof(SoLuong), ref soLuong, value);
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