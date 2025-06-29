using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN GSTrigger CostItem")]
[USharpPath("/Script/b1-Managed.BAN_GSTriggerCostItem")]
internal class BAN_GSTriggerCostItem : BAN_GSBase
{
	private static bool UseHulu_IsValid;

	private static int UseHulu_Offset;

	private static FFieldAddress UseHulu_PropertyAddress;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Item")]
	[UProperty]
	[DisplayName("使用葫芦")]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerCostItem:UseHulu")]
	public bool UseHulu
	{
		get
		{
			CheckDestroyed();
			if (!UseHulu_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerCostItem:UseHulu");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseHulu_Offset), 0, UseHulu_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseHulu_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerCostItem:UseHulu");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseHulu_Offset), 0, UseHulu_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerCostItem:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerCostItem:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (!(bUS_GSEventCollection == null))
		{
			if (UseHulu)
			{
				bUS_GSEventCollection.Evt_TriggerHuluEffect.Invoke();
			}
			else
			{
				bUS_GSEventCollection.Evt_TriggerCostItem.Invoke();
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerCostItem:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerCostItem bAN_GSTriggerCostItem = GCHelper.Find<b1.BAN_GSTriggerCostItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSTriggerCostItem.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerCostItem:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerCostItem bAN_GSTriggerCostItem = GCHelper.Find<b1.BAN_GSTriggerCostItem>(obj);
		bool value = bAN_GSTriggerCostItem.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSTriggerCostItem");
		NativeReflection.GetPropertyRef(ref UseHulu_PropertyAddress, intPtr, "UseHulu");
		UseHulu_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseHulu");
		UseHulu_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseHulu", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerCostItem:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerCostItem:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSTriggerCostItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSTriggerCostItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSTriggerCostItem));
	}
}
