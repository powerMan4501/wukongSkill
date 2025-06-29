using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_Primitives : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool AppendTriangulatedPolygon_IsValid;

	private static IntPtr AppendTriangulatedPolygon_FunctionAddress;

	private static int AppendTriangulatedPolygon_ParamsSize;

	private static bool AppendTriangulatedPolygon_TargetMesh_IsValid;

	private static FFieldAddress AppendTriangulatedPolygon_TargetMesh_PropertyAddress;

	private static int AppendTriangulatedPolygon_TargetMesh_Offset;

	private static bool AppendTriangulatedPolygon_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendTriangulatedPolygon_PrimitiveOptions_PropertyAddress;

	private static int AppendTriangulatedPolygon_PrimitiveOptions_Offset;

	private static bool AppendTriangulatedPolygon_Transform_IsValid;

	private static FFieldAddress AppendTriangulatedPolygon_Transform_PropertyAddress;

	private static int AppendTriangulatedPolygon_Transform_Offset;

	private static bool AppendTriangulatedPolygon_PolygonVertices_IsValid;

	private static FFieldAddress AppendTriangulatedPolygon_PolygonVertices_PropertyAddress;

	private static int AppendTriangulatedPolygon_PolygonVertices_Offset;

	private static bool AppendTriangulatedPolygon_bAllowSelfIntersections_IsValid;

	private static FFieldAddress AppendTriangulatedPolygon_bAllowSelfIntersections_PropertyAddress;

	private static int AppendTriangulatedPolygon_bAllowSelfIntersections_Offset;

	private static bool AppendTriangulatedPolygon_Debug_IsValid;

	private static FFieldAddress AppendTriangulatedPolygon_Debug_PropertyAddress;

	private static int AppendTriangulatedPolygon_Debug_Offset;

	private static bool AppendTriangulatedPolygon_ReturnValue_IsValid;

	private static FFieldAddress AppendTriangulatedPolygon_ReturnValue_PropertyAddress;

	private static int AppendTriangulatedPolygon_ReturnValue_Offset;

	private static bool AppendTorus_IsValid;

	private static IntPtr AppendTorus_FunctionAddress;

	private static int AppendTorus_ParamsSize;

	private static bool AppendTorus_TargetMesh_IsValid;

	private static FFieldAddress AppendTorus_TargetMesh_PropertyAddress;

	private static int AppendTorus_TargetMesh_Offset;

	private static bool AppendTorus_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendTorus_PrimitiveOptions_PropertyAddress;

	private static int AppendTorus_PrimitiveOptions_Offset;

	private static bool AppendTorus_Transform_IsValid;

	private static FFieldAddress AppendTorus_Transform_PropertyAddress;

	private static int AppendTorus_Transform_Offset;

	private static bool AppendTorus_RevolveOptions_IsValid;

	private static FFieldAddress AppendTorus_RevolveOptions_PropertyAddress;

	private static int AppendTorus_RevolveOptions_Offset;

	private static bool AppendTorus_MajorRadius_IsValid;

	private static FFieldAddress AppendTorus_MajorRadius_PropertyAddress;

	private static int AppendTorus_MajorRadius_Offset;

	private static bool AppendTorus_MinorRadius_IsValid;

	private static FFieldAddress AppendTorus_MinorRadius_PropertyAddress;

	private static int AppendTorus_MinorRadius_Offset;

	private static bool AppendTorus_MajorSteps_IsValid;

	private static FFieldAddress AppendTorus_MajorSteps_PropertyAddress;

	private static int AppendTorus_MajorSteps_Offset;

	private static bool AppendTorus_MinorSteps_IsValid;

	private static FFieldAddress AppendTorus_MinorSteps_PropertyAddress;

	private static int AppendTorus_MinorSteps_Offset;

	private static bool AppendTorus_Origin_IsValid;

	private static FFieldAddress AppendTorus_Origin_PropertyAddress;

	private static int AppendTorus_Origin_Offset;

	private static bool AppendTorus_Debug_IsValid;

	private static FFieldAddress AppendTorus_Debug_PropertyAddress;

	private static int AppendTorus_Debug_Offset;

	private static bool AppendTorus_ReturnValue_IsValid;

	private static FFieldAddress AppendTorus_ReturnValue_PropertyAddress;

	private static int AppendTorus_ReturnValue_Offset;

	private static bool AppendSpiralRevolvePolygon_IsValid;

	private static IntPtr AppendSpiralRevolvePolygon_FunctionAddress;

	private static int AppendSpiralRevolvePolygon_ParamsSize;

	private static bool AppendSpiralRevolvePolygon_TargetMesh_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_TargetMesh_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_TargetMesh_Offset;

	private static bool AppendSpiralRevolvePolygon_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_PrimitiveOptions_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_PrimitiveOptions_Offset;

	private static bool AppendSpiralRevolvePolygon_Transform_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_Transform_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_Transform_Offset;

	private static bool AppendSpiralRevolvePolygon_PolygonVertices_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_PolygonVertices_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_PolygonVertices_Offset;

	private static bool AppendSpiralRevolvePolygon_RevolveOptions_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_RevolveOptions_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_RevolveOptions_Offset;

	private static bool AppendSpiralRevolvePolygon_Radius_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_Radius_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_Radius_Offset;

	private static bool AppendSpiralRevolvePolygon_Steps_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_Steps_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_Steps_Offset;

	private static bool AppendSpiralRevolvePolygon_RisePerRevolution_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_RisePerRevolution_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_RisePerRevolution_Offset;

	private static bool AppendSpiralRevolvePolygon_Debug_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_Debug_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_Debug_Offset;

	private static bool AppendSpiralRevolvePolygon_ReturnValue_IsValid;

	private static FFieldAddress AppendSpiralRevolvePolygon_ReturnValue_PropertyAddress;

	private static int AppendSpiralRevolvePolygon_ReturnValue_Offset;

	private static bool AppendSphereLatLong_IsValid;

	private static IntPtr AppendSphereLatLong_FunctionAddress;

	private static int AppendSphereLatLong_ParamsSize;

	private static bool AppendSphereLatLong_TargetMesh_IsValid;

	private static FFieldAddress AppendSphereLatLong_TargetMesh_PropertyAddress;

	private static int AppendSphereLatLong_TargetMesh_Offset;

	private static bool AppendSphereLatLong_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendSphereLatLong_PrimitiveOptions_PropertyAddress;

	private static int AppendSphereLatLong_PrimitiveOptions_Offset;

	private static bool AppendSphereLatLong_Transform_IsValid;

	private static FFieldAddress AppendSphereLatLong_Transform_PropertyAddress;

	private static int AppendSphereLatLong_Transform_Offset;

	private static bool AppendSphereLatLong_Radius_IsValid;

	private static FFieldAddress AppendSphereLatLong_Radius_PropertyAddress;

	private static int AppendSphereLatLong_Radius_Offset;

	private static bool AppendSphereLatLong_StepsPhi_IsValid;

	private static FFieldAddress AppendSphereLatLong_StepsPhi_PropertyAddress;

	private static int AppendSphereLatLong_StepsPhi_Offset;

	private static bool AppendSphereLatLong_StepsTheta_IsValid;

	private static FFieldAddress AppendSphereLatLong_StepsTheta_PropertyAddress;

	private static int AppendSphereLatLong_StepsTheta_Offset;

	private static bool AppendSphereLatLong_Origin_IsValid;

	private static FFieldAddress AppendSphereLatLong_Origin_PropertyAddress;

	private static int AppendSphereLatLong_Origin_Offset;

	private static bool AppendSphereLatLong_Debug_IsValid;

	private static FFieldAddress AppendSphereLatLong_Debug_PropertyAddress;

	private static int AppendSphereLatLong_Debug_Offset;

	private static bool AppendSphereLatLong_ReturnValue_IsValid;

	private static FFieldAddress AppendSphereLatLong_ReturnValue_PropertyAddress;

	private static int AppendSphereLatLong_ReturnValue_Offset;

	private static bool AppendSphereBox_IsValid;

	private static IntPtr AppendSphereBox_FunctionAddress;

	private static int AppendSphereBox_ParamsSize;

	private static bool AppendSphereBox_TargetMesh_IsValid;

	private static FFieldAddress AppendSphereBox_TargetMesh_PropertyAddress;

	private static int AppendSphereBox_TargetMesh_Offset;

	private static bool AppendSphereBox_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendSphereBox_PrimitiveOptions_PropertyAddress;

	private static int AppendSphereBox_PrimitiveOptions_Offset;

	private static bool AppendSphereBox_Transform_IsValid;

	private static FFieldAddress AppendSphereBox_Transform_PropertyAddress;

	private static int AppendSphereBox_Transform_Offset;

	private static bool AppendSphereBox_Radius_IsValid;

	private static FFieldAddress AppendSphereBox_Radius_PropertyAddress;

	private static int AppendSphereBox_Radius_Offset;

	private static bool AppendSphereBox_StepsX_IsValid;

	private static FFieldAddress AppendSphereBox_StepsX_PropertyAddress;

	private static int AppendSphereBox_StepsX_Offset;

	private static bool AppendSphereBox_StepsY_IsValid;

	private static FFieldAddress AppendSphereBox_StepsY_PropertyAddress;

	private static int AppendSphereBox_StepsY_Offset;

	private static bool AppendSphereBox_StepsZ_IsValid;

	private static FFieldAddress AppendSphereBox_StepsZ_PropertyAddress;

	private static int AppendSphereBox_StepsZ_Offset;

	private static bool AppendSphereBox_Origin_IsValid;

	private static FFieldAddress AppendSphereBox_Origin_PropertyAddress;

	private static int AppendSphereBox_Origin_Offset;

	private static bool AppendSphereBox_Debug_IsValid;

	private static FFieldAddress AppendSphereBox_Debug_PropertyAddress;

	private static int AppendSphereBox_Debug_Offset;

	private static bool AppendSphereBox_ReturnValue_IsValid;

	private static FFieldAddress AppendSphereBox_ReturnValue_PropertyAddress;

	private static int AppendSphereBox_ReturnValue_Offset;

	private static bool AppendSimpleSweptPolygon_IsValid;

	private static IntPtr AppendSimpleSweptPolygon_FunctionAddress;

	private static int AppendSimpleSweptPolygon_ParamsSize;

	private static bool AppendSimpleSweptPolygon_TargetMesh_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_TargetMesh_PropertyAddress;

	private static int AppendSimpleSweptPolygon_TargetMesh_Offset;

	private static bool AppendSimpleSweptPolygon_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_PrimitiveOptions_PropertyAddress;

	private static int AppendSimpleSweptPolygon_PrimitiveOptions_Offset;

	private static bool AppendSimpleSweptPolygon_Transform_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_Transform_PropertyAddress;

	private static int AppendSimpleSweptPolygon_Transform_Offset;

	private static bool AppendSimpleSweptPolygon_PolygonVertices_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_PolygonVertices_PropertyAddress;

	private static int AppendSimpleSweptPolygon_PolygonVertices_Offset;

	private static bool AppendSimpleSweptPolygon_SweepPath_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_SweepPath_PropertyAddress;

	private static int AppendSimpleSweptPolygon_SweepPath_Offset;

	private static bool AppendSimpleSweptPolygon_bLoop_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_bLoop_PropertyAddress;

	private static int AppendSimpleSweptPolygon_bLoop_Offset;

	private static bool AppendSimpleSweptPolygon_bCapped_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_bCapped_PropertyAddress;

	private static int AppendSimpleSweptPolygon_bCapped_Offset;

	private static bool AppendSimpleSweptPolygon_StartScale_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_StartScale_PropertyAddress;

	private static int AppendSimpleSweptPolygon_StartScale_Offset;

	private static bool AppendSimpleSweptPolygon_EndScale_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_EndScale_PropertyAddress;

	private static int AppendSimpleSweptPolygon_EndScale_Offset;

	private static bool AppendSimpleSweptPolygon_Debug_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_Debug_PropertyAddress;

	private static int AppendSimpleSweptPolygon_Debug_Offset;

	private static bool AppendSimpleSweptPolygon_ReturnValue_IsValid;

	private static FFieldAddress AppendSimpleSweptPolygon_ReturnValue_PropertyAddress;

	private static int AppendSimpleSweptPolygon_ReturnValue_Offset;

	private static bool AppendSimpleExtrudePolygon_IsValid;

	private static IntPtr AppendSimpleExtrudePolygon_FunctionAddress;

	private static int AppendSimpleExtrudePolygon_ParamsSize;

	private static bool AppendSimpleExtrudePolygon_TargetMesh_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_TargetMesh_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_TargetMesh_Offset;

	private static bool AppendSimpleExtrudePolygon_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_PrimitiveOptions_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_PrimitiveOptions_Offset;

	private static bool AppendSimpleExtrudePolygon_Transform_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_Transform_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_Transform_Offset;

	private static bool AppendSimpleExtrudePolygon_PolygonVertices_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_PolygonVertices_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_PolygonVertices_Offset;

	private static bool AppendSimpleExtrudePolygon_Height_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_Height_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_Height_Offset;

	private static bool AppendSimpleExtrudePolygon_HeightSteps_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_HeightSteps_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_HeightSteps_Offset;

	private static bool AppendSimpleExtrudePolygon_bCapped_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_bCapped_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_bCapped_Offset;

	private static bool AppendSimpleExtrudePolygon_Origin_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_Origin_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_Origin_Offset;

	private static bool AppendSimpleExtrudePolygon_Debug_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_Debug_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_Debug_Offset;

	private static bool AppendSimpleExtrudePolygon_ReturnValue_IsValid;

	private static FFieldAddress AppendSimpleExtrudePolygon_ReturnValue_PropertyAddress;

	private static int AppendSimpleExtrudePolygon_ReturnValue_Offset;

	private static bool AppendRoundRectangleXY_IsValid;

	private static IntPtr AppendRoundRectangleXY_FunctionAddress;

	private static int AppendRoundRectangleXY_ParamsSize;

	private static bool AppendRoundRectangleXY_TargetMesh_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_TargetMesh_PropertyAddress;

	private static int AppendRoundRectangleXY_TargetMesh_Offset;

	private static bool AppendRoundRectangleXY_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_PrimitiveOptions_PropertyAddress;

	private static int AppendRoundRectangleXY_PrimitiveOptions_Offset;

	private static bool AppendRoundRectangleXY_Transform_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_Transform_PropertyAddress;

	private static int AppendRoundRectangleXY_Transform_Offset;

	private static bool AppendRoundRectangleXY_DimensionX_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_DimensionX_PropertyAddress;

	private static int AppendRoundRectangleXY_DimensionX_Offset;

	private static bool AppendRoundRectangleXY_DimensionY_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_DimensionY_PropertyAddress;

	private static int AppendRoundRectangleXY_DimensionY_Offset;

	private static bool AppendRoundRectangleXY_CornerRadius_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_CornerRadius_PropertyAddress;

	private static int AppendRoundRectangleXY_CornerRadius_Offset;

	private static bool AppendRoundRectangleXY_StepsWidth_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_StepsWidth_PropertyAddress;

	private static int AppendRoundRectangleXY_StepsWidth_Offset;

	private static bool AppendRoundRectangleXY_StepsHeight_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_StepsHeight_PropertyAddress;

	private static int AppendRoundRectangleXY_StepsHeight_Offset;

	private static bool AppendRoundRectangleXY_StepsRound_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_StepsRound_PropertyAddress;

	private static int AppendRoundRectangleXY_StepsRound_Offset;

	private static bool AppendRoundRectangleXY_Debug_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_Debug_PropertyAddress;

	private static int AppendRoundRectangleXY_Debug_Offset;

	private static bool AppendRoundRectangleXY_ReturnValue_IsValid;

	private static FFieldAddress AppendRoundRectangleXY_ReturnValue_PropertyAddress;

	private static int AppendRoundRectangleXY_ReturnValue_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_IsValid;

	private static IntPtr AppendRoundRectangle_Compatibility_5_0_FunctionAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_ParamsSize;

	private static bool AppendRoundRectangle_Compatibility_5_0_TargetMesh_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_TargetMesh_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_TargetMesh_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_Transform_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_Transform_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_Transform_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_DimensionX_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_DimensionX_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_DimensionX_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_DimensionY_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_DimensionY_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_DimensionY_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_CornerRadius_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_CornerRadius_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_CornerRadius_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_StepsWidth_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_StepsWidth_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_StepsWidth_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_StepsHeight_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_StepsHeight_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_StepsHeight_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_StepsRound_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_StepsRound_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_StepsRound_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_Debug_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_Debug_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_Debug_Offset;

	private static bool AppendRoundRectangle_Compatibility_5_0_ReturnValue_IsValid;

	private static FFieldAddress AppendRoundRectangle_Compatibility_5_0_ReturnValue_PropertyAddress;

	private static int AppendRoundRectangle_Compatibility_5_0_ReturnValue_Offset;

	private static bool AppendRevolvePolygon_IsValid;

	private static IntPtr AppendRevolvePolygon_FunctionAddress;

	private static int AppendRevolvePolygon_ParamsSize;

	private static bool AppendRevolvePolygon_TargetMesh_IsValid;

	private static FFieldAddress AppendRevolvePolygon_TargetMesh_PropertyAddress;

	private static int AppendRevolvePolygon_TargetMesh_Offset;

	private static bool AppendRevolvePolygon_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendRevolvePolygon_PrimitiveOptions_PropertyAddress;

	private static int AppendRevolvePolygon_PrimitiveOptions_Offset;

	private static bool AppendRevolvePolygon_Transform_IsValid;

	private static FFieldAddress AppendRevolvePolygon_Transform_PropertyAddress;

	private static int AppendRevolvePolygon_Transform_Offset;

	private static bool AppendRevolvePolygon_PolygonVertices_IsValid;

	private static FFieldAddress AppendRevolvePolygon_PolygonVertices_PropertyAddress;

	private static int AppendRevolvePolygon_PolygonVertices_Offset;

	private static bool AppendRevolvePolygon_RevolveOptions_IsValid;

	private static FFieldAddress AppendRevolvePolygon_RevolveOptions_PropertyAddress;

	private static int AppendRevolvePolygon_RevolveOptions_Offset;

	private static bool AppendRevolvePolygon_Radius_IsValid;

	private static FFieldAddress AppendRevolvePolygon_Radius_PropertyAddress;

	private static int AppendRevolvePolygon_Radius_Offset;

	private static bool AppendRevolvePolygon_Steps_IsValid;

	private static FFieldAddress AppendRevolvePolygon_Steps_PropertyAddress;

	private static int AppendRevolvePolygon_Steps_Offset;

	private static bool AppendRevolvePolygon_Debug_IsValid;

	private static FFieldAddress AppendRevolvePolygon_Debug_PropertyAddress;

	private static int AppendRevolvePolygon_Debug_Offset;

	private static bool AppendRevolvePolygon_ReturnValue_IsValid;

	private static FFieldAddress AppendRevolvePolygon_ReturnValue_PropertyAddress;

	private static int AppendRevolvePolygon_ReturnValue_Offset;

	private static bool AppendRevolvePath_IsValid;

	private static IntPtr AppendRevolvePath_FunctionAddress;

	private static int AppendRevolvePath_ParamsSize;

	private static bool AppendRevolvePath_TargetMesh_IsValid;

	private static FFieldAddress AppendRevolvePath_TargetMesh_PropertyAddress;

	private static int AppendRevolvePath_TargetMesh_Offset;

	private static bool AppendRevolvePath_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendRevolvePath_PrimitiveOptions_PropertyAddress;

	private static int AppendRevolvePath_PrimitiveOptions_Offset;

	private static bool AppendRevolvePath_Transform_IsValid;

	private static FFieldAddress AppendRevolvePath_Transform_PropertyAddress;

	private static int AppendRevolvePath_Transform_Offset;

	private static bool AppendRevolvePath_PathVertices_IsValid;

	private static FFieldAddress AppendRevolvePath_PathVertices_PropertyAddress;

	private static int AppendRevolvePath_PathVertices_Offset;

	private static bool AppendRevolvePath_RevolveOptions_IsValid;

	private static FFieldAddress AppendRevolvePath_RevolveOptions_PropertyAddress;

	private static int AppendRevolvePath_RevolveOptions_Offset;

	private static bool AppendRevolvePath_Steps_IsValid;

	private static FFieldAddress AppendRevolvePath_Steps_PropertyAddress;

	private static int AppendRevolvePath_Steps_Offset;

	private static bool AppendRevolvePath_bCapped_IsValid;

	private static FFieldAddress AppendRevolvePath_bCapped_PropertyAddress;

	private static int AppendRevolvePath_bCapped_Offset;

	private static bool AppendRevolvePath_Debug_IsValid;

	private static FFieldAddress AppendRevolvePath_Debug_PropertyAddress;

	private static int AppendRevolvePath_Debug_Offset;

	private static bool AppendRevolvePath_ReturnValue_IsValid;

	private static FFieldAddress AppendRevolvePath_ReturnValue_PropertyAddress;

	private static int AppendRevolvePath_ReturnValue_Offset;

	private static bool AppendRectangleXY_IsValid;

	private static IntPtr AppendRectangleXY_FunctionAddress;

	private static int AppendRectangleXY_ParamsSize;

	private static bool AppendRectangleXY_TargetMesh_IsValid;

	private static FFieldAddress AppendRectangleXY_TargetMesh_PropertyAddress;

	private static int AppendRectangleXY_TargetMesh_Offset;

	private static bool AppendRectangleXY_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendRectangleXY_PrimitiveOptions_PropertyAddress;

	private static int AppendRectangleXY_PrimitiveOptions_Offset;

	private static bool AppendRectangleXY_Transform_IsValid;

	private static FFieldAddress AppendRectangleXY_Transform_PropertyAddress;

	private static int AppendRectangleXY_Transform_Offset;

	private static bool AppendRectangleXY_DimensionX_IsValid;

	private static FFieldAddress AppendRectangleXY_DimensionX_PropertyAddress;

	private static int AppendRectangleXY_DimensionX_Offset;

	private static bool AppendRectangleXY_DimensionY_IsValid;

	private static FFieldAddress AppendRectangleXY_DimensionY_PropertyAddress;

	private static int AppendRectangleXY_DimensionY_Offset;

	private static bool AppendRectangleXY_StepsWidth_IsValid;

	private static FFieldAddress AppendRectangleXY_StepsWidth_PropertyAddress;

	private static int AppendRectangleXY_StepsWidth_Offset;

	private static bool AppendRectangleXY_StepsHeight_IsValid;

	private static FFieldAddress AppendRectangleXY_StepsHeight_PropertyAddress;

	private static int AppendRectangleXY_StepsHeight_Offset;

	private static bool AppendRectangleXY_Debug_IsValid;

	private static FFieldAddress AppendRectangleXY_Debug_PropertyAddress;

	private static int AppendRectangleXY_Debug_Offset;

	private static bool AppendRectangleXY_ReturnValue_IsValid;

	private static FFieldAddress AppendRectangleXY_ReturnValue_PropertyAddress;

	private static int AppendRectangleXY_ReturnValue_Offset;

	private static bool AppendRectangle_Compatibility_5_0_IsValid;

	private static IntPtr AppendRectangle_Compatibility_5_0_FunctionAddress;

	private static int AppendRectangle_Compatibility_5_0_ParamsSize;

	private static bool AppendRectangle_Compatibility_5_0_TargetMesh_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_TargetMesh_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_TargetMesh_Offset;

	private static bool AppendRectangle_Compatibility_5_0_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_PrimitiveOptions_Offset;

	private static bool AppendRectangle_Compatibility_5_0_Transform_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_Transform_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_Transform_Offset;

	private static bool AppendRectangle_Compatibility_5_0_DimensionX_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_DimensionX_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_DimensionX_Offset;

	private static bool AppendRectangle_Compatibility_5_0_DimensionY_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_DimensionY_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_DimensionY_Offset;

	private static bool AppendRectangle_Compatibility_5_0_StepsWidth_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_StepsWidth_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_StepsWidth_Offset;

	private static bool AppendRectangle_Compatibility_5_0_StepsHeight_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_StepsHeight_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_StepsHeight_Offset;

	private static bool AppendRectangle_Compatibility_5_0_Debug_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_Debug_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_Debug_Offset;

	private static bool AppendRectangle_Compatibility_5_0_ReturnValue_IsValid;

	private static FFieldAddress AppendRectangle_Compatibility_5_0_ReturnValue_PropertyAddress;

	private static int AppendRectangle_Compatibility_5_0_ReturnValue_Offset;

	private static bool AppendLinearStairs_IsValid;

	private static IntPtr AppendLinearStairs_FunctionAddress;

	private static int AppendLinearStairs_ParamsSize;

	private static bool AppendLinearStairs_TargetMesh_IsValid;

	private static FFieldAddress AppendLinearStairs_TargetMesh_PropertyAddress;

	private static int AppendLinearStairs_TargetMesh_Offset;

	private static bool AppendLinearStairs_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendLinearStairs_PrimitiveOptions_PropertyAddress;

	private static int AppendLinearStairs_PrimitiveOptions_Offset;

	private static bool AppendLinearStairs_Transform_IsValid;

	private static FFieldAddress AppendLinearStairs_Transform_PropertyAddress;

	private static int AppendLinearStairs_Transform_Offset;

	private static bool AppendLinearStairs_StepWidth_IsValid;

	private static FFieldAddress AppendLinearStairs_StepWidth_PropertyAddress;

	private static int AppendLinearStairs_StepWidth_Offset;

	private static bool AppendLinearStairs_StepHeight_IsValid;

	private static FFieldAddress AppendLinearStairs_StepHeight_PropertyAddress;

	private static int AppendLinearStairs_StepHeight_Offset;

	private static bool AppendLinearStairs_StepDepth_IsValid;

	private static FFieldAddress AppendLinearStairs_StepDepth_PropertyAddress;

	private static int AppendLinearStairs_StepDepth_Offset;

	private static bool AppendLinearStairs_NumSteps_IsValid;

	private static FFieldAddress AppendLinearStairs_NumSteps_PropertyAddress;

	private static int AppendLinearStairs_NumSteps_Offset;

	private static bool AppendLinearStairs_bFloating_IsValid;

	private static FFieldAddress AppendLinearStairs_bFloating_PropertyAddress;

	private static int AppendLinearStairs_bFloating_Offset;

	private static bool AppendLinearStairs_Debug_IsValid;

	private static FFieldAddress AppendLinearStairs_Debug_PropertyAddress;

	private static int AppendLinearStairs_Debug_Offset;

	private static bool AppendLinearStairs_ReturnValue_IsValid;

	private static FFieldAddress AppendLinearStairs_ReturnValue_PropertyAddress;

	private static int AppendLinearStairs_ReturnValue_Offset;

	private static bool AppendDisc_IsValid;

	private static IntPtr AppendDisc_FunctionAddress;

	private static int AppendDisc_ParamsSize;

	private static bool AppendDisc_TargetMesh_IsValid;

	private static FFieldAddress AppendDisc_TargetMesh_PropertyAddress;

	private static int AppendDisc_TargetMesh_Offset;

	private static bool AppendDisc_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendDisc_PrimitiveOptions_PropertyAddress;

	private static int AppendDisc_PrimitiveOptions_Offset;

	private static bool AppendDisc_Transform_IsValid;

	private static FFieldAddress AppendDisc_Transform_PropertyAddress;

	private static int AppendDisc_Transform_Offset;

	private static bool AppendDisc_Radius_IsValid;

	private static FFieldAddress AppendDisc_Radius_PropertyAddress;

	private static int AppendDisc_Radius_Offset;

	private static bool AppendDisc_AngleSteps_IsValid;

	private static FFieldAddress AppendDisc_AngleSteps_PropertyAddress;

	private static int AppendDisc_AngleSteps_Offset;

	private static bool AppendDisc_SpokeSteps_IsValid;

	private static FFieldAddress AppendDisc_SpokeSteps_PropertyAddress;

	private static int AppendDisc_SpokeSteps_Offset;

	private static bool AppendDisc_StartAngle_IsValid;

	private static FFieldAddress AppendDisc_StartAngle_PropertyAddress;

	private static int AppendDisc_StartAngle_Offset;

	private static bool AppendDisc_EndAngle_IsValid;

	private static FFieldAddress AppendDisc_EndAngle_PropertyAddress;

	private static int AppendDisc_EndAngle_Offset;

	private static bool AppendDisc_HoleRadius_IsValid;

	private static FFieldAddress AppendDisc_HoleRadius_PropertyAddress;

	private static int AppendDisc_HoleRadius_Offset;

	private static bool AppendDisc_Debug_IsValid;

	private static FFieldAddress AppendDisc_Debug_PropertyAddress;

	private static int AppendDisc_Debug_Offset;

	private static bool AppendDisc_ReturnValue_IsValid;

	private static FFieldAddress AppendDisc_ReturnValue_PropertyAddress;

	private static int AppendDisc_ReturnValue_Offset;

	private static bool AppendCylinder_IsValid;

	private static IntPtr AppendCylinder_FunctionAddress;

	private static int AppendCylinder_ParamsSize;

	private static bool AppendCylinder_TargetMesh_IsValid;

	private static FFieldAddress AppendCylinder_TargetMesh_PropertyAddress;

	private static int AppendCylinder_TargetMesh_Offset;

	private static bool AppendCylinder_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendCylinder_PrimitiveOptions_PropertyAddress;

	private static int AppendCylinder_PrimitiveOptions_Offset;

	private static bool AppendCylinder_Transform_IsValid;

	private static FFieldAddress AppendCylinder_Transform_PropertyAddress;

	private static int AppendCylinder_Transform_Offset;

	private static bool AppendCylinder_Radius_IsValid;

	private static FFieldAddress AppendCylinder_Radius_PropertyAddress;

	private static int AppendCylinder_Radius_Offset;

	private static bool AppendCylinder_Height_IsValid;

	private static FFieldAddress AppendCylinder_Height_PropertyAddress;

	private static int AppendCylinder_Height_Offset;

	private static bool AppendCylinder_RadialSteps_IsValid;

	private static FFieldAddress AppendCylinder_RadialSteps_PropertyAddress;

	private static int AppendCylinder_RadialSteps_Offset;

	private static bool AppendCylinder_HeightSteps_IsValid;

	private static FFieldAddress AppendCylinder_HeightSteps_PropertyAddress;

	private static int AppendCylinder_HeightSteps_Offset;

	private static bool AppendCylinder_bCapped_IsValid;

	private static FFieldAddress AppendCylinder_bCapped_PropertyAddress;

	private static int AppendCylinder_bCapped_Offset;

	private static bool AppendCylinder_Origin_IsValid;

	private static FFieldAddress AppendCylinder_Origin_PropertyAddress;

	private static int AppendCylinder_Origin_Offset;

	private static bool AppendCylinder_Debug_IsValid;

	private static FFieldAddress AppendCylinder_Debug_PropertyAddress;

	private static int AppendCylinder_Debug_Offset;

	private static bool AppendCylinder_ReturnValue_IsValid;

	private static FFieldAddress AppendCylinder_ReturnValue_PropertyAddress;

	private static int AppendCylinder_ReturnValue_Offset;

	private static bool AppendCurvedStairs_IsValid;

	private static IntPtr AppendCurvedStairs_FunctionAddress;

	private static int AppendCurvedStairs_ParamsSize;

	private static bool AppendCurvedStairs_TargetMesh_IsValid;

	private static FFieldAddress AppendCurvedStairs_TargetMesh_PropertyAddress;

	private static int AppendCurvedStairs_TargetMesh_Offset;

	private static bool AppendCurvedStairs_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendCurvedStairs_PrimitiveOptions_PropertyAddress;

	private static int AppendCurvedStairs_PrimitiveOptions_Offset;

	private static bool AppendCurvedStairs_Transform_IsValid;

	private static FFieldAddress AppendCurvedStairs_Transform_PropertyAddress;

	private static int AppendCurvedStairs_Transform_Offset;

	private static bool AppendCurvedStairs_StepWidth_IsValid;

	private static FFieldAddress AppendCurvedStairs_StepWidth_PropertyAddress;

	private static int AppendCurvedStairs_StepWidth_Offset;

	private static bool AppendCurvedStairs_StepHeight_IsValid;

	private static FFieldAddress AppendCurvedStairs_StepHeight_PropertyAddress;

	private static int AppendCurvedStairs_StepHeight_Offset;

	private static bool AppendCurvedStairs_InnerRadius_IsValid;

	private static FFieldAddress AppendCurvedStairs_InnerRadius_PropertyAddress;

	private static int AppendCurvedStairs_InnerRadius_Offset;

	private static bool AppendCurvedStairs_CurveAngle_IsValid;

	private static FFieldAddress AppendCurvedStairs_CurveAngle_PropertyAddress;

	private static int AppendCurvedStairs_CurveAngle_Offset;

	private static bool AppendCurvedStairs_NumSteps_IsValid;

	private static FFieldAddress AppendCurvedStairs_NumSteps_PropertyAddress;

	private static int AppendCurvedStairs_NumSteps_Offset;

	private static bool AppendCurvedStairs_bFloating_IsValid;

	private static FFieldAddress AppendCurvedStairs_bFloating_PropertyAddress;

	private static int AppendCurvedStairs_bFloating_Offset;

	private static bool AppendCurvedStairs_Debug_IsValid;

	private static FFieldAddress AppendCurvedStairs_Debug_PropertyAddress;

	private static int AppendCurvedStairs_Debug_Offset;

	private static bool AppendCurvedStairs_ReturnValue_IsValid;

	private static FFieldAddress AppendCurvedStairs_ReturnValue_PropertyAddress;

	private static int AppendCurvedStairs_ReturnValue_Offset;

	private static bool AppendCone_IsValid;

	private static IntPtr AppendCone_FunctionAddress;

	private static int AppendCone_ParamsSize;

	private static bool AppendCone_TargetMesh_IsValid;

	private static FFieldAddress AppendCone_TargetMesh_PropertyAddress;

	private static int AppendCone_TargetMesh_Offset;

	private static bool AppendCone_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendCone_PrimitiveOptions_PropertyAddress;

	private static int AppendCone_PrimitiveOptions_Offset;

	private static bool AppendCone_Transform_IsValid;

	private static FFieldAddress AppendCone_Transform_PropertyAddress;

	private static int AppendCone_Transform_Offset;

	private static bool AppendCone_BaseRadius_IsValid;

	private static FFieldAddress AppendCone_BaseRadius_PropertyAddress;

	private static int AppendCone_BaseRadius_Offset;

	private static bool AppendCone_TopRadius_IsValid;

	private static FFieldAddress AppendCone_TopRadius_PropertyAddress;

	private static int AppendCone_TopRadius_Offset;

	private static bool AppendCone_Height_IsValid;

	private static FFieldAddress AppendCone_Height_PropertyAddress;

	private static int AppendCone_Height_Offset;

	private static bool AppendCone_RadialSteps_IsValid;

	private static FFieldAddress AppendCone_RadialSteps_PropertyAddress;

	private static int AppendCone_RadialSteps_Offset;

	private static bool AppendCone_HeightSteps_IsValid;

	private static FFieldAddress AppendCone_HeightSteps_PropertyAddress;

	private static int AppendCone_HeightSteps_Offset;

	private static bool AppendCone_bCapped_IsValid;

	private static FFieldAddress AppendCone_bCapped_PropertyAddress;

	private static int AppendCone_bCapped_Offset;

	private static bool AppendCone_Origin_IsValid;

	private static FFieldAddress AppendCone_Origin_PropertyAddress;

	private static int AppendCone_Origin_Offset;

	private static bool AppendCone_Debug_IsValid;

	private static FFieldAddress AppendCone_Debug_PropertyAddress;

	private static int AppendCone_Debug_Offset;

	private static bool AppendCone_ReturnValue_IsValid;

	private static FFieldAddress AppendCone_ReturnValue_PropertyAddress;

	private static int AppendCone_ReturnValue_Offset;

	private static bool AppendCapsule_IsValid;

	private static IntPtr AppendCapsule_FunctionAddress;

	private static int AppendCapsule_ParamsSize;

	private static bool AppendCapsule_TargetMesh_IsValid;

	private static FFieldAddress AppendCapsule_TargetMesh_PropertyAddress;

	private static int AppendCapsule_TargetMesh_Offset;

	private static bool AppendCapsule_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendCapsule_PrimitiveOptions_PropertyAddress;

	private static int AppendCapsule_PrimitiveOptions_Offset;

	private static bool AppendCapsule_Transform_IsValid;

	private static FFieldAddress AppendCapsule_Transform_PropertyAddress;

	private static int AppendCapsule_Transform_Offset;

	private static bool AppendCapsule_Radius_IsValid;

	private static FFieldAddress AppendCapsule_Radius_PropertyAddress;

	private static int AppendCapsule_Radius_Offset;

	private static bool AppendCapsule_LineLength_IsValid;

	private static FFieldAddress AppendCapsule_LineLength_PropertyAddress;

	private static int AppendCapsule_LineLength_Offset;

	private static bool AppendCapsule_HemisphereSteps_IsValid;

	private static FFieldAddress AppendCapsule_HemisphereSteps_PropertyAddress;

	private static int AppendCapsule_HemisphereSteps_Offset;

	private static bool AppendCapsule_CircleSteps_IsValid;

	private static FFieldAddress AppendCapsule_CircleSteps_PropertyAddress;

	private static int AppendCapsule_CircleSteps_Offset;

	private static bool AppendCapsule_Origin_IsValid;

	private static FFieldAddress AppendCapsule_Origin_PropertyAddress;

	private static int AppendCapsule_Origin_Offset;

	private static bool AppendCapsule_Debug_IsValid;

	private static FFieldAddress AppendCapsule_Debug_PropertyAddress;

	private static int AppendCapsule_Debug_Offset;

	private static bool AppendCapsule_ReturnValue_IsValid;

	private static FFieldAddress AppendCapsule_ReturnValue_PropertyAddress;

	private static int AppendCapsule_ReturnValue_Offset;

	private static bool AppendBox_IsValid;

	private static IntPtr AppendBox_FunctionAddress;

	private static int AppendBox_ParamsSize;

	private static bool AppendBox_TargetMesh_IsValid;

	private static FFieldAddress AppendBox_TargetMesh_PropertyAddress;

	private static int AppendBox_TargetMesh_Offset;

	private static bool AppendBox_PrimitiveOptions_IsValid;

	private static FFieldAddress AppendBox_PrimitiveOptions_PropertyAddress;

	private static int AppendBox_PrimitiveOptions_Offset;

	private static bool AppendBox_Transform_IsValid;

	private static FFieldAddress AppendBox_Transform_PropertyAddress;

	private static int AppendBox_Transform_Offset;

	private static bool AppendBox_DimensionX_IsValid;

	private static FFieldAddress AppendBox_DimensionX_PropertyAddress;

	private static int AppendBox_DimensionX_Offset;

	private static bool AppendBox_DimensionY_IsValid;

	private static FFieldAddress AppendBox_DimensionY_PropertyAddress;

	private static int AppendBox_DimensionY_Offset;

	private static bool AppendBox_DimensionZ_IsValid;

	private static FFieldAddress AppendBox_DimensionZ_PropertyAddress;

	private static int AppendBox_DimensionZ_Offset;

	private static bool AppendBox_StepsX_IsValid;

	private static FFieldAddress AppendBox_StepsX_PropertyAddress;

	private static int AppendBox_StepsX_Offset;

	private static bool AppendBox_StepsY_IsValid;

	private static FFieldAddress AppendBox_StepsY_PropertyAddress;

	private static int AppendBox_StepsY_Offset;

	private static bool AppendBox_StepsZ_IsValid;

	private static FFieldAddress AppendBox_StepsZ_PropertyAddress;

	private static int AppendBox_StepsZ_Offset;

	private static bool AppendBox_Origin_IsValid;

	private static FFieldAddress AppendBox_Origin_PropertyAddress;

	private static int AppendBox_Origin_Offset;

	private static bool AppendBox_Debug_IsValid;

	private static FFieldAddress AppendBox_Debug_PropertyAddress;

	private static int AppendBox_Debug_Offset;

	private static bool AppendBox_ReturnValue_IsValid;

	private static FFieldAddress AppendBox_ReturnValue_PropertyAddress;

	private static int AppendBox_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendTriangulatedPolygon")]
	public unsafe static UDynamicMesh AppendTriangulatedPolygon(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, bool bAllowSelfIntersections, UGeometryScriptDebug Debug)
	{
		if (!AppendTriangulatedPolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendTriangulatedPolygon");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendTriangulatedPolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendTriangulatedPolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendTriangulatedPolygon_TargetMesh_Offset), 0, AppendTriangulatedPolygon_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendTriangulatedPolygon_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendTriangulatedPolygon_PrimitiveOptions_Offset), 0, AppendTriangulatedPolygon_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendTriangulatedPolygon_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendTriangulatedPolygon_Transform_Offset), 0, AppendTriangulatedPolygon_Transform_PropertyAddress.Address, Transform);
		new TArrayCopyMarshaler<FVector2D>(1, AppendTriangulatedPolygon_PolygonVertices_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendTriangulatedPolygon_PolygonVertices_Offset), PolygonVertices);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendTriangulatedPolygon_bAllowSelfIntersections_Offset), 0, AppendTriangulatedPolygon_bAllowSelfIntersections_PropertyAddress.Address, bAllowSelfIntersections);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendTriangulatedPolygon_Debug_Offset), 0, AppendTriangulatedPolygon_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendTriangulatedPolygon_FunctionAddress, intPtr, AppendTriangulatedPolygon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendTriangulatedPolygon_PolygonVertices_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendTriangulatedPolygon_ReturnValue_Offset), 0, AppendTriangulatedPolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendTorus")]
	public unsafe static UDynamicMesh AppendTorus(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, FGeometryScriptRevolveOptions RevolveOptions, float MajorRadius, float MinorRadius, int MajorSteps, int MinorSteps, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendTorus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendTorus");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendTorus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendTorus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendTorus_TargetMesh_Offset), 0, AppendTorus_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendTorus_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendTorus_PrimitiveOptions_Offset), 0, AppendTorus_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendTorus_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendTorus_Transform_Offset), 0, AppendTorus_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InitializeValue_InContainer(AppendTorus_RevolveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptRevolveOptions.ToNative(IntPtr.Add(intPtr, AppendTorus_RevolveOptions_Offset), 0, AppendTorus_RevolveOptions_PropertyAddress.Address, RevolveOptions);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendTorus_MajorRadius_Offset), 0, AppendTorus_MajorRadius_PropertyAddress.Address, MajorRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendTorus_MinorRadius_Offset), 0, AppendTorus_MinorRadius_PropertyAddress.Address, MinorRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendTorus_MajorSteps_Offset), 0, AppendTorus_MajorSteps_PropertyAddress.Address, MajorSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendTorus_MinorSteps_Offset), 0, AppendTorus_MinorSteps_PropertyAddress.Address, MinorSteps);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendTorus_Origin_Offset), 0, AppendTorus_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendTorus_Debug_Offset), 0, AppendTorus_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendTorus_FunctionAddress, intPtr, AppendTorus_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendTorus_ReturnValue_Offset), 0, AppendTorus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSpiralRevolvePolygon")]
	public unsafe static UDynamicMesh AppendSpiralRevolvePolygon(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, FGeometryScriptRevolveOptions RevolveOptions, float Radius, int Steps, float RisePerRevolution, UGeometryScriptDebug Debug)
	{
		if (!AppendSpiralRevolvePolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSpiralRevolvePolygon");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendSpiralRevolvePolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendSpiralRevolvePolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_TargetMesh_Offset), 0, AppendSpiralRevolvePolygon_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendSpiralRevolvePolygon_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_PrimitiveOptions_Offset), 0, AppendSpiralRevolvePolygon_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendSpiralRevolvePolygon_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_Transform_Offset), 0, AppendSpiralRevolvePolygon_Transform_PropertyAddress.Address, Transform);
		new TArrayCopyMarshaler<FVector2D>(1, AppendSpiralRevolvePolygon_PolygonVertices_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_PolygonVertices_Offset), PolygonVertices);
		NativeReflection.InitializeValue_InContainer(AppendSpiralRevolvePolygon_RevolveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptRevolveOptions.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_RevolveOptions_Offset), 0, AppendSpiralRevolvePolygon_RevolveOptions_PropertyAddress.Address, RevolveOptions);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_Radius_Offset), 0, AppendSpiralRevolvePolygon_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_Steps_Offset), 0, AppendSpiralRevolvePolygon_Steps_PropertyAddress.Address, Steps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_RisePerRevolution_Offset), 0, AppendSpiralRevolvePolygon_RisePerRevolution_PropertyAddress.Address, RisePerRevolution);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_Debug_Offset), 0, AppendSpiralRevolvePolygon_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendSpiralRevolvePolygon_FunctionAddress, intPtr, AppendSpiralRevolvePolygon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendSpiralRevolvePolygon_PolygonVertices_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendSpiralRevolvePolygon_ReturnValue_Offset), 0, AppendSpiralRevolvePolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSphereLatLong")]
	public unsafe static UDynamicMesh AppendSphereLatLong(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, int StepsPhi, int StepsTheta, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendSphereLatLong_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSphereLatLong");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendSphereLatLong_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendSphereLatLong_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_TargetMesh_Offset), 0, AppendSphereLatLong_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendSphereLatLong_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_PrimitiveOptions_Offset), 0, AppendSphereLatLong_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendSphereLatLong_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_Transform_Offset), 0, AppendSphereLatLong_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_Radius_Offset), 0, AppendSphereLatLong_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_StepsPhi_Offset), 0, AppendSphereLatLong_StepsPhi_PropertyAddress.Address, StepsPhi);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_StepsTheta_Offset), 0, AppendSphereLatLong_StepsTheta_PropertyAddress.Address, StepsTheta);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_Origin_Offset), 0, AppendSphereLatLong_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendSphereLatLong_Debug_Offset), 0, AppendSphereLatLong_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendSphereLatLong_FunctionAddress, intPtr, AppendSphereLatLong_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendSphereLatLong_ReturnValue_Offset), 0, AppendSphereLatLong_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSphereBox")]
	public unsafe static UDynamicMesh AppendSphereBox(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, int StepsX, int StepsY, int StepsZ, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendSphereBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSphereBox");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendSphereBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendSphereBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_TargetMesh_Offset), 0, AppendSphereBox_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendSphereBox_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendSphereBox_PrimitiveOptions_Offset), 0, AppendSphereBox_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendSphereBox_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_Transform_Offset), 0, AppendSphereBox_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_Radius_Offset), 0, AppendSphereBox_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_StepsX_Offset), 0, AppendSphereBox_StepsX_PropertyAddress.Address, StepsX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_StepsY_Offset), 0, AppendSphereBox_StepsY_PropertyAddress.Address, StepsY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_StepsZ_Offset), 0, AppendSphereBox_StepsZ_PropertyAddress.Address, StepsZ);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_Origin_Offset), 0, AppendSphereBox_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendSphereBox_Debug_Offset), 0, AppendSphereBox_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendSphereBox_FunctionAddress, intPtr, AppendSphereBox_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendSphereBox_ReturnValue_Offset), 0, AppendSphereBox_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSimpleSweptPolygon")]
	public unsafe static UDynamicMesh AppendSimpleSweptPolygon(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, List<FVector> SweepPath, bool bLoop, bool bCapped, float StartScale, float EndScale, UGeometryScriptDebug Debug)
	{
		if (!AppendSimpleSweptPolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSimpleSweptPolygon");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendSimpleSweptPolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendSimpleSweptPolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_TargetMesh_Offset), 0, AppendSimpleSweptPolygon_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendSimpleSweptPolygon_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_PrimitiveOptions_Offset), 0, AppendSimpleSweptPolygon_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendSimpleSweptPolygon_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_Transform_Offset), 0, AppendSimpleSweptPolygon_Transform_PropertyAddress.Address, Transform);
		new TArrayCopyMarshaler<FVector2D>(1, AppendSimpleSweptPolygon_PolygonVertices_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_PolygonVertices_Offset), PolygonVertices);
		new TArrayCopyMarshaler<FVector>(1, AppendSimpleSweptPolygon_SweepPath_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_SweepPath_Offset), SweepPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_bLoop_Offset), 0, AppendSimpleSweptPolygon_bLoop_PropertyAddress.Address, bLoop);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_bCapped_Offset), 0, AppendSimpleSweptPolygon_bCapped_PropertyAddress.Address, bCapped);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_StartScale_Offset), 0, AppendSimpleSweptPolygon_StartScale_PropertyAddress.Address, StartScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_EndScale_Offset), 0, AppendSimpleSweptPolygon_EndScale_PropertyAddress.Address, EndScale);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_Debug_Offset), 0, AppendSimpleSweptPolygon_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendSimpleSweptPolygon_FunctionAddress, intPtr, AppendSimpleSweptPolygon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendSimpleSweptPolygon_PolygonVertices_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AppendSimpleSweptPolygon_SweepPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendSimpleSweptPolygon_ReturnValue_Offset), 0, AppendSimpleSweptPolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSimpleExtrudePolygon")]
	public unsafe static UDynamicMesh AppendSimpleExtrudePolygon(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, float Height, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendSimpleExtrudePolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSimpleExtrudePolygon");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendSimpleExtrudePolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendSimpleExtrudePolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_TargetMesh_Offset), 0, AppendSimpleExtrudePolygon_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendSimpleExtrudePolygon_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_PrimitiveOptions_Offset), 0, AppendSimpleExtrudePolygon_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendSimpleExtrudePolygon_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_Transform_Offset), 0, AppendSimpleExtrudePolygon_Transform_PropertyAddress.Address, Transform);
		new TArrayCopyMarshaler<FVector2D>(1, AppendSimpleExtrudePolygon_PolygonVertices_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_PolygonVertices_Offset), PolygonVertices);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_Height_Offset), 0, AppendSimpleExtrudePolygon_Height_PropertyAddress.Address, Height);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_HeightSteps_Offset), 0, AppendSimpleExtrudePolygon_HeightSteps_PropertyAddress.Address, HeightSteps);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_bCapped_Offset), 0, AppendSimpleExtrudePolygon_bCapped_PropertyAddress.Address, bCapped);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_Origin_Offset), 0, AppendSimpleExtrudePolygon_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_Debug_Offset), 0, AppendSimpleExtrudePolygon_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendSimpleExtrudePolygon_FunctionAddress, intPtr, AppendSimpleExtrudePolygon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendSimpleExtrudePolygon_PolygonVertices_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendSimpleExtrudePolygon_ReturnValue_Offset), 0, AppendSimpleExtrudePolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRoundRectangleXY")]
	public unsafe static UDynamicMesh AppendRoundRectangleXY(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, float CornerRadius, int StepsWidth, int StepsHeight, int StepsRound, UGeometryScriptDebug Debug)
	{
		if (!AppendRoundRectangleXY_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRoundRectangleXY");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendRoundRectangleXY_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendRoundRectangleXY_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_TargetMesh_Offset), 0, AppendRoundRectangleXY_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendRoundRectangleXY_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_PrimitiveOptions_Offset), 0, AppendRoundRectangleXY_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendRoundRectangleXY_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_Transform_Offset), 0, AppendRoundRectangleXY_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_DimensionX_Offset), 0, AppendRoundRectangleXY_DimensionX_PropertyAddress.Address, DimensionX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_DimensionY_Offset), 0, AppendRoundRectangleXY_DimensionY_PropertyAddress.Address, DimensionY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_CornerRadius_Offset), 0, AppendRoundRectangleXY_CornerRadius_PropertyAddress.Address, CornerRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_StepsWidth_Offset), 0, AppendRoundRectangleXY_StepsWidth_PropertyAddress.Address, StepsWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_StepsHeight_Offset), 0, AppendRoundRectangleXY_StepsHeight_PropertyAddress.Address, StepsHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_StepsRound_Offset), 0, AppendRoundRectangleXY_StepsRound_PropertyAddress.Address, StepsRound);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_Debug_Offset), 0, AppendRoundRectangleXY_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendRoundRectangleXY_FunctionAddress, intPtr, AppendRoundRectangleXY_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendRoundRectangleXY_ReturnValue_Offset), 0, AppendRoundRectangleXY_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRoundRectangle_Compatibility_5_0")]
	public unsafe static UDynamicMesh AppendRoundRectangle_Compatibility_5_0(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, float CornerRadius, int StepsWidth, int StepsHeight, int StepsRound, UGeometryScriptDebug Debug)
	{
		if (!AppendRoundRectangle_Compatibility_5_0_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRoundRectangle_Compatibility_5_0");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendRoundRectangle_Compatibility_5_0_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendRoundRectangle_Compatibility_5_0_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_TargetMesh_Offset), 0, AppendRoundRectangle_Compatibility_5_0_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_Offset), 0, AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendRoundRectangle_Compatibility_5_0_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_Transform_Offset), 0, AppendRoundRectangle_Compatibility_5_0_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_DimensionX_Offset), 0, AppendRoundRectangle_Compatibility_5_0_DimensionX_PropertyAddress.Address, DimensionX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_DimensionY_Offset), 0, AppendRoundRectangle_Compatibility_5_0_DimensionY_PropertyAddress.Address, DimensionY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_CornerRadius_Offset), 0, AppendRoundRectangle_Compatibility_5_0_CornerRadius_PropertyAddress.Address, CornerRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_StepsWidth_Offset), 0, AppendRoundRectangle_Compatibility_5_0_StepsWidth_PropertyAddress.Address, StepsWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_StepsHeight_Offset), 0, AppendRoundRectangle_Compatibility_5_0_StepsHeight_PropertyAddress.Address, StepsHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_StepsRound_Offset), 0, AppendRoundRectangle_Compatibility_5_0_StepsRound_PropertyAddress.Address, StepsRound);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_Debug_Offset), 0, AppendRoundRectangle_Compatibility_5_0_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, intPtr, AppendRoundRectangle_Compatibility_5_0_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendRoundRectangle_Compatibility_5_0_ReturnValue_Offset), 0, AppendRoundRectangle_Compatibility_5_0_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRevolvePolygon")]
	public unsafe static UDynamicMesh AppendRevolvePolygon(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, FGeometryScriptRevolveOptions RevolveOptions, float Radius, int Steps, UGeometryScriptDebug Debug)
	{
		if (!AppendRevolvePolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRevolvePolygon");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendRevolvePolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendRevolvePolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_TargetMesh_Offset), 0, AppendRevolvePolygon_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendRevolvePolygon_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_PrimitiveOptions_Offset), 0, AppendRevolvePolygon_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendRevolvePolygon_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_Transform_Offset), 0, AppendRevolvePolygon_Transform_PropertyAddress.Address, Transform);
		new TArrayCopyMarshaler<FVector2D>(1, AppendRevolvePolygon_PolygonVertices_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_PolygonVertices_Offset), PolygonVertices);
		NativeReflection.InitializeValue_InContainer(AppendRevolvePolygon_RevolveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptRevolveOptions.ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_RevolveOptions_Offset), 0, AppendRevolvePolygon_RevolveOptions_PropertyAddress.Address, RevolveOptions);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_Radius_Offset), 0, AppendRevolvePolygon_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_Steps_Offset), 0, AppendRevolvePolygon_Steps_PropertyAddress.Address, Steps);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendRevolvePolygon_Debug_Offset), 0, AppendRevolvePolygon_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendRevolvePolygon_FunctionAddress, intPtr, AppendRevolvePolygon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendRevolvePolygon_PolygonVertices_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendRevolvePolygon_ReturnValue_Offset), 0, AppendRevolvePolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRevolvePath")]
	public unsafe static UDynamicMesh AppendRevolvePath(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PathVertices, FGeometryScriptRevolveOptions RevolveOptions, int Steps, bool bCapped, UGeometryScriptDebug Debug)
	{
		if (!AppendRevolvePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRevolvePath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendRevolvePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendRevolvePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendRevolvePath_TargetMesh_Offset), 0, AppendRevolvePath_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendRevolvePath_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendRevolvePath_PrimitiveOptions_Offset), 0, AppendRevolvePath_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendRevolvePath_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendRevolvePath_Transform_Offset), 0, AppendRevolvePath_Transform_PropertyAddress.Address, Transform);
		new TArrayCopyMarshaler<FVector2D>(1, AppendRevolvePath_PathVertices_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, AppendRevolvePath_PathVertices_Offset), PathVertices);
		NativeReflection.InitializeValue_InContainer(AppendRevolvePath_RevolveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptRevolveOptions.ToNative(IntPtr.Add(intPtr, AppendRevolvePath_RevolveOptions_Offset), 0, AppendRevolvePath_RevolveOptions_PropertyAddress.Address, RevolveOptions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRevolvePath_Steps_Offset), 0, AppendRevolvePath_Steps_PropertyAddress.Address, Steps);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendRevolvePath_bCapped_Offset), 0, AppendRevolvePath_bCapped_PropertyAddress.Address, bCapped);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendRevolvePath_Debug_Offset), 0, AppendRevolvePath_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendRevolvePath_FunctionAddress, intPtr, AppendRevolvePath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AppendRevolvePath_PathVertices_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendRevolvePath_ReturnValue_Offset), 0, AppendRevolvePath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRectangleXY")]
	public unsafe static UDynamicMesh AppendRectangleXY(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, int StepsWidth, int StepsHeight, UGeometryScriptDebug Debug)
	{
		if (!AppendRectangleXY_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRectangleXY");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendRectangleXY_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendRectangleXY_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_TargetMesh_Offset), 0, AppendRectangleXY_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendRectangleXY_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_PrimitiveOptions_Offset), 0, AppendRectangleXY_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendRectangleXY_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_Transform_Offset), 0, AppendRectangleXY_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_DimensionX_Offset), 0, AppendRectangleXY_DimensionX_PropertyAddress.Address, DimensionX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_DimensionY_Offset), 0, AppendRectangleXY_DimensionY_PropertyAddress.Address, DimensionY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_StepsWidth_Offset), 0, AppendRectangleXY_StepsWidth_PropertyAddress.Address, StepsWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_StepsHeight_Offset), 0, AppendRectangleXY_StepsHeight_PropertyAddress.Address, StepsHeight);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendRectangleXY_Debug_Offset), 0, AppendRectangleXY_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendRectangleXY_FunctionAddress, intPtr, AppendRectangleXY_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendRectangleXY_ReturnValue_Offset), 0, AppendRectangleXY_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRectangle_Compatibility_5_0")]
	public unsafe static UDynamicMesh AppendRectangle_Compatibility_5_0(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, int StepsWidth, int StepsHeight, UGeometryScriptDebug Debug)
	{
		if (!AppendRectangle_Compatibility_5_0_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRectangle_Compatibility_5_0");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendRectangle_Compatibility_5_0_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendRectangle_Compatibility_5_0_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_TargetMesh_Offset), 0, AppendRectangle_Compatibility_5_0_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_PrimitiveOptions_Offset), 0, AppendRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendRectangle_Compatibility_5_0_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_Transform_Offset), 0, AppendRectangle_Compatibility_5_0_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_DimensionX_Offset), 0, AppendRectangle_Compatibility_5_0_DimensionX_PropertyAddress.Address, DimensionX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_DimensionY_Offset), 0, AppendRectangle_Compatibility_5_0_DimensionY_PropertyAddress.Address, DimensionY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_StepsWidth_Offset), 0, AppendRectangle_Compatibility_5_0_StepsWidth_PropertyAddress.Address, StepsWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_StepsHeight_Offset), 0, AppendRectangle_Compatibility_5_0_StepsHeight_PropertyAddress.Address, StepsHeight);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_Debug_Offset), 0, AppendRectangle_Compatibility_5_0_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, intPtr, AppendRectangle_Compatibility_5_0_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendRectangle_Compatibility_5_0_ReturnValue_Offset), 0, AppendRectangle_Compatibility_5_0_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendLinearStairs")]
	public unsafe static UDynamicMesh AppendLinearStairs(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float StepWidth, float StepHeight, float StepDepth, int NumSteps, bool bFloating, UGeometryScriptDebug Debug)
	{
		if (!AppendLinearStairs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendLinearStairs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendLinearStairs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendLinearStairs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_TargetMesh_Offset), 0, AppendLinearStairs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendLinearStairs_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_PrimitiveOptions_Offset), 0, AppendLinearStairs_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendLinearStairs_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_Transform_Offset), 0, AppendLinearStairs_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_StepWidth_Offset), 0, AppendLinearStairs_StepWidth_PropertyAddress.Address, StepWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_StepHeight_Offset), 0, AppendLinearStairs_StepHeight_PropertyAddress.Address, StepHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_StepDepth_Offset), 0, AppendLinearStairs_StepDepth_PropertyAddress.Address, StepDepth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_NumSteps_Offset), 0, AppendLinearStairs_NumSteps_PropertyAddress.Address, NumSteps);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_bFloating_Offset), 0, AppendLinearStairs_bFloating_PropertyAddress.Address, bFloating);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendLinearStairs_Debug_Offset), 0, AppendLinearStairs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendLinearStairs_FunctionAddress, intPtr, AppendLinearStairs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendLinearStairs_ReturnValue_Offset), 0, AppendLinearStairs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendDisc")]
	public unsafe static UDynamicMesh AppendDisc(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, int AngleSteps, int SpokeSteps, float StartAngle, float EndAngle, float HoleRadius, UGeometryScriptDebug Debug)
	{
		if (!AppendDisc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendDisc");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendDisc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendDisc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendDisc_TargetMesh_Offset), 0, AppendDisc_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendDisc_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendDisc_PrimitiveOptions_Offset), 0, AppendDisc_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendDisc_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendDisc_Transform_Offset), 0, AppendDisc_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendDisc_Radius_Offset), 0, AppendDisc_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendDisc_AngleSteps_Offset), 0, AppendDisc_AngleSteps_PropertyAddress.Address, AngleSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendDisc_SpokeSteps_Offset), 0, AppendDisc_SpokeSteps_PropertyAddress.Address, SpokeSteps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendDisc_StartAngle_Offset), 0, AppendDisc_StartAngle_PropertyAddress.Address, StartAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendDisc_EndAngle_Offset), 0, AppendDisc_EndAngle_PropertyAddress.Address, EndAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendDisc_HoleRadius_Offset), 0, AppendDisc_HoleRadius_PropertyAddress.Address, HoleRadius);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendDisc_Debug_Offset), 0, AppendDisc_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendDisc_FunctionAddress, intPtr, AppendDisc_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendDisc_ReturnValue_Offset), 0, AppendDisc_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCylinder")]
	public unsafe static UDynamicMesh AppendCylinder(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, float Height, int RadialSteps, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendCylinder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCylinder");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendCylinder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendCylinder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendCylinder_TargetMesh_Offset), 0, AppendCylinder_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendCylinder_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendCylinder_PrimitiveOptions_Offset), 0, AppendCylinder_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendCylinder_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendCylinder_Transform_Offset), 0, AppendCylinder_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCylinder_Radius_Offset), 0, AppendCylinder_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCylinder_Height_Offset), 0, AppendCylinder_Height_PropertyAddress.Address, Height);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendCylinder_RadialSteps_Offset), 0, AppendCylinder_RadialSteps_PropertyAddress.Address, RadialSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendCylinder_HeightSteps_Offset), 0, AppendCylinder_HeightSteps_PropertyAddress.Address, HeightSteps);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendCylinder_bCapped_Offset), 0, AppendCylinder_bCapped_PropertyAddress.Address, bCapped);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendCylinder_Origin_Offset), 0, AppendCylinder_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendCylinder_Debug_Offset), 0, AppendCylinder_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendCylinder_FunctionAddress, intPtr, AppendCylinder_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendCylinder_ReturnValue_Offset), 0, AppendCylinder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCurvedStairs")]
	public unsafe static UDynamicMesh AppendCurvedStairs(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float StepWidth, float StepHeight, float InnerRadius, float CurveAngle, int NumSteps, bool bFloating, UGeometryScriptDebug Debug)
	{
		if (!AppendCurvedStairs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCurvedStairs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendCurvedStairs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendCurvedStairs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_TargetMesh_Offset), 0, AppendCurvedStairs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendCurvedStairs_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_PrimitiveOptions_Offset), 0, AppendCurvedStairs_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendCurvedStairs_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_Transform_Offset), 0, AppendCurvedStairs_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_StepWidth_Offset), 0, AppendCurvedStairs_StepWidth_PropertyAddress.Address, StepWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_StepHeight_Offset), 0, AppendCurvedStairs_StepHeight_PropertyAddress.Address, StepHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_InnerRadius_Offset), 0, AppendCurvedStairs_InnerRadius_PropertyAddress.Address, InnerRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_CurveAngle_Offset), 0, AppendCurvedStairs_CurveAngle_PropertyAddress.Address, CurveAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_NumSteps_Offset), 0, AppendCurvedStairs_NumSteps_PropertyAddress.Address, NumSteps);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_bFloating_Offset), 0, AppendCurvedStairs_bFloating_PropertyAddress.Address, bFloating);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendCurvedStairs_Debug_Offset), 0, AppendCurvedStairs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendCurvedStairs_FunctionAddress, intPtr, AppendCurvedStairs_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendCurvedStairs_ReturnValue_Offset), 0, AppendCurvedStairs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCone")]
	public unsafe static UDynamicMesh AppendCone(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float BaseRadius, float TopRadius, float Height, int RadialSteps, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCone");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendCone_TargetMesh_Offset), 0, AppendCone_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendCone_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendCone_PrimitiveOptions_Offset), 0, AppendCone_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendCone_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendCone_Transform_Offset), 0, AppendCone_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCone_BaseRadius_Offset), 0, AppendCone_BaseRadius_PropertyAddress.Address, BaseRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCone_TopRadius_Offset), 0, AppendCone_TopRadius_PropertyAddress.Address, TopRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCone_Height_Offset), 0, AppendCone_Height_PropertyAddress.Address, Height);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendCone_RadialSteps_Offset), 0, AppendCone_RadialSteps_PropertyAddress.Address, RadialSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendCone_HeightSteps_Offset), 0, AppendCone_HeightSteps_PropertyAddress.Address, HeightSteps);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AppendCone_bCapped_Offset), 0, AppendCone_bCapped_PropertyAddress.Address, bCapped);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendCone_Origin_Offset), 0, AppendCone_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendCone_Debug_Offset), 0, AppendCone_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendCone_FunctionAddress, intPtr, AppendCone_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendCone_ReturnValue_Offset), 0, AppendCone_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCapsule")]
	public unsafe static UDynamicMesh AppendCapsule(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, float LineLength, int HemisphereSteps, int CircleSteps, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendCapsule_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCapsule");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendCapsule_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendCapsule_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendCapsule_TargetMesh_Offset), 0, AppendCapsule_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendCapsule_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendCapsule_PrimitiveOptions_Offset), 0, AppendCapsule_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendCapsule_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendCapsule_Transform_Offset), 0, AppendCapsule_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCapsule_Radius_Offset), 0, AppendCapsule_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendCapsule_LineLength_Offset), 0, AppendCapsule_LineLength_PropertyAddress.Address, LineLength);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendCapsule_HemisphereSteps_Offset), 0, AppendCapsule_HemisphereSteps_PropertyAddress.Address, HemisphereSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendCapsule_CircleSteps_Offset), 0, AppendCapsule_CircleSteps_PropertyAddress.Address, CircleSteps);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendCapsule_Origin_Offset), 0, AppendCapsule_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendCapsule_Debug_Offset), 0, AppendCapsule_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendCapsule_FunctionAddress, intPtr, AppendCapsule_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendCapsule_ReturnValue_Offset), 0, AppendCapsule_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendBox")]
	public unsafe static UDynamicMesh AppendBox(UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, float DimensionZ, int StepsX, int StepsY, int StepsZ, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		if (!AppendBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendBox");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AppendBox_TargetMesh_Offset), 0, AppendBox_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(AppendBox_PrimitiveOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptPrimitiveOptions.ToNative(IntPtr.Add(intPtr, AppendBox_PrimitiveOptions_Offset), 0, AppendBox_PrimitiveOptions_PropertyAddress.Address, PrimitiveOptions);
		NativeReflection.InitializeValue_InContainer(AppendBox_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AppendBox_Transform_Offset), 0, AppendBox_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendBox_DimensionX_Offset), 0, AppendBox_DimensionX_PropertyAddress.Address, DimensionX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendBox_DimensionY_Offset), 0, AppendBox_DimensionY_PropertyAddress.Address, DimensionY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AppendBox_DimensionZ_Offset), 0, AppendBox_DimensionZ_PropertyAddress.Address, DimensionZ);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendBox_StepsX_Offset), 0, AppendBox_StepsX_PropertyAddress.Address, StepsX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendBox_StepsY_Offset), 0, AppendBox_StepsY_PropertyAddress.Address, StepsY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AppendBox_StepsZ_Offset), 0, AppendBox_StepsZ_PropertyAddress.Address, StepsZ);
		EnumMarshaler<EGeometryScriptPrimitiveOriginMode>.ToNative(IntPtr.Add(intPtr, AppendBox_Origin_Offset), 0, AppendBox_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AppendBox_Debug_Offset), 0, AppendBox_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendBox_FunctionAddress, intPtr, AppendBox_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AppendBox_ReturnValue_Offset), 0, AppendBox_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_Primitives()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_Primitives)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_Primitives));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions");
		AppendTriangulatedPolygon_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendTriangulatedPolygon");
		AppendTriangulatedPolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendTriangulatedPolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendTriangulatedPolygon_TargetMesh_PropertyAddress, AppendTriangulatedPolygon_FunctionAddress, "TargetMesh");
		AppendTriangulatedPolygon_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendTriangulatedPolygon_FunctionAddress, "TargetMesh");
		AppendTriangulatedPolygon_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTriangulatedPolygon_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTriangulatedPolygon_PrimitiveOptions_PropertyAddress, AppendTriangulatedPolygon_FunctionAddress, "PrimitiveOptions");
		AppendTriangulatedPolygon_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendTriangulatedPolygon_FunctionAddress, "PrimitiveOptions");
		AppendTriangulatedPolygon_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTriangulatedPolygon_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTriangulatedPolygon_Transform_PropertyAddress, AppendTriangulatedPolygon_FunctionAddress, "Transform");
		AppendTriangulatedPolygon_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendTriangulatedPolygon_FunctionAddress, "Transform");
		AppendTriangulatedPolygon_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTriangulatedPolygon_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTriangulatedPolygon_PolygonVertices_PropertyAddress, AppendTriangulatedPolygon_FunctionAddress, "PolygonVertices");
		AppendTriangulatedPolygon_PolygonVertices_Offset = NativeReflectionCached.GetPropertyOffset(AppendTriangulatedPolygon_FunctionAddress, "PolygonVertices");
		AppendTriangulatedPolygon_PolygonVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTriangulatedPolygon_FunctionAddress, "PolygonVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTriangulatedPolygon_bAllowSelfIntersections_PropertyAddress, AppendTriangulatedPolygon_FunctionAddress, "bAllowSelfIntersections");
		AppendTriangulatedPolygon_bAllowSelfIntersections_Offset = NativeReflectionCached.GetPropertyOffset(AppendTriangulatedPolygon_FunctionAddress, "bAllowSelfIntersections");
		AppendTriangulatedPolygon_bAllowSelfIntersections_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTriangulatedPolygon_FunctionAddress, "bAllowSelfIntersections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTriangulatedPolygon_Debug_PropertyAddress, AppendTriangulatedPolygon_FunctionAddress, "Debug");
		AppendTriangulatedPolygon_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendTriangulatedPolygon_FunctionAddress, "Debug");
		AppendTriangulatedPolygon_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTriangulatedPolygon_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTriangulatedPolygon_ReturnValue_PropertyAddress, AppendTriangulatedPolygon_FunctionAddress, "ReturnValue");
		AppendTriangulatedPolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendTriangulatedPolygon_FunctionAddress, "ReturnValue");
		AppendTriangulatedPolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTriangulatedPolygon_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendTriangulatedPolygon_IsValid = AppendTriangulatedPolygon_FunctionAddress != IntPtr.Zero && AppendTriangulatedPolygon_TargetMesh_IsValid && AppendTriangulatedPolygon_PrimitiveOptions_IsValid && AppendTriangulatedPolygon_Transform_IsValid && AppendTriangulatedPolygon_PolygonVertices_IsValid && AppendTriangulatedPolygon_bAllowSelfIntersections_IsValid && AppendTriangulatedPolygon_Debug_IsValid && AppendTriangulatedPolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendTriangulatedPolygon", AppendTriangulatedPolygon_IsValid);
		AppendTorus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendTorus");
		AppendTorus_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendTorus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_TargetMesh_PropertyAddress, AppendTorus_FunctionAddress, "TargetMesh");
		AppendTorus_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "TargetMesh");
		AppendTorus_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_PrimitiveOptions_PropertyAddress, AppendTorus_FunctionAddress, "PrimitiveOptions");
		AppendTorus_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "PrimitiveOptions");
		AppendTorus_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_Transform_PropertyAddress, AppendTorus_FunctionAddress, "Transform");
		AppendTorus_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "Transform");
		AppendTorus_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_RevolveOptions_PropertyAddress, AppendTorus_FunctionAddress, "RevolveOptions");
		AppendTorus_RevolveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "RevolveOptions");
		AppendTorus_RevolveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "RevolveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_MajorRadius_PropertyAddress, AppendTorus_FunctionAddress, "MajorRadius");
		AppendTorus_MajorRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "MajorRadius");
		AppendTorus_MajorRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "MajorRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_MinorRadius_PropertyAddress, AppendTorus_FunctionAddress, "MinorRadius");
		AppendTorus_MinorRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "MinorRadius");
		AppendTorus_MinorRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "MinorRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_MajorSteps_PropertyAddress, AppendTorus_FunctionAddress, "MajorSteps");
		AppendTorus_MajorSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "MajorSteps");
		AppendTorus_MajorSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "MajorSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_MinorSteps_PropertyAddress, AppendTorus_FunctionAddress, "MinorSteps");
		AppendTorus_MinorSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "MinorSteps");
		AppendTorus_MinorSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "MinorSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_Origin_PropertyAddress, AppendTorus_FunctionAddress, "Origin");
		AppendTorus_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "Origin");
		AppendTorus_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_Debug_PropertyAddress, AppendTorus_FunctionAddress, "Debug");
		AppendTorus_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "Debug");
		AppendTorus_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendTorus_ReturnValue_PropertyAddress, AppendTorus_FunctionAddress, "ReturnValue");
		AppendTorus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendTorus_FunctionAddress, "ReturnValue");
		AppendTorus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendTorus_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendTorus_IsValid = AppendTorus_FunctionAddress != IntPtr.Zero && AppendTorus_TargetMesh_IsValid && AppendTorus_PrimitiveOptions_IsValid && AppendTorus_Transform_IsValid && AppendTorus_RevolveOptions_IsValid && AppendTorus_MajorRadius_IsValid && AppendTorus_MinorRadius_IsValid && AppendTorus_MajorSteps_IsValid && AppendTorus_MinorSteps_IsValid && AppendTorus_Origin_IsValid && AppendTorus_Debug_IsValid && AppendTorus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendTorus", AppendTorus_IsValid);
		AppendSpiralRevolvePolygon_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendSpiralRevolvePolygon");
		AppendSpiralRevolvePolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendSpiralRevolvePolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_TargetMesh_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "TargetMesh");
		AppendSpiralRevolvePolygon_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "TargetMesh");
		AppendSpiralRevolvePolygon_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_PrimitiveOptions_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "PrimitiveOptions");
		AppendSpiralRevolvePolygon_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "PrimitiveOptions");
		AppendSpiralRevolvePolygon_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_Transform_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "Transform");
		AppendSpiralRevolvePolygon_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "Transform");
		AppendSpiralRevolvePolygon_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_PolygonVertices_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "PolygonVertices");
		AppendSpiralRevolvePolygon_PolygonVertices_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "PolygonVertices");
		AppendSpiralRevolvePolygon_PolygonVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "PolygonVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_RevolveOptions_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "RevolveOptions");
		AppendSpiralRevolvePolygon_RevolveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "RevolveOptions");
		AppendSpiralRevolvePolygon_RevolveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "RevolveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_Radius_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "Radius");
		AppendSpiralRevolvePolygon_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "Radius");
		AppendSpiralRevolvePolygon_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_Steps_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "Steps");
		AppendSpiralRevolvePolygon_Steps_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "Steps");
		AppendSpiralRevolvePolygon_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_RisePerRevolution_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "RisePerRevolution");
		AppendSpiralRevolvePolygon_RisePerRevolution_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "RisePerRevolution");
		AppendSpiralRevolvePolygon_RisePerRevolution_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "RisePerRevolution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_Debug_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "Debug");
		AppendSpiralRevolvePolygon_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "Debug");
		AppendSpiralRevolvePolygon_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSpiralRevolvePolygon_ReturnValue_PropertyAddress, AppendSpiralRevolvePolygon_FunctionAddress, "ReturnValue");
		AppendSpiralRevolvePolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendSpiralRevolvePolygon_FunctionAddress, "ReturnValue");
		AppendSpiralRevolvePolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSpiralRevolvePolygon_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendSpiralRevolvePolygon_IsValid = AppendSpiralRevolvePolygon_FunctionAddress != IntPtr.Zero && AppendSpiralRevolvePolygon_TargetMesh_IsValid && AppendSpiralRevolvePolygon_PrimitiveOptions_IsValid && AppendSpiralRevolvePolygon_Transform_IsValid && AppendSpiralRevolvePolygon_PolygonVertices_IsValid && AppendSpiralRevolvePolygon_RevolveOptions_IsValid && AppendSpiralRevolvePolygon_Radius_IsValid && AppendSpiralRevolvePolygon_Steps_IsValid && AppendSpiralRevolvePolygon_RisePerRevolution_IsValid && AppendSpiralRevolvePolygon_Debug_IsValid && AppendSpiralRevolvePolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSpiralRevolvePolygon", AppendSpiralRevolvePolygon_IsValid);
		AppendSphereLatLong_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendSphereLatLong");
		AppendSphereLatLong_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendSphereLatLong_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_TargetMesh_PropertyAddress, AppendSphereLatLong_FunctionAddress, "TargetMesh");
		AppendSphereLatLong_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "TargetMesh");
		AppendSphereLatLong_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_PrimitiveOptions_PropertyAddress, AppendSphereLatLong_FunctionAddress, "PrimitiveOptions");
		AppendSphereLatLong_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "PrimitiveOptions");
		AppendSphereLatLong_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_Transform_PropertyAddress, AppendSphereLatLong_FunctionAddress, "Transform");
		AppendSphereLatLong_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "Transform");
		AppendSphereLatLong_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_Radius_PropertyAddress, AppendSphereLatLong_FunctionAddress, "Radius");
		AppendSphereLatLong_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "Radius");
		AppendSphereLatLong_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_StepsPhi_PropertyAddress, AppendSphereLatLong_FunctionAddress, "StepsPhi");
		AppendSphereLatLong_StepsPhi_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "StepsPhi");
		AppendSphereLatLong_StepsPhi_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "StepsPhi", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_StepsTheta_PropertyAddress, AppendSphereLatLong_FunctionAddress, "StepsTheta");
		AppendSphereLatLong_StepsTheta_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "StepsTheta");
		AppendSphereLatLong_StepsTheta_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "StepsTheta", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_Origin_PropertyAddress, AppendSphereLatLong_FunctionAddress, "Origin");
		AppendSphereLatLong_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "Origin");
		AppendSphereLatLong_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_Debug_PropertyAddress, AppendSphereLatLong_FunctionAddress, "Debug");
		AppendSphereLatLong_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "Debug");
		AppendSphereLatLong_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereLatLong_ReturnValue_PropertyAddress, AppendSphereLatLong_FunctionAddress, "ReturnValue");
		AppendSphereLatLong_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereLatLong_FunctionAddress, "ReturnValue");
		AppendSphereLatLong_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereLatLong_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendSphereLatLong_IsValid = AppendSphereLatLong_FunctionAddress != IntPtr.Zero && AppendSphereLatLong_TargetMesh_IsValid && AppendSphereLatLong_PrimitiveOptions_IsValid && AppendSphereLatLong_Transform_IsValid && AppendSphereLatLong_Radius_IsValid && AppendSphereLatLong_StepsPhi_IsValid && AppendSphereLatLong_StepsTheta_IsValid && AppendSphereLatLong_Origin_IsValid && AppendSphereLatLong_Debug_IsValid && AppendSphereLatLong_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSphereLatLong", AppendSphereLatLong_IsValid);
		AppendSphereBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendSphereBox");
		AppendSphereBox_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendSphereBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_TargetMesh_PropertyAddress, AppendSphereBox_FunctionAddress, "TargetMesh");
		AppendSphereBox_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "TargetMesh");
		AppendSphereBox_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_PrimitiveOptions_PropertyAddress, AppendSphereBox_FunctionAddress, "PrimitiveOptions");
		AppendSphereBox_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "PrimitiveOptions");
		AppendSphereBox_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_Transform_PropertyAddress, AppendSphereBox_FunctionAddress, "Transform");
		AppendSphereBox_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "Transform");
		AppendSphereBox_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_Radius_PropertyAddress, AppendSphereBox_FunctionAddress, "Radius");
		AppendSphereBox_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "Radius");
		AppendSphereBox_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_StepsX_PropertyAddress, AppendSphereBox_FunctionAddress, "StepsX");
		AppendSphereBox_StepsX_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "StepsX");
		AppendSphereBox_StepsX_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "StepsX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_StepsY_PropertyAddress, AppendSphereBox_FunctionAddress, "StepsY");
		AppendSphereBox_StepsY_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "StepsY");
		AppendSphereBox_StepsY_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "StepsY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_StepsZ_PropertyAddress, AppendSphereBox_FunctionAddress, "StepsZ");
		AppendSphereBox_StepsZ_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "StepsZ");
		AppendSphereBox_StepsZ_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "StepsZ", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_Origin_PropertyAddress, AppendSphereBox_FunctionAddress, "Origin");
		AppendSphereBox_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "Origin");
		AppendSphereBox_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_Debug_PropertyAddress, AppendSphereBox_FunctionAddress, "Debug");
		AppendSphereBox_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "Debug");
		AppendSphereBox_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSphereBox_ReturnValue_PropertyAddress, AppendSphereBox_FunctionAddress, "ReturnValue");
		AppendSphereBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendSphereBox_FunctionAddress, "ReturnValue");
		AppendSphereBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSphereBox_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendSphereBox_IsValid = AppendSphereBox_FunctionAddress != IntPtr.Zero && AppendSphereBox_TargetMesh_IsValid && AppendSphereBox_PrimitiveOptions_IsValid && AppendSphereBox_Transform_IsValid && AppendSphereBox_Radius_IsValid && AppendSphereBox_StepsX_IsValid && AppendSphereBox_StepsY_IsValid && AppendSphereBox_StepsZ_IsValid && AppendSphereBox_Origin_IsValid && AppendSphereBox_Debug_IsValid && AppendSphereBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSphereBox", AppendSphereBox_IsValid);
		AppendSimpleSweptPolygon_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendSimpleSweptPolygon");
		AppendSimpleSweptPolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendSimpleSweptPolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_TargetMesh_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "TargetMesh");
		AppendSimpleSweptPolygon_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "TargetMesh");
		AppendSimpleSweptPolygon_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_PrimitiveOptions_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "PrimitiveOptions");
		AppendSimpleSweptPolygon_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "PrimitiveOptions");
		AppendSimpleSweptPolygon_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_Transform_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "Transform");
		AppendSimpleSweptPolygon_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "Transform");
		AppendSimpleSweptPolygon_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_PolygonVertices_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "PolygonVertices");
		AppendSimpleSweptPolygon_PolygonVertices_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "PolygonVertices");
		AppendSimpleSweptPolygon_PolygonVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "PolygonVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_SweepPath_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "SweepPath");
		AppendSimpleSweptPolygon_SweepPath_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "SweepPath");
		AppendSimpleSweptPolygon_SweepPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "SweepPath", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_bLoop_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "bLoop");
		AppendSimpleSweptPolygon_bLoop_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "bLoop");
		AppendSimpleSweptPolygon_bLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "bLoop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_bCapped_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "bCapped");
		AppendSimpleSweptPolygon_bCapped_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "bCapped");
		AppendSimpleSweptPolygon_bCapped_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "bCapped", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_StartScale_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "StartScale");
		AppendSimpleSweptPolygon_StartScale_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "StartScale");
		AppendSimpleSweptPolygon_StartScale_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "StartScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_EndScale_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "EndScale");
		AppendSimpleSweptPolygon_EndScale_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "EndScale");
		AppendSimpleSweptPolygon_EndScale_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "EndScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_Debug_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "Debug");
		AppendSimpleSweptPolygon_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "Debug");
		AppendSimpleSweptPolygon_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleSweptPolygon_ReturnValue_PropertyAddress, AppendSimpleSweptPolygon_FunctionAddress, "ReturnValue");
		AppendSimpleSweptPolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleSweptPolygon_FunctionAddress, "ReturnValue");
		AppendSimpleSweptPolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleSweptPolygon_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendSimpleSweptPolygon_IsValid = AppendSimpleSweptPolygon_FunctionAddress != IntPtr.Zero && AppendSimpleSweptPolygon_TargetMesh_IsValid && AppendSimpleSweptPolygon_PrimitiveOptions_IsValid && AppendSimpleSweptPolygon_Transform_IsValid && AppendSimpleSweptPolygon_PolygonVertices_IsValid && AppendSimpleSweptPolygon_SweepPath_IsValid && AppendSimpleSweptPolygon_bLoop_IsValid && AppendSimpleSweptPolygon_bCapped_IsValid && AppendSimpleSweptPolygon_StartScale_IsValid && AppendSimpleSweptPolygon_EndScale_IsValid && AppendSimpleSweptPolygon_Debug_IsValid && AppendSimpleSweptPolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSimpleSweptPolygon", AppendSimpleSweptPolygon_IsValid);
		AppendSimpleExtrudePolygon_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendSimpleExtrudePolygon");
		AppendSimpleExtrudePolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendSimpleExtrudePolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_TargetMesh_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "TargetMesh");
		AppendSimpleExtrudePolygon_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "TargetMesh");
		AppendSimpleExtrudePolygon_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_PrimitiveOptions_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "PrimitiveOptions");
		AppendSimpleExtrudePolygon_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "PrimitiveOptions");
		AppendSimpleExtrudePolygon_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_Transform_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "Transform");
		AppendSimpleExtrudePolygon_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "Transform");
		AppendSimpleExtrudePolygon_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_PolygonVertices_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "PolygonVertices");
		AppendSimpleExtrudePolygon_PolygonVertices_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "PolygonVertices");
		AppendSimpleExtrudePolygon_PolygonVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "PolygonVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_Height_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "Height");
		AppendSimpleExtrudePolygon_Height_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "Height");
		AppendSimpleExtrudePolygon_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "Height", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_HeightSteps_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "HeightSteps");
		AppendSimpleExtrudePolygon_HeightSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "HeightSteps");
		AppendSimpleExtrudePolygon_HeightSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "HeightSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_bCapped_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "bCapped");
		AppendSimpleExtrudePolygon_bCapped_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "bCapped");
		AppendSimpleExtrudePolygon_bCapped_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "bCapped", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_Origin_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "Origin");
		AppendSimpleExtrudePolygon_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "Origin");
		AppendSimpleExtrudePolygon_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_Debug_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "Debug");
		AppendSimpleExtrudePolygon_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "Debug");
		AppendSimpleExtrudePolygon_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendSimpleExtrudePolygon_ReturnValue_PropertyAddress, AppendSimpleExtrudePolygon_FunctionAddress, "ReturnValue");
		AppendSimpleExtrudePolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendSimpleExtrudePolygon_FunctionAddress, "ReturnValue");
		AppendSimpleExtrudePolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendSimpleExtrudePolygon_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendSimpleExtrudePolygon_IsValid = AppendSimpleExtrudePolygon_FunctionAddress != IntPtr.Zero && AppendSimpleExtrudePolygon_TargetMesh_IsValid && AppendSimpleExtrudePolygon_PrimitiveOptions_IsValid && AppendSimpleExtrudePolygon_Transform_IsValid && AppendSimpleExtrudePolygon_PolygonVertices_IsValid && AppendSimpleExtrudePolygon_Height_IsValid && AppendSimpleExtrudePolygon_HeightSteps_IsValid && AppendSimpleExtrudePolygon_bCapped_IsValid && AppendSimpleExtrudePolygon_Origin_IsValid && AppendSimpleExtrudePolygon_Debug_IsValid && AppendSimpleExtrudePolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendSimpleExtrudePolygon", AppendSimpleExtrudePolygon_IsValid);
		AppendRoundRectangleXY_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendRoundRectangleXY");
		AppendRoundRectangleXY_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendRoundRectangleXY_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_TargetMesh_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "TargetMesh");
		AppendRoundRectangleXY_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "TargetMesh");
		AppendRoundRectangleXY_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_PrimitiveOptions_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "PrimitiveOptions");
		AppendRoundRectangleXY_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "PrimitiveOptions");
		AppendRoundRectangleXY_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_Transform_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "Transform");
		AppendRoundRectangleXY_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "Transform");
		AppendRoundRectangleXY_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_DimensionX_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "DimensionX");
		AppendRoundRectangleXY_DimensionX_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "DimensionX");
		AppendRoundRectangleXY_DimensionX_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "DimensionX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_DimensionY_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "DimensionY");
		AppendRoundRectangleXY_DimensionY_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "DimensionY");
		AppendRoundRectangleXY_DimensionY_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "DimensionY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_CornerRadius_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "CornerRadius");
		AppendRoundRectangleXY_CornerRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "CornerRadius");
		AppendRoundRectangleXY_CornerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "CornerRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_StepsWidth_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "StepsWidth");
		AppendRoundRectangleXY_StepsWidth_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "StepsWidth");
		AppendRoundRectangleXY_StepsWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "StepsWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_StepsHeight_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "StepsHeight");
		AppendRoundRectangleXY_StepsHeight_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "StepsHeight");
		AppendRoundRectangleXY_StepsHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "StepsHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_StepsRound_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "StepsRound");
		AppendRoundRectangleXY_StepsRound_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "StepsRound");
		AppendRoundRectangleXY_StepsRound_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "StepsRound", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_Debug_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "Debug");
		AppendRoundRectangleXY_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "Debug");
		AppendRoundRectangleXY_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangleXY_ReturnValue_PropertyAddress, AppendRoundRectangleXY_FunctionAddress, "ReturnValue");
		AppendRoundRectangleXY_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangleXY_FunctionAddress, "ReturnValue");
		AppendRoundRectangleXY_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangleXY_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendRoundRectangleXY_IsValid = AppendRoundRectangleXY_FunctionAddress != IntPtr.Zero && AppendRoundRectangleXY_TargetMesh_IsValid && AppendRoundRectangleXY_PrimitiveOptions_IsValid && AppendRoundRectangleXY_Transform_IsValid && AppendRoundRectangleXY_DimensionX_IsValid && AppendRoundRectangleXY_DimensionY_IsValid && AppendRoundRectangleXY_CornerRadius_IsValid && AppendRoundRectangleXY_StepsWidth_IsValid && AppendRoundRectangleXY_StepsHeight_IsValid && AppendRoundRectangleXY_StepsRound_IsValid && AppendRoundRectangleXY_Debug_IsValid && AppendRoundRectangleXY_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRoundRectangleXY", AppendRoundRectangleXY_IsValid);
		AppendRoundRectangle_Compatibility_5_0_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendRoundRectangle_Compatibility_5_0");
		AppendRoundRectangle_Compatibility_5_0_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendRoundRectangle_Compatibility_5_0_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_TargetMesh_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "TargetMesh");
		AppendRoundRectangle_Compatibility_5_0_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "TargetMesh");
		AppendRoundRectangle_Compatibility_5_0_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "PrimitiveOptions");
		AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "PrimitiveOptions");
		AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_Transform_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "Transform");
		AppendRoundRectangle_Compatibility_5_0_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "Transform");
		AppendRoundRectangle_Compatibility_5_0_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_DimensionX_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "DimensionX");
		AppendRoundRectangle_Compatibility_5_0_DimensionX_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "DimensionX");
		AppendRoundRectangle_Compatibility_5_0_DimensionX_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "DimensionX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_DimensionY_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "DimensionY");
		AppendRoundRectangle_Compatibility_5_0_DimensionY_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "DimensionY");
		AppendRoundRectangle_Compatibility_5_0_DimensionY_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "DimensionY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_CornerRadius_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "CornerRadius");
		AppendRoundRectangle_Compatibility_5_0_CornerRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "CornerRadius");
		AppendRoundRectangle_Compatibility_5_0_CornerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "CornerRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_StepsWidth_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsWidth");
		AppendRoundRectangle_Compatibility_5_0_StepsWidth_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsWidth");
		AppendRoundRectangle_Compatibility_5_0_StepsWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_StepsHeight_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsHeight");
		AppendRoundRectangle_Compatibility_5_0_StepsHeight_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsHeight");
		AppendRoundRectangle_Compatibility_5_0_StepsHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_StepsRound_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsRound");
		AppendRoundRectangle_Compatibility_5_0_StepsRound_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsRound");
		AppendRoundRectangle_Compatibility_5_0_StepsRound_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "StepsRound", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_Debug_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "Debug");
		AppendRoundRectangle_Compatibility_5_0_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "Debug");
		AppendRoundRectangle_Compatibility_5_0_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRoundRectangle_Compatibility_5_0_ReturnValue_PropertyAddress, AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "ReturnValue");
		AppendRoundRectangle_Compatibility_5_0_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "ReturnValue");
		AppendRoundRectangle_Compatibility_5_0_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRoundRectangle_Compatibility_5_0_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendRoundRectangle_Compatibility_5_0_IsValid = AppendRoundRectangle_Compatibility_5_0_FunctionAddress != IntPtr.Zero && AppendRoundRectangle_Compatibility_5_0_TargetMesh_IsValid && AppendRoundRectangle_Compatibility_5_0_PrimitiveOptions_IsValid && AppendRoundRectangle_Compatibility_5_0_Transform_IsValid && AppendRoundRectangle_Compatibility_5_0_DimensionX_IsValid && AppendRoundRectangle_Compatibility_5_0_DimensionY_IsValid && AppendRoundRectangle_Compatibility_5_0_CornerRadius_IsValid && AppendRoundRectangle_Compatibility_5_0_StepsWidth_IsValid && AppendRoundRectangle_Compatibility_5_0_StepsHeight_IsValid && AppendRoundRectangle_Compatibility_5_0_StepsRound_IsValid && AppendRoundRectangle_Compatibility_5_0_Debug_IsValid && AppendRoundRectangle_Compatibility_5_0_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRoundRectangle_Compatibility_5_0", AppendRoundRectangle_Compatibility_5_0_IsValid);
		AppendRevolvePolygon_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendRevolvePolygon");
		AppendRevolvePolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendRevolvePolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_TargetMesh_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "TargetMesh");
		AppendRevolvePolygon_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "TargetMesh");
		AppendRevolvePolygon_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_PrimitiveOptions_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "PrimitiveOptions");
		AppendRevolvePolygon_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "PrimitiveOptions");
		AppendRevolvePolygon_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_Transform_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "Transform");
		AppendRevolvePolygon_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "Transform");
		AppendRevolvePolygon_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_PolygonVertices_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "PolygonVertices");
		AppendRevolvePolygon_PolygonVertices_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "PolygonVertices");
		AppendRevolvePolygon_PolygonVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "PolygonVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_RevolveOptions_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "RevolveOptions");
		AppendRevolvePolygon_RevolveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "RevolveOptions");
		AppendRevolvePolygon_RevolveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "RevolveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_Radius_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "Radius");
		AppendRevolvePolygon_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "Radius");
		AppendRevolvePolygon_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_Steps_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "Steps");
		AppendRevolvePolygon_Steps_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "Steps");
		AppendRevolvePolygon_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_Debug_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "Debug");
		AppendRevolvePolygon_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "Debug");
		AppendRevolvePolygon_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePolygon_ReturnValue_PropertyAddress, AppendRevolvePolygon_FunctionAddress, "ReturnValue");
		AppendRevolvePolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePolygon_FunctionAddress, "ReturnValue");
		AppendRevolvePolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePolygon_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendRevolvePolygon_IsValid = AppendRevolvePolygon_FunctionAddress != IntPtr.Zero && AppendRevolvePolygon_TargetMesh_IsValid && AppendRevolvePolygon_PrimitiveOptions_IsValid && AppendRevolvePolygon_Transform_IsValid && AppendRevolvePolygon_PolygonVertices_IsValid && AppendRevolvePolygon_RevolveOptions_IsValid && AppendRevolvePolygon_Radius_IsValid && AppendRevolvePolygon_Steps_IsValid && AppendRevolvePolygon_Debug_IsValid && AppendRevolvePolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRevolvePolygon", AppendRevolvePolygon_IsValid);
		AppendRevolvePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendRevolvePath");
		AppendRevolvePath_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendRevolvePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_TargetMesh_PropertyAddress, AppendRevolvePath_FunctionAddress, "TargetMesh");
		AppendRevolvePath_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "TargetMesh");
		AppendRevolvePath_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_PrimitiveOptions_PropertyAddress, AppendRevolvePath_FunctionAddress, "PrimitiveOptions");
		AppendRevolvePath_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "PrimitiveOptions");
		AppendRevolvePath_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_Transform_PropertyAddress, AppendRevolvePath_FunctionAddress, "Transform");
		AppendRevolvePath_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "Transform");
		AppendRevolvePath_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_PathVertices_PropertyAddress, AppendRevolvePath_FunctionAddress, "PathVertices");
		AppendRevolvePath_PathVertices_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "PathVertices");
		AppendRevolvePath_PathVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "PathVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_RevolveOptions_PropertyAddress, AppendRevolvePath_FunctionAddress, "RevolveOptions");
		AppendRevolvePath_RevolveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "RevolveOptions");
		AppendRevolvePath_RevolveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "RevolveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_Steps_PropertyAddress, AppendRevolvePath_FunctionAddress, "Steps");
		AppendRevolvePath_Steps_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "Steps");
		AppendRevolvePath_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_bCapped_PropertyAddress, AppendRevolvePath_FunctionAddress, "bCapped");
		AppendRevolvePath_bCapped_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "bCapped");
		AppendRevolvePath_bCapped_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "bCapped", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_Debug_PropertyAddress, AppendRevolvePath_FunctionAddress, "Debug");
		AppendRevolvePath_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "Debug");
		AppendRevolvePath_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRevolvePath_ReturnValue_PropertyAddress, AppendRevolvePath_FunctionAddress, "ReturnValue");
		AppendRevolvePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendRevolvePath_FunctionAddress, "ReturnValue");
		AppendRevolvePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRevolvePath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendRevolvePath_IsValid = AppendRevolvePath_FunctionAddress != IntPtr.Zero && AppendRevolvePath_TargetMesh_IsValid && AppendRevolvePath_PrimitiveOptions_IsValid && AppendRevolvePath_Transform_IsValid && AppendRevolvePath_PathVertices_IsValid && AppendRevolvePath_RevolveOptions_IsValid && AppendRevolvePath_Steps_IsValid && AppendRevolvePath_bCapped_IsValid && AppendRevolvePath_Debug_IsValid && AppendRevolvePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRevolvePath", AppendRevolvePath_IsValid);
		AppendRectangleXY_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendRectangleXY");
		AppendRectangleXY_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendRectangleXY_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_TargetMesh_PropertyAddress, AppendRectangleXY_FunctionAddress, "TargetMesh");
		AppendRectangleXY_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "TargetMesh");
		AppendRectangleXY_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_PrimitiveOptions_PropertyAddress, AppendRectangleXY_FunctionAddress, "PrimitiveOptions");
		AppendRectangleXY_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "PrimitiveOptions");
		AppendRectangleXY_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_Transform_PropertyAddress, AppendRectangleXY_FunctionAddress, "Transform");
		AppendRectangleXY_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "Transform");
		AppendRectangleXY_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_DimensionX_PropertyAddress, AppendRectangleXY_FunctionAddress, "DimensionX");
		AppendRectangleXY_DimensionX_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "DimensionX");
		AppendRectangleXY_DimensionX_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "DimensionX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_DimensionY_PropertyAddress, AppendRectangleXY_FunctionAddress, "DimensionY");
		AppendRectangleXY_DimensionY_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "DimensionY");
		AppendRectangleXY_DimensionY_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "DimensionY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_StepsWidth_PropertyAddress, AppendRectangleXY_FunctionAddress, "StepsWidth");
		AppendRectangleXY_StepsWidth_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "StepsWidth");
		AppendRectangleXY_StepsWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "StepsWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_StepsHeight_PropertyAddress, AppendRectangleXY_FunctionAddress, "StepsHeight");
		AppendRectangleXY_StepsHeight_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "StepsHeight");
		AppendRectangleXY_StepsHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "StepsHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_Debug_PropertyAddress, AppendRectangleXY_FunctionAddress, "Debug");
		AppendRectangleXY_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "Debug");
		AppendRectangleXY_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangleXY_ReturnValue_PropertyAddress, AppendRectangleXY_FunctionAddress, "ReturnValue");
		AppendRectangleXY_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangleXY_FunctionAddress, "ReturnValue");
		AppendRectangleXY_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangleXY_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendRectangleXY_IsValid = AppendRectangleXY_FunctionAddress != IntPtr.Zero && AppendRectangleXY_TargetMesh_IsValid && AppendRectangleXY_PrimitiveOptions_IsValid && AppendRectangleXY_Transform_IsValid && AppendRectangleXY_DimensionX_IsValid && AppendRectangleXY_DimensionY_IsValid && AppendRectangleXY_StepsWidth_IsValid && AppendRectangleXY_StepsHeight_IsValid && AppendRectangleXY_Debug_IsValid && AppendRectangleXY_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRectangleXY", AppendRectangleXY_IsValid);
		AppendRectangle_Compatibility_5_0_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendRectangle_Compatibility_5_0");
		AppendRectangle_Compatibility_5_0_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendRectangle_Compatibility_5_0_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_TargetMesh_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "TargetMesh");
		AppendRectangle_Compatibility_5_0_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "TargetMesh");
		AppendRectangle_Compatibility_5_0_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_PrimitiveOptions_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "PrimitiveOptions");
		AppendRectangle_Compatibility_5_0_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "PrimitiveOptions");
		AppendRectangle_Compatibility_5_0_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_Transform_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "Transform");
		AppendRectangle_Compatibility_5_0_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "Transform");
		AppendRectangle_Compatibility_5_0_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_DimensionX_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "DimensionX");
		AppendRectangle_Compatibility_5_0_DimensionX_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "DimensionX");
		AppendRectangle_Compatibility_5_0_DimensionX_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "DimensionX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_DimensionY_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "DimensionY");
		AppendRectangle_Compatibility_5_0_DimensionY_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "DimensionY");
		AppendRectangle_Compatibility_5_0_DimensionY_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "DimensionY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_StepsWidth_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "StepsWidth");
		AppendRectangle_Compatibility_5_0_StepsWidth_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "StepsWidth");
		AppendRectangle_Compatibility_5_0_StepsWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "StepsWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_StepsHeight_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "StepsHeight");
		AppendRectangle_Compatibility_5_0_StepsHeight_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "StepsHeight");
		AppendRectangle_Compatibility_5_0_StepsHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "StepsHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_Debug_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "Debug");
		AppendRectangle_Compatibility_5_0_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "Debug");
		AppendRectangle_Compatibility_5_0_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendRectangle_Compatibility_5_0_ReturnValue_PropertyAddress, AppendRectangle_Compatibility_5_0_FunctionAddress, "ReturnValue");
		AppendRectangle_Compatibility_5_0_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendRectangle_Compatibility_5_0_FunctionAddress, "ReturnValue");
		AppendRectangle_Compatibility_5_0_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendRectangle_Compatibility_5_0_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendRectangle_Compatibility_5_0_IsValid = AppendRectangle_Compatibility_5_0_FunctionAddress != IntPtr.Zero && AppendRectangle_Compatibility_5_0_TargetMesh_IsValid && AppendRectangle_Compatibility_5_0_PrimitiveOptions_IsValid && AppendRectangle_Compatibility_5_0_Transform_IsValid && AppendRectangle_Compatibility_5_0_DimensionX_IsValid && AppendRectangle_Compatibility_5_0_DimensionY_IsValid && AppendRectangle_Compatibility_5_0_StepsWidth_IsValid && AppendRectangle_Compatibility_5_0_StepsHeight_IsValid && AppendRectangle_Compatibility_5_0_Debug_IsValid && AppendRectangle_Compatibility_5_0_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendRectangle_Compatibility_5_0", AppendRectangle_Compatibility_5_0_IsValid);
		AppendLinearStairs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendLinearStairs");
		AppendLinearStairs_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendLinearStairs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_TargetMesh_PropertyAddress, AppendLinearStairs_FunctionAddress, "TargetMesh");
		AppendLinearStairs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "TargetMesh");
		AppendLinearStairs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_PrimitiveOptions_PropertyAddress, AppendLinearStairs_FunctionAddress, "PrimitiveOptions");
		AppendLinearStairs_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "PrimitiveOptions");
		AppendLinearStairs_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_Transform_PropertyAddress, AppendLinearStairs_FunctionAddress, "Transform");
		AppendLinearStairs_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "Transform");
		AppendLinearStairs_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_StepWidth_PropertyAddress, AppendLinearStairs_FunctionAddress, "StepWidth");
		AppendLinearStairs_StepWidth_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "StepWidth");
		AppendLinearStairs_StepWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "StepWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_StepHeight_PropertyAddress, AppendLinearStairs_FunctionAddress, "StepHeight");
		AppendLinearStairs_StepHeight_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "StepHeight");
		AppendLinearStairs_StepHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "StepHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_StepDepth_PropertyAddress, AppendLinearStairs_FunctionAddress, "StepDepth");
		AppendLinearStairs_StepDepth_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "StepDepth");
		AppendLinearStairs_StepDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "StepDepth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_NumSteps_PropertyAddress, AppendLinearStairs_FunctionAddress, "NumSteps");
		AppendLinearStairs_NumSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "NumSteps");
		AppendLinearStairs_NumSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "NumSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_bFloating_PropertyAddress, AppendLinearStairs_FunctionAddress, "bFloating");
		AppendLinearStairs_bFloating_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "bFloating");
		AppendLinearStairs_bFloating_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "bFloating", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_Debug_PropertyAddress, AppendLinearStairs_FunctionAddress, "Debug");
		AppendLinearStairs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "Debug");
		AppendLinearStairs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendLinearStairs_ReturnValue_PropertyAddress, AppendLinearStairs_FunctionAddress, "ReturnValue");
		AppendLinearStairs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendLinearStairs_FunctionAddress, "ReturnValue");
		AppendLinearStairs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendLinearStairs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendLinearStairs_IsValid = AppendLinearStairs_FunctionAddress != IntPtr.Zero && AppendLinearStairs_TargetMesh_IsValid && AppendLinearStairs_PrimitiveOptions_IsValid && AppendLinearStairs_Transform_IsValid && AppendLinearStairs_StepWidth_IsValid && AppendLinearStairs_StepHeight_IsValid && AppendLinearStairs_StepDepth_IsValid && AppendLinearStairs_NumSteps_IsValid && AppendLinearStairs_bFloating_IsValid && AppendLinearStairs_Debug_IsValid && AppendLinearStairs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendLinearStairs", AppendLinearStairs_IsValid);
		AppendDisc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendDisc");
		AppendDisc_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendDisc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_TargetMesh_PropertyAddress, AppendDisc_FunctionAddress, "TargetMesh");
		AppendDisc_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "TargetMesh");
		AppendDisc_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_PrimitiveOptions_PropertyAddress, AppendDisc_FunctionAddress, "PrimitiveOptions");
		AppendDisc_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "PrimitiveOptions");
		AppendDisc_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_Transform_PropertyAddress, AppendDisc_FunctionAddress, "Transform");
		AppendDisc_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "Transform");
		AppendDisc_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_Radius_PropertyAddress, AppendDisc_FunctionAddress, "Radius");
		AppendDisc_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "Radius");
		AppendDisc_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_AngleSteps_PropertyAddress, AppendDisc_FunctionAddress, "AngleSteps");
		AppendDisc_AngleSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "AngleSteps");
		AppendDisc_AngleSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "AngleSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_SpokeSteps_PropertyAddress, AppendDisc_FunctionAddress, "SpokeSteps");
		AppendDisc_SpokeSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "SpokeSteps");
		AppendDisc_SpokeSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "SpokeSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_StartAngle_PropertyAddress, AppendDisc_FunctionAddress, "StartAngle");
		AppendDisc_StartAngle_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "StartAngle");
		AppendDisc_StartAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "StartAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_EndAngle_PropertyAddress, AppendDisc_FunctionAddress, "EndAngle");
		AppendDisc_EndAngle_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "EndAngle");
		AppendDisc_EndAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "EndAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_HoleRadius_PropertyAddress, AppendDisc_FunctionAddress, "HoleRadius");
		AppendDisc_HoleRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "HoleRadius");
		AppendDisc_HoleRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "HoleRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_Debug_PropertyAddress, AppendDisc_FunctionAddress, "Debug");
		AppendDisc_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "Debug");
		AppendDisc_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendDisc_ReturnValue_PropertyAddress, AppendDisc_FunctionAddress, "ReturnValue");
		AppendDisc_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendDisc_FunctionAddress, "ReturnValue");
		AppendDisc_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendDisc_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendDisc_IsValid = AppendDisc_FunctionAddress != IntPtr.Zero && AppendDisc_TargetMesh_IsValid && AppendDisc_PrimitiveOptions_IsValid && AppendDisc_Transform_IsValid && AppendDisc_Radius_IsValid && AppendDisc_AngleSteps_IsValid && AppendDisc_SpokeSteps_IsValid && AppendDisc_StartAngle_IsValid && AppendDisc_EndAngle_IsValid && AppendDisc_HoleRadius_IsValid && AppendDisc_Debug_IsValid && AppendDisc_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendDisc", AppendDisc_IsValid);
		AppendCylinder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendCylinder");
		AppendCylinder_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendCylinder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_TargetMesh_PropertyAddress, AppendCylinder_FunctionAddress, "TargetMesh");
		AppendCylinder_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "TargetMesh");
		AppendCylinder_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_PrimitiveOptions_PropertyAddress, AppendCylinder_FunctionAddress, "PrimitiveOptions");
		AppendCylinder_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "PrimitiveOptions");
		AppendCylinder_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_Transform_PropertyAddress, AppendCylinder_FunctionAddress, "Transform");
		AppendCylinder_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "Transform");
		AppendCylinder_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_Radius_PropertyAddress, AppendCylinder_FunctionAddress, "Radius");
		AppendCylinder_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "Radius");
		AppendCylinder_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_Height_PropertyAddress, AppendCylinder_FunctionAddress, "Height");
		AppendCylinder_Height_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "Height");
		AppendCylinder_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "Height", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_RadialSteps_PropertyAddress, AppendCylinder_FunctionAddress, "RadialSteps");
		AppendCylinder_RadialSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "RadialSteps");
		AppendCylinder_RadialSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "RadialSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_HeightSteps_PropertyAddress, AppendCylinder_FunctionAddress, "HeightSteps");
		AppendCylinder_HeightSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "HeightSteps");
		AppendCylinder_HeightSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "HeightSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_bCapped_PropertyAddress, AppendCylinder_FunctionAddress, "bCapped");
		AppendCylinder_bCapped_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "bCapped");
		AppendCylinder_bCapped_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "bCapped", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_Origin_PropertyAddress, AppendCylinder_FunctionAddress, "Origin");
		AppendCylinder_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "Origin");
		AppendCylinder_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_Debug_PropertyAddress, AppendCylinder_FunctionAddress, "Debug");
		AppendCylinder_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "Debug");
		AppendCylinder_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCylinder_ReturnValue_PropertyAddress, AppendCylinder_FunctionAddress, "ReturnValue");
		AppendCylinder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendCylinder_FunctionAddress, "ReturnValue");
		AppendCylinder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCylinder_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendCylinder_IsValid = AppendCylinder_FunctionAddress != IntPtr.Zero && AppendCylinder_TargetMesh_IsValid && AppendCylinder_PrimitiveOptions_IsValid && AppendCylinder_Transform_IsValid && AppendCylinder_Radius_IsValid && AppendCylinder_Height_IsValid && AppendCylinder_RadialSteps_IsValid && AppendCylinder_HeightSteps_IsValid && AppendCylinder_bCapped_IsValid && AppendCylinder_Origin_IsValid && AppendCylinder_Debug_IsValid && AppendCylinder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCylinder", AppendCylinder_IsValid);
		AppendCurvedStairs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendCurvedStairs");
		AppendCurvedStairs_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendCurvedStairs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_TargetMesh_PropertyAddress, AppendCurvedStairs_FunctionAddress, "TargetMesh");
		AppendCurvedStairs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "TargetMesh");
		AppendCurvedStairs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_PrimitiveOptions_PropertyAddress, AppendCurvedStairs_FunctionAddress, "PrimitiveOptions");
		AppendCurvedStairs_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "PrimitiveOptions");
		AppendCurvedStairs_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_Transform_PropertyAddress, AppendCurvedStairs_FunctionAddress, "Transform");
		AppendCurvedStairs_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "Transform");
		AppendCurvedStairs_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_StepWidth_PropertyAddress, AppendCurvedStairs_FunctionAddress, "StepWidth");
		AppendCurvedStairs_StepWidth_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "StepWidth");
		AppendCurvedStairs_StepWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "StepWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_StepHeight_PropertyAddress, AppendCurvedStairs_FunctionAddress, "StepHeight");
		AppendCurvedStairs_StepHeight_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "StepHeight");
		AppendCurvedStairs_StepHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "StepHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_InnerRadius_PropertyAddress, AppendCurvedStairs_FunctionAddress, "InnerRadius");
		AppendCurvedStairs_InnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "InnerRadius");
		AppendCurvedStairs_InnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "InnerRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_CurveAngle_PropertyAddress, AppendCurvedStairs_FunctionAddress, "CurveAngle");
		AppendCurvedStairs_CurveAngle_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "CurveAngle");
		AppendCurvedStairs_CurveAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "CurveAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_NumSteps_PropertyAddress, AppendCurvedStairs_FunctionAddress, "NumSteps");
		AppendCurvedStairs_NumSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "NumSteps");
		AppendCurvedStairs_NumSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "NumSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_bFloating_PropertyAddress, AppendCurvedStairs_FunctionAddress, "bFloating");
		AppendCurvedStairs_bFloating_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "bFloating");
		AppendCurvedStairs_bFloating_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "bFloating", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_Debug_PropertyAddress, AppendCurvedStairs_FunctionAddress, "Debug");
		AppendCurvedStairs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "Debug");
		AppendCurvedStairs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCurvedStairs_ReturnValue_PropertyAddress, AppendCurvedStairs_FunctionAddress, "ReturnValue");
		AppendCurvedStairs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendCurvedStairs_FunctionAddress, "ReturnValue");
		AppendCurvedStairs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCurvedStairs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendCurvedStairs_IsValid = AppendCurvedStairs_FunctionAddress != IntPtr.Zero && AppendCurvedStairs_TargetMesh_IsValid && AppendCurvedStairs_PrimitiveOptions_IsValid && AppendCurvedStairs_Transform_IsValid && AppendCurvedStairs_StepWidth_IsValid && AppendCurvedStairs_StepHeight_IsValid && AppendCurvedStairs_InnerRadius_IsValid && AppendCurvedStairs_CurveAngle_IsValid && AppendCurvedStairs_NumSteps_IsValid && AppendCurvedStairs_bFloating_IsValid && AppendCurvedStairs_Debug_IsValid && AppendCurvedStairs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCurvedStairs", AppendCurvedStairs_IsValid);
		AppendCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendCone");
		AppendCone_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_TargetMesh_PropertyAddress, AppendCone_FunctionAddress, "TargetMesh");
		AppendCone_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "TargetMesh");
		AppendCone_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_PrimitiveOptions_PropertyAddress, AppendCone_FunctionAddress, "PrimitiveOptions");
		AppendCone_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "PrimitiveOptions");
		AppendCone_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_Transform_PropertyAddress, AppendCone_FunctionAddress, "Transform");
		AppendCone_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "Transform");
		AppendCone_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_BaseRadius_PropertyAddress, AppendCone_FunctionAddress, "BaseRadius");
		AppendCone_BaseRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "BaseRadius");
		AppendCone_BaseRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "BaseRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_TopRadius_PropertyAddress, AppendCone_FunctionAddress, "TopRadius");
		AppendCone_TopRadius_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "TopRadius");
		AppendCone_TopRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "TopRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_Height_PropertyAddress, AppendCone_FunctionAddress, "Height");
		AppendCone_Height_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "Height");
		AppendCone_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "Height", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_RadialSteps_PropertyAddress, AppendCone_FunctionAddress, "RadialSteps");
		AppendCone_RadialSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "RadialSteps");
		AppendCone_RadialSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "RadialSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_HeightSteps_PropertyAddress, AppendCone_FunctionAddress, "HeightSteps");
		AppendCone_HeightSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "HeightSteps");
		AppendCone_HeightSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "HeightSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_bCapped_PropertyAddress, AppendCone_FunctionAddress, "bCapped");
		AppendCone_bCapped_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "bCapped");
		AppendCone_bCapped_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "bCapped", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_Origin_PropertyAddress, AppendCone_FunctionAddress, "Origin");
		AppendCone_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "Origin");
		AppendCone_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_Debug_PropertyAddress, AppendCone_FunctionAddress, "Debug");
		AppendCone_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "Debug");
		AppendCone_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCone_ReturnValue_PropertyAddress, AppendCone_FunctionAddress, "ReturnValue");
		AppendCone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendCone_FunctionAddress, "ReturnValue");
		AppendCone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCone_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendCone_IsValid = AppendCone_FunctionAddress != IntPtr.Zero && AppendCone_TargetMesh_IsValid && AppendCone_PrimitiveOptions_IsValid && AppendCone_Transform_IsValid && AppendCone_BaseRadius_IsValid && AppendCone_TopRadius_IsValid && AppendCone_Height_IsValid && AppendCone_RadialSteps_IsValid && AppendCone_HeightSteps_IsValid && AppendCone_bCapped_IsValid && AppendCone_Origin_IsValid && AppendCone_Debug_IsValid && AppendCone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCone", AppendCone_IsValid);
		AppendCapsule_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendCapsule");
		AppendCapsule_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendCapsule_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_TargetMesh_PropertyAddress, AppendCapsule_FunctionAddress, "TargetMesh");
		AppendCapsule_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "TargetMesh");
		AppendCapsule_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_PrimitiveOptions_PropertyAddress, AppendCapsule_FunctionAddress, "PrimitiveOptions");
		AppendCapsule_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "PrimitiveOptions");
		AppendCapsule_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_Transform_PropertyAddress, AppendCapsule_FunctionAddress, "Transform");
		AppendCapsule_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "Transform");
		AppendCapsule_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_Radius_PropertyAddress, AppendCapsule_FunctionAddress, "Radius");
		AppendCapsule_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "Radius");
		AppendCapsule_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_LineLength_PropertyAddress, AppendCapsule_FunctionAddress, "LineLength");
		AppendCapsule_LineLength_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "LineLength");
		AppendCapsule_LineLength_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "LineLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_HemisphereSteps_PropertyAddress, AppendCapsule_FunctionAddress, "HemisphereSteps");
		AppendCapsule_HemisphereSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "HemisphereSteps");
		AppendCapsule_HemisphereSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "HemisphereSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_CircleSteps_PropertyAddress, AppendCapsule_FunctionAddress, "CircleSteps");
		AppendCapsule_CircleSteps_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "CircleSteps");
		AppendCapsule_CircleSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "CircleSteps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_Origin_PropertyAddress, AppendCapsule_FunctionAddress, "Origin");
		AppendCapsule_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "Origin");
		AppendCapsule_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_Debug_PropertyAddress, AppendCapsule_FunctionAddress, "Debug");
		AppendCapsule_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "Debug");
		AppendCapsule_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendCapsule_ReturnValue_PropertyAddress, AppendCapsule_FunctionAddress, "ReturnValue");
		AppendCapsule_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendCapsule_FunctionAddress, "ReturnValue");
		AppendCapsule_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendCapsule_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendCapsule_IsValid = AppendCapsule_FunctionAddress != IntPtr.Zero && AppendCapsule_TargetMesh_IsValid && AppendCapsule_PrimitiveOptions_IsValid && AppendCapsule_Transform_IsValid && AppendCapsule_Radius_IsValid && AppendCapsule_LineLength_IsValid && AppendCapsule_HemisphereSteps_IsValid && AppendCapsule_CircleSteps_IsValid && AppendCapsule_Origin_IsValid && AppendCapsule_Debug_IsValid && AppendCapsule_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendCapsule", AppendCapsule_IsValid);
		AppendBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendBox");
		AppendBox_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_TargetMesh_PropertyAddress, AppendBox_FunctionAddress, "TargetMesh");
		AppendBox_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "TargetMesh");
		AppendBox_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_PrimitiveOptions_PropertyAddress, AppendBox_FunctionAddress, "PrimitiveOptions");
		AppendBox_PrimitiveOptions_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "PrimitiveOptions");
		AppendBox_PrimitiveOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "PrimitiveOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_Transform_PropertyAddress, AppendBox_FunctionAddress, "Transform");
		AppendBox_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "Transform");
		AppendBox_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_DimensionX_PropertyAddress, AppendBox_FunctionAddress, "DimensionX");
		AppendBox_DimensionX_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "DimensionX");
		AppendBox_DimensionX_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "DimensionX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_DimensionY_PropertyAddress, AppendBox_FunctionAddress, "DimensionY");
		AppendBox_DimensionY_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "DimensionY");
		AppendBox_DimensionY_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "DimensionY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_DimensionZ_PropertyAddress, AppendBox_FunctionAddress, "DimensionZ");
		AppendBox_DimensionZ_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "DimensionZ");
		AppendBox_DimensionZ_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "DimensionZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_StepsX_PropertyAddress, AppendBox_FunctionAddress, "StepsX");
		AppendBox_StepsX_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "StepsX");
		AppendBox_StepsX_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "StepsX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_StepsY_PropertyAddress, AppendBox_FunctionAddress, "StepsY");
		AppendBox_StepsY_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "StepsY");
		AppendBox_StepsY_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "StepsY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_StepsZ_PropertyAddress, AppendBox_FunctionAddress, "StepsZ");
		AppendBox_StepsZ_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "StepsZ");
		AppendBox_StepsZ_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "StepsZ", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_Origin_PropertyAddress, AppendBox_FunctionAddress, "Origin");
		AppendBox_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "Origin");
		AppendBox_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "Origin", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_Debug_PropertyAddress, AppendBox_FunctionAddress, "Debug");
		AppendBox_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "Debug");
		AppendBox_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendBox_ReturnValue_PropertyAddress, AppendBox_FunctionAddress, "ReturnValue");
		AppendBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AppendBox_FunctionAddress, "ReturnValue");
		AppendBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendBox_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AppendBox_IsValid = AppendBox_FunctionAddress != IntPtr.Zero && AppendBox_TargetMesh_IsValid && AppendBox_PrimitiveOptions_IsValid && AppendBox_Transform_IsValid && AppendBox_DimensionX_IsValid && AppendBox_DimensionY_IsValid && AppendBox_DimensionZ_IsValid && AppendBox_StepsX_IsValid && AppendBox_StepsY_IsValid && AppendBox_StepsZ_IsValid && AppendBox_Origin_IsValid && AppendBox_Debug_IsValid && AppendBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPrimitiveFunctions:AppendBox", AppendBox_IsValid);
	}
}
