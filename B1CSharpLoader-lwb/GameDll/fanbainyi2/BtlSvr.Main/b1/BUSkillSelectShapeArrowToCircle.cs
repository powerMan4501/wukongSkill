using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUSkillSelectShapeArrowToCircle : BUSkillSelectShapeTemplate
{
	public BUSkillSelectShapeArrowToCircle()
	{
		Type = ESmartSelectShapeType.SssArrowToCircle;
	}

	public override void InitSkillSelectActor(AActor Owner, AActor SkillSelectActor, int SkillID, out UStaticMeshComponent OutSkillSelectMesh, out UStaticMeshComponent OutSkillAuxiliaryMesh)
	{
		OutSkillSelectMesh = Owner.GetComponentByClass<UStaticMeshComponent>();
		OutSkillAuxiliaryMesh = null;
		List<UActorComponent> componentsByTag = SkillSelectActor.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.Arrow);
		if (componentsByTag.Count > 0)
		{
			OutSkillAuxiliaryMesh = componentsByTag[0] as UStaticMeshComponent;
		}
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc != null)
		{
			float max = playerSkillCtrlDesc.AttackRange / SkillShapeScaleDelimiter * 0.5f;
			float num = MathLib.Clamp(playerSkillCtrlDesc.SelectShapeParam1 / SkillShapeScaleDelimiter, 0.1f, max);
			float num2 = MathLib.Clamp(playerSkillCtrlDesc.SelectShapeParam2 / SkillShapeScaleDelimiter, 0.1f, max);
			SkillSelectActor.SetActorScale3D(new FVector(num, num2, 1.0));
			BGUFuncLibActorTransformCS.BGUSetActorRotation(SkillSelectActor, BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner), bTeleportPhysics: false);
		}
	}

	public override void GetSkillSelectActorInfo(AActor Owner, int SkillID, in FVector InputSkillDir, float InputDisRatio, out FVector DesiredSkillDir, out FVector SkillSelectShapeRelativeVec)
	{
		DesiredSkillDir = InputSkillDir;
		SkillSelectShapeRelativeVec = default(FVector);
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc != null)
		{
			SkillSelectShapeRelativeVec = InputSkillDir * InputDisRatio * playerSkillCtrlDesc.AttackRange;
		}
	}

	public override void RefreshSkillSelectActor(AActor Owner, AActor SkillSelectActor, UStaticMeshComponent SkillSelectMesh, UStaticMeshComponent SkillAuxiliaryMesh, in FVector RefPos, in FVector DesiredSkillDir, in FVector SkillSelectShapeRelativeVec)
	{
		BGUFuncLibActorTransformCS.BGUSetActorLocation(SkillSelectActor, RefPos + SkillSelectShapeRelativeVec, bSweep: false, bTeleport: false);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(SkillSelectActor, MathLib.Conv_VectorToRotator(DesiredSkillDir), bTeleportPhysics: false);
		if (!SkillAuxiliaryMesh.IsNullOrDestroyed())
		{
			SkillAuxiliaryMesh.SetWorldLocation(RefPos + SkillSelectShapeRelativeVec / 2.0, bSweep: false, out var _, bTeleport: false);
			float num = SkillSelectShapeRelativeVec.Size() / 2f;
			FVector actorScale3D = SkillSelectActor.GetActorScale3D();
			actorScale3D.X = num / SkillShapeScaleDelimiter;
			SkillAuxiliaryMesh.SetWorldScale3D(actorScale3D);
		}
	}
}
