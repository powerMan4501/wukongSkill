using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMInjectionInfo", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMInjectionInfo : UObject
{
	private static bool GetPin_IsValid;

	private static IntPtr GetPin_FunctionAddress;

	private static int GetPin_ParamsSize;

	private static bool GetPin_ReturnValue_IsValid;

	private static FFieldAddress GetPin_ReturnValue_PropertyAddress;

	private static int GetPin_ReturnValue_Offset;

	private static bool GetGraph_IsValid;

	private static IntPtr GetGraph_FunctionAddress;

	private static int GetGraph_ParamsSize;

	private static bool GetGraph_ReturnValue_IsValid;

	private static FFieldAddress GetGraph_ReturnValue_PropertyAddress;

	private static int GetGraph_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMInjectionInfo:GetPin")]
	public unsafe URigVMPin GetPin()
	{
		CheckDestroyed();
		if (!GetPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMInjectionInfo:GetPin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPin_FunctionAddress, intPtr, GetPin_ParamsSize);
		return UObjectMarshaler<URigVMPin>.FromNative(IntPtr.Add(intPtr, GetPin_ReturnValue_Offset), 0, GetPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMInjectionInfo:GetGraph")]
	public unsafe URigVMGraph GetGraph()
	{
		CheckDestroyed();
		if (!GetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMInjectionInfo:GetGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraph_FunctionAddress, intPtr, GetGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetGraph_ReturnValue_Offset), 0, GetGraph_ReturnValue_PropertyAddress.Address);
	}

	static URigVMInjectionInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMInjectionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMInjectionInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMInjectionInfo");
		GetPin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPin");
		GetPin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPin_ReturnValue_PropertyAddress, GetPin_FunctionAddress, "ReturnValue");
		GetPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPin_FunctionAddress, "ReturnValue");
		GetPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPin_IsValid = GetPin_FunctionAddress != IntPtr.Zero && GetPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMInjectionInfo:GetPin", GetPin_IsValid);
		GetGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGraph");
		GetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraph_ReturnValue_PropertyAddress, GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGraph_IsValid = GetGraph_FunctionAddress != IntPtr.Zero && GetGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMInjectionInfo:GetGraph", GetGraph_IsValid);
	}
}
