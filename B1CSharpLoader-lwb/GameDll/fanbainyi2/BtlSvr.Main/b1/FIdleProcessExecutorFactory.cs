namespace b1;

public static class FIdleProcessExecutorFactory
{
	public static FIdleProcessExecutorBase CreateInstance(EIdleProcessActionType InInstanceKey)
	{
		return InInstanceKey switch
		{
			EIdleProcessActionType.Teleport => new FIdleProcessExecutor_Teleport(), 
			EIdleProcessActionType.ActiveRebirthPoint => new FIdleProcessExecutor_ActiveRebirthPoint(), 
			EIdleProcessActionType.GameLevelPass => new FIdleProcessExecutor_GameLevelPass(), 
			EIdleProcessActionType.BlockRebirthPoint => new FIdleProcessExecutor_BlockRebirthPoint(), 
			EIdleProcessActionType.DisappearUnit => new FIdleProcessExecutor_DisappearUnit(), 
			EIdleProcessActionType.NotifyDropItemManagerDrop => new FIdleProcessExecutor_NotifyDropItemManagerDrop(), 
			EIdleProcessActionType.AiConversation => new FIdleProcessExecutor_AiConversation(), 
			EIdleProcessActionType.SetNPCParamOnlyInEnter => new FIdleProcessExecutor_SetNPCParamOnlyInEnter(), 
			EIdleProcessActionType.TriggerUnitBattle => new FIdleProcessExecutor_TriggerUnitBattle(), 
			EIdleProcessActionType.SpawnAssociationUnit => new FIdleProcessExecutor_SpawnAssociationUnit(), 
			EIdleProcessActionType.ActiveAssociationUnit => new FIdleProcessExecutor_ActiveAssociationUnit(), 
			EIdleProcessActionType.KillAssociationUnit => new FIdleProcessExecutor_KillAssociationUnit(), 
			EIdleProcessActionType.NpcPlayMontage => new FIdleProcessExecutor_NpcPlayMontage(), 
			EIdleProcessActionType.NpcMoveTo => new FIdleProcessExecutor_NpcMoveTo(), 
			EIdleProcessActionType.EnterWeakPerformState => new FIdleProcessExecutor_EnterWeakPerformState(), 
			EIdleProcessActionType.ExitWeakPerformState => new FIdleProcessExecutor_ExitWeakPerformState(), 
			EIdleProcessActionType.KillFollowPartner => new FIdleProcessExecutor_KillFollowPartner(), 
			EIdleProcessActionType.ClearAllBloodBar => new FIdleProcessExecutor_ClearAllBloodBar(), 
			EIdleProcessActionType.NotifyStateMachine => new FIdleProcessExecutor_NotifyStateMachine(), 
			EIdleProcessActionType.TeleportRebirthPoint => new FIdleProcessExecutor_TeleportRebirthPoint(), 
			EIdleProcessActionType.PlayDefeatUI => new FIdleProcessExecutor_PlayDefeatUI(), 
			EIdleProcessActionType.TriggerSplineMove => new FIdleProcessExecutor_TriggerSplineMove(), 
			_ => null, 
		};
	}
}
