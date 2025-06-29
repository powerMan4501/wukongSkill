using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnPointerEventWrapper")]
public class FOnPointerEventWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_Geometry_IsValid;

	private static int callback_Geometry_Offset;

	private static FFieldAddress callback_Geometry_PropertyAddress;

	private static bool callback_PointerEvent_IsValid;

	private static int callback_PointerEvent_Offset;

	private static FFieldAddress callback_PointerEvent_PropertyAddress;

	private static bool callback_ReturnValue_IsValid;

	private static int callback_ReturnValue_Offset;

	private static FFieldAddress callback_ReturnValue_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new UWidget.FOnPointerEvent.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnPointerEventWrapper:callback")]
	private FEventReply callback(FGeometry Geometry, FPointerEvent PointerEvent)
	{
		return ((UWidget.FOnPointerEvent.Signature)_action)(Geometry, PointerEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnPointerEventWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnPointerEventWrapper fOnPointerEventWrapper = GCHelper.Find<FOnPointerEventWrapper>(obj);
		FGeometry geometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, callback_Geometry_Offset));
		FPointerEvent pointerEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, callback_PointerEvent_Offset));
		FEventReply value = fOnPointerEventWrapper.callback(geometry, pointerEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, callback_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnPointerEventWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref callback_Geometry_PropertyAddress, callback_FunctionAddress, "Geometry");
		callback_Geometry_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "Geometry");
		callback_Geometry_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref callback_PointerEvent_PropertyAddress, callback_FunctionAddress, "PointerEvent");
		callback_PointerEvent_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "PointerEvent");
		callback_PointerEvent_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref callback_ReturnValue_PropertyAddress, callback_FunctionAddress, "ReturnValue");
		callback_ReturnValue_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "ReturnValue");
		callback_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_Geometry_IsValid && callback_PointerEvent_IsValid && callback_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnPointerEventWrapper:callback", callback_IsValid);
	}

	static FOnPointerEventWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnPointerEventWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnPointerEventWrapper));
	}
}
