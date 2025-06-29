using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BPC_PlayerStateTestData : IBPC_PlayerStateTestData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public PlayerStateTestData[] _RepData = new PlayerStateTestData[64];

	private int __TestID_Raw;

	private BindListPlayerTransactionBase __ActiveTransactions_Raw;

	[NeedToUI]
	[GSReplicated]
	public int TestID
	{
		get
		{
			return __TestID_Raw;
		}
		set
		{
			int _TestID_Raw = __TestID_Raw;
			__TestID_Raw = value;
			OnTestIDChg_Invoke(_TestID_Raw, value);
		}
	}

	[GSReplicated]
	public BindListPlayerTransactionBase ActiveTransactions
	{
		get
		{
			return __ActiveTransactions_Raw;
		}
		set
		{
			BindListPlayerTransactionBase _ActiveTransactions_Raw = __ActiveTransactions_Raw;
			__ActiveTransactions_Raw = value;
			OnActiveTransactionsChg_Invoke(_ActiveTransactions_Raw, value);
		}
	}

	public event Action<int, int> OnTestIDChg;

	public event Action<BindListPlayerTransactionBase, BindListPlayerTransactionBase> OnActiveTransactionsChg;

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
			ActiveTransactions?.RegGetDeltaDataFunc(AllocRepDataForActiveTransactions);
		}
		else
		{
			ActiveTransactions?.RegGetDeltaDataFunc(null);
		}
		ActiveTransactions?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ListDeltaMsgPlayerTransactionBase> AllocRepDataForActiveTransactions()
	{
		if (_RepActive)
		{
			return GetOrAllocRepData().ActiveTransactions;
		}
		return null;
	}

	public PlayerStateTestData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		PlayerStateTestData playerStateTestData = _RepData[__LocalRepVersion % 64];
		if (playerStateTestData == null)
		{
			playerStateTestData = new PlayerStateTestData();
			ActiveTransactions?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = playerStateTestData;
		}
		else if (flag)
		{
			playerStateTestData.ClearTestID();
			playerStateTestData.ActiveTransactions.Clear();
			ActiveTransactions?.ClearDeltaData();
		}
		return playerStateTestData;
	}

	public PlayerStateTestData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
			ActiveTransactions?.ClearDeltaData();
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		PlayerStateTestData playerStateTestData = new PlayerStateTestData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"PlayerStateTestData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			playerStateTestData.TestID = TestID;
			if (ActiveTransactions == null)
			{
				playerStateTestData.ActiveTransactions.Add(new ListDeltaMsgPlayerTransactionBase
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				ActiveTransactions.DumpFull(playerStateTestData.ActiveTransactions);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					PlayerStateTestData other = _RepData[i % 64];
					playerStateTestData.MergeFrom(other);
				}
			}
		}
		return playerStateTestData;
	}

	private void OnTestIDChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().TestID = NewValue;
			}
			this.OnTestIDChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnActiveTransactionsChg_Invoke(BindListPlayerTransactionBase OldValue, BindListPlayerTransactionBase NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			PlayerStateTestData orAllocRepData = GetOrAllocRepData();
			OldValue?.ClearDeltaData();
			orAllocRepData.ActiveTransactions.Clear();
			if (NewValue == null)
			{
				orAllocRepData.ActiveTransactions.Add(new ListDeltaMsgPlayerTransactionBase
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.DumpFull(orAllocRepData.ActiveTransactions);
			}
		}
		OldValue?.RegGetDeltaDataFunc(null);
		NewValue?.RegGetDeltaDataFunc(AllocRepDataForActiveTransactions);
		this.OnActiveTransactionsChg?.Invoke(OldValue, NewValue);
	}

	public BPC_PlayerStateTestData()
	{
		ActiveTransactions = new BindListPlayerTransactionBase();
	}
}
