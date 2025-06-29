using UnrealEngine.Runtime;

namespace b1;

public class BUS_HLMQuestStateComp : BUS_StateMachineCompBase
{
	public class State_0 : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SceneObjHLMEventTag.State_State0;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjHLMEventTag.Event_SawShe01, BGW_FlowUtils.SceneObjHLMEventTag.State_State1);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjHLMEventTag.Event_KillFrog, BGW_FlowUtils.SceneObjHLMEventTag.State_State2);
		}
	}

	public class State_1 : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SceneObjHLMEventTag.State_State1;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjHLMEventTag.Event_KillFrog, BGW_FlowUtils.SceneObjHLMEventTag.State_State3);
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_State1Event();
			}
		}
	}

	public class State_2 : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SceneObjHLMEventTag.State_State2;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjHLMEventTag.Event_SawShe02, BGW_FlowUtils.SceneObjHLMEventTag.State_State5);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}
	}

	public class State_3 : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SceneObjHLMEventTag.State_State3;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjHLMEventTag.Event_SawShe02, BGW_FlowUtils.SceneObjHLMEventTag.State_State4);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}
	}

	public class State_4 : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SceneObjHLMEventTag.State_State4;

		public override void OnInitialize()
		{
			base.OnInitialize();
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}
	}

	public class State_5 : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.SceneObjHLMEventTag.State_State5;

		public override void OnInitialize()
		{
			base.OnInitialize();
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_HLMQuestStateComp bUS_HLMQuestStateComp)
			{
				bUS_HLMQuestStateComp.HLM_WaDead();
			}
		}
	}

	private int DelaySetValue_State1Event;

	private int DelaySetValue_WaDead;

	public override void OnAttach()
	{
		base.OnAttach();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.ActorCaller;
		GSStateBase initialState = AddState(typeof(State_0), 0);
		AddState(typeof(State_1), 1);
		AddState(typeof(State_2), 2);
		AddState(typeof(State_3), 3);
		AddState(typeof(State_4), 4);
		AddState(typeof(State_5), 5);
		base.InitialState = initialState;
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (DelaySetValue_State1Event > 0)
		{
			DelaySetValue_State1Event--;
			if (DelaySetValue_State1Event <= 1)
			{
				HLM_State1Event();
			}
		}
		if (DelaySetValue_WaDead > 0)
		{
			DelaySetValue_WaDead--;
			if (DelaySetValue_WaDead <= 1)
			{
				HLM_WaDead();
			}
		}
	}

	public void HLM_State1Event()
	{
		BGU_QuestActor bGU_QuestActor = base.Owner as BGU_QuestActor;
		if (bGU_QuestActor.IsNullOrDestroyed() || bGU_QuestActor.HLMActor.IsNullOrDestroyed())
		{
			return;
		}
		if (DelaySetValue_State1Event <= 0)
		{
			DelaySetValue_State1Event = 3;
			return;
		}
		if (DelaySetValue_State1Event == 1)
		{
			DelaySetValue_State1Event = 0;
		}
		FTransform newTrans_HLM_State = bGU_QuestActor.NewTrans_HLM_State1;
		newTrans_HLM_State.Scale3D = bGU_QuestActor.HLMActor.GetActorScale3D();
		BGUFuncLibActorTransformCS.BGUSetActorTransform(bGU_QuestActor.HLMActor, newTrans_HLM_State, bSweep: false, bTeleport: false);
	}

	public void HLM_WaDead()
	{
		BGU_QuestActor bGU_QuestActor = base.Owner as BGU_QuestActor;
		if (bGU_QuestActor.IsNullOrDestroyed() || bGU_QuestActor.HLMActor.IsNullOrDestroyed())
		{
			return;
		}
		if (DelaySetValue_WaDead <= 0)
		{
			DelaySetValue_WaDead = 3;
			return;
		}
		if (DelaySetValue_WaDead == 1)
		{
			DelaySetValue_WaDead = 0;
		}
		FTransform newTrans_HLM_KillWa = bGU_QuestActor.NewTrans_HLM_KillWa;
		newTrans_HLM_KillWa.Scale3D = bGU_QuestActor.HLMActor.GetActorScale3D();
		BGUFuncLibActorTransformCS.BGUSetActorTransform(bGU_QuestActor.HLMActor, newTrans_HLM_KillWa, bSweep: false, bTeleport: false);
	}
}
