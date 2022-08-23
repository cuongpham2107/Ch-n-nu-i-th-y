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
	[XafDisplayName("TC/CN chăn nuôi")]
	[NavigationItem(R.MenuCoSoChanNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class TCCNCN_GiongVatNuoi : BaseObject {
		public TCCNCN_GiongVatNuoi(Session session) : base(session) { }

		CosoSanxuat coSoChanNuoi;
		[XafDisplayName("Cơ sở chăn nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CoSoChanNuoi {
			get => coSoChanNuoi;
			set => SetPropertyValue(nameof(CoSoChanNuoi), ref coSoChanNuoi, value);
		}

		Giong giong;
		[XafDisplayName("Giống"), ToolTip("")]
		public Giong Giong {
			get => giong;
			set => SetPropertyValue(nameof(Giong), ref giong, value);
		}

		LoaiVatNuoi loaiVatNuoi;
		[XafDisplayName("Loại vật nuôi"), ToolTip("")]
		public LoaiVatNuoi LoaiVatNuoi {
			get => loaiVatNuoi;
			set => SetPropertyValue(nameof(LoaiVatNuoi), ref loaiVatNuoi, value);
		}

		string phuongThucChanNuoi;
		[XafDisplayName("Phương thức chăn nuôi"), ToolTip("")]
		public string PhuongThucChanNuoi {
			get => phuongThucChanNuoi;
			set => SetPropertyValue(nameof(PhuongThucChanNuoi), ref phuongThucChanNuoi, value);
		}

		string sanLuong;
		[XafDisplayName("Sản lượng"), ToolTip("")]
		public string SanLuong {
			get => sanLuong;
			set => SetPropertyValue(nameof(SanLuong), ref sanLuong, value);
		}

		int soLuongVatNuoi;
		[XafDisplayName("Số lượng vật nuôi"), ToolTip("")]
		public int SoLuongVatNuoi {
			get => soLuongVatNuoi;
			set => SetPropertyValue(nameof(SoLuongVatNuoi), ref soLuongVatNuoi, value);
		}

		[XafDisplayName("Ngày thống kê"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public DateTime NgayThongKe { get; set; }
	}
}