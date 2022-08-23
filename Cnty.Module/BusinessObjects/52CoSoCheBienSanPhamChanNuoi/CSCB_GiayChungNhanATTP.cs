using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[DefaultClassOptions]
	[XafDefaultProperty(nameof(SoGiayChungNhan))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Giấy chứng nhận ATTP của CSCB")]
	[NavigationItem(R.MenuCoSoChanNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class CSCB_GiayChungNhanATTP : BaseObject {
		public CSCB_GiayChungNhanATTP(Session session) : base(session) { }


		string soGiayChungNhan;
		[XafDisplayName("Số giấy chứng nhận"), ToolTip("")]
		public string SoGiayChungNhan {
			get => soGiayChungNhan;
			set => SetPropertyValue(nameof(SoGiayChungNhan), ref soGiayChungNhan, value);
		}

		DateTime ngayCap;
		[XafDisplayName("Ngày cấp"), ToolTip("")]
		public DateTime NgayCap {
			get => ngayCap;
			set => SetPropertyValue(nameof(NgayCap), ref ngayCap, value);
		}

		CosoSanxuat coSoCheBien;
		[XafDisplayName("Cơ sở chế biến"), ToolTip("")]
		public CosoSanxuat CoSoCheBien {
			get => coSoCheBien;
			set => SetPropertyValue(nameof(CoSoCheBien), ref coSoCheBien, value);
		}

		CoQuanQuanLy coQuanCap;
		[XafDisplayName("Loại giấy chứng nhận"), ToolTip("")]
		public CoQuanQuanLy CoQuanCap {
			get => coQuanCap;
			set => SetPropertyValue(nameof(LoaiGiayChungNhan), ref coQuanCap, value);
		}


		DateTime ngayThuHoi;
		[XafDisplayName("Ngày thu hồi"), ToolTip("")]
		public DateTime NgayThuHoi {
			get => ngayThuHoi;
			set => SetPropertyValue(nameof(NgayThuHoi), ref ngayThuHoi, value);
		}
	}
}