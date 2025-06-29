using System;
using b1.ECS;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsReplicate;
using GurGsStruct;

namespace b1;

public class BPC_TransactionData : IBPC_TransactionData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public TransactionData[] _RepData = new TransactionData[64];

	private BindListPlayerTransactionBase __ActiveTransactions_Raw;

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

	public int ServerTransactionIdAlloc { get; set; }

	public int LocalTransactionIdAlloc { get; set; }

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

	public TransactionData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		TransactionData transactionData = _RepData[__LocalRepVersion % 64];
		if (transactionData == null)
		{
			transactionData = new TransactionData();
			ActiveTransactions?.ClearDeltaData();
			_RepData[__LocalRepVersion % 64] = transactionData;
		}
		else if (flag)
		{
			transactionData.ActiveTransactions.Clear();
			ActiveTransactions?.ClearDeltaData();
		}
		return transactionData;
	}

	public TransactionData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
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
		TransactionData transactionData = new TransactionData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"TransactionData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			if (ActiveTransactions == null)
			{
				transactionData.ActiveTransactions.Add(new ListDeltaMsgPlayerTransactionBase
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				ActiveTransactions.DumpFull(transactionData.ActiveTransactions);
			}
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					TransactionData other = _RepData[i % 64];
					transactionData.MergeFrom(other);
				}
			}
		}
		return transactionData;
	}

	private void OnActiveTransactionsChg_Invoke(BindListPlayerTransactionBase OldValue, BindListPlayerTransactionBase NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (_RepActive)
		{
			TransactionData orAllocRepData = GetOrAllocRepData();
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
}
