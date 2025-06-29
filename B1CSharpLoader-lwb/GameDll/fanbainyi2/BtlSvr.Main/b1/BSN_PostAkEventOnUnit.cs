using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.AkAudio;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("废弃")]
[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit")]
internal class BSN_PostAkEventOnUnit : UMovieSceneCalliopeNotifySection
{
	private const float MinimumDuration = 0.05f;

	private const float MaximumDuration = 720000f;

	private static bool bTakePlayerAsUnit_IsValid;

	private static int bTakePlayerAsUnit_Offset;

	private static FFieldAddress bTakePlayerAsUnit_PropertyAddress;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool CanHandleStopRequest_IsValid;

	private static int CanHandleStopRequest_Offset;

	private static FFieldAddress CanHandleStopRequest_PropertyAddress;

	private static bool AttachPointName_IsValid;

	private static int AttachPointName_Offset;

	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	private static bool AkStopEvent_IsValid;

	private static int AkStopEvent_Offset;

	private static bool Follow_IsValid;

	private static int Follow_Offset;

	private static FFieldAddress Follow_PropertyAddress;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool OnNotify_IsValid;

	private static IntPtr OnNotify_FunctionAddress;

	private static int OnNotify_ParamsSize;

	private static bool OnNotify_InPlayer_IsValid;

	private static int OnNotify_InPlayer_Offset;

	private static bool OnNotify_InStatus_IsValid;

	private static int OnNotify_InStatus_Offset;

	private static bool OnNotify_bInBackwards_IsValid;

	private static int OnNotify_bInBackwards_Offset;

	private static FFieldAddress OnNotify_bInBackwards_PropertyAddress;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static int GetDisplayName_ReturnValue_Offset;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static bool OnPreviewNotify_IsValid;

	private static IntPtr OnPreviewNotify_FunctionAddress;

	private static int OnPreviewNotify_ParamsSize;

	private static bool OnPreviewNotify_InPlaybackContext_IsValid;

	private static int OnPreviewNotify_InPlaybackContext_Offset;

	private static bool OnPreviewNotify_InStatus_IsValid;

	private static int OnPreviewNotify_InStatus_Offset;

	private static bool OnPreviewNotify_bInBackwards_IsValid;

	private static int OnPreviewNotify_bInBackwards_Offset;

	private static FFieldAddress OnPreviewNotify_bInBackwards_PropertyAddress;

	private static bool GetDurationTime_IsValid;

	private static IntPtr GetDurationTime_FunctionAddress;

	private static int GetDurationTime_ParamsSize;

	private static bool GetDurationTime_ReturnValue_IsValid;

	private static int GetDurationTime_ReturnValue_Offset;

	[DisplayName("主角作为Unit")]
	[Category("AkEvent")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:bTakePlayerAsUnit")]
	public bool bTakePlayerAsUnit
	{
		get
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:bTakePlayerAsUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:bTakePlayerAsUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address, value);
			}
		}
	}

	[Category("AkEvent")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!bTakePlayerAsUnit")]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("AkEvent")]
	[Tooltip("需要处理打断机制因而要被管理的请打上勾，打上勾的此Notify务必请配置在Montage里！")]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:CanHandleStopRequest")]
	public bool CanHandleStopRequest
	{
		get
		{
			CheckDestroyed();
			if (!CanHandleStopRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:CanHandleStopRequest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanHandleStopRequest_Offset), 0, CanHandleStopRequest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanHandleStopRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:CanHandleStopRequest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanHandleStopRequest_Offset), 0, CanHandleStopRequest_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("AkEvent")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:AttachPointName")]
	public FName AttachPointName
	{
		get
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:AttachPointName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachPointName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:AttachPointName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachPointName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("AkEvent")]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:AkEvent")]
	public UAkAudioEvent AkEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:AkEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:AkEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("AkEvent")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:AkStopEvent")]
	public UAkAudioEvent AkStopEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkStopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:AkStopEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkStopEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkStopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:AkStopEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkStopEvent_Offset), value);
			}
		}
	}

	[Category("AkEvent")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:Follow")]
	public bool Follow
	{
		get
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:Follow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:Follow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address, value);
			}
		}
	}

	[Category("AkEvent")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:EventName")]
	public string EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:EventName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_PostAkEventOnUnit:EventName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EventName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:OnPreviewNotify")]
	protected override void OnPreviewNotify_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
		if (InStatus != 1 || bInBackwards || bTakePlayerAsUnit)
		{
			return;
		}
		string plainName = UnitGuid.TagName.PlainName;
		AActor aActor = null;
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(InPlaybackContext);
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
			ABGUActorBase[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<ABGUActorBase>(InPlaybackContext);
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
			PostAkEvent(aActor, uSkeletalMeshComponent, AttachPointName, AkEvent, Follow, EventName, CanHandleStopRequest);
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		if (InStatus != 1 || bInBackwards)
		{
			return;
		}
		if (bTakePlayerAsUnit)
		{
			foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(playbackContext))
			{
				PostAkEventOnActor(allPlayerActor);
			}
			return;
		}
		string plainName = UnitGuid.TagName.PlainName;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(playbackContext, plainName);
		PostAkEventOnActor(actorByGuid);
	}

	private void PostAkEventOnActor(AActor PostOnActor)
	{
		if (!(PostOnActor == null) && !(BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(PostOnActor) == null) && BUS_EventCollectionCS.Get(PostOnActor) != null)
		{
			UMeshComponent uMeshComponent = null;
			uMeshComponent = ((!(PostOnActor is BGUCharacterCS bGUCharacterCS)) ? ((!(PostOnActor is ABGUPerformerActor aBGUPerformerActor)) ? PostOnActor.GetComponentByClass<USkeletalMeshComponent>() : aBGUPerformerActor.Mesh) : bGUCharacterCS.Mesh);
			if (uMeshComponent != null)
			{
				PostAkEvent(PostOnActor, uMeshComponent, AttachPointName, AkEvent, Follow, EventName, CanHandleStopRequest);
			}
		}
	}

	private void PostAkEvent(AActor Owner, UMeshComponent MeshComp, FName AttachPointName, UAkAudioEvent AkEvent, bool Follow, string EventName, bool CanHandleStopRequest)
	{
		if (Owner == null)
		{
			return;
		}
		if (!Follow)
		{
			UAkGameplayStatics.PostEventAtLocation(AkEvent, MeshComp.GetWorldLocation(), MeshComp.GetWorldRotation(), EventName, Owner.World);
			return;
		}
		UAkComponent uAkComponent = null;
		uAkComponent = UAkGameplayStatics.GetAkComponent(MeshComp, out var _, AttachPointName, FVector.ZeroVector, EAttachLocation.KeepRelativeOffset);
		if (uAkComponent != null)
		{
			FOnAkPostEventCallback postEventCallback = new FOnAkPostEventCallback();
			new List<FAkExternalSourceInfo>();
			uAkComponent.PostAkEvent(AkEvent, 0, postEventCallback, EventName);
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:GetDurationTime")]
	protected override float GetDurationTime_Implementation()
	{
		if (AkEvent != null && !AkEvent.IsInfinite)
		{
			return FMath.Clamp(AkEvent.MaximumDuration, 0.05f, 720000f);
		}
		return base.GetDurationTime_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BSN_PostAkEventOnUnit:GetDisplayName")]
	protected override string GetDisplayName_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string[] array = UnitGuid.TagName.PlainName.Split('.');
		int num = array.Length;
		if (num > 2)
		{
			stringBuilder.Append(array[num - 2]);
			stringBuilder.Append(".");
			stringBuilder.Append(array[num - 1]);
		}
		else
		{
			stringBuilder.Append(UnitGuid.TagName.PlainName);
		}
		stringBuilder.Append(" : ");
		stringBuilder.Append((AkEvent == null) ? EventName : AkEvent.GetName());
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_PostAkEventOnUnit:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSN_PostAkEventOnUnit bSN_PostAkEventOnUnit = GCHelper.Find<b1.BSN_PostAkEventOnUnit>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_PostAkEventOnUnit.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_PostAkEventOnUnit:GetDisplayName")]
	private static void GetDisplayName__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSN_PostAkEventOnUnit bSN_PostAkEventOnUnit = GCHelper.Find<b1.BSN_PostAkEventOnUnit>(obj);
		string displayName_Implementation = bSN_PostAkEventOnUnit.GetDisplayName_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayName_ReturnValue_Offset), displayName_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_PostAkEventOnUnit:OnPreviewNotify")]
	private static void OnPreviewNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSN_PostAkEventOnUnit bSN_PostAkEventOnUnit = GCHelper.Find<b1.BSN_PostAkEventOnUnit>(obj);
		UObject inPlaybackContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnPreviewNotify_InPlaybackContext_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnPreviewNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnPreviewNotify_bInBackwards_Offset), 0, OnPreviewNotify_bInBackwards_PropertyAddress.Address);
		bSN_PostAkEventOnUnit.OnPreviewNotify_Implementation(inPlaybackContext, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_PostAkEventOnUnit:GetDurationTime")]
	private static void GetDurationTime__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSN_PostAkEventOnUnit bSN_PostAkEventOnUnit = GCHelper.Find<b1.BSN_PostAkEventOnUnit>(obj);
		float durationTime_Implementation = bSN_PostAkEventOnUnit.GetDurationTime_Implementation();
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetDurationTime_ReturnValue_Offset), durationTime_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_PostAkEventOnUnit");
		NativeReflection.GetPropertyRef(ref bTakePlayerAsUnit_PropertyAddress, intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTakePlayerAsUnit", Classes.FBoolProperty);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CanHandleStopRequest_PropertyAddress, intPtr, "CanHandleStopRequest");
		CanHandleStopRequest_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanHandleStopRequest");
		CanHandleStopRequest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanHandleStopRequest", Classes.FBoolProperty);
		AttachPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachPointName");
		AttachPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachPointName", Classes.FNameProperty);
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FObjectProperty);
		AkStopEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkStopEvent");
		AkStopEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkStopEvent", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Follow_PropertyAddress, intPtr, "Follow");
		Follow_Offset = NativeReflection.GetPropertyOffset(intPtr, "Follow");
		Follow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Follow", Classes.FBoolProperty);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FStrProperty);
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		OnNotify_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InPlayer");
		OnNotify_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_InPlayer_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_PostAkEventOnUnit:OnNotify", OnNotify_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_PostAkEventOnUnit:GetDisplayName", GetDisplayName_IsValid);
		OnPreviewNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewNotify");
		OnPreviewNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewNotify_FunctionAddress);
		OnPreviewNotify_InPlaybackContext_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "InPlaybackContext");
		OnPreviewNotify_InPlaybackContext_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "InPlaybackContext", Classes.FObjectProperty);
		OnPreviewNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "InStatus");
		OnPreviewNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnPreviewNotify_bInBackwards_PropertyAddress, OnPreviewNotify_FunctionAddress, "bInBackwards");
		OnPreviewNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnPreviewNotify_FunctionAddress, "bInBackwards");
		OnPreviewNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnPreviewNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnPreviewNotify_IsValid = OnPreviewNotify_FunctionAddress != IntPtr.Zero && OnPreviewNotify_InPlaybackContext_IsValid && OnPreviewNotify_InStatus_IsValid && OnPreviewNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_PostAkEventOnUnit:OnPreviewNotify", OnPreviewNotify_IsValid);
		GetDurationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDurationTime");
		GetDurationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDurationTime_FunctionAddress);
		GetDurationTime_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDurationTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDurationTime_IsValid = GetDurationTime_FunctionAddress != IntPtr.Zero && GetDurationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_PostAkEventOnUnit:GetDurationTime", GetDurationTime_IsValid);
	}

	static BSN_PostAkEventOnUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BSN_PostAkEventOnUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BSN_PostAkEventOnUnit));
	}
}
