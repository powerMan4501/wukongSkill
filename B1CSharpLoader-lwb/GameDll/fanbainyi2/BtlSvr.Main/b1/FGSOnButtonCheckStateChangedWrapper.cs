using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.FGSOnButtonCheckStateChangedWrapper")]
public class FGSOnButtonCheckStateChangedWrapper : UILRuntimeDelegateWrapperBase
{
	private static bool callback_IsValid;

	private static IntPtr callback_FunctionAddress;

	private static int callback_ParamsSize;

	private static bool callback_GSID_IsValid;

	private static int callback_GSID_Offset;

	private static bool callback_bIsChecked_IsValid;

	private static int callback_bIsChecked_Offset;

	private static FFieldAddress callback_bIsChecked_PropertyAddress;

	public override Delegate GetSignature()
	{
		return new FGSOnButtonCheckStateChanged.Signature(callback);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.FGSOnButtonCheckStateChangedWrapper:callback")]
	private void callback(int GSID, bool bIsChecked)
	{
		((FGSOnButtonCheckStateChanged.Signature)_action)(GSID, bIsChecked);
	}

	[UFunctionInvoker("/Script/b1-Managed.FGSOnButtonCheckStateChangedWrapper:callback")]
	private static void callback__Invoker(IntPtr buffer, IntPtr obj)
	{
		FGSOnButtonCheckStateChangedWrapper fGSOnButtonCheckStateChangedWrapper = GCHelper.Find<FGSOnButtonCheckStateChangedWrapper>(obj);
		int gSID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, callback_GSID_Offset));
		bool bIsChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, callback_bIsChecked_Offset), 0, callback_bIsChecked_PropertyAddress.Address);
		fGSOnButtonCheckStateChangedWrapper.callback(gSID, bIsChecked);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.FGSOnButtonCheckStateChangedWrapper");
		callback_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "callback");
		callback_ParamsSize = NativeReflection.GetFunctionParamsSize(callback_FunctionAddress);
		callback_GSID_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "GSID");
		callback_GSID_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "GSID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref callback_bIsChecked_PropertyAddress, callback_FunctionAddress, "bIsChecked");
		callback_bIsChecked_Offset = NativeReflection.GetPropertyOffset(callback_FunctionAddress, "bIsChecked");
		callback_bIsChecked_IsValid = NativeReflection.ValidatePropertyClass(callback_FunctionAddress, "bIsChecked", Classes.FBoolProperty);
		callback_IsValid = callback_FunctionAddress != IntPtr.Zero && callback_GSID_IsValid && callback_bIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FGSOnButtonCheckStateChangedWrapper:callback", callback_IsValid);
	}

	static FGSOnButtonCheckStateChangedWrapper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSOnButtonCheckStateChangedWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSOnButtonCheckStateChangedWrapper));
	}
}
