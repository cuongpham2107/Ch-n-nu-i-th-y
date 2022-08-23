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
	[XafDisplayName("TC/CN mua bán con giống, tinh, phôi, ấu trùng")]
	[NavigationItem(R.MenuGiongVatNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class MuaBanConGiongTinhPhoiTrungAuTrung : BaseObject {
		public MuaBanConGiongTinhPhoiTrungAuTrung(Session session) : base(session) { }


		// Property region
		#region Properties
		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sơ sản xuất"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		//[Association("CosoSanxuat-MuaBanConGiongTinhPhoiTrungAuTrungs")]
		public CosoSanxuat CosoSanxuat {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoSanxuat), ref cosoSanxuat, value);
		}

		bool daDuocKiemDich;
		[XafDisplayName("Đã được kiểm dịch"), ToolTip("")]
		public bool DaDuocKiemDich {
			get => daDuocKiemDich;
			set => SetPropertyValue(nameof(DaDuocKiemDich), ref daDuocKiemDich, value);
		}

		bool daDuocKiemTraDanhGiaChatLuong;
		[XafDisplayName("Đã được kiểm tra đánh giá chất lượng"), ToolTip("")]
		public bool DaDuocKiemTraDanhGiaChatLuong {
			get => daDuocKiemTraDanhGiaChatLuong;
			set => SetPropertyValue(nameof(DaDuocKiemTraDanhGiaChatLuong), ref daDuocKiemTraDanhGiaChatLuong, value);
		}

		Giong giong;
		[XafDisplayName(""), ToolTip("")]
		public Giong Giong {
			get => giong;
			set => SetPropertyValue(nameof(Giong), ref giong, value);
		}

		LoaiGiong loaiGiong;
		[XafDisplayName("Loại giống"), ToolTip("")]
		public LoaiGiong LoaiGiong {
			get => loaiGiong;
			set => SetPropertyValue(nameof(LoaiGiong), ref loaiGiong, value);
		}

		int soLuongTrongMotNam;
		[XafDisplayName("Số lượng trong 1 năm"), ToolTip("")]
		public int SoLuongTrongMotNam {
			get => soLuongTrongMotNam;
			set => SetPropertyValue(nameof(SoLuongTrongMotNam), ref soLuongTrongMotNam, value);
		}
		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}
	public enum LoaiGiong {
		[XafDisplayName("Lợn")] Lon = 0,
		[XafDisplayName("Trâu")] Trau = 1,
		[XafDisplayName("Bò")] Bo = 2,
	}
}