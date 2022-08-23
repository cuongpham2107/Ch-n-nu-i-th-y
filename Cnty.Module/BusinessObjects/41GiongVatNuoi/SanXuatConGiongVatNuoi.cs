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
	[XafDisplayName("TC/CN sản xuất con giống vật nuôi")]
	[NavigationItem(R.MenuGiongVatNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class SanXuatConGiongVatNuoi : BaseObject {
		public SanXuatConGiongVatNuoi(Session session) : base(session) { }


		// Property region
		#region Properties

		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở sản xuất"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		//[Association("CosoSanxuat-SanXuatConGiongVatNuois")]
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

		DinhMucKinhTeKyThuat dinhMucKinhTeKyThuat;
		[XafDisplayName("Định mức kinh tế kỹ thuật"), ToolTip("")]
		public DinhMucKinhTeKyThuat DinhMucKinhTeKyThuat {
			get => dinhMucKinhTeKyThuat;
			set => SetPropertyValue(nameof(DinhMucKinhTeKyThuat), ref dinhMucKinhTeKyThuat, value);
		}

		TieuChuanQuocGia tieuChuanQuocGia;
		[XafDisplayName("Tiêu chuẩn quốc gia"), ToolTip("")]
		public TieuChuanQuocGia TieuChuanQuocGia {
			get => tieuChuanQuocGia;
			set => SetPropertyValue(nameof(TieuChuanQuocGia), ref tieuChuanQuocGia, value);
		}

		string quyMo;
		[XafDisplayName("Quy mô"), ToolTip("")]
		public string QuyMo {
			get => quyMo;
			set => SetPropertyValue(nameof(QuyMo), ref quyMo, value);
		}

		string capGiong;
		[XafDisplayName("Cấp giống"), ToolTip("")]
		public string CapGiong {
			get => capGiong;
			set => SetPropertyValue(nameof(CapGiong), ref capGiong, value);
		}

		double soLuong;
		[XafDisplayName("Số lượng"), ToolTip("")]
		public double SoLuong {
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