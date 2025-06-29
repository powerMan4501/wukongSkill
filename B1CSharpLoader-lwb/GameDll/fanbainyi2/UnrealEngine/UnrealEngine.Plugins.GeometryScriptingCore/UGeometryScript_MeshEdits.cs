using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshEdits : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetVertexPosition_IsValid;

	private static IntPtr SetVertexPosition_FunctionAddress;

	private static int SetVertexPosition_ParamsSize;

	private static bool SetVertexPosition_TargetMesh_IsValid;

	private static FFieldAddress SetVertexPosition_TargetMesh_PropertyAddress;

	private static int SetVertexPosition_TargetMesh_Offset;

	private static bool SetVertexPosition_VertexID_IsValid;

	private static FFieldAddress SetVertexPosition_VertexID_PropertyAddress;

	private static int SetVertexPosition_VertexID_Offset;

	private static bool SetVertexPosition_NewPosition_IsValid;

	private static FFieldAddress SetVertexPosition_NewPosition_PropertyAddress;

	private static int SetVertexPosition_NewPosition_Offset;

	private static bool SetVertexPosition_bIsValidVertex_IsValid;

	private static FFieldAddress SetVertexPosition_bIsValidVertex_PropertyAddress;

	private static int SetVertexPosition_bIsValidVertex_Offset;

	private static bool SetVertexPosition_bDeferChangeNotifications_IsValid;

	private static FFieldAddress SetVertexPosition_bDeferChangeNotifications_PropertyAddress;

	private static int SetVertexPosition_bDeferChangeNotifications_Offset;

	private static bool SetVertexPosition_ReturnValue_IsValid;

	private static FFieldAddress SetVertexPosition_ReturnValue_PropertyAddress;

	private static int SetVertexPosition_ReturnValue_Offset;

	private static bool DiscardMeshAttributes_IsValid;

	private static IntPtr DiscardMeshAttributes_FunctionAddress;

	private static int DiscardMeshAttributes_ParamsSize;

	private static bool DiscardMeshAttributes_TargetMesh_IsValid;

	private static FFieldAddress DiscardMeshAttributes_TargetMesh_PropertyAddress;

	private static int DiscardMeshAttributes_TargetMesh_Offset;

	private static bool DiscardMeshAttributes_bDeferChangeNotifications_IsValid;

	private static FFieldAddress DiscardMeshAttributes_bDeferChangeNotifications_PropertyAddress;

	private static int DiscardMeshAttributes_bDeferChangeNotifications_Offset;

	private static bool DiscardMeshAttributes_ReturnValue_IsValid;

	private static FFieldAddress DiscardMeshAttributes_ReturnValue_PropertyAddress;

	private static int DiscardMeshAttributes_ReturnValue_Offset;

	private static bool DeleteVerticesFromMesh_IsValid;

	private static IntPtr DeleteVerticesFromMesh_FunctionAddress;

	private static int DeleteVerticesFromMesh_ParamsSize;

	private static bool DeleteVerticesFromMesh_TargetMesh_IsValid;

	private static FFieldAddress DeleteVerticesFromMesh_TargetMesh_PropertyAddress;

	private static int DeleteVerticesFromMesh_TargetMesh_Offset;

	private static bool DeleteVerticesFromMesh_VertexList_IsValid;

	private static FFieldAddress DeleteVerticesFromMesh_VertexList_PropertyAddress;

	private static int DeleteVerticesFromMesh_VertexList_Offset;

	private static bool DeleteVerticesFromMesh_NumDeleted_IsValid;

	private static FFieldAddress DeleteVerticesFromMesh_NumDeleted_PropertyAddress;

	private static int DeleteVerticesFromMesh_NumDeleted_Offset;

	private static bool DeleteVerticesFromMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress DeleteVerticesFromMesh_bDeferChangeNotifications_PropertyAddress;

	private static int DeleteVerticesFromMesh_bDeferChangeNotifications_Offset;

	private static bool DeleteVerticesFromMesh_ReturnValue_IsValid;

	private static FFieldAddress DeleteVerticesFromMesh_ReturnValue_PropertyAddress;

	private static int DeleteVerticesFromMesh_ReturnValue_Offset;

	private static bool DeleteVertexFromMesh_IsValid;

	private static IntPtr DeleteVertexFromMesh_FunctionAddress;

	private static int DeleteVertexFromMesh_ParamsSize;

	private static bool DeleteVertexFromMesh_TargetMesh_IsValid;

	private static FFieldAddress DeleteVertexFromMesh_TargetMesh_PropertyAddress;

	private static int DeleteVertexFromMesh_TargetMesh_Offset;

	private static bool DeleteVertexFromMesh_VertexID_IsValid;

	private static FFieldAddress DeleteVertexFromMesh_VertexID_PropertyAddress;

	private static int DeleteVertexFromMesh_VertexID_Offset;

	private static bool DeleteVertexFromMesh_bWasVertexDeleted_IsValid;

	private static FFieldAddress DeleteVertexFromMesh_bWasVertexDeleted_PropertyAddress;

	private static int DeleteVertexFromMesh_bWasVertexDeleted_Offset;

	private static bool DeleteVertexFromMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress DeleteVertexFromMesh_bDeferChangeNotifications_PropertyAddress;

	private static int DeleteVertexFromMesh_bDeferChangeNotifications_Offset;

	private static bool DeleteVertexFromMesh_ReturnValue_IsValid;

	private static FFieldAddress DeleteVertexFromMesh_ReturnValue_PropertyAddress;

	private static int DeleteVertexFromMesh_ReturnValue_Offset;

	private static bool DeleteTrianglesFromMesh_IsValid;

	private static IntPtr DeleteTrianglesFromMesh_FunctionAddress;

	private static int DeleteTrianglesFromMesh_ParamsSize;

	private static bool DeleteTrianglesFromMesh_TargetMesh_IsValid;

	private static FFieldAddress DeleteTrianglesFromMesh_TargetMesh_PropertyAddress;

	private static int DeleteTrianglesFromMesh_TargetMesh_Offset;

	private static bool DeleteTrianglesFromMesh_TriangleList_IsValid;

	private static FFieldAddress DeleteTrianglesFromMesh_TriangleList_PropertyAddress;

	private static int DeleteTrianglesFromMesh_TriangleList_Offset;

	private static bool DeleteTrianglesFromMesh_NumDeleted_IsValid;

	private static FFieldAddress DeleteTrianglesFromMesh_NumDeleted_PropertyAddress;

	private static int DeleteTrianglesFromMesh_NumDeleted_Offset;

	private static bool DeleteTrianglesFromMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress DeleteTrianglesFromMesh_bDeferChangeNotifications_PropertyAddress;

	private static int DeleteTrianglesFromMesh_bDeferChangeNotifications_Offset;

	private static bool DeleteTrianglesFromMesh_ReturnValue_IsValid;

	private static FFieldAddress DeleteTrianglesFromMesh_ReturnValue_PropertyAddress;

	private static int DeleteTrianglesFromMesh_ReturnValue_Offset;

	private static bool DeleteTriangleFromMesh_IsValid;

	private static IntPtr DeleteTriangleFromMesh_FunctionAddress;

	private static int DeleteTriangleFromMesh_ParamsSize;

	private static bool DeleteTriangleFromMesh_TargetMesh_IsValid;

	private static FFieldAddress DeleteTriangleFromMesh_TargetMesh_PropertyAddress;

	private static int DeleteTriangleFromMesh_TargetMesh_Offset;

	private static bool DeleteTriangleFromMesh_TriangleID_IsValid;

	private static FFieldAddress DeleteTriangleFromMesh_TriangleID_PropertyAddress;

	private static int DeleteTriangleFromMesh_TriangleID_Offset;

	private static bool DeleteTriangleFromMesh_bWasTriangleDeleted_IsValid;

	private static FFieldAddress DeleteTriangleFromMesh_bWasTriangleDeleted_PropertyAddress;

	private static int DeleteTriangleFromMesh_bWasTriangleDeleted_Offset;

	private static bool DeleteTriangleFromMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress DeleteTriangleFromMesh_bDeferChangeNotifications_PropertyAddress;

	private static int DeleteTriangleFromMesh_bDeferChangeNotifications_Offset;

	private static bool DeleteTriangleFromMesh_ReturnValue_IsValid;

	private static FFieldAddress DeleteTriangleFromMesh_ReturnValue_PropertyAddress;

	private static int DeleteTriangleFromMesh_ReturnValue_Offset;

	private static bool AppendMeshRepeated_IsValid;

	private static IntPtr AppendMeshRepeated_FunctionAddress;

	private static int AppendMeshRepeated_ParamsSize;

	private static bool AppendMeshRepeated_TargetMesh_IsValid;

	private static FFieldAddress AppendMeshRepeated_TargetMesh_PropertyAddress;

	private static int AppendMeshRepeated_TargetMesh_Offset;

	private static bool AppendMeshRepeated_AppendMesh_IsValid;

	private static FFieldAddress AppendMeshRepeated_AppendMesh_PropertyAddress;

	private static int AppendMeshRepeated_AppendMesh_Offset;

	private static bool AppendMeshRepeated_AppendTransform_IsValid;

	private static FFieldAddress AppendMeshRepeated_AppendTransform_PropertyAddress;

	private static int AppendMeshRepeated_AppendTransform_Offset;

	private static bool AppendMeshRepeated_RepeatCount_IsValid;

	private static FFieldAddress AppendMeshRepeated_RepeatCount_PropertyAddress;

	private static int AppendMeshRepeated_RepeatCount_Offset;

	private static bool AppendMeshRepeated_bApplyTransformToFirstInstance_IsValid;

	private static FFieldAddress AppendMeshRepeated_bApplyTransformToFirstInstance_PropertyAddress;

	private static int AppendMeshRepeated_bApplyTransformToFirstInstance_Offset;

	private static bool AppendMeshRepeated_bDeferChangeNotifications_IsValid;

	private static FFieldAddress AppendMeshRepeated_bDeferChangeNotifications_PropertyAddress;

	private static int AppendMeshRepeated_bDeferChangeNotifications_Offset;

	private static bool AppendMeshRepeated_Debug_IsValid;

	private static FFieldAddress AppendMeshRepeated_Debug_PropertyAddress;

	private static int AppendMeshRepeated_Debug_Offset;

	private static bool AppendMeshRepeated_ReturnValue_IsValid;

	private static FFieldAddress AppendMeshRepeated_ReturnValue_PropertyAddress;

	private static int AppendMeshRepeated_ReturnValue_Offset;

	private static bool AppendMesh_IsValid;

	private static IntPtr AppendMesh_FunctionAddress;

	private static int AppendMesh_ParamsSize;

	private static bool AppendMesh_TargetMesh_IsValid;

	private static FFieldAddress AppendMesh_TargetMesh_PropertyAddress;

	private static int AppendMesh_TargetMesh_Offset;

	private static bool AppendMesh_AppendMesh_IsValid;

	private static FFieldAddress AppendMesh_AppendMesh_PropertyAddress;

	private static int AppendMesh_AppendMesh_Offset;

	private static bool AppendMesh_AppendTransform_IsValid;

	private static FFieldAddress AppendMesh_AppendTransform_PropertyAddress;

	private static int AppendMesh_AppendTransform_Offset;

	private static bool AppendMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress AppendMesh_bDeferChangeNotifications_PropertyAddress;

	private static int AppendMesh_bDeferChangeNotifications_Offset;

	private static bool AppendMesh_Debug_IsValid;

	private static FFieldAddress AppendMesh_Debug_PropertyAddress;

	private static int AppendMesh_Debug_Offset;

	private static bool AppendMesh_ReturnValue_IsValid;

	private static FFieldAddress AppendMesh_ReturnValue_PropertyAddress;

	private static int AppendMesh_ReturnValue_Offset;

	private static bool AppendBuffersToMesh_IsValid;

	private static IntPtr AppendBuffersToMesh_FunctionAddress;

	private static int AppendBuffersToMesh_ParamsSize;

	private static bool AppendBuffersToMesh_TargetMesh_IsValid;

	private static FFieldAddress AppendBuffersToMesh_TargetMesh_PropertyAddress;

	private static int AppendBuffersToMesh_TargetMesh_Offset;

	private static bool AppendBuffersToMesh_Buffers_IsValid;

	private static FFieldAddress AppendBuffersToMesh_Buffers_PropertyAddress;

	private static int AppendBuffersToMesh_Buffers_Offset;

	private static bool AppendBuffersToMesh_NewTriangleIndicesList_IsValid;

	private static FFieldAddress AppendBuffersToMesh_NewTriangleIndicesList_PropertyAddress;

	private static int AppendBuffersToMesh_NewTriangleIndicesList_Offset;

	private static bool AppendBuffersToMesh_MaterialID_IsValid;

	private static FFieldAddress AppendBuffersToMesh_MaterialID_PropertyAddress;

	private static int AppendBuffersToMesh_MaterialID_Offset;

	private static bool AppendBuffersToMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress AppendBuffersToMesh_bDeferChangeNotifications_PropertyAddress;

	private static int AppendBuffersToMesh_bDeferChangeNotifications_Offset;

	private static bool AppendBuffersToMesh_Debug_IsValid;

	private static FFieldAddress AppendBuffersToMesh_Debug_PropertyAddress;

	private static int AppendBuffersToMesh_Debug_Offset;

	private static bool AppendBuffersToMesh_ReturnValue_IsValid;

	private static FFieldAddress AppendBuffersToMesh_ReturnValue_PropertyAddress;

	private static int AppendBuffersToMesh_ReturnValue_Offset;

	private static bool AddVerticesToMesh_IsValid;

	private static IntPtr AddVerticesToMesh_FunctionAddress;

	private static int AddVerticesToMesh_ParamsSize;

	private static bool AddVerticesToMesh_TargetMesh_IsValid;

	private static FFieldAddress AddVerticesToMesh_TargetMesh_PropertyAddress;

	private static int AddVerticesToMesh_TargetMesh_Offset;

	private static bool AddVerticesToMesh_NewPositionsList_IsValid;

	private static FFieldAddress AddVerticesToMesh_NewPositionsList_PropertyAddress;

	private static int AddVerticesToMesh_NewPositionsList_Offset;

	private static bool AddVerticesToMesh_NewIndicesList_IsValid;

	private static FFieldAddress AddVerticesToMesh_NewIndicesList_PropertyAddress;

	private static int AddVerticesToMesh_NewIndicesList_Offset;

	private static bool AddVerticesToMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress AddVerticesToMesh_bDeferChangeNotifications_PropertyAddress;

	private static int AddVerticesToMesh_bDeferChangeNotifications_Offset;

	private static bool AddVerticesToMesh_ReturnValue_IsValid;

	private static FFieldAddress AddVerticesToMesh_ReturnValue_PropertyAddress;

	private static int AddVerticesToMesh_ReturnValue_Offset;

	private static bool AddVertexToMesh_IsValid;

	private static IntPtr AddVertexToMesh_FunctionAddress;

	private static int AddVertexToMesh_ParamsSize;

	private static bool AddVertexToMesh_TargetMesh_IsValid;

	private static FFieldAddress AddVertexToMesh_TargetMesh_PropertyAddress;

	private static int AddVertexToMesh_TargetMesh_Offset;

	private static bool AddVertexToMesh_NewPosition_IsValid;

	private static FFieldAddress AddVertexToMesh_NewPosition_PropertyAddress;

	private static int AddVertexToMesh_NewPosition_Offset;

	private static bool AddVertexToMesh_NewVertexIndex_IsValid;

	private static FFieldAddress AddVertexToMesh_NewVertexIndex_PropertyAddress;

	private static int AddVertexToMesh_NewVertexIndex_Offset;

	private static bool AddVertexToMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress AddVertexToMesh_bDeferChangeNotifications_PropertyAddress;

	private static int AddVertexToMesh_bDeferChangeNotifications_Offset;

	private static bool AddVertexToMesh_ReturnValue_IsValid;

	private static FFieldAddress AddVertexToMesh_ReturnValue_PropertyAddress;

	private static int AddVertexToMesh_ReturnValue_Offset;

	private static bool AddTriangleToMesh_IsValid;

	private static IntPtr AddTriangleToMesh_FunctionAddress;

	private static int AddTriangleToMesh_ParamsSize;

	private static bool AddTriangleToMesh_TargetMesh_IsValid;

	private static FFieldAddress AddTriangleToMesh_TargetMesh_PropertyAddress;

	private static int AddTriangleToMesh_TargetMesh_Offset;

	private static bool AddTriangleToMesh_NewTriangle_IsValid;

	private static FFieldAddress AddTriangleToMesh_NewTriangle_PropertyAddress;

	private static int AddTriangleToMesh_NewTriangle_Offset;

	private static bool AddTriangleToMesh_NewTriangleIndex_IsValid;

	private static FFieldAddress AddTriangleToMesh_NewTriangleIndex_PropertyAddress;

	private static int AddTriangleToMesh_NewTriangleIndex_Offset;

	private static bool AddTriangleToMesh_NewTriangleGroupID_IsValid;

	private static FFieldAddress AddTriangleToMesh_NewTriangleGroupID_PropertyAddress;

	private static int AddTriangleToMesh_NewTriangleGroupID_Offset;

	private static bool AddTriangleToMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress AddTriangleToMesh_bDeferChangeNotifications_PropertyAddress;

	private static int AddTriangleToMesh_bDeferChangeNotifications_Offset;

	private static bool AddTriangleToMesh_Debug_IsValid;

	private static FFieldAddress AddTriangleToMesh_Debug_PropertyAddress;

	private static int AddTriangleToMesh_Debug_Offset;

	private static bool AddTriangleToMesh_ReturnValue_IsValid;

	private static FFieldAddress AddTriangleToMesh_ReturnValue_PropertyAddress;

	private static int AddTriangleToMesh_ReturnValue_Offset;

	private static bool AddTrianglesToMesh_IsValid;

	private static IntPtr AddTrianglesToMesh_FunctionAddress;

	private static int AddTrianglesToMesh_ParamsSize;

	private static bool AddTrianglesToMesh_TargetMesh_IsValid;

	private static FFieldAddress AddTrianglesToMesh_TargetMesh_PropertyAddress;

	private static int AddTrianglesToMesh_TargetMesh_Offset;

	private static bool AddTrianglesToMesh_NewTrianglesList_IsValid;

	private static FFieldAddress AddTrianglesToMesh_NewTrianglesList_PropertyAddress;

	private static int AddTrianglesToMesh_NewTrianglesList_Offset;

	private static bool AddTrianglesToMesh_NewIndicesList_IsValid;

	private static FFieldAddress AddTrianglesToMesh_NewIndicesList_PropertyAddress;

	private static int AddTrianglesToMesh_NewIndicesList_Offset;

	private static bool AddTrianglesToMesh_NewTriangleGroupID_IsValid;

	private static FFieldAddress AddTrianglesToMesh_NewTriangleGroupID_PropertyAddress;

	private static int AddTrianglesToMesh_NewTriangleGroupID_Offset;

	private static bool AddTrianglesToMesh_bDeferChangeNotifications_IsValid;

	private static FFieldAddress AddTrianglesToMesh_bDeferChangeNotifications_PropertyAddress;

	private static int AddTrianglesToMesh_bDeferChangeNotifications_Offset;

	private static bool AddTrianglesToMesh_Debug_IsValid;

	private static FFieldAddress AddTrianglesToMesh_Debug_PropertyAddress;

	private static int AddTrianglesToMesh_Debug_Offset;

	private static bool AddTrianglesToMesh_ReturnValue_IsValid;

	private static FFieldAddress AddTrianglesToMesh_ReturnValue_PropertyAddress;

	private static int AddTrianglesToMesh_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:SetVertexPosition")]
	public unsafe static UDynamicMesh SetVertexPosition(UDynamicMesh TargetMesh, int VertexID, FVector NewPosition, out bool bIsValidVertex, bool bDeferChangeNotifications = false)
	{
		if (!SetVertexPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:SetVertexPosition");
			bIsValidVertex = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVertexPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVertexPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetVertexPosition_TargetMesh_Offset), 0, SetVertexPosition_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVertexPosition_VertexID_Offset), 0, SetVertexPosition_VertexID_PropertyAddress.Address, VertexID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVertexPosition_NewPosition_Offset), 0, SetVertexPosition_NewPosition_PropertyAddress.Address, NewPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVertexPosition_bDeferChangeNotifications_Offset), 0, SetVertexPosition_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVertexPosition_FunctionAddress, intPtr, SetVertexPosition_ParamsSize);
		bIsValidVertex = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetVertexPosition_bIsValidVertex_Offset), 0, SetVertexPosition_bIsValidVertex_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetVertexPosition_ReturnValue_Offset), 0, SetVertexPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DiscardMeshAttributes")]
	public unsafe static UDynamicMesh DiscardMeshAttributes(UDynamicMesh TargetMesh, bool bDeferChangeNotifications = false)
	{
		if (!DiscardMeshAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DiscardMeshAttributes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DiscardMeshAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DiscardMeshAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, DiscardMeshAttributes_TargetMesh_Offset), 0, DiscardMeshAttributes_TargetMesh_PropertyAddress.Address, TargetMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DiscardMeshAttributes_bDeferChangeNotifications_Offset), 0, DiscardMeshAttributes_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DiscardMeshAttributes_FunctionAddress, intPtr, DiscardMeshAttributes_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, DiscardMeshAttributes_ReturnValue_Offset), 0, DiscardMeshAttributes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteVerticesFromMesh")]
	public unsafe static UDynamicMesh DeleteVerticesFromMesh(UDynamicMesh TargetMesh, FGeometryScriptIndexList VertexList, out int NumDeleted, bool bDeferChangeNotifications = false)
	{
		if (!DeleteVerticesFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteVerticesFromMesh");
			NumDeleted = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteVerticesFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteVerticesFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, DeleteVerticesFromMesh_TargetMesh_Offset), 0, DeleteVerticesFromMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(DeleteVerticesFromMesh_VertexList_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, DeleteVerticesFromMesh_VertexList_Offset), 0, DeleteVerticesFromMesh_VertexList_PropertyAddress.Address, VertexList);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteVerticesFromMesh_bDeferChangeNotifications_Offset), 0, DeleteVerticesFromMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteVerticesFromMesh_FunctionAddress, intPtr, DeleteVerticesFromMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteVerticesFromMesh_VertexList_PropertyAddress.Address, intPtr);
		NumDeleted = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, DeleteVerticesFromMesh_NumDeleted_Offset), 0, DeleteVerticesFromMesh_NumDeleted_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, DeleteVerticesFromMesh_ReturnValue_Offset), 0, DeleteVerticesFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteVertexFromMesh")]
	public unsafe static UDynamicMesh DeleteVertexFromMesh(UDynamicMesh TargetMesh, int VertexID, out bool bWasVertexDeleted, bool bDeferChangeNotifications = false)
	{
		if (!DeleteVertexFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteVertexFromMesh");
			bWasVertexDeleted = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteVertexFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteVertexFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, DeleteVertexFromMesh_TargetMesh_Offset), 0, DeleteVertexFromMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DeleteVertexFromMesh_VertexID_Offset), 0, DeleteVertexFromMesh_VertexID_PropertyAddress.Address, VertexID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteVertexFromMesh_bDeferChangeNotifications_Offset), 0, DeleteVertexFromMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteVertexFromMesh_FunctionAddress, intPtr, DeleteVertexFromMesh_ParamsSize);
		bWasVertexDeleted = BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteVertexFromMesh_bWasVertexDeleted_Offset), 0, DeleteVertexFromMesh_bWasVertexDeleted_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, DeleteVertexFromMesh_ReturnValue_Offset), 0, DeleteVertexFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteTrianglesFromMesh")]
	public unsafe static UDynamicMesh DeleteTrianglesFromMesh(UDynamicMesh TargetMesh, FGeometryScriptIndexList TriangleList, out int NumDeleted, bool bDeferChangeNotifications = false)
	{
		if (!DeleteTrianglesFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteTrianglesFromMesh");
			NumDeleted = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteTrianglesFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteTrianglesFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, DeleteTrianglesFromMesh_TargetMesh_Offset), 0, DeleteTrianglesFromMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(DeleteTrianglesFromMesh_TriangleList_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, DeleteTrianglesFromMesh_TriangleList_Offset), 0, DeleteTrianglesFromMesh_TriangleList_PropertyAddress.Address, TriangleList);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteTrianglesFromMesh_bDeferChangeNotifications_Offset), 0, DeleteTrianglesFromMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteTrianglesFromMesh_FunctionAddress, intPtr, DeleteTrianglesFromMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteTrianglesFromMesh_TriangleList_PropertyAddress.Address, intPtr);
		NumDeleted = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, DeleteTrianglesFromMesh_NumDeleted_Offset), 0, DeleteTrianglesFromMesh_NumDeleted_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, DeleteTrianglesFromMesh_ReturnValue_Offset), 0, DeleteTrianglesFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteTriangleFromMesh")]
	public unsafe static UDynamicMesh DeleteTriangleFromMesh(UDynamicMesh TargetMesh, int TriangleID, out bool bWasTriangleDeleted, bool bDeferChangeNotifications = false)
	{
		if (!DeleteTriangleFromMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteTriangleFromMesh");
			bWasTriangleDeleted = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteTriangleFromMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteTriangleFromMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, DeleteTriangleFromMesh_TargetMesh_Offset), 0, DeleteTriangleFromMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DeleteTriangleFromMesh_TriangleID_Offset), 0, DeleteTriangleFromMesh_TriangleID_PropertyAddress.Address, TriangleID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteTriangleFromMesh_bDeferChangeNotifications_Offset), 0, DeleteTriangleFromMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteTriangleFromMesh_FunctionAddress, intPtr, DeleteTriangleFromMesh_ParamsSize);
		bWasTriangleDeleted = BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteTriangleFromMesh_bWasTriangleDeleted_Offset), 0, DeleteTriangleFromMesh_bWasTriangleDeleted_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, DeleteTriangleFromMesh_ReturnValue_Offset), 0, DeleteTriangleFromMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendMeshRepeated")]
	public unsafe static UDynamicMesh AppendMeshRepeated(UDynamicMesh TargetMesh, UDynamicMesh AppendMesh, FTransform AppendTransform, int RepeatCount, bool bApplyTransformToFirstInstance, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!AppendMeshRepeated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendMeshRepeated");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendMeshRepeated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendMeshRepeated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendMeshRepeated_TargetMesh_Offset), 0, AppendMeshRepeated_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendMeshRepeated_AppendMesh_Offset), 0, AppendMeshRepeated_AppendMesh_PropertyAddress.Address, AppendMesh);
		NativeReflection.InitializeValue_InContainer(AppendMeshRepeated_AppendTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendMeshRepeated_AppendTransform_Offset), 0, AppendMeshRepeated_AppendTransform_PropertyAddress.Address, AppendTransform);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendMeshRepeated_RepeatCount_Offset), 0, AppendMeshRepeated_RepeatCount_PropertyAddress.Address, RepeatCount);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendMeshRepeated_bApplyTransformToFirstInstance_Offset), 0, AppendMeshRepeated_bApplyTransformToFirstInstance_PropertyAddress.Address, bApplyTransformToFirstInstance);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendMeshRepeated_bDeferChangeNotifications_Offset), 0, AppendMeshRepeated_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendMeshRepeated_Debug_Offset), 0, AppendMeshRepeated_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendMeshRepeated_FunctionAddress, intPtr, AppendMeshRepeated_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendMeshRepeated_ReturnValue_Offset), 0, AppendMeshRepeated_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendMesh")]
	public unsafe static UDynamicMesh AppendMesh(UDynamicMesh TargetMesh, UDynamicMesh AppendMesh, FTransform AppendTransform, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!AppendMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendMesh_TargetMesh_Offset), 0, AppendMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendMesh_AppendMesh_Offset), 0, AppendMesh_AppendMesh_PropertyAddress.Address, AppendMesh);
		NativeReflection.InitializeValue_InContainer(AppendMesh_AppendTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendMesh_AppendTransform_Offset), 0, AppendMesh_AppendTransform_PropertyAddress.Address, AppendTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendMesh_bDeferChangeNotifications_Offset), 0, AppendMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendMesh_Debug_Offset), 0, AppendMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendMesh_FunctionAddress, intPtr, AppendMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendMesh_ReturnValue_Offset), 0, AppendMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendBuffersToMesh")]
	public unsafe static UDynamicMesh AppendBuffersToMesh(UDynamicMesh TargetMesh, FGeometryScriptSimpleMeshBuffers Buffers, out FGeometryScriptIndexList NewTriangleIndicesList, int MaterialID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!AppendBuffersToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendBuffersToMesh");
			NewTriangleIndicesList = default(FGeometryScriptIndexList);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendBuffersToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendBuffersToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendBuffersToMesh_TargetMesh_Offset), 0, AppendBuffersToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendBuffersToMesh_Buffers_PropertyAddress.Address, intPtr);
		FGeometryScriptSimpleMeshBuffers.ToNative(IntPtr.Add(intPtr, AppendBuffersToMesh_Buffers_Offset), 0, AppendBuffersToMesh_Buffers_PropertyAddress.Address, Buffers);
		NativeReflection.InitializeValue_InContainer(AppendBuffersToMesh_NewTriangleIndicesList_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendBuffersToMesh_MaterialID_Offset), 0, AppendBuffersToMesh_MaterialID_PropertyAddress.Address, MaterialID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendBuffersToMesh_bDeferChangeNotifications_Offset), 0, AppendBuffersToMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendBuffersToMesh_Debug_Offset), 0, AppendBuffersToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendBuffersToMesh_FunctionAddress, intPtr, AppendBuffersToMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendBuffersToMesh_Buffers_PropertyAddress.Address, intPtr);
		NewTriangleIndicesList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, AppendBuffersToMesh_NewTriangleIndicesList_Offset), 0, AppendBuffersToMesh_NewTriangleIndicesList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AppendBuffersToMesh_NewTriangleIndicesList_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendBuffersToMesh_ReturnValue_Offset), 0, AppendBuffersToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddVerticesToMesh")]
	public unsafe static UDynamicMesh AddVerticesToMesh(UDynamicMesh TargetMesh, FGeometryScriptVectorList NewPositionsList, out FGeometryScriptIndexList NewIndicesList, bool bDeferChangeNotifications = false)
	{
		if (!AddVerticesToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddVerticesToMesh");
			NewIndicesList = default(FGeometryScriptIndexList);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVerticesToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVerticesToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AddVerticesToMesh_TargetMesh_Offset), 0, AddVerticesToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AddVerticesToMesh_NewPositionsList_PropertyAddress.Address, intPtr);
		FGeometryScriptVectorList.ToNative(IntPtr.Add(intPtr, AddVerticesToMesh_NewPositionsList_Offset), 0, AddVerticesToMesh_NewPositionsList_PropertyAddress.Address, NewPositionsList);
		NativeReflection.InitializeValue_InContainer(AddVerticesToMesh_NewIndicesList_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVerticesToMesh_bDeferChangeNotifications_Offset), 0, AddVerticesToMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddVerticesToMesh_FunctionAddress, intPtr, AddVerticesToMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddVerticesToMesh_NewPositionsList_PropertyAddress.Address, intPtr);
		NewIndicesList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, AddVerticesToMesh_NewIndicesList_Offset), 0, AddVerticesToMesh_NewIndicesList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddVerticesToMesh_NewIndicesList_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AddVerticesToMesh_ReturnValue_Offset), 0, AddVerticesToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddVertexToMesh")]
	public unsafe static UDynamicMesh AddVertexToMesh(UDynamicMesh TargetMesh, FVector NewPosition, out int NewVertexIndex, bool bDeferChangeNotifications = false)
	{
		if (!AddVertexToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddVertexToMesh");
			NewVertexIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVertexToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVertexToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AddVertexToMesh_TargetMesh_Offset), 0, AddVertexToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddVertexToMesh_NewPosition_Offset), 0, AddVertexToMesh_NewPosition_PropertyAddress.Address, NewPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVertexToMesh_bDeferChangeNotifications_Offset), 0, AddVertexToMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddVertexToMesh_FunctionAddress, intPtr, AddVertexToMesh_ParamsSize);
		NewVertexIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddVertexToMesh_NewVertexIndex_Offset), 0, AddVertexToMesh_NewVertexIndex_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AddVertexToMesh_ReturnValue_Offset), 0, AddVertexToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddTriangleToMesh")]
	public unsafe static UDynamicMesh AddTriangleToMesh(UDynamicMesh TargetMesh, FIntVector NewTriangle, out int NewTriangleIndex, int NewTriangleGroupID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!AddTriangleToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddTriangleToMesh");
			NewTriangleIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTriangleToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTriangleToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AddTriangleToMesh_TargetMesh_Offset), 0, AddTriangleToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<FIntVector>.ToNative(IntPtr.Add(intPtr, AddTriangleToMesh_NewTriangle_Offset), 0, AddTriangleToMesh_NewTriangle_PropertyAddress.Address, NewTriangle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddTriangleToMesh_NewTriangleGroupID_Offset), 0, AddTriangleToMesh_NewTriangleGroupID_PropertyAddress.Address, NewTriangleGroupID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddTriangleToMesh_bDeferChangeNotifications_Offset), 0, AddTriangleToMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AddTriangleToMesh_Debug_Offset), 0, AddTriangleToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTriangleToMesh_FunctionAddress, intPtr, AddTriangleToMesh_ParamsSize);
		NewTriangleIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddTriangleToMesh_NewTriangleIndex_Offset), 0, AddTriangleToMesh_NewTriangleIndex_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AddTriangleToMesh_ReturnValue_Offset), 0, AddTriangleToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddTrianglesToMesh")]
	public unsafe static UDynamicMesh AddTrianglesToMesh(UDynamicMesh TargetMesh, FGeometryScriptTriangleList NewTrianglesList, out FGeometryScriptIndexList NewIndicesList, int NewTriangleGroupID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!AddTrianglesToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddTrianglesToMesh");
			NewIndicesList = default(FGeometryScriptIndexList);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTrianglesToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTrianglesToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AddTrianglesToMesh_TargetMesh_Offset), 0, AddTrianglesToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AddTrianglesToMesh_NewTrianglesList_PropertyAddress.Address, intPtr);
		FGeometryScriptTriangleList.ToNative(IntPtr.Add(intPtr, AddTrianglesToMesh_NewTrianglesList_Offset), 0, AddTrianglesToMesh_NewTrianglesList_PropertyAddress.Address, NewTrianglesList);
		NativeReflection.InitializeValue_InContainer(AddTrianglesToMesh_NewIndicesList_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddTrianglesToMesh_NewTriangleGroupID_Offset), 0, AddTrianglesToMesh_NewTriangleGroupID_PropertyAddress.Address, NewTriangleGroupID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddTrianglesToMesh_bDeferChangeNotifications_Offset), 0, AddTrianglesToMesh_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AddTrianglesToMesh_Debug_Offset), 0, AddTrianglesToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTrianglesToMesh_FunctionAddress, intPtr, AddTrianglesToMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTrianglesToMesh_NewTrianglesList_PropertyAddress.Address, intPtr);
		NewIndicesList = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, AddTrianglesToMesh_NewIndicesList_Offset), 0, AddTrianglesToMesh_NewIndicesList_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddTrianglesToMesh_NewIndicesList_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AddTrianglesToMesh_ReturnValue_Offset), 0, AddTrianglesToMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshEdits()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshEdits)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshEdits));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions");
		SetVertexPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVertexPosition");
		SetVertexPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVertexPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_TargetMesh_PropertyAddress, SetVertexPosition_FunctionAddress, "TargetMesh");
		SetVertexPosition_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "TargetMesh");
		SetVertexPosition_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_VertexID_PropertyAddress, SetVertexPosition_FunctionAddress, "VertexID");
		SetVertexPosition_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "VertexID");
		SetVertexPosition_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "VertexID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_NewPosition_PropertyAddress, SetVertexPosition_FunctionAddress, "NewPosition");
		SetVertexPosition_NewPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "NewPosition");
		SetVertexPosition_NewPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "NewPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_bIsValidVertex_PropertyAddress, SetVertexPosition_FunctionAddress, "bIsValidVertex");
		SetVertexPosition_bIsValidVertex_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "bIsValidVertex");
		SetVertexPosition_bIsValidVertex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "bIsValidVertex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_bDeferChangeNotifications_PropertyAddress, SetVertexPosition_FunctionAddress, "bDeferChangeNotifications");
		SetVertexPosition_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "bDeferChangeNotifications");
		SetVertexPosition_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_ReturnValue_PropertyAddress, SetVertexPosition_FunctionAddress, "ReturnValue");
		SetVertexPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "ReturnValue");
		SetVertexPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetVertexPosition_IsValid = SetVertexPosition_FunctionAddress != IntPtr.Zero && SetVertexPosition_TargetMesh_IsValid && SetVertexPosition_VertexID_IsValid && SetVertexPosition_NewPosition_IsValid && SetVertexPosition_bIsValidVertex_IsValid && SetVertexPosition_bDeferChangeNotifications_IsValid && SetVertexPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:SetVertexPosition", SetVertexPosition_IsValid);
		DiscardMeshAttributes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DiscardMeshAttributes");
		DiscardMeshAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(DiscardMeshAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DiscardMeshAttributes_TargetMesh_PropertyAddress, DiscardMeshAttributes_FunctionAddress, "TargetMesh");
		DiscardMeshAttributes_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(DiscardMeshAttributes_FunctionAddress, "TargetMesh");
		DiscardMeshAttributes_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(DiscardMeshAttributes_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DiscardMeshAttributes_bDeferChangeNotifications_PropertyAddress, DiscardMeshAttributes_FunctionAddress, "bDeferChangeNotifications");
		DiscardMeshAttributes_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(DiscardMeshAttributes_FunctionAddress, "bDeferChangeNotifications");
		DiscardMeshAttributes_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(DiscardMeshAttributes_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DiscardMeshAttributes_ReturnValue_PropertyAddress, DiscardMeshAttributes_FunctionAddress, "ReturnValue");
		DiscardMeshAttributes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DiscardMeshAttributes_FunctionAddress, "ReturnValue");
		DiscardMeshAttributes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DiscardMeshAttributes_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DiscardMeshAttributes_IsValid = DiscardMeshAttributes_FunctionAddress != IntPtr.Zero && DiscardMeshAttributes_TargetMesh_IsValid && DiscardMeshAttributes_bDeferChangeNotifications_IsValid && DiscardMeshAttributes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DiscardMeshAttributes", DiscardMeshAttributes_IsValid);
		DeleteVerticesFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteVerticesFromMesh");
		DeleteVerticesFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteVerticesFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteVerticesFromMesh_TargetMesh_PropertyAddress, DeleteVerticesFromMesh_FunctionAddress, "TargetMesh");
		DeleteVerticesFromMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVerticesFromMesh_FunctionAddress, "TargetMesh");
		DeleteVerticesFromMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVerticesFromMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVerticesFromMesh_VertexList_PropertyAddress, DeleteVerticesFromMesh_FunctionAddress, "VertexList");
		DeleteVerticesFromMesh_VertexList_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVerticesFromMesh_FunctionAddress, "VertexList");
		DeleteVerticesFromMesh_VertexList_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVerticesFromMesh_FunctionAddress, "VertexList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVerticesFromMesh_NumDeleted_PropertyAddress, DeleteVerticesFromMesh_FunctionAddress, "NumDeleted");
		DeleteVerticesFromMesh_NumDeleted_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVerticesFromMesh_FunctionAddress, "NumDeleted");
		DeleteVerticesFromMesh_NumDeleted_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVerticesFromMesh_FunctionAddress, "NumDeleted", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVerticesFromMesh_bDeferChangeNotifications_PropertyAddress, DeleteVerticesFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteVerticesFromMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVerticesFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteVerticesFromMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVerticesFromMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVerticesFromMesh_ReturnValue_PropertyAddress, DeleteVerticesFromMesh_FunctionAddress, "ReturnValue");
		DeleteVerticesFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVerticesFromMesh_FunctionAddress, "ReturnValue");
		DeleteVerticesFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVerticesFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DeleteVerticesFromMesh_IsValid = DeleteVerticesFromMesh_FunctionAddress != IntPtr.Zero && DeleteVerticesFromMesh_TargetMesh_IsValid && DeleteVerticesFromMesh_VertexList_IsValid && DeleteVerticesFromMesh_NumDeleted_IsValid && DeleteVerticesFromMesh_bDeferChangeNotifications_IsValid && DeleteVerticesFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteVerticesFromMesh", DeleteVerticesFromMesh_IsValid);
		DeleteVertexFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteVertexFromMesh");
		DeleteVertexFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteVertexFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertexFromMesh_TargetMesh_PropertyAddress, DeleteVertexFromMesh_FunctionAddress, "TargetMesh");
		DeleteVertexFromMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertexFromMesh_FunctionAddress, "TargetMesh");
		DeleteVertexFromMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertexFromMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertexFromMesh_VertexID_PropertyAddress, DeleteVertexFromMesh_FunctionAddress, "VertexID");
		DeleteVertexFromMesh_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertexFromMesh_FunctionAddress, "VertexID");
		DeleteVertexFromMesh_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertexFromMesh_FunctionAddress, "VertexID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertexFromMesh_bWasVertexDeleted_PropertyAddress, DeleteVertexFromMesh_FunctionAddress, "bWasVertexDeleted");
		DeleteVertexFromMesh_bWasVertexDeleted_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertexFromMesh_FunctionAddress, "bWasVertexDeleted");
		DeleteVertexFromMesh_bWasVertexDeleted_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertexFromMesh_FunctionAddress, "bWasVertexDeleted", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertexFromMesh_bDeferChangeNotifications_PropertyAddress, DeleteVertexFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteVertexFromMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertexFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteVertexFromMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertexFromMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertexFromMesh_ReturnValue_PropertyAddress, DeleteVertexFromMesh_FunctionAddress, "ReturnValue");
		DeleteVertexFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertexFromMesh_FunctionAddress, "ReturnValue");
		DeleteVertexFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertexFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DeleteVertexFromMesh_IsValid = DeleteVertexFromMesh_FunctionAddress != IntPtr.Zero && DeleteVertexFromMesh_TargetMesh_IsValid && DeleteVertexFromMesh_VertexID_IsValid && DeleteVertexFromMesh_bWasVertexDeleted_IsValid && DeleteVertexFromMesh_bDeferChangeNotifications_IsValid && DeleteVertexFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteVertexFromMesh", DeleteVertexFromMesh_IsValid);
		DeleteTrianglesFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteTrianglesFromMesh");
		DeleteTrianglesFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteTrianglesFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesFromMesh_TargetMesh_PropertyAddress, DeleteTrianglesFromMesh_FunctionAddress, "TargetMesh");
		DeleteTrianglesFromMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesFromMesh_FunctionAddress, "TargetMesh");
		DeleteTrianglesFromMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesFromMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesFromMesh_TriangleList_PropertyAddress, DeleteTrianglesFromMesh_FunctionAddress, "TriangleList");
		DeleteTrianglesFromMesh_TriangleList_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesFromMesh_FunctionAddress, "TriangleList");
		DeleteTrianglesFromMesh_TriangleList_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesFromMesh_FunctionAddress, "TriangleList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesFromMesh_NumDeleted_PropertyAddress, DeleteTrianglesFromMesh_FunctionAddress, "NumDeleted");
		DeleteTrianglesFromMesh_NumDeleted_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesFromMesh_FunctionAddress, "NumDeleted");
		DeleteTrianglesFromMesh_NumDeleted_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesFromMesh_FunctionAddress, "NumDeleted", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesFromMesh_bDeferChangeNotifications_PropertyAddress, DeleteTrianglesFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteTrianglesFromMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteTrianglesFromMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesFromMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesFromMesh_ReturnValue_PropertyAddress, DeleteTrianglesFromMesh_FunctionAddress, "ReturnValue");
		DeleteTrianglesFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesFromMesh_FunctionAddress, "ReturnValue");
		DeleteTrianglesFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DeleteTrianglesFromMesh_IsValid = DeleteTrianglesFromMesh_FunctionAddress != IntPtr.Zero && DeleteTrianglesFromMesh_TargetMesh_IsValid && DeleteTrianglesFromMesh_TriangleList_IsValid && DeleteTrianglesFromMesh_NumDeleted_IsValid && DeleteTrianglesFromMesh_bDeferChangeNotifications_IsValid && DeleteTrianglesFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteTrianglesFromMesh", DeleteTrianglesFromMesh_IsValid);
		DeleteTriangleFromMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteTriangleFromMesh");
		DeleteTriangleFromMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteTriangleFromMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangleFromMesh_TargetMesh_PropertyAddress, DeleteTriangleFromMesh_FunctionAddress, "TargetMesh");
		DeleteTriangleFromMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangleFromMesh_FunctionAddress, "TargetMesh");
		DeleteTriangleFromMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangleFromMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangleFromMesh_TriangleID_PropertyAddress, DeleteTriangleFromMesh_FunctionAddress, "TriangleID");
		DeleteTriangleFromMesh_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangleFromMesh_FunctionAddress, "TriangleID");
		DeleteTriangleFromMesh_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangleFromMesh_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangleFromMesh_bWasTriangleDeleted_PropertyAddress, DeleteTriangleFromMesh_FunctionAddress, "bWasTriangleDeleted");
		DeleteTriangleFromMesh_bWasTriangleDeleted_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangleFromMesh_FunctionAddress, "bWasTriangleDeleted");
		DeleteTriangleFromMesh_bWasTriangleDeleted_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangleFromMesh_FunctionAddress, "bWasTriangleDeleted", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangleFromMesh_bDeferChangeNotifications_PropertyAddress, DeleteTriangleFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteTriangleFromMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangleFromMesh_FunctionAddress, "bDeferChangeNotifications");
		DeleteTriangleFromMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangleFromMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangleFromMesh_ReturnValue_PropertyAddress, DeleteTriangleFromMesh_FunctionAddress, "ReturnValue");
		DeleteTriangleFromMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangleFromMesh_FunctionAddress, "ReturnValue");
		DeleteTriangleFromMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangleFromMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DeleteTriangleFromMesh_IsValid = DeleteTriangleFromMesh_FunctionAddress != IntPtr.Zero && DeleteTriangleFromMesh_TargetMesh_IsValid && DeleteTriangleFromMesh_TriangleID_IsValid && DeleteTriangleFromMesh_bWasTriangleDeleted_IsValid && DeleteTriangleFromMesh_bDeferChangeNotifications_IsValid && DeleteTriangleFromMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:DeleteTriangleFromMesh", DeleteTriangleFromMesh_IsValid);
		AppendMeshRepeated_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendMeshRepeated");
		AppendMeshRepeated_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendMeshRepeated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_TargetMesh_PropertyAddress, AppendMeshRepeated_FunctionAddress, "TargetMesh");
		AppendMeshRepeated_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "TargetMesh");
		AppendMeshRepeated_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_AppendMesh_PropertyAddress, AppendMeshRepeated_FunctionAddress, "AppendMesh");
		AppendMeshRepeated_AppendMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "AppendMesh");
		AppendMeshRepeated_AppendMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "AppendMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_AppendTransform_PropertyAddress, AppendMeshRepeated_FunctionAddress, "AppendTransform");
		AppendMeshRepeated_AppendTransform_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "AppendTransform");
		AppendMeshRepeated_AppendTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "AppendTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_RepeatCount_PropertyAddress, AppendMeshRepeated_FunctionAddress, "RepeatCount");
		AppendMeshRepeated_RepeatCount_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "RepeatCount");
		AppendMeshRepeated_RepeatCount_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "RepeatCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_bApplyTransformToFirstInstance_PropertyAddress, AppendMeshRepeated_FunctionAddress, "bApplyTransformToFirstInstance");
		AppendMeshRepeated_bApplyTransformToFirstInstance_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "bApplyTransformToFirstInstance");
		AppendMeshRepeated_bApplyTransformToFirstInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "bApplyTransformToFirstInstance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_bDeferChangeNotifications_PropertyAddress, AppendMeshRepeated_FunctionAddress, "bDeferChangeNotifications");
		AppendMeshRepeated_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "bDeferChangeNotifications");
		AppendMeshRepeated_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_Debug_PropertyAddress, AppendMeshRepeated_FunctionAddress, "Debug");
		AppendMeshRepeated_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "Debug");
		AppendMeshRepeated_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMeshRepeated_ReturnValue_PropertyAddress, AppendMeshRepeated_FunctionAddress, "ReturnValue");
		AppendMeshRepeated_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendMeshRepeated_FunctionAddress, "ReturnValue");
		AppendMeshRepeated_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMeshRepeated_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendMeshRepeated_IsValid = AppendMeshRepeated_FunctionAddress != IntPtr.Zero && AppendMeshRepeated_TargetMesh_IsValid && AppendMeshRepeated_AppendMesh_IsValid && AppendMeshRepeated_AppendTransform_IsValid && AppendMeshRepeated_RepeatCount_IsValid && AppendMeshRepeated_bApplyTransformToFirstInstance_IsValid && AppendMeshRepeated_bDeferChangeNotifications_IsValid && AppendMeshRepeated_Debug_IsValid && AppendMeshRepeated_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendMeshRepeated", AppendMeshRepeated_IsValid);
		AppendMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendMesh");
		AppendMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendMesh_TargetMesh_PropertyAddress, AppendMesh_FunctionAddress, "TargetMesh");
		AppendMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendMesh_FunctionAddress, "TargetMesh");
		AppendMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMesh_AppendMesh_PropertyAddress, AppendMesh_FunctionAddress, "AppendMesh");
		AppendMesh_AppendMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendMesh_FunctionAddress, "AppendMesh");
		AppendMesh_AppendMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMesh_FunctionAddress, "AppendMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMesh_AppendTransform_PropertyAddress, AppendMesh_FunctionAddress, "AppendTransform");
		AppendMesh_AppendTransform_Offset = NativeReflectionCached.GetPropertyOffset(AppendMesh_FunctionAddress, "AppendTransform");
		AppendMesh_AppendTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMesh_FunctionAddress, "AppendTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMesh_bDeferChangeNotifications_PropertyAddress, AppendMesh_FunctionAddress, "bDeferChangeNotifications");
		AppendMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(AppendMesh_FunctionAddress, "bDeferChangeNotifications");
		AppendMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMesh_Debug_PropertyAddress, AppendMesh_FunctionAddress, "Debug");
		AppendMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendMesh_FunctionAddress, "Debug");
		AppendMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendMesh_ReturnValue_PropertyAddress, AppendMesh_FunctionAddress, "ReturnValue");
		AppendMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendMesh_FunctionAddress, "ReturnValue");
		AppendMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendMesh_IsValid = AppendMesh_FunctionAddress != IntPtr.Zero && AppendMesh_TargetMesh_IsValid && AppendMesh_AppendMesh_IsValid && AppendMesh_AppendTransform_IsValid && AppendMesh_bDeferChangeNotifications_IsValid && AppendMesh_Debug_IsValid && AppendMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendMesh", AppendMesh_IsValid);
		AppendBuffersToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendBuffersToMesh");
		AppendBuffersToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendBuffersToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendBuffersToMesh_TargetMesh_PropertyAddress, AppendBuffersToMesh_FunctionAddress, "TargetMesh");
		AppendBuffersToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendBuffersToMesh_FunctionAddress, "TargetMesh");
		AppendBuffersToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBuffersToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBuffersToMesh_Buffers_PropertyAddress, AppendBuffersToMesh_FunctionAddress, "Buffers");
		AppendBuffersToMesh_Buffers_Offset = NativeReflectionCached.GetPropertyOffset(AppendBuffersToMesh_FunctionAddress, "Buffers");
		AppendBuffersToMesh_Buffers_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBuffersToMesh_FunctionAddress, "Buffers", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBuffersToMesh_NewTriangleIndicesList_PropertyAddress, AppendBuffersToMesh_FunctionAddress, "NewTriangleIndicesList");
		AppendBuffersToMesh_NewTriangleIndicesList_Offset = NativeReflectionCached.GetPropertyOffset(AppendBuffersToMesh_FunctionAddress, "NewTriangleIndicesList");
		AppendBuffersToMesh_NewTriangleIndicesList_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBuffersToMesh_FunctionAddress, "NewTriangleIndicesList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBuffersToMesh_MaterialID_PropertyAddress, AppendBuffersToMesh_FunctionAddress, "MaterialID");
		AppendBuffersToMesh_MaterialID_Offset = NativeReflectionCached.GetPropertyOffset(AppendBuffersToMesh_FunctionAddress, "MaterialID");
		AppendBuffersToMesh_MaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBuffersToMesh_FunctionAddress, "MaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBuffersToMesh_bDeferChangeNotifications_PropertyAddress, AppendBuffersToMesh_FunctionAddress, "bDeferChangeNotifications");
		AppendBuffersToMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(AppendBuffersToMesh_FunctionAddress, "bDeferChangeNotifications");
		AppendBuffersToMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBuffersToMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBuffersToMesh_Debug_PropertyAddress, AppendBuffersToMesh_FunctionAddress, "Debug");
		AppendBuffersToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendBuffersToMesh_FunctionAddress, "Debug");
		AppendBuffersToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBuffersToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBuffersToMesh_ReturnValue_PropertyAddress, AppendBuffersToMesh_FunctionAddress, "ReturnValue");
		AppendBuffersToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendBuffersToMesh_FunctionAddress, "ReturnValue");
		AppendBuffersToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBuffersToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendBuffersToMesh_IsValid = AppendBuffersToMesh_FunctionAddress != IntPtr.Zero && AppendBuffersToMesh_TargetMesh_IsValid && AppendBuffersToMesh_Buffers_IsValid && AppendBuffersToMesh_NewTriangleIndicesList_IsValid && AppendBuffersToMesh_MaterialID_IsValid && AppendBuffersToMesh_bDeferChangeNotifications_IsValid && AppendBuffersToMesh_Debug_IsValid && AppendBuffersToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AppendBuffersToMesh", AppendBuffersToMesh_IsValid);
		AddVerticesToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddVerticesToMesh");
		AddVerticesToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVerticesToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVerticesToMesh_TargetMesh_PropertyAddress, AddVerticesToMesh_FunctionAddress, "TargetMesh");
		AddVerticesToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddVerticesToMesh_FunctionAddress, "TargetMesh");
		AddVerticesToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVerticesToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVerticesToMesh_NewPositionsList_PropertyAddress, AddVerticesToMesh_FunctionAddress, "NewPositionsList");
		AddVerticesToMesh_NewPositionsList_Offset = NativeReflectionCached.GetPropertyOffset(AddVerticesToMesh_FunctionAddress, "NewPositionsList");
		AddVerticesToMesh_NewPositionsList_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVerticesToMesh_FunctionAddress, "NewPositionsList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVerticesToMesh_NewIndicesList_PropertyAddress, AddVerticesToMesh_FunctionAddress, "NewIndicesList");
		AddVerticesToMesh_NewIndicesList_Offset = NativeReflectionCached.GetPropertyOffset(AddVerticesToMesh_FunctionAddress, "NewIndicesList");
		AddVerticesToMesh_NewIndicesList_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVerticesToMesh_FunctionAddress, "NewIndicesList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVerticesToMesh_bDeferChangeNotifications_PropertyAddress, AddVerticesToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddVerticesToMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(AddVerticesToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddVerticesToMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVerticesToMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVerticesToMesh_ReturnValue_PropertyAddress, AddVerticesToMesh_FunctionAddress, "ReturnValue");
		AddVerticesToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVerticesToMesh_FunctionAddress, "ReturnValue");
		AddVerticesToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVerticesToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddVerticesToMesh_IsValid = AddVerticesToMesh_FunctionAddress != IntPtr.Zero && AddVerticesToMesh_TargetMesh_IsValid && AddVerticesToMesh_NewPositionsList_IsValid && AddVerticesToMesh_NewIndicesList_IsValid && AddVerticesToMesh_bDeferChangeNotifications_IsValid && AddVerticesToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddVerticesToMesh", AddVerticesToMesh_IsValid);
		AddVertexToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddVertexToMesh");
		AddVertexToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVertexToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVertexToMesh_TargetMesh_PropertyAddress, AddVertexToMesh_FunctionAddress, "TargetMesh");
		AddVertexToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddVertexToMesh_FunctionAddress, "TargetMesh");
		AddVertexToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVertexToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVertexToMesh_NewPosition_PropertyAddress, AddVertexToMesh_FunctionAddress, "NewPosition");
		AddVertexToMesh_NewPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddVertexToMesh_FunctionAddress, "NewPosition");
		AddVertexToMesh_NewPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVertexToMesh_FunctionAddress, "NewPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVertexToMesh_NewVertexIndex_PropertyAddress, AddVertexToMesh_FunctionAddress, "NewVertexIndex");
		AddVertexToMesh_NewVertexIndex_Offset = NativeReflectionCached.GetPropertyOffset(AddVertexToMesh_FunctionAddress, "NewVertexIndex");
		AddVertexToMesh_NewVertexIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVertexToMesh_FunctionAddress, "NewVertexIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVertexToMesh_bDeferChangeNotifications_PropertyAddress, AddVertexToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddVertexToMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(AddVertexToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddVertexToMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVertexToMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVertexToMesh_ReturnValue_PropertyAddress, AddVertexToMesh_FunctionAddress, "ReturnValue");
		AddVertexToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVertexToMesh_FunctionAddress, "ReturnValue");
		AddVertexToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVertexToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddVertexToMesh_IsValid = AddVertexToMesh_FunctionAddress != IntPtr.Zero && AddVertexToMesh_TargetMesh_IsValid && AddVertexToMesh_NewPosition_IsValid && AddVertexToMesh_NewVertexIndex_IsValid && AddVertexToMesh_bDeferChangeNotifications_IsValid && AddVertexToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddVertexToMesh", AddVertexToMesh_IsValid);
		AddTriangleToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTriangleToMesh");
		AddTriangleToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTriangleToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTriangleToMesh_TargetMesh_PropertyAddress, AddTriangleToMesh_FunctionAddress, "TargetMesh");
		AddTriangleToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddTriangleToMesh_FunctionAddress, "TargetMesh");
		AddTriangleToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTriangleToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTriangleToMesh_NewTriangle_PropertyAddress, AddTriangleToMesh_FunctionAddress, "NewTriangle");
		AddTriangleToMesh_NewTriangle_Offset = NativeReflectionCached.GetPropertyOffset(AddTriangleToMesh_FunctionAddress, "NewTriangle");
		AddTriangleToMesh_NewTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTriangleToMesh_FunctionAddress, "NewTriangle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTriangleToMesh_NewTriangleIndex_PropertyAddress, AddTriangleToMesh_FunctionAddress, "NewTriangleIndex");
		AddTriangleToMesh_NewTriangleIndex_Offset = NativeReflectionCached.GetPropertyOffset(AddTriangleToMesh_FunctionAddress, "NewTriangleIndex");
		AddTriangleToMesh_NewTriangleIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTriangleToMesh_FunctionAddress, "NewTriangleIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTriangleToMesh_NewTriangleGroupID_PropertyAddress, AddTriangleToMesh_FunctionAddress, "NewTriangleGroupID");
		AddTriangleToMesh_NewTriangleGroupID_Offset = NativeReflectionCached.GetPropertyOffset(AddTriangleToMesh_FunctionAddress, "NewTriangleGroupID");
		AddTriangleToMesh_NewTriangleGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTriangleToMesh_FunctionAddress, "NewTriangleGroupID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTriangleToMesh_bDeferChangeNotifications_PropertyAddress, AddTriangleToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddTriangleToMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(AddTriangleToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddTriangleToMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTriangleToMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTriangleToMesh_Debug_PropertyAddress, AddTriangleToMesh_FunctionAddress, "Debug");
		AddTriangleToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AddTriangleToMesh_FunctionAddress, "Debug");
		AddTriangleToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTriangleToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTriangleToMesh_ReturnValue_PropertyAddress, AddTriangleToMesh_FunctionAddress, "ReturnValue");
		AddTriangleToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddTriangleToMesh_FunctionAddress, "ReturnValue");
		AddTriangleToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTriangleToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddTriangleToMesh_IsValid = AddTriangleToMesh_FunctionAddress != IntPtr.Zero && AddTriangleToMesh_TargetMesh_IsValid && AddTriangleToMesh_NewTriangle_IsValid && AddTriangleToMesh_NewTriangleIndex_IsValid && AddTriangleToMesh_NewTriangleGroupID_IsValid && AddTriangleToMesh_bDeferChangeNotifications_IsValid && AddTriangleToMesh_Debug_IsValid && AddTriangleToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddTriangleToMesh", AddTriangleToMesh_IsValid);
		AddTrianglesToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTrianglesToMesh");
		AddTrianglesToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTrianglesToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTrianglesToMesh_TargetMesh_PropertyAddress, AddTrianglesToMesh_FunctionAddress, "TargetMesh");
		AddTrianglesToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddTrianglesToMesh_FunctionAddress, "TargetMesh");
		AddTrianglesToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrianglesToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrianglesToMesh_NewTrianglesList_PropertyAddress, AddTrianglesToMesh_FunctionAddress, "NewTrianglesList");
		AddTrianglesToMesh_NewTrianglesList_Offset = NativeReflectionCached.GetPropertyOffset(AddTrianglesToMesh_FunctionAddress, "NewTrianglesList");
		AddTrianglesToMesh_NewTrianglesList_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrianglesToMesh_FunctionAddress, "NewTrianglesList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrianglesToMesh_NewIndicesList_PropertyAddress, AddTrianglesToMesh_FunctionAddress, "NewIndicesList");
		AddTrianglesToMesh_NewIndicesList_Offset = NativeReflectionCached.GetPropertyOffset(AddTrianglesToMesh_FunctionAddress, "NewIndicesList");
		AddTrianglesToMesh_NewIndicesList_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrianglesToMesh_FunctionAddress, "NewIndicesList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrianglesToMesh_NewTriangleGroupID_PropertyAddress, AddTrianglesToMesh_FunctionAddress, "NewTriangleGroupID");
		AddTrianglesToMesh_NewTriangleGroupID_Offset = NativeReflectionCached.GetPropertyOffset(AddTrianglesToMesh_FunctionAddress, "NewTriangleGroupID");
		AddTrianglesToMesh_NewTriangleGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrianglesToMesh_FunctionAddress, "NewTriangleGroupID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrianglesToMesh_bDeferChangeNotifications_PropertyAddress, AddTrianglesToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddTrianglesToMesh_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(AddTrianglesToMesh_FunctionAddress, "bDeferChangeNotifications");
		AddTrianglesToMesh_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrianglesToMesh_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrianglesToMesh_Debug_PropertyAddress, AddTrianglesToMesh_FunctionAddress, "Debug");
		AddTrianglesToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AddTrianglesToMesh_FunctionAddress, "Debug");
		AddTrianglesToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrianglesToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrianglesToMesh_ReturnValue_PropertyAddress, AddTrianglesToMesh_FunctionAddress, "ReturnValue");
		AddTrianglesToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddTrianglesToMesh_FunctionAddress, "ReturnValue");
		AddTrianglesToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrianglesToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddTrianglesToMesh_IsValid = AddTrianglesToMesh_FunctionAddress != IntPtr.Zero && AddTrianglesToMesh_TargetMesh_IsValid && AddTrianglesToMesh_NewTrianglesList_IsValid && AddTrianglesToMesh_NewIndicesList_IsValid && AddTrianglesToMesh_NewTriangleGroupID_IsValid && AddTrianglesToMesh_bDeferChangeNotifications_IsValid && AddTrianglesToMesh_Debug_IsValid && AddTrianglesToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBasicEditFunctions:AddTrianglesToMesh", AddTrianglesToMesh_IsValid);
	}
}
