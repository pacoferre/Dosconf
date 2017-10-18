using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PROT.ControlesEspeciales;

namespace LCC.WebGestion.presupuestos
{
	public partial class presupuestos_DocumentoModelo : PROT.ControlesEspeciales.RaizASCX
	{
		public int IDPresupuestoVersion
		{
			get
			{
				object tl = ViewState["IDPresupuestoVersion"];
				return ((tl == null) ? 0 : (int)tl);
			}
			set
			{
				ViewState["IDPresupuestoVersion"] = value;
			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{

		}
	}
}