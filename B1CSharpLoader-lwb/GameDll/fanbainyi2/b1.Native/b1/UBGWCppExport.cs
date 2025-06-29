using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGWCppExport", "b1", UnrealModuleType.Game)]
public class UBGWCppExport : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetAllFuncAsMap_IsValid;

	private static IntPtr GetAllFuncAsMap_FunctionAddress;

	private static int GetAllFuncAsMap_ParamsSize;

	private static bool GetAllFuncAsMap_ReturnValue_IsValid;

	private static FFieldAddress GetAllFuncAsMap_ReturnValue_PropertyAddress;

	private static int GetAllFuncAsMap_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGWCppExport:GetAllFuncAsMap")]
	public unsafe static Dictionary<string, FIntPtr> GetAllFuncAsMap()
	{
		if (!GetAllFuncAsMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWCppExport:GetAllFuncAsMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllFuncAsMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllFuncAsMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllFuncAsMap_FunctionAddress, intPtr, GetAllFuncAsMap_ParamsSize);
		Dictionary<string, FIntPtr> result = new TMapCopyMarshaler<string, FIntPtr>(1, GetAllFuncAsMap_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.FromNative, CachedMarshalingDelegates<FIntPtr, BlittableTypeMarshaler<FIntPtr>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllFuncAsMap_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllFuncAsMap_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UBGWCppExport()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWCppExport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWCppExport));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGWCppExport");
		GetAllFuncAsMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllFuncAsMap");
		GetAllFuncAsMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllFuncAsMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllFuncAsMap_ReturnValue_PropertyAddress, GetAllFuncAsMap_FunctionAddress, "ReturnValue");
		GetAllFuncAsMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllFuncAsMap_FunctionAddress, "ReturnValue");
		GetAllFuncAsMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllFuncAsMap_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetAllFuncAsMap_IsValid = GetAllFuncAsMap_FunctionAddress != IntPtr.Zero && GetAllFuncAsMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWCppExport:GetAllFuncAsMap", GetAllFuncAsMap_IsValid);
	}
}
