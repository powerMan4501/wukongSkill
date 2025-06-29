using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.X2DebugUtil", "b1", UnrealModuleType.Game)]
public class UX2DebugUtil : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool X2FlushPersistentDebugLines_IsValid;

	private static IntPtr X2FlushPersistentDebugLines_FunctionAddress;

	private static int X2FlushPersistentDebugLines_ParamsSize;

	private static bool X2FlushPersistentDebugLines_DebugTag_IsValid;

	private static FFieldAddress X2FlushPersistentDebugLines_DebugTag_PropertyAddress;

	private static int X2FlushPersistentDebugLines_DebugTag_Offset;

	private static bool X2FlushPersistentDebugLines_InWorld_IsValid;

	private static FFieldAddress X2FlushPersistentDebugLines_InWorld_PropertyAddress;

	private static int X2FlushPersistentDebugLines_InWorld_Offset;

	private static bool X2FlushDebugStrings_IsValid;

	private static IntPtr X2FlushDebugStrings_FunctionAddress;

	private static int X2FlushDebugStrings_ParamsSize;

	private static bool X2FlushDebugStrings_DebugTag_IsValid;

	private static FFieldAddress X2FlushDebugStrings_DebugTag_PropertyAddress;

	private static int X2FlushDebugStrings_DebugTag_Offset;

	private static bool X2FlushDebugStrings_InWorld_IsValid;

	private static FFieldAddress X2FlushDebugStrings_InWorld_PropertyAddress;

	private static int X2FlushDebugStrings_InWorld_Offset;

	private static bool X2DrawDebugString_IsValid;

	private static IntPtr X2DrawDebugString_FunctionAddress;

	private static int X2DrawDebugString_ParamsSize;

	private static bool X2DrawDebugString_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugString_DebugTag_PropertyAddress;

	private static int X2DrawDebugString_DebugTag_Offset;

	private static bool X2DrawDebugString_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugString_InWorld_PropertyAddress;

	private static int X2DrawDebugString_InWorld_Offset;

	private static bool X2DrawDebugString_TextLocation_IsValid;

	private static FFieldAddress X2DrawDebugString_TextLocation_PropertyAddress;

	private static int X2DrawDebugString_TextLocation_Offset;

	private static bool X2DrawDebugString_Text_IsValid;

	private static FFieldAddress X2DrawDebugString_Text_PropertyAddress;

	private static int X2DrawDebugString_Text_Offset;

	private static bool X2DrawDebugString_TestBaseActor_IsValid;

	private static FFieldAddress X2DrawDebugString_TestBaseActor_PropertyAddress;

	private static int X2DrawDebugString_TestBaseActor_Offset;

	private static bool X2DrawDebugString_TextColor_IsValid;

	private static FFieldAddress X2DrawDebugString_TextColor_PropertyAddress;

	private static int X2DrawDebugString_TextColor_Offset;

	private static bool X2DrawDebugString_Duration_IsValid;

	private static FFieldAddress X2DrawDebugString_Duration_PropertyAddress;

	private static int X2DrawDebugString_Duration_Offset;

	private static bool X2DrawDebugString_bDrawShadow_IsValid;

	private static FFieldAddress X2DrawDebugString_bDrawShadow_PropertyAddress;

	private static int X2DrawDebugString_bDrawShadow_Offset;

	private static bool X2DrawDebugString_FontScale_IsValid;

	private static FFieldAddress X2DrawDebugString_FontScale_PropertyAddress;

	private static int X2DrawDebugString_FontScale_Offset;

	private static bool X2DrawDebugSphere_IsValid;

	private static IntPtr X2DrawDebugSphere_FunctionAddress;

	private static int X2DrawDebugSphere_ParamsSize;

	private static bool X2DrawDebugSphere_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugSphere_DebugTag_PropertyAddress;

	private static int X2DrawDebugSphere_DebugTag_Offset;

	private static bool X2DrawDebugSphere_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugSphere_InWorld_PropertyAddress;

	private static int X2DrawDebugSphere_InWorld_Offset;

	private static bool X2DrawDebugSphere_Center_IsValid;

	private static FFieldAddress X2DrawDebugSphere_Center_PropertyAddress;

	private static int X2DrawDebugSphere_Center_Offset;

	private static bool X2DrawDebugSphere_Radius_IsValid;

	private static FFieldAddress X2DrawDebugSphere_Radius_PropertyAddress;

	private static int X2DrawDebugSphere_Radius_Offset;

	private static bool X2DrawDebugSphere_Segments_IsValid;

	private static FFieldAddress X2DrawDebugSphere_Segments_PropertyAddress;

	private static int X2DrawDebugSphere_Segments_Offset;

	private static bool X2DrawDebugSphere_Color_IsValid;

	private static FFieldAddress X2DrawDebugSphere_Color_PropertyAddress;

	private static int X2DrawDebugSphere_Color_Offset;

	private static bool X2DrawDebugSphere_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugSphere_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugSphere_bPersistentLines_Offset;

	private static bool X2DrawDebugSphere_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugSphere_LifeTime_PropertyAddress;

	private static int X2DrawDebugSphere_LifeTime_Offset;

	private static bool X2DrawDebugSphere_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugSphere_DepthPriority_PropertyAddress;

	private static int X2DrawDebugSphere_DepthPriority_Offset;

	private static bool X2DrawDebugSphere_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugSphere_Thickness_PropertyAddress;

	private static int X2DrawDebugSphere_Thickness_Offset;

	private static bool X2DrawDebugSolidPlane2_IsValid;

	private static IntPtr X2DrawDebugSolidPlane2_FunctionAddress;

	private static int X2DrawDebugSolidPlane2_ParamsSize;

	private static bool X2DrawDebugSolidPlane2_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_DebugTag_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_DebugTag_Offset;

	private static bool X2DrawDebugSolidPlane2_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_InWorld_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_InWorld_Offset;

	private static bool X2DrawDebugSolidPlane2_P_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_P_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_P_Offset;

	private static bool X2DrawDebugSolidPlane2_Loc_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_Loc_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_Loc_Offset;

	private static bool X2DrawDebugSolidPlane2_Extents_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_Extents_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_Extents_Offset;

	private static bool X2DrawDebugSolidPlane2_Color_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_Color_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_Color_Offset;

	private static bool X2DrawDebugSolidPlane2_bPersistent_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_bPersistent_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_bPersistent_Offset;

	private static bool X2DrawDebugSolidPlane2_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_LifeTime_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_LifeTime_Offset;

	private static bool X2DrawDebugSolidPlane2_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane2_DepthPriority_PropertyAddress;

	private static int X2DrawDebugSolidPlane2_DepthPriority_Offset;

	private static bool X2DrawDebugSolidPlane_IsValid;

	private static IntPtr X2DrawDebugSolidPlane_FunctionAddress;

	private static int X2DrawDebugSolidPlane_ParamsSize;

	private static bool X2DrawDebugSolidPlane_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_DebugTag_PropertyAddress;

	private static int X2DrawDebugSolidPlane_DebugTag_Offset;

	private static bool X2DrawDebugSolidPlane_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_InWorld_PropertyAddress;

	private static int X2DrawDebugSolidPlane_InWorld_Offset;

	private static bool X2DrawDebugSolidPlane_P_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_P_PropertyAddress;

	private static int X2DrawDebugSolidPlane_P_Offset;

	private static bool X2DrawDebugSolidPlane_Loc_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_Loc_PropertyAddress;

	private static int X2DrawDebugSolidPlane_Loc_Offset;

	private static bool X2DrawDebugSolidPlane_Size_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_Size_PropertyAddress;

	private static int X2DrawDebugSolidPlane_Size_Offset;

	private static bool X2DrawDebugSolidPlane_Color_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_Color_PropertyAddress;

	private static int X2DrawDebugSolidPlane_Color_Offset;

	private static bool X2DrawDebugSolidPlane_bPersistent_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_bPersistent_PropertyAddress;

	private static int X2DrawDebugSolidPlane_bPersistent_Offset;

	private static bool X2DrawDebugSolidPlane_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_LifeTime_PropertyAddress;

	private static int X2DrawDebugSolidPlane_LifeTime_Offset;

	private static bool X2DrawDebugSolidPlane_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugSolidPlane_DepthPriority_PropertyAddress;

	private static int X2DrawDebugSolidPlane_DepthPriority_Offset;

	private static bool X2DrawDebugSolidBox3_IsValid;

	private static IntPtr X2DrawDebugSolidBox3_FunctionAddress;

	private static int X2DrawDebugSolidBox3_ParamsSize;

	private static bool X2DrawDebugSolidBox3_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_DebugTag_PropertyAddress;

	private static int X2DrawDebugSolidBox3_DebugTag_Offset;

	private static bool X2DrawDebugSolidBox3_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_InWorld_PropertyAddress;

	private static int X2DrawDebugSolidBox3_InWorld_Offset;

	private static bool X2DrawDebugSolidBox3_Center_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_Center_PropertyAddress;

	private static int X2DrawDebugSolidBox3_Center_Offset;

	private static bool X2DrawDebugSolidBox3_Extent_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_Extent_PropertyAddress;

	private static int X2DrawDebugSolidBox3_Extent_Offset;

	private static bool X2DrawDebugSolidBox3_Rotation_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_Rotation_PropertyAddress;

	private static int X2DrawDebugSolidBox3_Rotation_Offset;

	private static bool X2DrawDebugSolidBox3_Color_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_Color_PropertyAddress;

	private static int X2DrawDebugSolidBox3_Color_Offset;

	private static bool X2DrawDebugSolidBox3_bPersistent_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_bPersistent_PropertyAddress;

	private static int X2DrawDebugSolidBox3_bPersistent_Offset;

	private static bool X2DrawDebugSolidBox3_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_LifeTime_PropertyAddress;

	private static int X2DrawDebugSolidBox3_LifeTime_Offset;

	private static bool X2DrawDebugSolidBox3_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox3_DepthPriority_PropertyAddress;

	private static int X2DrawDebugSolidBox3_DepthPriority_Offset;

	private static bool X2DrawDebugSolidBox2_IsValid;

	private static IntPtr X2DrawDebugSolidBox2_FunctionAddress;

	private static int X2DrawDebugSolidBox2_ParamsSize;

	private static bool X2DrawDebugSolidBox2_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_DebugTag_PropertyAddress;

	private static int X2DrawDebugSolidBox2_DebugTag_Offset;

	private static bool X2DrawDebugSolidBox2_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_InWorld_PropertyAddress;

	private static int X2DrawDebugSolidBox2_InWorld_Offset;

	private static bool X2DrawDebugSolidBox2_Center_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_Center_PropertyAddress;

	private static int X2DrawDebugSolidBox2_Center_Offset;

	private static bool X2DrawDebugSolidBox2_Extent_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_Extent_PropertyAddress;

	private static int X2DrawDebugSolidBox2_Extent_Offset;

	private static bool X2DrawDebugSolidBox2_Color_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_Color_PropertyAddress;

	private static int X2DrawDebugSolidBox2_Color_Offset;

	private static bool X2DrawDebugSolidBox2_bPersistent_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_bPersistent_PropertyAddress;

	private static int X2DrawDebugSolidBox2_bPersistent_Offset;

	private static bool X2DrawDebugSolidBox2_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_LifeTime_PropertyAddress;

	private static int X2DrawDebugSolidBox2_LifeTime_Offset;

	private static bool X2DrawDebugSolidBox2_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox2_DepthPriority_PropertyAddress;

	private static int X2DrawDebugSolidBox2_DepthPriority_Offset;

	private static bool X2DrawDebugSolidBox_IsValid;

	private static IntPtr X2DrawDebugSolidBox_FunctionAddress;

	private static int X2DrawDebugSolidBox_ParamsSize;

	private static bool X2DrawDebugSolidBox_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_DebugTag_PropertyAddress;

	private static int X2DrawDebugSolidBox_DebugTag_Offset;

	private static bool X2DrawDebugSolidBox_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_InWorld_PropertyAddress;

	private static int X2DrawDebugSolidBox_InWorld_Offset;

	private static bool X2DrawDebugSolidBox_Box_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_Box_PropertyAddress;

	private static int X2DrawDebugSolidBox_Box_Offset;

	private static bool X2DrawDebugSolidBox_Color_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_Color_PropertyAddress;

	private static int X2DrawDebugSolidBox_Color_Offset;

	private static bool X2DrawDebugSolidBox_Transform_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_Transform_PropertyAddress;

	private static int X2DrawDebugSolidBox_Transform_Offset;

	private static bool X2DrawDebugSolidBox_bPersistent_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_bPersistent_PropertyAddress;

	private static int X2DrawDebugSolidBox_bPersistent_Offset;

	private static bool X2DrawDebugSolidBox_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_LifeTime_PropertyAddress;

	private static int X2DrawDebugSolidBox_LifeTime_Offset;

	private static bool X2DrawDebugSolidBox_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugSolidBox_DepthPriority_PropertyAddress;

	private static int X2DrawDebugSolidBox_DepthPriority_Offset;

	private static bool X2DrawDebugPoint_IsValid;

	private static IntPtr X2DrawDebugPoint_FunctionAddress;

	private static int X2DrawDebugPoint_ParamsSize;

	private static bool X2DrawDebugPoint_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugPoint_DebugTag_PropertyAddress;

	private static int X2DrawDebugPoint_DebugTag_Offset;

	private static bool X2DrawDebugPoint_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugPoint_InWorld_PropertyAddress;

	private static int X2DrawDebugPoint_InWorld_Offset;

	private static bool X2DrawDebugPoint_Position_IsValid;

	private static FFieldAddress X2DrawDebugPoint_Position_PropertyAddress;

	private static int X2DrawDebugPoint_Position_Offset;

	private static bool X2DrawDebugPoint_Size_IsValid;

	private static FFieldAddress X2DrawDebugPoint_Size_PropertyAddress;

	private static int X2DrawDebugPoint_Size_Offset;

	private static bool X2DrawDebugPoint_PointColor_IsValid;

	private static FFieldAddress X2DrawDebugPoint_PointColor_PropertyAddress;

	private static int X2DrawDebugPoint_PointColor_Offset;

	private static bool X2DrawDebugPoint_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugPoint_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugPoint_bPersistentLines_Offset;

	private static bool X2DrawDebugPoint_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugPoint_LifeTime_PropertyAddress;

	private static int X2DrawDebugPoint_LifeTime_Offset;

	private static bool X2DrawDebugPoint_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugPoint_DepthPriority_PropertyAddress;

	private static int X2DrawDebugPoint_DepthPriority_Offset;

	private static bool X2DrawDebugMesh_IsValid;

	private static IntPtr X2DrawDebugMesh_FunctionAddress;

	private static int X2DrawDebugMesh_ParamsSize;

	private static bool X2DrawDebugMesh_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugMesh_DebugTag_PropertyAddress;

	private static int X2DrawDebugMesh_DebugTag_Offset;

	private static bool X2DrawDebugMesh_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugMesh_InWorld_PropertyAddress;

	private static int X2DrawDebugMesh_InWorld_Offset;

	private static bool X2DrawDebugMesh_Verts_IsValid;

	private static FFieldAddress X2DrawDebugMesh_Verts_PropertyAddress;

	private static int X2DrawDebugMesh_Verts_Offset;

	private static bool X2DrawDebugMesh_Indices_IsValid;

	private static FFieldAddress X2DrawDebugMesh_Indices_PropertyAddress;

	private static int X2DrawDebugMesh_Indices_Offset;

	private static bool X2DrawDebugMesh_Color_IsValid;

	private static FFieldAddress X2DrawDebugMesh_Color_PropertyAddress;

	private static int X2DrawDebugMesh_Color_Offset;

	private static bool X2DrawDebugMesh_bPersistent_IsValid;

	private static FFieldAddress X2DrawDebugMesh_bPersistent_PropertyAddress;

	private static int X2DrawDebugMesh_bPersistent_Offset;

	private static bool X2DrawDebugMesh_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugMesh_LifeTime_PropertyAddress;

	private static int X2DrawDebugMesh_LifeTime_Offset;

	private static bool X2DrawDebugMesh_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugMesh_DepthPriority_PropertyAddress;

	private static int X2DrawDebugMesh_DepthPriority_Offset;

	private static bool X2DrawDebugLine_IsValid;

	private static IntPtr X2DrawDebugLine_FunctionAddress;

	private static int X2DrawDebugLine_ParamsSize;

	private static bool X2DrawDebugLine_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugLine_DebugTag_PropertyAddress;

	private static int X2DrawDebugLine_DebugTag_Offset;

	private static bool X2DrawDebugLine_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugLine_InWorld_PropertyAddress;

	private static int X2DrawDebugLine_InWorld_Offset;

	private static bool X2DrawDebugLine_LineStart_IsValid;

	private static FFieldAddress X2DrawDebugLine_LineStart_PropertyAddress;

	private static int X2DrawDebugLine_LineStart_Offset;

	private static bool X2DrawDebugLine_LineEnd_IsValid;

	private static FFieldAddress X2DrawDebugLine_LineEnd_PropertyAddress;

	private static int X2DrawDebugLine_LineEnd_Offset;

	private static bool X2DrawDebugLine_Color_IsValid;

	private static FFieldAddress X2DrawDebugLine_Color_PropertyAddress;

	private static int X2DrawDebugLine_Color_Offset;

	private static bool X2DrawDebugLine_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugLine_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugLine_bPersistentLines_Offset;

	private static bool X2DrawDebugLine_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugLine_LifeTime_PropertyAddress;

	private static int X2DrawDebugLine_LifeTime_Offset;

	private static bool X2DrawDebugLine_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugLine_DepthPriority_PropertyAddress;

	private static int X2DrawDebugLine_DepthPriority_Offset;

	private static bool X2DrawDebugLine_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugLine_Thickness_PropertyAddress;

	private static int X2DrawDebugLine_Thickness_Offset;

	private static bool X2DrawDebugFrustum_IsValid;

	private static IntPtr X2DrawDebugFrustum_FunctionAddress;

	private static int X2DrawDebugFrustum_ParamsSize;

	private static bool X2DrawDebugFrustum_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_DebugTag_PropertyAddress;

	private static int X2DrawDebugFrustum_DebugTag_Offset;

	private static bool X2DrawDebugFrustum_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_InWorld_PropertyAddress;

	private static int X2DrawDebugFrustum_InWorld_Offset;

	private static bool X2DrawDebugFrustum_FrustumToWorld_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_FrustumToWorld_PropertyAddress;

	private static int X2DrawDebugFrustum_FrustumToWorld_Offset;

	private static bool X2DrawDebugFrustum_Color_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_Color_PropertyAddress;

	private static int X2DrawDebugFrustum_Color_Offset;

	private static bool X2DrawDebugFrustum_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugFrustum_bPersistentLines_Offset;

	private static bool X2DrawDebugFrustum_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_LifeTime_PropertyAddress;

	private static int X2DrawDebugFrustum_LifeTime_Offset;

	private static bool X2DrawDebugFrustum_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_DepthPriority_PropertyAddress;

	private static int X2DrawDebugFrustum_DepthPriority_Offset;

	private static bool X2DrawDebugFrustum_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugFrustum_Thickness_PropertyAddress;

	private static int X2DrawDebugFrustum_Thickness_Offset;

	private static bool X2DrawDebugDirectionalArrow_IsValid;

	private static IntPtr X2DrawDebugDirectionalArrow_FunctionAddress;

	private static int X2DrawDebugDirectionalArrow_ParamsSize;

	private static bool X2DrawDebugDirectionalArrow_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_DebugTag_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_DebugTag_Offset;

	private static bool X2DrawDebugDirectionalArrow_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_InWorld_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_InWorld_Offset;

	private static bool X2DrawDebugDirectionalArrow_LineStart_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_LineStart_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_LineStart_Offset;

	private static bool X2DrawDebugDirectionalArrow_LineEnd_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_LineEnd_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_LineEnd_Offset;

	private static bool X2DrawDebugDirectionalArrow_ArrowSize_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_ArrowSize_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_ArrowSize_Offset;

	private static bool X2DrawDebugDirectionalArrow_Color_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_Color_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_Color_Offset;

	private static bool X2DrawDebugDirectionalArrow_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_bPersistentLines_Offset;

	private static bool X2DrawDebugDirectionalArrow_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_LifeTime_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_LifeTime_Offset;

	private static bool X2DrawDebugDirectionalArrow_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_DepthPriority_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_DepthPriority_Offset;

	private static bool X2DrawDebugDirectionalArrow_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugDirectionalArrow_Thickness_PropertyAddress;

	private static int X2DrawDebugDirectionalArrow_Thickness_Offset;

	private static bool X2DrawDebugCylinder_IsValid;

	private static IntPtr X2DrawDebugCylinder_FunctionAddress;

	private static int X2DrawDebugCylinder_ParamsSize;

	private static bool X2DrawDebugCylinder_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_DebugTag_PropertyAddress;

	private static int X2DrawDebugCylinder_DebugTag_Offset;

	private static bool X2DrawDebugCylinder_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_InWorld_PropertyAddress;

	private static int X2DrawDebugCylinder_InWorld_Offset;

	private static bool X2DrawDebugCylinder_Start_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_Start_PropertyAddress;

	private static int X2DrawDebugCylinder_Start_Offset;

	private static bool X2DrawDebugCylinder_End_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_End_PropertyAddress;

	private static int X2DrawDebugCylinder_End_Offset;

	private static bool X2DrawDebugCylinder_Radius_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_Radius_PropertyAddress;

	private static int X2DrawDebugCylinder_Radius_Offset;

	private static bool X2DrawDebugCylinder_Segments_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_Segments_PropertyAddress;

	private static int X2DrawDebugCylinder_Segments_Offset;

	private static bool X2DrawDebugCylinder_Color_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_Color_PropertyAddress;

	private static int X2DrawDebugCylinder_Color_Offset;

	private static bool X2DrawDebugCylinder_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCylinder_bPersistentLines_Offset;

	private static bool X2DrawDebugCylinder_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_LifeTime_PropertyAddress;

	private static int X2DrawDebugCylinder_LifeTime_Offset;

	private static bool X2DrawDebugCylinder_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCylinder_DepthPriority_Offset;

	private static bool X2DrawDebugCylinder_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugCylinder_Thickness_PropertyAddress;

	private static int X2DrawDebugCylinder_Thickness_Offset;

	private static bool X2DrawDebugCrosshairs_IsValid;

	private static IntPtr X2DrawDebugCrosshairs_FunctionAddress;

	private static int X2DrawDebugCrosshairs_ParamsSize;

	private static bool X2DrawDebugCrosshairs_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_DebugTag_PropertyAddress;

	private static int X2DrawDebugCrosshairs_DebugTag_Offset;

	private static bool X2DrawDebugCrosshairs_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_InWorld_PropertyAddress;

	private static int X2DrawDebugCrosshairs_InWorld_Offset;

	private static bool X2DrawDebugCrosshairs_AxisLoc_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_AxisLoc_PropertyAddress;

	private static int X2DrawDebugCrosshairs_AxisLoc_Offset;

	private static bool X2DrawDebugCrosshairs_AxisRot_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_AxisRot_PropertyAddress;

	private static int X2DrawDebugCrosshairs_AxisRot_Offset;

	private static bool X2DrawDebugCrosshairs_Scale_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_Scale_PropertyAddress;

	private static int X2DrawDebugCrosshairs_Scale_Offset;

	private static bool X2DrawDebugCrosshairs_Color_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_Color_PropertyAddress;

	private static int X2DrawDebugCrosshairs_Color_Offset;

	private static bool X2DrawDebugCrosshairs_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCrosshairs_bPersistentLines_Offset;

	private static bool X2DrawDebugCrosshairs_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_LifeTime_PropertyAddress;

	private static int X2DrawDebugCrosshairs_LifeTime_Offset;

	private static bool X2DrawDebugCrosshairs_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCrosshairs_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCrosshairs_DepthPriority_Offset;

	private static bool X2DrawDebugCoordinateSystem_IsValid;

	private static IntPtr X2DrawDebugCoordinateSystem_FunctionAddress;

	private static int X2DrawDebugCoordinateSystem_ParamsSize;

	private static bool X2DrawDebugCoordinateSystem_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_DebugTag_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_DebugTag_Offset;

	private static bool X2DrawDebugCoordinateSystem_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_InWorld_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_InWorld_Offset;

	private static bool X2DrawDebugCoordinateSystem_AxisLoc_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_AxisLoc_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_AxisLoc_Offset;

	private static bool X2DrawDebugCoordinateSystem_AxisRot_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_AxisRot_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_AxisRot_Offset;

	private static bool X2DrawDebugCoordinateSystem_Scale_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_Scale_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_Scale_Offset;

	private static bool X2DrawDebugCoordinateSystem_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_bPersistentLines_Offset;

	private static bool X2DrawDebugCoordinateSystem_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_LifeTime_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_LifeTime_Offset;

	private static bool X2DrawDebugCoordinateSystem_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_DepthPriority_Offset;

	private static bool X2DrawDebugCoordinateSystem_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugCoordinateSystem_Thickness_PropertyAddress;

	private static int X2DrawDebugCoordinateSystem_Thickness_Offset;

	private static bool X2DrawDebugCone_IsValid;

	private static IntPtr X2DrawDebugCone_FunctionAddress;

	private static int X2DrawDebugCone_ParamsSize;

	private static bool X2DrawDebugCone_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCone_DebugTag_PropertyAddress;

	private static int X2DrawDebugCone_DebugTag_Offset;

	private static bool X2DrawDebugCone_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCone_InWorld_PropertyAddress;

	private static int X2DrawDebugCone_InWorld_Offset;

	private static bool X2DrawDebugCone_Origin_IsValid;

	private static FFieldAddress X2DrawDebugCone_Origin_PropertyAddress;

	private static int X2DrawDebugCone_Origin_Offset;

	private static bool X2DrawDebugCone_Direction_IsValid;

	private static FFieldAddress X2DrawDebugCone_Direction_PropertyAddress;

	private static int X2DrawDebugCone_Direction_Offset;

	private static bool X2DrawDebugCone_Length_IsValid;

	private static FFieldAddress X2DrawDebugCone_Length_PropertyAddress;

	private static int X2DrawDebugCone_Length_Offset;

	private static bool X2DrawDebugCone_AngleWidth_IsValid;

	private static FFieldAddress X2DrawDebugCone_AngleWidth_PropertyAddress;

	private static int X2DrawDebugCone_AngleWidth_Offset;

	private static bool X2DrawDebugCone_AngleHeight_IsValid;

	private static FFieldAddress X2DrawDebugCone_AngleHeight_PropertyAddress;

	private static int X2DrawDebugCone_AngleHeight_Offset;

	private static bool X2DrawDebugCone_NumSides_IsValid;

	private static FFieldAddress X2DrawDebugCone_NumSides_PropertyAddress;

	private static int X2DrawDebugCone_NumSides_Offset;

	private static bool X2DrawDebugCone_Color_IsValid;

	private static FFieldAddress X2DrawDebugCone_Color_PropertyAddress;

	private static int X2DrawDebugCone_Color_Offset;

	private static bool X2DrawDebugCone_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCone_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCone_bPersistentLines_Offset;

	private static bool X2DrawDebugCone_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCone_LifeTime_PropertyAddress;

	private static int X2DrawDebugCone_LifeTime_Offset;

	private static bool X2DrawDebugCone_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCone_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCone_DepthPriority_Offset;

	private static bool X2DrawDebugCone_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugCone_Thickness_PropertyAddress;

	private static int X2DrawDebugCone_Thickness_Offset;

	private static bool X2DrawDebugCircle2_IsValid;

	private static IntPtr X2DrawDebugCircle2_FunctionAddress;

	private static int X2DrawDebugCircle2_ParamsSize;

	private static bool X2DrawDebugCircle2_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_DebugTag_PropertyAddress;

	private static int X2DrawDebugCircle2_DebugTag_Offset;

	private static bool X2DrawDebugCircle2_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_InWorld_PropertyAddress;

	private static int X2DrawDebugCircle2_InWorld_Offset;

	private static bool X2DrawDebugCircle2_Center_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_Center_PropertyAddress;

	private static int X2DrawDebugCircle2_Center_Offset;

	private static bool X2DrawDebugCircle2_Radius_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_Radius_PropertyAddress;

	private static int X2DrawDebugCircle2_Radius_Offset;

	private static bool X2DrawDebugCircle2_Segments_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_Segments_PropertyAddress;

	private static int X2DrawDebugCircle2_Segments_Offset;

	private static bool X2DrawDebugCircle2_Color_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_Color_PropertyAddress;

	private static int X2DrawDebugCircle2_Color_Offset;

	private static bool X2DrawDebugCircle2_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCircle2_bPersistentLines_Offset;

	private static bool X2DrawDebugCircle2_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_LifeTime_PropertyAddress;

	private static int X2DrawDebugCircle2_LifeTime_Offset;

	private static bool X2DrawDebugCircle2_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCircle2_DepthPriority_Offset;

	private static bool X2DrawDebugCircle2_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_Thickness_PropertyAddress;

	private static int X2DrawDebugCircle2_Thickness_Offset;

	private static bool X2DrawDebugCircle2_YAxis_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_YAxis_PropertyAddress;

	private static int X2DrawDebugCircle2_YAxis_Offset;

	private static bool X2DrawDebugCircle2_ZAxis_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_ZAxis_PropertyAddress;

	private static int X2DrawDebugCircle2_ZAxis_Offset;

	private static bool X2DrawDebugCircle2_bDrawAxis_IsValid;

	private static FFieldAddress X2DrawDebugCircle2_bDrawAxis_PropertyAddress;

	private static int X2DrawDebugCircle2_bDrawAxis_Offset;

	private static bool X2DrawDebugCircle_IsValid;

	private static IntPtr X2DrawDebugCircle_FunctionAddress;

	private static int X2DrawDebugCircle_ParamsSize;

	private static bool X2DrawDebugCircle_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCircle_DebugTag_PropertyAddress;

	private static int X2DrawDebugCircle_DebugTag_Offset;

	private static bool X2DrawDebugCircle_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCircle_InWorld_PropertyAddress;

	private static int X2DrawDebugCircle_InWorld_Offset;

	private static bool X2DrawDebugCircle_TransformMatrix_IsValid;

	private static FFieldAddress X2DrawDebugCircle_TransformMatrix_PropertyAddress;

	private static int X2DrawDebugCircle_TransformMatrix_Offset;

	private static bool X2DrawDebugCircle_Radius_IsValid;

	private static FFieldAddress X2DrawDebugCircle_Radius_PropertyAddress;

	private static int X2DrawDebugCircle_Radius_Offset;

	private static bool X2DrawDebugCircle_Segments_IsValid;

	private static FFieldAddress X2DrawDebugCircle_Segments_PropertyAddress;

	private static int X2DrawDebugCircle_Segments_Offset;

	private static bool X2DrawDebugCircle_Color_IsValid;

	private static FFieldAddress X2DrawDebugCircle_Color_PropertyAddress;

	private static int X2DrawDebugCircle_Color_Offset;

	private static bool X2DrawDebugCircle_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCircle_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCircle_bPersistentLines_Offset;

	private static bool X2DrawDebugCircle_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCircle_LifeTime_PropertyAddress;

	private static int X2DrawDebugCircle_LifeTime_Offset;

	private static bool X2DrawDebugCircle_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCircle_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCircle_DepthPriority_Offset;

	private static bool X2DrawDebugCircle_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugCircle_Thickness_PropertyAddress;

	private static int X2DrawDebugCircle_Thickness_Offset;

	private static bool X2DrawDebugCircle_bDrawAxis_IsValid;

	private static FFieldAddress X2DrawDebugCircle_bDrawAxis_PropertyAddress;

	private static int X2DrawDebugCircle_bDrawAxis_Offset;

	private static bool X2DrawDebugCapsule_IsValid;

	private static IntPtr X2DrawDebugCapsule_FunctionAddress;

	private static int X2DrawDebugCapsule_ParamsSize;

	private static bool X2DrawDebugCapsule_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_DebugTag_PropertyAddress;

	private static int X2DrawDebugCapsule_DebugTag_Offset;

	private static bool X2DrawDebugCapsule_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_InWorld_PropertyAddress;

	private static int X2DrawDebugCapsule_InWorld_Offset;

	private static bool X2DrawDebugCapsule_Center_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_Center_PropertyAddress;

	private static int X2DrawDebugCapsule_Center_Offset;

	private static bool X2DrawDebugCapsule_HalfHeight_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_HalfHeight_PropertyAddress;

	private static int X2DrawDebugCapsule_HalfHeight_Offset;

	private static bool X2DrawDebugCapsule_Radius_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_Radius_PropertyAddress;

	private static int X2DrawDebugCapsule_Radius_Offset;

	private static bool X2DrawDebugCapsule_Rotation_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_Rotation_PropertyAddress;

	private static int X2DrawDebugCapsule_Rotation_Offset;

	private static bool X2DrawDebugCapsule_Color_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_Color_PropertyAddress;

	private static int X2DrawDebugCapsule_Color_Offset;

	private static bool X2DrawDebugCapsule_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCapsule_bPersistentLines_Offset;

	private static bool X2DrawDebugCapsule_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_LifeTime_PropertyAddress;

	private static int X2DrawDebugCapsule_LifeTime_Offset;

	private static bool X2DrawDebugCapsule_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCapsule_DepthPriority_Offset;

	private static bool X2DrawDebugCapsule_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugCapsule_Thickness_PropertyAddress;

	private static int X2DrawDebugCapsule_Thickness_Offset;

	private static bool X2DrawDebugCanvasWireSphere_IsValid;

	private static IntPtr X2DrawDebugCanvasWireSphere_FunctionAddress;

	private static int X2DrawDebugCanvasWireSphere_ParamsSize;

	private static bool X2DrawDebugCanvasWireSphere_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireSphere_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvasWireSphere_DebugTag_Offset;

	private static bool X2DrawDebugCanvasWireSphere_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireSphere_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvasWireSphere_Canvas_Offset;

	private static bool X2DrawDebugCanvasWireSphere_Base_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireSphere_Base_PropertyAddress;

	private static int X2DrawDebugCanvasWireSphere_Base_Offset;

	private static bool X2DrawDebugCanvasWireSphere_Color_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireSphere_Color_PropertyAddress;

	private static int X2DrawDebugCanvasWireSphere_Color_Offset;

	private static bool X2DrawDebugCanvasWireSphere_Radius_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireSphere_Radius_PropertyAddress;

	private static int X2DrawDebugCanvasWireSphere_Radius_Offset;

	private static bool X2DrawDebugCanvasWireSphere_NumSides_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireSphere_NumSides_PropertyAddress;

	private static int X2DrawDebugCanvasWireSphere_NumSides_Offset;

	private static bool X2DrawDebugCanvasWireCone_IsValid;

	private static IntPtr X2DrawDebugCanvasWireCone_FunctionAddress;

	private static int X2DrawDebugCanvasWireCone_ParamsSize;

	private static bool X2DrawDebugCanvasWireCone_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireCone_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvasWireCone_DebugTag_Offset;

	private static bool X2DrawDebugCanvasWireCone_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireCone_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvasWireCone_Canvas_Offset;

	private static bool X2DrawDebugCanvasWireCone_Transform_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireCone_Transform_PropertyAddress;

	private static int X2DrawDebugCanvasWireCone_Transform_Offset;

	private static bool X2DrawDebugCanvasWireCone_ConeRadius_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireCone_ConeRadius_PropertyAddress;

	private static int X2DrawDebugCanvasWireCone_ConeRadius_Offset;

	private static bool X2DrawDebugCanvasWireCone_ConeAngle_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireCone_ConeAngle_PropertyAddress;

	private static int X2DrawDebugCanvasWireCone_ConeAngle_Offset;

	private static bool X2DrawDebugCanvasWireCone_ConeSides_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireCone_ConeSides_PropertyAddress;

	private static int X2DrawDebugCanvasWireCone_ConeSides_Offset;

	private static bool X2DrawDebugCanvasWireCone_Color_IsValid;

	private static FFieldAddress X2DrawDebugCanvasWireCone_Color_PropertyAddress;

	private static int X2DrawDebugCanvasWireCone_Color_Offset;

	private static bool X2DrawDebugCanvasLine_IsValid;

	private static IntPtr X2DrawDebugCanvasLine_FunctionAddress;

	private static int X2DrawDebugCanvasLine_ParamsSize;

	private static bool X2DrawDebugCanvasLine_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvasLine_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvasLine_DebugTag_Offset;

	private static bool X2DrawDebugCanvasLine_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvasLine_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvasLine_Canvas_Offset;

	private static bool X2DrawDebugCanvasLine_Start_IsValid;

	private static FFieldAddress X2DrawDebugCanvasLine_Start_PropertyAddress;

	private static int X2DrawDebugCanvasLine_Start_Offset;

	private static bool X2DrawDebugCanvasLine_End_IsValid;

	private static FFieldAddress X2DrawDebugCanvasLine_End_PropertyAddress;

	private static int X2DrawDebugCanvasLine_End_Offset;

	private static bool X2DrawDebugCanvasLine_LineColor_IsValid;

	private static FFieldAddress X2DrawDebugCanvasLine_LineColor_PropertyAddress;

	private static int X2DrawDebugCanvasLine_LineColor_Offset;

	private static bool X2DrawDebugCanvasCircle_IsValid;

	private static IntPtr X2DrawDebugCanvasCircle_FunctionAddress;

	private static int X2DrawDebugCanvasCircle_ParamsSize;

	private static bool X2DrawDebugCanvasCircle_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_DebugTag_Offset;

	private static bool X2DrawDebugCanvasCircle_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_Canvas_Offset;

	private static bool X2DrawDebugCanvasCircle_Base_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_Base_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_Base_Offset;

	private static bool X2DrawDebugCanvasCircle_X_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_X_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_X_Offset;

	private static bool X2DrawDebugCanvasCircle_Y_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_Y_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_Y_Offset;

	private static bool X2DrawDebugCanvasCircle_Color_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_Color_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_Color_Offset;

	private static bool X2DrawDebugCanvasCircle_Radius_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_Radius_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_Radius_Offset;

	private static bool X2DrawDebugCanvasCircle_NumSides_IsValid;

	private static FFieldAddress X2DrawDebugCanvasCircle_NumSides_PropertyAddress;

	private static int X2DrawDebugCanvasCircle_NumSides_Offset;

	private static bool X2DrawDebugCanvas2DLine2_IsValid;

	private static IntPtr X2DrawDebugCanvas2DLine2_FunctionAddress;

	private static int X2DrawDebugCanvas2DLine2_ParamsSize;

	private static bool X2DrawDebugCanvas2DLine2_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine2_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine2_DebugTag_Offset;

	private static bool X2DrawDebugCanvas2DLine2_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine2_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine2_Canvas_Offset;

	private static bool X2DrawDebugCanvas2DLine2_StartPosition_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine2_StartPosition_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine2_StartPosition_Offset;

	private static bool X2DrawDebugCanvas2DLine2_EndPosition_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine2_EndPosition_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine2_EndPosition_Offset;

	private static bool X2DrawDebugCanvas2DLine2_LineColor_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine2_LineColor_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine2_LineColor_Offset;

	private static bool X2DrawDebugCanvas2DLine2_LineThickness_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine2_LineThickness_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine2_LineThickness_Offset;

	private static bool X2DrawDebugCanvas2DLine_IsValid;

	private static IntPtr X2DrawDebugCanvas2DLine_FunctionAddress;

	private static int X2DrawDebugCanvas2DLine_ParamsSize;

	private static bool X2DrawDebugCanvas2DLine_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine_DebugTag_Offset;

	private static bool X2DrawDebugCanvas2DLine_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine_Canvas_Offset;

	private static bool X2DrawDebugCanvas2DLine_Start_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine_Start_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine_Start_Offset;

	private static bool X2DrawDebugCanvas2DLine_End_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine_End_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine_End_Offset;

	private static bool X2DrawDebugCanvas2DLine_LineColor_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DLine_LineColor_PropertyAddress;

	private static int X2DrawDebugCanvas2DLine_LineColor_Offset;

	private static bool X2DrawDebugCanvas2DCircle_IsValid;

	private static IntPtr X2DrawDebugCanvas2DCircle_FunctionAddress;

	private static int X2DrawDebugCanvas2DCircle_ParamsSize;

	private static bool X2DrawDebugCanvas2DCircle_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DCircle_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvas2DCircle_DebugTag_Offset;

	private static bool X2DrawDebugCanvas2DCircle_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DCircle_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvas2DCircle_Canvas_Offset;

	private static bool X2DrawDebugCanvas2DCircle_Center_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DCircle_Center_PropertyAddress;

	private static int X2DrawDebugCanvas2DCircle_Center_Offset;

	private static bool X2DrawDebugCanvas2DCircle_Radius_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DCircle_Radius_PropertyAddress;

	private static int X2DrawDebugCanvas2DCircle_Radius_Offset;

	private static bool X2DrawDebugCanvas2DCircle_NumSides_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DCircle_NumSides_PropertyAddress;

	private static int X2DrawDebugCanvas2DCircle_NumSides_Offset;

	private static bool X2DrawDebugCanvas2DCircle_LineColor_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DCircle_LineColor_PropertyAddress;

	private static int X2DrawDebugCanvas2DCircle_LineColor_Offset;

	private static bool X2DrawDebugCanvas2DCircle_LineThickness_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DCircle_LineThickness_PropertyAddress;

	private static int X2DrawDebugCanvas2DCircle_LineThickness_Offset;

	private static bool X2DrawDebugCanvas2DBox_IsValid;

	private static IntPtr X2DrawDebugCanvas2DBox_FunctionAddress;

	private static int X2DrawDebugCanvas2DBox_ParamsSize;

	private static bool X2DrawDebugCanvas2DBox_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DBox_DebugTag_PropertyAddress;

	private static int X2DrawDebugCanvas2DBox_DebugTag_Offset;

	private static bool X2DrawDebugCanvas2DBox_Canvas_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DBox_Canvas_PropertyAddress;

	private static int X2DrawDebugCanvas2DBox_Canvas_Offset;

	private static bool X2DrawDebugCanvas2DBox_Box_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DBox_Box_PropertyAddress;

	private static int X2DrawDebugCanvas2DBox_Box_Offset;

	private static bool X2DrawDebugCanvas2DBox_LineColor_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DBox_LineColor_PropertyAddress;

	private static int X2DrawDebugCanvas2DBox_LineColor_Offset;

	private static bool X2DrawDebugCanvas2DBox_LineThickness_IsValid;

	private static FFieldAddress X2DrawDebugCanvas2DBox_LineThickness_PropertyAddress;

	private static int X2DrawDebugCanvas2DBox_LineThickness_Offset;

	private static bool X2DrawDebugCamera_IsValid;

	private static IntPtr X2DrawDebugCamera_FunctionAddress;

	private static int X2DrawDebugCamera_ParamsSize;

	private static bool X2DrawDebugCamera_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugCamera_DebugTag_PropertyAddress;

	private static int X2DrawDebugCamera_DebugTag_Offset;

	private static bool X2DrawDebugCamera_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugCamera_InWorld_PropertyAddress;

	private static int X2DrawDebugCamera_InWorld_Offset;

	private static bool X2DrawDebugCamera_Location_IsValid;

	private static FFieldAddress X2DrawDebugCamera_Location_PropertyAddress;

	private static int X2DrawDebugCamera_Location_Offset;

	private static bool X2DrawDebugCamera_Rotation_IsValid;

	private static FFieldAddress X2DrawDebugCamera_Rotation_PropertyAddress;

	private static int X2DrawDebugCamera_Rotation_Offset;

	private static bool X2DrawDebugCamera_FOVDeg_IsValid;

	private static FFieldAddress X2DrawDebugCamera_FOVDeg_PropertyAddress;

	private static int X2DrawDebugCamera_FOVDeg_Offset;

	private static bool X2DrawDebugCamera_Scale_IsValid;

	private static FFieldAddress X2DrawDebugCamera_Scale_PropertyAddress;

	private static int X2DrawDebugCamera_Scale_Offset;

	private static bool X2DrawDebugCamera_Color_IsValid;

	private static FFieldAddress X2DrawDebugCamera_Color_PropertyAddress;

	private static int X2DrawDebugCamera_Color_Offset;

	private static bool X2DrawDebugCamera_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugCamera_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugCamera_bPersistentLines_Offset;

	private static bool X2DrawDebugCamera_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugCamera_LifeTime_PropertyAddress;

	private static int X2DrawDebugCamera_LifeTime_Offset;

	private static bool X2DrawDebugCamera_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugCamera_DepthPriority_PropertyAddress;

	private static int X2DrawDebugCamera_DepthPriority_Offset;

	private static bool X2DrawDebugBox2_IsValid;

	private static IntPtr X2DrawDebugBox2_FunctionAddress;

	private static int X2DrawDebugBox2_ParamsSize;

	private static bool X2DrawDebugBox2_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugBox2_DebugTag_PropertyAddress;

	private static int X2DrawDebugBox2_DebugTag_Offset;

	private static bool X2DrawDebugBox2_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugBox2_InWorld_PropertyAddress;

	private static int X2DrawDebugBox2_InWorld_Offset;

	private static bool X2DrawDebugBox2_Center_IsValid;

	private static FFieldAddress X2DrawDebugBox2_Center_PropertyAddress;

	private static int X2DrawDebugBox2_Center_Offset;

	private static bool X2DrawDebugBox2_Extent_IsValid;

	private static FFieldAddress X2DrawDebugBox2_Extent_PropertyAddress;

	private static int X2DrawDebugBox2_Extent_Offset;

	private static bool X2DrawDebugBox2_Rotation_IsValid;

	private static FFieldAddress X2DrawDebugBox2_Rotation_PropertyAddress;

	private static int X2DrawDebugBox2_Rotation_Offset;

	private static bool X2DrawDebugBox2_Color_IsValid;

	private static FFieldAddress X2DrawDebugBox2_Color_PropertyAddress;

	private static int X2DrawDebugBox2_Color_Offset;

	private static bool X2DrawDebugBox2_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugBox2_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugBox2_bPersistentLines_Offset;

	private static bool X2DrawDebugBox2_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugBox2_LifeTime_PropertyAddress;

	private static int X2DrawDebugBox2_LifeTime_Offset;

	private static bool X2DrawDebugBox2_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugBox2_DepthPriority_PropertyAddress;

	private static int X2DrawDebugBox2_DepthPriority_Offset;

	private static bool X2DrawDebugBox2_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugBox2_Thickness_PropertyAddress;

	private static int X2DrawDebugBox2_Thickness_Offset;

	private static bool X2DrawDebugBox_IsValid;

	private static IntPtr X2DrawDebugBox_FunctionAddress;

	private static int X2DrawDebugBox_ParamsSize;

	private static bool X2DrawDebugBox_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugBox_DebugTag_PropertyAddress;

	private static int X2DrawDebugBox_DebugTag_Offset;

	private static bool X2DrawDebugBox_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugBox_InWorld_PropertyAddress;

	private static int X2DrawDebugBox_InWorld_Offset;

	private static bool X2DrawDebugBox_Center_IsValid;

	private static FFieldAddress X2DrawDebugBox_Center_PropertyAddress;

	private static int X2DrawDebugBox_Center_Offset;

	private static bool X2DrawDebugBox_Extent_IsValid;

	private static FFieldAddress X2DrawDebugBox_Extent_PropertyAddress;

	private static int X2DrawDebugBox_Extent_Offset;

	private static bool X2DrawDebugBox_Color_IsValid;

	private static FFieldAddress X2DrawDebugBox_Color_PropertyAddress;

	private static int X2DrawDebugBox_Color_Offset;

	private static bool X2DrawDebugBox_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugBox_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugBox_bPersistentLines_Offset;

	private static bool X2DrawDebugBox_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugBox_LifeTime_PropertyAddress;

	private static int X2DrawDebugBox_LifeTime_Offset;

	private static bool X2DrawDebugBox_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugBox_DepthPriority_PropertyAddress;

	private static int X2DrawDebugBox_DepthPriority_Offset;

	private static bool X2DrawDebugBox_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugBox_Thickness_PropertyAddress;

	private static int X2DrawDebugBox_Thickness_Offset;

	private static bool X2DrawDebugAltCone_IsValid;

	private static IntPtr X2DrawDebugAltCone_FunctionAddress;

	private static int X2DrawDebugAltCone_ParamsSize;

	private static bool X2DrawDebugAltCone_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_DebugTag_PropertyAddress;

	private static int X2DrawDebugAltCone_DebugTag_Offset;

	private static bool X2DrawDebugAltCone_InWorld_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_InWorld_PropertyAddress;

	private static int X2DrawDebugAltCone_InWorld_Offset;

	private static bool X2DrawDebugAltCone_Origin_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_Origin_PropertyAddress;

	private static int X2DrawDebugAltCone_Origin_Offset;

	private static bool X2DrawDebugAltCone_Rotation_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_Rotation_PropertyAddress;

	private static int X2DrawDebugAltCone_Rotation_Offset;

	private static bool X2DrawDebugAltCone_Length_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_Length_PropertyAddress;

	private static int X2DrawDebugAltCone_Length_Offset;

	private static bool X2DrawDebugAltCone_AngleWidth_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_AngleWidth_PropertyAddress;

	private static int X2DrawDebugAltCone_AngleWidth_Offset;

	private static bool X2DrawDebugAltCone_AngleHeight_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_AngleHeight_PropertyAddress;

	private static int X2DrawDebugAltCone_AngleHeight_Offset;

	private static bool X2DrawDebugAltCone_DrawColor_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_DrawColor_PropertyAddress;

	private static int X2DrawDebugAltCone_DrawColor_Offset;

	private static bool X2DrawDebugAltCone_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_bPersistentLines_PropertyAddress;

	private static int X2DrawDebugAltCone_bPersistentLines_Offset;

	private static bool X2DrawDebugAltCone_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_LifeTime_PropertyAddress;

	private static int X2DrawDebugAltCone_LifeTime_Offset;

	private static bool X2DrawDebugAltCone_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_DepthPriority_PropertyAddress;

	private static int X2DrawDebugAltCone_DepthPriority_Offset;

	private static bool X2DrawDebugAltCone_Thickness_IsValid;

	private static FFieldAddress X2DrawDebugAltCone_Thickness_PropertyAddress;

	private static int X2DrawDebugAltCone_Thickness_Offset;

	private static bool X2DrawDebug2DDonut_IsValid;

	private static IntPtr X2DrawDebug2DDonut_FunctionAddress;

	private static int X2DrawDebug2DDonut_ParamsSize;

	private static bool X2DrawDebug2DDonut_DebugTag_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_DebugTag_PropertyAddress;

	private static int X2DrawDebug2DDonut_DebugTag_Offset;

	private static bool X2DrawDebug2DDonut_InWorld_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_InWorld_PropertyAddress;

	private static int X2DrawDebug2DDonut_InWorld_Offset;

	private static bool X2DrawDebug2DDonut_TransformMatrix_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_TransformMatrix_PropertyAddress;

	private static int X2DrawDebug2DDonut_TransformMatrix_Offset;

	private static bool X2DrawDebug2DDonut_InnerRadius_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_InnerRadius_PropertyAddress;

	private static int X2DrawDebug2DDonut_InnerRadius_Offset;

	private static bool X2DrawDebug2DDonut_OuterRadius_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_OuterRadius_PropertyAddress;

	private static int X2DrawDebug2DDonut_OuterRadius_Offset;

	private static bool X2DrawDebug2DDonut_Segments_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_Segments_PropertyAddress;

	private static int X2DrawDebug2DDonut_Segments_Offset;

	private static bool X2DrawDebug2DDonut_Color_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_Color_PropertyAddress;

	private static int X2DrawDebug2DDonut_Color_Offset;

	private static bool X2DrawDebug2DDonut_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_bPersistentLines_PropertyAddress;

	private static int X2DrawDebug2DDonut_bPersistentLines_Offset;

	private static bool X2DrawDebug2DDonut_LifeTime_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_LifeTime_PropertyAddress;

	private static int X2DrawDebug2DDonut_LifeTime_Offset;

	private static bool X2DrawDebug2DDonut_DepthPriority_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_DepthPriority_PropertyAddress;

	private static int X2DrawDebug2DDonut_DepthPriority_Offset;

	private static bool X2DrawDebug2DDonut_Thickness_IsValid;

	private static FFieldAddress X2DrawDebug2DDonut_Thickness_PropertyAddress;

	private static int X2DrawDebug2DDonut_Thickness_Offset;

	private static bool X2DrawCircle_IsValid;

	private static IntPtr X2DrawCircle_FunctionAddress;

	private static int X2DrawCircle_ParamsSize;

	private static bool X2DrawCircle_DebugTag_IsValid;

	private static FFieldAddress X2DrawCircle_DebugTag_PropertyAddress;

	private static int X2DrawCircle_DebugTag_Offset;

	private static bool X2DrawCircle_InWorld_IsValid;

	private static FFieldAddress X2DrawCircle_InWorld_PropertyAddress;

	private static int X2DrawCircle_InWorld_Offset;

	private static bool X2DrawCircle_Base_IsValid;

	private static FFieldAddress X2DrawCircle_Base_PropertyAddress;

	private static int X2DrawCircle_Base_Offset;

	private static bool X2DrawCircle_X_IsValid;

	private static FFieldAddress X2DrawCircle_X_PropertyAddress;

	private static int X2DrawCircle_X_Offset;

	private static bool X2DrawCircle_Y_IsValid;

	private static FFieldAddress X2DrawCircle_Y_PropertyAddress;

	private static int X2DrawCircle_Y_Offset;

	private static bool X2DrawCircle_Color_IsValid;

	private static FFieldAddress X2DrawCircle_Color_PropertyAddress;

	private static int X2DrawCircle_Color_Offset;

	private static bool X2DrawCircle_Radius_IsValid;

	private static FFieldAddress X2DrawCircle_Radius_PropertyAddress;

	private static int X2DrawCircle_Radius_Offset;

	private static bool X2DrawCircle_NumSides_IsValid;

	private static FFieldAddress X2DrawCircle_NumSides_PropertyAddress;

	private static int X2DrawCircle_NumSides_Offset;

	private static bool X2DrawCircle_bPersistentLines_IsValid;

	private static FFieldAddress X2DrawCircle_bPersistentLines_PropertyAddress;

	private static int X2DrawCircle_bPersistentLines_Offset;

	private static bool X2DrawCircle_LifeTime_IsValid;

	private static FFieldAddress X2DrawCircle_LifeTime_PropertyAddress;

	private static int X2DrawCircle_LifeTime_Offset;

	private static bool X2DrawCircle_DepthPriority_IsValid;

	private static FFieldAddress X2DrawCircle_DepthPriority_PropertyAddress;

	private static int X2DrawCircle_DepthPriority_Offset;

	private static bool X2DrawCircle_Thickness_IsValid;

	private static FFieldAddress X2DrawCircle_Thickness_PropertyAddress;

	private static int X2DrawCircle_Thickness_Offset;

	private static bool DisableAllScreenMessages_IsValid;

	private static IntPtr DisableAllScreenMessages_FunctionAddress;

	private static int DisableAllScreenMessages_ParamsSize;

	private static bool DisableAllScreenMessages_WorldCtx_IsValid;

	private static FFieldAddress DisableAllScreenMessages_WorldCtx_PropertyAddress;

	private static int DisableAllScreenMessages_WorldCtx_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2FlushPersistentDebugLines")]
	public unsafe static void X2FlushPersistentDebugLines(bool DebugTag, UWorld InWorld)
	{
		if (!X2FlushPersistentDebugLines_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2FlushPersistentDebugLines");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2FlushPersistentDebugLines_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2FlushPersistentDebugLines_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2FlushPersistentDebugLines_DebugTag_Offset), 0, X2FlushPersistentDebugLines_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2FlushPersistentDebugLines_InWorld_Offset), 0, X2FlushPersistentDebugLines_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2FlushPersistentDebugLines_FunctionAddress, intPtr, X2FlushPersistentDebugLines_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2FlushDebugStrings")]
	public unsafe static void X2FlushDebugStrings(bool DebugTag, UWorld InWorld)
	{
		if (!X2FlushDebugStrings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2FlushDebugStrings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2FlushDebugStrings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2FlushDebugStrings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2FlushDebugStrings_DebugTag_Offset), 0, X2FlushDebugStrings_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2FlushDebugStrings_InWorld_Offset), 0, X2FlushDebugStrings_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2FlushDebugStrings_FunctionAddress, intPtr, X2FlushDebugStrings_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugString")]
	public unsafe static void X2DrawDebugString(bool DebugTag, UWorld InWorld, FVector TextLocation, string Text, AActor TestBaseActor, FColor TextColor, float Duration, bool bDrawShadow, float FontScale)
	{
		if (!X2DrawDebugString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_DebugTag_Offset), 0, X2DrawDebugString_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_InWorld_Offset), 0, X2DrawDebugString_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_TextLocation_Offset), 0, X2DrawDebugString_TextLocation_PropertyAddress.Address, TextLocation);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_Text_Offset), 0, X2DrawDebugString_Text_PropertyAddress.Address, Text);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_TestBaseActor_Offset), 0, X2DrawDebugString_TestBaseActor_PropertyAddress.Address, TestBaseActor);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_TextColor_Offset), 0, X2DrawDebugString_TextColor_PropertyAddress.Address, TextColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_Duration_Offset), 0, X2DrawDebugString_Duration_PropertyAddress.Address, Duration);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_bDrawShadow_Offset), 0, X2DrawDebugString_bDrawShadow_PropertyAddress.Address, bDrawShadow);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugString_FontScale_Offset), 0, X2DrawDebugString_FontScale_PropertyAddress.Address, FontScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugString_FunctionAddress, intPtr, X2DrawDebugString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(X2DrawDebugString_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugSphere")]
	public unsafe static void X2DrawDebugSphere(bool DebugTag, UWorld InWorld, FVector Center, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugSphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugSphere");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugSphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugSphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_DebugTag_Offset), 0, X2DrawDebugSphere_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_InWorld_Offset), 0, X2DrawDebugSphere_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_Center_Offset), 0, X2DrawDebugSphere_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_Radius_Offset), 0, X2DrawDebugSphere_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_Segments_Offset), 0, X2DrawDebugSphere_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_Color_Offset), 0, X2DrawDebugSphere_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_bPersistentLines_Offset), 0, X2DrawDebugSphere_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_LifeTime_Offset), 0, X2DrawDebugSphere_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_DepthPriority_Offset), 0, X2DrawDebugSphere_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSphere_Thickness_Offset), 0, X2DrawDebugSphere_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugSphere_FunctionAddress, intPtr, X2DrawDebugSphere_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugSolidPlane2")]
	public unsafe static void X2DrawDebugSolidPlane2(bool DebugTag, UWorld InWorld, FPlane P, FVector Loc, FVector2D Extents, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!X2DrawDebugSolidPlane2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugSolidPlane2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugSolidPlane2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugSolidPlane2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_DebugTag_Offset), 0, X2DrawDebugSolidPlane2_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_InWorld_Offset), 0, X2DrawDebugSolidPlane2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FPlane>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_P_Offset), 0, X2DrawDebugSolidPlane2_P_PropertyAddress.Address, P);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_Loc_Offset), 0, X2DrawDebugSolidPlane2_Loc_PropertyAddress.Address, Loc);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_Extents_Offset), 0, X2DrawDebugSolidPlane2_Extents_PropertyAddress.Address, Extents);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_Color_Offset), 0, X2DrawDebugSolidPlane2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_bPersistent_Offset), 0, X2DrawDebugSolidPlane2_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_LifeTime_Offset), 0, X2DrawDebugSolidPlane2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane2_DepthPriority_Offset), 0, X2DrawDebugSolidPlane2_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugSolidPlane2_FunctionAddress, intPtr, X2DrawDebugSolidPlane2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugSolidPlane")]
	public unsafe static void X2DrawDebugSolidPlane(bool DebugTag, UWorld InWorld, FPlane P, FVector Loc, float Size, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!X2DrawDebugSolidPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugSolidPlane");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugSolidPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugSolidPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_DebugTag_Offset), 0, X2DrawDebugSolidPlane_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_InWorld_Offset), 0, X2DrawDebugSolidPlane_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FPlane>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_P_Offset), 0, X2DrawDebugSolidPlane_P_PropertyAddress.Address, P);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_Loc_Offset), 0, X2DrawDebugSolidPlane_Loc_PropertyAddress.Address, Loc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_Size_Offset), 0, X2DrawDebugSolidPlane_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_Color_Offset), 0, X2DrawDebugSolidPlane_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_bPersistent_Offset), 0, X2DrawDebugSolidPlane_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_LifeTime_Offset), 0, X2DrawDebugSolidPlane_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidPlane_DepthPriority_Offset), 0, X2DrawDebugSolidPlane_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugSolidPlane_FunctionAddress, intPtr, X2DrawDebugSolidPlane_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox3")]
	public unsafe static void X2DrawDebugSolidBox3(bool DebugTag, UWorld InWorld, FVector Center, FVector Extent, FQuat Rotation, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!X2DrawDebugSolidBox3_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox3");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugSolidBox3_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugSolidBox3_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_DebugTag_Offset), 0, X2DrawDebugSolidBox3_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_InWorld_Offset), 0, X2DrawDebugSolidBox3_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_Center_Offset), 0, X2DrawDebugSolidBox3_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_Extent_Offset), 0, X2DrawDebugSolidBox3_Extent_PropertyAddress.Address, Extent);
		NativeReflection.InitializeValue_InContainer(X2DrawDebugSolidBox3_Rotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_Rotation_Offset), 0, X2DrawDebugSolidBox3_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_Color_Offset), 0, X2DrawDebugSolidBox3_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_bPersistent_Offset), 0, X2DrawDebugSolidBox3_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_LifeTime_Offset), 0, X2DrawDebugSolidBox3_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox3_DepthPriority_Offset), 0, X2DrawDebugSolidBox3_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugSolidBox3_FunctionAddress, intPtr, X2DrawDebugSolidBox3_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox2")]
	public unsafe static void X2DrawDebugSolidBox2(bool DebugTag, UWorld InWorld, FVector Center, FVector Extent, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!X2DrawDebugSolidBox2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugSolidBox2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugSolidBox2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_DebugTag_Offset), 0, X2DrawDebugSolidBox2_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_InWorld_Offset), 0, X2DrawDebugSolidBox2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_Center_Offset), 0, X2DrawDebugSolidBox2_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_Extent_Offset), 0, X2DrawDebugSolidBox2_Extent_PropertyAddress.Address, Extent);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_Color_Offset), 0, X2DrawDebugSolidBox2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_bPersistent_Offset), 0, X2DrawDebugSolidBox2_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_LifeTime_Offset), 0, X2DrawDebugSolidBox2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox2_DepthPriority_Offset), 0, X2DrawDebugSolidBox2_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugSolidBox2_FunctionAddress, intPtr, X2DrawDebugSolidBox2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox")]
	public unsafe static void X2DrawDebugSolidBox(bool DebugTag, UWorld InWorld, FBox Box, FColor Color, FTransform Transform, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!X2DrawDebugSolidBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugSolidBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugSolidBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_DebugTag_Offset), 0, X2DrawDebugSolidBox_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_InWorld_Offset), 0, X2DrawDebugSolidBox_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_Box_Offset), 0, X2DrawDebugSolidBox_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_Color_Offset), 0, X2DrawDebugSolidBox_Color_PropertyAddress.Address, Color);
		NativeReflection.InitializeValue_InContainer(X2DrawDebugSolidBox_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_Transform_Offset), 0, X2DrawDebugSolidBox_Transform_PropertyAddress.Address, Transform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_bPersistent_Offset), 0, X2DrawDebugSolidBox_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_LifeTime_Offset), 0, X2DrawDebugSolidBox_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugSolidBox_DepthPriority_Offset), 0, X2DrawDebugSolidBox_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugSolidBox_FunctionAddress, intPtr, X2DrawDebugSolidBox_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugPoint")]
	public unsafe static void X2DrawDebugPoint(bool DebugTag, UWorld InWorld, FVector Position, float Size, FColor PointColor, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!X2DrawDebugPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_DebugTag_Offset), 0, X2DrawDebugPoint_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_InWorld_Offset), 0, X2DrawDebugPoint_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_Position_Offset), 0, X2DrawDebugPoint_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_Size_Offset), 0, X2DrawDebugPoint_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_PointColor_Offset), 0, X2DrawDebugPoint_PointColor_PropertyAddress.Address, PointColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_bPersistentLines_Offset), 0, X2DrawDebugPoint_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_LifeTime_Offset), 0, X2DrawDebugPoint_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugPoint_DepthPriority_Offset), 0, X2DrawDebugPoint_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugPoint_FunctionAddress, intPtr, X2DrawDebugPoint_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugMesh")]
	public unsafe static void X2DrawDebugMesh(bool DebugTag, UWorld InWorld, List<FVector> Verts, List<int> Indices, FColor Color, bool bPersistent = false, float LifeTime = -1f, byte DepthPriority = 0)
	{
		if (!X2DrawDebugMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_DebugTag_Offset), 0, X2DrawDebugMesh_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_InWorld_Offset), 0, X2DrawDebugMesh_InWorld_PropertyAddress.Address, InWorld);
		new TArrayCopyMarshaler<FVector>(1, X2DrawDebugMesh_Verts_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_Verts_Offset), Verts);
		new TArrayCopyMarshaler<int>(1, X2DrawDebugMesh_Indices_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_Indices_Offset), Indices);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_Color_Offset), 0, X2DrawDebugMesh_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_bPersistent_Offset), 0, X2DrawDebugMesh_bPersistent_PropertyAddress.Address, bPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_LifeTime_Offset), 0, X2DrawDebugMesh_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugMesh_DepthPriority_Offset), 0, X2DrawDebugMesh_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugMesh_FunctionAddress, intPtr, X2DrawDebugMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(X2DrawDebugMesh_Verts_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(X2DrawDebugMesh_Indices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugLine")]
	public unsafe static void X2DrawDebugLine(bool DebugTag, UWorld InWorld, FVector LineStart, FVector LineEnd, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_DebugTag_Offset), 0, X2DrawDebugLine_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_InWorld_Offset), 0, X2DrawDebugLine_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_LineStart_Offset), 0, X2DrawDebugLine_LineStart_PropertyAddress.Address, LineStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_LineEnd_Offset), 0, X2DrawDebugLine_LineEnd_PropertyAddress.Address, LineEnd);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_Color_Offset), 0, X2DrawDebugLine_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_bPersistentLines_Offset), 0, X2DrawDebugLine_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_LifeTime_Offset), 0, X2DrawDebugLine_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_DepthPriority_Offset), 0, X2DrawDebugLine_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugLine_Thickness_Offset), 0, X2DrawDebugLine_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugLine_FunctionAddress, intPtr, X2DrawDebugLine_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugFrustum")]
	public unsafe static void X2DrawDebugFrustum(bool DebugTag, UWorld InWorld, FMatrix FrustumToWorld, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugFrustum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugFrustum");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugFrustum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugFrustum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_DebugTag_Offset), 0, X2DrawDebugFrustum_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_InWorld_Offset), 0, X2DrawDebugFrustum_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_FrustumToWorld_Offset), 0, X2DrawDebugFrustum_FrustumToWorld_PropertyAddress.Address, FrustumToWorld);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_Color_Offset), 0, X2DrawDebugFrustum_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_bPersistentLines_Offset), 0, X2DrawDebugFrustum_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_LifeTime_Offset), 0, X2DrawDebugFrustum_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_DepthPriority_Offset), 0, X2DrawDebugFrustum_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugFrustum_Thickness_Offset), 0, X2DrawDebugFrustum_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugFrustum_FunctionAddress, intPtr, X2DrawDebugFrustum_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugDirectionalArrow")]
	public unsafe static void X2DrawDebugDirectionalArrow(bool DebugTag, UWorld InWorld, FVector LineStart, FVector LineEnd, float ArrowSize, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugDirectionalArrow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugDirectionalArrow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugDirectionalArrow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugDirectionalArrow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_DebugTag_Offset), 0, X2DrawDebugDirectionalArrow_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_InWorld_Offset), 0, X2DrawDebugDirectionalArrow_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_LineStart_Offset), 0, X2DrawDebugDirectionalArrow_LineStart_PropertyAddress.Address, LineStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_LineEnd_Offset), 0, X2DrawDebugDirectionalArrow_LineEnd_PropertyAddress.Address, LineEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_ArrowSize_Offset), 0, X2DrawDebugDirectionalArrow_ArrowSize_PropertyAddress.Address, ArrowSize);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_Color_Offset), 0, X2DrawDebugDirectionalArrow_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_bPersistentLines_Offset), 0, X2DrawDebugDirectionalArrow_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_LifeTime_Offset), 0, X2DrawDebugDirectionalArrow_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_DepthPriority_Offset), 0, X2DrawDebugDirectionalArrow_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugDirectionalArrow_Thickness_Offset), 0, X2DrawDebugDirectionalArrow_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugDirectionalArrow_FunctionAddress, intPtr, X2DrawDebugDirectionalArrow_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCylinder")]
	public unsafe static void X2DrawDebugCylinder(bool DebugTag, UWorld InWorld, FVector Start, FVector End, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugCylinder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCylinder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCylinder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCylinder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_DebugTag_Offset), 0, X2DrawDebugCylinder_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_InWorld_Offset), 0, X2DrawDebugCylinder_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_Start_Offset), 0, X2DrawDebugCylinder_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_End_Offset), 0, X2DrawDebugCylinder_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_Radius_Offset), 0, X2DrawDebugCylinder_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_Segments_Offset), 0, X2DrawDebugCylinder_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_Color_Offset), 0, X2DrawDebugCylinder_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_bPersistentLines_Offset), 0, X2DrawDebugCylinder_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_LifeTime_Offset), 0, X2DrawDebugCylinder_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_DepthPriority_Offset), 0, X2DrawDebugCylinder_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCylinder_Thickness_Offset), 0, X2DrawDebugCylinder_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCylinder_FunctionAddress, intPtr, X2DrawDebugCylinder_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCrosshairs")]
	public unsafe static void X2DrawDebugCrosshairs(bool DebugTag, UWorld InWorld, FVector AxisLoc, FRotator AxisRot, float Scale, FColor Color, bool bPersistentLines, float LifeTime, byte DepthPriority)
	{
		if (!X2DrawDebugCrosshairs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCrosshairs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCrosshairs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCrosshairs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_DebugTag_Offset), 0, X2DrawDebugCrosshairs_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_InWorld_Offset), 0, X2DrawDebugCrosshairs_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_AxisLoc_Offset), 0, X2DrawDebugCrosshairs_AxisLoc_PropertyAddress.Address, AxisLoc);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_AxisRot_Offset), 0, X2DrawDebugCrosshairs_AxisRot_PropertyAddress.Address, AxisRot);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_Scale_Offset), 0, X2DrawDebugCrosshairs_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_Color_Offset), 0, X2DrawDebugCrosshairs_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_bPersistentLines_Offset), 0, X2DrawDebugCrosshairs_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_LifeTime_Offset), 0, X2DrawDebugCrosshairs_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCrosshairs_DepthPriority_Offset), 0, X2DrawDebugCrosshairs_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCrosshairs_FunctionAddress, intPtr, X2DrawDebugCrosshairs_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCoordinateSystem")]
	public unsafe static void X2DrawDebugCoordinateSystem(bool DebugTag, UWorld InWorld, FVector AxisLoc, FRotator AxisRot, float Scale, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugCoordinateSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCoordinateSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCoordinateSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCoordinateSystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_DebugTag_Offset), 0, X2DrawDebugCoordinateSystem_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_InWorld_Offset), 0, X2DrawDebugCoordinateSystem_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_AxisLoc_Offset), 0, X2DrawDebugCoordinateSystem_AxisLoc_PropertyAddress.Address, AxisLoc);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_AxisRot_Offset), 0, X2DrawDebugCoordinateSystem_AxisRot_PropertyAddress.Address, AxisRot);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_Scale_Offset), 0, X2DrawDebugCoordinateSystem_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_bPersistentLines_Offset), 0, X2DrawDebugCoordinateSystem_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_LifeTime_Offset), 0, X2DrawDebugCoordinateSystem_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_DepthPriority_Offset), 0, X2DrawDebugCoordinateSystem_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCoordinateSystem_Thickness_Offset), 0, X2DrawDebugCoordinateSystem_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCoordinateSystem_FunctionAddress, intPtr, X2DrawDebugCoordinateSystem_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCone")]
	public unsafe static void X2DrawDebugCone(bool DebugTag, UWorld InWorld, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_DebugTag_Offset), 0, X2DrawDebugCone_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_InWorld_Offset), 0, X2DrawDebugCone_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_Origin_Offset), 0, X2DrawDebugCone_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_Direction_Offset), 0, X2DrawDebugCone_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_Length_Offset), 0, X2DrawDebugCone_Length_PropertyAddress.Address, Length);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_AngleWidth_Offset), 0, X2DrawDebugCone_AngleWidth_PropertyAddress.Address, AngleWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_AngleHeight_Offset), 0, X2DrawDebugCone_AngleHeight_PropertyAddress.Address, AngleHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_NumSides_Offset), 0, X2DrawDebugCone_NumSides_PropertyAddress.Address, NumSides);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_Color_Offset), 0, X2DrawDebugCone_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_bPersistentLines_Offset), 0, X2DrawDebugCone_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_LifeTime_Offset), 0, X2DrawDebugCone_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_DepthPriority_Offset), 0, X2DrawDebugCone_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCone_Thickness_Offset), 0, X2DrawDebugCone_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCone_FunctionAddress, intPtr, X2DrawDebugCone_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCircle2")]
	public unsafe static void X2DrawDebugCircle2(bool DebugTag, UWorld InWorld, FVector Center, float Radius, int Segments, FColor Color, bool bPersistentLines, float LifeTime, byte DepthPriority, float Thickness, FVector YAxis, FVector ZAxis, bool bDrawAxis)
	{
		if (!X2DrawDebugCircle2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCircle2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCircle2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCircle2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_DebugTag_Offset), 0, X2DrawDebugCircle2_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_InWorld_Offset), 0, X2DrawDebugCircle2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_Center_Offset), 0, X2DrawDebugCircle2_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_Radius_Offset), 0, X2DrawDebugCircle2_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_Segments_Offset), 0, X2DrawDebugCircle2_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_Color_Offset), 0, X2DrawDebugCircle2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_bPersistentLines_Offset), 0, X2DrawDebugCircle2_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_LifeTime_Offset), 0, X2DrawDebugCircle2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_DepthPriority_Offset), 0, X2DrawDebugCircle2_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_Thickness_Offset), 0, X2DrawDebugCircle2_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_YAxis_Offset), 0, X2DrawDebugCircle2_YAxis_PropertyAddress.Address, YAxis);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_ZAxis_Offset), 0, X2DrawDebugCircle2_ZAxis_PropertyAddress.Address, ZAxis);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle2_bDrawAxis_Offset), 0, X2DrawDebugCircle2_bDrawAxis_PropertyAddress.Address, bDrawAxis);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCircle2_FunctionAddress, intPtr, X2DrawDebugCircle2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCircle")]
	public unsafe static void X2DrawDebugCircle(bool DebugTag, UWorld InWorld, FMatrix TransformMatrix, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f, bool bDrawAxis = true)
	{
		if (!X2DrawDebugCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_DebugTag_Offset), 0, X2DrawDebugCircle_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_InWorld_Offset), 0, X2DrawDebugCircle_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_TransformMatrix_Offset), 0, X2DrawDebugCircle_TransformMatrix_PropertyAddress.Address, TransformMatrix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_Radius_Offset), 0, X2DrawDebugCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_Segments_Offset), 0, X2DrawDebugCircle_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_Color_Offset), 0, X2DrawDebugCircle_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_bPersistentLines_Offset), 0, X2DrawDebugCircle_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_LifeTime_Offset), 0, X2DrawDebugCircle_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_DepthPriority_Offset), 0, X2DrawDebugCircle_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_Thickness_Offset), 0, X2DrawDebugCircle_Thickness_PropertyAddress.Address, Thickness);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCircle_bDrawAxis_Offset), 0, X2DrawDebugCircle_bDrawAxis_PropertyAddress.Address, bDrawAxis);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCircle_FunctionAddress, intPtr, X2DrawDebugCircle_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCapsule")]
	public unsafe static void X2DrawDebugCapsule(bool DebugTag, UWorld InWorld, FVector Center, float HalfHeight, float Radius, FQuat Rotation, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugCapsule_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCapsule");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCapsule_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCapsule_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_DebugTag_Offset), 0, X2DrawDebugCapsule_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_InWorld_Offset), 0, X2DrawDebugCapsule_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_Center_Offset), 0, X2DrawDebugCapsule_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_HalfHeight_Offset), 0, X2DrawDebugCapsule_HalfHeight_PropertyAddress.Address, HalfHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_Radius_Offset), 0, X2DrawDebugCapsule_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InitializeValue_InContainer(X2DrawDebugCapsule_Rotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_Rotation_Offset), 0, X2DrawDebugCapsule_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_Color_Offset), 0, X2DrawDebugCapsule_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_bPersistentLines_Offset), 0, X2DrawDebugCapsule_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_LifeTime_Offset), 0, X2DrawDebugCapsule_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_DepthPriority_Offset), 0, X2DrawDebugCapsule_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCapsule_Thickness_Offset), 0, X2DrawDebugCapsule_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCapsule_FunctionAddress, intPtr, X2DrawDebugCapsule_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvasWireSphere")]
	public unsafe static void X2DrawDebugCanvasWireSphere(bool DebugTag, UCanvas Canvas, FVector Base, FColor Color, float Radius, int NumSides)
	{
		if (!X2DrawDebugCanvasWireSphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvasWireSphere");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvasWireSphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvasWireSphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireSphere_DebugTag_Offset), 0, X2DrawDebugCanvasWireSphere_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireSphere_Canvas_Offset), 0, X2DrawDebugCanvasWireSphere_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireSphere_Base_Offset), 0, X2DrawDebugCanvasWireSphere_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireSphere_Color_Offset), 0, X2DrawDebugCanvasWireSphere_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireSphere_Radius_Offset), 0, X2DrawDebugCanvasWireSphere_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireSphere_NumSides_Offset), 0, X2DrawDebugCanvasWireSphere_NumSides_PropertyAddress.Address, NumSides);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvasWireSphere_FunctionAddress, intPtr, X2DrawDebugCanvasWireSphere_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvasWireCone")]
	public unsafe static void X2DrawDebugCanvasWireCone(bool DebugTag, UCanvas Canvas, FTransform Transform, float ConeRadius, float ConeAngle, int ConeSides, FColor Color)
	{
		if (!X2DrawDebugCanvasWireCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvasWireCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvasWireCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvasWireCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireCone_DebugTag_Offset), 0, X2DrawDebugCanvasWireCone_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireCone_Canvas_Offset), 0, X2DrawDebugCanvasWireCone_Canvas_PropertyAddress.Address, Canvas);
		NativeReflection.InitializeValue_InContainer(X2DrawDebugCanvasWireCone_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireCone_Transform_Offset), 0, X2DrawDebugCanvasWireCone_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireCone_ConeRadius_Offset), 0, X2DrawDebugCanvasWireCone_ConeRadius_PropertyAddress.Address, ConeRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireCone_ConeAngle_Offset), 0, X2DrawDebugCanvasWireCone_ConeAngle_PropertyAddress.Address, ConeAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireCone_ConeSides_Offset), 0, X2DrawDebugCanvasWireCone_ConeSides_PropertyAddress.Address, ConeSides);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasWireCone_Color_Offset), 0, X2DrawDebugCanvasWireCone_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvasWireCone_FunctionAddress, intPtr, X2DrawDebugCanvasWireCone_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvasLine")]
	public unsafe static void X2DrawDebugCanvasLine(bool DebugTag, UCanvas Canvas, FVector Start, FVector End, FLinearColor LineColor)
	{
		if (!X2DrawDebugCanvasLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvasLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvasLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvasLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasLine_DebugTag_Offset), 0, X2DrawDebugCanvasLine_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasLine_Canvas_Offset), 0, X2DrawDebugCanvasLine_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasLine_Start_Offset), 0, X2DrawDebugCanvasLine_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasLine_End_Offset), 0, X2DrawDebugCanvasLine_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasLine_LineColor_Offset), 0, X2DrawDebugCanvasLine_LineColor_PropertyAddress.Address, LineColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvasLine_FunctionAddress, intPtr, X2DrawDebugCanvasLine_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvasCircle")]
	public unsafe static void X2DrawDebugCanvasCircle(bool DebugTag, UCanvas Canvas, FVector Base, FVector X, FVector Y, FColor Color, float Radius, int NumSides)
	{
		if (!X2DrawDebugCanvasCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvasCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvasCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvasCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_DebugTag_Offset), 0, X2DrawDebugCanvasCircle_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_Canvas_Offset), 0, X2DrawDebugCanvasCircle_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_Base_Offset), 0, X2DrawDebugCanvasCircle_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_X_Offset), 0, X2DrawDebugCanvasCircle_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_Y_Offset), 0, X2DrawDebugCanvasCircle_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_Color_Offset), 0, X2DrawDebugCanvasCircle_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_Radius_Offset), 0, X2DrawDebugCanvasCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvasCircle_NumSides_Offset), 0, X2DrawDebugCanvasCircle_NumSides_PropertyAddress.Address, NumSides);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvasCircle_FunctionAddress, intPtr, X2DrawDebugCanvasCircle_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DLine2")]
	public unsafe static void X2DrawDebugCanvas2DLine2(bool DebugTag, UCanvas Canvas, FVector2D StartPosition, FVector2D EndPosition, FLinearColor LineColor, float LineThickness = 1f)
	{
		if (!X2DrawDebugCanvas2DLine2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DLine2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvas2DLine2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvas2DLine2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine2_DebugTag_Offset), 0, X2DrawDebugCanvas2DLine2_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine2_Canvas_Offset), 0, X2DrawDebugCanvas2DLine2_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine2_StartPosition_Offset), 0, X2DrawDebugCanvas2DLine2_StartPosition_PropertyAddress.Address, StartPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine2_EndPosition_Offset), 0, X2DrawDebugCanvas2DLine2_EndPosition_PropertyAddress.Address, EndPosition);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine2_LineColor_Offset), 0, X2DrawDebugCanvas2DLine2_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine2_LineThickness_Offset), 0, X2DrawDebugCanvas2DLine2_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvas2DLine2_FunctionAddress, intPtr, X2DrawDebugCanvas2DLine2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DLine")]
	public unsafe static void X2DrawDebugCanvas2DLine(bool DebugTag, UCanvas Canvas, FVector Start, FVector End, FLinearColor LineColor)
	{
		if (!X2DrawDebugCanvas2DLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvas2DLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvas2DLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine_DebugTag_Offset), 0, X2DrawDebugCanvas2DLine_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine_Canvas_Offset), 0, X2DrawDebugCanvas2DLine_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine_Start_Offset), 0, X2DrawDebugCanvas2DLine_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine_End_Offset), 0, X2DrawDebugCanvas2DLine_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DLine_LineColor_Offset), 0, X2DrawDebugCanvas2DLine_LineColor_PropertyAddress.Address, LineColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvas2DLine_FunctionAddress, intPtr, X2DrawDebugCanvas2DLine_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DCircle")]
	public unsafe static void X2DrawDebugCanvas2DCircle(bool DebugTag, UCanvas Canvas, FVector2D Center, float Radius, int NumSides, FLinearColor LineColor, float LineThickness = 1f)
	{
		if (!X2DrawDebugCanvas2DCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvas2DCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvas2DCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DCircle_DebugTag_Offset), 0, X2DrawDebugCanvas2DCircle_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DCircle_Canvas_Offset), 0, X2DrawDebugCanvas2DCircle_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DCircle_Center_Offset), 0, X2DrawDebugCanvas2DCircle_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DCircle_Radius_Offset), 0, X2DrawDebugCanvas2DCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DCircle_NumSides_Offset), 0, X2DrawDebugCanvas2DCircle_NumSides_PropertyAddress.Address, NumSides);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DCircle_LineColor_Offset), 0, X2DrawDebugCanvas2DCircle_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DCircle_LineThickness_Offset), 0, X2DrawDebugCanvas2DCircle_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, intPtr, X2DrawDebugCanvas2DCircle_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DBox")]
	public unsafe static void X2DrawDebugCanvas2DBox(bool DebugTag, UCanvas Canvas, FBox2D Box, FLinearColor LineColor, float LineThickness = 1f)
	{
		if (!X2DrawDebugCanvas2DBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCanvas2DBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCanvas2DBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DBox_DebugTag_Offset), 0, X2DrawDebugCanvas2DBox_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DBox_Canvas_Offset), 0, X2DrawDebugCanvas2DBox_Canvas_PropertyAddress.Address, Canvas);
		BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DBox_Box_Offset), 0, X2DrawDebugCanvas2DBox_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DBox_LineColor_Offset), 0, X2DrawDebugCanvas2DBox_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCanvas2DBox_LineThickness_Offset), 0, X2DrawDebugCanvas2DBox_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCanvas2DBox_FunctionAddress, intPtr, X2DrawDebugCanvas2DBox_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugCamera")]
	public unsafe static void X2DrawDebugCamera(bool DebugTag, UWorld InWorld, FVector Location, FRotator Rotation, float FOVDeg, float Scale, FColor Color, bool bPersistentLines, float LifeTime, byte DepthPriority)
	{
		if (!X2DrawDebugCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_DebugTag_Offset), 0, X2DrawDebugCamera_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_InWorld_Offset), 0, X2DrawDebugCamera_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_Location_Offset), 0, X2DrawDebugCamera_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_Rotation_Offset), 0, X2DrawDebugCamera_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_FOVDeg_Offset), 0, X2DrawDebugCamera_FOVDeg_PropertyAddress.Address, FOVDeg);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_Scale_Offset), 0, X2DrawDebugCamera_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_Color_Offset), 0, X2DrawDebugCamera_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_bPersistentLines_Offset), 0, X2DrawDebugCamera_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_LifeTime_Offset), 0, X2DrawDebugCamera_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugCamera_DepthPriority_Offset), 0, X2DrawDebugCamera_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugCamera_FunctionAddress, intPtr, X2DrawDebugCamera_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugBox2")]
	public unsafe static void X2DrawDebugBox2(bool DebugTag, UWorld InWorld, FVector Center, FVector Extent, FQuat Rotation, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugBox2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugBox2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugBox2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugBox2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_DebugTag_Offset), 0, X2DrawDebugBox2_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_InWorld_Offset), 0, X2DrawDebugBox2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_Center_Offset), 0, X2DrawDebugBox2_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_Extent_Offset), 0, X2DrawDebugBox2_Extent_PropertyAddress.Address, Extent);
		NativeReflection.InitializeValue_InContainer(X2DrawDebugBox2_Rotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_Rotation_Offset), 0, X2DrawDebugBox2_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_Color_Offset), 0, X2DrawDebugBox2_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_bPersistentLines_Offset), 0, X2DrawDebugBox2_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_LifeTime_Offset), 0, X2DrawDebugBox2_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_DepthPriority_Offset), 0, X2DrawDebugBox2_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox2_Thickness_Offset), 0, X2DrawDebugBox2_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugBox2_FunctionAddress, intPtr, X2DrawDebugBox2_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugBox")]
	public unsafe static void X2DrawDebugBox(bool DebugTag, UWorld InWorld, FVector Center, FVector Extent, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_DebugTag_Offset), 0, X2DrawDebugBox_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_InWorld_Offset), 0, X2DrawDebugBox_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_Center_Offset), 0, X2DrawDebugBox_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_Extent_Offset), 0, X2DrawDebugBox_Extent_PropertyAddress.Address, Extent);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_Color_Offset), 0, X2DrawDebugBox_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_bPersistentLines_Offset), 0, X2DrawDebugBox_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_LifeTime_Offset), 0, X2DrawDebugBox_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_DepthPriority_Offset), 0, X2DrawDebugBox_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugBox_Thickness_Offset), 0, X2DrawDebugBox_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugBox_FunctionAddress, intPtr, X2DrawDebugBox_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebugAltCone")]
	public unsafe static void X2DrawDebugAltCone(bool DebugTag, UWorld InWorld, FVector Origin, FRotator Rotation, float Length, float AngleWidth, float AngleHeight, FColor DrawColor, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebugAltCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebugAltCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebugAltCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebugAltCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_DebugTag_Offset), 0, X2DrawDebugAltCone_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_InWorld_Offset), 0, X2DrawDebugAltCone_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_Origin_Offset), 0, X2DrawDebugAltCone_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_Rotation_Offset), 0, X2DrawDebugAltCone_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_Length_Offset), 0, X2DrawDebugAltCone_Length_PropertyAddress.Address, Length);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_AngleWidth_Offset), 0, X2DrawDebugAltCone_AngleWidth_PropertyAddress.Address, AngleWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_AngleHeight_Offset), 0, X2DrawDebugAltCone_AngleHeight_PropertyAddress.Address, AngleHeight);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_DrawColor_Offset), 0, X2DrawDebugAltCone_DrawColor_PropertyAddress.Address, DrawColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_bPersistentLines_Offset), 0, X2DrawDebugAltCone_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_LifeTime_Offset), 0, X2DrawDebugAltCone_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_DepthPriority_Offset), 0, X2DrawDebugAltCone_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebugAltCone_Thickness_Offset), 0, X2DrawDebugAltCone_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebugAltCone_FunctionAddress, intPtr, X2DrawDebugAltCone_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawDebug2DDonut")]
	public unsafe static void X2DrawDebug2DDonut(bool DebugTag, UWorld InWorld, FMatrix TransformMatrix, float InnerRadius, float OuterRadius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawDebug2DDonut_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawDebug2DDonut");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawDebug2DDonut_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawDebug2DDonut_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_DebugTag_Offset), 0, X2DrawDebug2DDonut_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_InWorld_Offset), 0, X2DrawDebug2DDonut_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_TransformMatrix_Offset), 0, X2DrawDebug2DDonut_TransformMatrix_PropertyAddress.Address, TransformMatrix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_InnerRadius_Offset), 0, X2DrawDebug2DDonut_InnerRadius_PropertyAddress.Address, InnerRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_OuterRadius_Offset), 0, X2DrawDebug2DDonut_OuterRadius_PropertyAddress.Address, OuterRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_Segments_Offset), 0, X2DrawDebug2DDonut_Segments_PropertyAddress.Address, Segments);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_Color_Offset), 0, X2DrawDebug2DDonut_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_bPersistentLines_Offset), 0, X2DrawDebug2DDonut_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_LifeTime_Offset), 0, X2DrawDebug2DDonut_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_DepthPriority_Offset), 0, X2DrawDebug2DDonut_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawDebug2DDonut_Thickness_Offset), 0, X2DrawDebug2DDonut_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawDebug2DDonut_FunctionAddress, intPtr, X2DrawDebug2DDonut_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.X2DebugUtil:X2DrawCircle")]
	public unsafe static void X2DrawCircle(bool DebugTag, UWorld InWorld, FVector Base, FVector X, FVector Y, FColor Color, float Radius, int NumSides, bool bPersistentLines = false, float LifeTime = -1f, byte DepthPriority = 0, float Thickness = 0f)
	{
		if (!X2DrawCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:X2DrawCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(X2DrawCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)X2DrawCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawCircle_DebugTag_Offset), 0, X2DrawCircle_DebugTag_PropertyAddress.Address, DebugTag);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_InWorld_Offset), 0, X2DrawCircle_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_Base_Offset), 0, X2DrawCircle_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_X_Offset), 0, X2DrawCircle_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_Y_Offset), 0, X2DrawCircle_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_Color_Offset), 0, X2DrawCircle_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_Radius_Offset), 0, X2DrawCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_NumSides_Offset), 0, X2DrawCircle_NumSides_PropertyAddress.Address, NumSides);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, X2DrawCircle_bPersistentLines_Offset), 0, X2DrawCircle_bPersistentLines_PropertyAddress.Address, bPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_LifeTime_Offset), 0, X2DrawCircle_LifeTime_PropertyAddress.Address, LifeTime);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_DepthPriority_Offset), 0, X2DrawCircle_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, X2DrawCircle_Thickness_Offset), 0, X2DrawCircle_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, X2DrawCircle_FunctionAddress, intPtr, X2DrawCircle_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.X2DebugUtil:DisableAllScreenMessages")]
	public unsafe static void DisableAllScreenMessages(UObject WorldCtx)
	{
		if (!DisableAllScreenMessages_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.X2DebugUtil:DisableAllScreenMessages");
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

	static UX2DebugUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UX2DebugUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UX2DebugUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.X2DebugUtil");
		X2FlushPersistentDebugLines_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2FlushPersistentDebugLines");
		X2FlushPersistentDebugLines_ParamsSize = NativeReflection.GetFunctionParamsSize(X2FlushPersistentDebugLines_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2FlushPersistentDebugLines_DebugTag_PropertyAddress, X2FlushPersistentDebugLines_FunctionAddress, "DebugTag");
		X2FlushPersistentDebugLines_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2FlushPersistentDebugLines_FunctionAddress, "DebugTag");
		X2FlushPersistentDebugLines_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2FlushPersistentDebugLines_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2FlushPersistentDebugLines_InWorld_PropertyAddress, X2FlushPersistentDebugLines_FunctionAddress, "InWorld");
		X2FlushPersistentDebugLines_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2FlushPersistentDebugLines_FunctionAddress, "InWorld");
		X2FlushPersistentDebugLines_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2FlushPersistentDebugLines_FunctionAddress, "InWorld", Classes.FObjectProperty);
		X2FlushPersistentDebugLines_IsValid = X2FlushPersistentDebugLines_FunctionAddress != IntPtr.Zero && X2FlushPersistentDebugLines_DebugTag_IsValid && X2FlushPersistentDebugLines_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2FlushPersistentDebugLines", X2FlushPersistentDebugLines_IsValid);
		X2FlushDebugStrings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2FlushDebugStrings");
		X2FlushDebugStrings_ParamsSize = NativeReflection.GetFunctionParamsSize(X2FlushDebugStrings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2FlushDebugStrings_DebugTag_PropertyAddress, X2FlushDebugStrings_FunctionAddress, "DebugTag");
		X2FlushDebugStrings_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2FlushDebugStrings_FunctionAddress, "DebugTag");
		X2FlushDebugStrings_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2FlushDebugStrings_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2FlushDebugStrings_InWorld_PropertyAddress, X2FlushDebugStrings_FunctionAddress, "InWorld");
		X2FlushDebugStrings_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2FlushDebugStrings_FunctionAddress, "InWorld");
		X2FlushDebugStrings_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2FlushDebugStrings_FunctionAddress, "InWorld", Classes.FObjectProperty);
		X2FlushDebugStrings_IsValid = X2FlushDebugStrings_FunctionAddress != IntPtr.Zero && X2FlushDebugStrings_DebugTag_IsValid && X2FlushDebugStrings_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2FlushDebugStrings", X2FlushDebugStrings_IsValid);
		X2DrawDebugString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugString");
		X2DrawDebugString_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_DebugTag_PropertyAddress, X2DrawDebugString_FunctionAddress, "DebugTag");
		X2DrawDebugString_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "DebugTag");
		X2DrawDebugString_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_InWorld_PropertyAddress, X2DrawDebugString_FunctionAddress, "InWorld");
		X2DrawDebugString_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "InWorld");
		X2DrawDebugString_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_TextLocation_PropertyAddress, X2DrawDebugString_FunctionAddress, "TextLocation");
		X2DrawDebugString_TextLocation_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "TextLocation");
		X2DrawDebugString_TextLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "TextLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_Text_PropertyAddress, X2DrawDebugString_FunctionAddress, "Text");
		X2DrawDebugString_Text_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "Text");
		X2DrawDebugString_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_TestBaseActor_PropertyAddress, X2DrawDebugString_FunctionAddress, "TestBaseActor");
		X2DrawDebugString_TestBaseActor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "TestBaseActor");
		X2DrawDebugString_TestBaseActor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "TestBaseActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_TextColor_PropertyAddress, X2DrawDebugString_FunctionAddress, "TextColor");
		X2DrawDebugString_TextColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "TextColor");
		X2DrawDebugString_TextColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "TextColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_Duration_PropertyAddress, X2DrawDebugString_FunctionAddress, "Duration");
		X2DrawDebugString_Duration_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "Duration");
		X2DrawDebugString_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_bDrawShadow_PropertyAddress, X2DrawDebugString_FunctionAddress, "bDrawShadow");
		X2DrawDebugString_bDrawShadow_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "bDrawShadow");
		X2DrawDebugString_bDrawShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "bDrawShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugString_FontScale_PropertyAddress, X2DrawDebugString_FunctionAddress, "FontScale");
		X2DrawDebugString_FontScale_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugString_FunctionAddress, "FontScale");
		X2DrawDebugString_FontScale_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugString_FunctionAddress, "FontScale", Classes.FFloatProperty);
		X2DrawDebugString_IsValid = X2DrawDebugString_FunctionAddress != IntPtr.Zero && X2DrawDebugString_DebugTag_IsValid && X2DrawDebugString_InWorld_IsValid && X2DrawDebugString_TextLocation_IsValid && X2DrawDebugString_Text_IsValid && X2DrawDebugString_TestBaseActor_IsValid && X2DrawDebugString_TextColor_IsValid && X2DrawDebugString_Duration_IsValid && X2DrawDebugString_bDrawShadow_IsValid && X2DrawDebugString_FontScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugString", X2DrawDebugString_IsValid);
		X2DrawDebugSphere_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugSphere");
		X2DrawDebugSphere_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugSphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_DebugTag_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "DebugTag");
		X2DrawDebugSphere_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "DebugTag");
		X2DrawDebugSphere_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_InWorld_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "InWorld");
		X2DrawDebugSphere_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "InWorld");
		X2DrawDebugSphere_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_Center_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "Center");
		X2DrawDebugSphere_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "Center");
		X2DrawDebugSphere_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_Radius_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "Radius");
		X2DrawDebugSphere_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "Radius");
		X2DrawDebugSphere_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_Segments_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "Segments");
		X2DrawDebugSphere_Segments_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "Segments");
		X2DrawDebugSphere_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_Color_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "Color");
		X2DrawDebugSphere_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "Color");
		X2DrawDebugSphere_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_bPersistentLines_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "bPersistentLines");
		X2DrawDebugSphere_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "bPersistentLines");
		X2DrawDebugSphere_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_LifeTime_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "LifeTime");
		X2DrawDebugSphere_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "LifeTime");
		X2DrawDebugSphere_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_DepthPriority_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "DepthPriority");
		X2DrawDebugSphere_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "DepthPriority");
		X2DrawDebugSphere_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSphere_Thickness_PropertyAddress, X2DrawDebugSphere_FunctionAddress, "Thickness");
		X2DrawDebugSphere_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSphere_FunctionAddress, "Thickness");
		X2DrawDebugSphere_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSphere_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugSphere_IsValid = X2DrawDebugSphere_FunctionAddress != IntPtr.Zero && X2DrawDebugSphere_DebugTag_IsValid && X2DrawDebugSphere_InWorld_IsValid && X2DrawDebugSphere_Center_IsValid && X2DrawDebugSphere_Radius_IsValid && X2DrawDebugSphere_Segments_IsValid && X2DrawDebugSphere_Color_IsValid && X2DrawDebugSphere_bPersistentLines_IsValid && X2DrawDebugSphere_LifeTime_IsValid && X2DrawDebugSphere_DepthPriority_IsValid && X2DrawDebugSphere_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugSphere", X2DrawDebugSphere_IsValid);
		X2DrawDebugSolidPlane2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugSolidPlane2");
		X2DrawDebugSolidPlane2_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugSolidPlane2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_DebugTag_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "DebugTag");
		X2DrawDebugSolidPlane2_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "DebugTag");
		X2DrawDebugSolidPlane2_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_InWorld_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "InWorld");
		X2DrawDebugSolidPlane2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "InWorld");
		X2DrawDebugSolidPlane2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_P_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "P");
		X2DrawDebugSolidPlane2_P_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "P");
		X2DrawDebugSolidPlane2_P_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "P", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_Loc_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "Loc");
		X2DrawDebugSolidPlane2_Loc_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "Loc");
		X2DrawDebugSolidPlane2_Loc_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "Loc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_Extents_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "Extents");
		X2DrawDebugSolidPlane2_Extents_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "Extents");
		X2DrawDebugSolidPlane2_Extents_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "Extents", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_Color_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "Color");
		X2DrawDebugSolidPlane2_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "Color");
		X2DrawDebugSolidPlane2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_bPersistent_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "bPersistent");
		X2DrawDebugSolidPlane2_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "bPersistent");
		X2DrawDebugSolidPlane2_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_LifeTime_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "LifeTime");
		X2DrawDebugSolidPlane2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "LifeTime");
		X2DrawDebugSolidPlane2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane2_DepthPriority_PropertyAddress, X2DrawDebugSolidPlane2_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidPlane2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane2_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidPlane2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugSolidPlane2_IsValid = X2DrawDebugSolidPlane2_FunctionAddress != IntPtr.Zero && X2DrawDebugSolidPlane2_DebugTag_IsValid && X2DrawDebugSolidPlane2_InWorld_IsValid && X2DrawDebugSolidPlane2_P_IsValid && X2DrawDebugSolidPlane2_Loc_IsValid && X2DrawDebugSolidPlane2_Extents_IsValid && X2DrawDebugSolidPlane2_Color_IsValid && X2DrawDebugSolidPlane2_bPersistent_IsValid && X2DrawDebugSolidPlane2_LifeTime_IsValid && X2DrawDebugSolidPlane2_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugSolidPlane2", X2DrawDebugSolidPlane2_IsValid);
		X2DrawDebugSolidPlane_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugSolidPlane");
		X2DrawDebugSolidPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugSolidPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_DebugTag_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "DebugTag");
		X2DrawDebugSolidPlane_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "DebugTag");
		X2DrawDebugSolidPlane_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_InWorld_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "InWorld");
		X2DrawDebugSolidPlane_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "InWorld");
		X2DrawDebugSolidPlane_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_P_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "P");
		X2DrawDebugSolidPlane_P_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "P");
		X2DrawDebugSolidPlane_P_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "P", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_Loc_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "Loc");
		X2DrawDebugSolidPlane_Loc_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "Loc");
		X2DrawDebugSolidPlane_Loc_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "Loc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_Size_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "Size");
		X2DrawDebugSolidPlane_Size_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "Size");
		X2DrawDebugSolidPlane_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "Size", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_Color_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "Color");
		X2DrawDebugSolidPlane_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "Color");
		X2DrawDebugSolidPlane_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_bPersistent_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "bPersistent");
		X2DrawDebugSolidPlane_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "bPersistent");
		X2DrawDebugSolidPlane_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_LifeTime_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "LifeTime");
		X2DrawDebugSolidPlane_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "LifeTime");
		X2DrawDebugSolidPlane_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidPlane_DepthPriority_PropertyAddress, X2DrawDebugSolidPlane_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidPlane_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidPlane_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidPlane_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidPlane_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugSolidPlane_IsValid = X2DrawDebugSolidPlane_FunctionAddress != IntPtr.Zero && X2DrawDebugSolidPlane_DebugTag_IsValid && X2DrawDebugSolidPlane_InWorld_IsValid && X2DrawDebugSolidPlane_P_IsValid && X2DrawDebugSolidPlane_Loc_IsValid && X2DrawDebugSolidPlane_Size_IsValid && X2DrawDebugSolidPlane_Color_IsValid && X2DrawDebugSolidPlane_bPersistent_IsValid && X2DrawDebugSolidPlane_LifeTime_IsValid && X2DrawDebugSolidPlane_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugSolidPlane", X2DrawDebugSolidPlane_IsValid);
		X2DrawDebugSolidBox3_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugSolidBox3");
		X2DrawDebugSolidBox3_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugSolidBox3_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_DebugTag_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "DebugTag");
		X2DrawDebugSolidBox3_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "DebugTag");
		X2DrawDebugSolidBox3_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_InWorld_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "InWorld");
		X2DrawDebugSolidBox3_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "InWorld");
		X2DrawDebugSolidBox3_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_Center_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "Center");
		X2DrawDebugSolidBox3_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "Center");
		X2DrawDebugSolidBox3_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_Extent_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "Extent");
		X2DrawDebugSolidBox3_Extent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "Extent");
		X2DrawDebugSolidBox3_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_Rotation_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "Rotation");
		X2DrawDebugSolidBox3_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "Rotation");
		X2DrawDebugSolidBox3_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_Color_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "Color");
		X2DrawDebugSolidBox3_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "Color");
		X2DrawDebugSolidBox3_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_bPersistent_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "bPersistent");
		X2DrawDebugSolidBox3_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "bPersistent");
		X2DrawDebugSolidBox3_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_LifeTime_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "LifeTime");
		X2DrawDebugSolidBox3_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "LifeTime");
		X2DrawDebugSolidBox3_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox3_DepthPriority_PropertyAddress, X2DrawDebugSolidBox3_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidBox3_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox3_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidBox3_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox3_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugSolidBox3_IsValid = X2DrawDebugSolidBox3_FunctionAddress != IntPtr.Zero && X2DrawDebugSolidBox3_DebugTag_IsValid && X2DrawDebugSolidBox3_InWorld_IsValid && X2DrawDebugSolidBox3_Center_IsValid && X2DrawDebugSolidBox3_Extent_IsValid && X2DrawDebugSolidBox3_Rotation_IsValid && X2DrawDebugSolidBox3_Color_IsValid && X2DrawDebugSolidBox3_bPersistent_IsValid && X2DrawDebugSolidBox3_LifeTime_IsValid && X2DrawDebugSolidBox3_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox3", X2DrawDebugSolidBox3_IsValid);
		X2DrawDebugSolidBox2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugSolidBox2");
		X2DrawDebugSolidBox2_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugSolidBox2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_DebugTag_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "DebugTag");
		X2DrawDebugSolidBox2_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "DebugTag");
		X2DrawDebugSolidBox2_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_InWorld_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "InWorld");
		X2DrawDebugSolidBox2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "InWorld");
		X2DrawDebugSolidBox2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_Center_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "Center");
		X2DrawDebugSolidBox2_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "Center");
		X2DrawDebugSolidBox2_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_Extent_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "Extent");
		X2DrawDebugSolidBox2_Extent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "Extent");
		X2DrawDebugSolidBox2_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_Color_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "Color");
		X2DrawDebugSolidBox2_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "Color");
		X2DrawDebugSolidBox2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_bPersistent_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "bPersistent");
		X2DrawDebugSolidBox2_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "bPersistent");
		X2DrawDebugSolidBox2_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_LifeTime_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "LifeTime");
		X2DrawDebugSolidBox2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "LifeTime");
		X2DrawDebugSolidBox2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox2_DepthPriority_PropertyAddress, X2DrawDebugSolidBox2_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidBox2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox2_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidBox2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugSolidBox2_IsValid = X2DrawDebugSolidBox2_FunctionAddress != IntPtr.Zero && X2DrawDebugSolidBox2_DebugTag_IsValid && X2DrawDebugSolidBox2_InWorld_IsValid && X2DrawDebugSolidBox2_Center_IsValid && X2DrawDebugSolidBox2_Extent_IsValid && X2DrawDebugSolidBox2_Color_IsValid && X2DrawDebugSolidBox2_bPersistent_IsValid && X2DrawDebugSolidBox2_LifeTime_IsValid && X2DrawDebugSolidBox2_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox2", X2DrawDebugSolidBox2_IsValid);
		X2DrawDebugSolidBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugSolidBox");
		X2DrawDebugSolidBox_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugSolidBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_DebugTag_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "DebugTag");
		X2DrawDebugSolidBox_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "DebugTag");
		X2DrawDebugSolidBox_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_InWorld_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "InWorld");
		X2DrawDebugSolidBox_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "InWorld");
		X2DrawDebugSolidBox_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_Box_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "Box");
		X2DrawDebugSolidBox_Box_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "Box");
		X2DrawDebugSolidBox_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_Color_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "Color");
		X2DrawDebugSolidBox_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "Color");
		X2DrawDebugSolidBox_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_Transform_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "Transform");
		X2DrawDebugSolidBox_Transform_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "Transform");
		X2DrawDebugSolidBox_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_bPersistent_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "bPersistent");
		X2DrawDebugSolidBox_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "bPersistent");
		X2DrawDebugSolidBox_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_LifeTime_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "LifeTime");
		X2DrawDebugSolidBox_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "LifeTime");
		X2DrawDebugSolidBox_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugSolidBox_DepthPriority_PropertyAddress, X2DrawDebugSolidBox_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidBox_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugSolidBox_FunctionAddress, "DepthPriority");
		X2DrawDebugSolidBox_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugSolidBox_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugSolidBox_IsValid = X2DrawDebugSolidBox_FunctionAddress != IntPtr.Zero && X2DrawDebugSolidBox_DebugTag_IsValid && X2DrawDebugSolidBox_InWorld_IsValid && X2DrawDebugSolidBox_Box_IsValid && X2DrawDebugSolidBox_Color_IsValid && X2DrawDebugSolidBox_Transform_IsValid && X2DrawDebugSolidBox_bPersistent_IsValid && X2DrawDebugSolidBox_LifeTime_IsValid && X2DrawDebugSolidBox_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugSolidBox", X2DrawDebugSolidBox_IsValid);
		X2DrawDebugPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugPoint");
		X2DrawDebugPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_DebugTag_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "DebugTag");
		X2DrawDebugPoint_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "DebugTag");
		X2DrawDebugPoint_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_InWorld_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "InWorld");
		X2DrawDebugPoint_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "InWorld");
		X2DrawDebugPoint_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_Position_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "Position");
		X2DrawDebugPoint_Position_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "Position");
		X2DrawDebugPoint_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_Size_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "Size");
		X2DrawDebugPoint_Size_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "Size");
		X2DrawDebugPoint_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "Size", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_PointColor_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "PointColor");
		X2DrawDebugPoint_PointColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "PointColor");
		X2DrawDebugPoint_PointColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "PointColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_bPersistentLines_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "bPersistentLines");
		X2DrawDebugPoint_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "bPersistentLines");
		X2DrawDebugPoint_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_LifeTime_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "LifeTime");
		X2DrawDebugPoint_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "LifeTime");
		X2DrawDebugPoint_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugPoint_DepthPriority_PropertyAddress, X2DrawDebugPoint_FunctionAddress, "DepthPriority");
		X2DrawDebugPoint_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugPoint_FunctionAddress, "DepthPriority");
		X2DrawDebugPoint_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugPoint_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugPoint_IsValid = X2DrawDebugPoint_FunctionAddress != IntPtr.Zero && X2DrawDebugPoint_DebugTag_IsValid && X2DrawDebugPoint_InWorld_IsValid && X2DrawDebugPoint_Position_IsValid && X2DrawDebugPoint_Size_IsValid && X2DrawDebugPoint_PointColor_IsValid && X2DrawDebugPoint_bPersistentLines_IsValid && X2DrawDebugPoint_LifeTime_IsValid && X2DrawDebugPoint_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugPoint", X2DrawDebugPoint_IsValid);
		X2DrawDebugMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugMesh");
		X2DrawDebugMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_DebugTag_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "DebugTag");
		X2DrawDebugMesh_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "DebugTag");
		X2DrawDebugMesh_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_InWorld_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "InWorld");
		X2DrawDebugMesh_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "InWorld");
		X2DrawDebugMesh_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_Verts_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "Verts");
		X2DrawDebugMesh_Verts_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "Verts");
		X2DrawDebugMesh_Verts_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "Verts", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_Indices_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "Indices");
		X2DrawDebugMesh_Indices_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "Indices");
		X2DrawDebugMesh_Indices_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "Indices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_Color_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "Color");
		X2DrawDebugMesh_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "Color");
		X2DrawDebugMesh_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_bPersistent_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "bPersistent");
		X2DrawDebugMesh_bPersistent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "bPersistent");
		X2DrawDebugMesh_bPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "bPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_LifeTime_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "LifeTime");
		X2DrawDebugMesh_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "LifeTime");
		X2DrawDebugMesh_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugMesh_DepthPriority_PropertyAddress, X2DrawDebugMesh_FunctionAddress, "DepthPriority");
		X2DrawDebugMesh_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugMesh_FunctionAddress, "DepthPriority");
		X2DrawDebugMesh_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugMesh_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugMesh_IsValid = X2DrawDebugMesh_FunctionAddress != IntPtr.Zero && X2DrawDebugMesh_DebugTag_IsValid && X2DrawDebugMesh_InWorld_IsValid && X2DrawDebugMesh_Verts_IsValid && X2DrawDebugMesh_Indices_IsValid && X2DrawDebugMesh_Color_IsValid && X2DrawDebugMesh_bPersistent_IsValid && X2DrawDebugMesh_LifeTime_IsValid && X2DrawDebugMesh_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugMesh", X2DrawDebugMesh_IsValid);
		X2DrawDebugLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugLine");
		X2DrawDebugLine_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_DebugTag_PropertyAddress, X2DrawDebugLine_FunctionAddress, "DebugTag");
		X2DrawDebugLine_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "DebugTag");
		X2DrawDebugLine_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_InWorld_PropertyAddress, X2DrawDebugLine_FunctionAddress, "InWorld");
		X2DrawDebugLine_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "InWorld");
		X2DrawDebugLine_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_LineStart_PropertyAddress, X2DrawDebugLine_FunctionAddress, "LineStart");
		X2DrawDebugLine_LineStart_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "LineStart");
		X2DrawDebugLine_LineStart_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "LineStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_LineEnd_PropertyAddress, X2DrawDebugLine_FunctionAddress, "LineEnd");
		X2DrawDebugLine_LineEnd_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "LineEnd");
		X2DrawDebugLine_LineEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "LineEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_Color_PropertyAddress, X2DrawDebugLine_FunctionAddress, "Color");
		X2DrawDebugLine_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "Color");
		X2DrawDebugLine_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_bPersistentLines_PropertyAddress, X2DrawDebugLine_FunctionAddress, "bPersistentLines");
		X2DrawDebugLine_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "bPersistentLines");
		X2DrawDebugLine_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_LifeTime_PropertyAddress, X2DrawDebugLine_FunctionAddress, "LifeTime");
		X2DrawDebugLine_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "LifeTime");
		X2DrawDebugLine_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_DepthPriority_PropertyAddress, X2DrawDebugLine_FunctionAddress, "DepthPriority");
		X2DrawDebugLine_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "DepthPriority");
		X2DrawDebugLine_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugLine_Thickness_PropertyAddress, X2DrawDebugLine_FunctionAddress, "Thickness");
		X2DrawDebugLine_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugLine_FunctionAddress, "Thickness");
		X2DrawDebugLine_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugLine_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugLine_IsValid = X2DrawDebugLine_FunctionAddress != IntPtr.Zero && X2DrawDebugLine_DebugTag_IsValid && X2DrawDebugLine_InWorld_IsValid && X2DrawDebugLine_LineStart_IsValid && X2DrawDebugLine_LineEnd_IsValid && X2DrawDebugLine_Color_IsValid && X2DrawDebugLine_bPersistentLines_IsValid && X2DrawDebugLine_LifeTime_IsValid && X2DrawDebugLine_DepthPriority_IsValid && X2DrawDebugLine_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugLine", X2DrawDebugLine_IsValid);
		X2DrawDebugFrustum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugFrustum");
		X2DrawDebugFrustum_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugFrustum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_DebugTag_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "DebugTag");
		X2DrawDebugFrustum_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "DebugTag");
		X2DrawDebugFrustum_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_InWorld_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "InWorld");
		X2DrawDebugFrustum_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "InWorld");
		X2DrawDebugFrustum_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_FrustumToWorld_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "FrustumToWorld");
		X2DrawDebugFrustum_FrustumToWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "FrustumToWorld");
		X2DrawDebugFrustum_FrustumToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "FrustumToWorld", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_Color_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "Color");
		X2DrawDebugFrustum_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "Color");
		X2DrawDebugFrustum_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_bPersistentLines_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "bPersistentLines");
		X2DrawDebugFrustum_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "bPersistentLines");
		X2DrawDebugFrustum_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_LifeTime_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "LifeTime");
		X2DrawDebugFrustum_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "LifeTime");
		X2DrawDebugFrustum_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_DepthPriority_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "DepthPriority");
		X2DrawDebugFrustum_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "DepthPriority");
		X2DrawDebugFrustum_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugFrustum_Thickness_PropertyAddress, X2DrawDebugFrustum_FunctionAddress, "Thickness");
		X2DrawDebugFrustum_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugFrustum_FunctionAddress, "Thickness");
		X2DrawDebugFrustum_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugFrustum_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugFrustum_IsValid = X2DrawDebugFrustum_FunctionAddress != IntPtr.Zero && X2DrawDebugFrustum_DebugTag_IsValid && X2DrawDebugFrustum_InWorld_IsValid && X2DrawDebugFrustum_FrustumToWorld_IsValid && X2DrawDebugFrustum_Color_IsValid && X2DrawDebugFrustum_bPersistentLines_IsValid && X2DrawDebugFrustum_LifeTime_IsValid && X2DrawDebugFrustum_DepthPriority_IsValid && X2DrawDebugFrustum_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugFrustum", X2DrawDebugFrustum_IsValid);
		X2DrawDebugDirectionalArrow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugDirectionalArrow");
		X2DrawDebugDirectionalArrow_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugDirectionalArrow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_DebugTag_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "DebugTag");
		X2DrawDebugDirectionalArrow_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "DebugTag");
		X2DrawDebugDirectionalArrow_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_InWorld_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "InWorld");
		X2DrawDebugDirectionalArrow_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "InWorld");
		X2DrawDebugDirectionalArrow_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_LineStart_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "LineStart");
		X2DrawDebugDirectionalArrow_LineStart_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "LineStart");
		X2DrawDebugDirectionalArrow_LineStart_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "LineStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_LineEnd_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "LineEnd");
		X2DrawDebugDirectionalArrow_LineEnd_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "LineEnd");
		X2DrawDebugDirectionalArrow_LineEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "LineEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_ArrowSize_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "ArrowSize");
		X2DrawDebugDirectionalArrow_ArrowSize_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "ArrowSize");
		X2DrawDebugDirectionalArrow_ArrowSize_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "ArrowSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_Color_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "Color");
		X2DrawDebugDirectionalArrow_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "Color");
		X2DrawDebugDirectionalArrow_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_bPersistentLines_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "bPersistentLines");
		X2DrawDebugDirectionalArrow_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "bPersistentLines");
		X2DrawDebugDirectionalArrow_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_LifeTime_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "LifeTime");
		X2DrawDebugDirectionalArrow_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "LifeTime");
		X2DrawDebugDirectionalArrow_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_DepthPriority_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "DepthPriority");
		X2DrawDebugDirectionalArrow_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "DepthPriority");
		X2DrawDebugDirectionalArrow_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugDirectionalArrow_Thickness_PropertyAddress, X2DrawDebugDirectionalArrow_FunctionAddress, "Thickness");
		X2DrawDebugDirectionalArrow_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugDirectionalArrow_FunctionAddress, "Thickness");
		X2DrawDebugDirectionalArrow_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugDirectionalArrow_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugDirectionalArrow_IsValid = X2DrawDebugDirectionalArrow_FunctionAddress != IntPtr.Zero && X2DrawDebugDirectionalArrow_DebugTag_IsValid && X2DrawDebugDirectionalArrow_InWorld_IsValid && X2DrawDebugDirectionalArrow_LineStart_IsValid && X2DrawDebugDirectionalArrow_LineEnd_IsValid && X2DrawDebugDirectionalArrow_ArrowSize_IsValid && X2DrawDebugDirectionalArrow_Color_IsValid && X2DrawDebugDirectionalArrow_bPersistentLines_IsValid && X2DrawDebugDirectionalArrow_LifeTime_IsValid && X2DrawDebugDirectionalArrow_DepthPriority_IsValid && X2DrawDebugDirectionalArrow_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugDirectionalArrow", X2DrawDebugDirectionalArrow_IsValid);
		X2DrawDebugCylinder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCylinder");
		X2DrawDebugCylinder_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCylinder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_DebugTag_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "DebugTag");
		X2DrawDebugCylinder_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "DebugTag");
		X2DrawDebugCylinder_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_InWorld_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "InWorld");
		X2DrawDebugCylinder_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "InWorld");
		X2DrawDebugCylinder_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_Start_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "Start");
		X2DrawDebugCylinder_Start_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "Start");
		X2DrawDebugCylinder_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_End_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "End");
		X2DrawDebugCylinder_End_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "End");
		X2DrawDebugCylinder_End_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_Radius_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "Radius");
		X2DrawDebugCylinder_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "Radius");
		X2DrawDebugCylinder_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_Segments_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "Segments");
		X2DrawDebugCylinder_Segments_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "Segments");
		X2DrawDebugCylinder_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_Color_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "Color");
		X2DrawDebugCylinder_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "Color");
		X2DrawDebugCylinder_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_bPersistentLines_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "bPersistentLines");
		X2DrawDebugCylinder_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "bPersistentLines");
		X2DrawDebugCylinder_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_LifeTime_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "LifeTime");
		X2DrawDebugCylinder_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "LifeTime");
		X2DrawDebugCylinder_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_DepthPriority_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "DepthPriority");
		X2DrawDebugCylinder_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "DepthPriority");
		X2DrawDebugCylinder_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCylinder_Thickness_PropertyAddress, X2DrawDebugCylinder_FunctionAddress, "Thickness");
		X2DrawDebugCylinder_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCylinder_FunctionAddress, "Thickness");
		X2DrawDebugCylinder_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCylinder_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugCylinder_IsValid = X2DrawDebugCylinder_FunctionAddress != IntPtr.Zero && X2DrawDebugCylinder_DebugTag_IsValid && X2DrawDebugCylinder_InWorld_IsValid && X2DrawDebugCylinder_Start_IsValid && X2DrawDebugCylinder_End_IsValid && X2DrawDebugCylinder_Radius_IsValid && X2DrawDebugCylinder_Segments_IsValid && X2DrawDebugCylinder_Color_IsValid && X2DrawDebugCylinder_bPersistentLines_IsValid && X2DrawDebugCylinder_LifeTime_IsValid && X2DrawDebugCylinder_DepthPriority_IsValid && X2DrawDebugCylinder_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCylinder", X2DrawDebugCylinder_IsValid);
		X2DrawDebugCrosshairs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCrosshairs");
		X2DrawDebugCrosshairs_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCrosshairs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_DebugTag_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "DebugTag");
		X2DrawDebugCrosshairs_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "DebugTag");
		X2DrawDebugCrosshairs_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_InWorld_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "InWorld");
		X2DrawDebugCrosshairs_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "InWorld");
		X2DrawDebugCrosshairs_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_AxisLoc_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "AxisLoc");
		X2DrawDebugCrosshairs_AxisLoc_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "AxisLoc");
		X2DrawDebugCrosshairs_AxisLoc_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "AxisLoc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_AxisRot_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "AxisRot");
		X2DrawDebugCrosshairs_AxisRot_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "AxisRot");
		X2DrawDebugCrosshairs_AxisRot_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "AxisRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_Scale_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "Scale");
		X2DrawDebugCrosshairs_Scale_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "Scale");
		X2DrawDebugCrosshairs_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_Color_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "Color");
		X2DrawDebugCrosshairs_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "Color");
		X2DrawDebugCrosshairs_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_bPersistentLines_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "bPersistentLines");
		X2DrawDebugCrosshairs_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "bPersistentLines");
		X2DrawDebugCrosshairs_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_LifeTime_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "LifeTime");
		X2DrawDebugCrosshairs_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "LifeTime");
		X2DrawDebugCrosshairs_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCrosshairs_DepthPriority_PropertyAddress, X2DrawDebugCrosshairs_FunctionAddress, "DepthPriority");
		X2DrawDebugCrosshairs_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCrosshairs_FunctionAddress, "DepthPriority");
		X2DrawDebugCrosshairs_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCrosshairs_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugCrosshairs_IsValid = X2DrawDebugCrosshairs_FunctionAddress != IntPtr.Zero && X2DrawDebugCrosshairs_DebugTag_IsValid && X2DrawDebugCrosshairs_InWorld_IsValid && X2DrawDebugCrosshairs_AxisLoc_IsValid && X2DrawDebugCrosshairs_AxisRot_IsValid && X2DrawDebugCrosshairs_Scale_IsValid && X2DrawDebugCrosshairs_Color_IsValid && X2DrawDebugCrosshairs_bPersistentLines_IsValid && X2DrawDebugCrosshairs_LifeTime_IsValid && X2DrawDebugCrosshairs_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCrosshairs", X2DrawDebugCrosshairs_IsValid);
		X2DrawDebugCoordinateSystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCoordinateSystem");
		X2DrawDebugCoordinateSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCoordinateSystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_DebugTag_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "DebugTag");
		X2DrawDebugCoordinateSystem_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "DebugTag");
		X2DrawDebugCoordinateSystem_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_InWorld_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "InWorld");
		X2DrawDebugCoordinateSystem_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "InWorld");
		X2DrawDebugCoordinateSystem_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_AxisLoc_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "AxisLoc");
		X2DrawDebugCoordinateSystem_AxisLoc_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "AxisLoc");
		X2DrawDebugCoordinateSystem_AxisLoc_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "AxisLoc", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_AxisRot_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "AxisRot");
		X2DrawDebugCoordinateSystem_AxisRot_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "AxisRot");
		X2DrawDebugCoordinateSystem_AxisRot_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "AxisRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_Scale_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "Scale");
		X2DrawDebugCoordinateSystem_Scale_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "Scale");
		X2DrawDebugCoordinateSystem_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_bPersistentLines_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "bPersistentLines");
		X2DrawDebugCoordinateSystem_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "bPersistentLines");
		X2DrawDebugCoordinateSystem_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_LifeTime_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "LifeTime");
		X2DrawDebugCoordinateSystem_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "LifeTime");
		X2DrawDebugCoordinateSystem_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_DepthPriority_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "DepthPriority");
		X2DrawDebugCoordinateSystem_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "DepthPriority");
		X2DrawDebugCoordinateSystem_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCoordinateSystem_Thickness_PropertyAddress, X2DrawDebugCoordinateSystem_FunctionAddress, "Thickness");
		X2DrawDebugCoordinateSystem_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCoordinateSystem_FunctionAddress, "Thickness");
		X2DrawDebugCoordinateSystem_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCoordinateSystem_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugCoordinateSystem_IsValid = X2DrawDebugCoordinateSystem_FunctionAddress != IntPtr.Zero && X2DrawDebugCoordinateSystem_DebugTag_IsValid && X2DrawDebugCoordinateSystem_InWorld_IsValid && X2DrawDebugCoordinateSystem_AxisLoc_IsValid && X2DrawDebugCoordinateSystem_AxisRot_IsValid && X2DrawDebugCoordinateSystem_Scale_IsValid && X2DrawDebugCoordinateSystem_bPersistentLines_IsValid && X2DrawDebugCoordinateSystem_LifeTime_IsValid && X2DrawDebugCoordinateSystem_DepthPriority_IsValid && X2DrawDebugCoordinateSystem_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCoordinateSystem", X2DrawDebugCoordinateSystem_IsValid);
		X2DrawDebugCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCone");
		X2DrawDebugCone_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_DebugTag_PropertyAddress, X2DrawDebugCone_FunctionAddress, "DebugTag");
		X2DrawDebugCone_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "DebugTag");
		X2DrawDebugCone_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_InWorld_PropertyAddress, X2DrawDebugCone_FunctionAddress, "InWorld");
		X2DrawDebugCone_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "InWorld");
		X2DrawDebugCone_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_Origin_PropertyAddress, X2DrawDebugCone_FunctionAddress, "Origin");
		X2DrawDebugCone_Origin_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "Origin");
		X2DrawDebugCone_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_Direction_PropertyAddress, X2DrawDebugCone_FunctionAddress, "Direction");
		X2DrawDebugCone_Direction_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "Direction");
		X2DrawDebugCone_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_Length_PropertyAddress, X2DrawDebugCone_FunctionAddress, "Length");
		X2DrawDebugCone_Length_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "Length");
		X2DrawDebugCone_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_AngleWidth_PropertyAddress, X2DrawDebugCone_FunctionAddress, "AngleWidth");
		X2DrawDebugCone_AngleWidth_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "AngleWidth");
		X2DrawDebugCone_AngleWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "AngleWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_AngleHeight_PropertyAddress, X2DrawDebugCone_FunctionAddress, "AngleHeight");
		X2DrawDebugCone_AngleHeight_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "AngleHeight");
		X2DrawDebugCone_AngleHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "AngleHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_NumSides_PropertyAddress, X2DrawDebugCone_FunctionAddress, "NumSides");
		X2DrawDebugCone_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "NumSides");
		X2DrawDebugCone_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_Color_PropertyAddress, X2DrawDebugCone_FunctionAddress, "Color");
		X2DrawDebugCone_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "Color");
		X2DrawDebugCone_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_bPersistentLines_PropertyAddress, X2DrawDebugCone_FunctionAddress, "bPersistentLines");
		X2DrawDebugCone_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "bPersistentLines");
		X2DrawDebugCone_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_LifeTime_PropertyAddress, X2DrawDebugCone_FunctionAddress, "LifeTime");
		X2DrawDebugCone_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "LifeTime");
		X2DrawDebugCone_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_DepthPriority_PropertyAddress, X2DrawDebugCone_FunctionAddress, "DepthPriority");
		X2DrawDebugCone_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "DepthPriority");
		X2DrawDebugCone_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCone_Thickness_PropertyAddress, X2DrawDebugCone_FunctionAddress, "Thickness");
		X2DrawDebugCone_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCone_FunctionAddress, "Thickness");
		X2DrawDebugCone_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCone_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugCone_IsValid = X2DrawDebugCone_FunctionAddress != IntPtr.Zero && X2DrawDebugCone_DebugTag_IsValid && X2DrawDebugCone_InWorld_IsValid && X2DrawDebugCone_Origin_IsValid && X2DrawDebugCone_Direction_IsValid && X2DrawDebugCone_Length_IsValid && X2DrawDebugCone_AngleWidth_IsValid && X2DrawDebugCone_AngleHeight_IsValid && X2DrawDebugCone_NumSides_IsValid && X2DrawDebugCone_Color_IsValid && X2DrawDebugCone_bPersistentLines_IsValid && X2DrawDebugCone_LifeTime_IsValid && X2DrawDebugCone_DepthPriority_IsValid && X2DrawDebugCone_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCone", X2DrawDebugCone_IsValid);
		X2DrawDebugCircle2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCircle2");
		X2DrawDebugCircle2_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCircle2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_DebugTag_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "DebugTag");
		X2DrawDebugCircle2_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "DebugTag");
		X2DrawDebugCircle2_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_InWorld_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "InWorld");
		X2DrawDebugCircle2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "InWorld");
		X2DrawDebugCircle2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_Center_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "Center");
		X2DrawDebugCircle2_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "Center");
		X2DrawDebugCircle2_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_Radius_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "Radius");
		X2DrawDebugCircle2_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "Radius");
		X2DrawDebugCircle2_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_Segments_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "Segments");
		X2DrawDebugCircle2_Segments_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "Segments");
		X2DrawDebugCircle2_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_Color_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "Color");
		X2DrawDebugCircle2_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "Color");
		X2DrawDebugCircle2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_bPersistentLines_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "bPersistentLines");
		X2DrawDebugCircle2_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "bPersistentLines");
		X2DrawDebugCircle2_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_LifeTime_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "LifeTime");
		X2DrawDebugCircle2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "LifeTime");
		X2DrawDebugCircle2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_DepthPriority_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "DepthPriority");
		X2DrawDebugCircle2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "DepthPriority");
		X2DrawDebugCircle2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_Thickness_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "Thickness");
		X2DrawDebugCircle2_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "Thickness");
		X2DrawDebugCircle2_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_YAxis_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "YAxis");
		X2DrawDebugCircle2_YAxis_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "YAxis");
		X2DrawDebugCircle2_YAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "YAxis", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_ZAxis_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "ZAxis");
		X2DrawDebugCircle2_ZAxis_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "ZAxis");
		X2DrawDebugCircle2_ZAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "ZAxis", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle2_bDrawAxis_PropertyAddress, X2DrawDebugCircle2_FunctionAddress, "bDrawAxis");
		X2DrawDebugCircle2_bDrawAxis_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle2_FunctionAddress, "bDrawAxis");
		X2DrawDebugCircle2_bDrawAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle2_FunctionAddress, "bDrawAxis", Classes.FBoolProperty);
		X2DrawDebugCircle2_IsValid = X2DrawDebugCircle2_FunctionAddress != IntPtr.Zero && X2DrawDebugCircle2_DebugTag_IsValid && X2DrawDebugCircle2_InWorld_IsValid && X2DrawDebugCircle2_Center_IsValid && X2DrawDebugCircle2_Radius_IsValid && X2DrawDebugCircle2_Segments_IsValid && X2DrawDebugCircle2_Color_IsValid && X2DrawDebugCircle2_bPersistentLines_IsValid && X2DrawDebugCircle2_LifeTime_IsValid && X2DrawDebugCircle2_DepthPriority_IsValid && X2DrawDebugCircle2_Thickness_IsValid && X2DrawDebugCircle2_YAxis_IsValid && X2DrawDebugCircle2_ZAxis_IsValid && X2DrawDebugCircle2_bDrawAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCircle2", X2DrawDebugCircle2_IsValid);
		X2DrawDebugCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCircle");
		X2DrawDebugCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_DebugTag_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "DebugTag");
		X2DrawDebugCircle_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "DebugTag");
		X2DrawDebugCircle_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_InWorld_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "InWorld");
		X2DrawDebugCircle_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "InWorld");
		X2DrawDebugCircle_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_TransformMatrix_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "TransformMatrix");
		X2DrawDebugCircle_TransformMatrix_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "TransformMatrix");
		X2DrawDebugCircle_TransformMatrix_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "TransformMatrix", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_Radius_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "Radius");
		X2DrawDebugCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "Radius");
		X2DrawDebugCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_Segments_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "Segments");
		X2DrawDebugCircle_Segments_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "Segments");
		X2DrawDebugCircle_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_Color_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "Color");
		X2DrawDebugCircle_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "Color");
		X2DrawDebugCircle_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_bPersistentLines_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "bPersistentLines");
		X2DrawDebugCircle_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "bPersistentLines");
		X2DrawDebugCircle_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_LifeTime_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "LifeTime");
		X2DrawDebugCircle_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "LifeTime");
		X2DrawDebugCircle_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_DepthPriority_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "DepthPriority");
		X2DrawDebugCircle_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "DepthPriority");
		X2DrawDebugCircle_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_Thickness_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "Thickness");
		X2DrawDebugCircle_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "Thickness");
		X2DrawDebugCircle_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCircle_bDrawAxis_PropertyAddress, X2DrawDebugCircle_FunctionAddress, "bDrawAxis");
		X2DrawDebugCircle_bDrawAxis_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCircle_FunctionAddress, "bDrawAxis");
		X2DrawDebugCircle_bDrawAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCircle_FunctionAddress, "bDrawAxis", Classes.FBoolProperty);
		X2DrawDebugCircle_IsValid = X2DrawDebugCircle_FunctionAddress != IntPtr.Zero && X2DrawDebugCircle_DebugTag_IsValid && X2DrawDebugCircle_InWorld_IsValid && X2DrawDebugCircle_TransformMatrix_IsValid && X2DrawDebugCircle_Radius_IsValid && X2DrawDebugCircle_Segments_IsValid && X2DrawDebugCircle_Color_IsValid && X2DrawDebugCircle_bPersistentLines_IsValid && X2DrawDebugCircle_LifeTime_IsValid && X2DrawDebugCircle_DepthPriority_IsValid && X2DrawDebugCircle_Thickness_IsValid && X2DrawDebugCircle_bDrawAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCircle", X2DrawDebugCircle_IsValid);
		X2DrawDebugCapsule_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCapsule");
		X2DrawDebugCapsule_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCapsule_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_DebugTag_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "DebugTag");
		X2DrawDebugCapsule_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "DebugTag");
		X2DrawDebugCapsule_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_InWorld_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "InWorld");
		X2DrawDebugCapsule_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "InWorld");
		X2DrawDebugCapsule_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_Center_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "Center");
		X2DrawDebugCapsule_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "Center");
		X2DrawDebugCapsule_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_HalfHeight_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "HalfHeight");
		X2DrawDebugCapsule_HalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "HalfHeight");
		X2DrawDebugCapsule_HalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "HalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_Radius_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "Radius");
		X2DrawDebugCapsule_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "Radius");
		X2DrawDebugCapsule_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_Rotation_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "Rotation");
		X2DrawDebugCapsule_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "Rotation");
		X2DrawDebugCapsule_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_Color_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "Color");
		X2DrawDebugCapsule_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "Color");
		X2DrawDebugCapsule_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_bPersistentLines_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "bPersistentLines");
		X2DrawDebugCapsule_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "bPersistentLines");
		X2DrawDebugCapsule_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_LifeTime_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "LifeTime");
		X2DrawDebugCapsule_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "LifeTime");
		X2DrawDebugCapsule_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_DepthPriority_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "DepthPriority");
		X2DrawDebugCapsule_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "DepthPriority");
		X2DrawDebugCapsule_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCapsule_Thickness_PropertyAddress, X2DrawDebugCapsule_FunctionAddress, "Thickness");
		X2DrawDebugCapsule_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCapsule_FunctionAddress, "Thickness");
		X2DrawDebugCapsule_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCapsule_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugCapsule_IsValid = X2DrawDebugCapsule_FunctionAddress != IntPtr.Zero && X2DrawDebugCapsule_DebugTag_IsValid && X2DrawDebugCapsule_InWorld_IsValid && X2DrawDebugCapsule_Center_IsValid && X2DrawDebugCapsule_HalfHeight_IsValid && X2DrawDebugCapsule_Radius_IsValid && X2DrawDebugCapsule_Rotation_IsValid && X2DrawDebugCapsule_Color_IsValid && X2DrawDebugCapsule_bPersistentLines_IsValid && X2DrawDebugCapsule_LifeTime_IsValid && X2DrawDebugCapsule_DepthPriority_IsValid && X2DrawDebugCapsule_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCapsule", X2DrawDebugCapsule_IsValid);
		X2DrawDebugCanvasWireSphere_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvasWireSphere");
		X2DrawDebugCanvasWireSphere_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvasWireSphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireSphere_DebugTag_PropertyAddress, X2DrawDebugCanvasWireSphere_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasWireSphere_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireSphere_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasWireSphere_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireSphere_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireSphere_Canvas_PropertyAddress, X2DrawDebugCanvasWireSphere_FunctionAddress, "Canvas");
		X2DrawDebugCanvasWireSphere_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireSphere_FunctionAddress, "Canvas");
		X2DrawDebugCanvasWireSphere_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireSphere_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireSphere_Base_PropertyAddress, X2DrawDebugCanvasWireSphere_FunctionAddress, "Base");
		X2DrawDebugCanvasWireSphere_Base_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireSphere_FunctionAddress, "Base");
		X2DrawDebugCanvasWireSphere_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireSphere_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireSphere_Color_PropertyAddress, X2DrawDebugCanvasWireSphere_FunctionAddress, "Color");
		X2DrawDebugCanvasWireSphere_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireSphere_FunctionAddress, "Color");
		X2DrawDebugCanvasWireSphere_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireSphere_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireSphere_Radius_PropertyAddress, X2DrawDebugCanvasWireSphere_FunctionAddress, "Radius");
		X2DrawDebugCanvasWireSphere_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireSphere_FunctionAddress, "Radius");
		X2DrawDebugCanvasWireSphere_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireSphere_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireSphere_NumSides_PropertyAddress, X2DrawDebugCanvasWireSphere_FunctionAddress, "NumSides");
		X2DrawDebugCanvasWireSphere_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireSphere_FunctionAddress, "NumSides");
		X2DrawDebugCanvasWireSphere_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireSphere_FunctionAddress, "NumSides", Classes.FIntProperty);
		X2DrawDebugCanvasWireSphere_IsValid = X2DrawDebugCanvasWireSphere_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvasWireSphere_DebugTag_IsValid && X2DrawDebugCanvasWireSphere_Canvas_IsValid && X2DrawDebugCanvasWireSphere_Base_IsValid && X2DrawDebugCanvasWireSphere_Color_IsValid && X2DrawDebugCanvasWireSphere_Radius_IsValid && X2DrawDebugCanvasWireSphere_NumSides_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvasWireSphere", X2DrawDebugCanvasWireSphere_IsValid);
		X2DrawDebugCanvasWireCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvasWireCone");
		X2DrawDebugCanvasWireCone_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvasWireCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireCone_DebugTag_PropertyAddress, X2DrawDebugCanvasWireCone_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasWireCone_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireCone_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasWireCone_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireCone_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireCone_Canvas_PropertyAddress, X2DrawDebugCanvasWireCone_FunctionAddress, "Canvas");
		X2DrawDebugCanvasWireCone_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireCone_FunctionAddress, "Canvas");
		X2DrawDebugCanvasWireCone_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireCone_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireCone_Transform_PropertyAddress, X2DrawDebugCanvasWireCone_FunctionAddress, "Transform");
		X2DrawDebugCanvasWireCone_Transform_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireCone_FunctionAddress, "Transform");
		X2DrawDebugCanvasWireCone_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireCone_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireCone_ConeRadius_PropertyAddress, X2DrawDebugCanvasWireCone_FunctionAddress, "ConeRadius");
		X2DrawDebugCanvasWireCone_ConeRadius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireCone_FunctionAddress, "ConeRadius");
		X2DrawDebugCanvasWireCone_ConeRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireCone_FunctionAddress, "ConeRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireCone_ConeAngle_PropertyAddress, X2DrawDebugCanvasWireCone_FunctionAddress, "ConeAngle");
		X2DrawDebugCanvasWireCone_ConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireCone_FunctionAddress, "ConeAngle");
		X2DrawDebugCanvasWireCone_ConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireCone_FunctionAddress, "ConeAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireCone_ConeSides_PropertyAddress, X2DrawDebugCanvasWireCone_FunctionAddress, "ConeSides");
		X2DrawDebugCanvasWireCone_ConeSides_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireCone_FunctionAddress, "ConeSides");
		X2DrawDebugCanvasWireCone_ConeSides_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireCone_FunctionAddress, "ConeSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasWireCone_Color_PropertyAddress, X2DrawDebugCanvasWireCone_FunctionAddress, "Color");
		X2DrawDebugCanvasWireCone_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasWireCone_FunctionAddress, "Color");
		X2DrawDebugCanvasWireCone_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasWireCone_FunctionAddress, "Color", Classes.FStructProperty);
		X2DrawDebugCanvasWireCone_IsValid = X2DrawDebugCanvasWireCone_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvasWireCone_DebugTag_IsValid && X2DrawDebugCanvasWireCone_Canvas_IsValid && X2DrawDebugCanvasWireCone_Transform_IsValid && X2DrawDebugCanvasWireCone_ConeRadius_IsValid && X2DrawDebugCanvasWireCone_ConeAngle_IsValid && X2DrawDebugCanvasWireCone_ConeSides_IsValid && X2DrawDebugCanvasWireCone_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvasWireCone", X2DrawDebugCanvasWireCone_IsValid);
		X2DrawDebugCanvasLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvasLine");
		X2DrawDebugCanvasLine_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvasLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasLine_DebugTag_PropertyAddress, X2DrawDebugCanvasLine_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasLine_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasLine_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasLine_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasLine_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasLine_Canvas_PropertyAddress, X2DrawDebugCanvasLine_FunctionAddress, "Canvas");
		X2DrawDebugCanvasLine_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasLine_FunctionAddress, "Canvas");
		X2DrawDebugCanvasLine_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasLine_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasLine_Start_PropertyAddress, X2DrawDebugCanvasLine_FunctionAddress, "Start");
		X2DrawDebugCanvasLine_Start_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasLine_FunctionAddress, "Start");
		X2DrawDebugCanvasLine_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasLine_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasLine_End_PropertyAddress, X2DrawDebugCanvasLine_FunctionAddress, "End");
		X2DrawDebugCanvasLine_End_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasLine_FunctionAddress, "End");
		X2DrawDebugCanvasLine_End_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasLine_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasLine_LineColor_PropertyAddress, X2DrawDebugCanvasLine_FunctionAddress, "LineColor");
		X2DrawDebugCanvasLine_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasLine_FunctionAddress, "LineColor");
		X2DrawDebugCanvasLine_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasLine_FunctionAddress, "LineColor", Classes.FStructProperty);
		X2DrawDebugCanvasLine_IsValid = X2DrawDebugCanvasLine_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvasLine_DebugTag_IsValid && X2DrawDebugCanvasLine_Canvas_IsValid && X2DrawDebugCanvasLine_Start_IsValid && X2DrawDebugCanvasLine_End_IsValid && X2DrawDebugCanvasLine_LineColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvasLine", X2DrawDebugCanvasLine_IsValid);
		X2DrawDebugCanvasCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvasCircle");
		X2DrawDebugCanvasCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvasCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_DebugTag_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasCircle_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "DebugTag");
		X2DrawDebugCanvasCircle_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_Canvas_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "Canvas");
		X2DrawDebugCanvasCircle_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "Canvas");
		X2DrawDebugCanvasCircle_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_Base_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "Base");
		X2DrawDebugCanvasCircle_Base_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "Base");
		X2DrawDebugCanvasCircle_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_X_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "X");
		X2DrawDebugCanvasCircle_X_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "X");
		X2DrawDebugCanvasCircle_X_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_Y_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "Y");
		X2DrawDebugCanvasCircle_Y_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "Y");
		X2DrawDebugCanvasCircle_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_Color_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "Color");
		X2DrawDebugCanvasCircle_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "Color");
		X2DrawDebugCanvasCircle_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_Radius_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "Radius");
		X2DrawDebugCanvasCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "Radius");
		X2DrawDebugCanvasCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvasCircle_NumSides_PropertyAddress, X2DrawDebugCanvasCircle_FunctionAddress, "NumSides");
		X2DrawDebugCanvasCircle_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvasCircle_FunctionAddress, "NumSides");
		X2DrawDebugCanvasCircle_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvasCircle_FunctionAddress, "NumSides", Classes.FIntProperty);
		X2DrawDebugCanvasCircle_IsValid = X2DrawDebugCanvasCircle_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvasCircle_DebugTag_IsValid && X2DrawDebugCanvasCircle_Canvas_IsValid && X2DrawDebugCanvasCircle_Base_IsValid && X2DrawDebugCanvasCircle_X_IsValid && X2DrawDebugCanvasCircle_Y_IsValid && X2DrawDebugCanvasCircle_Color_IsValid && X2DrawDebugCanvasCircle_Radius_IsValid && X2DrawDebugCanvasCircle_NumSides_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvasCircle", X2DrawDebugCanvasCircle_IsValid);
		X2DrawDebugCanvas2DLine2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvas2DLine2");
		X2DrawDebugCanvas2DLine2_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvas2DLine2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine2_DebugTag_PropertyAddress, X2DrawDebugCanvas2DLine2_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DLine2_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine2_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DLine2_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine2_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine2_Canvas_PropertyAddress, X2DrawDebugCanvas2DLine2_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DLine2_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine2_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DLine2_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine2_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine2_StartPosition_PropertyAddress, X2DrawDebugCanvas2DLine2_FunctionAddress, "StartPosition");
		X2DrawDebugCanvas2DLine2_StartPosition_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine2_FunctionAddress, "StartPosition");
		X2DrawDebugCanvas2DLine2_StartPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine2_FunctionAddress, "StartPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine2_EndPosition_PropertyAddress, X2DrawDebugCanvas2DLine2_FunctionAddress, "EndPosition");
		X2DrawDebugCanvas2DLine2_EndPosition_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine2_FunctionAddress, "EndPosition");
		X2DrawDebugCanvas2DLine2_EndPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine2_FunctionAddress, "EndPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine2_LineColor_PropertyAddress, X2DrawDebugCanvas2DLine2_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DLine2_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine2_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DLine2_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine2_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine2_LineThickness_PropertyAddress, X2DrawDebugCanvas2DLine2_FunctionAddress, "LineThickness");
		X2DrawDebugCanvas2DLine2_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine2_FunctionAddress, "LineThickness");
		X2DrawDebugCanvas2DLine2_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine2_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		X2DrawDebugCanvas2DLine2_IsValid = X2DrawDebugCanvas2DLine2_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvas2DLine2_DebugTag_IsValid && X2DrawDebugCanvas2DLine2_Canvas_IsValid && X2DrawDebugCanvas2DLine2_StartPosition_IsValid && X2DrawDebugCanvas2DLine2_EndPosition_IsValid && X2DrawDebugCanvas2DLine2_LineColor_IsValid && X2DrawDebugCanvas2DLine2_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DLine2", X2DrawDebugCanvas2DLine2_IsValid);
		X2DrawDebugCanvas2DLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvas2DLine");
		X2DrawDebugCanvas2DLine_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvas2DLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine_DebugTag_PropertyAddress, X2DrawDebugCanvas2DLine_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DLine_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DLine_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine_Canvas_PropertyAddress, X2DrawDebugCanvas2DLine_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DLine_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DLine_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine_Start_PropertyAddress, X2DrawDebugCanvas2DLine_FunctionAddress, "Start");
		X2DrawDebugCanvas2DLine_Start_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine_FunctionAddress, "Start");
		X2DrawDebugCanvas2DLine_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine_End_PropertyAddress, X2DrawDebugCanvas2DLine_FunctionAddress, "End");
		X2DrawDebugCanvas2DLine_End_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine_FunctionAddress, "End");
		X2DrawDebugCanvas2DLine_End_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DLine_LineColor_PropertyAddress, X2DrawDebugCanvas2DLine_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DLine_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DLine_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DLine_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DLine_FunctionAddress, "LineColor", Classes.FStructProperty);
		X2DrawDebugCanvas2DLine_IsValid = X2DrawDebugCanvas2DLine_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvas2DLine_DebugTag_IsValid && X2DrawDebugCanvas2DLine_Canvas_IsValid && X2DrawDebugCanvas2DLine_Start_IsValid && X2DrawDebugCanvas2DLine_End_IsValid && X2DrawDebugCanvas2DLine_LineColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DLine", X2DrawDebugCanvas2DLine_IsValid);
		X2DrawDebugCanvas2DCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvas2DCircle");
		X2DrawDebugCanvas2DCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvas2DCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DCircle_DebugTag_PropertyAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DCircle_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DCircle_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DCircle_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DCircle_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DCircle_Canvas_PropertyAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DCircle_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DCircle_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DCircle_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DCircle_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DCircle_Center_PropertyAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, "Center");
		X2DrawDebugCanvas2DCircle_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DCircle_FunctionAddress, "Center");
		X2DrawDebugCanvas2DCircle_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DCircle_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DCircle_Radius_PropertyAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, "Radius");
		X2DrawDebugCanvas2DCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DCircle_FunctionAddress, "Radius");
		X2DrawDebugCanvas2DCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DCircle_NumSides_PropertyAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, "NumSides");
		X2DrawDebugCanvas2DCircle_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DCircle_FunctionAddress, "NumSides");
		X2DrawDebugCanvas2DCircle_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DCircle_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DCircle_LineColor_PropertyAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DCircle_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DCircle_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DCircle_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DCircle_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DCircle_LineThickness_PropertyAddress, X2DrawDebugCanvas2DCircle_FunctionAddress, "LineThickness");
		X2DrawDebugCanvas2DCircle_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DCircle_FunctionAddress, "LineThickness");
		X2DrawDebugCanvas2DCircle_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DCircle_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		X2DrawDebugCanvas2DCircle_IsValid = X2DrawDebugCanvas2DCircle_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvas2DCircle_DebugTag_IsValid && X2DrawDebugCanvas2DCircle_Canvas_IsValid && X2DrawDebugCanvas2DCircle_Center_IsValid && X2DrawDebugCanvas2DCircle_Radius_IsValid && X2DrawDebugCanvas2DCircle_NumSides_IsValid && X2DrawDebugCanvas2DCircle_LineColor_IsValid && X2DrawDebugCanvas2DCircle_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DCircle", X2DrawDebugCanvas2DCircle_IsValid);
		X2DrawDebugCanvas2DBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCanvas2DBox");
		X2DrawDebugCanvas2DBox_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCanvas2DBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DBox_DebugTag_PropertyAddress, X2DrawDebugCanvas2DBox_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DBox_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DBox_FunctionAddress, "DebugTag");
		X2DrawDebugCanvas2DBox_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DBox_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DBox_Canvas_PropertyAddress, X2DrawDebugCanvas2DBox_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DBox_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DBox_FunctionAddress, "Canvas");
		X2DrawDebugCanvas2DBox_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DBox_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DBox_Box_PropertyAddress, X2DrawDebugCanvas2DBox_FunctionAddress, "Box");
		X2DrawDebugCanvas2DBox_Box_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DBox_FunctionAddress, "Box");
		X2DrawDebugCanvas2DBox_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DBox_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DBox_LineColor_PropertyAddress, X2DrawDebugCanvas2DBox_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DBox_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DBox_FunctionAddress, "LineColor");
		X2DrawDebugCanvas2DBox_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DBox_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCanvas2DBox_LineThickness_PropertyAddress, X2DrawDebugCanvas2DBox_FunctionAddress, "LineThickness");
		X2DrawDebugCanvas2DBox_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCanvas2DBox_FunctionAddress, "LineThickness");
		X2DrawDebugCanvas2DBox_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCanvas2DBox_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		X2DrawDebugCanvas2DBox_IsValid = X2DrawDebugCanvas2DBox_FunctionAddress != IntPtr.Zero && X2DrawDebugCanvas2DBox_DebugTag_IsValid && X2DrawDebugCanvas2DBox_Canvas_IsValid && X2DrawDebugCanvas2DBox_Box_IsValid && X2DrawDebugCanvas2DBox_LineColor_IsValid && X2DrawDebugCanvas2DBox_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCanvas2DBox", X2DrawDebugCanvas2DBox_IsValid);
		X2DrawDebugCamera_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugCamera");
		X2DrawDebugCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_DebugTag_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "DebugTag");
		X2DrawDebugCamera_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "DebugTag");
		X2DrawDebugCamera_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_InWorld_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "InWorld");
		X2DrawDebugCamera_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "InWorld");
		X2DrawDebugCamera_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_Location_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "Location");
		X2DrawDebugCamera_Location_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "Location");
		X2DrawDebugCamera_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_Rotation_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "Rotation");
		X2DrawDebugCamera_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "Rotation");
		X2DrawDebugCamera_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_FOVDeg_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "FOVDeg");
		X2DrawDebugCamera_FOVDeg_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "FOVDeg");
		X2DrawDebugCamera_FOVDeg_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "FOVDeg", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_Scale_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "Scale");
		X2DrawDebugCamera_Scale_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "Scale");
		X2DrawDebugCamera_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_Color_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "Color");
		X2DrawDebugCamera_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "Color");
		X2DrawDebugCamera_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_bPersistentLines_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "bPersistentLines");
		X2DrawDebugCamera_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "bPersistentLines");
		X2DrawDebugCamera_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_LifeTime_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "LifeTime");
		X2DrawDebugCamera_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "LifeTime");
		X2DrawDebugCamera_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugCamera_DepthPriority_PropertyAddress, X2DrawDebugCamera_FunctionAddress, "DepthPriority");
		X2DrawDebugCamera_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugCamera_FunctionAddress, "DepthPriority");
		X2DrawDebugCamera_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugCamera_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		X2DrawDebugCamera_IsValid = X2DrawDebugCamera_FunctionAddress != IntPtr.Zero && X2DrawDebugCamera_DebugTag_IsValid && X2DrawDebugCamera_InWorld_IsValid && X2DrawDebugCamera_Location_IsValid && X2DrawDebugCamera_Rotation_IsValid && X2DrawDebugCamera_FOVDeg_IsValid && X2DrawDebugCamera_Scale_IsValid && X2DrawDebugCamera_Color_IsValid && X2DrawDebugCamera_bPersistentLines_IsValid && X2DrawDebugCamera_LifeTime_IsValid && X2DrawDebugCamera_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugCamera", X2DrawDebugCamera_IsValid);
		X2DrawDebugBox2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugBox2");
		X2DrawDebugBox2_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugBox2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_DebugTag_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "DebugTag");
		X2DrawDebugBox2_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "DebugTag");
		X2DrawDebugBox2_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_InWorld_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "InWorld");
		X2DrawDebugBox2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "InWorld");
		X2DrawDebugBox2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_Center_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "Center");
		X2DrawDebugBox2_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "Center");
		X2DrawDebugBox2_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_Extent_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "Extent");
		X2DrawDebugBox2_Extent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "Extent");
		X2DrawDebugBox2_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_Rotation_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "Rotation");
		X2DrawDebugBox2_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "Rotation");
		X2DrawDebugBox2_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_Color_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "Color");
		X2DrawDebugBox2_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "Color");
		X2DrawDebugBox2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_bPersistentLines_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "bPersistentLines");
		X2DrawDebugBox2_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "bPersistentLines");
		X2DrawDebugBox2_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_LifeTime_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "LifeTime");
		X2DrawDebugBox2_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "LifeTime");
		X2DrawDebugBox2_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_DepthPriority_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "DepthPriority");
		X2DrawDebugBox2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "DepthPriority");
		X2DrawDebugBox2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox2_Thickness_PropertyAddress, X2DrawDebugBox2_FunctionAddress, "Thickness");
		X2DrawDebugBox2_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox2_FunctionAddress, "Thickness");
		X2DrawDebugBox2_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox2_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugBox2_IsValid = X2DrawDebugBox2_FunctionAddress != IntPtr.Zero && X2DrawDebugBox2_DebugTag_IsValid && X2DrawDebugBox2_InWorld_IsValid && X2DrawDebugBox2_Center_IsValid && X2DrawDebugBox2_Extent_IsValid && X2DrawDebugBox2_Rotation_IsValid && X2DrawDebugBox2_Color_IsValid && X2DrawDebugBox2_bPersistentLines_IsValid && X2DrawDebugBox2_LifeTime_IsValid && X2DrawDebugBox2_DepthPriority_IsValid && X2DrawDebugBox2_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugBox2", X2DrawDebugBox2_IsValid);
		X2DrawDebugBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugBox");
		X2DrawDebugBox_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_DebugTag_PropertyAddress, X2DrawDebugBox_FunctionAddress, "DebugTag");
		X2DrawDebugBox_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "DebugTag");
		X2DrawDebugBox_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_InWorld_PropertyAddress, X2DrawDebugBox_FunctionAddress, "InWorld");
		X2DrawDebugBox_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "InWorld");
		X2DrawDebugBox_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_Center_PropertyAddress, X2DrawDebugBox_FunctionAddress, "Center");
		X2DrawDebugBox_Center_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "Center");
		X2DrawDebugBox_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_Extent_PropertyAddress, X2DrawDebugBox_FunctionAddress, "Extent");
		X2DrawDebugBox_Extent_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "Extent");
		X2DrawDebugBox_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_Color_PropertyAddress, X2DrawDebugBox_FunctionAddress, "Color");
		X2DrawDebugBox_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "Color");
		X2DrawDebugBox_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_bPersistentLines_PropertyAddress, X2DrawDebugBox_FunctionAddress, "bPersistentLines");
		X2DrawDebugBox_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "bPersistentLines");
		X2DrawDebugBox_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_LifeTime_PropertyAddress, X2DrawDebugBox_FunctionAddress, "LifeTime");
		X2DrawDebugBox_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "LifeTime");
		X2DrawDebugBox_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_DepthPriority_PropertyAddress, X2DrawDebugBox_FunctionAddress, "DepthPriority");
		X2DrawDebugBox_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "DepthPriority");
		X2DrawDebugBox_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugBox_Thickness_PropertyAddress, X2DrawDebugBox_FunctionAddress, "Thickness");
		X2DrawDebugBox_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugBox_FunctionAddress, "Thickness");
		X2DrawDebugBox_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugBox_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugBox_IsValid = X2DrawDebugBox_FunctionAddress != IntPtr.Zero && X2DrawDebugBox_DebugTag_IsValid && X2DrawDebugBox_InWorld_IsValid && X2DrawDebugBox_Center_IsValid && X2DrawDebugBox_Extent_IsValid && X2DrawDebugBox_Color_IsValid && X2DrawDebugBox_bPersistentLines_IsValid && X2DrawDebugBox_LifeTime_IsValid && X2DrawDebugBox_DepthPriority_IsValid && X2DrawDebugBox_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugBox", X2DrawDebugBox_IsValid);
		X2DrawDebugAltCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebugAltCone");
		X2DrawDebugAltCone_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebugAltCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_DebugTag_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "DebugTag");
		X2DrawDebugAltCone_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "DebugTag");
		X2DrawDebugAltCone_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_InWorld_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "InWorld");
		X2DrawDebugAltCone_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "InWorld");
		X2DrawDebugAltCone_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_Origin_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "Origin");
		X2DrawDebugAltCone_Origin_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "Origin");
		X2DrawDebugAltCone_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_Rotation_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "Rotation");
		X2DrawDebugAltCone_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "Rotation");
		X2DrawDebugAltCone_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_Length_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "Length");
		X2DrawDebugAltCone_Length_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "Length");
		X2DrawDebugAltCone_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_AngleWidth_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "AngleWidth");
		X2DrawDebugAltCone_AngleWidth_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "AngleWidth");
		X2DrawDebugAltCone_AngleWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "AngleWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_AngleHeight_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "AngleHeight");
		X2DrawDebugAltCone_AngleHeight_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "AngleHeight");
		X2DrawDebugAltCone_AngleHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "AngleHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_DrawColor_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "DrawColor");
		X2DrawDebugAltCone_DrawColor_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "DrawColor");
		X2DrawDebugAltCone_DrawColor_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "DrawColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_bPersistentLines_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "bPersistentLines");
		X2DrawDebugAltCone_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "bPersistentLines");
		X2DrawDebugAltCone_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_LifeTime_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "LifeTime");
		X2DrawDebugAltCone_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "LifeTime");
		X2DrawDebugAltCone_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_DepthPriority_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "DepthPriority");
		X2DrawDebugAltCone_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "DepthPriority");
		X2DrawDebugAltCone_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebugAltCone_Thickness_PropertyAddress, X2DrawDebugAltCone_FunctionAddress, "Thickness");
		X2DrawDebugAltCone_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebugAltCone_FunctionAddress, "Thickness");
		X2DrawDebugAltCone_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebugAltCone_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebugAltCone_IsValid = X2DrawDebugAltCone_FunctionAddress != IntPtr.Zero && X2DrawDebugAltCone_DebugTag_IsValid && X2DrawDebugAltCone_InWorld_IsValid && X2DrawDebugAltCone_Origin_IsValid && X2DrawDebugAltCone_Rotation_IsValid && X2DrawDebugAltCone_Length_IsValid && X2DrawDebugAltCone_AngleWidth_IsValid && X2DrawDebugAltCone_AngleHeight_IsValid && X2DrawDebugAltCone_DrawColor_IsValid && X2DrawDebugAltCone_bPersistentLines_IsValid && X2DrawDebugAltCone_LifeTime_IsValid && X2DrawDebugAltCone_DepthPriority_IsValid && X2DrawDebugAltCone_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebugAltCone", X2DrawDebugAltCone_IsValid);
		X2DrawDebug2DDonut_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawDebug2DDonut");
		X2DrawDebug2DDonut_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawDebug2DDonut_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_DebugTag_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "DebugTag");
		X2DrawDebug2DDonut_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "DebugTag");
		X2DrawDebug2DDonut_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_InWorld_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "InWorld");
		X2DrawDebug2DDonut_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "InWorld");
		X2DrawDebug2DDonut_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_TransformMatrix_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "TransformMatrix");
		X2DrawDebug2DDonut_TransformMatrix_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "TransformMatrix");
		X2DrawDebug2DDonut_TransformMatrix_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "TransformMatrix", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_InnerRadius_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "InnerRadius");
		X2DrawDebug2DDonut_InnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "InnerRadius");
		X2DrawDebug2DDonut_InnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "InnerRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_OuterRadius_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "OuterRadius");
		X2DrawDebug2DDonut_OuterRadius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "OuterRadius");
		X2DrawDebug2DDonut_OuterRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "OuterRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_Segments_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "Segments");
		X2DrawDebug2DDonut_Segments_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "Segments");
		X2DrawDebug2DDonut_Segments_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "Segments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_Color_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "Color");
		X2DrawDebug2DDonut_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "Color");
		X2DrawDebug2DDonut_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_bPersistentLines_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "bPersistentLines");
		X2DrawDebug2DDonut_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "bPersistentLines");
		X2DrawDebug2DDonut_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_LifeTime_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "LifeTime");
		X2DrawDebug2DDonut_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "LifeTime");
		X2DrawDebug2DDonut_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_DepthPriority_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "DepthPriority");
		X2DrawDebug2DDonut_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "DepthPriority");
		X2DrawDebug2DDonut_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawDebug2DDonut_Thickness_PropertyAddress, X2DrawDebug2DDonut_FunctionAddress, "Thickness");
		X2DrawDebug2DDonut_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawDebug2DDonut_FunctionAddress, "Thickness");
		X2DrawDebug2DDonut_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawDebug2DDonut_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawDebug2DDonut_IsValid = X2DrawDebug2DDonut_FunctionAddress != IntPtr.Zero && X2DrawDebug2DDonut_DebugTag_IsValid && X2DrawDebug2DDonut_InWorld_IsValid && X2DrawDebug2DDonut_TransformMatrix_IsValid && X2DrawDebug2DDonut_InnerRadius_IsValid && X2DrawDebug2DDonut_OuterRadius_IsValid && X2DrawDebug2DDonut_Segments_IsValid && X2DrawDebug2DDonut_Color_IsValid && X2DrawDebug2DDonut_bPersistentLines_IsValid && X2DrawDebug2DDonut_LifeTime_IsValid && X2DrawDebug2DDonut_DepthPriority_IsValid && X2DrawDebug2DDonut_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawDebug2DDonut", X2DrawDebug2DDonut_IsValid);
		X2DrawCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "X2DrawCircle");
		X2DrawCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(X2DrawCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_DebugTag_PropertyAddress, X2DrawCircle_FunctionAddress, "DebugTag");
		X2DrawCircle_DebugTag_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "DebugTag");
		X2DrawCircle_DebugTag_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "DebugTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_InWorld_PropertyAddress, X2DrawCircle_FunctionAddress, "InWorld");
		X2DrawCircle_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "InWorld");
		X2DrawCircle_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_Base_PropertyAddress, X2DrawCircle_FunctionAddress, "Base");
		X2DrawCircle_Base_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "Base");
		X2DrawCircle_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_X_PropertyAddress, X2DrawCircle_FunctionAddress, "X");
		X2DrawCircle_X_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "X");
		X2DrawCircle_X_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_Y_PropertyAddress, X2DrawCircle_FunctionAddress, "Y");
		X2DrawCircle_Y_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "Y");
		X2DrawCircle_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_Color_PropertyAddress, X2DrawCircle_FunctionAddress, "Color");
		X2DrawCircle_Color_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "Color");
		X2DrawCircle_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_Radius_PropertyAddress, X2DrawCircle_FunctionAddress, "Radius");
		X2DrawCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "Radius");
		X2DrawCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_NumSides_PropertyAddress, X2DrawCircle_FunctionAddress, "NumSides");
		X2DrawCircle_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "NumSides");
		X2DrawCircle_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_bPersistentLines_PropertyAddress, X2DrawCircle_FunctionAddress, "bPersistentLines");
		X2DrawCircle_bPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "bPersistentLines");
		X2DrawCircle_bPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "bPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_LifeTime_PropertyAddress, X2DrawCircle_FunctionAddress, "LifeTime");
		X2DrawCircle_LifeTime_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "LifeTime");
		X2DrawCircle_LifeTime_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "LifeTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_DepthPriority_PropertyAddress, X2DrawCircle_FunctionAddress, "DepthPriority");
		X2DrawCircle_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "DepthPriority");
		X2DrawCircle_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref X2DrawCircle_Thickness_PropertyAddress, X2DrawCircle_FunctionAddress, "Thickness");
		X2DrawCircle_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(X2DrawCircle_FunctionAddress, "Thickness");
		X2DrawCircle_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(X2DrawCircle_FunctionAddress, "Thickness", Classes.FFloatProperty);
		X2DrawCircle_IsValid = X2DrawCircle_FunctionAddress != IntPtr.Zero && X2DrawCircle_DebugTag_IsValid && X2DrawCircle_InWorld_IsValid && X2DrawCircle_Base_IsValid && X2DrawCircle_X_IsValid && X2DrawCircle_Y_IsValid && X2DrawCircle_Color_IsValid && X2DrawCircle_Radius_IsValid && X2DrawCircle_NumSides_IsValid && X2DrawCircle_bPersistentLines_IsValid && X2DrawCircle_LifeTime_IsValid && X2DrawCircle_DepthPriority_IsValid && X2DrawCircle_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:X2DrawCircle", X2DrawCircle_IsValid);
		DisableAllScreenMessages_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableAllScreenMessages");
		DisableAllScreenMessages_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableAllScreenMessages_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableAllScreenMessages_WorldCtx_PropertyAddress, DisableAllScreenMessages_FunctionAddress, "WorldCtx");
		DisableAllScreenMessages_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(DisableAllScreenMessages_FunctionAddress, "WorldCtx");
		DisableAllScreenMessages_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableAllScreenMessages_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		DisableAllScreenMessages_IsValid = DisableAllScreenMessages_FunctionAddress != IntPtr.Zero && DisableAllScreenMessages_WorldCtx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.X2DebugUtil:DisableAllScreenMessages", DisableAllScreenMessages_IsValid);
	}
}
