using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("NotifyPlayEnd")]
[USharpPath("/Script/b1-Managed.BSN_NotifyPlayEnd")]
public class BSN_NotifyPlayEnd : UMovieSceneCalliopeNotifySection
{
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

	[USharpPath("/Script/b1-Managed.BSN_NotifyPlayEnd:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		int movieInstanceIndex = InPlayer.MovieInstanceIndex;
		BGS_EventCollectionCS.Get(playbackContext).Evt_CurrentMovieNotifyEnd.Invoke(movieInstanceIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_NotifyPlayEnd:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_NotifyPlayEnd bSN_NotifyPlayEnd = GCHelper.Find<BSN_NotifyPlayEnd>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_NotifyPlayEnd.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BSN_NotifyPlayEnd");
		OnNotify_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNotify");
		OnNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotify_FunctionAddress);
		OnNotify_InPlayer_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InPlayer");
		OnNotify_InPlayer_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InPlayer", Classes.FObjectProperty);
		OnNotify_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "InStatus");
		OnNotify_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotify_bInBackwards_PropertyAddress, OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotify_FunctionAddress, "bInBackwards");
		OnNotify_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotify_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotify_IsValid = OnNotify_FunctionAddress != IntPtr.Zero && OnNotify_InPlayer_IsValid && OnNotify_InStatus_IsValid && OnNotify_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_NotifyPlayEnd:OnNotify", OnNotify_IsValid);
	}

	static BSN_NotifyPlayEnd()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_NotifyPlayEnd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_NotifyPlayEnd));
	}
}
