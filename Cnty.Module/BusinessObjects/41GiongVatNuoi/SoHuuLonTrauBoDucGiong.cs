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
	[XafDisplayName("TC/CN sở hữu trâu bò lợn đực giống")]
	[NavigationItem(R.MenuGiongVatNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class SoHuuLonTrauBoDucGiong : BaseObject {
		public SoHuuLonTrauBoDucGiong(Session session) : base(session) { }


		// Property region
		#region Properties

		CosoSanxuat cosoSanxuat;
		[XafDisplayName("Cơ sở sở hữu"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		//[Association("CosoSanxuat-SoHuuLonTrauBoDucGiongs")]
		public CosoSanxuat CosoSanxuat {
			get => cosoSanxuat;
			set => SetPropertyValue(nameof(CosoSanxuat), ref cosoSanxuat, value);
		}

		string ketQuaPhoiGiongHangNam;
		[XafDisplayName("Kết quả phối giống hàng năm"), ToolTip("")]
		public string KetQuaPhoiGiongHangNam {
			get => ketQuaPhoiGiongHangNam;
			set => SetPropertyValue(nameof(KetQuaPhoiGiongHangNam), ref ketQuaPhoiGiongHangNam, value);
		}

		LoaiDucGiong loaiDucGiong;
		[XafDisplayName("Loại đực giống"), ToolTip("")]
		public LoaiDucGiong LoaiDucGiong {
			get => loaiDucGiong;
			set => SetPropertyValue(nameof(LoaiDucGiong), ref loaiDucGiong, value);
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

	public enum LoaiDucGiong {
		[XafDisplayName("Lợn")] Lon = 0,
		[XafDisplayName("Trâu")] Trau = 1,
		[XafDisplayName("Bò")] Bo = 2,
	}
}