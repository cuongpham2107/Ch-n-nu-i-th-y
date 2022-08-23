using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[XafDefaultProperty(nameof(TenToChuc))]
	[DefaultClassOptions]
	[ImageName("BO_Contact")]
	[XafDisplayName("Tổ chức chứng nhận hợp quy")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class ToChucChungNhanHopQuy : BaseObject {
		public ToChucChungNhanHopQuy(Session session) : base(session) { }

		string tenToChuc;
		[XafDisplayName("Tên tổ chức"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenToChuc {
			get => tenToChuc;
			set => SetPropertyValue(nameof(TenToChuc), ref tenToChuc, value);
		}

		string diaChi;
		[XafDisplayName("Địa chỉ"), ToolTip("")]
		public string DiaChi {
			get => diaChi;
			set => SetPropertyValue(nameof(DiaChi), ref diaChi, value);
		}

		string email;
		[XafDisplayName("Email"), ToolTip("")]
		public string Email {
			get => email;
			set => SetPropertyValue(nameof(Email), ref email, value);
		}

		string soDienThoai;
		[XafDisplayName("Số điện thoại"), ToolTip("")]
		public string SoDienThoai {
			get => soDienThoai;
			set => SetPropertyValue(nameof(SoDienThoai), ref soDienThoai, value);
		}
	}
}