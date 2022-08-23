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
	[XafDefaultProperty(nameof(TenCoQuan))]
	[ImageName("BO_Contact")]
	//Cơ quan quản lý, cấp giấy chứng nhận cho các cơ sở CNTY
	[XafDisplayName("Cơ quan quản lý, cấp phép")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class CoQuanQuanLy : BaseObject {
		public CoQuanQuanLy(Session session) : base(session) { }


		// Property region
		#region Properties

		string tenCoQuan;
		[XafDisplayName("Tên cơ quan"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenCoQuan {
			get => tenCoQuan;
			set => SetPropertyValue(nameof(TenCoQuan), ref tenCoQuan, value);
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