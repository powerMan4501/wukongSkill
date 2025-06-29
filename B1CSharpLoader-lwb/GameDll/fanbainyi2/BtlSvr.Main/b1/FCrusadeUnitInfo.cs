using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class FCrusadeUnitInfo
{
	public delegate RepeatedField<ClassDeltaMsgFCrusadeUnitInfo> Del_GetRepData();

	public int RebirthPoint;

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgFCrusadeUnitInfo> DeltaDataCache;

	private ECrusadeState __CrusadeState_Raw;

	[GSReplicated]
	public ECrusadeState CrusadeState
	{
		get
		{
			return __CrusadeState_Raw;
		}
		set
		{
			ECrusadeState _CrusadeState_Raw = __CrusadeState_Raw;
			__CrusadeState_Raw = value;
			OnCrusadeStateChg_Invoke(_CrusadeState_Raw, value);
		}
	}

	protected RepeatedField<ClassDeltaMsgFCrusadeUnitInfo> DeltaData
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

	public event Action<ECrusadeState, ECrusadeState> OnCrusadeStateChg;

	public virtual void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
	}

	public virtual int GetGSRepSubClassIdx()
	{
		return -1;
	}

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgFCrusadeUnitInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgFCrusadeUnitInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgFCrusadeUnitInfo classDeltaMsgFCrusadeUnitInfo = new ClassDeltaMsgFCrusadeUnitInfo();
		classDeltaMsgFCrusadeUnitInfo.Op = OPType.Modify;
		classDeltaMsgFCrusadeUnitInfo.Version = version;
		classDeltaMsgFCrusadeUnitInfo.Value = new GurGsStruct.FCrusadeUnitInfo();
		classDeltaMsgFCrusadeUnitInfo.Value.CrusadeState = (int)CrusadeState;
		Data.Add(classDeltaMsgFCrusadeUnitInfo);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnCrusadeStateChg_Invoke(ECrusadeState OldValue, ECrusadeState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgFCrusadeUnitInfo classDeltaMsgFCrusadeUnitInfo = new ClassDeltaMsgFCrusadeUnitInfo();
				classDeltaMsgFCrusadeUnitInfo.Value = new GurGsStruct.FCrusadeUnitInfo();
				classDeltaMsgFCrusadeUnitInfo.Op = OPType.Modify;
				classDeltaMsgFCrusadeUnitInfo.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgFCrusadeUnitInfo);
				classDeltaMsgFCrusadeUnitInfo.Value.CrusadeState = (int)NewValue;
			}
			this.OnCrusadeStateChg?.Invoke(OldValue, NewValue);
		}
	}
}
