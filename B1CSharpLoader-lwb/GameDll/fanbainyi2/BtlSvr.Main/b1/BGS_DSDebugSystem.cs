using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using b1.GSFile;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_DSDebugSystem : GameModeSystemBase
{
	private BGC_DSDebugData DSDebugData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnAttach()
	{
		DSDebugData = RequireWritableData<BGC_DSDebugData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Combine(bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnItemChange));
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange = (BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange)Delegate.Remove(bGW_EventCollection.Evt_TaskGraphNotifyGraph_ItemChange, new BGW_EventCollection.Del_BGW_Void_TaskGraphNotifyGraph_ItemChange(OnItemChange));
	}

	private void OnItemChange(int ItemID, int OldNum, int NewNum)
	{
		int num = NewNum - OldNum;
		if (DSDebugData.ItemDict.TryGetValue(ItemID, out var _))
		{
			DSDebugData.ItemDict[ItemID] += num;
		}
		else
		{
			DSDebugData.ItemDict.Add(ItemID, num);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DSDebugData == null || !DebugConfig.IsDebugDS)
		{
			return;
		}
		if (!DSDebugData.PlayerLogin)
		{
			if (UGameplayStatics.GetNumPlayerControllers(GetOwner()) > 0)
			{
				DSDebugData.PlayerLogin = true;
				DSDebugData.KillDelayTime = 5f;
			}
		}
		else
		{
			if (!(DSDebugData.KillDelayTime > 0f))
			{
				return;
			}
			DSDebugData.KillDelayTime -= DeltaTime;
			if (DSDebugData.KillDelayTime <= 0f)
			{
				KillAllEnemy();
				BreakAllDestructible();
				CollectionAll();
				DSDebugData.KillCount++;
				if (DSDebugData.KillCount < 5)
				{
					DSDebugData.KillDelayTime = 5f;
					return;
				}
				ExportItemData();
				DSDebugData.DebugFinish = true;
			}
		}
	}

	private void ExportItemData()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("ItemID,Name,ItemNum");
		foreach (KeyValuePair<int, int> item in DSDebugData.ItemDict)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(item.Key);
			if (itemDesc != null)
			{
				stringBuilder.AppendLine($"{item.Key},{itemDesc.Name},{item.Value}");
			}
		}
		File.WriteAllText(FPaths.Combine(GSEFileUtil.GetTmpPath(), "DSDebug.csv"), stringBuilder.ToString(), Encoding.UTF8);
	}

	private void KillAllEnemy()
	{
		ABGUCharacter aBGUCharacter = null;
		if (BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player))
		{
			aBGUCharacter = Player as ABGUCharacter;
		}
		if (Player == null || aBGUCharacter == null)
		{
			return;
		}
		ABGUCharacter[] allActorsOfClass = Player.World.GetAllActorsOfClass<ABGUCharacter>();
		if (allActorsOfClass.Length < 1)
		{
			return;
		}
		ABGUCharacter[] array = allActorsOfClass;
		foreach (ABGUCharacter aBGUCharacter2 in array)
		{
			if (!BGUFunctionLibraryCS.BGUIsEnemyTeam(aBGUCharacter, aBGUCharacter2))
			{
				continue;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aBGUCharacter2);
			if (bUS_GSEventCollection != null)
			{
				BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(aBGUCharacter2);
				if (readOnlyData != null && !readOnlyData.HasState(EBGUUnitState.Dead))
				{
					bUS_GSEventCollection.Evt_UnitDead.Invoke(aBGUCharacter, EDeadReason.SkillDamage);
				}
			}
		}
	}

	private void CollectionAll()
	{
		ABGUCharacter aBGUCharacter = null;
		if (BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player))
		{
			aBGUCharacter = Player as ABGUCharacter;
		}
		if (Player == null || aBGUCharacter == null)
		{
			return;
		}
		BGUCollectionBase[] allActorsOfClass = Player.World.GetAllActorsOfClass<BGUCollectionBase>();
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(allActorsOfClass[i]);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_InteractCollection.Invoke(aBGUCharacter);
			}
		}
	}

	private void BreakAllDestructible()
	{
		ABGUCharacter aBGUCharacter = null;
		if (BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player))
		{
			aBGUCharacter = Player as ABGUCharacter;
		}
		if (!(Player == null) && !(aBGUCharacter == null))
		{
			BGUDroppableDestructionActorBase[] allActorsOfClass = Player.World.GetAllActorsOfClass<BGUDroppableDestructionActorBase>();
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				BGUFunctionLibraryCS.BGUDestroyDestructible(allActorsOfClass[i], FVector.ZeroVector, FVector.ZeroVector);
			}
		}
	}
}
