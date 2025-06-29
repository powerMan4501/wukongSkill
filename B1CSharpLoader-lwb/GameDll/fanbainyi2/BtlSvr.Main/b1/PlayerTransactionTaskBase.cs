using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class PlayerTransactionTaskBase
{
	public delegate RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> DeltaDataCache;

	private int __TaskType_Raw;

	private ETransactionTaskState __TaskState_Raw;

	[GSReplicated]
	public int TaskType
	{
		get
		{
			return __TaskType_Raw;
		}
		set
		{
			int _TaskType_Raw = __TaskType_Raw;
			__TaskType_Raw = value;
			OnTaskTypeChg_Invoke(_TaskType_Raw, value);
		}
	}

	[GSReplicated]
	public ETransactionTaskState TaskState
	{
		get
		{
			return __TaskState_Raw;
		}
		set
		{
			ETransactionTaskState _TaskState_Raw = __TaskState_Raw;
			__TaskState_Raw = value;
			OnTaskStateChg_Invoke(_TaskState_Raw, value);
		}
	}

	protected RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> DeltaData
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

	public event Action<int, int> OnTaskTypeChg;

	public event Action<ETransactionTaskState, ETransactionTaskState> OnTaskStateChg;

	public virtual void OnBegin()
	{
		TaskState = ETransactionTaskState.Runing;
	}

	public virtual void OnTick(float DeltaTime)
	{
	}

	protected virtual void DoFinish()
	{
		TaskState = ETransactionTaskState.Finished;
	}

	public virtual void OnTransactionFinish()
	{
		GSEUtil.Ensure(TaskState == ETransactionTaskState.Finished);
	}

	protected virtual void DoAbort()
	{
		TaskState = ETransactionTaskState.Aborted;
	}

	public virtual void OnTransactionAbort(ETransactionAbortReason AbortReason)
	{
		DoAbort();
	}

	public virtual void OnCue()
	{
	}

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

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgPlayerTransactionTaskBase
		{
			Op = OPType.ChangeRef,
			Version = version,
			Value = new GurGsStruct.PlayerTransactionTaskBase
			{
				GSRepSubClassIdx = GetGSRepSubClassIdx()
			}
		});
		ClassDeltaMsgPlayerTransactionTaskBase classDeltaMsgPlayerTransactionTaskBase = new ClassDeltaMsgPlayerTransactionTaskBase();
		classDeltaMsgPlayerTransactionTaskBase.Op = OPType.Modify;
		classDeltaMsgPlayerTransactionTaskBase.Version = version;
		classDeltaMsgPlayerTransactionTaskBase.Value = new GurGsStruct.PlayerTransactionTaskBase();
		classDeltaMsgPlayerTransactionTaskBase.Value.TaskType = TaskType;
		classDeltaMsgPlayerTransactionTaskBase.Value.TaskState = (int)TaskState;
		Data.Add(classDeltaMsgPlayerTransactionTaskBase);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
	}

	private void OnTaskTypeChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgPlayerTransactionTaskBase classDeltaMsgPlayerTransactionTaskBase = new ClassDeltaMsgPlayerTransactionTaskBase();
				classDeltaMsgPlayerTransactionTaskBase.Value = new GurGsStruct.PlayerTransactionTaskBase();
				classDeltaMsgPlayerTransactionTaskBase.Op = OPType.Modify;
				classDeltaMsgPlayerTransactionTaskBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgPlayerTransactionTaskBase);
				classDeltaMsgPlayerTransactionTaskBase.Value.TaskType = NewValue;
			}
			this.OnTaskTypeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTaskStateChg_Invoke(ETransactionTaskState OldValue, ETransactionTaskState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgPlayerTransactionTaskBase classDeltaMsgPlayerTransactionTaskBase = new ClassDeltaMsgPlayerTransactionTaskBase();
				classDeltaMsgPlayerTransactionTaskBase.Value = new GurGsStruct.PlayerTransactionTaskBase();
				classDeltaMsgPlayerTransactionTaskBase.Op = OPType.Modify;
				classDeltaMsgPlayerTransactionTaskBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgPlayerTransactionTaskBase);
				classDeltaMsgPlayerTransactionTaskBase.Value.TaskState = (int)NewValue;
			}
			this.OnTaskStateChg?.Invoke(OldValue, NewValue);
		}
	}
}
