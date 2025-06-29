using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_UVs : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TranslateMeshUVs_IsValid;

	private static IntPtr TranslateMeshUVs_FunctionAddress;

	private static int TranslateMeshUVs_ParamsSize;

	private static bool TranslateMeshUVs_TargetMesh_IsValid;

	private static FFieldAddress TranslateMeshUVs_TargetMesh_PropertyAddress;

	private static int TranslateMeshUVs_TargetMesh_Offset;

	private static bool TranslateMeshUVs_UVSetIndex_IsValid;

	private static FFieldAddress TranslateMeshUVs_UVSetIndex_PropertyAddress;

	private static int TranslateMeshUVs_UVSetIndex_Offset;

	private static bool TranslateMeshUVs_Translation_IsValid;

	private static FFieldAddress TranslateMeshUVs_Translation_PropertyAddress;

	private static int TranslateMeshUVs_Translation_Offset;

	private static bool TranslateMeshUVs_Debug_IsValid;

	private static FFieldAddress TranslateMeshUVs_Debug_PropertyAddress;

	private static int TranslateMeshUVs_Debug_Offset;

	private static bool TranslateMeshUVs_ReturnValue_IsValid;

	private static FFieldAddress TranslateMeshUVs_ReturnValue_PropertyAddress;

	private static int TranslateMeshUVs_ReturnValue_Offset;

	private static bool SetNumUVSets_IsValid;

	private static IntPtr SetNumUVSets_FunctionAddress;

	private static int SetNumUVSets_ParamsSize;

	private static bool SetNumUVSets_TargetMesh_IsValid;

	private static FFieldAddress SetNumUVSets_TargetMesh_PropertyAddress;

	private static int SetNumUVSets_TargetMesh_Offset;

	private static bool SetNumUVSets_NumUVSets_IsValid;

	private static FFieldAddress SetNumUVSets_NumUVSets_PropertyAddress;

	private static int SetNumUVSets_NumUVSets_Offset;

	private static bool SetNumUVSets_Debug_IsValid;

	private static FFieldAddress SetNumUVSets_Debug_PropertyAddress;

	private static int SetNumUVSets_Debug_Offset;

	private static bool SetNumUVSets_ReturnValue_IsValid;

	private static FFieldAddress SetNumUVSets_ReturnValue_PropertyAddress;

	private static int SetNumUVSets_ReturnValue_Offset;

	private static bool SetMeshUVsFromPlanarProjection_IsValid;

	private static IntPtr SetMeshUVsFromPlanarProjection_FunctionAddress;

	private static int SetMeshUVsFromPlanarProjection_ParamsSize;

	private static bool SetMeshUVsFromPlanarProjection_TargetMesh_IsValid;

	private static FFieldAddress SetMeshUVsFromPlanarProjection_TargetMesh_PropertyAddress;

	private static int SetMeshUVsFromPlanarProjection_TargetMesh_Offset;

	private static bool SetMeshUVsFromPlanarProjection_UVSetIndex_IsValid;

	private static FFieldAddress SetMeshUVsFromPlanarProjection_UVSetIndex_PropertyAddress;

	private static int SetMeshUVsFromPlanarProjection_UVSetIndex_Offset;

	private static bool SetMeshUVsFromPlanarProjection_PlaneTransform_IsValid;

	private static FFieldAddress SetMeshUVsFromPlanarProjection_PlaneTransform_PropertyAddress;

	private static int SetMeshUVsFromPlanarProjection_PlaneTransform_Offset;

	private static bool SetMeshUVsFromPlanarProjection_Debug_IsValid;

	private static FFieldAddress SetMeshUVsFromPlanarProjection_Debug_PropertyAddress;

	private static int SetMeshUVsFromPlanarProjection_Debug_Offset;

	private static bool SetMeshUVsFromPlanarProjection_ReturnValue_IsValid;

	private static FFieldAddress SetMeshUVsFromPlanarProjection_ReturnValue_PropertyAddress;

	private static int SetMeshUVsFromPlanarProjection_ReturnValue_Offset;

	private static bool SetMeshUVsFromCylinderProjection_IsValid;

	private static IntPtr SetMeshUVsFromCylinderProjection_FunctionAddress;

	private static int SetMeshUVsFromCylinderProjection_ParamsSize;

	private static bool SetMeshUVsFromCylinderProjection_TargetMesh_IsValid;

	private static FFieldAddress SetMeshUVsFromCylinderProjection_TargetMesh_PropertyAddress;

	private static int SetMeshUVsFromCylinderProjection_TargetMesh_Offset;

	private static bool SetMeshUVsFromCylinderProjection_UVSetIndex_IsValid;

	private static FFieldAddress SetMeshUVsFromCylinderProjection_UVSetIndex_PropertyAddress;

	private static int SetMeshUVsFromCylinderProjection_UVSetIndex_Offset;

	private static bool SetMeshUVsFromCylinderProjection_CylinderTransform_IsValid;

	private static FFieldAddress SetMeshUVsFromCylinderProjection_CylinderTransform_PropertyAddress;

	private static int SetMeshUVsFromCylinderProjection_CylinderTransform_Offset;

	private static bool SetMeshUVsFromCylinderProjection_SplitAngle_IsValid;

	private static FFieldAddress SetMeshUVsFromCylinderProjection_SplitAngle_PropertyAddress;

	private static int SetMeshUVsFromCylinderProjection_SplitAngle_Offset;

	private static bool SetMeshUVsFromCylinderProjection_Debug_IsValid;

	private static FFieldAddress SetMeshUVsFromCylinderProjection_Debug_PropertyAddress;

	private static int SetMeshUVsFromCylinderProjection_Debug_Offset;

	private static bool SetMeshUVsFromCylinderProjection_ReturnValue_IsValid;

	private static FFieldAddress SetMeshUVsFromCylinderProjection_ReturnValue_PropertyAddress;

	private static int SetMeshUVsFromCylinderProjection_ReturnValue_Offset;

	private static bool SetMeshUVsFromBoxProjection_IsValid;

	private static IntPtr SetMeshUVsFromBoxProjection_FunctionAddress;

	private static int SetMeshUVsFromBoxProjection_ParamsSize;

	private static bool SetMeshUVsFromBoxProjection_TargetMesh_IsValid;

	private static FFieldAddress SetMeshUVsFromBoxProjection_TargetMesh_PropertyAddress;

	private static int SetMeshUVsFromBoxProjection_TargetMesh_Offset;

	private static bool SetMeshUVsFromBoxProjection_UVSetIndex_IsValid;

	private static FFieldAddress SetMeshUVsFromBoxProjection_UVSetIndex_PropertyAddress;

	private static int SetMeshUVsFromBoxProjection_UVSetIndex_Offset;

	private static bool SetMeshUVsFromBoxProjection_BoxTransform_IsValid;

	private static FFieldAddress SetMeshUVsFromBoxProjection_BoxTransform_PropertyAddress;

	private static int SetMeshUVsFromBoxProjection_BoxTransform_Offset;

	private static bool SetMeshUVsFromBoxProjection_MinIslandTriCount_IsValid;

	private static FFieldAddress SetMeshUVsFromBoxProjection_MinIslandTriCount_PropertyAddress;

	private static int SetMeshUVsFromBoxProjection_MinIslandTriCount_Offset;

	private static bool SetMeshUVsFromBoxProjection_Debug_IsValid;

	private static FFieldAddress SetMeshUVsFromBoxProjection_Debug_PropertyAddress;

	private static int SetMeshUVsFromBoxProjection_Debug_Offset;

	private static bool SetMeshUVsFromBoxProjection_ReturnValue_IsValid;

	private static FFieldAddress SetMeshUVsFromBoxProjection_ReturnValue_PropertyAddress;

	private static int SetMeshUVsFromBoxProjection_ReturnValue_Offset;

	private static bool SetMeshTriangleUVs_IsValid;

	private static IntPtr SetMeshTriangleUVs_FunctionAddress;

	private static int SetMeshTriangleUVs_ParamsSize;

	private static bool SetMeshTriangleUVs_TargetMesh_IsValid;

	private static FFieldAddress SetMeshTriangleUVs_TargetMesh_PropertyAddress;

	private static int SetMeshTriangleUVs_TargetMesh_Offset;

	private static bool SetMeshTriangleUVs_UVSetIndex_IsValid;

	private static FFieldAddress SetMeshTriangleUVs_UVSetIndex_PropertyAddress;

	private static int SetMeshTriangleUVs_UVSetIndex_Offset;

	private static bool SetMeshTriangleUVs_TriangleID_IsValid;

	private static FFieldAddress SetMeshTriangleUVs_TriangleID_PropertyAddress;

	private static int SetMeshTriangleUVs_TriangleID_Offset;

	private static bool SetMeshTriangleUVs_UVs_IsValid;

	private static FFieldAddress SetMeshTriangleUVs_UVs_PropertyAddress;

	private static int SetMeshTriangleUVs_UVs_Offset;

	private static bool SetMeshTriangleUVs_bIsValidTriangle_IsValid;

	private static FFieldAddress SetMeshTriangleUVs_bIsValidTriangle_PropertyAddress;

	private static int SetMeshTriangleUVs_bIsValidTriangle_Offset;

	private static bool SetMeshTriangleUVs_bDeferChangeNotifications_IsValid;

	private static FFieldAddress SetMeshTriangleUVs_bDeferChangeNotifications_PropertyAddress;

	private static int SetMeshTriangleUVs_bDeferChangeNotifications_Offset;

	private static bool SetMeshTriangleUVs_ReturnValue_IsValid;

	private static FFieldAddress SetMeshTriangleUVs_ReturnValue_PropertyAddress;

	private static int SetMeshTriangleUVs_ReturnValue_Offset;

	private static bool ScaleMeshUVs_IsValid;

	private static IntPtr ScaleMeshUVs_FunctionAddress;

	private static int ScaleMeshUVs_ParamsSize;

	private static bool ScaleMeshUVs_TargetMesh_IsValid;

	private static FFieldAddress ScaleMeshUVs_TargetMesh_PropertyAddress;

	private static int ScaleMeshUVs_TargetMesh_Offset;

	private static bool ScaleMeshUVs_UVSetIndex_IsValid;

	private static FFieldAddress ScaleMeshUVs_UVSetIndex_PropertyAddress;

	private static int ScaleMeshUVs_UVSetIndex_Offset;

	private static bool ScaleMeshUVs_Scale_IsValid;

	private static FFieldAddress ScaleMeshUVs_Scale_PropertyAddress;

	private static int ScaleMeshUVs_Scale_Offset;

	private static bool ScaleMeshUVs_ScaleOrigin_IsValid;

	private static FFieldAddress ScaleMeshUVs_ScaleOrigin_PropertyAddress;

	private static int ScaleMeshUVs_ScaleOrigin_Offset;

	private static bool ScaleMeshUVs_Debug_IsValid;

	private static FFieldAddress ScaleMeshUVs_Debug_PropertyAddress;

	private static int ScaleMeshUVs_Debug_Offset;

	private static bool ScaleMeshUVs_ReturnValue_IsValid;

	private static FFieldAddress ScaleMeshUVs_ReturnValue_PropertyAddress;

	private static int ScaleMeshUVs_ReturnValue_Offset;

	private static bool RotateMeshUVs_IsValid;

	private static IntPtr RotateMeshUVs_FunctionAddress;

	private static int RotateMeshUVs_ParamsSize;

	private static bool RotateMeshUVs_TargetMesh_IsValid;

	private static FFieldAddress RotateMeshUVs_TargetMesh_PropertyAddress;

	private static int RotateMeshUVs_TargetMesh_Offset;

	private static bool RotateMeshUVs_UVSetIndex_IsValid;

	private static FFieldAddress RotateMeshUVs_UVSetIndex_PropertyAddress;

	private static int RotateMeshUVs_UVSetIndex_Offset;

	private static bool RotateMeshUVs_RotationAngle_IsValid;

	private static FFieldAddress RotateMeshUVs_RotationAngle_PropertyAddress;

	private static int RotateMeshUVs_RotationAngle_Offset;

	private static bool RotateMeshUVs_RotationOrigin_IsValid;

	private static FFieldAddress RotateMeshUVs_RotationOrigin_PropertyAddress;

	private static int RotateMeshUVs_RotationOrigin_Offset;

	private static bool RotateMeshUVs_Debug_IsValid;

	private static FFieldAddress RotateMeshUVs_Debug_PropertyAddress;

	private static int RotateMeshUVs_Debug_Offset;

	private static bool RotateMeshUVs_ReturnValue_IsValid;

	private static FFieldAddress RotateMeshUVs_ReturnValue_PropertyAddress;

	private static int RotateMeshUVs_ReturnValue_Offset;

	private static bool RepackMeshUVs_IsValid;

	private static IntPtr RepackMeshUVs_FunctionAddress;

	private static int RepackMeshUVs_ParamsSize;

	private static bool RepackMeshUVs_TargetMesh_IsValid;

	private static FFieldAddress RepackMeshUVs_TargetMesh_PropertyAddress;

	private static int RepackMeshUVs_TargetMesh_Offset;

	private static bool RepackMeshUVs_UVSetIndex_IsValid;

	private static FFieldAddress RepackMeshUVs_UVSetIndex_PropertyAddress;

	private static int RepackMeshUVs_UVSetIndex_Offset;

	private static bool RepackMeshUVs_RepackOptions_IsValid;

	private static FFieldAddress RepackMeshUVs_RepackOptions_PropertyAddress;

	private static int RepackMeshUVs_RepackOptions_Offset;

	private static bool RepackMeshUVs_Debug_IsValid;

	private static FFieldAddress RepackMeshUVs_Debug_PropertyAddress;

	private static int RepackMeshUVs_Debug_Offset;

	private static bool RepackMeshUVs_ReturnValue_IsValid;

	private static FFieldAddress RepackMeshUVs_ReturnValue_PropertyAddress;

	private static int RepackMeshUVs_ReturnValue_Offset;

	private static bool RecomputeMeshUVs_IsValid;

	private static IntPtr RecomputeMeshUVs_FunctionAddress;

	private static int RecomputeMeshUVs_ParamsSize;

	private static bool RecomputeMeshUVs_TargetMesh_IsValid;

	private static FFieldAddress RecomputeMeshUVs_TargetMesh_PropertyAddress;

	private static int RecomputeMeshUVs_TargetMesh_Offset;

	private static bool RecomputeMeshUVs_UVSetIndex_IsValid;

	private static FFieldAddress RecomputeMeshUVs_UVSetIndex_PropertyAddress;

	private static int RecomputeMeshUVs_UVSetIndex_Offset;

	private static bool RecomputeMeshUVs_Options_IsValid;

	private static FFieldAddress RecomputeMeshUVs_Options_PropertyAddress;

	private static int RecomputeMeshUVs_Options_Offset;

	private static bool RecomputeMeshUVs_Debug_IsValid;

	private static FFieldAddress RecomputeMeshUVs_Debug_PropertyAddress;

	private static int RecomputeMeshUVs_Debug_Offset;

	private static bool RecomputeMeshUVs_ReturnValue_IsValid;

	private static FFieldAddress RecomputeMeshUVs_ReturnValue_PropertyAddress;

	private static int RecomputeMeshUVs_ReturnValue_Offset;

	private static bool CopyUVSet_IsValid;

	private static IntPtr CopyUVSet_FunctionAddress;

	private static int CopyUVSet_ParamsSize;

	private static bool CopyUVSet_TargetMesh_IsValid;

	private static FFieldAddress CopyUVSet_TargetMesh_PropertyAddress;

	private static int CopyUVSet_TargetMesh_Offset;

	private static bool CopyUVSet_FromUVSet_IsValid;

	private static FFieldAddress CopyUVSet_FromUVSet_PropertyAddress;

	private static int CopyUVSet_FromUVSet_Offset;

	private static bool CopyUVSet_ToUVSet_IsValid;

	private static FFieldAddress CopyUVSet_ToUVSet_PropertyAddress;

	private static int CopyUVSet_ToUVSet_Offset;

	private static bool CopyUVSet_Debug_IsValid;

	private static FFieldAddress CopyUVSet_Debug_PropertyAddress;

	private static int CopyUVSet_Debug_Offset;

	private static bool CopyUVSet_ReturnValue_IsValid;

	private static FFieldAddress CopyUVSet_ReturnValue_PropertyAddress;

	private static int CopyUVSet_ReturnValue_Offset;

	private static bool AutoGenerateXAtlasMeshUVs_IsValid;

	private static IntPtr AutoGenerateXAtlasMeshUVs_FunctionAddress;

	private static int AutoGenerateXAtlasMeshUVs_ParamsSize;

	private static bool AutoGenerateXAtlasMeshUVs_TargetMesh_IsValid;

	private static FFieldAddress AutoGenerateXAtlasMeshUVs_TargetMesh_PropertyAddress;

	private static int AutoGenerateXAtlasMeshUVs_TargetMesh_Offset;

	private static bool AutoGenerateXAtlasMeshUVs_UVSetIndex_IsValid;

	private static FFieldAddress AutoGenerateXAtlasMeshUVs_UVSetIndex_PropertyAddress;

	private static int AutoGenerateXAtlasMeshUVs_UVSetIndex_Offset;

	private static bool AutoGenerateXAtlasMeshUVs_Options_IsValid;

	private static FFieldAddress AutoGenerateXAtlasMeshUVs_Options_PropertyAddress;

	private static int AutoGenerateXAtlasMeshUVs_Options_Offset;

	private static bool AutoGenerateXAtlasMeshUVs_Debug_IsValid;

	private static FFieldAddress AutoGenerateXAtlasMeshUVs_Debug_PropertyAddress;

	private static int AutoGenerateXAtlasMeshUVs_Debug_Offset;

	private static bool AutoGenerateXAtlasMeshUVs_ReturnValue_IsValid;

	private static FFieldAddress AutoGenerateXAtlasMeshUVs_ReturnValue_PropertyAddress;

	private static int AutoGenerateXAtlasMeshUVs_ReturnValue_Offset;

	private static bool AutoGeneratePatchBuilderMeshUVs_IsValid;

	private static IntPtr AutoGeneratePatchBuilderMeshUVs_FunctionAddress;

	private static int AutoGeneratePatchBuilderMeshUVs_ParamsSize;

	private static bool AutoGeneratePatchBuilderMeshUVs_TargetMesh_IsValid;

	private static FFieldAddress AutoGeneratePatchBuilderMeshUVs_TargetMesh_PropertyAddress;

	private static int AutoGeneratePatchBuilderMeshUVs_TargetMesh_Offset;

	private static bool AutoGeneratePatchBuilderMeshUVs_UVSetIndex_IsValid;

	private static FFieldAddress AutoGeneratePatchBuilderMeshUVs_UVSetIndex_PropertyAddress;

	private static int AutoGeneratePatchBuilderMeshUVs_UVSetIndex_Offset;

	private static bool AutoGeneratePatchBuilderMeshUVs_Options_IsValid;

	private static FFieldAddress AutoGeneratePatchBuilderMeshUVs_Options_PropertyAddress;

	private static int AutoGeneratePatchBuilderMeshUVs_Options_Offset;

	private static bool AutoGeneratePatchBuilderMeshUVs_Debug_IsValid;

	private static FFieldAddress AutoGeneratePatchBuilderMeshUVs_Debug_PropertyAddress;

	private static int AutoGeneratePatchBuilderMeshUVs_Debug_Offset;

	private static bool AutoGeneratePatchBuilderMeshUVs_ReturnValue_IsValid;

	private static FFieldAddress AutoGeneratePatchBuilderMeshUVs_ReturnValue_PropertyAddress;

	private static int AutoGeneratePatchBuilderMeshUVs_ReturnValue_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:TranslateMeshUVs")]
	public unsafe static UDynamicMesh TranslateMeshUVs(UDynamicMesh TargetMesh, int UVSetIndex, FVector2D Translation, UGeometryScriptDebug Debug)
	{
		if (!TranslateMeshUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:TranslateMeshUVs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TranslateMeshUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TranslateMeshUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, TranslateMeshUVs_TargetMesh_Offset), 0, TranslateMeshUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TranslateMeshUVs_UVSetIndex_Offset), 0, TranslateMeshUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, TranslateMeshUVs_Translation_Offset), 0, TranslateMeshUVs_Translation_PropertyAddress.Address, Translation);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, TranslateMeshUVs_Debug_Offset), 0, TranslateMeshUVs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TranslateMeshUVs_FunctionAddress, intPtr, TranslateMeshUVs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, TranslateMeshUVs_ReturnValue_Offset), 0, TranslateMeshUVs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetNumUVSets")]
	public unsafe static UDynamicMesh SetNumUVSets(UDynamicMesh TargetMesh, int NumUVSets, UGeometryScriptDebug Debug)
	{
		if (!SetNumUVSets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetNumUVSets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumUVSets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumUVSets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetNumUVSets_TargetMesh_Offset), 0, SetNumUVSets_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumUVSets_NumUVSets_Offset), 0, SetNumUVSets_NumUVSets_PropertyAddress.Address, NumUVSets);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetNumUVSets_Debug_Offset), 0, SetNumUVSets_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNumUVSets_FunctionAddress, intPtr, SetNumUVSets_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetNumUVSets_ReturnValue_Offset), 0, SetNumUVSets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromPlanarProjection")]
	public unsafe static UDynamicMesh SetMeshUVsFromPlanarProjection(UDynamicMesh TargetMesh, int UVSetIndex, FTransform PlaneTransform, UGeometryScriptDebug Debug)
	{
		if (!SetMeshUVsFromPlanarProjection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromPlanarProjection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshUVsFromPlanarProjection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshUVsFromPlanarProjection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromPlanarProjection_TargetMesh_Offset), 0, SetMeshUVsFromPlanarProjection_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromPlanarProjection_UVSetIndex_Offset), 0, SetMeshUVsFromPlanarProjection_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InitializeValue_InContainer(SetMeshUVsFromPlanarProjection_PlaneTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromPlanarProjection_PlaneTransform_Offset), 0, SetMeshUVsFromPlanarProjection_PlaneTransform_PropertyAddress.Address, PlaneTransform);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromPlanarProjection_Debug_Offset), 0, SetMeshUVsFromPlanarProjection_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMeshUVsFromPlanarProjection_FunctionAddress, intPtr, SetMeshUVsFromPlanarProjection_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetMeshUVsFromPlanarProjection_ReturnValue_Offset), 0, SetMeshUVsFromPlanarProjection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromCylinderProjection")]
	public unsafe static UDynamicMesh SetMeshUVsFromCylinderProjection(UDynamicMesh TargetMesh, int UVSetIndex, FTransform CylinderTransform, float SplitAngle, UGeometryScriptDebug Debug)
	{
		if (!SetMeshUVsFromCylinderProjection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromCylinderProjection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshUVsFromCylinderProjection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshUVsFromCylinderProjection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromCylinderProjection_TargetMesh_Offset), 0, SetMeshUVsFromCylinderProjection_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromCylinderProjection_UVSetIndex_Offset), 0, SetMeshUVsFromCylinderProjection_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InitializeValue_InContainer(SetMeshUVsFromCylinderProjection_CylinderTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromCylinderProjection_CylinderTransform_Offset), 0, SetMeshUVsFromCylinderProjection_CylinderTransform_PropertyAddress.Address, CylinderTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromCylinderProjection_SplitAngle_Offset), 0, SetMeshUVsFromCylinderProjection_SplitAngle_PropertyAddress.Address, SplitAngle);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromCylinderProjection_Debug_Offset), 0, SetMeshUVsFromCylinderProjection_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMeshUVsFromCylinderProjection_FunctionAddress, intPtr, SetMeshUVsFromCylinderProjection_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetMeshUVsFromCylinderProjection_ReturnValue_Offset), 0, SetMeshUVsFromCylinderProjection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromBoxProjection")]
	public unsafe static UDynamicMesh SetMeshUVsFromBoxProjection(UDynamicMesh TargetMesh, int UVSetIndex, FTransform BoxTransform, int MinIslandTriCount, UGeometryScriptDebug Debug)
	{
		if (!SetMeshUVsFromBoxProjection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromBoxProjection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshUVsFromBoxProjection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshUVsFromBoxProjection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromBoxProjection_TargetMesh_Offset), 0, SetMeshUVsFromBoxProjection_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromBoxProjection_UVSetIndex_Offset), 0, SetMeshUVsFromBoxProjection_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InitializeValue_InContainer(SetMeshUVsFromBoxProjection_BoxTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromBoxProjection_BoxTransform_Offset), 0, SetMeshUVsFromBoxProjection_BoxTransform_PropertyAddress.Address, BoxTransform);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromBoxProjection_MinIslandTriCount_Offset), 0, SetMeshUVsFromBoxProjection_MinIslandTriCount_PropertyAddress.Address, MinIslandTriCount);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetMeshUVsFromBoxProjection_Debug_Offset), 0, SetMeshUVsFromBoxProjection_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMeshUVsFromBoxProjection_FunctionAddress, intPtr, SetMeshUVsFromBoxProjection_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetMeshUVsFromBoxProjection_ReturnValue_Offset), 0, SetMeshUVsFromBoxProjection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshTriangleUVs")]
	public unsafe static UDynamicMesh SetMeshTriangleUVs(UDynamicMesh TargetMesh, int UVSetIndex, int TriangleID, FGeometryScriptUVTriangle UVs, out bool bIsValidTriangle, bool bDeferChangeNotifications = false)
	{
		if (!SetMeshTriangleUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshTriangleUVs");
			bIsValidTriangle = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshTriangleUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshTriangleUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetMeshTriangleUVs_TargetMesh_Offset), 0, SetMeshTriangleUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshTriangleUVs_UVSetIndex_Offset), 0, SetMeshTriangleUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshTriangleUVs_TriangleID_Offset), 0, SetMeshTriangleUVs_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InitializeValue_InContainer(SetMeshTriangleUVs_UVs_PropertyAddress.Address, intPtr);
		FGeometryScriptUVTriangle.ToNative(IntPtr.Add(intPtr, SetMeshTriangleUVs_UVs_Offset), 0, SetMeshTriangleUVs_UVs_PropertyAddress.Address, UVs);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMeshTriangleUVs_bDeferChangeNotifications_Offset), 0, SetMeshTriangleUVs_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMeshTriangleUVs_FunctionAddress, intPtr, SetMeshTriangleUVs_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMeshTriangleUVs_bIsValidTriangle_Offset), 0, SetMeshTriangleUVs_bIsValidTriangle_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetMeshTriangleUVs_ReturnValue_Offset), 0, SetMeshTriangleUVs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:ScaleMeshUVs")]
	public unsafe static UDynamicMesh ScaleMeshUVs(UDynamicMesh TargetMesh, int UVSetIndex, FVector2D Scale, FVector2D ScaleOrigin, UGeometryScriptDebug Debug)
	{
		if (!ScaleMeshUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:ScaleMeshUVs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScaleMeshUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScaleMeshUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ScaleMeshUVs_TargetMesh_Offset), 0, ScaleMeshUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScaleMeshUVs_UVSetIndex_Offset), 0, ScaleMeshUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ScaleMeshUVs_Scale_Offset), 0, ScaleMeshUVs_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ScaleMeshUVs_ScaleOrigin_Offset), 0, ScaleMeshUVs_ScaleOrigin_PropertyAddress.Address, ScaleOrigin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ScaleMeshUVs_Debug_Offset), 0, ScaleMeshUVs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScaleMeshUVs_FunctionAddress, intPtr, ScaleMeshUVs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ScaleMeshUVs_ReturnValue_Offset), 0, ScaleMeshUVs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RotateMeshUVs")]
	public unsafe static UDynamicMesh RotateMeshUVs(UDynamicMesh TargetMesh, int UVSetIndex, float RotationAngle, FVector2D RotationOrigin, UGeometryScriptDebug Debug)
	{
		if (!RotateMeshUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RotateMeshUVs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RotateMeshUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RotateMeshUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RotateMeshUVs_TargetMesh_Offset), 0, RotateMeshUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RotateMeshUVs_UVSetIndex_Offset), 0, RotateMeshUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RotateMeshUVs_RotationAngle_Offset), 0, RotateMeshUVs_RotationAngle_PropertyAddress.Address, RotationAngle);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, RotateMeshUVs_RotationOrigin_Offset), 0, RotateMeshUVs_RotationOrigin_PropertyAddress.Address, RotationOrigin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RotateMeshUVs_Debug_Offset), 0, RotateMeshUVs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RotateMeshUVs_FunctionAddress, intPtr, RotateMeshUVs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RotateMeshUVs_ReturnValue_Offset), 0, RotateMeshUVs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RepackMeshUVs")]
	public unsafe static UDynamicMesh RepackMeshUVs(UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptRepackUVsOptions RepackOptions, UGeometryScriptDebug Debug)
	{
		if (!RepackMeshUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RepackMeshUVs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RepackMeshUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RepackMeshUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RepackMeshUVs_TargetMesh_Offset), 0, RepackMeshUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RepackMeshUVs_UVSetIndex_Offset), 0, RepackMeshUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InitializeValue_InContainer(RepackMeshUVs_RepackOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptRepackUVsOptions.ToNative(IntPtr.Add(intPtr, RepackMeshUVs_RepackOptions_Offset), 0, RepackMeshUVs_RepackOptions_PropertyAddress.Address, RepackOptions);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RepackMeshUVs_Debug_Offset), 0, RepackMeshUVs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RepackMeshUVs_FunctionAddress, intPtr, RepackMeshUVs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RepackMeshUVs_ReturnValue_Offset), 0, RepackMeshUVs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RecomputeMeshUVs")]
	public unsafe static UDynamicMesh RecomputeMeshUVs(UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptRecomputeUVsOptions Options, UGeometryScriptDebug Debug)
	{
		if (!RecomputeMeshUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RecomputeMeshUVs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputeMeshUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputeMeshUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RecomputeMeshUVs_TargetMesh_Offset), 0, RecomputeMeshUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RecomputeMeshUVs_UVSetIndex_Offset), 0, RecomputeMeshUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InitializeValue_InContainer(RecomputeMeshUVs_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptRecomputeUVsOptions.ToNative(IntPtr.Add(intPtr, RecomputeMeshUVs_Options_Offset), 0, RecomputeMeshUVs_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RecomputeMeshUVs_Debug_Offset), 0, RecomputeMeshUVs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecomputeMeshUVs_FunctionAddress, intPtr, RecomputeMeshUVs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RecomputeMeshUVs_ReturnValue_Offset), 0, RecomputeMeshUVs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:CopyUVSet")]
	public unsafe static UDynamicMesh CopyUVSet(UDynamicMesh TargetMesh, int FromUVSet, int ToUVSet, UGeometryScriptDebug Debug)
	{
		if (!CopyUVSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:CopyUVSet");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyUVSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyUVSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CopyUVSet_TargetMesh_Offset), 0, CopyUVSet_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CopyUVSet_FromUVSet_Offset), 0, CopyUVSet_FromUVSet_PropertyAddress.Address, FromUVSet);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CopyUVSet_ToUVSet_Offset), 0, CopyUVSet_ToUVSet_PropertyAddress.Address, ToUVSet);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CopyUVSet_Debug_Offset), 0, CopyUVSet_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyUVSet_FunctionAddress, intPtr, CopyUVSet_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyUVSet_ReturnValue_Offset), 0, CopyUVSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:AutoGenerateXAtlasMeshUVs")]
	public unsafe static UDynamicMesh AutoGenerateXAtlasMeshUVs(UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptXAtlasOptions Options, UGeometryScriptDebug Debug)
	{
		if (!AutoGenerateXAtlasMeshUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:AutoGenerateXAtlasMeshUVs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutoGenerateXAtlasMeshUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutoGenerateXAtlasMeshUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AutoGenerateXAtlasMeshUVs_TargetMesh_Offset), 0, AutoGenerateXAtlasMeshUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AutoGenerateXAtlasMeshUVs_UVSetIndex_Offset), 0, AutoGenerateXAtlasMeshUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InitializeValue_InContainer(AutoGenerateXAtlasMeshUVs_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptXAtlasOptions.ToNative(IntPtr.Add(intPtr, AutoGenerateXAtlasMeshUVs_Options_Offset), 0, AutoGenerateXAtlasMeshUVs_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AutoGenerateXAtlasMeshUVs_Debug_Offset), 0, AutoGenerateXAtlasMeshUVs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutoGenerateXAtlasMeshUVs_FunctionAddress, intPtr, AutoGenerateXAtlasMeshUVs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AutoGenerateXAtlasMeshUVs_ReturnValue_Offset), 0, AutoGenerateXAtlasMeshUVs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:AutoGeneratePatchBuilderMeshUVs")]
	public unsafe static UDynamicMesh AutoGeneratePatchBuilderMeshUVs(UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptPatchBuilderOptions Options, UGeometryScriptDebug Debug)
	{
		if (!AutoGeneratePatchBuilderMeshUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:AutoGeneratePatchBuilderMeshUVs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutoGeneratePatchBuilderMeshUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutoGeneratePatchBuilderMeshUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AutoGeneratePatchBuilderMeshUVs_TargetMesh_Offset), 0, AutoGeneratePatchBuilderMeshUVs_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AutoGeneratePatchBuilderMeshUVs_UVSetIndex_Offset), 0, AutoGeneratePatchBuilderMeshUVs_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		NativeReflection.InitializeValue_InContainer(AutoGeneratePatchBuilderMeshUVs_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptPatchBuilderOptions.ToNative(IntPtr.Add(intPtr, AutoGeneratePatchBuilderMeshUVs_Options_Offset), 0, AutoGeneratePatchBuilderMeshUVs_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AutoGeneratePatchBuilderMeshUVs_Debug_Offset), 0, AutoGeneratePatchBuilderMeshUVs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutoGeneratePatchBuilderMeshUVs_FunctionAddress, intPtr, AutoGeneratePatchBuilderMeshUVs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AutoGeneratePatchBuilderMeshUVs_ReturnValue_Offset), 0, AutoGeneratePatchBuilderMeshUVs_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_UVs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_UVs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_UVs));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions");
		TranslateMeshUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TranslateMeshUVs");
		TranslateMeshUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(TranslateMeshUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TranslateMeshUVs_TargetMesh_PropertyAddress, TranslateMeshUVs_FunctionAddress, "TargetMesh");
		TranslateMeshUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMeshUVs_FunctionAddress, "TargetMesh");
		TranslateMeshUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMeshUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateMeshUVs_UVSetIndex_PropertyAddress, TranslateMeshUVs_FunctionAddress, "UVSetIndex");
		TranslateMeshUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMeshUVs_FunctionAddress, "UVSetIndex");
		TranslateMeshUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMeshUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateMeshUVs_Translation_PropertyAddress, TranslateMeshUVs_FunctionAddress, "Translation");
		TranslateMeshUVs_Translation_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMeshUVs_FunctionAddress, "Translation");
		TranslateMeshUVs_Translation_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMeshUVs_FunctionAddress, "Translation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateMeshUVs_Debug_PropertyAddress, TranslateMeshUVs_FunctionAddress, "Debug");
		TranslateMeshUVs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMeshUVs_FunctionAddress, "Debug");
		TranslateMeshUVs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMeshUVs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateMeshUVs_ReturnValue_PropertyAddress, TranslateMeshUVs_FunctionAddress, "ReturnValue");
		TranslateMeshUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMeshUVs_FunctionAddress, "ReturnValue");
		TranslateMeshUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMeshUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TranslateMeshUVs_IsValid = TranslateMeshUVs_FunctionAddress != IntPtr.Zero && TranslateMeshUVs_TargetMesh_IsValid && TranslateMeshUVs_UVSetIndex_IsValid && TranslateMeshUVs_Translation_IsValid && TranslateMeshUVs_Debug_IsValid && TranslateMeshUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:TranslateMeshUVs", TranslateMeshUVs_IsValid);
		SetNumUVSets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNumUVSets");
		SetNumUVSets_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumUVSets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumUVSets_TargetMesh_PropertyAddress, SetNumUVSets_FunctionAddress, "TargetMesh");
		SetNumUVSets_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetNumUVSets_FunctionAddress, "TargetMesh");
		SetNumUVSets_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumUVSets_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumUVSets_NumUVSets_PropertyAddress, SetNumUVSets_FunctionAddress, "NumUVSets");
		SetNumUVSets_NumUVSets_Offset = NativeReflectionCached.GetPropertyOffset(SetNumUVSets_FunctionAddress, "NumUVSets");
		SetNumUVSets_NumUVSets_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumUVSets_FunctionAddress, "NumUVSets", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumUVSets_Debug_PropertyAddress, SetNumUVSets_FunctionAddress, "Debug");
		SetNumUVSets_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetNumUVSets_FunctionAddress, "Debug");
		SetNumUVSets_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumUVSets_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumUVSets_ReturnValue_PropertyAddress, SetNumUVSets_FunctionAddress, "ReturnValue");
		SetNumUVSets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNumUVSets_FunctionAddress, "ReturnValue");
		SetNumUVSets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumUVSets_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetNumUVSets_IsValid = SetNumUVSets_FunctionAddress != IntPtr.Zero && SetNumUVSets_TargetMesh_IsValid && SetNumUVSets_NumUVSets_IsValid && SetNumUVSets_Debug_IsValid && SetNumUVSets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetNumUVSets", SetNumUVSets_IsValid);
		SetMeshUVsFromPlanarProjection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMeshUVsFromPlanarProjection");
		SetMeshUVsFromPlanarProjection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshUVsFromPlanarProjection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromPlanarProjection_TargetMesh_PropertyAddress, SetMeshUVsFromPlanarProjection_FunctionAddress, "TargetMesh");
		SetMeshUVsFromPlanarProjection_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromPlanarProjection_FunctionAddress, "TargetMesh");
		SetMeshUVsFromPlanarProjection_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromPlanarProjection_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromPlanarProjection_UVSetIndex_PropertyAddress, SetMeshUVsFromPlanarProjection_FunctionAddress, "UVSetIndex");
		SetMeshUVsFromPlanarProjection_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromPlanarProjection_FunctionAddress, "UVSetIndex");
		SetMeshUVsFromPlanarProjection_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromPlanarProjection_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromPlanarProjection_PlaneTransform_PropertyAddress, SetMeshUVsFromPlanarProjection_FunctionAddress, "PlaneTransform");
		SetMeshUVsFromPlanarProjection_PlaneTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromPlanarProjection_FunctionAddress, "PlaneTransform");
		SetMeshUVsFromPlanarProjection_PlaneTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromPlanarProjection_FunctionAddress, "PlaneTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromPlanarProjection_Debug_PropertyAddress, SetMeshUVsFromPlanarProjection_FunctionAddress, "Debug");
		SetMeshUVsFromPlanarProjection_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromPlanarProjection_FunctionAddress, "Debug");
		SetMeshUVsFromPlanarProjection_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromPlanarProjection_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromPlanarProjection_ReturnValue_PropertyAddress, SetMeshUVsFromPlanarProjection_FunctionAddress, "ReturnValue");
		SetMeshUVsFromPlanarProjection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromPlanarProjection_FunctionAddress, "ReturnValue");
		SetMeshUVsFromPlanarProjection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromPlanarProjection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMeshUVsFromPlanarProjection_IsValid = SetMeshUVsFromPlanarProjection_FunctionAddress != IntPtr.Zero && SetMeshUVsFromPlanarProjection_TargetMesh_IsValid && SetMeshUVsFromPlanarProjection_UVSetIndex_IsValid && SetMeshUVsFromPlanarProjection_PlaneTransform_IsValid && SetMeshUVsFromPlanarProjection_Debug_IsValid && SetMeshUVsFromPlanarProjection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromPlanarProjection", SetMeshUVsFromPlanarProjection_IsValid);
		SetMeshUVsFromCylinderProjection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMeshUVsFromCylinderProjection");
		SetMeshUVsFromCylinderProjection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshUVsFromCylinderProjection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromCylinderProjection_TargetMesh_PropertyAddress, SetMeshUVsFromCylinderProjection_FunctionAddress, "TargetMesh");
		SetMeshUVsFromCylinderProjection_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromCylinderProjection_FunctionAddress, "TargetMesh");
		SetMeshUVsFromCylinderProjection_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromCylinderProjection_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromCylinderProjection_UVSetIndex_PropertyAddress, SetMeshUVsFromCylinderProjection_FunctionAddress, "UVSetIndex");
		SetMeshUVsFromCylinderProjection_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromCylinderProjection_FunctionAddress, "UVSetIndex");
		SetMeshUVsFromCylinderProjection_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromCylinderProjection_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromCylinderProjection_CylinderTransform_PropertyAddress, SetMeshUVsFromCylinderProjection_FunctionAddress, "CylinderTransform");
		SetMeshUVsFromCylinderProjection_CylinderTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromCylinderProjection_FunctionAddress, "CylinderTransform");
		SetMeshUVsFromCylinderProjection_CylinderTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromCylinderProjection_FunctionAddress, "CylinderTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromCylinderProjection_SplitAngle_PropertyAddress, SetMeshUVsFromCylinderProjection_FunctionAddress, "SplitAngle");
		SetMeshUVsFromCylinderProjection_SplitAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromCylinderProjection_FunctionAddress, "SplitAngle");
		SetMeshUVsFromCylinderProjection_SplitAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromCylinderProjection_FunctionAddress, "SplitAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromCylinderProjection_Debug_PropertyAddress, SetMeshUVsFromCylinderProjection_FunctionAddress, "Debug");
		SetMeshUVsFromCylinderProjection_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromCylinderProjection_FunctionAddress, "Debug");
		SetMeshUVsFromCylinderProjection_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromCylinderProjection_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromCylinderProjection_ReturnValue_PropertyAddress, SetMeshUVsFromCylinderProjection_FunctionAddress, "ReturnValue");
		SetMeshUVsFromCylinderProjection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromCylinderProjection_FunctionAddress, "ReturnValue");
		SetMeshUVsFromCylinderProjection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromCylinderProjection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMeshUVsFromCylinderProjection_IsValid = SetMeshUVsFromCylinderProjection_FunctionAddress != IntPtr.Zero && SetMeshUVsFromCylinderProjection_TargetMesh_IsValid && SetMeshUVsFromCylinderProjection_UVSetIndex_IsValid && SetMeshUVsFromCylinderProjection_CylinderTransform_IsValid && SetMeshUVsFromCylinderProjection_SplitAngle_IsValid && SetMeshUVsFromCylinderProjection_Debug_IsValid && SetMeshUVsFromCylinderProjection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromCylinderProjection", SetMeshUVsFromCylinderProjection_IsValid);
		SetMeshUVsFromBoxProjection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMeshUVsFromBoxProjection");
		SetMeshUVsFromBoxProjection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshUVsFromBoxProjection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromBoxProjection_TargetMesh_PropertyAddress, SetMeshUVsFromBoxProjection_FunctionAddress, "TargetMesh");
		SetMeshUVsFromBoxProjection_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromBoxProjection_FunctionAddress, "TargetMesh");
		SetMeshUVsFromBoxProjection_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromBoxProjection_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromBoxProjection_UVSetIndex_PropertyAddress, SetMeshUVsFromBoxProjection_FunctionAddress, "UVSetIndex");
		SetMeshUVsFromBoxProjection_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromBoxProjection_FunctionAddress, "UVSetIndex");
		SetMeshUVsFromBoxProjection_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromBoxProjection_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromBoxProjection_BoxTransform_PropertyAddress, SetMeshUVsFromBoxProjection_FunctionAddress, "BoxTransform");
		SetMeshUVsFromBoxProjection_BoxTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromBoxProjection_FunctionAddress, "BoxTransform");
		SetMeshUVsFromBoxProjection_BoxTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromBoxProjection_FunctionAddress, "BoxTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromBoxProjection_MinIslandTriCount_PropertyAddress, SetMeshUVsFromBoxProjection_FunctionAddress, "MinIslandTriCount");
		SetMeshUVsFromBoxProjection_MinIslandTriCount_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromBoxProjection_FunctionAddress, "MinIslandTriCount");
		SetMeshUVsFromBoxProjection_MinIslandTriCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromBoxProjection_FunctionAddress, "MinIslandTriCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromBoxProjection_Debug_PropertyAddress, SetMeshUVsFromBoxProjection_FunctionAddress, "Debug");
		SetMeshUVsFromBoxProjection_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromBoxProjection_FunctionAddress, "Debug");
		SetMeshUVsFromBoxProjection_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromBoxProjection_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshUVsFromBoxProjection_ReturnValue_PropertyAddress, SetMeshUVsFromBoxProjection_FunctionAddress, "ReturnValue");
		SetMeshUVsFromBoxProjection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshUVsFromBoxProjection_FunctionAddress, "ReturnValue");
		SetMeshUVsFromBoxProjection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshUVsFromBoxProjection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMeshUVsFromBoxProjection_IsValid = SetMeshUVsFromBoxProjection_FunctionAddress != IntPtr.Zero && SetMeshUVsFromBoxProjection_TargetMesh_IsValid && SetMeshUVsFromBoxProjection_UVSetIndex_IsValid && SetMeshUVsFromBoxProjection_BoxTransform_IsValid && SetMeshUVsFromBoxProjection_MinIslandTriCount_IsValid && SetMeshUVsFromBoxProjection_Debug_IsValid && SetMeshUVsFromBoxProjection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshUVsFromBoxProjection", SetMeshUVsFromBoxProjection_IsValid);
		SetMeshTriangleUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMeshTriangleUVs");
		SetMeshTriangleUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshTriangleUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleUVs_TargetMesh_PropertyAddress, SetMeshTriangleUVs_FunctionAddress, "TargetMesh");
		SetMeshTriangleUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleUVs_FunctionAddress, "TargetMesh");
		SetMeshTriangleUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleUVs_UVSetIndex_PropertyAddress, SetMeshTriangleUVs_FunctionAddress, "UVSetIndex");
		SetMeshTriangleUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleUVs_FunctionAddress, "UVSetIndex");
		SetMeshTriangleUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleUVs_TriangleID_PropertyAddress, SetMeshTriangleUVs_FunctionAddress, "TriangleID");
		SetMeshTriangleUVs_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleUVs_FunctionAddress, "TriangleID");
		SetMeshTriangleUVs_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleUVs_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleUVs_UVs_PropertyAddress, SetMeshTriangleUVs_FunctionAddress, "UVs");
		SetMeshTriangleUVs_UVs_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleUVs_FunctionAddress, "UVs");
		SetMeshTriangleUVs_UVs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleUVs_FunctionAddress, "UVs", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleUVs_bIsValidTriangle_PropertyAddress, SetMeshTriangleUVs_FunctionAddress, "bIsValidTriangle");
		SetMeshTriangleUVs_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleUVs_FunctionAddress, "bIsValidTriangle");
		SetMeshTriangleUVs_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleUVs_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleUVs_bDeferChangeNotifications_PropertyAddress, SetMeshTriangleUVs_FunctionAddress, "bDeferChangeNotifications");
		SetMeshTriangleUVs_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleUVs_FunctionAddress, "bDeferChangeNotifications");
		SetMeshTriangleUVs_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleUVs_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleUVs_ReturnValue_PropertyAddress, SetMeshTriangleUVs_FunctionAddress, "ReturnValue");
		SetMeshTriangleUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleUVs_FunctionAddress, "ReturnValue");
		SetMeshTriangleUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMeshTriangleUVs_IsValid = SetMeshTriangleUVs_FunctionAddress != IntPtr.Zero && SetMeshTriangleUVs_TargetMesh_IsValid && SetMeshTriangleUVs_UVSetIndex_IsValid && SetMeshTriangleUVs_TriangleID_IsValid && SetMeshTriangleUVs_UVs_IsValid && SetMeshTriangleUVs_bIsValidTriangle_IsValid && SetMeshTriangleUVs_bDeferChangeNotifications_IsValid && SetMeshTriangleUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:SetMeshTriangleUVs", SetMeshTriangleUVs_IsValid);
		ScaleMeshUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScaleMeshUVs");
		ScaleMeshUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(ScaleMeshUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScaleMeshUVs_TargetMesh_PropertyAddress, ScaleMeshUVs_FunctionAddress, "TargetMesh");
		ScaleMeshUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMeshUVs_FunctionAddress, "TargetMesh");
		ScaleMeshUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMeshUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMeshUVs_UVSetIndex_PropertyAddress, ScaleMeshUVs_FunctionAddress, "UVSetIndex");
		ScaleMeshUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMeshUVs_FunctionAddress, "UVSetIndex");
		ScaleMeshUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMeshUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMeshUVs_Scale_PropertyAddress, ScaleMeshUVs_FunctionAddress, "Scale");
		ScaleMeshUVs_Scale_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMeshUVs_FunctionAddress, "Scale");
		ScaleMeshUVs_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMeshUVs_FunctionAddress, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMeshUVs_ScaleOrigin_PropertyAddress, ScaleMeshUVs_FunctionAddress, "ScaleOrigin");
		ScaleMeshUVs_ScaleOrigin_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMeshUVs_FunctionAddress, "ScaleOrigin");
		ScaleMeshUVs_ScaleOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMeshUVs_FunctionAddress, "ScaleOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMeshUVs_Debug_PropertyAddress, ScaleMeshUVs_FunctionAddress, "Debug");
		ScaleMeshUVs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMeshUVs_FunctionAddress, "Debug");
		ScaleMeshUVs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMeshUVs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMeshUVs_ReturnValue_PropertyAddress, ScaleMeshUVs_FunctionAddress, "ReturnValue");
		ScaleMeshUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMeshUVs_FunctionAddress, "ReturnValue");
		ScaleMeshUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMeshUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ScaleMeshUVs_IsValid = ScaleMeshUVs_FunctionAddress != IntPtr.Zero && ScaleMeshUVs_TargetMesh_IsValid && ScaleMeshUVs_UVSetIndex_IsValid && ScaleMeshUVs_Scale_IsValid && ScaleMeshUVs_ScaleOrigin_IsValid && ScaleMeshUVs_Debug_IsValid && ScaleMeshUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:ScaleMeshUVs", ScaleMeshUVs_IsValid);
		RotateMeshUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RotateMeshUVs");
		RotateMeshUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(RotateMeshUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RotateMeshUVs_TargetMesh_PropertyAddress, RotateMeshUVs_FunctionAddress, "TargetMesh");
		RotateMeshUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RotateMeshUVs_FunctionAddress, "TargetMesh");
		RotateMeshUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RotateMeshUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RotateMeshUVs_UVSetIndex_PropertyAddress, RotateMeshUVs_FunctionAddress, "UVSetIndex");
		RotateMeshUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(RotateMeshUVs_FunctionAddress, "UVSetIndex");
		RotateMeshUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RotateMeshUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RotateMeshUVs_RotationAngle_PropertyAddress, RotateMeshUVs_FunctionAddress, "RotationAngle");
		RotateMeshUVs_RotationAngle_Offset = NativeReflectionCached.GetPropertyOffset(RotateMeshUVs_FunctionAddress, "RotationAngle");
		RotateMeshUVs_RotationAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(RotateMeshUVs_FunctionAddress, "RotationAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RotateMeshUVs_RotationOrigin_PropertyAddress, RotateMeshUVs_FunctionAddress, "RotationOrigin");
		RotateMeshUVs_RotationOrigin_Offset = NativeReflectionCached.GetPropertyOffset(RotateMeshUVs_FunctionAddress, "RotationOrigin");
		RotateMeshUVs_RotationOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(RotateMeshUVs_FunctionAddress, "RotationOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RotateMeshUVs_Debug_PropertyAddress, RotateMeshUVs_FunctionAddress, "Debug");
		RotateMeshUVs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RotateMeshUVs_FunctionAddress, "Debug");
		RotateMeshUVs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RotateMeshUVs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RotateMeshUVs_ReturnValue_PropertyAddress, RotateMeshUVs_FunctionAddress, "ReturnValue");
		RotateMeshUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RotateMeshUVs_FunctionAddress, "ReturnValue");
		RotateMeshUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RotateMeshUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RotateMeshUVs_IsValid = RotateMeshUVs_FunctionAddress != IntPtr.Zero && RotateMeshUVs_TargetMesh_IsValid && RotateMeshUVs_UVSetIndex_IsValid && RotateMeshUVs_RotationAngle_IsValid && RotateMeshUVs_RotationOrigin_IsValid && RotateMeshUVs_Debug_IsValid && RotateMeshUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RotateMeshUVs", RotateMeshUVs_IsValid);
		RepackMeshUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RepackMeshUVs");
		RepackMeshUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(RepackMeshUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RepackMeshUVs_TargetMesh_PropertyAddress, RepackMeshUVs_FunctionAddress, "TargetMesh");
		RepackMeshUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RepackMeshUVs_FunctionAddress, "TargetMesh");
		RepackMeshUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RepackMeshUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RepackMeshUVs_UVSetIndex_PropertyAddress, RepackMeshUVs_FunctionAddress, "UVSetIndex");
		RepackMeshUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(RepackMeshUVs_FunctionAddress, "UVSetIndex");
		RepackMeshUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RepackMeshUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RepackMeshUVs_RepackOptions_PropertyAddress, RepackMeshUVs_FunctionAddress, "RepackOptions");
		RepackMeshUVs_RepackOptions_Offset = NativeReflectionCached.GetPropertyOffset(RepackMeshUVs_FunctionAddress, "RepackOptions");
		RepackMeshUVs_RepackOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(RepackMeshUVs_FunctionAddress, "RepackOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RepackMeshUVs_Debug_PropertyAddress, RepackMeshUVs_FunctionAddress, "Debug");
		RepackMeshUVs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RepackMeshUVs_FunctionAddress, "Debug");
		RepackMeshUVs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RepackMeshUVs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RepackMeshUVs_ReturnValue_PropertyAddress, RepackMeshUVs_FunctionAddress, "ReturnValue");
		RepackMeshUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RepackMeshUVs_FunctionAddress, "ReturnValue");
		RepackMeshUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RepackMeshUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RepackMeshUVs_IsValid = RepackMeshUVs_FunctionAddress != IntPtr.Zero && RepackMeshUVs_TargetMesh_IsValid && RepackMeshUVs_UVSetIndex_IsValid && RepackMeshUVs_RepackOptions_IsValid && RepackMeshUVs_Debug_IsValid && RepackMeshUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RepackMeshUVs", RepackMeshUVs_IsValid);
		RecomputeMeshUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecomputeMeshUVs");
		RecomputeMeshUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeMeshUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecomputeMeshUVs_TargetMesh_PropertyAddress, RecomputeMeshUVs_FunctionAddress, "TargetMesh");
		RecomputeMeshUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeMeshUVs_FunctionAddress, "TargetMesh");
		RecomputeMeshUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeMeshUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeMeshUVs_UVSetIndex_PropertyAddress, RecomputeMeshUVs_FunctionAddress, "UVSetIndex");
		RecomputeMeshUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeMeshUVs_FunctionAddress, "UVSetIndex");
		RecomputeMeshUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeMeshUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeMeshUVs_Options_PropertyAddress, RecomputeMeshUVs_FunctionAddress, "Options");
		RecomputeMeshUVs_Options_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeMeshUVs_FunctionAddress, "Options");
		RecomputeMeshUVs_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeMeshUVs_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeMeshUVs_Debug_PropertyAddress, RecomputeMeshUVs_FunctionAddress, "Debug");
		RecomputeMeshUVs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeMeshUVs_FunctionAddress, "Debug");
		RecomputeMeshUVs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeMeshUVs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeMeshUVs_ReturnValue_PropertyAddress, RecomputeMeshUVs_FunctionAddress, "ReturnValue");
		RecomputeMeshUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeMeshUVs_FunctionAddress, "ReturnValue");
		RecomputeMeshUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeMeshUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RecomputeMeshUVs_IsValid = RecomputeMeshUVs_FunctionAddress != IntPtr.Zero && RecomputeMeshUVs_TargetMesh_IsValid && RecomputeMeshUVs_UVSetIndex_IsValid && RecomputeMeshUVs_Options_IsValid && RecomputeMeshUVs_Debug_IsValid && RecomputeMeshUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:RecomputeMeshUVs", RecomputeMeshUVs_IsValid);
		CopyUVSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyUVSet");
		CopyUVSet_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyUVSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyUVSet_TargetMesh_PropertyAddress, CopyUVSet_FunctionAddress, "TargetMesh");
		CopyUVSet_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(CopyUVSet_FunctionAddress, "TargetMesh");
		CopyUVSet_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyUVSet_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyUVSet_FromUVSet_PropertyAddress, CopyUVSet_FunctionAddress, "FromUVSet");
		CopyUVSet_FromUVSet_Offset = NativeReflectionCached.GetPropertyOffset(CopyUVSet_FunctionAddress, "FromUVSet");
		CopyUVSet_FromUVSet_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyUVSet_FunctionAddress, "FromUVSet", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyUVSet_ToUVSet_PropertyAddress, CopyUVSet_FunctionAddress, "ToUVSet");
		CopyUVSet_ToUVSet_Offset = NativeReflectionCached.GetPropertyOffset(CopyUVSet_FunctionAddress, "ToUVSet");
		CopyUVSet_ToUVSet_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyUVSet_FunctionAddress, "ToUVSet", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyUVSet_Debug_PropertyAddress, CopyUVSet_FunctionAddress, "Debug");
		CopyUVSet_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CopyUVSet_FunctionAddress, "Debug");
		CopyUVSet_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyUVSet_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyUVSet_ReturnValue_PropertyAddress, CopyUVSet_FunctionAddress, "ReturnValue");
		CopyUVSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyUVSet_FunctionAddress, "ReturnValue");
		CopyUVSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyUVSet_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyUVSet_IsValid = CopyUVSet_FunctionAddress != IntPtr.Zero && CopyUVSet_TargetMesh_IsValid && CopyUVSet_FromUVSet_IsValid && CopyUVSet_ToUVSet_IsValid && CopyUVSet_Debug_IsValid && CopyUVSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:CopyUVSet", CopyUVSet_IsValid);
		AutoGenerateXAtlasMeshUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutoGenerateXAtlasMeshUVs");
		AutoGenerateXAtlasMeshUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoGenerateXAtlasMeshUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutoGenerateXAtlasMeshUVs_TargetMesh_PropertyAddress, AutoGenerateXAtlasMeshUVs_FunctionAddress, "TargetMesh");
		AutoGenerateXAtlasMeshUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AutoGenerateXAtlasMeshUVs_FunctionAddress, "TargetMesh");
		AutoGenerateXAtlasMeshUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGenerateXAtlasMeshUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGenerateXAtlasMeshUVs_UVSetIndex_PropertyAddress, AutoGenerateXAtlasMeshUVs_FunctionAddress, "UVSetIndex");
		AutoGenerateXAtlasMeshUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(AutoGenerateXAtlasMeshUVs_FunctionAddress, "UVSetIndex");
		AutoGenerateXAtlasMeshUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGenerateXAtlasMeshUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGenerateXAtlasMeshUVs_Options_PropertyAddress, AutoGenerateXAtlasMeshUVs_FunctionAddress, "Options");
		AutoGenerateXAtlasMeshUVs_Options_Offset = NativeReflectionCached.GetPropertyOffset(AutoGenerateXAtlasMeshUVs_FunctionAddress, "Options");
		AutoGenerateXAtlasMeshUVs_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGenerateXAtlasMeshUVs_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGenerateXAtlasMeshUVs_Debug_PropertyAddress, AutoGenerateXAtlasMeshUVs_FunctionAddress, "Debug");
		AutoGenerateXAtlasMeshUVs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AutoGenerateXAtlasMeshUVs_FunctionAddress, "Debug");
		AutoGenerateXAtlasMeshUVs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGenerateXAtlasMeshUVs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGenerateXAtlasMeshUVs_ReturnValue_PropertyAddress, AutoGenerateXAtlasMeshUVs_FunctionAddress, "ReturnValue");
		AutoGenerateXAtlasMeshUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AutoGenerateXAtlasMeshUVs_FunctionAddress, "ReturnValue");
		AutoGenerateXAtlasMeshUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGenerateXAtlasMeshUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AutoGenerateXAtlasMeshUVs_IsValid = AutoGenerateXAtlasMeshUVs_FunctionAddress != IntPtr.Zero && AutoGenerateXAtlasMeshUVs_TargetMesh_IsValid && AutoGenerateXAtlasMeshUVs_UVSetIndex_IsValid && AutoGenerateXAtlasMeshUVs_Options_IsValid && AutoGenerateXAtlasMeshUVs_Debug_IsValid && AutoGenerateXAtlasMeshUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:AutoGenerateXAtlasMeshUVs", AutoGenerateXAtlasMeshUVs_IsValid);
		AutoGeneratePatchBuilderMeshUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutoGeneratePatchBuilderMeshUVs");
		AutoGeneratePatchBuilderMeshUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoGeneratePatchBuilderMeshUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutoGeneratePatchBuilderMeshUVs_TargetMesh_PropertyAddress, AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "TargetMesh");
		AutoGeneratePatchBuilderMeshUVs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "TargetMesh");
		AutoGeneratePatchBuilderMeshUVs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGeneratePatchBuilderMeshUVs_UVSetIndex_PropertyAddress, AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "UVSetIndex");
		AutoGeneratePatchBuilderMeshUVs_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "UVSetIndex");
		AutoGeneratePatchBuilderMeshUVs_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGeneratePatchBuilderMeshUVs_Options_PropertyAddress, AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "Options");
		AutoGeneratePatchBuilderMeshUVs_Options_Offset = NativeReflectionCached.GetPropertyOffset(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "Options");
		AutoGeneratePatchBuilderMeshUVs_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGeneratePatchBuilderMeshUVs_Debug_PropertyAddress, AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "Debug");
		AutoGeneratePatchBuilderMeshUVs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "Debug");
		AutoGeneratePatchBuilderMeshUVs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoGeneratePatchBuilderMeshUVs_ReturnValue_PropertyAddress, AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "ReturnValue");
		AutoGeneratePatchBuilderMeshUVs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "ReturnValue");
		AutoGeneratePatchBuilderMeshUVs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoGeneratePatchBuilderMeshUVs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AutoGeneratePatchBuilderMeshUVs_IsValid = AutoGeneratePatchBuilderMeshUVs_FunctionAddress != IntPtr.Zero && AutoGeneratePatchBuilderMeshUVs_TargetMesh_IsValid && AutoGeneratePatchBuilderMeshUVs_UVSetIndex_IsValid && AutoGeneratePatchBuilderMeshUVs_Options_IsValid && AutoGeneratePatchBuilderMeshUVs_Debug_IsValid && AutoGeneratePatchBuilderMeshUVs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshUVFunctions:AutoGeneratePatchBuilderMeshUVs", AutoGeneratePatchBuilderMeshUVs_IsValid);
	}
}
