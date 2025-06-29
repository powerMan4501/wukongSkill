namespace b1;

public static class FPsmStateNodeInstanceFactory
{
	public static PsmStateNodeInstance CreateInstance(string InInstanceKey)
	{
		return InInstanceKey switch
		{
			"Process.State.NPCChangeLeisureAnim" => new PsmStateNodeInstance_NPCChangeLeisureAnim(), 
			"Process.State.AddBuff" => new PsmStateNodeInstance_AddBuff(), 
			"Process.State.CastSkill" => new PsmStateNodeInstance_CastSkill(), 
			"Process.State.NPCChangeIdleAnim" => new PsmStateNodeInstance_NPCChangeIdleAnim(), 
			"Process.State.NPCShow" => new PsmStateNodeInstance_NPCShow(), 
			"Process.State.ObserveRoleData" => new PsmStateNodeInstance_ObserveRoleData(), 
			"Process.State.ObserveSequence" => new PsmStateNodeInstance_ObserveSequence(), 
			"Process.State.PlayLevelSequence" => new PsmStateNodeInstance_PlayLevelSequence(), 
			"Process.State.QueryCompoundCondition" => new PsmStateNodeInstance_QueryCompoundCondition(), 
			"Process.State.NPCSwitchNoInteraction" => new PsmStateNodeInstance_NPCSwitchNoInteraction(), 
			"Process.State.UpdateInteractGroup" => new PsmStateNodeInstance_UpdateInteractGroup(), 
			"Process.State.RemoveBuff" => new PsmStateNodeInstance_RemoveBuff(), 
			"Process.State.ActiveUnit" => new PsmStateNodeInstance_ActiveUnit(), 
			"Process.State.DetectStart" => new PsmStateNodeInstance_DetectStart(), 
			"Process.State.DisableDetect" => new PsmStateNodeInstance_DisableDetect(), 
			"Process.State.EnableDetect" => new PsmStateNodeInstance_EnableDetect(), 
			"Process.State.EnterAction" => new PsmStateNodeInstance_EnterAction(), 
			"Process.State.ExecutionSequence" => new PsmStateNodeInstance_ExecutionSequence(), 
			"Process.State.ExitAction" => new PsmStateNodeInstance_ExitAction(), 
			"Process.State.Log" => new PsmStateNodeInstance_Log(), 
			"Process.State.LogicalAnd" => new PsmStateNodeInstance_LogicalAnd(), 
			"Process.State.LogicalOr" => new PsmStateNodeInstance_LogicalOr(), 
			"Process.State.NotifyActor" => new PsmStateNodeInstance_NotifyActor(), 
			"Process.State.NotifySelf" => new PsmStateNodeInstance_NotifySelf(), 
			"Process.State.ObserveActor" => new PsmStateNodeInstance_ObserveActor(), 
			"Process.State.Reroute" => new PsmStateNodeInstance_Reroute(), 
			"Process.State.ResetAction" => new PsmStateNodeInstance_ResetAction(), 
			"Process.State.ResetActor" => new PsmStateNodeInstance_ResetActor(), 
			"Process.State.ResetDetect" => new PsmStateNodeInstance_ResetDetect(), 
			"Process.State.TickAction" => new PsmStateNodeInstance_TickAction(), 
			"Process.State.Timer" => new PsmStateNodeInstance_Timer(), 
			_ => null, 
		};
	}
}
