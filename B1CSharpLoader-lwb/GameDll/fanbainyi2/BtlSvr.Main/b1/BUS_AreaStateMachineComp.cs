using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_AreaStateMachineComp : BUS_StateMachineCompBase
{
	public class EnableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.OverlapTag.Event_Disable, BGW_FlowUtils.OverlapTag.State_Disabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.OverlapTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_AreaStateMachineComp bUS_AreaStateMachineComp)
			{
				bUS_AreaStateMachineComp.EnableOverlap();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is BUS_AreaStateMachineComp bUS_AreaStateMachineComp)
			{
				bUS_AreaStateMachineComp.OnResetToOverlapEnable();
			}
		}
	}

	public class DisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.OverlapTag.Event_Enable, BGW_FlowUtils.OverlapTag.State_Enabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.OverlapTag.State_Enabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_AreaStateMachineComp bUS_AreaStateMachineComp)
			{
				bUS_AreaStateMachineComp.DisableOverlap();
			}
		}

		public override void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			base.OnRecoverAction(InOwner);
			if (InOwner is BUS_AreaStateMachineComp bUS_AreaStateMachineComp)
			{
				bUS_AreaStateMachineComp.OnResetToOverlapDisable();
			}
		}
	}

	private b1.IBUC_AreaBasicData AreaBasicData;

	public override void OnAttach()
	{
		base.OnAttach();
		AreaBasicData = RequireReadOnlyData<b1.IBUC_AreaBasicData, BUC_AreaBasicData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.OverlapBox;
		GSStateBase gSStateBase = AddState(typeof(EnableState), 1);
		GSStateBase gSStateBase2 = AddState(typeof(DisableState), 0);
		base.InitialState = (AreaBasicData.bAutoEnableOverlap ? gSStateBase : gSStateBase2);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}

	protected virtual void OnResetToOverlapEnable()
	{
	}

	protected virtual void OnResetToOverlapDisable()
	{
	}

	private void EnableOverlap()
	{
		base.BUSEventCollection?.Evt_EnableAreaOverlap.Invoke();
	}

	private void DisableOverlap()
	{
		base.BUSEventCollection?.Evt_DisableAreaOverlap.Invoke();
	}

	protected override void OnNotifyStartObserve()
	{
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}
}
