namespace b1;

internal class BUS_MiscInitComp : UActorCompBaseCS
{
	public override void LateBeginPlay()
	{
		if (OwnerAsCharacterCS.IsPlayerControlled())
		{
			base.BGWEventCollection.Evt_PlayerDelayBeginPlayFinished();
			RequireWritableData<BUC_UnitDebugData>().IsPlayerDelayBeginPlayFinished = true;
		}
	}
}
