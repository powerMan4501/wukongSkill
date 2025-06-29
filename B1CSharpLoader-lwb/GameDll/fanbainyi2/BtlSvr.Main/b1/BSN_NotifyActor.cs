using System;
using b1.CppExport;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Notify Actor")]
[USharpPath("/Script/b1-Managed.BSN_NotifyActor")]
public class BSN_NotifyActor : UMovieSceneCalliopeNotifySection
{
	private static bool NotifyActorGuid_IsValid;

	private static int NotifyActorGuid_Offset;

	private static bool NotifyTags_IsValid;

	private static int NotifyTags_Offset;

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

	[UProperty]
	[EditAnywhere]
	[Category("NotifyActor")]
	[USharpPath("/Script/b1-Managed.BSN_NotifyActor:NotifyActorGuid")]
	public FGameplayTag NotifyActorGuid
	{
		get
		{
			CheckDestroyed();
			if (!NotifyActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_NotifyActor:NotifyActorGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, NotifyActorGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_NotifyActor:NotifyActorGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, NotifyActorGuid_Offset), value);
			}
		}
	}

	[Category("NotifyActor")]
	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BSN_NotifyActor:NotifyTags")]
	public FGameplayTagContainer NotifyTags
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_NotifyActor:NotifyTags");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, NotifyTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_NotifyActor:NotifyTags");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, NotifyTags_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_NotifyActor:OnPreviewNotify")]
	protected override void OnPreviewNotify_Implementation(UObject InPlaybackContext, int InStatus, bool bInBackwards)
	{
	}

	[USharpPath("/Script/b1-Managed.BSN_NotifyActor:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		string plainName = NotifyActorGuid.TagName.PlainName;
		BGUActorBaseCS bGUActorBaseCS = BGU_DataUtil.GetActorByGuid(playbackContext, plainName) as BGUActorBaseCS;
		if (bGUActorBaseCS == null)
		{
			foreach (FGameplayTag gameplayTag in NotifyTags.GameplayTags)
			{
				BGW_EventCollection.Get(this).Evt_SaveSceneObjEvent(plainName, gameplayTag);
			}
			return;
		}
		BUS_EventCollectionCS.Get(bGUActorBaseCS).Evt_NotifyFromGraph.Invoke(new GameplayTagContainerRef(NotifyTags));
		foreach (FGameplayTag gameplayTag2 in NotifyTags.GameplayTags)
		{
			BUS_EventCollectionCS.Get(bGUActorBaseCS).Evt_SceneObjTransitByEvent.Invoke(gameplayTag2);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_NotifyActor:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_NotifyActor bSN_NotifyActor = GCHelper.Find<BSN_NotifyActor>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_NotifyActor.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_NotifyActor:OnPreviewNotify")]
	private static void OnPreviewNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_NotifyActor bSN_NotifyActor = GCHelper.Find<BSN_NotifyActor>(obj);
		UObject inPlaybackContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, OnPreviewNotify_InPlaybackContext_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnPreviewNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnPreviewNotify_bInBackwards_Offset), 0, OnPreviewNotify_bInBackwards_PropertyAddress.Address);
		bSN_NotifyActor.OnPreviewNotify_Implementation(inPlaybackContext, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_NotifyActor");
		NotifyActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyActorGuid");
		NotifyActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyActorGuid", Classes.FStructProperty);
		NotifyTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyTags");
		NotifyTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyTags", Classes.FStructProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_NotifyActor:OnNotify", OnNotify_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_NotifyActor:OnPreviewNotify", OnPreviewNotify_IsValid);
	}

	static BSN_NotifyActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_NotifyActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_NotifyActor));
	}
}
