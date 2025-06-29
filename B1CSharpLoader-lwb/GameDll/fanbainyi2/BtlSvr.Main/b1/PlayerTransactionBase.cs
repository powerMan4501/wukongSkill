using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;

namespace b1;

[ReplicateData]
public class PlayerTransactionBase
{
	public delegate RepeatedField<ClassDeltaMsgPlayerTransactionBase> Del_GetRepData();

	private Del_GetRepData GetDeltaDataFunc;

	private RepeatedField<ClassDeltaMsgPlayerTransactionBase> DeltaDataCache;

	private int __ParentTransactionId_Raw;

	private int __TransactionId_Raw;

	private PlayerTransactionTaskBase __ActiveTask_Raw;

	private BindListPlayerTransactionTaskBase __FinishedTasks_Raw;

	private ETransactionState __TransactionState_Raw;

	[GSReplicated]
	public int ParentTransactionId
	{
		get
		{
			return __ParentTransactionId_Raw;
		}
		set
		{
			int _ParentTransactionId_Raw = __ParentTransactionId_Raw;
			__ParentTransactionId_Raw = value;
			OnParentTransactionIdChg_Invoke(_ParentTransactionId_Raw, value);
		}
	}

	[GSReplicated]
	public int TransactionId
	{
		get
		{
			return __TransactionId_Raw;
		}
		set
		{
			int _TransactionId_Raw = __TransactionId_Raw;
			__TransactionId_Raw = value;
			OnTransactionIdChg_Invoke(_TransactionId_Raw, value);
		}
	}

	[GSReplicated]
	public PlayerTransactionTaskBase ActiveTask
	{
		get
		{
			return __ActiveTask_Raw;
		}
		set
		{
			PlayerTransactionTaskBase _ActiveTask_Raw = __ActiveTask_Raw;
			__ActiveTask_Raw = value;
			OnActiveTaskChg_Invoke(_ActiveTask_Raw, value);
		}
	}

	[GSReplicated]
	public BindListPlayerTransactionTaskBase FinishedTasks
	{
		get
		{
			return __FinishedTasks_Raw;
		}
		set
		{
			BindListPlayerTransactionTaskBase _FinishedTasks_Raw = __FinishedTasks_Raw;
			__FinishedTasks_Raw = value;
			OnFinishedTasksChg_Invoke(_FinishedTasks_Raw, value);
		}
	}

	[GSReplicated]
	public ETransactionState TransactionState
	{
		get
		{
			return __TransactionState_Raw;
		}
		set
		{
			ETransactionState _TransactionState_Raw = __TransactionState_Raw;
			__TransactionState_Raw = value;
			OnTransactionStateChg_Invoke(_TransactionState_Raw, value);
		}
	}

	protected RepeatedField<ClassDeltaMsgPlayerTransactionBase> DeltaData
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

	public event Action<int, int> OnParentTransactionIdChg;

	public event Action<int, int> OnTransactionIdChg;

	public event Action<PlayerTransactionTaskBase, PlayerTransactionTaskBase> OnActiveTaskChg;

	public event Action<BindListPlayerTransactionTaskBase, BindListPlayerTransactionTaskBase> OnFinishedTasksChg;

	public event Action<ETransactionState, ETransactionState> OnTransactionStateChg;

	public virtual void Start(ValueType StartParam)
	{
	}

	public virtual void EnterNewActiveTask(ETransactionTaskType TaskType)
	{
	}

	public virtual void Abort(ETransactionAbortReason AbortReason)
	{
		ActiveTask.OnTransactionAbort(AbortReason);
		foreach (PlayerTransactionTaskBase finishedTask in FinishedTasks)
		{
			finishedTask.OnTransactionAbort(AbortReason);
		}
	}

	public virtual void Finish()
	{
		ActiveTask.OnTransactionFinish();
		foreach (PlayerTransactionTaskBase finishedTask in FinishedTasks)
		{
			finishedTask.OnTransactionFinish();
		}
	}

	public virtual void OnTick(float DeltaTime)
	{
		ActiveTask.OnTick(DeltaTime);
	}

	public virtual void RefreshGetDeltaDataFunc(bool IsActive)
	{
		if (IsActive)
		{
			ActiveTask?.RegGetDeltaDataFunc(AllocRepDataForActiveTask);
			FinishedTasks?.RegGetDeltaDataFunc(AllocRepDataForFinishedTasks);
		}
		else
		{
			ActiveTask?.RegGetDeltaDataFunc(null);
			FinishedTasks?.RegGetDeltaDataFunc(null);
		}
		ActiveTask?.RefreshGetDeltaDataFunc(IsActive);
		FinishedTasks?.RefreshGetDeltaDataFunc(IsActive);
	}

	private RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> AllocRepDataForActiveTask()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
			classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgPlayerTransactionBase);
			return classDeltaMsgPlayerTransactionBase.Value.ActiveTask;
		}
		return null;
	}

	private RepeatedField<ListDeltaMsgPlayerTransactionTaskBase> AllocRepDataForFinishedTasks()
	{
		if (DeltaData != null)
		{
			ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
			classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgPlayerTransactionBase);
			return classDeltaMsgPlayerTransactionBase.Value.FinishedTasks;
		}
		return null;
	}

	public void RegGetDeltaDataFunc(Del_GetRepData Func)
	{
		GetDeltaDataFunc = Func;
	}

	public virtual int GetGSRepSubClassIdx()
	{
		return -1;
	}

	public virtual void DumpFull(RepeatedField<ClassDeltaMsgPlayerTransactionBase> Data)
	{
		Data.Clear();
		uint version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
		Data.Add(new ClassDeltaMsgPlayerTransactionBase
		{
			Op = OPType.ChangeRef,
			Version = version,
			Value = new GurGsStruct.PlayerTransactionBase
			{
				GSRepSubClassIdx = GetGSRepSubClassIdx()
			}
		});
		ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
		classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
		classDeltaMsgPlayerTransactionBase.Version = version;
		classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
		classDeltaMsgPlayerTransactionBase.Value.ParentTransactionId = ParentTransactionId;
		classDeltaMsgPlayerTransactionBase.Value.TransactionId = TransactionId;
		if (ActiveTask == null)
		{
			classDeltaMsgPlayerTransactionBase.Value.ActiveTask.Add(new ClassDeltaMsgPlayerTransactionTaskBase
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			ActiveTask.DumpFull(classDeltaMsgPlayerTransactionBase.Value.ActiveTask);
		}
		if (FinishedTasks == null)
		{
			classDeltaMsgPlayerTransactionBase.Value.FinishedTasks.Add(new ListDeltaMsgPlayerTransactionTaskBase
			{
				Op = OPType.SetNull,
				Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
			});
		}
		else
		{
			FinishedTasks.DumpFull(classDeltaMsgPlayerTransactionBase.Value.FinishedTasks);
		}
		classDeltaMsgPlayerTransactionBase.Value.TransactionState = (int)TransactionState;
		Data.Add(classDeltaMsgPlayerTransactionBase);
	}

	public void ClearDeltaData()
	{
		DeltaDataCache = null;
		ActiveTask?.ClearDeltaData();
		FinishedTasks?.ClearDeltaData();
	}

	private void OnParentTransactionIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
				classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgPlayerTransactionBase);
				classDeltaMsgPlayerTransactionBase.Value.ParentTransactionId = NewValue;
			}
			this.OnParentTransactionIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnTransactionIdChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
				classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgPlayerTransactionBase);
				classDeltaMsgPlayerTransactionBase.Value.TransactionId = NewValue;
			}
			this.OnTransactionIdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnActiveTaskChg_Invoke(PlayerTransactionTaskBase OldValue, PlayerTransactionTaskBase NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
			classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgPlayerTransactionBase);
			if (NewValue == null)
			{
				classDeltaMsgPlayerTransactionBase.Value.ActiveTask.Add(new ClassDeltaMsgPlayerTransactionTaskBase
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForActiveTask);
				NewValue.DumpFull(classDeltaMsgPlayerTransactionBase.Value.ActiveTask);
			}
		}
		this.OnActiveTaskChg?.Invoke(OldValue, NewValue);
	}

	private void OnFinishedTasksChg_Invoke(BindListPlayerTransactionTaskBase OldValue, BindListPlayerTransactionTaskBase NewValue)
	{
		if ((NewValue == null && OldValue == null) || ((NewValue != null || OldValue == null) && NewValue.Equals(OldValue)))
		{
			return;
		}
		if (DeltaData != null)
		{
			OldValue?.ClearDeltaData();
			ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
			classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
			classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
			DeltaData.Add(classDeltaMsgPlayerTransactionBase);
			if (NewValue == null)
			{
				classDeltaMsgPlayerTransactionBase.Value.FinishedTasks.Add(new ListDeltaMsgPlayerTransactionTaskBase
				{
					Op = OPType.SetNull,
					Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion()
				});
			}
			else
			{
				NewValue.ClearDeltaData();
				NewValue.RegGetDeltaDataFunc(AllocRepDataForFinishedTasks);
				NewValue.DumpFull(classDeltaMsgPlayerTransactionBase.Value.FinishedTasks);
			}
		}
		this.OnFinishedTasksChg?.Invoke(OldValue, NewValue);
	}

	private void OnTransactionStateChg_Invoke(ETransactionState OldValue, ETransactionState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (DeltaData != null)
			{
				ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
				classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				DeltaData.Add(classDeltaMsgPlayerTransactionBase);
				classDeltaMsgPlayerTransactionBase.Value.TransactionState = (int)NewValue;
			}
			this.OnTransactionStateChg?.Invoke(OldValue, NewValue);
		}
	}
}
