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
	[XafDefaultProperty(nameof(TenGiong))]
	[ImageName("BO_Contact")]
	//Cho điều 4.1 Dữ liệu về giống vật nuôi
	[XafDisplayName("Giống vật nuôi")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class Giong : BaseObject {
		public Giong(Session session) : base(session) { }

		// Property region
		#region Properties
		string tenGiong;
		[XafDisplayName("Tên giống"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenGiong {
			get => tenGiong;
			set => SetPropertyValue(nameof(TenGiong), ref tenGiong, value);
		}

		bool canBaoTon;
		[XafDisplayName("Cần bảo tồn"), ToolTip("")]
		public bool CanBaoTon {
			get => canBaoTon;
			set => SetPropertyValue(nameof(CanBaoTon), ref canBaoTon, value);
		}

		bool camXuaKhau;
		[XafDisplayName("Cấm xuất khẩu"), ToolTip("")]
		public bool CamXuaKhau {
			get => camXuaKhau;
			set => SetPropertyValue(nameof(CamXuaKhau), ref camXuaKhau, value);
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