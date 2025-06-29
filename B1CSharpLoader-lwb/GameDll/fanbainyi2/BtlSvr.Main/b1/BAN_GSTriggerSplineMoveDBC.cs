using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Trigger Spline Move DBC")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSTriggerSplineMoveDBC")]
internal class BAN_GSTriggerSplineMoveDBC : BAN_GSBase
{
	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerSplineMoveDBC:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null)
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_TriggerSplineMoveDBC.Invoke();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerSplineMoveDBC:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerSplineMoveDBC bAN_GSTriggerSplineMoveDBC = GCHelper.Find<b1.BAN_GSTriggerSplineMoveDBC>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSTriggerSplineMoveDBC.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSTriggerSplineMoveDBC");
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerSplineMoveDBC:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSTriggerSplineMoveDBC()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSTriggerSplineMoveDBC)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSTriggerSplineMoveDBC));
	}
}
