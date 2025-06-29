namespace b1;

public static class B1CalliopeDef
{
	public static class QuestNode
	{
		public static readonly string Counter = "Quest.Counter";

		public static readonly string CustomInput = "Quest.CustomInput";

		public static readonly string CustomOutput = "Quest.CustomOutput";

		public static readonly string ExecutionMultiGate = "Quest.ExecutionMultiGate";

		public static readonly string ExecutionSequence = "Quest.ExecutionSequence";

		public static readonly string Finish = "Quest.Finish";

		public static readonly string LevelStream = "Quest.LevelStream";

		public static readonly string Log = "Quest.Log";

		public static readonly string LogicalAnd = "Quest.LogicalAnd";

		public static readonly string LogicalOr = "Quest.LogicalOr";

		public static readonly string NotifyActor = "Quest.NotifyActor";

		public static readonly string ObserveByCondition = "Quest.ObserveByCondition";

		public static readonly string QueryGameState = "Quest.QueryGameState";

		public static readonly string OnNotifyFromActor = "Quest.OnNotifyFromActor";

		public static readonly string Reroute = "Quest.Reroute";

		public static readonly string Start = "Quest.Start";

		public static readonly string SubGraph = "Quest.SubGraph";

		public static readonly string RunProcessGraph = "Quest.RunProcessGraph";

		public static readonly string Timer = "Quest.Timer";

		public static readonly string BlendToCamera = "Quest.BlendToCamera";

		public static readonly string SwitchCameraGroup = "Quest.SwitchCameraGroup";

		public static readonly string PlayLevelSequence = "Quest.PlayLevelSequence";

		public static readonly string GainItem = "Quest.GainItem";

		public static readonly string GainItemPerformance = "Quest.GainItemPerformance";

		public static readonly string Teleport = "Quest.Teleport";

		public static readonly string PostAkEvent = "Quest.PostAkEvent";

		public static readonly string BackToCheckPoint = "Quest.BackToCheckPoint";

		public static readonly string SaveArchive = "Quest.SaveArchive";

		public static readonly string AiConversation = "Quest.AiConversation";

		public static readonly string PlayAnimMontage = "Quest.PlayAnimMontage";

		public static readonly string AddBuff = "Quest.AddBuff";

		public static readonly string GamePass = "Quest.GamePass";

		public static readonly string SetCameraTransform = "Quest.SetCameraTransform";

		public static readonly string SetPlayerRebirthPoint = "Quest.SetPlayerRebirthPoint";

		public static readonly string ObserveOnlineCondition = "Quest.ObserveOnlineCondition";

		public static readonly string TriggerOlineScreenMsg = "Quest.TriggerOlineScreenMsg";

		public static readonly string RemoveBuff = "Quest.ReMoveBuff";

		public static readonly string AwardPrizesRandom = "Quest.AwardPrizesRandom";

		public static readonly string SpawnBossTrace = "Quest.SpawnBossTrace";

		public static readonly string UnitTeleport = "Quest.UnitTeleport";

		public static readonly string RaiseAwardProbability = "Quest.RaiseAwardProbability";

		public static readonly string SetAwardState = "Quest.SetAwardState";

		public static readonly string PlayerLockTrainDummyTarget = "Quest.PlayerLockTrainDummyTarget";

		public static readonly string PlayerCastSkill = "Quest.PlayerCastSkill";

		public static readonly string PlayerCastMagic = "Quest.PlayerCastMagic";

		public static readonly string PlayerUseItem = "Quest.PlayerUseItem";

		public static readonly string PlayerCondition = "Quest.PlayerCondition";

		public static readonly string PlayerMoveToTrainDummyTarget = "Quest.PlayerMoveToTrainDummyTarget";

		public static readonly string TrainDummyResultReport = "Quest.TrainDummyResultReport";

		public static readonly string QuitGame = "Quest.QuitGame";

		public static readonly string ChallengeSuccess = "Quest.ChallengeSuccess";

		public static readonly string SetInteractState = "Quest.SetInteractState";

		public static readonly string StartWaveSpawnByChallenge = "Quest.StartWaveSpawnByChallenge";

		public static readonly string StopWaveSpawnByChallenge = "Quest.StopWaveSpawnByChallenge";

		public static readonly string PlayDBCEfxToInteract = "Quest.PlayDBCEfxToInteract";
	}

	public static class TaskNode
	{
		public static readonly string ObserveRoleData = "Task.ObserveRoleData";

		public static readonly string ObserveUnitByCondition = "Task.ObserveUnitByCondition";

		public static readonly string PushTaskStageState = "Task.PushTaskStageState";

		public static readonly string QueryCompoundCondition = "Task.QueryCompoundCondition";

		public static readonly string ObserveSequence = "Task.ObserveSequence";

		public static readonly string ChapterClear = "Task.ChapterClear";

		public static readonly string ObserveUnitsDeadWithOrder = "Task.ObserveUnitsDeadWithOrder";

		public static readonly string Demo820LevelAward = "Task.Demo820LevelAward";

		public static readonly string Demo820LevelPass = "Task.Demo820LevelPass";

		public static readonly string GameLevelPassFinal = "Task.GameLevelPassFinal";

		public static readonly string PrologueCompleted = "Task.PrologueCompleted";
	}

	public static class ComboNode
	{
		public static readonly string Condition = "Combo.Condition";

		public static readonly string Restart = "Combo.Restart";

		public static readonly string Skill = "Combo.Skill";

		public static readonly string Start = "Combo.Start";

		public static readonly string Idle = "Combo.Idle";

		public static readonly string Reroute = "Combo.Reroute";
	}

	public static class StateNode
	{
		public static readonly string Initial = "State.Initial";

		public static readonly string Single = "State.Single";

		public static readonly string Final = "State.Final";

		public static readonly string Junction = "State.Junction";

		public static readonly string Choice = "State.Choice";

		public static readonly string Fork = "State.Fork";

		public static readonly string Join = "State.Join";

		public static readonly string Terminate = "State.Terminate";

		public static readonly string EntryPoint = "State.EntryPoint";

		public static readonly string ExitPoint = "State.ExitPoint";

		public static readonly string Reroute = "State.Reroute";

		public static readonly string CustomEnter = "State.CustomEnter";

		public static readonly string CustomExit = "State.CustomExit";
	}

	public static class BehaviorNode
	{
		public static readonly string Start = "Behavior.Start";

		public static readonly string Desc = "Behavior.Desc";

		public static readonly string Action = "Behavior.Action";

		public static readonly string DetectUnit = "Behavior.DetectUnit";

		public static readonly string DetectForce = "Behavior.DetectForce";

		public static readonly string DetectEnvironment = "Behavior.DetectEnvironment";

		public static readonly string DetectExclusiveItemState = "Behavior.DetectExclusiveItemState";

		public static readonly string LogicalAnd = "Behavior.LogicalAnd";

		public static readonly string LogicalOr = "Behavior.LogicalOr";

		public static readonly string Sequence = "Behavior.Sequence";

		public static readonly string CastSkill = "Behavior.CastSkill";

		public static readonly string CastSkillByScore = "Behavior.CastSkillByScore";

		public static readonly string AddBuff = "Behavior.AddBuff";

		public static readonly string AddBuffInGroup = "Behavior.AddBuffInGroup";

		public static readonly string RemoveBuff = "Behavior.RemoveBuff";

		public static readonly string CastSkillInGroup = "Behavior.CastSkillInGroup";

		public static readonly string SimpleState = "Behavior.SimpleState";

		public static readonly string UnitStateTrigger = "Behavior.UnitStateTrigger";

		public static readonly string NotifyExclusiveItem = "Behavior.NotifyExclusiveItem";

		public static readonly string GameDataCounter = "Behavior.GameDataCounter";

		public static readonly string EnterState = "Behavior.EnterState";

		public static readonly string ExitState = "Behavior.ExitState";

		public static readonly string OnTrigerFSMEvent = "Behavior.OnTrigerFSMEvent";

		public static readonly string HandleBattleMessage = "Behavior.HandleBattleMessage";

		public static readonly string DetectUnitOnce = "Behavior.DetectUnitOnce";

		public static readonly string GenAndCachePointSet = "Behavior.GenAndCachePointSet";

		public static readonly string MulticastCachedPointSet = "Behavior.MulticastCachedPointSet";

		public static readonly string TriggerSkillEffect = "Behavior.TriggerSkillEffect";

		public static readonly string Random = "Behavior.Random";

		public static readonly string WeightRandom = "Behavior.WeightRandom";

		public static readonly string AiConversation = "Behavior.AiConversation";

		public static readonly string OnAllSummonBeKilled = "Behavior.OnAllSummonBeKilled";

		public static readonly string OnValidAttackStateEnded = "Behavior.OnValidAttackStateEnded";

		public static readonly string TriggerAttackStiff = "Behavior.TriggerAttackStiff";

		public static readonly string OnUnitTrans = "Behavior.OnUnitTrans";

		public static readonly string BeAttackedNumFromSkill = "Behavior.BeAttackedNumFromSkill";

		public static readonly string OnSkillValidAttackFrameEnded = "Behavior.OnSkillValidAttackFrameEnded";

		public static readonly string AMNotify = "Behavior.AMNotify";

		public static readonly string TriggerAttackStiff_ListenAttacker = "Behavior.TriggerAttackStiff_ListenAttacker";

		public static readonly string BeAttackedNumFromSkillEffect = "Behavior.BeAttackedNumFromSkillEffect";

		public static readonly string BeKilled = "Behavior.BeKilled";

		public static readonly string BeHurt = "Behavior.BeHurt";

		public static readonly string CheckCurrentCastSkillId = "Behavior.CheckCurrentCastSkillId";

		public static readonly string SpawnSocketAttachTamer = "Behavior.SpawnSocketAttachTamer";

		public static readonly string ChildActorCastSkill = "Behavior.ChildActorCastSkill";

		public static readonly string ChildActorBuff = "Behavior.ChildActorBuff";

		public static readonly string Combo = "Behavior.Combo";

		public static readonly string ExitPhasePerformance = "Behavior.ExitPhasePerformance";

		public static readonly string PlayLevelSeq = "Behavior.PlayLevelSeq";

		public static readonly string ControlChildActor = "Behavior.ControlChildActor";

		public static readonly string Log = "Behavior.Log";

		public static readonly string PlayPigsyStory = "Behavior.PlayPigsyStory";
	}

	public static class GuideNode
	{
		public static readonly string Initial = "Guide.Initial";

		public static readonly string Mark = "Guide.Mark";

		public static readonly string Wait = "Guide.Wait";

		public static readonly string Listener = "Guide.Listener";

		public static readonly string Reroute = "Guide.Reroute";
	}

	public static class SkillNode
	{
		public static readonly string Start = "Skill.Start";

		public static readonly string Desc = "Skill.Desc";
	}

	public static class DialogueNode
	{
		public static readonly string OnPlayerApproached = "Dialogue.OnPlayerApproached";
	}

	public static class MovieNode
	{
		public static readonly string Start = "Movie.Start";

		public static readonly string Finish = "Movie.Finish";

		public static readonly string BeforePlay = "Movie.BeforePlay";

		public static readonly string PreRoll = "Movie.PreRoll";

		public static readonly string AfterPlay = "Movie.AfterPlay";

		public static readonly string PlayEnd = "Movie.PlayEnd";

		public static readonly string OnSkipping = "Movie.OnSkipping";

		public static readonly string CustomEvent = "Movie.CustomEvent";

		public static readonly string Timer = "Movie.Timer";

		public static readonly string Delay = "Movie.Delay";

		public static readonly string Cut = "Movie.Cut";

		public static readonly string PerformerExitPhasePerformance = "Movie.PerformerExitPhasePerformance";

		public static readonly string PerformerSetTransform = "Movie.PerformerSetTransform";

		public static readonly string PerformerAddBuff = "Movie.PerformerAddBuff";

		public static readonly string PerformerRemoveBuff = "Movie.PerformerRemoveBuff";

		public static readonly string PerformerTriggerSkillEffect = "Movie.PerformerTriggerSkillEffect";

		public static readonly string PerformerCatchTarget = "Movie.PerformerCatchTarget";

		public static readonly string PerformerSetHiddenInGame = "Movie.SetHiddenInGame";

		public static readonly string PerformerStopWaiting = "Movie.StopWaiting";

		public static readonly string PerformerPostEvent = "Movie.PostEvent";

		public static readonly string PlayerBlendPosition = "Movie.PlayerBlendPosition";

		public static readonly string ClearPlayerStates = "Movie.ClearPlayerStates";

		public static readonly string PerformerSyncTransformToRefObj = "Movie.PerformerSyncTransformToRefObj";

		public static readonly string GiveBackControlRight = "Movie.GiveBackControlRight";

		public static readonly string GiveBackControlRightForMonster = "Movie.GiveBackControlRightForMonster";

		public static readonly string WarmingUp = "Movie.WarmingUp";

		public static readonly string PlayerLockTarget = "Movie.PlayerLockTarget";

		public static readonly string LoadOrUnloadStreamingLevel = "Movie.LoadOrUnloadStreamingLevel";

		public static readonly string ShowOrHiddenStreamingLevel = "Movie.ShowOrHiddenStreamingLevel";

		public static readonly string ActivateOrDeactivateStreamingSource = "Movie.ActivateOrDeactivateStreamingSource";

		public static readonly string SetStreamingManagerViewSource = "Movie.SetStreamingManagerViewSource";

		public static readonly string PlayFromMarkedFrame = "Movie.PlayFromMarkedFrame";

		public static readonly string SetStreamingLevelStateInfo = "Movie.SetStreamingLevelStateInfo";

		public static readonly string ConditionQuery = "Movie.ConditionQuery";

		public static readonly string PlayerSetCloudMoveEnabled = "Movie.PlayerSetCloudMoveEnabled";

		public static readonly string Transformation = "Movie.Transformation";
	}

	public static class ProcessMachineNode
	{
		public static readonly string Initial = "Process.Machine.Initial";

		public static readonly string State = "Process.Machine.State";

		public static readonly string NPCState = "Process.Machine.NPCState";

		public static readonly string Final = "Process.Machine.Final";

		public static readonly string Junction = "Process.Machine.Junction";

		public static readonly string Choice = "Process.Machine.Choice";

		public static readonly string Fork = "Process.Machine.Fork";

		public static readonly string Join = "Process.Machine.Join";

		public static readonly string Terminate = "Process.Machine.Terminate";

		public static readonly string EntryPoint = "Process.Machine.EntryPoint";

		public static readonly string ExitPoint = "Process.Machine.ExitPoint";

		public static readonly string Reroute = "Process.Machine.Reroute";

		public static readonly string TestSubMachine = "Process.Machine.TestSubMachine";

		public static readonly string BattlePaceController = "Process.Machine.BattlePaceController";

		public static readonly string GroupStart = "Process.Machine.GroupStart";

		public static readonly string GroupOut = "Process.Machine.GroupOut";

		public static readonly string Template = "Process.Machine.Template";

		public static readonly string Group = "Process.Machine.Group";

		public static readonly string Idle = "Process.Machine.Idle";

		public static readonly string Battle = "Process.Machine.Battle";

		public static readonly string Story = "Process.Machine.Story";

		public static readonly string Counter = "Process.Machine.Counter";

		public static readonly string SaveArchive = "Process.Machine.SaveArchive";

		public static readonly string ReportOSS = "Process.Machine.ReportOSS";

		public static readonly string Parallel = "Process.Machine.Parallel";
	}

	public static class ProcessStateNode
	{
		public const string EnterAction = "Process.State.EnterAction";

		public const string ExitAction = "Process.State.ExitAction";

		public const string ResetAction = "Process.State.ResetAction";

		public const string TickAction = "Process.State.TickAction";

		public const string DetectStart = "Process.State.DetectStart";

		public const string EnableDetect = "Process.State.EnableDetect";

		public const string DisableDetect = "Process.State.DisableDetect";

		public const string ResetDetect = "Process.State.ResetDetect";

		public const string NotifyActor = "Process.State.NotifyActor";

		public const string NPCShow = "Process.State.NPCShow";

		public const string NPCChangeIdleAnim = "Process.State.NPCChangeIdleAnim";

		public const string NPCChangeLeisureAnim = "Process.State.NPCChangeLeisureAnim";

		public const string NotifySelf = "Process.State.NotifySelf";

		public const string ResetActor = "Process.State.ResetActor";

		public const string ActiveUnit = "Process.State.ActiveUnit";

		public const string ObserveActor = "Process.State.ObserveActor";

		public const string ObserveRoleData = "Process.State.ObserveRoleData";

		public const string ObserveSequence = "Process.State.ObserveSequence";

		public const string QueryCompoundCondition = "Process.State.QueryCompoundCondition";

		public const string QueryTaskStage = "Process.State.QueryTaskStage";

		public const string ObserveTaskStage = "Process.State.ObserveTaskStage";

		public const string Reroute = "Process.State.Reroute";

		public const string Timer = "Process.State.Timer";

		public const string Log = "Process.State.Log";

		public const string LogicalAnd = "Process.State.LogicalAnd";

		public const string LogicalOr = "Process.State.LogicalOr";

		public const string ExecutionSequence = "Process.State.ExecutionSequence";

		public const string PlayLevelSequence = "Process.State.PlayLevelSequence";

		public const string CastSkill = "Process.State.CastSkill";

		public const string AddBuff = "Process.State.AddBuff";

		public const string RemoveBuff = "Process.State.RemoveBuff";

		public const string UpdateInteractGroup = "Process.State.UpdateInteractGroup";

		public const string NPCSwitchNoInteraction = "Process.State.NPCSwitchNoInteraction";
	}

	public static class BossRushNode
	{
		public static readonly string Initial = "BossRush.Initial";

		public static readonly string Reroute = "BossRush.Reroute";

		public static readonly string Template = "BossRush.Template";

		public static readonly string Group = "BossRush.Group";

		public static readonly string Idle = "BossRush.Idle";

		public static readonly string Battle = "BossRush.Battle";

		public static readonly string Story = "BossRush.Story";

		public static readonly string GroupStart = "BossRush.GroupStart";

		public static readonly string End = "BossRush.End";

		public static readonly string Wait = "BossRush.Wait";
	}

	public static class Common
	{
		public static readonly string DefaultConditionPinName = "Default";

		public static readonly string DefaultInputPinName = "In";

		public static readonly string DefaultOutputPinName = "Out";
	}
}
