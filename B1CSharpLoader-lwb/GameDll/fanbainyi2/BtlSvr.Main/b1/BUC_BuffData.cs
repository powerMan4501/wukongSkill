using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Engine;

namespace b1;

public class BUC_BuffData : IBUC_BuffData, IPersistentECSDataWithDestroyCB, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public BuffData[] _RepData = new BuffData[64];

	private BindDictInt_BuffInstData __BuffInstsDict_Raw;

	private static float INV1000 = 0.001f;

	public Dictionary<int, List<int>> FilterBuffInstsDict;

	public Dictionary<int, List<int>> FilterSkillEffectInstsDict;

	public Dictionary<int, BuffGroupInstData> BuffGroupInstsDict;

	public bool bEnableBuffGroupCheck;

	public FCostDmgInSkill_BuffHandler CostDmgInSkill_BuffHandler;

	[GSGameDataSnapShot]
	[GSReplicated]
	public BindDictInt_BuffInstData BuffInstsDict
	{
		get
		{
			return __BuffInstsDict_Raw;
		}
		set
		{
			BindDictInt_BuffInstData _BuffInstsDict_Raw = __BuffInstsDict_Raw;
			__BuffInstsDict_Raw = value;
			OnBuffInstsDictChg_Invoke(_BuffInstsDict_Raw, value);
		}
	}

	public bool bCanAddBuff { get; set; }

	[GSGameDataSnapShot]
	public bool bShouldUpdateBuffTime { get; set; }

	public event Action<BindDictInt_BuffInstData, BindDictInt_BuffInstData> OnBuffInstsDictChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			BuffInstsDict?.RegGetDeltaDataFunc(AllocRepDataForBuffInstsDict);
		}
		else
		{
			BuffInstsDict?.RegGetDeltaDataFunc(null);
		}
		BuffInstsDict?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<DictDeltaMsgInt_BuffInstData> AllocRepDataForBuffInstsDict()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().BuffInstsDict;
		}
		return null;
	}

	public BuffData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		BuffData buffData = _RepData[__LocalRepVersion % 64];
		if (buffData == null)
		{
			buffData = new BuffData();
			BuffInstsDict?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = buffData;
		}
		else if (flag)
		{
			buffData.BuffInstsDict.Clear();
			BuffInstsDict?.ClearDeltaData();
		}
		return buffData;
	}

	public BuffData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			BuffInstsDict?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		BuffData buffData = new BuffData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"BuffData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (BuffInstsDict == null)
			{
				buffData.BuffInstsDict.Add(new DictDeltaMsgInt_BuffInstData
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				BuffInstsDict.DumpFull(buffData.BuffInstsDict);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					BuffData other = _RepData[i % 64];
					buffData.MergeFrom(other);
				}
			}
		}
		return buffData;
	}

	private void OnBuffInstsDictChg_Invoke(BindDictInt_BuffInstData OldValue, BindDictInt_BuffInstData NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			BuffData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.BuffInstsDict.Clear();
			if (NewValue == null)
			{
				orAllocRepData.BuffInstsDict.Add(new DictDeltaMsgInt_BuffInstData
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.BuffInstsDict);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForBuffInstsDict);
		this.OnBuffInstsDictChg?.Invoke(OldValue, NewValue);
	}

	public BUC_BuffData()
	{
		BuffInstsDict = new BindDictInt_BuffInstData();
		BuffGroupInstsDict = new Dictionary<int, BuffGroupInstData>();
		bShouldUpdateBuffTime = true;
		FilterBuffInstsDict = new Dictionary<int, List<int>>();
		FilterSkillEffectInstsDict = new Dictionary<int, List<int>>();
		CostDmgInSkill_BuffHandler.Clear();
	}

	public void OnUnPersistentDestroy()
	{
		BuffInstsDict?.Clear();
	}

	public bool HasBuff(int BuffID)
	{
		BuffInstData BuffData2;
		if (BuffID < 0)
		{
			FUStBuffGroupDesc buffGroupDesc = BGW_GameDB.GetBuffGroupDesc(-BuffID);
			if (buffGroupDesc != null)
			{
				foreach (int buffID in buffGroupDesc.BuffIDList)
				{
					if (GetBuffInstData(buffID, out var BuffData))
					{
						return BuffData.bActive;
					}
				}
			}
		}
		else if (GetBuffInstData(BuffID, out BuffData2))
		{
			return BuffData2.bActive;
		}
		return false;
	}

	public void AddBuff(int BuffID, int Layer, AActor Caster, AActor RootCaster, AActor Owner, float Duration, int BuffEffectCount, EBuffSourceType BuffSourceType, out float FinalOutBuffDuration, FBattleAttrSnapShot BattleAttrSnapShot = default(FBattleAttrSnapShot))
	{
		FinalOutBuffDuration = 0f;
		if (!(RootCaster is IECSWorldObj))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(RootCaster);
		BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (buffDescRuntime == null)
		{
			return;
		}
		float num = Duration * INV1000;
		if (num == 0f)
		{
			num = (float)buffDescRuntime.GetDuration() * INV1000;
		}
		FinalOutBuffDuration = num;
		int almostEndAheadTime = buffDescRuntime.GetAlmostEndAheadTime();
		int maxLayer = buffDescRuntime.GetMaxLayer();
		if (GetBuffInstData(BuffID, out var BuffData))
		{
			BuffData.bActive = true;
			BuffData.LeftTime = num;
			BuffData.Duration = num;
			if (almostEndAheadTime >= 0)
			{
				BuffData.AlmostEndAheadTime = num - (float)almostEndAheadTime * INV1000;
				BuffData.bHasTriggerAlmostEndLogic = false;
			}
			else
			{
				BuffData.AlmostEndAheadTime = -1f;
				BuffData.bHasTriggerAlmostEndLogic = true;
			}
			int layer = BuffData.Layer;
			BuffData.Layer += Layer;
			if (BuffData.Layer > maxLayer && maxLayer > 0)
			{
				BuffData.Layer = maxLayer;
			}
			BuffData.CasterRef = new EntitySharedRef(Caster);
			BuffData.RootCasterRef = new EntitySharedRef(RootCaster);
			BuffData.BuffSourceType = BuffSourceType;
			BuffInstsDict.Set(BuffID, BuffData);
			bUS_GSEventCollection.Evt_OnBuffLayerChanged.Invoke(new EntitySharedRef(RootCaster), BuffID, layer, BuffData.Layer);
			bUS_GSEventCollection.Evt_OnBuffLayerChangedNotify.Invoke(BuffID, layer, BuffData.Layer);
			return;
		}
		BuffInstData buffInstData = new BuffInstData();
		buffInstData.bActive = true;
		buffInstData.BuffID = BuffID;
		buffInstData.DelayTime = (float)buffDescRuntime.GetDelay() * INV1000;
		buffInstData.LeftTime = num;
		buffInstData.Duration = num;
		if (almostEndAheadTime >= 0)
		{
			buffInstData.AlmostEndAheadTime = num - (float)almostEndAheadTime * INV1000;
			buffInstData.bHasTriggerAlmostEndLogic = false;
		}
		else
		{
			buffInstData.AlmostEndAheadTime = -1f;
			buffInstData.bHasTriggerAlmostEndLogic = true;
		}
		buffInstData.Layer = Layer;
		if (buffInstData.Layer > maxLayer && maxLayer > 0)
		{
			buffInstData.Layer = maxLayer;
		}
		buffInstData.UpdateTimer = 0f;
		buffInstData.CasterRef = new EntitySharedRef(Caster);
		buffInstData.RootCasterRef = new EntitySharedRef(RootCaster);
		buffInstData.OwnerRef = new EntitySharedRef(Owner);
		buffInstData.BuffEndTriggerByRemove = false;
		buffInstData.BuffEndTriggerByDead = false;
		buffInstData.HasTriggerAllRemoveByBuff = false;
		buffInstData.CachedFixFunctionReturnValues = new BindListFloat();
		for (int i = 0; i < BuffEffectCount; i++)
		{
			buffInstData.CachedFixFunctionReturnValues.Add(0f);
		}
		buffInstData.PropMgrHandleID = new BindDictEPropType_UInt();
		if (BattleAttrSnapShot.bSettedFlag)
		{
			buffInstData.Caster_AttrMemData = BattleAttrSnapShot;
		}
		else
		{
			buffInstData.Caster_AttrMemData = new FBattleAttrSnapShot(RootCaster);
		}
		buffInstData.BuffSourceType = BuffSourceType;
		BuffInstsDict.Set(BuffID, buffInstData);
		bUS_GSEventCollection.Evt_OnBuffLayerChanged.Invoke(new EntitySharedRef(RootCaster), BuffID, 0, buffInstData.Layer);
		bUS_GSEventCollection.Evt_OnBuffLayerChangedNotify.Invoke(BuffID, 0, buffInstData.Layer);
	}

	public bool RemoveBuff(AActor Owner, int BuffID, int Layer)
	{
		if (!GetBuffInstData(BuffID, out var BuffData))
		{
			return false;
		}
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
		if (BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData) == null)
		{
			return false;
		}
		int layer = BuffData.Layer;
		BuffData.Layer -= ((Layer > 0) ? Layer : BuffData.Layer);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
		bUS_GSEventCollection.Evt_OnBuffLayerChanged.Invoke(null, BuffID, layer, BuffData.Layer);
		bUS_GSEventCollection.Evt_OnBuffLayerChangedNotify.Invoke(BuffID, layer, BuffData.Layer);
		if (BuffData.Layer <= 0)
		{
			BuffData.bActive = false;
			BuffInstsDict.Remove(BuffID);
			BuffData.ClearTargetDic(IsBuffEnd: true);
			BuffData.ClearPropMgrHandleID();
			return true;
		}
		BuffData.LeftTime = BuffData.Duration;
		BuffData.UpdateTimer = 0f;
		BuffData.ClearTargetDic(IsBuffEnd: false);
		return false;
	}

	public List<int> GetAllFilterBuffID(out List<int> OutFilterIDs)
	{
		OutFilterIDs = new List<int>();
		foreach (KeyValuePair<int, List<int>> item in FilterBuffInstsDict)
		{
			OutFilterIDs.AddRange(item.Value);
		}
		return OutFilterIDs;
	}

	public List<int> GetAllFilterSkillEffectID(out List<int> OutFilterIDs)
	{
		OutFilterIDs = new List<int>();
		foreach (KeyValuePair<int, List<int>> item in FilterSkillEffectInstsDict)
		{
			OutFilterIDs.AddRange(item.Value);
		}
		return OutFilterIDs;
	}

	public bool GetBuffInstData(int BuffID, out BuffInstData BuffData)
	{
		BuffData = null;
		if (BuffInstsDict == null)
		{
			return false;
		}
		return BuffInstsDict.Find(BuffID, out BuffData);
	}

	public void SetIsActive(int BuffID, bool isActive)
	{
		if (GetBuffInstData(BuffID, out var BuffData))
		{
			BuffData.bActive = isActive;
		}
	}

	public List<BuffInstData> GetAllBuffInstData()
	{
		List<BuffInstData> list = new List<BuffInstData>();
		foreach (BuffInstData value in BuffInstsDict.RawData.Values)
		{
			list.Add(value);
		}
		return list;
	}

	public int GetBuffLayer(int BuffID)
	{
		if (GetBuffInstData(BuffID, out var BuffData))
		{
			return BuffData.Layer;
		}
		return 0;
	}

	public void CopyBuff(List<BuffInstData> Other, bool CleanCurrent = false)
	{
		if (CleanCurrent)
		{
			BuffInstsDict.Clear();
		}
		foreach (BuffInstData item in Other)
		{
			BuffInstsDict.Set(item.BuffID, item);
		}
	}
}
