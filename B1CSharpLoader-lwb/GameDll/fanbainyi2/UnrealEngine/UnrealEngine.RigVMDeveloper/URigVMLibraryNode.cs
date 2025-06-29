using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMLibraryNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMLibraryNode : URigVMNode
{
	private static bool GetLibrary_IsValid;

	private static IntPtr GetLibrary_FunctionAddress;

	private static int GetLibrary_ParamsSize;

	private static bool GetLibrary_ReturnValue_IsValid;

	private static FFieldAddress GetLibrary_ReturnValue_PropertyAddress;

	private static int GetLibrary_ReturnValue_Offset;

	private static bool GetContainedGraph_IsValid;

	private static IntPtr GetContainedGraph_FunctionAddress;

	private static int GetContainedGraph_ParamsSize;

	private static bool GetContainedGraph_ReturnValue_IsValid;

	private static FFieldAddress GetContainedGraph_ReturnValue_PropertyAddress;

	private static int GetContainedGraph_ReturnValue_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMLibraryNode:GetLibrary")]
	public unsafe URigVMFunctionLibrary GetLibrary()
	{
		CheckDestroyed();
		if (!GetLibrary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMLibraryNode:GetLibrary");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLibrary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLibrary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLibrary_FunctionAddress, intPtr, GetLibrary_ParamsSize);
		return UObjectMarshaler<URigVMFunctionLibrary>.FromNative(IntPtr.Add(intPtr, GetLibrary_ReturnValue_Offset), 0, GetLibrary_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMLibraryNode:GetContainedGraph")]
	public unsafe URigVMGraph GetContainedGraph()
	{
		CheckDestroyed();
		if (!GetContainedGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMLibraryNode:GetContainedGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContainedGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContainedGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContainedGraph_FunctionAddress, intPtr, GetContainedGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetContainedGraph_ReturnValue_Offset), 0, GetContainedGraph_ReturnValue_PropertyAddress.Address);
	}

	static URigVMLibraryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMLibraryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMLibraryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMLibraryNode");
		GetLibrary_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLibrary");
		GetLibrary_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLibrary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLibrary_ReturnValue_PropertyAddress, GetLibrary_FunctionAddress, "ReturnValue");
		GetLibrary_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLibrary_FunctionAddress, "ReturnValue");
		GetLibrary_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLibrary_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLibrary_IsValid = GetLibrary_FunctionAddress != IntPtr.Zero && GetLibrary_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMLibraryNode:GetLibrary", GetLibrary_IsValid);
		GetContainedGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContainedGraph");
		GetContainedGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContainedGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContainedGraph_ReturnValue_PropertyAddress, GetContainedGraph_FunctionAddress, "ReturnValue");
		GetContainedGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContainedGraph_FunctionAddress, "ReturnValue");
		GetContainedGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContainedGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetContainedGraph_IsValid = GetContainedGraph_FunctionAddress != IntPtr.Zero && GetContainedGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMLibraryNode:GetContainedGraph", GetContainedGraph_IsValid);
	}
}
