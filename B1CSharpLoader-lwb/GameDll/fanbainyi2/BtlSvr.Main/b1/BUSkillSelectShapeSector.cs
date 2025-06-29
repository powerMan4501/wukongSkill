using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUSkillSelectShapeSector : BUSkillSelectShapeTemplate
{
	public BUSkillSelectShapeSector()
	{
		Type = ESmartSelectShapeType.SssSector;
	}

	public override void InitSkillSelectActor(AActor Owner, AActor SkillSelectActor, int SkillID, out UStaticMeshComponent OutSkillSelectMesh, out UStaticMeshComponent OutSkillAuxiliaryMesh)
	{
		OutSkillSelectMesh = Owner.GetComponentByClass<UStaticMeshComponent>();
		OutSkillAuxiliaryMesh = null;
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc != null)
		{
			float num = playerSkillCtrlDesc.SelectShapeParam1 / SkillShapeScaleDelimiter;
			float num2 = playerSkillCtrlDesc.SelectShapeParam2 / SkillShapeScaleDelimiter;
			SkillSelectActor.SetActorScale3D(new FVector(num, num2, 1.0));
			BGUFuncLibActorTransformCS.BGUSetActorRotation(SkillSelectActor, BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner), bTeleportPhysics: false);
		}
	}

	public override void GetSkillSelectActorInfo(AActor Owner, int SkillID, in FVector InputSkillDir, float InputDisRatio, out FVector DesiredSkillDir, out FVector SkillSelectShapeRelativeVec)
	{
		DesiredSkillDir = InputSkillDir;
		SkillSelectShapeRelativeVec = FVector.ZeroVector;
	}

	public override void RefreshSkillSelectActor(AActor Owner, AActor SkillSelectActor, UStaticMeshComponent SkillSelectMesh, UStaticMeshComponent SkillAuxiliaryMesh, in FVector RefPos, in FVector DesiredSkillDir, in FVector SkillSelectShapeRelativeVec)
	{
		BGUFuncLibActorTransformCS.BGUSetActorLocation(SkillSelectActor, RefPos + SkillSelectShapeRelativeVec, bSweep: false, bTeleport: false);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(SkillSelectActor, MathLib.Conv_VectorToRotator(DesiredSkillDir), bTeleportPhysics: false);
	}
}
