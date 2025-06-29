using UnrealEngine.Runtime;

namespace b1;

public static class BGW_FlowUtils
{
	public static class CommonTagName
	{
		public static readonly FName Enable = new FName("B1.Common.Enable");

		public static readonly FName Disable = new FName("B1.Common.Disable");

		public static readonly FName Trigger = new FName("B1.Common.Trigger");

		public static readonly FName OverlapBegin = new FName("B1.Common.OverlapBegin");

		public static readonly FName OverlapEnd = new FName("B1.Common.OverlapEnd");

		public static readonly FName Spawn = new FName("B1.Common.Spawn");

		public static readonly FName Penetrate = new FName("B1.Common.Penetrate");

		public static readonly FName InteractionBegin = new FName("B1.Common.InteractionBegin");

		public static readonly FName InteractionBreak = new FName("B1.Common.InteractionBreak");

		public static readonly FName InteractionEnd = new FName("B1.Common.InteractionEnd");

		public static readonly FName InteractionTimeEmpty = new FName("B1.Common.InteractionTimeEmpty");

		public static readonly FName Dead = new FName("B1.Common.Dead");

		public static readonly FName AllDead = new FName("B1.Common.AllDead");

		public static readonly FName SpawnUnitAllDead = new FName("B1.Common.SpawnUnitAllDead");

		public static readonly FName TimeOver = new FName("B1.Common.TimeOver");

		public static readonly FName TimeOut = new FName("B1.Common.TimeOut");

		public static readonly FName WakeUp = new FName("B1.Common.WakeUp");

		public static readonly FName UnitDead = new FName("B1.Common.UnitDead");

		public static readonly FName BattleStart = new FName("B1.Common.BattleStart");

		public static readonly FName GateOpen = new FName("B1.Common.GateOpen");

		public static readonly FName GateClose = new FName("B1.Common.GateClose");

		public static readonly FName ChallengeFailed = new FName("B1.Common.ChallengeFailed");

		public static readonly FName ChallengeAwarded = new FName("B1.Common.ChallengeAwarded");

		public static readonly FName ChallengeSuccess = new FName("B1.Common.ChallengeSuccess");

		public static readonly FName ChallengeBegin = new FName("B1.Common.ChallengeBegin");
	}

	public static class CommonTag
	{
		public static readonly FGameplayTag Enable = GameplayTagExtension.MakeGameplayTag(CommonTagName.Enable);

		public static readonly FGameplayTag Disable = GameplayTagExtension.MakeGameplayTag(CommonTagName.Disable);

		public static readonly FGameplayTag Trigger = GameplayTagExtension.MakeGameplayTag(CommonTagName.Trigger);

		public static readonly FGameplayTag OverlapBegin = GameplayTagExtension.MakeGameplayTag(CommonTagName.OverlapBegin);

		public static readonly FGameplayTag OverlapEnd = GameplayTagExtension.MakeGameplayTag(CommonTagName.OverlapEnd);

		public static readonly FGameplayTag Spawn = GameplayTagExtension.MakeGameplayTag(CommonTagName.Spawn);

		public static readonly FGameplayTag Penetrate = GameplayTagExtension.MakeGameplayTag(CommonTagName.Penetrate);

		public static readonly FGameplayTag InteractionBegin = GameplayTagExtension.MakeGameplayTag(CommonTagName.InteractionBegin);

		public static readonly FGameplayTag InteractionBreak = GameplayTagExtension.MakeGameplayTag(CommonTagName.InteractionBreak);

		public static readonly FGameplayTag InteractionEnd = GameplayTagExtension.MakeGameplayTag(CommonTagName.InteractionEnd);

		public static readonly FGameplayTag InteractionTimeEmpty = GameplayTagExtension.MakeGameplayTag(CommonTagName.InteractionTimeEmpty);

		public static readonly FGameplayTag Dead = GameplayTagExtension.MakeGameplayTag(CommonTagName.Dead);

		public static readonly FGameplayTag AllDead = GameplayTagExtension.MakeGameplayTag(CommonTagName.AllDead);

		public static readonly FGameplayTag SpawnUnitAllDead = GameplayTagExtension.MakeGameplayTag(CommonTagName.SpawnUnitAllDead);

		public static readonly FGameplayTag TimeOver = GameplayTagExtension.MakeGameplayTag(CommonTagName.TimeOver);

		public static readonly FGameplayTag TimeOut = GameplayTagExtension.MakeGameplayTag(CommonTagName.TimeOut);

		public static readonly FGameplayTag WakeUp = GameplayTagExtension.MakeGameplayTag(CommonTagName.WakeUp);

		public static readonly FGameplayTag UnitDead = GameplayTagExtension.MakeGameplayTag(CommonTagName.UnitDead);

		public static readonly FGameplayTag BattleStart = GameplayTagExtension.MakeGameplayTag(CommonTagName.BattleStart);

		public static readonly FGameplayTag GateOpen = GameplayTagExtension.MakeGameplayTag(CommonTagName.GateOpen);

		public static readonly FGameplayTag GateClose = GameplayTagExtension.MakeGameplayTag(CommonTagName.GateClose);

		public static readonly FGameplayTag ChallengeFailed = GameplayTagExtension.MakeGameplayTag(CommonTagName.ChallengeFailed);

		public static readonly FGameplayTag ChallengeAwarded = GameplayTagExtension.MakeGameplayTag(CommonTagName.ChallengeAwarded);

		public static readonly FGameplayTag ChallengeSuccess = GameplayTagExtension.MakeGameplayTag(CommonTagName.ChallengeSuccess);

		public static readonly FGameplayTag ChallengeBegin = GameplayTagExtension.MakeGameplayTag(CommonTagName.ChallengeBegin);
	}

	public static class SceneObjCommonEventTagName
	{
		public static readonly FName Spawn = new FName("B1.SceneObj.CommonEvent.Spawn");

		public static readonly FName Reset = new FName("B1.SceneObj.CommonEvent.Reset");

		public static readonly FName Next = new FName("B1.SceneObj.CommonEvent.Next");

		public static readonly FName JumpToState0 = new FName("B1.SceneObj.CommonEvent.JumpToState0");

		public static readonly FName JumpToState1 = new FName("B1.SceneObj.CommonEvent.JumpToState1");

		public static readonly FName JumpToState2 = new FName("B1.SceneObj.CommonEvent.JumpToState2");

		public static readonly FName JumpToState3 = new FName("B1.SceneObj.CommonEvent.JumpToState3");
	}

	public static class SceneObjCommonEventTag
	{
		public static readonly FGameplayTag Reset = GameplayTagExtension.MakeGameplayTag(SceneObjCommonEventTagName.Reset);

		public static readonly FGameplayTag Spawn = GameplayTagExtension.MakeGameplayTag(SceneObjCommonEventTagName.Spawn);

		public static readonly FGameplayTag Next = GameplayTagExtension.MakeGameplayTag(SceneObjCommonEventTagName.Next);

		public static readonly FGameplayTag JumpToState0 = GameplayTagExtension.MakeGameplayTag(SceneObjCommonEventTagName.JumpToState0);

		public static readonly FGameplayTag JumpToState1 = GameplayTagExtension.MakeGameplayTag(SceneObjCommonEventTagName.JumpToState1);

		public static readonly FGameplayTag JumpToState2 = GameplayTagExtension.MakeGameplayTag(SceneObjCommonEventTagName.JumpToState2);

		public static readonly FGameplayTag JumpToState3 = GameplayTagExtension.MakeGameplayTag(SceneObjCommonEventTagName.JumpToState3);
	}

	public static class SceneObjHLMEventTagName
	{
		public static readonly FName State_State0 = new FName("B1.SceneObj.HLMEvent.State_State0");

		public static readonly FName State_State1 = new FName("B1.SceneObj.HLMEvent.State_State1");

		public static readonly FName State_State2 = new FName("B1.SceneObj.HLMEvent.State_State2");

		public static readonly FName State_State3 = new FName("B1.SceneObj.HLMEvent.State_State3");

		public static readonly FName State_State4 = new FName("B1.SceneObj.HLMEvent.State_State4");

		public static readonly FName State_State5 = new FName("B1.SceneObj.HLMEvent.State_State5");

		public static readonly FName Event_SawShe01 = new FName("B1.SceneObj.HLMEvent.Event_SawShe01");

		public static readonly FName Event_KillFrog = new FName("B1.SceneObj.HLMEvent.Event_KillFrog");

		public static readonly FName Event_SawShe02 = new FName("B1.SceneObj.HLMEvent.Event_SawShe02");
	}

	public static class SceneObjHLMEventTag
	{
		public static readonly FGameplayTag State_State0 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.State_State0);

		public static readonly FGameplayTag State_State1 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.State_State1);

		public static readonly FGameplayTag State_State2 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.State_State2);

		public static readonly FGameplayTag State_State3 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.State_State3);

		public static readonly FGameplayTag State_State4 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.State_State4);

		public static readonly FGameplayTag State_State5 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.State_State5);

		public static readonly FGameplayTag Event_SawShe01 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.Event_SawShe01);

		public static readonly FGameplayTag Event_KillFrog = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.Event_KillFrog);

		public static readonly FGameplayTag Event_SawShe02 = GameplayTagExtension.MakeGameplayTag(SceneObjHLMEventTagName.Event_SawShe02);
	}

	public static class SceneObjTagName
	{
		public static readonly FName OverlapBox = new FName("B1.SceneObj.Overlap");

		public static readonly FName RebirthPoint = new FName("B1.SceneObj.RebirthPoint");

		public static readonly FName ActorCaller = new FName("B1.SceneObj.ActorCaller");

		public static readonly FName DynamicObstacle = new FName("B1.SceneObj.DynamicObstacle");

		public static readonly FName Checker = new FName("B1.SceneObj.Checker");

		public static readonly FName RebirthPointInfoSave = new FName("B1.SceneObj.RebirthPointInfoSave");

		public static readonly FName WakeUp = new FName("B1.SceneObj.WakeUp");

		public static readonly FName Trigger = new FName("B1.SceneObj.Trigger");

		public static readonly FName Lamp = new FName("B1.SceneObj.Lamp");

		public static readonly FName Interactor = new FName("B1.SceneObj.Interactor");

		public static readonly FName Performer = new FName("B1.SceneObj.Performer");

		public static readonly FName NPCShow = new FName("B1.SceneObj.NPCShow");

		public static readonly FName MeditationPoint = new FName("B1.SceneObj.MeditationPoint");

		public static readonly FName Spawner = new FName("B1.SceneObj.Spawner");

		public static readonly FName Device = new FName("B1.SceneObj.Device");

		public static readonly FName BossControl = new FName("B1.SceneObj.BossControl");
	}

	public static class SceneObjTag
	{
		public static readonly FGameplayTag OverlapBox = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.OverlapBox);

		public static readonly FGameplayTag RebirthPoint = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.RebirthPoint);

		public static readonly FGameplayTag ActorCaller = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.ActorCaller);

		public static readonly FGameplayTag DynamicObstacle = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.DynamicObstacle);

		public static readonly FGameplayTag Checker = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.Checker);

		public static readonly FGameplayTag RebirthPointInfoSave = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.RebirthPointInfoSave);

		public static readonly FGameplayTag WakeUp = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.WakeUp);

		public static readonly FGameplayTag Trigger = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.Trigger);

		public static readonly FGameplayTag Lamp = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.Lamp);

		public static readonly FGameplayTag Interactor = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.Interactor);

		public static readonly FGameplayTag Performer = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.Performer);

		public static readonly FGameplayTag NPCShow = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.NPCShow);

		public static readonly FGameplayTag MeditationPoint = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.MeditationPoint);

		public static readonly FGameplayTag Spawner = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.Spawner);

		public static readonly FGameplayTag BossControl = GameplayTagExtension.MakeGameplayTag(SceneObjTagName.BossControl);
	}

	public static class OverlapTagName
	{
		public static readonly FName State_Enabled = new FName("B1.SceneObj.Overlap.State_Enabled");

		public static readonly FName State_Enabling = new FName("B1.SceneObj.Overlap.State_Enabling");

		public static readonly FName State_Disabled = new FName("B1.SceneObj.Overlap.State_Disabled");

		public static readonly FName Event_Enable = new FName("B1.SceneObj.Overlap.Event_Enable");

		public static readonly FName Event_Disable = new FName("B1.SceneObj.Overlap.Event_Disable");
	}

	public static class OverlapTag
	{
		public static readonly FGameplayTag State_Enabled = GameplayTagExtension.MakeGameplayTag(OverlapTagName.State_Enabled);

		public static readonly FGameplayTag State_Disabled = GameplayTagExtension.MakeGameplayTag(OverlapTagName.State_Disabled);

		public static readonly FGameplayTag Event_Enable = GameplayTagExtension.MakeGameplayTag(OverlapTagName.Event_Enable);

		public static readonly FGameplayTag Event_Disable = GameplayTagExtension.MakeGameplayTag(OverlapTagName.Event_Disable);
	}

	public static class RebirthPointTagName
	{
		public static readonly FName State_InActived = new FName("B1.SceneObj.RebirthPoint.State_InActived");

		public static readonly FName State_Actived = new FName("B1.SceneObj.RebirthPoint.State_Actived");

		public static readonly FName Event_Active = new FName("B1.SceneObj.RebirthPoint.Event_Active");

		public static readonly FName Event_Deactive = new FName("B1.SceneObj.RebirthPoint.Event_Deactive");
	}

	public static class RebirthPointTag
	{
		public static readonly FGameplayTag State_InActived = GameplayTagExtension.MakeGameplayTag(RebirthPointTagName.State_InActived);

		public static readonly FGameplayTag State_Actived = GameplayTagExtension.MakeGameplayTag(RebirthPointTagName.State_Actived);

		public static readonly FGameplayTag Event_Active = GameplayTagExtension.MakeGameplayTag(RebirthPointTagName.Event_Active);

		public static readonly FGameplayTag Event_Deactive = GameplayTagExtension.MakeGameplayTag(RebirthPointTagName.Event_Deactive);
	}

	public static class MeditationPointTagName
	{
		public static readonly FName State_InActived = new FName("B1.SceneObj.MeditationPoint.State_InActived");

		public static readonly FName State_Actived = new FName("B1.SceneObj.MeditationPoint.State_Actived");

		public static readonly FName Event_Active = new FName("B1.SceneObj.MeditationPoint.Event_Active");

		public static readonly FName Event_Deactive = new FName("B1.SceneObj.MeditationPoint.Event_Deactive");
	}

	public static class MeditationPointTag
	{
		public static readonly FGameplayTag State_InActived = GameplayTagExtension.MakeGameplayTag(MeditationPointTagName.State_InActived);

		public static readonly FGameplayTag State_Actived = GameplayTagExtension.MakeGameplayTag(MeditationPointTagName.State_Actived);

		public static readonly FGameplayTag Event_Active = GameplayTagExtension.MakeGameplayTag(MeditationPointTagName.Event_Active);

		public static readonly FGameplayTag Event_Deactive = GameplayTagExtension.MakeGameplayTag(MeditationPointTagName.Event_Deactive);
	}

	public static class DynamicObstacleTagName
	{
		public static readonly FName State_Enabled = new FName("B1.SceneObj.DynamicObstacle.State_Enabled");

		public static readonly FName State_EnabledToDisable = new FName("B1.SceneObj.DynamicObstacle.State_EnabledToDisable");

		public static readonly FName State_Disabled = new FName("B1.SceneObj.DynamicObstacle.State_Disabled");

		public static readonly FName State_DisabledToEnabled = new FName("B1.SceneObj.DynamicObstacle.State_DisabledToEnabled");

		public static readonly FName Event_Enable = new FName("B1.SceneObj.DynamicObstacle.Event_Enable");

		public static readonly FName Event_EnabledToDisable = new FName("B1.SceneObj.DynamicObstacle.Event_EnabledToDisable");

		public static readonly FName Event_Disable = new FName("B1.SceneObj.DynamicObstacle.Event_Disable");

		public static readonly FName Event_DisabledToEnabled = new FName("B1.SceneObj.DynamicObstacle.Event_DisabledToEnabled");

		public static readonly FName Event_AchievePermanent = new FName("B1.SceneObj.DynamicObstacle.Event_AchievePermanent");
	}

	public static class DynamicObstacleTag
	{
		public static readonly FGameplayTag State_Enabled = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.State_Enabled);

		public static readonly FGameplayTag State_EnabledToDisable = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.State_EnabledToDisable);

		public static readonly FGameplayTag State_Disabled = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.State_Disabled);

		public static readonly FGameplayTag State_DisabledToEnabled = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.State_DisabledToEnabled);

		public static readonly FGameplayTag Event_Enable = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.Event_Enable);

		public static readonly FGameplayTag Event_EnabledToDisable = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.Event_EnabledToDisable);

		public static readonly FGameplayTag Event_Disable = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.Event_Disable);

		public static readonly FGameplayTag Event_DisabledToEnabled = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.Event_DisabledToEnabled);

		public static readonly FGameplayTag Event_AchievePermanent = GameplayTagExtension.MakeGameplayTag(DynamicObstacleTagName.Event_AchievePermanent);
	}

	public static class CheckerTagName
	{
		public static readonly FName State_Enabled = new FName("B1.SceneObj.Checker.State_Enabled");

		public static readonly FName State_Disabled = new FName("B1.SceneObj.Checker.State_Disabled");

		public static readonly FName Event_Enable = new FName("B1.SceneObj.Checker.Event_Enable");

		public static readonly FName Event_Disable = new FName("B1.SceneObj.Checker.Event_Disable");
	}

	public static class CheckerTag
	{
		public static readonly FGameplayTag Event_Enable = GameplayTagExtension.MakeGameplayTag(CheckerTagName.Event_Enable);

		public static readonly FGameplayTag Event_Disable = GameplayTagExtension.MakeGameplayTag(CheckerTagName.Event_Disable);

		public static readonly FGameplayTag State_Enabled = GameplayTagExtension.MakeGameplayTag(CheckerTagName.State_Enabled);

		public static readonly FGameplayTag State_Disabled = GameplayTagExtension.MakeGameplayTag(CheckerTagName.State_Disabled);
	}

	public static class InteractorTagName
	{
		public static readonly FName State_Before_Active = new FName("B1.SceneObj.Interactor.State_Before_Active");

		public static readonly FName State_Before_Inactive = new FName("B1.SceneObj.Interactor.State_Before_Inactive");

		public static readonly FName State_After_Inactive = new FName("B1.SceneObj.Interactor.State_After_Inactive");

		public static readonly FName Event_Before_Active = new FName("B1.SceneObj.Interactor.Event_Before_Active");

		public static readonly FName Event_Before_Inactive = new FName("B1.SceneObj.Interactor.Event_Before_Inactive");

		public static readonly FName Event_After_Inactive = new FName("B1.SceneObj.Interactor.Event_After_Inactive");

		public static readonly FName Event_BeforeToAfter = new FName("B1.SceneObj.Interactor.Event_BeforeToAfter");
	}

	public static class InteractorTag
	{
		public static readonly FGameplayTag State_Before_Active = GameplayTagExtension.MakeGameplayTag(InteractorTagName.State_Before_Active);

		public static readonly FGameplayTag State_Before_Inactive = GameplayTagExtension.MakeGameplayTag(InteractorTagName.State_Before_Inactive);

		public static readonly FGameplayTag State_After_Inactive = GameplayTagExtension.MakeGameplayTag(InteractorTagName.State_After_Inactive);

		public static readonly FGameplayTag Event_Before_Active = GameplayTagExtension.MakeGameplayTag(InteractorTagName.Event_Before_Active);

		public static readonly FGameplayTag Event_Before_Inactive = GameplayTagExtension.MakeGameplayTag(InteractorTagName.Event_Before_Inactive);

		public static readonly FGameplayTag Event_After_Inactive = GameplayTagExtension.MakeGameplayTag(InteractorTagName.Event_After_Inactive);

		public static readonly FGameplayTag Event_BeforeToAfter = GameplayTagExtension.MakeGameplayTag(InteractorTagName.Event_BeforeToAfter);
	}

	public static class DestructionTagName
	{
		public static readonly FName State_CantGen_CantDrop = new FName("B1.SceneObj.Destruction.State_CantGen_CantDrop");

		public static readonly FName State_CanGen_CanDrop = new FName("B1.SceneObj.Destruction.State_CanGen_CanDrop");

		public static readonly FName State_CanGen_CantDrop = new FName("B1.SceneObj.Destruction.State_CanGen_CantDrop");

		public static readonly FName State_Drop_Fail = new FName("B1.SceneObj.Destruction.State_Drop_Fail");
	}

	public static class DestructionTag
	{
		public static readonly FGameplayTag State_CantGen_CantDrop = GameplayTagExtension.MakeGameplayTag(DestructionTagName.State_CantGen_CantDrop);

		public static readonly FGameplayTag State_CanGen_CanDrop = GameplayTagExtension.MakeGameplayTag(DestructionTagName.State_CanGen_CanDrop);

		public static readonly FGameplayTag State_CanGen_CantDrop = GameplayTagExtension.MakeGameplayTag(DestructionTagName.State_CanGen_CantDrop);

		public static readonly FGameplayTag State_Drop_Fail = GameplayTagExtension.MakeGameplayTag(DestructionTagName.State_Drop_Fail);
	}

	public static class RebirthPointInfoSaveTagName
	{
		public static readonly FName State_UnSave = new FName("B1.SceneObj.RebirthPointInfoSave.State_UnSave");

		public static readonly FName State_Save = new FName("B1.SceneObj.RebirthPointInfoSave.State_Save");

		public static readonly FName Event_CloseSave = new FName("B1.SceneObj.RebirthPointInfoSave.Event_CloseSave");

		public static readonly FName Event_OpenSave = new FName("B1.SceneObj.RebirthPointInfoSave.Event_OpenSave");
	}

	public static class RebirthPointInfoSaveTag
	{
		public static readonly FGameplayTag State_UnSave = GameplayTagExtension.MakeGameplayTag(RebirthPointInfoSaveTagName.State_UnSave);

		public static readonly FGameplayTag State_Save = GameplayTagExtension.MakeGameplayTag(RebirthPointInfoSaveTagName.State_Save);

		public static readonly FGameplayTag Event_CloseSave = GameplayTagExtension.MakeGameplayTag(RebirthPointInfoSaveTagName.Event_CloseSave);

		public static readonly FGameplayTag Event_OpenSave = GameplayTagExtension.MakeGameplayTag(RebirthPointInfoSaveTagName.Event_OpenSave);
	}

	public static class ActorCallerTagName
	{
		public static readonly FName State_NotCalled = new FName("B1.SceneObj.ActorCaller.State_NotCalled");

		public static readonly FName State_Called = new FName("B1.SceneObj.ActorCaller.State_Called");

		public static readonly FName Event_Call = new FName("B1.SceneObj.ActorCaller.Event_Call");

		public static readonly FName Event_Reset = new FName("B1.SceneObj.ActorCaller.Event_Reset");
	}

	public static class ActorCallerTag
	{
		public static readonly FGameplayTag State_NotCalled = GameplayTagExtension.MakeGameplayTag(ActorCallerTagName.State_NotCalled);

		public static readonly FGameplayTag State_Called = GameplayTagExtension.MakeGameplayTag(ActorCallerTagName.State_Called);

		public static readonly FGameplayTag Event_Call = GameplayTagExtension.MakeGameplayTag(ActorCallerTagName.Event_Call);

		public static readonly FGameplayTag Event_Reset = GameplayTagExtension.MakeGameplayTag(ActorCallerTagName.Event_Reset);
	}

	public static class WakeUpTagName
	{
		public static readonly FName State_InActived = new FName("B1.SceneObj.WakeUp.State_InActived");

		public static readonly FName State_Activating = new FName("B1.SceneObj.WakeUp.State_Activating");

		public static readonly FName State_Actived = new FName("B1.SceneObj.WakeUp.State_Actived");

		public static readonly FName Event_Active = new FName("B1.SceneObj.WakeUp.Event_Active");

		public static readonly FName Event_ActiveComplete = new FName("B1.SceneObj.WakeUp.Event_ActiveComplete");

		public static readonly FName Event_Deactive = new FName("B1.SceneObj.WakeUp.Event_Deactive");
	}

	public static class WakeUpTag
	{
		public static readonly FGameplayTag State_InActived = GameplayTagExtension.MakeGameplayTag(WakeUpTagName.State_InActived);

		public static readonly FGameplayTag State_Activating = GameplayTagExtension.MakeGameplayTag(WakeUpTagName.State_Activating);

		public static readonly FGameplayTag State_Actived = GameplayTagExtension.MakeGameplayTag(WakeUpTagName.State_Actived);

		public static readonly FGameplayTag Event_Active = GameplayTagExtension.MakeGameplayTag(WakeUpTagName.Event_Active);

		public static readonly FGameplayTag Event_ActiveComplete = GameplayTagExtension.MakeGameplayTag(WakeUpTagName.Event_ActiveComplete);

		public static readonly FGameplayTag Event_Deactive = GameplayTagExtension.MakeGameplayTag(WakeUpTagName.Event_Deactive);
	}

	public static class DumperTruckTagName
	{
		public static readonly FName State_InActived = new FName("B1.SceneObj.DumperTruck.State_InActived");

		public static readonly FName State_WaitWakeUp = new FName("B1.SceneObj.DumperTruck.State_WaitWakeUp");

		public static readonly FName State_Activating = new FName("B1.SceneObj.DumperTruck.State_Activating");

		public static readonly FName State_Actived = new FName("B1.SceneObj.DumperTruck.State_Actived");

		public static readonly FName Event_JumpToWakeUp = new FName("B1.SceneObj.DumperTruck.Event_JumpToWakeUp");

		public static readonly FName Event_JumpToActivating = new FName("B1.SceneObj.DumperTruck.Event_JumpToActivating");

		public static readonly FName Event_JumpToActived = new FName("B1.SceneObj.DumperTruck.Event_JumpToActived");

		public static readonly FName Event_JumpToInActived = new FName("B1.SceneObj.DumperTruck.Event_JumpToInActived");
	}

	public static class DumperTruckTag
	{
		public static readonly FGameplayTag State_InActived = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.State_InActived);

		public static readonly FGameplayTag State_WaitWakeUp = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.State_WaitWakeUp);

		public static readonly FGameplayTag State_Activating = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.State_Activating);

		public static readonly FGameplayTag State_Actived = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.State_Actived);

		public static readonly FGameplayTag Event_JumpToWakeUp = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.Event_JumpToWakeUp);

		public static readonly FGameplayTag Event_JumpToActivating = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.Event_JumpToActivating);

		public static readonly FGameplayTag Event_JumpToActived = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.Event_JumpToActived);

		public static readonly FGameplayTag Event_JumpToInActived = GameplayTagExtension.MakeGameplayTag(DumperTruckTagName.Event_JumpToInActived);
	}

	public static class AiInteractTagName
	{
		public static readonly FName State_Idle = new FName("B1.SceneObj.AiInteract.State_Idle");

		public static readonly FName State_Action = new FName("B1.SceneObj.AiInteract.State_Action");

		public static readonly FName State_Waiting = new FName("B1.SceneObj.AiInteract.State_Waiting");

		public static readonly FName State_MatchPos = new FName("B1.SceneObj.AiInteract.State_MatchPos");

		public static readonly FName State_MatchWaiting = new FName("B1.SceneObj.AiInteract.State_MatchWaiting");

		public static readonly FName State_TeleportPos = new FName("B1.SceneObj.AiInteract.State_TeleportPos");

		public static readonly FName State_TeleportWait = new FName("B1.SceneObj.AiInteract.State_TeleportWait");

		public static readonly FName Event_NextStep = new FName("B1.SceneObj.AiInteract.Event_NextStep");

		public static readonly FName Event_ToInteractPointFar = new FName("B1.SceneObj.AiInteract.Event_ToInteractPointFar");

		public static readonly FName Event_ToInteractPointNear = new FName("B1.SceneObj.AiInteract.Event_ToInteractPointNear");

		public static readonly FName Event_ToWaitPointFar = new FName("B1.SceneObj.AiInteract.Event_ToWaitPointFar");

		public static readonly FName Event_ToWaitPointNear = new FName("B1.SceneObj.AiInteract.Event_ToWaitPointNear");
	}

	public static class AiInteractTag
	{
		public static readonly FGameplayTag State_Idle = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.State_Idle);

		public static readonly FGameplayTag State_Action = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.State_Action);

		public static readonly FGameplayTag State_Waiting = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.State_Waiting);

		public static readonly FGameplayTag State_MatchPos = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.State_MatchPos);

		public static readonly FGameplayTag State_MatchWaiting = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.State_MatchWaiting);

		public static readonly FGameplayTag State_TeleportPos = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.State_TeleportPos);

		public static readonly FGameplayTag State_TeleportWait = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.State_TeleportWait);

		public static readonly FGameplayTag Event_NextStep = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.Event_NextStep);

		public static readonly FGameplayTag Event_ToInteractPointFar = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.Event_ToInteractPointFar);

		public static readonly FGameplayTag Event_ToInteractPointNear = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.Event_ToInteractPointNear);

		public static readonly FGameplayTag Event_ToWaitPointFar = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.Event_ToWaitPointFar);

		public static readonly FGameplayTag Event_ToWaitPointNear = GameplayTagExtension.MakeGameplayTag(AiInteractTagName.Event_ToWaitPointNear);
	}

	public static class SplineFlyMoveTagName
	{
		public static readonly FName State_InActived = new FName("B1.SceneObj.SplineFlyMoveTrigger.State_InActived");

		public static readonly FName State_Flying = new FName("B1.SceneObj.SplineFlyMoveTrigger.State_Flying");

		public static readonly FName State_Actived = new FName("B1.SceneObj.SplineFlyMoveTrigger.State_Actived");

		public static readonly FName Event_TriggerSplineFly = new FName("B1.SceneObj.SplineFlyMoveTrigger.Event_TriggerSplineFly");
	}

	public static class SplineFlyMoveTag
	{
		public static readonly FGameplayTag State_InActived = GameplayTagExtension.MakeGameplayTag(SplineFlyMoveTagName.State_InActived);

		public static readonly FGameplayTag State_Flying = GameplayTagExtension.MakeGameplayTag(SplineFlyMoveTagName.State_Flying);

		public static readonly FGameplayTag State_Actived = GameplayTagExtension.MakeGameplayTag(SplineFlyMoveTagName.State_Actived);

		public static readonly FGameplayTag Event_TriggerSplineFly = GameplayTagExtension.MakeGameplayTag(SplineFlyMoveTagName.Event_TriggerSplineFly);
	}

	public static class TriggerTagName
	{
		public static readonly FName State_Disabled = new FName("B1.SceneObj.Trigger.State_Disabled");

		public static readonly FName State_UnTriggered = new FName("B1.SceneObj.Trigger.State_UnTriggered");

		public static readonly FName State_Triggering = new FName("B1.SceneObj.Trigger.State_Triggering");

		public static readonly FName State_Triggered = new FName("B1.SceneObj.Trigger.State_Triggered");

		public static readonly FName Event_Disable = new FName("B1.SceneObj.Trigger.Event_Disable");

		public static readonly FName Event_Enable = new FName("B1.SceneObj.Trigger.Event_Enable");

		public static readonly FName Event_Trigger = new FName("B1.SceneObj.Trigger.Event_Trigger");

		public static readonly FName Event_TriggerComplete = new FName("B1.SceneObj.Trigger.Event_TriggerComplete");

		public static readonly FName Event_Reset = new FName("B1.SceneObj.Trigger.Event_Reset");

		public static readonly FName Event_ReTrigger = new FName("B1.SceneObj.Trigger.Event_ReTrigger");
	}

	public static class TriggerTag
	{
		public static readonly FGameplayTag State_Disabled = GameplayTagExtension.MakeGameplayTag(TriggerTagName.State_Disabled);

		public static readonly FGameplayTag State_UnTriggered = GameplayTagExtension.MakeGameplayTag(TriggerTagName.State_UnTriggered);

		public static readonly FGameplayTag State_Triggering = GameplayTagExtension.MakeGameplayTag(TriggerTagName.State_Triggering);

		public static readonly FGameplayTag State_Triggered = GameplayTagExtension.MakeGameplayTag(TriggerTagName.State_Triggered);

		public static readonly FGameplayTag Event_Disable = GameplayTagExtension.MakeGameplayTag(TriggerTagName.Event_Disable);

		public static readonly FGameplayTag Event_Enable = GameplayTagExtension.MakeGameplayTag(TriggerTagName.Event_Enable);

		public static readonly FGameplayTag Event_Trigger = GameplayTagExtension.MakeGameplayTag(TriggerTagName.Event_Trigger);

		public static readonly FGameplayTag Event_TriggerComplete = GameplayTagExtension.MakeGameplayTag(TriggerTagName.Event_TriggerComplete);

		public static readonly FGameplayTag Event_Reset = GameplayTagExtension.MakeGameplayTag(TriggerTagName.Event_Reset);

		public static readonly FGameplayTag Event_ReTrigger = GameplayTagExtension.MakeGameplayTag(TriggerTagName.Event_ReTrigger);
	}

	public static class LampTagName
	{
		public static readonly FName State_Off = new FName("B1.SceneObj.Lamp.State_Off");

		public static readonly FName State_Lighting1 = new FName("B1.SceneObj.Lamp.State_Lighting1");

		public static readonly FName State_Lighting2 = new FName("B1.SceneObj.Lamp.State_Lighting2");

		public static readonly FName Event_OpenLight1 = new FName("B1.SceneObj.Lamp.Event_OpenLight1");

		public static readonly FName Event_OpenLight2 = new FName("B1.SceneObj.Lamp.Event_OpenLight2");

		public static readonly FName Event_Close = new FName("B1.SceneObj.Lamp.Event_Close");
	}

	public static class LampTag
	{
		public static readonly FGameplayTag State_Off = GameplayTagExtension.MakeGameplayTag(LampTagName.State_Off);

		public static readonly FGameplayTag State_Lighting1 = GameplayTagExtension.MakeGameplayTag(LampTagName.State_Lighting1);

		public static readonly FGameplayTag State_Lighting2 = GameplayTagExtension.MakeGameplayTag(LampTagName.State_Lighting2);

		public static readonly FGameplayTag Event_OpenLight1 = GameplayTagExtension.MakeGameplayTag(LampTagName.Event_OpenLight1);

		public static readonly FGameplayTag Event_OpenLight2 = GameplayTagExtension.MakeGameplayTag(LampTagName.Event_OpenLight2);

		public static readonly FGameplayTag Event_Close = GameplayTagExtension.MakeGameplayTag(LampTagName.Event_Close);
	}

	public static class PerformerTagName
	{
		public static readonly FName State_Waiting = new FName("B1.SceneObj.Performer.State_Waiting");

		public static readonly FName State_Showing = new FName("B1.SceneObj.Performer.State_Showing");

		public static readonly FName State_PreShowing = new FName("B1.SceneObj.Performer.State_PreShowing");

		public static readonly FName State_Bowing = new FName("B1.SceneObj.Performer.State_Bowing");

		public static readonly FName State_Completed = new FName("B1.SceneObj.Performer.State_Completed");

		public static readonly FName Event_PreShow = new FName("B1.SceneObj.Performer.Event_PreShow");

		public static readonly FName Event_Show = new FName("B1.SceneObj.Performer.Event_Show");

		public static readonly FName Event_AfterShowing = new FName("B1.SceneObj.Performer.Event_AfterShowing");

		public static readonly FName Event_FinishBow = new FName("B1.SceneObj.Performer.Event_FinishBow");

		public static readonly FName Event_Wait = new FName("B1.SceneObj.Performer.Event_Disappear");
	}

	public static class PerformerTag
	{
		public static readonly FGameplayTag State_Waiting = GameplayTagExtension.MakeGameplayTag(PerformerTagName.State_Waiting);

		public static readonly FGameplayTag State_Showing = GameplayTagExtension.MakeGameplayTag(PerformerTagName.State_Showing);

		public static readonly FGameplayTag State_PreShowing = GameplayTagExtension.MakeGameplayTag(PerformerTagName.State_PreShowing);

		public static readonly FGameplayTag State_Bowing = GameplayTagExtension.MakeGameplayTag(PerformerTagName.State_Bowing);

		public static readonly FGameplayTag State_Completed = GameplayTagExtension.MakeGameplayTag(PerformerTagName.State_Completed);

		public static readonly FGameplayTag Event_PreShow = GameplayTagExtension.MakeGameplayTag(PerformerTagName.Event_PreShow);

		public static readonly FGameplayTag Event_Show = GameplayTagExtension.MakeGameplayTag(PerformerTagName.Event_Show);

		public static readonly FGameplayTag Event_AfterShowing = GameplayTagExtension.MakeGameplayTag(PerformerTagName.Event_AfterShowing);

		public static readonly FGameplayTag Event_FinishBow = GameplayTagExtension.MakeGameplayTag(PerformerTagName.Event_FinishBow);

		public static readonly FGameplayTag Event_Wait = GameplayTagExtension.MakeGameplayTag(PerformerTagName.Event_Wait);
	}

	public static class NPCShowTagName
	{
		public static readonly FName State_Appearing = new FName("B1.SceneObj.NPCShow.State_Appearing");

		public static readonly FName State_Hiding = new FName("B1.SceneObj.NPCShow.State_Hiding");

		public static readonly FName Event_Appear = new FName("B1.SceneObj.Performer.Event_Appear");

		public static readonly FName Event_Hide = new FName("B1.SceneObj.Performer.Event_Hide");
	}

	public static class NPCShowTag
	{
		public static readonly FGameplayTag State_Appearing = GameplayTagExtension.MakeGameplayTag(NPCShowTagName.State_Appearing);

		public static readonly FGameplayTag State_Hiding = GameplayTagExtension.MakeGameplayTag(NPCShowTagName.State_Hiding);

		public static readonly FGameplayTag Event_Appear = GameplayTagExtension.MakeGameplayTag(NPCShowTagName.Event_Appear);

		public static readonly FGameplayTag Event_Hide = GameplayTagExtension.MakeGameplayTag(NPCShowTagName.Event_Hide);
	}

	public static class SpawnerTagName
	{
		public static readonly FName State_Disabled = new FName("B1.SceneObj.Spawner.State_Disabled");

		public static readonly FName State_Idled = new FName("B1.SceneObj.Spawner.State_Idled");

		public static readonly FName State_Spawned = new FName("B1.SceneObj.Spawner.State_Spawned");

		public static readonly FName State_Cleared = new FName("B1.SceneObj.Spawner.State_Cleared");

		public static readonly FName Event_Active = new FName("B1.SceneObj.Spawner.Event_Active");

		public static readonly FName Event_Enable = new FName("B1.SceneObj.Spawner.Event_Enable");

		public static readonly FName Event_Spawn = new FName("B1.SceneObj.Spawner.Event_Spawn");

		public static readonly FName Event_Clear = new FName("B1.SceneObj.Spawner.Event_Clear");

		public static readonly FName Event_Disable = new FName("B1.SceneObj.Spawner.Event_Disable");

		public static readonly FName Event_RecoveryToIdle = new FName("B1.SceneObj.Spawner.Event_RecoveryToIdle");
	}

	public static class SpawnerTag
	{
		public static readonly FGameplayTag State_Disabled = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.State_Disabled);

		public static readonly FGameplayTag State_Idled = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.State_Idled);

		public static readonly FGameplayTag State_Spawned = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.State_Spawned);

		public static readonly FGameplayTag State_Cleared = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.State_Cleared);

		public static readonly FGameplayTag Event_Active = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.Event_Active);

		public static readonly FGameplayTag Event_Enable = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.Event_Enable);

		public static readonly FGameplayTag Event_Spawn = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.Event_Spawn);

		public static readonly FGameplayTag Event_Disable = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.Event_Disable);

		public static readonly FGameplayTag Event_Clear = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.Event_Clear);

		public static readonly FGameplayTag Event_RecoveryToIdle = GameplayTagExtension.MakeGameplayTag(SpawnerTagName.Event_RecoveryToIdle);
	}

	public static class BossControlTagName
	{
		public static readonly FName State_Disabled = new FName("B1.SceneObj.BossControl.State_Disabled");

		public static readonly FName State_Idled = new FName("B1.SceneObj.BossControl.State_Idled");

		public static readonly FName State_Fought = new FName("B1.SceneObj.BossControl.State_Fought");

		public static readonly FName State_Death = new FName("B1.SceneObj.BossControl.State_Death");

		public static readonly FName Event_Enable = new FName("B1.SceneObj.BossControl.Event_Enable");

		public static readonly FName Event_WakeUp = new FName("B1.SceneObj.BossControl.Event_WakeUp");

		public static readonly FName Event_GoHome = new FName("B1.SceneObj.BossControl.Event_GoHome");

		public static readonly FName Event_Kill = new FName("B1.SceneObj.BossControl.Event_Kill");

		public static readonly FName Event_Rebirth = new FName("B1.SceneObj.BossControl.Event_Rebirth");

		public static readonly FName Event_Disable = new FName("B1.SceneObj.BossControl.Event_Disable");
	}

	public static class BossControlTag
	{
		public static readonly FGameplayTag State_Disable = GameplayTagExtension.MakeGameplayTag(BossControlTagName.State_Disabled);

		public static readonly FGameplayTag State_Idled = GameplayTagExtension.MakeGameplayTag(BossControlTagName.State_Idled);

		public static readonly FGameplayTag State_Fought = GameplayTagExtension.MakeGameplayTag(BossControlTagName.State_Fought);

		public static readonly FGameplayTag State_Death = GameplayTagExtension.MakeGameplayTag(BossControlTagName.State_Death);

		public static readonly FGameplayTag Event_Enable = GameplayTagExtension.MakeGameplayTag(BossControlTagName.Event_Enable);

		public static readonly FGameplayTag Event_WakeUp = GameplayTagExtension.MakeGameplayTag(BossControlTagName.Event_WakeUp);

		public static readonly FGameplayTag Event_GoHome = GameplayTagExtension.MakeGameplayTag(BossControlTagName.Event_GoHome);

		public static readonly FGameplayTag Event_Kill = GameplayTagExtension.MakeGameplayTag(BossControlTagName.Event_Kill);

		public static readonly FGameplayTag Event_Rebirth = GameplayTagExtension.MakeGameplayTag(BossControlTagName.Event_Rebirth);

		public static readonly FGameplayTag Event_Disable = GameplayTagExtension.MakeGameplayTag(BossControlTagName.Event_Disable);
	}

	public static class PinName
	{
		public static readonly FName Start = new FName("Start");

		public static readonly FName Stop = new FName("Stop");

		public static readonly FName Success = new FName("Success");

		public static readonly FName Failed = new FName("Failed");

		public static readonly FName Completed = new FName("Completed");

		public static readonly FName Stopped = new FName("Stopped");

		public static readonly FName Enable = new FName("Enable");

		public static readonly FName Enabled = new FName("Enabled");

		public static readonly FName Disable = new FName("Disable");

		public static readonly FName Disabled = new FName("Disabled");

		public static readonly FName OverlapBegin = new FName("OverlapBegin");

		public static readonly FName OverlapEnd = new FName("OverlapEnd");

		public static readonly FName Spawn = new FName("Spawn");

		public static readonly FName Dead = new FName("Dead");

		public static readonly FName Skip = new FName("Skip");

		public static readonly FName Step = new FName("Step");

		public static readonly FName In = new FName("In");

		public static readonly FName Out = new FName("Out");

		public static readonly FName Goal = new FName("Goal");

		public static readonly FName Increment = new FName("Increment");

		public static readonly FName Decrement = new FName("Decrement");

		public static readonly FName Skipped = new FName("Skipped");

		public static readonly FName Zero = new FName("Zero");

		public static readonly FName Finish = new FName("Finish");

		public static readonly FName Reset = new FName("重置后");

		public static readonly FName PreStart = new FName("PreStart");

		public static readonly FName Started = new FName("Started");

		public static readonly FName StateMachineFinished = new FName("StateMachineFinished");

		public static readonly FName ShallowHistory = new FName("ShallowHistory");

		public static readonly FName DeepHistory = new FName("DeepHistory");
	}

	public static class NeutralAnimalAIFsmStateTagName
	{
		public static readonly FName Patrol = new FName("B1.FSM.State.NeutralAnimal.Patrol");

		public static readonly FName Battle = new FName("B1.FSM.State.NeutralAnimal.Battle");

		public static readonly FName Escape = new FName("B1.FSM.State.NeutralAnimal.Escape");
	}

	public static class NeutralAnimalAIFsmStateTag
	{
		public static readonly FGameplayTag Patrol = GameplayTagExtension.MakeGameplayTag(NeutralAnimalAIFsmStateTagName.Patrol);

		public static readonly FGameplayTag Battle = GameplayTagExtension.MakeGameplayTag(NeutralAnimalAIFsmStateTagName.Battle);

		public static readonly FGameplayTag Escape = GameplayTagExtension.MakeGameplayTag(NeutralAnimalAIFsmStateTagName.Escape);
	}

	public static class NeutralAnimalEscapeAIFsmEventTagName
	{
		public static readonly FName BackToPatrol = new FName("B1.FSM.Event.NeutralAnimal.BackToPatrol");
	}

	public static class NeutralAnimalEscapeAIFsmEventTag
	{
		public static readonly FGameplayTag BackToPatrol = GameplayTagExtension.MakeGameplayTag(NeutralAnimalEscapeAIFsmEventTagName.BackToPatrol);
	}

	public static class FollowPartnerAIFsmStateTagName
	{
		public static readonly FName Battle = new FName("B1.FSM.State.FollowPartner.Battle");

		public static readonly FName FocusOnAttack = new FName("B1.FSM.State.FollowPartner.Battle.FocusOnAttack");

		public static readonly FName FocusOnPlayer = new FName("B1.FSM.State.FollowPartner.Battle.FocusOnPlayer");

		public static readonly FName AroundPlayer = new FName("B1.FSM.State.FollowPartner.Battle.AroundPlayer");

		public static readonly FName NonCombat = new FName("B1.FSM.State.FollowPartner.NonCombat");

		public static readonly FName Idle = new FName("B1.FSM.State.FollowPartner.NonCombat.Idle");

		public static readonly FName Standby = new FName("B1.FSM.State.FollowPartner.NonCombat.Idle.Standby");

		public static readonly FName Dodge = new FName("B1.FSM.State.FollowPartner.NonCombat.Idle.Dodge");

		public static readonly FName LongIdle = new FName("B1.FSM.State.FollowPartner.NonCombat.Idle.LongIdle");

		public static readonly FName Interaction = new FName("B1.FSM.State.FollowPartner.NonCombat.Interaction");

		public static readonly FName Interacting = new FName("B1.FSM.State.FollowPartner.NonCombat.Interaction.Interacting");

		public static readonly FName Waiting = new FName("B1.FSM.State.FollowPartner.NonCombat.Interaction.Waiting");

		public static readonly FName InSeqShowing = new FName("B1.FSM.State.FollowPartner.InSeqShowing");

		public static readonly FName Hidden = new FName("B1.FSM.State.FollowPartner.InSeqShowing.Hidden");

		public static readonly FName Playback = new FName("B1.FSM.State.FollowPartner.InSeqShowing.Playback");
	}

	public static class FollowPartnerAIFsmStateTag
	{
		public static readonly FGameplayTag Battle = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Battle);

		public static readonly FGameplayTag FocusOnAttack = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.FocusOnAttack);

		public static readonly FGameplayTag FocusOnPlayer = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.FocusOnPlayer);

		public static readonly FGameplayTag AroundPlayer = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.AroundPlayer);

		public static readonly FGameplayTag NonCombat = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.NonCombat);

		public static readonly FGameplayTag Idle = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Idle);

		public static readonly FGameplayTag Standby = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Standby);

		public static readonly FGameplayTag Dodge = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Dodge);

		public static readonly FGameplayTag LongIdle = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.LongIdle);

		public static readonly FGameplayTag Interaction = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Interaction);

		public static readonly FGameplayTag Interacting = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Interacting);

		public static readonly FGameplayTag Waiting = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Waiting);

		public static readonly FGameplayTag InSeqShowing = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.InSeqShowing);

		public static readonly FGameplayTag Hidden = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Hidden);

		public static readonly FGameplayTag Playback = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmStateTagName.Playback);
	}

	public static class FollowPartnerAIFsmEventTagName
	{
		public static readonly FName FollowPartner = new FName("B1.FSM.Event.FollowPartner");

		public static readonly FName ApproachPlayer = new FName("B1.FSM.Event.FollowPartner.Battle.TryToApproachPlayer");

		public static readonly FName Attack = new FName("B1.FSM.Event.FollowPartner.Battle.Attack");

		public static readonly FName BackToPlayer = new FName("B1.FSM.Event.FollowPartner.Battle.BackToPlayer");

		public static readonly FName Dodge = new FName("B1.FSM.Event.FollowPartner.NonCombat.Dodge");

		public static readonly FName EnterInteractArea = new FName("B1.FSM.Event.FollowPartner.NonCombat.EnterInteractArea");

		public static readonly FName FreeTime = new FName("B1.FSM.Event.FollowPartner.NonCombat.FreeTime");

		public static readonly FName LongTimeNoAction = new FName("B1.FSM.Event.FollowPartner.NonCombat.LongTimeNoAction");

		public static readonly FName WaitForInteract = new FName("B1.FSM.Event.FollowPartner.NonCombat.WaitForInteract");

		public static readonly FName PlaybackFinish = new FName("B1.FSM.Event.FollowPartner.InSeqShowing.PlaybackFinish");

		public static readonly FName ShowBegin = new FName("B1.FSM.Event.FollowPartner.InSeqShowing.ShowBegin");

		public static readonly FName ShowFinish = new FName("B1.FSM.Event.FollowPartner.InSeqShowing.ShowFinish");
	}

	public static class FollowPartnerAIFsmEventTag
	{
		public static readonly FGameplayTag FollowPartner = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.FollowPartner);

		public static readonly FGameplayTag ApproachPlayer = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.ApproachPlayer);

		public static readonly FGameplayTag Attack = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.Attack);

		public static readonly FGameplayTag BackToPlayer = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.BackToPlayer);

		public static readonly FGameplayTag Dodge = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.Dodge);

		public static readonly FGameplayTag EnterInteractArea = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.EnterInteractArea);

		public static readonly FGameplayTag FreeTime = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.FreeTime);

		public static readonly FGameplayTag LongTimeNoAction = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.LongTimeNoAction);

		public static readonly FGameplayTag WaitForInteract = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.WaitForInteract);

		public static readonly FGameplayTag PlaybackFinish = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.PlaybackFinish);

		public static readonly FGameplayTag ShowBegin = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.ShowBegin);

		public static readonly FGameplayTag ShowFinish = GameplayTagExtension.MakeGameplayTag(FollowPartnerAIFsmEventTagName.ShowFinish);
	}

	public static class NormalAIFsmStateTagName
	{
		public static readonly FName AINonCombat = new FName("B1.FSM.State.AI.NonCombat");

		public static readonly FName AINonCombatIdle = new FName("B1.FSM.State.AI.NonCombat.Idle");

		public static readonly FName AINonCombatBorn = new FName("B1.FSM.State.AI.NonCombat.Born");

		public static readonly FName AIBattle = new FName("B1.FSM.State.AI.Battle");

		public static readonly FName AIBattleWander = new FName("B1.FSM.State.AI.Battle.Wander");

		public static readonly FName AIBattleAttack = new FName("B1.FSM.State.AI.Battle.Attack");

		public static readonly FName AIWakeup = new FName("B1.FSM.State.AI.Wakeup");

		public static readonly FName AIWakeupEngage = new FName("B1.FSM.State.AI.Wakeup.Engage");

		public static readonly FName AIWakeupSurpriseSkill = new FName("B1.FSM.State.AI.Wakeup.SurpriseSkill");

		public static readonly FName LifeTime = new FName("B1.FSM.State.AI.LifeTime");

		public static readonly FName LifeTimeStalemate = new FName("B1.FSM.State.AI.LifeTime.Stalemate");

		public static readonly FName LifeTimeDead = new FName("B1.FSM.State.AI.LifeTime.Dead");

		public static readonly FName LifeTimeReturnHome = new FName("B1.FSM.State.AI.LifeTime.ReturnHome");

		public static readonly FName LifeTimeRevolveAround = new FName("B1.FSM.State.AI.LifeTime.RevolveAround");
	}

	public static class NormalAIFsmStateTag
	{
		public static readonly FGameplayTag AINonCombat = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AINonCombat);

		public static readonly FGameplayTag AINonCombatIdle = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AINonCombatIdle);

		public static readonly FGameplayTag AINonCombatBorn = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AINonCombatBorn);

		public static readonly FGameplayTag AIBattle = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AIBattle);

		public static readonly FGameplayTag AIBattleWander = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AIBattleWander);

		public static readonly FGameplayTag AIBattleAttack = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AIBattleAttack);

		public static readonly FGameplayTag AIWakeup = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AIWakeup);

		public static readonly FGameplayTag AIWakeupEngage = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AIWakeupEngage);

		public static readonly FGameplayTag AIWakeupSurpriseSkill = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.AIWakeupSurpriseSkill);

		public static readonly FGameplayTag LifeTime = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.LifeTime);

		public static readonly FGameplayTag LifeTimeStalemate = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.LifeTimeStalemate);

		public static readonly FGameplayTag LifeTimeDead = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.LifeTimeDead);

		public static readonly FGameplayTag LifeTimeReturnHome = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.LifeTimeReturnHome);

		public static readonly FGameplayTag LifeTimeRevolveAround = GameplayTagExtension.MakeGameplayTag(NormalAIFsmStateTagName.LifeTimeRevolveAround);
	}

	public static class NormalAIFsmEventTagName
	{
		public static readonly FName Validation = new FName("B1.FSM.Event");

		public static readonly FName AINonCombatFinishBorn = new FName("B1.FSM.Event.AI.NonCombat.FinishBorn");

		public static readonly FName AIBattle = new FName("B1.FSM.Event.AI.Battle");

		public static readonly FName AIBattleAttack = new FName("B1.FSM.Event.AI.Battle.Attack");

		public static readonly FName AIBattleWander = new FName("B1.FSM.Event.AI.Battle.Wander");

		public static readonly FName AIBattleBeHit = new FName("B1.FSM.Event.AI.Battle.BeHit");

		public static readonly FName AIWakeupFinishEngage = new FName("B1.FSM.Event.AI.Wakeup.FinishEngage");

		public static readonly FName LifeTimeHasTarget = new FName("B1.FSM.Event.AI.LifeTime.HasTarget");

		public static readonly FName LifeTimeIntoBattle = new FName("B1.FSM.Event.AI.LifeTime.IntoBattle");

		public static readonly FName LifeTimeAwake = new FName("B1.FSM.Event.AI.LifeTime.Awake");

		public static readonly FName LifeTimeDie = new FName("B1.FSM.Event.AI.LifeTime.Die");

		public static readonly FName LifeTimeGoHome = new FName("B1.FSM.Event.AI.LifeTime.GoHome");

		public static readonly FName LifeTimeGazeAndSurround = new FName("B1.FSM.Event.AI.LifeTime.GazeAndSurround");

		public static readonly FName LifeTimeIntoStalemate = new FName("B1.FSM.Event.AI.LifeTime.IntoStalemate");

		public static readonly FName LifeTimeStandby = new FName("B1.FSM.Event.AI.LifeTime.Standby");

		public static readonly FName CommonReset = new FName("B1.FSM.Event.AI.Common.Reset");

		public static readonly FName ExitAll = new FName("B1.FSM.Event.AI.Common.ExitAll");
	}

	public static class NormalAIFsmEventTag
	{
		public static readonly FGameplayTag Validation = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.Validation);

		public static readonly FGameplayTag AINonCombatFinishBorn = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.AINonCombatFinishBorn);

		public static readonly FGameplayTag AIBattle = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.AIBattle);

		public static readonly FGameplayTag AIBattleAttack = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.AIBattleAttack);

		public static readonly FGameplayTag AIBattleWander = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.AIBattleWander);

		public static readonly FGameplayTag AIBattleBeHit = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.AIBattleBeHit);

		public static readonly FGameplayTag AIWakeupFinishEngage = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.AIWakeupFinishEngage);

		public static readonly FGameplayTag LifeTimeHasTarget = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeHasTarget);

		public static readonly FGameplayTag LifeTimeIntoBattle = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeIntoBattle);

		public static readonly FGameplayTag LifeTimeAwake = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeAwake);

		public static readonly FGameplayTag LifeTimeDie = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeDie);

		public static readonly FGameplayTag LifeTimeGoHome = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeGoHome);

		public static readonly FGameplayTag LifeTimeGazeAndSurround = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeGazeAndSurround);

		public static readonly FGameplayTag LifeTimeIntoStalemate = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeIntoStalemate);

		public static readonly FGameplayTag LifeTimeStandby = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.LifeTimeStandby);

		public static readonly FGameplayTag CommonReset = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.CommonReset);

		public static readonly FGameplayTag ExitAll = GameplayTagExtension.MakeGameplayTag(NormalAIFsmEventTagName.ExitAll);
	}

	public static class FsmStateTagName
	{
		public static readonly FName Validation = new FName("B1.FSM.State");

		public static readonly FName GraphInitial = new FName("B1.FSM.State.Graph.Initial");

		public static readonly FName GraphFork = new FName("B1.FSM.State.Graph.Fork");

		public static readonly FName GraphJoin = new FName("B1.FSM.State.Graph.Join");

		public static readonly FName GraphFinal = new FName("B1.FSM.State.Graph.Final");

		public static readonly FName GraphTerminate = new FName("B1.FSM.State.Graph.Terminate");
	}

	public static class FsmStateTag
	{
		public static readonly FGameplayTag Validation = GameplayTagExtension.MakeGameplayTag(FsmStateTagName.Validation);

		public static readonly FGameplayTag GraphInitial = GameplayTagExtension.MakeGameplayTag(FsmStateTagName.GraphInitial);

		public static readonly FGameplayTag GraphFork = GameplayTagExtension.MakeGameplayTag(FsmStateTagName.GraphFork);

		public static readonly FGameplayTag GraphJoin = GameplayTagExtension.MakeGameplayTag(FsmStateTagName.GraphJoin);

		public static readonly FGameplayTag GraphFinal = GameplayTagExtension.MakeGameplayTag(FsmStateTagName.GraphFinal);

		public static readonly FGameplayTag GraphTerminate = GameplayTagExtension.MakeGameplayTag(FsmStateTagName.GraphTerminate);
	}

	public static class FsmEventTagName_Coop
	{
		public static readonly FName PartnerDead = new FName("B1.FSM.Event.AI.Battle.PartnerDead");
	}

	public static class FsmEventTag_Coop
	{
		public static readonly FGameplayTag PartnerDead = GameplayTagExtension.MakeGameplayTag(FsmEventTagName_Coop.PartnerDead);
	}

	public static class DroppedItemEventTagName
	{
		public static readonly FName State_ItemNotDropped = new FName("B1.SceneObj.DroppedItem.State_ItemNotDropped");

		public static readonly FName State_ItemDropped = new FName("B1.SceneObj.DroppedItem.State_ItemDropped");

		public static readonly FName State_ItemPickedUp = new FName("B1.SceneObj.DroppedItem.State_ItemPickedUp");

		public static readonly FName Event_ItemDropped = new FName("B1.SceneObj.DroppedItem.Event_ItemDropped");

		public static readonly FName Event_ItemPickedUp = new FName("B1.SceneObj.DroppedItem.Event_ItemPickedUp");
	}

	public static class DroppedItemEventTag
	{
		public static readonly FGameplayTag State_ItemNotDropped = GameplayTagExtension.MakeGameplayTag(DroppedItemEventTagName.State_ItemNotDropped);

		public static readonly FGameplayTag State_ItemDropped = GameplayTagExtension.MakeGameplayTag(DroppedItemEventTagName.State_ItemDropped);

		public static readonly FGameplayTag State_ItemPickedUp = GameplayTagExtension.MakeGameplayTag(DroppedItemEventTagName.State_ItemPickedUp);

		public static readonly FGameplayTag Event_ItemDropped = GameplayTagExtension.MakeGameplayTag(DroppedItemEventTagName.Event_ItemDropped);

		public static readonly FGameplayTag Event_ItemPickedUp = GameplayTagExtension.MakeGameplayTag(DroppedItemEventTagName.Event_ItemPickedUp);
	}

	public static class TortoiseEventTagName
	{
		public static readonly FName TortoiseEnterBox0 = new FName("B1.SceneObj.Tortoise.TortoiseEnterBox0");

		public static readonly FName TortoiseEnterBox1 = new FName("B1.SceneObj.Tortoise.TortoiseEnterBox1");

		public static readonly FName TortoiseEnterBox2 = new FName("B1.SceneObj.Tortoise.TortoiseEnterBox2");

		public static readonly FName TortoiseEnterBox3 = new FName("B1.SceneObj.Tortoise.TortoiseEnterBox3");

		public static readonly FName TortoiseEnterBox4 = new FName("B1.SceneObj.Tortoise.TortoiseEnterBox4");

		public static readonly FName TortoiseExitBox0 = new FName("B1.SceneObj.Tortoise.TortoiseExitBox0");

		public static readonly FName TortoiseExitBox1 = new FName("B1.SceneObj.Tortoise.TortoiseExitBox1");

		public static readonly FName TortoiseExitBox2 = new FName("B1.SceneObj.Tortoise.TortoiseExitBox2");

		public static readonly FName TortoiseExitBox3 = new FName("B1.SceneObj.Tortoise.TortoiseExitBox3");

		public static readonly FName TortoiseExitBox4 = new FName("B1.SceneObj.Tortoise.TortoiseExitBox4");

		public static readonly FName State_UnitEnterFight = new FName("B1.SceneObj.Tortoise.State_UnitEnterFight");

		public static readonly FName State_UnitLeaveFight = new FName("B1.SceneObj.Tortoise.State_UnitLeaveFight");

		public static readonly FName Event_UnitEnterFight = new FName("B1.SceneObj.Tortoise.Event_UnitEnterFight");

		public static readonly FName Event_UnitLeaveFight = new FName("B1.SceneObj.Tortoise.Event_UnitLeaveFight");

		public static readonly FName Tortoise_Begin = new FName("B1.SceneObj.Tortoise.Tortoise_Begin");

		public static readonly FName Tortoise_Loop = new FName("B1.SceneObj.Tortoise.Tortoise_Loop");

		public static readonly FName Tortoise_End = new FName("B1.SceneObj.Tortoise.Tortoise_End");
	}

	public static class TortoiseEventTag
	{
		public static readonly FGameplayTag TortoiseEnterBox0 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseEnterBox0);

		public static readonly FGameplayTag TortoiseEnterBox1 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseEnterBox1);

		public static readonly FGameplayTag TortoiseEnterBox2 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseEnterBox2);

		public static readonly FGameplayTag TortoiseEnterBox3 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseEnterBox3);

		public static readonly FGameplayTag TortoiseEnterBox4 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseEnterBox4);

		public static readonly FGameplayTag TortoiseExitBox0 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseExitBox0);

		public static readonly FGameplayTag TortoiseExitBox1 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseExitBox1);

		public static readonly FGameplayTag TortoiseExitBox2 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseExitBox2);

		public static readonly FGameplayTag TortoiseExitBox3 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseExitBox3);

		public static readonly FGameplayTag TortoiseExitBox4 = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.TortoiseExitBox4);

		public static readonly FGameplayTag State_UnitEnterFight = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.State_UnitEnterFight);

		public static readonly FGameplayTag State_UnitLeaveFight = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.State_UnitLeaveFight);

		public static readonly FGameplayTag Event_UnitEnterFight = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.Event_UnitEnterFight);

		public static readonly FGameplayTag Event_UnitLeaveFight = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.Event_UnitLeaveFight);

		public static readonly FGameplayTag Tortoise_Begin = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.Tortoise_Begin);

		public static readonly FGameplayTag Tortoise_Loop = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.Tortoise_Loop);

		public static readonly FGameplayTag Tortoise_End = GameplayTagExtension.MakeGameplayTag(TortoiseEventTagName.Tortoise_End);
	}

	public static class BattlePaceControllerTagName
	{
		public static readonly FName State_Disabled = new FName("B1.CustomObj.BattlePaceController.State_Disabled");

		public static readonly FName State_UnTriggered = new FName("B1.CustomObj.BattlePaceController.State_UnTriggered");

		public static readonly FName State_Triggered = new FName("B1.CustomObj.BattlePaceController.State_Triggered");

		public static readonly FName State_Finished = new FName("B1.CustomObj.BattlePaceController.State_Finished");

		public static readonly FName Event_Enable = new FName("B1.CustomObj.BattlePaceController.Event_Enable");

		public static readonly FName Event_Trigger = new FName("B1.CustomObj.BattlePaceController.Event_Trigger");

		public static readonly FName Event_Reset = new FName("B1.CustomObj.BattlePaceController.Event_Reset");

		public static readonly FName Event_Finish = new FName("B1.CustomObj.BattlePaceController.Event_Finish");

		public static readonly FName Event_TriggerComplete = new FName("B1.CustomObj.BattlePaceController.Event_TriggerComplete");

		public static readonly FName Event_Disable = new FName("B1.CustomObj.BattlePaceController.Event_Disable");
	}

	public static class BattlePaceControllerTag
	{
		public static readonly FGameplayTag State_Disabled = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.State_Disabled);

		public static readonly FGameplayTag State_UnTriggered = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.State_UnTriggered);

		public static readonly FGameplayTag State_Triggered = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.State_Triggered);

		public static readonly FGameplayTag Event_Enable = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.Event_Enable);

		public static readonly FGameplayTag Event_Trigger = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.Event_Trigger);

		public static readonly FGameplayTag Event_Reset = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.Event_Reset);

		public static readonly FGameplayTag Event_Finish = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.Event_Finish);

		public static readonly FGameplayTag Event_TriggerComplete = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.Event_TriggerComplete);

		public static readonly FGameplayTag Event_Disable = GameplayTagExtension.MakeGameplayTag(BattlePaceControllerTagName.Event_Disable);
	}

	public static class CommonProcessTagName
	{
		public static readonly FName State_Idle = new FName("B1.Psm.Common.State_Idle");

		public static readonly FName State_Battle = new FName("B1.Psm.Common.State_Battle");

		public static readonly FName State_BattleEnd = new FName("B1.Psm.Common.State_BattleEnd");

		public static readonly FName State_Story = new FName("B1.Psm.Common.State_Story");

		public static readonly FName SaveArchive = new FName("B1.Psm.Common.State_SaveArchive");

		public static readonly FName State_ReportOSS = new FName("B1.Psm.Common.State_ReportOSS");

		public static readonly FName State_GroupActived = new FName("B1.Psm.Common.State_GroupActived");

		public static readonly FName State_GroupFinished = new FName("B1.Psm.Common.State_GroupFinished");

		public static readonly FName Event_GroupFinish = new FName("B1.Psm.Common.Event_GroupFinish");

		public static readonly FName State_Countdown = new FName("B1.Psm.Common.State_Countdown");
	}

	public static class CommonProcessTag
	{
		public static readonly FGameplayTag State_Idle = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_Idle);

		public static readonly FGameplayTag State_Battle = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_Battle);

		public static readonly FGameplayTag State_BattleEnd = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_BattleEnd);

		public static readonly FGameplayTag State_Story = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_Story);

		public static readonly FGameplayTag State_SaveArchive = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.SaveArchive);

		public static readonly FGameplayTag State_ReportOSS = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_ReportOSS);

		public static readonly FGameplayTag State_GroupActived = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_GroupActived);

		public static readonly FGameplayTag State_GroupFinished = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_GroupFinished);

		public static readonly FGameplayTag Event_GroupFinish = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.Event_GroupFinish);

		public static readonly FGameplayTag State_Countdown = GameplayTagExtension.MakeGameplayTag(CommonProcessTagName.State_Countdown);
	}

	public static class GuideTagName
	{
		public static readonly FName State_Mark = new FName("B1.Guide.Common.State_Mark");

		public static readonly FName State_Listner = new FName("B1.Guide.Common.State_Listener");
	}

	public static class GuideTag
	{
		public static readonly FGameplayTag State_Mark = GameplayTagExtension.MakeGameplayTag(GuideTagName.State_Mark);

		public static readonly FGameplayTag State_Listner = GameplayTagExtension.MakeGameplayTag(GuideTagName.State_Listner);
	}

	public static FCalliopeGraph LoadGraph(string PathName, string AssetName)
	{
		return BGW_CalliopeDataReader.Get().LoadGraphByAssetPath(PathName, AssetName);
	}
}
