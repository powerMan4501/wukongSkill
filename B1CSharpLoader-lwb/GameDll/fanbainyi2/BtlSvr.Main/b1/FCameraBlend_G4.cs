using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_G4 : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.FreeCameraMode != EPlayerFreeCameraType.G4Mode && base.CameraState.FreeCameraMode != EPlayerFreeCameraType.SeqMatch)
		{
			return;
		}
		GSRotation gSRotation = GSRotation.CreateByPool();
		gSRotation = base.CameraControlData.ControllerRotation;
		if (base.CameraState.TickTotalTime > 0f)
		{
			if (base.CameraState.G4TurnRunTime >= base.CameraState.TickTotalTime)
			{
				gSRotation.Yaw = base.CameraState.TargetRotation.Yaw;
				base.CameraControlData.ControllerRotation.SetValue(gSRotation);
			}
			else
			{
				float alpha = base.CameraState.G4TurnRunTime / base.CameraState.TickTotalTime;
				EGSBlendTypeG gSBlendTypeG;
				float easeExp;
				if (base.CameraState.IsTurning)
				{
					gSBlendTypeG = EGSBlendTypeG.GSEaseOut;
					easeExp = 1f;
				}
				else
				{
					gSBlendTypeG = EGSBlendTypeG.GSEaseInOut;
					easeExp = 1f;
				}
				float num = FRotator.NormalizeAxis(UBUS_UtilComm.GSEase(FRotator.NormalizeAxis(base.CameraState.Rt_ControllerRotation.Yaw - base.CameraState.BeginRotation.Yaw), base.CameraState.DeltaRotation.Yaw, alpha, gSBlendTypeG, easeExp));
				gSRotation.Yaw = FRotator.NormalizeAxis(base.CameraState.BeginRotation.Yaw + num);
				base.CameraControlData.ControllerRotation.SetValue(gSRotation);
			}
		}
		if (!base.CameraState.IsLocked)
		{
			gSRotation.Pitch = 0f;
			gSRotation.Roll = 0f;
			gSRotation = MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in gSRotation, base.DeltaTime, base.CameraState.G4RotateSpeed);
			base.CameraControlData.ControllerRotation.Pitch = gSRotation.Pitch;
		}
	}

	public FCameraBlend_G4(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
