using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_TriggerBaseComp : BUS_StateMachineCompBase
{
	public class UnTriggeredState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TriggerTag.State_UnTriggered;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_Trigger, BGW_FlowUtils.TriggerTag.State_Triggered);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.TriggerTag.State_Triggered);
			base.ReactionDictionary.Add(BGW_FlowUtils.TriggerTag.Event_ReTrigger, OnEnterReAction);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_TriggerBaseComp bUS_TriggerBaseComp)
			{
				bUS_TriggerBaseComp.OnEnter_UnTriggeredEvent();
			}
		}

		public void OnEnterReAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_TriggerBaseComp bUS_TriggerBaseComp)
			{
				bUS_TriggerBaseComp.OnEnter_ReTriggerEvent();
			}
		}
	}

	public class TriggeredState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TriggerTag.State_Triggered;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.TriggerTag.State_UnTriggered);
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_Reset, BGW_FlowUtils.TriggerTag.State_UnTriggered);
			base.EventTransitDictionary.Add(BGW_FlowUtils.TriggerTag.Event_TriggerComplete, BGW_FlowUtils.TriggerTag.State_UnTriggered);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_TriggerBaseComp bUS_TriggerBaseComp)
			{
				bUS_TriggerBaseComp.OnEnter_TriggeredEvent();
				if (!bUS_TriggerBaseComp.CanReTrigger())
				{
					bUS_TriggerBaseComp.OnEvent(BGW_FlowUtils.TriggerTag.Event_TriggerComplete);
				}
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is BUS_TriggerBaseComp bUS_TriggerBaseComp)
			{
				bUS_TriggerBaseComp.OnRecover_TriggeredEvent();
			}
		}

		public override void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnInitialAction(InOwner);
			if (InOwner is BUS_TriggerBaseComp bUS_TriggerBaseComp)
			{
				bUS_TriggerBaseComp.OnInitial_TriggeredEvent();
			}
		}
	}

	protected BUC_TriggerBoxData TriggerBoxData { get; set; }

	protected GSStateBase State_UnTriggered { get; private set; }

	protected GSStateBase State_Triggered { get; private set; }

	public override void OnAttach()
	{
		base.OnAttach();
		TriggerBoxData = RequireWritableData<BUC_TriggerBoxData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Trigger;
		base.BUSEventCollection.Evt_SetTriggerActors += new Del_Void_StringList(OnSetTriggerActors);
		State_UnTriggered = AddState(typeof(UnTriggeredState), 0);
		State_Triggered = AddState(typeof(TriggeredState), 2);
		base.InitialState = State_UnTriggered;
	}

	private void OnSetTriggerActors(List<string> TriggerActorsGuid)
	{
		TriggerBoxData.OverlappedOtherActor = null;
		if (TriggerActorsGuid != null && TriggerActorsGuid.Count > 0)
		{
			TriggerBoxData.OverlappedOtherActor = BGU_DataUtil.GetActorByGuid(GetOwner(), TriggerActorsGuid[0]);
		}
	}

	public virtual void OnEnter_TriggeredEvent()
	{
	}

	public virtual void OnEnter_UnTriggeredEvent()
	{
	}

	public virtual void OnEnter_ReTriggerEvent()
	{
	}

	public virtual void OnRecover_TriggeredEvent()
	{
	}

	public virtual void OnInitial_TriggeredEvent()
	{
	}

	public virtual bool CanReTrigger()
	{
		return false;
	}
}
