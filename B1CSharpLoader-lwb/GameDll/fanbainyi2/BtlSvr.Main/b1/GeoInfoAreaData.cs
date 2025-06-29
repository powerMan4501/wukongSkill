using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class GeoInfoAreaData
{
	public delegate RepeatedField<ClassDeltaMsgGeoInfoAreaData> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgGeoInfoAreaData> DeltaDataCache;

	private int __LevelId_Raw;

	private int __AreaId_Raw;

	private int __MapSpriteId_Raw;

	private EGeoAreaState __GeoAreaState_Raw;

	private double __ExploredTime_Raw;

	[GSPersistent]
	public int LevelId
	{
		get
		{
			return __LevelId_Raw;
		}
		set
		{
			int _LevelId_Raw = __LevelId_Raw;
			__LevelId_Raw = value;
			OnLevelIdChg_Invoke(_LevelId_Raw, value);
		}
	}

	[GSPersistent]
	public int AreaId
	{
		get
		{
			return __AreaId_Raw;
		}
		set
		{
			int _AreaId_Raw = __AreaId_Raw;
			__AreaId_Raw = value;
			OnAreaIdChg_Invoke(_AreaId_Raw, value);
		}
	}

	[GSPersistent]
	public int MapSpriteId
	{
		get
		{
			return __MapSpriteId_Raw;
		}
		set
		{
			int _MapSpriteId_Raw = __MapSpriteId_Raw;
			__MapSpriteId_Raw = value;
			OnMapSpriteIdChg_Invoke(_MapSpriteId_Raw, value);
		}
	}

	[GSPersistent]
	public EGeoAreaState GeoAreaState
	{
		get
		{
			return __GeoAreaState_Raw;
		}
		set
		{
			EGeoAreaState _GeoAreaState_Raw = __GeoAreaState_Raw;
			__GeoAreaState_Raw = value;
			OnGeoAreaStateChg_Invoke(_GeoAreaState_Raw, value);
		}
	}

	[GSPersistent]
	public double ExploredTime
	{
		get
		{
			return __ExploredTime_Raw;
		}
		set
		{
			double _ExploredTime_Raw = __ExploredTime_Raw;
			__ExploredTime_Raw = value;
			OnExploredTimeChg_Invoke(_ExploredTime_Raw, value);
		}
	}

	protected RepeatedField<ClassDeltaMsgGeoInfoAreaData> DeltaData
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

	public event Action<int, int> OnLevelIdChg;

	public event Action<int, int> OnAreaIdChg;

	public event Action<int, int> OnMapSpriteIdChg;

	public event Action<EGeoAreaState, EGeoAreaState> OnGeoAreaStateChg;

	public event Action<double, double> OnExploredTimeChg;

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgGeoInfoAreaData> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgGeoInfoAreaData
		{
			Op = OPType.ChangeRef,
			Version = version
		});
		ClassDeltaMsgGeoInfoAreaData classDeltaMsgGeoInfoAreaData = new ClassDeltaMsgGeoInfoAreaData();
		classDeltaMsgGeoInfoAreaData.Op = OPType.Modify;
		classDeltaMsgGeoInfoAreaData.Version = version;
		classDeltaMsgGeoInfoAreaData.Value = new GurGsStruct.GeoInfoAreaData();
		Data.Add(classDeltaMsgGeoInfoAreaData);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnLevelIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnLevelIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnAreaIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnAreaIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMapSpriteIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnMapSpriteIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnGeoAreaStateChg_Invoke(EGeoAreaState OldValue, EGeoAreaState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnGeoAreaStateChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnExploredTimeChg_Invoke(double OldValue, double NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnExploredTimeChg?.Invoke(OldValue, NewValue);
		}
	}
}
