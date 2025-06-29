using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AndroidPermission;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AndroidPermission.AndroidPermissionFunctionLibrary", "AndroidPermission", UnrealModuleType.EnginePlugin)]
public class UAndroidPermissionFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool CheckPermission_IsValid;

	private static IntPtr CheckPermission_FunctionAddress;

	private static int CheckPermission_ParamsSize;

	private static bool CheckPermission_permission_IsValid;

	private static FFieldAddress CheckPermission_permission_PropertyAddress;

	private static int CheckPermission_permission_Offset;

	private static bool CheckPermission_ReturnValue_IsValid;

	private static FFieldAddress CheckPermission_ReturnValue_PropertyAddress;

	private static int CheckPermission_ReturnValue_Offset;

	private static bool AcquirePermissions_IsValid;

	private static IntPtr AcquirePermissions_FunctionAddress;

	private static int AcquirePermissions_ParamsSize;

	private static bool AcquirePermissions_permissions_IsValid;

	private static FFieldAddress AcquirePermissions_permissions_PropertyAddress;

	private static int AcquirePermissions_permissions_Offset;

	private static bool AcquirePermissions_ReturnValue_IsValid;

	private static FFieldAddress AcquirePermissions_ReturnValue_PropertyAddress;

	private static int AcquirePermissions_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AndroidPermission.AndroidPermissionFunctionLibrary:CheckPermission")]
	public unsafe static bool CheckPermission(string permission)
	{
		if (!CheckPermission_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AndroidPermission.AndroidPermissionFunctionLibrary:CheckPermission");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckPermission_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckPermission_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckPermission_permission_Offset), 0, CheckPermission_permission_PropertyAddress.Address, permission);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckPermission_FunctionAddress, intPtr, CheckPermission_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckPermission_permission_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckPermission_ReturnValue_Offset), 0, CheckPermission_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AndroidPermission.AndroidPermissionFunctionLibrary:AcquirePermissions")]
	public unsafe static UAndroidPermissionCallbackProxy AcquirePermissions(List<string> permissions)
	{
		if (!AcquirePermissions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AndroidPermission.AndroidPermissionFunctionLibrary:AcquirePermissions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AcquirePermissions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AcquirePermissions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, AcquirePermissions_permissions_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AcquirePermissions_permissions_Offset), permissions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AcquirePermissions_FunctionAddress, intPtr, AcquirePermissions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AcquirePermissions_permissions_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAndroidPermissionCallbackProxy>.FromNative(IntPtr.Add(intPtr, AcquirePermissions_ReturnValue_Offset), 0, AcquirePermissions_ReturnValue_PropertyAddress.Address);
	}

	static UAndroidPermissionFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAndroidPermissionFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAndroidPermissionFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AndroidPermission.AndroidPermissionFunctionLibrary");
		CheckPermission_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckPermission");
		CheckPermission_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckPermission_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckPermission_permission_PropertyAddress, CheckPermission_FunctionAddress, "permission");
		CheckPermission_permission_Offset = NativeReflectionCached.GetPropertyOffset(CheckPermission_FunctionAddress, "permission");
		CheckPermission_permission_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPermission_FunctionAddress, "permission", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckPermission_ReturnValue_PropertyAddress, CheckPermission_FunctionAddress, "ReturnValue");
		CheckPermission_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckPermission_FunctionAddress, "ReturnValue");
		CheckPermission_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckPermission_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckPermission_IsValid = CheckPermission_FunctionAddress != IntPtr.Zero && CheckPermission_permission_IsValid && CheckPermission_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AndroidPermission.AndroidPermissionFunctionLibrary:CheckPermission", CheckPermission_IsValid);
		AcquirePermissions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AcquirePermissions");
		AcquirePermissions_ParamsSize = NativeReflection.GetFunctionParamsSize(AcquirePermissions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AcquirePermissions_permissions_PropertyAddress, AcquirePermissions_FunctionAddress, "permissions");
		AcquirePermissions_permissions_Offset = NativeReflectionCached.GetPropertyOffset(AcquirePermissions_FunctionAddress, "permissions");
		AcquirePermissions_permissions_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquirePermissions_FunctionAddress, "permissions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquirePermissions_ReturnValue_PropertyAddress, AcquirePermissions_FunctionAddress, "ReturnValue");
		AcquirePermissions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AcquirePermissions_FunctionAddress, "ReturnValue");
		AcquirePermissions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquirePermissions_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AcquirePermissions_IsValid = AcquirePermissions_FunctionAddress != IntPtr.Zero && AcquirePermissions_permissions_IsValid && AcquirePermissions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AndroidPermission.AndroidPermissionFunctionLibrary:AcquirePermissions", AcquirePermissions_IsValid);
	}
}
