using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_GridlyFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_GridlyFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RequestPage_IsValid;

	private static IntPtr RequestPage_FunctionAddress;

	private static int RequestPage_ParamsSize;

	private static bool RequestPage_Obj_IsValid;

	private static FFieldAddress RequestPage_Obj_PropertyAddress;

	private static int RequestPage_Obj_Offset;

	private static bool GetSupportCultures_IsValid;

	private static IntPtr GetSupportCultures_FunctionAddress;

	private static int GetSupportCultures_ParamsSize;

	private static bool GetSupportCultures_ReturnValue_IsValid;

	private static FFieldAddress GetSupportCultures_ReturnValue_PropertyAddress;

	private static int GetSupportCultures_ReturnValue_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GridlyFuncLib:RequestPage")]
	public unsafe static void RequestPage(UObject Obj)
	{
		if (!RequestPage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GridlyFuncLib:RequestPage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestPage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestPage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RequestPage_Obj_Offset), 0, RequestPage_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestPage_FunctionAddress, intPtr, RequestPage_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GridlyFuncLib:GetSupportCultures")]
	public unsafe static List<string> GetSupportCultures()
	{
		if (!GetSupportCultures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GridlyFuncLib:GetSupportCultures");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportCultures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportCultures_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSupportCultures_FunctionAddress, intPtr, GetSupportCultures_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetSupportCultures_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSupportCultures_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSupportCultures_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_GridlyFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_GridlyFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_GridlyFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_GridlyFuncLib");
		RequestPage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestPage");
		RequestPage_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestPage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestPage_Obj_PropertyAddress, RequestPage_FunctionAddress, "Obj");
		RequestPage_Obj_Offset = NativeReflectionCached.GetPropertyOffset(RequestPage_FunctionAddress, "Obj");
		RequestPage_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestPage_FunctionAddress, "Obj", Classes.FObjectProperty);
		RequestPage_IsValid = RequestPage_FunctionAddress != IntPtr.Zero && RequestPage_Obj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GridlyFuncLib:RequestPage", RequestPage_IsValid);
		GetSupportCultures_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSupportCultures");
		GetSupportCultures_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportCultures_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportCultures_ReturnValue_PropertyAddress, GetSupportCultures_FunctionAddress, "ReturnValue");
		GetSupportCultures_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportCultures_FunctionAddress, "ReturnValue");
		GetSupportCultures_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportCultures_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSupportCultures_IsValid = GetSupportCultures_FunctionAddress != IntPtr.Zero && GetSupportCultures_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GridlyFuncLib:GetSupportCultures", GetSupportCultures_IsValid);
	}
}
