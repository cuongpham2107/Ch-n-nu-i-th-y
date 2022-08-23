using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(CosoSanxuat))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("CSSX - Sản phẩm xử lý chất thải chăn nuôi")]
	[NavigationItem(R.MenuSanPhamXuLyChatThaiChanNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class CSSX_SoLuongSanPhamXuLyChatThai : BaseObject {
		public CSSX_SoLuongSanPhamXuLyChatThai(Session session) : base(session) { }


		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở sản xuất"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public CosoSanxuat CosoSanxuat {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoSanxuat), ref cosoSanxuat, value);
		}

		SanPhamXuLyChatThaiChanNuoi sanPhamXuLyChatThaiChanNuoi;
		[XafDisplayName("Sản phẩm xử lý chất thải chăn nuôi"), ToolTip("")]
		public SanPhamXuLyChatThaiChanNuoi SanPhamXuLyChatThaiChanNuoi {
			get => sanPhamXuLyChatThaiChanNuoi;
			set => SetPropertyValue(nameof(SanPhamXuLyChatThaiChanNuoi), ref sanPhamXuLyChatThaiChanNuoi, value);
		}

		string soLuong;
		[XafDisplayName("Số lượng"), ToolTip("")]
		public string SoLuong {
			get => soLuong;
			set => SetPropertyValue(nameof(SoLuong), ref soLuong, value);
		}

		TieuChuanQuocGia tieuChuanCongBoApDung;
		[XafDisplayName("Tiêu chuẩn công bố áp dụng"), ToolTip("")]
		public TieuChuanQuocGia TieuChuanCongBoApDung {
			get => tieuChuanCongBoApDung;
			set => SetPropertyValue(nameof(TieuChuanCongBoApDung), ref tieuChuanCongBoApDung, value);
		}
	}
}