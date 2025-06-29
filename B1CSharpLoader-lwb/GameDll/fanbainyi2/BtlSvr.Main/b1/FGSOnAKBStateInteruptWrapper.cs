using System;
using b1.Plugins.GSAnimationKeyBlender;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FGSOnAKBStateInteruptWrapper")]
public class FGSOnAKBStateInteruptWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_BeginStateName_IsValid;

	private static int callback_BeginStateName_Offset;

	private static bool callback_EndStateName_IsValid;

	private static int callback_EndStateName_Offset;

	private static bool callback_IsFromForceSetStateImmediately_IsValid;

	private static int callback_IsFromForceSetStateImmediately_Offset;

	private static FFieldAddress callback_IsFromForceSetStateImmediately_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new FGSOnAKBStateInterupt.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FGSOnAKBStateInteruptWrapper:callback")]
	private void callback(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		((FGSOnAKBStateInterupt.Signature)_action)(BeginStateName, EndStateName, IsFromForceSetStateImmediately);
	}

	[UFunctionInvoker("/Script/b1-Managed.FGSOnAKBStateInteruptWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FGSOnAKBStateInteruptWrapper fGSOnAKBStateInteruptWrapper = GCHelper.Find<FGSOnAKBStateInteruptWrapper>(obj);
		FName beginStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, callback_BeginStateName_Offset));
		FName endStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, callback_EndStateName_Offset));
		bool isFromForceSetStateImmediately = BoolMarshaler.FromNative(IntPtr.Add(buffer, callback_IsFromForceSetStateImmediately_Offset), 0, callback_IsFromForceSetStateImmediately_PropertyAddress.Address);
		fGSOnAKBStateInteruptWrapper.callback(beginStateName, endStateName, isFromForceSetStateImmediately);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FGSOnAKBStateInteruptWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_BeginStateName_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "BeginStateName");
		callback_BeginStateName_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "BeginStateName", Classes.FNameProperty);
		callback_EndStateName_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "EndStateName");
		callback_EndStateName_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "EndStateName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref callback_IsFromForceSetStateImmediately_PropertyAddress, callback_FunctionAddress, "IsFromForceSetStateImmediately");
		callback_IsFromForceSetStateImmediately_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "IsFromForceSetStateImmediately");
		callback_IsFromForceSetStateImmediately_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "IsFromForceSetStateImmediately", Classes.FBoolProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_BeginStateName_IsValid && callback_EndStateName_IsValid && callback_IsFromForceSetStateImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FGSOnAKBStateInteruptWrapper:callback", callback_IsValid);
	}

	static FGSOnAKBStateInteruptWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSOnAKBStateInteruptWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSOnAKBStateInteruptWrapper));
	}
}
