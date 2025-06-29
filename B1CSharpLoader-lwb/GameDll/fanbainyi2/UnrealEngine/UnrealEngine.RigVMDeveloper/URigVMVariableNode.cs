using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMVariableNode : URigVMNode
{
	private static bool IsLocalVariable_IsValid;

	private static IntPtr IsLocalVariable_FunctionAddress;

	private static int IsLocalVariable_ParamsSize;

	private static bool IsLocalVariable_ReturnValue_IsValid;

	private static FFieldAddress IsLocalVariable_ReturnValue_PropertyAddress;

	private static int IsLocalVariable_ReturnValue_Offset;

	private static bool IsInputArgument_IsValid;

	private static IntPtr IsInputArgument_FunctionAddress;

	private static int IsInputArgument_ParamsSize;

	private static bool IsInputArgument_ReturnValue_IsValid;

	private static FFieldAddress IsInputArgument_ReturnValue_PropertyAddress;

	private static int IsInputArgument_ReturnValue_Offset;

	private static bool IsGetter_IsValid;

	private static IntPtr IsGetter_FunctionAddress;

	private static int IsGetter_ParamsSize;

	private static bool IsGetter_ReturnValue_IsValid;

	private static FFieldAddress IsGetter_ReturnValue_PropertyAddress;

	private static int IsGetter_ReturnValue_Offset;

	private static bool GetVariableName_IsValid;

	private static IntPtr GetVariableName_FunctionAddress;

	private static int GetVariableName_ParamsSize;

	private static bool GetVariableName_ReturnValue_IsValid;

	private static FFieldAddress GetVariableName_ReturnValue_PropertyAddress;

	private static int GetVariableName_ReturnValue_Offset;

	private static bool GetVariableDescription_IsValid;

	private static IntPtr GetVariableDescription_FunctionAddress;

	private static int GetVariableDescription_ParamsSize;

	private static bool GetVariableDescription_ReturnValue_IsValid;

	private static FFieldAddress GetVariableDescription_ReturnValue_PropertyAddress;

	private static int GetVariableDescription_ReturnValue_Offset;

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
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:IsLocalVariable")]
	public unsafe bool IsLocalVariable()
	{
		CheckDestroyed();
		if (!IsLocalVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:IsLocalVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocalVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocalVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocalVariable_FunctionAddress, intPtr, IsLocalVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocalVariable_ReturnValue_Offset), 0, IsLocalVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:IsInputArgument")]
	public unsafe bool IsInputArgument()
	{
		CheckDestroyed();
		if (!IsInputArgument_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:IsInputArgument");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInputArgument_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInputArgument_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInputArgument_FunctionAddress, intPtr, IsInputArgument_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInputArgument_ReturnValue_Offset), 0, IsInputArgument_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:IsGetter")]
	public unsafe bool IsGetter()
	{
		CheckDestroyed();
		if (!IsGetter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:IsGetter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGetter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGetter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsGetter_FunctionAddress, intPtr, IsGetter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGetter_ReturnValue_Offset), 0, IsGetter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:GetVariableName")]
	public unsafe FName GetVariableName()
	{
		CheckDestroyed();
		if (!GetVariableName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:GetVariableName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariableName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariableName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariableName_FunctionAddress, intPtr, GetVariableName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetVariableName_ReturnValue_Offset), 0, GetVariableName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:GetVariableDescription")]
	public unsafe FRigVMGraphVariableDescription GetVariableDescription()
	{
		CheckDestroyed();
		if (!GetVariableDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:GetVariableDescription");
			return default(FRigVMGraphVariableDescription);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariableDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariableDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariableDescription_FunctionAddress, intPtr, GetVariableDescription_ParamsSize);
		FRigVMGraphVariableDescription result = FRigVMGraphVariableDescription.FromNative(IntPtr.Add(intPtr, GetVariableDescription_ReturnValue_Offset), 0, GetVariableDescription_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetVariableDescription_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:GetDefaultValue")]
	public unsafe string GetDefaultValue()
	{
		CheckDestroyed();
		if (!GetDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:GetDefaultValue");
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
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:GetCPPTypeObject")]
	public unsafe UObject GetCPPTypeObject()
	{
		CheckDestroyed();
		if (!GetCPPTypeObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:GetCPPTypeObject");
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
	[UMetaPath("/Script/RigVMDeveloper.RigVMVariableNode:GetCPPType")]
	public unsafe string GetCPPType()
	{
		CheckDestroyed();
		if (!GetCPPType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMVariableNode:GetCPPType");
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

	static URigVMVariableNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMVariableNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMVariableNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMVariableNode");
		IsLocalVariable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLocalVariable");
		IsLocalVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocalVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocalVariable_ReturnValue_PropertyAddress, IsLocalVariable_FunctionAddress, "ReturnValue");
		IsLocalVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocalVariable_FunctionAddress, "ReturnValue");
		IsLocalVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocalVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocalVariable_IsValid = IsLocalVariable_FunctionAddress != IntPtr.Zero && IsLocalVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:IsLocalVariable", IsLocalVariable_IsValid);
		IsInputArgument_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInputArgument");
		IsInputArgument_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInputArgument_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInputArgument_ReturnValue_PropertyAddress, IsInputArgument_FunctionAddress, "ReturnValue");
		IsInputArgument_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInputArgument_FunctionAddress, "ReturnValue");
		IsInputArgument_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInputArgument_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInputArgument_IsValid = IsInputArgument_FunctionAddress != IntPtr.Zero && IsInputArgument_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:IsInputArgument", IsInputArgument_IsValid);
		IsGetter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsGetter");
		IsGetter_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGetter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsGetter_ReturnValue_PropertyAddress, IsGetter_FunctionAddress, "ReturnValue");
		IsGetter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsGetter_FunctionAddress, "ReturnValue");
		IsGetter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGetter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGetter_IsValid = IsGetter_FunctionAddress != IntPtr.Zero && IsGetter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:IsGetter", IsGetter_IsValid);
		GetVariableName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariableName");
		GetVariableName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariableName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariableName_ReturnValue_PropertyAddress, GetVariableName_FunctionAddress, "ReturnValue");
		GetVariableName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableName_FunctionAddress, "ReturnValue");
		GetVariableName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetVariableName_IsValid = GetVariableName_FunctionAddress != IntPtr.Zero && GetVariableName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:GetVariableName", GetVariableName_IsValid);
		GetVariableDescription_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariableDescription");
		GetVariableDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariableDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariableDescription_ReturnValue_PropertyAddress, GetVariableDescription_FunctionAddress, "ReturnValue");
		GetVariableDescription_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableDescription_FunctionAddress, "ReturnValue");
		GetVariableDescription_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableDescription_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVariableDescription_IsValid = GetVariableDescription_FunctionAddress != IntPtr.Zero && GetVariableDescription_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:GetVariableDescription", GetVariableDescription_IsValid);
		GetDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDefaultValue");
		GetDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultValue_ReturnValue_PropertyAddress, GetDefaultValue_FunctionAddress, "ReturnValue");
		GetDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultValue_FunctionAddress, "ReturnValue");
		GetDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultValue_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDefaultValue_IsValid = GetDefaultValue_FunctionAddress != IntPtr.Zero && GetDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:GetDefaultValue", GetDefaultValue_IsValid);
		GetCPPTypeObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCPPTypeObject");
		GetCPPTypeObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPPTypeObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPPTypeObject_ReturnValue_PropertyAddress, GetCPPTypeObject_FunctionAddress, "ReturnValue");
		GetCPPTypeObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPPTypeObject_FunctionAddress, "ReturnValue");
		GetCPPTypeObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPPTypeObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCPPTypeObject_IsValid = GetCPPTypeObject_FunctionAddress != IntPtr.Zero && GetCPPTypeObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:GetCPPTypeObject", GetCPPTypeObject_IsValid);
		GetCPPType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCPPType");
		GetCPPType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPPType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPPType_ReturnValue_PropertyAddress, GetCPPType_FunctionAddress, "ReturnValue");
		GetCPPType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPPType_FunctionAddress, "ReturnValue");
		GetCPPType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPPType_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCPPType_IsValid = GetCPPType_FunctionAddress != IntPtr.Zero && GetCPPType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMVariableNode:GetCPPType", GetCPPType_IsValid);
	}
}
