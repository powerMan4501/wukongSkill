using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class CollectionGroupDataInfo
{
	public delegate RepeatedField<ClassDeltaMsgCollectionGroupDataInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgCollectionGroupDataInfo> DeltaDataCache;

	private int __FreshTime_Raw;

	private int __FreshCount_Raw;

	[GSPersistent]
	public int FreshTime
	{
		get
		{
			return __FreshTime_Raw;
		}
		set
		{
			int _FreshTime_Raw = __FreshTime_Raw;
			__FreshTime_Raw = value;
			OnFreshTimeChg_Invoke(_FreshTime_Raw, value);
		}
	}

	[GSPersistent]
	public int FreshCount
	{
		get
		{
			return __FreshCount_Raw;
		}
		set
		{
			int _FreshCount_Raw = __FreshCount_Raw;
			__FreshCount_Raw = value;
			OnFreshCountChg_Invoke(_FreshCount_Raw, value);
		}
	}

	protected RepeatedField<ClassDeltaMsgCollectionGroupDataInfo> DeltaData
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

	public event Action<int, int> OnFreshTimeChg;

	public event Action<int, int> OnFreshCountChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgCollectionGroupDataInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgCollectionGroupDataInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgCollectionGroupDataInfo classDeltaMsgCollectionGroupDataInfo = new ClassDeltaMsgCollectionGroupDataInfo();
		classDeltaMsgCollectionGroupDataInfo.Op = OPType.Modify;
		classDeltaMsgCollectionGroupDataInfo.Version = version;
		classDeltaMsgCollectionGroupDataInfo.Value = new GurGsStruct.CollectionGroupDataInfo();
		Data.Add(classDeltaMsgCollectionGroupDataInfo);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnFreshTimeChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnFreshTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnFreshCountChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnFreshCountChg?.Invoke(OldValue, NewValue);
		}
	}
}
