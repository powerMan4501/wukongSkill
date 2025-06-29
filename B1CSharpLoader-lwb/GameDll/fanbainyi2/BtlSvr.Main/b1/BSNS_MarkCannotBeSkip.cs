using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("标记不可跳过段")]
[USharpPath("/Script/b1-Managed.BSNS_MarkCannotBeSkip")]
internal class BSNS_MarkCannotBeSkip : UMovieSceneCalliopeNotifyStateSection
{
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

	[USharpPath("/Script/b1-Managed.BSNS_MarkCannotBeSkip:OnNotifyBegin")]
	protected override void OnNotifyBegin_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		BGS_EventCollectionCS.Get(InPlayer.GetPlaybackContext()).Evt_MarkMovieCanBeSkipped.Invoke(InPlayer.MovieInstanceIndex, P2: false);
	}

	[USharpPath("/Script/b1-Managed.BSNS_MarkCannotBeSkip:OnNotifyEnd")]
	protected override void OnNotifyEnd_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		BGS_EventCollectionCS.Get(InPlayer.GetPlaybackContext()).Evt_MarkMovieCanBeSkipped.Invoke(InPlayer.MovieInstanceIndex, P2: true);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_MarkCannotBeSkip:OnNotifyEnd")]
	private static void OnNotifyEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSNS_MarkCannotBeSkip bSNS_MarkCannotBeSkip = GCHelper.Find<b1.BSNS_MarkCannotBeSkip>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyEnd_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyEnd_bInBackwards_Offset), 0, OnNotifyEnd_bInBackwards_PropertyAddress.Address);
		bSNS_MarkCannotBeSkip.OnNotifyEnd_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_MarkCannotBeSkip:OnNotifyBegin")]
	private static void OnNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BSNS_MarkCannotBeSkip bSNS_MarkCannotBeSkip = GCHelper.Find<b1.BSNS_MarkCannotBeSkip>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_MarkCannotBeSkip.OnNotifyBegin_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BSNS_MarkCannotBeSkip");
		OnNotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNotifyEnd");
		OnNotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyEnd_FunctionAddress);
		OnNotifyEnd_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InPlayer");
		OnNotifyEnd_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotifyEnd_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "InStatus");
		OnNotifyEnd_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyEnd_bInBackwards_PropertyAddress, OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyEnd_FunctionAddress, "bInBackwards");
		OnNotifyEnd_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyEnd_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyEnd_IsValid = OnNotifyEnd_FunctionAddress != IntPtr.Zero && OnNotifyEnd_InPlayer_IsValid && OnNotifyEnd_InStatus_IsValid && OnNotifyEnd_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_MarkCannotBeSkip:OnNotifyEnd", OnNotifyEnd_IsValid);
		OnNotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNotifyBegin");
		OnNotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyBegin_FunctionAddress);
		OnNotifyBegin_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InPlayer");
		OnNotifyBegin_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotifyBegin_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InStatus");
		OnNotifyBegin_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyBegin_bInBackwards_PropertyAddress, OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyBegin_IsValid = OnNotifyBegin_FunctionAddress != IntPtr.Zero && OnNotifyBegin_InPlayer_IsValid && OnNotifyBegin_InStatus_IsValid && OnNotifyBegin_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_MarkCannotBeSkip:OnNotifyBegin", OnNotifyBegin_IsValid);
	}

	static BSNS_MarkCannotBeSkip()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BSNS_MarkCannotBeSkip)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BSNS_MarkCannotBeSkip));
	}
}
