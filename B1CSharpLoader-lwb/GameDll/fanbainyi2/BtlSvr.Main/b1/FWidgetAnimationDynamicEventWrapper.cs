using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FWidgetAnimationDynamicEventWrapper")]
public class FWidgetAnimationDynamicEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	public override Delegate GetSignature()
	{
		return new FWidgetAnimationDynamicEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FWidgetAnimationDynamicEventWrapper:callback")]
	private void callback()
	{
		((FWidgetAnimationDynamicEvent.Signature)_action)();
	}

	[UFunctionInvoker("/Script/b1-Managed.FWidgetAnimationDynamicEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FWidgetAnimationDynamicEventWrapper fWidgetAnimationDynamicEventWrapper = GCHelper.Find<FWidgetAnimationDynamicEventWrapper>(obj);
		fWidgetAnimationDynamicEventWrapper.callback();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FWidgetAnimationDynamicEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FWidgetAnimationDynamicEventWrapper:callback", callback_IsValid);
	}

	static FWidgetAnimationDynamicEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FWidgetAnimationDynamicEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWidgetAnimationDynamicEventWrapper));
	}
}
