using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_OnlineChallengeClientSystem : GameStateSystemBase
{
	private BGC_OnlineChallengeData OnlineChallengeData;

	private BGS_GSEventCollection BGSCollection;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		OnlineChallengeData = RequireWritableData<BGC_OnlineChallengeData>();
		UnrealGameplayData = RequireReadOnlyData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		OnlineChallengeData.OnlineChallengeStageDict.BindAnyOneValueChange(OnChallengeStageChange);
		OnlineChallengeData.OnlineChallengeStageDict.BindAdd(OnChallengeStageAdd);
	}

	public void OnChallengeStageChange(int ChallengeId, EChallengeState OldStageId, EChallengeState NewStageId)
	{
		OnlineChallengeStateTrigger(ChallengeId, NewStageId);
	}

	public void OnChallengeStageAdd(int ChallengeId, EChallengeState NewStageId)
	{
		OnlineChallengeStateTrigger(ChallengeId, NewStageId);
	}

	private void OnlineChallengeStateTrigger(int ChallengeId, EChallengeState State)
	{
		FUStChallengeDesc challengeDesc = BGW_GameDB.GetChallengeDesc(ChallengeId);
		if (challengeDesc != null)
		{
			FGameplayTag p = BGW_FlowUtils.CommonTag.ChallengeSuccess;
			switch (State)
			{
			case EChallengeState.Failed:
				p = BGW_FlowUtils.CommonTag.ChallengeFailed;
				break;
			case EChallengeState.Awarded:
				p = BGW_FlowUtils.CommonTag.ChallengeAwarded;
				break;
			case EChallengeState.Success:
				p = BGW_FlowUtils.CommonTag.ChallengeSuccess;
				break;
			case EChallengeState.Begin:
				p = BGW_FlowUtils.CommonTag.ChallengeBegin;
				break;
			}
			base.BGSEventCollection.Evt_BGS_NotifyGraph.Invoke(challengeDesc.InteractGuid, p);
		}
	}
}
