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
	[XafDisplayName("Giấy chứng nhận của TC/CN chăn nuôi")]
	[NavigationItem(R.MenuCoSoChanNuoi)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class TCCNCN_GiayChungNhan : BaseObject {
		public TCCNCN_GiayChungNhan(Session session) : base(session) { }


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

		CosoSanxuat coSoChanNuoi;
		[XafDisplayName("Cơ sở chăn nuôi"), ToolTip("")]
		public CosoSanxuat CoSoChanNuoi {
			get => coSoChanNuoi;
			set => SetPropertyValue(nameof(CoSoChanNuoi), ref coSoChanNuoi, value);
		}

		LoaiGiayChungNhan loaiGiayChungNhan;
		[XafDisplayName("Loại giấy chứng nhận"), ToolTip("")]
		public LoaiGiayChungNhan LoaiGiayChungNhan {
			get => loaiGiayChungNhan;
			set => SetPropertyValue(nameof(LoaiGiayChungNhan), ref loaiGiayChungNhan, value);
		}


		DateTime ngayThuHoi;
		[XafDisplayName("Ngày thu hồi"), ToolTip("")]
		public DateTime NgayThuHoi {
			get => ngayThuHoi;
			set => SetPropertyValue(nameof(NgayThuHoi), ref ngayThuHoi, value);
		}
	}

	public enum LoaiGiayChungNhan {
		[XafDisplayName("Đủ điều kiện chăn nuôi")] DU_DIEU_KIEN_CHAN_NUOI,
		[XafDisplayName("Thực hành chăn nuôi tốt")] THUC_HANH_CHAN_NUOI_TOT,
		[XafDisplayName("Trai chăn nuôi an toàn sinh học")] TRAI_CHAN_NUOI_AN_TOAN_SINH_HOC,
	}
}