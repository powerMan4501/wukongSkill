using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("ForceTrigger")]
[USharpPath("/Script/b1-Managed.BSN_ForceTrigger")]
public class BSN_ForceTrigger : UMovieSceneCalliopeNotifySection
{
	private static bool TriggerActorGuid_IsValid;

	private static int TriggerActorGuid_Offset;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BSN_ForceTrigger:TriggerActorGuid")]
	public FGameplayTag TriggerActorGuid
	{
		get
		{
			CheckDestroyed();
			if (!TriggerActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_ForceTrigger:TriggerActorGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, TriggerActorGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_ForceTrigger:TriggerActorGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, TriggerActorGuid_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_ForceTrigger:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		string plainName = TriggerActorGuid.TagName.PlainName;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(playbackContext, plainName);
		if (actorByGuid != null)
		{
			APawn playerPawn = UGameplayStatics.GetPlayerPawn(playbackContext, 0);
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_ForceTrigger.Invoke(playerPawn);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_ForceTrigger:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_ForceTrigger bSN_ForceTrigger = GCHelper.Find<BSN_ForceTrigger>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_ForceTrigger.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_ForceTrigger");
		TriggerActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerActorGuid");
		TriggerActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerActorGuid", Classes.FStructProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_ForceTrigger:OnNotify", OnNotify_IsValid);
	}

	static BSN_ForceTrigger()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_ForceTrigger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_ForceTrigger));
	}
}
