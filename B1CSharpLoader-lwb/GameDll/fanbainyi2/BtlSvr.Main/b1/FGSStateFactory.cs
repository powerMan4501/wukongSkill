using System;
using System.Collections.Generic;
using b1.BGU.BUActor.BUFXActor.BGUFXActorS;

namespace b1;

public static class FGSStateFactory
{
	public static Dictionary<Type, BUS_StateMachineCompBase.GSStateBase> InstanceMapping { get; }

	static FGSStateFactory()
	{
		InstanceMapping = new Dictionary<Type, BUS_StateMachineCompBase.GSStateBase>();
		InstanceMapping[typeof(BUS_AreaStateMachineComp.EnableState)] = new BUS_AreaStateMachineComp.EnableState();
		InstanceMapping[typeof(BUS_AreaStateMachineComp.DisableState)] = new BUS_AreaStateMachineComp.DisableState();
		InstanceMapping[typeof(BUS_PerformerControlComp.EnableState)] = new BUS_PerformerControlComp.EnableState();
		InstanceMapping[typeof(BUS_PerformerControlComp.DisableState)] = new BUS_PerformerControlComp.DisableState();
		InstanceMapping[typeof(b1.BUS_TortoiseLevelStreamingMgrComp.BeginState)] = new b1.BUS_TortoiseLevelStreamingMgrComp.BeginState();
		InstanceMapping[typeof(b1.BUS_TortoiseLevelStreamingMgrComp.LoopState)] = new b1.BUS_TortoiseLevelStreamingMgrComp.LoopState();
		InstanceMapping[typeof(b1.BUS_TortoiseLevelStreamingMgrComp.EndState)] = new b1.BUS_TortoiseLevelStreamingMgrComp.EndState();
		InstanceMapping[typeof(BUS_SplineFlyMoveTriggerComp.EnableState)] = new BUS_SplineFlyMoveTriggerComp.EnableState();
		InstanceMapping[typeof(BUS_SplineFlyMoveTriggerComp.Disable)] = new BUS_SplineFlyMoveTriggerComp.Disable();
		InstanceMapping[typeof(BUS_SplineFlyMoveTriggerComp.InActivedState)] = new BUS_SplineFlyMoveTriggerComp.InActivedState();
		InstanceMapping[typeof(BUS_SplineFlyMoveTriggerComp.FlyingState)] = new BUS_SplineFlyMoveTriggerComp.FlyingState();
		InstanceMapping[typeof(BUS_SplineFlyMoveTriggerComp.ActivedState)] = new BUS_SplineFlyMoveTriggerComp.ActivedState();
		InstanceMapping[typeof(BUS_BossControlComp.DisableState)] = new BUS_BossControlComp.DisableState();
		InstanceMapping[typeof(BUS_BossControlComp.IdledState)] = new BUS_BossControlComp.IdledState();
		InstanceMapping[typeof(BUS_BossControlComp.FoughtState)] = new BUS_BossControlComp.FoughtState();
		InstanceMapping[typeof(BUS_BossControlComp.DeathState)] = new BUS_BossControlComp.DeathState();
		InstanceMapping[typeof(BUS_IntervalTriggerImpl.IntervalTriggerEnableState)] = new BUS_IntervalTriggerImpl.IntervalTriggerEnableState();
		InstanceMapping[typeof(BUS_IntervalTriggerImpl.IntervalTriggerDisableState)] = new BUS_IntervalTriggerImpl.IntervalTriggerDisableState();
		InstanceMapping[typeof(BUS_QuestSpawnWavesComp.State_Disabled)] = new BUS_QuestSpawnWavesComp.State_Disabled();
		InstanceMapping[typeof(BUS_QuestSpawnWavesComp.State_Idled)] = new BUS_QuestSpawnWavesComp.State_Idled();
		InstanceMapping[typeof(BUS_QuestSpawnWavesComp.State_Spawned)] = new BUS_QuestSpawnWavesComp.State_Spawned();
		InstanceMapping[typeof(BUS_QuestSpawnWavesComp.State_Cleared)] = new BUS_QuestSpawnWavesComp.State_Cleared();
		InstanceMapping[typeof(b1.BUS_BattleTriggerComp.EnableState)] = new b1.BUS_BattleTriggerComp.EnableState();
		InstanceMapping[typeof(b1.BUS_BattleTriggerComp.DisableState)] = new b1.BUS_BattleTriggerComp.DisableState();
		InstanceMapping[typeof(BUS_DumperTruckTriggerComp.InActivedState)] = new BUS_DumperTruckTriggerComp.InActivedState();
		InstanceMapping[typeof(BUS_DumperTruckTriggerComp.WaitWakeUpState)] = new BUS_DumperTruckTriggerComp.WaitWakeUpState();
		InstanceMapping[typeof(BUS_DumperTruckTriggerComp.ActivatingState)] = new BUS_DumperTruckTriggerComp.ActivatingState();
		InstanceMapping[typeof(BUS_DumperTruckTriggerComp.ActivedState)] = new BUS_DumperTruckTriggerComp.ActivedState();
		InstanceMapping[typeof(b1.BUS_GateStateMachineComp.OpenState)] = new b1.BUS_GateStateMachineComp.OpenState();
		InstanceMapping[typeof(b1.BUS_GateStateMachineComp.OpenToCloseState)] = new b1.BUS_GateStateMachineComp.OpenToCloseState();
		InstanceMapping[typeof(b1.BUS_GateStateMachineComp.CloseState)] = new b1.BUS_GateStateMachineComp.CloseState();
		InstanceMapping[typeof(b1.BUS_GateStateMachineComp.CloseToOpenState)] = new b1.BUS_GateStateMachineComp.CloseToOpenState();
		InstanceMapping[typeof(BUS_AiInteractComp.IdleState)] = new BUS_AiInteractComp.IdleState();
		InstanceMapping[typeof(BUS_AiInteractComp.ActionState)] = new BUS_AiInteractComp.ActionState();
		InstanceMapping[typeof(BUS_AiInteractComp.WaitingState)] = new BUS_AiInteractComp.WaitingState();
		InstanceMapping[typeof(BUS_AiInteractComp.MatchPosState)] = new BUS_AiInteractComp.MatchPosState();
		InstanceMapping[typeof(BUS_AiInteractComp.MatchWaitingState)] = new BUS_AiInteractComp.MatchWaitingState();
		InstanceMapping[typeof(BUS_AiInteractComp.TeleportPosState)] = new BUS_AiInteractComp.TeleportPosState();
		InstanceMapping[typeof(BUS_AiInteractComp.TeleportWaitState)] = new BUS_AiInteractComp.TeleportWaitState();
		InstanceMapping[typeof(BUS_HLMQuestStateComp.State_0)] = new BUS_HLMQuestStateComp.State_0();
		InstanceMapping[typeof(BUS_HLMQuestStateComp.State_1)] = new BUS_HLMQuestStateComp.State_1();
		InstanceMapping[typeof(BUS_HLMQuestStateComp.State_2)] = new BUS_HLMQuestStateComp.State_2();
		InstanceMapping[typeof(BUS_HLMQuestStateComp.State_3)] = new BUS_HLMQuestStateComp.State_3();
		InstanceMapping[typeof(BUS_HLMQuestStateComp.State_4)] = new BUS_HLMQuestStateComp.State_4();
		InstanceMapping[typeof(BUS_HLMQuestStateComp.State_5)] = new BUS_HLMQuestStateComp.State_5();
		InstanceMapping[typeof(BUS_QuestCheckOnlinePlayerComp.EnableState)] = new BUS_QuestCheckOnlinePlayerComp.EnableState();
		InstanceMapping[typeof(BUS_QuestCheckOnlinePlayerComp.DisableState)] = new BUS_QuestCheckOnlinePlayerComp.DisableState();
		InstanceMapping[typeof(BUS_QuestCovertTimerOverlapComp.EnableState)] = new BUS_QuestCovertTimerOverlapComp.EnableState();
		InstanceMapping[typeof(BUS_QuestCovertTimerOverlapComp.DisableState)] = new BUS_QuestCovertTimerOverlapComp.DisableState();
		InstanceMapping[typeof(b1.BUS_MeditationPointCompImpl.InActivedState)] = new b1.BUS_MeditationPointCompImpl.InActivedState();
		InstanceMapping[typeof(b1.BUS_MeditationPointCompImpl.ActivedState)] = new b1.BUS_MeditationPointCompImpl.ActivedState();
		InstanceMapping[typeof(BUS_QuestCheckAreaDeathComp.EnableState)] = new BUS_QuestCheckAreaDeathComp.EnableState();
		InstanceMapping[typeof(BUS_QuestCheckAreaDeathComp.DisableState)] = new BUS_QuestCheckAreaDeathComp.DisableState();
		InstanceMapping[typeof(BUS_QuestDynamicObstacleComp.EnableState)] = new BUS_QuestDynamicObstacleComp.EnableState();
		InstanceMapping[typeof(BUS_QuestDynamicObstacleComp.DisableState)] = new BUS_QuestDynamicObstacleComp.DisableState();
		InstanceMapping[typeof(BUS_QuestOverlapComponent.EnableState)] = new BUS_QuestOverlapComponent.EnableState();
		InstanceMapping[typeof(BUS_QuestOverlapComponent.DisableState)] = new BUS_QuestOverlapComponent.DisableState();
		InstanceMapping[typeof(BUS_QuestTortoiseCtrlComp.DefaultState)] = new BUS_QuestTortoiseCtrlComp.DefaultState();
		InstanceMapping[typeof(b1.BUS_DroppedItemManagerComp.ItemNotDroppedState)] = new b1.BUS_DroppedItemManagerComp.ItemNotDroppedState();
		InstanceMapping[typeof(b1.BUS_DroppedItemManagerComp.ItemDroppedState)] = new b1.BUS_DroppedItemManagerComp.ItemDroppedState();
		InstanceMapping[typeof(b1.BUS_DroppedItemManagerComp.ItemPickedUpState)] = new b1.BUS_DroppedItemManagerComp.ItemPickedUpState();
		InstanceMapping[typeof(BUS_PerformerComp.WaitingState)] = new BUS_PerformerComp.WaitingState();
		InstanceMapping[typeof(BUS_PerformerComp.PreShowState)] = new BUS_PerformerComp.PreShowState();
		InstanceMapping[typeof(BUS_PerformerComp.ShowingState)] = new BUS_PerformerComp.ShowingState();
		InstanceMapping[typeof(BUS_PerformerComp.BowingState)] = new BUS_PerformerComp.BowingState();
		InstanceMapping[typeof(BUS_PerformerComp.CompletedState)] = new BUS_PerformerComp.CompletedState();
		InstanceMapping[typeof(b1.BUS_ActorCallCompImpl.NotCalledState)] = new b1.BUS_ActorCallCompImpl.NotCalledState();
		InstanceMapping[typeof(b1.BUS_ActorCallCompImpl.CalledState)] = new b1.BUS_ActorCallCompImpl.CalledState();
		InstanceMapping[typeof(b1.BUS_DynamicObstacleDisplayComp.EnableState)] = new b1.BUS_DynamicObstacleDisplayComp.EnableState();
		InstanceMapping[typeof(b1.BUS_DynamicObstacleDisplayComp.DisableState)] = new b1.BUS_DynamicObstacleDisplayComp.DisableState();
		InstanceMapping[typeof(b1.BUS_RebirthPointCompImpl.InActivedState)] = new b1.BUS_RebirthPointCompImpl.InActivedState();
		InstanceMapping[typeof(b1.BUS_RebirthPointCompImpl.ActivedState)] = new b1.BUS_RebirthPointCompImpl.ActivedState();
		InstanceMapping[typeof(b1.BUS_TriggerCompImpl.UnTriggeredState)] = new b1.BUS_TriggerCompImpl.UnTriggeredState();
		InstanceMapping[typeof(b1.BUS_TriggerCompImpl.TriggeringState)] = new b1.BUS_TriggerCompImpl.TriggeringState();
		InstanceMapping[typeof(b1.BUS_TriggerCompImpl.TriggeredState)] = new b1.BUS_TriggerCompImpl.TriggeredState();
		InstanceMapping[typeof(BUS_TriggerBaseComp.UnTriggeredState)] = new BUS_TriggerBaseComp.UnTriggeredState();
		InstanceMapping[typeof(BUS_TriggerBaseComp.TriggeredState)] = new BUS_TriggerBaseComp.TriggeredState();
		InstanceMapping[typeof(BUS_DestructionDropComp.CantGenCantDropState)] = new BUS_DestructionDropComp.CantGenCantDropState();
		InstanceMapping[typeof(BUS_DestructionDropComp.CanGenCantDropState)] = new BUS_DestructionDropComp.CanGenCantDropState();
		InstanceMapping[typeof(BUS_DestructionDropComp.CanGenCanDropState)] = new BUS_DestructionDropComp.CanGenCanDropState();
		InstanceMapping[typeof(BUS_DestructionDropComp.DropFailState)] = new BUS_DestructionDropComp.DropFailState();
	}

	public static BUS_StateMachineCompBase.GSStateBase GetInstance(Type InInstanceKey)
	{
		if (InstanceMapping.TryGetValue(InInstanceKey, out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetAllInstances(out IReadOnlyDictionary<Type, BUS_StateMachineCompBase.GSStateBase> OutAllInstances)
	{
		OutAllInstances = InstanceMapping;
		return OutAllInstances.Count;
	}
}
