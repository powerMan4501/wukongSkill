using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.U3DebugUtil", "b1", UnrealModuleType.Game)]
public class U3DebugUtil : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool U3FlushPersistentDebugLines_IsValid;

	private static IntPtr U3FlushPersistentDebugLines_FunctionAddress;

	private static int U3FlushPersistentDebugLines_ParamsSize;

	private static bool U3FlushPersistentDebugLines_InWorld_IsValid;

	private static FFieldAddress U3FlushPersistentDebugLines_InWorld_PropertyAddress;

	private static int U3FlushPersistentDebugLines_InWorld_Offset;

	private static bool U3FlushDebugStrings_IsValid;

	private static IntPtr U3FlushDebugStrings_FunctionAddress;

	private static int U3FlushDebugStrings_ParamsSize;

	private static bool U3FlushDebugStrings_InWorld_IsValid;

	private static FFieldAddress U3FlushDebugStrings_InWorld_PropertyAddress;

	private static int U3FlushDebugStrings_InWorld_Offset;

	private static bool U3DrawDebugString_IsValid;

	private static IntPtr U3DrawDebugString_FunctionAddress;

	private static int U3DrawDebugString_ParamsSize;

	private static bool U3DrawDebugString_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugString_InWorld_PropertyAddress;

	private static int U3DrawDebugString_InWorld_Offset;

	private static bool U3DrawDebugString_TextLocation_IsValid;

	private static FFieldAddress U3DrawDebugString_TextLocation_PropertyAddress;

	private static int U3DrawDebugString_TextLocation_Offset;

	private static bool U3DrawDebugString_Text_IsValid;

	private static FFieldAddress U3DrawDebugString_Text_PropertyAddress;

	private static int U3DrawDebugString_Text_Offset;

	private static bool U3DrawDebugString_TestBaseActor_IsValid;

	private static FFieldAddress U3DrawDebugString_TestBaseActor_PropertyAddress;

	private static int U3DrawDebugString_TestBaseActor_Offset;

	private static bool U3DrawDebugString_TextColor_IsValid;

	private static FFieldAddress U3DrawDebugString_TextColor_PropertyAddress;

	private static int U3DrawDebugString_TextColor_Offset;

	private static bool U3DrawDebugString_Duration_IsValid;

	private static FFieldAddress U3DrawDebugString_Duration_PropertyAddress;

	private static int U3DrawDebugString_Duration_Offset;

	private static bool U3DrawDebugString_bDrawShadow_IsValid;

	private static FFieldAddress U3DrawDebugString_bDrawShadow_PropertyAddress;

	private static int U3DrawDebugString_bDrawShadow_Offset;

	private static bool U3DrawDebugString_FontScale_IsValid;

	private static FFieldAddress U3DrawDebugString_FontScale_PropertyAddress;

	private static int U3DrawDebugString_FontScale_Offset;

	private static bool U3DrawDebugSphere_IsValid;

	private static IntPtr U3DrawDebugSphere_FunctionAddress;

	private static int U3DrawDebugSphere_ParamsSize;

	private static bool U3DrawDebugSphere_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugSphere_InWorld_PropertyAddress;

	private static int U3DrawDebugSphere_InWorld_Offset;

	private static bool U3DrawDebugSphere_Center_IsValid;

	private static FFieldAddress U3DrawDebugSphere_Center_PropertyAddress;

	private static int U3DrawDebugSphere_Center_Offset;

	private static bool U3DrawDebugSphere_Radius_IsValid;

	private static FFieldAddress U3DrawDebugSphere_Radius_PropertyAddress;

	private static int U3DrawDebugSphere_Radius_Offset;

	private static bool U3DrawDebugSphere_Segments_IsValid;

	private static FFieldAddress U3DrawDebugSphere_Segments_PropertyAddress;

	private static int U3DrawDebugSphere_Segments_Offset;

	private static bool U3DrawDebugSphere_Color_IsValid;

	private static FFieldAddress U3DrawDebugSphere_Color_PropertyAddress;

	private static int U3DrawDebugSphere_Color_Offset;

	private static bool U3DrawDebugSphere_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugSphere_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugSphere_bPersistentLines_Offset;

	private static bool U3DrawDebugSphere_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugSphere_LifeTime_PropertyAddress;

	private static int U3DrawDebugSphere_LifeTime_Offset;

	private static bool U3DrawDebugSphere_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugSphere_DepthPriority_PropertyAddress;

	private static int U3DrawDebugSphere_DepthPriority_Offset;

	private static bool U3DrawDebugSphere_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugSphere_Thickness_PropertyAddress;

	private static int U3DrawDebugSphere_Thickness_Offset;

	private static bool U3DrawDebugSolidPlane2_IsValid;

	private static IntPtr U3DrawDebugSolidPlane2_FunctionAddress;

	private static int U3DrawDebugSolidPlane2_ParamsSize;

	private static bool U3DrawDebugSolidPlane2_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_InWorld_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_InWorld_Offset;

	private static bool U3DrawDebugSolidPlane2_P_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_P_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_P_Offset;

	private static bool U3DrawDebugSolidPlane2_Loc_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_Loc_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_Loc_Offset;

	private static bool U3DrawDebugSolidPlane2_Extents_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_Extents_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_Extents_Offset;

	private static bool U3DrawDebugSolidPlane2_Color_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_Color_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_Color_Offset;

	private static bool U3DrawDebugSolidPlane2_bPersistent_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_bPersistent_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_bPersistent_Offset;

	private static bool U3DrawDebugSolidPlane2_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_LifeTime_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_LifeTime_Offset;

	private static bool U3DrawDebugSolidPlane2_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane2_DepthPriority_PropertyAddress;

	private static int U3DrawDebugSolidPlane2_DepthPriority_Offset;

	private static bool U3DrawDebugSolidPlane_IsValid;

	private static IntPtr U3DrawDebugSolidPlane_FunctionAddress;

	private static int U3DrawDebugSolidPlane_ParamsSize;

	private static bool U3DrawDebugSolidPlane_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_InWorld_PropertyAddress;

	private static int U3DrawDebugSolidPlane_InWorld_Offset;

	private static bool U3DrawDebugSolidPlane_P_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_P_PropertyAddress;

	private static int U3DrawDebugSolidPlane_P_Offset;

	private static bool U3DrawDebugSolidPlane_Loc_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_Loc_PropertyAddress;

	private static int U3DrawDebugSolidPlane_Loc_Offset;

	private static bool U3DrawDebugSolidPlane_Size_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_Size_PropertyAddress;

	private static int U3DrawDebugSolidPlane_Size_Offset;

	private static bool U3DrawDebugSolidPlane_Color_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_Color_PropertyAddress;

	private static int U3DrawDebugSolidPlane_Color_Offset;

	private static bool U3DrawDebugSolidPlane_bPersistent_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_bPersistent_PropertyAddress;

	private static int U3DrawDebugSolidPlane_bPersistent_Offset;

	private static bool U3DrawDebugSolidPlane_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_LifeTime_PropertyAddress;

	private static int U3DrawDebugSolidPlane_LifeTime_Offset;

	private static bool U3DrawDebugSolidPlane_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugSolidPlane_DepthPriority_PropertyAddress;

	private static int U3DrawDebugSolidPlane_DepthPriority_Offset;

	private static bool U3DrawDebugSolidBox3_IsValid;

	private static IntPtr U3DrawDebugSolidBox3_FunctionAddress;

	private static int U3DrawDebugSolidBox3_ParamsSize;

	private static bool U3DrawDebugSolidBox3_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_InWorld_PropertyAddress;

	private static int U3DrawDebugSolidBox3_InWorld_Offset;

	private static bool U3DrawDebugSolidBox3_Center_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_Center_PropertyAddress;

	private static int U3DrawDebugSolidBox3_Center_Offset;

	private static bool U3DrawDebugSolidBox3_Extent_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_Extent_PropertyAddress;

	private static int U3DrawDebugSolidBox3_Extent_Offset;

	private static bool U3DrawDebugSolidBox3_Rotation_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_Rotation_PropertyAddress;

	private static int U3DrawDebugSolidBox3_Rotation_Offset;

	private static bool U3DrawDebugSolidBox3_Color_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_Color_PropertyAddress;

	private static int U3DrawDebugSolidBox3_Color_Offset;

	private static bool U3DrawDebugSolidBox3_bPersistent_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_bPersistent_PropertyAddress;

	private static int U3DrawDebugSolidBox3_bPersistent_Offset;

	private static bool U3DrawDebugSolidBox3_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_LifeTime_PropertyAddress;

	private static int U3DrawDebugSolidBox3_LifeTime_Offset;

	private static bool U3DrawDebugSolidBox3_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox3_DepthPriority_PropertyAddress;

	private static int U3DrawDebugSolidBox3_DepthPriority_Offset;

	private static bool U3DrawDebugSolidBox2_IsValid;

	private static IntPtr U3DrawDebugSolidBox2_FunctionAddress;

	private static int U3DrawDebugSolidBox2_ParamsSize;

	private static bool U3DrawDebugSolidBox2_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox2_InWorld_PropertyAddress;

	private static int U3DrawDebugSolidBox2_InWorld_Offset;

	private static bool U3DrawDebugSolidBox2_Center_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox2_Center_PropertyAddress;

	private static int U3DrawDebugSolidBox2_Center_Offset;

	private static bool U3DrawDebugSolidBox2_Extent_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox2_Extent_PropertyAddress;

	private static int U3DrawDebugSolidBox2_Extent_Offset;

	private static bool U3DrawDebugSolidBox2_Color_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox2_Color_PropertyAddress;

	private static int U3DrawDebugSolidBox2_Color_Offset;

	private static bool U3DrawDebugSolidBox2_bPersistent_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox2_bPersistent_PropertyAddress;

	private static int U3DrawDebugSolidBox2_bPersistent_Offset;

	private static bool U3DrawDebugSolidBox2_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox2_LifeTime_PropertyAddress;

	private static int U3DrawDebugSolidBox2_LifeTime_Offset;

	private static bool U3DrawDebugSolidBox2_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox2_DepthPriority_PropertyAddress;

	private static int U3DrawDebugSolidBox2_DepthPriority_Offset;

	private static bool U3DrawDebugSolidBox_IsValid;

	private static IntPtr U3DrawDebugSolidBox_FunctionAddress;

	private static int U3DrawDebugSolidBox_ParamsSize;

	private static bool U3DrawDebugSolidBox_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox_InWorld_PropertyAddress;

	private static int U3DrawDebugSolidBox_InWorld_Offset;

	private static bool U3DrawDebugSolidBox_Box_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox_Box_PropertyAddress;

	private static int U3DrawDebugSolidBox_Box_Offset;

	private static bool U3DrawDebugSolidBox_Color_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox_Color_PropertyAddress;

	private static int U3DrawDebugSolidBox_Color_Offset;

	private static bool U3DrawDebugSolidBox_Transform_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox_Transform_PropertyAddress;

	private static int U3DrawDebugSolidBox_Transform_Offset;

	private static bool U3DrawDebugSolidBox_bPersistent_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox_bPersistent_PropertyAddress;

	private static int U3DrawDebugSolidBox_bPersistent_Offset;

	private static bool U3DrawDebugSolidBox_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox_LifeTime_PropertyAddress;

	private static int U3DrawDebugSolidBox_LifeTime_Offset;

	private static bool U3DrawDebugSolidBox_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugSolidBox_DepthPriority_PropertyAddress;

	private static int U3DrawDebugSolidBox_DepthPriority_Offset;

	private static bool U3DrawDebugPoint_IsValid;

	private static IntPtr U3DrawDebugPoint_FunctionAddress;

	private static int U3DrawDebugPoint_ParamsSize;

	private static bool U3DrawDebugPoint_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugPoint_InWorld_PropertyAddress;

	private static int U3DrawDebugPoint_InWorld_Offset;

	private static bool U3DrawDebugPoint_Position_IsValid;

	private static FFieldAddress U3DrawDebugPoint_Position_PropertyAddress;

	private static int U3DrawDebugPoint_Position_Offset;

	private static bool U3DrawDebugPoint_Size_IsValid;

	private static FFieldAddress U3DrawDebugPoint_Size_PropertyAddress;

	private static int U3DrawDebugPoint_Size_Offset;

	private static bool U3DrawDebugPoint_PointColor_IsValid;

	private static FFieldAddress U3DrawDebugPoint_PointColor_PropertyAddress;

	private static int U3DrawDebugPoint_PointColor_Offset;

	private static bool U3DrawDebugPoint_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugPoint_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugPoint_bPersistentLines_Offset;

	private static bool U3DrawDebugPoint_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugPoint_LifeTime_PropertyAddress;

	private static int U3DrawDebugPoint_LifeTime_Offset;

	private static bool U3DrawDebugPoint_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugPoint_DepthPriority_PropertyAddress;

	private static int U3DrawDebugPoint_DepthPriority_Offset;

	private static bool U3DrawDebugMesh_IsValid;

	private static IntPtr U3DrawDebugMesh_FunctionAddress;

	private static int U3DrawDebugMesh_ParamsSize;

	private static bool U3DrawDebugMesh_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugMesh_InWorld_PropertyAddress;

	private static int U3DrawDebugMesh_InWorld_Offset;

	private static bool U3DrawDebugMesh_Verts_IsValid;

	private static FFieldAddress U3DrawDebugMesh_Verts_PropertyAddress;

	private static int U3DrawDebugMesh_Verts_Offset;

	private static bool U3DrawDebugMesh_Indices_IsValid;

	private static FFieldAddress U3DrawDebugMesh_Indices_PropertyAddress;

	private static int U3DrawDebugMesh_Indices_Offset;

	private static bool U3DrawDebugMesh_Color_IsValid;

	private static FFieldAddress U3DrawDebugMesh_Color_PropertyAddress;

	private static int U3DrawDebugMesh_Color_Offset;

	private static bool U3DrawDebugMesh_bPersistent_IsValid;

	private static FFieldAddress U3DrawDebugMesh_bPersistent_PropertyAddress;

	private static int U3DrawDebugMesh_bPersistent_Offset;

	private static bool U3DrawDebugMesh_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugMesh_LifeTime_PropertyAddress;

	private static int U3DrawDebugMesh_LifeTime_Offset;

	private static bool U3DrawDebugMesh_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugMesh_DepthPriority_PropertyAddress;

	private static int U3DrawDebugMesh_DepthPriority_Offset;

	private static bool U3DrawDebugLine_IsValid;

	private static IntPtr U3DrawDebugLine_FunctionAddress;

	private static int U3DrawDebugLine_ParamsSize;

	private static bool U3DrawDebugLine_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugLine_InWorld_PropertyAddress;

	private static int U3DrawDebugLine_InWorld_Offset;

	private static bool U3DrawDebugLine_LineStart_IsValid;

	private static FFieldAddress U3DrawDebugLine_LineStart_PropertyAddress;

	private static int U3DrawDebugLine_LineStart_Offset;

	private static bool U3DrawDebugLine_LineEnd_IsValid;

	private static FFieldAddress U3DrawDebugLine_LineEnd_PropertyAddress;

	private static int U3DrawDebugLine_LineEnd_Offset;

	private static bool U3DrawDebugLine_Color_IsValid;

	private static FFieldAddress U3DrawDebugLine_Color_PropertyAddress;

	private static int U3DrawDebugLine_Color_Offset;

	private static bool U3DrawDebugLine_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugLine_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugLine_bPersistentLines_Offset;

	private static bool U3DrawDebugLine_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugLine_LifeTime_PropertyAddress;

	private static int U3DrawDebugLine_LifeTime_Offset;

	private static bool U3DrawDebugLine_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugLine_DepthPriority_PropertyAddress;

	private static int U3DrawDebugLine_DepthPriority_Offset;

	private static bool U3DrawDebugLine_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugLine_Thickness_PropertyAddress;

	private static int U3DrawDebugLine_Thickness_Offset;

	private static bool U3DrawDebugFrustum_IsValid;

	private static IntPtr U3DrawDebugFrustum_FunctionAddress;

	private static int U3DrawDebugFrustum_ParamsSize;

	private static bool U3DrawDebugFrustum_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugFrustum_InWorld_PropertyAddress;

	private static int U3DrawDebugFrustum_InWorld_Offset;

	private static bool U3DrawDebugFrustum_FrustumToWorld_IsValid;

	private static FFieldAddress U3DrawDebugFrustum_FrustumToWorld_PropertyAddress;

	private static int U3DrawDebugFrustum_FrustumToWorld_Offset;

	private static bool U3DrawDebugFrustum_Color_IsValid;

	private static FFieldAddress U3DrawDebugFrustum_Color_PropertyAddress;

	private static int U3DrawDebugFrustum_Color_Offset;

	private static bool U3DrawDebugFrustum_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugFrustum_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugFrustum_bPersistentLines_Offset;

	private static bool U3DrawDebugFrustum_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugFrustum_LifeTime_PropertyAddress;

	private static int U3DrawDebugFrustum_LifeTime_Offset;

	private static bool U3DrawDebugFrustum_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugFrustum_DepthPriority_PropertyAddress;

	private static int U3DrawDebugFrustum_DepthPriority_Offset;

	private static bool U3DrawDebugFrustum_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugFrustum_Thickness_PropertyAddress;

	private static int U3DrawDebugFrustum_Thickness_Offset;

	private static bool U3DrawDebugDirectionalArrow_IsValid;

	private static IntPtr U3DrawDebugDirectionalArrow_FunctionAddress;

	private static int U3DrawDebugDirectionalArrow_ParamsSize;

	private static bool U3DrawDebugDirectionalArrow_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_InWorld_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_InWorld_Offset;

	private static bool U3DrawDebugDirectionalArrow_LineStart_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_LineStart_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_LineStart_Offset;

	private static bool U3DrawDebugDirectionalArrow_LineEnd_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_LineEnd_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_LineEnd_Offset;

	private static bool U3DrawDebugDirectionalArrow_ArrowSize_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_ArrowSize_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_ArrowSize_Offset;

	private static bool U3DrawDebugDirectionalArrow_Color_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_Color_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_Color_Offset;

	private static bool U3DrawDebugDirectionalArrow_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_bPersistentLines_Offset;

	private static bool U3DrawDebugDirectionalArrow_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_LifeTime_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_LifeTime_Offset;

	private static bool U3DrawDebugDirectionalArrow_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_DepthPriority_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_DepthPriority_Offset;

	private static bool U3DrawDebugDirectionalArrow_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugDirectionalArrow_Thickness_PropertyAddress;

	private static int U3DrawDebugDirectionalArrow_Thickness_Offset;

	private static bool U3DrawDebugCylinder_IsValid;

	private static IntPtr U3DrawDebugCylinder_FunctionAddress;

	private static int U3DrawDebugCylinder_ParamsSize;

	private static bool U3DrawDebugCylinder_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_InWorld_PropertyAddress;

	private static int U3DrawDebugCylinder_InWorld_Offset;

	private static bool U3DrawDebugCylinder_Start_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_Start_PropertyAddress;

	private static int U3DrawDebugCylinder_Start_Offset;

	private static bool U3DrawDebugCylinder_End_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_End_PropertyAddress;

	private static int U3DrawDebugCylinder_End_Offset;

	private static bool U3DrawDebugCylinder_Radius_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_Radius_PropertyAddress;

	private static int U3DrawDebugCylinder_Radius_Offset;

	private static bool U3DrawDebugCylinder_Segments_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_Segments_PropertyAddress;

	private static int U3DrawDebugCylinder_Segments_Offset;

	private static bool U3DrawDebugCylinder_Color_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_Color_PropertyAddress;

	private static int U3DrawDebugCylinder_Color_Offset;

	private static bool U3DrawDebugCylinder_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCylinder_bPersistentLines_Offset;

	private static bool U3DrawDebugCylinder_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_LifeTime_PropertyAddress;

	private static int U3DrawDebugCylinder_LifeTime_Offset;

	private static bool U3DrawDebugCylinder_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCylinder_DepthPriority_Offset;

	private static bool U3DrawDebugCylinder_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugCylinder_Thickness_PropertyAddress;

	private static int U3DrawDebugCylinder_Thickness_Offset;

	private static bool U3DrawDebugCrosshairs_IsValid;

	private static IntPtr U3DrawDebugCrosshairs_FunctionAddress;

	private static int U3DrawDebugCrosshairs_ParamsSize;

	private static bool U3DrawDebugCrosshairs_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_InWorld_PropertyAddress;

	private static int U3DrawDebugCrosshairs_InWorld_Offset;

	private static bool U3DrawDebugCrosshairs_AxisLoc_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_AxisLoc_PropertyAddress;

	private static int U3DrawDebugCrosshairs_AxisLoc_Offset;

	private static bool U3DrawDebugCrosshairs_AxisRot_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_AxisRot_PropertyAddress;

	private static int U3DrawDebugCrosshairs_AxisRot_Offset;

	private static bool U3DrawDebugCrosshairs_Scale_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_Scale_PropertyAddress;

	private static int U3DrawDebugCrosshairs_Scale_Offset;

	private static bool U3DrawDebugCrosshairs_Color_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_Color_PropertyAddress;

	private static int U3DrawDebugCrosshairs_Color_Offset;

	private static bool U3DrawDebugCrosshairs_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCrosshairs_bPersistentLines_Offset;

	private static bool U3DrawDebugCrosshairs_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_LifeTime_PropertyAddress;

	private static int U3DrawDebugCrosshairs_LifeTime_Offset;

	private static bool U3DrawDebugCrosshairs_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCrosshairs_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCrosshairs_DepthPriority_Offset;

	private static bool U3DrawDebugCoordinateSystem_IsValid;

	private static IntPtr U3DrawDebugCoordinateSystem_FunctionAddress;

	private static int U3DrawDebugCoordinateSystem_ParamsSize;

	private static bool U3DrawDebugCoordinateSystem_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_InWorld_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_InWorld_Offset;

	private static bool U3DrawDebugCoordinateSystem_AxisLoc_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_AxisLoc_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_AxisLoc_Offset;

	private static bool U3DrawDebugCoordinateSystem_AxisRot_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_AxisRot_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_AxisRot_Offset;

	private static bool U3DrawDebugCoordinateSystem_Scale_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_Scale_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_Scale_Offset;

	private static bool U3DrawDebugCoordinateSystem_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_bPersistentLines_Offset;

	private static bool U3DrawDebugCoordinateSystem_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_LifeTime_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_LifeTime_Offset;

	private static bool U3DrawDebugCoordinateSystem_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_DepthPriority_Offset;

	private static bool U3DrawDebugCoordinateSystem_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugCoordinateSystem_Thickness_PropertyAddress;

	private static int U3DrawDebugCoordinateSystem_Thickness_Offset;

	private static bool U3DrawDebugCone_IsValid;

	private static IntPtr U3DrawDebugCone_FunctionAddress;

	private static int U3DrawDebugCone_ParamsSize;

	private static bool U3DrawDebugCone_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCone_InWorld_PropertyAddress;

	private static int U3DrawDebugCone_InWorld_Offset;

	private static bool U3DrawDebugCone_Origin_IsValid;

	private static FFieldAddress U3DrawDebugCone_Origin_PropertyAddress;

	private static int U3DrawDebugCone_Origin_Offset;

	private static bool U3DrawDebugCone_Direction_IsValid;

	private static FFieldAddress U3DrawDebugCone_Direction_PropertyAddress;

	private static int U3DrawDebugCone_Direction_Offset;

	private static bool U3DrawDebugCone_Length_IsValid;

	private static FFieldAddress U3DrawDebugCone_Length_PropertyAddress;

	private static int U3DrawDebugCone_Length_Offset;

	private static bool U3DrawDebugCone_AngleWidth_IsValid;

	private static FFieldAddress U3DrawDebugCone_AngleWidth_PropertyAddress;

	private static int U3DrawDebugCone_AngleWidth_Offset;

	private static bool U3DrawDebugCone_AngleHeight_IsValid;

	private static FFieldAddress U3DrawDebugCone_AngleHeight_PropertyAddress;

	private static int U3DrawDebugCone_AngleHeight_Offset;

	private static bool U3DrawDebugCone_NumSides_IsValid;

	private static FFieldAddress U3DrawDebugCone_NumSides_PropertyAddress;

	private static int U3DrawDebugCone_NumSides_Offset;

	private static bool U3DrawDebugCone_Color_IsValid;

	private static FFieldAddress U3DrawDebugCone_Color_PropertyAddress;

	private static int U3DrawDebugCone_Color_Offset;

	private static bool U3DrawDebugCone_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCone_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCone_bPersistentLines_Offset;

	private static bool U3DrawDebugCone_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCone_LifeTime_PropertyAddress;

	private static int U3DrawDebugCone_LifeTime_Offset;

	private static bool U3DrawDebugCone_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCone_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCone_DepthPriority_Offset;

	private static bool U3DrawDebugCone_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugCone_Thickness_PropertyAddress;

	private static int U3DrawDebugCone_Thickness_Offset;

	private static bool U3DrawDebugCircle2_IsValid;

	private static IntPtr U3DrawDebugCircle2_FunctionAddress;

	private static int U3DrawDebugCircle2_ParamsSize;

	private static bool U3DrawDebugCircle2_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_InWorld_PropertyAddress;

	private static int U3DrawDebugCircle2_InWorld_Offset;

	private static bool U3DrawDebugCircle2_Center_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_Center_PropertyAddress;

	private static int U3DrawDebugCircle2_Center_Offset;

	private static bool U3DrawDebugCircle2_Radius_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_Radius_PropertyAddress;

	private static int U3DrawDebugCircle2_Radius_Offset;

	private static bool U3DrawDebugCircle2_Segments_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_Segments_PropertyAddress;

	private static int U3DrawDebugCircle2_Segments_Offset;

	private static bool U3DrawDebugCircle2_Color_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_Color_PropertyAddress;

	private static int U3DrawDebugCircle2_Color_Offset;

	private static bool U3DrawDebugCircle2_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCircle2_bPersistentLines_Offset;

	private static bool U3DrawDebugCircle2_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_LifeTime_PropertyAddress;

	private static int U3DrawDebugCircle2_LifeTime_Offset;

	private static bool U3DrawDebugCircle2_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCircle2_DepthPriority_Offset;

	private static bool U3DrawDebugCircle2_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_Thickness_PropertyAddress;

	private static int U3DrawDebugCircle2_Thickness_Offset;

	private static bool U3DrawDebugCircle2_YAxis_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_YAxis_PropertyAddress;

	private static int U3DrawDebugCircle2_YAxis_Offset;

	private static bool U3DrawDebugCircle2_ZAxis_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_ZAxis_PropertyAddress;

	private static int U3DrawDebugCircle2_ZAxis_Offset;

	private static bool U3DrawDebugCircle2_bDrawAxis_IsValid;

	private static FFieldAddress U3DrawDebugCircle2_bDrawAxis_PropertyAddress;

	private static int U3DrawDebugCircle2_bDrawAxis_Offset;

	private static bool U3DrawDebugCircle_IsValid;

	private static IntPtr U3DrawDebugCircle_FunctionAddress;

	private static int U3DrawDebugCircle_ParamsSize;

	private static bool U3DrawDebugCircle_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCircle_InWorld_PropertyAddress;

	private static int U3DrawDebugCircle_InWorld_Offset;

	private static bool U3DrawDebugCircle_TransformMatrix_IsValid;

	private static FFieldAddress U3DrawDebugCircle_TransformMatrix_PropertyAddress;

	private static int U3DrawDebugCircle_TransformMatrix_Offset;

	private static bool U3DrawDebugCircle_Radius_IsValid;

	private static FFieldAddress U3DrawDebugCircle_Radius_PropertyAddress;

	private static int U3DrawDebugCircle_Radius_Offset;

	private static bool U3DrawDebugCircle_Segments_IsValid;

	private static FFieldAddress U3DrawDebugCircle_Segments_PropertyAddress;

	private static int U3DrawDebugCircle_Segments_Offset;

	private static bool U3DrawDebugCircle_Color_IsValid;

	private static FFieldAddress U3DrawDebugCircle_Color_PropertyAddress;

	private static int U3DrawDebugCircle_Color_Offset;

	private static bool U3DrawDebugCircle_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCircle_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCircle_bPersistentLines_Offset;

	private static bool U3DrawDebugCircle_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCircle_LifeTime_PropertyAddress;

	private static int U3DrawDebugCircle_LifeTime_Offset;

	private static bool U3DrawDebugCircle_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCircle_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCircle_DepthPriority_Offset;

	private static bool U3DrawDebugCircle_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugCircle_Thickness_PropertyAddress;

	private static int U3DrawDebugCircle_Thickness_Offset;

	private static bool U3DrawDebugCircle_bDrawAxis_IsValid;

	private static FFieldAddress U3DrawDebugCircle_bDrawAxis_PropertyAddress;

	private static int U3DrawDebugCircle_bDrawAxis_Offset;

	private static bool U3DrawDebugCapsule_IsValid;

	private static IntPtr U3DrawDebugCapsule_FunctionAddress;

	private static int U3DrawDebugCapsule_ParamsSize;

	private static bool U3DrawDebugCapsule_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_InWorld_PropertyAddress;

	private static int U3DrawDebugCapsule_InWorld_Offset;

	private static bool U3DrawDebugCapsule_Center_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_Center_PropertyAddress;

	private static int U3DrawDebugCapsule_Center_Offset;

	private static bool U3DrawDebugCapsule_HalfHeight_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_HalfHeight_PropertyAddress;

	private static int U3DrawDebugCapsule_HalfHeight_Offset;

	private static bool U3DrawDebugCapsule_Radius_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_Radius_PropertyAddress;

	private static int U3DrawDebugCapsule_Radius_Offset;

	private static bool U3DrawDebugCapsule_Rotation_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_Rotation_PropertyAddress;

	private static int U3DrawDebugCapsule_Rotation_Offset;

	private static bool U3DrawDebugCapsule_Color_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_Color_PropertyAddress;

	private static int U3DrawDebugCapsule_Color_Offset;

	private static bool U3DrawDebugCapsule_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCapsule_bPersistentLines_Offset;

	private static bool U3DrawDebugCapsule_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_LifeTime_PropertyAddress;

	private static int U3DrawDebugCapsule_LifeTime_Offset;

	private static bool U3DrawDebugCapsule_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCapsule_DepthPriority_Offset;

	private static bool U3DrawDebugCapsule_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugCapsule_Thickness_PropertyAddress;

	private static int U3DrawDebugCapsule_Thickness_Offset;

	private static bool U3DrawDebugCanvasWireSphere_IsValid;

	private static IntPtr U3DrawDebugCanvasWireSphere_FunctionAddress;

	private static int U3DrawDebugCanvasWireSphere_ParamsSize;

	private static bool U3DrawDebugCanvasWireSphere_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireSphere_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvasWireSphere_Canvas_Offset;

	private static bool U3DrawDebugCanvasWireSphere_Base_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireSphere_Base_PropertyAddress;

	private static int U3DrawDebugCanvasWireSphere_Base_Offset;

	private static bool U3DrawDebugCanvasWireSphere_Color_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireSphere_Color_PropertyAddress;

	private static int U3DrawDebugCanvasWireSphere_Color_Offset;

	private static bool U3DrawDebugCanvasWireSphere_Radius_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireSphere_Radius_PropertyAddress;

	private static int U3DrawDebugCanvasWireSphere_Radius_Offset;

	private static bool U3DrawDebugCanvasWireSphere_NumSides_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireSphere_NumSides_PropertyAddress;

	private static int U3DrawDebugCanvasWireSphere_NumSides_Offset;

	private static bool U3DrawDebugCanvasWireCone_IsValid;

	private static IntPtr U3DrawDebugCanvasWireCone_FunctionAddress;

	private static int U3DrawDebugCanvasWireCone_ParamsSize;

	private static bool U3DrawDebugCanvasWireCone_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireCone_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvasWireCone_Canvas_Offset;

	private static bool U3DrawDebugCanvasWireCone_Transform_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireCone_Transform_PropertyAddress;

	private static int U3DrawDebugCanvasWireCone_Transform_Offset;

	private static bool U3DrawDebugCanvasWireCone_ConeRadius_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireCone_ConeRadius_PropertyAddress;

	private static int U3DrawDebugCanvasWireCone_ConeRadius_Offset;

	private static bool U3DrawDebugCanvasWireCone_ConeAngle_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireCone_ConeAngle_PropertyAddress;

	private static int U3DrawDebugCanvasWireCone_ConeAngle_Offset;

	private static bool U3DrawDebugCanvasWireCone_ConeSides_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireCone_ConeSides_PropertyAddress;

	private static int U3DrawDebugCanvasWireCone_ConeSides_Offset;

	private static bool U3DrawDebugCanvasWireCone_Color_IsValid;

	private static FFieldAddress U3DrawDebugCanvasWireCone_Color_PropertyAddress;

	private static int U3DrawDebugCanvasWireCone_Color_Offset;

	private static bool U3DrawDebugCanvasLine_IsValid;

	private static IntPtr U3DrawDebugCanvasLine_FunctionAddress;

	private static int U3DrawDebugCanvasLine_ParamsSize;

	private static bool U3DrawDebugCanvasLine_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvasLine_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvasLine_Canvas_Offset;

	private static bool U3DrawDebugCanvasLine_Start_IsValid;

	private static FFieldAddress U3DrawDebugCanvasLine_Start_PropertyAddress;

	private static int U3DrawDebugCanvasLine_Start_Offset;

	private static bool U3DrawDebugCanvasLine_End_IsValid;

	private static FFieldAddress U3DrawDebugCanvasLine_End_PropertyAddress;

	private static int U3DrawDebugCanvasLine_End_Offset;

	private static bool U3DrawDebugCanvasLine_LineColor_IsValid;

	private static FFieldAddress U3DrawDebugCanvasLine_LineColor_PropertyAddress;

	private static int U3DrawDebugCanvasLine_LineColor_Offset;

	private static bool U3DrawDebugCanvasCircle_IsValid;

	private static IntPtr U3DrawDebugCanvasCircle_FunctionAddress;

	private static int U3DrawDebugCanvasCircle_ParamsSize;

	private static bool U3DrawDebugCanvasCircle_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvasCircle_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvasCircle_Canvas_Offset;

	private static bool U3DrawDebugCanvasCircle_Base_IsValid;

	private static FFieldAddress U3DrawDebugCanvasCircle_Base_PropertyAddress;

	private static int U3DrawDebugCanvasCircle_Base_Offset;

	private static bool U3DrawDebugCanvasCircle_X_IsValid;

	private static FFieldAddress U3DrawDebugCanvasCircle_X_PropertyAddress;

	private static int U3DrawDebugCanvasCircle_X_Offset;

	private static bool U3DrawDebugCanvasCircle_Y_IsValid;

	private static FFieldAddress U3DrawDebugCanvasCircle_Y_PropertyAddress;

	private static int U3DrawDebugCanvasCircle_Y_Offset;

	private static bool U3DrawDebugCanvasCircle_Color_IsValid;

	private static FFieldAddress U3DrawDebugCanvasCircle_Color_PropertyAddress;

	private static int U3DrawDebugCanvasCircle_Color_Offset;

	private static bool U3DrawDebugCanvasCircle_Radius_IsValid;

	private static FFieldAddress U3DrawDebugCanvasCircle_Radius_PropertyAddress;

	private static int U3DrawDebugCanvasCircle_Radius_Offset;

	private static bool U3DrawDebugCanvasCircle_NumSides_IsValid;

	private static FFieldAddress U3DrawDebugCanvasCircle_NumSides_PropertyAddress;

	private static int U3DrawDebugCanvasCircle_NumSides_Offset;

	private static bool U3DrawDebugCanvas2DLine2_IsValid;

	private static IntPtr U3DrawDebugCanvas2DLine2_FunctionAddress;

	private static int U3DrawDebugCanvas2DLine2_ParamsSize;

	private static bool U3DrawDebugCanvas2DLine2_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine2_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine2_Canvas_Offset;

	private static bool U3DrawDebugCanvas2DLine2_StartPosition_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine2_StartPosition_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine2_StartPosition_Offset;

	private static bool U3DrawDebugCanvas2DLine2_EndPosition_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine2_EndPosition_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine2_EndPosition_Offset;

	private static bool U3DrawDebugCanvas2DLine2_LineColor_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine2_LineColor_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine2_LineColor_Offset;

	private static bool U3DrawDebugCanvas2DLine2_LineThickness_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine2_LineThickness_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine2_LineThickness_Offset;

	private static bool U3DrawDebugCanvas2DLine_IsValid;

	private static IntPtr U3DrawDebugCanvas2DLine_FunctionAddress;

	private static int U3DrawDebugCanvas2DLine_ParamsSize;

	private static bool U3DrawDebugCanvas2DLine_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine_Canvas_Offset;

	private static bool U3DrawDebugCanvas2DLine_Start_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine_Start_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine_Start_Offset;

	private static bool U3DrawDebugCanvas2DLine_End_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine_End_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine_End_Offset;

	private static bool U3DrawDebugCanvas2DLine_LineColor_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DLine_LineColor_PropertyAddress;

	private static int U3DrawDebugCanvas2DLine_LineColor_Offset;

	private static bool U3DrawDebugCanvas2DCircle_IsValid;

	private static IntPtr U3DrawDebugCanvas2DCircle_FunctionAddress;

	private static int U3DrawDebugCanvas2DCircle_ParamsSize;

	private static bool U3DrawDebugCanvas2DCircle_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DCircle_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvas2DCircle_Canvas_Offset;

	private static bool U3DrawDebugCanvas2DCircle_Center_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DCircle_Center_PropertyAddress;

	private static int U3DrawDebugCanvas2DCircle_Center_Offset;

	private static bool U3DrawDebugCanvas2DCircle_Radius_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DCircle_Radius_PropertyAddress;

	private static int U3DrawDebugCanvas2DCircle_Radius_Offset;

	private static bool U3DrawDebugCanvas2DCircle_NumSides_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DCircle_NumSides_PropertyAddress;

	private static int U3DrawDebugCanvas2DCircle_NumSides_Offset;

	private static bool U3DrawDebugCanvas2DCircle_LineColor_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DCircle_LineColor_PropertyAddress;

	private static int U3DrawDebugCanvas2DCircle_LineColor_Offset;

	private static bool U3DrawDebugCanvas2DCircle_LineThickness_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DCircle_LineThickness_PropertyAddress;

	private static int U3DrawDebugCanvas2DCircle_LineThickness_Offset;

	private static bool U3DrawDebugCanvas2DBox_IsValid;

	private static IntPtr U3DrawDebugCanvas2DBox_FunctionAddress;

	private static int U3DrawDebugCanvas2DBox_ParamsSize;

	private static bool U3DrawDebugCanvas2DBox_Canvas_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DBox_Canvas_PropertyAddress;

	private static int U3DrawDebugCanvas2DBox_Canvas_Offset;

	private static bool U3DrawDebugCanvas2DBox_Box_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DBox_Box_PropertyAddress;

	private static int U3DrawDebugCanvas2DBox_Box_Offset;

	private static bool U3DrawDebugCanvas2DBox_LineColor_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DBox_LineColor_PropertyAddress;

	private static int U3DrawDebugCanvas2DBox_LineColor_Offset;

	private static bool U3DrawDebugCanvas2DBox_LineThickness_IsValid;

	private static FFieldAddress U3DrawDebugCanvas2DBox_LineThickness_PropertyAddress;

	private static int U3DrawDebugCanvas2DBox_LineThickness_Offset;

	private static bool U3DrawDebugCamera_IsValid;

	private static IntPtr U3DrawDebugCamera_FunctionAddress;

	private static int U3DrawDebugCamera_ParamsSize;

	private static bool U3DrawDebugCamera_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugCamera_InWorld_PropertyAddress;

	private static int U3DrawDebugCamera_InWorld_Offset;

	private static bool U3DrawDebugCamera_Location_IsValid;

	private static FFieldAddress U3DrawDebugCamera_Location_PropertyAddress;

	private static int U3DrawDebugCamera_Location_Offset;

	private static bool U3DrawDebugCamera_Rotation_IsValid;

	private static FFieldAddress U3DrawDebugCamera_Rotation_PropertyAddress;

	private static int U3DrawDebugCamera_Rotation_Offset;

	private static bool U3DrawDebugCamera_FOVDeg_IsValid;

	private static FFieldAddress U3DrawDebugCamera_FOVDeg_PropertyAddress;

	private static int U3DrawDebugCamera_FOVDeg_Offset;

	private static bool U3DrawDebugCamera_Scale_IsValid;

	private static FFieldAddress U3DrawDebugCamera_Scale_PropertyAddress;

	private static int U3DrawDebugCamera_Scale_Offset;

	private static bool U3DrawDebugCamera_Color_IsValid;

	private static FFieldAddress U3DrawDebugCamera_Color_PropertyAddress;

	private static int U3DrawDebugCamera_Color_Offset;

	private static bool U3DrawDebugCamera_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugCamera_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugCamera_bPersistentLines_Offset;

	private static bool U3DrawDebugCamera_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugCamera_LifeTime_PropertyAddress;

	private static int U3DrawDebugCamera_LifeTime_Offset;

	private static bool U3DrawDebugCamera_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugCamera_DepthPriority_PropertyAddress;

	private static int U3DrawDebugCamera_DepthPriority_Offset;

	private static bool U3DrawDebugBox2_IsValid;

	private static IntPtr U3DrawDebugBox2_FunctionAddress;

	private static int U3DrawDebugBox2_ParamsSize;

	private static bool U3DrawDebugBox2_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugBox2_InWorld_PropertyAddress;

	private static int U3DrawDebugBox2_InWorld_Offset;

	private static bool U3DrawDebugBox2_Center_IsValid;

	private static FFieldAddress U3DrawDebugBox2_Center_PropertyAddress;

	private static int U3DrawDebugBox2_Center_Offset;

	private static bool U3DrawDebugBox2_Extent_IsValid;

	private static FFieldAddress U3DrawDebugBox2_Extent_PropertyAddress;

	private static int U3DrawDebugBox2_Extent_Offset;

	private static bool U3DrawDebugBox2_Rotation_IsValid;

	private static FFieldAddress U3DrawDebugBox2_Rotation_PropertyAddress;

	private static int U3DrawDebugBox2_Rotation_Offset;

	private static bool U3DrawDebugBox2_Color_IsValid;

	private static FFieldAddress U3DrawDebugBox2_Color_PropertyAddress;

	private static int U3DrawDebugBox2_Color_Offset;

	private static bool U3DrawDebugBox2_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugBox2_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugBox2_bPersistentLines_Offset;

	private static bool U3DrawDebugBox2_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugBox2_LifeTime_PropertyAddress;

	private static int U3DrawDebugBox2_LifeTime_Offset;

	private static bool U3DrawDebugBox2_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugBox2_DepthPriority_PropertyAddress;

	private static int U3DrawDebugBox2_DepthPriority_Offset;

	private static bool U3DrawDebugBox2_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugBox2_Thickness_PropertyAddress;

	private static int U3DrawDebugBox2_Thickness_Offset;

	private static bool U3DrawDebugBox_IsValid;

	private static IntPtr U3DrawDebugBox_FunctionAddress;

	private static int U3DrawDebugBox_ParamsSize;

	private static bool U3DrawDebugBox_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugBox_InWorld_PropertyAddress;

	private static int U3DrawDebugBox_InWorld_Offset;

	private static bool U3DrawDebugBox_Center_IsValid;

	private static FFieldAddress U3DrawDebugBox_Center_PropertyAddress;

	private static int U3DrawDebugBox_Center_Offset;

	private static bool U3DrawDebugBox_Extent_IsValid;

	private static FFieldAddress U3DrawDebugBox_Extent_PropertyAddress;

	private static int U3DrawDebugBox_Extent_Offset;

	private static bool U3DrawDebugBox_Color_IsValid;

	private static FFieldAddress U3DrawDebugBox_Color_PropertyAddress;

	private static int U3DrawDebugBox_Color_Offset;

	private static bool U3DrawDebugBox_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugBox_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugBox_bPersistentLines_Offset;

	private static bool U3DrawDebugBox_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugBox_LifeTime_PropertyAddress;

	private static int U3DrawDebugBox_LifeTime_Offset;

	private static bool U3DrawDebugBox_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugBox_DepthPriority_PropertyAddress;

	private static int U3DrawDebugBox_DepthPriority_Offset;

	private static bool U3DrawDebugBox_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugBox_Thickness_PropertyAddress;

	private static int U3DrawDebugBox_Thickness_Offset;

	private static bool U3DrawDebugAltCone_IsValid;

	private static IntPtr U3DrawDebugAltCone_FunctionAddress;

	private static int U3DrawDebugAltCone_ParamsSize;

	private static bool U3DrawDebugAltCone_InWorld_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_InWorld_PropertyAddress;

	private static int U3DrawDebugAltCone_InWorld_Offset;

	private static bool U3DrawDebugAltCone_Origin_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_Origin_PropertyAddress;

	private static int U3DrawDebugAltCone_Origin_Offset;

	private static bool U3DrawDebugAltCone_Rotation_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_Rotation_PropertyAddress;

	private static int U3DrawDebugAltCone_Rotation_Offset;

	private static bool U3DrawDebugAltCone_Length_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_Length_PropertyAddress;

	private static int U3DrawDebugAltCone_Length_Offset;

	private static bool U3DrawDebugAltCone_AngleWidth_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_AngleWidth_PropertyAddress;

	private static int U3DrawDebugAltCone_AngleWidth_Offset;

	private static bool U3DrawDebugAltCone_AngleHeight_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_AngleHeight_PropertyAddress;

	private static int U3DrawDebugAltCone_AngleHeight_Offset;

	private static bool U3DrawDebugAltCone_DrawColor_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_DrawColor_PropertyAddress;

	private static int U3DrawDebugAltCone_DrawColor_Offset;

	private static bool U3DrawDebugAltCone_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_bPersistentLines_PropertyAddress;

	private static int U3DrawDebugAltCone_bPersistentLines_Offset;

	private static bool U3DrawDebugAltCone_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_LifeTime_PropertyAddress;

	private static int U3DrawDebugAltCone_LifeTime_Offset;

	private static bool U3DrawDebugAltCone_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_DepthPriority_PropertyAddress;

	private static int U3DrawDebugAltCone_DepthPriority_Offset;

	private static bool U3DrawDebugAltCone_Thickness_IsValid;

	private static FFieldAddress U3DrawDebugAltCone_Thickness_PropertyAddress;

	private static int U3DrawDebugAltCone_Thickness_Offset;

	private static bool U3DrawDebug2DDonut_IsValid;

	private static IntPtr U3DrawDebug2DDonut_FunctionAddress;

	private static int U3DrawDebug2DDonut_ParamsSize;

	private static bool U3DrawDebug2DDonut_InWorld_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_InWorld_PropertyAddress;

	private static int U3DrawDebug2DDonut_InWorld_Offset;

	private static bool U3DrawDebug2DDonut_TransformMatrix_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_TransformMatrix_PropertyAddress;

	private static int U3DrawDebug2DDonut_TransformMatrix_Offset;

	private static bool U3DrawDebug2DDonut_InnerRadius_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_InnerRadius_PropertyAddress;

	private static int U3DrawDebug2DDonut_InnerRadius_Offset;

	private static bool U3DrawDebug2DDonut_OuterRadius_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_OuterRadius_PropertyAddress;

	private static int U3DrawDebug2DDonut_OuterRadius_Offset;

	private static bool U3DrawDebug2DDonut_Segments_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_Segments_PropertyAddress;

	private static int U3DrawDebug2DDonut_Segments_Offset;

	private static bool U3DrawDebug2DDonut_Color_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_Color_PropertyAddress;

	private static int U3DrawDebug2DDonut_Color_Offset;

	private static bool U3DrawDebug2DDonut_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_bPersistentLines_PropertyAddress;

	private static int U3DrawDebug2DDonut_bPersistentLines_Offset;

	private static bool U3DrawDebug2DDonut_LifeTime_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_LifeTime_PropertyAddress;

	private static int U3DrawDebug2DDonut_LifeTime_Offset;

	private static bool U3DrawDebug2DDonut_DepthPriority_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_DepthPriority_PropertyAddress;

	private static int U3DrawDebug2DDonut_DepthPriority_Offset;

	private static bool U3DrawDebug2DDonut_Thickness_IsValid;

	private static FFieldAddress U3DrawDebug2DDonut_Thickness_PropertyAddress;

	private static int U3DrawDebug2DDonut_Thickness_Offset;

	private static bool U3DrawCircle_IsValid;

	private static IntPtr U3DrawCircle_FunctionAddress;

	private static int U3DrawCircle_ParamsSize;

	private static bool U3DrawCircle_InWorld_IsValid;

	private static FFieldAddress U3DrawCircle_InWorld_PropertyAddress;

	private static int U3DrawCircle_InWorld_Offset;

	private static bool U3DrawCircle_Base_IsValid;

	private static FFieldAddress U3DrawCircle_Base_PropertyAddress;

	private static int U3DrawCircle_Base_Offset;

	private static bool U3DrawCircle_X_IsValid;

	private static FFieldAddress U3DrawCircle_X_PropertyAddress;

	private static int U3DrawCircle_X_Offset;

	private static bool U3DrawCircle_Y_IsValid;

	private static FFieldAddress U3DrawCircle_Y_PropertyAddress;

	private static int U3DrawCircle_Y_Offset;

	private static bool U3DrawCircle_Color_IsValid;

	private static FFieldAddress U3DrawCircle_Color_PropertyAddress;

	private static int U3DrawCircle_Color_Offset;

	private static bool U3DrawCircle_Radius_IsValid;

	private static FFieldAddress U3DrawCircle_Radius_PropertyAddress;

	private static int U3DrawCircle_Radius_Offset;

	private static bool U3DrawCircle_NumSides_IsValid;

	private static FFieldAddress U3DrawCircle_NumSides_PropertyAddress;

	private static int U3DrawCircle_NumSides_Offset;

	private static bool U3DrawCircle_bPersistentLines_IsValid;

	private static FFieldAddress U3DrawCircle_bPersistentLines_PropertyAddress;

	private static int U3DrawCircle_bPersistentLines_Offset;

	private static bool U3DrawCircle_LifeTime_IsValid;

	private static FFieldAddress U3DrawCircle_LifeTime_PropertyAddress;

	private static int U3DrawCircle_LifeTime_Offset;

	private static bool U3DrawCircle_DepthPriority_IsValid;

	private static FFieldAddress U3DrawCircle_DepthPriority_PropertyAddress;

	private static int U3DrawCircle_DepthPriority_Offset;

	private static bool U3DrawCircle_Thickness_IsValid;

	private static FFieldAddress U3DrawCircle_Thickness_PropertyAddress;

	private static int U3DrawCircle_Thickness_Offset;

	private static bool DisableAllScreenMessages_IsValid;

	private static IntPtr DisableAllScreenMessages_FunctionAddress;

	private static int DisableAllScreenMessages_ParamsSize;

	private static bool DisableAllScreenMessages_WorldCtx_IsValid;

	private static FFieldAddress DisableAllScreenMessages_WorldCtx_PropertyAddress;

	private static int DisableAllScreenMessages_WorldCtx_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3FlushPersistentDebugLines")]
	public unsafe static void U3FlushPersistentDebugLines(UWorld InWorld)
	{
		if (!U3FlushPersistentDebugLines_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3FlushPersistentDebugLines");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3FlushPersistentDebugLines_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3FlushPersistentDebugLines_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3FlushPersistentDebugLines_InWorld_Offset), 0, U3FlushPersistentDebugLines_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3FlushPersistentDebugLines_FunctionAddress, intPtr, U3FlushPersistentDebugLines_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3FlushDebugStrings")]
	public unsafe static void U3FlushDebugStrings(UWorld InWorld)
	{
		if (!U3FlushDebugStrings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3FlushDebugStrings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3FlushDebugStrings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3FlushDebugStrings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3FlushDebugStrings_InWorld_Offset), 0, U3FlushDebugStrings_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3FlushDebugStrings_FunctionAddress, intPtr, U3FlushDebugStrings_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugString")]
	public unsafe static void U3DrawDebugString(UWorld InWorld, FVector TextLocation, string Text, AActor TestBaseActor, FColor TextColor, float Duration, bool bDrawShadow, float FontScale)
	{
		if (!U3DrawDebugString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_InWorld_Offset), 0, U3DrawDebugString_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_TextLocation_Offset), 0, U3DrawDebugString_TextLocation_PropertyAddress.Address, TextLocation);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_Text_Offset), 0, U3DrawDebugString_Text_PropertyAddress.Address, Text);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_TestBaseActor_Offset), 0, U3DrawDebugString_TestBaseActor_PropertyAddress.Address, TestBaseActor);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_TextColor_Offset), 0, U3DrawDebugString_TextColor_PropertyAddress.Address, TextColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_Duration_Offset), 0, U3DrawDebugString_Duration_PropertyAddress.Address, Duration);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_bDrawShadow_Offset), 0, U3DrawDebugString_bDrawShadow_PropertyAddress.Address, bDrawShadow);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugString_FontScale_Offset), 0, U3DrawDebugString_FontScale_PropertyAddress.Address, FontScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugString_FunctionAddress, intPtr, U3DrawDebugString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(U3DrawDebugString_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugSphere")]
	public unsafe static void U3DrawDebugSphere(UWorld InWorld, FVector Center, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugSphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugSphere");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugSphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugSphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_InWorld_Offset), 0, U3DrawDebugSphere_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_Center_Offset), 0, U3DrawDebugSphere_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_Radius_Offset), 0, U3DrawDebugSphere_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_Segments_Offset), 0, U3DrawDebugSphere_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_Color_Offset), 0, U3DrawDebugSphere_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_bPersistentLines_Offset), 0, U3DrawDebugSphere_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_LifeTime_Offset), 0, U3DrawDebugSphere_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_DepthPriority_Offset), 0, U3DrawDebugSphere_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSphere_Thickness_Offset), 0, U3DrawDebugSphere_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugSphere_FunctionAddress, intPtr, U3DrawDebugSphere_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugSolidPlane2")]
	public unsafe static void U3DrawDebugSolidPlane2(UWorld InWorld, FPlane P, FVector Loc, FVector2D Extents, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!U3DrawDebugSolidPlane2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugSolidPlane2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugSolidPlane2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugSolidPlane2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_InWorld_Offset), 0, U3DrawDebugSolidPlane2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FPlane>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_P_Offset), 0, U3DrawDebugSolidPlane2_P_PropertyAddress.Address, P);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_Loc_Offset), 0, U3DrawDebugSolidPlane2_Loc_PropertyAddress.Address, Loc);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_Extents_Offset), 0, U3DrawDebugSolidPlane2_Extents_PropertyAddress.Address, Extents);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_Color_Offset), 0, U3DrawDebugSolidPlane2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_bPersistent_Offset), 0, U3DrawDebugSolidPlane2_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_LifeTime_Offset), 0, U3DrawDebugSolidPlane2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane2_DepthPriority_Offset), 0, U3DrawDebugSolidPlane2_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugSolidPlane2_FunctionAddress, intPtr, U3DrawDebugSolidPlane2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugSolidPlane")]
	public unsafe static void U3DrawDebugSolidPlane(UWorld InWorld, FPlane P, FVector Loc, float Size, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!U3DrawDebugSolidPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugSolidPlane");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugSolidPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugSolidPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_InWorld_Offset), 0, U3DrawDebugSolidPlane_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FPlane>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_P_Offset), 0, U3DrawDebugSolidPlane_P_PropertyAddress.Address, P);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_Loc_Offset), 0, U3DrawDebugSolidPlane_Loc_PropertyAddress.Address, Loc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_Size_Offset), 0, U3DrawDebugSolidPlane_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_Color_Offset), 0, U3DrawDebugSolidPlane_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_bPersistent_Offset), 0, U3DrawDebugSolidPlane_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_LifeTime_Offset), 0, U3DrawDebugSolidPlane_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidPlane_DepthPriority_Offset), 0, U3DrawDebugSolidPlane_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugSolidPlane_FunctionAddress, intPtr, U3DrawDebugSolidPlane_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox3")]
	public unsafe static void U3DrawDebugSolidBox3(UWorld InWorld, FVector Center, FVector Extent, FQuat Rotation, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!U3DrawDebugSolidBox3_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox3");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugSolidBox3_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugSolidBox3_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_InWorld_Offset), 0, U3DrawDebugSolidBox3_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_Center_Offset), 0, U3DrawDebugSolidBox3_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_Extent_Offset), 0, U3DrawDebugSolidBox3_Extent_PropertyAddress.Address, Extent);
		NativeReflection.InitializeValue_InContainer(U3DrawDebugSolidBox3_Rotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_Rotation_Offset), 0, U3DrawDebugSolidBox3_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_Color_Offset), 0, U3DrawDebugSolidBox3_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_bPersistent_Offset), 0, U3DrawDebugSolidBox3_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_LifeTime_Offset), 0, U3DrawDebugSolidBox3_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox3_DepthPriority_Offset), 0, U3DrawDebugSolidBox3_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugSolidBox3_FunctionAddress, intPtr, U3DrawDebugSolidBox3_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox2")]
	public unsafe static void U3DrawDebugSolidBox2(UWorld InWorld, FVector Center, FVector Extent, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!U3DrawDebugSolidBox2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugSolidBox2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugSolidBox2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox2_InWorld_Offset), 0, U3DrawDebugSolidBox2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox2_Center_Offset), 0, U3DrawDebugSolidBox2_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox2_Extent_Offset), 0, U3DrawDebugSolidBox2_Extent_PropertyAddress.Address, Extent);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox2_Color_Offset), 0, U3DrawDebugSolidBox2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox2_bPersistent_Offset), 0, U3DrawDebugSolidBox2_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox2_LifeTime_Offset), 0, U3DrawDebugSolidBox2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox2_DepthPriority_Offset), 0, U3DrawDebugSolidBox2_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugSolidBox2_FunctionAddress, intPtr, U3DrawDebugSolidBox2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox")]
	public unsafe static void U3DrawDebugSolidBox(UWorld InWorld, FBox Box, FColor Color, FTransform Transform, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!U3DrawDebugSolidBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugSolidBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugSolidBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox_InWorld_Offset), 0, U3DrawDebugSolidBox_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox_Box_Offset), 0, U3DrawDebugSolidBox_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox_Color_Offset), 0, U3DrawDebugSolidBox_Color_PropertyAddress.Address, Color);
		NativeReflection.InitializeValue_InContainer(U3DrawDebugSolidBox_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox_Transform_Offset), 0, U3DrawDebugSolidBox_Transform_PropertyAddress.Address, Transform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox_bPersistent_Offset), 0, U3DrawDebugSolidBox_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox_LifeTime_Offset), 0, U3DrawDebugSolidBox_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugSolidBox_DepthPriority_Offset), 0, U3DrawDebugSolidBox_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugSolidBox_FunctionAddress, intPtr, U3DrawDebugSolidBox_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugPoint")]
	public unsafe static void U3DrawDebugPoint(UWorld InWorld, FVector Position, float Size, FColor PointColor, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!U3DrawDebugPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugPoint_InWorld_Offset), 0, U3DrawDebugPoint_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugPoint_Position_Offset), 0, U3DrawDebugPoint_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugPoint_Size_Offset), 0, U3DrawDebugPoint_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugPoint_PointColor_Offset), 0, U3DrawDebugPoint_PointColor_PropertyAddress.Address, PointColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugPoint_bPersistentLines_Offset), 0, U3DrawDebugPoint_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugPoint_LifeTime_Offset), 0, U3DrawDebugPoint_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugPoint_DepthPriority_Offset), 0, U3DrawDebugPoint_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugPoint_FunctionAddress, intPtr, U3DrawDebugPoint_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugMesh")]
	public unsafe static void U3DrawDebugMesh(UWorld InWorld, List<FVector> Verts, List<int> Indices, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!U3DrawDebugMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugMesh_InWorld_Offset), 0, U3DrawDebugMesh_InWorld_PropertyAddress.Address, InWorld);
		new TArrayCopyMarshaler<FVector>(1, U3DrawDebugMesh_Verts_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, U3DrawDebugMesh_Verts_Offset), Verts);
		new TArrayCopyMarshaler<int>(1, U3DrawDebugMesh_Indices_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, U3DrawDebugMesh_Indices_Offset), Indices);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugMesh_Color_Offset), 0, U3DrawDebugMesh_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugMesh_bPersistent_Offset), 0, U3DrawDebugMesh_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugMesh_LifeTime_Offset), 0, U3DrawDebugMesh_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugMesh_DepthPriority_Offset), 0, U3DrawDebugMesh_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugMesh_FunctionAddress, intPtr, U3DrawDebugMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(U3DrawDebugMesh_Verts_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(U3DrawDebugMesh_Indices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugLine")]
	public unsafe static void U3DrawDebugLine(UWorld InWorld, FVector LineStart, FVector LineEnd, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_InWorld_Offset), 0, U3DrawDebugLine_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_LineStart_Offset), 0, U3DrawDebugLine_LineStart_PropertyAddress.Address, LineStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_LineEnd_Offset), 0, U3DrawDebugLine_LineEnd_PropertyAddress.Address, LineEnd);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_Color_Offset), 0, U3DrawDebugLine_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_bPersistentLines_Offset), 0, U3DrawDebugLine_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_LifeTime_Offset), 0, U3DrawDebugLine_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_DepthPriority_Offset), 0, U3DrawDebugLine_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugLine_Thickness_Offset), 0, U3DrawDebugLine_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugLine_FunctionAddress, intPtr, U3DrawDebugLine_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugFrustum")]
	public unsafe static void U3DrawDebugFrustum(UWorld InWorld, FMatrix FrustumToWorld, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugFrustum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugFrustum");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugFrustum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugFrustum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugFrustum_InWorld_Offset), 0, U3DrawDebugFrustum_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(intPtr, U3DrawDebugFrustum_FrustumToWorld_Offset), 0, U3DrawDebugFrustum_FrustumToWorld_PropertyAddress.Address, FrustumToWorld);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugFrustum_Color_Offset), 0, U3DrawDebugFrustum_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugFrustum_bPersistentLines_Offset), 0, U3DrawDebugFrustum_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugFrustum_LifeTime_Offset), 0, U3DrawDebugFrustum_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugFrustum_DepthPriority_Offset), 0, U3DrawDebugFrustum_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugFrustum_Thickness_Offset), 0, U3DrawDebugFrustum_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugFrustum_FunctionAddress, intPtr, U3DrawDebugFrustum_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugDirectionalArrow")]
	public unsafe static void U3DrawDebugDirectionalArrow(UWorld InWorld, FVector LineStart, FVector LineEnd, float ArrowSize, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugDirectionalArrow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugDirectionalArrow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugDirectionalArrow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugDirectionalArrow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_InWorld_Offset), 0, U3DrawDebugDirectionalArrow_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_LineStart_Offset), 0, U3DrawDebugDirectionalArrow_LineStart_PropertyAddress.Address, LineStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_LineEnd_Offset), 0, U3DrawDebugDirectionalArrow_LineEnd_PropertyAddress.Address, LineEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_ArrowSize_Offset), 0, U3DrawDebugDirectionalArrow_ArrowSize_PropertyAddress.Address, ArrowSize);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_Color_Offset), 0, U3DrawDebugDirectionalArrow_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_bPersistentLines_Offset), 0, U3DrawDebugDirectionalArrow_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_LifeTime_Offset), 0, U3DrawDebugDirectionalArrow_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_DepthPriority_Offset), 0, U3DrawDebugDirectionalArrow_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugDirectionalArrow_Thickness_Offset), 0, U3DrawDebugDirectionalArrow_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugDirectionalArrow_FunctionAddress, intPtr, U3DrawDebugDirectionalArrow_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCylinder")]
	public unsafe static void U3DrawDebugCylinder(UWorld InWorld, FVector Start, FVector End, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugCylinder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCylinder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCylinder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCylinder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_InWorld_Offset), 0, U3DrawDebugCylinder_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_Start_Offset), 0, U3DrawDebugCylinder_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_End_Offset), 0, U3DrawDebugCylinder_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_Radius_Offset), 0, U3DrawDebugCylinder_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_Segments_Offset), 0, U3DrawDebugCylinder_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_Color_Offset), 0, U3DrawDebugCylinder_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_bPersistentLines_Offset), 0, U3DrawDebugCylinder_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_LifeTime_Offset), 0, U3DrawDebugCylinder_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_DepthPriority_Offset), 0, U3DrawDebugCylinder_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCylinder_Thickness_Offset), 0, U3DrawDebugCylinder_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCylinder_FunctionAddress, intPtr, U3DrawDebugCylinder_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCrosshairs")]
	public unsafe static void U3DrawDebugCrosshairs(UWorld InWorld, FVector AxisLoc, FRotator AxisRot, float Scale, FColor Color, bool bPersistentLines, float LifeTime, byte DepthPriority)
	{
		if (!U3DrawDebugCrosshairs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCrosshairs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCrosshairs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCrosshairs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_InWorld_Offset), 0, U3DrawDebugCrosshairs_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_AxisLoc_Offset), 0, U3DrawDebugCrosshairs_AxisLoc_PropertyAddress.Address, AxisLoc);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_AxisRot_Offset), 0, U3DrawDebugCrosshairs_AxisRot_PropertyAddress.Address, AxisRot);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_Scale_Offset), 0, U3DrawDebugCrosshairs_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_Color_Offset), 0, U3DrawDebugCrosshairs_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_bPersistentLines_Offset), 0, U3DrawDebugCrosshairs_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_LifeTime_Offset), 0, U3DrawDebugCrosshairs_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCrosshairs_DepthPriority_Offset), 0, U3DrawDebugCrosshairs_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCrosshairs_FunctionAddress, intPtr, U3DrawDebugCrosshairs_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCoordinateSystem")]
	public unsafe static void U3DrawDebugCoordinateSystem(UWorld InWorld, FVector AxisLoc, FRotator AxisRot, float Scale, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugCoordinateSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCoordinateSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCoordinateSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCoordinateSystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_InWorld_Offset), 0, U3DrawDebugCoordinateSystem_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_AxisLoc_Offset), 0, U3DrawDebugCoordinateSystem_AxisLoc_PropertyAddress.Address, AxisLoc);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_AxisRot_Offset), 0, U3DrawDebugCoordinateSystem_AxisRot_PropertyAddress.Address, AxisRot);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_Scale_Offset), 0, U3DrawDebugCoordinateSystem_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_bPersistentLines_Offset), 0, U3DrawDebugCoordinateSystem_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_LifeTime_Offset), 0, U3DrawDebugCoordinateSystem_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_DepthPriority_Offset), 0, U3DrawDebugCoordinateSystem_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCoordinateSystem_Thickness_Offset), 0, U3DrawDebugCoordinateSystem_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCoordinateSystem_FunctionAddress, intPtr, U3DrawDebugCoordinateSystem_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCone")]
	public unsafe static void U3DrawDebugCone(UWorld InWorld, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_InWorld_Offset), 0, U3DrawDebugCone_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_Origin_Offset), 0, U3DrawDebugCone_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_Direction_Offset), 0, U3DrawDebugCone_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_Length_Offset), 0, U3DrawDebugCone_Length_PropertyAddress.Address, Length);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_AngleWidth_Offset), 0, U3DrawDebugCone_AngleWidth_PropertyAddress.Address, AngleWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_AngleHeight_Offset), 0, U3DrawDebugCone_AngleHeight_PropertyAddress.Address, AngleHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_NumSides_Offset), 0, U3DrawDebugCone_NumSides_PropertyAddress.Address, NumSides);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_Color_Offset), 0, U3DrawDebugCone_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_bPersistentLines_Offset), 0, U3DrawDebugCone_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_LifeTime_Offset), 0, U3DrawDebugCone_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_DepthPriority_Offset), 0, U3DrawDebugCone_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCone_Thickness_Offset), 0, U3DrawDebugCone_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCone_FunctionAddress, intPtr, U3DrawDebugCone_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCircle2")]
	public unsafe static void U3DrawDebugCircle2(UWorld InWorld, FVector Center, float Radius, int Segments, FColor Color, bool bPersistentLines, float LifeTime, byte DepthPriority, float Thickness, FVector YAxis, FVector ZAxis, bool bDrawAxis)
	{
		if (!U3DrawDebugCircle2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCircle2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCircle2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCircle2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_InWorld_Offset), 0, U3DrawDebugCircle2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_Center_Offset), 0, U3DrawDebugCircle2_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_Radius_Offset), 0, U3DrawDebugCircle2_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_Segments_Offset), 0, U3DrawDebugCircle2_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_Color_Offset), 0, U3DrawDebugCircle2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_bPersistentLines_Offset), 0, U3DrawDebugCircle2_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_LifeTime_Offset), 0, U3DrawDebugCircle2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_DepthPriority_Offset), 0, U3DrawDebugCircle2_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_Thickness_Offset), 0, U3DrawDebugCircle2_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_YAxis_Offset), 0, U3DrawDebugCircle2_YAxis_PropertyAddress.Address, YAxis);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_ZAxis_Offset), 0, U3DrawDebugCircle2_ZAxis_PropertyAddress.Address, ZAxis);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle2_bDrawAxis_Offset), 0, U3DrawDebugCircle2_bDrawAxis_PropertyAddress.Address, bDrawAxis);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCircle2_FunctionAddress, intPtr, U3DrawDebugCircle2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCircle")]
	public unsafe static void U3DrawDebugCircle(UWorld InWorld, FMatrix TransformMatrix, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f, bool bDrawAxis = true)
	{
		if (!U3DrawDebugCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_InWorld_Offset), 0, U3DrawDebugCircle_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_TransformMatrix_Offset), 0, U3DrawDebugCircle_TransformMatrix_PropertyAddress.Address, TransformMatrix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_Radius_Offset), 0, U3DrawDebugCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_Segments_Offset), 0, U3DrawDebugCircle_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_Color_Offset), 0, U3DrawDebugCircle_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_bPersistentLines_Offset), 0, U3DrawDebugCircle_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_LifeTime_Offset), 0, U3DrawDebugCircle_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_DepthPriority_Offset), 0, U3DrawDebugCircle_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_Thickness_Offset), 0, U3DrawDebugCircle_Thickness_PropertyAddress.Address, Thickness);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCircle_bDrawAxis_Offset), 0, U3DrawDebugCircle_bDrawAxis_PropertyAddress.Address, bDrawAxis);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCircle_FunctionAddress, intPtr, U3DrawDebugCircle_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCapsule")]
	public unsafe static void U3DrawDebugCapsule(UWorld InWorld, FVector Center, float HalfHeight, float Radius, FQuat Rotation, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugCapsule_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCapsule");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCapsule_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCapsule_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_InWorld_Offset), 0, U3DrawDebugCapsule_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_Center_Offset), 0, U3DrawDebugCapsule_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_HalfHeight_Offset), 0, U3DrawDebugCapsule_HalfHeight_PropertyAddress.Address, HalfHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_Radius_Offset), 0, U3DrawDebugCapsule_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InitializeValue_InContainer(U3DrawDebugCapsule_Rotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_Rotation_Offset), 0, U3DrawDebugCapsule_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_Color_Offset), 0, U3DrawDebugCapsule_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_bPersistentLines_Offset), 0, U3DrawDebugCapsule_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_LifeTime_Offset), 0, U3DrawDebugCapsule_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_DepthPriority_Offset), 0, U3DrawDebugCapsule_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCapsule_Thickness_Offset), 0, U3DrawDebugCapsule_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCapsule_FunctionAddress, intPtr, U3DrawDebugCapsule_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvasWireSphere")]
	public unsafe static void U3DrawDebugCanvasWireSphere(UCanvas Canvas, FVector Base, FColor Color, float Radius, int NumSides)
	{
		if (!U3DrawDebugCanvasWireSphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvasWireSphere");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvasWireSphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvasWireSphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireSphere_Canvas_Offset), 0, U3DrawDebugCanvasWireSphere_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireSphere_Base_Offset), 0, U3DrawDebugCanvasWireSphere_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireSphere_Color_Offset), 0, U3DrawDebugCanvasWireSphere_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireSphere_Radius_Offset), 0, U3DrawDebugCanvasWireSphere_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireSphere_NumSides_Offset), 0, U3DrawDebugCanvasWireSphere_NumSides_PropertyAddress.Address, NumSides);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvasWireSphere_FunctionAddress, intPtr, U3DrawDebugCanvasWireSphere_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvasWireCone")]
	public unsafe static void U3DrawDebugCanvasWireCone(UCanvas Canvas, FTransform Transform, float ConeRadius, float ConeAngle, int ConeSides, FColor Color)
	{
		if (!U3DrawDebugCanvasWireCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvasWireCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvasWireCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvasWireCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireCone_Canvas_Offset), 0, U3DrawDebugCanvasWireCone_Canvas_PropertyAddress.Address, Canvas);
		NativeReflection.InitializeValue_InContainer(U3DrawDebugCanvasWireCone_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireCone_Transform_Offset), 0, U3DrawDebugCanvasWireCone_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireCone_ConeRadius_Offset), 0, U3DrawDebugCanvasWireCone_ConeRadius_PropertyAddress.Address, ConeRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireCone_ConeAngle_Offset), 0, U3DrawDebugCanvasWireCone_ConeAngle_PropertyAddress.Address, ConeAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireCone_ConeSides_Offset), 0, U3DrawDebugCanvasWireCone_ConeSides_PropertyAddress.Address, ConeSides);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasWireCone_Color_Offset), 0, U3DrawDebugCanvasWireCone_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvasWireCone_FunctionAddress, intPtr, U3DrawDebugCanvasWireCone_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvasLine")]
	public unsafe static void U3DrawDebugCanvasLine(UCanvas Canvas, FVector Start, FVector End, FLinearColor LineColor)
	{
		if (!U3DrawDebugCanvasLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvasLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvasLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvasLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasLine_Canvas_Offset), 0, U3DrawDebugCanvasLine_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasLine_Start_Offset), 0, U3DrawDebugCanvasLine_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasLine_End_Offset), 0, U3DrawDebugCanvasLine_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasLine_LineColor_Offset), 0, U3DrawDebugCanvasLine_LineColor_PropertyAddress.Address, LineColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvasLine_FunctionAddress, intPtr, U3DrawDebugCanvasLine_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvasCircle")]
	public unsafe static void U3DrawDebugCanvasCircle(UCanvas Canvas, FVector Base, FVector X, FVector Y, FColor Color, float Radius, int NumSides)
	{
		if (!U3DrawDebugCanvasCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvasCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvasCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvasCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasCircle_Canvas_Offset), 0, U3DrawDebugCanvasCircle_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasCircle_Base_Offset), 0, U3DrawDebugCanvasCircle_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasCircle_X_Offset), 0, U3DrawDebugCanvasCircle_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasCircle_Y_Offset), 0, U3DrawDebugCanvasCircle_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasCircle_Color_Offset), 0, U3DrawDebugCanvasCircle_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasCircle_Radius_Offset), 0, U3DrawDebugCanvasCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvasCircle_NumSides_Offset), 0, U3DrawDebugCanvasCircle_NumSides_PropertyAddress.Address, NumSides);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvasCircle_FunctionAddress, intPtr, U3DrawDebugCanvasCircle_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DLine2")]
	public unsafe static void U3DrawDebugCanvas2DLine2(UCanvas Canvas, FVector2D StartPosition, FVector2D EndPosition, FLinearColor LineColor, float LineThickness = 1f)
	{
		if (!U3DrawDebugCanvas2DLine2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DLine2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvas2DLine2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvas2DLine2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine2_Canvas_Offset), 0, U3DrawDebugCanvas2DLine2_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine2_StartPosition_Offset), 0, U3DrawDebugCanvas2DLine2_StartPosition_PropertyAddress.Address, StartPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine2_EndPosition_Offset), 0, U3DrawDebugCanvas2DLine2_EndPosition_PropertyAddress.Address, EndPosition);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine2_LineColor_Offset), 0, U3DrawDebugCanvas2DLine2_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine2_LineThickness_Offset), 0, U3DrawDebugCanvas2DLine2_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvas2DLine2_FunctionAddress, intPtr, U3DrawDebugCanvas2DLine2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DLine")]
	public unsafe static void U3DrawDebugCanvas2DLine(UCanvas Canvas, FVector Start, FVector End, FLinearColor LineColor)
	{
		if (!U3DrawDebugCanvas2DLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvas2DLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvas2DLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine_Canvas_Offset), 0, U3DrawDebugCanvas2DLine_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine_Start_Offset), 0, U3DrawDebugCanvas2DLine_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine_End_Offset), 0, U3DrawDebugCanvas2DLine_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DLine_LineColor_Offset), 0, U3DrawDebugCanvas2DLine_LineColor_PropertyAddress.Address, LineColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvas2DLine_FunctionAddress, intPtr, U3DrawDebugCanvas2DLine_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DCircle")]
	public unsafe static void U3DrawDebugCanvas2DCircle(UCanvas Canvas, FVector2D Center, float Radius, int NumSides, FLinearColor LineColor, float LineThickness = 1f)
	{
		if (!U3DrawDebugCanvas2DCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvas2DCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvas2DCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DCircle_Canvas_Offset), 0, U3DrawDebugCanvas2DCircle_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DCircle_Center_Offset), 0, U3DrawDebugCanvas2DCircle_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DCircle_Radius_Offset), 0, U3DrawDebugCanvas2DCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DCircle_NumSides_Offset), 0, U3DrawDebugCanvas2DCircle_NumSides_PropertyAddress.Address, NumSides);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DCircle_LineColor_Offset), 0, U3DrawDebugCanvas2DCircle_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DCircle_LineThickness_Offset), 0, U3DrawDebugCanvas2DCircle_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvas2DCircle_FunctionAddress, intPtr, U3DrawDebugCanvas2DCircle_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DBox")]
	public unsafe static void U3DrawDebugCanvas2DBox(UCanvas Canvas, FBox2D Box, FLinearColor LineColor, float LineThickness = 1f)
	{
		if (!U3DrawDebugCanvas2DBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCanvas2DBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCanvas2DBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DBox_Canvas_Offset), 0, U3DrawDebugCanvas2DBox_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DBox_Box_Offset), 0, U3DrawDebugCanvas2DBox_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DBox_LineColor_Offset), 0, U3DrawDebugCanvas2DBox_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCanvas2DBox_LineThickness_Offset), 0, U3DrawDebugCanvas2DBox_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCanvas2DBox_FunctionAddress, intPtr, U3DrawDebugCanvas2DBox_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugCamera")]
	public unsafe static void U3DrawDebugCamera(UWorld InWorld, FVector Location, FRotator Rotation, float FOVDeg, float Scale, FColor Color, bool bPersistentLines, float LifeTime, byte DepthPriority)
	{
		if (!U3DrawDebugCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_InWorld_Offset), 0, U3DrawDebugCamera_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_Location_Offset), 0, U3DrawDebugCamera_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_Rotation_Offset), 0, U3DrawDebugCamera_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_FOVDeg_Offset), 0, U3DrawDebugCamera_FOVDeg_PropertyAddress.Address, FOVDeg);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_Scale_Offset), 0, U3DrawDebugCamera_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_Color_Offset), 0, U3DrawDebugCamera_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_bPersistentLines_Offset), 0, U3DrawDebugCamera_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_LifeTime_Offset), 0, U3DrawDebugCamera_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugCamera_DepthPriority_Offset), 0, U3DrawDebugCamera_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugCamera_FunctionAddress, intPtr, U3DrawDebugCamera_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugBox2")]
	public unsafe static void U3DrawDebugBox2(UWorld InWorld, FVector Center, FVector Extent, FQuat Rotation, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugBox2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugBox2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugBox2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugBox2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_InWorld_Offset), 0, U3DrawDebugBox2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_Center_Offset), 0, U3DrawDebugBox2_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_Extent_Offset), 0, U3DrawDebugBox2_Extent_PropertyAddress.Address, Extent);
		NativeReflection.InitializeValue_InContainer(U3DrawDebugBox2_Rotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_Rotation_Offset), 0, U3DrawDebugBox2_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_Color_Offset), 0, U3DrawDebugBox2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_bPersistentLines_Offset), 0, U3DrawDebugBox2_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_LifeTime_Offset), 0, U3DrawDebugBox2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_DepthPriority_Offset), 0, U3DrawDebugBox2_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox2_Thickness_Offset), 0, U3DrawDebugBox2_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugBox2_FunctionAddress, intPtr, U3DrawDebugBox2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugBox")]
	public unsafe static void U3DrawDebugBox(UWorld InWorld, FVector Center, FVector Extent, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_InWorld_Offset), 0, U3DrawDebugBox_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_Center_Offset), 0, U3DrawDebugBox_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_Extent_Offset), 0, U3DrawDebugBox_Extent_PropertyAddress.Address, Extent);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_Color_Offset), 0, U3DrawDebugBox_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_bPersistentLines_Offset), 0, U3DrawDebugBox_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_LifeTime_Offset), 0, U3DrawDebugBox_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_DepthPriority_Offset), 0, U3DrawDebugBox_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugBox_Thickness_Offset), 0, U3DrawDebugBox_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugBox_FunctionAddress, intPtr, U3DrawDebugBox_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebugAltCone")]
	public unsafe static void U3DrawDebugAltCone(UWorld InWorld, FVector Origin, FRotator Rotation, float Length, float AngleWidth, float AngleHeight, FColor DrawColor, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebugAltCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebugAltCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebugAltCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebugAltCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_InWorld_Offset), 0, U3DrawDebugAltCone_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_Origin_Offset), 0, U3DrawDebugAltCone_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_Rotation_Offset), 0, U3DrawDebugAltCone_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_Length_Offset), 0, U3DrawDebugAltCone_Length_PropertyAddress.Address, Length);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_AngleWidth_Offset), 0, U3DrawDebugAltCone_AngleWidth_PropertyAddress.Address, AngleWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_AngleHeight_Offset), 0, U3DrawDebugAltCone_AngleHeight_PropertyAddress.Address, AngleHeight);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_DrawColor_Offset), 0, U3DrawDebugAltCone_DrawColor_PropertyAddress.Address, DrawColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_bPersistentLines_Offset), 0, U3DrawDebugAltCone_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_LifeTime_Offset), 0, U3DrawDebugAltCone_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_DepthPriority_Offset), 0, U3DrawDebugAltCone_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebugAltCone_Thickness_Offset), 0, U3DrawDebugAltCone_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebugAltCone_FunctionAddress, intPtr, U3DrawDebugAltCone_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawDebug2DDonut")]
	public unsafe static void U3DrawDebug2DDonut(UWorld InWorld, FMatrix TransformMatrix, float InnerRadius, float OuterRadius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawDebug2DDonut_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawDebug2DDonut");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawDebug2DDonut_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawDebug2DDonut_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_InWorld_Offset), 0, U3DrawDebug2DDonut_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_TransformMatrix_Offset), 0, U3DrawDebug2DDonut_TransformMatrix_PropertyAddress.Address, TransformMatrix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_InnerRadius_Offset), 0, U3DrawDebug2DDonut_InnerRadius_PropertyAddress.Address, InnerRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_OuterRadius_Offset), 0, U3DrawDebug2DDonut_OuterRadius_PropertyAddress.Address, OuterRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_Segments_Offset), 0, U3DrawDebug2DDonut_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_Color_Offset), 0, U3DrawDebug2DDonut_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_bPersistentLines_Offset), 0, U3DrawDebug2DDonut_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_LifeTime_Offset), 0, U3DrawDebug2DDonut_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_DepthPriority_Offset), 0, U3DrawDebug2DDonut_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawDebug2DDonut_Thickness_Offset), 0, U3DrawDebug2DDonut_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawDebug2DDonut_FunctionAddress, intPtr, U3DrawDebug2DDonut_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.U3DebugUtil:U3DrawCircle")]
	public unsafe static void U3DrawCircle(UWorld InWorld, FVector Base, FVector X, FVector Y, FColor Color, float Radius, int NumSides, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!U3DrawCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:U3DrawCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(U3DrawCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)U3DrawCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_InWorld_Offset), 0, U3DrawCircle_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_Base_Offset), 0, U3DrawCircle_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_X_Offset), 0, U3DrawCircle_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_Y_Offset), 0, U3DrawCircle_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_Color_Offset), 0, U3DrawCircle_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_Radius_Offset), 0, U3DrawCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_NumSides_Offset), 0, U3DrawCircle_NumSides_PropertyAddress.Address, NumSides);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, U3DrawCircle_bPersistentLines_Offset), 0, U3DrawCircle_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_LifeTime_Offset), 0, U3DrawCircle_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_DepthPriority_Offset), 0, U3DrawCircle_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, U3DrawCircle_Thickness_Offset), 0, U3DrawCircle_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, U3DrawCircle_FunctionAddress, intPtr, U3DrawCircle_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.U3DebugUtil:DisableAllScreenMessages")]
	public unsafe static void DisableAllScreenMessages(UObject WorldCtx)
	{
		if (!DisableAllScreenMessages_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.U3DebugUtil:DisableAllScreenMessages");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableAllScreenMessages_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableAllScreenMessages_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DisableAllScreenMessages_WorldCtx_Offset), 0, DisableAllScreenMessages_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableAllScreenMessages_FunctionAddress, intPtr, DisableAllScreenMessages_ParamsSize);
	}

	static U3DebugUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(U3DebugUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(U3DebugUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.U3DebugUtil");
		U3FlushPersistentDebugLines_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3FlushPersistentDebugLines");
		U3FlushPersistentDebugLines_ParamsSize = NativeReflection.GetFunctionParamsSize(U3FlushPersistentDebugLines_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3FlushPersistentDebugLines_InWorld_PropertyAddress, U3FlushPersistentDebugLines_FunctionAddress, "InWorld");
		U3FlushPersistentDebugLines_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3FlushPersistentDebugLines_FunctionAddress, "InWorld");
		U3FlushPersistentDebugLines_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3FlushPersistentDebugLines_FunctionAddress, "InWorld", Classes.FObjectProperty);
		U3FlushPersistentDebugLines_IsValid = U3FlushPersistentDebugLines_FunctionAddress != IntPtr.Zero && U3FlushPersistentDebugLines_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3FlushPersistentDebugLines", U3FlushPersistentDebugLines_IsValid);
		U3FlushDebugStrings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3FlushDebugStrings");
		U3FlushDebugStrings_ParamsSize = NativeReflection.GetFunctionParamsSize(U3FlushDebugStrings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3FlushDebugStrings_InWorld_PropertyAddress, U3FlushDebugStrings_FunctionAddress, "InWorld");
		U3FlushDebugStrings_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3FlushDebugStrings_FunctionAddress, "InWorld");
		U3FlushDebugStrings_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3FlushDebugStrings_FunctionAddress, "InWorld", Classes.FObjectProperty);
		U3FlushDebugStrings_IsValid = U3FlushDebugStrings_FunctionAddress != IntPtr.Zero && U3FlushDebugStrings_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3FlushDebugStrings", U3FlushDebugStrings_IsValid);
		U3DrawDebugString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugString");
		U3DrawDebugString_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_InWorld_PropertyAddress, U3DrawDebugString_FunctionAddress, "InWorld");
		U3DrawDebugString_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "InWorld");
		U3DrawDebugString_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_TextLocation_PropertyAddress, U3DrawDebugString_FunctionAddress, "TextLocation");
		U3DrawDebugString_TextLocation_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "TextLocation");
		U3DrawDebugString_TextLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "TextLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_Text_PropertyAddress, U3DrawDebugString_FunctionAddress, "Text");
		U3DrawDebugString_Text_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "Text");
		U3DrawDebugString_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_TestBaseActor_PropertyAddress, U3DrawDebugString_FunctionAddress, "TestBaseActor");
		U3DrawDebugString_TestBaseActor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "TestBaseActor");
		U3DrawDebugString_TestBaseActor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "TestBaseActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_TextColor_PropertyAddress, U3DrawDebugString_FunctionAddress, "TextColor");
		U3DrawDebugString_TextColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "TextColor");
		U3DrawDebugString_TextColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "TextColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_Duration_PropertyAddress, U3DrawDebugString_FunctionAddress, "Duration");
		U3DrawDebugString_Duration_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "Duration");
		U3DrawDebugString_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_bDrawShadow_PropertyAddress, U3DrawDebugString_FunctionAddress, "bDrawShadow");
		U3DrawDebugString_bDrawShadow_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "bDrawShadow");
		U3DrawDebugString_bDrawShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "bDrawShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugString_FontScale_PropertyAddress, U3DrawDebugString_FunctionAddress, "FontScale");
		U3DrawDebugString_FontScale_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugString_FunctionAddress, "FontScale");
		U3DrawDebugString_FontScale_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugString_FunctionAddress, "FontScale", Classes.FFloatProperty);
		U3DrawDebugString_IsValid = U3DrawDebugString_FunctionAddress != IntPtr.Zero && U3DrawDebugString_InWorld_IsValid && U3DrawDebugString_TextLocation_IsValid && U3DrawDebugString_Text_IsValid && U3DrawDebugString_TestBaseActor_IsValid && U3DrawDebugString_TextColor_IsValid && U3DrawDebugString_Duration_IsValid && U3DrawDebugString_bDrawShadow_IsValid && U3DrawDebugString_FontScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugString", U3DrawDebugString_IsValid);
		U3DrawDebugSphere_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugSphere");
		U3DrawDebugSphere_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugSphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_InWorld_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "InWorld");
		U3DrawDebugSphere_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "InWorld");
		U3DrawDebugSphere_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_Center_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "Center");
		U3DrawDebugSphere_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "Center");
		U3DrawDebugSphere_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_Radius_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "Radius");
		U3DrawDebugSphere_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "Radius");
		U3DrawDebugSphere_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_Segments_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "Segments");
		U3DrawDebugSphere_Segments_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "Segments");
		U3DrawDebugSphere_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_Color_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "Color");
		U3DrawDebugSphere_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "Color");
		U3DrawDebugSphere_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_bPersistentLines_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "bPersistentLines");
		U3DrawDebugSphere_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "bPersistentLines");
		U3DrawDebugSphere_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_LifeTime_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "LifeTime");
		U3DrawDebugSphere_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "LifeTime");
		U3DrawDebugSphere_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_DepthPriority_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "DepthPriority");
		U3DrawDebugSphere_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "DepthPriority");
		U3DrawDebugSphere_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSphere_Thickness_PropertyAddress, U3DrawDebugSphere_FunctionAddress, "Thickness");
		U3DrawDebugSphere_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSphere_FunctionAddress, "Thickness");
		U3DrawDebugSphere_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSphere_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugSphere_IsValid = U3DrawDebugSphere_FunctionAddress != IntPtr.Zero && U3DrawDebugSphere_InWorld_IsValid && U3DrawDebugSphere_Center_IsValid && U3DrawDebugSphere_Radius_IsValid && U3DrawDebugSphere_Segments_IsValid && U3DrawDebugSphere_Color_IsValid && U3DrawDebugSphere_bPersistentLines_IsValid && U3DrawDebugSphere_LifeTime_IsValid && U3DrawDebugSphere_DepthPriority_IsValid && U3DrawDebugSphere_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugSphere", U3DrawDebugSphere_IsValid);
		U3DrawDebugSolidPlane2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugSolidPlane2");
		U3DrawDebugSolidPlane2_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugSolidPlane2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_InWorld_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "InWorld");
		U3DrawDebugSolidPlane2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "InWorld");
		U3DrawDebugSolidPlane2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_P_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "P");
		U3DrawDebugSolidPlane2_P_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "P");
		U3DrawDebugSolidPlane2_P_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "P", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_Loc_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "Loc");
		U3DrawDebugSolidPlane2_Loc_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "Loc");
		U3DrawDebugSolidPlane2_Loc_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "Loc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_Extents_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "Extents");
		U3DrawDebugSolidPlane2_Extents_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "Extents");
		U3DrawDebugSolidPlane2_Extents_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "Extents", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_Color_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "Color");
		U3DrawDebugSolidPlane2_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "Color");
		U3DrawDebugSolidPlane2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_bPersistent_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "bPersistent");
		U3DrawDebugSolidPlane2_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "bPersistent");
		U3DrawDebugSolidPlane2_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_LifeTime_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "LifeTime");
		U3DrawDebugSolidPlane2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "LifeTime");
		U3DrawDebugSolidPlane2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane2_DepthPriority_PropertyAddress, U3DrawDebugSolidPlane2_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidPlane2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane2_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidPlane2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugSolidPlane2_IsValid = U3DrawDebugSolidPlane2_FunctionAddress != IntPtr.Zero && U3DrawDebugSolidPlane2_InWorld_IsValid && U3DrawDebugSolidPlane2_P_IsValid && U3DrawDebugSolidPlane2_Loc_IsValid && U3DrawDebugSolidPlane2_Extents_IsValid && U3DrawDebugSolidPlane2_Color_IsValid && U3DrawDebugSolidPlane2_bPersistent_IsValid && U3DrawDebugSolidPlane2_LifeTime_IsValid && U3DrawDebugSolidPlane2_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugSolidPlane2", U3DrawDebugSolidPlane2_IsValid);
		U3DrawDebugSolidPlane_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugSolidPlane");
		U3DrawDebugSolidPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugSolidPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_InWorld_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "InWorld");
		U3DrawDebugSolidPlane_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "InWorld");
		U3DrawDebugSolidPlane_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_P_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "P");
		U3DrawDebugSolidPlane_P_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "P");
		U3DrawDebugSolidPlane_P_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "P", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_Loc_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "Loc");
		U3DrawDebugSolidPlane_Loc_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "Loc");
		U3DrawDebugSolidPlane_Loc_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "Loc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_Size_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "Size");
		U3DrawDebugSolidPlane_Size_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "Size");
		U3DrawDebugSolidPlane_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "Size", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_Color_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "Color");
		U3DrawDebugSolidPlane_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "Color");
		U3DrawDebugSolidPlane_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_bPersistent_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "bPersistent");
		U3DrawDebugSolidPlane_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "bPersistent");
		U3DrawDebugSolidPlane_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_LifeTime_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "LifeTime");
		U3DrawDebugSolidPlane_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "LifeTime");
		U3DrawDebugSolidPlane_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidPlane_DepthPriority_PropertyAddress, U3DrawDebugSolidPlane_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidPlane_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidPlane_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidPlane_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidPlane_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugSolidPlane_IsValid = U3DrawDebugSolidPlane_FunctionAddress != IntPtr.Zero && U3DrawDebugSolidPlane_InWorld_IsValid && U3DrawDebugSolidPlane_P_IsValid && U3DrawDebugSolidPlane_Loc_IsValid && U3DrawDebugSolidPlane_Size_IsValid && U3DrawDebugSolidPlane_Color_IsValid && U3DrawDebugSolidPlane_bPersistent_IsValid && U3DrawDebugSolidPlane_LifeTime_IsValid && U3DrawDebugSolidPlane_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugSolidPlane", U3DrawDebugSolidPlane_IsValid);
		U3DrawDebugSolidBox3_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugSolidBox3");
		U3DrawDebugSolidBox3_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugSolidBox3_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_InWorld_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "InWorld");
		U3DrawDebugSolidBox3_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "InWorld");
		U3DrawDebugSolidBox3_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_Center_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "Center");
		U3DrawDebugSolidBox3_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "Center");
		U3DrawDebugSolidBox3_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_Extent_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "Extent");
		U3DrawDebugSolidBox3_Extent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "Extent");
		U3DrawDebugSolidBox3_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_Rotation_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "Rotation");
		U3DrawDebugSolidBox3_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "Rotation");
		U3DrawDebugSolidBox3_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_Color_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "Color");
		U3DrawDebugSolidBox3_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "Color");
		U3DrawDebugSolidBox3_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_bPersistent_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "bPersistent");
		U3DrawDebugSolidBox3_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "bPersistent");
		U3DrawDebugSolidBox3_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_LifeTime_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "LifeTime");
		U3DrawDebugSolidBox3_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "LifeTime");
		U3DrawDebugSolidBox3_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox3_DepthPriority_PropertyAddress, U3DrawDebugSolidBox3_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidBox3_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox3_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidBox3_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox3_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugSolidBox3_IsValid = U3DrawDebugSolidBox3_FunctionAddress != IntPtr.Zero && U3DrawDebugSolidBox3_InWorld_IsValid && U3DrawDebugSolidBox3_Center_IsValid && U3DrawDebugSolidBox3_Extent_IsValid && U3DrawDebugSolidBox3_Rotation_IsValid && U3DrawDebugSolidBox3_Color_IsValid && U3DrawDebugSolidBox3_bPersistent_IsValid && U3DrawDebugSolidBox3_LifeTime_IsValid && U3DrawDebugSolidBox3_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox3", U3DrawDebugSolidBox3_IsValid);
		U3DrawDebugSolidBox2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugSolidBox2");
		U3DrawDebugSolidBox2_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugSolidBox2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox2_InWorld_PropertyAddress, U3DrawDebugSolidBox2_FunctionAddress, "InWorld");
		U3DrawDebugSolidBox2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox2_FunctionAddress, "InWorld");
		U3DrawDebugSolidBox2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox2_Center_PropertyAddress, U3DrawDebugSolidBox2_FunctionAddress, "Center");
		U3DrawDebugSolidBox2_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox2_FunctionAddress, "Center");
		U3DrawDebugSolidBox2_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox2_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox2_Extent_PropertyAddress, U3DrawDebugSolidBox2_FunctionAddress, "Extent");
		U3DrawDebugSolidBox2_Extent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox2_FunctionAddress, "Extent");
		U3DrawDebugSolidBox2_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox2_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox2_Color_PropertyAddress, U3DrawDebugSolidBox2_FunctionAddress, "Color");
		U3DrawDebugSolidBox2_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox2_FunctionAddress, "Color");
		U3DrawDebugSolidBox2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox2_bPersistent_PropertyAddress, U3DrawDebugSolidBox2_FunctionAddress, "bPersistent");
		U3DrawDebugSolidBox2_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox2_FunctionAddress, "bPersistent");
		U3DrawDebugSolidBox2_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox2_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox2_LifeTime_PropertyAddress, U3DrawDebugSolidBox2_FunctionAddress, "LifeTime");
		U3DrawDebugSolidBox2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox2_FunctionAddress, "LifeTime");
		U3DrawDebugSolidBox2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox2_DepthPriority_PropertyAddress, U3DrawDebugSolidBox2_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidBox2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox2_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidBox2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugSolidBox2_IsValid = U3DrawDebugSolidBox2_FunctionAddress != IntPtr.Zero && U3DrawDebugSolidBox2_InWorld_IsValid && U3DrawDebugSolidBox2_Center_IsValid && U3DrawDebugSolidBox2_Extent_IsValid && U3DrawDebugSolidBox2_Color_IsValid && U3DrawDebugSolidBox2_bPersistent_IsValid && U3DrawDebugSolidBox2_LifeTime_IsValid && U3DrawDebugSolidBox2_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox2", U3DrawDebugSolidBox2_IsValid);
		U3DrawDebugSolidBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugSolidBox");
		U3DrawDebugSolidBox_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugSolidBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox_InWorld_PropertyAddress, U3DrawDebugSolidBox_FunctionAddress, "InWorld");
		U3DrawDebugSolidBox_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox_FunctionAddress, "InWorld");
		U3DrawDebugSolidBox_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox_Box_PropertyAddress, U3DrawDebugSolidBox_FunctionAddress, "Box");
		U3DrawDebugSolidBox_Box_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox_FunctionAddress, "Box");
		U3DrawDebugSolidBox_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox_Color_PropertyAddress, U3DrawDebugSolidBox_FunctionAddress, "Color");
		U3DrawDebugSolidBox_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox_FunctionAddress, "Color");
		U3DrawDebugSolidBox_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox_Transform_PropertyAddress, U3DrawDebugSolidBox_FunctionAddress, "Transform");
		U3DrawDebugSolidBox_Transform_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox_FunctionAddress, "Transform");
		U3DrawDebugSolidBox_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox_bPersistent_PropertyAddress, U3DrawDebugSolidBox_FunctionAddress, "bPersistent");
		U3DrawDebugSolidBox_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox_FunctionAddress, "bPersistent");
		U3DrawDebugSolidBox_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox_LifeTime_PropertyAddress, U3DrawDebugSolidBox_FunctionAddress, "LifeTime");
		U3DrawDebugSolidBox_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox_FunctionAddress, "LifeTime");
		U3DrawDebugSolidBox_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugSolidBox_DepthPriority_PropertyAddress, U3DrawDebugSolidBox_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidBox_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugSolidBox_FunctionAddress, "DepthPriority");
		U3DrawDebugSolidBox_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugSolidBox_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugSolidBox_IsValid = U3DrawDebugSolidBox_FunctionAddress != IntPtr.Zero && U3DrawDebugSolidBox_InWorld_IsValid && U3DrawDebugSolidBox_Box_IsValid && U3DrawDebugSolidBox_Color_IsValid && U3DrawDebugSolidBox_Transform_IsValid && U3DrawDebugSolidBox_bPersistent_IsValid && U3DrawDebugSolidBox_LifeTime_IsValid && U3DrawDebugSolidBox_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugSolidBox", U3DrawDebugSolidBox_IsValid);
		U3DrawDebugPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugPoint");
		U3DrawDebugPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugPoint_InWorld_PropertyAddress, U3DrawDebugPoint_FunctionAddress, "InWorld");
		U3DrawDebugPoint_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugPoint_FunctionAddress, "InWorld");
		U3DrawDebugPoint_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugPoint_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugPoint_Position_PropertyAddress, U3DrawDebugPoint_FunctionAddress, "Position");
		U3DrawDebugPoint_Position_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugPoint_FunctionAddress, "Position");
		U3DrawDebugPoint_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugPoint_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugPoint_Size_PropertyAddress, U3DrawDebugPoint_FunctionAddress, "Size");
		U3DrawDebugPoint_Size_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugPoint_FunctionAddress, "Size");
		U3DrawDebugPoint_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugPoint_FunctionAddress, "Size", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugPoint_PointColor_PropertyAddress, U3DrawDebugPoint_FunctionAddress, "PointColor");
		U3DrawDebugPoint_PointColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugPoint_FunctionAddress, "PointColor");
		U3DrawDebugPoint_PointColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugPoint_FunctionAddress, "PointColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugPoint_bPersistentLines_PropertyAddress, U3DrawDebugPoint_FunctionAddress, "bPersistentLines");
		U3DrawDebugPoint_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugPoint_FunctionAddress, "bPersistentLines");
		U3DrawDebugPoint_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugPoint_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugPoint_LifeTime_PropertyAddress, U3DrawDebugPoint_FunctionAddress, "LifeTime");
		U3DrawDebugPoint_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugPoint_FunctionAddress, "LifeTime");
		U3DrawDebugPoint_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugPoint_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugPoint_DepthPriority_PropertyAddress, U3DrawDebugPoint_FunctionAddress, "DepthPriority");
		U3DrawDebugPoint_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugPoint_FunctionAddress, "DepthPriority");
		U3DrawDebugPoint_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugPoint_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugPoint_IsValid = U3DrawDebugPoint_FunctionAddress != IntPtr.Zero && U3DrawDebugPoint_InWorld_IsValid && U3DrawDebugPoint_Position_IsValid && U3DrawDebugPoint_Size_IsValid && U3DrawDebugPoint_PointColor_IsValid && U3DrawDebugPoint_bPersistentLines_IsValid && U3DrawDebugPoint_LifeTime_IsValid && U3DrawDebugPoint_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugPoint", U3DrawDebugPoint_IsValid);
		U3DrawDebugMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugMesh");
		U3DrawDebugMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugMesh_InWorld_PropertyAddress, U3DrawDebugMesh_FunctionAddress, "InWorld");
		U3DrawDebugMesh_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugMesh_FunctionAddress, "InWorld");
		U3DrawDebugMesh_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugMesh_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugMesh_Verts_PropertyAddress, U3DrawDebugMesh_FunctionAddress, "Verts");
		U3DrawDebugMesh_Verts_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugMesh_FunctionAddress, "Verts");
		U3DrawDebugMesh_Verts_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugMesh_FunctionAddress, "Verts", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugMesh_Indices_PropertyAddress, U3DrawDebugMesh_FunctionAddress, "Indices");
		U3DrawDebugMesh_Indices_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugMesh_FunctionAddress, "Indices");
		U3DrawDebugMesh_Indices_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugMesh_FunctionAddress, "Indices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugMesh_Color_PropertyAddress, U3DrawDebugMesh_FunctionAddress, "Color");
		U3DrawDebugMesh_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugMesh_FunctionAddress, "Color");
		U3DrawDebugMesh_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugMesh_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugMesh_bPersistent_PropertyAddress, U3DrawDebugMesh_FunctionAddress, "bPersistent");
		U3DrawDebugMesh_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugMesh_FunctionAddress, "bPersistent");
		U3DrawDebugMesh_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugMesh_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugMesh_LifeTime_PropertyAddress, U3DrawDebugMesh_FunctionAddress, "LifeTime");
		U3DrawDebugMesh_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugMesh_FunctionAddress, "LifeTime");
		U3DrawDebugMesh_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugMesh_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugMesh_DepthPriority_PropertyAddress, U3DrawDebugMesh_FunctionAddress, "DepthPriority");
		U3DrawDebugMesh_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugMesh_FunctionAddress, "DepthPriority");
		U3DrawDebugMesh_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugMesh_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugMesh_IsValid = U3DrawDebugMesh_FunctionAddress != IntPtr.Zero && U3DrawDebugMesh_InWorld_IsValid && U3DrawDebugMesh_Verts_IsValid && U3DrawDebugMesh_Indices_IsValid && U3DrawDebugMesh_Color_IsValid && U3DrawDebugMesh_bPersistent_IsValid && U3DrawDebugMesh_LifeTime_IsValid && U3DrawDebugMesh_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugMesh", U3DrawDebugMesh_IsValid);
		U3DrawDebugLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugLine");
		U3DrawDebugLine_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_InWorld_PropertyAddress, U3DrawDebugLine_FunctionAddress, "InWorld");
		U3DrawDebugLine_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "InWorld");
		U3DrawDebugLine_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_LineStart_PropertyAddress, U3DrawDebugLine_FunctionAddress, "LineStart");
		U3DrawDebugLine_LineStart_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "LineStart");
		U3DrawDebugLine_LineStart_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "LineStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_LineEnd_PropertyAddress, U3DrawDebugLine_FunctionAddress, "LineEnd");
		U3DrawDebugLine_LineEnd_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "LineEnd");
		U3DrawDebugLine_LineEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "LineEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_Color_PropertyAddress, U3DrawDebugLine_FunctionAddress, "Color");
		U3DrawDebugLine_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "Color");
		U3DrawDebugLine_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_bPersistentLines_PropertyAddress, U3DrawDebugLine_FunctionAddress, "bPersistentLines");
		U3DrawDebugLine_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "bPersistentLines");
		U3DrawDebugLine_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_LifeTime_PropertyAddress, U3DrawDebugLine_FunctionAddress, "LifeTime");
		U3DrawDebugLine_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "LifeTime");
		U3DrawDebugLine_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_DepthPriority_PropertyAddress, U3DrawDebugLine_FunctionAddress, "DepthPriority");
		U3DrawDebugLine_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "DepthPriority");
		U3DrawDebugLine_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugLine_Thickness_PropertyAddress, U3DrawDebugLine_FunctionAddress, "Thickness");
		U3DrawDebugLine_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugLine_FunctionAddress, "Thickness");
		U3DrawDebugLine_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugLine_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugLine_IsValid = U3DrawDebugLine_FunctionAddress != IntPtr.Zero && U3DrawDebugLine_InWorld_IsValid && U3DrawDebugLine_LineStart_IsValid && U3DrawDebugLine_LineEnd_IsValid && U3DrawDebugLine_Color_IsValid && U3DrawDebugLine_bPersistentLines_IsValid && U3DrawDebugLine_LifeTime_IsValid && U3DrawDebugLine_DepthPriority_IsValid && U3DrawDebugLine_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugLine", U3DrawDebugLine_IsValid);
		U3DrawDebugFrustum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugFrustum");
		U3DrawDebugFrustum_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugFrustum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugFrustum_InWorld_PropertyAddress, U3DrawDebugFrustum_FunctionAddress, "InWorld");
		U3DrawDebugFrustum_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugFrustum_FunctionAddress, "InWorld");
		U3DrawDebugFrustum_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugFrustum_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugFrustum_FrustumToWorld_PropertyAddress, U3DrawDebugFrustum_FunctionAddress, "FrustumToWorld");
		U3DrawDebugFrustum_FrustumToWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugFrustum_FunctionAddress, "FrustumToWorld");
		U3DrawDebugFrustum_FrustumToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugFrustum_FunctionAddress, "FrustumToWorld", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugFrustum_Color_PropertyAddress, U3DrawDebugFrustum_FunctionAddress, "Color");
		U3DrawDebugFrustum_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugFrustum_FunctionAddress, "Color");
		U3DrawDebugFrustum_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugFrustum_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugFrustum_bPersistentLines_PropertyAddress, U3DrawDebugFrustum_FunctionAddress, "bPersistentLines");
		U3DrawDebugFrustum_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugFrustum_FunctionAddress, "bPersistentLines");
		U3DrawDebugFrustum_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugFrustum_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugFrustum_LifeTime_PropertyAddress, U3DrawDebugFrustum_FunctionAddress, "LifeTime");
		U3DrawDebugFrustum_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugFrustum_FunctionAddress, "LifeTime");
		U3DrawDebugFrustum_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugFrustum_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugFrustum_DepthPriority_PropertyAddress, U3DrawDebugFrustum_FunctionAddress, "DepthPriority");
		U3DrawDebugFrustum_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugFrustum_FunctionAddress, "DepthPriority");
		U3DrawDebugFrustum_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugFrustum_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugFrustum_Thickness_PropertyAddress, U3DrawDebugFrustum_FunctionAddress, "Thickness");
		U3DrawDebugFrustum_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugFrustum_FunctionAddress, "Thickness");
		U3DrawDebugFrustum_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugFrustum_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugFrustum_IsValid = U3DrawDebugFrustum_FunctionAddress != IntPtr.Zero && U3DrawDebugFrustum_InWorld_IsValid && U3DrawDebugFrustum_FrustumToWorld_IsValid && U3DrawDebugFrustum_Color_IsValid && U3DrawDebugFrustum_bPersistentLines_IsValid && U3DrawDebugFrustum_LifeTime_IsValid && U3DrawDebugFrustum_DepthPriority_IsValid && U3DrawDebugFrustum_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugFrustum", U3DrawDebugFrustum_IsValid);
		U3DrawDebugDirectionalArrow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugDirectionalArrow");
		U3DrawDebugDirectionalArrow_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugDirectionalArrow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_InWorld_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "InWorld");
		U3DrawDebugDirectionalArrow_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "InWorld");
		U3DrawDebugDirectionalArrow_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_LineStart_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "LineStart");
		U3DrawDebugDirectionalArrow_LineStart_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "LineStart");
		U3DrawDebugDirectionalArrow_LineStart_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "LineStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_LineEnd_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "LineEnd");
		U3DrawDebugDirectionalArrow_LineEnd_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "LineEnd");
		U3DrawDebugDirectionalArrow_LineEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "LineEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_ArrowSize_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "ArrowSize");
		U3DrawDebugDirectionalArrow_ArrowSize_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "ArrowSize");
		U3DrawDebugDirectionalArrow_ArrowSize_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "ArrowSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_Color_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "Color");
		U3DrawDebugDirectionalArrow_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "Color");
		U3DrawDebugDirectionalArrow_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_bPersistentLines_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "bPersistentLines");
		U3DrawDebugDirectionalArrow_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "bPersistentLines");
		U3DrawDebugDirectionalArrow_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_LifeTime_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "LifeTime");
		U3DrawDebugDirectionalArrow_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "LifeTime");
		U3DrawDebugDirectionalArrow_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_DepthPriority_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "DepthPriority");
		U3DrawDebugDirectionalArrow_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "DepthPriority");
		U3DrawDebugDirectionalArrow_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugDirectionalArrow_Thickness_PropertyAddress, U3DrawDebugDirectionalArrow_FunctionAddress, "Thickness");
		U3DrawDebugDirectionalArrow_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugDirectionalArrow_FunctionAddress, "Thickness");
		U3DrawDebugDirectionalArrow_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugDirectionalArrow_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugDirectionalArrow_IsValid = U3DrawDebugDirectionalArrow_FunctionAddress != IntPtr.Zero && U3DrawDebugDirectionalArrow_InWorld_IsValid && U3DrawDebugDirectionalArrow_LineStart_IsValid && U3DrawDebugDirectionalArrow_LineEnd_IsValid && U3DrawDebugDirectionalArrow_ArrowSize_IsValid && U3DrawDebugDirectionalArrow_Color_IsValid && U3DrawDebugDirectionalArrow_bPersistentLines_IsValid && U3DrawDebugDirectionalArrow_LifeTime_IsValid && U3DrawDebugDirectionalArrow_DepthPriority_IsValid && U3DrawDebugDirectionalArrow_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugDirectionalArrow", U3DrawDebugDirectionalArrow_IsValid);
		U3DrawDebugCylinder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCylinder");
		U3DrawDebugCylinder_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCylinder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_InWorld_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "InWorld");
		U3DrawDebugCylinder_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "InWorld");
		U3DrawDebugCylinder_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_Start_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "Start");
		U3DrawDebugCylinder_Start_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "Start");
		U3DrawDebugCylinder_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_End_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "End");
		U3DrawDebugCylinder_End_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "End");
		U3DrawDebugCylinder_End_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_Radius_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "Radius");
		U3DrawDebugCylinder_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "Radius");
		U3DrawDebugCylinder_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_Segments_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "Segments");
		U3DrawDebugCylinder_Segments_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "Segments");
		U3DrawDebugCylinder_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_Color_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "Color");
		U3DrawDebugCylinder_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "Color");
		U3DrawDebugCylinder_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_bPersistentLines_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "bPersistentLines");
		U3DrawDebugCylinder_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "bPersistentLines");
		U3DrawDebugCylinder_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_LifeTime_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "LifeTime");
		U3DrawDebugCylinder_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "LifeTime");
		U3DrawDebugCylinder_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_DepthPriority_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "DepthPriority");
		U3DrawDebugCylinder_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "DepthPriority");
		U3DrawDebugCylinder_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCylinder_Thickness_PropertyAddress, U3DrawDebugCylinder_FunctionAddress, "Thickness");
		U3DrawDebugCylinder_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCylinder_FunctionAddress, "Thickness");
		U3DrawDebugCylinder_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCylinder_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugCylinder_IsValid = U3DrawDebugCylinder_FunctionAddress != IntPtr.Zero && U3DrawDebugCylinder_InWorld_IsValid && U3DrawDebugCylinder_Start_IsValid && U3DrawDebugCylinder_End_IsValid && U3DrawDebugCylinder_Radius_IsValid && U3DrawDebugCylinder_Segments_IsValid && U3DrawDebugCylinder_Color_IsValid && U3DrawDebugCylinder_bPersistentLines_IsValid && U3DrawDebugCylinder_LifeTime_IsValid && U3DrawDebugCylinder_DepthPriority_IsValid && U3DrawDebugCylinder_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCylinder", U3DrawDebugCylinder_IsValid);
		U3DrawDebugCrosshairs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCrosshairs");
		U3DrawDebugCrosshairs_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCrosshairs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_InWorld_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "InWorld");
		U3DrawDebugCrosshairs_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "InWorld");
		U3DrawDebugCrosshairs_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_AxisLoc_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "AxisLoc");
		U3DrawDebugCrosshairs_AxisLoc_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "AxisLoc");
		U3DrawDebugCrosshairs_AxisLoc_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "AxisLoc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_AxisRot_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "AxisRot");
		U3DrawDebugCrosshairs_AxisRot_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "AxisRot");
		U3DrawDebugCrosshairs_AxisRot_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "AxisRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_Scale_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "Scale");
		U3DrawDebugCrosshairs_Scale_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "Scale");
		U3DrawDebugCrosshairs_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_Color_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "Color");
		U3DrawDebugCrosshairs_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "Color");
		U3DrawDebugCrosshairs_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_bPersistentLines_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "bPersistentLines");
		U3DrawDebugCrosshairs_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "bPersistentLines");
		U3DrawDebugCrosshairs_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_LifeTime_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "LifeTime");
		U3DrawDebugCrosshairs_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "LifeTime");
		U3DrawDebugCrosshairs_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCrosshairs_DepthPriority_PropertyAddress, U3DrawDebugCrosshairs_FunctionAddress, "DepthPriority");
		U3DrawDebugCrosshairs_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCrosshairs_FunctionAddress, "DepthPriority");
		U3DrawDebugCrosshairs_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCrosshairs_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugCrosshairs_IsValid = U3DrawDebugCrosshairs_FunctionAddress != IntPtr.Zero && U3DrawDebugCrosshairs_InWorld_IsValid && U3DrawDebugCrosshairs_AxisLoc_IsValid && U3DrawDebugCrosshairs_AxisRot_IsValid && U3DrawDebugCrosshairs_Scale_IsValid && U3DrawDebugCrosshairs_Color_IsValid && U3DrawDebugCrosshairs_bPersistentLines_IsValid && U3DrawDebugCrosshairs_LifeTime_IsValid && U3DrawDebugCrosshairs_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCrosshairs", U3DrawDebugCrosshairs_IsValid);
		U3DrawDebugCoordinateSystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCoordinateSystem");
		U3DrawDebugCoordinateSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCoordinateSystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_InWorld_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "InWorld");
		U3DrawDebugCoordinateSystem_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "InWorld");
		U3DrawDebugCoordinateSystem_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_AxisLoc_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "AxisLoc");
		U3DrawDebugCoordinateSystem_AxisLoc_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "AxisLoc");
		U3DrawDebugCoordinateSystem_AxisLoc_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "AxisLoc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_AxisRot_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "AxisRot");
		U3DrawDebugCoordinateSystem_AxisRot_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "AxisRot");
		U3DrawDebugCoordinateSystem_AxisRot_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "AxisRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_Scale_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "Scale");
		U3DrawDebugCoordinateSystem_Scale_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "Scale");
		U3DrawDebugCoordinateSystem_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_bPersistentLines_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "bPersistentLines");
		U3DrawDebugCoordinateSystem_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "bPersistentLines");
		U3DrawDebugCoordinateSystem_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_LifeTime_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "LifeTime");
		U3DrawDebugCoordinateSystem_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "LifeTime");
		U3DrawDebugCoordinateSystem_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_DepthPriority_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "DepthPriority");
		U3DrawDebugCoordinateSystem_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "DepthPriority");
		U3DrawDebugCoordinateSystem_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCoordinateSystem_Thickness_PropertyAddress, U3DrawDebugCoordinateSystem_FunctionAddress, "Thickness");
		U3DrawDebugCoordinateSystem_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCoordinateSystem_FunctionAddress, "Thickness");
		U3DrawDebugCoordinateSystem_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCoordinateSystem_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugCoordinateSystem_IsValid = U3DrawDebugCoordinateSystem_FunctionAddress != IntPtr.Zero && U3DrawDebugCoordinateSystem_InWorld_IsValid && U3DrawDebugCoordinateSystem_AxisLoc_IsValid && U3DrawDebugCoordinateSystem_AxisRot_IsValid && U3DrawDebugCoordinateSystem_Scale_IsValid && U3DrawDebugCoordinateSystem_bPersistentLines_IsValid && U3DrawDebugCoordinateSystem_LifeTime_IsValid && U3DrawDebugCoordinateSystem_DepthPriority_IsValid && U3DrawDebugCoordinateSystem_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCoordinateSystem", U3DrawDebugCoordinateSystem_IsValid);
		U3DrawDebugCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCone");
		U3DrawDebugCone_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_InWorld_PropertyAddress, U3DrawDebugCone_FunctionAddress, "InWorld");
		U3DrawDebugCone_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "InWorld");
		U3DrawDebugCone_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_Origin_PropertyAddress, U3DrawDebugCone_FunctionAddress, "Origin");
		U3DrawDebugCone_Origin_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "Origin");
		U3DrawDebugCone_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_Direction_PropertyAddress, U3DrawDebugCone_FunctionAddress, "Direction");
		U3DrawDebugCone_Direction_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "Direction");
		U3DrawDebugCone_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_Length_PropertyAddress, U3DrawDebugCone_FunctionAddress, "Length");
		U3DrawDebugCone_Length_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "Length");
		U3DrawDebugCone_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_AngleWidth_PropertyAddress, U3DrawDebugCone_FunctionAddress, "AngleWidth");
		U3DrawDebugCone_AngleWidth_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "AngleWidth");
		U3DrawDebugCone_AngleWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "AngleWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_AngleHeight_PropertyAddress, U3DrawDebugCone_FunctionAddress, "AngleHeight");
		U3DrawDebugCone_AngleHeight_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "AngleHeight");
		U3DrawDebugCone_AngleHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "AngleHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_NumSides_PropertyAddress, U3DrawDebugCone_FunctionAddress, "NumSides");
		U3DrawDebugCone_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "NumSides");
		U3DrawDebugCone_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_Color_PropertyAddress, U3DrawDebugCone_FunctionAddress, "Color");
		U3DrawDebugCone_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "Color");
		U3DrawDebugCone_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_bPersistentLines_PropertyAddress, U3DrawDebugCone_FunctionAddress, "bPersistentLines");
		U3DrawDebugCone_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "bPersistentLines");
		U3DrawDebugCone_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_LifeTime_PropertyAddress, U3DrawDebugCone_FunctionAddress, "LifeTime");
		U3DrawDebugCone_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "LifeTime");
		U3DrawDebugCone_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_DepthPriority_PropertyAddress, U3DrawDebugCone_FunctionAddress, "DepthPriority");
		U3DrawDebugCone_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "DepthPriority");
		U3DrawDebugCone_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCone_Thickness_PropertyAddress, U3DrawDebugCone_FunctionAddress, "Thickness");
		U3DrawDebugCone_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCone_FunctionAddress, "Thickness");
		U3DrawDebugCone_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCone_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugCone_IsValid = U3DrawDebugCone_FunctionAddress != IntPtr.Zero && U3DrawDebugCone_InWorld_IsValid && U3DrawDebugCone_Origin_IsValid && U3DrawDebugCone_Direction_IsValid && U3DrawDebugCone_Length_IsValid && U3DrawDebugCone_AngleWidth_IsValid && U3DrawDebugCone_AngleHeight_IsValid && U3DrawDebugCone_NumSides_IsValid && U3DrawDebugCone_Color_IsValid && U3DrawDebugCone_bPersistentLines_IsValid && U3DrawDebugCone_LifeTime_IsValid && U3DrawDebugCone_DepthPriority_IsValid && U3DrawDebugCone_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCone", U3DrawDebugCone_IsValid);
		U3DrawDebugCircle2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCircle2");
		U3DrawDebugCircle2_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCircle2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_InWorld_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "InWorld");
		U3DrawDebugCircle2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "InWorld");
		U3DrawDebugCircle2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_Center_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "Center");
		U3DrawDebugCircle2_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "Center");
		U3DrawDebugCircle2_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_Radius_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "Radius");
		U3DrawDebugCircle2_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "Radius");
		U3DrawDebugCircle2_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_Segments_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "Segments");
		U3DrawDebugCircle2_Segments_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "Segments");
		U3DrawDebugCircle2_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_Color_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "Color");
		U3DrawDebugCircle2_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "Color");
		U3DrawDebugCircle2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_bPersistentLines_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "bPersistentLines");
		U3DrawDebugCircle2_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "bPersistentLines");
		U3DrawDebugCircle2_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_LifeTime_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "LifeTime");
		U3DrawDebugCircle2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "LifeTime");
		U3DrawDebugCircle2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_DepthPriority_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "DepthPriority");
		U3DrawDebugCircle2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "DepthPriority");
		U3DrawDebugCircle2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_Thickness_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "Thickness");
		U3DrawDebugCircle2_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "Thickness");
		U3DrawDebugCircle2_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_YAxis_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "YAxis");
		U3DrawDebugCircle2_YAxis_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "YAxis");
		U3DrawDebugCircle2_YAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "YAxis", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_ZAxis_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "ZAxis");
		U3DrawDebugCircle2_ZAxis_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "ZAxis");
		U3DrawDebugCircle2_ZAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "ZAxis", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle2_bDrawAxis_PropertyAddress, U3DrawDebugCircle2_FunctionAddress, "bDrawAxis");
		U3DrawDebugCircle2_bDrawAxis_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle2_FunctionAddress, "bDrawAxis");
		U3DrawDebugCircle2_bDrawAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle2_FunctionAddress, "bDrawAxis", Classes.FBoolProperty);
		U3DrawDebugCircle2_IsValid = U3DrawDebugCircle2_FunctionAddress != IntPtr.Zero && U3DrawDebugCircle2_InWorld_IsValid && U3DrawDebugCircle2_Center_IsValid && U3DrawDebugCircle2_Radius_IsValid && U3DrawDebugCircle2_Segments_IsValid && U3DrawDebugCircle2_Color_IsValid && U3DrawDebugCircle2_bPersistentLines_IsValid && U3DrawDebugCircle2_LifeTime_IsValid && U3DrawDebugCircle2_DepthPriority_IsValid && U3DrawDebugCircle2_Thickness_IsValid && U3DrawDebugCircle2_YAxis_IsValid && U3DrawDebugCircle2_ZAxis_IsValid && U3DrawDebugCircle2_bDrawAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCircle2", U3DrawDebugCircle2_IsValid);
		U3DrawDebugCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCircle");
		U3DrawDebugCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_InWorld_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "InWorld");
		U3DrawDebugCircle_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "InWorld");
		U3DrawDebugCircle_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_TransformMatrix_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "TransformMatrix");
		U3DrawDebugCircle_TransformMatrix_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "TransformMatrix");
		U3DrawDebugCircle_TransformMatrix_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "TransformMatrix", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_Radius_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "Radius");
		U3DrawDebugCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "Radius");
		U3DrawDebugCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_Segments_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "Segments");
		U3DrawDebugCircle_Segments_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "Segments");
		U3DrawDebugCircle_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_Color_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "Color");
		U3DrawDebugCircle_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "Color");
		U3DrawDebugCircle_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_bPersistentLines_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "bPersistentLines");
		U3DrawDebugCircle_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "bPersistentLines");
		U3DrawDebugCircle_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_LifeTime_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "LifeTime");
		U3DrawDebugCircle_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "LifeTime");
		U3DrawDebugCircle_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_DepthPriority_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "DepthPriority");
		U3DrawDebugCircle_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "DepthPriority");
		U3DrawDebugCircle_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_Thickness_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "Thickness");
		U3DrawDebugCircle_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "Thickness");
		U3DrawDebugCircle_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCircle_bDrawAxis_PropertyAddress, U3DrawDebugCircle_FunctionAddress, "bDrawAxis");
		U3DrawDebugCircle_bDrawAxis_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCircle_FunctionAddress, "bDrawAxis");
		U3DrawDebugCircle_bDrawAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCircle_FunctionAddress, "bDrawAxis", Classes.FBoolProperty);
		U3DrawDebugCircle_IsValid = U3DrawDebugCircle_FunctionAddress != IntPtr.Zero && U3DrawDebugCircle_InWorld_IsValid && U3DrawDebugCircle_TransformMatrix_IsValid && U3DrawDebugCircle_Radius_IsValid && U3DrawDebugCircle_Segments_IsValid && U3DrawDebugCircle_Color_IsValid && U3DrawDebugCircle_bPersistentLines_IsValid && U3DrawDebugCircle_LifeTime_IsValid && U3DrawDebugCircle_DepthPriority_IsValid && U3DrawDebugCircle_Thickness_IsValid && U3DrawDebugCircle_bDrawAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCircle", U3DrawDebugCircle_IsValid);
		U3DrawDebugCapsule_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCapsule");
		U3DrawDebugCapsule_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCapsule_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_InWorld_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "InWorld");
		U3DrawDebugCapsule_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "InWorld");
		U3DrawDebugCapsule_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_Center_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "Center");
		U3DrawDebugCapsule_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "Center");
		U3DrawDebugCapsule_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_HalfHeight_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "HalfHeight");
		U3DrawDebugCapsule_HalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "HalfHeight");
		U3DrawDebugCapsule_HalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "HalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_Radius_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "Radius");
		U3DrawDebugCapsule_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "Radius");
		U3DrawDebugCapsule_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_Rotation_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "Rotation");
		U3DrawDebugCapsule_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "Rotation");
		U3DrawDebugCapsule_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_Color_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "Color");
		U3DrawDebugCapsule_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "Color");
		U3DrawDebugCapsule_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_bPersistentLines_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "bPersistentLines");
		U3DrawDebugCapsule_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "bPersistentLines");
		U3DrawDebugCapsule_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_LifeTime_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "LifeTime");
		U3DrawDebugCapsule_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "LifeTime");
		U3DrawDebugCapsule_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_DepthPriority_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "DepthPriority");
		U3DrawDebugCapsule_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "DepthPriority");
		U3DrawDebugCapsule_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCapsule_Thickness_PropertyAddress, U3DrawDebugCapsule_FunctionAddress, "Thickness");
		U3DrawDebugCapsule_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCapsule_FunctionAddress, "Thickness");
		U3DrawDebugCapsule_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCapsule_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugCapsule_IsValid = U3DrawDebugCapsule_FunctionAddress != IntPtr.Zero && U3DrawDebugCapsule_InWorld_IsValid && U3DrawDebugCapsule_Center_IsValid && U3DrawDebugCapsule_HalfHeight_IsValid && U3DrawDebugCapsule_Radius_IsValid && U3DrawDebugCapsule_Rotation_IsValid && U3DrawDebugCapsule_Color_IsValid && U3DrawDebugCapsule_bPersistentLines_IsValid && U3DrawDebugCapsule_LifeTime_IsValid && U3DrawDebugCapsule_DepthPriority_IsValid && U3DrawDebugCapsule_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCapsule", U3DrawDebugCapsule_IsValid);
		U3DrawDebugCanvasWireSphere_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvasWireSphere");
		U3DrawDebugCanvasWireSphere_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvasWireSphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireSphere_Canvas_PropertyAddress, U3DrawDebugCanvasWireSphere_FunctionAddress, "Canvas");
		U3DrawDebugCanvasWireSphere_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireSphere_FunctionAddress, "Canvas");
		U3DrawDebugCanvasWireSphere_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireSphere_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireSphere_Base_PropertyAddress, U3DrawDebugCanvasWireSphere_FunctionAddress, "Base");
		U3DrawDebugCanvasWireSphere_Base_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireSphere_FunctionAddress, "Base");
		U3DrawDebugCanvasWireSphere_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireSphere_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireSphere_Color_PropertyAddress, U3DrawDebugCanvasWireSphere_FunctionAddress, "Color");
		U3DrawDebugCanvasWireSphere_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireSphere_FunctionAddress, "Color");
		U3DrawDebugCanvasWireSphere_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireSphere_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireSphere_Radius_PropertyAddress, U3DrawDebugCanvasWireSphere_FunctionAddress, "Radius");
		U3DrawDebugCanvasWireSphere_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireSphere_FunctionAddress, "Radius");
		U3DrawDebugCanvasWireSphere_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireSphere_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireSphere_NumSides_PropertyAddress, U3DrawDebugCanvasWireSphere_FunctionAddress, "NumSides");
		U3DrawDebugCanvasWireSphere_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireSphere_FunctionAddress, "NumSides");
		U3DrawDebugCanvasWireSphere_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireSphere_FunctionAddress, "NumSides", Classes.FIntProperty);
		U3DrawDebugCanvasWireSphere_IsValid = U3DrawDebugCanvasWireSphere_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvasWireSphere_Canvas_IsValid && U3DrawDebugCanvasWireSphere_Base_IsValid && U3DrawDebugCanvasWireSphere_Color_IsValid && U3DrawDebugCanvasWireSphere_Radius_IsValid && U3DrawDebugCanvasWireSphere_NumSides_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvasWireSphere", U3DrawDebugCanvasWireSphere_IsValid);
		U3DrawDebugCanvasWireCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvasWireCone");
		U3DrawDebugCanvasWireCone_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvasWireCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireCone_Canvas_PropertyAddress, U3DrawDebugCanvasWireCone_FunctionAddress, "Canvas");
		U3DrawDebugCanvasWireCone_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireCone_FunctionAddress, "Canvas");
		U3DrawDebugCanvasWireCone_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireCone_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireCone_Transform_PropertyAddress, U3DrawDebugCanvasWireCone_FunctionAddress, "Transform");
		U3DrawDebugCanvasWireCone_Transform_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireCone_FunctionAddress, "Transform");
		U3DrawDebugCanvasWireCone_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireCone_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireCone_ConeRadius_PropertyAddress, U3DrawDebugCanvasWireCone_FunctionAddress, "ConeRadius");
		U3DrawDebugCanvasWireCone_ConeRadius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireCone_FunctionAddress, "ConeRadius");
		U3DrawDebugCanvasWireCone_ConeRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireCone_FunctionAddress, "ConeRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireCone_ConeAngle_PropertyAddress, U3DrawDebugCanvasWireCone_FunctionAddress, "ConeAngle");
		U3DrawDebugCanvasWireCone_ConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireCone_FunctionAddress, "ConeAngle");
		U3DrawDebugCanvasWireCone_ConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireCone_FunctionAddress, "ConeAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireCone_ConeSides_PropertyAddress, U3DrawDebugCanvasWireCone_FunctionAddress, "ConeSides");
		U3DrawDebugCanvasWireCone_ConeSides_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireCone_FunctionAddress, "ConeSides");
		U3DrawDebugCanvasWireCone_ConeSides_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireCone_FunctionAddress, "ConeSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasWireCone_Color_PropertyAddress, U3DrawDebugCanvasWireCone_FunctionAddress, "Color");
		U3DrawDebugCanvasWireCone_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasWireCone_FunctionAddress, "Color");
		U3DrawDebugCanvasWireCone_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasWireCone_FunctionAddress, "Color", Classes.FStructProperty);
		U3DrawDebugCanvasWireCone_IsValid = U3DrawDebugCanvasWireCone_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvasWireCone_Canvas_IsValid && U3DrawDebugCanvasWireCone_Transform_IsValid && U3DrawDebugCanvasWireCone_ConeRadius_IsValid && U3DrawDebugCanvasWireCone_ConeAngle_IsValid && U3DrawDebugCanvasWireCone_ConeSides_IsValid && U3DrawDebugCanvasWireCone_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvasWireCone", U3DrawDebugCanvasWireCone_IsValid);
		U3DrawDebugCanvasLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvasLine");
		U3DrawDebugCanvasLine_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvasLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasLine_Canvas_PropertyAddress, U3DrawDebugCanvasLine_FunctionAddress, "Canvas");
		U3DrawDebugCanvasLine_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasLine_FunctionAddress, "Canvas");
		U3DrawDebugCanvasLine_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasLine_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasLine_Start_PropertyAddress, U3DrawDebugCanvasLine_FunctionAddress, "Start");
		U3DrawDebugCanvasLine_Start_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasLine_FunctionAddress, "Start");
		U3DrawDebugCanvasLine_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasLine_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasLine_End_PropertyAddress, U3DrawDebugCanvasLine_FunctionAddress, "End");
		U3DrawDebugCanvasLine_End_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasLine_FunctionAddress, "End");
		U3DrawDebugCanvasLine_End_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasLine_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasLine_LineColor_PropertyAddress, U3DrawDebugCanvasLine_FunctionAddress, "LineColor");
		U3DrawDebugCanvasLine_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasLine_FunctionAddress, "LineColor");
		U3DrawDebugCanvasLine_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasLine_FunctionAddress, "LineColor", Classes.FStructProperty);
		U3DrawDebugCanvasLine_IsValid = U3DrawDebugCanvasLine_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvasLine_Canvas_IsValid && U3DrawDebugCanvasLine_Start_IsValid && U3DrawDebugCanvasLine_End_IsValid && U3DrawDebugCanvasLine_LineColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvasLine", U3DrawDebugCanvasLine_IsValid);
		U3DrawDebugCanvasCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvasCircle");
		U3DrawDebugCanvasCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvasCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasCircle_Canvas_PropertyAddress, U3DrawDebugCanvasCircle_FunctionAddress, "Canvas");
		U3DrawDebugCanvasCircle_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasCircle_FunctionAddress, "Canvas");
		U3DrawDebugCanvasCircle_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasCircle_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasCircle_Base_PropertyAddress, U3DrawDebugCanvasCircle_FunctionAddress, "Base");
		U3DrawDebugCanvasCircle_Base_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasCircle_FunctionAddress, "Base");
		U3DrawDebugCanvasCircle_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasCircle_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasCircle_X_PropertyAddress, U3DrawDebugCanvasCircle_FunctionAddress, "X");
		U3DrawDebugCanvasCircle_X_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasCircle_FunctionAddress, "X");
		U3DrawDebugCanvasCircle_X_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasCircle_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasCircle_Y_PropertyAddress, U3DrawDebugCanvasCircle_FunctionAddress, "Y");
		U3DrawDebugCanvasCircle_Y_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasCircle_FunctionAddress, "Y");
		U3DrawDebugCanvasCircle_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasCircle_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasCircle_Color_PropertyAddress, U3DrawDebugCanvasCircle_FunctionAddress, "Color");
		U3DrawDebugCanvasCircle_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasCircle_FunctionAddress, "Color");
		U3DrawDebugCanvasCircle_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasCircle_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasCircle_Radius_PropertyAddress, U3DrawDebugCanvasCircle_FunctionAddress, "Radius");
		U3DrawDebugCanvasCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasCircle_FunctionAddress, "Radius");
		U3DrawDebugCanvasCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvasCircle_NumSides_PropertyAddress, U3DrawDebugCanvasCircle_FunctionAddress, "NumSides");
		U3DrawDebugCanvasCircle_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvasCircle_FunctionAddress, "NumSides");
		U3DrawDebugCanvasCircle_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvasCircle_FunctionAddress, "NumSides", Classes.FIntProperty);
		U3DrawDebugCanvasCircle_IsValid = U3DrawDebugCanvasCircle_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvasCircle_Canvas_IsValid && U3DrawDebugCanvasCircle_Base_IsValid && U3DrawDebugCanvasCircle_X_IsValid && U3DrawDebugCanvasCircle_Y_IsValid && U3DrawDebugCanvasCircle_Color_IsValid && U3DrawDebugCanvasCircle_Radius_IsValid && U3DrawDebugCanvasCircle_NumSides_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvasCircle", U3DrawDebugCanvasCircle_IsValid);
		U3DrawDebugCanvas2DLine2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvas2DLine2");
		U3DrawDebugCanvas2DLine2_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvas2DLine2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine2_Canvas_PropertyAddress, U3DrawDebugCanvas2DLine2_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DLine2_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine2_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DLine2_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine2_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine2_StartPosition_PropertyAddress, U3DrawDebugCanvas2DLine2_FunctionAddress, "StartPosition");
		U3DrawDebugCanvas2DLine2_StartPosition_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine2_FunctionAddress, "StartPosition");
		U3DrawDebugCanvas2DLine2_StartPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine2_FunctionAddress, "StartPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine2_EndPosition_PropertyAddress, U3DrawDebugCanvas2DLine2_FunctionAddress, "EndPosition");
		U3DrawDebugCanvas2DLine2_EndPosition_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine2_FunctionAddress, "EndPosition");
		U3DrawDebugCanvas2DLine2_EndPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine2_FunctionAddress, "EndPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine2_LineColor_PropertyAddress, U3DrawDebugCanvas2DLine2_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DLine2_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine2_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DLine2_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine2_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine2_LineThickness_PropertyAddress, U3DrawDebugCanvas2DLine2_FunctionAddress, "LineThickness");
		U3DrawDebugCanvas2DLine2_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine2_FunctionAddress, "LineThickness");
		U3DrawDebugCanvas2DLine2_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine2_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		U3DrawDebugCanvas2DLine2_IsValid = U3DrawDebugCanvas2DLine2_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvas2DLine2_Canvas_IsValid && U3DrawDebugCanvas2DLine2_StartPosition_IsValid && U3DrawDebugCanvas2DLine2_EndPosition_IsValid && U3DrawDebugCanvas2DLine2_LineColor_IsValid && U3DrawDebugCanvas2DLine2_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DLine2", U3DrawDebugCanvas2DLine2_IsValid);
		U3DrawDebugCanvas2DLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvas2DLine");
		U3DrawDebugCanvas2DLine_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvas2DLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine_Canvas_PropertyAddress, U3DrawDebugCanvas2DLine_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DLine_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DLine_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine_Start_PropertyAddress, U3DrawDebugCanvas2DLine_FunctionAddress, "Start");
		U3DrawDebugCanvas2DLine_Start_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine_FunctionAddress, "Start");
		U3DrawDebugCanvas2DLine_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine_End_PropertyAddress, U3DrawDebugCanvas2DLine_FunctionAddress, "End");
		U3DrawDebugCanvas2DLine_End_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine_FunctionAddress, "End");
		U3DrawDebugCanvas2DLine_End_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DLine_LineColor_PropertyAddress, U3DrawDebugCanvas2DLine_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DLine_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DLine_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DLine_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DLine_FunctionAddress, "LineColor", Classes.FStructProperty);
		U3DrawDebugCanvas2DLine_IsValid = U3DrawDebugCanvas2DLine_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvas2DLine_Canvas_IsValid && U3DrawDebugCanvas2DLine_Start_IsValid && U3DrawDebugCanvas2DLine_End_IsValid && U3DrawDebugCanvas2DLine_LineColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DLine", U3DrawDebugCanvas2DLine_IsValid);
		U3DrawDebugCanvas2DCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvas2DCircle");
		U3DrawDebugCanvas2DCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvas2DCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DCircle_Canvas_PropertyAddress, U3DrawDebugCanvas2DCircle_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DCircle_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DCircle_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DCircle_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DCircle_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DCircle_Center_PropertyAddress, U3DrawDebugCanvas2DCircle_FunctionAddress, "Center");
		U3DrawDebugCanvas2DCircle_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DCircle_FunctionAddress, "Center");
		U3DrawDebugCanvas2DCircle_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DCircle_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DCircle_Radius_PropertyAddress, U3DrawDebugCanvas2DCircle_FunctionAddress, "Radius");
		U3DrawDebugCanvas2DCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DCircle_FunctionAddress, "Radius");
		U3DrawDebugCanvas2DCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DCircle_NumSides_PropertyAddress, U3DrawDebugCanvas2DCircle_FunctionAddress, "NumSides");
		U3DrawDebugCanvas2DCircle_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DCircle_FunctionAddress, "NumSides");
		U3DrawDebugCanvas2DCircle_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DCircle_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DCircle_LineColor_PropertyAddress, U3DrawDebugCanvas2DCircle_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DCircle_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DCircle_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DCircle_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DCircle_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DCircle_LineThickness_PropertyAddress, U3DrawDebugCanvas2DCircle_FunctionAddress, "LineThickness");
		U3DrawDebugCanvas2DCircle_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DCircle_FunctionAddress, "LineThickness");
		U3DrawDebugCanvas2DCircle_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DCircle_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		U3DrawDebugCanvas2DCircle_IsValid = U3DrawDebugCanvas2DCircle_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvas2DCircle_Canvas_IsValid && U3DrawDebugCanvas2DCircle_Center_IsValid && U3DrawDebugCanvas2DCircle_Radius_IsValid && U3DrawDebugCanvas2DCircle_NumSides_IsValid && U3DrawDebugCanvas2DCircle_LineColor_IsValid && U3DrawDebugCanvas2DCircle_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DCircle", U3DrawDebugCanvas2DCircle_IsValid);
		U3DrawDebugCanvas2DBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCanvas2DBox");
		U3DrawDebugCanvas2DBox_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCanvas2DBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DBox_Canvas_PropertyAddress, U3DrawDebugCanvas2DBox_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DBox_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DBox_FunctionAddress, "Canvas");
		U3DrawDebugCanvas2DBox_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DBox_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DBox_Box_PropertyAddress, U3DrawDebugCanvas2DBox_FunctionAddress, "Box");
		U3DrawDebugCanvas2DBox_Box_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DBox_FunctionAddress, "Box");
		U3DrawDebugCanvas2DBox_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DBox_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DBox_LineColor_PropertyAddress, U3DrawDebugCanvas2DBox_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DBox_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DBox_FunctionAddress, "LineColor");
		U3DrawDebugCanvas2DBox_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DBox_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCanvas2DBox_LineThickness_PropertyAddress, U3DrawDebugCanvas2DBox_FunctionAddress, "LineThickness");
		U3DrawDebugCanvas2DBox_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCanvas2DBox_FunctionAddress, "LineThickness");
		U3DrawDebugCanvas2DBox_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCanvas2DBox_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		U3DrawDebugCanvas2DBox_IsValid = U3DrawDebugCanvas2DBox_FunctionAddress != IntPtr.Zero && U3DrawDebugCanvas2DBox_Canvas_IsValid && U3DrawDebugCanvas2DBox_Box_IsValid && U3DrawDebugCanvas2DBox_LineColor_IsValid && U3DrawDebugCanvas2DBox_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCanvas2DBox", U3DrawDebugCanvas2DBox_IsValid);
		U3DrawDebugCamera_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugCamera");
		U3DrawDebugCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_InWorld_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "InWorld");
		U3DrawDebugCamera_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "InWorld");
		U3DrawDebugCamera_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_Location_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "Location");
		U3DrawDebugCamera_Location_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "Location");
		U3DrawDebugCamera_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_Rotation_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "Rotation");
		U3DrawDebugCamera_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "Rotation");
		U3DrawDebugCamera_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_FOVDeg_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "FOVDeg");
		U3DrawDebugCamera_FOVDeg_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "FOVDeg");
		U3DrawDebugCamera_FOVDeg_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "FOVDeg", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_Scale_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "Scale");
		U3DrawDebugCamera_Scale_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "Scale");
		U3DrawDebugCamera_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_Color_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "Color");
		U3DrawDebugCamera_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "Color");
		U3DrawDebugCamera_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_bPersistentLines_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "bPersistentLines");
		U3DrawDebugCamera_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "bPersistentLines");
		U3DrawDebugCamera_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_LifeTime_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "LifeTime");
		U3DrawDebugCamera_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "LifeTime");
		U3DrawDebugCamera_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugCamera_DepthPriority_PropertyAddress, U3DrawDebugCamera_FunctionAddress, "DepthPriority");
		U3DrawDebugCamera_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugCamera_FunctionAddress, "DepthPriority");
		U3DrawDebugCamera_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugCamera_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		U3DrawDebugCamera_IsValid = U3DrawDebugCamera_FunctionAddress != IntPtr.Zero && U3DrawDebugCamera_InWorld_IsValid && U3DrawDebugCamera_Location_IsValid && U3DrawDebugCamera_Rotation_IsValid && U3DrawDebugCamera_FOVDeg_IsValid && U3DrawDebugCamera_Scale_IsValid && U3DrawDebugCamera_Color_IsValid && U3DrawDebugCamera_bPersistentLines_IsValid && U3DrawDebugCamera_LifeTime_IsValid && U3DrawDebugCamera_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugCamera", U3DrawDebugCamera_IsValid);
		U3DrawDebugBox2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugBox2");
		U3DrawDebugBox2_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugBox2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_InWorld_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "InWorld");
		U3DrawDebugBox2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "InWorld");
		U3DrawDebugBox2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_Center_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "Center");
		U3DrawDebugBox2_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "Center");
		U3DrawDebugBox2_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_Extent_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "Extent");
		U3DrawDebugBox2_Extent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "Extent");
		U3DrawDebugBox2_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_Rotation_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "Rotation");
		U3DrawDebugBox2_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "Rotation");
		U3DrawDebugBox2_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_Color_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "Color");
		U3DrawDebugBox2_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "Color");
		U3DrawDebugBox2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_bPersistentLines_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "bPersistentLines");
		U3DrawDebugBox2_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "bPersistentLines");
		U3DrawDebugBox2_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_LifeTime_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "LifeTime");
		U3DrawDebugBox2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "LifeTime");
		U3DrawDebugBox2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_DepthPriority_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "DepthPriority");
		U3DrawDebugBox2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "DepthPriority");
		U3DrawDebugBox2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox2_Thickness_PropertyAddress, U3DrawDebugBox2_FunctionAddress, "Thickness");
		U3DrawDebugBox2_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox2_FunctionAddress, "Thickness");
		U3DrawDebugBox2_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox2_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugBox2_IsValid = U3DrawDebugBox2_FunctionAddress != IntPtr.Zero && U3DrawDebugBox2_InWorld_IsValid && U3DrawDebugBox2_Center_IsValid && U3DrawDebugBox2_Extent_IsValid && U3DrawDebugBox2_Rotation_IsValid && U3DrawDebugBox2_Color_IsValid && U3DrawDebugBox2_bPersistentLines_IsValid && U3DrawDebugBox2_LifeTime_IsValid && U3DrawDebugBox2_DepthPriority_IsValid && U3DrawDebugBox2_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugBox2", U3DrawDebugBox2_IsValid);
		U3DrawDebugBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugBox");
		U3DrawDebugBox_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_InWorld_PropertyAddress, U3DrawDebugBox_FunctionAddress, "InWorld");
		U3DrawDebugBox_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "InWorld");
		U3DrawDebugBox_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_Center_PropertyAddress, U3DrawDebugBox_FunctionAddress, "Center");
		U3DrawDebugBox_Center_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "Center");
		U3DrawDebugBox_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_Extent_PropertyAddress, U3DrawDebugBox_FunctionAddress, "Extent");
		U3DrawDebugBox_Extent_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "Extent");
		U3DrawDebugBox_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_Color_PropertyAddress, U3DrawDebugBox_FunctionAddress, "Color");
		U3DrawDebugBox_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "Color");
		U3DrawDebugBox_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_bPersistentLines_PropertyAddress, U3DrawDebugBox_FunctionAddress, "bPersistentLines");
		U3DrawDebugBox_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "bPersistentLines");
		U3DrawDebugBox_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_LifeTime_PropertyAddress, U3DrawDebugBox_FunctionAddress, "LifeTime");
		U3DrawDebugBox_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "LifeTime");
		U3DrawDebugBox_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_DepthPriority_PropertyAddress, U3DrawDebugBox_FunctionAddress, "DepthPriority");
		U3DrawDebugBox_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "DepthPriority");
		U3DrawDebugBox_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugBox_Thickness_PropertyAddress, U3DrawDebugBox_FunctionAddress, "Thickness");
		U3DrawDebugBox_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugBox_FunctionAddress, "Thickness");
		U3DrawDebugBox_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugBox_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugBox_IsValid = U3DrawDebugBox_FunctionAddress != IntPtr.Zero && U3DrawDebugBox_InWorld_IsValid && U3DrawDebugBox_Center_IsValid && U3DrawDebugBox_Extent_IsValid && U3DrawDebugBox_Color_IsValid && U3DrawDebugBox_bPersistentLines_IsValid && U3DrawDebugBox_LifeTime_IsValid && U3DrawDebugBox_DepthPriority_IsValid && U3DrawDebugBox_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugBox", U3DrawDebugBox_IsValid);
		U3DrawDebugAltCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebugAltCone");
		U3DrawDebugAltCone_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebugAltCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_InWorld_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "InWorld");
		U3DrawDebugAltCone_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "InWorld");
		U3DrawDebugAltCone_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_Origin_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "Origin");
		U3DrawDebugAltCone_Origin_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "Origin");
		U3DrawDebugAltCone_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_Rotation_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "Rotation");
		U3DrawDebugAltCone_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "Rotation");
		U3DrawDebugAltCone_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_Length_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "Length");
		U3DrawDebugAltCone_Length_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "Length");
		U3DrawDebugAltCone_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_AngleWidth_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "AngleWidth");
		U3DrawDebugAltCone_AngleWidth_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "AngleWidth");
		U3DrawDebugAltCone_AngleWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "AngleWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_AngleHeight_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "AngleHeight");
		U3DrawDebugAltCone_AngleHeight_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "AngleHeight");
		U3DrawDebugAltCone_AngleHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "AngleHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_DrawColor_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "DrawColor");
		U3DrawDebugAltCone_DrawColor_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "DrawColor");
		U3DrawDebugAltCone_DrawColor_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "DrawColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_bPersistentLines_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "bPersistentLines");
		U3DrawDebugAltCone_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "bPersistentLines");
		U3DrawDebugAltCone_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_LifeTime_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "LifeTime");
		U3DrawDebugAltCone_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "LifeTime");
		U3DrawDebugAltCone_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_DepthPriority_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "DepthPriority");
		U3DrawDebugAltCone_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "DepthPriority");
		U3DrawDebugAltCone_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebugAltCone_Thickness_PropertyAddress, U3DrawDebugAltCone_FunctionAddress, "Thickness");
		U3DrawDebugAltCone_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebugAltCone_FunctionAddress, "Thickness");
		U3DrawDebugAltCone_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebugAltCone_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebugAltCone_IsValid = U3DrawDebugAltCone_FunctionAddress != IntPtr.Zero && U3DrawDebugAltCone_InWorld_IsValid && U3DrawDebugAltCone_Origin_IsValid && U3DrawDebugAltCone_Rotation_IsValid && U3DrawDebugAltCone_Length_IsValid && U3DrawDebugAltCone_AngleWidth_IsValid && U3DrawDebugAltCone_AngleHeight_IsValid && U3DrawDebugAltCone_DrawColor_IsValid && U3DrawDebugAltCone_bPersistentLines_IsValid && U3DrawDebugAltCone_LifeTime_IsValid && U3DrawDebugAltCone_DepthPriority_IsValid && U3DrawDebugAltCone_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebugAltCone", U3DrawDebugAltCone_IsValid);
		U3DrawDebug2DDonut_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawDebug2DDonut");
		U3DrawDebug2DDonut_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawDebug2DDonut_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_InWorld_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "InWorld");
		U3DrawDebug2DDonut_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "InWorld");
		U3DrawDebug2DDonut_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_TransformMatrix_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "TransformMatrix");
		U3DrawDebug2DDonut_TransformMatrix_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "TransformMatrix");
		U3DrawDebug2DDonut_TransformMatrix_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "TransformMatrix", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_InnerRadius_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "InnerRadius");
		U3DrawDebug2DDonut_InnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "InnerRadius");
		U3DrawDebug2DDonut_InnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "InnerRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_OuterRadius_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "OuterRadius");
		U3DrawDebug2DDonut_OuterRadius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "OuterRadius");
		U3DrawDebug2DDonut_OuterRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "OuterRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_Segments_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "Segments");
		U3DrawDebug2DDonut_Segments_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "Segments");
		U3DrawDebug2DDonut_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_Color_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "Color");
		U3DrawDebug2DDonut_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "Color");
		U3DrawDebug2DDonut_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_bPersistentLines_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "bPersistentLines");
		U3DrawDebug2DDonut_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "bPersistentLines");
		U3DrawDebug2DDonut_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_LifeTime_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "LifeTime");
		U3DrawDebug2DDonut_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "LifeTime");
		U3DrawDebug2DDonut_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_DepthPriority_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "DepthPriority");
		U3DrawDebug2DDonut_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "DepthPriority");
		U3DrawDebug2DDonut_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawDebug2DDonut_Thickness_PropertyAddress, U3DrawDebug2DDonut_FunctionAddress, "Thickness");
		U3DrawDebug2DDonut_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawDebug2DDonut_FunctionAddress, "Thickness");
		U3DrawDebug2DDonut_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawDebug2DDonut_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawDebug2DDonut_IsValid = U3DrawDebug2DDonut_FunctionAddress != IntPtr.Zero && U3DrawDebug2DDonut_InWorld_IsValid && U3DrawDebug2DDonut_TransformMatrix_IsValid && U3DrawDebug2DDonut_InnerRadius_IsValid && U3DrawDebug2DDonut_OuterRadius_IsValid && U3DrawDebug2DDonut_Segments_IsValid && U3DrawDebug2DDonut_Color_IsValid && U3DrawDebug2DDonut_bPersistentLines_IsValid && U3DrawDebug2DDonut_LifeTime_IsValid && U3DrawDebug2DDonut_DepthPriority_IsValid && U3DrawDebug2DDonut_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawDebug2DDonut", U3DrawDebug2DDonut_IsValid);
		U3DrawCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "U3DrawCircle");
		U3DrawCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(U3DrawCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_InWorld_PropertyAddress, U3DrawCircle_FunctionAddress, "InWorld");
		U3DrawCircle_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "InWorld");
		U3DrawCircle_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_Base_PropertyAddress, U3DrawCircle_FunctionAddress, "Base");
		U3DrawCircle_Base_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "Base");
		U3DrawCircle_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_X_PropertyAddress, U3DrawCircle_FunctionAddress, "X");
		U3DrawCircle_X_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "X");
		U3DrawCircle_X_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_Y_PropertyAddress, U3DrawCircle_FunctionAddress, "Y");
		U3DrawCircle_Y_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "Y");
		U3DrawCircle_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_Color_PropertyAddress, U3DrawCircle_FunctionAddress, "Color");
		U3DrawCircle_Color_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "Color");
		U3DrawCircle_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_Radius_PropertyAddress, U3DrawCircle_FunctionAddress, "Radius");
		U3DrawCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "Radius");
		U3DrawCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_NumSides_PropertyAddress, U3DrawCircle_FunctionAddress, "NumSides");
		U3DrawCircle_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "NumSides");
		U3DrawCircle_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_bPersistentLines_PropertyAddress, U3DrawCircle_FunctionAddress, "bPersistentLines");
		U3DrawCircle_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "bPersistentLines");
		U3DrawCircle_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_LifeTime_PropertyAddress, U3DrawCircle_FunctionAddress, "LifeTime");
		U3DrawCircle_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "LifeTime");
		U3DrawCircle_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_DepthPriority_PropertyAddress, U3DrawCircle_FunctionAddress, "DepthPriority");
		U3DrawCircle_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "DepthPriority");
		U3DrawCircle_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref U3DrawCircle_Thickness_PropertyAddress, U3DrawCircle_FunctionAddress, "Thickness");
		U3DrawCircle_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(U3DrawCircle_FunctionAddress, "Thickness");
		U3DrawCircle_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(U3DrawCircle_FunctionAddress, "Thickness", Classes.FFloatProperty);
		U3DrawCircle_IsValid = U3DrawCircle_FunctionAddress != IntPtr.Zero && U3DrawCircle_InWorld_IsValid && U3DrawCircle_Base_IsValid && U3DrawCircle_X_IsValid && U3DrawCircle_Y_IsValid && U3DrawCircle_Color_IsValid && U3DrawCircle_Radius_IsValid && U3DrawCircle_NumSides_IsValid && U3DrawCircle_bPersistentLines_IsValid && U3DrawCircle_LifeTime_IsValid && U3DrawCircle_DepthPriority_IsValid && U3DrawCircle_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:U3DrawCircle", U3DrawCircle_IsValid);
		DisableAllScreenMessages_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableAllScreenMessages");
		DisableAllScreenMessages_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableAllScreenMessages_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableAllScreenMessages_WorldCtx_PropertyAddress, DisableAllScreenMessages_FunctionAddress, "WorldCtx");
		DisableAllScreenMessages_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(DisableAllScreenMessages_FunctionAddress, "WorldCtx");
		DisableAllScreenMessages_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableAllScreenMessages_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		DisableAllScreenMessages_IsValid = DisableAllScreenMessages_FunctionAddress != IntPtr.Zero && DisableAllScreenMessages_WorldCtx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.U3DebugUtil:DisableAllScreenMessages", DisableAllScreenMessages_IsValid);
	}
}
