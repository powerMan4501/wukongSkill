using System;
using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_GameBgmMgr : GameStateSystemBase
{
	private BGC_GameBgmMgrData GameBgmMgrData;

	private BGC_DynamicGameObjectData DynamicGameObjectData;

	public IBGC_UnrealGameplayData UnrealGameplayData;

	private IBIC_LevelData LevelData { get; set; }

	public override void OnAttach()
	{
		GameBgmMgrData = RequireWritableData<BGC_GameBgmMgrData>();
		DynamicGameObjectData = RequireWritableData<BGC_DynamicGameObjectData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		LevelData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Owner);
		GameBgmMgrData.HasInit = true;
		GameBgmMgrData.WanderVolumeInfoStack = new List<BGMVolumeInfo>();
		GameBgmMgrData.WanderVolumeStack = new List<AActor>();
		GameBgmMgrData.VolumeGroupInfo = new Dictionary<FName, BGMVolumeInfo>();
		GameBgmMgrData.BGMTracks = new Dictionary<EBGMTrackType, IBGUBgmTrack>();
		GameBgmMgrData.BGMConfigInfo = new BGWBGMConfigInfo();
		GameBgmMgrData.WanderBgmEntity = ECSUtil.ToEntity(Owner);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_UIShrineMain = (Del_Void_Bool)Delegate.Combine(bGWEventCollection.Evt_UIShrineMain, new Del_Void_Bool(OnUIShrineMainActive));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_UIBgmActived = (Del_Void_IntIntBool)Delegate.Combine(bGWEventCollection2.Evt_UIBgmActived, new Del_Void_IntIntBool(OnUIBgmActived));
		BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
		bGWEventCollection3.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Combine(bGWEventCollection3.Evt_OnCurrentLevelChanged, new Del_Void_Int(CheckCurrentLevelChanged));
		BGW_EventCollection bGWEventCollection4 = base.BGWEventCollection;
		bGWEventCollection4.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection4.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnReset));
		base.BGSEventCollection.Evt_BGS_PlayerEnterBgmVolume += new Del_BGS_PlayerEnterBgmVolume(PlayerEnterBgmVolume);
		base.BGSEventCollection.Evt_BGS_PlayerLeaveBgmVolume += new Del_BGS_PlayerLeaveBgmVolume(PlayerLeaveBgmVolume);
		base.BGSEventCollection.Evt_BGS_BGMVolumeInfoUpdate += new Del_BGS_BGMVolumeInfoUpdate(BGMVolumeInfoUpdate);
		base.BGSEventCollection.Evt_BGS_TryPlayBattleBGM += new Del_BGS_TryPlayBattleBGM(TryPlayBattleBGM);
		base.BGSEventCollection.Evt_BGS_TryStopBattleBGM += new Del_BGS_TryStopBattleBGM(TryStopBattleBGM);
		base.BGSEventCollection.Evt_BGS_SetBattleBgmCanTick += new Del_BGS_SetBattleBgmCanTick(SetBattleBgmCanTick);
		base.BGSEventCollection.Evt_BGS_PauseDefaultBGM += new Del_BGS_PauseDefaultBGM(PauseDefaultBGM);
		base.BGSEventCollection.Evt_BGS_ResumeDefaultBGM += new Del_BGS_ResumeDefaultBGM(ResumeDefaultBGM);
		base.BGSEventCollection.Evt_BGS_TryPlayTransMusic += new Del_BGS_TryPlayTransMusic(TryPlayTransMusic);
		base.BGSEventCollection.Evt_BGS_TryStopTransMusic += new Del_BGS_TryStopTransMusic(TryStopTransMusic);
		GetBgmTrackByType(EBGMTrackType.Default);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_UIShrineMain = (Del_Void_Bool)Delegate.Remove(bGWEventCollection.Evt_UIShrineMain, new Del_Void_Bool(OnUIShrineMainActive));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_UIBgmActived = (Del_Void_IntIntBool)Delegate.Remove(bGWEventCollection2.Evt_UIBgmActived, new Del_Void_IntIntBool(OnUIBgmActived));
		BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
		bGWEventCollection3.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Remove(bGWEventCollection3.Evt_OnCurrentLevelChanged, new Del_Void_Int(CheckCurrentLevelChanged));
		BGW_EventCollection bGWEventCollection4 = base.BGWEventCollection;
		bGWEventCollection4.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGWEventCollection4.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnReset));
		base.BGSEventCollection.Evt_BGS_PlayerEnterBgmVolume -= new Del_BGS_PlayerEnterBgmVolume(PlayerEnterBgmVolume);
		base.BGSEventCollection.Evt_BGS_PlayerLeaveBgmVolume -= new Del_BGS_PlayerLeaveBgmVolume(PlayerLeaveBgmVolume);
		base.BGSEventCollection.Evt_BGS_BGMVolumeInfoUpdate -= new Del_BGS_BGMVolumeInfoUpdate(BGMVolumeInfoUpdate);
		base.BGSEventCollection.Evt_BGS_TryPlayBattleBGM -= new Del_BGS_TryPlayBattleBGM(TryPlayBattleBGM);
		base.BGSEventCollection.Evt_BGS_TryStopBattleBGM -= new Del_BGS_TryStopBattleBGM(TryStopBattleBGM);
		base.BGSEventCollection.Evt_BGS_SetBattleBgmCanTick -= new Del_BGS_SetBattleBgmCanTick(SetBattleBgmCanTick);
		base.BGSEventCollection.Evt_BGS_PauseDefaultBGM -= new Del_BGS_PauseDefaultBGM(PauseDefaultBGM);
		base.BGSEventCollection.Evt_BGS_ResumeDefaultBGM -= new Del_BGS_ResumeDefaultBGM(ResumeDefaultBGM);
		base.BGSEventCollection.Evt_BGS_TryPlayTransMusic -= new Del_BGS_TryPlayTransMusic(TryPlayTransMusic);
		base.BGSEventCollection.Evt_BGS_TryStopTransMusic -= new Del_BGS_TryStopTransMusic(TryStopTransMusic);
		foreach (IBGUBgmTrack value in GameBgmMgrData.BGMTracks.Values)
		{
			value.OnShutdown();
		}
		GameBgmMgrData.WanderVolumeInfoStack.Clear();
		GameBgmMgrData.WanderVolumeStack.Clear();
		GameBgmMgrData.WanderVolumeInfoStack = null;
		GameBgmMgrData.WanderVolumeStack = null;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (LevelData != null)
		{
			CheckCurrentLevelChanged(LevelData.CurrentLevelID);
		}
		else
		{
			CheckCurrentLevelChanged(-1);
			LevelData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Owner);
		}
		foreach (IBGUBgmTrack value in GameBgmMgrData.BGMTracks.Values)
		{
			value.Tick(DeltaTime);
		}
	}

	private void OnReset(EResetActorReason ResetReason)
	{
		Dictionary<FName, BGMVolumeInfo> volumeGroupInfo = GameBgmMgrData.VolumeGroupInfo;
		List<BGMVolumeInfo> wanderVolumeInfoStack = GameBgmMgrData.WanderVolumeInfoStack;
		volumeGroupInfo.Clear();
		foreach (BGMVolumeInfo item in wanderVolumeInfoStack)
		{
			if (!(item.VolumeGroupInfo.VolumeGroupName != FName.None))
			{
				continue;
			}
			if (volumeGroupInfo.TryGetValue(item.VolumeGroupInfo.VolumeGroupName, out var value))
			{
				if (item.VolumeGroupInfo.VolumePriority > value.VolumeGroupInfo.VolumePriority)
				{
					volumeGroupInfo[item.VolumeGroupInfo.VolumeGroupName] = item;
				}
			}
			else
			{
				volumeGroupInfo.Add(item.VolumeGroupInfo.VolumeGroupName, item);
			}
		}
		if (wanderVolumeInfoStack.Count > 0 && wanderVolumeInfoStack[0].VolumeGroupInfo.VolumeGroupName != FName.None && wanderVolumeInfoStack[0].VolumeGroupInfo.VolumePriority < volumeGroupInfo[wanderVolumeInfoStack[0].VolumeGroupInfo.VolumeGroupName].VolumeGroupInfo.VolumePriority)
		{
			OnCurrentVolumeGroupPriorInfoUpdate(wanderVolumeInfoStack[0].VolumeGroupInfo.VolumeGroupName);
		}
		foreach (IBGUBgmTrack value2 in GameBgmMgrData.BGMTracks.Values)
		{
			value2.OnReset(ResetReason);
		}
	}

	private void CheckCurrentLevelChanged(int InLevelID)
	{
		if (GameBgmMgrData.CurrentConfigLevelID != InLevelID)
		{
			GameBgmMgrData.CurrentConfigLevelID = InLevelID;
			LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(GameBgmMgrData.CurrentConfigLevelID);
			if (levelDesc != null && !levelDesc.LevelDefaultBgmConfigPath.Equals(string.Empty))
			{
				GameBgmMgrData.LevelBGMConfigDataAsset = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWBGMConfigDataAsset>(levelDesc.LevelDefaultBgmConfigPath, ELoadResourceType.SyncLoadAndCache);
			}
			if (GameBgmMgrData.LevelBGMConfigDataAsset == null)
			{
				GameBgmMgrData.LevelBGMConfigDataAsset = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWBGMConfigDataAsset>("BGWBGMConfigDataAsset'/Game/00Main/DataAsset/DA_BGMConfig.DA_BGMConfig'", ELoadResourceType.SyncLoadAndCache);
			}
			GameBgmMgrData.LevelBGMConfigInfo = ((GameBgmMgrData.LevelBGMConfigDataAsset != null) ? GameBgmMgrData.LevelBGMConfigDataAsset.GetConfigInfo() : new BGWBGMConfigInfo());
			UpdateBGMConfigInfo();
		}
	}

	private void OnCurrentVolumeChanged()
	{
		UpdateBGMConfigInfo();
	}

	private void UpdateBGMConfigInfo()
	{
		GameBgmMgrData.BGMConfigInfo = new BGWBGMConfigInfo(GameBgmMgrData.LevelBGMConfigInfo);
		GameBgmMgrData.BGMConfigInfo.TryCoverByOtherConfig(GetCurrentVolumeConfigInfo());
		(GetBgmTrackByType(EBGMTrackType.Default) as BGUBgmTrackDefault)?.OnBGMConfigChanged();
	}

	private BGMVolumeInfo GetCurrentBgmVolumeInfo()
	{
		if (GameBgmMgrData.WanderVolumeInfoStack.Count == 0)
		{
			return null;
		}
		if (GameBgmMgrData.VolumeGroupInfo.TryGetValue(GameBgmMgrData.WanderVolumeInfoStack[0].VolumeGroupInfo.VolumeGroupName, out var value))
		{
			return value;
		}
		return GameBgmMgrData.WanderVolumeInfoStack[0];
	}

	private BGWBGMConfigInfo GetCurrentVolumeConfigInfo()
	{
		return GetCurrentBgmVolumeInfo()?.BgmConfigInfo;
	}

	private void OnCurrentVolumeGroupPriorInfoUpdate(FName GroupName)
	{
		if (GameBgmMgrData.WanderVolumeInfoStack.Count > 0 && GameBgmMgrData.VolumeGroupInfo.TryGetValue(GroupName, out var value))
		{
			(GetBgmTrackByType(EBGMTrackType.Default) as BGUBgmTrackDefault)?.OnCurrentVolumeGroupPriorInfoUpdate(new BGMWrap(GameBgmMgrData.WanderVolumeInfoStack[0].WanderEventBegin, GameBgmMgrData.WanderVolumeInfoStack[0].WanderEventEnd), new BGMWrap(value.WanderEventBegin, value.WanderEventEnd), value.VolumeGroupInfo.PriorityEvent);
		}
	}

	public void PlayerEnterBgmVolume(AActor WanderVolumeActor, BGMVolumeInfo VolumeInfo)
	{
		if (WanderVolumeActor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("BGW_BattleBGMMgr::PlayerEnterWanderVolume WanderVolumeActor IsNullOrDestroyed");
			return;
		}
		int num = GameBgmMgrData.WanderVolumeStack.FindIndex((AActor r) => r == WanderVolumeActor);
		if (num != -1)
		{
			return;
		}
		num = GameBgmMgrData.WanderVolumeInfoStack.FindIndex((BGMVolumeInfo r) => VolumeInfo.VolumePriority > r.VolumePriority);
		if (num == -1)
		{
			GameBgmMgrData.WanderVolumeStack.Add(WanderVolumeActor);
			GameBgmMgrData.WanderVolumeInfoStack.Add(VolumeInfo);
		}
		else
		{
			GameBgmMgrData.WanderVolumeStack.Insert(num, WanderVolumeActor);
			GameBgmMgrData.WanderVolumeInfoStack.Insert(num, VolumeInfo);
		}
		if (VolumeInfo.VolumeGroupInfo.VolumeGroupName != FName.None)
		{
			if (GameBgmMgrData.VolumeGroupInfo.TryGetValue(VolumeInfo.VolumeGroupInfo.VolumeGroupName, out var value))
			{
				if (VolumeInfo.VolumeGroupInfo.VolumePriority > value.VolumeGroupInfo.VolumePriority)
				{
					GameBgmMgrData.VolumeGroupInfo[VolumeInfo.VolumeGroupInfo.VolumeGroupName] = VolumeInfo;
					if (GameBgmMgrData.WanderVolumeInfoStack[0].VolumeGroupInfo.VolumePriority < VolumeInfo.VolumeGroupInfo.VolumePriority)
					{
						OnCurrentVolumeGroupPriorInfoUpdate(VolumeInfo.VolumeGroupInfo.VolumeGroupName);
					}
				}
			}
			else
			{
				GameBgmMgrData.VolumeGroupInfo.Add(VolumeInfo.VolumeGroupInfo.VolumeGroupName, VolumeInfo);
			}
		}
		if (GameBgmMgrData.WanderVolumeStack.Count == 1 || num == 0)
		{
			OnCurrentVolumeChanged();
		}
	}

	public void PlayerLeaveBgmVolume(AActor WanderVolumeActor)
	{
		if (WanderVolumeActor.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("BGW_BattleBGMMgr::PlayerLeaveWanderVolume WanderVolumeActor IsNullOrDestroyed");
			return;
		}
		int num = GameBgmMgrData.WanderVolumeStack.FindIndex((AActor r) => r == WanderVolumeActor);
		if (num >= 0)
		{
			GameBgmMgrData.WanderVolumeStack.RemoveAt(num);
			GameBgmMgrData.WanderVolumeInfoStack.RemoveAt(num);
			if (num == 0)
			{
				OnCurrentVolumeChanged();
			}
		}
	}

	public void BGMVolumeInfoUpdate(AActor WanderVolumeActor, BGMVolumeInfo VolumeInfo)
	{
		int num = GameBgmMgrData.WanderVolumeStack.FindIndex((AActor r) => r == WanderVolumeActor);
		if (num != -1)
		{
			GameBgmMgrData.WanderVolumeInfoStack[num] = VolumeInfo;
			if (num == 0)
			{
				OnCurrentVolumeChanged();
			}
		}
	}

	public bool IsBgmTypeDisabled(EBGMPriority BGMPriority)
	{
		return BGMPriority switch
		{
			EBGMPriority.BossBattleBGM => IsBgmTypeDisabled(EBGMDisableType.BossBattleBGM), 
			EBGMPriority.EliteBattleBGM => IsBgmTypeDisabled(EBGMDisableType.EliteBattleBGM), 
			EBGMPriority.MonsterBattleBGM => IsBgmTypeDisabled(EBGMDisableType.MonsterBattleBGM), 
			EBGMPriority.WanderBGM => IsBgmTypeDisabled(EBGMDisableType.WanderBGM), 
			_ => false, 
		};
	}

	public bool IsBgmTypeDisabled(EBGMDisableType DisableType)
	{
		if (GameBgmMgrData.BGMConfigInfo.DisabledBGMTypes == null || !GameBgmMgrData.BGMConfigInfo.DisabledBGMTypes.Contains(DisableType))
		{
			return false;
		}
		return true;
	}

	private IBGUBgmTrack GetBgmTrackByType(EBGMTrackType BgmTrackType)
	{
		IBGUBgmTrack value = null;
		if (!GameBgmMgrData.BGMTracks.TryGetValue(BgmTrackType, out value))
		{
			switch (BgmTrackType)
			{
			case EBGMTrackType.Default:
				GameBgmMgrData.BattleBGMTrack = new BGUBgmTrackDefault(this);
				value = GameBgmMgrData.BattleBGMTrack;
				break;
			case EBGMTrackType.ShrineUI:
				value = new BGUUniqueMusicTrack(this);
				break;
			case EBGMTrackType.RoleMain:
				value = new BGUUniqueMusicTrack(this);
				break;
			case EBGMTrackType.TransMusic:
				value = new BGUTransMusicTrack(this);
				break;
			}
			if (value != null)
			{
				GameBgmMgrData.BGMTracks.Add(BgmTrackType, value);
			}
		}
		return value;
	}

	public int PostStopEvent(UAkAudioEvent AkEvent, BGMWrap Wrap, int CallbackMask, FOnAkPostEventCallback PostEventCallback, List<FAkExternalSourceInfo> ExternalSources, bool bStopWhenAttachedToDestroyed = false, string EventName = null)
	{
		int result = PostEventWithWrap(AkEvent, Wrap, CallbackMask, PostEventCallback, ExternalSources, bStopWhenAttachedToDestroyed, EventName);
		DynamicGameObjectData.ReleaseGameObject(Wrap.GameObjectWrap);
		Wrap.GameObjectWrap = null;
		return result;
	}

	public int PostEventWithWrap(UAkAudioEvent AkEvent, BGMWrap Wrap, int CallbackMask, FOnAkPostEventCallback PostEventCallback, List<FAkExternalSourceInfo> ExternalSources, bool bStopWhenAttachedToDestroyed = false, string EventName = null)
	{
		if (Wrap.GameObjectWrap == null)
		{
			DynamicGameObjectData.GetNewGameObject(Owner, out Wrap.GameObjectWrap);
			if (Wrap.GameObjectWrap != null && !Wrap.GameObjectWrap.GameObject.IsNullOrDestroyed())
			{
				UAkComponent uAkComponent = UGSE_ActorFuncLib.AddComponentByClass(Wrap.GameObjectWrap.GameObject, UClass.GetClass<UAkComponent>(), bManualAttachment: false, FTransform.Identity, bDeferredFinish: false) as UAkComponent;
				if (uAkComponent != null)
				{
					uAkComponent.OcclusionCollisionChannel = (EAkCollisionChannel)27;
				}
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor player = GetPlayer();
			if (player != null)
			{
				BGUFunctionLibraryCS.LogBattleInfo(player, EBattleInfoType.BattleBGM, "<action>Post事件名：</><effect>" + AkEvent?.GetName() + "</><action>，事件GameObject：</><effect>" + Wrap.GameObjectWrap.GameObject?.GetName() + "</>");
			}
		}
		return UAkGameplayStatics.PostEvent(AkEvent, Wrap.GameObjectWrap.GameObject, CallbackMask, PostEventCallback, bStopWhenAttachedToDestroyed, EventName);
	}

	public void TryPlayBattleBGM(BGMWrap NewBGMWrap)
	{
		GetBgmTrackByType(EBGMTrackType.Default)?.TryPlayBGM(NewBGMWrap);
	}

	public void TryStopBattleBGM(Entity RequestorEntity, EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		GetBgmTrackByType(EBGMTrackType.Default)?.TryStopBGM(RequestorEntity, StopCondition);
	}

	public void SetBattleBgmCanTick(bool NewIsCanTick)
	{
		GetBgmTrackByType(EBGMTrackType.Default)?.SetIsCanTick(NewIsCanTick);
	}

	public void PauseDefaultBGM(EBGMStopCondition StopCondition = EBGMStopCondition.Default)
	{
		GetBgmTrackByType(EBGMTrackType.Default)?.PauseBGM(StopCondition);
		GetBgmTrackByType(EBGMTrackType.TransMusic)?.PauseBGM(StopCondition);
	}

	public void ResumeDefaultBGM()
	{
		GetBgmTrackByType(EBGMTrackType.Default)?.ResumeBGM();
		GetBgmTrackByType(EBGMTrackType.TransMusic)?.ResumeBGM();
	}

	private void OnUIBgmActived(int PageID, int BackPageID, bool IsActive)
	{
		switch ((EUIPageID)(byte)PageID)
		{
		default:
			return;
		case EUIPageID.RoleMain:
			if ((byte)BackPageID == 7)
			{
				return;
			}
			break;
		case EUIPageID.Map:
			break;
		}
		OnUIActived((EUIPageID)PageID, IsActive);
	}

	private void OnUIShrineMainActive(bool IsActive)
	{
		OnUIActived(EUIPageID.ShrineMain, IsActive);
	}

	private void OnUIActived(EUIPageID UIPage, bool IsActived)
	{
		if (IsActived)
		{
			TryPlayUIBGM(UIPage);
		}
		else
		{
			TryStopUIBGM(UIPage);
		}
	}

	private void TryPlayUIBGM(EUIPageID UIPage)
	{
		BGMWrap defaultUIBGMWrap = GetDefaultUIBGMWrap(UIPage);
		if (BGMWrap.IsValid(defaultUIBGMWrap))
		{
			EBGMTrackType TrackType = EBGMTrackType.Default;
			if (TryGetBgmTrackTypeUI(UIPage, out TrackType))
			{
				GetBgmTrackByType(TrackType)?.TryPlayBGM(defaultUIBGMWrap);
			}
		}
	}

	private void TryStopUIBGM(EUIPageID UIPage)
	{
		if (BGMWrap.IsValid(GetDefaultUIBGMWrap(UIPage)))
		{
			EBGMTrackType TrackType = EBGMTrackType.Default;
			if (TryGetBgmTrackTypeUI(UIPage, out TrackType))
			{
				GetBgmTrackByType(TrackType)?.TryStopBGM(Entity.Null);
			}
		}
	}

	private bool TryGetBgmTrackTypeUI(EUIPageID UIPage, out EBGMTrackType TrackType)
	{
		TrackType = EBGMTrackType.Default;
		switch (UIPage)
		{
		case EUIPageID.ShrineMain:
			TrackType = EBGMTrackType.ShrineUI;
			break;
		case EUIPageID.RoleMain:
		case EUIPageID.Map:
			TrackType = EBGMTrackType.RoleMain;
			break;
		default:
			return false;
		}
		return true;
	}

	private BGMWrap GetDefaultUIBGMWrap(EUIPageID UIPage)
	{
		if (GameBgmMgrData.BGMConfigInfo == null)
		{
			return null;
		}
		switch (UIPage)
		{
		case EUIPageID.ShrineMain:
			return new BGMWrap(GameBgmMgrData.BGMConfigInfo.DefaultShrineBGM.AkEventBegin, GameBgmMgrData.BGMConfigInfo.DefaultShrineBGM.AkEventStop);
		case EUIPageID.RoleMain:
		case EUIPageID.Map:
			return new BGMWrap(GameBgmMgrData.BGMConfigInfo.DefaultRoleBGM.AkEventBegin, GameBgmMgrData.BGMConfigInfo.DefaultRoleBGM.AkEventStop);
		default:
			return null;
		}
	}

	public void TryPlayTransMusic(BGMWrap NewBGMWrap)
	{
		if (BGMWrap.IsValid(NewBGMWrap) && !IsBgmTypeDisabled(EBGMDisableType.TransMusic))
		{
			GetBgmTrackByType(EBGMTrackType.TransMusic)?.TryPlayBGM(NewBGMWrap);
		}
	}

	public void TryStopTransMusic(Entity Requestor)
	{
		GetBgmTrackByType(EBGMTrackType.TransMusic)?.TryStopBGM(Requestor);
	}

	public AActor GetPlayer()
	{
		if (UnrealGameplayData == null)
		{
			return UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn();
		}
		return UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn();
	}
}
