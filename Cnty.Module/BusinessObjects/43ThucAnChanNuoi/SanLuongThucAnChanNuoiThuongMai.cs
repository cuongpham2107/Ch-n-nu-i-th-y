using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(CoSoMuaBanThucAn))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Cơ sở mua bán TĂCN - Sản lượng TĂCN thương mại")]
	[NavigationItem(R.MenuThucAn)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class SanLuongThucAnChanNuoiThuongMai : BaseObject {
		public SanLuongThucAnChanNuoiThuongMai(Session session) : base(session) { }


		CosoSanxuat coSoMuaBanThucAn;
		[XafDisplayName("Cơ sở mua bán thức ăn"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CoSoMuaBanThucAn {
			get => coSoMuaBanThucAn;
			set => SetPropertyValue(nameof(CoSoMuaBanThucAn), ref coSoMuaBanThucAn, value);
		}

		LoaiVatNuoi doiTuongVatNuoiSuDung;
		[XafDisplayName("Loại vật nuôi"), ToolTip("")]
		public LoaiVatNuoi DoiTuongVatNuoiSuDung {
			get => doiTuongVatNuoiSuDung;
			set => SetPropertyValue(nameof(DoiTuongVatNuoiSuDung), ref doiTuongVatNuoiSuDung, value);
		}

		ThucAnChanNuoi thucAnChanNuoi;
		[XafDisplayName(""), ToolTip("")]
		public ThucAnChanNuoi ThucAnChanNuoi {
			get => thucAnChanNuoi;
			set => SetPropertyValue(nameof(ThucAnChanNuoi), ref thucAnChanNuoi, value);
		}

		string sanLuong;
		[XafDisplayName("Sản lượng"), ToolTip("")]
		public string SanLuong {
			get => sanLuong;
			set => SetPropertyValue(nameof(SanLuong), ref sanLuong, value);
		}
	}
}