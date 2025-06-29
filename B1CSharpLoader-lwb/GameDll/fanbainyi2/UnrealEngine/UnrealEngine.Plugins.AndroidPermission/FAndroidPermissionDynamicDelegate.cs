using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AndroidPermission;

[UDelegate]
[UMetaPath("/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature")]
public class FAndroidPermissionDynamicDelegate : FMulticastDelegate<FAndroidPermissionDynamicDelegate.Signature>
{
	public delegate void Signature(List<string> Permissions, List<bool> GrantResults);

	private static bool AndroidPermissionDynamicDelegate__DelegateSignature_IsValid;

	private static IntPtr AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress;

	private static int AndroidPermissionDynamicDelegate__DelegateSignature_ParamsSize;

	private static bool AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_IsValid;

	private static FFieldAddress AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_PropertyAddress;

	private static int AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_Offset;

	private static bool AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_IsValid;

	private static FFieldAddress AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_PropertyAddress;

	private static int AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAndroidPermissionDynamicDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature");
		AndroidPermissionDynamicDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_PropertyAddress, AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress, "Permissions");
		AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_Offset = NativeReflectionCached.GetPropertyOffset(AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress, "Permissions");
		AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_IsValid = NativeReflectionCached.ValidatePropertyClass(AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress, "Permissions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_PropertyAddress, AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress, "GrantResults");
		AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_Offset = NativeReflectionCached.GetPropertyOffset(AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress, "GrantResults");
		AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_IsValid = NativeReflectionCached.ValidatePropertyClass(AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress, "GrantResults", Classes.FArrayProperty);
		AndroidPermissionDynamicDelegate__DelegateSignature_IsValid = AndroidPermissionDynamicDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_IsValid && AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature", AndroidPermissionDynamicDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<string> Permissions, List<bool> GrantResults)
	{
		if (!AndroidPermissionDynamicDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AndroidPermission.AndroidPermissionDynamicDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AndroidPermissionDynamicDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AndroidPermissionDynamicDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<string>(1, AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_Offset), Permissions);
			new TArrayCopyMarshaler<bool>(1, AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_Offset), GrantResults);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(AndroidPermissionDynamicDelegate__DelegateSignature_Permissions_PropertyAddress.Address, intPtr);
			NativeReflection.DestroyValue_InContainer(AndroidPermissionDynamicDelegate__DelegateSignature_GrantResults_PropertyAddress.Address, intPtr);
		}
	}
}
