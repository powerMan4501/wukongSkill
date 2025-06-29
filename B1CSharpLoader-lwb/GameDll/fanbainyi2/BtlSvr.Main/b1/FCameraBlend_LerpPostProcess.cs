using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_LerpPostProcess : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.IsLocked)
		{
			SetFoliageFadeDistance(base.CameraState.FoliageFadeScaleCurve);
		}
		else if (base.CameraState.bIsCloudMoving)
		{
			SetFoliageFadeDistance(base.CameraState.CloudFoliageFadeScaleCurve);
		}
	}

	private void SetFoliageFadeDistance(TStrongObjectPtr<UCurveFloat> FoliageFadeScaleCurve)
	{
		float num = 1f;
		if (FoliageFadeScaleCurve.IsValid())
		{
			num = FoliageFadeScaleCurve.Get().GetFloatValue(base.CameraControlData.ArmLength);
		}
		base.CameraControlData.FoliageFadeDistance = MathLib.FInterpTo(base.CameraState.Rt_FoliageFadeDistance, num * base.CameraControlData.ArmLength, base.DeltaTime, base.CameraState.FoliageFadeDistanceLerpSpeed);
	}

	public FCameraBlend_LerpPostProcess(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
