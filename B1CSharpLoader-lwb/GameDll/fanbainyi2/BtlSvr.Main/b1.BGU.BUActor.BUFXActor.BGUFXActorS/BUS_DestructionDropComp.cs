using System;
using b1.EventDelDefine;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUActor.BUFXActor.BGUFXActorS;

[UClass]
public class BUS_DestructionDropComp : BUS_StateMachineCompBase
{
	public class CantGenCantDropState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DestructionTag.State_CantGen_CantDrop;

		public override void OnInitialize()
		{
			base.OnInitialize();
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
		}
	}

	public class CanGenCantDropState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DestructionTag.State_CanGen_CantDrop;

		public override void OnInitialize()
		{
			base.OnInitialize();
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
		}
	}

	public class CanGenCanDropState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DestructionTag.State_CanGen_CanDrop;

		public override void OnInitialize()
		{
			base.OnInitialize();
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
		}
	}

	public class DropFailState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DestructionTag.State_Drop_Fail;

		public override void OnInitialize()
		{
			base.OnInitialize();
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
		}
	}

	private b1.BUC_DestructibleData DestructibleData;

	private GSStateBase CantGen_CantDrop_State;

	private GSStateBase CanGen_CantDrop_State;

	private GSStateBase CanGen_CanDrop_State;

	private GSStateBase Drop_Fail_State;

	public override void OnAttach()
	{
		base.OnAttach();
		DestructibleData = RequireWritableData<b1.BUC_DestructibleData>();
		base.BUSEventCollection.Evt_DestroyDestructible += new Del_DestroyDestructible(OnDestroyDestructible);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(ResetDestruction));
		base.BUSEventCollection.Evt_BGS_DestructionDropFail += new Del_DestructionDropFail(OnDestructionDropFail);
	}

	public override void PreBeginPlay()
	{
		CantGen_CantDrop_State = AddState(typeof(CantGenCantDropState), 0);
		CanGen_CantDrop_State = AddState(typeof(CanGenCantDropState), 1);
		CanGen_CanDrop_State = AddState(typeof(CanGenCanDropState), 2);
		Drop_Fail_State = AddState(typeof(DropFailState), 3);
		base.InitialState = CanGen_CanDrop_State;
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		ResetDestruction(EResetActorReason.None);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(ResetDestruction));
	}

	private void ResetDestruction(EResetActorReason ResetReason)
	{
		DestructionDropDesc destructionDropDesc = GameDBRuntime.GetDestructionDropDesc(DestructibleData.DestructionDropInfoID);
		if (destructionDropDesc == null)
		{
			return;
		}
		if (base.CurrentState == CantGen_CantDrop_State)
		{
			if (destructionDropDesc.CanRepeatGenerate == YesNoType.No)
			{
				JumpToState(CantGen_CantDrop_State);
			}
			else if (destructionDropDesc.CanRepeatDrop == YesNoType.No)
			{
				JumpToState(CanGen_CantDrop_State);
			}
			else
			{
				JumpToState(CanGen_CanDrop_State);
			}
		}
		else if (base.CurrentState == Drop_Fail_State)
		{
			JumpToState(CanGen_CanDrop_State);
		}
		if (base.CurrentState == CantGen_CantDrop_State)
		{
			base.BUSEventCollection.Evt_ResetDestructible.Invoke(P1: true);
		}
		else
		{
			base.BUSEventCollection.Evt_ResetDestructible.Invoke(P1: false);
		}
	}

	private void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		DestructionDropDesc destructionDropDesc = GameDBRuntime.GetDestructionDropDesc(DestructibleData.DestructionDropInfoID);
		if (destructionDropDesc != null && base.CurrentState == CanGen_CanDrop_State && base.BGSEventCollection.Evt_BGS_DestructionDropItem != null)
		{
			base.BGSEventCollection.Evt_BGS_DestructionDropItem.Invoke(base.Owner, destructionDropDesc.DropGroupId, destructionDropDesc.DropDistanceLimit);
		}
		JumpToState(CantGen_CantDrop_State);
	}

	private void OnDestructionDropFail()
	{
		JumpToState(Drop_Fail_State);
	}
}
