using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_GameIntentFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_GameIntentFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetCachedActivityIntentReceivedParam_IsValid;

	private static IntPtr GetCachedActivityIntentReceivedParam_FunctionAddress;

	private static int GetCachedActivityIntentReceivedParam_ParamsSize;

	private static bool GetCachedActivityIntentReceivedParam_OutParamCS_IsValid;

	private static FFieldAddress GetCachedActivityIntentReceivedParam_OutParamCS_PropertyAddress;

	private static int GetCachedActivityIntentReceivedParam_OutParamCS_Offset;

	private static bool GetCachedActivityIntentReceivedParam_ReturnValue_IsValid;

	private static FFieldAddress GetCachedActivityIntentReceivedParam_ReturnValue_PropertyAddress;

	private static int GetCachedActivityIntentReceivedParam_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GameIntentFuncLib:GetCachedActivityIntentReceivedParam")]
	public unsafe static bool GetCachedActivityIntentReceivedParam(out FCachedActivityIntentReceivedParamCS OutParamCS)
	{
		if (!GetCachedActivityIntentReceivedParam_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GameIntentFuncLib:GetCachedActivityIntentReceivedParam");
			OutParamCS = default(FCachedActivityIntentReceivedParamCS);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCachedActivityIntentReceivedParam_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCachedActivityIntentReceivedParam_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCachedActivityIntentReceivedParam_OutParamCS_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCachedActivityIntentReceivedParam_FunctionAddress, intPtr, GetCachedActivityIntentReceivedParam_ParamsSize);
		OutParamCS = FCachedActivityIntentReceivedParamCS.FromNative(IntPtr.Add(intPtr, GetCachedActivityIntentReceivedParam_OutParamCS_Offset), 0, GetCachedActivityIntentReceivedParam_OutParamCS_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCachedActivityIntentReceivedParam_OutParamCS_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedActivityIntentReceivedParam_ReturnValue_Offset), 0, GetCachedActivityIntentReceivedParam_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_GameIntentFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_GameIntentFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_GameIntentFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_GameIntentFuncLib");
		GetCachedActivityIntentReceivedParam_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCachedActivityIntentReceivedParam");
		GetCachedActivityIntentReceivedParam_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCachedActivityIntentReceivedParam_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCachedActivityIntentReceivedParam_OutParamCS_PropertyAddress, GetCachedActivityIntentReceivedParam_FunctionAddress, "OutParamCS");
		GetCachedActivityIntentReceivedParam_OutParamCS_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedActivityIntentReceivedParam_FunctionAddress, "OutParamCS");
		GetCachedActivityIntentReceivedParam_OutParamCS_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedActivityIntentReceivedParam_FunctionAddress, "OutParamCS", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCachedActivityIntentReceivedParam_ReturnValue_PropertyAddress, GetCachedActivityIntentReceivedParam_FunctionAddress, "ReturnValue");
		GetCachedActivityIntentReceivedParam_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedActivityIntentReceivedParam_FunctionAddress, "ReturnValue");
		GetCachedActivityIntentReceivedParam_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedActivityIntentReceivedParam_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCachedActivityIntentReceivedParam_IsValid = GetCachedActivityIntentReceivedParam_FunctionAddress != IntPtr.Zero && GetCachedActivityIntentReceivedParam_OutParamCS_IsValid && GetCachedActivityIntentReceivedParam_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GameIntentFuncLib:GetCachedActivityIntentReceivedParam", GetCachedActivityIntentReceivedParam_IsValid);
	}
}
