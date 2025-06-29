using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMPrototypeNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMPrototypeNode : URigVMNode
{
	private static bool GetNotation_IsValid;

	private static IntPtr GetNotation_FunctionAddress;

	private static int GetNotation_ParamsSize;

	private static bool GetNotation_ReturnValue_IsValid;

	private static FFieldAddress GetNotation_ReturnValue_PropertyAddress;

	private static int GetNotation_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMPrototypeNode:GetNotation")]
	public unsafe FName GetNotation()
	{
		CheckDestroyed();
		if (!GetNotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMPrototypeNode:GetNotation");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNotation_FunctionAddress, intPtr, GetNotation_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetNotation_ReturnValue_Offset), 0, GetNotation_ReturnValue_PropertyAddress.Address);
	}

	static URigVMPrototypeNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMPrototypeNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMPrototypeNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMPrototypeNode");
		GetNotation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNotation");
		GetNotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNotation_ReturnValue_PropertyAddress, GetNotation_FunctionAddress, "ReturnValue");
		GetNotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNotation_FunctionAddress, "ReturnValue");
		GetNotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotation_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetNotation_IsValid = GetNotation_FunctionAddress != IntPtr.Zero && GetNotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMPrototypeNode:GetNotation", GetNotation_IsValid);
	}
}
