using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class GSFloatCurveToParam
{
	public UCurveFloat CurveFloat { get; set; }

	public bool NotUseCurve { get; set; }

	public float OriFloatValue { get; set; }

	public float TargetFloatValue { get; set; }

	public FName ParamName { get; set; }

	public GSFloatCurveToParam(in FGSFloatCurveToParam InConfig)
	{
		CurveFloat = InConfig.CurveFloat;
		NotUseCurve = InConfig.NotUseCurve;
		OriFloatValue = InConfig.OriFloatValue;
		TargetFloatValue = InConfig.TargetFloatValue;
		ParamName = InConfig.ParamName;
	}
}
