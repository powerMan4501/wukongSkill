using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCMergeNiagaraMangerInfo
{
	public class CachedChildEventInfo
	{
		public bool isCurTickDoPlay;

		public bool SpawnInfoHasSendToMgr;

		public DBCPlayAdvanceNiagaraInfo Info;

		public int EventIndex { get; private set; }

		public CachedChildEventInfo(int _EventIndex, DBCPlayAdvanceNiagaraInfo SourceInfo)
		{
			EventIndex = _EventIndex;
			isCurTickDoPlay = true;
			Info = SourceInfo;
		}
	}

	public TStrongObjectPtr<UNiagaraComponent> MangerSystemComp = new TStrongObjectPtr<UNiagaraComponent>();

	public float ChildEventQueueSleepAtTime = -100f;

	public SortedDictionary<uint, CachedChildEventInfo> CachedChildDBCNiagaraEventInfo = new SortedDictionary<uint, CachedChildEventInfo>();

	public bool PreTickHasSendNewEvent = true;

	public bool PreTickHasSendCustomDataEvent;

	public int[] MgrArray_CurTickNewDoPlayChildEventIndex;

	public int[] MgrArray_CurTickValidChildEventIndex;

	public FVector[] MgrArray_SystemPosWS;

	public FQuat[] MgrArray_SystemRotationWS;

	public FVector[] MgrArray_SystemScaleWS;

	public FVector[] MgrArray_CurTickChildEventLifeState;

	public Dictionary<string, FVector[]> MgrArray_CustomVectorData;

	public Dictionary<string, FName> MgrArray_CustomVectorParamNameMapping;

	public uint MangerSystemTemplateUniqueID { get; private set; }

	public bool SendRotation { get; private set; }

	public bool SendScaleAtEventSpawn { get; private set; }

	public bool SendScaleEveryTick { get; private set; }

	public int ChildEventIndexACC { get; private set; } = -1;

	public int GetNewChildEventIndex()
	{
		ChildEventIndexACC++;
		ChildEventIndexACC = Math.Max(0, ChildEventIndexACC);
		return ChildEventIndexACC;
	}

	public bool IsValid()
	{
		if (MangerSystemComp != null && !MangerSystemComp.Get().IsNullOrDestroyed())
		{
			return CachedChildDBCNiagaraEventInfo != null;
		}
		return false;
	}

	public DBCMergeNiagaraMangerInfo(UObject WorldContextObject, BUC_DispLibDBC_NiagaraEventMergedSettings MergedSettings, FVector SpawnPosWS)
	{
		UNiagaraSystem mergeMangerSystem = MergedSettings.MergeMangerSystem;
		if (mergeMangerSystem.IsNullOrDestroyed() || WorldContextObject.IsNullOrDestroyed())
		{
			return;
		}
		MangerSystemTemplateUniqueID = mergeMangerSystem.GetUniqueID();
		SendRotation = MergedSettings.SendRotationInfo;
		SendScaleAtEventSpawn = MergedSettings.SendScaleInfo;
		SendScaleEveryTick = MergedSettings.SendScaleEveryTick;
		int perCreateCount = MergedSettings.PerCreateCount;
		MgrArray_CurTickNewDoPlayChildEventIndex = new int[perCreateCount];
		MgrArray_CurTickValidChildEventIndex = new int[perCreateCount];
		MgrArray_CurTickChildEventLifeState = new FVector[perCreateCount];
		MgrArray_SystemPosWS = new FVector[perCreateCount];
		if (SendRotation)
		{
			MgrArray_SystemRotationWS = new FQuat[perCreateCount];
		}
		if (SendScaleAtEventSpawn)
		{
			MgrArray_SystemScaleWS = new FVector[perCreateCount];
		}
		if (MergedSettings.HasCustomVectorParam && MergedSettings.CustomVectorParamNameMap != null && MergedSettings.CustomVectorParamNameMap.Count > 0)
		{
			MgrArray_CustomVectorData = new Dictionary<string, FVector[]>();
			MgrArray_CustomVectorParamNameMapping = new Dictionary<string, FName>();
			foreach (KeyValuePair<FName, FName> item in MergedSettings.CustomVectorParamNameMap)
			{
				string plainName = item.Key.PlainName;
				if (!MgrArray_CustomVectorData.ContainsKey(plainName))
				{
					MgrArray_CustomVectorData.Add(plainName, new FVector[0]);
					MgrArray_CustomVectorParamNameMapping.Add(plainName, item.Value);
				}
			}
		}
		UNiagaraComponent uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAtLocation(WorldContextObject, mergeMangerSystem, SpawnPosWS, FRotator.ZeroRotator, FVector.OneVector, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.ManualRelease, bPreCullCheck: false);
		if (!uNiagaraComponent.IsNullOrDestroyed())
		{
			uNiagaraComponent.SetForceSolo(bInForceSolo: true);
			uNiagaraComponent.ComponentTags.Add(B1GlobalFNames.DBCNG);
			MangerSystemComp.Set(uNiagaraComponent);
		}
	}

	public void OnOneChildEventDoPlay(DBCPlayAdvanceNiagaraInfo MergeNiagaraEventInfo)
	{
		if (MergeNiagaraEventInfo.IdentityID == 0 || CachedChildDBCNiagaraEventInfo.TryGetValue(MergeNiagaraEventInfo.IdentityID, out var value))
		{
			return;
		}
		int newChildEventIndex = GetNewChildEventIndex();
		value = new CachedChildEventInfo(newChildEventIndex, MergeNiagaraEventInfo);
		value.isCurTickDoPlay = true;
		CachedChildDBCNiagaraEventInfo.Add(MergeNiagaraEventInfo.IdentityID, value);
		int num = 5;
		if (newChildEventIndex >= MgrArray_CurTickNewDoPlayChildEventIndex.Length)
		{
			int newSize = MgrArray_CurTickNewDoPlayChildEventIndex.Length + num;
			Array.Resize(ref MgrArray_CurTickNewDoPlayChildEventIndex, newSize);
			Array.Resize(ref MgrArray_CurTickValidChildEventIndex, newSize);
			Array.Resize(ref MgrArray_CurTickChildEventLifeState, newSize);
			Array.Resize(ref MgrArray_SystemPosWS, newSize);
			if (SendRotation)
			{
				Array.Resize(ref MgrArray_SystemRotationWS, newSize);
			}
			if (SendScaleAtEventSpawn)
			{
				Array.Resize(ref MgrArray_SystemScaleWS, newSize);
			}
			if (MgrArray_CustomVectorData != null)
			{
				for (int i = 0; i < MgrArray_CustomVectorData.Count; i++)
				{
					KeyValuePair<string, FVector[]> keyValuePair = MgrArray_CustomVectorData.ElementAt(i);
					FVector[] array = keyValuePair.Value;
					Array.Resize(ref array, newSize);
					MgrArray_CustomVectorData[keyValuePair.Key] = array;
				}
			}
		}
		MgrArray_CurTickNewDoPlayChildEventIndex[newChildEventIndex] = 0;
		MgrArray_CurTickValidChildEventIndex[newChildEventIndex] = 0;
		MgrArray_CurTickChildEventLifeState[newChildEventIndex] = new FVector(MergeNiagaraEventInfo.GameAge, 1.0, 0.0);
		MgrArray_SystemPosWS[newChildEventIndex] = FVector.ZeroVector;
		if (SendRotation)
		{
			MgrArray_SystemRotationWS[newChildEventIndex] = FQuat.Identity;
		}
		if (SendScaleAtEventSpawn)
		{
			MgrArray_SystemScaleWS[newChildEventIndex] = FVector.OneVector;
		}
		if (MgrArray_CustomVectorData == null)
		{
			return;
		}
		foreach (FVector[] value2 in MgrArray_CustomVectorData.Values)
		{
			value2[newChildEventIndex] = FVector.ZeroVector;
		}
	}

	public void OnSetChildEventCustomVectorParam(DBCPlayAdvanceNiagaraInfo ChildEventInfo, string ParamName, FVector Value)
	{
		if (ChildEventInfo.IdentityID != 0 && MgrArray_CustomVectorData != null && MgrArray_CustomVectorData.TryGetValue(ParamName, out var value) && value != null && CachedChildDBCNiagaraEventInfo.TryGetValue(ChildEventInfo.IdentityID, out var value2) && value2.EventIndex < value.Length)
		{
			value[value2.EventIndex] = Value;
			PreTickHasSendCustomDataEvent = true;
		}
	}
}
