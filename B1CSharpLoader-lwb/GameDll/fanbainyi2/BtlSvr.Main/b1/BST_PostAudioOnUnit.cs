using System;
using System.Text;
using b1.Plugins.AkAudio;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Track of Post Audio On Unit")]
[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit")]
internal class BST_PostAudioOnUnit : UMovieSceneCalliopeNormalSection
{
	private const float MinimumDuration = 0.05f;

	private const float MaximumDuration = 720000f;

	private static bool bTakePlayerAsUnit_IsValid;

	private static int bTakePlayerAsUnit_Offset;

	private static FFieldAddress bTakePlayerAsUnit_PropertyAddress;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool AttachPointName_IsValid;

	private static int AttachPointName_Offset;

	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool bRetriggerEvent_IsValid;

	private static int bRetriggerEvent_Offset;

	private static FFieldAddress bRetriggerEvent_PropertyAddress;

	private static bool ScrubTailLengthMs_IsValid;

	private static int ScrubTailLengthMs_Offset;

	private static bool bStopAtSectionEnd_IsValid;

	private static int bStopAtSectionEnd_Offset;

	private static FFieldAddress bStopAtSectionEnd_PropertyAddress;

	private static bool PostOnDummyObj_IsValid;

	private static int PostOnDummyObj_Offset;

	private static FFieldAddress PostOnDummyObj_PropertyAddress;

	private static bool SetEvent_Editor_IsValid;

	private static IntPtr SetEvent_Editor_FunctionAddress;

	private static int SetEvent_Editor_ParamsSize;

	private static bool SetEvent_Editor_Event_IsValid;

	private static int SetEvent_Editor_Event_Offset;

	private static bool Evaluate_IsValid;

	private static IntPtr Evaluate_FunctionAddress;

	private static int Evaluate_ParamsSize;

	private static bool Evaluate_InSectionData_IsValid;

	private static int Evaluate_InSectionData_Offset;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static int GetDisplayName_ReturnValue_Offset;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static bool GetDurationTime_IsValid;

	private static IntPtr GetDurationTime_FunctionAddress;

	private static int GetDurationTime_ParamsSize;

	private static bool GetDurationTime_ReturnValue_IsValid;

	private static int GetDurationTime_ReturnValue_Offset;

	private static bool MakeSectionData_IsValid;

	private static IntPtr MakeSectionData_FunctionAddress;

	private static int MakeSectionData_ParamsSize;

	private static bool MakeSectionData_ReturnValue_IsValid;

	private static int MakeSectionData_ReturnValue_Offset;

	private static bool SectionBeingDestroyed_IsValid;

	private static IntPtr SectionBeingDestroyed_FunctionAddress;

	private static int SectionBeingDestroyed_ParamsSize;

	private static bool SectionBeingDestroyed_InSectionData_IsValid;

	private static int SectionBeingDestroyed_InSectionData_Offset;

	[EditAnywhere]
	[Category("AkEvent")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("主角作为Unit")]
	[UMeta(MDProp.EditCondition, "!PostOnDummyObj")]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:bTakePlayerAsUnit")]
	public bool bTakePlayerAsUnit
	{
		get
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:bTakePlayerAsUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:bTakePlayerAsUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "!bTakePlayerAsUnit")]
	[BlueprintReadWrite]
	[Category("AkEvent")]
	[UMeta(MDProp.EditCondition, "!PostOnDummyObj")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "!PostOnDummyObj")]
	[DisplayName("附加的骨骼挂点")]
	[Category("AkEvent")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:AttachPointName")]
	public FName AttachPointName
	{
		get
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:AttachPointName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachPointName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:AttachPointName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachPointName_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("AkEvent")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:AkEvent")]
	public UAkAudioEvent AkEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:AkEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:AkEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_Offset), value);
			}
		}
	}

	[Category("AkEvent")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:EventName")]
	public string EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:EventName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:EventName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EventName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AkEvent")]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:bRetriggerEvent")]
	public bool bRetriggerEvent
	{
		get
		{
			CheckDestroyed();
			if (!bRetriggerEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:bRetriggerEvent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRetriggerEvent_Offset), 0, bRetriggerEvent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRetriggerEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:bRetriggerEvent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRetriggerEvent_Offset), 0, bRetriggerEvent_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.UIMax, 500)]
	[UProperty]
	[UMeta(MDProp.ClampMax, 500)]
	[BlueprintReadWrite]
	[Category("AkEvent")]
	[UMeta(MDProp.ClampMin, 30)]
	[EditAnywhere]
	[UMeta(MDProp.UIMin, 30)]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:ScrubTailLengthMs")]
	public int ScrubTailLengthMs
	{
		get
		{
			CheckDestroyed();
			if (!ScrubTailLengthMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:ScrubTailLengthMs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ScrubTailLengthMs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrubTailLengthMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:ScrubTailLengthMs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ScrubTailLengthMs_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("AkEvent")]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:bStopAtSectionEnd")]
	public bool bStopAtSectionEnd
	{
		get
		{
			CheckDestroyed();
			if (!bStopAtSectionEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:bStopAtSectionEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStopAtSectionEnd_Offset), 0, bStopAtSectionEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStopAtSectionEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:bStopAtSectionEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStopAtSectionEnd_Offset), 0, bStopAtSectionEnd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("AkEvent")]
	[BlueprintReadWrite]
	[DisplayName("不受关卡等卸载影响")]
	[Tooltip("使之可以在关卡卸载时不中断播放, 但会失去空间特性和字幕回调")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:PostOnDummyObj")]
	public bool PostOnDummyObj
	{
		get
		{
			CheckDestroyed();
			if (!PostOnDummyObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:PostOnDummyObj");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PostOnDummyObj_Offset), 0, PostOnDummyObj_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PostOnDummyObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BST_PostAudioOnUnit:PostOnDummyObj");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PostOnDummyObj_Offset), 0, PostOnDummyObj_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:SetEvent_Editor")]
	public void SetEvent_Editor(UAkAudioEvent Event)
	{
		bTakePlayerAsUnit = true;
		AkEvent = Event;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		ScrubTailLengthMs = 100;
		bStopAtSectionEnd = true;
	}

	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:GetDisplayName")]
	protected override string GetDisplayName_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string plainName = UnitGuid.TagName.PlainName;
		if (bTakePlayerAsUnit)
		{
			plainName = B1GlobalFNames.Player_Wukong.PlainName;
		}
		string[] array = plainName.Split('.');
		int num = array.Length;
		if (num > 2)
		{
			stringBuilder.Append(array[num - 2]);
			stringBuilder.Append(".");
			stringBuilder.Append(array[num - 1]);
		}
		else
		{
			stringBuilder.Append(plainName);
		}
		stringBuilder.Append(" : ");
		stringBuilder.Append((AkEvent == null) ? EventName : AkEvent.GetName());
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:GetDurationTime")]
	protected override float GetDurationTime_Implementation()
	{
		if (AkEvent != null && !AkEvent.IsInfinite)
		{
			return FMath.Clamp(AkEvent.MaximumDuration, 0.05f, 720000f);
		}
		return base.GetDurationTime_Implementation();
	}

	private FFloatRange GetAkEventDuration(UAkAudioEvent Event)
	{
		if (Event == null)
		{
			return new FFloatRange(0.5f);
		}
		if (Event.IsInfinite)
		{
			return new FFloatRange(FMath.Min(GetMovieMaxDuration(), 720000f));
		}
		return new FFloatRange(Event.MinimumDuration, FMath.Clamp(AkEvent.MaximumDuration, 0.05f, 720000f));
	}

	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:MakeSectionData")]
	protected override UMovieSceneCalliopeSectionData MakeSectionData_Implementation()
	{
		b1.SequenceSectionContext_PostAudioOnUnit sequenceSectionContext_PostAudioOnUnit = UObject.NewObject<b1.SequenceSectionContext_PostAudioOnUnit>(this);
		sequenceSectionContext_PostAudioOnUnit.bStopAtSectionEnd = bStopAtSectionEnd;
		sequenceSectionContext_PostAudioOnUnit.EventName = ((AkEvent == null) ? EventName : AkEvent.GetName());
		sequenceSectionContext_PostAudioOnUnit.Event = AkEvent;
		sequenceSectionContext_PostAudioOnUnit.ClipStartTime = GetStartTime();
		sequenceSectionContext_PostAudioOnUnit.ClipEndTime = GetEndTime();
		sequenceSectionContext_PostAudioOnUnit.EventDuration = GetAkEventDuration(AkEvent);
		sequenceSectionContext_PostAudioOnUnit.RetriggerEvent = bRetriggerEvent;
		sequenceSectionContext_PostAudioOnUnit.ScrubTailLengthMs = ScrubTailLengthMs;
		sequenceSectionContext_PostAudioOnUnit.PostOnDummyObj = PostOnDummyObj;
		sequenceSectionContext_PostAudioOnUnit.EmptyPlayingIDs();
		sequenceSectionContext_PostAudioOnUnit.EmptyScheduledStops();
		return sequenceSectionContext_PostAudioOnUnit;
	}

	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:SectionBeingDestroyed")]
	protected override void SectionBeingDestroyed_Implementation(UMovieSceneCalliopeSectionData InSectionData)
	{
		b1.SequenceSectionContext_PostAudioOnUnit sequenceSectionContext_PostAudioOnUnit = InSectionData as b1.SequenceSectionContext_PostAudioOnUnit;
		if (!(sequenceSectionContext_PostAudioOnUnit == null))
		{
			sequenceSectionContext_PostAudioOnUnit.ResetTracker();
		}
	}

	[USharpPath("/Script/b1-Managed.BST_PostAudioOnUnit:Evaluate")]
	protected override void Evaluate_Implementation(UMovieSceneCalliopeSectionData InSectionData)
	{
		b1.SequenceSectionContext_PostAudioOnUnit sequenceSectionContext_PostAudioOnUnit = InSectionData as b1.SequenceSectionContext_PostAudioOnUnit;
		if (sequenceSectionContext_PostAudioOnUnit == null)
		{
			return;
		}
		sequenceSectionContext_PostAudioOnUnit.AkComponent = GetAkComponent(sequenceSectionContext_PostAudioOnUnit);
		switch (sequenceSectionContext_PostAudioOnUnit.GetStatus())
		{
		case EMovieScenePlayerStatus.Stopped:
		case EMovieScenePlayerStatus.Paused:
			if (bStopAtSectionEnd)
			{
				sequenceSectionContext_PostAudioOnUnit.ResetTracker();
			}
			break;
		case EMovieScenePlayerStatus.Playing:
		{
			float timeInSeconds = sequenceSectionContext_PostAudioOnUnit.GetTimeInSeconds();
			bool flag = timeInSeconds <= sequenceSectionContext_PostAudioOnUnit.PreviousPlayingTime;
			if ((sequenceSectionContext_PostAudioOnUnit.IsForwardPlay() && !sequenceSectionContext_PostAudioOnUnit.IsPlaying()) || flag)
			{
				if (sequenceSectionContext_PostAudioOnUnit.IsPlaying() && flag)
				{
					sequenceSectionContext_PostAudioOnUnit.StopAllPlayingIDs();
				}
				if (Math.Abs(sequenceSectionContext_PostAudioOnUnit.PreviousEventStartTime - -1f) <= 1E-08f || flag)
				{
					sequenceSectionContext_PostAudioOnUnit.MasterPlay();
				}
				else if (bRetriggerEvent)
				{
					sequenceSectionContext_PostAudioOnUnit.MasterRetrigger();
				}
				sequenceSectionContext_PostAudioOnUnit.PreviousPlayingTime = timeInSeconds;
			}
			else if (sequenceSectionContext_PostAudioOnUnit.HasJumped())
			{
				sequenceSectionContext_PostAudioOnUnit.ResetTracker(bStopAudio: true);
				sequenceSectionContext_PostAudioOnUnit.MasterPlay(bIsJumped: true);
				sequenceSectionContext_PostAudioOnUnit.PreviousPlayingTime = timeInSeconds;
			}
			break;
		}
		case EMovieScenePlayerStatus.Scrubbing:
		case EMovieScenePlayerStatus.Jumping:
		case EMovieScenePlayerStatus.Stepping:
			sequenceSectionContext_PostAudioOnUnit.MasterScrub();
			break;
		}
	}

	private UAkComponent GetAkComponent(b1.SequenceSectionContext_PostAudioOnUnit SectionContext)
	{
		if (SectionContext.IsPreview)
		{
			return GetAkComponentPreview(SectionContext);
		}
		return GetAkComponentRuntime(SectionContext);
	}

	private UAkComponent GetAkComponentRuntime(b1.SequenceSectionContext_PostAudioOnUnit SectionContext)
	{
		UObject playBackContext = SectionContext.GetPlayBackContext();
		if (playBackContext == null || SectionContext.GetStatus() != EMovieScenePlayerStatus.Playing)
		{
			return null;
		}
		AActor aActor = null;
		if (bTakePlayerAsUnit)
		{
			aActor = UGameplayStatics.GetPlayerCharacter(playBackContext, 0);
		}
		else
		{
			string plainName = UnitGuid.TagName.PlainName;
			aActor = BGU_DataUtil.GetActorByGuid(playBackContext, plainName);
		}
		if (aActor == null)
		{
			return null;
		}
		if (BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(aActor) == null)
		{
			return null;
		}
		if (BUS_EventCollectionCS.Get(aActor) != null)
		{
			UMeshComponent uMeshComponent = null;
			uMeshComponent = ((!(aActor is BGUCharacterCS bGUCharacterCS)) ? ((!(aActor is ABGUPerformerActor aBGUPerformerActor)) ? aActor.GetComponentByClass<USkeletalMeshComponent>() : aBGUPerformerActor.Mesh) : bGUCharacterCS.Mesh);
			bool ComponentCreated;
			if (uMeshComponent != null)
			{
				return UAkGameplayStatics.GetAkComponent(uMeshComponent, out ComponentCreated, AttachPointName, FVector.ZeroVector, EAttachLocation.KeepRelativeOffset);
			}
		}
		return null;
	}

	private UAkComponent GetAkComponentPreview(b1.SequenceSectionContext_PostAudioOnUnit SectionContext)
	{
		UObject playBackContext = SectionContext.GetPlayBackContext();
		string plainName = UnitGuid.TagName.PlainName;
		AActor aActor = null;
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(playBackContext);
		foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
		{
			if (BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(bGUCharacterCS).Equals(plainName))
			{
				aActor = bGUCharacterCS;
				break;
			}
		}
		if (aActor == null)
		{
			ABGUActorBase[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<ABGUActorBase>(playBackContext);
			foreach (ABGUActorBase aBGUActorBase in allActorsOfClass2)
			{
				if (BGUFuncLibSceneObj.BGUGetFinalGuidByComponent(aBGUActorBase).Equals(plainName))
				{
					aActor = aBGUActorBase;
					break;
				}
			}
		}
		if (aActor != null)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = null;
			uSkeletalMeshComponent = ((!(aActor is BGUCharacterCS bGUCharacterCS2)) ? ((!(aActor is ABGUPerformerActor aBGUPerformerActor)) ? aActor.GetComponentByClass<USkeletalMeshComponent>() : aBGUPerformerActor.Mesh) : bGUCharacterCS2.Mesh);
			bool ComponentCreated;
			return UAkGameplayStatics.GetAkComponent(uSkeletalMeshComponent, out ComponentCreated, AttachPointName, FVector.ZeroVector, EAttachLocation.KeepRelativeOffset);
		}
		return null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BST_PostAudioOnUnit:SetEvent_Editor")]
	private static void SetEvent_Editor__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BST_PostAudioOnUnit bST_PostAudioOnUnit = GCHelper.Find<b1.BST_PostAudioOnUnit>(obj);
		UAkAudioEvent event_Editor = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(buffer, SetEvent_Editor_Event_Offset));
		bST_PostAudioOnUnit.SetEvent_Editor(event_Editor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BST_PostAudioOnUnit:Evaluate")]
	private static void Evaluate__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BST_PostAudioOnUnit bST_PostAudioOnUnit = GCHelper.Find<b1.BST_PostAudioOnUnit>(obj);
		UMovieSceneCalliopeSectionData inSectionData = UObjectMarshaler<UMovieSceneCalliopeSectionData>.FromNative(IntPtr.Add(buffer, Evaluate_InSectionData_Offset));
		bST_PostAudioOnUnit.Evaluate_Implementation(inSectionData);
	}

	[UFunctionInvoker("/Script/b1-Managed.BST_PostAudioOnUnit:GetDisplayName")]
	private static void GetDisplayName__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BST_PostAudioOnUnit bST_PostAudioOnUnit = GCHelper.Find<b1.BST_PostAudioOnUnit>(obj);
		string displayName_Implementation = bST_PostAudioOnUnit.GetDisplayName_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayName_ReturnValue_Offset), displayName_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BST_PostAudioOnUnit:GetDurationTime")]
	private static void GetDurationTime__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BST_PostAudioOnUnit bST_PostAudioOnUnit = GCHelper.Find<b1.BST_PostAudioOnUnit>(obj);
		float durationTime_Implementation = bST_PostAudioOnUnit.GetDurationTime_Implementation();
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetDurationTime_ReturnValue_Offset), durationTime_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BST_PostAudioOnUnit:MakeSectionData")]
	private static void MakeSectionData__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BST_PostAudioOnUnit bST_PostAudioOnUnit = GCHelper.Find<b1.BST_PostAudioOnUnit>(obj);
		UMovieSceneCalliopeSectionData value = bST_PostAudioOnUnit.MakeSectionData_Implementation();
		UObjectMarshaler<UMovieSceneCalliopeSectionData>.ToNative(IntPtr.Add(buffer, MakeSectionData_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BST_PostAudioOnUnit:SectionBeingDestroyed")]
	private static void SectionBeingDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BST_PostAudioOnUnit bST_PostAudioOnUnit = GCHelper.Find<b1.BST_PostAudioOnUnit>(obj);
		UMovieSceneCalliopeSectionData inSectionData = UObjectMarshaler<UMovieSceneCalliopeSectionData>.FromNative(IntPtr.Add(buffer, SectionBeingDestroyed_InSectionData_Offset));
		bST_PostAudioOnUnit.SectionBeingDestroyed_Implementation(inSectionData);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BST_PostAudioOnUnit");
		NativeReflection.GetPropertyRef(ref bTakePlayerAsUnit_PropertyAddress, intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTakePlayerAsUnit", Classes.FBoolProperty);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
		AttachPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachPointName");
		AttachPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachPointName", Classes.FNameProperty);
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FObjectProperty);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bRetriggerEvent_PropertyAddress, intPtr, "bRetriggerEvent");
		bRetriggerEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRetriggerEvent");
		bRetriggerEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRetriggerEvent", Classes.FBoolProperty);
		ScrubTailLengthMs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScrubTailLengthMs");
		ScrubTailLengthMs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScrubTailLengthMs", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bStopAtSectionEnd_PropertyAddress, intPtr, "bStopAtSectionEnd");
		bStopAtSectionEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStopAtSectionEnd");
		bStopAtSectionEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStopAtSectionEnd", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PostOnDummyObj_PropertyAddress, intPtr, "PostOnDummyObj");
		PostOnDummyObj_Offset = NativeReflection.GetPropertyOffset(intPtr, "PostOnDummyObj");
		PostOnDummyObj_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PostOnDummyObj", Classes.FBoolProperty);
		SetEvent_Editor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEvent_Editor");
		SetEvent_Editor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEvent_Editor_FunctionAddress);
		SetEvent_Editor_Event_Offset = NativeReflection.GetPropertyOffset(SetEvent_Editor_FunctionAddress, "Event");
		SetEvent_Editor_Event_IsValid = NativeReflection.ValidatePropertyClass(SetEvent_Editor_FunctionAddress, "Event", Classes.FObjectProperty);
		SetEvent_Editor_IsValid = SetEvent_Editor_FunctionAddress != IntPtr.Zero && SetEvent_Editor_Event_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BST_PostAudioOnUnit:SetEvent_Editor", SetEvent_Editor_IsValid);
		Evaluate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Evaluate");
		Evaluate_ParamsSize = NativeReflection.GetFunctionParamsSize(Evaluate_FunctionAddress);
		Evaluate_InSectionData_Offset = NativeReflection.GetPropertyOffset(Evaluate_FunctionAddress, "InSectionData");
		Evaluate_InSectionData_IsValid = NativeReflection.ValidatePropertyClass(Evaluate_FunctionAddress, "InSectionData", Classes.FObjectProperty);
		Evaluate_IsValid = Evaluate_FunctionAddress != IntPtr.Zero && Evaluate_InSectionData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BST_PostAudioOnUnit:Evaluate", Evaluate_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BST_PostAudioOnUnit:GetDisplayName", GetDisplayName_IsValid);
		GetDurationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDurationTime");
		GetDurationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDurationTime_FunctionAddress);
		GetDurationTime_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDurationTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDurationTime_IsValid = GetDurationTime_FunctionAddress != IntPtr.Zero && GetDurationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BST_PostAudioOnUnit:GetDurationTime", GetDurationTime_IsValid);
		MakeSectionData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeSectionData");
		MakeSectionData_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeSectionData_FunctionAddress);
		MakeSectionData_ReturnValue_Offset = NativeReflection.GetPropertyOffset(MakeSectionData_FunctionAddress, "ReturnValue");
		MakeSectionData_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(MakeSectionData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MakeSectionData_IsValid = MakeSectionData_FunctionAddress != IntPtr.Zero && MakeSectionData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BST_PostAudioOnUnit:MakeSectionData", MakeSectionData_IsValid);
		SectionBeingDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SectionBeingDestroyed");
		SectionBeingDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(SectionBeingDestroyed_FunctionAddress);
		SectionBeingDestroyed_InSectionData_Offset = NativeReflection.GetPropertyOffset(SectionBeingDestroyed_FunctionAddress, "InSectionData");
		SectionBeingDestroyed_InSectionData_IsValid = NativeReflection.ValidatePropertyClass(SectionBeingDestroyed_FunctionAddress, "InSectionData", Classes.FObjectProperty);
		SectionBeingDestroyed_IsValid = SectionBeingDestroyed_FunctionAddress != IntPtr.Zero && SectionBeingDestroyed_InSectionData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BST_PostAudioOnUnit:SectionBeingDestroyed", SectionBeingDestroyed_IsValid);
	}

	static BST_PostAudioOnUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BST_PostAudioOnUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BST_PostAudioOnUnit));
	}
}
