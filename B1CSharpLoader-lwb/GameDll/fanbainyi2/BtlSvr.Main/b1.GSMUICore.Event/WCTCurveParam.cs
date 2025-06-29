using UnrealEngine.Runtime;

namespace b1.GSMUICore.Event;

public class WCTCurveParam
{
	public float AmplitudeRateMin;

	public float AmplitudeRateMax;

	public float AmplitudeMin;

	public float AmplitudeMax;

	public ENGSEasingFunc ForwardEasingFunc;

	public float ForwardEaseParam;

	public ENGSEasingFunc SideEasingFunc;

	public float SideEaseParam;

	public FVector2D OriginVector;

	public WCTCurveParam(float amplitudeRateMin = 0f, float amplitudeRateMax = 0f, float amplitudeMin = 10f, float amplitudeMax = 50f, ENGSEasingFunc forwardEasingFunc = ENGSEasingFunc.EaseInQuart, float forwardEaseParam = 1.73f, ENGSEasingFunc sideEasingFunc = ENGSEasingFunc.Sin, float sideEaseParam = 1f, FVector2D originVector = default(FVector2D))
	{
		AmplitudeRateMin = amplitudeRateMin;
		AmplitudeRateMax = amplitudeRateMax;
		AmplitudeMin = amplitudeMin;
		AmplitudeMax = amplitudeMax;
		ForwardEasingFunc = forwardEasingFunc;
		ForwardEaseParam = forwardEaseParam;
		SideEasingFunc = sideEasingFunc;
		SideEaseParam = sideEaseParam;
		OriginVector = originVector;
	}
}
