using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_TortoiseLevelStreamingMgrComp : BUS_StateMachineCompBase
{
	public class BeginState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TortoiseEventTag.Tortoise_Begin;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.TortoiseEventTag.Tortoise_Loop, BGW_FlowUtils.TortoiseEventTag.Tortoise_Loop);
			base.EventTransitDictionary.Add(BGW_FlowUtils.TortoiseEventTag.Tortoise_End, BGW_FlowUtils.TortoiseEventTag.Tortoise_End);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_TortoiseLevelStreamingMgrComp bUS_TortoiseLevelStreamingMgrComp)
			{
				bUS_TortoiseLevelStreamingMgrComp.OnEnter_BeginState();
			}
		}
	}

	public class LoopState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TortoiseEventTag.Tortoise_Loop;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.TortoiseEventTag.Tortoise_Begin, BGW_FlowUtils.TortoiseEventTag.Tortoise_Begin);
			base.EventTransitDictionary.Add(BGW_FlowUtils.TortoiseEventTag.Tortoise_End, BGW_FlowUtils.TortoiseEventTag.Tortoise_End);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_TortoiseLevelStreamingMgrComp bUS_TortoiseLevelStreamingMgrComp)
			{
				bUS_TortoiseLevelStreamingMgrComp.OnEnter_LoopState();
			}
		}
	}

	public class EndState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.TortoiseEventTag.Tortoise_End;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.TortoiseEventTag.Tortoise_Begin, BGW_FlowUtils.TortoiseEventTag.Tortoise_Begin);
			base.EventTransitDictionary.Add(BGW_FlowUtils.TortoiseEventTag.Tortoise_Loop, BGW_FlowUtils.TortoiseEventTag.Tortoise_Loop);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is b1.BUS_TortoiseLevelStreamingMgrComp bUS_TortoiseLevelStreamingMgrComp)
			{
				bUS_TortoiseLevelStreamingMgrComp.OnEnter_EndState();
			}
		}
	}

	private b1.BUC_TortoiseLevelStreamingMgrData TortoiseLevelStreamingMgrData;

	private IBIC_LevelData LevelData;

	private GSStateBase GSBeginState;

	private GSStateBase GSLoopState;

	private GSStateBase GSEndState;

	public override void OnAttach()
	{
		base.OnAttach();
		TortoiseLevelStreamingMgrData = RequireWritableData<b1.BUC_TortoiseLevelStreamingMgrData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		OnInit();
		GSBeginState = AddState(typeof(BeginState), 0);
		GSLoopState = AddState(typeof(LoopState), 1);
		GSEndState = AddState(typeof(EndState), 2);
		base.InitialState = GSBeginState;
	}

	private void OnInit()
	{
		TortoiseLevelStreamingMgrData.RequestGUID = BGU_DataUtil.GetActorGuid(base.Owner);
	}

	private void OnSwitchState(FTortoiseLevelState ToroiseLevelState)
	{
		TortoiseLevelStreamingMgrData.CurrentLevelState = ToroiseLevelState;
		BGW_LevelStreamingStateMgr.Get(base.Owner)?.UpdateLevelState(TortoiseLevelStreamingMgrData.RequestGUID, LevelData.CurrentLevelID, TortoiseLevelStreamingMgrData.TortoiseLevelStreamingConfigs[TortoiseLevelStreamingMgrData.CurrentLevelState], EGSLevelStateInfoLayerType.CPG);
	}

	public void OnEnter_BeginState()
	{
		OnSwitchState(FTortoiseLevelState.begin);
	}

	public void OnEnter_LoopState()
	{
		OnSwitchState(FTortoiseLevelState.loop);
	}

	public void OnEnter_EndState()
	{
		OnSwitchState(FTortoiseLevelState.end);
	}
}
