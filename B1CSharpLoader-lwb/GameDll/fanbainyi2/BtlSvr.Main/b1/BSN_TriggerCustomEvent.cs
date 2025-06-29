using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Trigger Custom Event")]
[UClass]
[USharpPath("/Script/b1-Managed.BSN_TriggerCustomEvent")]
public class BSN_TriggerCustomEvent : UMovieSceneCalliopeNotifySection
{
	private static bool EventTag_IsValid;

	private static int EventTag_Offset;

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

	[UProperty]
	[EditAnywhere]
	[Category("Custom Event")]
	[USharpPath("/Script/b1-Managed.BSN_TriggerCustomEvent:EventTag")]
	public FGameplayTag EventTag
	{
		get
		{
			CheckDestroyed();
			if (!EventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_TriggerCustomEvent:EventTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, EventTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_TriggerCustomEvent:EventTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, EventTag_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_TriggerCustomEvent:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		if (GameplayTagExtension.IsValid(EventTag))
		{
			int movieInstanceIndex = InPlayer.MovieInstanceIndex;
			BGS_EventCollectionCS.Get(playbackContext).Evt_TriggerCustomMovieEvent.Invoke(movieInstanceIndex, EventTag);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_TriggerCustomEvent:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_TriggerCustomEvent bSN_TriggerCustomEvent = GCHelper.Find<BSN_TriggerCustomEvent>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_TriggerCustomEvent.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_TriggerCustomEvent");
		EventTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventTag");
		EventTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventTag", Classes.FStructProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_TriggerCustomEvent:OnNotify", OnNotify_IsValid);
	}

	static BSN_TriggerCustomEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_TriggerCustomEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_TriggerCustomEvent));
	}
}
