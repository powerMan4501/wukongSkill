using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ActionTriggerComp : BUS_TriggerBaseComp
{
	private b1.BUC_ActionTriggerConfigData ActionTriggerConfigData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		ActionTriggerConfigData = RequireWritableData<b1.BUC_ActionTriggerConfigData>();
	}

	private List<ABGUCharacter> SelectTargets()
	{
		List<ABGUCharacter> list = new List<ABGUCharacter>();
		if (ActionTriggerConfigData == null)
		{
			return list;
		}
		if (ActionTriggerConfigData.UseManualSelect)
		{
			foreach (TStrongObjectPtr<ABGUCharacter> target in ActionTriggerConfigData.TargetList)
			{
				ABGUCharacter aBGUCharacter = target.Get();
				if (!aBGUCharacter.IsNullOrDestroyed() && !list.Contains(aBGUCharacter) && BGUFunctionLibraryCS.BGUSeletUnitsFilter(aBGUCharacter as BGUCharacterCS, ActionTriggerConfigData.ResIdList, ActionTriggerConfigData.bSelectUnitHasTarget, ActionTriggerConfigData.bSelectPassiveUnit))
				{
					list.Add(aBGUCharacter);
				}
			}
		}
		if (ActionTriggerConfigData.UseAreaSelect)
		{
			foreach (TStrongObjectPtr<BGUSelectAreaActor> area in ActionTriggerConfigData.AreaList)
			{
				BGUSelectAreaActor bGUSelectAreaActor = area.Get();
				if (bGUSelectAreaActor.IsNullOrDestroyed())
				{
					continue;
				}
				UBoxComponent boxComp = bGUSelectAreaActor.GetBoxComp();
				if (boxComp == null)
				{
					continue;
				}
				List<ABGUCharacter> OutArray = new List<ABGUCharacter>();
				UBGUSelectUtil.BoxOverlapBGUCharacters(GetOwner().World, boxComp.GetWorldLocation(), boxComp.GetScaledBoxExtent(), out OutArray);
				foreach (ABGUCharacter item in OutArray)
				{
					if (!list.Contains(item) && BGUFunctionLibraryCS.BGUSeletUnitsFilter(item as BGUCharacterCS, ActionTriggerConfigData.ResIdList, ActionTriggerConfigData.bSelectUnitHasTarget, ActionTriggerConfigData.bSelectPassiveUnit))
					{
						list.Add(item);
					}
				}
			}
		}
		return list;
	}

	private void WakeUpUnits(AActor CatchedTarget, List<ABGUCharacter> WakeUpUnits)
	{
		if (WakeUpUnits == null)
		{
			return;
		}
		ABGUCharacter aBGUCharacter = CatchedTarget as ABGUCharacter;
		if (aBGUCharacter.IsNullOrDestroyed() || !aBGUCharacter.IsPlayerControlled() || ActionTriggerConfigData == null)
		{
			return;
		}
		foreach (ABGUCharacter WakeUpUnit in WakeUpUnits)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(WakeUpUnit);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_AICatchTarget.Invoke(CatchedTarget, ETargetSourceType.Target_ActionBoxAssignTarget);
			}
		}
	}

	public override void OnEnter_TriggeredEvent()
	{
		if (ActionTriggerConfigData != null)
		{
			List<ABGUCharacter> list = new List<ABGUCharacter>();
			list = SelectTargets();
			if (ActionTriggerConfigData.TargetActionType == ETargetActionType.WakeUp)
			{
				WakeUpUnits(base.TriggerBoxData.OverlappedOtherActor, list);
			}
		}
	}
}
