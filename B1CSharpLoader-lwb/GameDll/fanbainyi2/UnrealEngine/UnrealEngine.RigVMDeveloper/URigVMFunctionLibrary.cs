using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMFunctionLibrary", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMFunctionLibrary : URigVMGraph
{
	private static bool GetReferencesForFunction_IsValid;

	private static IntPtr GetReferencesForFunction_FunctionAddress;

	private static int GetReferencesForFunction_ParamsSize;

	private static bool GetReferencesForFunction_InFunctionName_IsValid;

	private static FFieldAddress GetReferencesForFunction_InFunctionName_PropertyAddress;

	private static int GetReferencesForFunction_InFunctionName_Offset;

	private static bool GetReferencesForFunction_ReturnValue_IsValid;

	private static FFieldAddress GetReferencesForFunction_ReturnValue_PropertyAddress;

	private static int GetReferencesForFunction_ReturnValue_Offset;

	private static bool GetReferencePathsForFunction_IsValid;

	private static IntPtr GetReferencePathsForFunction_FunctionAddress;

	private static int GetReferencePathsForFunction_ParamsSize;

	private static bool GetReferencePathsForFunction_InFunctionName_IsValid;

	private static FFieldAddress GetReferencePathsForFunction_InFunctionName_PropertyAddress;

	private static int GetReferencePathsForFunction_InFunctionName_Offset;

	private static bool GetReferencePathsForFunction_ReturnValue_IsValid;

	private static FFieldAddress GetReferencePathsForFunction_ReturnValue_PropertyAddress;

	private static int GetReferencePathsForFunction_ReturnValue_Offset;

	private static bool GetFunctions_IsValid;

	private static IntPtr GetFunctions_FunctionAddress;

	private static int GetFunctions_ParamsSize;

	private static bool GetFunctions_ReturnValue_IsValid;

	private static FFieldAddress GetFunctions_ReturnValue_PropertyAddress;

	private static int GetFunctions_ReturnValue_Offset;

	private static bool FindFunctionForNode_IsValid;

	private static IntPtr FindFunctionForNode_FunctionAddress;

	private static int FindFunctionForNode_ParamsSize;

	private static bool FindFunctionForNode_InNode_IsValid;

	private static FFieldAddress FindFunctionForNode_InNode_PropertyAddress;

	private static int FindFunctionForNode_InNode_Offset;

	private static bool FindFunctionForNode_ReturnValue_IsValid;

	private static FFieldAddress FindFunctionForNode_ReturnValue_PropertyAddress;

	private static int FindFunctionForNode_ReturnValue_Offset;

	private static bool FindFunction_IsValid;

	private static IntPtr FindFunction_FunctionAddress;

	private static int FindFunction_ParamsSize;

	private static bool FindFunction_InFunctionName_IsValid;

	private static FFieldAddress FindFunction_InFunctionName_PropertyAddress;

	private static int FindFunction_InFunctionName_Offset;

	private static bool FindFunction_ReturnValue_IsValid;

	private static FFieldAddress FindFunction_ReturnValue_PropertyAddress;

	private static int FindFunction_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetReferencesForFunction")]
	public unsafe List<TSoftObject<URigVMFunctionReferenceNode>> GetReferencesForFunction(FName InFunctionName)
	{
		CheckDestroyed();
		if (!GetReferencesForFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetReferencesForFunction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferencesForFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferencesForFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetReferencesForFunction_InFunctionName_Offset), 0, GetReferencesForFunction_InFunctionName_PropertyAddress.Address, InFunctionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReferencesForFunction_FunctionAddress, intPtr, GetReferencesForFunction_ParamsSize);
		List<TSoftObject<URigVMFunctionReferenceNode>> result = new TArrayCopyMarshaler<TSoftObject<URigVMFunctionReferenceNode>>(1, GetReferencesForFunction_ReturnValue_PropertyAddress, CachedMarshalingDelegates<TSoftObject<URigVMFunctionReferenceNode>, TSoftObjectMarshaler<URigVMFunctionReferenceNode>>.FromNative, CachedMarshalingDelegates<TSoftObject<URigVMFunctionReferenceNode>, TSoftObjectMarshaler<URigVMFunctionReferenceNode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetReferencesForFunction_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetReferencesForFunction_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetReferencePathsForFunction")]
	public unsafe List<string> GetReferencePathsForFunction(FName InFunctionName)
	{
		CheckDestroyed();
		if (!GetReferencePathsForFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetReferencePathsForFunction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferencePathsForFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferencePathsForFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetReferencePathsForFunction_InFunctionName_Offset), 0, GetReferencePathsForFunction_InFunctionName_PropertyAddress.Address, InFunctionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReferencePathsForFunction_FunctionAddress, intPtr, GetReferencePathsForFunction_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetReferencePathsForFunction_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetReferencePathsForFunction_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetReferencePathsForFunction_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetFunctions")]
	public unsafe List<URigVMLibraryNode> GetFunctions()
	{
		CheckDestroyed();
		if (!GetFunctions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetFunctions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFunctions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFunctions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFunctions_FunctionAddress, intPtr, GetFunctions_ParamsSize);
		List<URigVMLibraryNode> result = new TArrayCopyMarshaler<URigVMLibraryNode>(1, GetFunctions_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.FromNative, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetFunctions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetFunctions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMFunctionLibrary:FindFunctionForNode")]
	public unsafe URigVMLibraryNode FindFunctionForNode(URigVMNode InNode)
	{
		CheckDestroyed();
		if (!FindFunctionForNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMFunctionLibrary:FindFunctionForNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindFunctionForNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindFunctionForNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, FindFunctionForNode_InNode_Offset), 0, FindFunctionForNode_InNode_PropertyAddress.Address, InNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindFunctionForNode_FunctionAddress, intPtr, FindFunctionForNode_ParamsSize);
		return UObjectMarshaler<URigVMLibraryNode>.FromNative(IntPtr.Add(intPtr, FindFunctionForNode_ReturnValue_Offset), 0, FindFunctionForNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMFunctionLibrary:FindFunction")]
	public new unsafe URigVMLibraryNode FindFunction(FName InFunctionName)
	{
		CheckDestroyed();
		if (!FindFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMFunctionLibrary:FindFunction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindFunction_InFunctionName_Offset), 0, FindFunction_InFunctionName_PropertyAddress.Address, InFunctionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindFunction_FunctionAddress, intPtr, FindFunction_ParamsSize);
		return UObjectMarshaler<URigVMLibraryNode>.FromNative(IntPtr.Add(intPtr, FindFunction_ReturnValue_Offset), 0, FindFunction_ReturnValue_PropertyAddress.Address);
	}

	static URigVMFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMFunctionLibrary");
		GetReferencesForFunction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetReferencesForFunction");
		GetReferencesForFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferencesForFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferencesForFunction_InFunctionName_PropertyAddress, GetReferencesForFunction_FunctionAddress, "InFunctionName");
		GetReferencesForFunction_InFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencesForFunction_FunctionAddress, "InFunctionName");
		GetReferencesForFunction_InFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencesForFunction_FunctionAddress, "InFunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferencesForFunction_ReturnValue_PropertyAddress, GetReferencesForFunction_FunctionAddress, "ReturnValue");
		GetReferencesForFunction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencesForFunction_FunctionAddress, "ReturnValue");
		GetReferencesForFunction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencesForFunction_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetReferencesForFunction_IsValid = GetReferencesForFunction_FunctionAddress != IntPtr.Zero && GetReferencesForFunction_InFunctionName_IsValid && GetReferencesForFunction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetReferencesForFunction", GetReferencesForFunction_IsValid);
		GetReferencePathsForFunction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetReferencePathsForFunction");
		GetReferencePathsForFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferencePathsForFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferencePathsForFunction_InFunctionName_PropertyAddress, GetReferencePathsForFunction_FunctionAddress, "InFunctionName");
		GetReferencePathsForFunction_InFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencePathsForFunction_FunctionAddress, "InFunctionName");
		GetReferencePathsForFunction_InFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencePathsForFunction_FunctionAddress, "InFunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferencePathsForFunction_ReturnValue_PropertyAddress, GetReferencePathsForFunction_FunctionAddress, "ReturnValue");
		GetReferencePathsForFunction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencePathsForFunction_FunctionAddress, "ReturnValue");
		GetReferencePathsForFunction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencePathsForFunction_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetReferencePathsForFunction_IsValid = GetReferencePathsForFunction_FunctionAddress != IntPtr.Zero && GetReferencePathsForFunction_InFunctionName_IsValid && GetReferencePathsForFunction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetReferencePathsForFunction", GetReferencePathsForFunction_IsValid);
		GetFunctions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFunctions");
		GetFunctions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFunctions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFunctions_ReturnValue_PropertyAddress, GetFunctions_FunctionAddress, "ReturnValue");
		GetFunctions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFunctions_FunctionAddress, "ReturnValue");
		GetFunctions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFunctions_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetFunctions_IsValid = GetFunctions_FunctionAddress != IntPtr.Zero && GetFunctions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMFunctionLibrary:GetFunctions", GetFunctions_IsValid);
		FindFunctionForNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindFunctionForNode");
		FindFunctionForNode_ParamsSize = NativeReflection.GetFunctionParamsSize(FindFunctionForNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindFunctionForNode_InNode_PropertyAddress, FindFunctionForNode_FunctionAddress, "InNode");
		FindFunctionForNode_InNode_Offset = NativeReflectionCached.GetPropertyOffset(FindFunctionForNode_FunctionAddress, "InNode");
		FindFunctionForNode_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFunctionForNode_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindFunctionForNode_ReturnValue_PropertyAddress, FindFunctionForNode_FunctionAddress, "ReturnValue");
		FindFunctionForNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindFunctionForNode_FunctionAddress, "ReturnValue");
		FindFunctionForNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFunctionForNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindFunctionForNode_IsValid = FindFunctionForNode_FunctionAddress != IntPtr.Zero && FindFunctionForNode_InNode_IsValid && FindFunctionForNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMFunctionLibrary:FindFunctionForNode", FindFunctionForNode_IsValid);
		FindFunction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindFunction");
		FindFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(FindFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindFunction_InFunctionName_PropertyAddress, FindFunction_FunctionAddress, "InFunctionName");
		FindFunction_InFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(FindFunction_FunctionAddress, "InFunctionName");
		FindFunction_InFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFunction_FunctionAddress, "InFunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindFunction_ReturnValue_PropertyAddress, FindFunction_FunctionAddress, "ReturnValue");
		FindFunction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindFunction_FunctionAddress, "ReturnValue");
		FindFunction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFunction_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindFunction_IsValid = FindFunction_FunctionAddress != IntPtr.Zero && FindFunction_InFunctionName_IsValid && FindFunction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMFunctionLibrary:FindFunction", FindFunction_IsValid);
	}
}
