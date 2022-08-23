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
	[XafDefaultProperty(nameof(TenBenhDich))]
	[ImageName("BO_Contact")]
	//Cho Điều 6 và 7.2
	[XafDisplayName("Bệnh dịch")]
	[NavigationItem(R.MenuDanhmuc)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class BenhDich : BaseObject {
		public BenhDich(Session session) : base(session) { }


		// Property region
		#region Properties

		string tenBenhDich;
		[XafDisplayName("Tên bệnh (dịch)"), ToolTip("")]
		//[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string TenBenhDich {
			get => tenBenhDich;
			set => SetPropertyValue(nameof(TenBenhDich), ref tenBenhDich, value);
		}

		string moTa;
		[XafDisplayName("Mô tả"), ToolTip("")]
		////[RuleRequiredField(CustomMessageTemplate = "Trường dữ liệu bắt buộc")]
		public string MoTa
		{
			get => moTa;
			set => SetPropertyValue(nameof(MoTa), ref moTa, value);
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