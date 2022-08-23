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
	[XafDefaultProperty(nameof(Ten))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Kết quả nghiên cứu khoa học")]
	//[NavigationItem(R.MenuQuanLyDuLieu)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class KetQuaNghienCuuKhoaHoc : BaseObject {
		public KetQuaNghienCuuKhoaHoc(Session session) : base(session) { }

		// Property region
		#region Properties		
		string ten;
		[XafDisplayName("Tên nghiên cứu"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string Ten {
			get => ten;
			set => SetPropertyValue(nameof(Ten), ref ten, value);
		}

		string linhVuc;
		[XafDisplayName("Lĩnh vực"), ToolTip("")]
		public string LinhVuc {
			get => linhVuc;
			set => SetPropertyValue(nameof(LinhVuc), ref linhVuc, value);
		}

		string tomTatNghienCuu;
		[XafDisplayName("Tóm tắt nghiên cứu"), ToolTip("")]
		public string TomTatNghienCuu {
			get => tomTatNghienCuu;
			set => SetPropertyValue(nameof(TomTatNghienCuu), ref tomTatNghienCuu, value);
		}

		string ketQuaNoiBat;
		[XafDisplayName("Kết quả nổi bật"), ToolTip("")]
		public string KetQuaNoiBat {
			get => ketQuaNoiBat;
			set => SetPropertyValue(nameof(KetQuaNoiBat), ref ketQuaNoiBat, value);
		}

		string thongTinLienHe;
		[XafDisplayName("Thông tin liên hệ"), ToolTip("")]
		public string ThongTinLienHe {
			get => thongTinLienHe;
			set => SetPropertyValue(nameof(ThongTinLienHe), ref thongTinLienHe, value);
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