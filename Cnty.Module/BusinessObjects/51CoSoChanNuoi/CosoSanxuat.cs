using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[DefaultClassOptions]
	[NavigationItem(R.MenuDanhmuc)]
	[ImageName("BO_Contact")]
	[DefaultProperty(nameof(TenCoso))]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	[XafDisplayName("Cơ sở sản xuất kinh doanh")]
	public class CosoSanxuat : BaseObject {
		public CosoSanxuat(Session session)
			: base(session) {
		}

		public override void AfterConstruction() {
			base.AfterConstruction();
		}

		string tenCoso;
		[XafDisplayName("Tên cơ sở"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenCoso {
			get => tenCoso;
			set => SetPropertyValue(nameof(TenCoso), ref tenCoso, value);
		}

		string diachi;
		[XafDisplayName("Địa chỉ"), ToolTip("")]
		public string Diachi {
			get => diachi;
			set => SetPropertyValue(nameof(Diachi), ref diachi, value);
		}

		string email;
		[XafDisplayName(""), ToolTip("")]
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

		bool caNhanSoHuu;
		[XafDisplayName("Cá nhân sở hữu"), ToolTip("")]
		public bool CaNhanSoHuu {
			get => caNhanSoHuu;
			set => SetPropertyValue(nameof(CaNhanSoHuu), ref caNhanSoHuu, value);
		}

		string quyMo;
		[XafDisplayName("Quy mô"), ToolTip("")]
		public string QuyMo {
			get => quyMo;
			set => SetPropertyValue(nameof(QuyMo), ref quyMo, value);
		}
	}
}