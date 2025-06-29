using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class FBirthPointInfo
{
	public delegate RepeatedField<ClassDeltaMsgFBirthPointInfo> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgFBirthPointInfo> DeltaDataCache;

	private EBirthPointType __PointType_Raw;

	private int __PointID_Raw;

	protected RepeatedField<ClassDeltaMsgFBirthPointInfo> DeltaData
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

	[GSPersistent]
	public EBirthPointType PointType
	{
		get
		{
			return __PointType_Raw;
		}
		set
		{
			EBirthPointType _PointType_Raw = __PointType_Raw;
			__PointType_Raw = value;
			OnPointTypeChg_Invoke(_PointType_Raw, value);
		}
	}

	[GSPersistent]
	public int PointID
	{
		get
		{
			return __PointID_Raw;
		}
		set
		{
			int _PointID_Raw = __PointID_Raw;
			__PointID_Raw = value;
			OnPointIDChg_Invoke(_PointID_Raw, value);
		}
	}

	public event Action<EBirthPointType, EBirthPointType> OnPointTypeChg;

	public event Action<int, int> OnPointIDChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgFBirthPointInfo> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgFBirthPointInfo
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgFBirthPointInfo classDeltaMsgFBirthPointInfo = new ClassDeltaMsgFBirthPointInfo();
		classDeltaMsgFBirthPointInfo.Op = OPType.Modify;
		classDeltaMsgFBirthPointInfo.Version = version;
		classDeltaMsgFBirthPointInfo.Value = new GurGsStruct.FBirthPointInfo();
		Data.Add(classDeltaMsgFBirthPointInfo);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnPointTypeChg_Invoke(EBirthPointType OldValue, EBirthPointType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPointTypeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnPointIDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPointIDChg?.Invoke(OldValue, NewValue);
		}
	}
}
