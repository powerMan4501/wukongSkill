using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class FRepInnerClass
{
	public delegate RepeatedField<ClassDeltaMsgFRepInnerClass> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgFRepInnerClass> DeltaDataCache;

	private int __InnerInt_Raw;

	protected RepeatedField<ClassDeltaMsgFRepInnerClass> DeltaData
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
	public int InnerInt
	{
		get
		{
			return __InnerInt_Raw;
		}
		set
		{
			int _InnerInt_Raw = __InnerInt_Raw;
			__InnerInt_Raw = value;
			OnInnerIntChg_Invoke(_InnerInt_Raw, value);
		}
	}

	public event Action<int, int> OnInnerIntChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgFRepInnerClass> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgFRepInnerClass
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgFRepInnerClass classDeltaMsgFRepInnerClass = new ClassDeltaMsgFRepInnerClass();
		classDeltaMsgFRepInnerClass.Op = OPType.Modify;
		classDeltaMsgFRepInnerClass.Version = version;
		classDeltaMsgFRepInnerClass.Value = new GurGsStruct.FRepInnerClass();
		classDeltaMsgFRepInnerClass.Value.InnerInt = InnerInt;
		Data.Add(classDeltaMsgFRepInnerClass);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnInnerIntChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgFRepInnerClass classDeltaMsgFRepInnerClass = new ClassDeltaMsgFRepInnerClass();
				classDeltaMsgFRepInnerClass.Value = new GurGsStruct.FRepInnerClass();
				classDeltaMsgFRepInnerClass.Op = OPType.Modify;
				classDeltaMsgFRepInnerClass.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgFRepInnerClass);
				classDeltaMsgFRepInnerClass.Value.InnerInt = NewValue;
			}
			this.OnInnerIntChg?.Invoke(OldValue, NewValue);
		}
	}
}
