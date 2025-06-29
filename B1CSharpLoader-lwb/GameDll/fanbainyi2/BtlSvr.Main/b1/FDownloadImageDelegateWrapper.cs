using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FDownloadImageDelegateWrapper")]
public class FDownloadImageDelegateWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_Texture_IsValid;

	private static int callback_Texture_Offset;

	public override Delegate GetSignature()
	{
		return new FDownloadImageDelegate.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FDownloadImageDelegateWrapper:callback")]
	private void callback(UTexture2DDynamic Texture)
	{
		((FDownloadImageDelegate.Signature)_action)(Texture);
	}

	[UFunctionInvoker("/Script/b1-Managed.FDownloadImageDelegateWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FDownloadImageDelegateWrapper fDownloadImageDelegateWrapper = GCHelper.Find<FDownloadImageDelegateWrapper>(obj);
		UTexture2DDynamic texture = UObjectMarshaler<UTexture2DDynamic>.FromNative(IntPtr.Add(buffer, callback_Texture_Offset));
		fDownloadImageDelegateWrapper.callback(texture);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FDownloadImageDelegateWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_Texture_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "Texture");
		callback_Texture_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "Texture", Classes.FObjectProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FDownloadImageDelegateWrapper:callback", callback_IsValid);
	}

	static FDownloadImageDelegateWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDownloadImageDelegateWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDownloadImageDelegateWrapper));
	}
}
