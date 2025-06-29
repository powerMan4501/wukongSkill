using System;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN HandleBattleMessage")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSHandleBattleMessage")]
internal class BANS_GSHandleBattleMessage : BAN_GSBase
{
	private static bool BattleMessage_IsValid;

	private static int BattleMessage_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSHandleBattleMessage:BattleMessage")]
	public FGameplayTag BattleMessage
	{
		get
		{
			CheckDestroyed();
			if (!BattleMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHandleBattleMessage:BattleMessage");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, BattleMessage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHandleBattleMessage:BattleMessage");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, BattleMessage_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSHandleBattleMessage:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSHandleBattleMessage:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (bUS_GSEventCollection != null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.CSGDebug, $"<character>{owner.GetName().ConvertLongGuid2DisplayGuid()}</><effect>【CSGDEBUG】</><action> 通过AMNotify发起了BattleMessage </><effectnum>{BattleMessage.TagName}</>");
			}
			bUS_GSEventCollection.Evt_HandleBattleMessage.Invoke(BattleMessage);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSHandleBattleMessage:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSHandleBattleMessage bANS_GSHandleBattleMessage = GCHelper.Find<b1.BANS_GSHandleBattleMessage>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bANS_GSHandleBattleMessage.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSHandleBattleMessage:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSHandleBattleMessage bANS_GSHandleBattleMessage = GCHelper.Find<b1.BANS_GSHandleBattleMessage>(obj);
		bool value = bANS_GSHandleBattleMessage.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSHandleBattleMessage");
		BattleMessage_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleMessage");
		BattleMessage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleMessage", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSHandleBattleMessage:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSHandleBattleMessage:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BANS_GSHandleBattleMessage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSHandleBattleMessage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSHandleBattleMessage));
	}
}
