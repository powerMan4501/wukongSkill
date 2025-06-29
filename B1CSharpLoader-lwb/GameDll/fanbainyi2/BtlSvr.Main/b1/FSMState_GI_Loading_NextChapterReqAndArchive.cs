using CsB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class FSMState_GI_Loading_NextChapterReqAndArchive : FSMState_GI_LoadingBase
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Context.OwnerUObj);
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(firstLocalPlayerController.PlayerState);
		CSMsgChapterEnterNextReq chapterEnterNext = new CSMsgChapterEnterNextReq();
		BPC_PlayerRoleData playerRoleData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(firstLocalPlayerController);
		int CurChapterCache = playerRoleData.RoleData.RoleCs.Chapter.CurChapter;
		bTF_EventCollectionCS.Evt_ChapterEnterNextReq(chapterEnterNext, delegate(MsgErrCode Code, CSMsgChapterEnterNextReq Req, CSMsgChapterEnterNextRes Res)
		{
			if (Code == MsgErrCode.ErrSuccess)
			{
				if (playerRoleData != null)
				{
					playerRoleData.MapId = Context.TargetLevelId;
					BGW_EventCollection.Get(Context.OwnerUObj).Evt_NextChapterTravelBegin(CurChapterCache);
					base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
				}
				return;
			}
			throw new FSMException(this, $"ChapterEnterNextReq Code == {Code}");
		});
	}

	public override int OnTick(float Delta)
	{
		return 100;
	}

	public override void OnExit()
	{
	}
}
