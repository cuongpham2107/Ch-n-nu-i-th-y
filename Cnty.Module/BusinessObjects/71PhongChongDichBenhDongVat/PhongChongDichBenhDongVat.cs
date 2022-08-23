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
	[XafDefaultProperty(nameof(BenhDich))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Phòng chống dịch bệnh động vật")]
	[NavigationItem(R.MenuPhongChongDichBenh)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class PhongChongDichBenhDongVat : BaseObject {
		public PhongChongDichBenhDongVat(Session session) : base(session) { }

		// Property region
		#region Properties

		BenhDich benhDich;
		[XafDisplayName("Tên dịch bệnh"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public BenhDich BenhDich {
			get => benhDich;
			set => SetPropertyValue(nameof(BenhDich), ref benhDich, value);
		}

		LoaiVatNuoi loaiVatNuoi;
		[XafDisplayName("Đối tượng vật nuôi"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public LoaiVatNuoi LoaiVatNuoi {
			get => loaiVatNuoi;
			set => SetPropertyValue(nameof(LoaiVatNuoi), ref loaiVatNuoi, value);
		}

		VungChanNuoi vungXayRaDichBenh;
		[XafDisplayName("Nơi xảy ra dịch bệnh"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public VungChanNuoi VungXayRaDichBenh {
			get => vungXayRaDichBenh;
			set => SetPropertyValue(nameof(VungXayRaDichBenh), ref vungXayRaDichBenh, value);
		}

		int soLuongVatNuoiThietHai;
		[XafDisplayName("Số lượng vật nuôi thiệt hại"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public int SoLuongVatNuoiThietHai {
			get => soLuongVatNuoiThietHai;
			set => SetPropertyValue(nameof(SoLuongVatNuoiThietHai), ref soLuongVatNuoiThietHai, value);
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