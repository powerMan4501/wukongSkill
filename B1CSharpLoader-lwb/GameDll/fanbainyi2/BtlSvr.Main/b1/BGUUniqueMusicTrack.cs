using b1.ECS;
using Diana.Common;
using UnrealEngine.Engine;

namespace b1;

public class BGUUniqueMusicTrack : BGUBgmTrackBase
{
	protected BGMWrap CurrentBGMWrap;

	public BGUUniqueMusicTrack(BGS_GameBgmMgr GameBgmMgr)
		: base(GameBgmMgr)
	{
		CurrentBGMWrap = null;
		IsCanTick = false;
	}

	public override void TryPlayBGM(BGMWrap NewBGMWrap)
	{
		if (CurrentBGMWrap != null)
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GameBgmMgr.GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>播放 BGM: </><effect>" + NewBGMWrap.AkEventBegin.GetName() + "</><action></>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
		}
		PostEventWithWrap(NewBGMWrap.AkEventBegin, NewBGMWrap, 0, null, null);
		CurrentBGMWrap = NewBGMWrap;
	}

	public override void TryStopBGM(Entity RequestorEntity, EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		if (CurrentBGMWrap == null || CurrentBGMWrap.RequestorEntity != RequestorEntity)
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GameBgmMgr.GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>停止播放 BGM，事件: </><effect>" + CurrentBGMWrap.GetStopEvent(StopCondition).GetName() + "</><action></>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
		}
		PostEventWithWrap(CurrentBGMWrap.GetStopEvent(StopCondition), CurrentBGMWrap, 0, null, null);
		CurrentBGMWrap = null;
	}

	public override void OnShutdown()
	{
		if (CurrentBGMWrap != null)
		{
			TryStopBGM(CurrentBGMWrap.RequestorEntity);
		}
	}

	public override void PauseBGM(EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		if (CurrentBGMWrap != null)
		{
			TryStopBGM(CurrentBGMWrap.RequestorEntity, StopCondition);
		}
	}
}
