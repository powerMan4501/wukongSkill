using System.Collections.Generic;
using System.Text;
using b1.ECS;
using b1.Plugins.AkAudio;
using Diana.Common;
using UnrealEngine.Engine;

namespace b1;

public class BGUBgmTrackDefault : BGUBgmTrackBase
{
	private IBGC_GameBgmMgrData GameBgmMgrData;

	private BGMWrap CurrentPlayingWrap;

	private bool IsPendingStop;

	private float PendingStopTimer;

	private EBGMStopCondition PendingStopCondition;

	private List<BGMWrap> RequestedWrapPriorityQueue;

	private float PendingBeginTimer;

	public BGUBgmTrackDefault(BGS_GameBgmMgr GameBgmMgr)
		: base(GameBgmMgr)
	{
		GameBgmMgrData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_GameBgmMgrData, BGC_GameBgmMgrData>(GameBgmMgr.GetOwner());
		CurrentPlayingWrap = null;
		IsPendingStop = false;
		PendingStopCondition = EBGMStopCondition.Default;
		PendingStopTimer = -1f;
		RequestedWrapPriorityQueue = new List<BGMWrap>();
		PendingBeginTimer = 0.5f;
	}

	private bool TryFindWrapSuitableIdx(BGMWrap Wrap, out int Index)
	{
		Index = -1;
		if (!BGMWrap.IsValid(Wrap))
		{
			return false;
		}
		for (int i = 0; i < RequestedWrapPriorityQueue.Count; i++)
		{
			if ((int)Wrap.BGMPriority < (int)RequestedWrapPriorityQueue[i].BGMPriority)
			{
				Index = i;
				break;
			}
			if (Wrap.IsWrapEventEqual(RequestedWrapPriorityQueue[i]))
			{
				Index = i + 1;
			}
			else if (Index > -1)
			{
				break;
			}
		}
		if (Index < 0)
		{
			Index = RequestedWrapPriorityQueue.Count;
		}
		return true;
	}

	public override void TryPlayBGM(BGMWrap NewBGMWrap)
	{
		AActor player = GameBgmMgr.GetPlayer();
		if (player == null || BGUFunctionLibraryCS.BGUIsUnitDead(player) || !BGMWrap.IsValid(NewBGMWrap) || GameBgmMgr.IsBgmTypeDisabled(NewBGMWrap.BGMPriority))
		{
			return;
		}
		int Index = RequestedWrapPriorityQueue.FindIndex((BGMWrap r) => r.RequestorEntity == NewBGMWrap.RequestorEntity);
		if (DebugConfig.IsOpenBattleInfoTool && (Index < 0 || !RequestedWrapPriorityQueue[Index].IsWrapEventEqual(NewBGMWrap)))
		{
			string text = ((ECSExtension.ToActor(NewBGMWrap.RequestorEntity) == null) ? "" : ("</><effect>(" + ECSExtension.ToActor(NewBGMWrap.RequestorEntity).GetActorLabel() + ")</><action>"));
			BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, $"<action>收到来自Entity：</><effect>{NewBGMWrap.RequestorEntity.GetHashCode()}</><action>{text}的发起音乐请求，优先级为</><effect>{NewBGMWrap.BGMPriority}</><action>，Begin事件为</><effect>{NewBGMWrap.AkEventBegin.GetName()}</><action>，Stop事件为</><effect>{NewBGMWrap.GetStopEvent().GetName()}</><action></>");
			if (Index > -1)
			{
				if (RequestedWrapPriorityQueue[Index].AkEventBegin == NewBGMWrap.AkEventBegin)
				{
					BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>事件队列中已存在相同Entity的请求，合并请求，不触发事件。</>");
					BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				}
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>事件队列中已存在相同Entity的不同请求，移除之前的音乐请求。</>");
			}
		}
		if (Index > -1)
		{
			if (RequestedWrapPriorityQueue[Index].AkEventBegin == NewBGMWrap.AkEventBegin)
			{
				if (!RequestedWrapPriorityQueue[Index].IsWrapEventEqual(NewBGMWrap))
				{
					if (CurrentPlayingWrap == RequestedWrapPriorityQueue[Index])
					{
						CurrentPlayingWrap = NewBGMWrap;
					}
					RequestedWrapPriorityQueue[Index].ShareGameObjectWrap(NewBGMWrap);
					RequestedWrapPriorityQueue[Index] = NewBGMWrap;
				}
				return;
			}
			TryStopBGM(NewBGMWrap.RequestorEntity);
		}
		if (!TryFindWrapSuitableIdx(NewBGMWrap, out Index))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Index == 0)
			{
				if (CurrentPlayingWrap != null)
				{
					if (IsPendingStop && CurrentPlayingWrap.AkEventBegin == NewBGMWrap.AkEventBegin)
					{
						stringBuilder.Append("请求播放的BGM当前优先级最高，但与当前正在结束的BGM事件相同，事件为</><effect>" + NewBGMWrap.AkEventBegin.GetName() + "</><action>，停止结束当前BGM。");
					}
					else
					{
						stringBuilder.Append("请求播放的BGM当前优先级最高，且与当前正在播放BGM不同，发起停止正在播放的BGM请求。");
					}
				}
				stringBuilder.Append("请求播放的BGM当前优先级最高。");
			}
			stringBuilder.Append("将请求加入播放队列。");
			BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, $"<action>{stringBuilder}</>");
			BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
		}
		if (Index == 0 && CurrentPlayingWrap != null)
		{
			if (IsPendingStop && CurrentPlayingWrap.AkEventBegin == NewBGMWrap.AkEventBegin)
			{
				CurrentPlayingWrap.ShareGameObjectWrap(NewBGMWrap);
				CurrentPlayingWrap = NewBGMWrap;
				IsPendingStop = false;
			}
			else
			{
				TryStopBGM(CurrentPlayingWrap.RequestorEntity);
			}
		}
		RequestedWrapPriorityQueue.Insert(Index, NewBGMWrap);
	}

	public bool TryGetCurrentEntityBattleBgmWrap(Entity entity, out BGMWrap BgmWrap)
	{
		BgmWrap = RequestedWrapPriorityQueue.Find((BGMWrap r) => r.RequestorEntity == entity);
		return BgmWrap != null;
	}

	public override void TryStopBGM(Entity RequestorEntity, EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		int num = RequestedWrapPriorityQueue.FindIndex((BGMWrap r) => r.RequestorEntity == RequestorEntity);
		if (num < 0)
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GameBgmMgr.GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				string text = ((ECSExtension.ToActor(RequestorEntity) == null) ? "" : ("</><effect>(" + ECSExtension.ToActor(RequestorEntity).GetActorLabel() + ")</><action>"));
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, $"<action>收到来自Entity：</><effect>{RequestorEntity.GetHashCode()}</><action>{text}的停止音乐请求，优先级为</><effect>{RequestedWrapPriorityQueue[num].BGMPriority}</><action>，Begin事件为</><effect>{RequestedWrapPriorityQueue[num].AkEventBegin.GetName()}</><action>，Stop事件为</><effect>{RequestedWrapPriorityQueue[num].GetStopEvent().GetName()}</><action></>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, $"<action></><effect>{RequestorEntity.GetHashCode()}</><action>所有音乐被移出播放队列。</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
		}
		if (CurrentPlayingWrap == RequestedWrapPriorityQueue[num] && !IsPendingStop)
		{
			IsPendingStop = true;
			PendingStopTimer = 1f;
			PendingStopCondition = StopCondition;
		}
		RequestedWrapPriorityQueue.RemoveAt(num);
	}

	public override void OnShutdown()
	{
		if (CurrentPlayingWrap != null)
		{
			TryStopBGM(CurrentPlayingWrap.RequestorEntity);
		}
		RequestedWrapPriorityQueue.Clear();
	}

	private void OnPlayerDead()
	{
		if (CurrentPlayingWrap != null)
		{
			TryStopBGM(CurrentPlayingWrap.RequestorEntity, EBGMStopCondition.PlayerDead);
		}
		RequestedWrapPriorityQueue.Clear();
	}

	protected override void OnTick(float DeltaTime)
	{
		if (B1Global.GIsBossRushMode)
		{
			float globalTimeDilation = UGameplayStatics.GetGlobalTimeDilation(GetOwner());
			if (globalTimeDilation > 0f)
			{
				DeltaTime /= globalTimeDilation;
			}
		}
		if (IsPendingStop)
		{
			if (RequestedWrapPriorityQueue.Count > 0 && RequestedWrapPriorityQueue[0].AkEventBegin == CurrentPlayingWrap.AkEventBegin)
			{
				CurrentPlayingWrap.ShareGameObjectWrap(RequestedWrapPriorityQueue[0]);
				CurrentPlayingWrap = RequestedWrapPriorityQueue[0];
				IsPendingStop = false;
			}
			else
			{
				PendingStopTimer -= DeltaTime;
				if (PendingStopTimer < 0f)
				{
					PostStopEvent(CurrentPlayingWrap.GetStopEvent(PendingStopCondition), CurrentPlayingWrap, 0, null, null);
					CurrentPlayingWrap = null;
					IsPendingStop = false;
				}
			}
		}
		AActor player = GameBgmMgr.GetPlayer();
		if (BGUFunctionLibraryCS.BGUIsUnitDead(player) && CurrentPlayingWrap != null && !IsPendingStop)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>玩家死亡，清除所有BGM。</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
			OnPlayerDead();
		}
		else
		{
			if (CurrentPlayingWrap != null)
			{
				return;
			}
			PendingBeginTimer -= DeltaTime;
			if (PendingBeginTimer < 0f)
			{
				if (RequestedWrapPriorityQueue.Count > 0)
				{
					PlayWrap(RequestedWrapPriorityQueue[0]);
				}
				else
				{
					TryPlayBGM(GameBgmMgrData.GetCurrentWanderBGM());
				}
				PendingBeginTimer = 0.5f;
			}
		}
	}

	private void PlayWrap(BGMWrap Wrap)
	{
		Wrap.PlayingID = PostEventWithWrap(Wrap.AkEventBegin, Wrap, 0, null, null);
		CurrentPlayingWrap = Wrap;
	}

	public override void PauseBGM(EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GameBgmMgr.GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>暂停战斗探索BGM。</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
		}
		SetIsCanTick(NewIsCanTick: false);
		if (CurrentPlayingWrap != null && GameBgmMgrData.BGMConfigInfo != null)
		{
			if (GameBgmMgrData.BGMConfigInfo.DefaultSequenceStopBGMEvent != null)
			{
				PostEventWithWrap(GameBgmMgrData.BGMConfigInfo.DefaultSequenceStopBGMEvent, CurrentPlayingWrap, 0, null, null);
			}
			else
			{
				PostEventWithWrap(CurrentPlayingWrap.GetStopEvent(StopCondition), CurrentPlayingWrap, 0, null, null);
			}
			CurrentPlayingWrap = null;
			IsPendingStop = false;
		}
	}

	public override void ResumeBGM()
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GameBgmMgr.GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>恢复战斗探索BGM。</>");
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>=============================================分割线=============================================</>");
			}
		}
		SetIsCanTick(NewIsCanTick: true);
	}

	public void CheckRequestedWrapsFromDefaultNeedStop()
	{
		List<Entity> list = new List<Entity>();
		foreach (BGMWrap item in RequestedWrapPriorityQueue)
		{
			if (!item.IsWrapFromDefaultConfig)
			{
				continue;
			}
			switch (item.BGMPriority)
			{
			case EBGMPriority.BossBattleBGM:
				foreach (BGWSingleBattleBGMConfigInfo defaultBossBattleBGM in GameBgmMgrData.BGMConfigInfo.DefaultBossBattleBGMList)
				{
					if (item.AkEventBegin == defaultBossBattleBGM.AkEventBegin)
					{
						BGMWrap bGMWrap4 = defaultBossBattleBGM.ToBGMWrap();
						if (!bGMWrap4.IsWrapEventEqual(item))
						{
							item.SetEventsFromWrap(bGMWrap4);
						}
						return;
					}
				}
				break;
			case EBGMPriority.EliteBattleBGM:
				foreach (BGWSingleBattleBGMConfigInfo defaultEliteBattleBGM in GameBgmMgrData.BGMConfigInfo.DefaultEliteBattleBGMList)
				{
					if (item.AkEventBegin == defaultEliteBattleBGM.AkEventBegin)
					{
						BGMWrap bGMWrap3 = defaultEliteBattleBGM.ToBGMWrap();
						if (!bGMWrap3.IsWrapEventEqual(item))
						{
							item.SetEventsFromWrap(bGMWrap3);
						}
						return;
					}
				}
				break;
			case EBGMPriority.MonsterBattleBGM:
				foreach (BGWSingleBattleBGMConfigInfo defaultMonsterBattleBGM in GameBgmMgrData.BGMConfigInfo.DefaultMonsterBattleBGMList)
				{
					if (item.AkEventBegin == defaultMonsterBattleBGM.AkEventBegin)
					{
						BGMWrap bGMWrap2 = defaultMonsterBattleBGM.ToBGMWrap();
						if (!bGMWrap2.IsWrapEventEqual(item))
						{
							item.SetEventsFromWrap(bGMWrap2);
						}
						return;
					}
				}
				break;
			case EBGMPriority.WanderBGM:
				foreach (BGWSingleBGMConfigInfo defaultWanderBGM in GameBgmMgrData.BGMConfigInfo.DefaultWanderBGMList)
				{
					if (item.AkEventBegin == defaultWanderBGM.AkEventBegin)
					{
						BGMWrap bGMWrap = defaultWanderBGM.ToBGMWrap();
						if (!bGMWrap.IsWrapEventEqual(item))
						{
							item.SetEventsFromWrap(bGMWrap);
						}
						return;
					}
				}
				break;
			}
			list.Add(item.RequestorEntity);
		}
		foreach (Entity item2 in list)
		{
			TryStopBGM(item2);
		}
	}

	public void OnBGMConfigChanged()
	{
		if (GameBgmMgrData.BGMConfigInfo != null && GameBgmMgrData.BGMConfigInfo.DisabledBGMTypes.Count > 0)
		{
			for (int num = RequestedWrapPriorityQueue.Count - 1; num >= 0; num--)
			{
				if (GameBgmMgr.IsBgmTypeDisabled(RequestedWrapPriorityQueue[num].BGMPriority))
				{
					TryStopBGM(RequestedWrapPriorityQueue[num].RequestorEntity);
				}
			}
		}
		CheckRequestedWrapsFromDefaultNeedStop();
	}

	public void OnCurrentVolumeGroupPriorInfoUpdate(BGMWrap CurrentVolumeWrap, BGMWrap GroupPriorWrap, UAkAudioEvent PriorityEvent)
	{
		if (CurrentVolumeWrap != null && GroupPriorWrap != null && CurrentVolumeWrap.IsWrapEventEqual(CurrentPlayingWrap) && CurrentPlayingWrap.IsWrapFromDefaultConfig)
		{
			PostEventWithWrap(PriorityEvent, CurrentPlayingWrap, 0, null, null);
			CurrentPlayingWrap.SetEventsFromWrap(GroupPriorWrap);
		}
	}
}
