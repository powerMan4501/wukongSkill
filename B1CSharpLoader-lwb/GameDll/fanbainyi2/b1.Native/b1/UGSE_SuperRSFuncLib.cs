using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SuperRSFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SuperRSFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetIsXeSSSupported_IsValid;

	private static IntPtr GetIsXeSSSupported_FunctionAddress;

	private static int GetIsXeSSSupported_ParamsSize;

	private static bool GetIsXeSSSupported_ReturnValue_IsValid;

	private static FFieldAddress GetIsXeSSSupported_ReturnValue_PropertyAddress;

	private static int GetIsXeSSSupported_ReturnValue_Offset;

	private static bool GetIsDX12_IsValid;

	private static IntPtr GetIsDX12_FunctionAddress;

	private static int GetIsDX12_ParamsSize;

	private static bool GetIsDX12_ReturnValue_IsValid;

	private static FFieldAddress GetIsDX12_ReturnValue_PropertyAddress;

	private static int GetIsDX12_ReturnValue_Offset;

	private static bool GetDLSSLisFeatureSupported_IsValid;

	private static IntPtr GetDLSSLisFeatureSupported_FunctionAddress;

	private static int GetDLSSLisFeatureSupported_ParamsSize;

	private static bool GetDLSSLisFeatureSupported_ReturnValue_IsValid;

	private static FFieldAddress GetDLSSLisFeatureSupported_ReturnValue_PropertyAddress;

	private static int GetDLSSLisFeatureSupported_ReturnValue_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetIsXeSSSupported")]
	public unsafe static bool GetIsXeSSSupported()
	{
		if (!GetIsXeSSSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetIsXeSSSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsXeSSSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsXeSSSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsXeSSSupported_FunctionAddress, intPtr, GetIsXeSSSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsXeSSSupported_ReturnValue_Offset), 0, GetIsXeSSSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetIsDX12")]
	public unsafe static bool GetIsDX12()
	{
		if (!GetIsDX12_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetIsDX12");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsDX12_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsDX12_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsDX12_FunctionAddress, intPtr, GetIsDX12_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsDX12_ReturnValue_Offset), 0, GetIsDX12_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetDLSSLisFeatureSupported")]
	public unsafe static bool GetDLSSLisFeatureSupported()
	{
		if (!GetDLSSLisFeatureSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetDLSSLisFeatureSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDLSSLisFeatureSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDLSSLisFeatureSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDLSSLisFeatureSupported_FunctionAddress, intPtr, GetDLSSLisFeatureSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetDLSSLisFeatureSupported_ReturnValue_Offset), 0, GetDLSSLisFeatureSupported_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_SuperRSFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SuperRSFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SuperRSFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SuperRSFuncLib");
		GetIsXeSSSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsXeSSSupported");
		GetIsXeSSSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsXeSSSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsXeSSSupported_ReturnValue_PropertyAddress, GetIsXeSSSupported_FunctionAddress, "ReturnValue");
		GetIsXeSSSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsXeSSSupported_FunctionAddress, "ReturnValue");
		GetIsXeSSSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsXeSSSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsXeSSSupported_IsValid = GetIsXeSSSupported_FunctionAddress != IntPtr.Zero && GetIsXeSSSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetIsXeSSSupported", GetIsXeSSSupported_IsValid);
		GetIsDX12_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsDX12");
		GetIsDX12_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsDX12_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsDX12_ReturnValue_PropertyAddress, GetIsDX12_FunctionAddress, "ReturnValue");
		GetIsDX12_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsDX12_FunctionAddress, "ReturnValue");
		GetIsDX12_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsDX12_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsDX12_IsValid = GetIsDX12_FunctionAddress != IntPtr.Zero && GetIsDX12_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetIsDX12", GetIsDX12_IsValid);
		GetDLSSLisFeatureSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDLSSLisFeatureSupported");
		GetDLSSLisFeatureSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDLSSLisFeatureSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDLSSLisFeatureSupported_ReturnValue_PropertyAddress, GetDLSSLisFeatureSupported_FunctionAddress, "ReturnValue");
		GetDLSSLisFeatureSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDLSSLisFeatureSupported_FunctionAddress, "ReturnValue");
		GetDLSSLisFeatureSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDLSSLisFeatureSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetDLSSLisFeatureSupported_IsValid = GetDLSSLisFeatureSupported_FunctionAddress != IntPtr.Zero && GetDLSSLisFeatureSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SuperRSFuncLib:GetDLSSLisFeatureSupported", GetDLSSLisFeatureSupported_IsValid);
	}
}
