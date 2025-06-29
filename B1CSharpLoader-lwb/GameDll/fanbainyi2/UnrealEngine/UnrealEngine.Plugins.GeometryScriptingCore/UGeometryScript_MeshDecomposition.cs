using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshDecomposition : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SplitMeshByPolygroups_IsValid;

	private static IntPtr SplitMeshByPolygroups_FunctionAddress;

	private static int SplitMeshByPolygroups_ParamsSize;

	private static bool SplitMeshByPolygroups_TargetMesh_IsValid;

	private static FFieldAddress SplitMeshByPolygroups_TargetMesh_PropertyAddress;

	private static int SplitMeshByPolygroups_TargetMesh_Offset;

	private static bool SplitMeshByPolygroups_GroupLayer_IsValid;

	private static FFieldAddress SplitMeshByPolygroups_GroupLayer_PropertyAddress;

	private static int SplitMeshByPolygroups_GroupLayer_Offset;

	private static bool SplitMeshByPolygroups_ComponentMeshes_IsValid;

	private static FFieldAddress SplitMeshByPolygroups_ComponentMeshes_PropertyAddress;

	private static int SplitMeshByPolygroups_ComponentMeshes_Offset;

	private static bool SplitMeshByPolygroups_ComponentPolygroups_IsValid;

	private static FFieldAddress SplitMeshByPolygroups_ComponentPolygroups_PropertyAddress;

	private static int SplitMeshByPolygroups_ComponentPolygroups_Offset;

	private static bool SplitMeshByPolygroups_MeshPool_IsValid;

	private static FFieldAddress SplitMeshByPolygroups_MeshPool_PropertyAddress;

	private static int SplitMeshByPolygroups_MeshPool_Offset;

	private static bool SplitMeshByPolygroups_Debug_IsValid;

	private static FFieldAddress SplitMeshByPolygroups_Debug_PropertyAddress;

	private static int SplitMeshByPolygroups_Debug_Offset;

	private static bool SplitMeshByPolygroups_ReturnValue_IsValid;

	private static FFieldAddress SplitMeshByPolygroups_ReturnValue_PropertyAddress;

	private static int SplitMeshByPolygroups_ReturnValue_Offset;

	private static bool SplitMeshByMaterialIDs_IsValid;

	private static IntPtr SplitMeshByMaterialIDs_FunctionAddress;

	private static int SplitMeshByMaterialIDs_ParamsSize;

	private static bool SplitMeshByMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress SplitMeshByMaterialIDs_TargetMesh_PropertyAddress;

	private static int SplitMeshByMaterialIDs_TargetMesh_Offset;

	private static bool SplitMeshByMaterialIDs_ComponentMeshes_IsValid;

	private static FFieldAddress SplitMeshByMaterialIDs_ComponentMeshes_PropertyAddress;

	private static int SplitMeshByMaterialIDs_ComponentMeshes_Offset;

	private static bool SplitMeshByMaterialIDs_ComponentMaterialIDs_IsValid;

	private static FFieldAddress SplitMeshByMaterialIDs_ComponentMaterialIDs_PropertyAddress;

	private static int SplitMeshByMaterialIDs_ComponentMaterialIDs_Offset;

	private static bool SplitMeshByMaterialIDs_MeshPool_IsValid;

	private static FFieldAddress SplitMeshByMaterialIDs_MeshPool_PropertyAddress;

	private static int SplitMeshByMaterialIDs_MeshPool_Offset;

	private static bool SplitMeshByMaterialIDs_Debug_IsValid;

	private static FFieldAddress SplitMeshByMaterialIDs_Debug_PropertyAddress;

	private static int SplitMeshByMaterialIDs_Debug_Offset;

	private static bool SplitMeshByMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress SplitMeshByMaterialIDs_ReturnValue_PropertyAddress;

	private static int SplitMeshByMaterialIDs_ReturnValue_Offset;

	private static bool SplitMeshByComponents_IsValid;

	private static IntPtr SplitMeshByComponents_FunctionAddress;

	private static int SplitMeshByComponents_ParamsSize;

	private static bool SplitMeshByComponents_TargetMesh_IsValid;

	private static FFieldAddress SplitMeshByComponents_TargetMesh_PropertyAddress;

	private static int SplitMeshByComponents_TargetMesh_Offset;

	private static bool SplitMeshByComponents_ComponentMeshes_IsValid;

	private static FFieldAddress SplitMeshByComponents_ComponentMeshes_PropertyAddress;

	private static int SplitMeshByComponents_ComponentMeshes_Offset;

	private static bool SplitMeshByComponents_MeshPool_IsValid;

	private static FFieldAddress SplitMeshByComponents_MeshPool_PropertyAddress;

	private static int SplitMeshByComponents_MeshPool_Offset;

	private static bool SplitMeshByComponents_Debug_IsValid;

	private static FFieldAddress SplitMeshByComponents_Debug_PropertyAddress;

	private static int SplitMeshByComponents_Debug_Offset;

	private static bool SplitMeshByComponents_ReturnValue_IsValid;

	private static FFieldAddress SplitMeshByComponents_ReturnValue_PropertyAddress;

	private static int SplitMeshByComponents_ReturnValue_Offset;

	private static bool GetSubMeshFromMesh_IsValid;

	private static IntPtr GetSubMeshFromMesh_FunctionAddress;

	private static int GetSubMeshFromMesh_ParamsSize;

	private static bool GetSubMeshFromMesh_TargetMesh_IsValid;

	private static FFieldAddress GetSubMeshFromMesh_TargetMesh_PropertyAddress;

	private static int GetSubMeshFromMesh_TargetMesh_Offset;

	private static bool GetSubMeshFromMesh_StoreToSubmesh_IsValid;

	private static FFieldAddress GetSubMeshFromMesh_StoreToSubmesh_PropertyAddress;

	private static int GetSubMeshFromMesh_StoreToSubmesh_Offset;

	private static bool GetSubMeshFromMesh_TriangleList_IsValid;

	private static FFieldAddress GetSubMeshFromMesh_TriangleList_PropertyAddress;

	private static int GetSubMeshFromMesh_TriangleList_Offset;

	private static bool GetSubMeshFromMesh_StoreToSubmeshOut_IsValid;

	private static FFieldAddress GetSubMeshFromMesh_StoreToSubmeshOut_PropertyAddress;

	private static int GetSubMeshFromMesh_StoreToSubmeshOut_Offset;

	private static bool GetSubMeshFromMesh_Debug_IsValid;

	private static FFieldAddress GetSubMeshFromMesh_Debug_PropertyAddress;

	private static int GetSubMeshFromMesh_Debug_Offset;

	private static bool GetSubMeshFromMesh_ReturnValue_IsValid;

	private static FFieldAddress GetSubMeshFromMesh_ReturnValue_PropertyAddress;

	private static int GetSubMeshFromMesh_ReturnValue_Offset;

	private static bool CopyMeshToMesh_IsValid;

	private static IntPtr CopyMeshToMesh_FunctionAddress;

	private static int CopyMeshToMesh_ParamsSize;

	private static bool CopyMeshToMesh_CopyFromMesh_IsValid;

	private static FFieldAddress CopyMeshToMesh_CopyFromMesh_PropertyAddress;

	private static int CopyMeshToMesh_CopyFromMesh_Offset;

	private static bool CopyMeshToMesh_CopyToMesh_IsValid;

	private static FFieldAddress CopyMeshToMesh_CopyToMesh_PropertyAddress;

	private static int CopyMeshToMesh_CopyToMesh_Offset;

	private static bool CopyMeshToMesh_CopyToMeshOut_IsValid;

	private static FFieldAddress CopyMeshToMesh_CopyToMeshOut_PropertyAddress;

	private static int CopyMeshToMesh_CopyToMeshOut_Offset;

	private static bool CopyMeshToMesh_Debug_IsValid;

	private static FFieldAddress CopyMeshToMesh_Debug_PropertyAddress;

	private static int CopyMeshToMesh_Debug_Offset;

	private static bool CopyMeshToMesh_ReturnValue_IsValid;

	private static FFieldAddress CopyMeshToMesh_ReturnValue_PropertyAddress;

	private static int CopyMeshToMesh_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByPolygroups")]
	public unsafe static UDynamicMesh SplitMeshByPolygroups(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, out List<UDynamicMesh> ComponentMeshes, out List<int> ComponentPolygroups, UDynamicMeshPool MeshPool, UGeometryScriptDebug Debug)
	{
		if (!SplitMeshByPolygroups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByPolygroups");
			ComponentMeshes = null;
			ComponentPolygroups = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SplitMeshByPolygroups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SplitMeshByPolygroups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SplitMeshByPolygroups_TargetMesh_Offset), 0, SplitMeshByPolygroups_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(SplitMeshByPolygroups_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, SplitMeshByPolygroups_GroupLayer_Offset), 0, SplitMeshByPolygroups_GroupLayer_PropertyAddress.Address, GroupLayer);
		UObjectMarshaler<UDynamicMeshPool>.ToNative(IntPtr.Add(intPtr, SplitMeshByPolygroups_MeshPool_Offset), 0, SplitMeshByPolygroups_MeshPool_PropertyAddress.Address, MeshPool);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SplitMeshByPolygroups_Debug_Offset), 0, SplitMeshByPolygroups_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SplitMeshByPolygroups_FunctionAddress, intPtr, SplitMeshByPolygroups_ParamsSize);
		ComponentMeshes = new TArrayCopyMarshaler<UDynamicMesh>(1, SplitMeshByPolygroups_ComponentMeshes_PropertyAddress, CachedMarshalingDelegates<UDynamicMesh, UObjectMarshaler<UDynamicMesh>>.FromNative, CachedMarshalingDelegates<UDynamicMesh, UObjectMarshaler<UDynamicMesh>>.ToNative).FromNative(IntPtr.Add(intPtr, SplitMeshByPolygroups_ComponentMeshes_Offset));
		NativeReflection.DestroyValue_InContainer(SplitMeshByPolygroups_ComponentMeshes_PropertyAddress.Address, intPtr);
		ComponentPolygroups = new TArrayCopyMarshaler<int>(1, SplitMeshByPolygroups_ComponentPolygroups_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, SplitMeshByPolygroups_ComponentPolygroups_Offset));
		NativeReflection.DestroyValue_InContainer(SplitMeshByPolygroups_ComponentPolygroups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SplitMeshByPolygroups_ReturnValue_Offset), 0, SplitMeshByPolygroups_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByMaterialIDs")]
	public unsafe static UDynamicMesh SplitMeshByMaterialIDs(UDynamicMesh TargetMesh, out List<UDynamicMesh> ComponentMeshes, out List<int> ComponentMaterialIDs, UDynamicMeshPool MeshPool, UGeometryScriptDebug Debug)
	{
		if (!SplitMeshByMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByMaterialIDs");
			ComponentMeshes = null;
			ComponentMaterialIDs = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SplitMeshByMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SplitMeshByMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SplitMeshByMaterialIDs_TargetMesh_Offset), 0, SplitMeshByMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMeshPool>.ToNative(IntPtr.Add(intPtr, SplitMeshByMaterialIDs_MeshPool_Offset), 0, SplitMeshByMaterialIDs_MeshPool_PropertyAddress.Address, MeshPool);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SplitMeshByMaterialIDs_Debug_Offset), 0, SplitMeshByMaterialIDs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SplitMeshByMaterialIDs_FunctionAddress, intPtr, SplitMeshByMaterialIDs_ParamsSize);
		ComponentMeshes = new TArrayCopyMarshaler<UDynamicMesh>(1, SplitMeshByMaterialIDs_ComponentMeshes_PropertyAddress, CachedMarshalingDelegates<UDynamicMesh, UObjectMarshaler<UDynamicMesh>>.FromNative, CachedMarshalingDelegates<UDynamicMesh, UObjectMarshaler<UDynamicMesh>>.ToNative).FromNative(IntPtr.Add(intPtr, SplitMeshByMaterialIDs_ComponentMeshes_Offset));
		NativeReflection.DestroyValue_InContainer(SplitMeshByMaterialIDs_ComponentMeshes_PropertyAddress.Address, intPtr);
		ComponentMaterialIDs = new TArrayCopyMarshaler<int>(1, SplitMeshByMaterialIDs_ComponentMaterialIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, SplitMeshByMaterialIDs_ComponentMaterialIDs_Offset));
		NativeReflection.DestroyValue_InContainer(SplitMeshByMaterialIDs_ComponentMaterialIDs_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SplitMeshByMaterialIDs_ReturnValue_Offset), 0, SplitMeshByMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByComponents")]
	public unsafe static UDynamicMesh SplitMeshByComponents(UDynamicMesh TargetMesh, out List<UDynamicMesh> ComponentMeshes, UDynamicMeshPool MeshPool, UGeometryScriptDebug Debug)
	{
		if (!SplitMeshByComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByComponents");
			ComponentMeshes = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SplitMeshByComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SplitMeshByComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SplitMeshByComponents_TargetMesh_Offset), 0, SplitMeshByComponents_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMeshPool>.ToNative(IntPtr.Add(intPtr, SplitMeshByComponents_MeshPool_Offset), 0, SplitMeshByComponents_MeshPool_PropertyAddress.Address, MeshPool);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SplitMeshByComponents_Debug_Offset), 0, SplitMeshByComponents_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SplitMeshByComponents_FunctionAddress, intPtr, SplitMeshByComponents_ParamsSize);
		ComponentMeshes = new TArrayCopyMarshaler<UDynamicMesh>(1, SplitMeshByComponents_ComponentMeshes_PropertyAddress, CachedMarshalingDelegates<UDynamicMesh, UObjectMarshaler<UDynamicMesh>>.FromNative, CachedMarshalingDelegates<UDynamicMesh, UObjectMarshaler<UDynamicMesh>>.ToNative).FromNative(IntPtr.Add(intPtr, SplitMeshByComponents_ComponentMeshes_Offset));
		NativeReflection.DestroyValue_InContainer(SplitMeshByComponents_ComponentMeshes_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SplitMeshByComponents_ReturnValue_Offset), 0, SplitMeshByComponents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:GetSubMeshFromMesh")]
	public unsafe static UDynamicMesh GetSubMeshFromMesh(UDynamicMesh TargetMesh, ref UDynamicMesh StoreToSubmesh, FGeometryScriptIndexList TriangleList, out UDynamicMesh StoreToSubmeshOut, UGeometryScriptDebug Debug)
	{
		if (!GetSubMeshFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:GetSubMeshFromMesh");
			StoreToSubmeshOut = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubMeshFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubMeshFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetSubMeshFromMesh_TargetMesh_Offset), 0, GetSubMeshFromMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetSubMeshFromMesh_StoreToSubmesh_Offset), 0, GetSubMeshFromMesh_StoreToSubmesh_PropertyAddress.Address, StoreToSubmesh);
		NativeReflection.InitializeValue_InContainer(GetSubMeshFromMesh_TriangleList_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, GetSubMeshFromMesh_TriangleList_Offset), 0, GetSubMeshFromMesh_TriangleList_PropertyAddress.Address, TriangleList);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, GetSubMeshFromMesh_Debug_Offset), 0, GetSubMeshFromMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSubMeshFromMesh_FunctionAddress, intPtr, GetSubMeshFromMesh_ParamsSize);
		StoreToSubmesh = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetSubMeshFromMesh_StoreToSubmesh_Offset), 0, GetSubMeshFromMesh_StoreToSubmesh_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSubMeshFromMesh_TriangleList_PropertyAddress.Address, intPtr);
		StoreToSubmeshOut = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetSubMeshFromMesh_StoreToSubmeshOut_Offset), 0, GetSubMeshFromMesh_StoreToSubmeshOut_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetSubMeshFromMesh_ReturnValue_Offset), 0, GetSubMeshFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:CopyMeshToMesh")]
	public unsafe static UDynamicMesh CopyMeshToMesh(UDynamicMesh CopyFromMesh, ref UDynamicMesh CopyToMesh, out UDynamicMesh CopyToMeshOut, UGeometryScriptDebug Debug)
	{
		if (!CopyMeshToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:CopyMeshToMesh");
			CopyToMeshOut = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMeshToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMeshToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CopyMeshToMesh_CopyFromMesh_Offset), 0, CopyMeshToMesh_CopyFromMesh_PropertyAddress.Address, CopyFromMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CopyMeshToMesh_CopyToMesh_Offset), 0, CopyMeshToMesh_CopyToMesh_PropertyAddress.Address, CopyToMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CopyMeshToMesh_Debug_Offset), 0, CopyMeshToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyMeshToMesh_FunctionAddress, intPtr, CopyMeshToMesh_ParamsSize);
		CopyToMesh = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyMeshToMesh_CopyToMesh_Offset), 0, CopyMeshToMesh_CopyToMesh_PropertyAddress.Address);
		CopyToMeshOut = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyMeshToMesh_CopyToMeshOut_Offset), 0, CopyMeshToMesh_CopyToMeshOut_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyMeshToMesh_ReturnValue_Offset), 0, CopyMeshToMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshDecomposition()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshDecomposition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshDecomposition));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions");
		SplitMeshByPolygroups_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SplitMeshByPolygroups");
		SplitMeshByPolygroups_ParamsSize = NativeReflection.GetFunctionParamsSize(SplitMeshByPolygroups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByPolygroups_TargetMesh_PropertyAddress, SplitMeshByPolygroups_FunctionAddress, "TargetMesh");
		SplitMeshByPolygroups_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByPolygroups_FunctionAddress, "TargetMesh");
		SplitMeshByPolygroups_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByPolygroups_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByPolygroups_GroupLayer_PropertyAddress, SplitMeshByPolygroups_FunctionAddress, "GroupLayer");
		SplitMeshByPolygroups_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByPolygroups_FunctionAddress, "GroupLayer");
		SplitMeshByPolygroups_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByPolygroups_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByPolygroups_ComponentMeshes_PropertyAddress, SplitMeshByPolygroups_FunctionAddress, "ComponentMeshes");
		SplitMeshByPolygroups_ComponentMeshes_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByPolygroups_FunctionAddress, "ComponentMeshes");
		SplitMeshByPolygroups_ComponentMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByPolygroups_FunctionAddress, "ComponentMeshes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByPolygroups_ComponentPolygroups_PropertyAddress, SplitMeshByPolygroups_FunctionAddress, "ComponentPolygroups");
		SplitMeshByPolygroups_ComponentPolygroups_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByPolygroups_FunctionAddress, "ComponentPolygroups");
		SplitMeshByPolygroups_ComponentPolygroups_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByPolygroups_FunctionAddress, "ComponentPolygroups", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByPolygroups_MeshPool_PropertyAddress, SplitMeshByPolygroups_FunctionAddress, "MeshPool");
		SplitMeshByPolygroups_MeshPool_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByPolygroups_FunctionAddress, "MeshPool");
		SplitMeshByPolygroups_MeshPool_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByPolygroups_FunctionAddress, "MeshPool", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByPolygroups_Debug_PropertyAddress, SplitMeshByPolygroups_FunctionAddress, "Debug");
		SplitMeshByPolygroups_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByPolygroups_FunctionAddress, "Debug");
		SplitMeshByPolygroups_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByPolygroups_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByPolygroups_ReturnValue_PropertyAddress, SplitMeshByPolygroups_FunctionAddress, "ReturnValue");
		SplitMeshByPolygroups_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByPolygroups_FunctionAddress, "ReturnValue");
		SplitMeshByPolygroups_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByPolygroups_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SplitMeshByPolygroups_IsValid = SplitMeshByPolygroups_FunctionAddress != IntPtr.Zero && SplitMeshByPolygroups_TargetMesh_IsValid && SplitMeshByPolygroups_GroupLayer_IsValid && SplitMeshByPolygroups_ComponentMeshes_IsValid && SplitMeshByPolygroups_ComponentPolygroups_IsValid && SplitMeshByPolygroups_MeshPool_IsValid && SplitMeshByPolygroups_Debug_IsValid && SplitMeshByPolygroups_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByPolygroups", SplitMeshByPolygroups_IsValid);
		SplitMeshByMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SplitMeshByMaterialIDs");
		SplitMeshByMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(SplitMeshByMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByMaterialIDs_TargetMesh_PropertyAddress, SplitMeshByMaterialIDs_FunctionAddress, "TargetMesh");
		SplitMeshByMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByMaterialIDs_FunctionAddress, "TargetMesh");
		SplitMeshByMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByMaterialIDs_ComponentMeshes_PropertyAddress, SplitMeshByMaterialIDs_FunctionAddress, "ComponentMeshes");
		SplitMeshByMaterialIDs_ComponentMeshes_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByMaterialIDs_FunctionAddress, "ComponentMeshes");
		SplitMeshByMaterialIDs_ComponentMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByMaterialIDs_FunctionAddress, "ComponentMeshes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByMaterialIDs_ComponentMaterialIDs_PropertyAddress, SplitMeshByMaterialIDs_FunctionAddress, "ComponentMaterialIDs");
		SplitMeshByMaterialIDs_ComponentMaterialIDs_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByMaterialIDs_FunctionAddress, "ComponentMaterialIDs");
		SplitMeshByMaterialIDs_ComponentMaterialIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByMaterialIDs_FunctionAddress, "ComponentMaterialIDs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByMaterialIDs_MeshPool_PropertyAddress, SplitMeshByMaterialIDs_FunctionAddress, "MeshPool");
		SplitMeshByMaterialIDs_MeshPool_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByMaterialIDs_FunctionAddress, "MeshPool");
		SplitMeshByMaterialIDs_MeshPool_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByMaterialIDs_FunctionAddress, "MeshPool", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByMaterialIDs_Debug_PropertyAddress, SplitMeshByMaterialIDs_FunctionAddress, "Debug");
		SplitMeshByMaterialIDs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByMaterialIDs_FunctionAddress, "Debug");
		SplitMeshByMaterialIDs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByMaterialIDs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByMaterialIDs_ReturnValue_PropertyAddress, SplitMeshByMaterialIDs_FunctionAddress, "ReturnValue");
		SplitMeshByMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByMaterialIDs_FunctionAddress, "ReturnValue");
		SplitMeshByMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByMaterialIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SplitMeshByMaterialIDs_IsValid = SplitMeshByMaterialIDs_FunctionAddress != IntPtr.Zero && SplitMeshByMaterialIDs_TargetMesh_IsValid && SplitMeshByMaterialIDs_ComponentMeshes_IsValid && SplitMeshByMaterialIDs_ComponentMaterialIDs_IsValid && SplitMeshByMaterialIDs_MeshPool_IsValid && SplitMeshByMaterialIDs_Debug_IsValid && SplitMeshByMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByMaterialIDs", SplitMeshByMaterialIDs_IsValid);
		SplitMeshByComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SplitMeshByComponents");
		SplitMeshByComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(SplitMeshByComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByComponents_TargetMesh_PropertyAddress, SplitMeshByComponents_FunctionAddress, "TargetMesh");
		SplitMeshByComponents_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByComponents_FunctionAddress, "TargetMesh");
		SplitMeshByComponents_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByComponents_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByComponents_ComponentMeshes_PropertyAddress, SplitMeshByComponents_FunctionAddress, "ComponentMeshes");
		SplitMeshByComponents_ComponentMeshes_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByComponents_FunctionAddress, "ComponentMeshes");
		SplitMeshByComponents_ComponentMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByComponents_FunctionAddress, "ComponentMeshes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByComponents_MeshPool_PropertyAddress, SplitMeshByComponents_FunctionAddress, "MeshPool");
		SplitMeshByComponents_MeshPool_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByComponents_FunctionAddress, "MeshPool");
		SplitMeshByComponents_MeshPool_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByComponents_FunctionAddress, "MeshPool", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByComponents_Debug_PropertyAddress, SplitMeshByComponents_FunctionAddress, "Debug");
		SplitMeshByComponents_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByComponents_FunctionAddress, "Debug");
		SplitMeshByComponents_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByComponents_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitMeshByComponents_ReturnValue_PropertyAddress, SplitMeshByComponents_FunctionAddress, "ReturnValue");
		SplitMeshByComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SplitMeshByComponents_FunctionAddress, "ReturnValue");
		SplitMeshByComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitMeshByComponents_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SplitMeshByComponents_IsValid = SplitMeshByComponents_FunctionAddress != IntPtr.Zero && SplitMeshByComponents_TargetMesh_IsValid && SplitMeshByComponents_ComponentMeshes_IsValid && SplitMeshByComponents_MeshPool_IsValid && SplitMeshByComponents_Debug_IsValid && SplitMeshByComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:SplitMeshByComponents", SplitMeshByComponents_IsValid);
		GetSubMeshFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSubMeshFromMesh");
		GetSubMeshFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubMeshFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubMeshFromMesh_TargetMesh_PropertyAddress, GetSubMeshFromMesh_FunctionAddress, "TargetMesh");
		GetSubMeshFromMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSubMeshFromMesh_FunctionAddress, "TargetMesh");
		GetSubMeshFromMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubMeshFromMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubMeshFromMesh_StoreToSubmesh_PropertyAddress, GetSubMeshFromMesh_FunctionAddress, "StoreToSubmesh");
		GetSubMeshFromMesh_StoreToSubmesh_Offset = NativeReflectionCached.GetPropertyOffset(GetSubMeshFromMesh_FunctionAddress, "StoreToSubmesh");
		GetSubMeshFromMesh_StoreToSubmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubMeshFromMesh_FunctionAddress, "StoreToSubmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubMeshFromMesh_TriangleList_PropertyAddress, GetSubMeshFromMesh_FunctionAddress, "TriangleList");
		GetSubMeshFromMesh_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(GetSubMeshFromMesh_FunctionAddress, "TriangleList");
		GetSubMeshFromMesh_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubMeshFromMesh_FunctionAddress, "TriangleList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubMeshFromMesh_StoreToSubmeshOut_PropertyAddress, GetSubMeshFromMesh_FunctionAddress, "StoreToSubmeshOut");
		GetSubMeshFromMesh_StoreToSubmeshOut_Offset = NativeReflectionCached.GetPropertyOffset(GetSubMeshFromMesh_FunctionAddress, "StoreToSubmeshOut");
		GetSubMeshFromMesh_StoreToSubmeshOut_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubMeshFromMesh_FunctionAddress, "StoreToSubmeshOut", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubMeshFromMesh_Debug_PropertyAddress, GetSubMeshFromMesh_FunctionAddress, "Debug");
		GetSubMeshFromMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(GetSubMeshFromMesh_FunctionAddress, "Debug");
		GetSubMeshFromMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubMeshFromMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubMeshFromMesh_ReturnValue_PropertyAddress, GetSubMeshFromMesh_FunctionAddress, "ReturnValue");
		GetSubMeshFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSubMeshFromMesh_FunctionAddress, "ReturnValue");
		GetSubMeshFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubMeshFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSubMeshFromMesh_IsValid = GetSubMeshFromMesh_FunctionAddress != IntPtr.Zero && GetSubMeshFromMesh_TargetMesh_IsValid && GetSubMeshFromMesh_StoreToSubmesh_IsValid && GetSubMeshFromMesh_TriangleList_IsValid && GetSubMeshFromMesh_StoreToSubmeshOut_IsValid && GetSubMeshFromMesh_Debug_IsValid && GetSubMeshFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:GetSubMeshFromMesh", GetSubMeshFromMesh_IsValid);
		CopyMeshToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyMeshToMesh");
		CopyMeshToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMeshToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToMesh_CopyFromMesh_PropertyAddress, CopyMeshToMesh_FunctionAddress, "CopyFromMesh");
		CopyMeshToMesh_CopyFromMesh_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToMesh_FunctionAddress, "CopyFromMesh");
		CopyMeshToMesh_CopyFromMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToMesh_FunctionAddress, "CopyFromMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToMesh_CopyToMesh_PropertyAddress, CopyMeshToMesh_FunctionAddress, "CopyToMesh");
		CopyMeshToMesh_CopyToMesh_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToMesh_FunctionAddress, "CopyToMesh");
		CopyMeshToMesh_CopyToMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToMesh_FunctionAddress, "CopyToMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToMesh_CopyToMeshOut_PropertyAddress, CopyMeshToMesh_FunctionAddress, "CopyToMeshOut");
		CopyMeshToMesh_CopyToMeshOut_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToMesh_FunctionAddress, "CopyToMeshOut");
		CopyMeshToMesh_CopyToMeshOut_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToMesh_FunctionAddress, "CopyToMeshOut", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToMesh_Debug_PropertyAddress, CopyMeshToMesh_FunctionAddress, "Debug");
		CopyMeshToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToMesh_FunctionAddress, "Debug");
		CopyMeshToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMeshToMesh_ReturnValue_PropertyAddress, CopyMeshToMesh_FunctionAddress, "ReturnValue");
		CopyMeshToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyMeshToMesh_FunctionAddress, "ReturnValue");
		CopyMeshToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMeshToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyMeshToMesh_IsValid = CopyMeshToMesh_FunctionAddress != IntPtr.Zero && CopyMeshToMesh_CopyFromMesh_IsValid && CopyMeshToMesh_CopyToMesh_IsValid && CopyMeshToMesh_CopyToMeshOut_IsValid && CopyMeshToMesh_Debug_IsValid && CopyMeshToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDecompositionFunctions:CopyMeshToMesh", CopyMeshToMesh_IsValid);
	}
}
