using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_SoulItemMgr : GameStateSystemBase
{
	private BGC_SoulItemData SoulItemData;

	public override void OnAttach()
	{
		SoulItemData = RequireWritableData<BGC_SoulItemData>();
		base.BGSEventCollection.Evt_BGS_OnSpawnDropItem += new Del_BGS_OnSpawnDropItem(OnSpawnDropItem);
		base.BGSEventCollection.Evt_BGS_OnCollectionPendingSoul += new Del_Void(ClearPendingSoul);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnResetAllActors));
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_OnSpawnDropItem -= new Del_BGS_OnSpawnDropItem(OnSpawnDropItem);
		base.BGSEventCollection.Evt_BGS_OnCollectionPendingSoul -= new Del_Void(ClearPendingSoul);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnResetAllActors));
		base.OnEndPlay(EndPlayReason);
	}

	private void OnSpawnDropItem(int ItemID, DropReason DropReason, AActor DropItem)
	{
		if (GameDBRuntime.GetSoulSkillDesc(ItemID) != null && DropReason != DropReason.DropItemMgr)
		{
			if (!SoulItemData.SoulItems.ContainsKey(ItemID))
			{
				SoulItemData.SoulItems.Add(ItemID, DropItem);
			}
			else
			{
				SoulItemData.SoulItems[ItemID] = DropItem;
			}
		}
	}

	private void OnResetAllActors(EResetActorReason ResetReason)
	{
		ClearPendingSoul();
	}

	private void ClearPendingSoul()
	{
		foreach (AActor value in SoulItemData.SoulItems.Values)
		{
			if (value != null)
			{
				BGU_UnrealWorldUtil.DestroyActor(value);
			}
		}
		SoulItemData.SoulItems.Clear();
	}
}
