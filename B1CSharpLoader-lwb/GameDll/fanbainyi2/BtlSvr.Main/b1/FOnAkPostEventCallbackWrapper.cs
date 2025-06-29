using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FOnAkPostEventCallbackWrapper")]
public class FOnAkPostEventCallbackWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_CallbackType_IsValid;

	private static int callback_CallbackType_Offset;

	private static FFieldAddress callback_CallbackType_PropertyAddress;

	private static bool callback_CallbackInfo_IsValid;

	private static int callback_CallbackInfo_Offset;

	public override Delegate GetSignature()
	{
		return new FOnAkPostEventCallback.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FOnAkPostEventCallbackWrapper:callback")]
	private void callback(EAkCallbackType CallbackType, UAkCallbackInfo CallbackInfo)
	{
		((FOnAkPostEventCallback.Signature)_action)(CallbackType, CallbackInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.FOnAkPostEventCallbackWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FOnAkPostEventCallbackWrapper fOnAkPostEventCallbackWrapper = GCHelper.Find<FOnAkPostEventCallbackWrapper>(obj);
		EAkCallbackType callbackType = EnumMarshaler<EAkCallbackType>.FromNative(IntPtr.Add(buffer, callback_CallbackType_Offset), 0, callback_CallbackType_PropertyAddress.Address);
		UAkCallbackInfo callbackInfo = UObjectMarshaler<UAkCallbackInfo>.FromNative(IntPtr.Add(buffer, callback_CallbackInfo_Offset));
		fOnAkPostEventCallbackWrapper.callback(callbackType, callbackInfo);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FOnAkPostEventCallbackWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		NativeReflection.GetPropertyRef(ref callback_CallbackType_PropertyAddress, callback_FunctionAddress, "CallbackType");
		callback_CallbackType_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "CallbackType");
		callback_CallbackType_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "CallbackType", Classes.FEnumProperty);
		callback_CallbackInfo_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "CallbackInfo");
		callback_CallbackInfo_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "CallbackInfo", Classes.FObjectProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_CallbackType_IsValid && callback_CallbackInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FOnAkPostEventCallbackWrapper:callback", callback_IsValid);
	}

	static FOnAkPostEventCallbackWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FOnAkPostEventCallbackWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOnAkPostEventCallbackWrapper));
	}
}
