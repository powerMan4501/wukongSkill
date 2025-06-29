using UnrealEngine.Engine;

namespace GSDispLib;

public abstract class DBCInfoBase : DBCIdentityInfoBase
{
	public float PlayAtTime;

	public float EndAtTime;

	public float CustomTimeDilation { get; protected set; } = 1f;

	protected float GetCurTime()
	{
		if (base.SourceDispOwnerComp != null)
		{
			return BGU_DispLibDataUtil.GSTimeAfterBeginPlay(base.SourceDispOwnerComp.GetOwner());
		}
		return 0f;
	}

	public void DBCInfoInit(USceneComponent _SourceDispOwnerComp)
	{
		base.SourceDispOwnerComp = _SourceDispOwnerComp;
		AActor owner = base.SourceDispOwnerComp.GetOwner();
		base.OwnerActorUniqueID = owner.GetUniqueID();
	}
}
