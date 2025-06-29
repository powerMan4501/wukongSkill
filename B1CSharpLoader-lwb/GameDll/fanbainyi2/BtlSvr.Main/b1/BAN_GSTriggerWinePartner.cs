using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN_GSTriggerWinePartner")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSTriggerWinePartner")]
internal class BAN_GSTriggerWinePartner : BAN_GSBase
{
	private static bool TriggerId_IsValid;

	private static int TriggerId_Offset;

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

	[DisplayName("泡酒物触发时机")]
	[Category("Item")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerWinePartner:TriggerId")]
	public int TriggerId
	{
		get
		{
			CheckDestroyed();
			if (!TriggerId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerWinePartner:TriggerId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TriggerId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerWinePartner:TriggerId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TriggerId_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerWinePartner:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerWinePartner:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_TriggerWinePartner.Invoke(TriggerId);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerWinePartner:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerWinePartner bAN_GSTriggerWinePartner = GCHelper.Find<b1.BAN_GSTriggerWinePartner>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSTriggerWinePartner.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerWinePartner:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerWinePartner bAN_GSTriggerWinePartner = GCHelper.Find<b1.BAN_GSTriggerWinePartner>(obj);
		bool value = bAN_GSTriggerWinePartner.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSTriggerWinePartner");
		TriggerId_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerId");
		TriggerId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerId", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerWinePartner:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerWinePartner:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSTriggerWinePartner()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSTriggerWinePartner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSTriggerWinePartner));
	}
}
