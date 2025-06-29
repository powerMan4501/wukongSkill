using CsB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class TaskNodeInstance_PrologueCompleted : QuestNodeInstance
{
	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerChapterPrologueCompletedEvent();
		TriggerFirstOutput(bFinish: true);
	}

	private void TriggerChapterPrologueCompletedEvent()
	{
		BTF_EventCollectionCS.Get(UGameplayStatics.GetPlayerState(base.Owner, 0)).Evt_ChapterPrologueCompletedReq(new CSMsgChapterPrologueCompletedReq(), delegate(MsgErrCode ErrCode, CSMsgChapterPrologueCompletedReq Req, CSMsgChapterPrologueCompletedRes Res)
		{
			if (ErrCode != MsgErrCode.ErrSuccess)
			{
				BGW_LogUtil.LogError($"Evt_ChapterPrologueCompletedReq Faild MsgErrCode:{ErrCode}");
			}
			PrologueCompletedImpl();
		});
	}

	private void PrologueCompletedImpl()
	{
		BGW_EventCollection.Get(base.Owner).Evt_PostPrologueCompleted();
		APlayerState playerState = UGameplayStatics.GetPlayerState(base.Owner, 0);
		BPS_EventCollectionCS.Get(playerState).Evt_ForceSetRebirthPoint.Invoke(1001);
		BGU_DataUtil.GetReadOnlyData<BPC_TransData>(playerState)?.SetCurActorResId(0);
		BGW_PlayGoMgr bGW_PlayGoMgr = BGW_PlayGoMgr.Get(base.Owner);
		if (bGW_PlayGoMgr.IsDownloadIncomplete())
		{
			bGW_PlayGoMgr.TriggerPrologueCompleted();
			BGW_EventCollection.Get(base.Owner).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.BackToMainMenuByPlayGo);
		}
		else
		{
			BPS_EventCollectionCS.Get(playerState).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.PrologueCompleted, null, EPlayerTeleportReason.PrologueCompleted);
		}
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void RecoverActiveState()
	{
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}
}
