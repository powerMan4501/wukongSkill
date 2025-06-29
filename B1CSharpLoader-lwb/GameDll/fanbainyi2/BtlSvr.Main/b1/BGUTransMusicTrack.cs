using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;

namespace b1;

public class BGUTransMusicTrack : BGUUniqueMusicTrack
{
	private bool IsPlaying;

	private string LastEnemyGuid;

	public BGUTransMusicTrack(BGS_GameBgmMgr GameBgmMgr)
		: base(GameBgmMgr)
	{
		IsPlaying = false;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (CurrentBGMWrap == null)
		{
			IsCanTick = false;
		}
		else if (!UpdateTransMusicCanPlay())
		{
			StopBGMLogic(EBGMStopCondition.LeaveBattle);
		}
	}

	private void PlayBGMLogic(BGUCharacterCS TriggerUnit)
	{
		TriggerUnit.GetActorGuid(out LastEnemyGuid);
		if (IsPlaying)
		{
			return;
		}
		PostEventWithWrap(CurrentBGMWrap.AkEventBegin, CurrentBGMWrap, 0, null, null);
		IsPlaying = true;
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GameBgmMgr.GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>【变身】变身接敌！播放BGM: </><effect>" + CurrentBGMWrap.AkEventBegin.GetName() + "</><action></>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
		}
	}

	private void StopBGMLogic(EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		if (!IsPlaying)
		{
			return;
		}
		LastEnemyGuid = "";
		PostEventWithWrap(CurrentBGMWrap.GetStopEvent(StopCondition), CurrentBGMWrap, 0, null, null);
		IsPlaying = false;
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GameBgmMgr.GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>【变身】" + ((StopCondition == EBGMStopCondition.Default) ? "击杀Boss" : "变身脱战") + "，停止播放变身BGM，事件: </><effect>" + CurrentBGMWrap.GetStopEvent(StopCondition).GetName() + "</><action></>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
		}
	}

	public override void TryPlayBGM(BGMWrap NewBGMWrap)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(GameBgmMgr.GetOwner());
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
		}
		if (CurrentBGMWrap == null)
		{
			CurrentBGMWrap = NewBGMWrap;
			IsCanTick = true;
		}
	}

	public override void TryStopBGM(Entity RequestorEntity, EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(GameBgmMgr.GetOwner());
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
		}
		if (CurrentBGMWrap != null && !(CurrentBGMWrap.RequestorEntity != RequestorEntity))
		{
			StopBGMLogic(EBGMStopCondition.LeaveBattle);
			CurrentBGMWrap = null;
			IsCanTick = false;
		}
	}

	public override void PauseBGM(EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		base.PauseBGM(StopCondition);
		SetIsCanTick(NewIsCanTick: false);
	}

	public override void ResumeBGM()
	{
		base.ResumeBGM();
		SetIsCanTick(NewIsCanTick: true);
	}

	public override void OnShutdown()
	{
		if (CurrentBGMWrap != null)
		{
			TryStopBGM(CurrentBGMWrap.RequestorEntity);
		}
	}

	private void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
	{
		if (CurrentBGMWrap == null)
		{
			IsCanTick = false;
		}
		else if (IsPlaying && !(LastEnemyGuid != InUnitGuid) && !UpdateTransMusicCanPlay())
		{
			StopBGMLogic();
		}
	}

	private bool UpdateTransMusicCanPlay()
	{
		IBUC_BattleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(GameBgmMgr.GetPlayer());
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		foreach (Entity canSetOwnerAsTargetUnit in unPersistentReadOnlyData.CanSetOwnerAsTargetUnitList)
		{
			BGUCharacterCS bGUCharacterCS = ECSExtension.ToActor(canSetOwnerAsTargetUnit) as BGUCharacterCS;
			IBUC_BattleBGMData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BattleBGMData, BUC_BattleBGMData>(bGUCharacterCS);
			if (unPersistentReadOnlyData2 == null)
			{
				continue;
			}
			switch (unPersistentReadOnlyData2.TransMusicConfig)
			{
			case ETransMusicConfig.ByQuality:
			{
				FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(bGUCharacterCS.GetFinalBattleInfoExtendID());
				if (unitBattleInfoExtendDesc != null && (int)unitBattleInfoExtendDesc.QualityType >= 6)
				{
					PlayBGMLogic(bGUCharacterCS);
					return true;
				}
				break;
			}
			case ETransMusicConfig.Enable:
				PlayBGMLogic(bGUCharacterCS);
				return true;
			}
		}
		return false;
	}
}
