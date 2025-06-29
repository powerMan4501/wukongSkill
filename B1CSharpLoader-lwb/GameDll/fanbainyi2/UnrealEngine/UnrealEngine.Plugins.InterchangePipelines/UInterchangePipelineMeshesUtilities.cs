using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangePipelines;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities", "InterchangePipelines", UnrealModuleType.EnginePlugin)]
public class UInterchangePipelineMeshesUtilities : UObject
{
	private static IntPtr classAddress;

	private static bool IsValidMeshInstanceUid_IsValid;

	private static IntPtr IsValidMeshInstanceUid_FunctionAddress;

	private static int IsValidMeshInstanceUid_ParamsSize;

	private static bool IsValidMeshInstanceUid_MeshInstanceUid_IsValid;

	private static FFieldAddress IsValidMeshInstanceUid_MeshInstanceUid_PropertyAddress;

	private static int IsValidMeshInstanceUid_MeshInstanceUid_Offset;

	private static bool IsValidMeshInstanceUid_ReturnValue_IsValid;

	private static FFieldAddress IsValidMeshInstanceUid_ReturnValue_PropertyAddress;

	private static int IsValidMeshInstanceUid_ReturnValue_Offset;

	private static bool IsValidMeshGeometryUid_IsValid;

	private static IntPtr IsValidMeshGeometryUid_FunctionAddress;

	private static int IsValidMeshGeometryUid_ParamsSize;

	private static bool IsValidMeshGeometryUid_MeshGeometryUid_IsValid;

	private static FFieldAddress IsValidMeshGeometryUid_MeshGeometryUid_PropertyAddress;

	private static int IsValidMeshGeometryUid_MeshGeometryUid_Offset;

	private static bool IsValidMeshGeometryUid_ReturnValue_IsValid;

	private static FFieldAddress IsValidMeshGeometryUid_ReturnValue_PropertyAddress;

	private static int IsValidMeshGeometryUid_ReturnValue_Offset;

	private static bool GetMeshInstanceSkeletonRootUid_IsValid;

	private static IntPtr GetMeshInstanceSkeletonRootUid_FunctionAddress;

	private static int GetMeshInstanceSkeletonRootUid_ParamsSize;

	private static bool GetMeshInstanceSkeletonRootUid_MeshInstanceUid_IsValid;

	private static FFieldAddress GetMeshInstanceSkeletonRootUid_MeshInstanceUid_PropertyAddress;

	private static int GetMeshInstanceSkeletonRootUid_MeshInstanceUid_Offset;

	private static bool GetMeshInstanceSkeletonRootUid_ReturnValue_IsValid;

	private static FFieldAddress GetMeshInstanceSkeletonRootUid_ReturnValue_PropertyAddress;

	private static int GetMeshInstanceSkeletonRootUid_ReturnValue_Offset;

	private static bool GetMeshInstanceByUid_IsValid;

	private static IntPtr GetMeshInstanceByUid_FunctionAddress;

	private static int GetMeshInstanceByUid_ParamsSize;

	private static bool GetMeshInstanceByUid_MeshInstanceUid_IsValid;

	private static FFieldAddress GetMeshInstanceByUid_MeshInstanceUid_PropertyAddress;

	private static int GetMeshInstanceByUid_MeshInstanceUid_Offset;

	private static bool GetMeshInstanceByUid_ReturnValue_IsValid;

	private static FFieldAddress GetMeshInstanceByUid_ReturnValue_PropertyAddress;

	private static int GetMeshInstanceByUid_ReturnValue_Offset;

	private static bool GetMeshGeometrySkeletonRootUid_IsValid;

	private static IntPtr GetMeshGeometrySkeletonRootUid_FunctionAddress;

	private static int GetMeshGeometrySkeletonRootUid_ParamsSize;

	private static bool GetMeshGeometrySkeletonRootUid_MeshGeometryUid_IsValid;

	private static FFieldAddress GetMeshGeometrySkeletonRootUid_MeshGeometryUid_PropertyAddress;

	private static int GetMeshGeometrySkeletonRootUid_MeshGeometryUid_Offset;

	private static bool GetMeshGeometrySkeletonRootUid_ReturnValue_IsValid;

	private static FFieldAddress GetMeshGeometrySkeletonRootUid_ReturnValue_PropertyAddress;

	private static int GetMeshGeometrySkeletonRootUid_ReturnValue_Offset;

	private static bool GetMeshGeometryByUid_IsValid;

	private static IntPtr GetMeshGeometryByUid_FunctionAddress;

	private static int GetMeshGeometryByUid_ParamsSize;

	private static bool GetMeshGeometryByUid_MeshGeometryUid_IsValid;

	private static FFieldAddress GetMeshGeometryByUid_MeshGeometryUid_PropertyAddress;

	private static int GetMeshGeometryByUid_MeshGeometryUid_Offset;

	private static bool GetMeshGeometryByUid_ReturnValue_IsValid;

	private static FFieldAddress GetMeshGeometryByUid_ReturnValue_PropertyAddress;

	private static int GetMeshGeometryByUid_ReturnValue_Offset;

	private static bool GetAllStaticMeshInstance_IsValid;

	private static IntPtr GetAllStaticMeshInstance_FunctionAddress;

	private static int GetAllStaticMeshInstance_ParamsSize;

	private static bool GetAllStaticMeshInstance_MeshInstanceUids_IsValid;

	private static FFieldAddress GetAllStaticMeshInstance_MeshInstanceUids_PropertyAddress;

	private static int GetAllStaticMeshInstance_MeshInstanceUids_Offset;

	private static bool GetAllStaticMeshGeometry_IsValid;

	private static IntPtr GetAllStaticMeshGeometry_FunctionAddress;

	private static int GetAllStaticMeshGeometry_ParamsSize;

	private static bool GetAllStaticMeshGeometry_MeshGeometryUids_IsValid;

	private static FFieldAddress GetAllStaticMeshGeometry_MeshGeometryUids_PropertyAddress;

	private static int GetAllStaticMeshGeometry_MeshGeometryUids_Offset;

	private static bool GetAllSkinnedMeshInstance_IsValid;

	private static IntPtr GetAllSkinnedMeshInstance_FunctionAddress;

	private static int GetAllSkinnedMeshInstance_ParamsSize;

	private static bool GetAllSkinnedMeshInstance_MeshInstanceUids_IsValid;

	private static FFieldAddress GetAllSkinnedMeshInstance_MeshInstanceUids_PropertyAddress;

	private static int GetAllSkinnedMeshInstance_MeshInstanceUids_Offset;

	private static bool GetAllSkinnedMeshGeometry_IsValid;

	private static IntPtr GetAllSkinnedMeshGeometry_FunctionAddress;

	private static int GetAllSkinnedMeshGeometry_ParamsSize;

	private static bool GetAllSkinnedMeshGeometry_MeshGeometryUids_IsValid;

	private static FFieldAddress GetAllSkinnedMeshGeometry_MeshGeometryUids_PropertyAddress;

	private static int GetAllSkinnedMeshGeometry_MeshGeometryUids_Offset;

	private static bool GetAllMeshInstanceUidsUsingMeshGeometryUid_IsValid;

	private static IntPtr GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress;

	private static int GetAllMeshInstanceUidsUsingMeshGeometryUid_ParamsSize;

	private static bool GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_IsValid;

	private static FFieldAddress GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_PropertyAddress;

	private static int GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_Offset;

	private static bool GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_IsValid;

	private static FFieldAddress GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_PropertyAddress;

	private static int GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_Offset;

	private static bool GetAllMeshInstanceUids_IsValid;

	private static IntPtr GetAllMeshInstanceUids_FunctionAddress;

	private static int GetAllMeshInstanceUids_ParamsSize;

	private static bool GetAllMeshInstanceUids_MeshInstanceUids_IsValid;

	private static FFieldAddress GetAllMeshInstanceUids_MeshInstanceUids_PropertyAddress;

	private static int GetAllMeshInstanceUids_MeshInstanceUids_Offset;

	private static bool GetAllMeshGeometryNotInstanced_IsValid;

	private static IntPtr GetAllMeshGeometryNotInstanced_FunctionAddress;

	private static int GetAllMeshGeometryNotInstanced_ParamsSize;

	private static bool GetAllMeshGeometryNotInstanced_MeshGeometryUids_IsValid;

	private static FFieldAddress GetAllMeshGeometryNotInstanced_MeshGeometryUids_PropertyAddress;

	private static int GetAllMeshGeometryNotInstanced_MeshGeometryUids_Offset;

	private static bool GetAllMeshGeometry_IsValid;

	private static IntPtr GetAllMeshGeometry_FunctionAddress;

	private static int GetAllMeshGeometry_ParamsSize;

	private static bool GetAllMeshGeometry_MeshGeometryUids_IsValid;

	private static FFieldAddress GetAllMeshGeometry_MeshGeometryUids_PropertyAddress;

	private static int GetAllMeshGeometry_MeshGeometryUids_Offset;

	private static bool CreateInterchangePipelineMeshesUtilities_IsValid;

	private static IntPtr CreateInterchangePipelineMeshesUtilities_FunctionAddress;

	private static int CreateInterchangePipelineMeshesUtilities_ParamsSize;

	private static bool CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_IsValid;

	private static FFieldAddress CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_PropertyAddress;

	private static int CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_Offset;

	private static bool CreateInterchangePipelineMeshesUtilities_ReturnValue_IsValid;

	private static FFieldAddress CreateInterchangePipelineMeshesUtilities_ReturnValue_PropertyAddress;

	private static int CreateInterchangePipelineMeshesUtilities_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshInstanceUid")]
	public unsafe bool IsValidMeshInstanceUid(string MeshInstanceUid)
	{
		CheckDestroyed();
		if (!IsValidMeshInstanceUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshInstanceUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidMeshInstanceUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidMeshInstanceUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsValidMeshInstanceUid_MeshInstanceUid_Offset), 0, IsValidMeshInstanceUid_MeshInstanceUid_PropertyAddress.Address, MeshInstanceUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidMeshInstanceUid_FunctionAddress, intPtr, IsValidMeshInstanceUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsValidMeshInstanceUid_MeshInstanceUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidMeshInstanceUid_ReturnValue_Offset), 0, IsValidMeshInstanceUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshGeometryUid")]
	public unsafe bool IsValidMeshGeometryUid(string MeshGeometryUid)
	{
		CheckDestroyed();
		if (!IsValidMeshGeometryUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshGeometryUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidMeshGeometryUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidMeshGeometryUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsValidMeshGeometryUid_MeshGeometryUid_Offset), 0, IsValidMeshGeometryUid_MeshGeometryUid_PropertyAddress.Address, MeshGeometryUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidMeshGeometryUid_FunctionAddress, intPtr, IsValidMeshGeometryUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsValidMeshGeometryUid_MeshGeometryUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidMeshGeometryUid_ReturnValue_Offset), 0, IsValidMeshGeometryUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceSkeletonRootUid")]
	public unsafe string GetMeshInstanceSkeletonRootUid(string MeshInstanceUid)
	{
		CheckDestroyed();
		if (!GetMeshInstanceSkeletonRootUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceSkeletonRootUid");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshInstanceSkeletonRootUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshInstanceSkeletonRootUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetMeshInstanceSkeletonRootUid_MeshInstanceUid_Offset), 0, GetMeshInstanceSkeletonRootUid_MeshInstanceUid_PropertyAddress.Address, MeshInstanceUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshInstanceSkeletonRootUid_FunctionAddress, intPtr, GetMeshInstanceSkeletonRootUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMeshInstanceSkeletonRootUid_MeshInstanceUid_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMeshInstanceSkeletonRootUid_ReturnValue_Offset), 0, GetMeshInstanceSkeletonRootUid_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMeshInstanceSkeletonRootUid_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceByUid")]
	public unsafe FInterchangeMeshInstance GetMeshInstanceByUid(string MeshInstanceUid)
	{
		CheckDestroyed();
		if (!GetMeshInstanceByUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceByUid");
			return default(FInterchangeMeshInstance);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshInstanceByUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshInstanceByUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetMeshInstanceByUid_MeshInstanceUid_Offset), 0, GetMeshInstanceByUid_MeshInstanceUid_PropertyAddress.Address, MeshInstanceUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshInstanceByUid_FunctionAddress, intPtr, GetMeshInstanceByUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMeshInstanceByUid_MeshInstanceUid_PropertyAddress.Address, intPtr);
		FInterchangeMeshInstance result = FInterchangeMeshInstance.FromNative(IntPtr.Add(intPtr, GetMeshInstanceByUid_ReturnValue_Offset), 0, GetMeshInstanceByUid_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMeshInstanceByUid_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometrySkeletonRootUid")]
	public unsafe string GetMeshGeometrySkeletonRootUid(string MeshGeometryUid)
	{
		CheckDestroyed();
		if (!GetMeshGeometrySkeletonRootUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometrySkeletonRootUid");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshGeometrySkeletonRootUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshGeometrySkeletonRootUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetMeshGeometrySkeletonRootUid_MeshGeometryUid_Offset), 0, GetMeshGeometrySkeletonRootUid_MeshGeometryUid_PropertyAddress.Address, MeshGeometryUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshGeometrySkeletonRootUid_FunctionAddress, intPtr, GetMeshGeometrySkeletonRootUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMeshGeometrySkeletonRootUid_MeshGeometryUid_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMeshGeometrySkeletonRootUid_ReturnValue_Offset), 0, GetMeshGeometrySkeletonRootUid_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMeshGeometrySkeletonRootUid_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometryByUid")]
	public unsafe FInterchangeMeshGeometry GetMeshGeometryByUid(string MeshGeometryUid)
	{
		CheckDestroyed();
		if (!GetMeshGeometryByUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometryByUid");
			return default(FInterchangeMeshGeometry);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshGeometryByUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshGeometryByUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetMeshGeometryByUid_MeshGeometryUid_Offset), 0, GetMeshGeometryByUid_MeshGeometryUid_PropertyAddress.Address, MeshGeometryUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshGeometryByUid_FunctionAddress, intPtr, GetMeshGeometryByUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMeshGeometryByUid_MeshGeometryUid_PropertyAddress.Address, intPtr);
		FInterchangeMeshGeometry result = FInterchangeMeshGeometry.FromNative(IntPtr.Add(intPtr, GetMeshGeometryByUid_ReturnValue_Offset), 0, GetMeshGeometryByUid_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMeshGeometryByUid_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllStaticMeshInstance")]
	public unsafe void GetAllStaticMeshInstance(out List<string> MeshInstanceUids)
	{
		CheckDestroyed();
		if (!GetAllStaticMeshInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllStaticMeshInstance");
			MeshInstanceUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllStaticMeshInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllStaticMeshInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllStaticMeshInstance_FunctionAddress, intPtr, GetAllStaticMeshInstance_ParamsSize);
		MeshInstanceUids = new TArrayCopyMarshaler<string>(1, GetAllStaticMeshInstance_MeshInstanceUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllStaticMeshInstance_MeshInstanceUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllStaticMeshInstance_MeshInstanceUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllStaticMeshGeometry")]
	public unsafe void GetAllStaticMeshGeometry(out List<string> MeshGeometryUids)
	{
		CheckDestroyed();
		if (!GetAllStaticMeshGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllStaticMeshGeometry");
			MeshGeometryUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllStaticMeshGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllStaticMeshGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllStaticMeshGeometry_FunctionAddress, intPtr, GetAllStaticMeshGeometry_ParamsSize);
		MeshGeometryUids = new TArrayCopyMarshaler<string>(1, GetAllStaticMeshGeometry_MeshGeometryUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllStaticMeshGeometry_MeshGeometryUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllStaticMeshGeometry_MeshGeometryUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllSkinnedMeshInstance")]
	public unsafe void GetAllSkinnedMeshInstance(out List<string> MeshInstanceUids)
	{
		CheckDestroyed();
		if (!GetAllSkinnedMeshInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllSkinnedMeshInstance");
			MeshInstanceUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllSkinnedMeshInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllSkinnedMeshInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllSkinnedMeshInstance_FunctionAddress, intPtr, GetAllSkinnedMeshInstance_ParamsSize);
		MeshInstanceUids = new TArrayCopyMarshaler<string>(1, GetAllSkinnedMeshInstance_MeshInstanceUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllSkinnedMeshInstance_MeshInstanceUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllSkinnedMeshInstance_MeshInstanceUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllSkinnedMeshGeometry")]
	public unsafe void GetAllSkinnedMeshGeometry(out List<string> MeshGeometryUids)
	{
		CheckDestroyed();
		if (!GetAllSkinnedMeshGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllSkinnedMeshGeometry");
			MeshGeometryUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllSkinnedMeshGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllSkinnedMeshGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllSkinnedMeshGeometry_FunctionAddress, intPtr, GetAllSkinnedMeshGeometry_ParamsSize);
		MeshGeometryUids = new TArrayCopyMarshaler<string>(1, GetAllSkinnedMeshGeometry_MeshGeometryUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllSkinnedMeshGeometry_MeshGeometryUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllSkinnedMeshGeometry_MeshGeometryUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshInstanceUidsUsingMeshGeometryUid")]
	public unsafe void GetAllMeshInstanceUidsUsingMeshGeometryUid(string MeshGeometryUid, out List<string> MeshInstanceUids)
	{
		CheckDestroyed();
		if (!GetAllMeshInstanceUidsUsingMeshGeometryUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshInstanceUidsUsingMeshGeometryUid");
			MeshInstanceUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllMeshInstanceUidsUsingMeshGeometryUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllMeshInstanceUidsUsingMeshGeometryUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_Offset), 0, GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_PropertyAddress.Address, MeshGeometryUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress, intPtr, GetAllMeshInstanceUidsUsingMeshGeometryUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_PropertyAddress.Address, intPtr);
		MeshInstanceUids = new TArrayCopyMarshaler<string>(1, GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshInstanceUids")]
	public unsafe void GetAllMeshInstanceUids(out List<string> MeshInstanceUids)
	{
		CheckDestroyed();
		if (!GetAllMeshInstanceUids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshInstanceUids");
			MeshInstanceUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllMeshInstanceUids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllMeshInstanceUids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllMeshInstanceUids_FunctionAddress, intPtr, GetAllMeshInstanceUids_ParamsSize);
		MeshInstanceUids = new TArrayCopyMarshaler<string>(1, GetAllMeshInstanceUids_MeshInstanceUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllMeshInstanceUids_MeshInstanceUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllMeshInstanceUids_MeshInstanceUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshGeometryNotInstanced")]
	public unsafe void GetAllMeshGeometryNotInstanced(out List<string> MeshGeometryUids)
	{
		CheckDestroyed();
		if (!GetAllMeshGeometryNotInstanced_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshGeometryNotInstanced");
			MeshGeometryUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllMeshGeometryNotInstanced_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllMeshGeometryNotInstanced_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllMeshGeometryNotInstanced_FunctionAddress, intPtr, GetAllMeshGeometryNotInstanced_ParamsSize);
		MeshGeometryUids = new TArrayCopyMarshaler<string>(1, GetAllMeshGeometryNotInstanced_MeshGeometryUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllMeshGeometryNotInstanced_MeshGeometryUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllMeshGeometryNotInstanced_MeshGeometryUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshGeometry")]
	public unsafe void GetAllMeshGeometry(out List<string> MeshGeometryUids)
	{
		CheckDestroyed();
		if (!GetAllMeshGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshGeometry");
			MeshGeometryUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllMeshGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllMeshGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllMeshGeometry_FunctionAddress, intPtr, GetAllMeshGeometry_ParamsSize);
		MeshGeometryUids = new TArrayCopyMarshaler<string>(1, GetAllMeshGeometry_MeshGeometryUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllMeshGeometry_MeshGeometryUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllMeshGeometry_MeshGeometryUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:CreateInterchangePipelineMeshesUtilities")]
	public unsafe static UInterchangePipelineMeshesUtilities CreateInterchangePipelineMeshesUtilities(UInterchangeBaseNodeContainer BaseNodeContainer)
	{
		if (!CreateInterchangePipelineMeshesUtilities_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:CreateInterchangePipelineMeshesUtilities");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateInterchangePipelineMeshesUtilities_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateInterchangePipelineMeshesUtilities_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNodeContainer>.ToNative(IntPtr.Add(intPtr, CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_Offset), 0, CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_PropertyAddress.Address, BaseNodeContainer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateInterchangePipelineMeshesUtilities_FunctionAddress, intPtr, CreateInterchangePipelineMeshesUtilities_ParamsSize);
		return UObjectMarshaler<UInterchangePipelineMeshesUtilities>.FromNative(IntPtr.Add(intPtr, CreateInterchangePipelineMeshesUtilities_ReturnValue_Offset), 0, CreateInterchangePipelineMeshesUtilities_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangePipelineMeshesUtilities()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangePipelineMeshesUtilities)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangePipelineMeshesUtilities));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities");
		IsValidMeshInstanceUid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidMeshInstanceUid");
		IsValidMeshInstanceUid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidMeshInstanceUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidMeshInstanceUid_MeshInstanceUid_PropertyAddress, IsValidMeshInstanceUid_FunctionAddress, "MeshInstanceUid");
		IsValidMeshInstanceUid_MeshInstanceUid_Offset = NativeReflectionCached.GetPropertyOffset(IsValidMeshInstanceUid_FunctionAddress, "MeshInstanceUid");
		IsValidMeshInstanceUid_MeshInstanceUid_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidMeshInstanceUid_FunctionAddress, "MeshInstanceUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidMeshInstanceUid_ReturnValue_PropertyAddress, IsValidMeshInstanceUid_FunctionAddress, "ReturnValue");
		IsValidMeshInstanceUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidMeshInstanceUid_FunctionAddress, "ReturnValue");
		IsValidMeshInstanceUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidMeshInstanceUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidMeshInstanceUid_IsValid = IsValidMeshInstanceUid_FunctionAddress != IntPtr.Zero && IsValidMeshInstanceUid_MeshInstanceUid_IsValid && IsValidMeshInstanceUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshInstanceUid", IsValidMeshInstanceUid_IsValid);
		IsValidMeshGeometryUid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidMeshGeometryUid");
		IsValidMeshGeometryUid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidMeshGeometryUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidMeshGeometryUid_MeshGeometryUid_PropertyAddress, IsValidMeshGeometryUid_FunctionAddress, "MeshGeometryUid");
		IsValidMeshGeometryUid_MeshGeometryUid_Offset = NativeReflectionCached.GetPropertyOffset(IsValidMeshGeometryUid_FunctionAddress, "MeshGeometryUid");
		IsValidMeshGeometryUid_MeshGeometryUid_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidMeshGeometryUid_FunctionAddress, "MeshGeometryUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidMeshGeometryUid_ReturnValue_PropertyAddress, IsValidMeshGeometryUid_FunctionAddress, "ReturnValue");
		IsValidMeshGeometryUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidMeshGeometryUid_FunctionAddress, "ReturnValue");
		IsValidMeshGeometryUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidMeshGeometryUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidMeshGeometryUid_IsValid = IsValidMeshGeometryUid_FunctionAddress != IntPtr.Zero && IsValidMeshGeometryUid_MeshGeometryUid_IsValid && IsValidMeshGeometryUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:IsValidMeshGeometryUid", IsValidMeshGeometryUid_IsValid);
		GetMeshInstanceSkeletonRootUid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshInstanceSkeletonRootUid");
		GetMeshInstanceSkeletonRootUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshInstanceSkeletonRootUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshInstanceSkeletonRootUid_MeshInstanceUid_PropertyAddress, GetMeshInstanceSkeletonRootUid_FunctionAddress, "MeshInstanceUid");
		GetMeshInstanceSkeletonRootUid_MeshInstanceUid_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshInstanceSkeletonRootUid_FunctionAddress, "MeshInstanceUid");
		GetMeshInstanceSkeletonRootUid_MeshInstanceUid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshInstanceSkeletonRootUid_FunctionAddress, "MeshInstanceUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshInstanceSkeletonRootUid_ReturnValue_PropertyAddress, GetMeshInstanceSkeletonRootUid_FunctionAddress, "ReturnValue");
		GetMeshInstanceSkeletonRootUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshInstanceSkeletonRootUid_FunctionAddress, "ReturnValue");
		GetMeshInstanceSkeletonRootUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshInstanceSkeletonRootUid_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMeshInstanceSkeletonRootUid_IsValid = GetMeshInstanceSkeletonRootUid_FunctionAddress != IntPtr.Zero && GetMeshInstanceSkeletonRootUid_MeshInstanceUid_IsValid && GetMeshInstanceSkeletonRootUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceSkeletonRootUid", GetMeshInstanceSkeletonRootUid_IsValid);
		GetMeshInstanceByUid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshInstanceByUid");
		GetMeshInstanceByUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshInstanceByUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshInstanceByUid_MeshInstanceUid_PropertyAddress, GetMeshInstanceByUid_FunctionAddress, "MeshInstanceUid");
		GetMeshInstanceByUid_MeshInstanceUid_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshInstanceByUid_FunctionAddress, "MeshInstanceUid");
		GetMeshInstanceByUid_MeshInstanceUid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshInstanceByUid_FunctionAddress, "MeshInstanceUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshInstanceByUid_ReturnValue_PropertyAddress, GetMeshInstanceByUid_FunctionAddress, "ReturnValue");
		GetMeshInstanceByUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshInstanceByUid_FunctionAddress, "ReturnValue");
		GetMeshInstanceByUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshInstanceByUid_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMeshInstanceByUid_IsValid = GetMeshInstanceByUid_FunctionAddress != IntPtr.Zero && GetMeshInstanceByUid_MeshInstanceUid_IsValid && GetMeshInstanceByUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshInstanceByUid", GetMeshInstanceByUid_IsValid);
		GetMeshGeometrySkeletonRootUid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshGeometrySkeletonRootUid");
		GetMeshGeometrySkeletonRootUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshGeometrySkeletonRootUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshGeometrySkeletonRootUid_MeshGeometryUid_PropertyAddress, GetMeshGeometrySkeletonRootUid_FunctionAddress, "MeshGeometryUid");
		GetMeshGeometrySkeletonRootUid_MeshGeometryUid_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshGeometrySkeletonRootUid_FunctionAddress, "MeshGeometryUid");
		GetMeshGeometrySkeletonRootUid_MeshGeometryUid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshGeometrySkeletonRootUid_FunctionAddress, "MeshGeometryUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshGeometrySkeletonRootUid_ReturnValue_PropertyAddress, GetMeshGeometrySkeletonRootUid_FunctionAddress, "ReturnValue");
		GetMeshGeometrySkeletonRootUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshGeometrySkeletonRootUid_FunctionAddress, "ReturnValue");
		GetMeshGeometrySkeletonRootUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshGeometrySkeletonRootUid_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMeshGeometrySkeletonRootUid_IsValid = GetMeshGeometrySkeletonRootUid_FunctionAddress != IntPtr.Zero && GetMeshGeometrySkeletonRootUid_MeshGeometryUid_IsValid && GetMeshGeometrySkeletonRootUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometrySkeletonRootUid", GetMeshGeometrySkeletonRootUid_IsValid);
		GetMeshGeometryByUid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshGeometryByUid");
		GetMeshGeometryByUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshGeometryByUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshGeometryByUid_MeshGeometryUid_PropertyAddress, GetMeshGeometryByUid_FunctionAddress, "MeshGeometryUid");
		GetMeshGeometryByUid_MeshGeometryUid_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshGeometryByUid_FunctionAddress, "MeshGeometryUid");
		GetMeshGeometryByUid_MeshGeometryUid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshGeometryByUid_FunctionAddress, "MeshGeometryUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshGeometryByUid_ReturnValue_PropertyAddress, GetMeshGeometryByUid_FunctionAddress, "ReturnValue");
		GetMeshGeometryByUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshGeometryByUid_FunctionAddress, "ReturnValue");
		GetMeshGeometryByUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshGeometryByUid_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMeshGeometryByUid_IsValid = GetMeshGeometryByUid_FunctionAddress != IntPtr.Zero && GetMeshGeometryByUid_MeshGeometryUid_IsValid && GetMeshGeometryByUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetMeshGeometryByUid", GetMeshGeometryByUid_IsValid);
		GetAllStaticMeshInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllStaticMeshInstance");
		GetAllStaticMeshInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllStaticMeshInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllStaticMeshInstance_MeshInstanceUids_PropertyAddress, GetAllStaticMeshInstance_FunctionAddress, "MeshInstanceUids");
		GetAllStaticMeshInstance_MeshInstanceUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllStaticMeshInstance_FunctionAddress, "MeshInstanceUids");
		GetAllStaticMeshInstance_MeshInstanceUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllStaticMeshInstance_FunctionAddress, "MeshInstanceUids", Classes.FArrayProperty);
		GetAllStaticMeshInstance_IsValid = GetAllStaticMeshInstance_FunctionAddress != IntPtr.Zero && GetAllStaticMeshInstance_MeshInstanceUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllStaticMeshInstance", GetAllStaticMeshInstance_IsValid);
		GetAllStaticMeshGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllStaticMeshGeometry");
		GetAllStaticMeshGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllStaticMeshGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllStaticMeshGeometry_MeshGeometryUids_PropertyAddress, GetAllStaticMeshGeometry_FunctionAddress, "MeshGeometryUids");
		GetAllStaticMeshGeometry_MeshGeometryUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllStaticMeshGeometry_FunctionAddress, "MeshGeometryUids");
		GetAllStaticMeshGeometry_MeshGeometryUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllStaticMeshGeometry_FunctionAddress, "MeshGeometryUids", Classes.FArrayProperty);
		GetAllStaticMeshGeometry_IsValid = GetAllStaticMeshGeometry_FunctionAddress != IntPtr.Zero && GetAllStaticMeshGeometry_MeshGeometryUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllStaticMeshGeometry", GetAllStaticMeshGeometry_IsValid);
		GetAllSkinnedMeshInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllSkinnedMeshInstance");
		GetAllSkinnedMeshInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSkinnedMeshInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllSkinnedMeshInstance_MeshInstanceUids_PropertyAddress, GetAllSkinnedMeshInstance_FunctionAddress, "MeshInstanceUids");
		GetAllSkinnedMeshInstance_MeshInstanceUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSkinnedMeshInstance_FunctionAddress, "MeshInstanceUids");
		GetAllSkinnedMeshInstance_MeshInstanceUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSkinnedMeshInstance_FunctionAddress, "MeshInstanceUids", Classes.FArrayProperty);
		GetAllSkinnedMeshInstance_IsValid = GetAllSkinnedMeshInstance_FunctionAddress != IntPtr.Zero && GetAllSkinnedMeshInstance_MeshInstanceUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllSkinnedMeshInstance", GetAllSkinnedMeshInstance_IsValid);
		GetAllSkinnedMeshGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllSkinnedMeshGeometry");
		GetAllSkinnedMeshGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSkinnedMeshGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllSkinnedMeshGeometry_MeshGeometryUids_PropertyAddress, GetAllSkinnedMeshGeometry_FunctionAddress, "MeshGeometryUids");
		GetAllSkinnedMeshGeometry_MeshGeometryUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSkinnedMeshGeometry_FunctionAddress, "MeshGeometryUids");
		GetAllSkinnedMeshGeometry_MeshGeometryUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSkinnedMeshGeometry_FunctionAddress, "MeshGeometryUids", Classes.FArrayProperty);
		GetAllSkinnedMeshGeometry_IsValid = GetAllSkinnedMeshGeometry_FunctionAddress != IntPtr.Zero && GetAllSkinnedMeshGeometry_MeshGeometryUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllSkinnedMeshGeometry", GetAllSkinnedMeshGeometry_IsValid);
		GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllMeshInstanceUidsUsingMeshGeometryUid");
		GetAllMeshInstanceUidsUsingMeshGeometryUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_PropertyAddress, GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress, "MeshGeometryUid");
		GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_Offset = NativeReflectionCached.GetPropertyOffset(GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress, "MeshGeometryUid");
		GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress, "MeshGeometryUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_PropertyAddress, GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress, "MeshInstanceUids");
		GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress, "MeshInstanceUids");
		GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress, "MeshInstanceUids", Classes.FArrayProperty);
		GetAllMeshInstanceUidsUsingMeshGeometryUid_IsValid = GetAllMeshInstanceUidsUsingMeshGeometryUid_FunctionAddress != IntPtr.Zero && GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshGeometryUid_IsValid && GetAllMeshInstanceUidsUsingMeshGeometryUid_MeshInstanceUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshInstanceUidsUsingMeshGeometryUid", GetAllMeshInstanceUidsUsingMeshGeometryUid_IsValid);
		GetAllMeshInstanceUids_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllMeshInstanceUids");
		GetAllMeshInstanceUids_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllMeshInstanceUids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllMeshInstanceUids_MeshInstanceUids_PropertyAddress, GetAllMeshInstanceUids_FunctionAddress, "MeshInstanceUids");
		GetAllMeshInstanceUids_MeshInstanceUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllMeshInstanceUids_FunctionAddress, "MeshInstanceUids");
		GetAllMeshInstanceUids_MeshInstanceUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllMeshInstanceUids_FunctionAddress, "MeshInstanceUids", Classes.FArrayProperty);
		GetAllMeshInstanceUids_IsValid = GetAllMeshInstanceUids_FunctionAddress != IntPtr.Zero && GetAllMeshInstanceUids_MeshInstanceUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshInstanceUids", GetAllMeshInstanceUids_IsValid);
		GetAllMeshGeometryNotInstanced_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllMeshGeometryNotInstanced");
		GetAllMeshGeometryNotInstanced_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllMeshGeometryNotInstanced_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllMeshGeometryNotInstanced_MeshGeometryUids_PropertyAddress, GetAllMeshGeometryNotInstanced_FunctionAddress, "MeshGeometryUids");
		GetAllMeshGeometryNotInstanced_MeshGeometryUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllMeshGeometryNotInstanced_FunctionAddress, "MeshGeometryUids");
		GetAllMeshGeometryNotInstanced_MeshGeometryUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllMeshGeometryNotInstanced_FunctionAddress, "MeshGeometryUids", Classes.FArrayProperty);
		GetAllMeshGeometryNotInstanced_IsValid = GetAllMeshGeometryNotInstanced_FunctionAddress != IntPtr.Zero && GetAllMeshGeometryNotInstanced_MeshGeometryUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshGeometryNotInstanced", GetAllMeshGeometryNotInstanced_IsValid);
		GetAllMeshGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllMeshGeometry");
		GetAllMeshGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllMeshGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllMeshGeometry_MeshGeometryUids_PropertyAddress, GetAllMeshGeometry_FunctionAddress, "MeshGeometryUids");
		GetAllMeshGeometry_MeshGeometryUids_Offset = NativeReflectionCached.GetPropertyOffset(GetAllMeshGeometry_FunctionAddress, "MeshGeometryUids");
		GetAllMeshGeometry_MeshGeometryUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllMeshGeometry_FunctionAddress, "MeshGeometryUids", Classes.FArrayProperty);
		GetAllMeshGeometry_IsValid = GetAllMeshGeometry_FunctionAddress != IntPtr.Zero && GetAllMeshGeometry_MeshGeometryUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:GetAllMeshGeometry", GetAllMeshGeometry_IsValid);
		CreateInterchangePipelineMeshesUtilities_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateInterchangePipelineMeshesUtilities");
		CreateInterchangePipelineMeshesUtilities_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInterchangePipelineMeshesUtilities_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_PropertyAddress, CreateInterchangePipelineMeshesUtilities_FunctionAddress, "BaseNodeContainer");
		CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_Offset = NativeReflectionCached.GetPropertyOffset(CreateInterchangePipelineMeshesUtilities_FunctionAddress, "BaseNodeContainer");
		CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInterchangePipelineMeshesUtilities_FunctionAddress, "BaseNodeContainer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInterchangePipelineMeshesUtilities_ReturnValue_PropertyAddress, CreateInterchangePipelineMeshesUtilities_FunctionAddress, "ReturnValue");
		CreateInterchangePipelineMeshesUtilities_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateInterchangePipelineMeshesUtilities_FunctionAddress, "ReturnValue");
		CreateInterchangePipelineMeshesUtilities_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInterchangePipelineMeshesUtilities_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateInterchangePipelineMeshesUtilities_IsValid = CreateInterchangePipelineMeshesUtilities_FunctionAddress != IntPtr.Zero && CreateInterchangePipelineMeshesUtilities_BaseNodeContainer_IsValid && CreateInterchangePipelineMeshesUtilities_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities:CreateInterchangePipelineMeshesUtilities", CreateInterchangePipelineMeshesUtilities_IsValid);
	}
}
