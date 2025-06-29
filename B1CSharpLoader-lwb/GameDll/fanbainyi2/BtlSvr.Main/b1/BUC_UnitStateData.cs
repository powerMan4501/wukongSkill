using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BUC_UnitStateData : IBUC_UnitStateData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public UnitStateData[] _RepData = new UnitStateData[64];

	private BindListWNRFloat __UnitStates_Raw;

	private static int MAX_ENUM_NUM;

	public bool bShouldUpdateStateTime;

	private static EGSBindRepType[] sStateRepFlag;

	[GSReplicated]
	[GSGameDataSnapShot]
	public BindListWNRFloat UnitStates
	{
		get
		{
			return __UnitStates_Raw;
		}
		set
		{
			BindListWNRFloat _UnitStates_Raw = __UnitStates_Raw;
			__UnitStates_Raw = value;
			OnUnitStatesChg_Invoke(_UnitStates_Raw, value);
		}
	}

	private GSBindList<int> LastTimeOutUnitStates { get; set; }

	public event Action<BindListWNRFloat, BindListWNRFloat> OnUnitStatesChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			UnitStates?.RegGetDeltaDataFunc(AllocRepDataForUnitStates);
		}
		else
		{
			UnitStates?.RegGetDeltaDataFunc(null);
		}
		UnitStates?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListWNRDeltaMsgFloat> AllocRepDataForUnitStates()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().UnitStates;
		}
		return null;
	}

	public UnitStateData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		UnitStateData unitStateData = _RepData[__LocalRepVersion % 64];
		if (unitStateData == null)
		{
			unitStateData = new UnitStateData();
			UnitStates?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = unitStateData;
		}
		else if (flag)
		{
			unitStateData.UnitStates.Clear();
			UnitStates?.ClearDeltaData();
		}
		return unitStateData;
	}

	public UnitStateData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			UnitStates?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		UnitStateData unitStateData = new UnitStateData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"UnitStateData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (UnitStates == null)
			{
				unitStateData.UnitStates.Add(new ListWNRDeltaMsgFloat
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				UnitStates.DumpFull(unitStateData.UnitStates);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					UnitStateData other = _RepData[i % 64];
					unitStateData.MergeFrom(other);
				}
			}
		}
		return unitStateData;
	}

	private void OnUnitStatesChg_Invoke(BindListWNRFloat OldValue, BindListWNRFloat NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			UnitStateData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.UnitStates.Clear();
			if (NewValue == null)
			{
				orAllocRepData.UnitStates.Add(new ListWNRDeltaMsgFloat
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.UnitStates);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForUnitStates);
		this.OnUnitStatesChg?.Invoke(OldValue, NewValue);
	}

	static BUC_UnitStateData()
	{
		MAX_ENUM_NUM = 45;
		sStateRepFlag = new EGSBindRepType[45];
		sStateRepFlag[1] = EGSBindRepType.Local;
		sStateRepFlag[2] = EGSBindRepType.Local;
		sStateRepFlag[3] = EGSBindRepType.Local;
		sStateRepFlag[4] = EGSBindRepType.Local;
		sStateRepFlag[5] = EGSBindRepType.Local;
		sStateRepFlag[6] = EGSBindRepType.Local;
		sStateRepFlag[7] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[8] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[9] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[10] = EGSBindRepType.Local;
		sStateRepFlag[11] = EGSBindRepType.Local;
		sStateRepFlag[12] = EGSBindRepType.Local;
		sStateRepFlag[13] = EGSBindRepType.Local;
		sStateRepFlag[14] = EGSBindRepType.Local;
		sStateRepFlag[43] = EGSBindRepType.Local;
		sStateRepFlag[15] = EGSBindRepType.Local;
		sStateRepFlag[16] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[17] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[18] = EGSBindRepType.Local;
		sStateRepFlag[19] = EGSBindRepType.Local;
		sStateRepFlag[20] = EGSBindRepType.Local;
		sStateRepFlag[21] = EGSBindRepType.Local;
		sStateRepFlag[22] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[24] = EGSBindRepType.Local;
		sStateRepFlag[25] = EGSBindRepType.Local;
		sStateRepFlag[26] = EGSBindRepType.Local;
		sStateRepFlag[27] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[28] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[29] = EGSBindRepType.ServerAuthority;
		sStateRepFlag[34] = EGSBindRepType.ServerAuthority;
	}

	public void Init(int NetRole)
	{
		UnitStates = new BindListWNRFloat(sStateRepFlag, NetRole);
		LastTimeOutUnitStates = new GSBindList<int>();
		bShouldUpdateStateTime = true;
	}

	public bool HasState(EBGUUnitState UnitState)
	{
		return UnitStates.GetValue((int)UnitState) != 0f;
	}

	public EGSBindRepType GetStateNetMode(EBGUUnitState UnitState)
	{
		return UnitStates.GetReplicateType((int)UnitState);
	}

	public string GetString()
	{
		string text = "UnitStateData:";
		for (int i = 0; i < MAX_ENUM_NUM; i++)
		{
			if (UnitStates.GetValue(i) != 0f)
			{
				text += $"[{(EBGUUnitState)i}:t_{UnitStates.GetValue(i):0.00}],";
			}
		}
		return text;
	}

	public bool SetState(EBGUUnitState UnitState, bool NeedForceUpdate, float Time = -1f)
	{
		float value = UnitStates.GetValue((int)UnitState);
		if (!NeedForceUpdate && value > 0f && Time < value && Time > 0f)
		{
			Time = value;
		}
		return UnitStates.SetByNetMode((int)UnitState, Time);
	}

	public GSBindList<int> GetLastTimeOutUnitStates()
	{
		return LastTimeOutUnitStates;
	}

	public void UpdateStateTime(float DeltaTime)
	{
		LastTimeOutUnitStates.Clear();
		for (int i = 0; i < MAX_ENUM_NUM; i++)
		{
			float value = UnitStates.GetValue(i);
			if (value > 0f)
			{
				value -= DeltaTime;
				if (value <= 0f)
				{
					value = 0f;
					LastTimeOutUnitStates.Add(i);
				}
				UnitStates.SetByNetMode(i, value);
			}
		}
	}

	public bool RemoveState(EBGUUnitState UnitState)
	{
		return UnitStates.SetByNetMode((int)UnitState, 0f);
	}
}
