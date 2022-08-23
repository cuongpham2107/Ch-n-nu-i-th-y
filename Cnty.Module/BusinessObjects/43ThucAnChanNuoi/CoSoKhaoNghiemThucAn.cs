 using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Cnty.Module.BusinessObjects {
	[DefaultClassOptions]
	[XafDefaultProperty(nameof(CoSoKhaoNghiem))]
	[ImageName("BO_Contact")]
	[XafDisplayName("Cơ sở khảo nghiệm TĂCN")]
	[NavigationItem(R.MenuCoSoKhaoNghiemBaoTonGen)]
	[DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
	public class CoSoKhaoNghiemThucAn : BaseObject {
		public CoSoKhaoNghiemThucAn(Session session) : base(session) { }


		// Property region
		#region Properties

		CosoSanxuat coSoKhaoNghiem;
		[XafDisplayName("Cơ sở khảo nghiệm"), ToolTip("")]
		public CosoSanxuat CoSoKhaoNghiem {
			get => coSoKhaoNghiem;
			set => SetPropertyValue(nameof(CoSoKhaoNghiem), ref coSoKhaoNghiem, value);
		}

		[PersistentAlias("")]
		[XafDisplayName("Địa chỉ"), ToolTip("")]
		public string DiaChi => CoSoKhaoNghiem?.Diachi;

		[PersistentAlias("")]
		[XafDisplayName("Email"), ToolTip("")]
		public string Email => CoSoKhaoNghiem?.Email;

		[PersistentAlias("")]
		[XafDisplayName("Số điện thoại"), ToolTip("")]
		public string SoDienThoai => CoSoKhaoNghiem?.SoDienThoai;
		#endregion

		// Association region
		#region Associations

		#endregion

		// Action region
		#region Actions

		#endregion
	}
}