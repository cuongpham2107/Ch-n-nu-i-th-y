using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(TenPhepThu))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Phép thử nghiệm TĂCN")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class PhepThuThucAnChanNuoi : BaseObject {
		public PhepThuThucAnChanNuoi(Session session) : base(session) { }

		string tenPhepThu;
		[XafDisplayName("Tên phép thử"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenPhepThu {
			get => tenPhepThu;
			set => SetPropertyValue(nameof(TenPhepThu), ref tenPhepThu, value);
		}

		string moTa;
		[XafDisplayName("Mô tả"), ToolTip("")]
		public string MoTa {
			get => moTa;
			set => SetPropertyValue(nameof(MoTa), ref moTa, value);
		}
	}
}