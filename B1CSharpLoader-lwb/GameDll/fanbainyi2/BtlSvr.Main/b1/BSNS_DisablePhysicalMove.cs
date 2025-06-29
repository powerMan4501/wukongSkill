using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Disable Physical Move")]
[USharpPath("/Script/b1-Managed.BSNS_DisablePhysicalMove")]
public class BSNS_DisablePhysicalMove : UMovieSceneCalliopeNotifyStateSection
{
	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

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

	[EditDefaultsOnly]
	[UProperty]
	[Category("DisablePhysicalMove")]
	[USharpPath("/Script/b1-Managed.BSNS_DisablePhysicalMove:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_DisablePhysicalMove:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_DisablePhysicalMove:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	private AActor Unit { get; set; }

	[USharpPath("/Script/b1-Managed.BSNS_DisablePhysicalMove:OnNotifyBegin")]
	protected override void OnNotifyBegin_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		Unit = BGU_DataUtil.GetActorByGuid(playbackContext, UnitGuid.TagName.PlainName);
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit)?.Evt_DisablePhysicalMove.Invoke(P1: true);
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_DisablePhysicalMove:OnNotifyEnd")]
	protected override void OnNotifyEnd_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		if (!(Unit == null))
		{
			BUS_EventCollectionCS.Get(Unit)?.Evt_DisablePhysicalMove.Invoke(P1: false);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_DisablePhysicalMove:OnNotifyEnd")]
	private static void OnNotifyEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_DisablePhysicalMove bSNS_DisablePhysicalMove = GCHelper.Find<BSNS_DisablePhysicalMove>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyEnd_bInBackwards_Offset), 0, OnNotifyEnd_bInBackwards_PropertyAddress.Address);
		bSNS_DisablePhysicalMove.OnNotifyEnd_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_DisablePhysicalMove:OnNotifyBegin")]
	private static void OnNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_DisablePhysicalMove bSNS_DisablePhysicalMove = GCHelper.Find<BSNS_DisablePhysicalMove>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_DisablePhysicalMove.OnNotifyBegin_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSNS_DisablePhysicalMove");
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_DisablePhysicalMove:OnNotifyEnd", OnNotifyEnd_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_DisablePhysicalMove:OnNotifyBegin", OnNotifyBegin_IsValid);
	}

	static BSNS_DisablePhysicalMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSNS_DisablePhysicalMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSNS_DisablePhysicalMove));
	}
}
