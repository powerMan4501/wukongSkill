using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class GSUnitBookData
{
	public delegate RepeatedField<ClassDeltaMsgGSUnitBookData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgGSUnitBookData> DeltaDataCache;

	private bool __IsFirstSightRead_Raw;

	private bool __IsStory1Read_Raw;

	private int __MIParamFirst_Raw;

	private int __MIParamFull_Raw;

	protected RepeatedField<ClassDeltaMsgGSUnitBookData> DeltaData
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
	[GSPersistent]
	public bool IsFirstSightRead
	{
		get
		{
			return __IsFirstSightRead_Raw;
		}
		set
		{
			bool _IsFirstSightRead_Raw = __IsFirstSightRead_Raw;
			__IsFirstSightRead_Raw = value;
			OnIsFirstSightReadChg_Invoke(_IsFirstSightRead_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	[GSReplicated]
	[GSPersistent]
	public bool IsStory1Read
	{
		get
		{
			return __IsStory1Read_Raw;
		}
		set
		{
			bool _IsStory1Read_Raw = __IsStory1Read_Raw;
			__IsStory1Read_Raw = value;
			OnIsStory1ReadChg_Invoke(_IsStory1Read_Raw, value);
		}
	}

	[GSGameDataSnapShot]
	[GSPersistent]
	[GSReplicated]
	public int MIParamFirst
	{
		get
		{
			return __MIParamFirst_Raw;
		}
		set
		{
			int _MIParamFirst_Raw = __MIParamFirst_Raw;
			__MIParamFirst_Raw = value;
			OnMIParamFirstChg_Invoke(_MIParamFirst_Raw, value);
		}
	}

	[GSPersistent]
	[GSReplicated]
	[GSGameDataSnapShot]
	public int MIParamFull
	{
		get
		{
			return __MIParamFull_Raw;
		}
		set
		{
			int _MIParamFull_Raw = __MIParamFull_Raw;
			__MIParamFull_Raw = value;
			OnMIParamFullChg_Invoke(_MIParamFull_Raw, value);
		}
	}

	public event Action<bool, bool> OnIsFirstSightReadChg;

	public event Action<bool, bool> OnIsStory1ReadChg;

	public event Action<int, int> OnMIParamFirstChg;

	public event Action<int, int> OnMIParamFullChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgGSUnitBookData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgGSUnitBookData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgGSUnitBookData classDeltaMsgGSUnitBookData = new ClassDeltaMsgGSUnitBookData();
		classDeltaMsgGSUnitBookData.Op = OPType.Modify;
		classDeltaMsgGSUnitBookData.Version = version;
		classDeltaMsgGSUnitBookData.Value = new GurGsStruct.GSUnitBookData();
		classDeltaMsgGSUnitBookData.Value.IsFirstSightRead = IsFirstSightRead;
		classDeltaMsgGSUnitBookData.Value.IsStory1Read = IsStory1Read;
		classDeltaMsgGSUnitBookData.Value.MIParamFirst = MIParamFirst;
		classDeltaMsgGSUnitBookData.Value.MIParamFull = MIParamFull;
		Data.Add(classDeltaMsgGSUnitBookData);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnIsFirstSightReadChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgGSUnitBookData classDeltaMsgGSUnitBookData = new ClassDeltaMsgGSUnitBookData();
				classDeltaMsgGSUnitBookData.Value = new GurGsStruct.GSUnitBookData();
				classDeltaMsgGSUnitBookData.Op = OPType.Modify;
				classDeltaMsgGSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgGSUnitBookData);
				classDeltaMsgGSUnitBookData.Value.IsFirstSightRead = NewValue;
			}
			this.OnIsFirstSightReadChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnIsStory1ReadChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgGSUnitBookData classDeltaMsgGSUnitBookData = new ClassDeltaMsgGSUnitBookData();
				classDeltaMsgGSUnitBookData.Value = new GurGsStruct.GSUnitBookData();
				classDeltaMsgGSUnitBookData.Op = OPType.Modify;
				classDeltaMsgGSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgGSUnitBookData);
				classDeltaMsgGSUnitBookData.Value.IsStory1Read = NewValue;
			}
			this.OnIsStory1ReadChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMIParamFirstChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgGSUnitBookData classDeltaMsgGSUnitBookData = new ClassDeltaMsgGSUnitBookData();
				classDeltaMsgGSUnitBookData.Value = new GurGsStruct.GSUnitBookData();
				classDeltaMsgGSUnitBookData.Op = OPType.Modify;
				classDeltaMsgGSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgGSUnitBookData);
				classDeltaMsgGSUnitBookData.Value.MIParamFirst = NewValue;
			}
			this.OnMIParamFirstChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMIParamFullChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgGSUnitBookData classDeltaMsgGSUnitBookData = new ClassDeltaMsgGSUnitBookData();
				classDeltaMsgGSUnitBookData.Value = new GurGsStruct.GSUnitBookData();
				classDeltaMsgGSUnitBookData.Op = OPType.Modify;
				classDeltaMsgGSUnitBookData.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgGSUnitBookData);
				classDeltaMsgGSUnitBookData.Value.MIParamFull = NewValue;
			}
			this.OnMIParamFullChg?.Invoke(OldValue, NewValue);
		}
	}
}
