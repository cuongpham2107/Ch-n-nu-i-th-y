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
	[XafDisplayName("TC/CN thu thập nguồn gen")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class ThuThapNguonGen : BaseObject {
		public ThuThapNguonGen(Session session) : base(session) { }


		// Property region
		#region Properties

		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở thu thập"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CosoSanxuat {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoSanxuat), ref cosoSanxuat, value);
		}

		string chiTieuSinhHoc;
		[XafDisplayName("Chỉ tiêu sinh học"), ToolTip("")]
		public string ChiTieuSinhHoc {
			get => chiTieuSinhHoc;
			set => SetPropertyValue(nameof(ChiTieuSinhHoc), ref chiTieuSinhHoc, value);
		}

		string diaDiemThuThap;
		[XafDisplayName("Địa điểm thu thập"), ToolTip("")]
		public string DiaDiemThuThap {
			get => diaDiemThuThap;
			set => SetPropertyValue(nameof(DiaDiemThuThap), ref diaDiemThuThap, value);
		}

		string giaTriSuDung;
		[XafDisplayName("Giá trị sử dụng"), ToolTip("")]
		public string GiaTriSuDung {
			get => giaTriSuDung;
			set => SetPropertyValue(nameof(GiaTriSuDung), ref giaTriSuDung, value);
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