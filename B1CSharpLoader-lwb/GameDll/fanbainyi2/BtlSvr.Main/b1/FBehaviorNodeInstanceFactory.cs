namespace b1;

public static class FBehaviorNodeInstanceFactory
{
	public static FBehaviorNodeInstanceBase CreateInstance(string InInstanceKey)
	{
		return InInstanceKey switch
		{
			"Behavior.DetectEnvironment" => new FBehaviorLeftNodeInstance_DetectEnvironment(), 
			"Behavior.DetectExclusiveItemState" => new FBehaviorLeftNodeInstance_DetectExclusiveItemState(), 
			"Behavior.DetectForce" => new FBehaviorLeftNodeInstance_DetectForce(), 
			"Behavior.DetectUnit" => new FBehaviorLeftNodeInstance_DetectUnit(), 
			"Behavior.LogicalAnd" => new FBehaviorLeftNodeInstance_LogicAnd(), 
			"Behavior.LogicalOr" => new FBehaviorLeftNodeInstance_LogicOr(), 
			"Behavior.AMNotify" => new FBehaviorRightNodeInstance_AmNotify(), 
			"Behavior.BeAttackedNumFromSkill" => new FBehaviorRightNodeInstance_BeAttackedNumFromSkill(), 
			"Behavior.BeAttackedNumFromSkillEffect" => new FBehaviorRightNodeInstance_BeAttackedNumFromSkillEffect(), 
			"Behavior.BeHurt" => new FBehaviorRightNodeInstance_BeHurt(), 
			"Behavior.BeKilled" => new FBehaviorRightNodeInstance_BeKilled(), 
			"Behavior.GameDataCounter" => new FBehaviorRightNodeInstance_Counter(), 
			"Behavior.DetectUnitOnce" => new FBehaviorRightNodeInstance_DetectUnitOnce(), 
			"Behavior.EnterState" => new FBehaviorRightNodeInstance_EnterState(), 
			"Behavior.ExitState" => new FBehaviorRightNodeInstance_ExitState(), 
			"Behavior.OnAllSummonBeKilled" => new FBehaviorRightNodeInstance_OnAllSummonBeKilled(), 
			"Behavior.OnSkillValidAttackFrameEnded" => new FBehaviorRightNodeInstance_OnSkillValidAttackFrameEnded(), 
			"Behavior.OnTrigerFSMEvent" => new FBehaviorRightNodeInstance_TriggerFSMEvent(), 
			"Behavior.OnUnitTrans" => new FBehaviorRightNodeInstance_OnUnitTrans(), 
			"Behavior.TriggerAttackStiff" => new FBehaviorRightNodeInstance_TriggerAttackStiff(), 
			"Behavior.TriggerAttackStiff_ListenAttacker" => new FBehaviorRightNodeInstance_TriggerAttackStiff_ListenAttacker(), 
			"Behavior.AddBuff" => new FBehaviorRightNodeInstance_AddBuff(), 
			"Behavior.AiConversation" => new FBehaviorRightNodeInstance_AiConversation(), 
			"Behavior.CastSkill" => new FBehaviorRightNodeInstance_CastSkill(), 
			"Behavior.CastSkillByScore" => new BehaviorRightNodeInstance_CastSkillByScore(), 
			"Behavior.CheckCurrentCastSkillId" => new FBehaviorRightNodeInstance_CheckCurrentCastSkillId(), 
			"Behavior.Combo" => new FBehaviorRightNodeInstance_Combo(), 
			"Behavior.ControlChildActor" => new FBehaviorRightNodeInstance_ControlChildActor(), 
			"Behavior.ExitPhasePerformance" => new FBehaviorRightNodeInstance_ExitPhasePerformance(), 
			"Behavior.GenAndCachePointSet" => new FBehaviorRightNodeInstance_GenAndCachePointSet(), 
			"Behavior.HandleBattleMessage" => new FBehaviorRightNodeInstance_HandleBattleMessage(), 
			"Behavior.Log" => new BehaviorRightNodeInstance_Log(), 
			"Behavior.MulticastCachedPointSet" => new FBehaviorRightNodeInstance_MulticastCachedPointSet(), 
			"Behavior.NotifyExclusiveItem" => new FBehaviorRightNodeInstance_NotifyExclusiveItem(), 
			"Behavior.PlayLevelSeq" => new FBehaviorRightNodeInstance_PlayLevelSeq(), 
			"Behavior.Random" => new FBehaviorRightNodeInstance_Random(), 
			"Behavior.RemoveBuff" => new FBehaviorRightNodeInstance_RemoveBuff(), 
			"Behavior.Sequence" => new FBehaviorRightNodeInstance_Sequence(), 
			"Behavior.SimpleState" => new FBehaviorRightNodeInstance_SimpleState(), 
			"Behavior.TriggerSkillEffect" => new FBehaviorRightNodeInstance_TriggerSkillEffect(), 
			"Behavior.UnitStateTrigger" => new FBehaviorRightNodeInstance_UnitStateTrigger(), 
			"Behavior.WeightRandom" => new FBehaviorRightNodeInstance_WeightRandom(), 
			"Behavior.PlayPigsyStory" => new FBehaviorRightNodeInstance_PlayPigsyStory(), 
			"Dialogue.OnPlayerApproached" => new DialogueNodeInstance_OnPlayerApproached(), 
			_ => null, 
		};
	}
}
