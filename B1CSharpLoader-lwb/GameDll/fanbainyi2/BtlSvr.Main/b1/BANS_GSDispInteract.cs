using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Disp Interact")]
[USharpPath("/Script/b1-Managed.BANS_GSDispInteract")]
internal class BANS_GSDispInteract : BANS_GSBase
{
	private static bool ExtraInteractBones_IsValid;

	private static int ExtraInteractBones_Offset;

	private static FFieldAddress ExtraInteractBones_PropertyAddress;

	private TArrayReadWriteMarshaler<FBoneUseForDispMap> ExtraInteractBones_Marshaler;

	private static bool OverrideInfo_IsValid;

	private static int OverrideInfo_Offset;

	private static FFieldAddress OverrideInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<DispInteractOverride> OverrideInfo_Marshaler;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("DispInteract")]
	[DisplayName("新增额外交互数据")]
	[USharpPath("/Script/b1-Managed.BANS_GSDispInteract:ExtraInteractBones")]
	public TArrayReadWrite<FBoneUseForDispMap> ExtraInteractBones
	{
		get
		{
			CheckDestroyed();
			if (!ExtraInteractBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDispInteract:ExtraInteractBones");
				return null;
			}
			if (ExtraInteractBones_Marshaler == null)
			{
				ExtraInteractBones_Marshaler = new TArrayReadWriteMarshaler<FBoneUseForDispMap>(1, ExtraInteractBones_PropertyAddress, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.FromNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.ToNative);
			}
			return ExtraInteractBones_Marshaler.FromNative(IntPtr.Add(base.Address, ExtraInteractBones_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DispInteract")]
	[DisplayName("交互数据变化")]
	[USharpPath("/Script/b1-Managed.BANS_GSDispInteract:OverrideInfo")]
	public TArrayReadWrite<DispInteractOverride> OverrideInfo
	{
		get
		{
			CheckDestroyed();
			if (!OverrideInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDispInteract:OverrideInfo");
				return null;
			}
			if (OverrideInfo_Marshaler == null)
			{
				OverrideInfo_Marshaler = new TArrayReadWriteMarshaler<DispInteractOverride>(1, OverrideInfo_PropertyAddress, CachedMarshalingDelegates<DispInteractOverride, DispInteractOverride>.FromNative, CachedMarshalingDelegates<DispInteractOverride, DispInteractOverride>.ToNative);
			}
			return OverrideInfo_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideInfo_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (bUS_GSEventCollection != null)
		{
			if (ExtraInteractBones.Count > 0)
			{
				bUS_GSEventCollection.Evt_RegistExtraInteractBones.Invoke((int)GetUniqueID(), ExtraInteractBones);
			}
			if (OverrideInfo.Count > 0)
			{
				bUS_GSEventCollection.Evt_InteractOverrideBegin.Invoke((int)GetUniqueID(), OverrideInfo);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (bUS_GSEventCollection != null)
		{
			if (ExtraInteractBones.Count > 0)
			{
				bUS_GSEventCollection.Evt_CancelExtraInteractBones.Invoke((int)GetUniqueID());
			}
			if (OverrideInfo.Count > 0)
			{
				bUS_GSEventCollection.Evt_InteractOverrideEnd.Invoke((int)GetUniqueID());
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	private AActor GSGetActorByTag(UWorld World, FName TagName)
	{
		UGameplayStatics.GetAllActorsOfClass(World, UClass.GetClass<AActor>(), out var OutActors);
		foreach (AActor item in OutActors)
		{
			if (item.ActorHasTag(TagName))
			{
				return item;
			}
		}
		return null;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSDispInteract bANS_GSDispInteract = GCHelper.Find<b1.BANS_GSDispInteract>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSDispInteract.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSDispInteract bANS_GSDispInteract = GCHelper.Find<b1.BANS_GSDispInteract>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSDispInteract.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSDispInteract bANS_GSDispInteract = GCHelper.Find<b1.BANS_GSDispInteract>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSDispInteract.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSDispInteract");
		NativeReflection.GetPropertyRef(ref ExtraInteractBones_PropertyAddress, intPtr, "ExtraInteractBones");
		ExtraInteractBones_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtraInteractBones");
		ExtraInteractBones_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtraInteractBones", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideInfo_PropertyAddress, intPtr, "OverrideInfo");
		OverrideInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideInfo");
		OverrideInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideInfo", Classes.FArrayProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDispInteract:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSDispInteract()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSDispInteract)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSDispInteract));
	}
}
