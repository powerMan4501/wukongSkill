using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class GSLinearColorCurveToParam
{
	public UCurveLinearColor CurveLinearColor { get; set; }

	public bool NotUseCurve { get; set; }

	public FLinearColor OriLinearColorValue { get; set; }

	public FLinearColor TargetLinearColorValue { get; set; }

	public FName ParamName { get; set; }

	public GSLinearColorCurveToParam(in FGSLinearColorCurveToParam InConfig)
	{
		CurveLinearColor = InConfig.CurveLinearColor;
		NotUseCurve = InConfig.NotUseCurve;
		OriLinearColorValue = InConfig.OriLinearColorValue;
		TargetLinearColorValue = InConfig.TargetLinearColorValue;
		ParamName = InConfig.ParamName;
	}
}
