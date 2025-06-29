using System.Collections.Generic;

namespace b1;

internal class BUC_DecalConfigData : b1.IBUC_DecalConfigData
{
	public List<b1.GSFloatCurveToParam> FloatCurveList { get; set; } = new List<b1.GSFloatCurveToParam>();

	public List<b1.GSLinearColorCurveToParam> LinearColorCurveList { get; set; } = new List<b1.GSLinearColorCurveToParam>();
}
