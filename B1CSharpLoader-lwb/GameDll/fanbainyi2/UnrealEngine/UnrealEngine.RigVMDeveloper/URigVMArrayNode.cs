using System;
using System.Runtime.CompilerServices;
using UnrealEngine.RigVM;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMArrayNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMArrayNode : URigVMNode
{
	private static bool GetOpCode_IsValid;

	private static IntPtr GetOpCode_FunctionAddress;

	private static int GetOpCode_ParamsSize;

	private static bool GetOpCode_ReturnValue_IsValid;

	private static FFieldAddress GetOpCode_ReturnValue_PropertyAddress;

	private static int GetOpCode_ReturnValue_Offset;

	private static bool GetCPPTypeObject_IsValid;

	private static IntPtr GetCPPTypeObject_FunctionAddress;

	private static int GetCPPTypeObject_ParamsSize;

	private static bool GetCPPTypeObject_ReturnValue_IsValid;

	private static FFieldAddress GetCPPTypeObject_ReturnValue_PropertyAddress;

	private static int GetCPPTypeObject_ReturnValue_Offset;

	private static bool GetCPPType_IsValid;

	private static IntPtr GetCPPType_FunctionAddress;

	private static int GetCPPType_ParamsSize;

	private static bool GetCPPType_ReturnValue_IsValid;

	private static FFieldAddress GetCPPType_ReturnValue_PropertyAddress;

	private static int GetCPPType_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMArrayNode:GetOpCode")]
	public unsafe ERigVMOpCode GetOpCode()
	{
		CheckDestroyed();
		if (!GetOpCode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMArrayNode:GetOpCode");
			return ERigVMOpCode.Execute_0_Operands;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOpCode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOpCode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOpCode_FunctionAddress, intPtr, GetOpCode_ParamsSize);
		return EnumMarshaler<ERigVMOpCode>.FromNative(IntPtr.Add(intPtr, GetOpCode_ReturnValue_Offset), 0, GetOpCode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMArrayNode:GetCPPTypeObject")]
	public unsafe UObject GetCPPTypeObject()
	{
		CheckDestroyed();
		if (!GetCPPTypeObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMArrayNode:GetCPPTypeObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCPPTypeObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCPPTypeObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCPPTypeObject_FunctionAddress, intPtr, GetCPPTypeObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetCPPTypeObject_ReturnValue_Offset), 0, GetCPPTypeObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMArrayNode:GetCPPType")]
	public unsafe string GetCPPType()
	{
		CheckDestroyed();
		if (!GetCPPType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMArrayNode:GetCPPType");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCPPType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCPPType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCPPType_FunctionAddress, intPtr, GetCPPType_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCPPType_ReturnValue_Offset), 0, GetCPPType_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCPPType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static URigVMArrayNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMArrayNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMArrayNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMArrayNode");
		GetOpCode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOpCode");
		GetOpCode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOpCode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOpCode_ReturnValue_PropertyAddress, GetOpCode_FunctionAddress, "ReturnValue");
		GetOpCode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOpCode_FunctionAddress, "ReturnValue");
		GetOpCode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOpCode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetOpCode_IsValid = GetOpCode_FunctionAddress != IntPtr.Zero && GetOpCode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMArrayNode:GetOpCode", GetOpCode_IsValid);
		GetCPPTypeObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCPPTypeObject");
		GetCPPTypeObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPPTypeObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPPTypeObject_ReturnValue_PropertyAddress, GetCPPTypeObject_FunctionAddress, "ReturnValue");
		GetCPPTypeObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPPTypeObject_FunctionAddress, "ReturnValue");
		GetCPPTypeObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPPTypeObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCPPTypeObject_IsValid = GetCPPTypeObject_FunctionAddress != IntPtr.Zero && GetCPPTypeObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMArrayNode:GetCPPTypeObject", GetCPPTypeObject_IsValid);
		GetCPPType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCPPType");
		GetCPPType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPPType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPPType_ReturnValue_PropertyAddress, GetCPPType_FunctionAddress, "ReturnValue");
		GetCPPType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPPType_FunctionAddress, "ReturnValue");
		GetCPPType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPPType_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCPPType_IsValid = GetCPPType_FunctionAddress != IntPtr.Zero && GetCPPType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMArrayNode:GetCPPType", GetCPPType_IsValid);
	}
}
