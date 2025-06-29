using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BUC_SimpleStateData : IBUC_SimpleStateData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public SimpleStateData[] _RepData = new SimpleStateData[64];

	private BindListWNRInt __SimpleStates_Raw;

	private static EGSBindRepType[] sStateRepFlags = new EGSBindRepType[174];

	[GSReplicated]
	[GSGameDataSnapShot]
	public BindListWNRInt SimpleStates
	{
		get
		{
			return __SimpleStates_Raw;
		}
		set
		{
			BindListWNRInt _SimpleStates_Raw = __SimpleStates_Raw;
			__SimpleStates_Raw = value;
			OnSimpleStatesChg_Invoke(_SimpleStates_Raw, value);
		}
	}

	public event Action<BindListWNRInt, BindListWNRInt> OnSimpleStatesChg;

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
			SimpleStates?.RegGetDeltaDataFunc(AllocRepDataForSimpleStates);
		}
		else
		{
			SimpleStates?.RegGetDeltaDataFunc(null);
		}
		SimpleStates?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListWNRDeltaMsgInt> AllocRepDataForSimpleStates()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().SimpleStates;
		}
		return null;
	}

	public SimpleStateData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		SimpleStateData simpleStateData = _RepData[__LocalRepVersion % 64];
		if (simpleStateData == null)
		{
			simpleStateData = new SimpleStateData();
			SimpleStates?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = simpleStateData;
		}
		else if (flag)
		{
			simpleStateData.SimpleStates.Clear();
			SimpleStates?.ClearDeltaData();
		}
		return simpleStateData;
	}

	public SimpleStateData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			SimpleStates?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		SimpleStateData simpleStateData = new SimpleStateData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"SimpleStateData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (SimpleStates == null)
			{
				simpleStateData.SimpleStates.Add(new ListWNRDeltaMsgInt
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				SimpleStates.DumpFull(simpleStateData.SimpleStates);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					SimpleStateData other = _RepData[i % 64];
					simpleStateData.MergeFrom(other);
				}
			}
		}
		return simpleStateData;
	}

	private void OnSimpleStatesChg_Invoke(BindListWNRInt OldValue, BindListWNRInt NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			SimpleStateData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.SimpleStates.Clear();
			if (NewValue == null)
			{
				orAllocRepData.SimpleStates.Add(new ListWNRDeltaMsgInt
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.SimpleStates);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForSimpleStates);
		this.OnSimpleStatesChg?.Invoke(OldValue, NewValue);
	}

	public void Init(int NetRole)
	{
		for (int i = 0; i < 174; i++)
		{
			sStateRepFlags[i] = EGSBindRepType.ServerAuthority;
		}
		SimpleStates = new BindListWNRInt(sStateRepFlags, NetRole);
	}

	public string GetString()
	{
		string text = "SimpleStateList:";
		for (int i = 0; i < 174; i++)
		{
			if (SimpleStates[i] != 0)
			{
				text += $"[{(EBGUSimpleState)i}:t_{SimpleStates[i]:0.00}],";
			}
		}
		return text;
	}

	public void SetSimpleState(EBGUSimpleState SimpleState)
	{
		if ((int)SimpleState < 174)
		{
			SimpleStates[(int)SimpleState]++;
		}
	}

	public void RemoveSimpleState(EBGUSimpleState SimpleState)
	{
		if ((int)SimpleState < 174 && SimpleStates[(int)SimpleState] > 0)
		{
			SimpleStates[(int)SimpleState]--;
		}
	}

	public bool HasSimpleState(EBGUSimpleState SimpleState)
	{
		if ((int)SimpleState >= 174)
		{
			return false;
		}
		return SimpleStates[(int)SimpleState] > 0;
	}

	public bool GetSimpleStateLayer(EBGUSimpleState SimpleState, out int LayerNum)
	{
		LayerNum = 0;
		if (HasSimpleState(SimpleState))
		{
			LayerNum = SimpleStates[(int)SimpleState];
			return true;
		}
		return false;
	}
}
