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
	[XafDefaultProperty(nameof(CosoKhaithac))]
	[ImageName("BO_Contact")]
	[XafDisplayName("TC/CN khai thác phát triển nguồn gen")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class KhaiThacPhatTrienNguonGen : BaseObject {
		public KhaiThacPhatTrienNguonGen(Session session) : base(session) { }


		// Property region
		#region Properties

		CosoSanxuat cosoKhaithac;
		[XafDisplayName("Cơ sở khai thác"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CosoKhaithac {
			get => cosoKhaithac;
			set => SetPropertyValue(nameof(CosoKhaithac), ref cosoKhaithac, value);
		}

		string diaDiemKhaiThacPhatTrien;
		[XafDisplayName("Địa điểm khai thác phát triển"), ToolTip("")]
		public string DiaDiemKhaiThacPhatTrien {
			get => diaDiemKhaiThacPhatTrien;
			set => SetPropertyValue(nameof(DiaDiemKhaiThacPhatTrien), ref diaDiemKhaiThacPhatTrien, value);
		}

		NguonGenGiongVatNuoi nguonGen;
		[XafDisplayName("Nguồn gen"), ToolTip("")]
		public NguonGenGiongVatNuoi NguonGen {
			get => nguonGen;
			set => SetPropertyValue(nameof(NguonGen), ref nguonGen, value);
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