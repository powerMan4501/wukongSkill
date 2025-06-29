using System;
using b1.Plugins.Calliope;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Tooltip("仅UI表演")]
[DisplayName("GainItemDisplay")]
[USharpPath("/Script/b1-Managed.BSN_GainItem")]
public class BSN_GainItem : UMovieSceneCalliopeNotifySection
{
	private static bool ItemId_IsValid;

	private static int ItemId_Offset;

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

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BSN_GainItem:ItemId")]
	public int ItemId
	{
		get
		{
			CheckDestroyed();
			if (!ItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_GainItem:ItemId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSN_GainItem:ItemId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemId_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSN_GainItem:OnNotify")]
	protected override void OnNotify_Implementation(UCalliopeLevelSequencePlayer InPlayer, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = InPlayer.GetPlaybackContext();
		UGameplayStatics.GetPlayerCharacter(playbackContext, 0);
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(playbackContext);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_ShowDropMainSpacial(new ItemOne
			{
				Id = ItemId,
				Num = 1
			});
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSN_GainItem:OnNotify")]
	private static void OnNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSN_GainItem bSN_GainItem = GCHelper.Find<BSN_GainItem>(obj);
		UCalliopeLevelSequencePlayer inPlayer = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotify_InPlayer_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotify_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotify_bInBackwards_Offset), 0, OnNotify_bInBackwards_PropertyAddress.Address);
		bSN_GainItem.OnNotify_Implementation(inPlayer, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSN_GainItem");
		ItemId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemId");
		ItemId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemId", Classes.FIntProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSN_GainItem:OnNotify", OnNotify_IsValid);
	}

	static BSN_GainItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSN_GainItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSN_GainItem));
	}
}
