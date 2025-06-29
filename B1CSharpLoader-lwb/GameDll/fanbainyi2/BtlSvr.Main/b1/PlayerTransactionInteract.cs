using System;
using Google.Protobuf.Collections;
using GUR.Runtime;
using GurGsStruct;
using UnrealEngine.Engine;

namespace b1;

[ReplicateData]
public class PlayerTransactionInteract : PlayerTransactionBase
{
	private AActor __InteractTarget_Raw;

	[GSReplicated]
	[GSTransactionStartParam]
	public AActor InteractTarget
	{
		get
		{
			return __InteractTarget_Raw;
		}
		set
		{
			AActor _InteractTarget_Raw = __InteractTarget_Raw;
			__InteractTarget_Raw = value;
			OnInteractTargetChg_Invoke(_InteractTarget_Raw, value);
		}
	}

	public event Action<AActor, AActor> OnInteractTargetChg;

	public override void Start(ValueType StartParam)
	{
		base.Start(StartParam);
		InteractTarget = ((PlayerTransactionInteractStartParams)StartParam).InteractTarget;
		OnStart();
	}

	private void OnStart()
	{
		throw new NotImplementedException();
	}

	public override void Abort(ETransactionAbortReason AbortReason)
	{
		base.Abort(AbortReason);
	}

	public override void OnTick(float DeltaTime)
	{
		base.OnTick(DeltaTime);
	}

	public override void RefreshGetDeltaDataFunc(bool IsActive)
	{
		base.RefreshGetDeltaDataFunc(IsActive);
	}

	public override int GetGSRepSubClassIdx()
	{
		return 0;
	}

	public override void DumpFull(RepeatedField<ClassDeltaMsgPlayerTransactionBase> Data)
	{
		base.DumpFull(Data);
		Data[1].Value.PlayerTransactionInteractInteractTarget = BGW_NativeFuncs.GSRep_GetGUIDByActor(InteractTarget?.Address ?? IntPtr.Zero);
	}

	private void OnInteractTargetChg_Invoke(AActor OldValue, AActor NewValue)
	{
		if ((!(NewValue == null) || !(OldValue == null)) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			if (base.DeltaData != null)
			{
				ClassDeltaMsgPlayerTransactionBase classDeltaMsgPlayerTransactionBase = new ClassDeltaMsgPlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Value = new GurGsStruct.PlayerTransactionBase();
				classDeltaMsgPlayerTransactionBase.Op = OPType.Modify;
				classDeltaMsgPlayerTransactionBase.Version = (uint)BGWGameInstanceCS.AllocGlobalReplicateVersion();
				base.DeltaData.Add(classDeltaMsgPlayerTransactionBase);
				classDeltaMsgPlayerTransactionBase.Value.PlayerTransactionInteractInteractTarget = BGW_NativeFuncs.GSRep_GetGUIDByActor(NewValue?.Address ?? IntPtr.Zero);
			}
			this.OnInteractTargetChg?.Invoke(OldValue, NewValue);
		}
	}
}
