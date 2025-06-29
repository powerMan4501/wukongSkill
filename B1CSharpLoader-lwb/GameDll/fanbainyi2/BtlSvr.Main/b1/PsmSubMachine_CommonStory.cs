using System.Collections.Generic;
using BtlB1;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PsmSubMachine_CommonStory : PsmSubMachine_TemplateBase
{
	private class State_Playing : PsmSubMachineState
	{
		private bool bWaitPlayFinish { get; set; }

		private int SequenceID { get; set; }

		private List<CalliopeCustom_GainItem> GainItems { get; } = new List<CalliopeCustom_GainItem>();

		private bool bChapterEndStory { get; set; }

		private int ChapterID { get; set; }

		private bool bTriggerTransback { get; set; }

		private float WaitTransbackTime { get; set; }

		public override void OnEnterAction()
		{
			if (GetSubMachine<PsmSubMachine_CommonStory>(out var OutSubMachine))
			{
				OutSubMachine.SetObjStateOnBeginning();
				ProcessCustom_Story customData = OutSubMachine.CustomData;
				bWaitPlayFinish = customData.IsWaitPlayFinish;
				SequenceID = base.ParentPsmInstance.ConvertParamID2IntParam(customData.SequenceId);
				GainItems.AddRange(customData.GainItems);
				bChapterEndStory = customData.IsChapterEndStory;
				ChapterID = customData.ChapterId;
				bTriggerTransback = customData.IsTriggerTransback;
				FUStDefeatSlowTimeConfigDesc slowTimeConfigDescBySeqID = BGW_GameDB.GetSlowTimeConfigDescBySeqID(SequenceID);
				if (slowTimeConfigDescBySeqID != null && slowTimeConfigDescBySeqID.TriggerType == EDefeatUITriggerType.Seq)
				{
					bTriggerTransback = false;
				}
				if (B1Global.GIsMovieRendering)
				{
					NotifySelfNext();
				}
				else
				{
					OnPrePlaySequence();
				}
			}
		}

		public override void OnRecoverAction()
		{
			FUStMovieSequenceDesc movieSequenceDesc = BGW_GameDB.GetMovieSequenceDesc(SequenceID);
			if (movieSequenceDesc == null)
			{
				NotifySelfNext();
				return;
			}
			if (movieSequenceDesc.PlayType == EPlayType.Once)
			{
				BGW_EventCollection.Get(base.ParentPsmInstance.Owner)?.Evt_MarkMoviePlayed(SequenceID);
			}
			PlayChapterEndStory();
			NotifySelfNext();
		}

		public override void OnResetAction()
		{
		}

		public override void OnTickAction(float InDeltaTime)
		{
			if (WaitTransbackTime > 0f)
			{
				WaitTransbackTime -= InDeltaTime;
				if (WaitTransbackTime <= 0f)
				{
					WaitTransbackTime = -1f;
					OnFinishTransBack();
				}
			}
		}

		private void OnPrePlaySequence()
		{
			BGW_EventCollection.Get(GetOwner())?.Evt_SetGamePause(EPauseEvent.UIAndBattleInput, bPause: true);
			if (bTriggerTransback)
			{
				APawn playerPawn = UGameplayStatics.GetPlayerPawn(GetOwner(), 0);
				if (playerPawn != null)
				{
					float transBackDurationTime = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerTransData, BUC_PlayerTransData>(playerPawn).TransBackDurationTime;
					if (transBackDurationTime > 0f)
					{
						BUS_EventCollectionCS.Get(playerPawn)?.Evt_TriggerTransBack.Invoke();
						WaitTransbackTime = transBackDurationTime;
						return;
					}
					IBUC_MagicallyChangeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>(playerPawn);
					float vigorSkillReEnterWaitTime = unPersistentReadOnlyData.VigorSkillReEnterWaitTime;
					if (unPersistentReadOnlyData.IsDurMagicallyChange() && vigorSkillReEnterWaitTime > 0f)
					{
						BUS_EventCollectionCS.Get(playerPawn)?.Evt_OnMagicallyChangeRecover.Invoke(0);
						WaitTransbackTime = vigorSkillReEnterWaitTime;
						return;
					}
				}
			}
			OnStartPlaySequence();
		}

		private void OnFinishTransBack()
		{
			OnStartPlaySequence();
		}

		private void OnStartPlaySequence()
		{
			BGW_EventCollection.Get(GetOwner())?.Evt_SetGamePause(EPauseEvent.UIAndBattleInput, bPause: false);
			if (GetSubMachine<PsmSubMachine_CommonStory>(out var OutSubMachine))
			{
				FPlayMovieRequest inRequest = default(FPlayMovieRequest);
				ProcessCustom_Story customData = OutSubMachine.CustomData;
				inRequest.SequenceID = base.ParentPsmInstance.ConvertParamID2IntParam(customData.SequenceId);
				inRequest.bDisablePlayerControl = customData.IsDisablePlayerControl;
				inRequest.bDisableMovementInput = customData.IsDisableMovementInput;
				inRequest.bDisableLookAtInput = customData.IsDisableLookAtInput;
				inRequest.bHidePlayer = customData.IsHidePlayer;
				inRequest.bHideHud = customData.IsHideHud;
				inRequest.OverlapBoxGuid = base.ParentPsmInstance.ConvertParamID2StringParam(customData.MatchOverlapBox);
				inRequest.MatchType = (ESequenceBlendInMatchPositionType)customData.MatchType;
				if (customData.IsWaitPlayFinish)
				{
					inRequest.MovieFinishCallback = OnSequenceFinished;
				}
				else
				{
					inRequest.BeforePlayFinishCallback = OnFinishBeforePlay;
				}
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
				if (bGW_EventCollection != null)
				{
					bGW_EventCollection.Evt_RequestPlayMovie(inRequest);
				}
			}
		}

		private void PlayChapterEndStory()
		{
			if (bChapterEndStory)
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(UGameplayStatics.GetPlayerCharacter(GetOwner(), 0));
				if (bGW_EventCollection != null && GSGameplayCVar.CVar_SkipAllChapterMovie.GetValueInGameThread() == 0)
				{
					bGW_EventCollection.Evt_UIChapterMovie(ChapterID);
				}
			}
		}

		private void OnSequenceFinished()
		{
			PlayChapterEndStory();
			NotifySelfNext();
		}

		private void OnFinishBeforePlay()
		{
			if (!bWaitPlayFinish)
			{
				NotifySelfNext();
			}
		}

		private void NotifySelfNext()
		{
			NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
		}
	}

	public override string NodeClass => B1CalliopeDef.ProcessMachineNode.Story;

	protected override string DefaultTerminatePinName => BGW_FlowUtils.PinName.Out.PlainName;

	private ProcessCustom_Story CustomData { get; set; }

	private int LockArchiveID { get; set; }

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		CustomData = new ProcessCustom_Story();
		CustomData.MergeFrom(CustomDataBytes);
		LockArchiveID = -1;
		base.ManagedSceneObjs.AddRange(CustomData.ManagedObjs);
		base.ManagedNpcUnits.AddRange(CustomData.ManagedNpcUnits);
		base.ManagedInteractors.AddRange(CustomData.ManagedInteractors);
		base.ManagedStreamingLevelStateConfigs.AddRange(CustomData.ManagedStreamingLevelStateConfigs);
		base.ManagedGroupUnits.AddRange(CustomData.ManagedGroupUnits);
		FGameplayTag state_Story = BGW_FlowUtils.CommonProcessTag.State_Story;
		RegisterStateWithClass(state_Story, typeof(State_Playing));
		RegisterInitialTransition(state_Story);
		RegisterFinalTransition(state_Story, BGW_FlowUtils.SceneObjCommonEventTag.Next);
	}

	public override bool CheckNodeQueryable(out string ErrorMassager)
	{
		if (BGW_GameDB.GetMovieSequenceDesc(base.ParentPsmInstance.ConvertParamID2IntParam(CustomData.SequenceId)) == null)
		{
			ErrorMassager = "不存在的SequenceID";
			return false;
		}
		ErrorMassager = "";
		return true;
	}

	public override void Start()
	{
		if (B1Global.GIsBossRushMode)
		{
			base.BGWEventCollection.Evt_BossRushBattleTimeSetPaused(P1: true);
		}
		SetArchiveLock(bLock: true);
		base.Start();
	}

	public override void Shutdown()
	{
		base.Shutdown();
		SetArchiveLock(bLock: false);
		if (B1Global.GIsBossRushMode)
		{
			base.BGWEventCollection.Evt_BossRushBattleTimeSetPaused(P1: false);
		}
	}

	public void SetArchiveLock(bool bLock)
	{
		if (LockArchiveID >= 0)
		{
			if (!bLock)
			{
				BGW_GameArchiveMgr.Get(GetOwner()).ReleaseSaveLock(LockArchiveID);
				LockArchiveID = -1;
			}
		}
		else if (bLock)
		{
			LockArchiveID = BGW_GameArchiveMgr.Get(GetOwner()).LockSaveArchive(EArchiveDelaySaveSource.SequencePlaying, $"Sequence ID : {base.ParentPsmInstance.ConvertParamID2IntParam(CustomData.SequenceId)}");
		}
	}
}
