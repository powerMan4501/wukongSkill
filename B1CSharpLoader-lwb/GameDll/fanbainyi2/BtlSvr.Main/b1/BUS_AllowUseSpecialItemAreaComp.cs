using UnrealEngine.Engine;

namespace b1;

internal class BUS_AllowUseSpecialItemAreaComp : UActorCompBaseCS
{
	private b1.IBUC_AllowUseSpecialItemAreaData AllowUseSpecialItemAreaData;

	public override void OnAttach()
	{
		base.OnAttach();
		AllowUseSpecialItemAreaData = RequireReadOnlyData<b1.IBUC_AllowUseSpecialItemAreaData, b1.BUC_AllowUseSpecialItemAreaData>();
		base.BGSEventCollection?.Evt_BGS_OnRegisterAllowUseSpecialItemArea.Invoke(GetOwner());
	}

	private void OnActorEnter(AActor actor)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = actor as BGUPlayerCharacterCS;
		if (!(bGUPlayerCharacterCS == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUPlayerCharacterCS);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_SetAllowUseSpecialItemMap.Invoke(AllowUseSpecialItemAreaData.AllowUseSpecialItemMap);
			}
		}
	}

	private void OnActorLeave(AActor actor)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = actor as BGUPlayerCharacterCS;
		if (!(bGUPlayerCharacterCS == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUPlayerCharacterCS);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_SetAllowUseSpecialItemMap.Invoke(AllowUseSpecialItemAreaData.AllowUseSpecialItemRemoveMap);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection?.Evt_BGS_OnUnregisterAllowUseSpecialItemArea.Invoke(GetOwner());
	}
}
