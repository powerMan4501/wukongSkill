using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Arteries.ArteriesObject", "Arteries", UnrealModuleType.GamePlugin)]
public class UArteriesObject : UObject
{
	private static IntPtr classAddress;

	private static bool Voronoi_IsValid;

	private static IntPtr Voronoi_FunctionAddress;

	private static int Voronoi_ParamsSize;

	private static bool Voronoi_Groups_IsValid;

	private static FFieldAddress Voronoi_Groups_PropertyAddress;

	private static int Voronoi_Groups_Offset;

	private static bool Voronoi_Seed_IsValid;

	private static FFieldAddress Voronoi_Seed_PropertyAddress;

	private static int Voronoi_Seed_Offset;

	private static bool Voronoi_Count_IsValid;

	private static FFieldAddress Voronoi_Count_PropertyAddress;

	private static int Voronoi_Count_Offset;

	private static bool Voronoi_Density_IsValid;

	private static FFieldAddress Voronoi_Density_PropertyAddress;

	private static int Voronoi_Density_Offset;

	private static bool Voronoi_Iterations_IsValid;

	private static FFieldAddress Voronoi_Iterations_PropertyAddress;

	private static int Voronoi_Iterations_Offset;

	private static bool Voronoi_ReturnValue_IsValid;

	private static FFieldAddress Voronoi_ReturnValue_PropertyAddress;

	private static int Voronoi_ReturnValue_Offset;

	private static bool Tube_IsValid;

	private static IntPtr Tube_FunctionAddress;

	private static int Tube_ParamsSize;

	private static bool Tube_Origin_IsValid;

	private static FFieldAddress Tube_Origin_PropertyAddress;

	private static int Tube_Origin_Offset;

	private static bool Tube_Rotation_IsValid;

	private static FFieldAddress Tube_Rotation_PropertyAddress;

	private static int Tube_Rotation_Offset;

	private static bool Tube_Radius_IsValid;

	private static FFieldAddress Tube_Radius_PropertyAddress;

	private static int Tube_Radius_Offset;

	private static bool Tube_Height_IsValid;

	private static FFieldAddress Tube_Height_PropertyAddress;

	private static int Tube_Height_Offset;

	private static bool Tube_Rows_IsValid;

	private static FFieldAddress Tube_Rows_PropertyAddress;

	private static int Tube_Rows_Offset;

	private static bool Tube_Columns_IsValid;

	private static FFieldAddress Tube_Columns_PropertyAddress;

	private static int Tube_Columns_Offset;

	private static bool Tube_ReturnValue_IsValid;

	private static FFieldAddress Tube_ReturnValue_PropertyAddress;

	private static int Tube_ReturnValue_Offset;

	private static bool Triangulate_IsValid;

	private static IntPtr Triangulate_FunctionAddress;

	private static int Triangulate_ParamsSize;

	private static bool Triangulate_ReturnValue_IsValid;

	private static FFieldAddress Triangulate_ReturnValue_PropertyAddress;

	private static int Triangulate_ReturnValue_Offset;

	private static bool Transform_IsValid;

	private static IntPtr Transform_FunctionAddress;

	private static int Transform_ParamsSize;

	private static bool Transform_GroupType_IsValid;

	private static FFieldAddress Transform_GroupType_PropertyAddress;

	private static int Transform_GroupType_Offset;

	private static bool Transform_Groups_IsValid;

	private static FFieldAddress Transform_Groups_PropertyAddress;

	private static int Transform_Groups_Offset;

	private static bool Transform_Rotation_IsValid;

	private static FFieldAddress Transform_Rotation_PropertyAddress;

	private static int Transform_Rotation_Offset;

	private static bool Transform_Translation_IsValid;

	private static FFieldAddress Transform_Translation_PropertyAddress;

	private static int Transform_Translation_Offset;

	private static bool Transform_Scale_IsValid;

	private static FFieldAddress Transform_Scale_PropertyAddress;

	private static int Transform_Scale_Offset;

	private static bool Transform_ReturnValue_IsValid;

	private static FFieldAddress Transform_ReturnValue_PropertyAddress;

	private static int Transform_ReturnValue_Offset;

	private static bool Torus_IsValid;

	private static IntPtr Torus_FunctionAddress;

	private static int Torus_ParamsSize;

	private static bool Torus_Origin_IsValid;

	private static FFieldAddress Torus_Origin_PropertyAddress;

	private static int Torus_Origin_Offset;

	private static bool Torus_Rotation_IsValid;

	private static FFieldAddress Torus_Rotation_PropertyAddress;

	private static int Torus_Rotation_Offset;

	private static bool Torus_Radius_IsValid;

	private static FFieldAddress Torus_Radius_PropertyAddress;

	private static int Torus_Radius_Offset;

	private static bool Torus_Rows_IsValid;

	private static FFieldAddress Torus_Rows_PropertyAddress;

	private static int Torus_Rows_Offset;

	private static bool Torus_Columns_IsValid;

	private static FFieldAddress Torus_Columns_PropertyAddress;

	private static int Torus_Columns_Offset;

	private static bool Torus_ReturnValue_IsValid;

	private static FFieldAddress Torus_ReturnValue_PropertyAddress;

	private static int Torus_ReturnValue_Offset;

	private static bool Sweep_IsValid;

	private static IntPtr Sweep_FunctionAddress;

	private static int Sweep_ParamsSize;

	private static bool Sweep_Backbones_IsValid;

	private static FFieldAddress Sweep_Backbones_PropertyAddress;

	private static int Sweep_Backbones_Offset;

	private static bool Sweep_ReturnValue_IsValid;

	private static FFieldAddress Sweep_ReturnValue_PropertyAddress;

	private static int Sweep_ReturnValue_Offset;

	private static bool SubDivide_IsValid;

	private static IntPtr SubDivide_FunctionAddress;

	private static int SubDivide_ParamsSize;

	private static bool SubDivide_Groups_IsValid;

	private static FFieldAddress SubDivide_Groups_PropertyAddress;

	private static int SubDivide_Groups_Offset;

	private static bool SubDivide_MinLength_IsValid;

	private static FFieldAddress SubDivide_MinLength_PropertyAddress;

	private static int SubDivide_MinLength_Offset;

	private static bool SubDivide_ReturnValue_IsValid;

	private static FFieldAddress SubDivide_ReturnValue_PropertyAddress;

	private static int SubDivide_ReturnValue_Offset;

	private static bool Sphere_IsValid;

	private static IntPtr Sphere_FunctionAddress;

	private static int Sphere_ParamsSize;

	private static bool Sphere_Origin_IsValid;

	private static FFieldAddress Sphere_Origin_PropertyAddress;

	private static int Sphere_Origin_Offset;

	private static bool Sphere_Rotation_IsValid;

	private static FFieldAddress Sphere_Rotation_PropertyAddress;

	private static int Sphere_Rotation_Offset;

	private static bool Sphere_Radius_IsValid;

	private static FFieldAddress Sphere_Radius_PropertyAddress;

	private static int Sphere_Radius_Offset;

	private static bool Sphere_Rows_IsValid;

	private static FFieldAddress Sphere_Rows_PropertyAddress;

	private static int Sphere_Rows_Offset;

	private static bool Sphere_Columns_IsValid;

	private static FFieldAddress Sphere_Columns_PropertyAddress;

	private static int Sphere_Columns_Offset;

	private static bool Sphere_ReturnValue_IsValid;

	private static FFieldAddress Sphere_ReturnValue_PropertyAddress;

	private static int Sphere_ReturnValue_Offset;

	private static bool SortRandomly_IsValid;

	private static IntPtr SortRandomly_FunctionAddress;

	private static int SortRandomly_ParamsSize;

	private static bool SortRandomly_Seed_IsValid;

	private static FFieldAddress SortRandomly_Seed_PropertyAddress;

	private static int SortRandomly_Seed_Offset;

	private static bool SortRandomly_ReturnValue_IsValid;

	private static FFieldAddress SortRandomly_ReturnValue_PropertyAddress;

	private static int SortRandomly_ReturnValue_Offset;

	private static bool SortByAttribute_IsValid;

	private static IntPtr SortByAttribute_FunctionAddress;

	private static int SortByAttribute_ParamsSize;

	private static bool SortByAttribute_AttrName_IsValid;

	private static FFieldAddress SortByAttribute_AttrName_PropertyAddress;

	private static int SortByAttribute_AttrName_Offset;

	private static bool SortByAttribute_ReturnValue_IsValid;

	private static FFieldAddress SortByAttribute_ReturnValue_PropertyAddress;

	private static int SortByAttribute_ReturnValue_Offset;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_Groups_IsValid;

	private static FFieldAddress SetMaterial_Groups_PropertyAddress;

	private static int SetMaterial_Groups_Offset;

	private static bool SetMaterial_Material_IsValid;

	private static FFieldAddress SetMaterial_Material_PropertyAddress;

	private static int SetMaterial_Material_Offset;

	private static bool SetMaterial_UVScale_IsValid;

	private static FFieldAddress SetMaterial_UVScale_PropertyAddress;

	private static int SetMaterial_UVScale_Offset;

	private static bool SetMaterial_UVOffset_IsValid;

	private static FFieldAddress SetMaterial_UVOffset_PropertyAddress;

	private static int SetMaterial_UVOffset_Offset;

	private static bool SetMaterial_UVRotation_IsValid;

	private static FFieldAddress SetMaterial_UVRotation_PropertyAddress;

	private static int SetMaterial_UVRotation_Offset;

	private static bool SetMaterial_NullOnly_IsValid;

	private static FFieldAddress SetMaterial_NullOnly_PropertyAddress;

	private static int SetMaterial_NullOnly_Offset;

	private static bool SetMaterial_ReturnValue_IsValid;

	private static FFieldAddress SetMaterial_ReturnValue_PropertyAddress;

	private static int SetMaterial_ReturnValue_Offset;

	private static bool Scatter_IsValid;

	private static IntPtr Scatter_FunctionAddress;

	private static int Scatter_ParamsSize;

	private static bool Scatter_Groups_IsValid;

	private static FFieldAddress Scatter_Groups_PropertyAddress;

	private static int Scatter_Groups_Offset;

	private static bool Scatter_Seed_IsValid;

	private static FFieldAddress Scatter_Seed_PropertyAddress;

	private static int Scatter_Seed_Offset;

	private static bool Scatter_Count_IsValid;

	private static FFieldAddress Scatter_Count_PropertyAddress;

	private static int Scatter_Count_Offset;

	private static bool Scatter_Density_IsValid;

	private static FFieldAddress Scatter_Density_PropertyAddress;

	private static int Scatter_Density_Offset;

	private static bool Scatter_Iterations_IsValid;

	private static FFieldAddress Scatter_Iterations_PropertyAddress;

	private static int Scatter_Iterations_Offset;

	private static bool Scatter_ReturnValue_IsValid;

	private static FFieldAddress Scatter_ReturnValue_PropertyAddress;

	private static int Scatter_ReturnValue_Offset;

	private static bool Road_IsValid;

	private static IntPtr Road_FunctionAddress;

	private static int Road_ParamsSize;

	private static bool Road_DefaultWidth_IsValid;

	private static FFieldAddress Road_DefaultWidth_PropertyAddress;

	private static int Road_DefaultWidth_Offset;

	private static bool Road_ReturnValue_IsValid;

	private static FFieldAddress Road_ReturnValue_PropertyAddress;

	private static int Road_ReturnValue_Offset;

	private static bool Reverse_IsValid;

	private static IntPtr Reverse_FunctionAddress;

	private static int Reverse_ParamsSize;

	private static bool Reverse_Groups_IsValid;

	private static FFieldAddress Reverse_Groups_PropertyAddress;

	private static int Reverse_Groups_Offset;

	private static bool Reverse_ReturnValue_IsValid;

	private static FFieldAddress Reverse_ReturnValue_PropertyAddress;

	private static int Reverse_ReturnValue_Offset;

	private static bool Resample_IsValid;

	private static IntPtr Resample_FunctionAddress;

	private static int Resample_ParamsSize;

	private static bool Resample_ByEdge_IsValid;

	private static FFieldAddress Resample_ByEdge_PropertyAddress;

	private static int Resample_ByEdge_Offset;

	private static bool Resample_SegmentLength_IsValid;

	private static FFieldAddress Resample_SegmentLength_PropertyAddress;

	private static int Resample_SegmentLength_Offset;

	private static bool Resample_NumSegments_IsValid;

	private static FFieldAddress Resample_NumSegments_PropertyAddress;

	private static int Resample_NumSegments_Offset;

	private static bool Resample_OutputType_IsValid;

	private static FFieldAddress Resample_OutputType_PropertyAddress;

	private static int Resample_OutputType_Offset;

	private static bool Resample_ReturnValue_IsValid;

	private static FFieldAddress Resample_ReturnValue_PropertyAddress;

	private static int Resample_ReturnValue_Offset;

	private static bool PrimitiveInGroup_IsValid;

	private static IntPtr PrimitiveInGroup_FunctionAddress;

	private static int PrimitiveInGroup_ParamsSize;

	private static bool PrimitiveInGroup_GroupName_IsValid;

	private static FFieldAddress PrimitiveInGroup_GroupName_PropertyAddress;

	private static int PrimitiveInGroup_GroupName_Offset;

	private static bool PrimitiveInGroup_Index_IsValid;

	private static FFieldAddress PrimitiveInGroup_Index_PropertyAddress;

	private static int PrimitiveInGroup_Index_Offset;

	private static bool PrimitiveInGroup_ReturnValue_IsValid;

	private static FFieldAddress PrimitiveInGroup_ReturnValue_PropertyAddress;

	private static int PrimitiveInGroup_ReturnValue_Offset;

	private static bool PolyExtrude_IsValid;

	private static IntPtr PolyExtrude_FunctionAddress;

	private static int PolyExtrude_ParamsSize;

	private static bool PolyExtrude_Groups_IsValid;

	private static FFieldAddress PolyExtrude_Groups_PropertyAddress;

	private static int PolyExtrude_Groups_Offset;

	private static bool PolyExtrude_Distance_IsValid;

	private static FFieldAddress PolyExtrude_Distance_PropertyAddress;

	private static int PolyExtrude_Distance_Offset;

	private static bool PolyExtrude_Inset_IsValid;

	private static FFieldAddress PolyExtrude_Inset_PropertyAddress;

	private static int PolyExtrude_Inset_Offset;

	private static bool PolyExtrude_FrontGroup_IsValid;

	private static FFieldAddress PolyExtrude_FrontGroup_PropertyAddress;

	private static int PolyExtrude_FrontGroup_Offset;

	private static bool PolyExtrude_SideGroup_IsValid;

	private static FFieldAddress PolyExtrude_SideGroup_PropertyAddress;

	private static int PolyExtrude_SideGroup_Offset;

	private static bool PolyExtrude_DeleteSource_IsValid;

	private static FFieldAddress PolyExtrude_DeleteSource_PropertyAddress;

	private static int PolyExtrude_DeleteSource_Offset;

	private static bool PolyExtrude_ReturnValue_IsValid;

	private static FFieldAddress PolyExtrude_ReturnValue_PropertyAddress;

	private static int PolyExtrude_ReturnValue_Offset;

	private static bool PolyExpand_IsValid;

	private static IntPtr PolyExpand_FunctionAddress;

	private static int PolyExpand_ParamsSize;

	private static bool PolyExpand_Groups_IsValid;

	private static FFieldAddress PolyExpand_Groups_PropertyAddress;

	private static int PolyExpand_Groups_Offset;

	private static bool PolyExpand_Offset_IsValid;

	private static FFieldAddress PolyExpand_Offset_PropertyAddress;

	private static int PolyExpand_Offset_Offset;

	private static bool PolyExpand_CurveGroup_IsValid;

	private static FFieldAddress PolyExpand_CurveGroup_PropertyAddress;

	private static int PolyExpand_CurveGroup_Offset;

	private static bool PolyExpand_SurfaceGroup_IsValid;

	private static FFieldAddress PolyExpand_SurfaceGroup_PropertyAddress;

	private static int PolyExpand_SurfaceGroup_Offset;

	private static bool PolyExpand_OutputTangents_IsValid;

	private static FFieldAddress PolyExpand_OutputTangents_PropertyAddress;

	private static int PolyExpand_OutputTangents_Offset;

	private static bool PolyExpand_DeleteSource_IsValid;

	private static FFieldAddress PolyExpand_DeleteSource_PropertyAddress;

	private static int PolyExpand_DeleteSource_Offset;

	private static bool PolyExpand_ReturnValue_IsValid;

	private static FFieldAddress PolyExpand_ReturnValue_PropertyAddress;

	private static int PolyExpand_ReturnValue_Offset;

	private static bool PolyBevel_IsValid;

	private static IntPtr PolyBevel_FunctionAddress;

	private static int PolyBevel_ParamsSize;

	private static bool PolyBevel_GroupType_IsValid;

	private static FFieldAddress PolyBevel_GroupType_PropertyAddress;

	private static int PolyBevel_GroupType_Offset;

	private static bool PolyBevel_Groups_IsValid;

	private static FFieldAddress PolyBevel_Groups_PropertyAddress;

	private static int PolyBevel_Groups_Offset;

	private static bool PolyBevel_Distance_IsValid;

	private static FFieldAddress PolyBevel_Distance_PropertyAddress;

	private static int PolyBevel_Distance_Offset;

	private static bool PolyBevel_Divisions_IsValid;

	private static FFieldAddress PolyBevel_Divisions_PropertyAddress;

	private static int PolyBevel_Divisions_Offset;

	private static bool PolyBevel_bBevelSingleCurve_IsValid;

	private static FFieldAddress PolyBevel_bBevelSingleCurve_PropertyAddress;

	private static int PolyBevel_bBevelSingleCurve_Offset;

	private static bool PolyBevel_ReturnValue_IsValid;

	private static FFieldAddress PolyBevel_ReturnValue_PropertyAddress;

	private static int PolyBevel_ReturnValue_Offset;

	private static bool PointInGroup_IsValid;

	private static IntPtr PointInGroup_FunctionAddress;

	private static int PointInGroup_ParamsSize;

	private static bool PointInGroup_GroupName_IsValid;

	private static FFieldAddress PointInGroup_GroupName_PropertyAddress;

	private static int PointInGroup_GroupName_Offset;

	private static bool PointInGroup_Index_IsValid;

	private static FFieldAddress PointInGroup_Index_PropertyAddress;

	private static int PointInGroup_Index_Offset;

	private static bool PointInGroup_ReturnValue_IsValid;

	private static FFieldAddress PointInGroup_ReturnValue_PropertyAddress;

	private static int PointInGroup_ReturnValue_Offset;

	private static bool NumPrimitives_IsValid;

	private static IntPtr NumPrimitives_FunctionAddress;

	private static int NumPrimitives_ParamsSize;

	private static bool NumPrimitives_ReturnValue_IsValid;

	private static FFieldAddress NumPrimitives_ReturnValue_PropertyAddress;

	private static int NumPrimitives_ReturnValue_Offset;

	private static bool NumPoints_IsValid;

	private static IntPtr NumPoints_FunctionAddress;

	private static int NumPoints_ParamsSize;

	private static bool NumPoints_ReturnValue_IsValid;

	private static FFieldAddress NumPoints_ReturnValue_PropertyAddress;

	private static int NumPoints_ReturnValue_Offset;

	private static bool New_IsValid;

	private static IntPtr New_FunctionAddress;

	private static int New_ParamsSize;

	private static bool New_ReturnValue_IsValid;

	private static FFieldAddress New_ReturnValue_PropertyAddress;

	private static int New_ReturnValue_Offset;

	private static bool MergeArray_IsValid;

	private static IntPtr MergeArray_FunctionAddress;

	private static int MergeArray_ParamsSize;

	private static bool MergeArray_Objs_IsValid;

	private static FFieldAddress MergeArray_Objs_PropertyAddress;

	private static int MergeArray_Objs_Offset;

	private static bool MergeArray_ReturnValue_IsValid;

	private static FFieldAddress MergeArray_ReturnValue_PropertyAddress;

	private static int MergeArray_ReturnValue_Offset;

	private static bool Merge_IsValid;

	private static IntPtr Merge_FunctionAddress;

	private static int Merge_ParamsSize;

	private static bool Merge_Obj0_IsValid;

	private static FFieldAddress Merge_Obj0_PropertyAddress;

	private static int Merge_Obj0_Offset;

	private static bool Merge_Obj1_IsValid;

	private static FFieldAddress Merge_Obj1_PropertyAddress;

	private static int Merge_Obj1_Offset;

	private static bool Merge_Obj2_IsValid;

	private static FFieldAddress Merge_Obj2_PropertyAddress;

	private static int Merge_Obj2_Offset;

	private static bool Merge_Obj3_IsValid;

	private static FFieldAddress Merge_Obj3_PropertyAddress;

	private static int Merge_Obj3_Offset;

	private static bool Merge_Obj4_IsValid;

	private static FFieldAddress Merge_Obj4_PropertyAddress;

	private static int Merge_Obj4_Offset;

	private static bool Merge_ReturnValue_IsValid;

	private static FFieldAddress Merge_ReturnValue_PropertyAddress;

	private static int Merge_ReturnValue_Offset;

	private static bool Measure_IsValid;

	private static IntPtr Measure_FunctionAddress;

	private static int Measure_ParamsSize;

	private static bool Measure_Name_IsValid;

	private static FFieldAddress Measure_Name_PropertyAddress;

	private static int Measure_Name_Offset;

	private static bool Measure_ReturnValue_IsValid;

	private static FFieldAddress Measure_ReturnValue_PropertyAddress;

	private static int Measure_ReturnValue_Offset;

	private static bool MakeGrids_IsValid;

	private static IntPtr MakeGrids_FunctionAddress;

	private static int MakeGrids_ParamsSize;

	private static bool MakeGrids_Groups_IsValid;

	private static FFieldAddress MakeGrids_Groups_PropertyAddress;

	private static int MakeGrids_Groups_Offset;

	private static bool MakeGrids_GridSize_IsValid;

	private static FFieldAddress MakeGrids_GridSize_PropertyAddress;

	private static int MakeGrids_GridSize_Offset;

	private static bool MakeGrids_MinGrids_IsValid;

	private static FFieldAddress MakeGrids_MinGrids_PropertyAddress;

	private static int MakeGrids_MinGrids_Offset;

	private static bool MakeGrids_OBBOnly_IsValid;

	private static FFieldAddress MakeGrids_OBBOnly_PropertyAddress;

	private static int MakeGrids_OBBOnly_Offset;

	private static bool MakeGrids_ReturnValue_IsValid;

	private static FFieldAddress MakeGrids_ReturnValue_PropertyAddress;

	private static int MakeGrids_ReturnValue_Offset;

	private static bool Line_IsValid;

	private static IntPtr Line_FunctionAddress;

	private static int Line_ParamsSize;

	private static bool Line_Origin_IsValid;

	private static FFieldAddress Line_Origin_PropertyAddress;

	private static int Line_Origin_Offset;

	private static bool Line_Direction_IsValid;

	private static FFieldAddress Line_Direction_PropertyAddress;

	private static int Line_Direction_Offset;

	private static bool Line_Length_IsValid;

	private static FFieldAddress Line_Length_PropertyAddress;

	private static int Line_Length_Offset;

	private static bool Line_NumPoints_IsValid;

	private static FFieldAddress Line_NumPoints_PropertyAddress;

	private static int Line_NumPoints_Offset;

	private static bool Line_ReturnValue_IsValid;

	private static FFieldAddress Line_ReturnValue_PropertyAddress;

	private static int Line_ReturnValue_Offset;

	private static bool LastPrimitive_IsValid;

	private static IntPtr LastPrimitive_FunctionAddress;

	private static int LastPrimitive_ParamsSize;

	private static bool LastPrimitive_ReturnValue_IsValid;

	private static FFieldAddress LastPrimitive_ReturnValue_PropertyAddress;

	private static int LastPrimitive_ReturnValue_Offset;

	private static bool LastPoint_IsValid;

	private static IntPtr LastPoint_FunctionAddress;

	private static int LastPoint_ParamsSize;

	private static bool LastPoint_ReturnValue_IsValid;

	private static FFieldAddress LastPoint_ReturnValue_PropertyAddress;

	private static int LastPoint_ReturnValue_Offset;

	private static bool Hole_IsValid;

	private static IntPtr Hole_FunctionAddress;

	private static int Hole_ParamsSize;

	private static bool Hole_OuterGroups_IsValid;

	private static FFieldAddress Hole_OuterGroups_PropertyAddress;

	private static int Hole_OuterGroups_Offset;

	private static bool Hole_InnerGroups_IsValid;

	private static FFieldAddress Hole_InnerGroups_PropertyAddress;

	private static int Hole_InnerGroups_Offset;

	private static bool Hole_Tolerance_IsValid;

	private static FFieldAddress Hole_Tolerance_PropertyAddress;

	private static int Hole_Tolerance_Offset;

	private static bool Hole_ReturnValue_IsValid;

	private static FFieldAddress Hole_ReturnValue_PropertyAddress;

	private static int Hole_ReturnValue_Offset;

	private static bool GroupRange_IsValid;

	private static IntPtr GroupRange_FunctionAddress;

	private static int GroupRange_ParamsSize;

	private static bool GroupRange_Groups_IsValid;

	private static FFieldAddress GroupRange_Groups_PropertyAddress;

	private static int GroupRange_Groups_Offset;

	private static bool GroupRange_ReturnValue_IsValid;

	private static FFieldAddress GroupRange_ReturnValue_PropertyAddress;

	private static int GroupRange_ReturnValue_Offset;

	private static bool Ground_IsValid;

	private static IntPtr Ground_FunctionAddress;

	private static int Ground_ParamsSize;

	private static bool Ground_ReturnValue_IsValid;

	private static FFieldAddress Ground_ReturnValue_PropertyAddress;

	private static int Ground_ReturnValue_Offset;

	private static bool Grid_IsValid;

	private static IntPtr Grid_FunctionAddress;

	private static int Grid_ParamsSize;

	private static bool Grid_Origin_IsValid;

	private static FFieldAddress Grid_Origin_PropertyAddress;

	private static int Grid_Origin_Offset;

	private static bool Grid_Rotation_IsValid;

	private static FFieldAddress Grid_Rotation_PropertyAddress;

	private static int Grid_Rotation_Offset;

	private static bool Grid_Size_IsValid;

	private static FFieldAddress Grid_Size_PropertyAddress;

	private static int Grid_Size_Offset;

	private static bool Grid_NumPointsX_IsValid;

	private static FFieldAddress Grid_NumPointsX_PropertyAddress;

	private static int Grid_NumPointsX_Offset;

	private static bool Grid_NumPointsY_IsValid;

	private static FFieldAddress Grid_NumPointsY_PropertyAddress;

	private static int Grid_NumPointsY_Offset;

	private static bool Grid_ReturnValue_IsValid;

	private static FFieldAddress Grid_ReturnValue_PropertyAddress;

	private static int Grid_ReturnValue_Offset;

	private static bool GetPrimitiveInt_IsValid;

	private static IntPtr GetPrimitiveInt_FunctionAddress;

	private static int GetPrimitiveInt_ParamsSize;

	private static bool GetPrimitiveInt_Key_IsValid;

	private static FFieldAddress GetPrimitiveInt_Key_PropertyAddress;

	private static int GetPrimitiveInt_Key_Offset;

	private static bool GetPrimitiveInt_Index_IsValid;

	private static FFieldAddress GetPrimitiveInt_Index_PropertyAddress;

	private static int GetPrimitiveInt_Index_Offset;

	private static bool GetPrimitiveInt_ReturnValue_IsValid;

	private static FFieldAddress GetPrimitiveInt_ReturnValue_PropertyAddress;

	private static int GetPrimitiveInt_ReturnValue_Offset;

	private static bool GetPointTransform_IsValid;

	private static IntPtr GetPointTransform_FunctionAddress;

	private static int GetPointTransform_ParamsSize;

	private static bool GetPointTransform_Index_IsValid;

	private static FFieldAddress GetPointTransform_Index_PropertyAddress;

	private static int GetPointTransform_Index_Offset;

	private static bool GetPointTransform_ReturnValue_IsValid;

	private static FFieldAddress GetPointTransform_ReturnValue_PropertyAddress;

	private static int GetPointTransform_ReturnValue_Offset;

	private static bool GetPointInt_IsValid;

	private static IntPtr GetPointInt_FunctionAddress;

	private static int GetPointInt_ParamsSize;

	private static bool GetPointInt_Key_IsValid;

	private static FFieldAddress GetPointInt_Key_PropertyAddress;

	private static int GetPointInt_Key_Offset;

	private static bool GetPointInt_Index_IsValid;

	private static FFieldAddress GetPointInt_Index_PropertyAddress;

	private static int GetPointInt_Index_Offset;

	private static bool GetPointInt_ReturnValue_IsValid;

	private static FFieldAddress GetPointInt_ReturnValue_PropertyAddress;

	private static int GetPointInt_ReturnValue_Offset;

	private static bool Fuse_IsValid;

	private static IntPtr Fuse_FunctionAddress;

	private static int Fuse_ParamsSize;

	private static bool Fuse_Groups_IsValid;

	private static FFieldAddress Fuse_Groups_PropertyAddress;

	private static int Fuse_Groups_Offset;

	private static bool Fuse_SnapDist_IsValid;

	private static FFieldAddress Fuse_SnapDist_PropertyAddress;

	private static int Fuse_SnapDist_Offset;

	private static bool Fuse_ReturnValue_IsValid;

	private static FFieldAddress Fuse_ReturnValue_PropertyAddress;

	private static int Fuse_ReturnValue_Offset;

	private static bool Flatten_IsValid;

	private static IntPtr Flatten_FunctionAddress;

	private static int Flatten_ParamsSize;

	private static bool Flatten_Transform_IsValid;

	private static FFieldAddress Flatten_Transform_PropertyAddress;

	private static int Flatten_Transform_Offset;

	private static bool Flatten_ReturnValue_IsValid;

	private static FFieldAddress Flatten_ReturnValue_PropertyAddress;

	private static int Flatten_ReturnValue_Offset;

	private static bool Facet_IsValid;

	private static IntPtr Facet_FunctionAddress;

	private static int Facet_ParamsSize;

	private static bool Facet_Tolerance_IsValid;

	private static FFieldAddress Facet_Tolerance_PropertyAddress;

	private static int Facet_Tolerance_Offset;

	private static bool Facet_ReturnValue_IsValid;

	private static FFieldAddress Facet_ReturnValue_PropertyAddress;

	private static int Facet_ReturnValue_Offset;

	private static bool Divide_IsValid;

	private static IntPtr Divide_FunctionAddress;

	private static int Divide_ParamsSize;

	private static bool Divide_Tolerance_IsValid;

	private static FFieldAddress Divide_Tolerance_PropertyAddress;

	private static int Divide_Tolerance_Offset;

	private static bool Divide_ReturnValue_IsValid;

	private static FFieldAddress Divide_ReturnValue_PropertyAddress;

	private static int Divide_ReturnValue_Offset;

	private static bool CopyToPoints_IsValid;

	private static IntPtr CopyToPoints_FunctionAddress;

	private static int CopyToPoints_ParamsSize;

	private static bool CopyToPoints_Groups_IsValid;

	private static FFieldAddress CopyToPoints_Groups_PropertyAddress;

	private static int CopyToPoints_Groups_Offset;

	private static bool CopyToPoints_Source_IsValid;

	private static FFieldAddress CopyToPoints_Source_PropertyAddress;

	private static int CopyToPoints_Source_Offset;

	private static bool CopyToPoints_LocalTransform_IsValid;

	private static FFieldAddress CopyToPoints_LocalTransform_PropertyAddress;

	private static int CopyToPoints_LocalTransform_Offset;

	private static bool CopyToPoints_ReturnValue_IsValid;

	private static FFieldAddress CopyToPoints_ReturnValue_PropertyAddress;

	private static int CopyToPoints_ReturnValue_Offset;

	private static bool CopyAndTransform_IsValid;

	private static IntPtr CopyAndTransform_FunctionAddress;

	private static int CopyAndTransform_ParamsSize;

	private static bool CopyAndTransform_NumCopies_IsValid;

	private static FFieldAddress CopyAndTransform_NumCopies_PropertyAddress;

	private static int CopyAndTransform_NumCopies_Offset;

	private static bool CopyAndTransform_Transform_IsValid;

	private static FFieldAddress CopyAndTransform_Transform_PropertyAddress;

	private static int CopyAndTransform_Transform_Offset;

	private static bool CopyAndTransform_ReturnValue_IsValid;

	private static FFieldAddress CopyAndTransform_ReturnValue_PropertyAddress;

	private static int CopyAndTransform_ReturnValue_Offset;

	private static bool Copy__IsValid;

	private static IntPtr Copy__FunctionAddress;

	private static int Copy__ParamsSize;

	private static bool Copy__ReturnValue_IsValid;

	private static FFieldAddress Copy__ReturnValue_PropertyAddress;

	private static int Copy__ReturnValue_Offset;

	private static bool Clip_IsValid;

	private static IntPtr Clip_FunctionAddress;

	private static int Clip_ParamsSize;

	private static bool Clip_Groups_IsValid;

	private static FFieldAddress Clip_Groups_PropertyAddress;

	private static int Clip_Groups_Offset;

	private static bool Clip_PlaneNormal_IsValid;

	private static FFieldAddress Clip_PlaneNormal_PropertyAddress;

	private static int Clip_PlaneNormal_Offset;

	private static bool Clip_PlaneDist_IsValid;

	private static FFieldAddress Clip_PlaneDist_PropertyAddress;

	private static int Clip_PlaneDist_Offset;

	private static bool Clip_PositiveGroup_IsValid;

	private static FFieldAddress Clip_PositiveGroup_PropertyAddress;

	private static int Clip_PositiveGroup_Offset;

	private static bool Clip_NegativeGroup_IsValid;

	private static FFieldAddress Clip_NegativeGroup_PropertyAddress;

	private static int Clip_NegativeGroup_Offset;

	private static bool Clip_ReturnValue_IsValid;

	private static FFieldAddress Clip_ReturnValue_PropertyAddress;

	private static int Clip_ReturnValue_Offset;

	private static bool Clean_IsValid;

	private static IntPtr Clean_FunctionAddress;

	private static int Clean_ParamsSize;

	private static bool Clean_ReturnValue_IsValid;

	private static FFieldAddress Clean_ReturnValue_PropertyAddress;

	private static int Clean_ReturnValue_Offset;

	private static bool Circle_IsValid;

	private static IntPtr Circle_FunctionAddress;

	private static int Circle_ParamsSize;

	private static bool Circle_Origin_IsValid;

	private static FFieldAddress Circle_Origin_PropertyAddress;

	private static int Circle_Origin_Offset;

	private static bool Circle_Rotation_IsValid;

	private static FFieldAddress Circle_Rotation_PropertyAddress;

	private static int Circle_Rotation_Offset;

	private static bool Circle_Radius_IsValid;

	private static FFieldAddress Circle_Radius_PropertyAddress;

	private static int Circle_Radius_Offset;

	private static bool Circle_NumPoints_IsValid;

	private static FFieldAddress Circle_NumPoints_PropertyAddress;

	private static int Circle_NumPoints_Offset;

	private static bool Circle_ReturnValue_IsValid;

	private static FFieldAddress Circle_ReturnValue_PropertyAddress;

	private static int Circle_ReturnValue_Offset;

	private static bool Carve_IsValid;

	private static IntPtr Carve_FunctionAddress;

	private static int Carve_ParamsSize;

	private static bool Carve_StartAlign_IsValid;

	private static FFieldAddress Carve_StartAlign_PropertyAddress;

	private static int Carve_StartAlign_Offset;

	private static bool Carve_StartU_IsValid;

	private static FFieldAddress Carve_StartU_PropertyAddress;

	private static int Carve_StartU_Offset;

	private static bool Carve_EndAlign_IsValid;

	private static FFieldAddress Carve_EndAlign_PropertyAddress;

	private static int Carve_EndAlign_Offset;

	private static bool Carve_EndU_IsValid;

	private static FFieldAddress Carve_EndU_PropertyAddress;

	private static int Carve_EndU_Offset;

	private static bool Carve_ReturnValue_IsValid;

	private static FFieldAddress Carve_ReturnValue_PropertyAddress;

	private static int Carve_ReturnValue_Offset;

	private static bool Bridge_IsValid;

	private static IntPtr Bridge_FunctionAddress;

	private static int Bridge_ParamsSize;

	private static bool Bridge_StartGroupName_IsValid;

	private static FFieldAddress Bridge_StartGroupName_PropertyAddress;

	private static int Bridge_StartGroupName_Offset;

	private static bool Bridge_EndGroupName_IsValid;

	private static FFieldAddress Bridge_EndGroupName_PropertyAddress;

	private static int Bridge_EndGroupName_Offset;

	private static bool Bridge_ReturnValue_IsValid;

	private static FFieldAddress Bridge_ReturnValue_PropertyAddress;

	private static int Bridge_ReturnValue_Offset;

	private static bool BreakPoints_IsValid;

	private static IntPtr BreakPoints_FunctionAddress;

	private static int BreakPoints_ParamsSize;

	private static bool BreakPoints_Groups_IsValid;

	private static FFieldAddress BreakPoints_Groups_PropertyAddress;

	private static int BreakPoints_Groups_Offset;

	private static bool BreakPoints_ReturnValue_IsValid;

	private static FFieldAddress BreakPoints_ReturnValue_PropertyAddress;

	private static int BreakPoints_ReturnValue_Offset;

	private static bool Box_IsValid;

	private static IntPtr Box_FunctionAddress;

	private static int Box_ParamsSize;

	private static bool Box_Origin_IsValid;

	private static FFieldAddress Box_Origin_PropertyAddress;

	private static int Box_Origin_Offset;

	private static bool Box_Rotation_IsValid;

	private static FFieldAddress Box_Rotation_PropertyAddress;

	private static int Box_Rotation_Offset;

	private static bool Box_Size_IsValid;

	private static FFieldAddress Box_Size_PropertyAddress;

	private static int Box_Size_Offset;

	private static bool Box_NumPointsX_IsValid;

	private static FFieldAddress Box_NumPointsX_PropertyAddress;

	private static int Box_NumPointsX_Offset;

	private static bool Box_NumPointsY_IsValid;

	private static FFieldAddress Box_NumPointsY_PropertyAddress;

	private static int Box_NumPointsY_Offset;

	private static bool Box_NumPointsZ_IsValid;

	private static FFieldAddress Box_NumPointsZ_PropertyAddress;

	private static int Box_NumPointsZ_Offset;

	private static bool Box_ReturnValue_IsValid;

	private static FFieldAddress Box_ReturnValue_PropertyAddress;

	private static int Box_ReturnValue_Offset;

	private static bool Blast_IsValid;

	private static IntPtr Blast_FunctionAddress;

	private static int Blast_ParamsSize;

	private static bool Blast_Groups_IsValid;

	private static FFieldAddress Blast_Groups_PropertyAddress;

	private static int Blast_Groups_Offset;

	private static bool Blast_Tags_IsValid;

	private static FFieldAddress Blast_Tags_PropertyAddress;

	private static int Blast_Tags_Offset;

	private static bool Blast_DeleteNonSelected_IsValid;

	private static FFieldAddress Blast_DeleteNonSelected_PropertyAddress;

	private static int Blast_DeleteNonSelected_Offset;

	private static bool Blast_ReturnValue_IsValid;

	private static FFieldAddress Blast_ReturnValue_PropertyAddress;

	private static int Blast_ReturnValue_Offset;

	private static bool Arc_IsValid;

	private static IntPtr Arc_FunctionAddress;

	private static int Arc_ParamsSize;

	private static bool Arc_Groups_IsValid;

	private static FFieldAddress Arc_Groups_PropertyAddress;

	private static int Arc_Groups_Offset;

	private static bool Arc_NumSegments_IsValid;

	private static FFieldAddress Arc_NumSegments_PropertyAddress;

	private static int Arc_NumSegments_Offset;

	private static bool Arc_Angle_IsValid;

	private static FFieldAddress Arc_Angle_PropertyAddress;

	private static int Arc_Angle_Offset;

	private static bool Arc_ReturnValue_IsValid;

	private static FFieldAddress Arc_ReturnValue_PropertyAddress;

	private static int Arc_ReturnValue_Offset;

	private static bool Add_IsValid;

	private static IntPtr Add_FunctionAddress;

	private static int Add_ParamsSize;

	private static bool Add_Source_IsValid;

	private static FFieldAddress Add_Source_PropertyAddress;

	private static int Add_Source_Offset;

	private static bool Add_Transform_IsValid;

	private static FFieldAddress Add_Transform_PropertyAddress;

	private static int Add_Transform_Offset;

	private static bool Add_ReturnValue_IsValid;

	private static FFieldAddress Add_ReturnValue_PropertyAddress;

	private static int Add_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Voronoi")]
	public unsafe UArteriesObject Voronoi(string Groups, int Seed, int Count, float Density = 0f, int Iterations = 10)
	{
		CheckDestroyed();
		if (!Voronoi_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Voronoi");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Voronoi_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Voronoi_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Voronoi_Groups_Offset), 0, Voronoi_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Voronoi_Seed_Offset), 0, Voronoi_Seed_PropertyAddress.Address, Seed);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Voronoi_Count_Offset), 0, Voronoi_Count_PropertyAddress.Address, Count);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Voronoi_Density_Offset), 0, Voronoi_Density_PropertyAddress.Address, Density);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Voronoi_Iterations_Offset), 0, Voronoi_Iterations_PropertyAddress.Address, Iterations);
		NativeReflection.InvokeFunctionOptimized(base.Address, Voronoi_FunctionAddress, intPtr, Voronoi_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Voronoi_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Voronoi_ReturnValue_Offset), 0, Voronoi_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Tube")]
	public unsafe static UArteriesObject Tube(FVector Origin, FRotator Rotation, FVector2D Radius, float Height, int Rows, int Columns)
	{
		if (!Tube_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Tube");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tube_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tube_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Tube_Origin_Offset), 0, Tube_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Tube_Rotation_Offset), 0, Tube_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Tube_Radius_Offset), 0, Tube_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tube_Height_Offset), 0, Tube_Height_PropertyAddress.Address, Height);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Tube_Rows_Offset), 0, Tube_Rows_PropertyAddress.Address, Rows);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Tube_Columns_Offset), 0, Tube_Columns_PropertyAddress.Address, Columns);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Tube_FunctionAddress, intPtr, Tube_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Tube_ReturnValue_Offset), 0, Tube_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Triangulate")]
	public unsafe UArteriesObject Triangulate()
	{
		CheckDestroyed();
		if (!Triangulate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Triangulate");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Triangulate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Triangulate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Triangulate_FunctionAddress, intPtr, Triangulate_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Triangulate_ReturnValue_Offset), 0, Triangulate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Transform")]
	public unsafe UArteriesObject Transform(EArteriesGroupType GroupType, string Groups, FRotator Rotation, FVector Translation, FVector Scale)
	{
		CheckDestroyed();
		if (!Transform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Transform");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Transform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Transform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EArteriesGroupType>.ToNative(IntPtr.Add(intPtr, Transform_GroupType_Offset), 0, Transform_GroupType_PropertyAddress.Address, GroupType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Transform_Groups_Offset), 0, Transform_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Transform_Rotation_Offset), 0, Transform_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Transform_Translation_Offset), 0, Transform_Translation_PropertyAddress.Address, Translation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Transform_Scale_Offset), 0, Transform_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeFunctionOptimized(base.Address, Transform_FunctionAddress, intPtr, Transform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Transform_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Transform_ReturnValue_Offset), 0, Transform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Torus")]
	public unsafe static UArteriesObject Torus(FVector Origin, FRotator Rotation, FVector2D Radius, int Rows, int Columns)
	{
		if (!Torus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Torus");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Torus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Torus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Torus_Origin_Offset), 0, Torus_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Torus_Rotation_Offset), 0, Torus_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Torus_Radius_Offset), 0, Torus_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Torus_Rows_Offset), 0, Torus_Rows_PropertyAddress.Address, Rows);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Torus_Columns_Offset), 0, Torus_Columns_PropertyAddress.Address, Columns);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Torus_FunctionAddress, intPtr, Torus_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Torus_ReturnValue_Offset), 0, Torus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Sweep")]
	public unsafe UArteriesObject Sweep(UArteriesObject Backbones)
	{
		CheckDestroyed();
		if (!Sweep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Sweep");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Sweep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Sweep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, Sweep_Backbones_Offset), 0, Sweep_Backbones_PropertyAddress.Address, Backbones);
		NativeReflection.InvokeFunctionOptimized(base.Address, Sweep_FunctionAddress, intPtr, Sweep_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Sweep_ReturnValue_Offset), 0, Sweep_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:SubDivide")]
	public unsafe UArteriesObject SubDivide(string Groups, float MinLength = 1000f)
	{
		CheckDestroyed();
		if (!SubDivide_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:SubDivide");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SubDivide_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SubDivide_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SubDivide_Groups_Offset), 0, SubDivide_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SubDivide_MinLength_Offset), 0, SubDivide_MinLength_PropertyAddress.Address, MinLength);
		NativeReflection.InvokeFunctionOptimized(base.Address, SubDivide_FunctionAddress, intPtr, SubDivide_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SubDivide_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, SubDivide_ReturnValue_Offset), 0, SubDivide_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Sphere")]
	public unsafe static UArteriesObject Sphere(FVector Origin, FRotator Rotation, FVector Radius, int Rows, int Columns)
	{
		if (!Sphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Sphere");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Sphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Sphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Sphere_Origin_Offset), 0, Sphere_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Sphere_Rotation_Offset), 0, Sphere_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Sphere_Radius_Offset), 0, Sphere_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Sphere_Rows_Offset), 0, Sphere_Rows_PropertyAddress.Address, Rows);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Sphere_Columns_Offset), 0, Sphere_Columns_PropertyAddress.Address, Columns);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Sphere_FunctionAddress, intPtr, Sphere_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Sphere_ReturnValue_Offset), 0, Sphere_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:SortRandomly")]
	public unsafe UArteriesObject SortRandomly(int Seed)
	{
		CheckDestroyed();
		if (!SortRandomly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:SortRandomly");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortRandomly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortRandomly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SortRandomly_Seed_Offset), 0, SortRandomly_Seed_PropertyAddress.Address, Seed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortRandomly_FunctionAddress, intPtr, SortRandomly_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, SortRandomly_ReturnValue_Offset), 0, SortRandomly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:SortByAttribute")]
	public unsafe UArteriesObject SortByAttribute(FName AttrName)
	{
		CheckDestroyed();
		if (!SortByAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:SortByAttribute");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortByAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortByAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SortByAttribute_AttrName_Offset), 0, SortByAttribute_AttrName_PropertyAddress.Address, AttrName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortByAttribute_FunctionAddress, intPtr, SortByAttribute_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, SortByAttribute_ReturnValue_Offset), 0, SortByAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:SetMaterial")]
	public unsafe UArteriesObject SetMaterial(string Groups, UMaterialInterface Material, FVector2D UVScale, FVector2D UVOffset, float UVRotation, bool NullOnly)
	{
		CheckDestroyed();
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:SetMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMaterial_Groups_Offset), 0, SetMaterial_Groups_PropertyAddress.Address, Groups);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterial_Material_Offset), 0, SetMaterial_Material_PropertyAddress.Address, Material);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMaterial_UVScale_Offset), 0, SetMaterial_UVScale_PropertyAddress.Address, UVScale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMaterial_UVOffset_Offset), 0, SetMaterial_UVOffset_PropertyAddress.Address, UVOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaterial_UVRotation_Offset), 0, SetMaterial_UVRotation_PropertyAddress.Address, UVRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMaterial_NullOnly_Offset), 0, SetMaterial_NullOnly_PropertyAddress.Address, NullOnly);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMaterial_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, SetMaterial_ReturnValue_Offset), 0, SetMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Scatter")]
	public unsafe UArteriesObject Scatter(string Groups, int Seed, int Count, float Density = 0f, int Iterations = 10)
	{
		CheckDestroyed();
		if (!Scatter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Scatter");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Scatter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Scatter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Scatter_Groups_Offset), 0, Scatter_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Scatter_Seed_Offset), 0, Scatter_Seed_PropertyAddress.Address, Seed);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Scatter_Count_Offset), 0, Scatter_Count_PropertyAddress.Address, Count);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Scatter_Density_Offset), 0, Scatter_Density_PropertyAddress.Address, Density);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Scatter_Iterations_Offset), 0, Scatter_Iterations_PropertyAddress.Address, Iterations);
		NativeReflection.InvokeFunctionOptimized(base.Address, Scatter_FunctionAddress, intPtr, Scatter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Scatter_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Scatter_ReturnValue_Offset), 0, Scatter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Road")]
	public unsafe UArteriesObject Road(float DefaultWidth = 1000f)
	{
		CheckDestroyed();
		if (!Road_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Road");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Road_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Road_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Road_DefaultWidth_Offset), 0, Road_DefaultWidth_PropertyAddress.Address, DefaultWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, Road_FunctionAddress, intPtr, Road_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Road_ReturnValue_Offset), 0, Road_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Reverse")]
	public unsafe UArteriesObject Reverse(string Groups)
	{
		CheckDestroyed();
		if (!Reverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Reverse");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reverse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Reverse_Groups_Offset), 0, Reverse_Groups_PropertyAddress.Address, Groups);
		NativeReflection.InvokeFunctionOptimized(base.Address, Reverse_FunctionAddress, intPtr, Reverse_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Reverse_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Reverse_ReturnValue_Offset), 0, Reverse_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Resample")]
	public unsafe UArteriesObject Resample(bool ByEdge = true, float SegmentLength = 100f, int NumSegments = 0, EArteriesTangentOutputType OutputType = EArteriesTangentOutputType.Normal)
	{
		CheckDestroyed();
		if (!Resample_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Resample");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Resample_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Resample_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Resample_ByEdge_Offset), 0, Resample_ByEdge_PropertyAddress.Address, ByEdge);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Resample_SegmentLength_Offset), 0, Resample_SegmentLength_PropertyAddress.Address, SegmentLength);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Resample_NumSegments_Offset), 0, Resample_NumSegments_PropertyAddress.Address, NumSegments);
		EnumMarshaler<EArteriesTangentOutputType>.ToNative(IntPtr.Add(intPtr, Resample_OutputType_Offset), 0, Resample_OutputType_PropertyAddress.Address, OutputType);
		NativeReflection.InvokeFunctionOptimized(base.Address, Resample_FunctionAddress, intPtr, Resample_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Resample_ReturnValue_Offset), 0, Resample_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:PrimitiveInGroup")]
	public unsafe bool PrimitiveInGroup(FName GroupName, int Index)
	{
		CheckDestroyed();
		if (!PrimitiveInGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:PrimitiveInGroup");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrimitiveInGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrimitiveInGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PrimitiveInGroup_GroupName_Offset), 0, PrimitiveInGroup_GroupName_PropertyAddress.Address, GroupName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PrimitiveInGroup_Index_Offset), 0, PrimitiveInGroup_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, PrimitiveInGroup_FunctionAddress, intPtr, PrimitiveInGroup_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PrimitiveInGroup_ReturnValue_Offset), 0, PrimitiveInGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:PolyExtrude")]
	public unsafe UArteriesObject PolyExtrude(string Groups, float Distance, float Inset, FName FrontGroup, FName SideGroup, bool DeleteSource)
	{
		CheckDestroyed();
		if (!PolyExtrude_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:PolyExtrude");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PolyExtrude_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PolyExtrude_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PolyExtrude_Groups_Offset), 0, PolyExtrude_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PolyExtrude_Distance_Offset), 0, PolyExtrude_Distance_PropertyAddress.Address, Distance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PolyExtrude_Inset_Offset), 0, PolyExtrude_Inset_PropertyAddress.Address, Inset);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PolyExtrude_FrontGroup_Offset), 0, PolyExtrude_FrontGroup_PropertyAddress.Address, FrontGroup);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PolyExtrude_SideGroup_Offset), 0, PolyExtrude_SideGroup_PropertyAddress.Address, SideGroup);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PolyExtrude_DeleteSource_Offset), 0, PolyExtrude_DeleteSource_PropertyAddress.Address, DeleteSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, PolyExtrude_FunctionAddress, intPtr, PolyExtrude_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PolyExtrude_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, PolyExtrude_ReturnValue_Offset), 0, PolyExtrude_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:PolyExpand")]
	public unsafe UArteriesObject PolyExpand(string Groups, float Offset, FName CurveGroup, FName SurfaceGroup, bool OutputTangents, bool DeleteSource)
	{
		CheckDestroyed();
		if (!PolyExpand_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:PolyExpand");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PolyExpand_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PolyExpand_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PolyExpand_Groups_Offset), 0, PolyExpand_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PolyExpand_Offset_Offset), 0, PolyExpand_Offset_PropertyAddress.Address, Offset);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PolyExpand_CurveGroup_Offset), 0, PolyExpand_CurveGroup_PropertyAddress.Address, CurveGroup);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PolyExpand_SurfaceGroup_Offset), 0, PolyExpand_SurfaceGroup_PropertyAddress.Address, SurfaceGroup);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PolyExpand_OutputTangents_Offset), 0, PolyExpand_OutputTangents_PropertyAddress.Address, OutputTangents);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PolyExpand_DeleteSource_Offset), 0, PolyExpand_DeleteSource_PropertyAddress.Address, DeleteSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, PolyExpand_FunctionAddress, intPtr, PolyExpand_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PolyExpand_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, PolyExpand_ReturnValue_Offset), 0, PolyExpand_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:PolyBevel")]
	public unsafe UArteriesObject PolyBevel(EArteriesGroupType GroupType, string Groups, float Distance, int Divisions = 2, bool bBevelSingleCurve = true)
	{
		CheckDestroyed();
		if (!PolyBevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:PolyBevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PolyBevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PolyBevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EArteriesGroupType>.ToNative(IntPtr.Add(intPtr, PolyBevel_GroupType_Offset), 0, PolyBevel_GroupType_PropertyAddress.Address, GroupType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PolyBevel_Groups_Offset), 0, PolyBevel_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PolyBevel_Distance_Offset), 0, PolyBevel_Distance_PropertyAddress.Address, Distance);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PolyBevel_Divisions_Offset), 0, PolyBevel_Divisions_PropertyAddress.Address, Divisions);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PolyBevel_bBevelSingleCurve_Offset), 0, PolyBevel_bBevelSingleCurve_PropertyAddress.Address, bBevelSingleCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, PolyBevel_FunctionAddress, intPtr, PolyBevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PolyBevel_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, PolyBevel_ReturnValue_Offset), 0, PolyBevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:PointInGroup")]
	public unsafe bool PointInGroup(FName GroupName, int Index)
	{
		CheckDestroyed();
		if (!PointInGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:PointInGroup");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointInGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointInGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PointInGroup_GroupName_Offset), 0, PointInGroup_GroupName_PropertyAddress.Address, GroupName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PointInGroup_Index_Offset), 0, PointInGroup_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, PointInGroup_FunctionAddress, intPtr, PointInGroup_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointInGroup_ReturnValue_Offset), 0, PointInGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:NumPrimitives")]
	public unsafe int NumPrimitives()
	{
		CheckDestroyed();
		if (!NumPrimitives_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:NumPrimitives");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NumPrimitives_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NumPrimitives_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NumPrimitives_FunctionAddress, intPtr, NumPrimitives_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, NumPrimitives_ReturnValue_Offset), 0, NumPrimitives_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:NumPoints")]
	public unsafe int NumPoints()
	{
		CheckDestroyed();
		if (!NumPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:NumPoints");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NumPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NumPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NumPoints_FunctionAddress, intPtr, NumPoints_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, NumPoints_ReturnValue_Offset), 0, NumPoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:New")]
	public unsafe static UArteriesObject New()
	{
		if (!New_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:New");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(New_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)New_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, New_FunctionAddress, intPtr, New_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, New_ReturnValue_Offset), 0, New_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:MergeArray")]
	public unsafe static UArteriesObject MergeArray(List<UArteriesObject> Objs)
	{
		if (!MergeArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:MergeArray");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UArteriesObject>(1, MergeArray_Objs_PropertyAddress, CachedMarshalingDelegates<UArteriesObject, UObjectMarshaler<UArteriesObject>>.FromNative, CachedMarshalingDelegates<UArteriesObject, UObjectMarshaler<UArteriesObject>>.ToNative).ToNative(IntPtr.Add(intPtr, MergeArray_Objs_Offset), Objs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MergeArray_FunctionAddress, intPtr, MergeArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MergeArray_Objs_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, MergeArray_ReturnValue_Offset), 0, MergeArray_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Merge")]
	public unsafe static UArteriesObject Merge(UArteriesObject Obj0, UArteriesObject Obj1, UArteriesObject Obj2, UArteriesObject Obj3, UArteriesObject Obj4)
	{
		if (!Merge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Merge");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Merge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Merge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, Merge_Obj0_Offset), 0, Merge_Obj0_PropertyAddress.Address, Obj0);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, Merge_Obj1_Offset), 0, Merge_Obj1_PropertyAddress.Address, Obj1);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, Merge_Obj2_Offset), 0, Merge_Obj2_PropertyAddress.Address, Obj2);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, Merge_Obj3_Offset), 0, Merge_Obj3_PropertyAddress.Address, Obj3);
		UObjectMarshaler<UArteriesObject>.ToNative(IntPtr.Add(intPtr, Merge_Obj4_Offset), 0, Merge_Obj4_PropertyAddress.Address, Obj4);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Merge_FunctionAddress, intPtr, Merge_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Merge_ReturnValue_Offset), 0, Merge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Measure")]
	public unsafe UArteriesObject Measure(FName Name)
	{
		CheckDestroyed();
		if (!Measure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Measure");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Measure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Measure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Measure_Name_Offset), 0, Measure_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, Measure_FunctionAddress, intPtr, Measure_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Measure_ReturnValue_Offset), 0, Measure_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:MakeGrids")]
	public unsafe UArteriesObject MakeGrids(string Groups, float GridSize = 0f, int MinGrids = 3, bool OBBOnly = false)
	{
		CheckDestroyed();
		if (!MakeGrids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:MakeGrids");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGrids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGrids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakeGrids_Groups_Offset), 0, MakeGrids_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeGrids_GridSize_Offset), 0, MakeGrids_GridSize_PropertyAddress.Address, GridSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeGrids_MinGrids_Offset), 0, MakeGrids_MinGrids_PropertyAddress.Address, MinGrids);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeGrids_OBBOnly_Offset), 0, MakeGrids_OBBOnly_PropertyAddress.Address, OBBOnly);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeGrids_FunctionAddress, intPtr, MakeGrids_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeGrids_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, MakeGrids_ReturnValue_Offset), 0, MakeGrids_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Line")]
	public unsafe static UArteriesObject Line(FVector Origin, FVector Direction, float Length, int NumPoints)
	{
		if (!Line_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Line");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Line_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Line_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Line_Origin_Offset), 0, Line_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Line_Direction_Offset), 0, Line_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Line_Length_Offset), 0, Line_Length_PropertyAddress.Address, Length);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Line_NumPoints_Offset), 0, Line_NumPoints_PropertyAddress.Address, NumPoints);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Line_FunctionAddress, intPtr, Line_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Line_ReturnValue_Offset), 0, Line_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:LastPrimitive")]
	public unsafe int LastPrimitive()
	{
		CheckDestroyed();
		if (!LastPrimitive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:LastPrimitive");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LastPrimitive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LastPrimitive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, LastPrimitive_FunctionAddress, intPtr, LastPrimitive_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LastPrimitive_ReturnValue_Offset), 0, LastPrimitive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:LastPoint")]
	public unsafe int LastPoint()
	{
		CheckDestroyed();
		if (!LastPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:LastPoint");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LastPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LastPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, LastPoint_FunctionAddress, intPtr, LastPoint_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LastPoint_ReturnValue_Offset), 0, LastPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Hole")]
	public unsafe UArteriesObject Hole(string OuterGroups, string InnerGroups, float Tolerance = 10f)
	{
		CheckDestroyed();
		if (!Hole_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Hole");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Hole_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Hole_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Hole_OuterGroups_Offset), 0, Hole_OuterGroups_PropertyAddress.Address, OuterGroups);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Hole_InnerGroups_Offset), 0, Hole_InnerGroups_PropertyAddress.Address, InnerGroups);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Hole_Tolerance_Offset), 0, Hole_Tolerance_PropertyAddress.Address, Tolerance);
		NativeReflection.InvokeFunctionOptimized(base.Address, Hole_FunctionAddress, intPtr, Hole_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Hole_OuterGroups_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Hole_InnerGroups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Hole_ReturnValue_Offset), 0, Hole_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:GroupRange")]
	public unsafe UArteriesObject GroupRange(List<FArteriesGroupRange> Groups)
	{
		CheckDestroyed();
		if (!GroupRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:GroupRange");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GroupRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GroupRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FArteriesGroupRange>(1, GroupRange_Groups_PropertyAddress, CachedMarshalingDelegates<FArteriesGroupRange, FArteriesGroupRange>.FromNative, CachedMarshalingDelegates<FArteriesGroupRange, FArteriesGroupRange>.ToNative).ToNative(IntPtr.Add(intPtr, GroupRange_Groups_Offset), Groups);
		NativeReflection.InvokeFunctionOptimized(base.Address, GroupRange_FunctionAddress, intPtr, GroupRange_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GroupRange_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, GroupRange_ReturnValue_Offset), 0, GroupRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Ground")]
	public unsafe UArteriesObject Ground()
	{
		CheckDestroyed();
		if (!Ground_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Ground");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Ground_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Ground_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Ground_FunctionAddress, intPtr, Ground_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Ground_ReturnValue_Offset), 0, Ground_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Grid")]
	public unsafe static UArteriesObject Grid(FVector Origin, FRotator Rotation, FVector2D Size, int NumPointsX, int NumPointsY)
	{
		if (!Grid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Grid");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Grid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Grid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Grid_Origin_Offset), 0, Grid_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Grid_Rotation_Offset), 0, Grid_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Grid_Size_Offset), 0, Grid_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Grid_NumPointsX_Offset), 0, Grid_NumPointsX_PropertyAddress.Address, NumPointsX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Grid_NumPointsY_Offset), 0, Grid_NumPointsY_PropertyAddress.Address, NumPointsY);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Grid_FunctionAddress, intPtr, Grid_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Grid_ReturnValue_Offset), 0, Grid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:GetPrimitiveInt")]
	public unsafe int GetPrimitiveInt(FName Key, int Index)
	{
		CheckDestroyed();
		if (!GetPrimitiveInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:GetPrimitiveInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrimitiveInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrimitiveInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPrimitiveInt_Key_Offset), 0, GetPrimitiveInt_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPrimitiveInt_Index_Offset), 0, GetPrimitiveInt_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPrimitiveInt_FunctionAddress, intPtr, GetPrimitiveInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPrimitiveInt_ReturnValue_Offset), 0, GetPrimitiveInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:GetPointTransform")]
	public unsafe FTransform GetPointTransform(int Index)
	{
		CheckDestroyed();
		if (!GetPointTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:GetPointTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPointTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPointTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPointTransform_Index_Offset), 0, GetPointTransform_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPointTransform_FunctionAddress, intPtr, GetPointTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetPointTransform_ReturnValue_Offset), 0, GetPointTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:GetPointInt")]
	public unsafe int GetPointInt(FName Key, int Index)
	{
		CheckDestroyed();
		if (!GetPointInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:GetPointInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPointInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPointInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPointInt_Key_Offset), 0, GetPointInt_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPointInt_Index_Offset), 0, GetPointInt_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPointInt_FunctionAddress, intPtr, GetPointInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPointInt_ReturnValue_Offset), 0, GetPointInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Fuse")]
	public unsafe UArteriesObject Fuse(string Groups, float SnapDist)
	{
		CheckDestroyed();
		if (!Fuse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Fuse");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Fuse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Fuse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Fuse_Groups_Offset), 0, Fuse_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Fuse_SnapDist_Offset), 0, Fuse_SnapDist_PropertyAddress.Address, SnapDist);
		NativeReflection.InvokeFunctionOptimized(base.Address, Fuse_FunctionAddress, intPtr, Fuse_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Fuse_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Fuse_ReturnValue_Offset), 0, Fuse_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Flatten")]
	public unsafe static FTransform Flatten(FTransform Transform)
	{
		if (!Flatten_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Flatten");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Flatten_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Flatten_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Flatten_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Flatten_Transform_Offset), 0, Flatten_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Flatten_FunctionAddress, intPtr, Flatten_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, Flatten_ReturnValue_Offset), 0, Flatten_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Facet")]
	public unsafe UArteriesObject Facet(float Tolerance = 0.0001f)
	{
		CheckDestroyed();
		if (!Facet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Facet");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Facet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Facet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Facet_Tolerance_Offset), 0, Facet_Tolerance_PropertyAddress.Address, Tolerance);
		NativeReflection.InvokeFunctionOptimized(base.Address, Facet_FunctionAddress, intPtr, Facet_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Facet_ReturnValue_Offset), 0, Facet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Divide")]
	public unsafe UArteriesObject Divide(float Tolerance = 0.999f)
	{
		CheckDestroyed();
		if (!Divide_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Divide");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Divide_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Divide_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Divide_Tolerance_Offset), 0, Divide_Tolerance_PropertyAddress.Address, Tolerance);
		NativeReflection.InvokeFunctionOptimized(base.Address, Divide_FunctionAddress, intPtr, Divide_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Divide_ReturnValue_Offset), 0, Divide_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:CopyToPoints")]
	public unsafe UArteriesObject CopyToPoints(string Groups, UObject Source, FTransform LocalTransform)
	{
		CheckDestroyed();
		if (!CopyToPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:CopyToPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyToPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyToPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CopyToPoints_Groups_Offset), 0, CopyToPoints_Groups_PropertyAddress.Address, Groups);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CopyToPoints_Source_Offset), 0, CopyToPoints_Source_PropertyAddress.Address, Source);
		NativeReflection.InitializeValue_InContainer(CopyToPoints_LocalTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CopyToPoints_LocalTransform_Offset), 0, CopyToPoints_LocalTransform_PropertyAddress.Address, LocalTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyToPoints_FunctionAddress, intPtr, CopyToPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyToPoints_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, CopyToPoints_ReturnValue_Offset), 0, CopyToPoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:CopyAndTransform")]
	public unsafe UArteriesObject CopyAndTransform(int NumCopies, FTransform Transform)
	{
		CheckDestroyed();
		if (!CopyAndTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:CopyAndTransform");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAndTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAndTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CopyAndTransform_NumCopies_Offset), 0, CopyAndTransform_NumCopies_PropertyAddress.Address, NumCopies);
		NativeReflection.InitializeValue_InContainer(CopyAndTransform_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CopyAndTransform_Transform_Offset), 0, CopyAndTransform_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyAndTransform_FunctionAddress, intPtr, CopyAndTransform_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, CopyAndTransform_ReturnValue_Offset), 0, CopyAndTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Copy")]
	public unsafe UArteriesObject Copy_()
	{
		CheckDestroyed();
		if (!Copy__IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Copy");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Copy__ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Copy__ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Copy__FunctionAddress, intPtr, Copy__ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Copy__ReturnValue_Offset), 0, Copy__ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Clip")]
	public unsafe UArteriesObject Clip(string Groups, FVector PlaneNormal, float PlaneDist, FName PositiveGroup, FName NegativeGroup)
	{
		CheckDestroyed();
		if (!Clip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Clip");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Clip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Clip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Clip_Groups_Offset), 0, Clip_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Clip_PlaneNormal_Offset), 0, Clip_PlaneNormal_PropertyAddress.Address, PlaneNormal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Clip_PlaneDist_Offset), 0, Clip_PlaneDist_PropertyAddress.Address, PlaneDist);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Clip_PositiveGroup_Offset), 0, Clip_PositiveGroup_PropertyAddress.Address, PositiveGroup);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Clip_NegativeGroup_Offset), 0, Clip_NegativeGroup_PropertyAddress.Address, NegativeGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, Clip_FunctionAddress, intPtr, Clip_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Clip_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Clip_ReturnValue_Offset), 0, Clip_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Clean")]
	public unsafe UArteriesObject Clean()
	{
		CheckDestroyed();
		if (!Clean_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Clean");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Clean_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Clean_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Clean_FunctionAddress, intPtr, Clean_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Clean_ReturnValue_Offset), 0, Clean_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Circle")]
	public unsafe static UArteriesObject Circle(FVector Origin, FRotator Rotation, FVector2D Radius, int NumPoints)
	{
		if (!Circle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Circle");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Circle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Circle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Circle_Origin_Offset), 0, Circle_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Circle_Rotation_Offset), 0, Circle_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Circle_Radius_Offset), 0, Circle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Circle_NumPoints_Offset), 0, Circle_NumPoints_PropertyAddress.Address, NumPoints);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Circle_FunctionAddress, intPtr, Circle_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Circle_ReturnValue_Offset), 0, Circle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Carve")]
	public unsafe UArteriesObject Carve(EArteriesAlignType StartAlign = EArteriesAlignType.Start, float StartU = 0f, EArteriesAlignType EndAlign = EArteriesAlignType.End, float EndU = 0f)
	{
		CheckDestroyed();
		if (!Carve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Carve");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Carve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Carve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EArteriesAlignType>.ToNative(IntPtr.Add(intPtr, Carve_StartAlign_Offset), 0, Carve_StartAlign_PropertyAddress.Address, StartAlign);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Carve_StartU_Offset), 0, Carve_StartU_PropertyAddress.Address, StartU);
		EnumMarshaler<EArteriesAlignType>.ToNative(IntPtr.Add(intPtr, Carve_EndAlign_Offset), 0, Carve_EndAlign_PropertyAddress.Address, EndAlign);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Carve_EndU_Offset), 0, Carve_EndU_PropertyAddress.Address, EndU);
		NativeReflection.InvokeFunctionOptimized(base.Address, Carve_FunctionAddress, intPtr, Carve_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Carve_ReturnValue_Offset), 0, Carve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Bridge")]
	public unsafe UArteriesObject Bridge(FName StartGroupName, FName EndGroupName)
	{
		CheckDestroyed();
		if (!Bridge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Bridge");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Bridge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Bridge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Bridge_StartGroupName_Offset), 0, Bridge_StartGroupName_PropertyAddress.Address, StartGroupName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Bridge_EndGroupName_Offset), 0, Bridge_EndGroupName_PropertyAddress.Address, EndGroupName);
		NativeReflection.InvokeFunctionOptimized(base.Address, Bridge_FunctionAddress, intPtr, Bridge_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Bridge_ReturnValue_Offset), 0, Bridge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:BreakPoints")]
	public unsafe UArteriesObject BreakPoints(string Groups)
	{
		CheckDestroyed();
		if (!BreakPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:BreakPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BreakPoints_Groups_Offset), 0, BreakPoints_Groups_PropertyAddress.Address, Groups);
		NativeReflection.InvokeFunctionOptimized(base.Address, BreakPoints_FunctionAddress, intPtr, BreakPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BreakPoints_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, BreakPoints_ReturnValue_Offset), 0, BreakPoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Box")]
	public unsafe static UArteriesObject Box(FVector Origin, FRotator Rotation, FVector Size, int NumPointsX, int NumPointsY, int NumPointsZ)
	{
		if (!Box_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Box");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Box_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Box_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Box_Origin_Offset), 0, Box_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Box_Rotation_Offset), 0, Box_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Box_Size_Offset), 0, Box_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Box_NumPointsX_Offset), 0, Box_NumPointsX_PropertyAddress.Address, NumPointsX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Box_NumPointsY_Offset), 0, Box_NumPointsY_PropertyAddress.Address, NumPointsY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Box_NumPointsZ_Offset), 0, Box_NumPointsZ_PropertyAddress.Address, NumPointsZ);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Box_FunctionAddress, intPtr, Box_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Box_ReturnValue_Offset), 0, Box_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Blast")]
	public unsafe UArteriesObject Blast(string Groups, string Tags, bool DeleteNonSelected = false)
	{
		CheckDestroyed();
		if (!Blast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Blast");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Blast_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Blast_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Blast_Groups_Offset), 0, Blast_Groups_PropertyAddress.Address, Groups);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Blast_Tags_Offset), 0, Blast_Tags_PropertyAddress.Address, Tags);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Blast_DeleteNonSelected_Offset), 0, Blast_DeleteNonSelected_PropertyAddress.Address, DeleteNonSelected);
		NativeReflection.InvokeFunctionOptimized(base.Address, Blast_FunctionAddress, intPtr, Blast_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Blast_Groups_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(Blast_Tags_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Blast_ReturnValue_Offset), 0, Blast_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Arc")]
	public unsafe UArteriesObject Arc(string Groups, int NumSegments = 4, float Angle = 90f)
	{
		CheckDestroyed();
		if (!Arc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Arc");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Arc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Arc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Arc_Groups_Offset), 0, Arc_Groups_PropertyAddress.Address, Groups);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Arc_NumSegments_Offset), 0, Arc_NumSegments_PropertyAddress.Address, NumSegments);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Arc_Angle_Offset), 0, Arc_Angle_PropertyAddress.Address, Angle);
		NativeReflection.InvokeFunctionOptimized(base.Address, Arc_FunctionAddress, intPtr, Arc_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Arc_Groups_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Arc_ReturnValue_Offset), 0, Arc_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Arteries.ArteriesObject:Add")]
	public unsafe UArteriesObject Add(UObject Source, FTransform Transform)
	{
		CheckDestroyed();
		if (!Add_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Arteries.ArteriesObject:Add");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Add_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Add_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Add_Source_Offset), 0, Add_Source_PropertyAddress.Address, Source);
		NativeReflection.InitializeValue_InContainer(Add_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Add_Transform_Offset), 0, Add_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeFunctionOptimized(base.Address, Add_FunctionAddress, intPtr, Add_ParamsSize);
		return UObjectMarshaler<UArteriesObject>.FromNative(IntPtr.Add(intPtr, Add_ReturnValue_Offset), 0, Add_ReturnValue_PropertyAddress.Address);
	}

	static UArteriesObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UArteriesObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UArteriesObject));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Arteries.ArteriesObject");
		Voronoi_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Voronoi");
		Voronoi_ParamsSize = NativeReflection.GetFunctionParamsSize(Voronoi_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Voronoi_Groups_PropertyAddress, Voronoi_FunctionAddress, "Groups");
		Voronoi_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Voronoi_FunctionAddress, "Groups");
		Voronoi_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Voronoi_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Voronoi_Seed_PropertyAddress, Voronoi_FunctionAddress, "Seed");
		Voronoi_Seed_Offset = NativeReflectionCached.GetPropertyOffset(Voronoi_FunctionAddress, "Seed");
		Voronoi_Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(Voronoi_FunctionAddress, "Seed", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Voronoi_Count_PropertyAddress, Voronoi_FunctionAddress, "Count");
		Voronoi_Count_Offset = NativeReflectionCached.GetPropertyOffset(Voronoi_FunctionAddress, "Count");
		Voronoi_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(Voronoi_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Voronoi_Density_PropertyAddress, Voronoi_FunctionAddress, "Density");
		Voronoi_Density_Offset = NativeReflectionCached.GetPropertyOffset(Voronoi_FunctionAddress, "Density");
		Voronoi_Density_IsValid = NativeReflectionCached.ValidatePropertyClass(Voronoi_FunctionAddress, "Density", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Voronoi_Iterations_PropertyAddress, Voronoi_FunctionAddress, "Iterations");
		Voronoi_Iterations_Offset = NativeReflectionCached.GetPropertyOffset(Voronoi_FunctionAddress, "Iterations");
		Voronoi_Iterations_IsValid = NativeReflectionCached.ValidatePropertyClass(Voronoi_FunctionAddress, "Iterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Voronoi_ReturnValue_PropertyAddress, Voronoi_FunctionAddress, "ReturnValue");
		Voronoi_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Voronoi_FunctionAddress, "ReturnValue");
		Voronoi_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Voronoi_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Voronoi_IsValid = Voronoi_FunctionAddress != IntPtr.Zero && Voronoi_Groups_IsValid && Voronoi_Seed_IsValid && Voronoi_Count_IsValid && Voronoi_Density_IsValid && Voronoi_Iterations_IsValid && Voronoi_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Voronoi", Voronoi_IsValid);
		Tube_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Tube");
		Tube_ParamsSize = NativeReflection.GetFunctionParamsSize(Tube_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Tube_Origin_PropertyAddress, Tube_FunctionAddress, "Origin");
		Tube_Origin_Offset = NativeReflectionCached.GetPropertyOffset(Tube_FunctionAddress, "Origin");
		Tube_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(Tube_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Tube_Rotation_PropertyAddress, Tube_FunctionAddress, "Rotation");
		Tube_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(Tube_FunctionAddress, "Rotation");
		Tube_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Tube_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Tube_Radius_PropertyAddress, Tube_FunctionAddress, "Radius");
		Tube_Radius_Offset = NativeReflectionCached.GetPropertyOffset(Tube_FunctionAddress, "Radius");
		Tube_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(Tube_FunctionAddress, "Radius", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Tube_Height_PropertyAddress, Tube_FunctionAddress, "Height");
		Tube_Height_Offset = NativeReflectionCached.GetPropertyOffset(Tube_FunctionAddress, "Height");
		Tube_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(Tube_FunctionAddress, "Height", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Tube_Rows_PropertyAddress, Tube_FunctionAddress, "Rows");
		Tube_Rows_Offset = NativeReflectionCached.GetPropertyOffset(Tube_FunctionAddress, "Rows");
		Tube_Rows_IsValid = NativeReflectionCached.ValidatePropertyClass(Tube_FunctionAddress, "Rows", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Tube_Columns_PropertyAddress, Tube_FunctionAddress, "Columns");
		Tube_Columns_Offset = NativeReflectionCached.GetPropertyOffset(Tube_FunctionAddress, "Columns");
		Tube_Columns_IsValid = NativeReflectionCached.ValidatePropertyClass(Tube_FunctionAddress, "Columns", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Tube_ReturnValue_PropertyAddress, Tube_FunctionAddress, "ReturnValue");
		Tube_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Tube_FunctionAddress, "ReturnValue");
		Tube_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Tube_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Tube_IsValid = Tube_FunctionAddress != IntPtr.Zero && Tube_Origin_IsValid && Tube_Rotation_IsValid && Tube_Radius_IsValid && Tube_Height_IsValid && Tube_Rows_IsValid && Tube_Columns_IsValid && Tube_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Tube", Tube_IsValid);
		Triangulate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Triangulate");
		Triangulate_ParamsSize = NativeReflection.GetFunctionParamsSize(Triangulate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Triangulate_ReturnValue_PropertyAddress, Triangulate_FunctionAddress, "ReturnValue");
		Triangulate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Triangulate_FunctionAddress, "ReturnValue");
		Triangulate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Triangulate_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Triangulate_IsValid = Triangulate_FunctionAddress != IntPtr.Zero && Triangulate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Triangulate", Triangulate_IsValid);
		Transform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Transform");
		Transform_ParamsSize = NativeReflection.GetFunctionParamsSize(Transform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Transform_GroupType_PropertyAddress, Transform_FunctionAddress, "GroupType");
		Transform_GroupType_Offset = NativeReflectionCached.GetPropertyOffset(Transform_FunctionAddress, "GroupType");
		Transform_GroupType_IsValid = NativeReflectionCached.ValidatePropertyClass(Transform_FunctionAddress, "GroupType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Transform_Groups_PropertyAddress, Transform_FunctionAddress, "Groups");
		Transform_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Transform_FunctionAddress, "Groups");
		Transform_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Transform_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Transform_Rotation_PropertyAddress, Transform_FunctionAddress, "Rotation");
		Transform_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(Transform_FunctionAddress, "Rotation");
		Transform_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Transform_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Transform_Translation_PropertyAddress, Transform_FunctionAddress, "Translation");
		Transform_Translation_Offset = NativeReflectionCached.GetPropertyOffset(Transform_FunctionAddress, "Translation");
		Transform_Translation_IsValid = NativeReflectionCached.ValidatePropertyClass(Transform_FunctionAddress, "Translation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Transform_Scale_PropertyAddress, Transform_FunctionAddress, "Scale");
		Transform_Scale_Offset = NativeReflectionCached.GetPropertyOffset(Transform_FunctionAddress, "Scale");
		Transform_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(Transform_FunctionAddress, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Transform_ReturnValue_PropertyAddress, Transform_FunctionAddress, "ReturnValue");
		Transform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Transform_FunctionAddress, "ReturnValue");
		Transform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Transform_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Transform_IsValid = Transform_FunctionAddress != IntPtr.Zero && Transform_GroupType_IsValid && Transform_Groups_IsValid && Transform_Rotation_IsValid && Transform_Translation_IsValid && Transform_Scale_IsValid && Transform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Transform", Transform_IsValid);
		Torus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Torus");
		Torus_ParamsSize = NativeReflection.GetFunctionParamsSize(Torus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Torus_Origin_PropertyAddress, Torus_FunctionAddress, "Origin");
		Torus_Origin_Offset = NativeReflectionCached.GetPropertyOffset(Torus_FunctionAddress, "Origin");
		Torus_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(Torus_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Torus_Rotation_PropertyAddress, Torus_FunctionAddress, "Rotation");
		Torus_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(Torus_FunctionAddress, "Rotation");
		Torus_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Torus_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Torus_Radius_PropertyAddress, Torus_FunctionAddress, "Radius");
		Torus_Radius_Offset = NativeReflectionCached.GetPropertyOffset(Torus_FunctionAddress, "Radius");
		Torus_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(Torus_FunctionAddress, "Radius", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Torus_Rows_PropertyAddress, Torus_FunctionAddress, "Rows");
		Torus_Rows_Offset = NativeReflectionCached.GetPropertyOffset(Torus_FunctionAddress, "Rows");
		Torus_Rows_IsValid = NativeReflectionCached.ValidatePropertyClass(Torus_FunctionAddress, "Rows", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Torus_Columns_PropertyAddress, Torus_FunctionAddress, "Columns");
		Torus_Columns_Offset = NativeReflectionCached.GetPropertyOffset(Torus_FunctionAddress, "Columns");
		Torus_Columns_IsValid = NativeReflectionCached.ValidatePropertyClass(Torus_FunctionAddress, "Columns", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Torus_ReturnValue_PropertyAddress, Torus_FunctionAddress, "ReturnValue");
		Torus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Torus_FunctionAddress, "ReturnValue");
		Torus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Torus_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Torus_IsValid = Torus_FunctionAddress != IntPtr.Zero && Torus_Origin_IsValid && Torus_Rotation_IsValid && Torus_Radius_IsValid && Torus_Rows_IsValid && Torus_Columns_IsValid && Torus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Torus", Torus_IsValid);
		Sweep_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Sweep");
		Sweep_ParamsSize = NativeReflection.GetFunctionParamsSize(Sweep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Sweep_Backbones_PropertyAddress, Sweep_FunctionAddress, "Backbones");
		Sweep_Backbones_Offset = NativeReflectionCached.GetPropertyOffset(Sweep_FunctionAddress, "Backbones");
		Sweep_Backbones_IsValid = NativeReflectionCached.ValidatePropertyClass(Sweep_FunctionAddress, "Backbones", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Sweep_ReturnValue_PropertyAddress, Sweep_FunctionAddress, "ReturnValue");
		Sweep_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Sweep_FunctionAddress, "ReturnValue");
		Sweep_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Sweep_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Sweep_IsValid = Sweep_FunctionAddress != IntPtr.Zero && Sweep_Backbones_IsValid && Sweep_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Sweep", Sweep_IsValid);
		SubDivide_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SubDivide");
		SubDivide_ParamsSize = NativeReflection.GetFunctionParamsSize(SubDivide_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SubDivide_Groups_PropertyAddress, SubDivide_FunctionAddress, "Groups");
		SubDivide_Groups_Offset = NativeReflectionCached.GetPropertyOffset(SubDivide_FunctionAddress, "Groups");
		SubDivide_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(SubDivide_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SubDivide_MinLength_PropertyAddress, SubDivide_FunctionAddress, "MinLength");
		SubDivide_MinLength_Offset = NativeReflectionCached.GetPropertyOffset(SubDivide_FunctionAddress, "MinLength");
		SubDivide_MinLength_IsValid = NativeReflectionCached.ValidatePropertyClass(SubDivide_FunctionAddress, "MinLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SubDivide_ReturnValue_PropertyAddress, SubDivide_FunctionAddress, "ReturnValue");
		SubDivide_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SubDivide_FunctionAddress, "ReturnValue");
		SubDivide_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SubDivide_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SubDivide_IsValid = SubDivide_FunctionAddress != IntPtr.Zero && SubDivide_Groups_IsValid && SubDivide_MinLength_IsValid && SubDivide_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:SubDivide", SubDivide_IsValid);
		Sphere_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Sphere");
		Sphere_ParamsSize = NativeReflection.GetFunctionParamsSize(Sphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Sphere_Origin_PropertyAddress, Sphere_FunctionAddress, "Origin");
		Sphere_Origin_Offset = NativeReflectionCached.GetPropertyOffset(Sphere_FunctionAddress, "Origin");
		Sphere_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(Sphere_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Sphere_Rotation_PropertyAddress, Sphere_FunctionAddress, "Rotation");
		Sphere_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(Sphere_FunctionAddress, "Rotation");
		Sphere_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Sphere_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Sphere_Radius_PropertyAddress, Sphere_FunctionAddress, "Radius");
		Sphere_Radius_Offset = NativeReflectionCached.GetPropertyOffset(Sphere_FunctionAddress, "Radius");
		Sphere_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(Sphere_FunctionAddress, "Radius", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Sphere_Rows_PropertyAddress, Sphere_FunctionAddress, "Rows");
		Sphere_Rows_Offset = NativeReflectionCached.GetPropertyOffset(Sphere_FunctionAddress, "Rows");
		Sphere_Rows_IsValid = NativeReflectionCached.ValidatePropertyClass(Sphere_FunctionAddress, "Rows", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Sphere_Columns_PropertyAddress, Sphere_FunctionAddress, "Columns");
		Sphere_Columns_Offset = NativeReflectionCached.GetPropertyOffset(Sphere_FunctionAddress, "Columns");
		Sphere_Columns_IsValid = NativeReflectionCached.ValidatePropertyClass(Sphere_FunctionAddress, "Columns", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Sphere_ReturnValue_PropertyAddress, Sphere_FunctionAddress, "ReturnValue");
		Sphere_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Sphere_FunctionAddress, "ReturnValue");
		Sphere_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Sphere_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Sphere_IsValid = Sphere_FunctionAddress != IntPtr.Zero && Sphere_Origin_IsValid && Sphere_Rotation_IsValid && Sphere_Radius_IsValid && Sphere_Rows_IsValid && Sphere_Columns_IsValid && Sphere_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Sphere", Sphere_IsValid);
		SortRandomly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SortRandomly");
		SortRandomly_ParamsSize = NativeReflection.GetFunctionParamsSize(SortRandomly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortRandomly_Seed_PropertyAddress, SortRandomly_FunctionAddress, "Seed");
		SortRandomly_Seed_Offset = NativeReflectionCached.GetPropertyOffset(SortRandomly_FunctionAddress, "Seed");
		SortRandomly_Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(SortRandomly_FunctionAddress, "Seed", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SortRandomly_ReturnValue_PropertyAddress, SortRandomly_FunctionAddress, "ReturnValue");
		SortRandomly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SortRandomly_FunctionAddress, "ReturnValue");
		SortRandomly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SortRandomly_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SortRandomly_IsValid = SortRandomly_FunctionAddress != IntPtr.Zero && SortRandomly_Seed_IsValid && SortRandomly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:SortRandomly", SortRandomly_IsValid);
		SortByAttribute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SortByAttribute");
		SortByAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(SortByAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortByAttribute_AttrName_PropertyAddress, SortByAttribute_FunctionAddress, "AttrName");
		SortByAttribute_AttrName_Offset = NativeReflectionCached.GetPropertyOffset(SortByAttribute_FunctionAddress, "AttrName");
		SortByAttribute_AttrName_IsValid = NativeReflectionCached.ValidatePropertyClass(SortByAttribute_FunctionAddress, "AttrName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SortByAttribute_ReturnValue_PropertyAddress, SortByAttribute_FunctionAddress, "ReturnValue");
		SortByAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SortByAttribute_FunctionAddress, "ReturnValue");
		SortByAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SortByAttribute_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SortByAttribute_IsValid = SortByAttribute_FunctionAddress != IntPtr.Zero && SortByAttribute_AttrName_IsValid && SortByAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:SortByAttribute", SortByAttribute_IsValid);
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Groups_PropertyAddress, SetMaterial_FunctionAddress, "Groups");
		SetMaterial_Groups_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Groups");
		SetMaterial_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Material_PropertyAddress, SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_UVScale_PropertyAddress, SetMaterial_FunctionAddress, "UVScale");
		SetMaterial_UVScale_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "UVScale");
		SetMaterial_UVScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "UVScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_UVOffset_PropertyAddress, SetMaterial_FunctionAddress, "UVOffset");
		SetMaterial_UVOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "UVOffset");
		SetMaterial_UVOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "UVOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_UVRotation_PropertyAddress, SetMaterial_FunctionAddress, "UVRotation");
		SetMaterial_UVRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "UVRotation");
		SetMaterial_UVRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "UVRotation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_NullOnly_PropertyAddress, SetMaterial_FunctionAddress, "NullOnly");
		SetMaterial_NullOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "NullOnly");
		SetMaterial_NullOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "NullOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_ReturnValue_PropertyAddress, SetMaterial_FunctionAddress, "ReturnValue");
		SetMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "ReturnValue");
		SetMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_Groups_IsValid && SetMaterial_Material_IsValid && SetMaterial_UVScale_IsValid && SetMaterial_UVOffset_IsValid && SetMaterial_UVRotation_IsValid && SetMaterial_NullOnly_IsValid && SetMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:SetMaterial", SetMaterial_IsValid);
		Scatter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Scatter");
		Scatter_ParamsSize = NativeReflection.GetFunctionParamsSize(Scatter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Scatter_Groups_PropertyAddress, Scatter_FunctionAddress, "Groups");
		Scatter_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Scatter_FunctionAddress, "Groups");
		Scatter_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Scatter_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Scatter_Seed_PropertyAddress, Scatter_FunctionAddress, "Seed");
		Scatter_Seed_Offset = NativeReflectionCached.GetPropertyOffset(Scatter_FunctionAddress, "Seed");
		Scatter_Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(Scatter_FunctionAddress, "Seed", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Scatter_Count_PropertyAddress, Scatter_FunctionAddress, "Count");
		Scatter_Count_Offset = NativeReflectionCached.GetPropertyOffset(Scatter_FunctionAddress, "Count");
		Scatter_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(Scatter_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Scatter_Density_PropertyAddress, Scatter_FunctionAddress, "Density");
		Scatter_Density_Offset = NativeReflectionCached.GetPropertyOffset(Scatter_FunctionAddress, "Density");
		Scatter_Density_IsValid = NativeReflectionCached.ValidatePropertyClass(Scatter_FunctionAddress, "Density", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Scatter_Iterations_PropertyAddress, Scatter_FunctionAddress, "Iterations");
		Scatter_Iterations_Offset = NativeReflectionCached.GetPropertyOffset(Scatter_FunctionAddress, "Iterations");
		Scatter_Iterations_IsValid = NativeReflectionCached.ValidatePropertyClass(Scatter_FunctionAddress, "Iterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Scatter_ReturnValue_PropertyAddress, Scatter_FunctionAddress, "ReturnValue");
		Scatter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Scatter_FunctionAddress, "ReturnValue");
		Scatter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Scatter_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Scatter_IsValid = Scatter_FunctionAddress != IntPtr.Zero && Scatter_Groups_IsValid && Scatter_Seed_IsValid && Scatter_Count_IsValid && Scatter_Density_IsValid && Scatter_Iterations_IsValid && Scatter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Scatter", Scatter_IsValid);
		Road_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Road");
		Road_ParamsSize = NativeReflection.GetFunctionParamsSize(Road_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Road_DefaultWidth_PropertyAddress, Road_FunctionAddress, "DefaultWidth");
		Road_DefaultWidth_Offset = NativeReflectionCached.GetPropertyOffset(Road_FunctionAddress, "DefaultWidth");
		Road_DefaultWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(Road_FunctionAddress, "DefaultWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Road_ReturnValue_PropertyAddress, Road_FunctionAddress, "ReturnValue");
		Road_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Road_FunctionAddress, "ReturnValue");
		Road_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Road_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Road_IsValid = Road_FunctionAddress != IntPtr.Zero && Road_DefaultWidth_IsValid && Road_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Road", Road_IsValid);
		Reverse_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Reverse");
		Reverse_ParamsSize = NativeReflection.GetFunctionParamsSize(Reverse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Reverse_Groups_PropertyAddress, Reverse_FunctionAddress, "Groups");
		Reverse_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Reverse_FunctionAddress, "Groups");
		Reverse_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Reverse_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Reverse_ReturnValue_PropertyAddress, Reverse_FunctionAddress, "ReturnValue");
		Reverse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Reverse_FunctionAddress, "ReturnValue");
		Reverse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Reverse_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Reverse_IsValid = Reverse_FunctionAddress != IntPtr.Zero && Reverse_Groups_IsValid && Reverse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Reverse", Reverse_IsValid);
		Resample_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Resample");
		Resample_ParamsSize = NativeReflection.GetFunctionParamsSize(Resample_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Resample_ByEdge_PropertyAddress, Resample_FunctionAddress, "ByEdge");
		Resample_ByEdge_Offset = NativeReflectionCached.GetPropertyOffset(Resample_FunctionAddress, "ByEdge");
		Resample_ByEdge_IsValid = NativeReflectionCached.ValidatePropertyClass(Resample_FunctionAddress, "ByEdge", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Resample_SegmentLength_PropertyAddress, Resample_FunctionAddress, "SegmentLength");
		Resample_SegmentLength_Offset = NativeReflectionCached.GetPropertyOffset(Resample_FunctionAddress, "SegmentLength");
		Resample_SegmentLength_IsValid = NativeReflectionCached.ValidatePropertyClass(Resample_FunctionAddress, "SegmentLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Resample_NumSegments_PropertyAddress, Resample_FunctionAddress, "NumSegments");
		Resample_NumSegments_Offset = NativeReflectionCached.GetPropertyOffset(Resample_FunctionAddress, "NumSegments");
		Resample_NumSegments_IsValid = NativeReflectionCached.ValidatePropertyClass(Resample_FunctionAddress, "NumSegments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Resample_OutputType_PropertyAddress, Resample_FunctionAddress, "OutputType");
		Resample_OutputType_Offset = NativeReflectionCached.GetPropertyOffset(Resample_FunctionAddress, "OutputType");
		Resample_OutputType_IsValid = NativeReflectionCached.ValidatePropertyClass(Resample_FunctionAddress, "OutputType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Resample_ReturnValue_PropertyAddress, Resample_FunctionAddress, "ReturnValue");
		Resample_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Resample_FunctionAddress, "ReturnValue");
		Resample_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Resample_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Resample_IsValid = Resample_FunctionAddress != IntPtr.Zero && Resample_ByEdge_IsValid && Resample_SegmentLength_IsValid && Resample_NumSegments_IsValid && Resample_OutputType_IsValid && Resample_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Resample", Resample_IsValid);
		PrimitiveInGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrimitiveInGroup");
		PrimitiveInGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(PrimitiveInGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrimitiveInGroup_GroupName_PropertyAddress, PrimitiveInGroup_FunctionAddress, "GroupName");
		PrimitiveInGroup_GroupName_Offset = NativeReflectionCached.GetPropertyOffset(PrimitiveInGroup_FunctionAddress, "GroupName");
		PrimitiveInGroup_GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(PrimitiveInGroup_FunctionAddress, "GroupName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PrimitiveInGroup_Index_PropertyAddress, PrimitiveInGroup_FunctionAddress, "Index");
		PrimitiveInGroup_Index_Offset = NativeReflectionCached.GetPropertyOffset(PrimitiveInGroup_FunctionAddress, "Index");
		PrimitiveInGroup_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(PrimitiveInGroup_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PrimitiveInGroup_ReturnValue_PropertyAddress, PrimitiveInGroup_FunctionAddress, "ReturnValue");
		PrimitiveInGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PrimitiveInGroup_FunctionAddress, "ReturnValue");
		PrimitiveInGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PrimitiveInGroup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PrimitiveInGroup_IsValid = PrimitiveInGroup_FunctionAddress != IntPtr.Zero && PrimitiveInGroup_GroupName_IsValid && PrimitiveInGroup_Index_IsValid && PrimitiveInGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:PrimitiveInGroup", PrimitiveInGroup_IsValid);
		PolyExtrude_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PolyExtrude");
		PolyExtrude_ParamsSize = NativeReflection.GetFunctionParamsSize(PolyExtrude_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PolyExtrude_Groups_PropertyAddress, PolyExtrude_FunctionAddress, "Groups");
		PolyExtrude_Groups_Offset = NativeReflectionCached.GetPropertyOffset(PolyExtrude_FunctionAddress, "Groups");
		PolyExtrude_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExtrude_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExtrude_Distance_PropertyAddress, PolyExtrude_FunctionAddress, "Distance");
		PolyExtrude_Distance_Offset = NativeReflectionCached.GetPropertyOffset(PolyExtrude_FunctionAddress, "Distance");
		PolyExtrude_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExtrude_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExtrude_Inset_PropertyAddress, PolyExtrude_FunctionAddress, "Inset");
		PolyExtrude_Inset_Offset = NativeReflectionCached.GetPropertyOffset(PolyExtrude_FunctionAddress, "Inset");
		PolyExtrude_Inset_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExtrude_FunctionAddress, "Inset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExtrude_FrontGroup_PropertyAddress, PolyExtrude_FunctionAddress, "FrontGroup");
		PolyExtrude_FrontGroup_Offset = NativeReflectionCached.GetPropertyOffset(PolyExtrude_FunctionAddress, "FrontGroup");
		PolyExtrude_FrontGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExtrude_FunctionAddress, "FrontGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExtrude_SideGroup_PropertyAddress, PolyExtrude_FunctionAddress, "SideGroup");
		PolyExtrude_SideGroup_Offset = NativeReflectionCached.GetPropertyOffset(PolyExtrude_FunctionAddress, "SideGroup");
		PolyExtrude_SideGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExtrude_FunctionAddress, "SideGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExtrude_DeleteSource_PropertyAddress, PolyExtrude_FunctionAddress, "DeleteSource");
		PolyExtrude_DeleteSource_Offset = NativeReflectionCached.GetPropertyOffset(PolyExtrude_FunctionAddress, "DeleteSource");
		PolyExtrude_DeleteSource_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExtrude_FunctionAddress, "DeleteSource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExtrude_ReturnValue_PropertyAddress, PolyExtrude_FunctionAddress, "ReturnValue");
		PolyExtrude_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PolyExtrude_FunctionAddress, "ReturnValue");
		PolyExtrude_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExtrude_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PolyExtrude_IsValid = PolyExtrude_FunctionAddress != IntPtr.Zero && PolyExtrude_Groups_IsValid && PolyExtrude_Distance_IsValid && PolyExtrude_Inset_IsValid && PolyExtrude_FrontGroup_IsValid && PolyExtrude_SideGroup_IsValid && PolyExtrude_DeleteSource_IsValid && PolyExtrude_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:PolyExtrude", PolyExtrude_IsValid);
		PolyExpand_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PolyExpand");
		PolyExpand_ParamsSize = NativeReflection.GetFunctionParamsSize(PolyExpand_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PolyExpand_Groups_PropertyAddress, PolyExpand_FunctionAddress, "Groups");
		PolyExpand_Groups_Offset = NativeReflectionCached.GetPropertyOffset(PolyExpand_FunctionAddress, "Groups");
		PolyExpand_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExpand_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExpand_Offset_PropertyAddress, PolyExpand_FunctionAddress, "Offset");
		PolyExpand_Offset_Offset = NativeReflectionCached.GetPropertyOffset(PolyExpand_FunctionAddress, "Offset");
		PolyExpand_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExpand_FunctionAddress, "Offset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExpand_CurveGroup_PropertyAddress, PolyExpand_FunctionAddress, "CurveGroup");
		PolyExpand_CurveGroup_Offset = NativeReflectionCached.GetPropertyOffset(PolyExpand_FunctionAddress, "CurveGroup");
		PolyExpand_CurveGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExpand_FunctionAddress, "CurveGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExpand_SurfaceGroup_PropertyAddress, PolyExpand_FunctionAddress, "SurfaceGroup");
		PolyExpand_SurfaceGroup_Offset = NativeReflectionCached.GetPropertyOffset(PolyExpand_FunctionAddress, "SurfaceGroup");
		PolyExpand_SurfaceGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExpand_FunctionAddress, "SurfaceGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExpand_OutputTangents_PropertyAddress, PolyExpand_FunctionAddress, "OutputTangents");
		PolyExpand_OutputTangents_Offset = NativeReflectionCached.GetPropertyOffset(PolyExpand_FunctionAddress, "OutputTangents");
		PolyExpand_OutputTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExpand_FunctionAddress, "OutputTangents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExpand_DeleteSource_PropertyAddress, PolyExpand_FunctionAddress, "DeleteSource");
		PolyExpand_DeleteSource_Offset = NativeReflectionCached.GetPropertyOffset(PolyExpand_FunctionAddress, "DeleteSource");
		PolyExpand_DeleteSource_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExpand_FunctionAddress, "DeleteSource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyExpand_ReturnValue_PropertyAddress, PolyExpand_FunctionAddress, "ReturnValue");
		PolyExpand_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PolyExpand_FunctionAddress, "ReturnValue");
		PolyExpand_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyExpand_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PolyExpand_IsValid = PolyExpand_FunctionAddress != IntPtr.Zero && PolyExpand_Groups_IsValid && PolyExpand_Offset_IsValid && PolyExpand_CurveGroup_IsValid && PolyExpand_SurfaceGroup_IsValid && PolyExpand_OutputTangents_IsValid && PolyExpand_DeleteSource_IsValid && PolyExpand_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:PolyExpand", PolyExpand_IsValid);
		PolyBevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PolyBevel");
		PolyBevel_ParamsSize = NativeReflection.GetFunctionParamsSize(PolyBevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PolyBevel_GroupType_PropertyAddress, PolyBevel_FunctionAddress, "GroupType");
		PolyBevel_GroupType_Offset = NativeReflectionCached.GetPropertyOffset(PolyBevel_FunctionAddress, "GroupType");
		PolyBevel_GroupType_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyBevel_FunctionAddress, "GroupType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyBevel_Groups_PropertyAddress, PolyBevel_FunctionAddress, "Groups");
		PolyBevel_Groups_Offset = NativeReflectionCached.GetPropertyOffset(PolyBevel_FunctionAddress, "Groups");
		PolyBevel_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyBevel_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyBevel_Distance_PropertyAddress, PolyBevel_FunctionAddress, "Distance");
		PolyBevel_Distance_Offset = NativeReflectionCached.GetPropertyOffset(PolyBevel_FunctionAddress, "Distance");
		PolyBevel_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyBevel_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyBevel_Divisions_PropertyAddress, PolyBevel_FunctionAddress, "Divisions");
		PolyBevel_Divisions_Offset = NativeReflectionCached.GetPropertyOffset(PolyBevel_FunctionAddress, "Divisions");
		PolyBevel_Divisions_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyBevel_FunctionAddress, "Divisions", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyBevel_bBevelSingleCurve_PropertyAddress, PolyBevel_FunctionAddress, "bBevelSingleCurve");
		PolyBevel_bBevelSingleCurve_Offset = NativeReflectionCached.GetPropertyOffset(PolyBevel_FunctionAddress, "bBevelSingleCurve");
		PolyBevel_bBevelSingleCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyBevel_FunctionAddress, "bBevelSingleCurve", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PolyBevel_ReturnValue_PropertyAddress, PolyBevel_FunctionAddress, "ReturnValue");
		PolyBevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PolyBevel_FunctionAddress, "ReturnValue");
		PolyBevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PolyBevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PolyBevel_IsValid = PolyBevel_FunctionAddress != IntPtr.Zero && PolyBevel_GroupType_IsValid && PolyBevel_Groups_IsValid && PolyBevel_Distance_IsValid && PolyBevel_Divisions_IsValid && PolyBevel_bBevelSingleCurve_IsValid && PolyBevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:PolyBevel", PolyBevel_IsValid);
		PointInGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointInGroup");
		PointInGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(PointInGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointInGroup_GroupName_PropertyAddress, PointInGroup_FunctionAddress, "GroupName");
		PointInGroup_GroupName_Offset = NativeReflectionCached.GetPropertyOffset(PointInGroup_FunctionAddress, "GroupName");
		PointInGroup_GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(PointInGroup_FunctionAddress, "GroupName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PointInGroup_Index_PropertyAddress, PointInGroup_FunctionAddress, "Index");
		PointInGroup_Index_Offset = NativeReflectionCached.GetPropertyOffset(PointInGroup_FunctionAddress, "Index");
		PointInGroup_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(PointInGroup_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PointInGroup_ReturnValue_PropertyAddress, PointInGroup_FunctionAddress, "ReturnValue");
		PointInGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointInGroup_FunctionAddress, "ReturnValue");
		PointInGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointInGroup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PointInGroup_IsValid = PointInGroup_FunctionAddress != IntPtr.Zero && PointInGroup_GroupName_IsValid && PointInGroup_Index_IsValid && PointInGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:PointInGroup", PointInGroup_IsValid);
		NumPrimitives_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NumPrimitives");
		NumPrimitives_ParamsSize = NativeReflection.GetFunctionParamsSize(NumPrimitives_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NumPrimitives_ReturnValue_PropertyAddress, NumPrimitives_FunctionAddress, "ReturnValue");
		NumPrimitives_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NumPrimitives_FunctionAddress, "ReturnValue");
		NumPrimitives_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NumPrimitives_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		NumPrimitives_IsValid = NumPrimitives_FunctionAddress != IntPtr.Zero && NumPrimitives_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:NumPrimitives", NumPrimitives_IsValid);
		NumPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NumPoints");
		NumPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(NumPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NumPoints_ReturnValue_PropertyAddress, NumPoints_FunctionAddress, "ReturnValue");
		NumPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NumPoints_FunctionAddress, "ReturnValue");
		NumPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NumPoints_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		NumPoints_IsValid = NumPoints_FunctionAddress != IntPtr.Zero && NumPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:NumPoints", NumPoints_IsValid);
		New_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "New");
		New_ParamsSize = NativeReflection.GetFunctionParamsSize(New_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref New_ReturnValue_PropertyAddress, New_FunctionAddress, "ReturnValue");
		New_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(New_FunctionAddress, "ReturnValue");
		New_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(New_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		New_IsValid = New_FunctionAddress != IntPtr.Zero && New_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:New", New_IsValid);
		MergeArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MergeArray");
		MergeArray_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeArray_Objs_PropertyAddress, MergeArray_FunctionAddress, "Objs");
		MergeArray_Objs_Offset = NativeReflectionCached.GetPropertyOffset(MergeArray_FunctionAddress, "Objs");
		MergeArray_Objs_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeArray_FunctionAddress, "Objs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeArray_ReturnValue_PropertyAddress, MergeArray_FunctionAddress, "ReturnValue");
		MergeArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MergeArray_FunctionAddress, "ReturnValue");
		MergeArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeArray_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MergeArray_IsValid = MergeArray_FunctionAddress != IntPtr.Zero && MergeArray_Objs_IsValid && MergeArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:MergeArray", MergeArray_IsValid);
		Merge_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Merge");
		Merge_ParamsSize = NativeReflection.GetFunctionParamsSize(Merge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Merge_Obj0_PropertyAddress, Merge_FunctionAddress, "Obj0");
		Merge_Obj0_Offset = NativeReflectionCached.GetPropertyOffset(Merge_FunctionAddress, "Obj0");
		Merge_Obj0_IsValid = NativeReflectionCached.ValidatePropertyClass(Merge_FunctionAddress, "Obj0", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Merge_Obj1_PropertyAddress, Merge_FunctionAddress, "Obj1");
		Merge_Obj1_Offset = NativeReflectionCached.GetPropertyOffset(Merge_FunctionAddress, "Obj1");
		Merge_Obj1_IsValid = NativeReflectionCached.ValidatePropertyClass(Merge_FunctionAddress, "Obj1", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Merge_Obj2_PropertyAddress, Merge_FunctionAddress, "Obj2");
		Merge_Obj2_Offset = NativeReflectionCached.GetPropertyOffset(Merge_FunctionAddress, "Obj2");
		Merge_Obj2_IsValid = NativeReflectionCached.ValidatePropertyClass(Merge_FunctionAddress, "Obj2", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Merge_Obj3_PropertyAddress, Merge_FunctionAddress, "Obj3");
		Merge_Obj3_Offset = NativeReflectionCached.GetPropertyOffset(Merge_FunctionAddress, "Obj3");
		Merge_Obj3_IsValid = NativeReflectionCached.ValidatePropertyClass(Merge_FunctionAddress, "Obj3", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Merge_Obj4_PropertyAddress, Merge_FunctionAddress, "Obj4");
		Merge_Obj4_Offset = NativeReflectionCached.GetPropertyOffset(Merge_FunctionAddress, "Obj4");
		Merge_Obj4_IsValid = NativeReflectionCached.ValidatePropertyClass(Merge_FunctionAddress, "Obj4", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Merge_ReturnValue_PropertyAddress, Merge_FunctionAddress, "ReturnValue");
		Merge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Merge_FunctionAddress, "ReturnValue");
		Merge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Merge_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Merge_IsValid = Merge_FunctionAddress != IntPtr.Zero && Merge_Obj0_IsValid && Merge_Obj1_IsValid && Merge_Obj2_IsValid && Merge_Obj3_IsValid && Merge_Obj4_IsValid && Merge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Merge", Merge_IsValid);
		Measure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Measure");
		Measure_ParamsSize = NativeReflection.GetFunctionParamsSize(Measure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Measure_Name_PropertyAddress, Measure_FunctionAddress, "Name");
		Measure_Name_Offset = NativeReflectionCached.GetPropertyOffset(Measure_FunctionAddress, "Name");
		Measure_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(Measure_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Measure_ReturnValue_PropertyAddress, Measure_FunctionAddress, "ReturnValue");
		Measure_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Measure_FunctionAddress, "ReturnValue");
		Measure_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Measure_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Measure_IsValid = Measure_FunctionAddress != IntPtr.Zero && Measure_Name_IsValid && Measure_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Measure", Measure_IsValid);
		MakeGrids_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeGrids");
		MakeGrids_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGrids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGrids_Groups_PropertyAddress, MakeGrids_FunctionAddress, "Groups");
		MakeGrids_Groups_Offset = NativeReflectionCached.GetPropertyOffset(MakeGrids_FunctionAddress, "Groups");
		MakeGrids_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGrids_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGrids_GridSize_PropertyAddress, MakeGrids_FunctionAddress, "GridSize");
		MakeGrids_GridSize_Offset = NativeReflectionCached.GetPropertyOffset(MakeGrids_FunctionAddress, "GridSize");
		MakeGrids_GridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGrids_FunctionAddress, "GridSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGrids_MinGrids_PropertyAddress, MakeGrids_FunctionAddress, "MinGrids");
		MakeGrids_MinGrids_Offset = NativeReflectionCached.GetPropertyOffset(MakeGrids_FunctionAddress, "MinGrids");
		MakeGrids_MinGrids_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGrids_FunctionAddress, "MinGrids", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGrids_OBBOnly_PropertyAddress, MakeGrids_FunctionAddress, "OBBOnly");
		MakeGrids_OBBOnly_Offset = NativeReflectionCached.GetPropertyOffset(MakeGrids_FunctionAddress, "OBBOnly");
		MakeGrids_OBBOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGrids_FunctionAddress, "OBBOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGrids_ReturnValue_PropertyAddress, MakeGrids_FunctionAddress, "ReturnValue");
		MakeGrids_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGrids_FunctionAddress, "ReturnValue");
		MakeGrids_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGrids_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MakeGrids_IsValid = MakeGrids_FunctionAddress != IntPtr.Zero && MakeGrids_Groups_IsValid && MakeGrids_GridSize_IsValid && MakeGrids_MinGrids_IsValid && MakeGrids_OBBOnly_IsValid && MakeGrids_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:MakeGrids", MakeGrids_IsValid);
		Line_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Line");
		Line_ParamsSize = NativeReflection.GetFunctionParamsSize(Line_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Line_Origin_PropertyAddress, Line_FunctionAddress, "Origin");
		Line_Origin_Offset = NativeReflectionCached.GetPropertyOffset(Line_FunctionAddress, "Origin");
		Line_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(Line_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Line_Direction_PropertyAddress, Line_FunctionAddress, "Direction");
		Line_Direction_Offset = NativeReflectionCached.GetPropertyOffset(Line_FunctionAddress, "Direction");
		Line_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(Line_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Line_Length_PropertyAddress, Line_FunctionAddress, "Length");
		Line_Length_Offset = NativeReflectionCached.GetPropertyOffset(Line_FunctionAddress, "Length");
		Line_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(Line_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Line_NumPoints_PropertyAddress, Line_FunctionAddress, "NumPoints");
		Line_NumPoints_Offset = NativeReflectionCached.GetPropertyOffset(Line_FunctionAddress, "NumPoints");
		Line_NumPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(Line_FunctionAddress, "NumPoints", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Line_ReturnValue_PropertyAddress, Line_FunctionAddress, "ReturnValue");
		Line_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Line_FunctionAddress, "ReturnValue");
		Line_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Line_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Line_IsValid = Line_FunctionAddress != IntPtr.Zero && Line_Origin_IsValid && Line_Direction_IsValid && Line_Length_IsValid && Line_NumPoints_IsValid && Line_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Line", Line_IsValid);
		LastPrimitive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LastPrimitive");
		LastPrimitive_ParamsSize = NativeReflection.GetFunctionParamsSize(LastPrimitive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LastPrimitive_ReturnValue_PropertyAddress, LastPrimitive_FunctionAddress, "ReturnValue");
		LastPrimitive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LastPrimitive_FunctionAddress, "ReturnValue");
		LastPrimitive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LastPrimitive_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LastPrimitive_IsValid = LastPrimitive_FunctionAddress != IntPtr.Zero && LastPrimitive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:LastPrimitive", LastPrimitive_IsValid);
		LastPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LastPoint");
		LastPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(LastPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LastPoint_ReturnValue_PropertyAddress, LastPoint_FunctionAddress, "ReturnValue");
		LastPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LastPoint_FunctionAddress, "ReturnValue");
		LastPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LastPoint_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LastPoint_IsValid = LastPoint_FunctionAddress != IntPtr.Zero && LastPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:LastPoint", LastPoint_IsValid);
		Hole_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Hole");
		Hole_ParamsSize = NativeReflection.GetFunctionParamsSize(Hole_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Hole_OuterGroups_PropertyAddress, Hole_FunctionAddress, "OuterGroups");
		Hole_OuterGroups_Offset = NativeReflectionCached.GetPropertyOffset(Hole_FunctionAddress, "OuterGroups");
		Hole_OuterGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(Hole_FunctionAddress, "OuterGroups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Hole_InnerGroups_PropertyAddress, Hole_FunctionAddress, "InnerGroups");
		Hole_InnerGroups_Offset = NativeReflectionCached.GetPropertyOffset(Hole_FunctionAddress, "InnerGroups");
		Hole_InnerGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(Hole_FunctionAddress, "InnerGroups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Hole_Tolerance_PropertyAddress, Hole_FunctionAddress, "Tolerance");
		Hole_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(Hole_FunctionAddress, "Tolerance");
		Hole_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(Hole_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Hole_ReturnValue_PropertyAddress, Hole_FunctionAddress, "ReturnValue");
		Hole_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Hole_FunctionAddress, "ReturnValue");
		Hole_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Hole_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Hole_IsValid = Hole_FunctionAddress != IntPtr.Zero && Hole_OuterGroups_IsValid && Hole_InnerGroups_IsValid && Hole_Tolerance_IsValid && Hole_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Hole", Hole_IsValid);
		GroupRange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GroupRange");
		GroupRange_ParamsSize = NativeReflection.GetFunctionParamsSize(GroupRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GroupRange_Groups_PropertyAddress, GroupRange_FunctionAddress, "Groups");
		GroupRange_Groups_Offset = NativeReflectionCached.GetPropertyOffset(GroupRange_FunctionAddress, "Groups");
		GroupRange_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(GroupRange_FunctionAddress, "Groups", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupRange_ReturnValue_PropertyAddress, GroupRange_FunctionAddress, "ReturnValue");
		GroupRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GroupRange_FunctionAddress, "ReturnValue");
		GroupRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GroupRange_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GroupRange_IsValid = GroupRange_FunctionAddress != IntPtr.Zero && GroupRange_Groups_IsValid && GroupRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:GroupRange", GroupRange_IsValid);
		Ground_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Ground");
		Ground_ParamsSize = NativeReflection.GetFunctionParamsSize(Ground_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Ground_ReturnValue_PropertyAddress, Ground_FunctionAddress, "ReturnValue");
		Ground_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Ground_FunctionAddress, "ReturnValue");
		Ground_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Ground_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Ground_IsValid = Ground_FunctionAddress != IntPtr.Zero && Ground_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Ground", Ground_IsValid);
		Grid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Grid");
		Grid_ParamsSize = NativeReflection.GetFunctionParamsSize(Grid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Grid_Origin_PropertyAddress, Grid_FunctionAddress, "Origin");
		Grid_Origin_Offset = NativeReflectionCached.GetPropertyOffset(Grid_FunctionAddress, "Origin");
		Grid_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(Grid_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Grid_Rotation_PropertyAddress, Grid_FunctionAddress, "Rotation");
		Grid_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(Grid_FunctionAddress, "Rotation");
		Grid_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Grid_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Grid_Size_PropertyAddress, Grid_FunctionAddress, "Size");
		Grid_Size_Offset = NativeReflectionCached.GetPropertyOffset(Grid_FunctionAddress, "Size");
		Grid_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(Grid_FunctionAddress, "Size", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Grid_NumPointsX_PropertyAddress, Grid_FunctionAddress, "NumPointsX");
		Grid_NumPointsX_Offset = NativeReflectionCached.GetPropertyOffset(Grid_FunctionAddress, "NumPointsX");
		Grid_NumPointsX_IsValid = NativeReflectionCached.ValidatePropertyClass(Grid_FunctionAddress, "NumPointsX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Grid_NumPointsY_PropertyAddress, Grid_FunctionAddress, "NumPointsY");
		Grid_NumPointsY_Offset = NativeReflectionCached.GetPropertyOffset(Grid_FunctionAddress, "NumPointsY");
		Grid_NumPointsY_IsValid = NativeReflectionCached.ValidatePropertyClass(Grid_FunctionAddress, "NumPointsY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Grid_ReturnValue_PropertyAddress, Grid_FunctionAddress, "ReturnValue");
		Grid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Grid_FunctionAddress, "ReturnValue");
		Grid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Grid_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Grid_IsValid = Grid_FunctionAddress != IntPtr.Zero && Grid_Origin_IsValid && Grid_Rotation_IsValid && Grid_Size_IsValid && Grid_NumPointsX_IsValid && Grid_NumPointsY_IsValid && Grid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Grid", Grid_IsValid);
		GetPrimitiveInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPrimitiveInt");
		GetPrimitiveInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrimitiveInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrimitiveInt_Key_PropertyAddress, GetPrimitiveInt_FunctionAddress, "Key");
		GetPrimitiveInt_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimitiveInt_FunctionAddress, "Key");
		GetPrimitiveInt_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimitiveInt_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPrimitiveInt_Index_PropertyAddress, GetPrimitiveInt_FunctionAddress, "Index");
		GetPrimitiveInt_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimitiveInt_FunctionAddress, "Index");
		GetPrimitiveInt_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimitiveInt_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPrimitiveInt_ReturnValue_PropertyAddress, GetPrimitiveInt_FunctionAddress, "ReturnValue");
		GetPrimitiveInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimitiveInt_FunctionAddress, "ReturnValue");
		GetPrimitiveInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimitiveInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPrimitiveInt_IsValid = GetPrimitiveInt_FunctionAddress != IntPtr.Zero && GetPrimitiveInt_Key_IsValid && GetPrimitiveInt_Index_IsValid && GetPrimitiveInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:GetPrimitiveInt", GetPrimitiveInt_IsValid);
		GetPointTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPointTransform");
		GetPointTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPointTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPointTransform_Index_PropertyAddress, GetPointTransform_FunctionAddress, "Index");
		GetPointTransform_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetPointTransform_FunctionAddress, "Index");
		GetPointTransform_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointTransform_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPointTransform_ReturnValue_PropertyAddress, GetPointTransform_FunctionAddress, "ReturnValue");
		GetPointTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPointTransform_FunctionAddress, "ReturnValue");
		GetPointTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPointTransform_IsValid = GetPointTransform_FunctionAddress != IntPtr.Zero && GetPointTransform_Index_IsValid && GetPointTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:GetPointTransform", GetPointTransform_IsValid);
		GetPointInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPointInt");
		GetPointInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPointInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPointInt_Key_PropertyAddress, GetPointInt_FunctionAddress, "Key");
		GetPointInt_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetPointInt_FunctionAddress, "Key");
		GetPointInt_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointInt_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPointInt_Index_PropertyAddress, GetPointInt_FunctionAddress, "Index");
		GetPointInt_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetPointInt_FunctionAddress, "Index");
		GetPointInt_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointInt_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPointInt_ReturnValue_PropertyAddress, GetPointInt_FunctionAddress, "ReturnValue");
		GetPointInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPointInt_FunctionAddress, "ReturnValue");
		GetPointInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPointInt_IsValid = GetPointInt_FunctionAddress != IntPtr.Zero && GetPointInt_Key_IsValid && GetPointInt_Index_IsValid && GetPointInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:GetPointInt", GetPointInt_IsValid);
		Fuse_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Fuse");
		Fuse_ParamsSize = NativeReflection.GetFunctionParamsSize(Fuse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Fuse_Groups_PropertyAddress, Fuse_FunctionAddress, "Groups");
		Fuse_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Fuse_FunctionAddress, "Groups");
		Fuse_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Fuse_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Fuse_SnapDist_PropertyAddress, Fuse_FunctionAddress, "SnapDist");
		Fuse_SnapDist_Offset = NativeReflectionCached.GetPropertyOffset(Fuse_FunctionAddress, "SnapDist");
		Fuse_SnapDist_IsValid = NativeReflectionCached.ValidatePropertyClass(Fuse_FunctionAddress, "SnapDist", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Fuse_ReturnValue_PropertyAddress, Fuse_FunctionAddress, "ReturnValue");
		Fuse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Fuse_FunctionAddress, "ReturnValue");
		Fuse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Fuse_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Fuse_IsValid = Fuse_FunctionAddress != IntPtr.Zero && Fuse_Groups_IsValid && Fuse_SnapDist_IsValid && Fuse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Fuse", Fuse_IsValid);
		Flatten_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Flatten");
		Flatten_ParamsSize = NativeReflection.GetFunctionParamsSize(Flatten_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Flatten_Transform_PropertyAddress, Flatten_FunctionAddress, "Transform");
		Flatten_Transform_Offset = NativeReflectionCached.GetPropertyOffset(Flatten_FunctionAddress, "Transform");
		Flatten_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(Flatten_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Flatten_ReturnValue_PropertyAddress, Flatten_FunctionAddress, "ReturnValue");
		Flatten_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Flatten_FunctionAddress, "ReturnValue");
		Flatten_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Flatten_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Flatten_IsValid = Flatten_FunctionAddress != IntPtr.Zero && Flatten_Transform_IsValid && Flatten_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Flatten", Flatten_IsValid);
		Facet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Facet");
		Facet_ParamsSize = NativeReflection.GetFunctionParamsSize(Facet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Facet_Tolerance_PropertyAddress, Facet_FunctionAddress, "Tolerance");
		Facet_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(Facet_FunctionAddress, "Tolerance");
		Facet_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(Facet_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Facet_ReturnValue_PropertyAddress, Facet_FunctionAddress, "ReturnValue");
		Facet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Facet_FunctionAddress, "ReturnValue");
		Facet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Facet_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Facet_IsValid = Facet_FunctionAddress != IntPtr.Zero && Facet_Tolerance_IsValid && Facet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Facet", Facet_IsValid);
		Divide_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Divide");
		Divide_ParamsSize = NativeReflection.GetFunctionParamsSize(Divide_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Divide_Tolerance_PropertyAddress, Divide_FunctionAddress, "Tolerance");
		Divide_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(Divide_FunctionAddress, "Tolerance");
		Divide_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(Divide_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Divide_ReturnValue_PropertyAddress, Divide_FunctionAddress, "ReturnValue");
		Divide_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Divide_FunctionAddress, "ReturnValue");
		Divide_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Divide_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Divide_IsValid = Divide_FunctionAddress != IntPtr.Zero && Divide_Tolerance_IsValid && Divide_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Divide", Divide_IsValid);
		CopyToPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyToPoints");
		CopyToPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyToPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyToPoints_Groups_PropertyAddress, CopyToPoints_FunctionAddress, "Groups");
		CopyToPoints_Groups_Offset = NativeReflectionCached.GetPropertyOffset(CopyToPoints_FunctionAddress, "Groups");
		CopyToPoints_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToPoints_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyToPoints_Source_PropertyAddress, CopyToPoints_FunctionAddress, "Source");
		CopyToPoints_Source_Offset = NativeReflectionCached.GetPropertyOffset(CopyToPoints_FunctionAddress, "Source");
		CopyToPoints_Source_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToPoints_FunctionAddress, "Source", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyToPoints_LocalTransform_PropertyAddress, CopyToPoints_FunctionAddress, "LocalTransform");
		CopyToPoints_LocalTransform_Offset = NativeReflectionCached.GetPropertyOffset(CopyToPoints_FunctionAddress, "LocalTransform");
		CopyToPoints_LocalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToPoints_FunctionAddress, "LocalTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyToPoints_ReturnValue_PropertyAddress, CopyToPoints_FunctionAddress, "ReturnValue");
		CopyToPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyToPoints_FunctionAddress, "ReturnValue");
		CopyToPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToPoints_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyToPoints_IsValid = CopyToPoints_FunctionAddress != IntPtr.Zero && CopyToPoints_Groups_IsValid && CopyToPoints_Source_IsValid && CopyToPoints_LocalTransform_IsValid && CopyToPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:CopyToPoints", CopyToPoints_IsValid);
		CopyAndTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAndTransform");
		CopyAndTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAndTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAndTransform_NumCopies_PropertyAddress, CopyAndTransform_FunctionAddress, "NumCopies");
		CopyAndTransform_NumCopies_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndTransform_FunctionAddress, "NumCopies");
		CopyAndTransform_NumCopies_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndTransform_FunctionAddress, "NumCopies", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAndTransform_Transform_PropertyAddress, CopyAndTransform_FunctionAddress, "Transform");
		CopyAndTransform_Transform_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndTransform_FunctionAddress, "Transform");
		CopyAndTransform_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndTransform_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAndTransform_ReturnValue_PropertyAddress, CopyAndTransform_FunctionAddress, "ReturnValue");
		CopyAndTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyAndTransform_FunctionAddress, "ReturnValue");
		CopyAndTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAndTransform_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyAndTransform_IsValid = CopyAndTransform_FunctionAddress != IntPtr.Zero && CopyAndTransform_NumCopies_IsValid && CopyAndTransform_Transform_IsValid && CopyAndTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:CopyAndTransform", CopyAndTransform_IsValid);
		Copy__FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Copy");
		Copy__ParamsSize = NativeReflection.GetFunctionParamsSize(Copy__FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Copy__ReturnValue_PropertyAddress, Copy__FunctionAddress, "ReturnValue");
		Copy__ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Copy__FunctionAddress, "ReturnValue");
		Copy__ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Copy__FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Copy__IsValid = Copy__FunctionAddress != IntPtr.Zero && Copy__ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Copy", Copy__IsValid);
		Clip_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Clip");
		Clip_ParamsSize = NativeReflection.GetFunctionParamsSize(Clip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Clip_Groups_PropertyAddress, Clip_FunctionAddress, "Groups");
		Clip_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Clip_FunctionAddress, "Groups");
		Clip_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Clip_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Clip_PlaneNormal_PropertyAddress, Clip_FunctionAddress, "PlaneNormal");
		Clip_PlaneNormal_Offset = NativeReflectionCached.GetPropertyOffset(Clip_FunctionAddress, "PlaneNormal");
		Clip_PlaneNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(Clip_FunctionAddress, "PlaneNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Clip_PlaneDist_PropertyAddress, Clip_FunctionAddress, "PlaneDist");
		Clip_PlaneDist_Offset = NativeReflectionCached.GetPropertyOffset(Clip_FunctionAddress, "PlaneDist");
		Clip_PlaneDist_IsValid = NativeReflectionCached.ValidatePropertyClass(Clip_FunctionAddress, "PlaneDist", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Clip_PositiveGroup_PropertyAddress, Clip_FunctionAddress, "PositiveGroup");
		Clip_PositiveGroup_Offset = NativeReflectionCached.GetPropertyOffset(Clip_FunctionAddress, "PositiveGroup");
		Clip_PositiveGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(Clip_FunctionAddress, "PositiveGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Clip_NegativeGroup_PropertyAddress, Clip_FunctionAddress, "NegativeGroup");
		Clip_NegativeGroup_Offset = NativeReflectionCached.GetPropertyOffset(Clip_FunctionAddress, "NegativeGroup");
		Clip_NegativeGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(Clip_FunctionAddress, "NegativeGroup", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Clip_ReturnValue_PropertyAddress, Clip_FunctionAddress, "ReturnValue");
		Clip_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Clip_FunctionAddress, "ReturnValue");
		Clip_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Clip_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Clip_IsValid = Clip_FunctionAddress != IntPtr.Zero && Clip_Groups_IsValid && Clip_PlaneNormal_IsValid && Clip_PlaneDist_IsValid && Clip_PositiveGroup_IsValid && Clip_NegativeGroup_IsValid && Clip_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Clip", Clip_IsValid);
		Clean_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Clean");
		Clean_ParamsSize = NativeReflection.GetFunctionParamsSize(Clean_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Clean_ReturnValue_PropertyAddress, Clean_FunctionAddress, "ReturnValue");
		Clean_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Clean_FunctionAddress, "ReturnValue");
		Clean_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Clean_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Clean_IsValid = Clean_FunctionAddress != IntPtr.Zero && Clean_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Clean", Clean_IsValid);
		Circle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Circle");
		Circle_ParamsSize = NativeReflection.GetFunctionParamsSize(Circle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Circle_Origin_PropertyAddress, Circle_FunctionAddress, "Origin");
		Circle_Origin_Offset = NativeReflectionCached.GetPropertyOffset(Circle_FunctionAddress, "Origin");
		Circle_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(Circle_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Circle_Rotation_PropertyAddress, Circle_FunctionAddress, "Rotation");
		Circle_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(Circle_FunctionAddress, "Rotation");
		Circle_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Circle_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Circle_Radius_PropertyAddress, Circle_FunctionAddress, "Radius");
		Circle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(Circle_FunctionAddress, "Radius");
		Circle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(Circle_FunctionAddress, "Radius", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Circle_NumPoints_PropertyAddress, Circle_FunctionAddress, "NumPoints");
		Circle_NumPoints_Offset = NativeReflectionCached.GetPropertyOffset(Circle_FunctionAddress, "NumPoints");
		Circle_NumPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(Circle_FunctionAddress, "NumPoints", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Circle_ReturnValue_PropertyAddress, Circle_FunctionAddress, "ReturnValue");
		Circle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Circle_FunctionAddress, "ReturnValue");
		Circle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Circle_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Circle_IsValid = Circle_FunctionAddress != IntPtr.Zero && Circle_Origin_IsValid && Circle_Rotation_IsValid && Circle_Radius_IsValid && Circle_NumPoints_IsValid && Circle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Circle", Circle_IsValid);
		Carve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Carve");
		Carve_ParamsSize = NativeReflection.GetFunctionParamsSize(Carve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Carve_StartAlign_PropertyAddress, Carve_FunctionAddress, "StartAlign");
		Carve_StartAlign_Offset = NativeReflectionCached.GetPropertyOffset(Carve_FunctionAddress, "StartAlign");
		Carve_StartAlign_IsValid = NativeReflectionCached.ValidatePropertyClass(Carve_FunctionAddress, "StartAlign", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Carve_StartU_PropertyAddress, Carve_FunctionAddress, "StartU");
		Carve_StartU_Offset = NativeReflectionCached.GetPropertyOffset(Carve_FunctionAddress, "StartU");
		Carve_StartU_IsValid = NativeReflectionCached.ValidatePropertyClass(Carve_FunctionAddress, "StartU", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Carve_EndAlign_PropertyAddress, Carve_FunctionAddress, "EndAlign");
		Carve_EndAlign_Offset = NativeReflectionCached.GetPropertyOffset(Carve_FunctionAddress, "EndAlign");
		Carve_EndAlign_IsValid = NativeReflectionCached.ValidatePropertyClass(Carve_FunctionAddress, "EndAlign", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Carve_EndU_PropertyAddress, Carve_FunctionAddress, "EndU");
		Carve_EndU_Offset = NativeReflectionCached.GetPropertyOffset(Carve_FunctionAddress, "EndU");
		Carve_EndU_IsValid = NativeReflectionCached.ValidatePropertyClass(Carve_FunctionAddress, "EndU", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Carve_ReturnValue_PropertyAddress, Carve_FunctionAddress, "ReturnValue");
		Carve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Carve_FunctionAddress, "ReturnValue");
		Carve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Carve_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Carve_IsValid = Carve_FunctionAddress != IntPtr.Zero && Carve_StartAlign_IsValid && Carve_StartU_IsValid && Carve_EndAlign_IsValid && Carve_EndU_IsValid && Carve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Carve", Carve_IsValid);
		Bridge_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Bridge");
		Bridge_ParamsSize = NativeReflection.GetFunctionParamsSize(Bridge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Bridge_StartGroupName_PropertyAddress, Bridge_FunctionAddress, "StartGroupName");
		Bridge_StartGroupName_Offset = NativeReflectionCached.GetPropertyOffset(Bridge_FunctionAddress, "StartGroupName");
		Bridge_StartGroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(Bridge_FunctionAddress, "StartGroupName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Bridge_EndGroupName_PropertyAddress, Bridge_FunctionAddress, "EndGroupName");
		Bridge_EndGroupName_Offset = NativeReflectionCached.GetPropertyOffset(Bridge_FunctionAddress, "EndGroupName");
		Bridge_EndGroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(Bridge_FunctionAddress, "EndGroupName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Bridge_ReturnValue_PropertyAddress, Bridge_FunctionAddress, "ReturnValue");
		Bridge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Bridge_FunctionAddress, "ReturnValue");
		Bridge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Bridge_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Bridge_IsValid = Bridge_FunctionAddress != IntPtr.Zero && Bridge_StartGroupName_IsValid && Bridge_EndGroupName_IsValid && Bridge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Bridge", Bridge_IsValid);
		BreakPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakPoints");
		BreakPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakPoints_Groups_PropertyAddress, BreakPoints_FunctionAddress, "Groups");
		BreakPoints_Groups_Offset = NativeReflectionCached.GetPropertyOffset(BreakPoints_FunctionAddress, "Groups");
		BreakPoints_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPoints_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakPoints_ReturnValue_PropertyAddress, BreakPoints_FunctionAddress, "ReturnValue");
		BreakPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BreakPoints_FunctionAddress, "ReturnValue");
		BreakPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPoints_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BreakPoints_IsValid = BreakPoints_FunctionAddress != IntPtr.Zero && BreakPoints_Groups_IsValid && BreakPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:BreakPoints", BreakPoints_IsValid);
		Box_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Box");
		Box_ParamsSize = NativeReflection.GetFunctionParamsSize(Box_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Box_Origin_PropertyAddress, Box_FunctionAddress, "Origin");
		Box_Origin_Offset = NativeReflectionCached.GetPropertyOffset(Box_FunctionAddress, "Origin");
		Box_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(Box_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Box_Rotation_PropertyAddress, Box_FunctionAddress, "Rotation");
		Box_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(Box_FunctionAddress, "Rotation");
		Box_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Box_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Box_Size_PropertyAddress, Box_FunctionAddress, "Size");
		Box_Size_Offset = NativeReflectionCached.GetPropertyOffset(Box_FunctionAddress, "Size");
		Box_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(Box_FunctionAddress, "Size", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Box_NumPointsX_PropertyAddress, Box_FunctionAddress, "NumPointsX");
		Box_NumPointsX_Offset = NativeReflectionCached.GetPropertyOffset(Box_FunctionAddress, "NumPointsX");
		Box_NumPointsX_IsValid = NativeReflectionCached.ValidatePropertyClass(Box_FunctionAddress, "NumPointsX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Box_NumPointsY_PropertyAddress, Box_FunctionAddress, "NumPointsY");
		Box_NumPointsY_Offset = NativeReflectionCached.GetPropertyOffset(Box_FunctionAddress, "NumPointsY");
		Box_NumPointsY_IsValid = NativeReflectionCached.ValidatePropertyClass(Box_FunctionAddress, "NumPointsY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Box_NumPointsZ_PropertyAddress, Box_FunctionAddress, "NumPointsZ");
		Box_NumPointsZ_Offset = NativeReflectionCached.GetPropertyOffset(Box_FunctionAddress, "NumPointsZ");
		Box_NumPointsZ_IsValid = NativeReflectionCached.ValidatePropertyClass(Box_FunctionAddress, "NumPointsZ", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Box_ReturnValue_PropertyAddress, Box_FunctionAddress, "ReturnValue");
		Box_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Box_FunctionAddress, "ReturnValue");
		Box_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Box_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Box_IsValid = Box_FunctionAddress != IntPtr.Zero && Box_Origin_IsValid && Box_Rotation_IsValid && Box_Size_IsValid && Box_NumPointsX_IsValid && Box_NumPointsY_IsValid && Box_NumPointsZ_IsValid && Box_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Box", Box_IsValid);
		Blast_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Blast");
		Blast_ParamsSize = NativeReflection.GetFunctionParamsSize(Blast_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Blast_Groups_PropertyAddress, Blast_FunctionAddress, "Groups");
		Blast_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Blast_FunctionAddress, "Groups");
		Blast_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Blast_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Blast_Tags_PropertyAddress, Blast_FunctionAddress, "Tags");
		Blast_Tags_Offset = NativeReflectionCached.GetPropertyOffset(Blast_FunctionAddress, "Tags");
		Blast_Tags_IsValid = NativeReflectionCached.ValidatePropertyClass(Blast_FunctionAddress, "Tags", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Blast_DeleteNonSelected_PropertyAddress, Blast_FunctionAddress, "DeleteNonSelected");
		Blast_DeleteNonSelected_Offset = NativeReflectionCached.GetPropertyOffset(Blast_FunctionAddress, "DeleteNonSelected");
		Blast_DeleteNonSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(Blast_FunctionAddress, "DeleteNonSelected", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Blast_ReturnValue_PropertyAddress, Blast_FunctionAddress, "ReturnValue");
		Blast_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Blast_FunctionAddress, "ReturnValue");
		Blast_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Blast_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Blast_IsValid = Blast_FunctionAddress != IntPtr.Zero && Blast_Groups_IsValid && Blast_Tags_IsValid && Blast_DeleteNonSelected_IsValid && Blast_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Blast", Blast_IsValid);
		Arc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Arc");
		Arc_ParamsSize = NativeReflection.GetFunctionParamsSize(Arc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Arc_Groups_PropertyAddress, Arc_FunctionAddress, "Groups");
		Arc_Groups_Offset = NativeReflectionCached.GetPropertyOffset(Arc_FunctionAddress, "Groups");
		Arc_Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(Arc_FunctionAddress, "Groups", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Arc_NumSegments_PropertyAddress, Arc_FunctionAddress, "NumSegments");
		Arc_NumSegments_Offset = NativeReflectionCached.GetPropertyOffset(Arc_FunctionAddress, "NumSegments");
		Arc_NumSegments_IsValid = NativeReflectionCached.ValidatePropertyClass(Arc_FunctionAddress, "NumSegments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Arc_Angle_PropertyAddress, Arc_FunctionAddress, "Angle");
		Arc_Angle_Offset = NativeReflectionCached.GetPropertyOffset(Arc_FunctionAddress, "Angle");
		Arc_Angle_IsValid = NativeReflectionCached.ValidatePropertyClass(Arc_FunctionAddress, "Angle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Arc_ReturnValue_PropertyAddress, Arc_FunctionAddress, "ReturnValue");
		Arc_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Arc_FunctionAddress, "ReturnValue");
		Arc_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Arc_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Arc_IsValid = Arc_FunctionAddress != IntPtr.Zero && Arc_Groups_IsValid && Arc_NumSegments_IsValid && Arc_Angle_IsValid && Arc_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Arc", Arc_IsValid);
		Add_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Add");
		Add_ParamsSize = NativeReflection.GetFunctionParamsSize(Add_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Add_Source_PropertyAddress, Add_FunctionAddress, "Source");
		Add_Source_Offset = NativeReflectionCached.GetPropertyOffset(Add_FunctionAddress, "Source");
		Add_Source_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FunctionAddress, "Source", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Add_Transform_PropertyAddress, Add_FunctionAddress, "Transform");
		Add_Transform_Offset = NativeReflectionCached.GetPropertyOffset(Add_FunctionAddress, "Transform");
		Add_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Add_ReturnValue_PropertyAddress, Add_FunctionAddress, "ReturnValue");
		Add_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Add_FunctionAddress, "ReturnValue");
		Add_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Add_IsValid = Add_FunctionAddress != IntPtr.Zero && Add_Source_IsValid && Add_Transform_IsValid && Add_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Arteries.ArteriesObject:Add", Add_IsValid);
	}
}
