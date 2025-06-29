using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.AkAudio;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.SequenceSectionContext_PostAudioOnUnit")]
internal class SequenceSectionContext_PostAudioOnUnit : UMovieSceneCalliopeSectionData
{
	private const float MinimumDuration = 0.05f;

	private const float MaximumDuration = 720000f;

	private static bool PostEventCallbackHandler_IsValid;

	private static IntPtr PostEventCallbackHandler_FunctionAddress;

	private static int PostEventCallbackHandler_ParamsSize;

	private static bool PostEventCallbackHandler_CallbackType_IsValid;

	private static int PostEventCallbackHandler_CallbackType_Offset;

	private static FFieldAddress PostEventCallbackHandler_CallbackType_PropertyAddress;

	private static bool PostEventCallbackHandler_CallbackInfo_IsValid;

	private static int PostEventCallbackHandler_CallbackInfo_Offset;

	public bool IsDirty { get; set; }

	public List<int> PlayingIDs { get; } = new List<int>();

	public List<int> ScheduledStops { get; } = new List<int>();

	public string EventName { get; set; }

	public UAkAudioEvent Event { get; set; }

	public float ClipStartTime { get; set; }

	public float ClipEndTime { get; set; }

	public FFloatRange EventDuration { get; set; }

	public bool RetriggerEvent { get; set; }

	public int ScrubTailLengthMs { get; set; }

	public float PreviousEventStartTime { get; set; } = -1f;

	public float PreviousPlayingTime { get; set; } = -1f;

	public float CurrentDurationEstimation { get; set; } = -1f;

	public float CurrentDurationProportionRemaining { get; set; } = 1f;

	public bool bStopAtSectionEnd { get; set; } = true;

	public bool PostOnDummyObj { get; set; } = true;

	public UAkComponent AkComponent { get; set; }

	private object PlayingIDsLock { get; set; } = new object();

	private object ScheduledStopsLock { get; set; } = new object();

	public bool IsPlaying()
	{
		lock (PlayingIDsLock)
		{
			return PlayingIDs.Count > 0;
		}
	}

	public bool HasScheduledStop()
	{
		lock (ScheduledStopsLock)
		{
			return ScheduledStops.Count > 0;
		}
	}

	public float GetClipDuration()
	{
		return ClipEndTime - ClipStartTime;
	}

	public void TryAddPlayingID(int PlayingID)
	{
		lock (PlayingIDsLock)
		{
			PlayingIDs.Add(PlayingID);
		}
	}

	public void RemovePlayingID(int InID)
	{
		lock (PlayingIDsLock)
		{
			PlayingIDs.Remove(InID);
		}
	}

	public void RemoveScheduledStop(int InID)
	{
		lock (ScheduledStopsLock)
		{
			ScheduledStops.Remove(InID);
		}
	}

	public void EmptyPlayingIDs()
	{
		lock (PlayingIDsLock)
		{
			PlayingIDs.Clear();
		}
	}

	public void EmptyScheduledStops()
	{
		lock (ScheduledStopsLock)
		{
			ScheduledStops.Clear();
		}
	}

	public bool PlayingIDHasScheduledStop(int InID)
	{
		lock (ScheduledStopsLock)
		{
			foreach (int scheduledStop in ScheduledStops)
			{
				if (scheduledStop == InID)
				{
					return true;
				}
			}
			return false;
		}
	}

	public void AddScheduledStop(int InID)
	{
		lock (ScheduledStopsLock)
		{
			ScheduledStops.Add(InID);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.SequenceSectionContext_PostAudioOnUnit:PostEventCallbackHandler")]
	public void PostEventCallbackHandler(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
	{
		if (CallbackInfo == null)
		{
			return;
		}
		switch (CallbackType)
		{
		case EAkCallbackType.EndOfEvent:
		{
			UAkEventCallbackInfo uAkEventCallbackInfo = CallbackInfo as UAkEventCallbackInfo;
			if (!(uAkEventCallbackInfo == null))
			{
				int playingID = uAkEventCallbackInfo.PlayingID;
				RemovePlayingID(playingID);
				RemoveScheduledStop(playingID);
			}
			break;
		}
		case EAkCallbackType.Duration:
		{
			UAkDurationCallbackInfo uAkDurationCallbackInfo = CallbackInfo as UAkDurationCallbackInfo;
			if (!(uAkDurationCallbackInfo == null))
			{
				CurrentDurationEstimation = uAkDurationCallbackInfo.EstimatedDuration * CurrentDurationProportionRemaining / 1000f;
			}
			break;
		}
		}
	}

	private float GetMaxDuration()
	{
		if (Event == null)
		{
			return 0.05f;
		}
		return FMath.Clamp(Event.MaximumDuration, 0.05f, 720000f);
	}

	private bool EventShouldPlay()
	{
		float num = ((Math.Abs(PreviousEventStartTime - -1f) < 1E-08f) ? ClipStartTime : PreviousEventStartTime);
		if (!(GetTimeInSeconds() - num < GetMaxDuration()))
		{
			return RetriggerEvent;
		}
		return true;
	}

	private float GetProportionalTime(bool bIsJumped = false)
	{
		if (base.Valid)
		{
			float maxDuration = GetMaxDuration();
			if (maxDuration > 0f)
			{
				float num = ((PreviousEventStartTime == -1f) ? ClipStartTime : PreviousEventStartTime);
				float x = GetTimeInSeconds() - num;
				if (bIsJumped && BGW_GameDB.GetSeqAudioJumpLength(Event.GetFName().ToString(), out var AudioLength))
				{
					float num2 = 0f;
					UCalliopeLevelSequencePlayer calliopePlayer = GetCalliopePlayer();
					if (calliopePlayer != null)
					{
						num2 = calliopePlayer.SeqJumpError;
					}
					x = (float)AudioLength / 60f + num2;
				}
				x = MathLib.Clamp(x, 0f, maxDuration);
				return x / maxDuration;
			}
		}
		return 1f;
	}

	public void MasterPlay(bool bIsJumped = false)
	{
		if (base.Valid && EventShouldPlay())
		{
			StopAllPlayingIDs();
			PreviousEventStartTime = ClipStartTime;
			float timeInSeconds = GetTimeInSeconds();
			int inPlayingID = PostAkEvent(AkComponent);
			float proportionalTime = GetProportionalTime(bIsJumped);
			if (proportionalTime < 1f && proportionalTime >= 0f)
			{
				UBGUFunctionLibAK.SeekOnEvent(EventName, AkComponent, proportionalTime, bInSeekToNearestMarker: false, inPlayingID);
				CurrentDurationProportionRemaining = 1f - proportionalTime;
			}
			PreviousEventStartTime = timeInSeconds;
		}
	}

	public void MasterRetrigger()
	{
		if (base.Valid && EventShouldPlay())
		{
			float timeInSeconds = GetTimeInSeconds();
			int inPlayingID = PostAkEvent(AkComponent);
			PreviousEventStartTime = timeInSeconds;
			float proportionalTime = GetProportionalTime();
			if (proportionalTime < 1f && proportionalTime >= 0f)
			{
				UBGUFunctionLibAK.SeekOnEvent(EventName, AkComponent, proportionalTime, bInSeekToNearestMarker: false, inPlayingID);
				CurrentDurationProportionRemaining = 1f - proportionalTime;
			}
		}
	}

	public void MasterScrub()
	{
		if (!base.Valid || !EventShouldPlay())
		{
			return;
		}
		if (!IsPlaying())
		{
			TriggerScrubSnippet();
		}
		else if (!HasScheduledStop())
		{
			ScheduleStopEventsForCurrentlyPlayingIDs();
		}
		PreviousEventStartTime = -1f;
		float proportionalTime = GetProportionalTime();
		foreach (int playingID in PlayingIDs)
		{
			UBGUFunctionLibAK.SeekOnEvent(EventName, AkComponent, proportionalTime, bInSeekToNearestMarker: false, playingID);
			CurrentDurationProportionRemaining = 1f - proportionalTime;
		}
	}

	private void TriggerScrubSnippet()
	{
		if (!string.IsNullOrEmpty(EventName))
		{
			int playingID = PostAkEvent(AkComponent);
			TriggerStopEvent(playingID);
		}
	}

	private void ScheduleStopEventsForCurrentlyPlayingIDs()
	{
		foreach (int playingID in PlayingIDs)
		{
			if (!PlayingIDHasScheduledStop(playingID))
			{
				TriggerStopEvent(playingID);
			}
		}
	}

	private void TriggerStopEvent(int PlayingID)
	{
		UBGUFunctionLibAK.BGUAKStopPlayingID(PlayingID, ScrubTailLengthMs, 2);
		AddScheduledStop(PlayingID);
	}

	public void ResetTracker(bool bStopAudio = false)
	{
		if (bStopAtSectionEnd || bStopAudio)
		{
			StopAllPlayingIDs();
		}
		PreviousEventStartTime = -1f;
		PreviousPlayingTime = -1f;
	}

	public void StopAllPlayingIDs()
	{
		foreach (int playingID in PlayingIDs)
		{
			StopAkByPlayingID(playingID);
		}
		EmptyPlayingIDs();
	}

	private void StopAkByPlayingID(int PlayingID)
	{
		UBGUFunctionLibAK.BGUAKStopPlayingID(PlayingID, 0, 4);
	}

	private int PostAkEvent(UAkComponent AkComp)
	{
		int num = 0;
		if (PostOnDummyObj)
		{
			UObject playBackContext = GetPlayBackContext();
			if (playBackContext != null)
			{
				BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(playBackContext);
				if (bGW_PreloadAssetMgr != null)
				{
					bGW_PreloadAssetMgr.SustainAkReferenceWithinTime(Event);
				}
			}
			num = UAkGameplayStatics.PostEventOnDummyObj(Event, string.Empty);
		}
		if (AkComp != null && num == 0)
		{
			AActor actor = AkComp?.GetOwner();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_PostAkEvent_OnAkComp.Invoke(AkComp, Event, bPlaySubtitle: true);
				b1.IBUC_AkMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_AkMgrData, BUC_AKMgrData>(actor);
				if (readOnlyData != null)
				{
					num = readOnlyData.LastPlayingID;
				}
			}
		}
		if (num == 0)
		{
			if (AkComp == null)
			{
				num = UBGUFunctionLibAK.PostAkEventOnDummyActor(EventName, Event);
			}
			else
			{
				FOnAkPostEventCallback fOnAkPostEventCallback = new FOnAkPostEventCallback();
				fOnAkPostEventCallback.Bind(this, B1GlobalFNames.PostEventCallbackHandler);
				num = AkComp.PostAkEvent(Event, 9, fOnAkPostEventCallback, EventName);
			}
		}
		TryAddPlayingID(num);
		if (Event != null && Event.IsValidLowLevel() && num != 0)
		{
			UBGUFunctionLibAK.AkEventPinInGarbageCollector(Event, num);
		}
		return num;
	}

	[UFunctionInvoker("/Script/b1-Managed.SequenceSectionContext_PostAudioOnUnit:PostEventCallbackHandler")]
	private static void PostEventCallbackHandler__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.SequenceSectionContext_PostAudioOnUnit sequenceSectionContext_PostAudioOnUnit = GCHelper.Find<b1.SequenceSectionContext_PostAudioOnUnit>(obj);
		EAkCallbackType callbackType = EnumMarshaler<EAkCallbackType>.FromNative(IntPtr.Add(buffer, PostEventCallbackHandler_CallbackType_Offset), 0, PostEventCallbackHandler_CallbackType_PropertyAddress.Address);
		UAkCallbackInfo callbackInfo = UObjectMarshaler<UAkCallbackInfo>.FromNative(IntPtr.Add(buffer, PostEventCallbackHandler_CallbackInfo_Offset));
		sequenceSectionContext_PostAudioOnUnit.PostEventCallbackHandler(callbackType, callbackInfo);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.SequenceSectionContext_PostAudioOnUnit");
		PostEventCallbackHandler_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostEventCallbackHandler");
		PostEventCallbackHandler_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEventCallbackHandler_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostEventCallbackHandler_CallbackType_PropertyAddress, PostEventCallbackHandler_FunctionAddress, "CallbackType");
		PostEventCallbackHandler_CallbackType_Offset = NativeReflection.GetPropertyOffset(PostEventCallbackHandler_FunctionAddress, "CallbackType");
		PostEventCallbackHandler_CallbackType_IsValid = NativeReflection.ValidatePropertyClass(PostEventCallbackHandler_FunctionAddress, "CallbackType", Classes.FEnumProperty);
		PostEventCallbackHandler_CallbackInfo_Offset = NativeReflection.GetPropertyOffset(PostEventCallbackHandler_FunctionAddress, "CallbackInfo");
		PostEventCallbackHandler_CallbackInfo_IsValid = NativeReflection.ValidatePropertyClass(PostEventCallbackHandler_FunctionAddress, "CallbackInfo", Classes.FObjectProperty);
		PostEventCallbackHandler_IsValid = PostEventCallbackHandler_FunctionAddress != IntPtr.Zero && PostEventCallbackHandler_CallbackType_IsValid && PostEventCallbackHandler_CallbackInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SequenceSectionContext_PostAudioOnUnit:PostEventCallbackHandler", PostEventCallbackHandler_IsValid);
	}

	static SequenceSectionContext_PostAudioOnUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.SequenceSectionContext_PostAudioOnUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.SequenceSectionContext_PostAudioOnUnit));
	}
}
