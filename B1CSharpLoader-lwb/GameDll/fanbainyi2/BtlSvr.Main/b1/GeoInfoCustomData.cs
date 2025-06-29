using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class GeoInfoCustomData
{
	public delegate RepeatedField<ClassDeltaMsgGeoInfoCustomData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgGeoInfoCustomData> DeltaDataCache;

	private int __Id_Raw;

	private int __MapId_Raw;

	private float __PosX_Raw;

	private float __PosY_Raw;

	private EGeoInfoCustomType __GeoInfoCustomType_Raw;

	[GSPersistent]
	public int Id
	{
		get
		{
			return __Id_Raw;
		}
		set
		{
			int _Id_Raw = __Id_Raw;
			__Id_Raw = value;
			OnIdChg_Invoke(_Id_Raw, value);
		}
	}

	[GSPersistent]
	public int MapId
	{
		get
		{
			return __MapId_Raw;
		}
		set
		{
			int _MapId_Raw = __MapId_Raw;
			__MapId_Raw = value;
			OnMapIdChg_Invoke(_MapId_Raw, value);
		}
	}

	[GSPersistent]
	public float PosX
	{
		get
		{
			return __PosX_Raw;
		}
		set
		{
			float _PosX_Raw = __PosX_Raw;
			__PosX_Raw = value;
			OnPosXChg_Invoke(_PosX_Raw, value);
		}
	}

	[GSPersistent]
	public float PosY
	{
		get
		{
			return __PosY_Raw;
		}
		set
		{
			float _PosY_Raw = __PosY_Raw;
			__PosY_Raw = value;
			OnPosYChg_Invoke(_PosY_Raw, value);
		}
	}

	[GSPersistent]
	public EGeoInfoCustomType GeoInfoCustomType
	{
		get
		{
			return __GeoInfoCustomType_Raw;
		}
		set
		{
			EGeoInfoCustomType _GeoInfoCustomType_Raw = __GeoInfoCustomType_Raw;
			__GeoInfoCustomType_Raw = value;
			OnGeoInfoCustomTypeChg_Invoke(_GeoInfoCustomType_Raw, value);
		}
	}

	protected RepeatedField<ClassDeltaMsgGeoInfoCustomData> DeltaData
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

	public event Action<int, int> OnIdChg;

	public event Action<int, int> OnMapIdChg;

	public event Action<float, float> OnPosXChg;

	public event Action<float, float> OnPosYChg;

	public event Action<EGeoInfoCustomType, EGeoInfoCustomType> OnGeoInfoCustomTypeChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgGeoInfoCustomData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgGeoInfoCustomData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgGeoInfoCustomData classDeltaMsgGeoInfoCustomData = new ClassDeltaMsgGeoInfoCustomData();
		classDeltaMsgGeoInfoCustomData.Op = OPType.Modify;
		classDeltaMsgGeoInfoCustomData.Version = version;
		classDeltaMsgGeoInfoCustomData.Value = new GurGsStruct.GeoInfoCustomData();
		Data.Add(classDeltaMsgGeoInfoCustomData);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMapIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnMapIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnPosXChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPosXChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnPosYChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPosYChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnGeoInfoCustomTypeChg_Invoke(EGeoInfoCustomType OldValue, EGeoInfoCustomType NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnGeoInfoCustomTypeChg?.Invoke(OldValue, NewValue);
		}
	}
}
