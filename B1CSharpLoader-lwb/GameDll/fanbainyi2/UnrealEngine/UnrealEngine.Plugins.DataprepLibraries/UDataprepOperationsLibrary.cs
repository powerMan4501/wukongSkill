using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Runtime;
using UnrealEngine.StaticMeshEditor;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepOperationsLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SubstituteMesh_IsValid;

	private static IntPtr SubstituteMesh_FunctionAddress;

	private static int SubstituteMesh_ParamsSize;

	private static bool SubstituteMesh_SelectedObjects_IsValid;

	private static FFieldAddress SubstituteMesh_SelectedObjects_PropertyAddress;

	private static int SubstituteMesh_SelectedObjects_Offset;

	private static bool SubstituteMesh_MeshSearch_IsValid;

	private static FFieldAddress SubstituteMesh_MeshSearch_PropertyAddress;

	private static int SubstituteMesh_MeshSearch_Offset;

	private static bool SubstituteMesh_StringMatch_IsValid;

	private static FFieldAddress SubstituteMesh_StringMatch_PropertyAddress;

	private static int SubstituteMesh_StringMatch_Offset;

	private static bool SubstituteMesh_MeshSubstitute_IsValid;

	private static FFieldAddress SubstituteMesh_MeshSubstitute_PropertyAddress;

	private static int SubstituteMesh_MeshSubstitute_Offset;

	private static bool SubstituteMaterialsByTable_IsValid;

	private static IntPtr SubstituteMaterialsByTable_FunctionAddress;

	private static int SubstituteMaterialsByTable_ParamsSize;

	private static bool SubstituteMaterialsByTable_SelectedObjects_IsValid;

	private static FFieldAddress SubstituteMaterialsByTable_SelectedObjects_PropertyAddress;

	private static int SubstituteMaterialsByTable_SelectedObjects_Offset;

	private static bool SubstituteMaterialsByTable_DataTable_IsValid;

	private static FFieldAddress SubstituteMaterialsByTable_DataTable_PropertyAddress;

	private static int SubstituteMaterialsByTable_DataTable_Offset;

	private static bool SubstituteMaterial_IsValid;

	private static IntPtr SubstituteMaterial_FunctionAddress;

	private static int SubstituteMaterial_ParamsSize;

	private static bool SubstituteMaterial_SelectedObjects_IsValid;

	private static FFieldAddress SubstituteMaterial_SelectedObjects_PropertyAddress;

	private static int SubstituteMaterial_SelectedObjects_Offset;

	private static bool SubstituteMaterial_MaterialSearch_IsValid;

	private static FFieldAddress SubstituteMaterial_MaterialSearch_PropertyAddress;

	private static int SubstituteMaterial_MaterialSearch_Offset;

	private static bool SubstituteMaterial_StringMatch_IsValid;

	private static FFieldAddress SubstituteMaterial_StringMatch_PropertyAddress;

	private static int SubstituteMaterial_StringMatch_Offset;

	private static bool SubstituteMaterial_MaterialSubstitute_IsValid;

	private static FFieldAddress SubstituteMaterial_MaterialSubstitute_PropertyAddress;

	private static int SubstituteMaterial_MaterialSubstitute_Offset;

	private static bool SetSubOuputLevel_IsValid;

	private static IntPtr SetSubOuputLevel_FunctionAddress;

	private static int SetSubOuputLevel_ParamsSize;

	private static bool SetSubOuputLevel_SelectedObjects_IsValid;

	private static FFieldAddress SetSubOuputLevel_SelectedObjects_PropertyAddress;

	private static int SetSubOuputLevel_SelectedObjects_Offset;

	private static bool SetSubOuputLevel_SubLevelName_IsValid;

	private static FFieldAddress SetSubOuputLevel_SubLevelName_PropertyAddress;

	private static int SetSubOuputLevel_SubLevelName_Offset;

	private static bool SetSubOuputFolder_IsValid;

	private static IntPtr SetSubOuputFolder_FunctionAddress;

	private static int SetSubOuputFolder_ParamsSize;

	private static bool SetSubOuputFolder_SelectedObjects_IsValid;

	private static FFieldAddress SetSubOuputFolder_SelectedObjects_PropertyAddress;

	private static int SetSubOuputFolder_SelectedObjects_Offset;

	private static bool SetSubOuputFolder_SubFolderName_IsValid;

	private static FFieldAddress SetSubOuputFolder_SubFolderName_PropertyAddress;

	private static int SetSubOuputFolder_SubFolderName_Offset;

	private static bool SetSimpleCollision_IsValid;

	private static IntPtr SetSimpleCollision_FunctionAddress;

	private static int SetSimpleCollision_ParamsSize;

	private static bool SetSimpleCollision_SelectedObjects_IsValid;

	private static FFieldAddress SetSimpleCollision_SelectedObjects_PropertyAddress;

	private static int SetSimpleCollision_SelectedObjects_Offset;

	private static bool SetSimpleCollision_ShapeType_IsValid;

	private static FFieldAddress SetSimpleCollision_ShapeType_PropertyAddress;

	private static int SetSimpleCollision_ShapeType_Offset;

	private static bool SetSimpleCollision_ModifiedObjects_IsValid;

	private static FFieldAddress SetSimpleCollision_ModifiedObjects_PropertyAddress;

	private static int SetSimpleCollision_ModifiedObjects_Offset;

	private static bool SetNaniteSettings_IsValid;

	private static IntPtr SetNaniteSettings_FunctionAddress;

	private static int SetNaniteSettings_ParamsSize;

	private static bool SetNaniteSettings_InSelectedObjects_IsValid;

	private static FFieldAddress SetNaniteSettings_InSelectedObjects_PropertyAddress;

	private static int SetNaniteSettings_InSelectedObjects_Offset;

	private static bool SetNaniteSettings_bInEnabled_IsValid;

	private static FFieldAddress SetNaniteSettings_bInEnabled_PropertyAddress;

	private static int SetNaniteSettings_bInEnabled_Offset;

	private static bool SetNaniteSettings_InPositionPrecision_IsValid;

	private static FFieldAddress SetNaniteSettings_InPositionPrecision_PropertyAddress;

	private static int SetNaniteSettings_InPositionPrecision_Offset;

	private static bool SetNaniteSettings_InPercentTriangles_IsValid;

	private static FFieldAddress SetNaniteSettings_InPercentTriangles_PropertyAddress;

	private static int SetNaniteSettings_InPercentTriangles_Offset;

	private static bool SetNaniteSettings_OutModifiedObjects_IsValid;

	private static FFieldAddress SetNaniteSettings_OutModifiedObjects_PropertyAddress;

	private static int SetNaniteSettings_OutModifiedObjects_Offset;

	private static bool SetMobility_IsValid;

	private static IntPtr SetMobility_FunctionAddress;

	private static int SetMobility_ParamsSize;

	private static bool SetMobility_SelectedObjects_IsValid;

	private static FFieldAddress SetMobility_SelectedObjects_PropertyAddress;

	private static int SetMobility_SelectedObjects_Offset;

	private static bool SetMobility_MobilityType_IsValid;

	private static FFieldAddress SetMobility_MobilityType_PropertyAddress;

	private static int SetMobility_MobilityType_Offset;

	private static bool SetMesh_IsValid;

	private static IntPtr SetMesh_FunctionAddress;

	private static int SetMesh_ParamsSize;

	private static bool SetMesh_SelectedObjects_IsValid;

	private static FFieldAddress SetMesh_SelectedObjects_PropertyAddress;

	private static int SetMesh_SelectedObjects_Offset;

	private static bool SetMesh_MeshSubstitute_IsValid;

	private static FFieldAddress SetMesh_MeshSubstitute_PropertyAddress;

	private static int SetMesh_MeshSubstitute_Offset;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_SelectedObjects_IsValid;

	private static FFieldAddress SetMaterial_SelectedObjects_PropertyAddress;

	private static int SetMaterial_SelectedObjects_Offset;

	private static bool SetMaterial_MaterialSubstitute_IsValid;

	private static FFieldAddress SetMaterial_MaterialSubstitute_PropertyAddress;

	private static int SetMaterial_MaterialSubstitute_Offset;

	private static bool SetLods_IsValid;

	private static IntPtr SetLods_FunctionAddress;

	private static int SetLods_ParamsSize;

	private static bool SetLods_SelectedObjects_IsValid;

	private static FFieldAddress SetLods_SelectedObjects_PropertyAddress;

	private static int SetLods_SelectedObjects_Offset;

	private static bool SetLods_ReductionOptions_IsValid;

	private static FFieldAddress SetLods_ReductionOptions_PropertyAddress;

	private static int SetLods_ReductionOptions_Offset;

	private static bool SetLods_ModifiedObjects_IsValid;

	private static FFieldAddress SetLods_ModifiedObjects_PropertyAddress;

	private static int SetLods_ModifiedObjects_Offset;

	private static bool SetLODGroup_IsValid;

	private static IntPtr SetLODGroup_FunctionAddress;

	private static int SetLODGroup_ParamsSize;

	private static bool SetLODGroup_SelectedObjects_IsValid;

	private static FFieldAddress SetLODGroup_SelectedObjects_PropertyAddress;

	private static int SetLODGroup_SelectedObjects_Offset;

	private static bool SetLODGroup_LODGroupName_IsValid;

	private static FFieldAddress SetLODGroup_LODGroupName_PropertyAddress;

	private static int SetLODGroup_LODGroupName_Offset;

	private static bool SetLODGroup_ModifiedObjects_IsValid;

	private static FFieldAddress SetLODGroup_ModifiedObjects_PropertyAddress;

	private static int SetLODGroup_ModifiedObjects_Offset;

	private static bool SetConvexDecompositionCollision_IsValid;

	private static IntPtr SetConvexDecompositionCollision_FunctionAddress;

	private static int SetConvexDecompositionCollision_ParamsSize;

	private static bool SetConvexDecompositionCollision_SelectedObjects_IsValid;

	private static FFieldAddress SetConvexDecompositionCollision_SelectedObjects_PropertyAddress;

	private static int SetConvexDecompositionCollision_SelectedObjects_Offset;

	private static bool SetConvexDecompositionCollision_HullCount_IsValid;

	private static FFieldAddress SetConvexDecompositionCollision_HullCount_PropertyAddress;

	private static int SetConvexDecompositionCollision_HullCount_Offset;

	private static bool SetConvexDecompositionCollision_MaxHullVerts_IsValid;

	private static FFieldAddress SetConvexDecompositionCollision_MaxHullVerts_PropertyAddress;

	private static int SetConvexDecompositionCollision_MaxHullVerts_Offset;

	private static bool SetConvexDecompositionCollision_HullPrecision_IsValid;

	private static FFieldAddress SetConvexDecompositionCollision_HullPrecision_PropertyAddress;

	private static int SetConvexDecompositionCollision_HullPrecision_Offset;

	private static bool SetConvexDecompositionCollision_ModifiedObjects_IsValid;

	private static FFieldAddress SetConvexDecompositionCollision_ModifiedObjects_PropertyAddress;

	private static int SetConvexDecompositionCollision_ModifiedObjects_Offset;

	private static bool SetCollisionComplexity_IsValid;

	private static IntPtr SetCollisionComplexity_FunctionAddress;

	private static int SetCollisionComplexity_ParamsSize;

	private static bool SetCollisionComplexity_InSelectedObjects_IsValid;

	private static FFieldAddress SetCollisionComplexity_InSelectedObjects_PropertyAddress;

	private static int SetCollisionComplexity_InSelectedObjects_Offset;

	private static bool SetCollisionComplexity_InCollisionTraceFlag_IsValid;

	private static FFieldAddress SetCollisionComplexity_InCollisionTraceFlag_PropertyAddress;

	private static int SetCollisionComplexity_InCollisionTraceFlag_Offset;

	private static bool SetCollisionComplexity_InModifiedObjects_IsValid;

	private static FFieldAddress SetCollisionComplexity_InModifiedObjects_PropertyAddress;

	private static int SetCollisionComplexity_InModifiedObjects_Offset;

	private static bool ResizeTextures_IsValid;

	private static IntPtr ResizeTextures_FunctionAddress;

	private static int ResizeTextures_ParamsSize;

	private static bool ResizeTextures_InTextures_IsValid;

	private static FFieldAddress ResizeTextures_InTextures_PropertyAddress;

	private static int ResizeTextures_InTextures_Offset;

	private static bool ResizeTextures_InMaxSize_IsValid;

	private static FFieldAddress ResizeTextures_InMaxSize_PropertyAddress;

	private static int ResizeTextures_InMaxSize_Offset;

	private static bool RandomizeTransform_IsValid;

	private static IntPtr RandomizeTransform_FunctionAddress;

	private static int RandomizeTransform_ParamsSize;

	private static bool RandomizeTransform_SelectedObjects_IsValid;

	private static FFieldAddress RandomizeTransform_SelectedObjects_PropertyAddress;

	private static int RandomizeTransform_SelectedObjects_Offset;

	private static bool RandomizeTransform_TransformType_IsValid;

	private static FFieldAddress RandomizeTransform_TransformType_PropertyAddress;

	private static int RandomizeTransform_TransformType_Offset;

	private static bool RandomizeTransform_ReferenceFrame_IsValid;

	private static FFieldAddress RandomizeTransform_ReferenceFrame_PropertyAddress;

	private static int RandomizeTransform_ReferenceFrame_Offset;

	private static bool RandomizeTransform_Min_IsValid;

	private static FFieldAddress RandomizeTransform_Min_PropertyAddress;

	private static int RandomizeTransform_Min_Offset;

	private static bool RandomizeTransform_Max_IsValid;

	private static FFieldAddress RandomizeTransform_Max_PropertyAddress;

	private static int RandomizeTransform_Max_Offset;

	private static bool FlipFaces_IsValid;

	private static IntPtr FlipFaces_FunctionAddress;

	private static int FlipFaces_ParamsSize;

	private static bool FlipFaces_StaticMeshes_IsValid;

	private static FFieldAddress FlipFaces_StaticMeshes_PropertyAddress;

	private static int FlipFaces_StaticMeshes_Offset;

	private static bool ConsolidateObjects_IsValid;

	private static IntPtr ConsolidateObjects_FunctionAddress;

	private static int ConsolidateObjects_ParamsSize;

	private static bool ConsolidateObjects_SelectedObjects_IsValid;

	private static FFieldAddress ConsolidateObjects_SelectedObjects_PropertyAddress;

	private static int ConsolidateObjects_SelectedObjects_Offset;

	private static bool AddToLayer_IsValid;

	private static IntPtr AddToLayer_FunctionAddress;

	private static int AddToLayer_ParamsSize;

	private static bool AddToLayer_SelectedObjects_IsValid;

	private static FFieldAddress AddToLayer_SelectedObjects_PropertyAddress;

	private static int AddToLayer_SelectedObjects_Offset;

	private static bool AddToLayer_LayerName_IsValid;

	private static FFieldAddress AddToLayer_LayerName_PropertyAddress;

	private static int AddToLayer_LayerName_Offset;

	private static bool AddTags_IsValid;

	private static IntPtr AddTags_FunctionAddress;

	private static int AddTags_ParamsSize;

	private static bool AddTags_SelectedObjects_IsValid;

	private static FFieldAddress AddTags_SelectedObjects_PropertyAddress;

	private static int AddTags_SelectedObjects_Offset;

	private static bool AddTags_InTags_IsValid;

	private static FFieldAddress AddTags_InTags_PropertyAddress;

	private static int AddTags_InTags_Offset;

	private static bool AddMetadata_IsValid;

	private static IntPtr AddMetadata_FunctionAddress;

	private static int AddMetadata_ParamsSize;

	private static bool AddMetadata_SelectedObjects_IsValid;

	private static FFieldAddress AddMetadata_SelectedObjects_PropertyAddress;

	private static int AddMetadata_SelectedObjects_Offset;

	private static bool AddMetadata_InMetadata_IsValid;

	private static FFieldAddress AddMetadata_InMetadata_PropertyAddress;

	private static int AddMetadata_InMetadata_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMesh")]
	public unsafe static void SubstituteMesh(List<UObject> SelectedObjects, string MeshSearch, EEditorScriptingStringMatchType StringMatch, UStaticMesh MeshSubstitute)
	{
		if (!SubstituteMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SubstituteMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SubstituteMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SubstituteMesh_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SubstituteMesh_SelectedObjects_Offset), SelectedObjects);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SubstituteMesh_MeshSearch_Offset), 0, SubstituteMesh_MeshSearch_PropertyAddress.Address, MeshSearch);
		EnumMarshaler<EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(intPtr, SubstituteMesh_StringMatch_Offset), 0, SubstituteMesh_StringMatch_PropertyAddress.Address, StringMatch);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SubstituteMesh_MeshSubstitute_Offset), 0, SubstituteMesh_MeshSubstitute_PropertyAddress.Address, MeshSubstitute);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SubstituteMesh_FunctionAddress, intPtr, SubstituteMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SubstituteMesh_SelectedObjects_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SubstituteMesh_MeshSearch_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMaterialsByTable")]
	public unsafe static void SubstituteMaterialsByTable(List<UObject> SelectedObjects, UDataTable DataTable)
	{
		if (!SubstituteMaterialsByTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMaterialsByTable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SubstituteMaterialsByTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SubstituteMaterialsByTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SubstituteMaterialsByTable_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SubstituteMaterialsByTable_SelectedObjects_Offset), SelectedObjects);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, SubstituteMaterialsByTable_DataTable_Offset), 0, SubstituteMaterialsByTable_DataTable_PropertyAddress.Address, DataTable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SubstituteMaterialsByTable_FunctionAddress, intPtr, SubstituteMaterialsByTable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SubstituteMaterialsByTable_SelectedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMaterial")]
	public unsafe static void SubstituteMaterial(List<UObject> SelectedObjects, string MaterialSearch, EEditorScriptingStringMatchType StringMatch, UMaterialInterface MaterialSubstitute)
	{
		if (!SubstituteMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SubstituteMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SubstituteMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SubstituteMaterial_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SubstituteMaterial_SelectedObjects_Offset), SelectedObjects);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SubstituteMaterial_MaterialSearch_Offset), 0, SubstituteMaterial_MaterialSearch_PropertyAddress.Address, MaterialSearch);
		EnumMarshaler<EEditorScriptingStringMatchType>.ToNative(IntPtr.Add(intPtr, SubstituteMaterial_StringMatch_Offset), 0, SubstituteMaterial_StringMatch_PropertyAddress.Address, StringMatch);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SubstituteMaterial_MaterialSubstitute_Offset), 0, SubstituteMaterial_MaterialSubstitute_PropertyAddress.Address, MaterialSubstitute);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SubstituteMaterial_FunctionAddress, intPtr, SubstituteMaterial_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SubstituteMaterial_SelectedObjects_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SubstituteMaterial_MaterialSearch_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSubOuputLevel")]
	public unsafe static void SetSubOuputLevel(List<UObject> SelectedObjects, string SubLevelName)
	{
		if (!SetSubOuputLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSubOuputLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubOuputLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubOuputLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetSubOuputLevel_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSubOuputLevel_SelectedObjects_Offset), SelectedObjects);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSubOuputLevel_SubLevelName_Offset), 0, SetSubOuputLevel_SubLevelName_PropertyAddress.Address, SubLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSubOuputLevel_FunctionAddress, intPtr, SetSubOuputLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSubOuputLevel_SelectedObjects_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetSubOuputLevel_SubLevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSubOuputFolder")]
	public unsafe static void SetSubOuputFolder(List<UObject> SelectedObjects, string SubFolderName)
	{
		if (!SetSubOuputFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSubOuputFolder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubOuputFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubOuputFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetSubOuputFolder_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSubOuputFolder_SelectedObjects_Offset), SelectedObjects);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSubOuputFolder_SubFolderName_Offset), 0, SetSubOuputFolder_SubFolderName_PropertyAddress.Address, SubFolderName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSubOuputFolder_FunctionAddress, intPtr, SetSubOuputFolder_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSubOuputFolder_SelectedObjects_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetSubOuputFolder_SubFolderName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSimpleCollision")]
	public unsafe static void SetSimpleCollision(List<UObject> SelectedObjects, EScriptCollisionShapeType ShapeType, out List<UObject> ModifiedObjects)
	{
		if (!SetSimpleCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSimpleCollision");
			ModifiedObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSimpleCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSimpleCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetSimpleCollision_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSimpleCollision_SelectedObjects_Offset), SelectedObjects);
		EnumMarshaler<EScriptCollisionShapeType>.ToNative(IntPtr.Add(intPtr, SetSimpleCollision_ShapeType_Offset), 0, SetSimpleCollision_ShapeType_PropertyAddress.Address, ShapeType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSimpleCollision_FunctionAddress, intPtr, SetSimpleCollision_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSimpleCollision_SelectedObjects_PropertyAddress.Address, intPtr);
		ModifiedObjects = new TArrayCopyMarshaler<UObject>(1, SetSimpleCollision_ModifiedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, SetSimpleCollision_ModifiedObjects_Offset));
		NativeReflection.DestroyValue_InContainer(SetSimpleCollision_ModifiedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetNaniteSettings")]
	public unsafe static void SetNaniteSettings(List<UObject> InSelectedObjects, bool bInEnabled, int InPositionPrecision, float InPercentTriangles, out List<UObject> OutModifiedObjects)
	{
		if (!SetNaniteSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetNaniteSettings");
			OutModifiedObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNaniteSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNaniteSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetNaniteSettings_InSelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNaniteSettings_InSelectedObjects_Offset), InSelectedObjects);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNaniteSettings_bInEnabled_Offset), 0, SetNaniteSettings_bInEnabled_PropertyAddress.Address, bInEnabled);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNaniteSettings_InPositionPrecision_Offset), 0, SetNaniteSettings_InPositionPrecision_PropertyAddress.Address, InPositionPrecision);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNaniteSettings_InPercentTriangles_Offset), 0, SetNaniteSettings_InPercentTriangles_PropertyAddress.Address, InPercentTriangles);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNaniteSettings_FunctionAddress, intPtr, SetNaniteSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNaniteSettings_InSelectedObjects_PropertyAddress.Address, intPtr);
		OutModifiedObjects = new TArrayCopyMarshaler<UObject>(1, SetNaniteSettings_OutModifiedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, SetNaniteSettings_OutModifiedObjects_Offset));
		NativeReflection.DestroyValue_InContainer(SetNaniteSettings_OutModifiedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMobility")]
	public unsafe static void SetMobility(List<UObject> SelectedObjects, EComponentMobility MobilityType)
	{
		if (!SetMobility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMobility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMobility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMobility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetMobility_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMobility_SelectedObjects_Offset), SelectedObjects);
		EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(intPtr, SetMobility_MobilityType_Offset), 0, SetMobility_MobilityType_PropertyAddress.Address, MobilityType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMobility_FunctionAddress, intPtr, SetMobility_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMobility_SelectedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMesh")]
	public unsafe static void SetMesh(List<UObject> SelectedObjects, UStaticMesh MeshSubstitute)
	{
		if (!SetMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetMesh_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMesh_SelectedObjects_Offset), SelectedObjects);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetMesh_MeshSubstitute_Offset), 0, SetMesh_MeshSubstitute_PropertyAddress.Address, MeshSubstitute);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMesh_FunctionAddress, intPtr, SetMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMesh_SelectedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMaterial")]
	public unsafe static void SetMaterial(List<UObject> SelectedObjects, UMaterialInterface MaterialSubstitute)
	{
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetMaterial_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMaterial_SelectedObjects_Offset), SelectedObjects);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterial_MaterialSubstitute_Offset), 0, SetMaterial_MaterialSubstitute_PropertyAddress.Address, MaterialSubstitute);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMaterial_SelectedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetLods")]
	public unsafe static void SetLods(List<UObject> SelectedObjects, FStaticMeshReductionOptions ReductionOptions, out List<UObject> ModifiedObjects)
	{
		if (!SetLods_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetLods");
			ModifiedObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLods_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLods_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetLods_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetLods_SelectedObjects_Offset), SelectedObjects);
		NativeReflection.InitializeValue_InContainer(SetLods_ReductionOptions_PropertyAddress.Address, intPtr);
		FStaticMeshReductionOptions.ToNative(IntPtr.Add(intPtr, SetLods_ReductionOptions_Offset), 0, SetLods_ReductionOptions_PropertyAddress.Address, ReductionOptions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLods_FunctionAddress, intPtr, SetLods_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLods_SelectedObjects_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetLods_ReductionOptions_PropertyAddress.Address, intPtr);
		ModifiedObjects = new TArrayCopyMarshaler<UObject>(1, SetLods_ModifiedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, SetLods_ModifiedObjects_Offset));
		NativeReflection.DestroyValue_InContainer(SetLods_ModifiedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetLODGroup")]
	public unsafe static void SetLODGroup(List<UObject> SelectedObjects, out FName LODGroupName, out List<UObject> ModifiedObjects)
	{
		if (!SetLODGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetLODGroup");
			LODGroupName = default(FName);
			ModifiedObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLODGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLODGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetLODGroup_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetLODGroup_SelectedObjects_Offset), SelectedObjects);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLODGroup_FunctionAddress, intPtr, SetLODGroup_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLODGroup_SelectedObjects_PropertyAddress.Address, intPtr);
		LODGroupName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, SetLODGroup_LODGroupName_Offset), 0, SetLODGroup_LODGroupName_PropertyAddress.Address);
		ModifiedObjects = new TArrayCopyMarshaler<UObject>(1, SetLODGroup_ModifiedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, SetLODGroup_ModifiedObjects_Offset));
		NativeReflection.DestroyValue_InContainer(SetLODGroup_ModifiedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetConvexDecompositionCollision")]
	public unsafe static void SetConvexDecompositionCollision(List<UObject> SelectedObjects, int HullCount, int MaxHullVerts, int HullPrecision, out List<UObject> ModifiedObjects)
	{
		if (!SetConvexDecompositionCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetConvexDecompositionCollision");
			ModifiedObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConvexDecompositionCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConvexDecompositionCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetConvexDecompositionCollision_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollision_SelectedObjects_Offset), SelectedObjects);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollision_HullCount_Offset), 0, SetConvexDecompositionCollision_HullCount_PropertyAddress.Address, HullCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollision_MaxHullVerts_Offset), 0, SetConvexDecompositionCollision_MaxHullVerts_PropertyAddress.Address, MaxHullVerts);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexDecompositionCollision_HullPrecision_Offset), 0, SetConvexDecompositionCollision_HullPrecision_PropertyAddress.Address, HullPrecision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetConvexDecompositionCollision_FunctionAddress, intPtr, SetConvexDecompositionCollision_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetConvexDecompositionCollision_SelectedObjects_PropertyAddress.Address, intPtr);
		ModifiedObjects = new TArrayCopyMarshaler<UObject>(1, SetConvexDecompositionCollision_ModifiedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, SetConvexDecompositionCollision_ModifiedObjects_Offset));
		NativeReflection.DestroyValue_InContainer(SetConvexDecompositionCollision_ModifiedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:SetCollisionComplexity")]
	public unsafe static void SetCollisionComplexity(List<UObject> InSelectedObjects, ECollisionTraceFlag InCollisionTraceFlag, out List<UObject> InModifiedObjects)
	{
		if (!SetCollisionComplexity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:SetCollisionComplexity");
			InModifiedObjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionComplexity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionComplexity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SetCollisionComplexity_InSelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetCollisionComplexity_InSelectedObjects_Offset), InSelectedObjects);
		EnumMarshaler<ECollisionTraceFlag>.ToNative(IntPtr.Add(intPtr, SetCollisionComplexity_InCollisionTraceFlag_Offset), 0, SetCollisionComplexity_InCollisionTraceFlag_PropertyAddress.Address, InCollisionTraceFlag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCollisionComplexity_FunctionAddress, intPtr, SetCollisionComplexity_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCollisionComplexity_InSelectedObjects_PropertyAddress.Address, intPtr);
		InModifiedObjects = new TArrayCopyMarshaler<UObject>(1, SetCollisionComplexity_InModifiedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, SetCollisionComplexity_InModifiedObjects_Offset));
		NativeReflection.DestroyValue_InContainer(SetCollisionComplexity_InModifiedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:ResizeTextures")]
	public unsafe static void ResizeTextures(List<UTexture2D> InTextures, int InMaxSize)
	{
		if (!ResizeTextures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:ResizeTextures");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResizeTextures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResizeTextures_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UTexture2D>(1, ResizeTextures_InTextures_PropertyAddress, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.FromNative, CachedMarshalingDelegates<UTexture2D, UObjectMarshaler<UTexture2D>>.ToNative).ToNative(IntPtr.Add(intPtr, ResizeTextures_InTextures_Offset), InTextures);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ResizeTextures_InMaxSize_Offset), 0, ResizeTextures_InMaxSize_PropertyAddress.Address, InMaxSize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResizeTextures_FunctionAddress, intPtr, ResizeTextures_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResizeTextures_InTextures_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:RandomizeTransform")]
	public unsafe static void RandomizeTransform(List<UObject> SelectedObjects, ERandomizeTransformType TransformType, ERandomizeTransformReferenceFrame ReferenceFrame, FVector Min, FVector Max)
	{
		if (!RandomizeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:RandomizeTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RandomizeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RandomizeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, RandomizeTransform_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, RandomizeTransform_SelectedObjects_Offset), SelectedObjects);
		EnumMarshaler<ERandomizeTransformType>.ToNative(IntPtr.Add(intPtr, RandomizeTransform_TransformType_Offset), 0, RandomizeTransform_TransformType_PropertyAddress.Address, TransformType);
		EnumMarshaler<ERandomizeTransformReferenceFrame>.ToNative(IntPtr.Add(intPtr, RandomizeTransform_ReferenceFrame_Offset), 0, RandomizeTransform_ReferenceFrame_PropertyAddress.Address, ReferenceFrame);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RandomizeTransform_Min_Offset), 0, RandomizeTransform_Min_PropertyAddress.Address, Min);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RandomizeTransform_Max_Offset), 0, RandomizeTransform_Max_PropertyAddress.Address, Max);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RandomizeTransform_FunctionAddress, intPtr, RandomizeTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RandomizeTransform_SelectedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:FlipFaces")]
	public unsafe static void FlipFaces(HashSet<UStaticMesh> StaticMeshes)
	{
		if (!FlipFaces_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:FlipFaces");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlipFaces_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlipFaces_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FlipFaces_StaticMeshes_PropertyAddress.Address, intPtr);
		new TSetCopyMarshaler<UStaticMesh>(1, FlipFaces_StaticMeshes_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative).ToNative(IntPtr.Add(intPtr, FlipFaces_StaticMeshes_Offset), StaticMeshes);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FlipFaces_FunctionAddress, intPtr, FlipFaces_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FlipFaces_StaticMeshes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:ConsolidateObjects")]
	public unsafe static void ConsolidateObjects(List<UObject> SelectedObjects)
	{
		if (!ConsolidateObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:ConsolidateObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsolidateObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsolidateObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, ConsolidateObjects_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ConsolidateObjects_SelectedObjects_Offset), SelectedObjects);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConsolidateObjects_FunctionAddress, intPtr, ConsolidateObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConsolidateObjects_SelectedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:AddToLayer")]
	public unsafe static void AddToLayer(List<UObject> SelectedObjects, FName LayerName)
	{
		if (!AddToLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:AddToLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, AddToLayer_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, AddToLayer_SelectedObjects_Offset), SelectedObjects);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddToLayer_LayerName_Offset), 0, AddToLayer_LayerName_PropertyAddress.Address, LayerName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddToLayer_FunctionAddress, intPtr, AddToLayer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddToLayer_SelectedObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:AddTags")]
	public unsafe static void AddTags(List<UObject> SelectedObjects, List<FName> InTags)
	{
		if (!AddTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:AddTags");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, AddTags_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, AddTags_SelectedObjects_Offset), SelectedObjects);
		new TArrayCopyMarshaler<FName>(1, AddTags_InTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, AddTags_InTags_Offset), InTags);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTags_FunctionAddress, intPtr, AddTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTags_SelectedObjects_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddTags_InTags_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/DataprepLibraries.DataprepOperationsLibrary:AddMetadata")]
	public unsafe static void AddMetadata(List<UObject> SelectedObjects, Dictionary<FName, string> InMetadata)
	{
		if (!AddMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepLibraries.DataprepOperationsLibrary:AddMetadata");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMetadata_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMetadata_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, AddMetadata_SelectedObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, AddMetadata_SelectedObjects_Offset), SelectedObjects);
		NativeReflection.InitializeValue_InContainer(AddMetadata_InMetadata_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FName, string>(1, AddMetadata_InMetadata_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AddMetadata_InMetadata_Offset), InMetadata);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMetadata_FunctionAddress, intPtr, AddMetadata_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMetadata_SelectedObjects_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddMetadata_InMetadata_PropertyAddress.Address, intPtr);
	}

	static UDataprepOperationsLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepOperationsLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepOperationsLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepOperationsLibrary");
		SubstituteMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SubstituteMesh");
		SubstituteMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SubstituteMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMesh_SelectedObjects_PropertyAddress, SubstituteMesh_FunctionAddress, "SelectedObjects");
		SubstituteMesh_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMesh_FunctionAddress, "SelectedObjects");
		SubstituteMesh_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMesh_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMesh_MeshSearch_PropertyAddress, SubstituteMesh_FunctionAddress, "MeshSearch");
		SubstituteMesh_MeshSearch_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMesh_FunctionAddress, "MeshSearch");
		SubstituteMesh_MeshSearch_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMesh_FunctionAddress, "MeshSearch", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMesh_StringMatch_PropertyAddress, SubstituteMesh_FunctionAddress, "StringMatch");
		SubstituteMesh_StringMatch_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMesh_FunctionAddress, "StringMatch");
		SubstituteMesh_StringMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMesh_FunctionAddress, "StringMatch", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMesh_MeshSubstitute_PropertyAddress, SubstituteMesh_FunctionAddress, "MeshSubstitute");
		SubstituteMesh_MeshSubstitute_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMesh_FunctionAddress, "MeshSubstitute");
		SubstituteMesh_MeshSubstitute_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMesh_FunctionAddress, "MeshSubstitute", Classes.FObjectProperty);
		SubstituteMesh_IsValid = SubstituteMesh_FunctionAddress != IntPtr.Zero && SubstituteMesh_SelectedObjects_IsValid && SubstituteMesh_MeshSearch_IsValid && SubstituteMesh_StringMatch_IsValid && SubstituteMesh_MeshSubstitute_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMesh", SubstituteMesh_IsValid);
		SubstituteMaterialsByTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SubstituteMaterialsByTable");
		SubstituteMaterialsByTable_ParamsSize = NativeReflection.GetFunctionParamsSize(SubstituteMaterialsByTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMaterialsByTable_SelectedObjects_PropertyAddress, SubstituteMaterialsByTable_FunctionAddress, "SelectedObjects");
		SubstituteMaterialsByTable_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMaterialsByTable_FunctionAddress, "SelectedObjects");
		SubstituteMaterialsByTable_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMaterialsByTable_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMaterialsByTable_DataTable_PropertyAddress, SubstituteMaterialsByTable_FunctionAddress, "DataTable");
		SubstituteMaterialsByTable_DataTable_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMaterialsByTable_FunctionAddress, "DataTable");
		SubstituteMaterialsByTable_DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMaterialsByTable_FunctionAddress, "DataTable", Classes.FObjectProperty);
		SubstituteMaterialsByTable_IsValid = SubstituteMaterialsByTable_FunctionAddress != IntPtr.Zero && SubstituteMaterialsByTable_SelectedObjects_IsValid && SubstituteMaterialsByTable_DataTable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMaterialsByTable", SubstituteMaterialsByTable_IsValid);
		SubstituteMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SubstituteMaterial");
		SubstituteMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SubstituteMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMaterial_SelectedObjects_PropertyAddress, SubstituteMaterial_FunctionAddress, "SelectedObjects");
		SubstituteMaterial_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMaterial_FunctionAddress, "SelectedObjects");
		SubstituteMaterial_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMaterial_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMaterial_MaterialSearch_PropertyAddress, SubstituteMaterial_FunctionAddress, "MaterialSearch");
		SubstituteMaterial_MaterialSearch_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMaterial_FunctionAddress, "MaterialSearch");
		SubstituteMaterial_MaterialSearch_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMaterial_FunctionAddress, "MaterialSearch", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMaterial_StringMatch_PropertyAddress, SubstituteMaterial_FunctionAddress, "StringMatch");
		SubstituteMaterial_StringMatch_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMaterial_FunctionAddress, "StringMatch");
		SubstituteMaterial_StringMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMaterial_FunctionAddress, "StringMatch", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SubstituteMaterial_MaterialSubstitute_PropertyAddress, SubstituteMaterial_FunctionAddress, "MaterialSubstitute");
		SubstituteMaterial_MaterialSubstitute_Offset = NativeReflectionCached.GetPropertyOffset(SubstituteMaterial_FunctionAddress, "MaterialSubstitute");
		SubstituteMaterial_MaterialSubstitute_IsValid = NativeReflectionCached.ValidatePropertyClass(SubstituteMaterial_FunctionAddress, "MaterialSubstitute", Classes.FObjectProperty);
		SubstituteMaterial_IsValid = SubstituteMaterial_FunctionAddress != IntPtr.Zero && SubstituteMaterial_SelectedObjects_IsValid && SubstituteMaterial_MaterialSearch_IsValid && SubstituteMaterial_StringMatch_IsValid && SubstituteMaterial_MaterialSubstitute_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SubstituteMaterial", SubstituteMaterial_IsValid);
		SetSubOuputLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSubOuputLevel");
		SetSubOuputLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubOuputLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubOuputLevel_SelectedObjects_PropertyAddress, SetSubOuputLevel_FunctionAddress, "SelectedObjects");
		SetSubOuputLevel_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetSubOuputLevel_FunctionAddress, "SelectedObjects");
		SetSubOuputLevel_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubOuputLevel_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubOuputLevel_SubLevelName_PropertyAddress, SetSubOuputLevel_FunctionAddress, "SubLevelName");
		SetSubOuputLevel_SubLevelName_Offset = NativeReflectionCached.GetPropertyOffset(SetSubOuputLevel_FunctionAddress, "SubLevelName");
		SetSubOuputLevel_SubLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubOuputLevel_FunctionAddress, "SubLevelName", Classes.FStrProperty);
		SetSubOuputLevel_IsValid = SetSubOuputLevel_FunctionAddress != IntPtr.Zero && SetSubOuputLevel_SelectedObjects_IsValid && SetSubOuputLevel_SubLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSubOuputLevel", SetSubOuputLevel_IsValid);
		SetSubOuputFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSubOuputFolder");
		SetSubOuputFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubOuputFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubOuputFolder_SelectedObjects_PropertyAddress, SetSubOuputFolder_FunctionAddress, "SelectedObjects");
		SetSubOuputFolder_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetSubOuputFolder_FunctionAddress, "SelectedObjects");
		SetSubOuputFolder_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubOuputFolder_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubOuputFolder_SubFolderName_PropertyAddress, SetSubOuputFolder_FunctionAddress, "SubFolderName");
		SetSubOuputFolder_SubFolderName_Offset = NativeReflectionCached.GetPropertyOffset(SetSubOuputFolder_FunctionAddress, "SubFolderName");
		SetSubOuputFolder_SubFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubOuputFolder_FunctionAddress, "SubFolderName", Classes.FStrProperty);
		SetSubOuputFolder_IsValid = SetSubOuputFolder_FunctionAddress != IntPtr.Zero && SetSubOuputFolder_SelectedObjects_IsValid && SetSubOuputFolder_SubFolderName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSubOuputFolder", SetSubOuputFolder_IsValid);
		SetSimpleCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSimpleCollision");
		SetSimpleCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSimpleCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSimpleCollision_SelectedObjects_PropertyAddress, SetSimpleCollision_FunctionAddress, "SelectedObjects");
		SetSimpleCollision_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetSimpleCollision_FunctionAddress, "SelectedObjects");
		SetSimpleCollision_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSimpleCollision_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSimpleCollision_ShapeType_PropertyAddress, SetSimpleCollision_FunctionAddress, "ShapeType");
		SetSimpleCollision_ShapeType_Offset = NativeReflectionCached.GetPropertyOffset(SetSimpleCollision_FunctionAddress, "ShapeType");
		SetSimpleCollision_ShapeType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSimpleCollision_FunctionAddress, "ShapeType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSimpleCollision_ModifiedObjects_PropertyAddress, SetSimpleCollision_FunctionAddress, "ModifiedObjects");
		SetSimpleCollision_ModifiedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetSimpleCollision_FunctionAddress, "ModifiedObjects");
		SetSimpleCollision_ModifiedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSimpleCollision_FunctionAddress, "ModifiedObjects", Classes.FArrayProperty);
		SetSimpleCollision_IsValid = SetSimpleCollision_FunctionAddress != IntPtr.Zero && SetSimpleCollision_SelectedObjects_IsValid && SetSimpleCollision_ShapeType_IsValid && SetSimpleCollision_ModifiedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetSimpleCollision", SetSimpleCollision_IsValid);
		SetNaniteSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNaniteSettings");
		SetNaniteSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNaniteSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_InSelectedObjects_PropertyAddress, SetNaniteSettings_FunctionAddress, "InSelectedObjects");
		SetNaniteSettings_InSelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "InSelectedObjects");
		SetNaniteSettings_InSelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "InSelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_bInEnabled_PropertyAddress, SetNaniteSettings_FunctionAddress, "bInEnabled");
		SetNaniteSettings_bInEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "bInEnabled");
		SetNaniteSettings_bInEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "bInEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_InPositionPrecision_PropertyAddress, SetNaniteSettings_FunctionAddress, "InPositionPrecision");
		SetNaniteSettings_InPositionPrecision_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "InPositionPrecision");
		SetNaniteSettings_InPositionPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "InPositionPrecision", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_InPercentTriangles_PropertyAddress, SetNaniteSettings_FunctionAddress, "InPercentTriangles");
		SetNaniteSettings_InPercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "InPercentTriangles");
		SetNaniteSettings_InPercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "InPercentTriangles", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteSettings_OutModifiedObjects_PropertyAddress, SetNaniteSettings_FunctionAddress, "OutModifiedObjects");
		SetNaniteSettings_OutModifiedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteSettings_FunctionAddress, "OutModifiedObjects");
		SetNaniteSettings_OutModifiedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteSettings_FunctionAddress, "OutModifiedObjects", Classes.FArrayProperty);
		SetNaniteSettings_IsValid = SetNaniteSettings_FunctionAddress != IntPtr.Zero && SetNaniteSettings_InSelectedObjects_IsValid && SetNaniteSettings_bInEnabled_IsValid && SetNaniteSettings_InPositionPrecision_IsValid && SetNaniteSettings_InPercentTriangles_IsValid && SetNaniteSettings_OutModifiedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetNaniteSettings", SetNaniteSettings_IsValid);
		SetMobility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMobility");
		SetMobility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMobility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMobility_SelectedObjects_PropertyAddress, SetMobility_FunctionAddress, "SelectedObjects");
		SetMobility_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetMobility_FunctionAddress, "SelectedObjects");
		SetMobility_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMobility_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMobility_MobilityType_PropertyAddress, SetMobility_FunctionAddress, "MobilityType");
		SetMobility_MobilityType_Offset = NativeReflectionCached.GetPropertyOffset(SetMobility_FunctionAddress, "MobilityType");
		SetMobility_MobilityType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMobility_FunctionAddress, "MobilityType", Classes.FByteProperty);
		SetMobility_IsValid = SetMobility_FunctionAddress != IntPtr.Zero && SetMobility_SelectedObjects_IsValid && SetMobility_MobilityType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMobility", SetMobility_IsValid);
		SetMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMesh");
		SetMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMesh_SelectedObjects_PropertyAddress, SetMesh_FunctionAddress, "SelectedObjects");
		SetMesh_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetMesh_FunctionAddress, "SelectedObjects");
		SetMesh_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMesh_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMesh_MeshSubstitute_PropertyAddress, SetMesh_FunctionAddress, "MeshSubstitute");
		SetMesh_MeshSubstitute_Offset = NativeReflectionCached.GetPropertyOffset(SetMesh_FunctionAddress, "MeshSubstitute");
		SetMesh_MeshSubstitute_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMesh_FunctionAddress, "MeshSubstitute", Classes.FObjectProperty);
		SetMesh_IsValid = SetMesh_FunctionAddress != IntPtr.Zero && SetMesh_SelectedObjects_IsValid && SetMesh_MeshSubstitute_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMesh", SetMesh_IsValid);
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_SelectedObjects_PropertyAddress, SetMaterial_FunctionAddress, "SelectedObjects");
		SetMaterial_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "SelectedObjects");
		SetMaterial_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_MaterialSubstitute_PropertyAddress, SetMaterial_FunctionAddress, "MaterialSubstitute");
		SetMaterial_MaterialSubstitute_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "MaterialSubstitute");
		SetMaterial_MaterialSubstitute_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "MaterialSubstitute", Classes.FObjectProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_SelectedObjects_IsValid && SetMaterial_MaterialSubstitute_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetMaterial", SetMaterial_IsValid);
		SetLods_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLods");
		SetLods_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLods_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLods_SelectedObjects_PropertyAddress, SetLods_FunctionAddress, "SelectedObjects");
		SetLods_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetLods_FunctionAddress, "SelectedObjects");
		SetLods_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLods_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLods_ReductionOptions_PropertyAddress, SetLods_FunctionAddress, "ReductionOptions");
		SetLods_ReductionOptions_Offset = NativeReflectionCached.GetPropertyOffset(SetLods_FunctionAddress, "ReductionOptions");
		SetLods_ReductionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLods_FunctionAddress, "ReductionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLods_ModifiedObjects_PropertyAddress, SetLods_FunctionAddress, "ModifiedObjects");
		SetLods_ModifiedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetLods_FunctionAddress, "ModifiedObjects");
		SetLods_ModifiedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLods_FunctionAddress, "ModifiedObjects", Classes.FArrayProperty);
		SetLods_IsValid = SetLods_FunctionAddress != IntPtr.Zero && SetLods_SelectedObjects_IsValid && SetLods_ReductionOptions_IsValid && SetLods_ModifiedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetLods", SetLods_IsValid);
		SetLODGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLODGroup");
		SetLODGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLODGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLODGroup_SelectedObjects_PropertyAddress, SetLODGroup_FunctionAddress, "SelectedObjects");
		SetLODGroup_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetLODGroup_FunctionAddress, "SelectedObjects");
		SetLODGroup_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODGroup_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODGroup_LODGroupName_PropertyAddress, SetLODGroup_FunctionAddress, "LODGroupName");
		SetLODGroup_LODGroupName_Offset = NativeReflectionCached.GetPropertyOffset(SetLODGroup_FunctionAddress, "LODGroupName");
		SetLODGroup_LODGroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODGroup_FunctionAddress, "LODGroupName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLODGroup_ModifiedObjects_PropertyAddress, SetLODGroup_FunctionAddress, "ModifiedObjects");
		SetLODGroup_ModifiedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetLODGroup_FunctionAddress, "ModifiedObjects");
		SetLODGroup_ModifiedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLODGroup_FunctionAddress, "ModifiedObjects", Classes.FArrayProperty);
		SetLODGroup_IsValid = SetLODGroup_FunctionAddress != IntPtr.Zero && SetLODGroup_SelectedObjects_IsValid && SetLODGroup_LODGroupName_IsValid && SetLODGroup_ModifiedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetLODGroup", SetLODGroup_IsValid);
		SetConvexDecompositionCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetConvexDecompositionCollision");
		SetConvexDecompositionCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConvexDecompositionCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollision_SelectedObjects_PropertyAddress, SetConvexDecompositionCollision_FunctionAddress, "SelectedObjects");
		SetConvexDecompositionCollision_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollision_FunctionAddress, "SelectedObjects");
		SetConvexDecompositionCollision_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollision_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollision_HullCount_PropertyAddress, SetConvexDecompositionCollision_FunctionAddress, "HullCount");
		SetConvexDecompositionCollision_HullCount_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollision_FunctionAddress, "HullCount");
		SetConvexDecompositionCollision_HullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollision_FunctionAddress, "HullCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollision_MaxHullVerts_PropertyAddress, SetConvexDecompositionCollision_FunctionAddress, "MaxHullVerts");
		SetConvexDecompositionCollision_MaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollision_FunctionAddress, "MaxHullVerts");
		SetConvexDecompositionCollision_MaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollision_FunctionAddress, "MaxHullVerts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollision_HullPrecision_PropertyAddress, SetConvexDecompositionCollision_FunctionAddress, "HullPrecision");
		SetConvexDecompositionCollision_HullPrecision_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollision_FunctionAddress, "HullPrecision");
		SetConvexDecompositionCollision_HullPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollision_FunctionAddress, "HullPrecision", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexDecompositionCollision_ModifiedObjects_PropertyAddress, SetConvexDecompositionCollision_FunctionAddress, "ModifiedObjects");
		SetConvexDecompositionCollision_ModifiedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexDecompositionCollision_FunctionAddress, "ModifiedObjects");
		SetConvexDecompositionCollision_ModifiedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexDecompositionCollision_FunctionAddress, "ModifiedObjects", Classes.FArrayProperty);
		SetConvexDecompositionCollision_IsValid = SetConvexDecompositionCollision_FunctionAddress != IntPtr.Zero && SetConvexDecompositionCollision_SelectedObjects_IsValid && SetConvexDecompositionCollision_HullCount_IsValid && SetConvexDecompositionCollision_MaxHullVerts_IsValid && SetConvexDecompositionCollision_HullPrecision_IsValid && SetConvexDecompositionCollision_ModifiedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetConvexDecompositionCollision", SetConvexDecompositionCollision_IsValid);
		SetCollisionComplexity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCollisionComplexity");
		SetCollisionComplexity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionComplexity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionComplexity_InSelectedObjects_PropertyAddress, SetCollisionComplexity_FunctionAddress, "InSelectedObjects");
		SetCollisionComplexity_InSelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionComplexity_FunctionAddress, "InSelectedObjects");
		SetCollisionComplexity_InSelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionComplexity_FunctionAddress, "InSelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionComplexity_InCollisionTraceFlag_PropertyAddress, SetCollisionComplexity_FunctionAddress, "InCollisionTraceFlag");
		SetCollisionComplexity_InCollisionTraceFlag_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionComplexity_FunctionAddress, "InCollisionTraceFlag");
		SetCollisionComplexity_InCollisionTraceFlag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionComplexity_FunctionAddress, "InCollisionTraceFlag", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionComplexity_InModifiedObjects_PropertyAddress, SetCollisionComplexity_FunctionAddress, "InModifiedObjects");
		SetCollisionComplexity_InModifiedObjects_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionComplexity_FunctionAddress, "InModifiedObjects");
		SetCollisionComplexity_InModifiedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionComplexity_FunctionAddress, "InModifiedObjects", Classes.FArrayProperty);
		SetCollisionComplexity_IsValid = SetCollisionComplexity_FunctionAddress != IntPtr.Zero && SetCollisionComplexity_InSelectedObjects_IsValid && SetCollisionComplexity_InCollisionTraceFlag_IsValid && SetCollisionComplexity_InModifiedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:SetCollisionComplexity", SetCollisionComplexity_IsValid);
		ResizeTextures_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResizeTextures");
		ResizeTextures_ParamsSize = NativeReflection.GetFunctionParamsSize(ResizeTextures_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResizeTextures_InTextures_PropertyAddress, ResizeTextures_FunctionAddress, "InTextures");
		ResizeTextures_InTextures_Offset = NativeReflectionCached.GetPropertyOffset(ResizeTextures_FunctionAddress, "InTextures");
		ResizeTextures_InTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeTextures_FunctionAddress, "InTextures", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizeTextures_InMaxSize_PropertyAddress, ResizeTextures_FunctionAddress, "InMaxSize");
		ResizeTextures_InMaxSize_Offset = NativeReflectionCached.GetPropertyOffset(ResizeTextures_FunctionAddress, "InMaxSize");
		ResizeTextures_InMaxSize_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeTextures_FunctionAddress, "InMaxSize", Classes.FIntProperty);
		ResizeTextures_IsValid = ResizeTextures_FunctionAddress != IntPtr.Zero && ResizeTextures_InTextures_IsValid && ResizeTextures_InMaxSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:ResizeTextures", ResizeTextures_IsValid);
		RandomizeTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RandomizeTransform");
		RandomizeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(RandomizeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RandomizeTransform_SelectedObjects_PropertyAddress, RandomizeTransform_FunctionAddress, "SelectedObjects");
		RandomizeTransform_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(RandomizeTransform_FunctionAddress, "SelectedObjects");
		RandomizeTransform_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomizeTransform_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomizeTransform_TransformType_PropertyAddress, RandomizeTransform_FunctionAddress, "TransformType");
		RandomizeTransform_TransformType_Offset = NativeReflectionCached.GetPropertyOffset(RandomizeTransform_FunctionAddress, "TransformType");
		RandomizeTransform_TransformType_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomizeTransform_FunctionAddress, "TransformType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomizeTransform_ReferenceFrame_PropertyAddress, RandomizeTransform_FunctionAddress, "ReferenceFrame");
		RandomizeTransform_ReferenceFrame_Offset = NativeReflectionCached.GetPropertyOffset(RandomizeTransform_FunctionAddress, "ReferenceFrame");
		RandomizeTransform_ReferenceFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomizeTransform_FunctionAddress, "ReferenceFrame", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomizeTransform_Min_PropertyAddress, RandomizeTransform_FunctionAddress, "Min");
		RandomizeTransform_Min_Offset = NativeReflectionCached.GetPropertyOffset(RandomizeTransform_FunctionAddress, "Min");
		RandomizeTransform_Min_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomizeTransform_FunctionAddress, "Min", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomizeTransform_Max_PropertyAddress, RandomizeTransform_FunctionAddress, "Max");
		RandomizeTransform_Max_Offset = NativeReflectionCached.GetPropertyOffset(RandomizeTransform_FunctionAddress, "Max");
		RandomizeTransform_Max_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomizeTransform_FunctionAddress, "Max", Classes.FStructProperty);
		RandomizeTransform_IsValid = RandomizeTransform_FunctionAddress != IntPtr.Zero && RandomizeTransform_SelectedObjects_IsValid && RandomizeTransform_TransformType_IsValid && RandomizeTransform_ReferenceFrame_IsValid && RandomizeTransform_Min_IsValid && RandomizeTransform_Max_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:RandomizeTransform", RandomizeTransform_IsValid);
		FlipFaces_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FlipFaces");
		FlipFaces_ParamsSize = NativeReflection.GetFunctionParamsSize(FlipFaces_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FlipFaces_StaticMeshes_PropertyAddress, FlipFaces_FunctionAddress, "StaticMeshes");
		FlipFaces_StaticMeshes_Offset = NativeReflectionCached.GetPropertyOffset(FlipFaces_FunctionAddress, "StaticMeshes");
		FlipFaces_StaticMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(FlipFaces_FunctionAddress, "StaticMeshes", Classes.FSetProperty);
		FlipFaces_IsValid = FlipFaces_FunctionAddress != IntPtr.Zero && FlipFaces_StaticMeshes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:FlipFaces", FlipFaces_IsValid);
		ConsolidateObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConsolidateObjects");
		ConsolidateObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsolidateObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConsolidateObjects_SelectedObjects_PropertyAddress, ConsolidateObjects_FunctionAddress, "SelectedObjects");
		ConsolidateObjects_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(ConsolidateObjects_FunctionAddress, "SelectedObjects");
		ConsolidateObjects_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsolidateObjects_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		ConsolidateObjects_IsValid = ConsolidateObjects_FunctionAddress != IntPtr.Zero && ConsolidateObjects_SelectedObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:ConsolidateObjects", ConsolidateObjects_IsValid);
		AddToLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddToLayer");
		AddToLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToLayer_SelectedObjects_PropertyAddress, AddToLayer_FunctionAddress, "SelectedObjects");
		AddToLayer_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(AddToLayer_FunctionAddress, "SelectedObjects");
		AddToLayer_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToLayer_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToLayer_LayerName_PropertyAddress, AddToLayer_FunctionAddress, "LayerName");
		AddToLayer_LayerName_Offset = NativeReflectionCached.GetPropertyOffset(AddToLayer_FunctionAddress, "LayerName");
		AddToLayer_LayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToLayer_FunctionAddress, "LayerName", Classes.FNameProperty);
		AddToLayer_IsValid = AddToLayer_FunctionAddress != IntPtr.Zero && AddToLayer_SelectedObjects_IsValid && AddToLayer_LayerName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:AddToLayer", AddToLayer_IsValid);
		AddTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTags");
		AddTags_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTags_SelectedObjects_PropertyAddress, AddTags_FunctionAddress, "SelectedObjects");
		AddTags_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(AddTags_FunctionAddress, "SelectedObjects");
		AddTags_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTags_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTags_InTags_PropertyAddress, AddTags_FunctionAddress, "InTags");
		AddTags_InTags_Offset = NativeReflectionCached.GetPropertyOffset(AddTags_FunctionAddress, "InTags");
		AddTags_InTags_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTags_FunctionAddress, "InTags", Classes.FArrayProperty);
		AddTags_IsValid = AddTags_FunctionAddress != IntPtr.Zero && AddTags_SelectedObjects_IsValid && AddTags_InTags_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:AddTags", AddTags_IsValid);
		AddMetadata_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMetadata");
		AddMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMetadata_SelectedObjects_PropertyAddress, AddMetadata_FunctionAddress, "SelectedObjects");
		AddMetadata_SelectedObjects_Offset = NativeReflectionCached.GetPropertyOffset(AddMetadata_FunctionAddress, "SelectedObjects");
		AddMetadata_SelectedObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMetadata_FunctionAddress, "SelectedObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMetadata_InMetadata_PropertyAddress, AddMetadata_FunctionAddress, "InMetadata");
		AddMetadata_InMetadata_Offset = NativeReflectionCached.GetPropertyOffset(AddMetadata_FunctionAddress, "InMetadata");
		AddMetadata_InMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMetadata_FunctionAddress, "InMetadata", Classes.FMapProperty);
		AddMetadata_IsValid = AddMetadata_FunctionAddress != IntPtr.Zero && AddMetadata_SelectedObjects_IsValid && AddMetadata_InMetadata_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepLibraries.DataprepOperationsLibrary:AddMetadata", AddMetadata_IsValid);
	}
}
