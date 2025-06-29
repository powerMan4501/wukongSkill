using System.Collections.Generic;

namespace b1;

internal interface IBUC_DecalConfigData
{
	List<b1.GSFloatCurveToParam> FloatCurveList { get; }

	List<b1.GSLinearColorCurveToParam> LinearColorCurveList { get; }
}
