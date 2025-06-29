using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UnrealEd;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptEditorEngineLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_Engine_IsValid;

	private static FFieldAddress SetMaterial_Engine_PropertyAddress;

	private static int SetMaterial_Engine_Offset;

	private static bool SetMaterial_InModel_IsValid;

	private static FFieldAddress SetMaterial_InModel_PropertyAddress;

	private static int SetMaterial_InModel_Offset;

	private static bool SetMaterial_Material_IsValid;

	private static FFieldAddress SetMaterial_Material_PropertyAddress;

	private static int SetMaterial_Material_Offset;

	private static bool SetMaterial_Surfaces_IsValid;

	private static FFieldAddress SetMaterial_Surfaces_PropertyAddress;

	private static int SetMaterial_Surfaces_Offset;

	private static bool SelectNone_IsValid;

	private static IntPtr SelectNone_FunctionAddress;

	private static int SelectNone_ParamsSize;

	private static bool SelectNone_Engine_IsValid;

	private static FFieldAddress SelectNone_Engine_PropertyAddress;

	private static int SelectNone_Engine_Offset;

	private static bool SelectNone_bNoteSelectionChange_IsValid;

	private static FFieldAddress SelectNone_bNoteSelectionChange_PropertyAddress;

	private static int SelectNone_bNoteSelectionChange_Offset;

	private static bool SelectNone_bDeselectBSPSurfs_IsValid;

	private static FFieldAddress SelectNone_bDeselectBSPSurfs_PropertyAddress;

	private static int SelectNone_bDeselectBSPSurfs_Offset;

	private static bool SelectNone_WarnAboutManyActors_IsValid;

	private static FFieldAddress SelectNone_WarnAboutManyActors_PropertyAddress;

	private static int SelectNone_WarnAboutManyActors_Offset;

	private static bool SelectGroup_IsValid;

	private static IntPtr SelectGroup_FunctionAddress;

	private static int SelectGroup_ParamsSize;

	private static bool SelectGroup_Engine_IsValid;

	private static FFieldAddress SelectGroup_Engine_PropertyAddress;

	private static int SelectGroup_Engine_Offset;

	private static bool SelectGroup_InGroupActor_IsValid;

	private static FFieldAddress SelectGroup_InGroupActor_PropertyAddress;

	private static int SelectGroup_InGroupActor_Offset;

	private static bool SelectGroup_bForceSelection_IsValid;

	private static FFieldAddress SelectGroup_bForceSelection_PropertyAddress;

	private static int SelectGroup_bForceSelection_Offset;

	private static bool SelectGroup_bInSelected_IsValid;

	private static FFieldAddress SelectGroup_bInSelected_PropertyAddress;

	private static int SelectGroup_bInSelected_Offset;

	private static bool SelectGroup_bNotify_IsValid;

	private static FFieldAddress SelectGroup_bNotify_PropertyAddress;

	private static int SelectGroup_bNotify_Offset;

	private static bool SelectComponent_IsValid;

	private static IntPtr SelectComponent_FunctionAddress;

	private static int SelectComponent_ParamsSize;

	private static bool SelectComponent_Engine_IsValid;

	private static FFieldAddress SelectComponent_Engine_PropertyAddress;

	private static int SelectComponent_Engine_Offset;

	private static bool SelectComponent_Component_IsValid;

	private static FFieldAddress SelectComponent_Component_PropertyAddress;

	private static int SelectComponent_Component_Offset;

	private static bool SelectComponent_bInSelected_IsValid;

	private static FFieldAddress SelectComponent_bInSelected_PropertyAddress;

	private static int SelectComponent_bInSelected_Offset;

	private static bool SelectComponent_bNotify_IsValid;

	private static FFieldAddress SelectComponent_bNotify_PropertyAddress;

	private static int SelectComponent_bNotify_Offset;

	private static bool SelectComponent_bSelectEvenIfHidden_IsValid;

	private static FFieldAddress SelectComponent_bSelectEvenIfHidden_PropertyAddress;

	private static int SelectComponent_bSelectEvenIfHidden_Offset;

	private static bool SelectActor_IsValid;

	private static IntPtr SelectActor_FunctionAddress;

	private static int SelectActor_ParamsSize;

	private static bool SelectActor_Engine_IsValid;

	private static FFieldAddress SelectActor_Engine_PropertyAddress;

	private static int SelectActor_Engine_Offset;

	private static bool SelectActor_Actor_IsValid;

	private static FFieldAddress SelectActor_Actor_PropertyAddress;

	private static int SelectActor_Actor_Offset;

	private static bool SelectActor_bInSelected_IsValid;

	private static FFieldAddress SelectActor_bInSelected_PropertyAddress;

	private static int SelectActor_bInSelected_Offset;

	private static bool SelectActor_bNotify_IsValid;

	private static FFieldAddress SelectActor_bNotify_PropertyAddress;

	private static int SelectActor_bNotify_Offset;

	private static bool SelectActor_bSelectEvenIfHidden_IsValid;

	private static FFieldAddress SelectActor_bSelectEvenIfHidden_PropertyAddress;

	private static int SelectActor_bSelectEvenIfHidden_Offset;

	private static bool SelectActor_bForceRefresh_IsValid;

	private static FFieldAddress SelectActor_bForceRefresh_PropertyAddress;

	private static int SelectActor_bForceRefresh_Offset;

	private static bool RedrawAllViewports_IsValid;

	private static IntPtr RedrawAllViewports_FunctionAddress;

	private static int RedrawAllViewports_ParamsSize;

	private static bool RedrawAllViewports_Engine_IsValid;

	private static FFieldAddress RedrawAllViewports_Engine_PropertyAddress;

	private static int RedrawAllViewports_Engine_Offset;

	private static bool RedrawAllViewports_bInvalidateHitProxies_IsValid;

	private static FFieldAddress RedrawAllViewports_bInvalidateHitProxies_PropertyAddress;

	private static int RedrawAllViewports_bInvalidateHitProxies_Offset;

	private static bool RebuildStaticNavigableGeometry_IsValid;

	private static IntPtr RebuildStaticNavigableGeometry_FunctionAddress;

	private static int RebuildStaticNavigableGeometry_ParamsSize;

	private static bool RebuildStaticNavigableGeometry_Engine_IsValid;

	private static FFieldAddress RebuildStaticNavigableGeometry_Engine_PropertyAddress;

	private static int RebuildStaticNavigableGeometry_Engine_Offset;

	private static bool RebuildStaticNavigableGeometry_Level_IsValid;

	private static FFieldAddress RebuildStaticNavigableGeometry_Level_PropertyAddress;

	private static int RebuildStaticNavigableGeometry_Level_Offset;

	private static bool RebuildLevel_IsValid;

	private static IntPtr RebuildLevel_FunctionAddress;

	private static int RebuildLevel_ParamsSize;

	private static bool RebuildLevel_Engine_IsValid;

	private static FFieldAddress RebuildLevel_Engine_PropertyAddress;

	private static int RebuildLevel_Engine_Offset;

	private static bool RebuildLevel_Level_IsValid;

	private static FFieldAddress RebuildLevel_Level_PropertyAddress;

	private static int RebuildLevel_Level_Offset;

	private static bool GetSurfaces_IsValid;

	private static IntPtr GetSurfaces_FunctionAddress;

	private static int GetSurfaces_ParamsSize;

	private static bool GetSurfaces_Brush_IsValid;

	private static FFieldAddress GetSurfaces_Brush_PropertyAddress;

	private static int GetSurfaces_Brush_Offset;

	private static bool GetSurfaces_Surfaces_IsValid;

	private static FFieldAddress GetSurfaces_Surfaces_PropertyAddress;

	private static int GetSurfaces_Surfaces_Offset;

	private static bool GetSelectedSet_IsValid;

	private static IntPtr GetSelectedSet_FunctionAddress;

	private static int GetSelectedSet_ParamsSize;

	private static bool GetSelectedSet_Engine_IsValid;

	private static FFieldAddress GetSelectedSet_Engine_PropertyAddress;

	private static int GetSelectedSet_Engine_Offset;

	private static bool GetSelectedSet_Class_IsValid;

	private static FFieldAddress GetSelectedSet_Class_PropertyAddress;

	private static int GetSelectedSet_Class_Offset;

	private static bool GetSelectedSet_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedSet_ReturnValue_PropertyAddress;

	private static int GetSelectedSet_ReturnValue_Offset;

	private static bool GetSelectedObjects_IsValid;

	private static IntPtr GetSelectedObjects_FunctionAddress;

	private static int GetSelectedObjects_ParamsSize;

	private static bool GetSelectedObjects_Engine_IsValid;

	private static FFieldAddress GetSelectedObjects_Engine_PropertyAddress;

	private static int GetSelectedObjects_Engine_Offset;

	private static bool GetSelectedObjects_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedObjects_ReturnValue_PropertyAddress;

	private static int GetSelectedObjects_ReturnValue_Offset;

	private static bool GetSelectedComponents_IsValid;

	private static IntPtr GetSelectedComponents_FunctionAddress;

	private static int GetSelectedComponents_ParamsSize;

	private static bool GetSelectedComponents_Engine_IsValid;

	private static FFieldAddress GetSelectedComponents_Engine_PropertyAddress;

	private static int GetSelectedComponents_Engine_Offset;

	private static bool GetSelectedComponents_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedComponents_ReturnValue_PropertyAddress;

	private static int GetSelectedComponents_ReturnValue_Offset;

	private static bool GetPIEWorld_IsValid;

	private static IntPtr GetPIEWorld_FunctionAddress;

	private static int GetPIEWorld_ParamsSize;

	private static bool GetPIEWorld_Engine_IsValid;

	private static FFieldAddress GetPIEWorld_Engine_PropertyAddress;

	private static int GetPIEWorld_Engine_Offset;

	private static bool GetPIEWorld_ReturnValue_IsValid;

	private static FFieldAddress GetPIEWorld_ReturnValue_PropertyAddress;

	private static int GetPIEWorld_ReturnValue_Offset;

	private static bool GetLongPackagePath_IsValid;

	private static IntPtr GetLongPackagePath_FunctionAddress;

	private static int GetLongPackagePath_ParamsSize;

	private static bool GetLongPackagePath_InPackage_IsValid;

	private static FFieldAddress GetLongPackagePath_InPackage_PropertyAddress;

	private static int GetLongPackagePath_InPackage_Offset;

	private static bool GetLongPackagePath_ReturnValue_IsValid;

	private static FFieldAddress GetLongPackagePath_ReturnValue_PropertyAddress;

	private static int GetLongPackagePath_ReturnValue_Offset;

	private static bool GetLevelViewportCameraInfo_IsValid;

	private static IntPtr GetLevelViewportCameraInfo_FunctionAddress;

	private static int GetLevelViewportCameraInfo_ParamsSize;

	private static bool GetLevelViewportCameraInfo_Engine_IsValid;

	private static FFieldAddress GetLevelViewportCameraInfo_Engine_PropertyAddress;

	private static int GetLevelViewportCameraInfo_Engine_Offset;

	private static bool GetLevelViewportCameraInfo_CameraLocation_IsValid;

	private static FFieldAddress GetLevelViewportCameraInfo_CameraLocation_PropertyAddress;

	private static int GetLevelViewportCameraInfo_CameraLocation_Offset;

	private static bool GetLevelViewportCameraInfo_CameraRotation_IsValid;

	private static FFieldAddress GetLevelViewportCameraInfo_CameraRotation_PropertyAddress;

	private static int GetLevelViewportCameraInfo_CameraRotation_Offset;

	private static bool GetLevelViewportCameraInfo_ReturnValue_IsValid;

	private static FFieldAddress GetLevelViewportCameraInfo_ReturnValue_PropertyAddress;

	private static int GetLevelViewportCameraInfo_ReturnValue_Offset;

	private static bool GetEditorWorld_IsValid;

	private static IntPtr GetEditorWorld_FunctionAddress;

	private static int GetEditorWorld_ParamsSize;

	private static bool GetEditorWorld_Engine_IsValid;

	private static FFieldAddress GetEditorWorld_Engine_PropertyAddress;

	private static int GetEditorWorld_Engine_Offset;

	private static bool GetEditorWorld_ReturnValue_IsValid;

	private static FFieldAddress GetEditorWorld_ReturnValue_PropertyAddress;

	private static int GetEditorWorld_ReturnValue_Offset;

	private static bool FindBrushBuilder_IsValid;

	private static IntPtr FindBrushBuilder_FunctionAddress;

	private static int FindBrushBuilder_ParamsSize;

	private static bool FindBrushBuilder_Engine_IsValid;

	private static FFieldAddress FindBrushBuilder_Engine_PropertyAddress;

	private static int FindBrushBuilder_Engine_Offset;

	private static bool FindBrushBuilder_BrushBuilderClass_IsValid;

	private static FFieldAddress FindBrushBuilder_BrushBuilderClass_PropertyAddress;

	private static int FindBrushBuilder_BrushBuilderClass_Offset;

	private static bool FindBrushBuilder_ReturnValue_IsValid;

	private static FFieldAddress FindBrushBuilder_ReturnValue_PropertyAddress;

	private static int FindBrushBuilder_ReturnValue_Offset;

	private static bool Exec_IsValid;

	private static IntPtr Exec_FunctionAddress;

	private static int Exec_ParamsSize;

	private static bool Exec_Engine_IsValid;

	private static FFieldAddress Exec_Engine_PropertyAddress;

	private static int Exec_Engine_Offset;

	private static bool Exec_InWorld_IsValid;

	private static FFieldAddress Exec_InWorld_PropertyAddress;

	private static int Exec_InWorld_Offset;

	private static bool Exec_Command_IsValid;

	private static FFieldAddress Exec_Command_PropertyAddress;

	private static int Exec_Command_Offset;

	private static bool Exec_Out_IsValid;

	private static FFieldAddress Exec_Out_PropertyAddress;

	private static int Exec_Out_Offset;

	private static bool Exec_ReturnValue_IsValid;

	private static FFieldAddress Exec_ReturnValue_PropertyAddress;

	private static int Exec_ReturnValue_Offset;

	private static bool DuplicateAsset_IsValid;

	private static IntPtr DuplicateAsset_FunctionAddress;

	private static int DuplicateAsset_ParamsSize;

	private static bool DuplicateAsset_AssetName_IsValid;

	private static FFieldAddress DuplicateAsset_AssetName_PropertyAddress;

	private static int DuplicateAsset_AssetName_Offset;

	private static bool DuplicateAsset_PackagePath_IsValid;

	private static FFieldAddress DuplicateAsset_PackagePath_PropertyAddress;

	private static int DuplicateAsset_PackagePath_Offset;

	private static bool DuplicateAsset_OriginalObject_IsValid;

	private static FFieldAddress DuplicateAsset_OriginalObject_PropertyAddress;

	private static int DuplicateAsset_OriginalObject_Offset;

	private static bool DuplicateAsset_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAsset_ReturnValue_PropertyAddress;

	private static int DuplicateAsset_ReturnValue_Offset;

	private static bool DeleteObjectsUnchecked_IsValid;

	private static IntPtr DeleteObjectsUnchecked_FunctionAddress;

	private static int DeleteObjectsUnchecked_ParamsSize;

	private static bool DeleteObjectsUnchecked_ObjectsToDelete_IsValid;

	private static FFieldAddress DeleteObjectsUnchecked_ObjectsToDelete_PropertyAddress;

	private static int DeleteObjectsUnchecked_ObjectsToDelete_Offset;

	private static bool DeleteObjectsUnchecked_ReturnValue_IsValid;

	private static FFieldAddress DeleteObjectsUnchecked_ReturnValue_PropertyAddress;

	private static int DeleteObjectsUnchecked_ReturnValue_Offset;

	private static bool CanSelectActor_IsValid;

	private static IntPtr CanSelectActor_FunctionAddress;

	private static int CanSelectActor_ParamsSize;

	private static bool CanSelectActor_Engine_IsValid;

	private static FFieldAddress CanSelectActor_Engine_PropertyAddress;

	private static int CanSelectActor_Engine_Offset;

	private static bool CanSelectActor_Actor_IsValid;

	private static FFieldAddress CanSelectActor_Actor_PropertyAddress;

	private static int CanSelectActor_Actor_Offset;

	private static bool CanSelectActor_bInSelected_IsValid;

	private static FFieldAddress CanSelectActor_bInSelected_PropertyAddress;

	private static int CanSelectActor_bInSelected_Offset;

	private static bool CanSelectActor_bSelectEvenIfHidden_IsValid;

	private static FFieldAddress CanSelectActor_bSelectEvenIfHidden_PropertyAddress;

	private static int CanSelectActor_bSelectEvenIfHidden_Offset;

	private static bool CanSelectActor_bWarnIfLevelLocked_IsValid;

	private static FFieldAddress CanSelectActor_bWarnIfLevelLocked_PropertyAddress;

	private static int CanSelectActor_bWarnIfLevelLocked_Offset;

	private static bool CanSelectActor_ReturnValue_IsValid;

	private static FFieldAddress CanSelectActor_ReturnValue_PropertyAddress;

	private static int CanSelectActor_ReturnValue_Offset;

	private static bool bspBrushCSG_IsValid;

	private static IntPtr bspBrushCSG_FunctionAddress;

	private static int bspBrushCSG_ParamsSize;

	private static bool bspBrushCSG_Engine_IsValid;

	private static FFieldAddress bspBrushCSG_Engine_PropertyAddress;

	private static int bspBrushCSG_Engine_Offset;

	private static bool bspBrushCSG_Actor_IsValid;

	private static FFieldAddress bspBrushCSG_Actor_PropertyAddress;

	private static int bspBrushCSG_Actor_Offset;

	private static bool bspBrushCSG_Model_IsValid;

	private static FFieldAddress bspBrushCSG_Model_PropertyAddress;

	private static int bspBrushCSG_Model_Offset;

	private static bool bspBrushCSG_PolyFlags_IsValid;

	private static FFieldAddress bspBrushCSG_PolyFlags_PropertyAddress;

	private static int bspBrushCSG_PolyFlags_Offset;

	private static bool bspBrushCSG_BrushType_IsValid;

	private static FFieldAddress bspBrushCSG_BrushType_PropertyAddress;

	private static int bspBrushCSG_BrushType_Offset;

	private static bool bspBrushCSG_CSGOper_IsValid;

	private static FFieldAddress bspBrushCSG_CSGOper_PropertyAddress;

	private static int bspBrushCSG_CSGOper_Offset;

	private static bool bspBrushCSG_bBuildBounds_IsValid;

	private static FFieldAddress bspBrushCSG_bBuildBounds_PropertyAddress;

	private static int bspBrushCSG_bBuildBounds_Offset;

	private static bool bspBrushCSG_bMergePolys_IsValid;

	private static FFieldAddress bspBrushCSG_bMergePolys_PropertyAddress;

	private static int bspBrushCSG_bMergePolys_Offset;

	private static bool bspBrushCSG_bReplaceNULLMaterialRefs_IsValid;

	private static FFieldAddress bspBrushCSG_bReplaceNULLMaterialRefs_PropertyAddress;

	private static int bspBrushCSG_bReplaceNULLMaterialRefs_Offset;

	private static bool bspBrushCSG_bShowProgressBar_IsValid;

	private static FFieldAddress bspBrushCSG_bShowProgressBar_PropertyAddress;

	private static int bspBrushCSG_bShowProgressBar_Offset;

	private static bool bspBrushCSG_ReturnValue_IsValid;

	private static FFieldAddress bspBrushCSG_ReturnValue_PropertyAddress;

	private static int bspBrushCSG_ReturnValue_Offset;

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SetMaterial")]
	public unsafe static void SetMaterial(UEditorEngine Engine, UModel InModel, UMaterialInterface Material, List<int> Surfaces)
	{
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SetMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, SetMaterial_Engine_Offset), 0, SetMaterial_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<UModel>.ToNative(IntPtr.Add(intPtr, SetMaterial_InModel_Offset), 0, SetMaterial_InModel_PropertyAddress.Address, InModel);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterial_Material_Offset), 0, SetMaterial_Material_PropertyAddress.Address, Material);
		new TArrayCopyMarshaler<int>(1, SetMaterial_Surfaces_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SetMaterial_Surfaces_Offset), Surfaces);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMaterial_Surfaces_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectNone")]
	public unsafe static void SelectNone(UEditorEngine Engine, bool bNoteSelectionChange, bool bDeselectBSPSurfs, bool WarnAboutManyActors = true)
	{
		if (!SelectNone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectNone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectNone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectNone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, SelectNone_Engine_Offset), 0, SelectNone_Engine_PropertyAddress.Address, Engine);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNone_bNoteSelectionChange_Offset), 0, SelectNone_bNoteSelectionChange_PropertyAddress.Address, bNoteSelectionChange);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNone_bDeselectBSPSurfs_Offset), 0, SelectNone_bDeselectBSPSurfs_PropertyAddress.Address, bDeselectBSPSurfs);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNone_WarnAboutManyActors_Offset), 0, SelectNone_WarnAboutManyActors_PropertyAddress.Address, WarnAboutManyActors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectNone_FunctionAddress, intPtr, SelectNone_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectGroup")]
	public unsafe static void SelectGroup(UEditorEngine Engine, AGroupActor InGroupActor, bool bForceSelection = false, bool bInSelected = true, bool bNotify = true)
	{
		if (!SelectGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, SelectGroup_Engine_Offset), 0, SelectGroup_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<AGroupActor>.ToNative(IntPtr.Add(intPtr, SelectGroup_InGroupActor_Offset), 0, SelectGroup_InGroupActor_PropertyAddress.Address, InGroupActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectGroup_bForceSelection_Offset), 0, SelectGroup_bForceSelection_PropertyAddress.Address, bForceSelection);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectGroup_bInSelected_Offset), 0, SelectGroup_bInSelected_PropertyAddress.Address, bInSelected);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectGroup_bNotify_Offset), 0, SelectGroup_bNotify_PropertyAddress.Address, bNotify);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectGroup_FunctionAddress, intPtr, SelectGroup_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectComponent")]
	public unsafe static void SelectComponent(UEditorEngine Engine, UActorComponent Component, bool bInSelected, bool bNotify, bool bSelectEvenIfHidden = false)
	{
		if (!SelectComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, SelectComponent_Engine_Offset), 0, SelectComponent_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, SelectComponent_Component_Offset), 0, SelectComponent_Component_PropertyAddress.Address, Component);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectComponent_bInSelected_Offset), 0, SelectComponent_bInSelected_PropertyAddress.Address, bInSelected);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectComponent_bNotify_Offset), 0, SelectComponent_bNotify_PropertyAddress.Address, bNotify);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectComponent_bSelectEvenIfHidden_Offset), 0, SelectComponent_bSelectEvenIfHidden_PropertyAddress.Address, bSelectEvenIfHidden);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectComponent_FunctionAddress, intPtr, SelectComponent_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectActor")]
	public unsafe static void SelectActor(UEditorEngine Engine, AActor Actor, bool bInSelected, bool bNotify, bool bSelectEvenIfHidden = false, bool bForceRefresh = false)
	{
		if (!SelectActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, SelectActor_Engine_Offset), 0, SelectActor_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SelectActor_Actor_Offset), 0, SelectActor_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectActor_bInSelected_Offset), 0, SelectActor_bInSelected_PropertyAddress.Address, bInSelected);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectActor_bNotify_Offset), 0, SelectActor_bNotify_PropertyAddress.Address, bNotify);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectActor_bSelectEvenIfHidden_Offset), 0, SelectActor_bSelectEvenIfHidden_PropertyAddress.Address, bSelectEvenIfHidden);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectActor_bForceRefresh_Offset), 0, SelectActor_bForceRefresh_PropertyAddress.Address, bForceRefresh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectActor_FunctionAddress, intPtr, SelectActor_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RedrawAllViewports")]
	public unsafe static void RedrawAllViewports(UEditorEngine Engine, bool bInvalidateHitProxies)
	{
		if (!RedrawAllViewports_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RedrawAllViewports");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RedrawAllViewports_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RedrawAllViewports_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, RedrawAllViewports_Engine_Offset), 0, RedrawAllViewports_Engine_PropertyAddress.Address, Engine);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RedrawAllViewports_bInvalidateHitProxies_Offset), 0, RedrawAllViewports_bInvalidateHitProxies_PropertyAddress.Address, bInvalidateHitProxies);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RedrawAllViewports_FunctionAddress, intPtr, RedrawAllViewports_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RebuildStaticNavigableGeometry")]
	public unsafe static void RebuildStaticNavigableGeometry(UEditorEngine Engine, ULevel Level)
	{
		if (!RebuildStaticNavigableGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RebuildStaticNavigableGeometry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RebuildStaticNavigableGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RebuildStaticNavigableGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, RebuildStaticNavigableGeometry_Engine_Offset), 0, RebuildStaticNavigableGeometry_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, RebuildStaticNavigableGeometry_Level_Offset), 0, RebuildStaticNavigableGeometry_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RebuildStaticNavigableGeometry_FunctionAddress, intPtr, RebuildStaticNavigableGeometry_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RebuildLevel")]
	public unsafe static void RebuildLevel(UEditorEngine Engine, ULevel Level)
	{
		if (!RebuildLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RebuildLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RebuildLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RebuildLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, RebuildLevel_Engine_Offset), 0, RebuildLevel_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, RebuildLevel_Level_Offset), 0, RebuildLevel_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RebuildLevel_FunctionAddress, intPtr, RebuildLevel_ParamsSize);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSurfaces")]
	public unsafe static void GetSurfaces(ABrush Brush, out List<int> Surfaces)
	{
		if (!GetSurfaces_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSurfaces");
			Surfaces = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSurfaces_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSurfaces_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABrush>.ToNative(IntPtr.Add(intPtr, GetSurfaces_Brush_Offset), 0, GetSurfaces_Brush_PropertyAddress.Address, Brush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSurfaces_FunctionAddress, intPtr, GetSurfaces_ParamsSize);
		Surfaces = new TArrayCopyMarshaler<int>(1, GetSurfaces_Surfaces_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSurfaces_Surfaces_Offset));
		NativeReflection.DestroyValue_InContainer(GetSurfaces_Surfaces_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedSet")]
	public unsafe static USelection GetSelectedSet(UEditorEngine Engine, TSubclassOf<UObject> Class)
	{
		if (!GetSelectedSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedSet");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, GetSelectedSet_Engine_Offset), 0, GetSelectedSet_Engine_PropertyAddress.Address, Engine);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetSelectedSet_Class_Offset), 0, GetSelectedSet_Class_PropertyAddress.Address, Class);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedSet_FunctionAddress, intPtr, GetSelectedSet_ParamsSize);
		return UObjectMarshaler<USelection>.FromNative(IntPtr.Add(intPtr, GetSelectedSet_ReturnValue_Offset), 0, GetSelectedSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedObjects")]
	public unsafe static USelection GetSelectedObjects(UEditorEngine Engine)
	{
		if (!GetSelectedObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, GetSelectedObjects_Engine_Offset), 0, GetSelectedObjects_Engine_PropertyAddress.Address, Engine);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedObjects_FunctionAddress, intPtr, GetSelectedObjects_ParamsSize);
		return UObjectMarshaler<USelection>.FromNative(IntPtr.Add(intPtr, GetSelectedObjects_ReturnValue_Offset), 0, GetSelectedObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedComponents")]
	public unsafe static USelection GetSelectedComponents(UEditorEngine Engine)
	{
		if (!GetSelectedComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, GetSelectedComponents_Engine_Offset), 0, GetSelectedComponents_Engine_PropertyAddress.Address, Engine);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedComponents_FunctionAddress, intPtr, GetSelectedComponents_ParamsSize);
		return UObjectMarshaler<USelection>.FromNative(IntPtr.Add(intPtr, GetSelectedComponents_ReturnValue_Offset), 0, GetSelectedComponents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetPIEWorld")]
	public unsafe static UWorld GetPIEWorld(UEngine Engine)
	{
		if (!GetPIEWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetPIEWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPIEWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPIEWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEngine>.ToNative(IntPtr.Add(intPtr, GetPIEWorld_Engine_Offset), 0, GetPIEWorld_Engine_PropertyAddress.Address, Engine);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPIEWorld_FunctionAddress, intPtr, GetPIEWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetPIEWorld_ReturnValue_Offset), 0, GetPIEWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetLongPackagePath")]
	public unsafe static string GetLongPackagePath(UPackage InPackage)
	{
		if (!GetLongPackagePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetLongPackagePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLongPackagePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLongPackagePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPackage>.ToNative(IntPtr.Add(intPtr, GetLongPackagePath_InPackage_Offset), 0, GetLongPackagePath_InPackage_PropertyAddress.Address, InPackage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLongPackagePath_FunctionAddress, intPtr, GetLongPackagePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLongPackagePath_ReturnValue_Offset), 0, GetLongPackagePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLongPackagePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetLevelViewportCameraInfo")]
	public unsafe static bool GetLevelViewportCameraInfo(UEditorEngine Engine, out FVector CameraLocation, out FRotator CameraRotation)
	{
		if (!GetLevelViewportCameraInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetLevelViewportCameraInfo");
			CameraLocation = default(FVector);
			CameraRotation = default(FRotator);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelViewportCameraInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelViewportCameraInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, GetLevelViewportCameraInfo_Engine_Offset), 0, GetLevelViewportCameraInfo_Engine_PropertyAddress.Address, Engine);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelViewportCameraInfo_FunctionAddress, intPtr, GetLevelViewportCameraInfo_ParamsSize);
		CameraLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLevelViewportCameraInfo_CameraLocation_Offset), 0, GetLevelViewportCameraInfo_CameraLocation_PropertyAddress.Address);
		CameraRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetLevelViewportCameraInfo_CameraRotation_Offset), 0, GetLevelViewportCameraInfo_CameraRotation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLevelViewportCameraInfo_ReturnValue_Offset), 0, GetLevelViewportCameraInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetEditorWorld")]
	public unsafe static UWorld GetEditorWorld(UEngine Engine)
	{
		if (!GetEditorWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetEditorWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditorWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditorWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEngine>.ToNative(IntPtr.Add(intPtr, GetEditorWorld_Engine_Offset), 0, GetEditorWorld_Engine_PropertyAddress.Address, Engine);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEditorWorld_FunctionAddress, intPtr, GetEditorWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetEditorWorld_ReturnValue_Offset), 0, GetEditorWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:FindBrushBuilder")]
	public unsafe static UBrushBuilder FindBrushBuilder(UEditorEngine Engine, TSubclassOf<UObject> BrushBuilderClass)
	{
		if (!FindBrushBuilder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:FindBrushBuilder");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindBrushBuilder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindBrushBuilder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, FindBrushBuilder_Engine_Offset), 0, FindBrushBuilder_Engine_PropertyAddress.Address, Engine);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindBrushBuilder_BrushBuilderClass_Offset), 0, FindBrushBuilder_BrushBuilderClass_PropertyAddress.Address, BrushBuilderClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindBrushBuilder_FunctionAddress, intPtr, FindBrushBuilder_ParamsSize);
		return UObjectMarshaler<UBrushBuilder>.FromNative(IntPtr.Add(intPtr, FindBrushBuilder_ReturnValue_Offset), 0, FindBrushBuilder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:Exec")]
	public unsafe static bool Exec(UEditorEngine Engine, UWorld InWorld, string Command, out string Out)
	{
		if (!Exec_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:Exec");
			Out = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Exec_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Exec_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, Exec_Engine_Offset), 0, Exec_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, Exec_InWorld_Offset), 0, Exec_InWorld_PropertyAddress.Address, InWorld);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Exec_Command_Offset), 0, Exec_Command_PropertyAddress.Address, Command);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Exec_FunctionAddress, intPtr, Exec_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Exec_Command_PropertyAddress.Address, intPtr);
		Out = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Exec_Out_Offset), 0, Exec_Out_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Exec_Out_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Exec_ReturnValue_Offset), 0, Exec_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:DuplicateAsset")]
	public unsafe static UObject DuplicateAsset(string AssetName, string PackagePath, UObject OriginalObject)
	{
		if (!DuplicateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:DuplicateAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_AssetName_Offset), 0, DuplicateAsset_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_PackagePath_Offset), 0, DuplicateAsset_PackagePath_PropertyAddress.Address, PackagePath);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateAsset_OriginalObject_Offset), 0, DuplicateAsset_OriginalObject_PropertyAddress.Address, OriginalObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateAsset_FunctionAddress, intPtr, DuplicateAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_PackagePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, DuplicateAsset_ReturnValue_Offset), 0, DuplicateAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:DeleteObjectsUnchecked")]
	public unsafe static int DeleteObjectsUnchecked(List<UObject> ObjectsToDelete)
	{
		if (!DeleteObjectsUnchecked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:DeleteObjectsUnchecked");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteObjectsUnchecked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteObjectsUnchecked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, DeleteObjectsUnchecked_ObjectsToDelete_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, DeleteObjectsUnchecked_ObjectsToDelete_Offset), ObjectsToDelete);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteObjectsUnchecked_FunctionAddress, intPtr, DeleteObjectsUnchecked_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteObjectsUnchecked_ObjectsToDelete_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, DeleteObjectsUnchecked_ReturnValue_Offset), 0, DeleteObjectsUnchecked_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:CanSelectActor")]
	public unsafe static bool CanSelectActor(UEditorEngine Engine, AActor Actor, bool bInSelected, bool bSelectEvenIfHidden = false, bool bWarnIfLevelLocked = false)
	{
		if (!CanSelectActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:CanSelectActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanSelectActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanSelectActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, CanSelectActor_Engine_Offset), 0, CanSelectActor_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CanSelectActor_Actor_Offset), 0, CanSelectActor_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CanSelectActor_bInSelected_Offset), 0, CanSelectActor_bInSelected_PropertyAddress.Address, bInSelected);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CanSelectActor_bSelectEvenIfHidden_Offset), 0, CanSelectActor_bSelectEvenIfHidden_PropertyAddress.Address, bSelectEvenIfHidden);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CanSelectActor_bWarnIfLevelLocked_Offset), 0, CanSelectActor_bWarnIfLevelLocked_PropertyAddress.Address, bWarnIfLevelLocked);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanSelectActor_FunctionAddress, intPtr, CanSelectActor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanSelectActor_ReturnValue_Offset), 0, CanSelectActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:bspBrushCSG")]
	public unsafe static int bspBrushCSG(UEditorEngine Engine, ABrush Actor, UModel Model, int PolyFlags, EBrushType BrushType, ECsgOper CSGOper, bool bBuildBounds, bool bMergePolys, bool bReplaceNULLMaterialRefs, bool bShowProgressBar = true)
	{
		if (!bspBrushCSG_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:bspBrushCSG");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(bspBrushCSG_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)bspBrushCSG_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEditorEngine>.ToNative(IntPtr.Add(intPtr, bspBrushCSG_Engine_Offset), 0, bspBrushCSG_Engine_PropertyAddress.Address, Engine);
		UObjectMarshaler<ABrush>.ToNative(IntPtr.Add(intPtr, bspBrushCSG_Actor_Offset), 0, bspBrushCSG_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UModel>.ToNative(IntPtr.Add(intPtr, bspBrushCSG_Model_Offset), 0, bspBrushCSG_Model_PropertyAddress.Address, Model);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, bspBrushCSG_PolyFlags_Offset), 0, bspBrushCSG_PolyFlags_PropertyAddress.Address, PolyFlags);
		EnumMarshaler<EBrushType>.ToNative(IntPtr.Add(intPtr, bspBrushCSG_BrushType_Offset), 0, bspBrushCSG_BrushType_PropertyAddress.Address, BrushType);
		EnumMarshaler<ECsgOper>.ToNative(IntPtr.Add(intPtr, bspBrushCSG_CSGOper_Offset), 0, bspBrushCSG_CSGOper_PropertyAddress.Address, CSGOper);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, bspBrushCSG_bBuildBounds_Offset), 0, bspBrushCSG_bBuildBounds_PropertyAddress.Address, bBuildBounds);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, bspBrushCSG_bMergePolys_Offset), 0, bspBrushCSG_bMergePolys_PropertyAddress.Address, bMergePolys);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, bspBrushCSG_bReplaceNULLMaterialRefs_Offset), 0, bspBrushCSG_bReplaceNULLMaterialRefs_PropertyAddress.Address, bReplaceNULLMaterialRefs);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, bspBrushCSG_bShowProgressBar_Offset), 0, bspBrushCSG_bShowProgressBar_PropertyAddress.Address, bShowProgressBar);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, bspBrushCSG_FunctionAddress, intPtr, bspBrushCSG_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, bspBrushCSG_ReturnValue_Offset), 0, bspBrushCSG_ReturnValue_PropertyAddress.Address);
	}

	static UJavascriptEditorEngineLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptEditorEngineLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptEditorEngineLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptEditorEngineLibrary");
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Engine_PropertyAddress, SetMaterial_FunctionAddress, "Engine");
		SetMaterial_Engine_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Engine");
		SetMaterial_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_InModel_PropertyAddress, SetMaterial_FunctionAddress, "InModel");
		SetMaterial_InModel_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "InModel");
		SetMaterial_InModel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "InModel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Material_PropertyAddress, SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Surfaces_PropertyAddress, SetMaterial_FunctionAddress, "Surfaces");
		SetMaterial_Surfaces_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Surfaces");
		SetMaterial_Surfaces_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Surfaces", Classes.FArrayProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_Engine_IsValid && SetMaterial_InModel_IsValid && SetMaterial_Material_IsValid && SetMaterial_Surfaces_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SetMaterial", SetMaterial_IsValid);
		SelectNone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectNone");
		SelectNone_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectNone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectNone_Engine_PropertyAddress, SelectNone_FunctionAddress, "Engine");
		SelectNone_Engine_Offset = NativeReflectionCached.GetPropertyOffset(SelectNone_FunctionAddress, "Engine");
		SelectNone_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNone_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNone_bNoteSelectionChange_PropertyAddress, SelectNone_FunctionAddress, "bNoteSelectionChange");
		SelectNone_bNoteSelectionChange_Offset = NativeReflectionCached.GetPropertyOffset(SelectNone_FunctionAddress, "bNoteSelectionChange");
		SelectNone_bNoteSelectionChange_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNone_FunctionAddress, "bNoteSelectionChange", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNone_bDeselectBSPSurfs_PropertyAddress, SelectNone_FunctionAddress, "bDeselectBSPSurfs");
		SelectNone_bDeselectBSPSurfs_Offset = NativeReflectionCached.GetPropertyOffset(SelectNone_FunctionAddress, "bDeselectBSPSurfs");
		SelectNone_bDeselectBSPSurfs_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNone_FunctionAddress, "bDeselectBSPSurfs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNone_WarnAboutManyActors_PropertyAddress, SelectNone_FunctionAddress, "WarnAboutManyActors");
		SelectNone_WarnAboutManyActors_Offset = NativeReflectionCached.GetPropertyOffset(SelectNone_FunctionAddress, "WarnAboutManyActors");
		SelectNone_WarnAboutManyActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNone_FunctionAddress, "WarnAboutManyActors", Classes.FBoolProperty);
		SelectNone_IsValid = SelectNone_FunctionAddress != IntPtr.Zero && SelectNone_Engine_IsValid && SelectNone_bNoteSelectionChange_IsValid && SelectNone_bDeselectBSPSurfs_IsValid && SelectNone_WarnAboutManyActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectNone", SelectNone_IsValid);
		SelectGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectGroup");
		SelectGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectGroup_Engine_PropertyAddress, SelectGroup_FunctionAddress, "Engine");
		SelectGroup_Engine_Offset = NativeReflectionCached.GetPropertyOffset(SelectGroup_FunctionAddress, "Engine");
		SelectGroup_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectGroup_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectGroup_InGroupActor_PropertyAddress, SelectGroup_FunctionAddress, "InGroupActor");
		SelectGroup_InGroupActor_Offset = NativeReflectionCached.GetPropertyOffset(SelectGroup_FunctionAddress, "InGroupActor");
		SelectGroup_InGroupActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectGroup_FunctionAddress, "InGroupActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectGroup_bForceSelection_PropertyAddress, SelectGroup_FunctionAddress, "bForceSelection");
		SelectGroup_bForceSelection_Offset = NativeReflectionCached.GetPropertyOffset(SelectGroup_FunctionAddress, "bForceSelection");
		SelectGroup_bForceSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectGroup_FunctionAddress, "bForceSelection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectGroup_bInSelected_PropertyAddress, SelectGroup_FunctionAddress, "bInSelected");
		SelectGroup_bInSelected_Offset = NativeReflectionCached.GetPropertyOffset(SelectGroup_FunctionAddress, "bInSelected");
		SelectGroup_bInSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectGroup_FunctionAddress, "bInSelected", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectGroup_bNotify_PropertyAddress, SelectGroup_FunctionAddress, "bNotify");
		SelectGroup_bNotify_Offset = NativeReflectionCached.GetPropertyOffset(SelectGroup_FunctionAddress, "bNotify");
		SelectGroup_bNotify_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectGroup_FunctionAddress, "bNotify", Classes.FBoolProperty);
		SelectGroup_IsValid = SelectGroup_FunctionAddress != IntPtr.Zero && SelectGroup_Engine_IsValid && SelectGroup_InGroupActor_IsValid && SelectGroup_bForceSelection_IsValid && SelectGroup_bInSelected_IsValid && SelectGroup_bNotify_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectGroup", SelectGroup_IsValid);
		SelectComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectComponent");
		SelectComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectComponent_Engine_PropertyAddress, SelectComponent_FunctionAddress, "Engine");
		SelectComponent_Engine_Offset = NativeReflectionCached.GetPropertyOffset(SelectComponent_FunctionAddress, "Engine");
		SelectComponent_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectComponent_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectComponent_Component_PropertyAddress, SelectComponent_FunctionAddress, "Component");
		SelectComponent_Component_Offset = NativeReflectionCached.GetPropertyOffset(SelectComponent_FunctionAddress, "Component");
		SelectComponent_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectComponent_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectComponent_bInSelected_PropertyAddress, SelectComponent_FunctionAddress, "bInSelected");
		SelectComponent_bInSelected_Offset = NativeReflectionCached.GetPropertyOffset(SelectComponent_FunctionAddress, "bInSelected");
		SelectComponent_bInSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectComponent_FunctionAddress, "bInSelected", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectComponent_bNotify_PropertyAddress, SelectComponent_FunctionAddress, "bNotify");
		SelectComponent_bNotify_Offset = NativeReflectionCached.GetPropertyOffset(SelectComponent_FunctionAddress, "bNotify");
		SelectComponent_bNotify_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectComponent_FunctionAddress, "bNotify", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectComponent_bSelectEvenIfHidden_PropertyAddress, SelectComponent_FunctionAddress, "bSelectEvenIfHidden");
		SelectComponent_bSelectEvenIfHidden_Offset = NativeReflectionCached.GetPropertyOffset(SelectComponent_FunctionAddress, "bSelectEvenIfHidden");
		SelectComponent_bSelectEvenIfHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectComponent_FunctionAddress, "bSelectEvenIfHidden", Classes.FBoolProperty);
		SelectComponent_IsValid = SelectComponent_FunctionAddress != IntPtr.Zero && SelectComponent_Engine_IsValid && SelectComponent_Component_IsValid && SelectComponent_bInSelected_IsValid && SelectComponent_bNotify_IsValid && SelectComponent_bSelectEvenIfHidden_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectComponent", SelectComponent_IsValid);
		SelectActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectActor");
		SelectActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectActor_Engine_PropertyAddress, SelectActor_FunctionAddress, "Engine");
		SelectActor_Engine_Offset = NativeReflectionCached.GetPropertyOffset(SelectActor_FunctionAddress, "Engine");
		SelectActor_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectActor_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectActor_Actor_PropertyAddress, SelectActor_FunctionAddress, "Actor");
		SelectActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SelectActor_FunctionAddress, "Actor");
		SelectActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectActor_bInSelected_PropertyAddress, SelectActor_FunctionAddress, "bInSelected");
		SelectActor_bInSelected_Offset = NativeReflectionCached.GetPropertyOffset(SelectActor_FunctionAddress, "bInSelected");
		SelectActor_bInSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectActor_FunctionAddress, "bInSelected", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectActor_bNotify_PropertyAddress, SelectActor_FunctionAddress, "bNotify");
		SelectActor_bNotify_Offset = NativeReflectionCached.GetPropertyOffset(SelectActor_FunctionAddress, "bNotify");
		SelectActor_bNotify_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectActor_FunctionAddress, "bNotify", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectActor_bSelectEvenIfHidden_PropertyAddress, SelectActor_FunctionAddress, "bSelectEvenIfHidden");
		SelectActor_bSelectEvenIfHidden_Offset = NativeReflectionCached.GetPropertyOffset(SelectActor_FunctionAddress, "bSelectEvenIfHidden");
		SelectActor_bSelectEvenIfHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectActor_FunctionAddress, "bSelectEvenIfHidden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectActor_bForceRefresh_PropertyAddress, SelectActor_FunctionAddress, "bForceRefresh");
		SelectActor_bForceRefresh_Offset = NativeReflectionCached.GetPropertyOffset(SelectActor_FunctionAddress, "bForceRefresh");
		SelectActor_bForceRefresh_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectActor_FunctionAddress, "bForceRefresh", Classes.FBoolProperty);
		SelectActor_IsValid = SelectActor_FunctionAddress != IntPtr.Zero && SelectActor_Engine_IsValid && SelectActor_Actor_IsValid && SelectActor_bInSelected_IsValid && SelectActor_bNotify_IsValid && SelectActor_bSelectEvenIfHidden_IsValid && SelectActor_bForceRefresh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:SelectActor", SelectActor_IsValid);
		RedrawAllViewports_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RedrawAllViewports");
		RedrawAllViewports_ParamsSize = NativeReflection.GetFunctionParamsSize(RedrawAllViewports_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RedrawAllViewports_Engine_PropertyAddress, RedrawAllViewports_FunctionAddress, "Engine");
		RedrawAllViewports_Engine_Offset = NativeReflectionCached.GetPropertyOffset(RedrawAllViewports_FunctionAddress, "Engine");
		RedrawAllViewports_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(RedrawAllViewports_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RedrawAllViewports_bInvalidateHitProxies_PropertyAddress, RedrawAllViewports_FunctionAddress, "bInvalidateHitProxies");
		RedrawAllViewports_bInvalidateHitProxies_Offset = NativeReflectionCached.GetPropertyOffset(RedrawAllViewports_FunctionAddress, "bInvalidateHitProxies");
		RedrawAllViewports_bInvalidateHitProxies_IsValid = NativeReflectionCached.ValidatePropertyClass(RedrawAllViewports_FunctionAddress, "bInvalidateHitProxies", Classes.FBoolProperty);
		RedrawAllViewports_IsValid = RedrawAllViewports_FunctionAddress != IntPtr.Zero && RedrawAllViewports_Engine_IsValid && RedrawAllViewports_bInvalidateHitProxies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RedrawAllViewports", RedrawAllViewports_IsValid);
		RebuildStaticNavigableGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RebuildStaticNavigableGeometry");
		RebuildStaticNavigableGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(RebuildStaticNavigableGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RebuildStaticNavigableGeometry_Engine_PropertyAddress, RebuildStaticNavigableGeometry_FunctionAddress, "Engine");
		RebuildStaticNavigableGeometry_Engine_Offset = NativeReflectionCached.GetPropertyOffset(RebuildStaticNavigableGeometry_FunctionAddress, "Engine");
		RebuildStaticNavigableGeometry_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildStaticNavigableGeometry_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RebuildStaticNavigableGeometry_Level_PropertyAddress, RebuildStaticNavigableGeometry_FunctionAddress, "Level");
		RebuildStaticNavigableGeometry_Level_Offset = NativeReflectionCached.GetPropertyOffset(RebuildStaticNavigableGeometry_FunctionAddress, "Level");
		RebuildStaticNavigableGeometry_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildStaticNavigableGeometry_FunctionAddress, "Level", Classes.FObjectProperty);
		RebuildStaticNavigableGeometry_IsValid = RebuildStaticNavigableGeometry_FunctionAddress != IntPtr.Zero && RebuildStaticNavigableGeometry_Engine_IsValid && RebuildStaticNavigableGeometry_Level_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RebuildStaticNavigableGeometry", RebuildStaticNavigableGeometry_IsValid);
		RebuildLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RebuildLevel");
		RebuildLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(RebuildLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RebuildLevel_Engine_PropertyAddress, RebuildLevel_FunctionAddress, "Engine");
		RebuildLevel_Engine_Offset = NativeReflectionCached.GetPropertyOffset(RebuildLevel_FunctionAddress, "Engine");
		RebuildLevel_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildLevel_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RebuildLevel_Level_PropertyAddress, RebuildLevel_FunctionAddress, "Level");
		RebuildLevel_Level_Offset = NativeReflectionCached.GetPropertyOffset(RebuildLevel_FunctionAddress, "Level");
		RebuildLevel_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		RebuildLevel_IsValid = RebuildLevel_FunctionAddress != IntPtr.Zero && RebuildLevel_Engine_IsValid && RebuildLevel_Level_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:RebuildLevel", RebuildLevel_IsValid);
		GetSurfaces_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSurfaces");
		GetSurfaces_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSurfaces_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSurfaces_Brush_PropertyAddress, GetSurfaces_FunctionAddress, "Brush");
		GetSurfaces_Brush_Offset = NativeReflectionCached.GetPropertyOffset(GetSurfaces_FunctionAddress, "Brush");
		GetSurfaces_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSurfaces_FunctionAddress, "Brush", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSurfaces_Surfaces_PropertyAddress, GetSurfaces_FunctionAddress, "Surfaces");
		GetSurfaces_Surfaces_Offset = NativeReflectionCached.GetPropertyOffset(GetSurfaces_FunctionAddress, "Surfaces");
		GetSurfaces_Surfaces_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSurfaces_FunctionAddress, "Surfaces", Classes.FArrayProperty);
		GetSurfaces_IsValid = GetSurfaces_FunctionAddress != IntPtr.Zero && GetSurfaces_Brush_IsValid && GetSurfaces_Surfaces_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSurfaces", GetSurfaces_IsValid);
		GetSelectedSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedSet");
		GetSelectedSet_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedSet_Engine_PropertyAddress, GetSelectedSet_FunctionAddress, "Engine");
		GetSelectedSet_Engine_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedSet_FunctionAddress, "Engine");
		GetSelectedSet_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedSet_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedSet_Class_PropertyAddress, GetSelectedSet_FunctionAddress, "Class");
		GetSelectedSet_Class_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedSet_FunctionAddress, "Class");
		GetSelectedSet_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedSet_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedSet_ReturnValue_PropertyAddress, GetSelectedSet_FunctionAddress, "ReturnValue");
		GetSelectedSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedSet_FunctionAddress, "ReturnValue");
		GetSelectedSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedSet_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSelectedSet_IsValid = GetSelectedSet_FunctionAddress != IntPtr.Zero && GetSelectedSet_Engine_IsValid && GetSelectedSet_Class_IsValid && GetSelectedSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedSet", GetSelectedSet_IsValid);
		GetSelectedObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedObjects");
		GetSelectedObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_Engine_PropertyAddress, GetSelectedObjects_FunctionAddress, "Engine");
		GetSelectedObjects_Engine_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "Engine");
		GetSelectedObjects_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_ReturnValue_PropertyAddress, GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSelectedObjects_IsValid = GetSelectedObjects_FunctionAddress != IntPtr.Zero && GetSelectedObjects_Engine_IsValid && GetSelectedObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedObjects", GetSelectedObjects_IsValid);
		GetSelectedComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedComponents");
		GetSelectedComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedComponents_Engine_PropertyAddress, GetSelectedComponents_FunctionAddress, "Engine");
		GetSelectedComponents_Engine_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedComponents_FunctionAddress, "Engine");
		GetSelectedComponents_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedComponents_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedComponents_ReturnValue_PropertyAddress, GetSelectedComponents_FunctionAddress, "ReturnValue");
		GetSelectedComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedComponents_FunctionAddress, "ReturnValue");
		GetSelectedComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedComponents_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSelectedComponents_IsValid = GetSelectedComponents_FunctionAddress != IntPtr.Zero && GetSelectedComponents_Engine_IsValid && GetSelectedComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetSelectedComponents", GetSelectedComponents_IsValid);
		GetPIEWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPIEWorld");
		GetPIEWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPIEWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPIEWorld_Engine_PropertyAddress, GetPIEWorld_FunctionAddress, "Engine");
		GetPIEWorld_Engine_Offset = NativeReflectionCached.GetPropertyOffset(GetPIEWorld_FunctionAddress, "Engine");
		GetPIEWorld_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPIEWorld_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPIEWorld_ReturnValue_PropertyAddress, GetPIEWorld_FunctionAddress, "ReturnValue");
		GetPIEWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPIEWorld_FunctionAddress, "ReturnValue");
		GetPIEWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPIEWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPIEWorld_IsValid = GetPIEWorld_FunctionAddress != IntPtr.Zero && GetPIEWorld_Engine_IsValid && GetPIEWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetPIEWorld", GetPIEWorld_IsValid);
		GetLongPackagePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLongPackagePath");
		GetLongPackagePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLongPackagePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLongPackagePath_InPackage_PropertyAddress, GetLongPackagePath_FunctionAddress, "InPackage");
		GetLongPackagePath_InPackage_Offset = NativeReflectionCached.GetPropertyOffset(GetLongPackagePath_FunctionAddress, "InPackage");
		GetLongPackagePath_InPackage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLongPackagePath_FunctionAddress, "InPackage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLongPackagePath_ReturnValue_PropertyAddress, GetLongPackagePath_FunctionAddress, "ReturnValue");
		GetLongPackagePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLongPackagePath_FunctionAddress, "ReturnValue");
		GetLongPackagePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLongPackagePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLongPackagePath_IsValid = GetLongPackagePath_FunctionAddress != IntPtr.Zero && GetLongPackagePath_InPackage_IsValid && GetLongPackagePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetLongPackagePath", GetLongPackagePath_IsValid);
		GetLevelViewportCameraInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelViewportCameraInfo");
		GetLevelViewportCameraInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelViewportCameraInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelViewportCameraInfo_Engine_PropertyAddress, GetLevelViewportCameraInfo_FunctionAddress, "Engine");
		GetLevelViewportCameraInfo_Engine_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelViewportCameraInfo_FunctionAddress, "Engine");
		GetLevelViewportCameraInfo_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelViewportCameraInfo_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelViewportCameraInfo_CameraLocation_PropertyAddress, GetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		GetLevelViewportCameraInfo_CameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelViewportCameraInfo_FunctionAddress, "CameraLocation");
		GetLevelViewportCameraInfo_CameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelViewportCameraInfo_FunctionAddress, "CameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelViewportCameraInfo_CameraRotation_PropertyAddress, GetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		GetLevelViewportCameraInfo_CameraRotation_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelViewportCameraInfo_FunctionAddress, "CameraRotation");
		GetLevelViewportCameraInfo_CameraRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelViewportCameraInfo_FunctionAddress, "CameraRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelViewportCameraInfo_ReturnValue_PropertyAddress, GetLevelViewportCameraInfo_FunctionAddress, "ReturnValue");
		GetLevelViewportCameraInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelViewportCameraInfo_FunctionAddress, "ReturnValue");
		GetLevelViewportCameraInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelViewportCameraInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLevelViewportCameraInfo_IsValid = GetLevelViewportCameraInfo_FunctionAddress != IntPtr.Zero && GetLevelViewportCameraInfo_Engine_IsValid && GetLevelViewportCameraInfo_CameraLocation_IsValid && GetLevelViewportCameraInfo_CameraRotation_IsValid && GetLevelViewportCameraInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetLevelViewportCameraInfo", GetLevelViewportCameraInfo_IsValid);
		GetEditorWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditorWorld");
		GetEditorWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditorWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditorWorld_Engine_PropertyAddress, GetEditorWorld_FunctionAddress, "Engine");
		GetEditorWorld_Engine_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorWorld_FunctionAddress, "Engine");
		GetEditorWorld_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorWorld_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEditorWorld_ReturnValue_PropertyAddress, GetEditorWorld_FunctionAddress, "ReturnValue");
		GetEditorWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorWorld_FunctionAddress, "ReturnValue");
		GetEditorWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEditorWorld_IsValid = GetEditorWorld_FunctionAddress != IntPtr.Zero && GetEditorWorld_Engine_IsValid && GetEditorWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:GetEditorWorld", GetEditorWorld_IsValid);
		FindBrushBuilder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindBrushBuilder");
		FindBrushBuilder_ParamsSize = NativeReflection.GetFunctionParamsSize(FindBrushBuilder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindBrushBuilder_Engine_PropertyAddress, FindBrushBuilder_FunctionAddress, "Engine");
		FindBrushBuilder_Engine_Offset = NativeReflectionCached.GetPropertyOffset(FindBrushBuilder_FunctionAddress, "Engine");
		FindBrushBuilder_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBrushBuilder_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBrushBuilder_BrushBuilderClass_PropertyAddress, FindBrushBuilder_FunctionAddress, "BrushBuilderClass");
		FindBrushBuilder_BrushBuilderClass_Offset = NativeReflectionCached.GetPropertyOffset(FindBrushBuilder_FunctionAddress, "BrushBuilderClass");
		FindBrushBuilder_BrushBuilderClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBrushBuilder_FunctionAddress, "BrushBuilderClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBrushBuilder_ReturnValue_PropertyAddress, FindBrushBuilder_FunctionAddress, "ReturnValue");
		FindBrushBuilder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindBrushBuilder_FunctionAddress, "ReturnValue");
		FindBrushBuilder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBrushBuilder_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindBrushBuilder_IsValid = FindBrushBuilder_FunctionAddress != IntPtr.Zero && FindBrushBuilder_Engine_IsValid && FindBrushBuilder_BrushBuilderClass_IsValid && FindBrushBuilder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:FindBrushBuilder", FindBrushBuilder_IsValid);
		Exec_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Exec");
		Exec_ParamsSize = NativeReflection.GetFunctionParamsSize(Exec_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Exec_Engine_PropertyAddress, Exec_FunctionAddress, "Engine");
		Exec_Engine_Offset = NativeReflectionCached.GetPropertyOffset(Exec_FunctionAddress, "Engine");
		Exec_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(Exec_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Exec_InWorld_PropertyAddress, Exec_FunctionAddress, "InWorld");
		Exec_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(Exec_FunctionAddress, "InWorld");
		Exec_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(Exec_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Exec_Command_PropertyAddress, Exec_FunctionAddress, "Command");
		Exec_Command_Offset = NativeReflectionCached.GetPropertyOffset(Exec_FunctionAddress, "Command");
		Exec_Command_IsValid = NativeReflectionCached.ValidatePropertyClass(Exec_FunctionAddress, "Command", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Exec_Out_PropertyAddress, Exec_FunctionAddress, "Out");
		Exec_Out_Offset = NativeReflectionCached.GetPropertyOffset(Exec_FunctionAddress, "Out");
		Exec_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(Exec_FunctionAddress, "Out", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Exec_ReturnValue_PropertyAddress, Exec_FunctionAddress, "ReturnValue");
		Exec_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Exec_FunctionAddress, "ReturnValue");
		Exec_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Exec_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Exec_IsValid = Exec_FunctionAddress != IntPtr.Zero && Exec_Engine_IsValid && Exec_InWorld_IsValid && Exec_Command_IsValid && Exec_Out_IsValid && Exec_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:Exec", Exec_IsValid);
		DuplicateAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateAsset");
		DuplicateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_AssetName_PropertyAddress, DuplicateAsset_FunctionAddress, "AssetName");
		DuplicateAsset_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "AssetName");
		DuplicateAsset_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_PackagePath_PropertyAddress, DuplicateAsset_FunctionAddress, "PackagePath");
		DuplicateAsset_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "PackagePath");
		DuplicateAsset_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_OriginalObject_PropertyAddress, DuplicateAsset_FunctionAddress, "OriginalObject");
		DuplicateAsset_OriginalObject_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "OriginalObject");
		DuplicateAsset_OriginalObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "OriginalObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_ReturnValue_PropertyAddress, DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateAsset_IsValid = DuplicateAsset_FunctionAddress != IntPtr.Zero && DuplicateAsset_AssetName_IsValid && DuplicateAsset_PackagePath_IsValid && DuplicateAsset_OriginalObject_IsValid && DuplicateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:DuplicateAsset", DuplicateAsset_IsValid);
		DeleteObjectsUnchecked_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteObjectsUnchecked");
		DeleteObjectsUnchecked_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteObjectsUnchecked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteObjectsUnchecked_ObjectsToDelete_PropertyAddress, DeleteObjectsUnchecked_FunctionAddress, "ObjectsToDelete");
		DeleteObjectsUnchecked_ObjectsToDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteObjectsUnchecked_FunctionAddress, "ObjectsToDelete");
		DeleteObjectsUnchecked_ObjectsToDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteObjectsUnchecked_FunctionAddress, "ObjectsToDelete", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteObjectsUnchecked_ReturnValue_PropertyAddress, DeleteObjectsUnchecked_FunctionAddress, "ReturnValue");
		DeleteObjectsUnchecked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteObjectsUnchecked_FunctionAddress, "ReturnValue");
		DeleteObjectsUnchecked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteObjectsUnchecked_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		DeleteObjectsUnchecked_IsValid = DeleteObjectsUnchecked_FunctionAddress != IntPtr.Zero && DeleteObjectsUnchecked_ObjectsToDelete_IsValid && DeleteObjectsUnchecked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:DeleteObjectsUnchecked", DeleteObjectsUnchecked_IsValid);
		CanSelectActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanSelectActor");
		CanSelectActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CanSelectActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanSelectActor_Engine_PropertyAddress, CanSelectActor_FunctionAddress, "Engine");
		CanSelectActor_Engine_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectActor_FunctionAddress, "Engine");
		CanSelectActor_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectActor_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSelectActor_Actor_PropertyAddress, CanSelectActor_FunctionAddress, "Actor");
		CanSelectActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectActor_FunctionAddress, "Actor");
		CanSelectActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSelectActor_bInSelected_PropertyAddress, CanSelectActor_FunctionAddress, "bInSelected");
		CanSelectActor_bInSelected_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectActor_FunctionAddress, "bInSelected");
		CanSelectActor_bInSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectActor_FunctionAddress, "bInSelected", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSelectActor_bSelectEvenIfHidden_PropertyAddress, CanSelectActor_FunctionAddress, "bSelectEvenIfHidden");
		CanSelectActor_bSelectEvenIfHidden_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectActor_FunctionAddress, "bSelectEvenIfHidden");
		CanSelectActor_bSelectEvenIfHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectActor_FunctionAddress, "bSelectEvenIfHidden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSelectActor_bWarnIfLevelLocked_PropertyAddress, CanSelectActor_FunctionAddress, "bWarnIfLevelLocked");
		CanSelectActor_bWarnIfLevelLocked_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectActor_FunctionAddress, "bWarnIfLevelLocked");
		CanSelectActor_bWarnIfLevelLocked_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectActor_FunctionAddress, "bWarnIfLevelLocked", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSelectActor_ReturnValue_PropertyAddress, CanSelectActor_FunctionAddress, "ReturnValue");
		CanSelectActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanSelectActor_FunctionAddress, "ReturnValue");
		CanSelectActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanSelectActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanSelectActor_IsValid = CanSelectActor_FunctionAddress != IntPtr.Zero && CanSelectActor_Engine_IsValid && CanSelectActor_Actor_IsValid && CanSelectActor_bInSelected_IsValid && CanSelectActor_bSelectEvenIfHidden_IsValid && CanSelectActor_bWarnIfLevelLocked_IsValid && CanSelectActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:CanSelectActor", CanSelectActor_IsValid);
		bspBrushCSG_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "bspBrushCSG");
		bspBrushCSG_ParamsSize = NativeReflection.GetFunctionParamsSize(bspBrushCSG_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_Engine_PropertyAddress, bspBrushCSG_FunctionAddress, "Engine");
		bspBrushCSG_Engine_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "Engine");
		bspBrushCSG_Engine_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "Engine", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_Actor_PropertyAddress, bspBrushCSG_FunctionAddress, "Actor");
		bspBrushCSG_Actor_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "Actor");
		bspBrushCSG_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_Model_PropertyAddress, bspBrushCSG_FunctionAddress, "Model");
		bspBrushCSG_Model_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "Model");
		bspBrushCSG_Model_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "Model", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_PolyFlags_PropertyAddress, bspBrushCSG_FunctionAddress, "PolyFlags");
		bspBrushCSG_PolyFlags_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "PolyFlags");
		bspBrushCSG_PolyFlags_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "PolyFlags", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_BrushType_PropertyAddress, bspBrushCSG_FunctionAddress, "BrushType");
		bspBrushCSG_BrushType_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "BrushType");
		bspBrushCSG_BrushType_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "BrushType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_CSGOper_PropertyAddress, bspBrushCSG_FunctionAddress, "CSGOper");
		bspBrushCSG_CSGOper_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "CSGOper");
		bspBrushCSG_CSGOper_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "CSGOper", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_bBuildBounds_PropertyAddress, bspBrushCSG_FunctionAddress, "bBuildBounds");
		bspBrushCSG_bBuildBounds_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "bBuildBounds");
		bspBrushCSG_bBuildBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "bBuildBounds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_bMergePolys_PropertyAddress, bspBrushCSG_FunctionAddress, "bMergePolys");
		bspBrushCSG_bMergePolys_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "bMergePolys");
		bspBrushCSG_bMergePolys_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "bMergePolys", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_bReplaceNULLMaterialRefs_PropertyAddress, bspBrushCSG_FunctionAddress, "bReplaceNULLMaterialRefs");
		bspBrushCSG_bReplaceNULLMaterialRefs_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "bReplaceNULLMaterialRefs");
		bspBrushCSG_bReplaceNULLMaterialRefs_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "bReplaceNULLMaterialRefs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_bShowProgressBar_PropertyAddress, bspBrushCSG_FunctionAddress, "bShowProgressBar");
		bspBrushCSG_bShowProgressBar_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "bShowProgressBar");
		bspBrushCSG_bShowProgressBar_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "bShowProgressBar", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref bspBrushCSG_ReturnValue_PropertyAddress, bspBrushCSG_FunctionAddress, "ReturnValue");
		bspBrushCSG_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(bspBrushCSG_FunctionAddress, "ReturnValue");
		bspBrushCSG_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(bspBrushCSG_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		bspBrushCSG_IsValid = bspBrushCSG_FunctionAddress != IntPtr.Zero && bspBrushCSG_Engine_IsValid && bspBrushCSG_Actor_IsValid && bspBrushCSG_Model_IsValid && bspBrushCSG_PolyFlags_IsValid && bspBrushCSG_BrushType_IsValid && bspBrushCSG_CSGOper_IsValid && bspBrushCSG_bBuildBounds_IsValid && bspBrushCSG_bMergePolys_IsValid && bspBrushCSG_bReplaceNULLMaterialRefs_IsValid && bspBrushCSG_bShowProgressBar_IsValid && bspBrushCSG_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorEngineLibrary:bspBrushCSG", bspBrushCSG_IsValid);
	}
}
