using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Localization;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AKMgrComp")]
internal class BUS_AKMgrComp : UActorCompBaseUObj
{
	private IBUC_SimpleStateData UnitSimpleStates;

	private bool HasPlay_LoopEvent;

	private bool bOwnerCanTriggerMotion;

	private BGW_UIMgr UIMgr;

	private BGW_PauseGameMgr PauseMgr;

	private int CurSubtitle_BindPlayingID = -1;

	private List<int> BlackList = new List<int> { 199910006, 199920006, 199930007, 199940001, 199950038 };

	private uint CurSubtitleReqID;

	private static bool OnAkEventCallBack_IsValid;

	private static IntPtr OnAkEventCallBack_FunctionAddress;

	private static int OnAkEventCallBack_ParamsSize;

	private static bool OnAkEventCallBack_CallbackType_IsValid;

	private static int OnAkEventCallBack_CallbackType_Offset;

	private static FFieldAddress OnAkEventCallBack_CallbackType_PropertyAddress;

	private static bool OnAkEventCallBack_CallbackInfo_IsValid;

	private static int OnAkEventCallBack_CallbackInfo_Offset;

	private static bool OnAkCompAutoDestroyed_IsValid;

	private static IntPtr OnAkCompAutoDestroyed_FunctionAddress;

	private static int OnAkCompAutoDestroyed_ParamsSize;

	private static bool OnAkCompAutoDestroyed_AkComp_IsValid;

	private static int OnAkCompAutoDestroyed_AkComp_Offset;

	private BUC_AKMgrData AkMgrData { get; set; }

	public override void OnAttach()
	{
		bOwnerCanTriggerMotion = UBGWFunctionLibraryCS.CanCharacterTriggerMotion(Owner);
		AkMgrData = RequireWritableData<BUC_AKMgrData>();
		UnitSimpleStates = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UIMgr = BGW_UIMgr.Get(this);
		base.BUSEventCollection.Evt_RemoveAkEventCtrl += new Del_Void_BoolInt(RemoveAkEventCtrl);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_PauseOrResumeAK += new Del_Void_Bool(PauseOrResumeAK);
		base.BUSEventCollection.Evt_PostAkEvent_Follow += new Del_PostAkEvent_Follow(PostAkEvent_Follow);
		base.BUSEventCollection.Evt_PostAkEvent_AtLocation += new Del_PostAkEvent_AtLocation(PostAkEvent_AtLocation);
		base.BUSEventCollection.Evt_PostAkEvent_OnAkComp += new Del_PostAkEvent_OnAkComp(PostAkEvent_OnAkComp);
		base.BUSEventCollection.Evt_PostAkEvent_AM += new Del_PostAkEvent_AM(AMPostAkEvent);
		base.BUSEventCollection.Evt_StopAkEvent += new Del_Void_Int(StopAkEvent);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		base.BUSEventCollection.Evt_JumpToNextSubtitleMarkerPos += new Del_JumpToNextSubtitleMarkerPos(JumpToNextSubtitleMarkerPos);
		base.BGSEventCollection.Evt_PostMulticastAkEvent += new Del_Void_AkEvent(PostMulticastAkEvent);
		if (Owner is BGUPerformerActorCS)
		{
			PauseMgr = BGW_PauseGameMgr.Get(this);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		foreach (UAkEventConfig stopWhenDeadAkEvent in AkMgrData.StopWhenDeadAkEvents)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(stopWhenDeadAkEvent.PlayingId, stopWhenDeadAkEvent.FadeOutTimeMs, (int)stopWhenDeadAkEvent.CurveInterpolation);
		}
		foreach (UAkEventConfig key in AkMgrData.StopByTimeAkEvents.Keys)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(key.PlayingId, key.FadeOutTimeMs, (int)key.CurveInterpolation);
		}
		AkMgrData.StopWhenDeadAkEvents.Clear();
		AkMgrData.StopByTimeAkEvents.Clear();
		base.BGSEventCollection.Evt_PostMulticastAkEvent -= new Del_Void_AkEvent(PostMulticastAkEvent);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!HasPlay_LoopEvent)
		{
			DoPlayAudio(AkMgrData.LoopEvent);
			HasPlay_LoopEvent = true;
		}
		PauseOrResumeAkTick();
		DurationTimeAkEventTick(DeltaTime);
	}

	private void PauseOrResumeAkTick()
	{
		if (!(GetOwner() == null) && UnitSimpleStates != null)
		{
			if (!AkMgrData.InAkPause && (UnitSimpleStates.HasSimpleState(EBGUSimpleState.Immobilizing) || UnitSimpleStates.HasSimpleState(EBGUSimpleState.Frozen)))
			{
				PauseOrResumeAK(IsPause: true);
				AkMgrData.InAkPause = true;
			}
			else if (AkMgrData.InAkPause && !UnitSimpleStates.HasSimpleState(EBGUSimpleState.Immobilizing) && !UnitSimpleStates.HasSimpleState(EBGUSimpleState.Frozen))
			{
				PauseOrResumeAK(IsPause: false);
				AkMgrData.InAkPause = false;
			}
		}
	}

	private void AMPostAkEvent(int MontageID, UMeshComponent MeshComp, FName AttachPointName, UAkAudioEvent AkEvent, UAkAudioEvent AkStopEvent, bool Follow, string EventName, bool CanHandleStopRequest, bool bPlaySubtitle = true, string GroupName = "", string SwitchStateName = "")
	{
		int num = -1;
		if (Follow)
		{
			PostAkEvent_Follow(MeshComp, AttachPointName, AkEvent, bPlaySubtitle, bNeedRecordSubtitleStamp: false, GroupName, SwitchStateName);
			num = AkMgrData.LastPlayingID;
		}
		else
		{
			FTransform fTransform = MeshComp.GetWorldTransform();
			if (AttachPointName != FName.None)
			{
				fTransform = MeshComp.GetSocketTransform(AttachPointName);
			}
			PostAkEvent_AtLocation(fTransform.GetLocation(), fTransform.Rotator(), AkEvent);
			num = AkMgrData.LastPlayingID;
		}
		if (num != -1 && CanHandleStopRequest)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = MeshComp as USkeletalMeshComponent;
			if (uSkeletalMeshComponent != null)
			{
				AddAkEventIntoCtrl(uSkeletalMeshComponent, MontageID, num, AkStopEvent);
			}
		}
		AkMgrData.LastPlayingID = num;
	}

	private void PostAkEvent_Follow(USceneComponent SceneComp, FName AttachPointName, UAkAudioEvent AkEvent, bool bPlaySubtitle = false, bool bNeedRecordSubtitleStamp = false, string GroupName = "", string SwitchStateName = "")
	{
		if (PauseMgr != null && PauseMgr.IsBattlePaused)
		{
			return;
		}
		int lastPlayingID = -1;
		AkMgrData.LastPlayingID = lastPlayingID;
		if (UnitSimpleStates != null && UnitSimpleStates.HasSimpleState(EBGUSimpleState.Mute))
		{
			return;
		}
		bool ComponentCreated = false;
		UAkComponent uAkComponent = SceneComp as UAkComponent;
		if (uAkComponent == null)
		{
			uAkComponent = UAkGameplayStatics.GetAkComponent(SceneComp, out ComponentCreated, AttachPointName, FVector.ZeroVector, EAttachLocation.SnapToTarget);
		}
		if (uAkComponent != null)
		{
			AkMgrData.LastFollowAkComp = uAkComponent;
			if (ComponentCreated)
			{
				uAkComponent.OcclusionCollisionChannel = (EAkCollisionChannel)27;
				uAkComponent.SetAutoDestroyCS(_bAutoDestory: true);
				uAkComponent.SetRTPCValue(null, bOwnerCanTriggerMotion ? 1 : 0, 0, B1GlobalFNames.MotionSwitch.ToString());
			}
			PostAkEvent_OnAkComp(uAkComponent, AkEvent, bPlaySubtitle, bNeedRecordSubtitleStamp, GroupName, SwitchStateName, bAkCompIsAutoDestroy: true);
		}
	}

	private void PostAkEvent_OnAkComp(UAkComponent AkComp, UAkAudioEvent AkEvent, bool bPlaySubtitle = false, bool bNeedRecordSubtitleStamp = false, string GroupName = "", string SwitchStateName = "", bool bAkCompIsAutoDestroy = false)
	{
		int lastPlayingID = -1;
		AkMgrData.LastPlayingID = lastPlayingID;
		if ((UnitSimpleStates != null && UnitSimpleStates.HasSimpleState(EBGUSimpleState.Mute)) || AkComp.IsNullOrDestroyed())
		{
			return;
		}
		ECollisionChannel eCollisionChannel = ECollisionChannel.ECC_GameTraceChannel14;
		if (AkComp.GetOcclusionCollisionChannel() != eCollisionChannel)
		{
			AkComp.OcclusionCollisionChannel = (EAkCollisionChannel)eCollisionChannel;
		}
		if (!string.IsNullOrEmpty(GroupName) && !string.IsNullOrEmpty(SwitchStateName))
		{
			AkComp.SetSwitch(null, GroupName, SwitchStateName);
		}
		int num = (bPlaySubtitle ? MakeCallBackMask(bCallBack_Duration: true, bCallBack_End: true, bCallBack_Marker: true) : 0);
		FOnAkPostEventCallback fOnAkPostEventCallback = null;
		if (num != 0)
		{
			fOnAkPostEventCallback = new FOnAkPostEventCallback();
			fOnAkPostEventCallback.Bind(this, new FName("OnAkEventCallBack"));
		}
		lastPlayingID = AkComp.PostAkEvent(AkEvent, num, fOnAkPostEventCallback, "");
		if (lastPlayingID > 0 && num != 0 && bAkCompIsAutoDestroy)
		{
			AkMgrData.AutoDestroyCompMap[AkComp] = lastPlayingID;
			AkComp.OnAkCompAutoDestroyed.Bind(this, B1GlobalFNames.OnAkCompAutoDestroyed);
			if (bNeedRecordSubtitleStamp)
			{
				string eventName = AkEvent.GetFName().ToString();
				InitSubtitleStamp(lastPlayingID, eventName);
			}
		}
		AkMgrData.LastPlayingID = lastPlayingID;
	}

	private void PostAkEvent_AtLocation(FVector WorldPosistion, FRotator WorldRotator, UAkAudioEvent AkEvent)
	{
		int lastPlayingID = -1;
		if (AkEvent != null)
		{
			string eventName = "";
			lastPlayingID = UAkGameplayStatics.PostEventAtLocation(AkEvent, WorldPosistion, WorldRotator, eventName, Owner.World);
		}
		AkMgrData.LastPlayingID = lastPlayingID;
	}

	private void StopAkEvent(int PlayingID)
	{
		UBGUFunctionLibAK.BGUAKStopPlayingID(PlayingID, 500, 4);
	}

	private int MakeCallBackMask(bool bCallBack_Duration, bool bCallBack_End, bool bCallBack_Marker)
	{
		int num = 0;
		if (bCallBack_Duration)
		{
			num += 8;
		}
		if (bCallBack_End)
		{
			num++;
		}
		if (bCallBack_Marker)
		{
			num += 4;
		}
		return num;
	}

	private void PostMulticastAkEvent(UAkAudioEvent AkEvent)
	{
		if (!(AkEvent != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
			if (firstLocalPlayerController != null && firstLocalPlayerController.GetControlledPawn() as BGUCharacterCS == bGUCharacterCS)
			{
				UAkGameplayStatics.PostEvent(AkEvent, Owner as ACharacter, 0, null);
			}
		}
	}

	private void AddAkEventIntoCtrl(USkeletalMeshComponent MeshComp, int MontageID, int PlayingID, UAkAudioEvent AkStopEvent = null)
	{
		if (AkMgrData.AkMap.ContainsKey(MontageID))
		{
			AkUnitInfo item = new AkUnitInfo
			{
				PlayingID = PlayingID,
				StopAkEvent = AkStopEvent
			};
			AkMgrData.AkMap[MontageID].Add(item);
		}
		else
		{
			List<AkUnitInfo> list = new List<AkUnitInfo>();
			list.Add(new AkUnitInfo
			{
				PlayingID = PlayingID,
				StopAkEvent = AkStopEvent
			});
			AkMgrData.AkMap.Add(MontageID, list);
		}
	}

	private void RemoveAkEventCtrl(bool bInterrupted, int MapInstID)
	{
		if (!AkMgrData.AkMap.ContainsKey(MapInstID))
		{
			return;
		}
		if (bInterrupted)
		{
			foreach (AkUnitInfo item in AkMgrData.AkMap[MapInstID])
			{
				if (item.StopAkEvent == null)
				{
					StopAkEvent(item.PlayingID);
				}
				else if (item.AkComp != null)
				{
					item.AkComp.PostAkEvent(item.StopAkEvent, 0, null, "");
				}
			}
		}
		AkMgrData.AkMap.Remove(MapInstID);
	}

	private void PauseOrResumeAK(bool IsPause)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		foreach (UActorComponent item in owner.GetComponentsByClass(UClass.GetClass<UAkComponent>()))
		{
			UAkComponent uAkComponent = item as UAkComponent;
			if (!uAkComponent.IsNullOrDestroyed())
			{
				if (IsPause)
				{
					uAkComponent.PostAkEvent(null, 0, null, "EVT_system_player_dingshenshu_pause");
				}
				else
				{
					uAkComponent.PostAkEvent(null, 0, null, "EVT_system_player_dingshenshu_resume");
				}
			}
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		DoPlayAudio(AkMgrData.DeadEvent);
		foreach (UAkEventConfig stopWhenDeadAkEvent in AkMgrData.StopWhenDeadAkEvents)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(stopWhenDeadAkEvent.PlayingId, stopWhenDeadAkEvent.FadeOutTimeMs, (int)stopWhenDeadAkEvent.CurveInterpolation);
		}
		AkMgrData.StopWhenDeadAkEvents.Clear();
	}

	private void DurationTimeAkEventTick(float InDeltaSeconds)
	{
		if (AkMgrData.StopByTimeAkEvents.Count < 1)
		{
			return;
		}
		AkMgrData.ExpireEvents.Clear();
		foreach (KeyValuePair<UAkEventConfig, float> stopByTimeAkEvent in AkMgrData.StopByTimeAkEvents)
		{
			UAkEventConfig key = stopByTimeAkEvent.Key;
			AkMgrData.StopByTimeAkEvents[key] -= InDeltaSeconds;
			if (stopByTimeAkEvent.Value <= 1E-08f)
			{
				UBGUFunctionLibAK.BGUAKStopPlayingID(key.PlayingId, key.FadeOutTimeMs, (int)key.CurveInterpolation);
				AkMgrData.ExpireEvents.Add(key);
			}
		}
		foreach (UAkEventConfig expireEvent in AkMgrData.ExpireEvents)
		{
			AkMgrData.StopByTimeAkEvents.Remove(expireEvent);
		}
		AkMgrData.StopByTimeAkEvents.Clear();
	}

	private void DoPlayAudio(UAkEventConfig InAkEventConfig)
	{
		if (InAkEventConfig.AkEvent == null || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.Mute))
		{
			return;
		}
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		if (aBGUCharacter == null || aBGUCharacter.Mesh == null)
		{
			return;
		}
		if (InAkEventConfig.bFollowAttachPoint)
		{
			bool ComponentCreated;
			UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(aBGUCharacter.Mesh, out ComponentCreated, InAkEventConfig.AttachPointName, FVector.ZeroVector, EAttachLocation.SnapToTarget);
			if (ComponentCreated)
			{
				akComponent.OcclusionCollisionChannel = (EAkCollisionChannel)27;
				akComponent.SetAutoDestroyCS(_bAutoDestory: true);
			}
			if (akComponent == null)
			{
				return;
			}
			InAkEventConfig.PlayingId = akComponent.PostAkEvent(InAkEventConfig.AkEvent, 0, null, null);
		}
		else
		{
			FTransform socketTransform = aBGUCharacter.Mesh.GetSocketTransform(InAkEventConfig.AttachPointName);
			InAkEventConfig.PlayingId = UAkGameplayStatics.PostEventAtLocation(InAkEventConfig.AkEvent, socketTransform.GetLocation(), socketTransform.GetRotation().Rotator(), null, aBGUCharacter);
		}
		switch (InAkEventConfig.StopMode)
		{
		case EAkEventStopMode.WhenUnitDead:
			AkMgrData.StopWhenDeadAkEvents.Add(InAkEventConfig);
			break;
		case EAkEventStopMode.ByTime:
			AkMgrData.StopByTimeAkEvents.Add(InAkEventConfig, (float)InAkEventConfig.StopTimeMs / 1000f);
			break;
		}
	}

	private void InitSubtitleStamp(int PlayingID, string EventName)
	{
		if (AkMgrData.SubtitleStamp == null || AkMgrData.SubtitleStamp.ContainsKey(PlayingID))
		{
			return;
		}
		List<FUStAkEventMarkerDesc> akEventMarkerDesc = BGW_GameDB.GetAkEventMarkerDesc(EventName);
		if (akEventMarkerDesc == null || akEventMarkerDesc.Count != 1)
		{
			return;
		}
		FUStAkEventMarkerDesc desc = akEventMarkerDesc[0];
		List<float> list = new List<float>();
		List<AKMarkerInfo> akEventCultureMarkers = BGW_GameDB.GetAkEventCultureMarkers(desc, UAkGameplayStatics.GetCurrentAudioCulture());
		if (akEventCultureMarkers != null)
		{
			foreach (AKMarkerInfo item in akEventCultureMarkers)
			{
				if (BGUFuncLibAiConversation.AnalysisStrParam_To_IntStrValue(item.Name, out var _, out var StrValue, '#'))
				{
					StrValue = StringParseHelper.SafeToLower(StrValue);
					if (StrValue == "start")
					{
						list.Add(item.TimeStamp);
					}
				}
			}
		}
		if (list.Count > 0)
		{
			AkMgrData.SubtitleStamp.Add(PlayingID, list);
		}
	}

	private void JumpToNextSubtitleMarkerPos(string InEventName, UAkComponent AkComp, int PlayingID)
	{
		if (AkMgrData.SubtitleStamp.TryGetValue(PlayingID, out var value) && AkMgrData.AudioLength.TryGetValue(PlayingID, out var value2))
		{
			if (value.Count > 0 && value2 > 0f)
			{
				float inPercent = FMath.Clamp(value[0] - 0.1f, 0f, value[0]) / value2;
				UBGUFunctionLibAK.SeekOnEvent(InEventName, AkComp, inPercent, bInSeekToNearestMarker: false, PlayingID);
			}
			else
			{
				UBGUFunctionLibAK.BGUAKStopPlayingID(PlayingID, 200, 4);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_AKMgrComp:OnAkEventCallBack")]
	private void OnAkEventCallBack(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
	{
		int num = -1;
		UAkEventCallbackInfo uAkEventCallbackInfo = CallbackInfo as UAkEventCallbackInfo;
		if (uAkEventCallbackInfo != null)
		{
			num = uAkEventCallbackInfo.PlayingID;
		}
		if (num >= 0)
		{
			switch (CallbackType)
			{
			case EAkCallbackType.Duration:
				OnAkEventCallBack_Duration(CallbackType, CallbackInfo, num);
				break;
			case EAkCallbackType.EndOfEvent:
				OnAkEventCallBack_Ended(CallbackType, CallbackInfo, num);
				break;
			case EAkCallbackType.Marker:
				OnAkEventCallBack_Marker(CallbackType, CallbackInfo, num);
				break;
			case (EAkCallbackType)1:
				break;
			}
		}
	}

	private void OnAkEventCallBack_Duration(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo, int PlayingID)
	{
		if (CallbackType != EAkCallbackType.Duration)
		{
			return;
		}
		UAkDurationCallbackInfo uAkDurationCallbackInfo = CallbackInfo as UAkDurationCallbackInfo;
		if (!(uAkDurationCallbackInfo == null))
		{
			if (AkMgrData.AudioLength.ContainsKey(PlayingID))
			{
				AkMgrData.AudioLength[PlayingID] = uAkDurationCallbackInfo.Duration / 1000f;
			}
			else
			{
				AkMgrData.AudioLength.Add(PlayingID, uAkDurationCallbackInfo.Duration / 1000f);
			}
		}
	}

	private void OnAkEventCallBack_Marker(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo, int PlayingID)
	{
		if (CallbackType != EAkCallbackType.Marker)
		{
			return;
		}
		UAkMarkerCallbackInfo uAkMarkerCallbackInfo = CallbackInfo as UAkMarkerCallbackInfo;
		if (uAkMarkerCallbackInfo == null || !BGUFuncLibAiConversation.AnalysisStrParam_To_IntStrValue(uAkMarkerCallbackInfo.Label, out var IntValue, out var StrValue, '#'))
		{
			return;
		}
		StrValue = StringParseHelper.SafeToLower(StrValue);
		if (StrValue == "start")
		{
			if (AkMgrData.SubtitleStamp.TryGetValue(PlayingID, out var value) && value.Count > 0)
			{
				List<float> list = new List<float>();
				list.AddRange(value);
				list.RemoveAt(0);
				AkMgrData.SubtitleStamp[PlayingID] = list;
			}
			if (!GSLocalization.IsZHCulture() || !BlackList.Contains(IntValue))
			{
				FUStDialogueDesc dialogueDesc = BGW_GameDB.GetDialogueDesc(IntValue);
				if (dialogueDesc != null && AkMgrData.AudioLength.TryGetValue(PlayingID, out var value2) && !(value2 <= 0f))
				{
					PlaySubtitleAndFacialAnim(dialogueDesc.Name.ToFText().ToString(), dialogueDesc.Content.ToFText().ToString(), value2, dialogueDesc.IsSupportSoundDirection == EGSYesNo.Yes, dialogueDesc.FacialAnimPath, dialogueDesc.FacialAnimTimeOffset, dialogueDesc.FacialAnimAutoBlendOutTime, dialogueDesc.IsSupportSkip == EGSYesNo.Yes);
					CurSubtitle_BindPlayingID = PlayingID;
				}
			}
		}
		else if (StrValue == "end" && CurSubtitle_BindPlayingID == PlayingID)
		{
			StopSubtitle();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_AKMgrComp:OnAkCompAutoDestroyed")]
	public void OnAkCompAutoDestroyed(UAkComponent AkComp)
	{
		if (AkMgrData.AutoDestroyCompMap.Count != 0 && AkMgrData.AutoDestroyCompMap.TryGetValue(AkComp, out var value))
		{
			OnAkEventCallBack_Ended(EAkCallbackType.EndOfEvent, null, value);
		}
	}

	public void OnAkEventCallBack_Ended(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo, int PlayingID)
	{
		if (CallbackType != EAkCallbackType.EndOfEvent)
		{
			return;
		}
		if (CurSubtitle_BindPlayingID == PlayingID)
		{
			StopFacialAnim();
			StopSubtitle();
		}
		AkMgrData.AudioLength.Remove(PlayingID);
		AkMgrData.SubtitleStamp.Remove(PlayingID);
		base.BUSEventCollection.Evt_OnAkEventEnded.Invoke(PlayingID);
		if (AkMgrData.AutoDestroyCompMap.Count <= 0)
		{
			return;
		}
		UAkComponent uAkComponent = null;
		foreach (KeyValuePair<UAkComponent, int> item in AkMgrData.AutoDestroyCompMap)
		{
			if (item.Value == PlayingID)
			{
				uAkComponent = item.Key;
			}
		}
		if (!uAkComponent.IsNullOrDestroyed())
		{
			uAkComponent.OnAkCompAutoDestroyed.Unbind(this, B1GlobalFNames.OnAkCompAutoDestroyed);
			AkMgrData.AutoDestroyCompMap.Remove(uAkComponent);
		}
	}

	private void PlaySubtitleAndFacialAnim(string name, string content, float duration, bool IsSupportSoundDirection, string FacialAnimPath, float TimeOffset, float AutoBlendOutTime, bool IsSupportSkip = false)
	{
		if (UIMgr != null)
		{
			CurSubtitleReqID = UIMgr.PlaySubtitle(name, content, duration, IsSupportSoundDirection, Owner, IsSupportSkip);
			PlayFacialAnim(FacialAnimPath, TimeOffset, AutoBlendOutTime);
			AkMgrData.bIsPlayingSubtitle = true;
		}
	}

	private void StopSubtitle()
	{
		if (AkMgrData.bIsPlayingSubtitle)
		{
			UIMgr?.StopSubtitle(CurSubtitleReqID);
			AkMgrData.bIsPlayingSubtitle = false;
			CurSubtitle_BindPlayingID = -1;
		}
	}

	private void PlayFacialAnim(string ExpressionAnimPath, float TimeOffset, float AutoBlendOutTime)
	{
		if (!string.IsNullOrEmpty(ExpressionAnimPath))
		{
			UAnimSequence uAnimSequence = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UAnimSequence>(ExpressionAnimPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.High);
			if (!(uAnimSequence == null))
			{
				base.BUSEventCollection?.Evt_PlayFacialAnim.Invoke(uAnimSequence, TimeOffset, AutoBlendOutTime);
			}
		}
	}

	private void StopFacialAnim()
	{
		base.BUSEventCollection?.Evt_StopFacialAnim.Invoke();
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (State == EMontageCallbackState.OnCompleted || State == EMontageCallbackState.OnInterrupted)
		{
			int uniqueID = (int)Montage.GetUniqueID();
			RemoveAkEventCtrl(State == EMontageCallbackState.OnInterrupted, uniqueID);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AKMgrComp:OnAkEventCallBack")]
	private static void OnAkEventCallBack__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUS_AKMgrComp bUS_AKMgrComp = GCHelper.Find<b1.BUS_AKMgrComp>(obj);
		EAkCallbackType callbackType = EnumMarshaler<EAkCallbackType>.FromNative(IntPtr.Add(buffer, OnAkEventCallBack_CallbackType_Offset), 0, OnAkEventCallBack_CallbackType_PropertyAddress.Address);
		UAkCallbackInfo callbackInfo = UObjectMarshaler<UAkCallbackInfo>.FromNative(IntPtr.Add(buffer, OnAkEventCallBack_CallbackInfo_Offset));
		bUS_AKMgrComp.OnAkEventCallBack(callbackType, callbackInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_AKMgrComp:OnAkCompAutoDestroyed")]
	private static void OnAkCompAutoDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUS_AKMgrComp bUS_AKMgrComp = GCHelper.Find<b1.BUS_AKMgrComp>(obj);
		UAkComponent akComp = UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(buffer, OnAkCompAutoDestroyed_AkComp_Offset));
		bUS_AKMgrComp.OnAkCompAutoDestroyed(akComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_AKMgrComp");
		OnAkEventCallBack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAkEventCallBack");
		OnAkEventCallBack_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAkEventCallBack_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAkEventCallBack_CallbackType_PropertyAddress, OnAkEventCallBack_FunctionAddress, "CallbackType");
		OnAkEventCallBack_CallbackType_Offset = NativeReflection.GetPropertyOffset(OnAkEventCallBack_FunctionAddress, "CallbackType");
		OnAkEventCallBack_CallbackType_IsValid = NativeReflection.ValidatePropertyClass(OnAkEventCallBack_FunctionAddress, "CallbackType", Classes.FEnumProperty);
		OnAkEventCallBack_CallbackInfo_Offset = NativeReflection.GetPropertyOffset(OnAkEventCallBack_FunctionAddress, "CallbackInfo");
		OnAkEventCallBack_CallbackInfo_IsValid = NativeReflection.ValidatePropertyClass(OnAkEventCallBack_FunctionAddress, "CallbackInfo", Classes.FObjectProperty);
		OnAkEventCallBack_IsValid = OnAkEventCallBack_FunctionAddress != IntPtr.Zero && OnAkEventCallBack_CallbackType_IsValid && OnAkEventCallBack_CallbackInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AKMgrComp:OnAkEventCallBack", OnAkEventCallBack_IsValid);
		OnAkCompAutoDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAkCompAutoDestroyed");
		OnAkCompAutoDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAkCompAutoDestroyed_FunctionAddress);
		OnAkCompAutoDestroyed_AkComp_Offset = NativeReflection.GetPropertyOffset(OnAkCompAutoDestroyed_FunctionAddress, "AkComp");
		OnAkCompAutoDestroyed_AkComp_IsValid = NativeReflection.ValidatePropertyClass(OnAkCompAutoDestroyed_FunctionAddress, "AkComp", Classes.FObjectProperty);
		OnAkCompAutoDestroyed_IsValid = OnAkCompAutoDestroyed_FunctionAddress != IntPtr.Zero && OnAkCompAutoDestroyed_AkComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_AKMgrComp:OnAkCompAutoDestroyed", OnAkCompAutoDestroyed_IsValid);
	}

	static BUS_AKMgrComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_AKMgrComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_AKMgrComp));
	}
}
