using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUSkillSelectShapeShootUI : BUSkillSelectShapeTemplate
{
	public BUSkillSelectShapeShootUI()
	{
		Type = ESmartSelectShapeType.SssShootUi;
	}

	public override void GetSkillSelectActorInfo(AActor Owner, int SkillID, in FVector InputSkillDir, float InputDisRatio, out FVector DesiredSkillDir, out FVector SkillSelectShapeRelativeVec)
	{
		DesiredSkillDir = default(FVector);
		SkillSelectShapeRelativeVec = default(FVector);
		if (BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner) != null)
		{
			APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(Owner);
			FVector forwardVector = localPlayerCameraManager.GetCameraRotation().GetForwardVector();
			FVector cameraLocation = localPlayerCameraManager.GetCameraLocation();
			FVector fVector = cameraLocation + forwardVector * 10000.0;
			FHitResultSimple HitResult;
			FVector fVector2 = ((UBGUSelectUtil.LineTraceSimple(Owner, cameraLocation, fVector, ETraceTypeQuery.TraceTypeQuery3, bDebug: false, out HitResult, null) != 1) ? fVector : HitResult.HitLocation);
			List<UActorComponent> componentsByTag = Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.ShootCon);
			FVector fVector3 = ((componentsByTag != null && componentsByTag.Count > 0) ? (componentsByTag[0] as USceneComponent).GetWorldLocation() : BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner));
			DesiredSkillDir = (fVector2 - fVector3).GetSafeNormal();
		}
	}
}
