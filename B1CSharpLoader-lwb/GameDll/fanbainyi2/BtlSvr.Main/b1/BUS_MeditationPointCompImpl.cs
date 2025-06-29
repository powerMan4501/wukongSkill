using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MeditationPointCompImpl : BUS_StateMachineCompBase
{
	public class InActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.MeditationPointTag.State_InActived;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.MeditationPointTag.Event_Active, BGW_FlowUtils.MeditationPointTag.State_Actived);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.MeditationPointTag.State_Actived);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			(InOwner as b1.BUS_MeditationPointCompImpl)?.SetMeditationPointActiveState(bActive: false);
		}
	}

	public class ActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.MeditationPointTag.State_Actived;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.MeditationPointTag.Event_Deactive, BGW_FlowUtils.MeditationPointTag.State_InActived);
		}

		public override void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			OnEnterAction(InOwner);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			(InOwner as b1.BUS_MeditationPointCompImpl)?.SetMeditationPointActiveState(bActive: true);
		}
	}

	private BUC_MeditationPointData MeditationPointData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		MeditationPointData = RequireWritableData<BUC_MeditationPointData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.MeditationPoint;
		GSStateBase gSStateBase = AddState(typeof(InActivedState), 0);
		GSStateBase gSStateBase2 = AddState(typeof(ActivedState), 1);
		base.InitialState = (MeditationPointData.bActiveState ? gSStateBase2 : gSStateBase);
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
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}

	protected override bool IsIgnoreSavedState()
	{
		return true;
	}

	public void SetMeditationPointActiveState(bool bActive)
	{
		MeditationPointData.bActiveState = bActive;
	}
}
