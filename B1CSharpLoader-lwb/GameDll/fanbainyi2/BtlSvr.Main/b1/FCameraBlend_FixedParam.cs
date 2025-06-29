namespace b1;

public class FCameraBlend_FixedParam : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		int fixedCameraParamFlags = base.CameraState.FixedCameraParamFlags;
		if (fixedCameraParamFlags == 0)
		{
			return;
		}
		for (int i = 0; i < 21; i++)
		{
			if ((fixedCameraParamFlags & (1 << i)) != 0)
			{
				FixedCameraParam((ECameraParamType)i);
			}
		}
	}

	private void FixedCameraParam(ECameraParamType FixedCameraParamType)
	{
		switch (FixedCameraParamType)
		{
		case ECameraParamType.ArmLocationX:
			base.CameraControlData.ArmLocation.SetValue(base.CameraState.Rt_ArmLocation.X, base.CameraControlData.ArmLocation.Y, base.CameraControlData.ArmLocation.Z);
			break;
		case ECameraParamType.ArmLocationY:
			base.CameraControlData.ArmLocation.SetValue(base.CameraControlData.ArmLocation.X, base.CameraState.Rt_ArmLocation.Y, base.CameraControlData.ArmLocation.Z);
			break;
		case ECameraParamType.ArmLocationZ:
			base.CameraControlData.ArmLocation.SetValue(base.CameraControlData.ArmLocation.X, base.CameraControlData.ArmLocation.Y, base.CameraState.Rt_ArmLocation.Z);
			break;
		case ECameraParamType.ArmSocketOffsetX:
			base.CameraControlData.Target_ArmSocketOffset.X = base.CameraState.Rt_ArmSocketOffset.X;
			base.CameraControlData.ArmSocketOffset.SetValue(base.CameraControlData.Target_ArmSocketOffset.X, base.CameraControlData.ArmSocketOffset.Y, base.CameraControlData.ArmSocketOffset.Z);
			break;
		case ECameraParamType.ArmSocketOffsetY:
			base.CameraControlData.Target_ArmSocketOffset.Y = base.CameraState.Rt_ArmSocketOffset.Y;
			base.CameraControlData.ArmSocketOffset.SetValue(base.CameraControlData.ArmSocketOffset.X, base.CameraControlData.Target_ArmSocketOffset.Y, base.CameraControlData.ArmSocketOffset.Z);
			break;
		case ECameraParamType.ArmSocketOffsetZ:
			base.CameraControlData.Target_ArmSocketOffset.Z = base.CameraState.Rt_ArmSocketOffset.Z;
			base.CameraControlData.ArmSocketOffset.SetValue(base.CameraControlData.ArmSocketOffset.X, base.CameraControlData.ArmSocketOffset.Y, base.CameraControlData.Target_ArmSocketOffset.Z);
			break;
		case ECameraParamType.ArmLength:
			base.CameraControlData.Target_ArmLength = base.CameraState.Rt_ArmLength;
			base.CameraControlData.ArmLength = base.CameraControlData.Target_ArmLength;
			break;
		case ECameraParamType.ControllerPitch:
			base.CameraControlData.ControllerRotation.SetValue(base.CameraState.Rt_ControllerRotation.Pitch, base.CameraControlData.ControllerRotation.Yaw, base.CameraControlData.ControllerRotation.Roll);
			break;
		case ECameraParamType.ControllerRoll:
			base.CameraControlData.ControllerRotation.SetValue(base.CameraControlData.ControllerRotation.Pitch, base.CameraControlData.ControllerRotation.Yaw, base.CameraState.Rt_ControllerRotation.Roll);
			break;
		case ECameraParamType.ControllerYaw:
			base.CameraControlData.ControllerRotation.SetValue(base.CameraControlData.ControllerRotation.Pitch, base.CameraState.Rt_ControllerRotation.Yaw, base.CameraControlData.ControllerRotation.Roll);
			break;
		case ECameraParamType.DmcActorLocationX:
			base.CameraControlData.DmcActorLocation.SetValue(base.CameraState.Rt_DmcActorLocation.X, base.CameraControlData.DmcActorLocation.Y, base.CameraControlData.DmcActorLocation.Z);
			break;
		case ECameraParamType.DmcActorLocationY:
			base.CameraControlData.DmcActorLocation.SetValue(base.CameraControlData.DmcActorLocation.X, base.CameraState.Rt_DmcActorLocation.Y, base.CameraControlData.DmcActorLocation.Z);
			break;
		case ECameraParamType.DmcActorLocationZ:
			base.CameraControlData.DmcActorLocation.SetValue(base.CameraControlData.DmcActorLocation.X, base.CameraControlData.DmcActorLocation.Y, base.CameraState.Rt_DmcActorLocation.Z);
			break;
		case ECameraParamType.DmcActorPitch:
			base.CameraControlData.DmcActorRotation.SetValue(base.CameraState.Rt_DmcActorRotation.Pitch, base.CameraControlData.DmcActorRotation.Yaw, base.CameraControlData.DmcActorRotation.Roll);
			break;
		case ECameraParamType.DmcActorRoll:
			base.CameraControlData.DmcActorRotation.SetValue(base.CameraControlData.DmcActorRotation.Pitch, base.CameraControlData.DmcActorRotation.Yaw, base.CameraState.Rt_ControllerRotation.Roll);
			break;
		case ECameraParamType.DmcActorYaw:
			base.CameraControlData.DmcActorRotation.SetValue(base.CameraControlData.DmcActorRotation.Pitch, base.CameraState.Rt_ControllerRotation.Yaw, base.CameraControlData.DmcActorRotation.Roll);
			break;
		case ECameraParamType.DmcArmLength:
			base.CameraControlData.DmcArmLength = base.CameraState.Rt_DmcArmLength;
			break;
		case ECameraParamType.PlayerPosition2D:
		case ECameraParamType.PlayerPositionZ:
		case ECameraParamType.TargetPosition2D:
		case ECameraParamType.TargetPositionZ:
			break;
		}
	}

	public FCameraBlend_FixedParam(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
