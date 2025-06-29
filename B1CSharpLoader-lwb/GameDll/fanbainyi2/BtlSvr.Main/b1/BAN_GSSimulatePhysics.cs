using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN SimulatePhysics")]
[USharpPath("/Script/b1-Managed.BAN_GSSimulatePhysics")]
internal class BAN_GSSimulatePhysics : BAN_GSBase
{
	private static bool PhysicsSimulateEnable_IsValid;

	private static int PhysicsSimulateEnable_Offset;

	private static FFieldAddress PhysicsSimulateEnable_PropertyAddress;

	private static bool IncludeChildren_IsValid;

	private static int IncludeChildren_Offset;

	private static FFieldAddress IncludeChildren_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[Tooltip("是否开启物理模拟")]
	[DisplayName("开启物理模拟")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSimulatePhysics:PhysicsSimulateEnable")]
	public bool PhysicsSimulateEnable
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsSimulateEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSimulatePhysics:PhysicsSimulateEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PhysicsSimulateEnable_Offset), 0, PhysicsSimulateEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsSimulateEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSimulatePhysics:PhysicsSimulateEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PhysicsSimulateEnable_Offset), 0, PhysicsSimulateEnable_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("包含子物体")]
	[Tooltip("是否包含子物体")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSimulatePhysics:IncludeChildren")]
	public bool IncludeChildren
	{
		get
		{
			CheckDestroyed();
			if (!IncludeChildren_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSimulatePhysics:IncludeChildren");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeChildren_Offset), 0, IncludeChildren_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeChildren_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSimulatePhysics:IncludeChildren");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeChildren_Offset), 0, IncludeChildren_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSimulatePhysics:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSimulatePhysics:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSimulatePhysics bAN_GSSimulatePhysics = GCHelper.Find<b1.BAN_GSSimulatePhysics>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSimulatePhysics.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSimulatePhysics");
		NativeReflection.GetPropertyRef(ref PhysicsSimulateEnable_PropertyAddress, intPtr, "PhysicsSimulateEnable");
		PhysicsSimulateEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicsSimulateEnable");
		PhysicsSimulateEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicsSimulateEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IncludeChildren_PropertyAddress, intPtr, "IncludeChildren");
		IncludeChildren_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncludeChildren");
		IncludeChildren_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncludeChildren", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSimulatePhysics:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSSimulatePhysics()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSSimulatePhysics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSSimulatePhysics));
	}
}
