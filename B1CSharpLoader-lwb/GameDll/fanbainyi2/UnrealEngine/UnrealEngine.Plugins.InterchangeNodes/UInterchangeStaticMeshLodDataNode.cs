using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeStaticMeshLodDataNode : UInterchangeBaseNode
{
	private static bool RemoveMeshUid_IsValid;

	private static IntPtr RemoveMeshUid_FunctionAddress;

	private static int RemoveMeshUid_ParamsSize;

	private static bool RemoveMeshUid_MeshName_IsValid;

	private static FFieldAddress RemoveMeshUid_MeshName_PropertyAddress;

	private static int RemoveMeshUid_MeshName_Offset;

	private static bool RemoveMeshUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveMeshUid_ReturnValue_PropertyAddress;

	private static int RemoveMeshUid_ReturnValue_Offset;

	private static bool RemoveAllMeshes_IsValid;

	private static IntPtr RemoveAllMeshes_FunctionAddress;

	private static int RemoveAllMeshes_ParamsSize;

	private static bool RemoveAllMeshes_ReturnValue_IsValid;

	private static FFieldAddress RemoveAllMeshes_ReturnValue_PropertyAddress;

	private static int RemoveAllMeshes_ReturnValue_Offset;

	private static bool GetMeshUidsCount_IsValid;

	private static IntPtr GetMeshUidsCount_FunctionAddress;

	private static int GetMeshUidsCount_ParamsSize;

	private static bool GetMeshUidsCount_ReturnValue_IsValid;

	private static FFieldAddress GetMeshUidsCount_ReturnValue_PropertyAddress;

	private static int GetMeshUidsCount_ReturnValue_Offset;

	private static bool GetMeshUids_IsValid;

	private static IntPtr GetMeshUids_FunctionAddress;

	private static int GetMeshUids_ParamsSize;

	private static bool GetMeshUids_OutMeshNames_IsValid;

	private static FFieldAddress GetMeshUids_OutMeshNames_PropertyAddress;

	private static int GetMeshUids_OutMeshNames_Offset;

	private static bool AddMeshUid_IsValid;

	private static IntPtr AddMeshUid_FunctionAddress;

	private static int AddMeshUid_ParamsSize;

	private static bool AddMeshUid_MeshName_IsValid;

	private static FFieldAddress AddMeshUid_MeshName_PropertyAddress;

	private static int AddMeshUid_MeshName_Offset;

	private static bool AddMeshUid_ReturnValue_IsValid;

	private static FFieldAddress AddMeshUid_ReturnValue_PropertyAddress;

	private static int AddMeshUid_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:RemoveMeshUid")]
	public unsafe bool RemoveMeshUid(string MeshName)
	{
		CheckDestroyed();
		if (!RemoveMeshUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:RemoveMeshUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMeshUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMeshUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveMeshUid_MeshName_Offset), 0, RemoveMeshUid_MeshName_PropertyAddress.Address, MeshName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveMeshUid_FunctionAddress, intPtr, RemoveMeshUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveMeshUid_MeshName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveMeshUid_ReturnValue_Offset), 0, RemoveMeshUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:RemoveAllMeshes")]
	public unsafe bool RemoveAllMeshes()
	{
		CheckDestroyed();
		if (!RemoveAllMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:RemoveAllMeshes");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllMeshes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllMeshes_FunctionAddress, intPtr, RemoveAllMeshes_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAllMeshes_ReturnValue_Offset), 0, RemoveAllMeshes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:GetMeshUidsCount")]
	public unsafe int GetMeshUidsCount()
	{
		CheckDestroyed();
		if (!GetMeshUidsCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:GetMeshUidsCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshUidsCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshUidsCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshUidsCount_FunctionAddress, intPtr, GetMeshUidsCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMeshUidsCount_ReturnValue_Offset), 0, GetMeshUidsCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:GetMeshUids")]
	public unsafe void GetMeshUids(out List<string> OutMeshNames)
	{
		CheckDestroyed();
		if (!GetMeshUids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:GetMeshUids");
			OutMeshNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshUids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshUids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshUids_FunctionAddress, intPtr, GetMeshUids_ParamsSize);
		OutMeshNames = new TArrayCopyMarshaler<string>(1, GetMeshUids_OutMeshNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetMeshUids_OutMeshNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetMeshUids_OutMeshNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:AddMeshUid")]
	public unsafe bool AddMeshUid(string MeshName)
	{
		CheckDestroyed();
		if (!AddMeshUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:AddMeshUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMeshUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMeshUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddMeshUid_MeshName_Offset), 0, AddMeshUid_MeshName_PropertyAddress.Address, MeshName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMeshUid_FunctionAddress, intPtr, AddMeshUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMeshUid_MeshName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddMeshUid_ReturnValue_Offset), 0, AddMeshUid_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeStaticMeshLodDataNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeStaticMeshLodDataNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeStaticMeshLodDataNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode");
		RemoveMeshUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveMeshUid");
		RemoveMeshUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMeshUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMeshUid_MeshName_PropertyAddress, RemoveMeshUid_FunctionAddress, "MeshName");
		RemoveMeshUid_MeshName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMeshUid_FunctionAddress, "MeshName");
		RemoveMeshUid_MeshName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMeshUid_FunctionAddress, "MeshName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMeshUid_ReturnValue_PropertyAddress, RemoveMeshUid_FunctionAddress, "ReturnValue");
		RemoveMeshUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMeshUid_FunctionAddress, "ReturnValue");
		RemoveMeshUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMeshUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveMeshUid_IsValid = RemoveMeshUid_FunctionAddress != IntPtr.Zero && RemoveMeshUid_MeshName_IsValid && RemoveMeshUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:RemoveMeshUid", RemoveMeshUid_IsValid);
		RemoveAllMeshes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllMeshes");
		RemoveAllMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllMeshes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllMeshes_ReturnValue_PropertyAddress, RemoveAllMeshes_FunctionAddress, "ReturnValue");
		RemoveAllMeshes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllMeshes_FunctionAddress, "ReturnValue");
		RemoveAllMeshes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllMeshes_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAllMeshes_IsValid = RemoveAllMeshes_FunctionAddress != IntPtr.Zero && RemoveAllMeshes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:RemoveAllMeshes", RemoveAllMeshes_IsValid);
		GetMeshUidsCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMeshUidsCount");
		GetMeshUidsCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshUidsCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshUidsCount_ReturnValue_PropertyAddress, GetMeshUidsCount_FunctionAddress, "ReturnValue");
		GetMeshUidsCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshUidsCount_FunctionAddress, "ReturnValue");
		GetMeshUidsCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshUidsCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMeshUidsCount_IsValid = GetMeshUidsCount_FunctionAddress != IntPtr.Zero && GetMeshUidsCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:GetMeshUidsCount", GetMeshUidsCount_IsValid);
		GetMeshUids_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMeshUids");
		GetMeshUids_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshUids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshUids_OutMeshNames_PropertyAddress, GetMeshUids_FunctionAddress, "OutMeshNames");
		GetMeshUids_OutMeshNames_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshUids_FunctionAddress, "OutMeshNames");
		GetMeshUids_OutMeshNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshUids_FunctionAddress, "OutMeshNames", Classes.FArrayProperty);
		GetMeshUids_IsValid = GetMeshUids_FunctionAddress != IntPtr.Zero && GetMeshUids_OutMeshNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:GetMeshUids", GetMeshUids_IsValid);
		AddMeshUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddMeshUid");
		AddMeshUid_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMeshUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMeshUid_MeshName_PropertyAddress, AddMeshUid_FunctionAddress, "MeshName");
		AddMeshUid_MeshName_Offset = NativeReflectionCached.GetPropertyOffset(AddMeshUid_FunctionAddress, "MeshName");
		AddMeshUid_MeshName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMeshUid_FunctionAddress, "MeshName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMeshUid_ReturnValue_PropertyAddress, AddMeshUid_FunctionAddress, "ReturnValue");
		AddMeshUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMeshUid_FunctionAddress, "ReturnValue");
		AddMeshUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMeshUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddMeshUid_IsValid = AddMeshUid_FunctionAddress != IntPtr.Zero && AddMeshUid_MeshName_IsValid && AddMeshUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshLodDataNode:AddMeshUid", AddMeshUid_IsValid);
	}
}
