using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_ShootSuction : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		GSLocation shootSuctionTargetDir = base.CameraState.ShootSuctionTargetDir;
		if (!shootSuctionTargetDir.IsNearlyZero())
		{
			FVector forwardVector = base.CameraState.Rt_ControllerRotation.ToRotator().GetForwardVector();
			if (!(MathLib.DegAcos(GSLocation.DotProduct(shootSuctionTargetDir, forwardVector)) <= 1f))
			{
				base.CameraControlData.ControllerRotation.SetValue(MathLib.RInterpConstantTo(base.CameraState.Rt_ControllerRotation, shootSuctionTargetDir.Rotation(), base.DeltaTime, 15f));
			}
		}
	}

	public FCameraBlend_ShootSuction(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
