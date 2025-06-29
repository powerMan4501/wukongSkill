using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_Materials : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetTriangleMaterialID_IsValid;

	private static IntPtr SetTriangleMaterialID_FunctionAddress;

	private static int SetTriangleMaterialID_ParamsSize;

	private static bool SetTriangleMaterialID_TargetMesh_IsValid;

	private static FFieldAddress SetTriangleMaterialID_TargetMesh_PropertyAddress;

	private static int SetTriangleMaterialID_TargetMesh_Offset;

	private static bool SetTriangleMaterialID_TriangleID_IsValid;

	private static FFieldAddress SetTriangleMaterialID_TriangleID_PropertyAddress;

	private static int SetTriangleMaterialID_TriangleID_Offset;

	private static bool SetTriangleMaterialID_MaterialID_IsValid;

	private static FFieldAddress SetTriangleMaterialID_MaterialID_PropertyAddress;

	private static int SetTriangleMaterialID_MaterialID_Offset;

	private static bool SetTriangleMaterialID_bIsValidTriangle_IsValid;

	private static FFieldAddress SetTriangleMaterialID_bIsValidTriangle_PropertyAddress;

	private static int SetTriangleMaterialID_bIsValidTriangle_Offset;

	private static bool SetTriangleMaterialID_bDeferChangeNotifications_IsValid;

	private static FFieldAddress SetTriangleMaterialID_bDeferChangeNotifications_PropertyAddress;

	private static int SetTriangleMaterialID_bDeferChangeNotifications_Offset;

	private static bool SetTriangleMaterialID_ReturnValue_IsValid;

	private static FFieldAddress SetTriangleMaterialID_ReturnValue_PropertyAddress;

	private static int SetTriangleMaterialID_ReturnValue_Offset;

	private static bool SetPolygroupMaterialID_IsValid;

	private static IntPtr SetPolygroupMaterialID_FunctionAddress;

	private static int SetPolygroupMaterialID_ParamsSize;

	private static bool SetPolygroupMaterialID_TargetMesh_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_TargetMesh_PropertyAddress;

	private static int SetPolygroupMaterialID_TargetMesh_Offset;

	private static bool SetPolygroupMaterialID_GroupLayer_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_GroupLayer_PropertyAddress;

	private static int SetPolygroupMaterialID_GroupLayer_Offset;

	private static bool SetPolygroupMaterialID_PolygroupID_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_PolygroupID_PropertyAddress;

	private static int SetPolygroupMaterialID_PolygroupID_Offset;

	private static bool SetPolygroupMaterialID_MaterialID_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_MaterialID_PropertyAddress;

	private static int SetPolygroupMaterialID_MaterialID_Offset;

	private static bool SetPolygroupMaterialID_bIsValidPolygroupID_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_bIsValidPolygroupID_PropertyAddress;

	private static int SetPolygroupMaterialID_bIsValidPolygroupID_Offset;

	private static bool SetPolygroupMaterialID_bDeferChangeNotifications_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_bDeferChangeNotifications_PropertyAddress;

	private static int SetPolygroupMaterialID_bDeferChangeNotifications_Offset;

	private static bool SetPolygroupMaterialID_Debug_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_Debug_PropertyAddress;

	private static int SetPolygroupMaterialID_Debug_Offset;

	private static bool SetPolygroupMaterialID_ReturnValue_IsValid;

	private static FFieldAddress SetPolygroupMaterialID_ReturnValue_PropertyAddress;

	private static int SetPolygroupMaterialID_ReturnValue_Offset;

	private static bool SetAllTriangleMaterialIDs_IsValid;

	private static IntPtr SetAllTriangleMaterialIDs_FunctionAddress;

	private static int SetAllTriangleMaterialIDs_ParamsSize;

	private static bool SetAllTriangleMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress SetAllTriangleMaterialIDs_TargetMesh_PropertyAddress;

	private static int SetAllTriangleMaterialIDs_TargetMesh_Offset;

	private static bool SetAllTriangleMaterialIDs_TriangleMaterialIDList_IsValid;

	private static FFieldAddress SetAllTriangleMaterialIDs_TriangleMaterialIDList_PropertyAddress;

	private static int SetAllTriangleMaterialIDs_TriangleMaterialIDList_Offset;

	private static bool SetAllTriangleMaterialIDs_bDeferChangeNotifications_IsValid;

	private static FFieldAddress SetAllTriangleMaterialIDs_bDeferChangeNotifications_PropertyAddress;

	private static int SetAllTriangleMaterialIDs_bDeferChangeNotifications_Offset;

	private static bool SetAllTriangleMaterialIDs_Debug_IsValid;

	private static FFieldAddress SetAllTriangleMaterialIDs_Debug_PropertyAddress;

	private static int SetAllTriangleMaterialIDs_Debug_Offset;

	private static bool SetAllTriangleMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress SetAllTriangleMaterialIDs_ReturnValue_PropertyAddress;

	private static int SetAllTriangleMaterialIDs_ReturnValue_Offset;

	private static bool RemapMaterialIDs_IsValid;

	private static IntPtr RemapMaterialIDs_FunctionAddress;

	private static int RemapMaterialIDs_ParamsSize;

	private static bool RemapMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress RemapMaterialIDs_TargetMesh_PropertyAddress;

	private static int RemapMaterialIDs_TargetMesh_Offset;

	private static bool RemapMaterialIDs_FromMaterialID_IsValid;

	private static FFieldAddress RemapMaterialIDs_FromMaterialID_PropertyAddress;

	private static int RemapMaterialIDs_FromMaterialID_Offset;

	private static bool RemapMaterialIDs_ToMaterialID_IsValid;

	private static FFieldAddress RemapMaterialIDs_ToMaterialID_PropertyAddress;

	private static int RemapMaterialIDs_ToMaterialID_Offset;

	private static bool RemapMaterialIDs_Debug_IsValid;

	private static FFieldAddress RemapMaterialIDs_Debug_PropertyAddress;

	private static int RemapMaterialIDs_Debug_Offset;

	private static bool RemapMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress RemapMaterialIDs_ReturnValue_PropertyAddress;

	private static int RemapMaterialIDs_ReturnValue_Offset;

	private static bool GetTriangleMaterialID_IsValid;

	private static IntPtr GetTriangleMaterialID_FunctionAddress;

	private static int GetTriangleMaterialID_ParamsSize;

	private static bool GetTriangleMaterialID_TargetMesh_IsValid;

	private static FFieldAddress GetTriangleMaterialID_TargetMesh_PropertyAddress;

	private static int GetTriangleMaterialID_TargetMesh_Offset;

	private static bool GetTriangleMaterialID_TriangleID_IsValid;

	private static FFieldAddress GetTriangleMaterialID_TriangleID_PropertyAddress;

	private static int GetTriangleMaterialID_TriangleID_Offset;

	private static bool GetTriangleMaterialID_bIsValidTriangle_IsValid;

	private static FFieldAddress GetTriangleMaterialID_bIsValidTriangle_PropertyAddress;

	private static int GetTriangleMaterialID_bIsValidTriangle_Offset;

	private static bool GetTriangleMaterialID_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleMaterialID_ReturnValue_PropertyAddress;

	private static int GetTriangleMaterialID_ReturnValue_Offset;

	private static bool GetMaxMaterialID_IsValid;

	private static IntPtr GetMaxMaterialID_FunctionAddress;

	private static int GetMaxMaterialID_ParamsSize;

	private static bool GetMaxMaterialID_TargetMesh_IsValid;

	private static FFieldAddress GetMaxMaterialID_TargetMesh_PropertyAddress;

	private static int GetMaxMaterialID_TargetMesh_Offset;

	private static bool GetMaxMaterialID_bHasMaterialIDs_IsValid;

	private static FFieldAddress GetMaxMaterialID_bHasMaterialIDs_PropertyAddress;

	private static int GetMaxMaterialID_bHasMaterialIDs_Offset;

	private static bool GetMaxMaterialID_ReturnValue_IsValid;

	private static FFieldAddress GetMaxMaterialID_ReturnValue_PropertyAddress;

	private static int GetMaxMaterialID_ReturnValue_Offset;

	private static bool GetAllTriangleMaterialIDs_IsValid;

	private static IntPtr GetAllTriangleMaterialIDs_FunctionAddress;

	private static int GetAllTriangleMaterialIDs_ParamsSize;

	private static bool GetAllTriangleMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress GetAllTriangleMaterialIDs_TargetMesh_PropertyAddress;

	private static int GetAllTriangleMaterialIDs_TargetMesh_Offset;

	private static bool GetAllTriangleMaterialIDs_MaterialIDList_IsValid;

	private static FFieldAddress GetAllTriangleMaterialIDs_MaterialIDList_PropertyAddress;

	private static int GetAllTriangleMaterialIDs_MaterialIDList_Offset;

	private static bool GetAllTriangleMaterialIDs_bHasMaterialIDs_IsValid;

	private static FFieldAddress GetAllTriangleMaterialIDs_bHasMaterialIDs_PropertyAddress;

	private static int GetAllTriangleMaterialIDs_bHasMaterialIDs_Offset;

	private static bool GetAllTriangleMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress GetAllTriangleMaterialIDs_ReturnValue_PropertyAddress;

	private static int GetAllTriangleMaterialIDs_ReturnValue_Offset;

	private static bool EnableMaterialIDs_IsValid;

	private static IntPtr EnableMaterialIDs_FunctionAddress;

	private static int EnableMaterialIDs_ParamsSize;

	private static bool EnableMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress EnableMaterialIDs_TargetMesh_PropertyAddress;

	private static int EnableMaterialIDs_TargetMesh_Offset;

	private static bool EnableMaterialIDs_Debug_IsValid;

	private static FFieldAddress EnableMaterialIDs_Debug_PropertyAddress;

	private static int EnableMaterialIDs_Debug_Offset;

	private static bool EnableMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress EnableMaterialIDs_ReturnValue_PropertyAddress;

	private static int EnableMaterialIDs_ReturnValue_Offset;

	private static bool DeleteTrianglesByMaterialID_IsValid;

	private static IntPtr DeleteTrianglesByMaterialID_FunctionAddress;

	private static int DeleteTrianglesByMaterialID_ParamsSize;

	private static bool DeleteTrianglesByMaterialID_TargetMesh_IsValid;

	private static FFieldAddress DeleteTrianglesByMaterialID_TargetMesh_PropertyAddress;

	private static int DeleteTrianglesByMaterialID_TargetMesh_Offset;

	private static bool DeleteTrianglesByMaterialID_MaterialID_IsValid;

	private static FFieldAddress DeleteTrianglesByMaterialID_MaterialID_PropertyAddress;

	private static int DeleteTrianglesByMaterialID_MaterialID_Offset;

	private static bool DeleteTrianglesByMaterialID_NumDeleted_IsValid;

	private static FFieldAddress DeleteTrianglesByMaterialID_NumDeleted_PropertyAddress;

	private static int DeleteTrianglesByMaterialID_NumDeleted_Offset;

	private static bool DeleteTrianglesByMaterialID_bDeferChangeNotifications_IsValid;

	private static FFieldAddress DeleteTrianglesByMaterialID_bDeferChangeNotifications_PropertyAddress;

	private static int DeleteTrianglesByMaterialID_bDeferChangeNotifications_Offset;

	private static bool DeleteTrianglesByMaterialID_Debug_IsValid;

	private static FFieldAddress DeleteTrianglesByMaterialID_Debug_PropertyAddress;

	private static int DeleteTrianglesByMaterialID_Debug_Offset;

	private static bool DeleteTrianglesByMaterialID_ReturnValue_IsValid;

	private static FFieldAddress DeleteTrianglesByMaterialID_ReturnValue_PropertyAddress;

	private static int DeleteTrianglesByMaterialID_ReturnValue_Offset;

	private static bool CompactMaterialIDs_IsValid;

	private static IntPtr CompactMaterialIDs_FunctionAddress;

	private static int CompactMaterialIDs_ParamsSize;

	private static bool CompactMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress CompactMaterialIDs_TargetMesh_PropertyAddress;

	private static int CompactMaterialIDs_TargetMesh_Offset;

	private static bool CompactMaterialIDs_SourceMaterialList_IsValid;

	private static FFieldAddress CompactMaterialIDs_SourceMaterialList_PropertyAddress;

	private static int CompactMaterialIDs_SourceMaterialList_Offset;

	private static bool CompactMaterialIDs_CompactedMaterialList_IsValid;

	private static FFieldAddress CompactMaterialIDs_CompactedMaterialList_PropertyAddress;

	private static int CompactMaterialIDs_CompactedMaterialList_Offset;

	private static bool CompactMaterialIDs_Debug_IsValid;

	private static FFieldAddress CompactMaterialIDs_Debug_PropertyAddress;

	private static int CompactMaterialIDs_Debug_Offset;

	private static bool CompactMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress CompactMaterialIDs_ReturnValue_PropertyAddress;

	private static int CompactMaterialIDs_ReturnValue_Offset;

	private static bool ClearMaterialIDs_IsValid;

	private static IntPtr ClearMaterialIDs_FunctionAddress;

	private static int ClearMaterialIDs_ParamsSize;

	private static bool ClearMaterialIDs_TargetMesh_IsValid;

	private static FFieldAddress ClearMaterialIDs_TargetMesh_PropertyAddress;

	private static int ClearMaterialIDs_TargetMesh_Offset;

	private static bool ClearMaterialIDs_ClearValue_IsValid;

	private static FFieldAddress ClearMaterialIDs_ClearValue_PropertyAddress;

	private static int ClearMaterialIDs_ClearValue_Offset;

	private static bool ClearMaterialIDs_Debug_IsValid;

	private static FFieldAddress ClearMaterialIDs_Debug_PropertyAddress;

	private static int ClearMaterialIDs_Debug_Offset;

	private static bool ClearMaterialIDs_ReturnValue_IsValid;

	private static FFieldAddress ClearMaterialIDs_ReturnValue_PropertyAddress;

	private static int ClearMaterialIDs_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetTriangleMaterialID")]
	public unsafe static UDynamicMesh SetTriangleMaterialID(UDynamicMesh TargetMesh, int TriangleID, int MaterialID, out bool bIsValidTriangle, bool bDeferChangeNotifications = false)
	{
		if (!SetTriangleMaterialID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetTriangleMaterialID");
			bIsValidTriangle = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTriangleMaterialID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTriangleMaterialID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetTriangleMaterialID_TargetMesh_Offset), 0, SetTriangleMaterialID_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTriangleMaterialID_TriangleID_Offset), 0, SetTriangleMaterialID_TriangleID_PropertyAddress.Address, TriangleID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTriangleMaterialID_MaterialID_Offset), 0, SetTriangleMaterialID_MaterialID_PropertyAddress.Address, MaterialID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTriangleMaterialID_bDeferChangeNotifications_Offset), 0, SetTriangleMaterialID_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTriangleMaterialID_FunctionAddress, intPtr, SetTriangleMaterialID_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTriangleMaterialID_bIsValidTriangle_Offset), 0, SetTriangleMaterialID_bIsValidTriangle_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetTriangleMaterialID_ReturnValue_Offset), 0, SetTriangleMaterialID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetPolygroupMaterialID")]
	public unsafe static UDynamicMesh SetPolygroupMaterialID(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int PolygroupID, int MaterialID, out bool bIsValidPolygroupID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!SetPolygroupMaterialID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetPolygroupMaterialID");
			bIsValidPolygroupID = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPolygroupMaterialID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPolygroupMaterialID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_TargetMesh_Offset), 0, SetPolygroupMaterialID_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(SetPolygroupMaterialID_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_GroupLayer_Offset), 0, SetPolygroupMaterialID_GroupLayer_PropertyAddress.Address, GroupLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_PolygroupID_Offset), 0, SetPolygroupMaterialID_PolygroupID_PropertyAddress.Address, PolygroupID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_MaterialID_Offset), 0, SetPolygroupMaterialID_MaterialID_PropertyAddress.Address, MaterialID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_bDeferChangeNotifications_Offset), 0, SetPolygroupMaterialID_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_Debug_Offset), 0, SetPolygroupMaterialID_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPolygroupMaterialID_FunctionAddress, intPtr, SetPolygroupMaterialID_ParamsSize);
		bIsValidPolygroupID = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_bIsValidPolygroupID_Offset), 0, SetPolygroupMaterialID_bIsValidPolygroupID_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetPolygroupMaterialID_ReturnValue_Offset), 0, SetPolygroupMaterialID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetAllTriangleMaterialIDs")]
	public unsafe static UDynamicMesh SetAllTriangleMaterialIDs(UDynamicMesh TargetMesh, out FGeometryScriptIndexList TriangleMaterialIDList, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!SetAllTriangleMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetAllTriangleMaterialIDs");
			TriangleMaterialIDList = default(FGeometryScriptIndexList);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllTriangleMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllTriangleMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetAllTriangleMaterialIDs_TargetMesh_Offset), 0, SetAllTriangleMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(SetAllTriangleMaterialIDs_TriangleMaterialIDList_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllTriangleMaterialIDs_bDeferChangeNotifications_Offset), 0, SetAllTriangleMaterialIDs_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetAllTriangleMaterialIDs_Debug_Offset), 0, SetAllTriangleMaterialIDs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAllTriangleMaterialIDs_FunctionAddress, intPtr, SetAllTriangleMaterialIDs_ParamsSize);
		TriangleMaterialIDList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, SetAllTriangleMaterialIDs_TriangleMaterialIDList_Offset), 0, SetAllTriangleMaterialIDs_TriangleMaterialIDList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetAllTriangleMaterialIDs_TriangleMaterialIDList_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetAllTriangleMaterialIDs_ReturnValue_Offset), 0, SetAllTriangleMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:RemapMaterialIDs")]
	public unsafe static UDynamicMesh RemapMaterialIDs(UDynamicMesh TargetMesh, int FromMaterialID, int ToMaterialID, UGeometryScriptDebug Debug)
	{
		if (!RemapMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:RemapMaterialIDs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemapMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemapMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RemapMaterialIDs_TargetMesh_Offset), 0, RemapMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemapMaterialIDs_FromMaterialID_Offset), 0, RemapMaterialIDs_FromMaterialID_PropertyAddress.Address, FromMaterialID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemapMaterialIDs_ToMaterialID_Offset), 0, RemapMaterialIDs_ToMaterialID_PropertyAddress.Address, ToMaterialID);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RemapMaterialIDs_Debug_Offset), 0, RemapMaterialIDs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemapMaterialIDs_FunctionAddress, intPtr, RemapMaterialIDs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RemapMaterialIDs_ReturnValue_Offset), 0, RemapMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetTriangleMaterialID")]
	public unsafe static int GetTriangleMaterialID(UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle)
	{
		if (!GetTriangleMaterialID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetTriangleMaterialID");
			bIsValidTriangle = false;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleMaterialID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleMaterialID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetTriangleMaterialID_TargetMesh_Offset), 0, GetTriangleMaterialID_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTriangleMaterialID_TriangleID_Offset), 0, GetTriangleMaterialID_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTriangleMaterialID_FunctionAddress, intPtr, GetTriangleMaterialID_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTriangleMaterialID_bIsValidTriangle_Offset), 0, GetTriangleMaterialID_bIsValidTriangle_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTriangleMaterialID_ReturnValue_Offset), 0, GetTriangleMaterialID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetMaxMaterialID")]
	public unsafe static int GetMaxMaterialID(UDynamicMesh TargetMesh, out bool bHasMaterialIDs)
	{
		if (!GetMaxMaterialID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetMaxMaterialID");
			bHasMaterialIDs = false;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxMaterialID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxMaterialID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetMaxMaterialID_TargetMesh_Offset), 0, GetMaxMaterialID_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMaxMaterialID_FunctionAddress, intPtr, GetMaxMaterialID_ParamsSize);
		bHasMaterialIDs = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetMaxMaterialID_bHasMaterialIDs_Offset), 0, GetMaxMaterialID_bHasMaterialIDs_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaxMaterialID_ReturnValue_Offset), 0, GetMaxMaterialID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetAllTriangleMaterialIDs")]
	public unsafe static UDynamicMesh GetAllTriangleMaterialIDs(UDynamicMesh TargetMesh, out FGeometryScriptIndexList MaterialIDList, out bool bHasMaterialIDs)
	{
		if (!GetAllTriangleMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetAllTriangleMaterialIDs");
			MaterialIDList = default(FGeometryScriptIndexList);
			bHasMaterialIDs = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllTriangleMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllTriangleMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetAllTriangleMaterialIDs_TargetMesh_Offset), 0, GetAllTriangleMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetAllTriangleMaterialIDs_MaterialIDList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllTriangleMaterialIDs_FunctionAddress, intPtr, GetAllTriangleMaterialIDs_ParamsSize);
		MaterialIDList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, GetAllTriangleMaterialIDs_MaterialIDList_Offset), 0, GetAllTriangleMaterialIDs_MaterialIDList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAllTriangleMaterialIDs_MaterialIDList_PropertyAddress.Address, intPtr);
		bHasMaterialIDs = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllTriangleMaterialIDs_bHasMaterialIDs_Offset), 0, GetAllTriangleMaterialIDs_bHasMaterialIDs_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetAllTriangleMaterialIDs_ReturnValue_Offset), 0, GetAllTriangleMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:EnableMaterialIDs")]
	public unsafe static UDynamicMesh EnableMaterialIDs(UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		if (!EnableMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:EnableMaterialIDs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, EnableMaterialIDs_TargetMesh_Offset), 0, EnableMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, EnableMaterialIDs_Debug_Offset), 0, EnableMaterialIDs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableMaterialIDs_FunctionAddress, intPtr, EnableMaterialIDs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, EnableMaterialIDs_ReturnValue_Offset), 0, EnableMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:DeleteTrianglesByMaterialID")]
	public unsafe static UDynamicMesh DeleteTrianglesByMaterialID(UDynamicMesh TargetMesh, int MaterialID, out int NumDeleted, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!DeleteTrianglesByMaterialID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:DeleteTrianglesByMaterialID");
			NumDeleted = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteTrianglesByMaterialID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteTrianglesByMaterialID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, DeleteTrianglesByMaterialID_TargetMesh_Offset), 0, DeleteTrianglesByMaterialID_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DeleteTrianglesByMaterialID_MaterialID_Offset), 0, DeleteTrianglesByMaterialID_MaterialID_PropertyAddress.Address, MaterialID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteTrianglesByMaterialID_bDeferChangeNotifications_Offset), 0, DeleteTrianglesByMaterialID_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, DeleteTrianglesByMaterialID_Debug_Offset), 0, DeleteTrianglesByMaterialID_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteTrianglesByMaterialID_FunctionAddress, intPtr, DeleteTrianglesByMaterialID_ParamsSize);
		NumDeleted = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, DeleteTrianglesByMaterialID_NumDeleted_Offset), 0, DeleteTrianglesByMaterialID_NumDeleted_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, DeleteTrianglesByMaterialID_ReturnValue_Offset), 0, DeleteTrianglesByMaterialID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:CompactMaterialIDs")]
	public unsafe static UDynamicMesh CompactMaterialIDs(UDynamicMesh TargetMesh, List<UMaterialInterface> SourceMaterialList, out List<UMaterialInterface> CompactedMaterialList, UGeometryScriptDebug Debug)
	{
		if (!CompactMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:CompactMaterialIDs");
			CompactedMaterialList = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompactMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompactMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CompactMaterialIDs_TargetMesh_Offset), 0, CompactMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		new TArrayCopyMarshaler<UMaterialInterface>(1, CompactMaterialIDs_SourceMaterialList_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).ToNative(IntPtr.Add(intPtr, CompactMaterialIDs_SourceMaterialList_Offset), SourceMaterialList);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CompactMaterialIDs_Debug_Offset), 0, CompactMaterialIDs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompactMaterialIDs_FunctionAddress, intPtr, CompactMaterialIDs_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CompactMaterialIDs_SourceMaterialList_PropertyAddress.Address, intPtr);
		CompactedMaterialList = new TArrayCopyMarshaler<UMaterialInterface>(1, CompactMaterialIDs_CompactedMaterialList_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(intPtr, CompactMaterialIDs_CompactedMaterialList_Offset));
		NativeReflection.DestroyValue_InContainer(CompactMaterialIDs_CompactedMaterialList_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CompactMaterialIDs_ReturnValue_Offset), 0, CompactMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:ClearMaterialIDs")]
	public unsafe static UDynamicMesh ClearMaterialIDs(UDynamicMesh TargetMesh, int ClearValue, UGeometryScriptDebug Debug)
	{
		if (!ClearMaterialIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:ClearMaterialIDs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMaterialIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMaterialIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ClearMaterialIDs_TargetMesh_Offset), 0, ClearMaterialIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ClearMaterialIDs_ClearValue_Offset), 0, ClearMaterialIDs_ClearValue_PropertyAddress.Address, ClearValue);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ClearMaterialIDs_Debug_Offset), 0, ClearMaterialIDs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearMaterialIDs_FunctionAddress, intPtr, ClearMaterialIDs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ClearMaterialIDs_ReturnValue_Offset), 0, ClearMaterialIDs_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_Materials()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_Materials)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_Materials));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions");
		SetTriangleMaterialID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTriangleMaterialID");
		SetTriangleMaterialID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTriangleMaterialID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTriangleMaterialID_TargetMesh_PropertyAddress, SetTriangleMaterialID_FunctionAddress, "TargetMesh");
		SetTriangleMaterialID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetTriangleMaterialID_FunctionAddress, "TargetMesh");
		SetTriangleMaterialID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTriangleMaterialID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTriangleMaterialID_TriangleID_PropertyAddress, SetTriangleMaterialID_FunctionAddress, "TriangleID");
		SetTriangleMaterialID_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(SetTriangleMaterialID_FunctionAddress, "TriangleID");
		SetTriangleMaterialID_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTriangleMaterialID_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTriangleMaterialID_MaterialID_PropertyAddress, SetTriangleMaterialID_FunctionAddress, "MaterialID");
		SetTriangleMaterialID_MaterialID_Offset = NativeReflectionCached.GetPropertyOffset(SetTriangleMaterialID_FunctionAddress, "MaterialID");
		SetTriangleMaterialID_MaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTriangleMaterialID_FunctionAddress, "MaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTriangleMaterialID_bIsValidTriangle_PropertyAddress, SetTriangleMaterialID_FunctionAddress, "bIsValidTriangle");
		SetTriangleMaterialID_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(SetTriangleMaterialID_FunctionAddress, "bIsValidTriangle");
		SetTriangleMaterialID_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTriangleMaterialID_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTriangleMaterialID_bDeferChangeNotifications_PropertyAddress, SetTriangleMaterialID_FunctionAddress, "bDeferChangeNotifications");
		SetTriangleMaterialID_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(SetTriangleMaterialID_FunctionAddress, "bDeferChangeNotifications");
		SetTriangleMaterialID_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTriangleMaterialID_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTriangleMaterialID_ReturnValue_PropertyAddress, SetTriangleMaterialID_FunctionAddress, "ReturnValue");
		SetTriangleMaterialID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTriangleMaterialID_FunctionAddress, "ReturnValue");
		SetTriangleMaterialID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTriangleMaterialID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetTriangleMaterialID_IsValid = SetTriangleMaterialID_FunctionAddress != IntPtr.Zero && SetTriangleMaterialID_TargetMesh_IsValid && SetTriangleMaterialID_TriangleID_IsValid && SetTriangleMaterialID_MaterialID_IsValid && SetTriangleMaterialID_bIsValidTriangle_IsValid && SetTriangleMaterialID_bDeferChangeNotifications_IsValid && SetTriangleMaterialID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetTriangleMaterialID", SetTriangleMaterialID_IsValid);
		SetPolygroupMaterialID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPolygroupMaterialID");
		SetPolygroupMaterialID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPolygroupMaterialID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_TargetMesh_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "TargetMesh");
		SetPolygroupMaterialID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "TargetMesh");
		SetPolygroupMaterialID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_GroupLayer_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "GroupLayer");
		SetPolygroupMaterialID_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "GroupLayer");
		SetPolygroupMaterialID_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_PolygroupID_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "PolygroupID");
		SetPolygroupMaterialID_PolygroupID_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "PolygroupID");
		SetPolygroupMaterialID_PolygroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "PolygroupID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_MaterialID_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "MaterialID");
		SetPolygroupMaterialID_MaterialID_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "MaterialID");
		SetPolygroupMaterialID_MaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "MaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_bIsValidPolygroupID_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "bIsValidPolygroupID");
		SetPolygroupMaterialID_bIsValidPolygroupID_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "bIsValidPolygroupID");
		SetPolygroupMaterialID_bIsValidPolygroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "bIsValidPolygroupID", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_bDeferChangeNotifications_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "bDeferChangeNotifications");
		SetPolygroupMaterialID_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "bDeferChangeNotifications");
		SetPolygroupMaterialID_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_Debug_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "Debug");
		SetPolygroupMaterialID_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "Debug");
		SetPolygroupMaterialID_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygroupMaterialID_ReturnValue_PropertyAddress, SetPolygroupMaterialID_FunctionAddress, "ReturnValue");
		SetPolygroupMaterialID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygroupMaterialID_FunctionAddress, "ReturnValue");
		SetPolygroupMaterialID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygroupMaterialID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetPolygroupMaterialID_IsValid = SetPolygroupMaterialID_FunctionAddress != IntPtr.Zero && SetPolygroupMaterialID_TargetMesh_IsValid && SetPolygroupMaterialID_GroupLayer_IsValid && SetPolygroupMaterialID_PolygroupID_IsValid && SetPolygroupMaterialID_MaterialID_IsValid && SetPolygroupMaterialID_bIsValidPolygroupID_IsValid && SetPolygroupMaterialID_bDeferChangeNotifications_IsValid && SetPolygroupMaterialID_Debug_IsValid && SetPolygroupMaterialID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetPolygroupMaterialID", SetPolygroupMaterialID_IsValid);
		SetAllTriangleMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAllTriangleMaterialIDs");
		SetAllTriangleMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllTriangleMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllTriangleMaterialIDs_TargetMesh_PropertyAddress, SetAllTriangleMaterialIDs_FunctionAddress, "TargetMesh");
		SetAllTriangleMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetAllTriangleMaterialIDs_FunctionAddress, "TargetMesh");
		SetAllTriangleMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllTriangleMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllTriangleMaterialIDs_TriangleMaterialIDList_PropertyAddress, SetAllTriangleMaterialIDs_FunctionAddress, "TriangleMaterialIDList");
		SetAllTriangleMaterialIDs_TriangleMaterialIDList_Offset = NativeReflectionCached.GetPropertyOffset(SetAllTriangleMaterialIDs_FunctionAddress, "TriangleMaterialIDList");
		SetAllTriangleMaterialIDs_TriangleMaterialIDList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllTriangleMaterialIDs_FunctionAddress, "TriangleMaterialIDList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllTriangleMaterialIDs_bDeferChangeNotifications_PropertyAddress, SetAllTriangleMaterialIDs_FunctionAddress, "bDeferChangeNotifications");
		SetAllTriangleMaterialIDs_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(SetAllTriangleMaterialIDs_FunctionAddress, "bDeferChangeNotifications");
		SetAllTriangleMaterialIDs_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllTriangleMaterialIDs_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllTriangleMaterialIDs_Debug_PropertyAddress, SetAllTriangleMaterialIDs_FunctionAddress, "Debug");
		SetAllTriangleMaterialIDs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetAllTriangleMaterialIDs_FunctionAddress, "Debug");
		SetAllTriangleMaterialIDs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllTriangleMaterialIDs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllTriangleMaterialIDs_ReturnValue_PropertyAddress, SetAllTriangleMaterialIDs_FunctionAddress, "ReturnValue");
		SetAllTriangleMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAllTriangleMaterialIDs_FunctionAddress, "ReturnValue");
		SetAllTriangleMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllTriangleMaterialIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetAllTriangleMaterialIDs_IsValid = SetAllTriangleMaterialIDs_FunctionAddress != IntPtr.Zero && SetAllTriangleMaterialIDs_TargetMesh_IsValid && SetAllTriangleMaterialIDs_TriangleMaterialIDList_IsValid && SetAllTriangleMaterialIDs_bDeferChangeNotifications_IsValid && SetAllTriangleMaterialIDs_Debug_IsValid && SetAllTriangleMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:SetAllTriangleMaterialIDs", SetAllTriangleMaterialIDs_IsValid);
		RemapMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemapMaterialIDs");
		RemapMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(RemapMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemapMaterialIDs_TargetMesh_PropertyAddress, RemapMaterialIDs_FunctionAddress, "TargetMesh");
		RemapMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemapMaterialIDs_FunctionAddress, "TargetMesh");
		RemapMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemapMaterialIDs_FromMaterialID_PropertyAddress, RemapMaterialIDs_FunctionAddress, "FromMaterialID");
		RemapMaterialIDs_FromMaterialID_Offset = NativeReflectionCached.GetPropertyOffset(RemapMaterialIDs_FunctionAddress, "FromMaterialID");
		RemapMaterialIDs_FromMaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapMaterialIDs_FunctionAddress, "FromMaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemapMaterialIDs_ToMaterialID_PropertyAddress, RemapMaterialIDs_FunctionAddress, "ToMaterialID");
		RemapMaterialIDs_ToMaterialID_Offset = NativeReflectionCached.GetPropertyOffset(RemapMaterialIDs_FunctionAddress, "ToMaterialID");
		RemapMaterialIDs_ToMaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapMaterialIDs_FunctionAddress, "ToMaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemapMaterialIDs_Debug_PropertyAddress, RemapMaterialIDs_FunctionAddress, "Debug");
		RemapMaterialIDs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RemapMaterialIDs_FunctionAddress, "Debug");
		RemapMaterialIDs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapMaterialIDs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemapMaterialIDs_ReturnValue_PropertyAddress, RemapMaterialIDs_FunctionAddress, "ReturnValue");
		RemapMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemapMaterialIDs_FunctionAddress, "ReturnValue");
		RemapMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapMaterialIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RemapMaterialIDs_IsValid = RemapMaterialIDs_FunctionAddress != IntPtr.Zero && RemapMaterialIDs_TargetMesh_IsValid && RemapMaterialIDs_FromMaterialID_IsValid && RemapMaterialIDs_ToMaterialID_IsValid && RemapMaterialIDs_Debug_IsValid && RemapMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:RemapMaterialIDs", RemapMaterialIDs_IsValid);
		GetTriangleMaterialID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTriangleMaterialID");
		GetTriangleMaterialID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleMaterialID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleMaterialID_TargetMesh_PropertyAddress, GetTriangleMaterialID_FunctionAddress, "TargetMesh");
		GetTriangleMaterialID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleMaterialID_FunctionAddress, "TargetMesh");
		GetTriangleMaterialID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleMaterialID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleMaterialID_TriangleID_PropertyAddress, GetTriangleMaterialID_FunctionAddress, "TriangleID");
		GetTriangleMaterialID_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleMaterialID_FunctionAddress, "TriangleID");
		GetTriangleMaterialID_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleMaterialID_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleMaterialID_bIsValidTriangle_PropertyAddress, GetTriangleMaterialID_FunctionAddress, "bIsValidTriangle");
		GetTriangleMaterialID_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleMaterialID_FunctionAddress, "bIsValidTriangle");
		GetTriangleMaterialID_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleMaterialID_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleMaterialID_ReturnValue_PropertyAddress, GetTriangleMaterialID_FunctionAddress, "ReturnValue");
		GetTriangleMaterialID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleMaterialID_FunctionAddress, "ReturnValue");
		GetTriangleMaterialID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleMaterialID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTriangleMaterialID_IsValid = GetTriangleMaterialID_FunctionAddress != IntPtr.Zero && GetTriangleMaterialID_TargetMesh_IsValid && GetTriangleMaterialID_TriangleID_IsValid && GetTriangleMaterialID_bIsValidTriangle_IsValid && GetTriangleMaterialID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetTriangleMaterialID", GetTriangleMaterialID_IsValid);
		GetMaxMaterialID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMaxMaterialID");
		GetMaxMaterialID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxMaterialID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxMaterialID_TargetMesh_PropertyAddress, GetMaxMaterialID_FunctionAddress, "TargetMesh");
		GetMaxMaterialID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxMaterialID_FunctionAddress, "TargetMesh");
		GetMaxMaterialID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxMaterialID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaxMaterialID_bHasMaterialIDs_PropertyAddress, GetMaxMaterialID_FunctionAddress, "bHasMaterialIDs");
		GetMaxMaterialID_bHasMaterialIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxMaterialID_FunctionAddress, "bHasMaterialIDs");
		GetMaxMaterialID_bHasMaterialIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxMaterialID_FunctionAddress, "bHasMaterialIDs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaxMaterialID_ReturnValue_PropertyAddress, GetMaxMaterialID_FunctionAddress, "ReturnValue");
		GetMaxMaterialID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxMaterialID_FunctionAddress, "ReturnValue");
		GetMaxMaterialID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxMaterialID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaxMaterialID_IsValid = GetMaxMaterialID_FunctionAddress != IntPtr.Zero && GetMaxMaterialID_TargetMesh_IsValid && GetMaxMaterialID_bHasMaterialIDs_IsValid && GetMaxMaterialID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetMaxMaterialID", GetMaxMaterialID_IsValid);
		GetAllTriangleMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllTriangleMaterialIDs");
		GetAllTriangleMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllTriangleMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleMaterialIDs_TargetMesh_PropertyAddress, GetAllTriangleMaterialIDs_FunctionAddress, "TargetMesh");
		GetAllTriangleMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleMaterialIDs_FunctionAddress, "TargetMesh");
		GetAllTriangleMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleMaterialIDs_MaterialIDList_PropertyAddress, GetAllTriangleMaterialIDs_FunctionAddress, "MaterialIDList");
		GetAllTriangleMaterialIDs_MaterialIDList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleMaterialIDs_FunctionAddress, "MaterialIDList");
		GetAllTriangleMaterialIDs_MaterialIDList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleMaterialIDs_FunctionAddress, "MaterialIDList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleMaterialIDs_bHasMaterialIDs_PropertyAddress, GetAllTriangleMaterialIDs_FunctionAddress, "bHasMaterialIDs");
		GetAllTriangleMaterialIDs_bHasMaterialIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleMaterialIDs_FunctionAddress, "bHasMaterialIDs");
		GetAllTriangleMaterialIDs_bHasMaterialIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleMaterialIDs_FunctionAddress, "bHasMaterialIDs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTriangleMaterialIDs_ReturnValue_PropertyAddress, GetAllTriangleMaterialIDs_FunctionAddress, "ReturnValue");
		GetAllTriangleMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTriangleMaterialIDs_FunctionAddress, "ReturnValue");
		GetAllTriangleMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTriangleMaterialIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAllTriangleMaterialIDs_IsValid = GetAllTriangleMaterialIDs_FunctionAddress != IntPtr.Zero && GetAllTriangleMaterialIDs_TargetMesh_IsValid && GetAllTriangleMaterialIDs_MaterialIDList_IsValid && GetAllTriangleMaterialIDs_bHasMaterialIDs_IsValid && GetAllTriangleMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:GetAllTriangleMaterialIDs", GetAllTriangleMaterialIDs_IsValid);
		EnableMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableMaterialIDs");
		EnableMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableMaterialIDs_TargetMesh_PropertyAddress, EnableMaterialIDs_FunctionAddress, "TargetMesh");
		EnableMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(EnableMaterialIDs_FunctionAddress, "TargetMesh");
		EnableMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableMaterialIDs_Debug_PropertyAddress, EnableMaterialIDs_FunctionAddress, "Debug");
		EnableMaterialIDs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(EnableMaterialIDs_FunctionAddress, "Debug");
		EnableMaterialIDs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableMaterialIDs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableMaterialIDs_ReturnValue_PropertyAddress, EnableMaterialIDs_FunctionAddress, "ReturnValue");
		EnableMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EnableMaterialIDs_FunctionAddress, "ReturnValue");
		EnableMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableMaterialIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		EnableMaterialIDs_IsValid = EnableMaterialIDs_FunctionAddress != IntPtr.Zero && EnableMaterialIDs_TargetMesh_IsValid && EnableMaterialIDs_Debug_IsValid && EnableMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:EnableMaterialIDs", EnableMaterialIDs_IsValid);
		DeleteTrianglesByMaterialID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteTrianglesByMaterialID");
		DeleteTrianglesByMaterialID_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteTrianglesByMaterialID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesByMaterialID_TargetMesh_PropertyAddress, DeleteTrianglesByMaterialID_FunctionAddress, "TargetMesh");
		DeleteTrianglesByMaterialID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesByMaterialID_FunctionAddress, "TargetMesh");
		DeleteTrianglesByMaterialID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesByMaterialID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesByMaterialID_MaterialID_PropertyAddress, DeleteTrianglesByMaterialID_FunctionAddress, "MaterialID");
		DeleteTrianglesByMaterialID_MaterialID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesByMaterialID_FunctionAddress, "MaterialID");
		DeleteTrianglesByMaterialID_MaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesByMaterialID_FunctionAddress, "MaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesByMaterialID_NumDeleted_PropertyAddress, DeleteTrianglesByMaterialID_FunctionAddress, "NumDeleted");
		DeleteTrianglesByMaterialID_NumDeleted_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesByMaterialID_FunctionAddress, "NumDeleted");
		DeleteTrianglesByMaterialID_NumDeleted_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesByMaterialID_FunctionAddress, "NumDeleted", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesByMaterialID_bDeferChangeNotifications_PropertyAddress, DeleteTrianglesByMaterialID_FunctionAddress, "bDeferChangeNotifications");
		DeleteTrianglesByMaterialID_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesByMaterialID_FunctionAddress, "bDeferChangeNotifications");
		DeleteTrianglesByMaterialID_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesByMaterialID_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesByMaterialID_Debug_PropertyAddress, DeleteTrianglesByMaterialID_FunctionAddress, "Debug");
		DeleteTrianglesByMaterialID_Debug_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesByMaterialID_FunctionAddress, "Debug");
		DeleteTrianglesByMaterialID_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesByMaterialID_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesByMaterialID_ReturnValue_PropertyAddress, DeleteTrianglesByMaterialID_FunctionAddress, "ReturnValue");
		DeleteTrianglesByMaterialID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesByMaterialID_FunctionAddress, "ReturnValue");
		DeleteTrianglesByMaterialID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesByMaterialID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DeleteTrianglesByMaterialID_IsValid = DeleteTrianglesByMaterialID_FunctionAddress != IntPtr.Zero && DeleteTrianglesByMaterialID_TargetMesh_IsValid && DeleteTrianglesByMaterialID_MaterialID_IsValid && DeleteTrianglesByMaterialID_NumDeleted_IsValid && DeleteTrianglesByMaterialID_bDeferChangeNotifications_IsValid && DeleteTrianglesByMaterialID_Debug_IsValid && DeleteTrianglesByMaterialID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:DeleteTrianglesByMaterialID", DeleteTrianglesByMaterialID_IsValid);
		CompactMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompactMaterialIDs");
		CompactMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(CompactMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompactMaterialIDs_TargetMesh_PropertyAddress, CompactMaterialIDs_FunctionAddress, "TargetMesh");
		CompactMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(CompactMaterialIDs_FunctionAddress, "TargetMesh");
		CompactMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompactMaterialIDs_SourceMaterialList_PropertyAddress, CompactMaterialIDs_FunctionAddress, "SourceMaterialList");
		CompactMaterialIDs_SourceMaterialList_Offset = NativeReflectionCached.GetPropertyOffset(CompactMaterialIDs_FunctionAddress, "SourceMaterialList");
		CompactMaterialIDs_SourceMaterialList_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMaterialIDs_FunctionAddress, "SourceMaterialList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CompactMaterialIDs_CompactedMaterialList_PropertyAddress, CompactMaterialIDs_FunctionAddress, "CompactedMaterialList");
		CompactMaterialIDs_CompactedMaterialList_Offset = NativeReflectionCached.GetPropertyOffset(CompactMaterialIDs_FunctionAddress, "CompactedMaterialList");
		CompactMaterialIDs_CompactedMaterialList_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMaterialIDs_FunctionAddress, "CompactedMaterialList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CompactMaterialIDs_Debug_PropertyAddress, CompactMaterialIDs_FunctionAddress, "Debug");
		CompactMaterialIDs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CompactMaterialIDs_FunctionAddress, "Debug");
		CompactMaterialIDs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMaterialIDs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompactMaterialIDs_ReturnValue_PropertyAddress, CompactMaterialIDs_FunctionAddress, "ReturnValue");
		CompactMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CompactMaterialIDs_FunctionAddress, "ReturnValue");
		CompactMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMaterialIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CompactMaterialIDs_IsValid = CompactMaterialIDs_FunctionAddress != IntPtr.Zero && CompactMaterialIDs_TargetMesh_IsValid && CompactMaterialIDs_SourceMaterialList_IsValid && CompactMaterialIDs_CompactedMaterialList_IsValid && CompactMaterialIDs_Debug_IsValid && CompactMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:CompactMaterialIDs", CompactMaterialIDs_IsValid);
		ClearMaterialIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearMaterialIDs");
		ClearMaterialIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMaterialIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearMaterialIDs_TargetMesh_PropertyAddress, ClearMaterialIDs_FunctionAddress, "TargetMesh");
		ClearMaterialIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ClearMaterialIDs_FunctionAddress, "TargetMesh");
		ClearMaterialIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMaterialIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearMaterialIDs_ClearValue_PropertyAddress, ClearMaterialIDs_FunctionAddress, "ClearValue");
		ClearMaterialIDs_ClearValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearMaterialIDs_FunctionAddress, "ClearValue");
		ClearMaterialIDs_ClearValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMaterialIDs_FunctionAddress, "ClearValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearMaterialIDs_Debug_PropertyAddress, ClearMaterialIDs_FunctionAddress, "Debug");
		ClearMaterialIDs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ClearMaterialIDs_FunctionAddress, "Debug");
		ClearMaterialIDs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMaterialIDs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearMaterialIDs_ReturnValue_PropertyAddress, ClearMaterialIDs_FunctionAddress, "ReturnValue");
		ClearMaterialIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearMaterialIDs_FunctionAddress, "ReturnValue");
		ClearMaterialIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMaterialIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ClearMaterialIDs_IsValid = ClearMaterialIDs_FunctionAddress != IntPtr.Zero && ClearMaterialIDs_TargetMesh_IsValid && ClearMaterialIDs_ClearValue_IsValid && ClearMaterialIDs_Debug_IsValid && ClearMaterialIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshMaterialFunctions:ClearMaterialIDs", ClearMaterialIDs_IsValid);
	}
}
