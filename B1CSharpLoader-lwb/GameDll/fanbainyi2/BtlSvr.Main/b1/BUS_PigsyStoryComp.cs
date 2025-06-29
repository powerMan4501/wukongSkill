using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PigsyStoryComp : UActorCompBaseCS
{
	private BUC_PigsyStoryData StoryData;

	private IBUC_BattleStateData BattleStateData;

	private IBGC_PigsyStoryData StoryMgrData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	public override void OnAttach()
	{
		StoryData = RequireWritableData<BUC_PigsyStoryData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		StoryMgrData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_PigsyStoryData, BGC_PigsyStoryData>(Owner);
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		base.BGSEventCollection.Evt_OnCurStoryFinished += new Del_Void(OnCurStoryFinished);
		base.BUSEventCollection.Evt_PlayPigsyStory += new Del_Void(PlayStory);
		base.BUSEventCollection.Evt_OnAiMoveToWaitPoint += new Del_Void(OnAiMoveToInteract);
		base.BUSEventCollection.Evt_OnAiMoveToInteractPoint += new Del_Void(OnAiMoveToInteract);
	}

	public override void OnBeginPlay()
	{
		StoryData.OwnerGUID = BGU_DataUtil.GetActorGuid(Owner);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckListenNextStoryDist();
		CheckPlayerMoveDist();
	}

	private void OnAiMoveToInteract()
	{
		if (StoryMgrData.IsPlayingStory())
		{
			base.BGSEventCollection.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Interrupt, EACInterruptReason.PigsyStory_BajieInteractWait);
		}
	}

	private void PlayStory()
	{
		if (CanPlayStory())
		{
			base.BGSEventCollection?.Evt_PlayPigsyStory.Invoke(StoryData.OwnerGUID);
			if (StoryMgrData.IsSuccess_LastReqPlayStory())
			{
				StoryData.LastPlayerPos = LocalPlayerSharedData.CachedLocalPlayerLocation;
			}
		}
	}

	private bool CanPlayStory()
	{
		if (BattleStateData.IsUnitInBattle())
		{
			return false;
		}
		if (StoryData.PlayerNeedMove)
		{
			return false;
		}
		return true;
	}

	private void OnCurStoryFinished()
	{
		StoryData.PlayerNeedMove = true;
		StoryData.LastPlayerPos_PlayerNeedMove = LocalPlayerSharedData.CachedLocalPlayerLocation;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (base.BGSEventCollection != null)
		{
			base.BGSEventCollection.Evt_OnCurStoryFinished -= new Del_Void(OnCurStoryFinished);
		}
	}

	private void CheckListenNextStoryDist()
	{
		if (StoryData.PlayerNeedMove && BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.PigsyStory_ListenNextStoryDist, out var ConfigInfo))
		{
			float floatValue = ConfigInfo.FloatValue;
			if (FVector.Dist2D(LocalPlayerSharedData.CachedLocalPlayerLocation, StoryData.LastPlayerPos_PlayerNeedMove) > floatValue)
			{
				StoryData.PlayerNeedMove = false;
			}
		}
	}

	private void CheckPlayerMoveDist()
	{
		if ((StoryMgrData.IsPlayingStory() || StoryMgrData.IsPlayingResumeStory()) && BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.PigsyStory_PlayerOverDistInterrupt, out var ConfigInfo))
		{
			float floatValue = ConfigInfo.FloatValue;
			if (FVector.Dist2D(LocalPlayerSharedData.CachedLocalPlayerLocation, StoryData.LastPlayerPos) > floatValue)
			{
				base.BGSEventCollection?.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Interrupt, EACInterruptReason.PigsyStory_PlayerMoveOverDist);
				StoryData.LastPlayerPos = LocalPlayerSharedData.CachedLocalPlayerLocation;
			}
		}
	}
}
