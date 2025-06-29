using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryCollectionEngine;
using UnrealEngine.Plugins.ApexDestruction;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorStaticMeshLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StaticMeshPostLoad_IsValid;

	private static IntPtr StaticMeshPostLoad_FunctionAddress;

	private static int StaticMeshPostLoad_ParamsSize;

	private static bool StaticMeshPostLoad_StaticMesh_IsValid;

	private static FFieldAddress StaticMeshPostLoad_StaticMesh_PropertyAddress;

	private static int StaticMeshPostLoad_StaticMesh_Offset;

	private static bool StartPhysicsSim_IsValid;

	private static IntPtr StartPhysicsSim_FunctionAddress;

	private static int StartPhysicsSim_ParamsSize;

	private static bool SetStaticMeshVertexColorSingleChannl_IsValid;

	private static IntPtr SetStaticMeshVertexColorSingleChannl_FunctionAddress;

	private static int SetStaticMeshVertexColorSingleChannl_ParamsSize;

	private static bool SetStaticMeshVertexColorSingleChannl_StaticMesh_IsValid;

	private static FFieldAddress SetStaticMeshVertexColorSingleChannl_StaticMesh_PropertyAddress;

	private static int SetStaticMeshVertexColorSingleChannl_StaticMesh_Offset;

	private static bool SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_IsValid;

	private static FFieldAddress SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_PropertyAddress;

	private static int SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_Offset;

	private static bool SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_IsValid;

	private static FFieldAddress SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_PropertyAddress;

	private static int SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_Offset;

	private static bool SetStaticMeshVertexColorSingleChannl_ChannlIndex_IsValid;

	private static FFieldAddress SetStaticMeshVertexColorSingleChannl_ChannlIndex_PropertyAddress;

	private static int SetStaticMeshVertexColorSingleChannl_ChannlIndex_Offset;

	private static bool SetStaticMeshVertexColor_IsValid;

	private static IntPtr SetStaticMeshVertexColor_FunctionAddress;

	private static int SetStaticMeshVertexColor_ParamsSize;

	private static bool SetStaticMeshVertexColor_StaticMesh_IsValid;

	private static FFieldAddress SetStaticMeshVertexColor_StaticMesh_PropertyAddress;

	private static int SetStaticMeshVertexColor_StaticMesh_Offset;

	private static bool SetStaticMeshVertexColor_VertexColorData_IsValid;

	private static FFieldAddress SetStaticMeshVertexColor_VertexColorData_PropertyAddress;

	private static int SetStaticMeshVertexColor_VertexColorData_Offset;

	private static bool SetStaticMeshUseOpacityMicroMap_IsValid;

	private static IntPtr SetStaticMeshUseOpacityMicroMap_FunctionAddress;

	private static int SetStaticMeshUseOpacityMicroMap_ParamsSize;

	private static bool SetStaticMeshUseOpacityMicroMap_InSM_IsValid;

	private static FFieldAddress SetStaticMeshUseOpacityMicroMap_InSM_PropertyAddress;

	private static int SetStaticMeshUseOpacityMicroMap_InSM_Offset;

	private static bool SetStaticMeshUseOpacityMicroMap_NewUse_IsValid;

	private static FFieldAddress SetStaticMeshUseOpacityMicroMap_NewUse_PropertyAddress;

	private static int SetStaticMeshUseOpacityMicroMap_NewUse_Offset;

	private static bool SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_IsValid;

	private static FFieldAddress SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_PropertyAddress;

	private static int SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_Offset;

	private static bool SetStaticMeshUseOpacityMicroMap_ReturnValue_IsValid;

	private static FFieldAddress SetStaticMeshUseOpacityMicroMap_ReturnValue_PropertyAddress;

	private static int SetStaticMeshUseOpacityMicroMap_ReturnValue_Offset;

	private static bool SetStaticMeshLODScreenSize_IsValid;

	private static IntPtr SetStaticMeshLODScreenSize_FunctionAddress;

	private static int SetStaticMeshLODScreenSize_ParamsSize;

	private static bool SetStaticMeshLODScreenSize_InSM_IsValid;

	private static FFieldAddress SetStaticMeshLODScreenSize_InSM_PropertyAddress;

	private static int SetStaticMeshLODScreenSize_InSM_Offset;

	private static bool SetStaticMeshLODScreenSize_LodIndex_IsValid;

	private static FFieldAddress SetStaticMeshLODScreenSize_LodIndex_PropertyAddress;

	private static int SetStaticMeshLODScreenSize_LodIndex_Offset;

	private static bool SetStaticMeshLODScreenSize_NewScreenSize_IsValid;

	private static FFieldAddress SetStaticMeshLODScreenSize_NewScreenSize_PropertyAddress;

	private static int SetStaticMeshLODScreenSize_NewScreenSize_Offset;

	private static bool SetStaticMeshLODScreenSize_ReturnValue_IsValid;

	private static FFieldAddress SetStaticMeshLODScreenSize_ReturnValue_PropertyAddress;

	private static int SetStaticMeshLODScreenSize_ReturnValue_Offset;

	private static bool SetStaticMeshesDFResScale_IsValid;

	private static IntPtr SetStaticMeshesDFResScale_FunctionAddress;

	private static int SetStaticMeshesDFResScale_ParamsSize;

	private static bool SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_IsValid;

	private static FFieldAddress SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_PropertyAddress;

	private static int SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_Offset;

	private static bool SetStaticMeshesDFResScale_InTargetDFResolution_IsValid;

	private static FFieldAddress SetStaticMeshesDFResScale_InTargetDFResolution_PropertyAddress;

	private static int SetStaticMeshesDFResScale_InTargetDFResolution_Offset;

	private static bool SetSourceFileName_IsValid;

	private static IntPtr SetSourceFileName_FunctionAddress;

	private static int SetSourceFileName_ParamsSize;

	private static bool SetSourceFileName_SM_IsValid;

	private static FFieldAddress SetSourceFileName_SM_PropertyAddress;

	private static int SetSourceFileName_SM_Offset;

	private static bool SetSourceFileName_TargetFileName_IsValid;

	private static FFieldAddress SetSourceFileName_TargetFileName_PropertyAddress;

	private static int SetSourceFileName_TargetFileName_Offset;

	private static bool SetNumStreamedLODs_IsValid;

	private static IntPtr SetNumStreamedLODs_FunctionAddress;

	private static int SetNumStreamedLODs_ParamsSize;

	private static bool SetNumStreamedLODs_StaticMesh_IsValid;

	private static FFieldAddress SetNumStreamedLODs_StaticMesh_PropertyAddress;

	private static int SetNumStreamedLODs_StaticMesh_Offset;

	private static bool SetNumStreamedLODs_InNumStreamedLODs_IsValid;

	private static FFieldAddress SetNumStreamedLODs_InNumStreamedLODs_PropertyAddress;

	private static int SetNumStreamedLODs_InNumStreamedLODs_Offset;

	private static bool SetNumStreamedLODs_ReturnValue_IsValid;

	private static FFieldAddress SetNumStreamedLODs_ReturnValue_PropertyAddress;

	private static int SetNumStreamedLODs_ReturnValue_Offset;

	private static bool SetNaniteEnable_IsValid;

	private static IntPtr SetNaniteEnable_FunctionAddress;

	private static int SetNaniteEnable_ParamsSize;

	private static bool SetNaniteEnable_StaticMesh_IsValid;

	private static FFieldAddress SetNaniteEnable_StaticMesh_PropertyAddress;

	private static int SetNaniteEnable_StaticMesh_Offset;

	private static bool SetNaniteEnable_NewState_IsValid;

	private static FFieldAddress SetNaniteEnable_NewState_PropertyAddress;

	private static int SetNaniteEnable_NewState_Offset;

	private static bool SetMinLOD_IsValid;

	private static IntPtr SetMinLOD_FunctionAddress;

	private static int SetMinLOD_ParamsSize;

	private static bool SetMinLOD_StaticMesh_IsValid;

	private static FFieldAddress SetMinLOD_StaticMesh_PropertyAddress;

	private static int SetMinLOD_StaticMesh_Offset;

	private static bool SetMinLOD_MinLOD_IsValid;

	private static FFieldAddress SetMinLOD_MinLOD_PropertyAddress;

	private static int SetMinLOD_MinLOD_Offset;

	private static bool SetDestructibleMesh_IsValid;

	private static IntPtr SetDestructibleMesh_FunctionAddress;

	private static int SetDestructibleMesh_ParamsSize;

	private static bool SetDestructibleMesh_BPO_IsValid;

	private static FFieldAddress SetDestructibleMesh_BPO_PropertyAddress;

	private static int SetDestructibleMesh_BPO_Offset;

	private static bool ResetGeometryCollection_IsValid;

	private static IntPtr ResetGeometryCollection_FunctionAddress;

	private static int ResetGeometryCollection_ParamsSize;

	private static bool ResetGeometryCollection_GeometryCollectionComponent_IsValid;

	private static FFieldAddress ResetGeometryCollection_GeometryCollectionComponent_PropertyAddress;

	private static int ResetGeometryCollection_GeometryCollectionComponent_Offset;

	private static bool ReplaceSourceFileName_IsValid;

	private static IntPtr ReplaceSourceFileName_FunctionAddress;

	private static int ReplaceSourceFileName_ParamsSize;

	private static bool ReplaceSourceFileName_SM_IsValid;

	private static FFieldAddress ReplaceSourceFileName_SM_PropertyAddress;

	private static int ReplaceSourceFileName_SM_Offset;

	private static bool ReplaceSourceFileName_Src_IsValid;

	private static FFieldAddress ReplaceSourceFileName_Src_PropertyAddress;

	private static int ReplaceSourceFileName_Src_Offset;

	private static bool ReplaceSourceFileName_Target_IsValid;

	private static FFieldAddress ReplaceSourceFileName_Target_PropertyAddress;

	private static int ReplaceSourceFileName_Target_Offset;

	private static bool ReplaceLodSections_IsValid;

	private static IntPtr ReplaceLodSections_FunctionAddress;

	private static int ReplaceLodSections_ParamsSize;

	private static bool ReplaceLodSections_StaticMesh_IsValid;

	private static FFieldAddress ReplaceLodSections_StaticMesh_PropertyAddress;

	private static int ReplaceLodSections_StaticMesh_Offset;

	private static bool ReplaceLodSections_LODIndex_IsValid;

	private static FFieldAddress ReplaceLodSections_LODIndex_PropertyAddress;

	private static int ReplaceLodSections_LODIndex_Offset;

	private static bool ReplaceLodSections_SectionIDMap_IsValid;

	private static FFieldAddress ReplaceLodSections_SectionIDMap_PropertyAddress;

	private static int ReplaceLodSections_SectionIDMap_Offset;

	private static bool ReplaceLodSections_ReturnValue_IsValid;

	private static FFieldAddress ReplaceLodSections_ReturnValue_PropertyAddress;

	private static int ReplaceLodSections_ReturnValue_Offset;

	private static bool QuickHullByDefaultHACD_IsValid;

	private static IntPtr QuickHullByDefaultHACD_FunctionAddress;

	private static int QuickHullByDefaultHACD_ParamsSize;

	private static bool QuickHullByDefaultHACD_InStaticMesh_IsValid;

	private static FFieldAddress QuickHullByDefaultHACD_InStaticMesh_PropertyAddress;

	private static int QuickHullByDefaultHACD_InStaticMesh_Offset;

	private static bool QuickHullByDefaultHACD_Vertexs_IsValid;

	private static FFieldAddress QuickHullByDefaultHACD_Vertexs_PropertyAddress;

	private static int QuickHullByDefaultHACD_Vertexs_Offset;

	private static bool QuickHullByDefaultHACD_InIndices_IsValid;

	private static FFieldAddress QuickHullByDefaultHACD_InIndices_PropertyAddress;

	private static int QuickHullByDefaultHACD_InIndices_Offset;

	private static bool QuickHullByDefaultHACD_InHullCount_IsValid;

	private static FFieldAddress QuickHullByDefaultHACD_InHullCount_PropertyAddress;

	private static int QuickHullByDefaultHACD_InHullCount_Offset;

	private static bool QuickHullByDefaultHACD_InMaxHullVerts_IsValid;

	private static FFieldAddress QuickHullByDefaultHACD_InMaxHullVerts_PropertyAddress;

	private static int QuickHullByDefaultHACD_InMaxHullVerts_Offset;

	private static bool QuickHullByDefaultHACD_InResolution_IsValid;

	private static FFieldAddress QuickHullByDefaultHACD_InResolution_PropertyAddress;

	private static int QuickHullByDefaultHACD_InResolution_Offset;

	private static bool QuickHull_IsValid;

	private static IntPtr QuickHull_FunctionAddress;

	private static int QuickHull_ParamsSize;

	private static bool QuickHull_Vertexs_IsValid;

	private static FFieldAddress QuickHull_Vertexs_PropertyAddress;

	private static int QuickHull_Vertexs_Offset;

	private static bool QuickHull_CleanVertexRemap_IsValid;

	private static FFieldAddress QuickHull_CleanVertexRemap_PropertyAddress;

	private static int QuickHull_CleanVertexRemap_Offset;

	private static bool QuickHull_MinCell_IsValid;

	private static FFieldAddress QuickHull_MinCell_PropertyAddress;

	private static int QuickHull_MinCell_Offset;

	private static bool QuickHull_ReturnValue_IsValid;

	private static FFieldAddress QuickHull_ReturnValue_PropertyAddress;

	private static int QuickHull_ReturnValue_Offset;

	private static bool PrintStaticMeshesDFInfo_IsValid;

	private static IntPtr PrintStaticMeshesDFInfo_FunctionAddress;

	private static int PrintStaticMeshesDFInfo_ParamsSize;

	private static bool PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_IsValid;

	private static FFieldAddress PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_PropertyAddress;

	private static int PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_Offset;

	private static bool MergeSameSections_IsValid;

	private static IntPtr MergeSameSections_FunctionAddress;

	private static int MergeSameSections_ParamsSize;

	private static bool MergeSameSections_StaticMesh_IsValid;

	private static FFieldAddress MergeSameSections_StaticMesh_PropertyAddress;

	private static int MergeSameSections_StaticMesh_Offset;

	private static bool IsNaniteEnable_IsValid;

	private static IntPtr IsNaniteEnable_FunctionAddress;

	private static int IsNaniteEnable_ParamsSize;

	private static bool IsNaniteEnable_StaticMesh_IsValid;

	private static FFieldAddress IsNaniteEnable_StaticMesh_PropertyAddress;

	private static int IsNaniteEnable_StaticMesh_Offset;

	private static bool IsNaniteEnable_ReturnValue_IsValid;

	private static FFieldAddress IsNaniteEnable_ReturnValue_PropertyAddress;

	private static int IsNaniteEnable_ReturnValue_Offset;

	private static bool ImportDMChunks_IsValid;

	private static IntPtr ImportDMChunks_FunctionAddress;

	private static int ImportDMChunks_ParamsSize;

	private static bool ImportDMChunks_DestructibleMesh_IsValid;

	private static FFieldAddress ImportDMChunks_DestructibleMesh_PropertyAddress;

	private static int ImportDMChunks_DestructibleMesh_Offset;

	private static bool ImportDMChunks_ImportFilename_IsValid;

	private static FFieldAddress ImportDMChunks_ImportFilename_PropertyAddress;

	private static int ImportDMChunks_ImportFilename_Offset;

	private static bool GetStaticMeshVertexNum_IsValid;

	private static IntPtr GetStaticMeshVertexNum_FunctionAddress;

	private static int GetStaticMeshVertexNum_ParamsSize;

	private static bool GetStaticMeshVertexNum_StaticMesh_IsValid;

	private static FFieldAddress GetStaticMeshVertexNum_StaticMesh_PropertyAddress;

	private static int GetStaticMeshVertexNum_StaticMesh_Offset;

	private static bool GetStaticMeshVertexNum_LOD_IsValid;

	private static FFieldAddress GetStaticMeshVertexNum_LOD_PropertyAddress;

	private static int GetStaticMeshVertexNum_LOD_Offset;

	private static bool GetStaticMeshVertexNum_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshVertexNum_ReturnValue_PropertyAddress;

	private static int GetStaticMeshVertexNum_ReturnValue_Offset;

	private static bool GetStaticMeshVertexColor_IsValid;

	private static IntPtr GetStaticMeshVertexColor_FunctionAddress;

	private static int GetStaticMeshVertexColor_ParamsSize;

	private static bool GetStaticMeshVertexColor_StaticMesh_IsValid;

	private static FFieldAddress GetStaticMeshVertexColor_StaticMesh_PropertyAddress;

	private static int GetStaticMeshVertexColor_StaticMesh_Offset;

	private static bool GetStaticMeshVertexColor_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshVertexColor_ReturnValue_PropertyAddress;

	private static int GetStaticMeshVertexColor_ReturnValue_Offset;

	private static bool GetStaticMeshTrianglesNum_IsValid;

	private static IntPtr GetStaticMeshTrianglesNum_FunctionAddress;

	private static int GetStaticMeshTrianglesNum_ParamsSize;

	private static bool GetStaticMeshTrianglesNum_StaticMesh_IsValid;

	private static FFieldAddress GetStaticMeshTrianglesNum_StaticMesh_PropertyAddress;

	private static int GetStaticMeshTrianglesNum_StaticMesh_Offset;

	private static bool GetStaticMeshTrianglesNum_LOD_IsValid;

	private static FFieldAddress GetStaticMeshTrianglesNum_LOD_PropertyAddress;

	private static int GetStaticMeshTrianglesNum_LOD_Offset;

	private static bool GetStaticMeshTrianglesNum_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshTrianglesNum_ReturnValue_PropertyAddress;

	private static int GetStaticMeshTrianglesNum_ReturnValue_Offset;

	private static bool GetStaticMeshConvexCollisionTriangleNum_IsValid;

	private static IntPtr GetStaticMeshConvexCollisionTriangleNum_FunctionAddress;

	private static int GetStaticMeshConvexCollisionTriangleNum_ParamsSize;

	private static bool GetStaticMeshConvexCollisionTriangleNum_StaticMesh_IsValid;

	private static FFieldAddress GetStaticMeshConvexCollisionTriangleNum_StaticMesh_PropertyAddress;

	private static int GetStaticMeshConvexCollisionTriangleNum_StaticMesh_Offset;

	private static bool GetStaticMeshConvexCollisionTriangleNum_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshConvexCollisionTriangleNum_ReturnValue_PropertyAddress;

	private static int GetStaticMeshConvexCollisionTriangleNum_ReturnValue_Offset;

	private static bool GetStaticMeshComponentsVertex3f_IsValid;

	private static IntPtr GetStaticMeshComponentsVertex3f_FunctionAddress;

	private static int GetStaticMeshComponentsVertex3f_ParamsSize;

	private static bool GetStaticMeshComponentsVertex3f_StaticMeshComponents_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex3f_StaticMeshComponents_PropertyAddress;

	private static int GetStaticMeshComponentsVertex3f_StaticMeshComponents_Offset;

	private static bool GetStaticMeshComponentsVertex3f_Index_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex3f_Index_PropertyAddress;

	private static int GetStaticMeshComponentsVertex3f_Index_Offset;

	private static bool GetStaticMeshComponentsVertex3f_Center_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex3f_Center_PropertyAddress;

	private static int GetStaticMeshComponentsVertex3f_Center_Offset;

	private static bool GetStaticMeshComponentsVertex3f_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex3f_ReturnValue_PropertyAddress;

	private static int GetStaticMeshComponentsVertex3f_ReturnValue_Offset;

	private static bool GetStaticMeshComponentsVertex_IsValid;

	private static IntPtr GetStaticMeshComponentsVertex_FunctionAddress;

	private static int GetStaticMeshComponentsVertex_ParamsSize;

	private static bool GetStaticMeshComponentsVertex_StaticMeshComponents_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex_StaticMeshComponents_PropertyAddress;

	private static int GetStaticMeshComponentsVertex_StaticMeshComponents_Offset;

	private static bool GetStaticMeshComponentsVertex_Index_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex_Index_PropertyAddress;

	private static int GetStaticMeshComponentsVertex_Index_Offset;

	private static bool GetStaticMeshComponentsVertex_Center_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex_Center_PropertyAddress;

	private static int GetStaticMeshComponentsVertex_Center_Offset;

	private static bool GetStaticMeshComponentsVertex_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshComponentsVertex_ReturnValue_PropertyAddress;

	private static int GetStaticMeshComponentsVertex_ReturnValue_Offset;

	private static bool GetNaniteVertexes_IsValid;

	private static IntPtr GetNaniteVertexes_FunctionAddress;

	private static int GetNaniteVertexes_ParamsSize;

	private static bool GetNaniteVertexes_StaticMesh_IsValid;

	private static FFieldAddress GetNaniteVertexes_StaticMesh_PropertyAddress;

	private static int GetNaniteVertexes_StaticMesh_Offset;

	private static bool GetNaniteVertexes_ReturnValue_IsValid;

	private static FFieldAddress GetNaniteVertexes_ReturnValue_PropertyAddress;

	private static int GetNaniteVertexes_ReturnValue_Offset;

	private static bool GetNaniteTriangles_IsValid;

	private static IntPtr GetNaniteTriangles_FunctionAddress;

	private static int GetNaniteTriangles_ParamsSize;

	private static bool GetNaniteTriangles_StaticMesh_IsValid;

	private static FFieldAddress GetNaniteTriangles_StaticMesh_PropertyAddress;

	private static int GetNaniteTriangles_StaticMesh_Offset;

	private static bool GetNaniteTriangles_ReturnValue_IsValid;

	private static FFieldAddress GetNaniteTriangles_ReturnValue_PropertyAddress;

	private static int GetNaniteTriangles_ReturnValue_Offset;

	private static bool GetConvexCollisionVertex_IsValid;

	private static IntPtr GetConvexCollisionVertex_FunctionAddress;

	private static int GetConvexCollisionVertex_ParamsSize;

	private static bool GetConvexCollisionVertex_StaticMesh_IsValid;

	private static FFieldAddress GetConvexCollisionVertex_StaticMesh_PropertyAddress;

	private static int GetConvexCollisionVertex_StaticMesh_Offset;

	private static bool GetConvexCollisionVertex_Index_IsValid;

	private static FFieldAddress GetConvexCollisionVertex_Index_PropertyAddress;

	private static int GetConvexCollisionVertex_Index_Offset;

	private static bool GetConvexCollisionVertex_ReturnValue_IsValid;

	private static FFieldAddress GetConvexCollisionVertex_ReturnValue_PropertyAddress;

	private static int GetConvexCollisionVertex_ReturnValue_Offset;

	private static bool GetCDOStaticMeshComponents_IsValid;

	private static IntPtr GetCDOStaticMeshComponents_FunctionAddress;

	private static int GetCDOStaticMeshComponents_ParamsSize;

	private static bool GetCDOStaticMeshComponents_ActorClass_IsValid;

	private static FFieldAddress GetCDOStaticMeshComponents_ActorClass_PropertyAddress;

	private static int GetCDOStaticMeshComponents_ActorClass_Offset;

	private static bool GetCDOStaticMeshComponents_ReturnValue_IsValid;

	private static FFieldAddress GetCDOStaticMeshComponents_ReturnValue_PropertyAddress;

	private static int GetCDOStaticMeshComponents_ReturnValue_Offset;

	private static bool FinishPhysicsSim_IsValid;

	private static IntPtr FinishPhysicsSim_FunctionAddress;

	private static int FinishPhysicsSim_ParamsSize;

	private static bool DisableStaticMeshCollision_IsValid;

	private static IntPtr DisableStaticMeshCollision_FunctionAddress;

	private static int DisableStaticMeshCollision_ParamsSize;

	private static bool DisableStaticMeshCollision_InSM_IsValid;

	private static FFieldAddress DisableStaticMeshCollision_InSM_PropertyAddress;

	private static int DisableStaticMeshCollision_InSM_Offset;

	private static bool DisableStaticMeshCollision_ReturnValue_IsValid;

	private static FFieldAddress DisableStaticMeshCollision_ReturnValue_PropertyAddress;

	private static int DisableStaticMeshCollision_ReturnValue_Offset;

	private static bool DisableNavData_IsValid;

	private static IntPtr DisableNavData_FunctionAddress;

	private static int DisableNavData_ParamsSize;

	private static bool DisableNavData_InSM_IsValid;

	private static FFieldAddress DisableNavData_InSM_PropertyAddress;

	private static int DisableNavData_InSM_Offset;

	private static bool DisableNavData_ReturnValue_IsValid;

	private static FFieldAddress DisableNavData_ReturnValue_PropertyAddress;

	private static int DisableNavData_ReturnValue_Offset;

	private static bool ClickFractureButton_IsValid;

	private static IntPtr ClickFractureButton_FunctionAddress;

	private static int ClickFractureButton_ParamsSize;

	private static bool ApplyCustomPrimitiveDataValues_IsValid;

	private static IntPtr ApplyCustomPrimitiveDataValues_FunctionAddress;

	private static int ApplyCustomPrimitiveDataValues_ParamsSize;

	private static bool ApplyCustomPrimitiveDataValues_InSMComponent_IsValid;

	private static FFieldAddress ApplyCustomPrimitiveDataValues_InSMComponent_PropertyAddress;

	private static int ApplyCustomPrimitiveDataValues_InSMComponent_Offset;

	private static bool ApplyCustomPrimitiveDataValues_InDataArray_IsValid;

	private static FFieldAddress ApplyCustomPrimitiveDataValues_InDataArray_PropertyAddress;

	private static int ApplyCustomPrimitiveDataValues_InDataArray_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:StaticMeshPostLoad")]
	public unsafe static void StaticMeshPostLoad(UStaticMesh StaticMesh)
	{
		if (!StaticMeshPostLoad_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:StaticMeshPostLoad");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StaticMeshPostLoad_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StaticMeshPostLoad_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, StaticMeshPostLoad_StaticMesh_Offset), 0, StaticMeshPostLoad_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StaticMeshPostLoad_FunctionAddress, intPtr, StaticMeshPostLoad_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:StartPhysicsSim")]
	public unsafe static void StartPhysicsSim()
	{
		if (!StartPhysicsSim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:StartPhysicsSim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPhysicsSim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPhysicsSim_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StartPhysicsSim_FunctionAddress, argsSize: StartPhysicsSim_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshVertexColorSingleChannl")]
	public unsafe static void SetStaticMeshVertexColorSingleChannl(UStaticMesh StaticMesh, int PaintingMeshLODIndex, Dictionary<FVector, float> VertexColorSingleChannlData, int ChannlIndex)
	{
		if (!SetStaticMeshVertexColorSingleChannl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshVertexColorSingleChannl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshVertexColorSingleChannl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshVertexColorSingleChannl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMeshVertexColorSingleChannl_StaticMesh_Offset), 0, SetStaticMeshVertexColorSingleChannl_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_Offset), 0, SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_PropertyAddress.Address, PaintingMeshLODIndex);
		NativeReflection.InitializeValue_InContainer(SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FVector, float>(1, SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_Offset), VertexColorSingleChannlData);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetStaticMeshVertexColorSingleChannl_ChannlIndex_Offset), 0, SetStaticMeshVertexColorSingleChannl_ChannlIndex_PropertyAddress.Address, ChannlIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshVertexColorSingleChannl_FunctionAddress, intPtr, SetStaticMeshVertexColorSingleChannl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshVertexColor")]
	public unsafe static void SetStaticMeshVertexColor(UStaticMesh StaticMesh, Dictionary<FVector, FColor> VertexColorData)
	{
		if (!SetStaticMeshVertexColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshVertexColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshVertexColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshVertexColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMeshVertexColor_StaticMesh_Offset), 0, SetStaticMeshVertexColor_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InitializeValue_InContainer(SetStaticMeshVertexColor_VertexColorData_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FVector, FColor>(1, SetStaticMeshVertexColor_VertexColorData_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetStaticMeshVertexColor_VertexColorData_Offset), VertexColorData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshVertexColor_FunctionAddress, intPtr, SetStaticMeshVertexColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStaticMeshVertexColor_VertexColorData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshUseOpacityMicroMap")]
	public unsafe static bool SetStaticMeshUseOpacityMicroMap(UStaticMesh InSM, bool NewUse, bool VisibleInRayTracing)
	{
		if (!SetStaticMeshUseOpacityMicroMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshUseOpacityMicroMap");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshUseOpacityMicroMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshUseOpacityMicroMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMeshUseOpacityMicroMap_InSM_Offset), 0, SetStaticMeshUseOpacityMicroMap_InSM_PropertyAddress.Address, InSM);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStaticMeshUseOpacityMicroMap_NewUse_Offset), 0, SetStaticMeshUseOpacityMicroMap_NewUse_PropertyAddress.Address, NewUse);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_Offset), 0, SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_PropertyAddress.Address, VisibleInRayTracing);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshUseOpacityMicroMap_FunctionAddress, intPtr, SetStaticMeshUseOpacityMicroMap_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetStaticMeshUseOpacityMicroMap_ReturnValue_Offset), 0, SetStaticMeshUseOpacityMicroMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshLODScreenSize")]
	public unsafe static bool SetStaticMeshLODScreenSize(UStaticMesh InSM, int LodIndex, float NewScreenSize)
	{
		if (!SetStaticMeshLODScreenSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshLODScreenSize");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshLODScreenSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshLODScreenSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetStaticMeshLODScreenSize_InSM_Offset), 0, SetStaticMeshLODScreenSize_InSM_PropertyAddress.Address, InSM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetStaticMeshLODScreenSize_LodIndex_Offset), 0, SetStaticMeshLODScreenSize_LodIndex_PropertyAddress.Address, LodIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStaticMeshLODScreenSize_NewScreenSize_Offset), 0, SetStaticMeshLODScreenSize_NewScreenSize_PropertyAddress.Address, NewScreenSize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshLODScreenSize_FunctionAddress, intPtr, SetStaticMeshLODScreenSize_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetStaticMeshLODScreenSize_ReturnValue_Offset), 0, SetStaticMeshLODScreenSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshesDFResScale")]
	public unsafe static void SetStaticMeshesDFResScale(string TxtFilePathContainsStaticMeshList, float InTargetDFResolution = 1f)
	{
		if (!SetStaticMeshesDFResScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshesDFResScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshesDFResScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshesDFResScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_Offset), 0, SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_PropertyAddress.Address, TxtFilePathContainsStaticMeshList);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStaticMeshesDFResScale_InTargetDFResolution_Offset), 0, SetStaticMeshesDFResScale_InTargetDFResolution_PropertyAddress.Address, InTargetDFResolution);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshesDFResScale_FunctionAddress, intPtr, SetStaticMeshesDFResScale_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetSourceFileName")]
	public unsafe static void SetSourceFileName(UStaticMesh SM, string TargetFileName)
	{
		if (!SetSourceFileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetSourceFileName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceFileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceFileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetSourceFileName_SM_Offset), 0, SetSourceFileName_SM_PropertyAddress.Address, SM);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSourceFileName_TargetFileName_Offset), 0, SetSourceFileName_TargetFileName_PropertyAddress.Address, TargetFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSourceFileName_FunctionAddress, intPtr, SetSourceFileName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSourceFileName_TargetFileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetNumStreamedLODs")]
	public unsafe static bool SetNumStreamedLODs(UStaticMesh StaticMesh, int InNumStreamedLODs)
	{
		if (!SetNumStreamedLODs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetNumStreamedLODs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumStreamedLODs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumStreamedLODs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetNumStreamedLODs_StaticMesh_Offset), 0, SetNumStreamedLODs_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumStreamedLODs_InNumStreamedLODs_Offset), 0, SetNumStreamedLODs_InNumStreamedLODs_PropertyAddress.Address, InNumStreamedLODs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNumStreamedLODs_FunctionAddress, intPtr, SetNumStreamedLODs_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNumStreamedLODs_ReturnValue_Offset), 0, SetNumStreamedLODs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetNaniteEnable")]
	public unsafe static void SetNaniteEnable(UStaticMesh StaticMesh, bool NewState)
	{
		if (!SetNaniteEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetNaniteEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNaniteEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNaniteEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetNaniteEnable_StaticMesh_Offset), 0, SetNaniteEnable_StaticMesh_PropertyAddress.Address, StaticMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNaniteEnable_NewState_Offset), 0, SetNaniteEnable_NewState_PropertyAddress.Address, NewState);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNaniteEnable_FunctionAddress, intPtr, SetNaniteEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetMinLOD")]
	public unsafe static void SetMinLOD(UStaticMesh StaticMesh, int MinLOD)
	{
		if (!SetMinLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetMinLOD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetMinLOD_StaticMesh_Offset), 0, SetMinLOD_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMinLOD_MinLOD_Offset), 0, SetMinLOD_MinLOD_PropertyAddress.Address, MinLOD);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMinLOD_FunctionAddress, intPtr, SetMinLOD_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetDestructibleMesh")]
	public unsafe static void SetDestructibleMesh(UObject BPO)
	{
		if (!SetDestructibleMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetDestructibleMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDestructibleMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDestructibleMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetDestructibleMesh_BPO_Offset), 0, SetDestructibleMesh_BPO_PropertyAddress.Address, BPO);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDestructibleMesh_FunctionAddress, intPtr, SetDestructibleMesh_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ResetGeometryCollection")]
	public unsafe static void ResetGeometryCollection(UGeometryCollectionComponent GeometryCollectionComponent)
	{
		if (!ResetGeometryCollection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ResetGeometryCollection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetGeometryCollection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetGeometryCollection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGeometryCollectionComponent>.ToNative(IntPtr.Add(intPtr, ResetGeometryCollection_GeometryCollectionComponent_Offset), 0, ResetGeometryCollection_GeometryCollectionComponent_PropertyAddress.Address, GeometryCollectionComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetGeometryCollection_FunctionAddress, intPtr, ResetGeometryCollection_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ReplaceSourceFileName")]
	public unsafe static void ReplaceSourceFileName(UStaticMesh SM, string Src, string Target)
	{
		if (!ReplaceSourceFileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ReplaceSourceFileName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceSourceFileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceSourceFileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ReplaceSourceFileName_SM_Offset), 0, ReplaceSourceFileName_SM_PropertyAddress.Address, SM);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceSourceFileName_Src_Offset), 0, ReplaceSourceFileName_Src_PropertyAddress.Address, Src);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceSourceFileName_Target_Offset), 0, ReplaceSourceFileName_Target_PropertyAddress.Address, Target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceSourceFileName_FunctionAddress, intPtr, ReplaceSourceFileName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceSourceFileName_Src_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ReplaceSourceFileName_Target_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ReplaceLodSections")]
	public unsafe static bool ReplaceLodSections(UStaticMesh StaticMesh, int LODIndex, Dictionary<int, int> SectionIDMap)
	{
		if (!ReplaceLodSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ReplaceLodSections");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceLodSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceLodSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, ReplaceLodSections_StaticMesh_Offset), 0, ReplaceLodSections_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReplaceLodSections_LODIndex_Offset), 0, ReplaceLodSections_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InitializeValue_InContainer(ReplaceLodSections_SectionIDMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, ReplaceLodSections_SectionIDMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceLodSections_SectionIDMap_Offset), SectionIDMap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceLodSections_FunctionAddress, intPtr, ReplaceLodSections_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceLodSections_SectionIDMap_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReplaceLodSections_ReturnValue_Offset), 0, ReplaceLodSections_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:QuickHullByDefaultHACD")]
	public unsafe static void QuickHullByDefaultHACD(UStaticMesh InStaticMesh, List<FVector3f> Vertexs, List<int> InIndices, int InHullCount, int InMaxHullVerts, int InResolution)
	{
		if (!QuickHullByDefaultHACD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:QuickHullByDefaultHACD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QuickHullByDefaultHACD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QuickHullByDefaultHACD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, QuickHullByDefaultHACD_InStaticMesh_Offset), 0, QuickHullByDefaultHACD_InStaticMesh_PropertyAddress.Address, InStaticMesh);
		new TArrayCopyMarshaler<FVector3f>(1, QuickHullByDefaultHACD_Vertexs_PropertyAddress, CachedMarshalingDelegates<FVector3f, FVector3f>.FromNative, CachedMarshalingDelegates<FVector3f, FVector3f>.ToNative).ToNative(IntPtr.Add(intPtr, QuickHullByDefaultHACD_Vertexs_Offset), Vertexs);
		new TArrayCopyMarshaler<int>(1, QuickHullByDefaultHACD_InIndices_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, QuickHullByDefaultHACD_InIndices_Offset), InIndices);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, QuickHullByDefaultHACD_InHullCount_Offset), 0, QuickHullByDefaultHACD_InHullCount_PropertyAddress.Address, InHullCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, QuickHullByDefaultHACD_InMaxHullVerts_Offset), 0, QuickHullByDefaultHACD_InMaxHullVerts_PropertyAddress.Address, InMaxHullVerts);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, QuickHullByDefaultHACD_InResolution_Offset), 0, QuickHullByDefaultHACD_InResolution_PropertyAddress.Address, InResolution);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QuickHullByDefaultHACD_FunctionAddress, intPtr, QuickHullByDefaultHACD_ParamsSize);
		NativeReflection.DestroyValue_InContainer(QuickHullByDefaultHACD_Vertexs_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(QuickHullByDefaultHACD_InIndices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:QuickHull")]
	public unsafe static List<FVector> QuickHull(List<FVector> Vertexs, out List<int> CleanVertexRemap, float MinCell = 10f)
	{
		if (!QuickHull_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:QuickHull");
			CleanVertexRemap = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QuickHull_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QuickHull_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, QuickHull_Vertexs_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, QuickHull_Vertexs_Offset), Vertexs);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, QuickHull_MinCell_Offset), 0, QuickHull_MinCell_PropertyAddress.Address, MinCell);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QuickHull_FunctionAddress, intPtr, QuickHull_ParamsSize);
		NativeReflection.DestroyValue_InContainer(QuickHull_Vertexs_PropertyAddress.Address, intPtr);
		CleanVertexRemap = new TArrayCopyMarshaler<int>(1, QuickHull_CleanVertexRemap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, QuickHull_CleanVertexRemap_Offset));
		NativeReflection.DestroyValue_InContainer(QuickHull_CleanVertexRemap_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, QuickHull_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, QuickHull_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(QuickHull_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:PrintStaticMeshesDFInfo")]
	public unsafe static void PrintStaticMeshesDFInfo(string TxtFilePathContainsStaticMeshList)
	{
		if (!PrintStaticMeshesDFInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:PrintStaticMeshesDFInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrintStaticMeshesDFInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrintStaticMeshesDFInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_Offset), 0, PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_PropertyAddress.Address, TxtFilePathContainsStaticMeshList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrintStaticMeshesDFInfo_FunctionAddress, intPtr, PrintStaticMeshesDFInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:MergeSameSections")]
	public unsafe static void MergeSameSections(UStaticMesh StaticMesh)
	{
		if (!MergeSameSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:MergeSameSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeSameSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeSameSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, MergeSameSections_StaticMesh_Offset), 0, MergeSameSections_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MergeSameSections_FunctionAddress, intPtr, MergeSameSections_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:IsNaniteEnable")]
	public unsafe static bool IsNaniteEnable(UStaticMesh StaticMesh)
	{
		if (!IsNaniteEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:IsNaniteEnable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNaniteEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNaniteEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, IsNaniteEnable_StaticMesh_Offset), 0, IsNaniteEnable_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNaniteEnable_FunctionAddress, intPtr, IsNaniteEnable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNaniteEnable_ReturnValue_Offset), 0, IsNaniteEnable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ImportDMChunks")]
	public unsafe static void ImportDMChunks(UDestructibleMesh DestructibleMesh, string ImportFilename)
	{
		if (!ImportDMChunks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ImportDMChunks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportDMChunks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportDMChunks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDestructibleMesh>.ToNative(IntPtr.Add(intPtr, ImportDMChunks_DestructibleMesh_Offset), 0, ImportDMChunks_DestructibleMesh_PropertyAddress.Address, DestructibleMesh);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportDMChunks_ImportFilename_Offset), 0, ImportDMChunks_ImportFilename_PropertyAddress.Address, ImportFilename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportDMChunks_FunctionAddress, intPtr, ImportDMChunks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportDMChunks_ImportFilename_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshVertexNum")]
	public unsafe static int GetStaticMeshVertexNum(UStaticMesh StaticMesh, int LOD)
	{
		if (!GetStaticMeshVertexNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshVertexNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshVertexNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshVertexNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetStaticMeshVertexNum_StaticMesh_Offset), 0, GetStaticMeshVertexNum_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetStaticMeshVertexNum_LOD_Offset), 0, GetStaticMeshVertexNum_LOD_PropertyAddress.Address, LOD);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshVertexNum_FunctionAddress, intPtr, GetStaticMeshVertexNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStaticMeshVertexNum_ReturnValue_Offset), 0, GetStaticMeshVertexNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshVertexColor")]
	public unsafe static Dictionary<FVector, FColor> GetStaticMeshVertexColor(UStaticMesh StaticMesh)
	{
		if (!GetStaticMeshVertexColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshVertexColor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshVertexColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshVertexColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetStaticMeshVertexColor_StaticMesh_Offset), 0, GetStaticMeshVertexColor_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshVertexColor_FunctionAddress, intPtr, GetStaticMeshVertexColor_ParamsSize);
		Dictionary<FVector, FColor> result = new TMapCopyMarshaler<FVector, FColor>(1, GetStaticMeshVertexColor_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetStaticMeshVertexColor_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetStaticMeshVertexColor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshTrianglesNum")]
	public unsafe static int GetStaticMeshTrianglesNum(UStaticMesh StaticMesh, int LOD)
	{
		if (!GetStaticMeshTrianglesNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshTrianglesNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshTrianglesNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshTrianglesNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetStaticMeshTrianglesNum_StaticMesh_Offset), 0, GetStaticMeshTrianglesNum_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetStaticMeshTrianglesNum_LOD_Offset), 0, GetStaticMeshTrianglesNum_LOD_PropertyAddress.Address, LOD);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshTrianglesNum_FunctionAddress, intPtr, GetStaticMeshTrianglesNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStaticMeshTrianglesNum_ReturnValue_Offset), 0, GetStaticMeshTrianglesNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshConvexCollisionTriangleNum")]
	public unsafe static int GetStaticMeshConvexCollisionTriangleNum(UStaticMesh StaticMesh)
	{
		if (!GetStaticMeshConvexCollisionTriangleNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshConvexCollisionTriangleNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshConvexCollisionTriangleNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshConvexCollisionTriangleNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetStaticMeshConvexCollisionTriangleNum_StaticMesh_Offset), 0, GetStaticMeshConvexCollisionTriangleNum_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshConvexCollisionTriangleNum_FunctionAddress, intPtr, GetStaticMeshConvexCollisionTriangleNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStaticMeshConvexCollisionTriangleNum_ReturnValue_Offset), 0, GetStaticMeshConvexCollisionTriangleNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshComponentsVertex3f")]
	public unsafe static List<FVector3f> GetStaticMeshComponentsVertex3f(List<UStaticMeshComponent> StaticMeshComponents, out List<int> Index, FVector Center)
	{
		if (!GetStaticMeshComponentsVertex3f_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshComponentsVertex3f");
			Index = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshComponentsVertex3f_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshComponentsVertex3f_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UStaticMeshComponent>(1, GetStaticMeshComponentsVertex3f_StaticMeshComponents_PropertyAddress, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.FromNative, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex3f_StaticMeshComponents_Offset), StaticMeshComponents);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex3f_Center_Offset), 0, GetStaticMeshComponentsVertex3f_Center_PropertyAddress.Address, Center);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshComponentsVertex3f_FunctionAddress, intPtr, GetStaticMeshComponentsVertex3f_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetStaticMeshComponentsVertex3f_StaticMeshComponents_PropertyAddress.Address, intPtr);
		Index = new TArrayCopyMarshaler<int>(1, GetStaticMeshComponentsVertex3f_Index_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex3f_Index_Offset));
		NativeReflection.DestroyValue_InContainer(GetStaticMeshComponentsVertex3f_Index_PropertyAddress.Address, intPtr);
		List<FVector3f> result = new TArrayCopyMarshaler<FVector3f>(1, GetStaticMeshComponentsVertex3f_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector3f, FVector3f>.FromNative, CachedMarshalingDelegates<FVector3f, FVector3f>.ToNative).FromNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex3f_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetStaticMeshComponentsVertex3f_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshComponentsVertex")]
	public unsafe static List<FVector> GetStaticMeshComponentsVertex(List<UStaticMeshComponent> StaticMeshComponents, out List<int> Index, FVector Center)
	{
		if (!GetStaticMeshComponentsVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshComponentsVertex");
			Index = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshComponentsVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshComponentsVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UStaticMeshComponent>(1, GetStaticMeshComponentsVertex_StaticMeshComponents_PropertyAddress, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.FromNative, CachedMarshalingDelegates<UStaticMeshComponent, UObjectMarshaler<UStaticMeshComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex_StaticMeshComponents_Offset), StaticMeshComponents);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex_Center_Offset), 0, GetStaticMeshComponentsVertex_Center_PropertyAddress.Address, Center);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshComponentsVertex_FunctionAddress, intPtr, GetStaticMeshComponentsVertex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetStaticMeshComponentsVertex_StaticMeshComponents_PropertyAddress.Address, intPtr);
		Index = new TArrayCopyMarshaler<int>(1, GetStaticMeshComponentsVertex_Index_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex_Index_Offset));
		NativeReflection.DestroyValue_InContainer(GetStaticMeshComponentsVertex_Index_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetStaticMeshComponentsVertex_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetStaticMeshComponentsVertex_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetStaticMeshComponentsVertex_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetNaniteVertexes")]
	public unsafe static int GetNaniteVertexes(UStaticMesh StaticMesh)
	{
		if (!GetNaniteVertexes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetNaniteVertexes");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNaniteVertexes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNaniteVertexes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetNaniteVertexes_StaticMesh_Offset), 0, GetNaniteVertexes_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNaniteVertexes_FunctionAddress, intPtr, GetNaniteVertexes_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNaniteVertexes_ReturnValue_Offset), 0, GetNaniteVertexes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetNaniteTriangles")]
	public unsafe static int GetNaniteTriangles(UStaticMesh StaticMesh)
	{
		if (!GetNaniteTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetNaniteTriangles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNaniteTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNaniteTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetNaniteTriangles_StaticMesh_Offset), 0, GetNaniteTriangles_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNaniteTriangles_FunctionAddress, intPtr, GetNaniteTriangles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNaniteTriangles_ReturnValue_Offset), 0, GetNaniteTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetConvexCollisionVertex")]
	public unsafe static List<FVector> GetConvexCollisionVertex(UStaticMesh StaticMesh, out List<int> Index)
	{
		if (!GetConvexCollisionVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetConvexCollisionVertex");
			Index = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConvexCollisionVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConvexCollisionVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetConvexCollisionVertex_StaticMesh_Offset), 0, GetConvexCollisionVertex_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetConvexCollisionVertex_FunctionAddress, intPtr, GetConvexCollisionVertex_ParamsSize);
		Index = new TArrayCopyMarshaler<int>(1, GetConvexCollisionVertex_Index_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetConvexCollisionVertex_Index_Offset));
		NativeReflection.DestroyValue_InContainer(GetConvexCollisionVertex_Index_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetConvexCollisionVertex_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetConvexCollisionVertex_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetConvexCollisionVertex_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetCDOStaticMeshComponents")]
	public unsafe static List<UActorComponent> GetCDOStaticMeshComponents(TSubclassOf<AActor> ActorClass)
	{
		if (!GetCDOStaticMeshComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetCDOStaticMeshComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCDOStaticMeshComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCDOStaticMeshComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetCDOStaticMeshComponents_ActorClass_Offset), 0, GetCDOStaticMeshComponents_ActorClass_PropertyAddress.Address, ActorClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCDOStaticMeshComponents_FunctionAddress, intPtr, GetCDOStaticMeshComponents_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GetCDOStaticMeshComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCDOStaticMeshComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCDOStaticMeshComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:FinishPhysicsSim")]
	public unsafe static void FinishPhysicsSim()
	{
		if (!FinishPhysicsSim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:FinishPhysicsSim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishPhysicsSim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishPhysicsSim_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: FinishPhysicsSim_FunctionAddress, argsSize: FinishPhysicsSim_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:DisableStaticMeshCollision")]
	public unsafe static bool DisableStaticMeshCollision(UStaticMesh InSM)
	{
		if (!DisableStaticMeshCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:DisableStaticMeshCollision");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableStaticMeshCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableStaticMeshCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, DisableStaticMeshCollision_InSM_Offset), 0, DisableStaticMeshCollision_InSM_PropertyAddress.Address, InSM);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableStaticMeshCollision_FunctionAddress, intPtr, DisableStaticMeshCollision_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DisableStaticMeshCollision_ReturnValue_Offset), 0, DisableStaticMeshCollision_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:DisableNavData")]
	public unsafe static bool DisableNavData(UStaticMesh InSM)
	{
		if (!DisableNavData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:DisableNavData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableNavData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableNavData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, DisableNavData_InSM_Offset), 0, DisableNavData_InSM_PropertyAddress.Address, InSM);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableNavData_FunctionAddress, intPtr, DisableNavData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DisableNavData_ReturnValue_Offset), 0, DisableNavData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ClickFractureButton")]
	public unsafe static void ClickFractureButton()
	{
		if (!ClickFractureButton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ClickFractureButton");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClickFractureButton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClickFractureButton_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ClickFractureButton_FunctionAddress, argsSize: ClickFractureButton_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ApplyCustomPrimitiveDataValues")]
	public unsafe static void ApplyCustomPrimitiveDataValues(UStaticMeshComponent InSMComponent, List<float> InDataArray)
	{
		if (!ApplyCustomPrimitiveDataValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ApplyCustomPrimitiveDataValues");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyCustomPrimitiveDataValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyCustomPrimitiveDataValues_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, ApplyCustomPrimitiveDataValues_InSMComponent_Offset), 0, ApplyCustomPrimitiveDataValues_InSMComponent_PropertyAddress.Address, InSMComponent);
		new TArrayCopyMarshaler<float>(1, ApplyCustomPrimitiveDataValues_InDataArray_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, ApplyCustomPrimitiveDataValues_InDataArray_Offset), InDataArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyCustomPrimitiveDataValues_FunctionAddress, intPtr, ApplyCustomPrimitiveDataValues_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ApplyCustomPrimitiveDataValues_InDataArray_PropertyAddress.Address, intPtr);
	}

	static UGSEditorStaticMeshLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorStaticMeshLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorStaticMeshLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorStaticMeshLibrary");
		StaticMeshPostLoad_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StaticMeshPostLoad");
		StaticMeshPostLoad_ParamsSize = NativeReflection.GetFunctionParamsSize(StaticMeshPostLoad_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StaticMeshPostLoad_StaticMesh_PropertyAddress, StaticMeshPostLoad_FunctionAddress, "StaticMesh");
		StaticMeshPostLoad_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(StaticMeshPostLoad_FunctionAddress, "StaticMesh");
		StaticMeshPostLoad_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(StaticMeshPostLoad_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		StaticMeshPostLoad_IsValid = StaticMeshPostLoad_FunctionAddress != IntPtr.Zero && StaticMeshPostLoad_StaticMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:StaticMeshPostLoad", StaticMeshPostLoad_IsValid);
		StartPhysicsSim_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartPhysicsSim");
		StartPhysicsSim_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPhysicsSim_FunctionAddress);
		StartPhysicsSim_IsValid = StartPhysicsSim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:StartPhysicsSim", StartPhysicsSim_IsValid);
		SetStaticMeshVertexColorSingleChannl_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshVertexColorSingleChannl");
		SetStaticMeshVertexColorSingleChannl_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshVertexColorSingleChannl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshVertexColorSingleChannl_StaticMesh_PropertyAddress, SetStaticMeshVertexColorSingleChannl_FunctionAddress, "StaticMesh");
		SetStaticMeshVertexColorSingleChannl_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "StaticMesh");
		SetStaticMeshVertexColorSingleChannl_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_PropertyAddress, SetStaticMeshVertexColorSingleChannl_FunctionAddress, "PaintingMeshLODIndex");
		SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "PaintingMeshLODIndex");
		SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "PaintingMeshLODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_PropertyAddress, SetStaticMeshVertexColorSingleChannl_FunctionAddress, "VertexColorSingleChannlData");
		SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "VertexColorSingleChannlData");
		SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "VertexColorSingleChannlData", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshVertexColorSingleChannl_ChannlIndex_PropertyAddress, SetStaticMeshVertexColorSingleChannl_FunctionAddress, "ChannlIndex");
		SetStaticMeshVertexColorSingleChannl_ChannlIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "ChannlIndex");
		SetStaticMeshVertexColorSingleChannl_ChannlIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshVertexColorSingleChannl_FunctionAddress, "ChannlIndex", Classes.FIntProperty);
		SetStaticMeshVertexColorSingleChannl_IsValid = SetStaticMeshVertexColorSingleChannl_FunctionAddress != IntPtr.Zero && SetStaticMeshVertexColorSingleChannl_StaticMesh_IsValid && SetStaticMeshVertexColorSingleChannl_PaintingMeshLODIndex_IsValid && SetStaticMeshVertexColorSingleChannl_VertexColorSingleChannlData_IsValid && SetStaticMeshVertexColorSingleChannl_ChannlIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshVertexColorSingleChannl", SetStaticMeshVertexColorSingleChannl_IsValid);
		SetStaticMeshVertexColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshVertexColor");
		SetStaticMeshVertexColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshVertexColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshVertexColor_StaticMesh_PropertyAddress, SetStaticMeshVertexColor_FunctionAddress, "StaticMesh");
		SetStaticMeshVertexColor_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshVertexColor_FunctionAddress, "StaticMesh");
		SetStaticMeshVertexColor_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshVertexColor_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshVertexColor_VertexColorData_PropertyAddress, SetStaticMeshVertexColor_FunctionAddress, "VertexColorData");
		SetStaticMeshVertexColor_VertexColorData_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshVertexColor_FunctionAddress, "VertexColorData");
		SetStaticMeshVertexColor_VertexColorData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshVertexColor_FunctionAddress, "VertexColorData", Classes.FMapProperty);
		SetStaticMeshVertexColor_IsValid = SetStaticMeshVertexColor_FunctionAddress != IntPtr.Zero && SetStaticMeshVertexColor_StaticMesh_IsValid && SetStaticMeshVertexColor_VertexColorData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshVertexColor", SetStaticMeshVertexColor_IsValid);
		SetStaticMeshUseOpacityMicroMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshUseOpacityMicroMap");
		SetStaticMeshUseOpacityMicroMap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshUseOpacityMicroMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshUseOpacityMicroMap_InSM_PropertyAddress, SetStaticMeshUseOpacityMicroMap_FunctionAddress, "InSM");
		SetStaticMeshUseOpacityMicroMap_InSM_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "InSM");
		SetStaticMeshUseOpacityMicroMap_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshUseOpacityMicroMap_NewUse_PropertyAddress, SetStaticMeshUseOpacityMicroMap_FunctionAddress, "NewUse");
		SetStaticMeshUseOpacityMicroMap_NewUse_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "NewUse");
		SetStaticMeshUseOpacityMicroMap_NewUse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "NewUse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_PropertyAddress, SetStaticMeshUseOpacityMicroMap_FunctionAddress, "VisibleInRayTracing");
		SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "VisibleInRayTracing");
		SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "VisibleInRayTracing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshUseOpacityMicroMap_ReturnValue_PropertyAddress, SetStaticMeshUseOpacityMicroMap_FunctionAddress, "ReturnValue");
		SetStaticMeshUseOpacityMicroMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "ReturnValue");
		SetStaticMeshUseOpacityMicroMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshUseOpacityMicroMap_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetStaticMeshUseOpacityMicroMap_IsValid = SetStaticMeshUseOpacityMicroMap_FunctionAddress != IntPtr.Zero && SetStaticMeshUseOpacityMicroMap_InSM_IsValid && SetStaticMeshUseOpacityMicroMap_NewUse_IsValid && SetStaticMeshUseOpacityMicroMap_VisibleInRayTracing_IsValid && SetStaticMeshUseOpacityMicroMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshUseOpacityMicroMap", SetStaticMeshUseOpacityMicroMap_IsValid);
		SetStaticMeshLODScreenSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshLODScreenSize");
		SetStaticMeshLODScreenSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshLODScreenSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshLODScreenSize_InSM_PropertyAddress, SetStaticMeshLODScreenSize_FunctionAddress, "InSM");
		SetStaticMeshLODScreenSize_InSM_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshLODScreenSize_FunctionAddress, "InSM");
		SetStaticMeshLODScreenSize_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshLODScreenSize_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshLODScreenSize_LodIndex_PropertyAddress, SetStaticMeshLODScreenSize_FunctionAddress, "LodIndex");
		SetStaticMeshLODScreenSize_LodIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshLODScreenSize_FunctionAddress, "LodIndex");
		SetStaticMeshLODScreenSize_LodIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshLODScreenSize_FunctionAddress, "LodIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshLODScreenSize_NewScreenSize_PropertyAddress, SetStaticMeshLODScreenSize_FunctionAddress, "NewScreenSize");
		SetStaticMeshLODScreenSize_NewScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshLODScreenSize_FunctionAddress, "NewScreenSize");
		SetStaticMeshLODScreenSize_NewScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshLODScreenSize_FunctionAddress, "NewScreenSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshLODScreenSize_ReturnValue_PropertyAddress, SetStaticMeshLODScreenSize_FunctionAddress, "ReturnValue");
		SetStaticMeshLODScreenSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshLODScreenSize_FunctionAddress, "ReturnValue");
		SetStaticMeshLODScreenSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshLODScreenSize_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetStaticMeshLODScreenSize_IsValid = SetStaticMeshLODScreenSize_FunctionAddress != IntPtr.Zero && SetStaticMeshLODScreenSize_InSM_IsValid && SetStaticMeshLODScreenSize_LodIndex_IsValid && SetStaticMeshLODScreenSize_NewScreenSize_IsValid && SetStaticMeshLODScreenSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshLODScreenSize", SetStaticMeshLODScreenSize_IsValid);
		SetStaticMeshesDFResScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshesDFResScale");
		SetStaticMeshesDFResScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshesDFResScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_PropertyAddress, SetStaticMeshesDFResScale_FunctionAddress, "TxtFilePathContainsStaticMeshList");
		SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshesDFResScale_FunctionAddress, "TxtFilePathContainsStaticMeshList");
		SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshesDFResScale_FunctionAddress, "TxtFilePathContainsStaticMeshList", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshesDFResScale_InTargetDFResolution_PropertyAddress, SetStaticMeshesDFResScale_FunctionAddress, "InTargetDFResolution");
		SetStaticMeshesDFResScale_InTargetDFResolution_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshesDFResScale_FunctionAddress, "InTargetDFResolution");
		SetStaticMeshesDFResScale_InTargetDFResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshesDFResScale_FunctionAddress, "InTargetDFResolution", Classes.FFloatProperty);
		SetStaticMeshesDFResScale_IsValid = SetStaticMeshesDFResScale_FunctionAddress != IntPtr.Zero && SetStaticMeshesDFResScale_TxtFilePathContainsStaticMeshList_IsValid && SetStaticMeshesDFResScale_InTargetDFResolution_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetStaticMeshesDFResScale", SetStaticMeshesDFResScale_IsValid);
		SetSourceFileName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSourceFileName");
		SetSourceFileName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceFileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceFileName_SM_PropertyAddress, SetSourceFileName_FunctionAddress, "SM");
		SetSourceFileName_SM_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceFileName_FunctionAddress, "SM");
		SetSourceFileName_SM_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceFileName_FunctionAddress, "SM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSourceFileName_TargetFileName_PropertyAddress, SetSourceFileName_FunctionAddress, "TargetFileName");
		SetSourceFileName_TargetFileName_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceFileName_FunctionAddress, "TargetFileName");
		SetSourceFileName_TargetFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceFileName_FunctionAddress, "TargetFileName", Classes.FStrProperty);
		SetSourceFileName_IsValid = SetSourceFileName_FunctionAddress != IntPtr.Zero && SetSourceFileName_SM_IsValid && SetSourceFileName_TargetFileName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetSourceFileName", SetSourceFileName_IsValid);
		SetNumStreamedLODs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNumStreamedLODs");
		SetNumStreamedLODs_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumStreamedLODs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumStreamedLODs_StaticMesh_PropertyAddress, SetNumStreamedLODs_FunctionAddress, "StaticMesh");
		SetNumStreamedLODs_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetNumStreamedLODs_FunctionAddress, "StaticMesh");
		SetNumStreamedLODs_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumStreamedLODs_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumStreamedLODs_InNumStreamedLODs_PropertyAddress, SetNumStreamedLODs_FunctionAddress, "InNumStreamedLODs");
		SetNumStreamedLODs_InNumStreamedLODs_Offset = NativeReflectionCached.GetPropertyOffset(SetNumStreamedLODs_FunctionAddress, "InNumStreamedLODs");
		SetNumStreamedLODs_InNumStreamedLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumStreamedLODs_FunctionAddress, "InNumStreamedLODs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumStreamedLODs_ReturnValue_PropertyAddress, SetNumStreamedLODs_FunctionAddress, "ReturnValue");
		SetNumStreamedLODs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNumStreamedLODs_FunctionAddress, "ReturnValue");
		SetNumStreamedLODs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumStreamedLODs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNumStreamedLODs_IsValid = SetNumStreamedLODs_FunctionAddress != IntPtr.Zero && SetNumStreamedLODs_StaticMesh_IsValid && SetNumStreamedLODs_InNumStreamedLODs_IsValid && SetNumStreamedLODs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetNumStreamedLODs", SetNumStreamedLODs_IsValid);
		SetNaniteEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNaniteEnable");
		SetNaniteEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNaniteEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteEnable_StaticMesh_PropertyAddress, SetNaniteEnable_FunctionAddress, "StaticMesh");
		SetNaniteEnable_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteEnable_FunctionAddress, "StaticMesh");
		SetNaniteEnable_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteEnable_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNaniteEnable_NewState_PropertyAddress, SetNaniteEnable_FunctionAddress, "NewState");
		SetNaniteEnable_NewState_Offset = NativeReflectionCached.GetPropertyOffset(SetNaniteEnable_FunctionAddress, "NewState");
		SetNaniteEnable_NewState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNaniteEnable_FunctionAddress, "NewState", Classes.FBoolProperty);
		SetNaniteEnable_IsValid = SetNaniteEnable_FunctionAddress != IntPtr.Zero && SetNaniteEnable_StaticMesh_IsValid && SetNaniteEnable_NewState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetNaniteEnable", SetNaniteEnable_IsValid);
		SetMinLOD_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMinLOD");
		SetMinLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinLOD_StaticMesh_PropertyAddress, SetMinLOD_FunctionAddress, "StaticMesh");
		SetMinLOD_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMinLOD_FunctionAddress, "StaticMesh");
		SetMinLOD_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinLOD_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMinLOD_MinLOD_PropertyAddress, SetMinLOD_FunctionAddress, "MinLOD");
		SetMinLOD_MinLOD_Offset = NativeReflectionCached.GetPropertyOffset(SetMinLOD_FunctionAddress, "MinLOD");
		SetMinLOD_MinLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinLOD_FunctionAddress, "MinLOD", Classes.FIntProperty);
		SetMinLOD_IsValid = SetMinLOD_FunctionAddress != IntPtr.Zero && SetMinLOD_StaticMesh_IsValid && SetMinLOD_MinLOD_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetMinLOD", SetMinLOD_IsValid);
		SetDestructibleMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDestructibleMesh");
		SetDestructibleMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDestructibleMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDestructibleMesh_BPO_PropertyAddress, SetDestructibleMesh_FunctionAddress, "BPO");
		SetDestructibleMesh_BPO_Offset = NativeReflectionCached.GetPropertyOffset(SetDestructibleMesh_FunctionAddress, "BPO");
		SetDestructibleMesh_BPO_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDestructibleMesh_FunctionAddress, "BPO", Classes.FObjectProperty);
		SetDestructibleMesh_IsValid = SetDestructibleMesh_FunctionAddress != IntPtr.Zero && SetDestructibleMesh_BPO_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:SetDestructibleMesh", SetDestructibleMesh_IsValid);
		ResetGeometryCollection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetGeometryCollection");
		ResetGeometryCollection_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetGeometryCollection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetGeometryCollection_GeometryCollectionComponent_PropertyAddress, ResetGeometryCollection_FunctionAddress, "GeometryCollectionComponent");
		ResetGeometryCollection_GeometryCollectionComponent_Offset = NativeReflectionCached.GetPropertyOffset(ResetGeometryCollection_FunctionAddress, "GeometryCollectionComponent");
		ResetGeometryCollection_GeometryCollectionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetGeometryCollection_FunctionAddress, "GeometryCollectionComponent", Classes.FObjectProperty);
		ResetGeometryCollection_IsValid = ResetGeometryCollection_FunctionAddress != IntPtr.Zero && ResetGeometryCollection_GeometryCollectionComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ResetGeometryCollection", ResetGeometryCollection_IsValid);
		ReplaceSourceFileName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceSourceFileName");
		ReplaceSourceFileName_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceSourceFileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSourceFileName_SM_PropertyAddress, ReplaceSourceFileName_FunctionAddress, "SM");
		ReplaceSourceFileName_SM_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSourceFileName_FunctionAddress, "SM");
		ReplaceSourceFileName_SM_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSourceFileName_FunctionAddress, "SM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSourceFileName_Src_PropertyAddress, ReplaceSourceFileName_FunctionAddress, "Src");
		ReplaceSourceFileName_Src_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSourceFileName_FunctionAddress, "Src");
		ReplaceSourceFileName_Src_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSourceFileName_FunctionAddress, "Src", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSourceFileName_Target_PropertyAddress, ReplaceSourceFileName_FunctionAddress, "Target");
		ReplaceSourceFileName_Target_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSourceFileName_FunctionAddress, "Target");
		ReplaceSourceFileName_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSourceFileName_FunctionAddress, "Target", Classes.FStrProperty);
		ReplaceSourceFileName_IsValid = ReplaceSourceFileName_FunctionAddress != IntPtr.Zero && ReplaceSourceFileName_SM_IsValid && ReplaceSourceFileName_Src_IsValid && ReplaceSourceFileName_Target_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ReplaceSourceFileName", ReplaceSourceFileName_IsValid);
		ReplaceLodSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceLodSections");
		ReplaceLodSections_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceLodSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceLodSections_StaticMesh_PropertyAddress, ReplaceLodSections_FunctionAddress, "StaticMesh");
		ReplaceLodSections_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceLodSections_FunctionAddress, "StaticMesh");
		ReplaceLodSections_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceLodSections_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceLodSections_LODIndex_PropertyAddress, ReplaceLodSections_FunctionAddress, "LODIndex");
		ReplaceLodSections_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceLodSections_FunctionAddress, "LODIndex");
		ReplaceLodSections_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceLodSections_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceLodSections_SectionIDMap_PropertyAddress, ReplaceLodSections_FunctionAddress, "SectionIDMap");
		ReplaceLodSections_SectionIDMap_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceLodSections_FunctionAddress, "SectionIDMap");
		ReplaceLodSections_SectionIDMap_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceLodSections_FunctionAddress, "SectionIDMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceLodSections_ReturnValue_PropertyAddress, ReplaceLodSections_FunctionAddress, "ReturnValue");
		ReplaceLodSections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceLodSections_FunctionAddress, "ReturnValue");
		ReplaceLodSections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceLodSections_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReplaceLodSections_IsValid = ReplaceLodSections_FunctionAddress != IntPtr.Zero && ReplaceLodSections_StaticMesh_IsValid && ReplaceLodSections_LODIndex_IsValid && ReplaceLodSections_SectionIDMap_IsValid && ReplaceLodSections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ReplaceLodSections", ReplaceLodSections_IsValid);
		QuickHullByDefaultHACD_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QuickHullByDefaultHACD");
		QuickHullByDefaultHACD_ParamsSize = NativeReflection.GetFunctionParamsSize(QuickHullByDefaultHACD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QuickHullByDefaultHACD_InStaticMesh_PropertyAddress, QuickHullByDefaultHACD_FunctionAddress, "InStaticMesh");
		QuickHullByDefaultHACD_InStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(QuickHullByDefaultHACD_FunctionAddress, "InStaticMesh");
		QuickHullByDefaultHACD_InStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHullByDefaultHACD_FunctionAddress, "InStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHullByDefaultHACD_Vertexs_PropertyAddress, QuickHullByDefaultHACD_FunctionAddress, "Vertexs");
		QuickHullByDefaultHACD_Vertexs_Offset = NativeReflectionCached.GetPropertyOffset(QuickHullByDefaultHACD_FunctionAddress, "Vertexs");
		QuickHullByDefaultHACD_Vertexs_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHullByDefaultHACD_FunctionAddress, "Vertexs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHullByDefaultHACD_InIndices_PropertyAddress, QuickHullByDefaultHACD_FunctionAddress, "InIndices");
		QuickHullByDefaultHACD_InIndices_Offset = NativeReflectionCached.GetPropertyOffset(QuickHullByDefaultHACD_FunctionAddress, "InIndices");
		QuickHullByDefaultHACD_InIndices_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHullByDefaultHACD_FunctionAddress, "InIndices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHullByDefaultHACD_InHullCount_PropertyAddress, QuickHullByDefaultHACD_FunctionAddress, "InHullCount");
		QuickHullByDefaultHACD_InHullCount_Offset = NativeReflectionCached.GetPropertyOffset(QuickHullByDefaultHACD_FunctionAddress, "InHullCount");
		QuickHullByDefaultHACD_InHullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHullByDefaultHACD_FunctionAddress, "InHullCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHullByDefaultHACD_InMaxHullVerts_PropertyAddress, QuickHullByDefaultHACD_FunctionAddress, "InMaxHullVerts");
		QuickHullByDefaultHACD_InMaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(QuickHullByDefaultHACD_FunctionAddress, "InMaxHullVerts");
		QuickHullByDefaultHACD_InMaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHullByDefaultHACD_FunctionAddress, "InMaxHullVerts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHullByDefaultHACD_InResolution_PropertyAddress, QuickHullByDefaultHACD_FunctionAddress, "InResolution");
		QuickHullByDefaultHACD_InResolution_Offset = NativeReflectionCached.GetPropertyOffset(QuickHullByDefaultHACD_FunctionAddress, "InResolution");
		QuickHullByDefaultHACD_InResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHullByDefaultHACD_FunctionAddress, "InResolution", Classes.FIntProperty);
		QuickHullByDefaultHACD_IsValid = QuickHullByDefaultHACD_FunctionAddress != IntPtr.Zero && QuickHullByDefaultHACD_InStaticMesh_IsValid && QuickHullByDefaultHACD_Vertexs_IsValid && QuickHullByDefaultHACD_InIndices_IsValid && QuickHullByDefaultHACD_InHullCount_IsValid && QuickHullByDefaultHACD_InMaxHullVerts_IsValid && QuickHullByDefaultHACD_InResolution_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:QuickHullByDefaultHACD", QuickHullByDefaultHACD_IsValid);
		QuickHull_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QuickHull");
		QuickHull_ParamsSize = NativeReflection.GetFunctionParamsSize(QuickHull_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QuickHull_Vertexs_PropertyAddress, QuickHull_FunctionAddress, "Vertexs");
		QuickHull_Vertexs_Offset = NativeReflectionCached.GetPropertyOffset(QuickHull_FunctionAddress, "Vertexs");
		QuickHull_Vertexs_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHull_FunctionAddress, "Vertexs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHull_CleanVertexRemap_PropertyAddress, QuickHull_FunctionAddress, "CleanVertexRemap");
		QuickHull_CleanVertexRemap_Offset = NativeReflectionCached.GetPropertyOffset(QuickHull_FunctionAddress, "CleanVertexRemap");
		QuickHull_CleanVertexRemap_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHull_FunctionAddress, "CleanVertexRemap", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHull_MinCell_PropertyAddress, QuickHull_FunctionAddress, "MinCell");
		QuickHull_MinCell_Offset = NativeReflectionCached.GetPropertyOffset(QuickHull_FunctionAddress, "MinCell");
		QuickHull_MinCell_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHull_FunctionAddress, "MinCell", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref QuickHull_ReturnValue_PropertyAddress, QuickHull_FunctionAddress, "ReturnValue");
		QuickHull_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QuickHull_FunctionAddress, "ReturnValue");
		QuickHull_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QuickHull_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		QuickHull_IsValid = QuickHull_FunctionAddress != IntPtr.Zero && QuickHull_Vertexs_IsValid && QuickHull_CleanVertexRemap_IsValid && QuickHull_MinCell_IsValid && QuickHull_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:QuickHull", QuickHull_IsValid);
		PrintStaticMeshesDFInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrintStaticMeshesDFInfo");
		PrintStaticMeshesDFInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintStaticMeshesDFInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_PropertyAddress, PrintStaticMeshesDFInfo_FunctionAddress, "TxtFilePathContainsStaticMeshList");
		PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_Offset = NativeReflectionCached.GetPropertyOffset(PrintStaticMeshesDFInfo_FunctionAddress, "TxtFilePathContainsStaticMeshList");
		PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_IsValid = NativeReflectionCached.ValidatePropertyClass(PrintStaticMeshesDFInfo_FunctionAddress, "TxtFilePathContainsStaticMeshList", Classes.FStrProperty);
		PrintStaticMeshesDFInfo_IsValid = PrintStaticMeshesDFInfo_FunctionAddress != IntPtr.Zero && PrintStaticMeshesDFInfo_TxtFilePathContainsStaticMeshList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:PrintStaticMeshesDFInfo", PrintStaticMeshesDFInfo_IsValid);
		MergeSameSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MergeSameSections");
		MergeSameSections_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeSameSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeSameSections_StaticMesh_PropertyAddress, MergeSameSections_FunctionAddress, "StaticMesh");
		MergeSameSections_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(MergeSameSections_FunctionAddress, "StaticMesh");
		MergeSameSections_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeSameSections_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		MergeSameSections_IsValid = MergeSameSections_FunctionAddress != IntPtr.Zero && MergeSameSections_StaticMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:MergeSameSections", MergeSameSections_IsValid);
		IsNaniteEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNaniteEnable");
		IsNaniteEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNaniteEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNaniteEnable_StaticMesh_PropertyAddress, IsNaniteEnable_FunctionAddress, "StaticMesh");
		IsNaniteEnable_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsNaniteEnable_FunctionAddress, "StaticMesh");
		IsNaniteEnable_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNaniteEnable_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNaniteEnable_ReturnValue_PropertyAddress, IsNaniteEnable_FunctionAddress, "ReturnValue");
		IsNaniteEnable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNaniteEnable_FunctionAddress, "ReturnValue");
		IsNaniteEnable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNaniteEnable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNaniteEnable_IsValid = IsNaniteEnable_FunctionAddress != IntPtr.Zero && IsNaniteEnable_StaticMesh_IsValid && IsNaniteEnable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:IsNaniteEnable", IsNaniteEnable_IsValid);
		ImportDMChunks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportDMChunks");
		ImportDMChunks_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportDMChunks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportDMChunks_DestructibleMesh_PropertyAddress, ImportDMChunks_FunctionAddress, "DestructibleMesh");
		ImportDMChunks_DestructibleMesh_Offset = NativeReflectionCached.GetPropertyOffset(ImportDMChunks_FunctionAddress, "DestructibleMesh");
		ImportDMChunks_DestructibleMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportDMChunks_FunctionAddress, "DestructibleMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportDMChunks_ImportFilename_PropertyAddress, ImportDMChunks_FunctionAddress, "ImportFilename");
		ImportDMChunks_ImportFilename_Offset = NativeReflectionCached.GetPropertyOffset(ImportDMChunks_FunctionAddress, "ImportFilename");
		ImportDMChunks_ImportFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportDMChunks_FunctionAddress, "ImportFilename", Classes.FStrProperty);
		ImportDMChunks_IsValid = ImportDMChunks_FunctionAddress != IntPtr.Zero && ImportDMChunks_DestructibleMesh_IsValid && ImportDMChunks_ImportFilename_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ImportDMChunks", ImportDMChunks_IsValid);
		GetStaticMeshVertexNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshVertexNum");
		GetStaticMeshVertexNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshVertexNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshVertexNum_StaticMesh_PropertyAddress, GetStaticMeshVertexNum_FunctionAddress, "StaticMesh");
		GetStaticMeshVertexNum_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshVertexNum_FunctionAddress, "StaticMesh");
		GetStaticMeshVertexNum_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshVertexNum_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshVertexNum_LOD_PropertyAddress, GetStaticMeshVertexNum_FunctionAddress, "LOD");
		GetStaticMeshVertexNum_LOD_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshVertexNum_FunctionAddress, "LOD");
		GetStaticMeshVertexNum_LOD_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshVertexNum_FunctionAddress, "LOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshVertexNum_ReturnValue_PropertyAddress, GetStaticMeshVertexNum_FunctionAddress, "ReturnValue");
		GetStaticMeshVertexNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshVertexNum_FunctionAddress, "ReturnValue");
		GetStaticMeshVertexNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshVertexNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStaticMeshVertexNum_IsValid = GetStaticMeshVertexNum_FunctionAddress != IntPtr.Zero && GetStaticMeshVertexNum_StaticMesh_IsValid && GetStaticMeshVertexNum_LOD_IsValid && GetStaticMeshVertexNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshVertexNum", GetStaticMeshVertexNum_IsValid);
		GetStaticMeshVertexColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshVertexColor");
		GetStaticMeshVertexColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshVertexColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshVertexColor_StaticMesh_PropertyAddress, GetStaticMeshVertexColor_FunctionAddress, "StaticMesh");
		GetStaticMeshVertexColor_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshVertexColor_FunctionAddress, "StaticMesh");
		GetStaticMeshVertexColor_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshVertexColor_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshVertexColor_ReturnValue_PropertyAddress, GetStaticMeshVertexColor_FunctionAddress, "ReturnValue");
		GetStaticMeshVertexColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshVertexColor_FunctionAddress, "ReturnValue");
		GetStaticMeshVertexColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshVertexColor_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetStaticMeshVertexColor_IsValid = GetStaticMeshVertexColor_FunctionAddress != IntPtr.Zero && GetStaticMeshVertexColor_StaticMesh_IsValid && GetStaticMeshVertexColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshVertexColor", GetStaticMeshVertexColor_IsValid);
		GetStaticMeshTrianglesNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshTrianglesNum");
		GetStaticMeshTrianglesNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshTrianglesNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshTrianglesNum_StaticMesh_PropertyAddress, GetStaticMeshTrianglesNum_FunctionAddress, "StaticMesh");
		GetStaticMeshTrianglesNum_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshTrianglesNum_FunctionAddress, "StaticMesh");
		GetStaticMeshTrianglesNum_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshTrianglesNum_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshTrianglesNum_LOD_PropertyAddress, GetStaticMeshTrianglesNum_FunctionAddress, "LOD");
		GetStaticMeshTrianglesNum_LOD_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshTrianglesNum_FunctionAddress, "LOD");
		GetStaticMeshTrianglesNum_LOD_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshTrianglesNum_FunctionAddress, "LOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshTrianglesNum_ReturnValue_PropertyAddress, GetStaticMeshTrianglesNum_FunctionAddress, "ReturnValue");
		GetStaticMeshTrianglesNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshTrianglesNum_FunctionAddress, "ReturnValue");
		GetStaticMeshTrianglesNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshTrianglesNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStaticMeshTrianglesNum_IsValid = GetStaticMeshTrianglesNum_FunctionAddress != IntPtr.Zero && GetStaticMeshTrianglesNum_StaticMesh_IsValid && GetStaticMeshTrianglesNum_LOD_IsValid && GetStaticMeshTrianglesNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshTrianglesNum", GetStaticMeshTrianglesNum_IsValid);
		GetStaticMeshConvexCollisionTriangleNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshConvexCollisionTriangleNum");
		GetStaticMeshConvexCollisionTriangleNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshConvexCollisionTriangleNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshConvexCollisionTriangleNum_StaticMesh_PropertyAddress, GetStaticMeshConvexCollisionTriangleNum_FunctionAddress, "StaticMesh");
		GetStaticMeshConvexCollisionTriangleNum_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshConvexCollisionTriangleNum_FunctionAddress, "StaticMesh");
		GetStaticMeshConvexCollisionTriangleNum_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshConvexCollisionTriangleNum_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshConvexCollisionTriangleNum_ReturnValue_PropertyAddress, GetStaticMeshConvexCollisionTriangleNum_FunctionAddress, "ReturnValue");
		GetStaticMeshConvexCollisionTriangleNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshConvexCollisionTriangleNum_FunctionAddress, "ReturnValue");
		GetStaticMeshConvexCollisionTriangleNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshConvexCollisionTriangleNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStaticMeshConvexCollisionTriangleNum_IsValid = GetStaticMeshConvexCollisionTriangleNum_FunctionAddress != IntPtr.Zero && GetStaticMeshConvexCollisionTriangleNum_StaticMesh_IsValid && GetStaticMeshConvexCollisionTriangleNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshConvexCollisionTriangleNum", GetStaticMeshConvexCollisionTriangleNum_IsValid);
		GetStaticMeshComponentsVertex3f_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshComponentsVertex3f");
		GetStaticMeshComponentsVertex3f_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshComponentsVertex3f_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex3f_StaticMeshComponents_PropertyAddress, GetStaticMeshComponentsVertex3f_FunctionAddress, "StaticMeshComponents");
		GetStaticMeshComponentsVertex3f_StaticMeshComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex3f_FunctionAddress, "StaticMeshComponents");
		GetStaticMeshComponentsVertex3f_StaticMeshComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex3f_FunctionAddress, "StaticMeshComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex3f_Index_PropertyAddress, GetStaticMeshComponentsVertex3f_FunctionAddress, "Index");
		GetStaticMeshComponentsVertex3f_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex3f_FunctionAddress, "Index");
		GetStaticMeshComponentsVertex3f_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex3f_FunctionAddress, "Index", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex3f_Center_PropertyAddress, GetStaticMeshComponentsVertex3f_FunctionAddress, "Center");
		GetStaticMeshComponentsVertex3f_Center_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex3f_FunctionAddress, "Center");
		GetStaticMeshComponentsVertex3f_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex3f_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex3f_ReturnValue_PropertyAddress, GetStaticMeshComponentsVertex3f_FunctionAddress, "ReturnValue");
		GetStaticMeshComponentsVertex3f_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex3f_FunctionAddress, "ReturnValue");
		GetStaticMeshComponentsVertex3f_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex3f_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetStaticMeshComponentsVertex3f_IsValid = GetStaticMeshComponentsVertex3f_FunctionAddress != IntPtr.Zero && GetStaticMeshComponentsVertex3f_StaticMeshComponents_IsValid && GetStaticMeshComponentsVertex3f_Index_IsValid && GetStaticMeshComponentsVertex3f_Center_IsValid && GetStaticMeshComponentsVertex3f_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshComponentsVertex3f", GetStaticMeshComponentsVertex3f_IsValid);
		GetStaticMeshComponentsVertex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshComponentsVertex");
		GetStaticMeshComponentsVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshComponentsVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex_StaticMeshComponents_PropertyAddress, GetStaticMeshComponentsVertex_FunctionAddress, "StaticMeshComponents");
		GetStaticMeshComponentsVertex_StaticMeshComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex_FunctionAddress, "StaticMeshComponents");
		GetStaticMeshComponentsVertex_StaticMeshComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex_FunctionAddress, "StaticMeshComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex_Index_PropertyAddress, GetStaticMeshComponentsVertex_FunctionAddress, "Index");
		GetStaticMeshComponentsVertex_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex_FunctionAddress, "Index");
		GetStaticMeshComponentsVertex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex_FunctionAddress, "Index", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex_Center_PropertyAddress, GetStaticMeshComponentsVertex_FunctionAddress, "Center");
		GetStaticMeshComponentsVertex_Center_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex_FunctionAddress, "Center");
		GetStaticMeshComponentsVertex_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshComponentsVertex_ReturnValue_PropertyAddress, GetStaticMeshComponentsVertex_FunctionAddress, "ReturnValue");
		GetStaticMeshComponentsVertex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshComponentsVertex_FunctionAddress, "ReturnValue");
		GetStaticMeshComponentsVertex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshComponentsVertex_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetStaticMeshComponentsVertex_IsValid = GetStaticMeshComponentsVertex_FunctionAddress != IntPtr.Zero && GetStaticMeshComponentsVertex_StaticMeshComponents_IsValid && GetStaticMeshComponentsVertex_Index_IsValid && GetStaticMeshComponentsVertex_Center_IsValid && GetStaticMeshComponentsVertex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetStaticMeshComponentsVertex", GetStaticMeshComponentsVertex_IsValid);
		GetNaniteVertexes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNaniteVertexes");
		GetNaniteVertexes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNaniteVertexes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNaniteVertexes_StaticMesh_PropertyAddress, GetNaniteVertexes_FunctionAddress, "StaticMesh");
		GetNaniteVertexes_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNaniteVertexes_FunctionAddress, "StaticMesh");
		GetNaniteVertexes_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNaniteVertexes_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNaniteVertexes_ReturnValue_PropertyAddress, GetNaniteVertexes_FunctionAddress, "ReturnValue");
		GetNaniteVertexes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNaniteVertexes_FunctionAddress, "ReturnValue");
		GetNaniteVertexes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNaniteVertexes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNaniteVertexes_IsValid = GetNaniteVertexes_FunctionAddress != IntPtr.Zero && GetNaniteVertexes_StaticMesh_IsValid && GetNaniteVertexes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetNaniteVertexes", GetNaniteVertexes_IsValid);
		GetNaniteTriangles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNaniteTriangles");
		GetNaniteTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNaniteTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNaniteTriangles_StaticMesh_PropertyAddress, GetNaniteTriangles_FunctionAddress, "StaticMesh");
		GetNaniteTriangles_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNaniteTriangles_FunctionAddress, "StaticMesh");
		GetNaniteTriangles_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNaniteTriangles_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNaniteTriangles_ReturnValue_PropertyAddress, GetNaniteTriangles_FunctionAddress, "ReturnValue");
		GetNaniteTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNaniteTriangles_FunctionAddress, "ReturnValue");
		GetNaniteTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNaniteTriangles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNaniteTriangles_IsValid = GetNaniteTriangles_FunctionAddress != IntPtr.Zero && GetNaniteTriangles_StaticMesh_IsValid && GetNaniteTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetNaniteTriangles", GetNaniteTriangles_IsValid);
		GetConvexCollisionVertex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetConvexCollisionVertex");
		GetConvexCollisionVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConvexCollisionVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConvexCollisionVertex_StaticMesh_PropertyAddress, GetConvexCollisionVertex_FunctionAddress, "StaticMesh");
		GetConvexCollisionVertex_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetConvexCollisionVertex_FunctionAddress, "StaticMesh");
		GetConvexCollisionVertex_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConvexCollisionVertex_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConvexCollisionVertex_Index_PropertyAddress, GetConvexCollisionVertex_FunctionAddress, "Index");
		GetConvexCollisionVertex_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetConvexCollisionVertex_FunctionAddress, "Index");
		GetConvexCollisionVertex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConvexCollisionVertex_FunctionAddress, "Index", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConvexCollisionVertex_ReturnValue_PropertyAddress, GetConvexCollisionVertex_FunctionAddress, "ReturnValue");
		GetConvexCollisionVertex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConvexCollisionVertex_FunctionAddress, "ReturnValue");
		GetConvexCollisionVertex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConvexCollisionVertex_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetConvexCollisionVertex_IsValid = GetConvexCollisionVertex_FunctionAddress != IntPtr.Zero && GetConvexCollisionVertex_StaticMesh_IsValid && GetConvexCollisionVertex_Index_IsValid && GetConvexCollisionVertex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetConvexCollisionVertex", GetConvexCollisionVertex_IsValid);
		GetCDOStaticMeshComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCDOStaticMeshComponents");
		GetCDOStaticMeshComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCDOStaticMeshComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCDOStaticMeshComponents_ActorClass_PropertyAddress, GetCDOStaticMeshComponents_FunctionAddress, "ActorClass");
		GetCDOStaticMeshComponents_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(GetCDOStaticMeshComponents_FunctionAddress, "ActorClass");
		GetCDOStaticMeshComponents_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDOStaticMeshComponents_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCDOStaticMeshComponents_ReturnValue_PropertyAddress, GetCDOStaticMeshComponents_FunctionAddress, "ReturnValue");
		GetCDOStaticMeshComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCDOStaticMeshComponents_FunctionAddress, "ReturnValue");
		GetCDOStaticMeshComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDOStaticMeshComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCDOStaticMeshComponents_IsValid = GetCDOStaticMeshComponents_FunctionAddress != IntPtr.Zero && GetCDOStaticMeshComponents_ActorClass_IsValid && GetCDOStaticMeshComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:GetCDOStaticMeshComponents", GetCDOStaticMeshComponents_IsValid);
		FinishPhysicsSim_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FinishPhysicsSim");
		FinishPhysicsSim_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishPhysicsSim_FunctionAddress);
		FinishPhysicsSim_IsValid = FinishPhysicsSim_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:FinishPhysicsSim", FinishPhysicsSim_IsValid);
		DisableStaticMeshCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableStaticMeshCollision");
		DisableStaticMeshCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableStaticMeshCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableStaticMeshCollision_InSM_PropertyAddress, DisableStaticMeshCollision_FunctionAddress, "InSM");
		DisableStaticMeshCollision_InSM_Offset = NativeReflectionCached.GetPropertyOffset(DisableStaticMeshCollision_FunctionAddress, "InSM");
		DisableStaticMeshCollision_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableStaticMeshCollision_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableStaticMeshCollision_ReturnValue_PropertyAddress, DisableStaticMeshCollision_FunctionAddress, "ReturnValue");
		DisableStaticMeshCollision_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DisableStaticMeshCollision_FunctionAddress, "ReturnValue");
		DisableStaticMeshCollision_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableStaticMeshCollision_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DisableStaticMeshCollision_IsValid = DisableStaticMeshCollision_FunctionAddress != IntPtr.Zero && DisableStaticMeshCollision_InSM_IsValid && DisableStaticMeshCollision_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:DisableStaticMeshCollision", DisableStaticMeshCollision_IsValid);
		DisableNavData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableNavData");
		DisableNavData_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableNavData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableNavData_InSM_PropertyAddress, DisableNavData_FunctionAddress, "InSM");
		DisableNavData_InSM_Offset = NativeReflectionCached.GetPropertyOffset(DisableNavData_FunctionAddress, "InSM");
		DisableNavData_InSM_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableNavData_FunctionAddress, "InSM", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableNavData_ReturnValue_PropertyAddress, DisableNavData_FunctionAddress, "ReturnValue");
		DisableNavData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DisableNavData_FunctionAddress, "ReturnValue");
		DisableNavData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableNavData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DisableNavData_IsValid = DisableNavData_FunctionAddress != IntPtr.Zero && DisableNavData_InSM_IsValid && DisableNavData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:DisableNavData", DisableNavData_IsValid);
		ClickFractureButton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClickFractureButton");
		ClickFractureButton_ParamsSize = NativeReflection.GetFunctionParamsSize(ClickFractureButton_FunctionAddress);
		ClickFractureButton_IsValid = ClickFractureButton_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ClickFractureButton", ClickFractureButton_IsValid);
		ApplyCustomPrimitiveDataValues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyCustomPrimitiveDataValues");
		ApplyCustomPrimitiveDataValues_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyCustomPrimitiveDataValues_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyCustomPrimitiveDataValues_InSMComponent_PropertyAddress, ApplyCustomPrimitiveDataValues_FunctionAddress, "InSMComponent");
		ApplyCustomPrimitiveDataValues_InSMComponent_Offset = NativeReflectionCached.GetPropertyOffset(ApplyCustomPrimitiveDataValues_FunctionAddress, "InSMComponent");
		ApplyCustomPrimitiveDataValues_InSMComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyCustomPrimitiveDataValues_FunctionAddress, "InSMComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyCustomPrimitiveDataValues_InDataArray_PropertyAddress, ApplyCustomPrimitiveDataValues_FunctionAddress, "InDataArray");
		ApplyCustomPrimitiveDataValues_InDataArray_Offset = NativeReflectionCached.GetPropertyOffset(ApplyCustomPrimitiveDataValues_FunctionAddress, "InDataArray");
		ApplyCustomPrimitiveDataValues_InDataArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyCustomPrimitiveDataValues_FunctionAddress, "InDataArray", Classes.FArrayProperty);
		ApplyCustomPrimitiveDataValues_IsValid = ApplyCustomPrimitiveDataValues_FunctionAddress != IntPtr.Zero && ApplyCustomPrimitiveDataValues_InSMComponent_IsValid && ApplyCustomPrimitiveDataValues_InDataArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshLibrary:ApplyCustomPrimitiveDataValues", ApplyCustomPrimitiveDataValues_IsValid);
	}
}
