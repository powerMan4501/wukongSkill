using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMParameterNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMParameterNode : URigVMNode
{
	private static bool IsInput_IsValid;

	private static IntPtr IsInput_FunctionAddress;

	private static int IsInput_ParamsSize;

	private static bool IsInput_ReturnValue_IsValid;

	private static FFieldAddress IsInput_ReturnValue_PropertyAddress;

	private static int IsInput_ReturnValue_Offset;

	private static bool GetParameterName_IsValid;

	private static IntPtr GetParameterName_FunctionAddress;

	private static int GetParameterName_ParamsSize;

	private static bool GetParameterName_ReturnValue_IsValid;

	private static FFieldAddress GetParameterName_ReturnValue_PropertyAddress;

	private static int GetParameterName_ReturnValue_Offset;

	private static bool GetParameterDescription_IsValid;

	private static IntPtr GetParameterDescription_FunctionAddress;

	private static int GetParameterDescription_ParamsSize;

	private static bool GetParameterDescription_ReturnValue_IsValid;

	private static FFieldAddress GetParameterDescription_ReturnValue_PropertyAddress;

	private static int GetParameterDescription_ReturnValue_Offset;

	private static bool GetDefaultValue_IsValid;

	private static IntPtr GetDefaultValue_FunctionAddress;

	private static int GetDefaultValue_ParamsSize;

	private static bool GetDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultValue_ReturnValue_PropertyAddress;

	private static int GetDefaultValue_ReturnValue_Offset;

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
	[UMetaPath("/Script/RigVMDeveloper.RigVMParameterNode:IsInput")]
	public unsafe bool IsInput()
	{
		CheckDestroyed();
		if (!IsInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMParameterNode:IsInput");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInput_FunctionAddress, intPtr, IsInput_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInput_ReturnValue_Offset), 0, IsInput_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMParameterNode:GetParameterName")]
	public unsafe FName GetParameterName()
	{
		CheckDestroyed();
		if (!GetParameterName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMParameterNode:GetParameterName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterName_FunctionAddress, intPtr, GetParameterName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetParameterName_ReturnValue_Offset), 0, GetParameterName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMParameterNode:GetParameterDescription")]
	public unsafe FRigVMGraphParameterDescription GetParameterDescription()
	{
		CheckDestroyed();
		if (!GetParameterDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMParameterNode:GetParameterDescription");
			return default(FRigVMGraphParameterDescription);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterDescription_FunctionAddress, intPtr, GetParameterDescription_ParamsSize);
		FRigVMGraphParameterDescription result = FRigVMGraphParameterDescription.FromNative(IntPtr.Add(intPtr, GetParameterDescription_ReturnValue_Offset), 0, GetParameterDescription_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParameterDescription_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMParameterNode:GetDefaultValue")]
	public unsafe string GetDefaultValue()
	{
		CheckDestroyed();
		if (!GetDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMParameterNode:GetDefaultValue");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultValue_FunctionAddress, intPtr, GetDefaultValue_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDefaultValue_ReturnValue_Offset), 0, GetDefaultValue_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMParameterNode:GetCPPTypeObject")]
	public unsafe UObject GetCPPTypeObject()
	{
		CheckDestroyed();
		if (!GetCPPTypeObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMParameterNode:GetCPPTypeObject");
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
	[UMetaPath("/Script/RigVMDeveloper.RigVMParameterNode:GetCPPType")]
	public unsafe string GetCPPType()
	{
		CheckDestroyed();
		if (!GetCPPType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMParameterNode:GetCPPType");
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

	static URigVMParameterNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMParameterNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMParameterNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMParameterNode");
		IsInput_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInput");
		IsInput_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInput_ReturnValue_PropertyAddress, IsInput_FunctionAddress, "ReturnValue");
		IsInput_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInput_FunctionAddress, "ReturnValue");
		IsInput_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInput_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInput_IsValid = IsInput_FunctionAddress != IntPtr.Zero && IsInput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMParameterNode:IsInput", IsInput_IsValid);
		GetParameterName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterName");
		GetParameterName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterName_ReturnValue_PropertyAddress, GetParameterName_FunctionAddress, "ReturnValue");
		GetParameterName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterName_FunctionAddress, "ReturnValue");
		GetParameterName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetParameterName_IsValid = GetParameterName_FunctionAddress != IntPtr.Zero && GetParameterName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMParameterNode:GetParameterName", GetParameterName_IsValid);
		GetParameterDescription_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterDescription");
		GetParameterDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterDescription_ReturnValue_PropertyAddress, GetParameterDescription_FunctionAddress, "ReturnValue");
		GetParameterDescription_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterDescription_FunctionAddress, "ReturnValue");
		GetParameterDescription_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterDescription_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParameterDescription_IsValid = GetParameterDescription_FunctionAddress != IntPtr.Zero && GetParameterDescription_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMParameterNode:GetParameterDescription", GetParameterDescription_IsValid);
		GetDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDefaultValue");
		GetDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultValue_ReturnValue_PropertyAddress, GetDefaultValue_FunctionAddress, "ReturnValue");
		GetDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultValue_FunctionAddress, "ReturnValue");
		GetDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultValue_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDefaultValue_IsValid = GetDefaultValue_FunctionAddress != IntPtr.Zero && GetDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMParameterNode:GetDefaultValue", GetDefaultValue_IsValid);
		GetCPPTypeObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCPPTypeObject");
		GetCPPTypeObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPPTypeObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPPTypeObject_ReturnValue_PropertyAddress, GetCPPTypeObject_FunctionAddress, "ReturnValue");
		GetCPPTypeObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPPTypeObject_FunctionAddress, "ReturnValue");
		GetCPPTypeObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPPTypeObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCPPTypeObject_IsValid = GetCPPTypeObject_FunctionAddress != IntPtr.Zero && GetCPPTypeObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMParameterNode:GetCPPTypeObject", GetCPPTypeObject_IsValid);
		GetCPPType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCPPType");
		GetCPPType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPPType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPPType_ReturnValue_PropertyAddress, GetCPPType_FunctionAddress, "ReturnValue");
		GetCPPType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPPType_FunctionAddress, "ReturnValue");
		GetCPPType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPPType_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCPPType_IsValid = GetCPPType_FunctionAddress != IntPtr.Zero && GetCPPType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMParameterNode:GetCPPType", GetCPPType_IsValid);
	}
}
