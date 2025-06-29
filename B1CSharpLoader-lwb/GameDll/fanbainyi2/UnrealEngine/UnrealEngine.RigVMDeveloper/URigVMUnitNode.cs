using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMUnitNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMUnitNode : URigVMNode
{
	private static bool GetStructDefaultValue_IsValid;

	private static IntPtr GetStructDefaultValue_FunctionAddress;

	private static int GetStructDefaultValue_ParamsSize;

	private static bool GetStructDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress GetStructDefaultValue_ReturnValue_PropertyAddress;

	private static int GetStructDefaultValue_ReturnValue_Offset;

	private static bool GetScriptStruct_IsValid;

	private static IntPtr GetScriptStruct_FunctionAddress;

	private static int GetScriptStruct_ParamsSize;

	private static bool GetScriptStruct_ReturnValue_IsValid;

	private static FFieldAddress GetScriptStruct_ReturnValue_PropertyAddress;

	private static int GetScriptStruct_ReturnValue_Offset;

	private static bool GetMethodName_IsValid;

	private static IntPtr GetMethodName_FunctionAddress;

	private static int GetMethodName_ParamsSize;

	private static bool GetMethodName_ReturnValue_IsValid;

	private static FFieldAddress GetMethodName_ReturnValue_PropertyAddress;

	private static int GetMethodName_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMUnitNode:GetStructDefaultValue")]
	public unsafe string GetStructDefaultValue()
	{
		CheckDestroyed();
		if (!GetStructDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMUnitNode:GetStructDefaultValue");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStructDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStructDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStructDefaultValue_FunctionAddress, intPtr, GetStructDefaultValue_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStructDefaultValue_ReturnValue_Offset), 0, GetStructDefaultValue_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStructDefaultValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMUnitNode:GetScriptStruct")]
	public unsafe UScriptStruct GetScriptStruct()
	{
		CheckDestroyed();
		if (!GetScriptStruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMUnitNode:GetScriptStruct");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScriptStruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScriptStruct_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScriptStruct_FunctionAddress, intPtr, GetScriptStruct_ParamsSize);
		return UObjectMarshaler<UScriptStruct>.FromNative(IntPtr.Add(intPtr, GetScriptStruct_ReturnValue_Offset), 0, GetScriptStruct_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMUnitNode:GetMethodName")]
	public unsafe FName GetMethodName()
	{
		CheckDestroyed();
		if (!GetMethodName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMUnitNode:GetMethodName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMethodName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMethodName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMethodName_FunctionAddress, intPtr, GetMethodName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetMethodName_ReturnValue_Offset), 0, GetMethodName_ReturnValue_PropertyAddress.Address);
	}

	static URigVMUnitNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMUnitNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMUnitNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMUnitNode");
		GetStructDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStructDefaultValue");
		GetStructDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStructDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStructDefaultValue_ReturnValue_PropertyAddress, GetStructDefaultValue_FunctionAddress, "ReturnValue");
		GetStructDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStructDefaultValue_FunctionAddress, "ReturnValue");
		GetStructDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStructDefaultValue_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStructDefaultValue_IsValid = GetStructDefaultValue_FunctionAddress != IntPtr.Zero && GetStructDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMUnitNode:GetStructDefaultValue", GetStructDefaultValue_IsValid);
		GetScriptStruct_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetScriptStruct");
		GetScriptStruct_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScriptStruct_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScriptStruct_ReturnValue_PropertyAddress, GetScriptStruct_FunctionAddress, "ReturnValue");
		GetScriptStruct_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScriptStruct_FunctionAddress, "ReturnValue");
		GetScriptStruct_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScriptStruct_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetScriptStruct_IsValid = GetScriptStruct_FunctionAddress != IntPtr.Zero && GetScriptStruct_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMUnitNode:GetScriptStruct", GetScriptStruct_IsValid);
		GetMethodName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMethodName");
		GetMethodName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMethodName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMethodName_ReturnValue_PropertyAddress, GetMethodName_FunctionAddress, "ReturnValue");
		GetMethodName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMethodName_FunctionAddress, "ReturnValue");
		GetMethodName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMethodName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetMethodName_IsValid = GetMethodName_FunctionAddress != IntPtr.Zero && GetMethodName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMUnitNode:GetMethodName", GetMethodName_IsValid);
	}
}
