using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialParameterCollection", "Engine", UnrealModuleType.Engine)]
public class UMaterialParameterCollection : UObject
{
	private static bool GetVectorParameterNames_IsValid;

	private static IntPtr GetVectorParameterNames_FunctionAddress;

	private static int GetVectorParameterNames_ParamsSize;

	private static bool GetVectorParameterNames_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameterNames_ReturnValue_PropertyAddress;

	private static int GetVectorParameterNames_ReturnValue_Offset;

	private static bool GetVectorParameterDefaultValue_IsValid;

	private static IntPtr GetVectorParameterDefaultValue_FunctionAddress;

	private static int GetVectorParameterDefaultValue_ParamsSize;

	private static bool GetVectorParameterDefaultValue_ParameterName_IsValid;

	private static FFieldAddress GetVectorParameterDefaultValue_ParameterName_PropertyAddress;

	private static int GetVectorParameterDefaultValue_ParameterName_Offset;

	private static bool GetVectorParameterDefaultValue_bParameterFound_IsValid;

	private static FFieldAddress GetVectorParameterDefaultValue_bParameterFound_PropertyAddress;

	private static int GetVectorParameterDefaultValue_bParameterFound_Offset;

	private static bool GetVectorParameterDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameterDefaultValue_ReturnValue_PropertyAddress;

	private static int GetVectorParameterDefaultValue_ReturnValue_Offset;

	private static bool GetScalarParameterNames_IsValid;

	private static IntPtr GetScalarParameterNames_FunctionAddress;

	private static int GetScalarParameterNames_ParamsSize;

	private static bool GetScalarParameterNames_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterNames_ReturnValue_PropertyAddress;

	private static int GetScalarParameterNames_ReturnValue_Offset;

	private static bool GetScalarParameterDefaultValue_IsValid;

	private static IntPtr GetScalarParameterDefaultValue_FunctionAddress;

	private static int GetScalarParameterDefaultValue_ParamsSize;

	private static bool GetScalarParameterDefaultValue_ParameterName_IsValid;

	private static FFieldAddress GetScalarParameterDefaultValue_ParameterName_PropertyAddress;

	private static int GetScalarParameterDefaultValue_ParameterName_Offset;

	private static bool GetScalarParameterDefaultValue_bParameterFound_IsValid;

	private static FFieldAddress GetScalarParameterDefaultValue_bParameterFound_PropertyAddress;

	private static int GetScalarParameterDefaultValue_bParameterFound_Offset;

	private static bool GetScalarParameterDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterDefaultValue_ReturnValue_PropertyAddress;

	private static int GetScalarParameterDefaultValue_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.MaterialParameterCollection:GetVectorParameterNames")]
	public unsafe List<FName> GetVectorParameterNames()
	{
		CheckDestroyed();
		if (!GetVectorParameterNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialParameterCollection:GetVectorParameterNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameterNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameterNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorParameterNames_FunctionAddress, intPtr, GetVectorParameterNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetVectorParameterNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetVectorParameterNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetVectorParameterNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.MaterialParameterCollection:GetVectorParameterDefaultValue")]
	public unsafe FLinearColor GetVectorParameterDefaultValue(FName ParameterName, out bool bParameterFound)
	{
		CheckDestroyed();
		if (!GetVectorParameterDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialParameterCollection:GetVectorParameterDefaultValue");
			bParameterFound = false;
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameterDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameterDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorParameterDefaultValue_ParameterName_Offset), 0, GetVectorParameterDefaultValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorParameterDefaultValue_FunctionAddress, intPtr, GetVectorParameterDefaultValue_ParamsSize);
		bParameterFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVectorParameterDefaultValue_bParameterFound_Offset), 0, GetVectorParameterDefaultValue_bParameterFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetVectorParameterDefaultValue_ReturnValue_Offset), 0, GetVectorParameterDefaultValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.MaterialParameterCollection:GetScalarParameterNames")]
	public unsafe List<FName> GetScalarParameterNames()
	{
		CheckDestroyed();
		if (!GetScalarParameterNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialParameterCollection:GetScalarParameterNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScalarParameterNames_FunctionAddress, intPtr, GetScalarParameterNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetScalarParameterNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetScalarParameterNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetScalarParameterNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.MaterialParameterCollection:GetScalarParameterDefaultValue")]
	public unsafe float GetScalarParameterDefaultValue(FName ParameterName, out bool bParameterFound)
	{
		CheckDestroyed();
		if (!GetScalarParameterDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialParameterCollection:GetScalarParameterDefaultValue");
			bParameterFound = false;
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetScalarParameterDefaultValue_ParameterName_Offset), 0, GetScalarParameterDefaultValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScalarParameterDefaultValue_FunctionAddress, intPtr, GetScalarParameterDefaultValue_ParamsSize);
		bParameterFound = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetScalarParameterDefaultValue_bParameterFound_Offset), 0, GetScalarParameterDefaultValue_bParameterFound_PropertyAddress.Address);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScalarParameterDefaultValue_ReturnValue_Offset), 0, GetScalarParameterDefaultValue_ReturnValue_PropertyAddress.Address);
	}

	static UMaterialParameterCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialParameterCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialParameterCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.MaterialParameterCollection");
		GetVectorParameterNames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVectorParameterNames");
		GetVectorParameterNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameterNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterNames_ReturnValue_PropertyAddress, GetVectorParameterNames_FunctionAddress, "ReturnValue");
		GetVectorParameterNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterNames_FunctionAddress, "ReturnValue");
		GetVectorParameterNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetVectorParameterNames_IsValid = GetVectorParameterNames_FunctionAddress != IntPtr.Zero && GetVectorParameterNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialParameterCollection:GetVectorParameterNames", GetVectorParameterNames_IsValid);
		GetVectorParameterDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVectorParameterDefaultValue");
		GetVectorParameterDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameterDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterDefaultValue_ParameterName_PropertyAddress, GetVectorParameterDefaultValue_FunctionAddress, "ParameterName");
		GetVectorParameterDefaultValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterDefaultValue_FunctionAddress, "ParameterName");
		GetVectorParameterDefaultValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterDefaultValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterDefaultValue_bParameterFound_PropertyAddress, GetVectorParameterDefaultValue_FunctionAddress, "bParameterFound");
		GetVectorParameterDefaultValue_bParameterFound_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterDefaultValue_FunctionAddress, "bParameterFound");
		GetVectorParameterDefaultValue_bParameterFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterDefaultValue_FunctionAddress, "bParameterFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterDefaultValue_ReturnValue_PropertyAddress, GetVectorParameterDefaultValue_FunctionAddress, "ReturnValue");
		GetVectorParameterDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterDefaultValue_FunctionAddress, "ReturnValue");
		GetVectorParameterDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterDefaultValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorParameterDefaultValue_IsValid = GetVectorParameterDefaultValue_FunctionAddress != IntPtr.Zero && GetVectorParameterDefaultValue_ParameterName_IsValid && GetVectorParameterDefaultValue_bParameterFound_IsValid && GetVectorParameterDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialParameterCollection:GetVectorParameterDefaultValue", GetVectorParameterDefaultValue_IsValid);
		GetScalarParameterNames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetScalarParameterNames");
		GetScalarParameterNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterNames_ReturnValue_PropertyAddress, GetScalarParameterNames_FunctionAddress, "ReturnValue");
		GetScalarParameterNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterNames_FunctionAddress, "ReturnValue");
		GetScalarParameterNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetScalarParameterNames_IsValid = GetScalarParameterNames_FunctionAddress != IntPtr.Zero && GetScalarParameterNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialParameterCollection:GetScalarParameterNames", GetScalarParameterNames_IsValid);
		GetScalarParameterDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetScalarParameterDefaultValue");
		GetScalarParameterDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterDefaultValue_ParameterName_PropertyAddress, GetScalarParameterDefaultValue_FunctionAddress, "ParameterName");
		GetScalarParameterDefaultValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterDefaultValue_FunctionAddress, "ParameterName");
		GetScalarParameterDefaultValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterDefaultValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterDefaultValue_bParameterFound_PropertyAddress, GetScalarParameterDefaultValue_FunctionAddress, "bParameterFound");
		GetScalarParameterDefaultValue_bParameterFound_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterDefaultValue_FunctionAddress, "bParameterFound");
		GetScalarParameterDefaultValue_bParameterFound_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterDefaultValue_FunctionAddress, "bParameterFound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterDefaultValue_ReturnValue_PropertyAddress, GetScalarParameterDefaultValue_FunctionAddress, "ReturnValue");
		GetScalarParameterDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterDefaultValue_FunctionAddress, "ReturnValue");
		GetScalarParameterDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterDefaultValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScalarParameterDefaultValue_IsValid = GetScalarParameterDefaultValue_FunctionAddress != IntPtr.Zero && GetScalarParameterDefaultValue_ParameterName_IsValid && GetScalarParameterDefaultValue_bParameterFound_IsValid && GetScalarParameterDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialParameterCollection:GetScalarParameterDefaultValue", GetScalarParameterDefaultValue_IsValid);
	}
}
