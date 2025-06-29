using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_FieldSystem : GameStateSystemBase
{
	private BGC_FieldData FieldSystemData;

	public override void OnAttach()
	{
		base.OnAttach();
		FieldSystemData = RequireWritableData<BGC_FieldData>();
		base.BGSEventCollection.Evt_OnActorIntoField += new Del_Void_OnActorIntoField(OnActorEnter);
		base.BGSEventCollection.Evt_OnActorLeaveField += new Del_Void_ActorActor(OnActorLeave);
	}

	private void OnActorEnter(AActor MagicFieldActor, AActor OtherActor, List<FFieldBuffInfo> FieldBuffList)
	{
		if ((MagicFieldActor as BGUMagicFieldBaseCS).IsNullOrDestroyed())
		{
			return;
		}
		IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(MagicFieldActor);
		if (readOnlyData == null)
		{
			return;
		}
		AActor masterActor = readOnlyData.GetMasterActor();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OtherActor);
		foreach (FFieldBuffInfo FieldBuff in FieldBuffList)
		{
			if (FieldBuff.bIgnoreTypeFilter || (BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTeamFilter(MagicFieldActor, OtherActor, FieldBuff.TargetTeamFilter) && BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTypeFilter(OtherActor, FieldBuff.TargetTypeFilter)))
			{
				int buffID = FieldBuff.BuffID;
				if (!FieldSystemData.InnerTargetMonitor.ContainsKey(OtherActor))
				{
					FieldSystemData.InnerTargetMonitor.Add(OtherActor, new Dictionary<int, Stack<AActor>>());
				}
				if (!FieldSystemData.InnerTargetMonitor[OtherActor].ContainsKey(buffID))
				{
					FieldSystemData.InnerTargetMonitor[OtherActor].Add(buffID, new Stack<AActor>());
				}
				FieldSystemData.InnerTargetMonitor[OtherActor][buffID].Push(MagicFieldActor);
				if (!FieldSystemData.FieldCasterRecord.ContainsKey(OtherActor))
				{
					FieldSystemData.FieldCasterRecord.Add(OtherActor, new Dictionary<int, AActor>());
				}
				if (!FieldSystemData.FieldCasterRecord[OtherActor].ContainsKey(buffID))
				{
					FieldSystemData.FieldCasterRecord[OtherActor].Add(buffID, MagicFieldActor);
					bUS_GSEventCollection?.Evt_BuffAdd.Invoke(buffID, masterActor, masterActor, -1f, EBuffSourceType.MFOverlapEvent);
				}
				else
				{
					FieldSystemData.FieldCasterRecord[OtherActor][buffID] = MagicFieldActor;
					bUS_GSEventCollection?.Evt_UpdateBuffCaster.Invoke(masterActor, masterActor, buffID);
				}
			}
		}
		if (!FieldSystemData.UnitDeadListenFlag && FieldSystemData.InnerTargetMonitor.Count > 0)
		{
			base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
			FieldSystemData.UnitDeadListenFlag = true;
		}
	}

	private void OnActorLeave(AActor MagicFieldActor, AActor OtherActor)
	{
		if (FieldSystemData.InnerTargetMonitor.TryGetValue(OtherActor, out var value))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OtherActor);
			List<int> list = new List<int>();
			foreach (int key in value.Keys)
			{
				if (!value[key].Contains(MagicFieldActor))
				{
					continue;
				}
				if (FieldSystemData.FieldCasterRecord[OtherActor][key] != MagicFieldActor)
				{
					if (value[key].Contains(MagicFieldActor))
					{
						list.Add(key);
					}
					continue;
				}
				if (value[key].Count == 1)
				{
					bUS_GSEventCollection?.Evt_BuffRemove.Invoke(key, EBuffEffectTriggerType.None, 1, WithTriggerRemmoveEffect: false);
					FieldSystemData.FieldCasterRecord[OtherActor].Remove(key);
				}
				else
				{
					AActor aActor = null;
					foreach (AActor item in value[key])
					{
						if (item != MagicFieldActor)
						{
							aActor = item;
							break;
						}
					}
					if (aActor != null)
					{
						IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(aActor);
						if (readOnlyData != null)
						{
							AActor masterActor = readOnlyData.GetMasterActor();
							bUS_GSEventCollection?.Evt_UpdateBuffCaster.Invoke(masterActor, masterActor, key);
							FieldSystemData.FieldCasterRecord[OtherActor][key] = aActor;
						}
					}
				}
				list.Add(key);
			}
			foreach (int item2 in list)
			{
				if (FieldSystemData.InnerTargetMonitor[OtherActor][item2].Count == 1)
				{
					FieldSystemData.InnerTargetMonitor[OtherActor].Remove(item2);
					continue;
				}
				Stack<AActor> stack = new Stack<AActor>();
				AActor aActor2 = null;
				while (aActor2 != MagicFieldActor && FieldSystemData.InnerTargetMonitor[OtherActor][item2].Count > 0)
				{
					if (!aActor2.IsNullOrDestroyed())
					{
						stack.Push(aActor2);
					}
					aActor2 = FieldSystemData.InnerTargetMonitor[OtherActor][item2].Pop();
				}
				foreach (AActor item3 in stack)
				{
					FieldSystemData.InnerTargetMonitor[OtherActor][item2].Push(item3);
				}
			}
			if (FieldSystemData.InnerTargetMonitor[OtherActor].Count == 0)
			{
				FieldSystemData.InnerTargetMonitor.Remove(OtherActor);
			}
			if (FieldSystemData.FieldCasterRecord[OtherActor].Count == 0)
			{
				FieldSystemData.FieldCasterRecord.Remove(OtherActor);
			}
		}
		if (FieldSystemData.UnitDeadListenFlag && FieldSystemData.InnerTargetMonitor.Count == 0)
		{
			base.BGSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
			FieldSystemData.UnitDeadListenFlag = false;
		}
	}

	private void OnUnitDead(string UnitGuid, EDeadReason DeadReason)
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, UnitGuid);
		if (!actorByGuid.IsNullOrDestroyed())
		{
			FieldSystemData.InnerTargetMonitor.Remove(actorByGuid);
			FieldSystemData.FieldCasterRecord.Remove(actorByGuid);
		}
	}

	private void CheckBuffExist()
	{
		Dictionary<AActor, Dictionary<int, Stack<AActor>>>.KeyCollection keys = FieldSystemData.InnerTargetMonitor.Keys;
		Dictionary<AActor, HashSet<int>> dictionary = null;
		foreach (AActor item in keys)
		{
			if (item.IsNullOrDestroyed() || !FieldSystemData.InnerTargetMonitor.TryGetValue(item, out var value))
			{
				continue;
			}
			foreach (KeyValuePair<int, Stack<AActor>> item2 in value)
			{
				int key = item2.Key;
				AActor aActor = item2.Value.Peek();
				if (BGUFunctionLibraryCS.BGUHasBuffByID(item, key))
				{
					if (FieldSystemData.FieldCasterRecord.ContainsKey(item) && FieldSystemData.FieldCasterRecord[item][key] != aActor)
					{
						IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(aActor);
						if (readOnlyData != null)
						{
							AActor masterActor = readOnlyData.GetMasterActor();
							FieldSystemData.FieldCasterRecord[item][key] = aActor;
							BUS_EventCollectionCS.Get(item)?.Evt_UpdateBuffCaster.Invoke(masterActor, masterActor, key);
						}
					}
				}
				else
				{
					if (dictionary == null)
					{
						dictionary = new Dictionary<AActor, HashSet<int>>();
					}
					if (!dictionary.ContainsKey(item))
					{
						dictionary.Add(item, new HashSet<int>());
					}
					dictionary[item].Add(key);
				}
			}
		}
		if (dictionary == null)
		{
			return;
		}
		foreach (KeyValuePair<AActor, HashSet<int>> item3 in dictionary)
		{
			AActor key2 = item3.Key;
			if (key2.IsNullOrDestroyed())
			{
				continue;
			}
			foreach (int item4 in item3.Value)
			{
				if (!FieldSystemData.InnerTargetMonitor.ContainsKey(key2) || !FieldSystemData.InnerTargetMonitor[key2].TryGetValue(item4, out var value2))
				{
					continue;
				}
				AActor aActor2 = value2.Peek();
				if (aActor2.IsNullOrDestroyed())
				{
					continue;
				}
				IBUC_MasterData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(aActor2);
				if (readOnlyData2 == null)
				{
					continue;
				}
				AActor masterActor2 = readOnlyData2.GetMasterActor();
				if (!masterActor2.IsNullOrDestroyed())
				{
					if (!FieldSystemData.FieldCasterRecord.ContainsKey(key2))
					{
						FieldSystemData.FieldCasterRecord.Add(key2, new Dictionary<int, AActor>());
						FieldSystemData.FieldCasterRecord[key2].Add(item4, aActor2);
					}
					else if (!FieldSystemData.FieldCasterRecord[key2].ContainsKey(item4))
					{
						FieldSystemData.FieldCasterRecord[key2].Add(item4, aActor2);
					}
					else
					{
						FieldSystemData.FieldCasterRecord[key2][item4] = aActor2;
					}
					BUS_EventCollectionCS.Get(key2)?.Evt_BuffAdd.Invoke(item4, masterActor2, masterActor2, -1f, EBuffSourceType.MFOverlapEvent);
				}
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		FieldSystemData.UpdateRemainTimer -= DeltaTime;
		if (FieldSystemData.UpdateRemainTimer <= 0f)
		{
			CheckBuffExist();
			FieldSystemData.UpdateRemainTimer = FieldSystemData.UPDATE_INTERVAL;
		}
	}
}
