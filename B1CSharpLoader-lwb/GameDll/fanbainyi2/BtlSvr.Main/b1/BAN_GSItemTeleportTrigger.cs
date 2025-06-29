using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN GSItemTeleportTrigger")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSItemTeleportTrigger")]
internal class BAN_GSItemTeleportTrigger : BAN_GSBase
{
	private static bool ItemTeleportType_IsValid;

	private static int ItemTeleportType_Offset;

	private static FFieldAddress ItemTeleportType_PropertyAddress;

	private static bool TargetRebirthPointId_IsValid;

	private static int TargetRebirthPointId_Offset;

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

	[Category("ItemTeleport")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSItemTeleportTrigger:ItemTeleportType")]
	public BANItemTeleportType ItemTeleportType
	{
		get
		{
			CheckDestroyed();
			if (!ItemTeleportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSItemTeleportTrigger:ItemTeleportType");
				return BANItemTeleportType.TeleportTargetRebirthPointId;
			}
			return EnumMarshaler<BANItemTeleportType>.FromNative(IntPtr.Add(base.Address, ItemTeleportType_Offset), 0, ItemTeleportType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ItemTeleportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSItemTeleportTrigger:ItemTeleportType");
			}
			else
			{
				EnumMarshaler<BANItemTeleportType>.ToNative(IntPtr.Add(base.Address, ItemTeleportType_Offset), 0, ItemTeleportType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("ItemTeleport")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSItemTeleportTrigger:TargetRebirthPointId")]
	public int TargetRebirthPointId
	{
		get
		{
			CheckDestroyed();
			if (!TargetRebirthPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSItemTeleportTrigger:TargetRebirthPointId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetRebirthPointId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetRebirthPointId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSItemTeleportTrigger:TargetRebirthPointId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetRebirthPointId_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSItemTeleportTrigger:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSItemTeleportTrigger:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_GSItemTeleportTrigger.Invoke(ItemTeleportType, TargetRebirthPointId);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSItemTeleportTrigger:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSItemTeleportTrigger bAN_GSItemTeleportTrigger = GCHelper.Find<b1.BAN_GSItemTeleportTrigger>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSItemTeleportTrigger.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSItemTeleportTrigger:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSItemTeleportTrigger bAN_GSItemTeleportTrigger = GCHelper.Find<b1.BAN_GSItemTeleportTrigger>(obj);
		bool value = bAN_GSItemTeleportTrigger.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSItemTeleportTrigger");
		NativeReflection.GetPropertyRef(ref ItemTeleportType_PropertyAddress, intPtr, "ItemTeleportType");
		ItemTeleportType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemTeleportType");
		ItemTeleportType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemTeleportType", Classes.FEnumProperty);
		TargetRebirthPointId_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetRebirthPointId");
		TargetRebirthPointId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetRebirthPointId", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSItemTeleportTrigger:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSItemTeleportTrigger:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSItemTeleportTrigger()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSItemTeleportTrigger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSItemTeleportTrigger));
	}
}
