using UnrealEngine.Engine;

namespace b1;

internal class BUS_BirthDecideAreaComp : BUS_QuestOverlapComponent
{
	protected override void OnCollisionBeginOverlapImpl(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = OtherActor as BGUPlayerCharacterCS;
		if (bGUPlayerCharacterCS != null && bGUPlayerCharacterCS.IsPlayerControlled())
		{
			APlayerController aPlayerController = bGUPlayerCharacterCS.GetController() as APlayerController;
			if (aPlayerController != null)
			{
				BPS_EventCollectionCS.Get(aPlayerController)?.Evt_SetCurrentBirthPoint.Invoke(base.OverlapData.BirthPointID);
			}
		}
	}

	protected override void OnCollisionEndOverlapImpl(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
	{
	}
}
