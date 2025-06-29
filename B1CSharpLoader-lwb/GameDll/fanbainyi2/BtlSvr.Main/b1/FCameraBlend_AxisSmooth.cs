using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_AxisSmooth : FCameraBlendBase
{
	public bool IsXAxisFixed { get; set; }

	public bool IsYAxisFixed { get; set; }

	public bool IsZAxisFixed { get; set; }

	public float SmoothSpeed { get; set; }

	public float CameraLagSpeed { get; set; }

	protected override void BlendCamera()
	{
		base.BlendCamera();
		SmoothSpeed = FMath.Max(0.0001f, SmoothSpeed);
		if (base.CameraState.IsLocked && GSGameplayCVar.CVar_StraightCameraVersion.GetValueInGameThread() == 2)
		{
			base.CameraControlData.IsXAxisFixed = true;
			base.CameraControlData.IsYAxisFixed = true;
			base.CameraControlData.IsZAxisFixed = true;
		}
		else
		{
			base.CameraControlData.IsXAxisFixed = IsXAxisFixed;
			base.CameraControlData.IsYAxisFixed = IsYAxisFixed;
			base.CameraControlData.IsZAxisFixed = IsZAxisFixed;
		}
		base.CameraControlData.CameraLagMaxDistance.SetValue(MathLib.VInterpTo(base.CameraState.Rt_CameraLagMaxDistance, base.CameraState.DefaultInverseOffset, base.DeltaTime, SmoothSpeed));
		base.CameraControlData.CameraLagSpeed.SetValue(MathLib.VInterpTo(base.CameraState.Rt_CameraLagSpeed, base.CameraState.DefaultInverseOffsetSpeed, base.DeltaTime, SmoothSpeed));
		base.CameraControlData.CameraLagInverseSpeed.SetValue(MathLib.VInterpTo(base.CameraState.Rt_CameraLagInverseSpeed, base.CameraState.DefaultInverseOffsetResetSpeed, base.DeltaTime, SmoothSpeed));
	}

	public FCameraBlend_AxisSmooth(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
