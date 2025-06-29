using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Remove Buff By ID")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSRemoveBuffByID")]
internal class BAN_GSRemoveBuffByID : BAN_GSBase
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool WithTriggerRemmoveEffect_IsValid;

	private static int WithTriggerRemmoveEffect_Offset;

	private static FFieldAddress WithTriggerRemmoveEffect_PropertyAddress;

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

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("需要移除BuffID")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSRemoveBuffByID:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSRemoveBuffByID:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSRemoveBuffByID:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[Tooltip("填写-1，全部层数移除")]
	[DisplayName("需要移除Buff层数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSRemoveBuffByID:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSRemoveBuffByID:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSRemoveBuffByID:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[DisplayName("是否需要触发Remove效果")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("Buff触发类型为EBuffEffectTriggerType.Remove")]
	[USharpPath("/Script/b1-Managed.BAN_GSRemoveBuffByID:WithTriggerRemmoveEffect")]
	public bool WithTriggerRemmoveEffect
	{
		get
		{
			CheckDestroyed();
			if (!WithTriggerRemmoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSRemoveBuffByID:WithTriggerRemmoveEffect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WithTriggerRemmoveEffect_Offset), 0, WithTriggerRemmoveEffect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WithTriggerRemmoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSRemoveBuffByID:WithTriggerRemmoveEffect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WithTriggerRemmoveEffect_Offset), 0, WithTriggerRemmoveEffect_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSRemoveBuffByID:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize();
		WithTriggerRemmoveEffect = true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSRemoveBuffByID:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(BuffID, EBuffEffectTriggerType.None, BuffLayer, WithTriggerRemmoveEffect);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSRemoveBuffByID:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSRemoveBuffByID bAN_GSRemoveBuffByID = GCHelper.Find<b1.BAN_GSRemoveBuffByID>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSRemoveBuffByID.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSRemoveBuffByID:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSRemoveBuffByID bAN_GSRemoveBuffByID = GCHelper.Find<b1.BAN_GSRemoveBuffByID>(obj);
		bool value = bAN_GSRemoveBuffByID.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSRemoveBuffByID");
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref WithTriggerRemmoveEffect_PropertyAddress, intPtr, "WithTriggerRemmoveEffect");
		WithTriggerRemmoveEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "WithTriggerRemmoveEffect");
		WithTriggerRemmoveEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WithTriggerRemmoveEffect", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSRemoveBuffByID:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSRemoveBuffByID:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSRemoveBuffByID()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSRemoveBuffByID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSRemoveBuffByID));
	}
}
