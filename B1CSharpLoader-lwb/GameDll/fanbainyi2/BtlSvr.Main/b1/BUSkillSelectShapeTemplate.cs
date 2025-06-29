using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public abstract class BUSkillSelectShapeTemplate
{
	protected ESmartSelectShapeType Type;

	protected float SkillShapeScaleDelimiter;

	protected BUSkillSelectShapeTemplate()
	{
		Type = ESmartSelectShapeType.SssNone;
		SkillShapeScaleDelimiter = 50f;
	}

	public virtual void InitSkillSelectActor(AActor Owner, AActor SkillSelectActor, int SkillID, out UStaticMeshComponent OutSkillSelectMesh, out UStaticMeshComponent OutSkillAuxiliaryMesh)
	{
		OutSkillSelectMesh = null;
		OutSkillAuxiliaryMesh = null;
	}

	public virtual void GetSkillSelectActorInfo(AActor Owner, int SkillID, in FVector InputSkillDir, float InputDisRatio, out FVector DesiredSkillDir, out FVector SkillSelectShapeRelativeVec)
	{
		DesiredSkillDir = default(FVector);
		SkillSelectShapeRelativeVec = default(FVector);
	}

	public virtual void RefreshSkillSelectActor(AActor Owner, AActor SkillSelectActor, UStaticMeshComponent SkillSelectMesh, UStaticMeshComponent SkillAuxiliaryMesh, in FVector RefPos, in FVector DesiredSkillDir, in FVector SkillSelectShapeRelativeVec)
	{
	}
}
