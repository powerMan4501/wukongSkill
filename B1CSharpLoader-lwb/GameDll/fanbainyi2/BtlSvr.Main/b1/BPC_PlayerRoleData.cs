using System;
using ArchiveB1;
using b1.ECS;
using CommB1;
using GUR.Runtime;

namespace b1;

public class BPC_PlayerRoleData : IBPC_PlayerRoleData, IPersistentECSData
{
	private int __BeginAreaStayTime_Raw;

	private int __LastRebirthPointTime_Raw;

	private int __MapAreaId_Raw;

	private int __MaxMapAreaId_Raw;

	private int __MaxMapId_Raw;

	private int __MapId_Raw;

	private int __Demo820MapIdx_Raw;

	private int __DefaultShortcutsPosition_Raw;

	private BindDictInt_GSUnitBookData __UnitBookDataDic_Raw;

	private BindListInt __SurprisePerformedList_Raw;

	private ReadOnlyRoleData RoleDataReadOnly;

	private ReadOnlyRoleDataClient RoleDataClientReadOnly;

	[GSPersistent]
	public int BeginAreaStayTime
	{
		get
		{
			return __BeginAreaStayTime_Raw;
		}
		set
		{
			int _BeginAreaStayTime_Raw = __BeginAreaStayTime_Raw;
			__BeginAreaStayTime_Raw = value;
			OnBeginAreaStayTimeChg_Invoke(_BeginAreaStayTime_Raw, value);
		}
	}

	[GSPersistent]
	public int LastRebirthPointTime
	{
		get
		{
			return __LastRebirthPointTime_Raw;
		}
		set
		{
			int _LastRebirthPointTime_Raw = __LastRebirthPointTime_Raw;
			__LastRebirthPointTime_Raw = value;
			OnLastRebirthPointTimeChg_Invoke(_LastRebirthPointTime_Raw, value);
		}
	}

	[GSPersistent]
	public int MapAreaId
	{
		get
		{
			return __MapAreaId_Raw;
		}
		set
		{
			int _MapAreaId_Raw = __MapAreaId_Raw;
			__MapAreaId_Raw = value;
			OnMapAreaIdChg_Invoke(_MapAreaId_Raw, value);
		}
	}

	[GSPersistent]
	public int MaxMapAreaId
	{
		get
		{
			return __MaxMapAreaId_Raw;
		}
		set
		{
			int _MaxMapAreaId_Raw = __MaxMapAreaId_Raw;
			__MaxMapAreaId_Raw = value;
			OnMaxMapAreaIdChg_Invoke(_MaxMapAreaId_Raw, value);
		}
	}

	[GSPersistent]
	public int MaxMapId
	{
		get
		{
			return __MaxMapId_Raw;
		}
		set
		{
			int _MaxMapId_Raw = __MaxMapId_Raw;
			__MaxMapId_Raw = value;
			OnMaxMapIdChg_Invoke(_MaxMapId_Raw, value);
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
	public int Demo820MapIdx
	{
		get
		{
			return __Demo820MapIdx_Raw;
		}
		set
		{
			int _Demo820MapIdx_Raw = __Demo820MapIdx_Raw;
			__Demo820MapIdx_Raw = value;
			OnDemo820MapIdxChg_Invoke(_Demo820MapIdx_Raw, value);
		}
	}

	[GSPersistent]
	public int DefaultShortcutsPosition
	{
		get
		{
			return __DefaultShortcutsPosition_Raw;
		}
		set
		{
			int _DefaultShortcutsPosition_Raw = __DefaultShortcutsPosition_Raw;
			__DefaultShortcutsPosition_Raw = value;
			OnDefaultShortcutsPositionChg_Invoke(_DefaultShortcutsPosition_Raw, value);
		}
	}

	[GSPersistent]
	public BindDictInt_GSUnitBookData UnitBookDataDic
	{
		get
		{
			return __UnitBookDataDic_Raw;
		}
		set
		{
			BindDictInt_GSUnitBookData _UnitBookDataDic_Raw = __UnitBookDataDic_Raw;
			__UnitBookDataDic_Raw = value;
			OnUnitBookDataDicChg_Invoke(_UnitBookDataDic_Raw, value);
		}
	}

	[GSPersistent]
	public BindListInt SurprisePerformedList
	{
		get
		{
			return __SurprisePerformedList_Raw;
		}
		set
		{
			BindListInt _SurprisePerformedList_Raw = __SurprisePerformedList_Raw;
			__SurprisePerformedList_Raw = value;
			OnSurprisePerformedListChg_Invoke(_SurprisePerformedList_Raw, value);
		}
	}

	public ReadOnlyRoleData RoleData => RoleDataReadOnly;

	public ReadOnlyRoleDataClient RoleData_Client => RoleDataClientReadOnly;

	public EffectAttrList AttrFloatList { get; set; }

	public event Action<int, int> OnBeginAreaStayTimeChg;

	public event Action<int, int> OnLastRebirthPointTimeChg;

	public event Action<int, int> OnMapAreaIdChg;

	public event Action<int, int> OnMaxMapAreaIdChg;

	public event Action<int, int> OnMaxMapIdChg;

	public event Action<int, int> OnMapIdChg;

	public event Action<int, int> OnDemo820MapIdxChg;

	public event Action<int, int> OnDefaultShortcutsPositionChg;

	public event Action<BindDictInt_GSUnitBookData, BindDictInt_GSUnitBookData> OnUnitBookDataDicChg;

	public event Action<BindListInt, BindListInt> OnSurprisePerformedListChg;

	private void OnBeginAreaStayTimeChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnBeginAreaStayTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnLastRebirthPointTimeChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnLastRebirthPointTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMapAreaIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnMapAreaIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMaxMapAreaIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnMaxMapAreaIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMaxMapIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnMaxMapIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnMapIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnMapIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnDemo820MapIdxChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnDemo820MapIdxChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnDefaultShortcutsPositionChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnDefaultShortcutsPositionChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnUnitBookDataDicChg_Invoke(BindDictInt_GSUnitBookData OldValue, BindDictInt_GSUnitBookData NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnUnitBookDataDicChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnSurprisePerformedListChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnSurprisePerformedListChg?.Invoke(OldValue, NewValue);
		}
	}

	public BPC_PlayerRoleData()
	{
		UnitBookDataDic = new BindDictInt_GSUnitBookData();
		SurprisePerformedList = new BindListInt();
	}

	public void InitRoleData(RoleData roleData, RoleDataClient roleDataClient)
	{
		RoleDataReadOnly = new ReadOnlyRoleData(roleData);
		RoleDataClientReadOnly = new ReadOnlyRoleDataClient(roleDataClient);
	}

	public int GetGameTotalTime()
	{
		return (int)RoleData.RoleClient.StaticsData.SummaryStatics.GameTotalTime;
	}

	public int GetNewGamePlusCount()
	{
		if (RoleData != null)
		{
			return RoleData.RoleCs.Actor.NewGamePlusCount;
		}
		return 1;
	}
}
