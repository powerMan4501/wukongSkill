using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;
using UnrealEngine.Engine;

namespace b1;

[ReplicateData]
public class BuffInstData
{
	public delegate RepeatedField<ClassDeltaMsgBuffInstData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgBuffInstData> DeltaDataCache;

	private int __BuffID_Raw;

	private int __Layer_Raw;

	private EntitySharedRef __CasterRef_Raw;

	private float __Duration_Raw;

	private EBuffSourceType __BuffSourceType_Raw;

	private BindListFloat __CachedFixFunctionReturnValues_Raw;

	private BindDictEPropType_UInt __PropMgrHandleID_Raw;

	public float AlmostEndAheadTime;

	public bool bActive;

	public float UpdateTimer;

	public bool bHasTriggerAlmostEndLogic;

	public bool HasTriggerAllRemoveByBuff;

	public bool BuffEndTriggerByRemove;

	public bool BuffEndTriggerByDead;

	public Dictionary<int, EntitySharedRefDic<int>> EffectTargetDic = new Dictionary<int, EntitySharedRefDic<int>>();

	private List<EntitySharedRef> EffectTargetNeedRemoveList = new List<EntitySharedRef>();

	public bool bHasTriggeredApplyByBuff;

	public FBattleAttrSnapShot Caster_AttrMemData;

	public float GCTimeMarker = -1f;

	public const float GCOverTime = 150f;

	protected RepeatedField<ClassDeltaMsgBuffInstData> DeltaData
	{
		get
		{
			if (GetDeltaDataFunc != null && DeltaDataCache == null)
			{
				DeltaDataCache = GetDeltaDataFunc();
			}
			return DeltaDataCache;
		}
	}

	[GSReplicated]
	[GSGameDataSnapShot]
	public int BuffID
	{
		get
		{
			return __BuffID_Raw;
		}
		set
		{
			int _BuffID_Raw = __BuffID_Raw;
			__BuffID_Raw = value;
			OnBuffIDChg_Invoke(_BuffID_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	public float DelayTime { get; set; }

	[GSGameDataSnapShot]
	public float LeftTime { get; set; }

	[GSReplicated]
	[GSGameDataSnapShot]
	public int Layer
	{
		get
		{
			return __Layer_Raw;
		}
		set
		{
			int _Layer_Raw = __Layer_Raw;
			__Layer_Raw = value;
			OnLayerChg_Invoke(_Layer_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	public EntitySharedRef RootCasterRef { get; set; }

	[GSReplicated]
	[GSGameDataSnapShot]
	public EntitySharedRef CasterRef
	{
		get
		{
			return __CasterRef_Raw;
		}
		set
		{
			EntitySharedRef _CasterRef_Raw = __CasterRef_Raw;
			__CasterRef_Raw = value;
			OnCasterRefChg_Invoke(_CasterRef_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	public EntitySharedRef OwnerRef { get; set; }

	[GSReplicated]
	[GSGameDataSnapShot]
	public float Duration
	{
		get
		{
			return __Duration_Raw;
		}
		set
		{
			float _Duration_Raw = __Duration_Raw;
			__Duration_Raw = value;
			OnDurationChg_Invoke(_Duration_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	[GSReplicated]
	public EBuffSourceType BuffSourceType
	{
		get
		{
			return __BuffSourceType_Raw;
		}
		set
		{
			EBuffSourceType _BuffSourceType_Raw = __BuffSourceType_Raw;
			__BuffSourceType_Raw = value;
			OnBuffSourceTypeChg_Invoke(_BuffSourceType_Raw, value);
		}
	}

	[GSReplicated]
	public BindListFloat CachedFixFunctionReturnValues
	{
		get
		{
			return __CachedFixFunctionReturnValues_Raw;
		}
		set
		{
			BindListFloat _CachedFixFunctionReturnValues_Raw = __CachedFixFunctionReturnValues_Raw;
			__CachedFixFunctionReturnValues_Raw = value;
			OnCachedFixFunctionReturnValuesChg_Invoke(_CachedFixFunctionReturnValues_Raw, value);
		}
	}

	[GSReplicated]
	public BindDictEPropType_UInt PropMgrHandleID
	{
		get
		{
			return __PropMgrHandleID_Raw;
		}
		set
		{
			BindDictEPropType_UInt _PropMgrHandleID_Raw = __PropMgrHandleID_Raw;
			__PropMgrHandleID_Raw = value;
			OnPropMgrHandleIDChg_Invoke(_PropMgrHandleID_Raw, value);
		}
	}

	public bool bAlreadyDisplayed_Normal { get; set; }

	public bool bAlreadyDisplayed_Single { get; set; }

	public event Action<int, int> OnBuffIDChg;

	public event Action<int, int> OnLayerChg;

	public event Action<EntitySharedRef, EntitySharedRef> OnCasterRefChg;

	public event Action<float, float> OnDurationChg;

	public event Action<EBuffSourceType, EBuffSourceType> OnBuffSourceTypeChg;

	public event Action<BindListFloat, BindListFloat> OnCachedFixFunctionReturnValuesChg;

	public event Action<BindDictEPropType_UInt, BindDictEPropType_UInt> OnPropMgrHandleIDChg;

	public virtual void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			CachedFixFunctionReturnValues?.RegGetDeltaDataFunc(AllocRepDataForCachedFixFunctionReturnValues);
			PropMgrHandleID?.RegGetDeltaDataFunc(AllocRepDataForPropMgrHandleID);
		}
		else
		{
			CachedFixFunctionReturnValues?.RegGetDeltaDataFunc(null);
			PropMgrHandleID?.RegGetDeltaDataFunc(null);
		}
		CachedFixFunctionReturnValues?.RefreshGetDeltaDataFunc(IsActive);
		PropMgrHandleID?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgFloat> AllocRepDataForCachedFixFunctionReturnValues()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
			classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
			classDeltaMsgBuffInstData.Op = OPType.Modify;
			classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgBuffInstData);
			return classDeltaMsgBuffInstData.Value.CachedFixFunctionReturnValues;
		}
		return null;
	}

	private RepeatedField<DictDeltaMsgEPropType_UInt> AllocRepDataForPropMgrHandleID()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
			classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
			classDeltaMsgBuffInstData.Op = OPType.Modify;
			classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgBuffInstData);
			return classDeltaMsgBuffInstData.Value.PropMgrHandleID;
		}
		return null;
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
	}

	public virtual int GetGSRepSubClassIdx()
	{
		return -1;
	}

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgBuffInstData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgBuffInstData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
		classDeltaMsgBuffInstData.Op = OPType.Modify;
		classDeltaMsgBuffInstData.Version = version;
		classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
		classDeltaMsgBuffInstData.Value.BuffID = BuffID;
		classDeltaMsgBuffInstData.Value.Layer = Layer;
		classDeltaMsgBuffInstData.Value.CasterRef = BGUFuncLibReplication.GetNetGUIDByEntitySharedRef(CasterRef);
		classDeltaMsgBuffInstData.Value.Duration = Duration;
		classDeltaMsgBuffInstData.Value.BuffSourceType = (int)BuffSourceType;
		if (CachedFixFunctionReturnValues == null)
		{
			classDeltaMsgBuffInstData.Value.CachedFixFunctionReturnValues.Add(new ListDeltaMsgFloat
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			CachedFixFunctionReturnValues.DumpFull(classDeltaMsgBuffInstData.Value.CachedFixFunctionReturnValues);
		}
		if (PropMgrHandleID == null)
		{
			classDeltaMsgBuffInstData.Value.PropMgrHandleID.Add(new DictDeltaMsgEPropType_UInt
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			PropMgrHandleID.DumpFull(classDeltaMsgBuffInstData.Value.PropMgrHandleID);
		}
		Data.Add(classDeltaMsgBuffInstData);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		CachedFixFunctionReturnValues?.ClearDeltaData();
		PropMgrHandleID?.ClearDeltaData();
	}

	private void OnBuffIDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
				classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
				classDeltaMsgBuffInstData.Op = OPType.Modify;
				classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgBuffInstData);
				classDeltaMsgBuffInstData.Value.BuffID = NewValue;
			}
			this.OnBuffIDChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLayerChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
				classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
				classDeltaMsgBuffInstData.Op = OPType.Modify;
				classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgBuffInstData);
				classDeltaMsgBuffInstData.Value.Layer = NewValue;
			}
			this.OnLayerChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCasterRefChg_Invoke(EntitySharedRef OldValue, EntitySharedRef NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
				classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
				classDeltaMsgBuffInstData.Op = OPType.Modify;
				classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgBuffInstData);
				classDeltaMsgBuffInstData.Value.CasterRef = BGUFuncLibReplication.GetNetGUIDByEntitySharedRef(NewValue);
			}
			this.OnCasterRefChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnDurationChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
				classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
				classDeltaMsgBuffInstData.Op = OPType.Modify;
				classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgBuffInstData);
				classDeltaMsgBuffInstData.Value.Duration = NewValue;
			}
			this.OnDurationChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnBuffSourceTypeChg_Invoke(EBuffSourceType OldValue, EBuffSourceType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
				classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
				classDeltaMsgBuffInstData.Op = OPType.Modify;
				classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgBuffInstData);
				classDeltaMsgBuffInstData.Value.BuffSourceType = (int)NewValue;
			}
			this.OnBuffSourceTypeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnCachedFixFunctionReturnValuesChg_Invoke(BindListFloat OldValue, BindListFloat NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
			classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
			classDeltaMsgBuffInstData.Op = OPType.Modify;
			classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgBuffInstData);
			if (NewValue == null)
			{
				classDeltaMsgBuffInstData.Value.CachedFixFunctionReturnValues.Add(new ListDeltaMsgFloat
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForCachedFixFunctionReturnValues);
				NewValue.DumpFull(classDeltaMsgBuffInstData.Value.CachedFixFunctionReturnValues);
			}
		}
		this.OnCachedFixFunctionReturnValuesChg?.Invoke(OldValue, NewValue);
	}

	private void OnPropMgrHandleIDChg_Invoke(BindDictEPropType_UInt OldValue, BindDictEPropType_UInt NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgBuffInstData classDeltaMsgBuffInstData = new ClassDeltaMsgBuffInstData();
			classDeltaMsgBuffInstData.Value = new GurGsStruct.BuffInstData();
			classDeltaMsgBuffInstData.Op = OPType.Modify;
			classDeltaMsgBuffInstData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgBuffInstData);
			if (NewValue == null)
			{
				classDeltaMsgBuffInstData.Value.PropMgrHandleID.Add(new DictDeltaMsgEPropType_UInt
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForPropMgrHandleID);
				NewValue.DumpFull(classDeltaMsgBuffInstData.Value.PropMgrHandleID);
			}
		}
		this.OnPropMgrHandleIDChg?.Invoke(OldValue, NewValue);
	}

	public void AddEffectTarget(int EffectIdx, AActor Target)
	{
		if (EffectTargetDic.TryGetValue(EffectIdx, out var value))
		{
			if (value == null)
			{
				value = new EntitySharedRefDic<int>();
			}
			int value2 = ((!value.TryGetValue(Target, out value2)) ? 1 : (value2 + 1));
			value[Target] = value2;
			EffectTargetDic[EffectIdx] = value;
		}
		else
		{
			if (value == null)
			{
				value = new EntitySharedRefDic<int>();
			}
			value[Target] = 1;
			EffectTargetDic.Add(EffectIdx, value);
		}
	}

	public void ClearTargetDic(bool IsBuffEnd)
	{
		if (EffectTargetDic == null)
		{
			return;
		}
		if (IsBuffEnd)
		{
			EffectTargetDic.Clear();
			return;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, EntitySharedRefDic<int>> item in EffectTargetDic)
		{
			int key = item.Key;
			EntitySharedRefDic<int> value = item.Value;
			int num = value.Count;
			foreach (KeyValuePair<EntitySharedRef, int> item2 in value)
			{
				if (item2.Value <= 0)
				{
					num--;
				}
			}
			if (num <= 0)
			{
				list.Add(key);
			}
		}
		foreach (int item3 in list)
		{
			EffectTargetDic[item3].Clear();
		}
	}

	public void AddPropMgrHandleID(EPropType PropType, uint HandleID)
	{
		if (PropMgrHandleID == null)
		{
			PropMgrHandleID = new BindDictEPropType_UInt();
		}
		if (PropMgrHandleID.ContainsKey(PropType))
		{
			PropMgrHandleID[PropType] = HandleID;
		}
		else
		{
			PropMgrHandleID.Add(PropType, HandleID);
		}
	}

	public void ClearPropMgrHandleID()
	{
		if (PropMgrHandleID != null)
		{
			PropMgrHandleID.Clear();
		}
	}

	public void RemovePropMgrHandleID(EPropType Type)
	{
		if (PropMgrHandleID != null)
		{
			PropMgrHandleID.Remove(Type);
		}
	}

	public void ReliabilityUpdate(float CurrentTimeInSeconds)
	{
		foreach (KeyValuePair<int, EntitySharedRefDic<int>> item in EffectTargetDic)
		{
			EffectTargetNeedRemoveList.Clear();
			int key = item.Key;
			foreach (EntitySharedRef key2 in EffectTargetDic[key].Keys)
			{
				if (EntitySharedRefFuncLib.Actor(key2) == null)
				{
					EffectTargetNeedRemoveList.Add(key2);
				}
			}
			foreach (EntitySharedRef effectTargetNeedRemove in EffectTargetNeedRemoveList)
			{
				EffectTargetDic[key].Remove(effectTargetNeedRemove);
			}
		}
		if (GCTimeMarker < 0f && (EntitySharedRefFuncLib.Actor(RootCasterRef) == null || EntitySharedRefFuncLib.Actor(CasterRef) == null))
		{
			GCTimeMarker = CurrentTimeInSeconds;
		}
	}

	public bool bNeedRemove_Over3Min(float CurrentTimeInSeconds)
	{
		if (GCTimeMarker > 0f && CurrentTimeInSeconds - GCTimeMarker >= 150f)
		{
			return true;
		}
		return false;
	}
}
