using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SceneItemCommData : IPersistentECSData
{
	public float DelayEnableCollisionTimer;

	public FTransform TeleportTransform;

	public int SkillID;

	public bool NeedClosePhysicWhenReset;

	public void Init()
	{
		DelayEnableCollisionTimer = -1f;
		TeleportTransform = new FTransform(FQuat.Identity, FVector.ZeroVector, FVector.OneVector);
	}

	public void CopyBPDataToData(FTransform TeleportTrans, FTransform ActorTransform, int InSkillID, bool _NeedClosePhysicWhenReset)
	{
		TeleportTransform.SetScale3D(FVector.OneVector);
		TeleportTransform.SetRotation(ActorTransform.GetRotation());
		TeleportTransform.SetLocation(TeleportTrans.GetLocation() + ActorTransform.GetLocation());
		SkillID = InSkillID;
		NeedClosePhysicWhenReset = _NeedClosePhysicWhenReset;
	}
}
