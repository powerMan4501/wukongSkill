using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SkillSelectHelperData : IBUC_SkillSelectHelperData
{
	private TStrongObjectPtr<AActor> mSkillSelectActor = new TStrongObjectPtr<AActor>();

	public int CurSkillID;

	public FVector DesiredSkillForwardDirection;

	public FVector SkillShapeRelativeVec;

	public bool WillCancelSkill;

	public bool HasAppliedCancelSkillEffect;

	public UStaticMeshComponent AttackRangeMesh;

	public UStaticMeshComponent SkillSelectMesh;

	public UStaticMeshComponent SkillAuxiliaryMesh;

	public FVector4 CancelOffColor;

	public FVector4 CancelOnColor;

	public AActor SkillSelectActor
	{
		get
		{
			return mSkillSelectActor.Get();
		}
		set
		{
			mSkillSelectActor.Set(value);
		}
	}

	public FVector ExpectedFowardDirectionUnderInput { get; set; }

	public string ShowingSelectUIName { get; set; }

	public bool GetWillCancelSkill()
	{
		return WillCancelSkill;
	}

	public FVector GetDesiredSkillDirection()
	{
		return DesiredSkillForwardDirection;
	}

	public FRotator GetDesiredSkillRotation()
	{
		if (!SkillSelectActor.IsNullOrDestroyed())
		{
			return BGUFuncLibActorTransformCS.BGUGetActorRotation(SkillSelectActor);
		}
		return FRotator.ZeroRotator;
	}

	public FVector GetDesiredSkillLocation()
	{
		if (!SkillSelectActor.IsNullOrDestroyed())
		{
			return BGUFuncLibActorTransformCS.BGUGetActorLocation(SkillSelectActor);
		}
		return FVector.ZeroVector;
	}
}
