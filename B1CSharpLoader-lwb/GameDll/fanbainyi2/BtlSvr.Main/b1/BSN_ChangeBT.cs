using System;
using b1.Plugins.Calliope;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("ChangeBT")]
[USharpPath("/Script/b1-Managed.BSN_ChangeBT")]
public class BSN_ChangeBT : UMovieSceneCalliopeNotifySection
{
	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool BehaviorTree_IsValid;

	private static int BehaviorTree_Offset;

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
	[Category("ChangeBT")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BSN_ChangeBT:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_ChangeBT:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_ChangeBT:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("ChangeBT")]
	[USharpPath("/Script/b1-Managed.BSN_ChangeBT:BehaviorTree")]
	public UBehaviorTree BehaviorTree
	{
		get
		{
			CheckDestroyed();
			if (!BehaviorTree_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_ChangeBT:BehaviorTree");
				return null;
			}
			return UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(base.Address, BehaviorTree_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BehaviorTree_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_ChangeBT:BehaviorTree");
			}
			else
			{
				UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(base.Address, BehaviorTree_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_ChangeBT:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		string plainName = UnitGuid.TagName.PlainName;
		BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(playbackContext, plainName) as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetBT.Invoke(BehaviorTree);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_ChangeBT:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_ChangeBT bSN_ChangeBT = GCHelper.Find<BSN_ChangeBT>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_ChangeBT.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_ChangeBT");
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
		BehaviorTree_Offset = NativeReflection.GetPropertyOffset(intPtr, "BehaviorTree");
		BehaviorTree_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BehaviorTree", Classes.FObjectProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_ChangeBT:OnNotify", OnNotify_IsValid);
	}

	static BSN_ChangeBT()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_ChangeBT)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_ChangeBT));
	}
}
