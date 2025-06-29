using UnrealEngine.Engine;

namespace b1;

public class BUS_GuidCompImpl : UActorCompBaseCS
{
	private BUC_GuidData GuidData;

	public override void OnAttach()
	{
		GuidData = RequireWritableData<BUC_GuidData>();
	}

	public override void PreBeginPlay()
	{
		base.BGWEventCollection.Evt_SetActorGuid2Entity(Owner, GuidData.GetFinalGuid(), GetActorResID());
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGWEventCollection.Evt_RemoveActorGuid2Entity(Owner, GuidData.GetFinalGuid(), GetActorResID());
	}
}
