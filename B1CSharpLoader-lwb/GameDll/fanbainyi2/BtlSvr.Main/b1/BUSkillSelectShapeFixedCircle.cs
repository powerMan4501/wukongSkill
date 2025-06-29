using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUSkillSelectShapeFixedCircle : BUSkillSelectShapeTemplate
{
	public BUSkillSelectShapeFixedCircle()
	{
		Type = ESmartSelectShapeType.SssFixedCircle;
	}

	public override void InitSkillSelectActor(AActor Owner, AActor SkillSelectActor, int SkillID, out UStaticMeshComponent OutSkillSelectMesh, out UStaticMeshComponent OutSkillAuxiliaryMesh)
	{
		OutSkillSelectMesh = Owner.GetComponentByClass<UStaticMeshComponent>();
		OutSkillAuxiliaryMesh = null;
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc != null)
		{
			float max = playerSkillCtrlDesc.AttackRange / SkillShapeScaleDelimiter * 0.5f;
			float num = MathLib.Clamp(playerSkillCtrlDesc.SelectShapeParam1 / SkillShapeScaleDelimiter, 0.1f, max);
			float num2 = num;
			SkillSelectActor.SetActorScale3D(new FVector(num, num2, 1.0));
			BGUFuncLibActorTransformCS.BGUSetActorRotation(SkillSelectActor, BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner), bTeleportPhysics: false);
		}
	}

	public override void GetSkillSelectActorInfo(AActor Owner, int SkillID, in FVector InputSkillDir, float InputDisRatio, out FVector DesiredSkillDir, out FVector SkillSelectShapeRelativeVec)
	{
		DesiredSkillDir = Owner.GetActorForwardVector();
		SkillSelectShapeRelativeVec = default(FVector);
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc != null)
		{
			SkillSelectShapeRelativeVec = DesiredSkillDir * playerSkillCtrlDesc.SelectShapeParam2;
		}
	}

	public override void RefreshSkillSelectActor(AActor Owner, AActor SkillSelectActor, UStaticMeshComponent SkillSelectMesh, UStaticMeshComponent SkillAuxiliaryMesh, in FVector RefPos, in FVector DesiredSkillDir, in FVector SkillSelectShapeRelativeVec)
	{
		BGUFuncLibActorTransformCS.BGUSetActorLocation(SkillSelectActor, RefPos + SkillSelectShapeRelativeVec, bSweep: false, bTeleport: false);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(SkillSelectActor, MathLib.Conv_VectorToRotator(DesiredSkillDir), bTeleportPhysics: false);
	}
}
