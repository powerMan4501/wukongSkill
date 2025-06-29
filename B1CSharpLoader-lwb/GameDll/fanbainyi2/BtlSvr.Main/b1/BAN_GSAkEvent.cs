using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN AkEvent")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSAkEvent")]
internal class BAN_GSAkEvent : BAN_GSBase
{
	private static bool CanHandleStopRequest_IsValid;

	private static int CanHandleStopRequest_Offset;

	private static FFieldAddress CanHandleStopRequest_PropertyAddress;

	private static bool PlaySubtitle_IsValid;

	private static int PlaySubtitle_Offset;

	private static FFieldAddress PlaySubtitle_PropertyAddress;

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

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[Tooltip("需要处理打断机制因而要被管理的请打上勾，打上勾的此Notify务必请配置在Montage里！")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:CanHandleStopRequest")]
	public bool CanHandleStopRequest
	{
		get
		{
			CheckDestroyed();
			if (!CanHandleStopRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:CanHandleStopRequest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanHandleStopRequest_Offset), 0, CanHandleStopRequest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanHandleStopRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:CanHandleStopRequest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanHandleStopRequest_Offset), 0, CanHandleStopRequest_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("播放字幕")]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:PlaySubtitle")]
	public bool PlaySubtitle
	{
		get
		{
			CheckDestroyed();
			if (!PlaySubtitle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:PlaySubtitle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PlaySubtitle_Offset), 0, PlaySubtitle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PlaySubtitle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:PlaySubtitle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PlaySubtitle_Offset), 0, PlaySubtitle_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:AttachPointName")]
	public string AttachPointName
	{
		get
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:AttachPointName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AttachPointName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:AttachPointName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AttachPointName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:AkEvent")]
	public TSoftObject<UAkAudioEvent> AkEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:AkEvent");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:AkEvent");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:AkStopEvent")]
	public TSoftObject<UAkAudioEvent> AkStopEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkStopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:AkStopEvent");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkStopEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkStopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:AkStopEvent");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkStopEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:Follow")]
	public bool Follow
	{
		get
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:Follow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:Follow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:EventName")]
	public string EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:EventName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSAkEvent:EventName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EventName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		List<FSoftObjectPath> list = new List<FSoftObjectPath>();
		if (!AkEvent.IsNull)
		{
			list.Add(AkEvent.ObjectPath);
		}
		if (!AkStopEvent.IsNull)
		{
			list.Add(AkStopEvent.ObjectPath);
		}
		return list;
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!AkEvent.IsNull)
		{
			SoftPathSet.Add(AkEvent.ObjectPath);
		}
		if (!AkStopEvent.IsNull)
		{
			SoftPathSet.Add(AkStopEvent.ObjectPath);
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSAkEvent:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (actorStreamingLevelWorld == null)
		{
			return;
		}
		UAkAudioEvent validResource = GetValidResource(AkEvent);
		if (validResource == null)
		{
			return;
		}
		UAkAudioEvent validResource2 = GetValidResource(AkStopEvent);
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			PostAkEvent(owner, NotifyParam.MeshComp, new FName(AttachPointName), validResource, Follow, EventName, CanHandleStopRequest);
		}
		else
		{
			if (!UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(actorStreamingLevelWorld))
			{
				return;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				int montageID = -1;
				if (NotifyParam.Animation != null)
				{
					montageID = (int)NotifyParam.Animation.GetUniqueID();
				}
				bUS_GSEventCollection.Evt_PostAkEvent_AM.Invoke(montageID, NotifyParam.MeshComp, new FName(AttachPointName), validResource, validResource2, Follow, EventName, CanHandleStopRequest, PlaySubtitle);
			}
		}
	}

	private void PostAkEvent(AActor Owner, USkeletalMeshComponent MeshComp, FName AttachPointName, UAkAudioEvent AkEvent, bool Follow, string EventName, bool CanHandleStopRequest)
	{
		if (Owner == null)
		{
			return;
		}
		int num = -1;
		if (!Follow)
		{
			num = UAkGameplayStatics.PostEventAtLocation(AkEvent, MeshComp.GetWorldLocation(), MeshComp.GetWorldRotation(), EventName, Owner.World);
		}
		else
		{
			bool ComponentCreated;
			UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(MeshComp, out ComponentCreated, AttachPointName, FVector.ZeroVector, EAttachLocation.KeepRelativeOffset);
			if (akComponent != null)
			{
				FOnAkPostEventCallback postEventCallback = new FOnAkPostEventCallback();
				num = akComponent.PostAkEvent(AkEvent, 0, postEventCallback, EventName);
			}
		}
		if (num != -1)
		{
			UAkGameplayStatics.SetRTPCValueByPlayingID(num, UBGWFunctionLibraryCS.CanCharacterTriggerMotion(Owner) ? 1 : 0, B1GlobalFNames.MotionSwitch);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSAkEvent:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSAkEvent bAN_GSAkEvent = GCHelper.Find<b1.BAN_GSAkEvent>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSAkEvent.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSAkEvent:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSAkEvent bAN_GSAkEvent = GCHelper.Find<b1.BAN_GSAkEvent>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bAN_GSAkEvent.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSAkEvent:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSAkEvent bAN_GSAkEvent = GCHelper.Find<b1.BAN_GSAkEvent>(obj);
		bool value = bAN_GSAkEvent.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSAkEvent");
		NativeReflection.GetPropertyRef(ref CanHandleStopRequest_PropertyAddress, intPtr, "CanHandleStopRequest");
		CanHandleStopRequest_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanHandleStopRequest");
		CanHandleStopRequest_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanHandleStopRequest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PlaySubtitle_PropertyAddress, intPtr, "PlaySubtitle");
		PlaySubtitle_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlaySubtitle");
		PlaySubtitle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlaySubtitle", Classes.FBoolProperty);
		AttachPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachPointName");
		AttachPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachPointName", Classes.FStrProperty);
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FSoftObjectProperty);
		AkStopEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkStopEvent");
		AkStopEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkStopEvent", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref Follow_PropertyAddress, intPtr, "Follow");
		Follow_Offset = NativeReflection.GetPropertyOffset(intPtr, "Follow");
		Follow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Follow", Classes.FBoolProperty);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FStrProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSAkEvent:GSNotifyCS", GSNotifyCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSAkEvent:GetSoftReferences", GetSoftReferences_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSAkEvent:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSAkEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSAkEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSAkEvent));
	}
}
