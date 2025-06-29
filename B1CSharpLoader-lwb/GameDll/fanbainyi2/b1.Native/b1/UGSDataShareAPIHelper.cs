using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GSDataShare.GSDataShareAPIHelper", "GSDataShare", UnrealModuleType.Game)]
public class UGSDataShareAPIHelper : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsAssetExist_IsValid;

	private static IntPtr IsAssetExist_FunctionAddress;

	private static int IsAssetExist_ParamsSize;

	private static bool IsAssetExist_AssetPath_IsValid;

	private static FFieldAddress IsAssetExist_AssetPath_PropertyAddress;

	private static int IsAssetExist_AssetPath_Offset;

	private static bool IsAssetExist_ReturnValue_IsValid;

	private static FFieldAddress IsAssetExist_ReturnValue_PropertyAddress;

	private static int IsAssetExist_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSDataShare.GSDataShareAPIHelper:IsAssetExist")]
	public unsafe static bool IsAssetExist(string AssetPath)
	{
		if (!IsAssetExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSDataShare.GSDataShareAPIHelper:IsAssetExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAssetExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAssetExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsAssetExist_AssetPath_Offset), 0, IsAssetExist_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAssetExist_FunctionAddress, intPtr, IsAssetExist_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsAssetExist_AssetPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAssetExist_ReturnValue_Offset), 0, IsAssetExist_ReturnValue_PropertyAddress.Address);
	}

	static UGSDataShareAPIHelper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSDataShareAPIHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSDataShareAPIHelper));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSDataShare.GSDataShareAPIHelper");
		IsAssetExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAssetExist");
		IsAssetExist_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAssetExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAssetExist_AssetPath_PropertyAddress, IsAssetExist_FunctionAddress, "AssetPath");
		IsAssetExist_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(IsAssetExist_FunctionAddress, "AssetPath");
		IsAssetExist_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAssetExist_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAssetExist_ReturnValue_PropertyAddress, IsAssetExist_FunctionAddress, "ReturnValue");
		IsAssetExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAssetExist_FunctionAddress, "ReturnValue");
		IsAssetExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAssetExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAssetExist_IsValid = IsAssetExist_FunctionAddress != IntPtr.Zero && IsAssetExist_AssetPath_IsValid && IsAssetExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSDataShare.GSDataShareAPIHelper:IsAssetExist", IsAssetExist_IsValid);
	}
}
