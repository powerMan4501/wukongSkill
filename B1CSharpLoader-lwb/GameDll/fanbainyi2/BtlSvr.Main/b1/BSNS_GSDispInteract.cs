using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Disp Interact")]
[UClass]
[USharpPath("/Script/b1-Managed.BSNS_GSDispInteract")]
public class BSNS_GSDispInteract : UMovieSceneCalliopeNotifyStateSection
{
	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool ExtraInteractBones_IsValid;

	private static int ExtraInteractBones_Offset;

	private static FFieldAddress ExtraInteractBones_PropertyAddress;

	private TArrayReadWriteMarshaler<FBoneUseForDispMap> ExtraInteractBones_Marshaler;

	private static bool OverrideInfo_IsValid;

	private static int OverrideInfo_Offset;

	private static FFieldAddress OverrideInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<DispInteractOverride> OverrideInfo_Marshaler;

	private static bool OnNotifyEnd_IsValid;

	private static IntPtr OnNotifyEnd_FunctionAddress;

	private static int OnNotifyEnd_ParamsSize;

	private static bool OnNotifyEnd_InPlayer_IsValid;

	private static int OnNotifyEnd_InPlayer_Offset;

	private static bool OnNotifyEnd_InStatus_IsValid;

	private static int OnNotifyEnd_InStatus_Offset;

	private static bool OnNotifyEnd_bInBackwards_IsValid;

	private static int OnNotifyEnd_bInBackwards_Offset;

	private static FFieldAddress OnNotifyEnd_bInBackwards_PropertyAddress;

	private static bool OnNotifyBegin_IsValid;

	private static IntPtr OnNotifyBegin_FunctionAddress;

	private static int OnNotifyBegin_ParamsSize;

	private static bool OnNotifyBegin_InPlayer_IsValid;

	private static int OnNotifyBegin_InPlayer_Offset;

	private static bool OnNotifyBegin_InStatus_IsValid;

	private static int OnNotifyBegin_InStatus_Offset;

	private static bool OnNotifyBegin_bInBackwards_IsValid;

	private static int OnNotifyBegin_bInBackwards_Offset;

	private static FFieldAddress OnNotifyBegin_bInBackwards_PropertyAddress;

	[UProperty]
	[EditDefaultsOnly]
	[Category("DispInteract")]
	[USharpPath("/Script/b1-Managed.BSNS_GSDispInteract:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_GSDispInteract:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_GSDispInteract:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[DisplayName("新增额外交互数据")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("DispInteract")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSNS_GSDispInteract:ExtraInteractBones")]
	public TArrayReadWrite<FBoneUseForDispMap> ExtraInteractBones
	{
		get
		{
			CheckDestroyed();
			if (!ExtraInteractBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_GSDispInteract:ExtraInteractBones");
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
	[USharpPath("/Script/b1-Managed.BSNS_GSDispInteract:OverrideInfo")]
	public TArrayReadWrite<DispInteractOverride> OverrideInfo
	{
		get
		{
			CheckDestroyed();
			if (!OverrideInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_GSDispInteract:OverrideInfo");
				return null;
			}
			if (OverrideInfo_Marshaler == null)
			{
				OverrideInfo_Marshaler = new TArrayReadWriteMarshaler<DispInteractOverride>(1, OverrideInfo_PropertyAddress, CachedMarshalingDelegates<DispInteractOverride, DispInteractOverride>.FromNative, CachedMarshalingDelegates<DispInteractOverride, DispInteractOverride>.ToNative);
			}
			return OverrideInfo_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideInfo_Offset));
		}
	}

	private BGUCharacterCS Unit { get; set; }

	[USharpPath("/Script/b1-Managed.BSNS_GSDispInteract:OnNotifyBegin")]
	protected override void OnNotifyBegin_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		Unit = BGU_DataUtil.GetActorByGuid(playbackContext, UnitGuid.TagName.PlainName) as BGUCharacterCS;
		if (Unit.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
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

	[USharpPath("/Script/b1-Managed.BSNS_GSDispInteract:OnNotifyEnd")]
	protected override void OnNotifyEnd_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		if (Unit.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
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

	[UFunctionInvoker("/Script/b1-Managed.BSNS_GSDispInteract:OnNotifyEnd")]
	private static void OnNotifyEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_GSDispInteract bSNS_GSDispInteract = GCHelper.Find<BSNS_GSDispInteract>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyEnd_bInBackwards_Offset), 0, OnNotifyEnd_bInBackwards_PropertyAddress.Address);
		bSNS_GSDispInteract.OnNotifyEnd_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_GSDispInteract:OnNotifyBegin")]
	private static void OnNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_GSDispInteract bSNS_GSDispInteract = GCHelper.Find<BSNS_GSDispInteract>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_GSDispInteract.OnNotifyBegin_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSNS_GSDispInteract");
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ExtraInteractBones_PropertyAddress, intPtr, "ExtraInteractBones");
		ExtraInteractBones_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtraInteractBones");
		ExtraInteractBones_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtraInteractBones", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideInfo_PropertyAddress, intPtr, "OverrideInfo");
		OverrideInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideInfo");
		OverrideInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideInfo", Classes.FArrayProperty);
		OnNotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyEnd");
		OnNotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyEnd_FunctionAddress);
		OnNotifyEnd_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InPlayer");
		OnNotifyEnd_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotifyEnd_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InStatus");
		OnNotifyEnd_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyEnd_bInBackwards_PropertyAddress, OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyEnd_IsValid = OnNotifyEnd_FunctionAddress != IntPtr.Zero && OnNotifyEnd_InPlayer_IsValid && OnNotifyEnd_InStatus_IsValid && OnNotifyEnd_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_GSDispInteract:OnNotifyEnd", OnNotifyEnd_IsValid);
		OnNotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyBegin");
		OnNotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyBegin_FunctionAddress);
		OnNotifyBegin_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InPlayer");
		OnNotifyBegin_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotifyBegin_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InStatus");
		OnNotifyBegin_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyBegin_bInBackwards_PropertyAddress, OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyBegin_IsValid = OnNotifyBegin_FunctionAddress != IntPtr.Zero && OnNotifyBegin_InPlayer_IsValid && OnNotifyBegin_InStatus_IsValid && OnNotifyBegin_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_GSDispInteract:OnNotifyBegin", OnNotifyBegin_IsValid);
	}

	static BSNS_GSDispInteract()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSNS_GSDispInteract)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSNS_GSDispInteract));
	}
}
