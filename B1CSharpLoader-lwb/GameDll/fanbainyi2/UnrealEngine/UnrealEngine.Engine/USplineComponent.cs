using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SplineComponent", "Engine", UnrealModuleType.Engine)]
public class USplineComponent : UPrimitiveComponent
{
	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool StationaryEndpoints_IsValid;

	private static FFieldAddress StationaryEndpoints_PropertyAddress;

	private static int StationaryEndpoints_Offset;

	private static bool InputSplinePointsToConstructionScript_IsValid;

	private static FFieldAddress InputSplinePointsToConstructionScript_PropertyAddress;

	private static int InputSplinePointsToConstructionScript_Offset;

	private static bool DrawDebug_IsValid;

	private static FFieldAddress DrawDebug_PropertyAddress;

	private static int DrawDebug_Offset;

	private static bool DefaultUpVector_IsValid;

	private static int DefaultUpVector_Offset;

	private static bool UpdateSpline_IsValid;

	private static IntPtr UpdateSpline_FunctionAddress;

	private static int UpdateSpline_ParamsSize;

	private static bool SetUpVectorAtSplinePoint_IsValid;

	private static IntPtr SetUpVectorAtSplinePoint_FunctionAddress;

	private static int SetUpVectorAtSplinePoint_ParamsSize;

	private static bool SetUpVectorAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress SetUpVectorAtSplinePoint_PointIndex_PropertyAddress;

	private static int SetUpVectorAtSplinePoint_PointIndex_Offset;

	private static bool SetUpVectorAtSplinePoint_InUpVector_IsValid;

	private static FFieldAddress SetUpVectorAtSplinePoint_InUpVector_PropertyAddress;

	private static int SetUpVectorAtSplinePoint_InUpVector_Offset;

	private static bool SetUpVectorAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress SetUpVectorAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int SetUpVectorAtSplinePoint_CoordinateSpace_Offset;

	private static bool SetUpVectorAtSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress SetUpVectorAtSplinePoint_bUpdateSpline_PropertyAddress;

	private static int SetUpVectorAtSplinePoint_bUpdateSpline_Offset;

	private static bool SetUnselectedSplineSegmentColor_IsValid;

	private static IntPtr SetUnselectedSplineSegmentColor_FunctionAddress;

	private static int SetUnselectedSplineSegmentColor_ParamsSize;

	private static bool SetUnselectedSplineSegmentColor_SegmentColor_IsValid;

	private static FFieldAddress SetUnselectedSplineSegmentColor_SegmentColor_PropertyAddress;

	private static int SetUnselectedSplineSegmentColor_SegmentColor_Offset;

	private static bool SetTangentsAtSplinePoint_IsValid;

	private static IntPtr SetTangentsAtSplinePoint_FunctionAddress;

	private static int SetTangentsAtSplinePoint_ParamsSize;

	private static bool SetTangentsAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress SetTangentsAtSplinePoint_PointIndex_PropertyAddress;

	private static int SetTangentsAtSplinePoint_PointIndex_Offset;

	private static bool SetTangentsAtSplinePoint_InArriveTangent_IsValid;

	private static FFieldAddress SetTangentsAtSplinePoint_InArriveTangent_PropertyAddress;

	private static int SetTangentsAtSplinePoint_InArriveTangent_Offset;

	private static bool SetTangentsAtSplinePoint_InLeaveTangent_IsValid;

	private static FFieldAddress SetTangentsAtSplinePoint_InLeaveTangent_PropertyAddress;

	private static int SetTangentsAtSplinePoint_InLeaveTangent_Offset;

	private static bool SetTangentsAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress SetTangentsAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int SetTangentsAtSplinePoint_CoordinateSpace_Offset;

	private static bool SetTangentsAtSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress SetTangentsAtSplinePoint_bUpdateSpline_PropertyAddress;

	private static int SetTangentsAtSplinePoint_bUpdateSpline_Offset;

	private static bool SetTangentColor_IsValid;

	private static IntPtr SetTangentColor_FunctionAddress;

	private static int SetTangentColor_ParamsSize;

	private static bool SetTangentColor_TangentColor_IsValid;

	private static FFieldAddress SetTangentColor_TangentColor_PropertyAddress;

	private static int SetTangentColor_TangentColor_Offset;

	private static bool SetTangentAtSplinePoint_IsValid;

	private static IntPtr SetTangentAtSplinePoint_FunctionAddress;

	private static int SetTangentAtSplinePoint_ParamsSize;

	private static bool SetTangentAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress SetTangentAtSplinePoint_PointIndex_PropertyAddress;

	private static int SetTangentAtSplinePoint_PointIndex_Offset;

	private static bool SetTangentAtSplinePoint_InTangent_IsValid;

	private static FFieldAddress SetTangentAtSplinePoint_InTangent_PropertyAddress;

	private static int SetTangentAtSplinePoint_InTangent_Offset;

	private static bool SetTangentAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress SetTangentAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int SetTangentAtSplinePoint_CoordinateSpace_Offset;

	private static bool SetTangentAtSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress SetTangentAtSplinePoint_bUpdateSpline_PropertyAddress;

	private static int SetTangentAtSplinePoint_bUpdateSpline_Offset;

	private static bool SetSplinePointType_IsValid;

	private static IntPtr SetSplinePointType_FunctionAddress;

	private static int SetSplinePointType_ParamsSize;

	private static bool SetSplinePointType_PointIndex_IsValid;

	private static FFieldAddress SetSplinePointType_PointIndex_PropertyAddress;

	private static int SetSplinePointType_PointIndex_Offset;

	private static bool SetSplinePointType_Type_IsValid;

	private static FFieldAddress SetSplinePointType_Type_PropertyAddress;

	private static int SetSplinePointType_Type_Offset;

	private static bool SetSplinePointType_bUpdateSpline_IsValid;

	private static FFieldAddress SetSplinePointType_bUpdateSpline_PropertyAddress;

	private static int SetSplinePointType_bUpdateSpline_Offset;

	private static bool SetSplinePoints_IsValid;

	private static IntPtr SetSplinePoints_FunctionAddress;

	private static int SetSplinePoints_ParamsSize;

	private static bool SetSplinePoints_Points_IsValid;

	private static FFieldAddress SetSplinePoints_Points_PropertyAddress;

	private static int SetSplinePoints_Points_Offset;

	private static bool SetSplinePoints_CoordinateSpace_IsValid;

	private static FFieldAddress SetSplinePoints_CoordinateSpace_PropertyAddress;

	private static int SetSplinePoints_CoordinateSpace_Offset;

	private static bool SetSplinePoints_bUpdateSpline_IsValid;

	private static FFieldAddress SetSplinePoints_bUpdateSpline_PropertyAddress;

	private static int SetSplinePoints_bUpdateSpline_Offset;

	private static bool SetSelectedSplineSegmentColor_IsValid;

	private static IntPtr SetSelectedSplineSegmentColor_FunctionAddress;

	private static int SetSelectedSplineSegmentColor_ParamsSize;

	private static bool SetSelectedSplineSegmentColor_SegmentColor_IsValid;

	private static FFieldAddress SetSelectedSplineSegmentColor_SegmentColor_PropertyAddress;

	private static int SetSelectedSplineSegmentColor_SegmentColor_Offset;

	private static bool SetScaleAtSplinePoint_IsValid;

	private static IntPtr SetScaleAtSplinePoint_FunctionAddress;

	private static int SetScaleAtSplinePoint_ParamsSize;

	private static bool SetScaleAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress SetScaleAtSplinePoint_PointIndex_PropertyAddress;

	private static int SetScaleAtSplinePoint_PointIndex_Offset;

	private static bool SetScaleAtSplinePoint_InScaleVector_IsValid;

	private static FFieldAddress SetScaleAtSplinePoint_InScaleVector_PropertyAddress;

	private static int SetScaleAtSplinePoint_InScaleVector_Offset;

	private static bool SetScaleAtSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress SetScaleAtSplinePoint_bUpdateSpline_PropertyAddress;

	private static int SetScaleAtSplinePoint_bUpdateSpline_Offset;

	private static bool SetRotationAtSplinePoint_IsValid;

	private static IntPtr SetRotationAtSplinePoint_FunctionAddress;

	private static int SetRotationAtSplinePoint_ParamsSize;

	private static bool SetRotationAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress SetRotationAtSplinePoint_PointIndex_PropertyAddress;

	private static int SetRotationAtSplinePoint_PointIndex_Offset;

	private static bool SetRotationAtSplinePoint_InRotation_IsValid;

	private static FFieldAddress SetRotationAtSplinePoint_InRotation_PropertyAddress;

	private static int SetRotationAtSplinePoint_InRotation_Offset;

	private static bool SetRotationAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress SetRotationAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int SetRotationAtSplinePoint_CoordinateSpace_Offset;

	private static bool SetRotationAtSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress SetRotationAtSplinePoint_bUpdateSpline_PropertyAddress;

	private static int SetRotationAtSplinePoint_bUpdateSpline_Offset;

	private static bool SetLocationAtSplinePoint_IsValid;

	private static IntPtr SetLocationAtSplinePoint_FunctionAddress;

	private static int SetLocationAtSplinePoint_ParamsSize;

	private static bool SetLocationAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress SetLocationAtSplinePoint_PointIndex_PropertyAddress;

	private static int SetLocationAtSplinePoint_PointIndex_Offset;

	private static bool SetLocationAtSplinePoint_InLocation_IsValid;

	private static FFieldAddress SetLocationAtSplinePoint_InLocation_PropertyAddress;

	private static int SetLocationAtSplinePoint_InLocation_Offset;

	private static bool SetLocationAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress SetLocationAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int SetLocationAtSplinePoint_CoordinateSpace_Offset;

	private static bool SetLocationAtSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress SetLocationAtSplinePoint_bUpdateSpline_PropertyAddress;

	private static int SetLocationAtSplinePoint_bUpdateSpline_Offset;

	private static bool SetDrawDebug_IsValid;

	private static IntPtr SetDrawDebug_FunctionAddress;

	private static int SetDrawDebug_ParamsSize;

	private static bool SetDrawDebug_bShow_IsValid;

	private static FFieldAddress SetDrawDebug_bShow_PropertyAddress;

	private static int SetDrawDebug_bShow_Offset;

	private static bool SetDefaultUpVector_IsValid;

	private static IntPtr SetDefaultUpVector_FunctionAddress;

	private static int SetDefaultUpVector_ParamsSize;

	private static bool SetDefaultUpVector_UpVector_IsValid;

	private static FFieldAddress SetDefaultUpVector_UpVector_PropertyAddress;

	private static int SetDefaultUpVector_UpVector_Offset;

	private static bool SetDefaultUpVector_CoordinateSpace_IsValid;

	private static FFieldAddress SetDefaultUpVector_CoordinateSpace_PropertyAddress;

	private static int SetDefaultUpVector_CoordinateSpace_Offset;

	private static bool SetClosedLoopAtPosition_IsValid;

	private static IntPtr SetClosedLoopAtPosition_FunctionAddress;

	private static int SetClosedLoopAtPosition_ParamsSize;

	private static bool SetClosedLoopAtPosition_bInClosedLoop_IsValid;

	private static FFieldAddress SetClosedLoopAtPosition_bInClosedLoop_PropertyAddress;

	private static int SetClosedLoopAtPosition_bInClosedLoop_Offset;

	private static bool SetClosedLoopAtPosition_Key_IsValid;

	private static FFieldAddress SetClosedLoopAtPosition_Key_PropertyAddress;

	private static int SetClosedLoopAtPosition_Key_Offset;

	private static bool SetClosedLoopAtPosition_bUpdateSpline_IsValid;

	private static FFieldAddress SetClosedLoopAtPosition_bUpdateSpline_PropertyAddress;

	private static int SetClosedLoopAtPosition_bUpdateSpline_Offset;

	private static bool SetClosedLoop_IsValid;

	private static IntPtr SetClosedLoop_FunctionAddress;

	private static int SetClosedLoop_ParamsSize;

	private static bool SetClosedLoop_bInClosedLoop_IsValid;

	private static FFieldAddress SetClosedLoop_bInClosedLoop_PropertyAddress;

	private static int SetClosedLoop_bInClosedLoop_Offset;

	private static bool SetClosedLoop_bUpdateSpline_IsValid;

	private static FFieldAddress SetClosedLoop_bUpdateSpline_PropertyAddress;

	private static int SetClosedLoop_bUpdateSpline_Offset;

	private static bool RemoveSplinePoint_IsValid;

	private static IntPtr RemoveSplinePoint_FunctionAddress;

	private static int RemoveSplinePoint_ParamsSize;

	private static bool RemoveSplinePoint_Index_IsValid;

	private static FFieldAddress RemoveSplinePoint_Index_PropertyAddress;

	private static int RemoveSplinePoint_Index_Offset;

	private static bool RemoveSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress RemoveSplinePoint_bUpdateSpline_PropertyAddress;

	private static int RemoveSplinePoint_bUpdateSpline_Offset;

	private static bool IsClosedLoop_IsValid;

	private static IntPtr IsClosedLoop_FunctionAddress;

	private static int IsClosedLoop_ParamsSize;

	private static bool IsClosedLoop_ReturnValue_IsValid;

	private static FFieldAddress IsClosedLoop_ReturnValue_PropertyAddress;

	private static int IsClosedLoop_ReturnValue_Offset;

	private static bool GetVectorPropertyAtSplinePoint_IsValid;

	private static IntPtr GetVectorPropertyAtSplinePoint_FunctionAddress;

	private static int GetVectorPropertyAtSplinePoint_ParamsSize;

	private static bool GetVectorPropertyAtSplinePoint_Index_IsValid;

	private static FFieldAddress GetVectorPropertyAtSplinePoint_Index_PropertyAddress;

	private static int GetVectorPropertyAtSplinePoint_Index_Offset;

	private static bool GetVectorPropertyAtSplinePoint_PropertyName_IsValid;

	private static FFieldAddress GetVectorPropertyAtSplinePoint_PropertyName_PropertyAddress;

	private static int GetVectorPropertyAtSplinePoint_PropertyName_Offset;

	private static bool GetVectorPropertyAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetVectorPropertyAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetVectorPropertyAtSplinePoint_ReturnValue_Offset;

	private static bool GetVectorPropertyAtSplineInputKey_IsValid;

	private static IntPtr GetVectorPropertyAtSplineInputKey_FunctionAddress;

	private static int GetVectorPropertyAtSplineInputKey_ParamsSize;

	private static bool GetVectorPropertyAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetVectorPropertyAtSplineInputKey_InKey_PropertyAddress;

	private static int GetVectorPropertyAtSplineInputKey_InKey_Offset;

	private static bool GetVectorPropertyAtSplineInputKey_PropertyName_IsValid;

	private static FFieldAddress GetVectorPropertyAtSplineInputKey_PropertyName_PropertyAddress;

	private static int GetVectorPropertyAtSplineInputKey_PropertyName_Offset;

	private static bool GetVectorPropertyAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetVectorPropertyAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetVectorPropertyAtSplineInputKey_ReturnValue_Offset;

	private static bool GetUpVectorAtTime_IsValid;

	private static IntPtr GetUpVectorAtTime_FunctionAddress;

	private static int GetUpVectorAtTime_ParamsSize;

	private static bool GetUpVectorAtTime_Time_IsValid;

	private static FFieldAddress GetUpVectorAtTime_Time_PropertyAddress;

	private static int GetUpVectorAtTime_Time_Offset;

	private static bool GetUpVectorAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetUpVectorAtTime_CoordinateSpace_PropertyAddress;

	private static int GetUpVectorAtTime_CoordinateSpace_Offset;

	private static bool GetUpVectorAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetUpVectorAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetUpVectorAtTime_bUseConstantVelocity_Offset;

	private static bool GetUpVectorAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetUpVectorAtTime_ReturnValue_PropertyAddress;

	private static int GetUpVectorAtTime_ReturnValue_Offset;

	private static bool GetUpVectorAtSplinePoint_IsValid;

	private static IntPtr GetUpVectorAtSplinePoint_FunctionAddress;

	private static int GetUpVectorAtSplinePoint_ParamsSize;

	private static bool GetUpVectorAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetUpVectorAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetUpVectorAtSplinePoint_PointIndex_Offset;

	private static bool GetUpVectorAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetUpVectorAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetUpVectorAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetUpVectorAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetUpVectorAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetUpVectorAtSplinePoint_ReturnValue_Offset;

	private static bool GetUpVectorAtSplineInputKey_IsValid;

	private static IntPtr GetUpVectorAtSplineInputKey_FunctionAddress;

	private static int GetUpVectorAtSplineInputKey_ParamsSize;

	private static bool GetUpVectorAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetUpVectorAtSplineInputKey_InKey_PropertyAddress;

	private static int GetUpVectorAtSplineInputKey_InKey_Offset;

	private static bool GetUpVectorAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetUpVectorAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetUpVectorAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetUpVectorAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetUpVectorAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetUpVectorAtSplineInputKey_ReturnValue_Offset;

	private static bool GetUpVectorAtDistanceAlongSpline_IsValid;

	private static IntPtr GetUpVectorAtDistanceAlongSpline_FunctionAddress;

	private static int GetUpVectorAtDistanceAlongSpline_ParamsSize;

	private static bool GetUpVectorAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetUpVectorAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetUpVectorAtDistanceAlongSpline_Distance_Offset;

	private static bool GetUpVectorAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetUpVectorAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetUpVectorAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetUpVectorAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetUpVectorAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetUpVectorAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetTransformAtTime_IsValid;

	private static IntPtr GetTransformAtTime_FunctionAddress;

	private static int GetTransformAtTime_ParamsSize;

	private static bool GetTransformAtTime_Time_IsValid;

	private static FFieldAddress GetTransformAtTime_Time_PropertyAddress;

	private static int GetTransformAtTime_Time_Offset;

	private static bool GetTransformAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetTransformAtTime_CoordinateSpace_PropertyAddress;

	private static int GetTransformAtTime_CoordinateSpace_Offset;

	private static bool GetTransformAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetTransformAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetTransformAtTime_bUseConstantVelocity_Offset;

	private static bool GetTransformAtTime_bUseScale_IsValid;

	private static FFieldAddress GetTransformAtTime_bUseScale_PropertyAddress;

	private static int GetTransformAtTime_bUseScale_Offset;

	private static bool GetTransformAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetTransformAtTime_ReturnValue_PropertyAddress;

	private static int GetTransformAtTime_ReturnValue_Offset;

	private static bool GetTransformAtSplinePoint_IsValid;

	private static IntPtr GetTransformAtSplinePoint_FunctionAddress;

	private static int GetTransformAtSplinePoint_ParamsSize;

	private static bool GetTransformAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetTransformAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetTransformAtSplinePoint_PointIndex_Offset;

	private static bool GetTransformAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetTransformAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetTransformAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetTransformAtSplinePoint_bUseScale_IsValid;

	private static FFieldAddress GetTransformAtSplinePoint_bUseScale_PropertyAddress;

	private static int GetTransformAtSplinePoint_bUseScale_Offset;

	private static bool GetTransformAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetTransformAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetTransformAtSplinePoint_ReturnValue_Offset;

	private static bool GetTransformAtSplineInputKey_IsValid;

	private static IntPtr GetTransformAtSplineInputKey_FunctionAddress;

	private static int GetTransformAtSplineInputKey_ParamsSize;

	private static bool GetTransformAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetTransformAtSplineInputKey_InKey_PropertyAddress;

	private static int GetTransformAtSplineInputKey_InKey_Offset;

	private static bool GetTransformAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetTransformAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetTransformAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetTransformAtSplineInputKey_bUseScale_IsValid;

	private static FFieldAddress GetTransformAtSplineInputKey_bUseScale_PropertyAddress;

	private static int GetTransformAtSplineInputKey_bUseScale_Offset;

	private static bool GetTransformAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetTransformAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetTransformAtSplineInputKey_ReturnValue_Offset;

	private static bool GetTransformAtDistanceAlongSpline_IsValid;

	private static IntPtr GetTransformAtDistanceAlongSpline_FunctionAddress;

	private static int GetTransformAtDistanceAlongSpline_ParamsSize;

	private static bool GetTransformAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetTransformAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetTransformAtDistanceAlongSpline_Distance_Offset;

	private static bool GetTransformAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetTransformAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetTransformAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetTransformAtDistanceAlongSpline_bUseScale_IsValid;

	private static FFieldAddress GetTransformAtDistanceAlongSpline_bUseScale_PropertyAddress;

	private static int GetTransformAtDistanceAlongSpline_bUseScale_Offset;

	private static bool GetTransformAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetTransformAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetTransformAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetTangentAtTime_IsValid;

	private static IntPtr GetTangentAtTime_FunctionAddress;

	private static int GetTangentAtTime_ParamsSize;

	private static bool GetTangentAtTime_Time_IsValid;

	private static FFieldAddress GetTangentAtTime_Time_PropertyAddress;

	private static int GetTangentAtTime_Time_Offset;

	private static bool GetTangentAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetTangentAtTime_CoordinateSpace_PropertyAddress;

	private static int GetTangentAtTime_CoordinateSpace_Offset;

	private static bool GetTangentAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetTangentAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetTangentAtTime_bUseConstantVelocity_Offset;

	private static bool GetTangentAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetTangentAtTime_ReturnValue_PropertyAddress;

	private static int GetTangentAtTime_ReturnValue_Offset;

	private static bool GetTangentAtSplinePoint_IsValid;

	private static IntPtr GetTangentAtSplinePoint_FunctionAddress;

	private static int GetTangentAtSplinePoint_ParamsSize;

	private static bool GetTangentAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetTangentAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetTangentAtSplinePoint_PointIndex_Offset;

	private static bool GetTangentAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetTangentAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetTangentAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetTangentAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetTangentAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetTangentAtSplinePoint_ReturnValue_Offset;

	private static bool GetTangentAtSplineInputKey_IsValid;

	private static IntPtr GetTangentAtSplineInputKey_FunctionAddress;

	private static int GetTangentAtSplineInputKey_ParamsSize;

	private static bool GetTangentAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetTangentAtSplineInputKey_InKey_PropertyAddress;

	private static int GetTangentAtSplineInputKey_InKey_Offset;

	private static bool GetTangentAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetTangentAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetTangentAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetTangentAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetTangentAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetTangentAtSplineInputKey_ReturnValue_Offset;

	private static bool GetTangentAtDistanceAlongSpline_IsValid;

	private static IntPtr GetTangentAtDistanceAlongSpline_FunctionAddress;

	private static int GetTangentAtDistanceAlongSpline_ParamsSize;

	private static bool GetTangentAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetTangentAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetTangentAtDistanceAlongSpline_Distance_Offset;

	private static bool GetTangentAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetTangentAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetTangentAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetTangentAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetTangentAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetTangentAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetSplinePointType_IsValid;

	private static IntPtr GetSplinePointType_FunctionAddress;

	private static int GetSplinePointType_ParamsSize;

	private static bool GetSplinePointType_PointIndex_IsValid;

	private static FFieldAddress GetSplinePointType_PointIndex_PropertyAddress;

	private static int GetSplinePointType_PointIndex_Offset;

	private static bool GetSplinePointType_ReturnValue_IsValid;

	private static FFieldAddress GetSplinePointType_ReturnValue_PropertyAddress;

	private static int GetSplinePointType_ReturnValue_Offset;

	private static bool GetSplineLength_IsValid;

	private static IntPtr GetSplineLength_FunctionAddress;

	private static int GetSplineLength_ParamsSize;

	private static bool GetSplineLength_ReturnValue_IsValid;

	private static FFieldAddress GetSplineLength_ReturnValue_PropertyAddress;

	private static int GetSplineLength_ReturnValue_Offset;

	private static bool GetScaleAtTime_IsValid;

	private static IntPtr GetScaleAtTime_FunctionAddress;

	private static int GetScaleAtTime_ParamsSize;

	private static bool GetScaleAtTime_Time_IsValid;

	private static FFieldAddress GetScaleAtTime_Time_PropertyAddress;

	private static int GetScaleAtTime_Time_Offset;

	private static bool GetScaleAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetScaleAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetScaleAtTime_bUseConstantVelocity_Offset;

	private static bool GetScaleAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetScaleAtTime_ReturnValue_PropertyAddress;

	private static int GetScaleAtTime_ReturnValue_Offset;

	private static bool GetScaleAtSplinePoint_IsValid;

	private static IntPtr GetScaleAtSplinePoint_FunctionAddress;

	private static int GetScaleAtSplinePoint_ParamsSize;

	private static bool GetScaleAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetScaleAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetScaleAtSplinePoint_PointIndex_Offset;

	private static bool GetScaleAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetScaleAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetScaleAtSplinePoint_ReturnValue_Offset;

	private static bool GetScaleAtSplineInputKey_IsValid;

	private static IntPtr GetScaleAtSplineInputKey_FunctionAddress;

	private static int GetScaleAtSplineInputKey_ParamsSize;

	private static bool GetScaleAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetScaleAtSplineInputKey_InKey_PropertyAddress;

	private static int GetScaleAtSplineInputKey_InKey_Offset;

	private static bool GetScaleAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetScaleAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetScaleAtSplineInputKey_ReturnValue_Offset;

	private static bool GetScaleAtDistanceAlongSpline_IsValid;

	private static IntPtr GetScaleAtDistanceAlongSpline_FunctionAddress;

	private static int GetScaleAtDistanceAlongSpline_ParamsSize;

	private static bool GetScaleAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetScaleAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetScaleAtDistanceAlongSpline_Distance_Offset;

	private static bool GetScaleAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetScaleAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetScaleAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetRotationAtTime_IsValid;

	private static IntPtr GetRotationAtTime_FunctionAddress;

	private static int GetRotationAtTime_ParamsSize;

	private static bool GetRotationAtTime_Time_IsValid;

	private static FFieldAddress GetRotationAtTime_Time_PropertyAddress;

	private static int GetRotationAtTime_Time_Offset;

	private static bool GetRotationAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetRotationAtTime_CoordinateSpace_PropertyAddress;

	private static int GetRotationAtTime_CoordinateSpace_Offset;

	private static bool GetRotationAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetRotationAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetRotationAtTime_bUseConstantVelocity_Offset;

	private static bool GetRotationAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetRotationAtTime_ReturnValue_PropertyAddress;

	private static int GetRotationAtTime_ReturnValue_Offset;

	private static bool GetRotationAtSplinePoint_IsValid;

	private static IntPtr GetRotationAtSplinePoint_FunctionAddress;

	private static int GetRotationAtSplinePoint_ParamsSize;

	private static bool GetRotationAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetRotationAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetRotationAtSplinePoint_PointIndex_Offset;

	private static bool GetRotationAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetRotationAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetRotationAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetRotationAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetRotationAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetRotationAtSplinePoint_ReturnValue_Offset;

	private static bool GetRotationAtSplineInputKey_IsValid;

	private static IntPtr GetRotationAtSplineInputKey_FunctionAddress;

	private static int GetRotationAtSplineInputKey_ParamsSize;

	private static bool GetRotationAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetRotationAtSplineInputKey_InKey_PropertyAddress;

	private static int GetRotationAtSplineInputKey_InKey_Offset;

	private static bool GetRotationAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetRotationAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetRotationAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetRotationAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetRotationAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetRotationAtSplineInputKey_ReturnValue_Offset;

	private static bool GetRotationAtDistanceAlongSpline_IsValid;

	private static IntPtr GetRotationAtDistanceAlongSpline_FunctionAddress;

	private static int GetRotationAtDistanceAlongSpline_ParamsSize;

	private static bool GetRotationAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetRotationAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetRotationAtDistanceAlongSpline_Distance_Offset;

	private static bool GetRotationAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetRotationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetRotationAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetRotationAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetRotationAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetRotationAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetRollAtTime_IsValid;

	private static IntPtr GetRollAtTime_FunctionAddress;

	private static int GetRollAtTime_ParamsSize;

	private static bool GetRollAtTime_Time_IsValid;

	private static FFieldAddress GetRollAtTime_Time_PropertyAddress;

	private static int GetRollAtTime_Time_Offset;

	private static bool GetRollAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetRollAtTime_CoordinateSpace_PropertyAddress;

	private static int GetRollAtTime_CoordinateSpace_Offset;

	private static bool GetRollAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetRollAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetRollAtTime_bUseConstantVelocity_Offset;

	private static bool GetRollAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetRollAtTime_ReturnValue_PropertyAddress;

	private static int GetRollAtTime_ReturnValue_Offset;

	private static bool GetRollAtSplinePoint_IsValid;

	private static IntPtr GetRollAtSplinePoint_FunctionAddress;

	private static int GetRollAtSplinePoint_ParamsSize;

	private static bool GetRollAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetRollAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetRollAtSplinePoint_PointIndex_Offset;

	private static bool GetRollAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetRollAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetRollAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetRollAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetRollAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetRollAtSplinePoint_ReturnValue_Offset;

	private static bool GetRollAtSplineInputKey_IsValid;

	private static IntPtr GetRollAtSplineInputKey_FunctionAddress;

	private static int GetRollAtSplineInputKey_ParamsSize;

	private static bool GetRollAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetRollAtSplineInputKey_InKey_PropertyAddress;

	private static int GetRollAtSplineInputKey_InKey_Offset;

	private static bool GetRollAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetRollAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetRollAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetRollAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetRollAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetRollAtSplineInputKey_ReturnValue_Offset;

	private static bool GetRollAtDistanceAlongSpline_IsValid;

	private static IntPtr GetRollAtDistanceAlongSpline_FunctionAddress;

	private static int GetRollAtDistanceAlongSpline_ParamsSize;

	private static bool GetRollAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetRollAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetRollAtDistanceAlongSpline_Distance_Offset;

	private static bool GetRollAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetRollAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetRollAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetRollAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetRollAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetRollAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetRightVectorAtTime_IsValid;

	private static IntPtr GetRightVectorAtTime_FunctionAddress;

	private static int GetRightVectorAtTime_ParamsSize;

	private static bool GetRightVectorAtTime_Time_IsValid;

	private static FFieldAddress GetRightVectorAtTime_Time_PropertyAddress;

	private static int GetRightVectorAtTime_Time_Offset;

	private static bool GetRightVectorAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetRightVectorAtTime_CoordinateSpace_PropertyAddress;

	private static int GetRightVectorAtTime_CoordinateSpace_Offset;

	private static bool GetRightVectorAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetRightVectorAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetRightVectorAtTime_bUseConstantVelocity_Offset;

	private static bool GetRightVectorAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetRightVectorAtTime_ReturnValue_PropertyAddress;

	private static int GetRightVectorAtTime_ReturnValue_Offset;

	private static bool GetRightVectorAtSplinePoint_IsValid;

	private static IntPtr GetRightVectorAtSplinePoint_FunctionAddress;

	private static int GetRightVectorAtSplinePoint_ParamsSize;

	private static bool GetRightVectorAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetRightVectorAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetRightVectorAtSplinePoint_PointIndex_Offset;

	private static bool GetRightVectorAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetRightVectorAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetRightVectorAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetRightVectorAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetRightVectorAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetRightVectorAtSplinePoint_ReturnValue_Offset;

	private static bool GetRightVectorAtSplineInputKey_IsValid;

	private static IntPtr GetRightVectorAtSplineInputKey_FunctionAddress;

	private static int GetRightVectorAtSplineInputKey_ParamsSize;

	private static bool GetRightVectorAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetRightVectorAtSplineInputKey_InKey_PropertyAddress;

	private static int GetRightVectorAtSplineInputKey_InKey_Offset;

	private static bool GetRightVectorAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetRightVectorAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetRightVectorAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetRightVectorAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetRightVectorAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetRightVectorAtSplineInputKey_ReturnValue_Offset;

	private static bool GetRightVectorAtDistanceAlongSpline_IsValid;

	private static IntPtr GetRightVectorAtDistanceAlongSpline_FunctionAddress;

	private static int GetRightVectorAtDistanceAlongSpline_ParamsSize;

	private static bool GetRightVectorAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetRightVectorAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetRightVectorAtDistanceAlongSpline_Distance_Offset;

	private static bool GetRightVectorAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetRightVectorAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetRightVectorAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetRightVectorAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetRightVectorAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetRightVectorAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetNumberOfSplineSegments_IsValid;

	private static IntPtr GetNumberOfSplineSegments_FunctionAddress;

	private static int GetNumberOfSplineSegments_ParamsSize;

	private static bool GetNumberOfSplineSegments_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfSplineSegments_ReturnValue_PropertyAddress;

	private static int GetNumberOfSplineSegments_ReturnValue_Offset;

	private static bool GetNumberOfSplinePoints_IsValid;

	private static IntPtr GetNumberOfSplinePoints_FunctionAddress;

	private static int GetNumberOfSplinePoints_ParamsSize;

	private static bool GetNumberOfSplinePoints_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfSplinePoints_ReturnValue_PropertyAddress;

	private static int GetNumberOfSplinePoints_ReturnValue_Offset;

	private static bool GetLocationAtTime_IsValid;

	private static IntPtr GetLocationAtTime_FunctionAddress;

	private static int GetLocationAtTime_ParamsSize;

	private static bool GetLocationAtTime_Time_IsValid;

	private static FFieldAddress GetLocationAtTime_Time_PropertyAddress;

	private static int GetLocationAtTime_Time_Offset;

	private static bool GetLocationAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAtTime_CoordinateSpace_PropertyAddress;

	private static int GetLocationAtTime_CoordinateSpace_Offset;

	private static bool GetLocationAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetLocationAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetLocationAtTime_bUseConstantVelocity_Offset;

	private static bool GetLocationAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetLocationAtTime_ReturnValue_PropertyAddress;

	private static int GetLocationAtTime_ReturnValue_Offset;

	private static bool GetLocationAtSplinePoint_IsValid;

	private static IntPtr GetLocationAtSplinePoint_FunctionAddress;

	private static int GetLocationAtSplinePoint_ParamsSize;

	private static bool GetLocationAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetLocationAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetLocationAtSplinePoint_PointIndex_Offset;

	private static bool GetLocationAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetLocationAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetLocationAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetLocationAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetLocationAtSplinePoint_ReturnValue_Offset;

	private static bool GetLocationAtSplineInputKey_IsValid;

	private static IntPtr GetLocationAtSplineInputKey_FunctionAddress;

	private static int GetLocationAtSplineInputKey_ParamsSize;

	private static bool GetLocationAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetLocationAtSplineInputKey_InKey_PropertyAddress;

	private static int GetLocationAtSplineInputKey_InKey_Offset;

	private static bool GetLocationAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetLocationAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetLocationAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetLocationAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetLocationAtSplineInputKey_ReturnValue_Offset;

	private static bool GetLocationAtDistanceAlongSpline_IsValid;

	private static IntPtr GetLocationAtDistanceAlongSpline_FunctionAddress;

	private static int GetLocationAtDistanceAlongSpline_ParamsSize;

	private static bool GetLocationAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetLocationAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetLocationAtDistanceAlongSpline_Distance_Offset;

	private static bool GetLocationAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetLocationAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetLocationAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetLocationAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetLocationAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetLocationAndTangentAtSplinePoint_IsValid;

	private static IntPtr GetLocationAndTangentAtSplinePoint_FunctionAddress;

	private static int GetLocationAndTangentAtSplinePoint_ParamsSize;

	private static bool GetLocationAndTangentAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetLocationAndTangentAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetLocationAndTangentAtSplinePoint_PointIndex_Offset;

	private static bool GetLocationAndTangentAtSplinePoint_Location_IsValid;

	private static FFieldAddress GetLocationAndTangentAtSplinePoint_Location_PropertyAddress;

	private static int GetLocationAndTangentAtSplinePoint_Location_Offset;

	private static bool GetLocationAndTangentAtSplinePoint_Tangent_IsValid;

	private static FFieldAddress GetLocationAndTangentAtSplinePoint_Tangent_PropertyAddress;

	private static int GetLocationAndTangentAtSplinePoint_Tangent_Offset;

	private static bool GetLocationAndTangentAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAndTangentAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetLocationAndTangentAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetLeaveTangentAtSplinePoint_IsValid;

	private static IntPtr GetLeaveTangentAtSplinePoint_FunctionAddress;

	private static int GetLeaveTangentAtSplinePoint_ParamsSize;

	private static bool GetLeaveTangentAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetLeaveTangentAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetLeaveTangentAtSplinePoint_PointIndex_Offset;

	private static bool GetLeaveTangentAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetLeaveTangentAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetLeaveTangentAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetLeaveTangentAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetLeaveTangentAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetLeaveTangentAtSplinePoint_ReturnValue_Offset;

	private static bool GetInputKeyAtDistanceAlongSpline_IsValid;

	private static IntPtr GetInputKeyAtDistanceAlongSpline_FunctionAddress;

	private static int GetInputKeyAtDistanceAlongSpline_ParamsSize;

	private static bool GetInputKeyAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetInputKeyAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetInputKeyAtDistanceAlongSpline_Distance_Offset;

	private static bool GetInputKeyAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetInputKeyAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetInputKeyAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetFloatPropertyAtSplinePoint_IsValid;

	private static IntPtr GetFloatPropertyAtSplinePoint_FunctionAddress;

	private static int GetFloatPropertyAtSplinePoint_ParamsSize;

	private static bool GetFloatPropertyAtSplinePoint_Index_IsValid;

	private static FFieldAddress GetFloatPropertyAtSplinePoint_Index_PropertyAddress;

	private static int GetFloatPropertyAtSplinePoint_Index_Offset;

	private static bool GetFloatPropertyAtSplinePoint_PropertyName_IsValid;

	private static FFieldAddress GetFloatPropertyAtSplinePoint_PropertyName_PropertyAddress;

	private static int GetFloatPropertyAtSplinePoint_PropertyName_Offset;

	private static bool GetFloatPropertyAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetFloatPropertyAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetFloatPropertyAtSplinePoint_ReturnValue_Offset;

	private static bool GetFloatPropertyAtSplineInputKey_IsValid;

	private static IntPtr GetFloatPropertyAtSplineInputKey_FunctionAddress;

	private static int GetFloatPropertyAtSplineInputKey_ParamsSize;

	private static bool GetFloatPropertyAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetFloatPropertyAtSplineInputKey_InKey_PropertyAddress;

	private static int GetFloatPropertyAtSplineInputKey_InKey_Offset;

	private static bool GetFloatPropertyAtSplineInputKey_PropertyName_IsValid;

	private static FFieldAddress GetFloatPropertyAtSplineInputKey_PropertyName_PropertyAddress;

	private static int GetFloatPropertyAtSplineInputKey_PropertyName_Offset;

	private static bool GetFloatPropertyAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetFloatPropertyAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetFloatPropertyAtSplineInputKey_ReturnValue_Offset;

	private static bool GetDistanceAlongSplineAtSplinePoint_IsValid;

	private static IntPtr GetDistanceAlongSplineAtSplinePoint_FunctionAddress;

	private static int GetDistanceAlongSplineAtSplinePoint_ParamsSize;

	private static bool GetDistanceAlongSplineAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetDistanceAlongSplineAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetDistanceAlongSplineAtSplinePoint_PointIndex_Offset;

	private static bool GetDistanceAlongSplineAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetDistanceAlongSplineAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetDistanceAlongSplineAtSplinePoint_ReturnValue_Offset;

	private static bool GetDistanceAlongSplineAtSplineInputKey_IsValid;

	private static IntPtr GetDistanceAlongSplineAtSplineInputKey_FunctionAddress;

	private static int GetDistanceAlongSplineAtSplineInputKey_ParamsSize;

	private static bool GetDistanceAlongSplineAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetDistanceAlongSplineAtSplineInputKey_InKey_PropertyAddress;

	private static int GetDistanceAlongSplineAtSplineInputKey_InKey_Offset;

	private static bool GetDistanceAlongSplineAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetDistanceAlongSplineAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetDistanceAlongSplineAtSplineInputKey_ReturnValue_Offset;

	private static bool GetDirectionAtTime_IsValid;

	private static IntPtr GetDirectionAtTime_FunctionAddress;

	private static int GetDirectionAtTime_ParamsSize;

	private static bool GetDirectionAtTime_Time_IsValid;

	private static FFieldAddress GetDirectionAtTime_Time_PropertyAddress;

	private static int GetDirectionAtTime_Time_Offset;

	private static bool GetDirectionAtTime_CoordinateSpace_IsValid;

	private static FFieldAddress GetDirectionAtTime_CoordinateSpace_PropertyAddress;

	private static int GetDirectionAtTime_CoordinateSpace_Offset;

	private static bool GetDirectionAtTime_bUseConstantVelocity_IsValid;

	private static FFieldAddress GetDirectionAtTime_bUseConstantVelocity_PropertyAddress;

	private static int GetDirectionAtTime_bUseConstantVelocity_Offset;

	private static bool GetDirectionAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetDirectionAtTime_ReturnValue_PropertyAddress;

	private static int GetDirectionAtTime_ReturnValue_Offset;

	private static bool GetDirectionAtSplinePoint_IsValid;

	private static IntPtr GetDirectionAtSplinePoint_FunctionAddress;

	private static int GetDirectionAtSplinePoint_ParamsSize;

	private static bool GetDirectionAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetDirectionAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetDirectionAtSplinePoint_PointIndex_Offset;

	private static bool GetDirectionAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetDirectionAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetDirectionAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetDirectionAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetDirectionAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetDirectionAtSplinePoint_ReturnValue_Offset;

	private static bool GetDirectionAtSplineInputKey_IsValid;

	private static IntPtr GetDirectionAtSplineInputKey_FunctionAddress;

	private static int GetDirectionAtSplineInputKey_ParamsSize;

	private static bool GetDirectionAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetDirectionAtSplineInputKey_InKey_PropertyAddress;

	private static int GetDirectionAtSplineInputKey_InKey_Offset;

	private static bool GetDirectionAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetDirectionAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetDirectionAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetDirectionAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetDirectionAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetDirectionAtSplineInputKey_ReturnValue_Offset;

	private static bool GetDirectionAtDistanceAlongSpline_IsValid;

	private static IntPtr GetDirectionAtDistanceAlongSpline_FunctionAddress;

	private static int GetDirectionAtDistanceAlongSpline_ParamsSize;

	private static bool GetDirectionAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetDirectionAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetDirectionAtDistanceAlongSpline_Distance_Offset;

	private static bool GetDirectionAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetDirectionAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetDirectionAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetDirectionAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetDirectionAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetDirectionAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetDefaultUpVector_IsValid;

	private static IntPtr GetDefaultUpVector_FunctionAddress;

	private static int GetDefaultUpVector_ParamsSize;

	private static bool GetDefaultUpVector_CoordinateSpace_IsValid;

	private static FFieldAddress GetDefaultUpVector_CoordinateSpace_PropertyAddress;

	private static int GetDefaultUpVector_CoordinateSpace_Offset;

	private static bool GetDefaultUpVector_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultUpVector_ReturnValue_PropertyAddress;

	private static int GetDefaultUpVector_ReturnValue_Offset;

	private static bool GetArriveTangentAtSplinePoint_IsValid;

	private static IntPtr GetArriveTangentAtSplinePoint_FunctionAddress;

	private static int GetArriveTangentAtSplinePoint_ParamsSize;

	private static bool GetArriveTangentAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetArriveTangentAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetArriveTangentAtSplinePoint_PointIndex_Offset;

	private static bool GetArriveTangentAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetArriveTangentAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetArriveTangentAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetArriveTangentAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetArriveTangentAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetArriveTangentAtSplinePoint_ReturnValue_Offset;

	private static bool FindUpVectorClosestToWorldLocation_IsValid;

	private static IntPtr FindUpVectorClosestToWorldLocation_FunctionAddress;

	private static int FindUpVectorClosestToWorldLocation_ParamsSize;

	private static bool FindUpVectorClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindUpVectorClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindUpVectorClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindUpVectorClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindUpVectorClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindUpVectorClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindUpVectorClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindUpVectorClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindUpVectorClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindTransformClosestToWorldLocation_IsValid;

	private static IntPtr FindTransformClosestToWorldLocation_FunctionAddress;

	private static int FindTransformClosestToWorldLocation_ParamsSize;

	private static bool FindTransformClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindTransformClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindTransformClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindTransformClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindTransformClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindTransformClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindTransformClosestToWorldLocation_bUseScale_IsValid;

	private static FFieldAddress FindTransformClosestToWorldLocation_bUseScale_PropertyAddress;

	private static int FindTransformClosestToWorldLocation_bUseScale_Offset;

	private static bool FindTransformClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindTransformClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindTransformClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindTangentClosestToWorldLocation_IsValid;

	private static IntPtr FindTangentClosestToWorldLocation_FunctionAddress;

	private static int FindTangentClosestToWorldLocation_ParamsSize;

	private static bool FindTangentClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindTangentClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindTangentClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindTangentClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindTangentClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindTangentClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindTangentClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindTangentClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindTangentClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindScaleClosestToWorldLocation_IsValid;

	private static IntPtr FindScaleClosestToWorldLocation_FunctionAddress;

	private static int FindScaleClosestToWorldLocation_ParamsSize;

	private static bool FindScaleClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindScaleClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindScaleClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindScaleClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindScaleClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindScaleClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindRotationClosestToWorldLocation_IsValid;

	private static IntPtr FindRotationClosestToWorldLocation_FunctionAddress;

	private static int FindRotationClosestToWorldLocation_ParamsSize;

	private static bool FindRotationClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindRotationClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindRotationClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindRotationClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindRotationClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindRotationClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindRotationClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindRotationClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindRotationClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindRollClosestToWorldLocation_IsValid;

	private static IntPtr FindRollClosestToWorldLocation_FunctionAddress;

	private static int FindRollClosestToWorldLocation_ParamsSize;

	private static bool FindRollClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindRollClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindRollClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindRollClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindRollClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindRollClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindRollClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindRollClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindRollClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindRightVectorClosestToWorldLocation_IsValid;

	private static IntPtr FindRightVectorClosestToWorldLocation_FunctionAddress;

	private static int FindRightVectorClosestToWorldLocation_ParamsSize;

	private static bool FindRightVectorClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindRightVectorClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindRightVectorClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindRightVectorClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindRightVectorClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindRightVectorClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindRightVectorClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindRightVectorClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindRightVectorClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindLocationClosestToWorldLocation_IsValid;

	private static IntPtr FindLocationClosestToWorldLocation_FunctionAddress;

	private static int FindLocationClosestToWorldLocation_ParamsSize;

	private static bool FindLocationClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindLocationClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindLocationClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindLocationClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindLocationClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindLocationClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindLocationClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindLocationClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindLocationClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindInputKeyClosestToWorldLocation_IsValid;

	private static IntPtr FindInputKeyClosestToWorldLocation_FunctionAddress;

	private static int FindInputKeyClosestToWorldLocation_ParamsSize;

	private static bool FindInputKeyClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindInputKeyClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindInputKeyClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindInputKeyClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindInputKeyClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindInputKeyClosestToWorldLocation_ReturnValue_Offset;

	private static bool FindDirectionClosestToWorldLocation_IsValid;

	private static IntPtr FindDirectionClosestToWorldLocation_FunctionAddress;

	private static int FindDirectionClosestToWorldLocation_ParamsSize;

	private static bool FindDirectionClosestToWorldLocation_WorldLocation_IsValid;

	private static FFieldAddress FindDirectionClosestToWorldLocation_WorldLocation_PropertyAddress;

	private static int FindDirectionClosestToWorldLocation_WorldLocation_Offset;

	private static bool FindDirectionClosestToWorldLocation_CoordinateSpace_IsValid;

	private static FFieldAddress FindDirectionClosestToWorldLocation_CoordinateSpace_PropertyAddress;

	private static int FindDirectionClosestToWorldLocation_CoordinateSpace_Offset;

	private static bool FindDirectionClosestToWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress FindDirectionClosestToWorldLocation_ReturnValue_PropertyAddress;

	private static int FindDirectionClosestToWorldLocation_ReturnValue_Offset;

	private static bool DivideSplineIntoPolylineRecursive_IsValid;

	private static IntPtr DivideSplineIntoPolylineRecursive_FunctionAddress;

	private static int DivideSplineIntoPolylineRecursive_ParamsSize;

	private static bool DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_IsValid;

	private static FFieldAddress DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_PropertyAddress;

	private static int DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_Offset;

	private static bool DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_IsValid;

	private static FFieldAddress DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_PropertyAddress;

	private static int DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_Offset;

	private static bool DivideSplineIntoPolylineRecursive_CoordinateSpace_IsValid;

	private static FFieldAddress DivideSplineIntoPolylineRecursive_CoordinateSpace_PropertyAddress;

	private static int DivideSplineIntoPolylineRecursive_CoordinateSpace_Offset;

	private static bool DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_IsValid;

	private static FFieldAddress DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_PropertyAddress;

	private static int DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_Offset;

	private static bool DivideSplineIntoPolylineRecursive_OutPoints_IsValid;

	private static FFieldAddress DivideSplineIntoPolylineRecursive_OutPoints_PropertyAddress;

	private static int DivideSplineIntoPolylineRecursive_OutPoints_Offset;

	private static bool DivideSplineIntoPolylineRecursive_ReturnValue_IsValid;

	private static FFieldAddress DivideSplineIntoPolylineRecursive_ReturnValue_PropertyAddress;

	private static int DivideSplineIntoPolylineRecursive_ReturnValue_Offset;

	private static bool ConvertSplineToPolyLine_IsValid;

	private static IntPtr ConvertSplineToPolyLine_FunctionAddress;

	private static int ConvertSplineToPolyLine_ParamsSize;

	private static bool ConvertSplineToPolyLine_CoordinateSpace_IsValid;

	private static FFieldAddress ConvertSplineToPolyLine_CoordinateSpace_PropertyAddress;

	private static int ConvertSplineToPolyLine_CoordinateSpace_Offset;

	private static bool ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_IsValid;

	private static FFieldAddress ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_PropertyAddress;

	private static int ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_Offset;

	private static bool ConvertSplineToPolyLine_OutPoints_IsValid;

	private static FFieldAddress ConvertSplineToPolyLine_OutPoints_PropertyAddress;

	private static int ConvertSplineToPolyLine_OutPoints_Offset;

	private static bool ConvertSplineToPolyLine_ReturnValue_IsValid;

	private static FFieldAddress ConvertSplineToPolyLine_ReturnValue_PropertyAddress;

	private static int ConvertSplineToPolyLine_ReturnValue_Offset;

	private static bool ConvertSplineSegmentToPolyLine_IsValid;

	private static IntPtr ConvertSplineSegmentToPolyLine_FunctionAddress;

	private static int ConvertSplineSegmentToPolyLine_ParamsSize;

	private static bool ConvertSplineSegmentToPolyLine_SplinePointStartIndex_IsValid;

	private static FFieldAddress ConvertSplineSegmentToPolyLine_SplinePointStartIndex_PropertyAddress;

	private static int ConvertSplineSegmentToPolyLine_SplinePointStartIndex_Offset;

	private static bool ConvertSplineSegmentToPolyLine_CoordinateSpace_IsValid;

	private static FFieldAddress ConvertSplineSegmentToPolyLine_CoordinateSpace_PropertyAddress;

	private static int ConvertSplineSegmentToPolyLine_CoordinateSpace_Offset;

	private static bool ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_IsValid;

	private static FFieldAddress ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_PropertyAddress;

	private static int ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_Offset;

	private static bool ConvertSplineSegmentToPolyLine_OutPoints_IsValid;

	private static FFieldAddress ConvertSplineSegmentToPolyLine_OutPoints_PropertyAddress;

	private static int ConvertSplineSegmentToPolyLine_OutPoints_Offset;

	private static bool ConvertSplineSegmentToPolyLine_ReturnValue_IsValid;

	private static FFieldAddress ConvertSplineSegmentToPolyLine_ReturnValue_PropertyAddress;

	private static int ConvertSplineSegmentToPolyLine_ReturnValue_Offset;

	private static bool ClearSplinePoints_IsValid;

	private static IntPtr ClearSplinePoints_FunctionAddress;

	private static int ClearSplinePoints_ParamsSize;

	private static bool ClearSplinePoints_bUpdateSpline_IsValid;

	private static FFieldAddress ClearSplinePoints_bUpdateSpline_PropertyAddress;

	private static int ClearSplinePoints_bUpdateSpline_Offset;

	private static bool AddSplinePointAtIndex_IsValid;

	private static IntPtr AddSplinePointAtIndex_FunctionAddress;

	private static int AddSplinePointAtIndex_ParamsSize;

	private static bool AddSplinePointAtIndex_Position_IsValid;

	private static FFieldAddress AddSplinePointAtIndex_Position_PropertyAddress;

	private static int AddSplinePointAtIndex_Position_Offset;

	private static bool AddSplinePointAtIndex_Index_IsValid;

	private static FFieldAddress AddSplinePointAtIndex_Index_PropertyAddress;

	private static int AddSplinePointAtIndex_Index_Offset;

	private static bool AddSplinePointAtIndex_CoordinateSpace_IsValid;

	private static FFieldAddress AddSplinePointAtIndex_CoordinateSpace_PropertyAddress;

	private static int AddSplinePointAtIndex_CoordinateSpace_Offset;

	private static bool AddSplinePointAtIndex_bUpdateSpline_IsValid;

	private static FFieldAddress AddSplinePointAtIndex_bUpdateSpline_PropertyAddress;

	private static int AddSplinePointAtIndex_bUpdateSpline_Offset;

	private static bool AddSplinePoint_IsValid;

	private static IntPtr AddSplinePoint_FunctionAddress;

	private static int AddSplinePoint_ParamsSize;

	private static bool AddSplinePoint_Position_IsValid;

	private static FFieldAddress AddSplinePoint_Position_PropertyAddress;

	private static int AddSplinePoint_Position_Offset;

	private static bool AddSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress AddSplinePoint_CoordinateSpace_PropertyAddress;

	private static int AddSplinePoint_CoordinateSpace_Offset;

	private static bool AddSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress AddSplinePoint_bUpdateSpline_PropertyAddress;

	private static int AddSplinePoint_bUpdateSpline_Offset;

	private static bool AddPoints_IsValid;

	private static IntPtr AddPoints_FunctionAddress;

	private static int AddPoints_ParamsSize;

	private static bool AddPoints_Points_IsValid;

	private static FFieldAddress AddPoints_Points_PropertyAddress;

	private static int AddPoints_Points_Offset;

	private static bool AddPoints_bUpdateSpline_IsValid;

	private static FFieldAddress AddPoints_bUpdateSpline_PropertyAddress;

	private static int AddPoints_bUpdateSpline_Offset;

	private static bool AddPoint_IsValid;

	private static IntPtr AddPoint_FunctionAddress;

	private static int AddPoint_ParamsSize;

	private static bool AddPoint_Point_IsValid;

	private static FFieldAddress AddPoint_Point_PropertyAddress;

	private static int AddPoint_Point_Offset;

	private static bool AddPoint_bUpdateSpline_IsValid;

	private static FFieldAddress AddPoint_bUpdateSpline_PropertyAddress;

	private static int AddPoint_bUpdateSpline_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplineComponent:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SplineComponent:bStationaryEndpoints")]
	public bool StationaryEndpoints
	{
		get
		{
			CheckDestroyed();
			if (!StationaryEndpoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:bStationaryEndpoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StationaryEndpoints_Offset), 0, StationaryEndpoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StationaryEndpoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:bStationaryEndpoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StationaryEndpoints_Offset), 0, StationaryEndpoints_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplineComponent:bInputSplinePointsToConstructionScript")]
	public bool InputSplinePointsToConstructionScript
	{
		get
		{
			CheckDestroyed();
			if (!InputSplinePointsToConstructionScript_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:bInputSplinePointsToConstructionScript");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InputSplinePointsToConstructionScript_Offset), 0, InputSplinePointsToConstructionScript_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InputSplinePointsToConstructionScript_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:bInputSplinePointsToConstructionScript");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InputSplinePointsToConstructionScript_Offset), 0, InputSplinePointsToConstructionScript_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplineComponent:bDrawDebug")]
	public bool DrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:bDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:bDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SplineComponent:DefaultUpVector")]
	public FVector DefaultUpVector
	{
		get
		{
			CheckDestroyed();
			if (!DefaultUpVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:DefaultUpVector");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, DefaultUpVector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultUpVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SplineComponent:DefaultUpVector");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, DefaultUpVector_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.SplineComponent:UpdateSpline")]
	public unsafe void UpdateSpline()
	{
		CheckDestroyed();
		if (!UpdateSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:UpdateSpline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateSpline_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateSpline_FunctionAddress, argsSize: UpdateSpline_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetUpVectorAtSplinePoint")]
	public unsafe void SetUpVectorAtSplinePoint(int PointIndex, FVector InUpVector, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetUpVectorAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetUpVectorAtSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUpVectorAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUpVectorAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUpVectorAtSplinePoint_PointIndex_Offset), 0, SetUpVectorAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetUpVectorAtSplinePoint_InUpVector_Offset), 0, SetUpVectorAtSplinePoint_InUpVector_PropertyAddress.Address, InUpVector);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, SetUpVectorAtSplinePoint_CoordinateSpace_Offset), 0, SetUpVectorAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUpVectorAtSplinePoint_bUpdateSpline_Offset), 0, SetUpVectorAtSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUpVectorAtSplinePoint_FunctionAddress, intPtr, SetUpVectorAtSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetUnselectedSplineSegmentColor")]
	public unsafe void SetUnselectedSplineSegmentColor(FLinearColor SegmentColor)
	{
		CheckDestroyed();
		if (!SetUnselectedSplineSegmentColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetUnselectedSplineSegmentColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUnselectedSplineSegmentColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUnselectedSplineSegmentColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetUnselectedSplineSegmentColor_SegmentColor_Offset), 0, SetUnselectedSplineSegmentColor_SegmentColor_PropertyAddress.Address, SegmentColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUnselectedSplineSegmentColor_FunctionAddress, intPtr, SetUnselectedSplineSegmentColor_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetTangentsAtSplinePoint")]
	public unsafe void SetTangentsAtSplinePoint(int PointIndex, FVector InArriveTangent, FVector InLeaveTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetTangentsAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetTangentsAtSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTangentsAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTangentsAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTangentsAtSplinePoint_PointIndex_Offset), 0, SetTangentsAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetTangentsAtSplinePoint_InArriveTangent_Offset), 0, SetTangentsAtSplinePoint_InArriveTangent_PropertyAddress.Address, InArriveTangent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetTangentsAtSplinePoint_InLeaveTangent_Offset), 0, SetTangentsAtSplinePoint_InLeaveTangent_PropertyAddress.Address, InLeaveTangent);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, SetTangentsAtSplinePoint_CoordinateSpace_Offset), 0, SetTangentsAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTangentsAtSplinePoint_bUpdateSpline_Offset), 0, SetTangentsAtSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTangentsAtSplinePoint_FunctionAddress, intPtr, SetTangentsAtSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetTangentColor")]
	public unsafe void SetTangentColor(FLinearColor TangentColor)
	{
		CheckDestroyed();
		if (!SetTangentColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetTangentColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTangentColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTangentColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetTangentColor_TangentColor_Offset), 0, SetTangentColor_TangentColor_PropertyAddress.Address, TangentColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTangentColor_FunctionAddress, intPtr, SetTangentColor_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetTangentAtSplinePoint")]
	public unsafe void SetTangentAtSplinePoint(int PointIndex, FVector InTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetTangentAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetTangentAtSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTangentAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTangentAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTangentAtSplinePoint_PointIndex_Offset), 0, SetTangentAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetTangentAtSplinePoint_InTangent_Offset), 0, SetTangentAtSplinePoint_InTangent_PropertyAddress.Address, InTangent);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, SetTangentAtSplinePoint_CoordinateSpace_Offset), 0, SetTangentAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTangentAtSplinePoint_bUpdateSpline_Offset), 0, SetTangentAtSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTangentAtSplinePoint_FunctionAddress, intPtr, SetTangentAtSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetSplinePointType")]
	public unsafe void SetSplinePointType(int PointIndex, ESplinePointType Type, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetSplinePointType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetSplinePointType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplinePointType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplinePointType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSplinePointType_PointIndex_Offset), 0, SetSplinePointType_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplinePointType>.ToNative(IntPtr.Add(intPtr, SetSplinePointType_Type_Offset), 0, SetSplinePointType_Type_PropertyAddress.Address, Type);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSplinePointType_bUpdateSpline_Offset), 0, SetSplinePointType_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSplinePointType_FunctionAddress, intPtr, SetSplinePointType_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetSplinePoints")]
	public unsafe void SetSplinePoints(List<FVector> Points, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetSplinePoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetSplinePoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplinePoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplinePoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, SetSplinePoints_Points_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSplinePoints_Points_Offset), Points);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, SetSplinePoints_CoordinateSpace_Offset), 0, SetSplinePoints_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSplinePoints_bUpdateSpline_Offset), 0, SetSplinePoints_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSplinePoints_FunctionAddress, intPtr, SetSplinePoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSplinePoints_Points_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetSelectedSplineSegmentColor")]
	public unsafe void SetSelectedSplineSegmentColor(FLinearColor SegmentColor)
	{
		CheckDestroyed();
		if (!SetSelectedSplineSegmentColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetSelectedSplineSegmentColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSelectedSplineSegmentColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSelectedSplineSegmentColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSelectedSplineSegmentColor_SegmentColor_Offset), 0, SetSelectedSplineSegmentColor_SegmentColor_PropertyAddress.Address, SegmentColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSelectedSplineSegmentColor_FunctionAddress, intPtr, SetSelectedSplineSegmentColor_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetScaleAtSplinePoint")]
	public unsafe void SetScaleAtSplinePoint(int PointIndex, FVector InScaleVector, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetScaleAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetScaleAtSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScaleAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScaleAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetScaleAtSplinePoint_PointIndex_Offset), 0, SetScaleAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetScaleAtSplinePoint_InScaleVector_Offset), 0, SetScaleAtSplinePoint_InScaleVector_PropertyAddress.Address, InScaleVector);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetScaleAtSplinePoint_bUpdateSpline_Offset), 0, SetScaleAtSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScaleAtSplinePoint_FunctionAddress, intPtr, SetScaleAtSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetRotationAtSplinePoint")]
	public unsafe void SetRotationAtSplinePoint(int PointIndex, FRotator InRotation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetRotationAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetRotationAtSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRotationAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRotationAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRotationAtSplinePoint_PointIndex_Offset), 0, SetRotationAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetRotationAtSplinePoint_InRotation_Offset), 0, SetRotationAtSplinePoint_InRotation_PropertyAddress.Address, InRotation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, SetRotationAtSplinePoint_CoordinateSpace_Offset), 0, SetRotationAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRotationAtSplinePoint_bUpdateSpline_Offset), 0, SetRotationAtSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRotationAtSplinePoint_FunctionAddress, intPtr, SetRotationAtSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetLocationAtSplinePoint")]
	public unsafe void SetLocationAtSplinePoint(int PointIndex, FVector InLocation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetLocationAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetLocationAtSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocationAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocationAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLocationAtSplinePoint_PointIndex_Offset), 0, SetLocationAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLocationAtSplinePoint_InLocation_Offset), 0, SetLocationAtSplinePoint_InLocation_PropertyAddress.Address, InLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, SetLocationAtSplinePoint_CoordinateSpace_Offset), 0, SetLocationAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocationAtSplinePoint_bUpdateSpline_Offset), 0, SetLocationAtSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocationAtSplinePoint_FunctionAddress, intPtr, SetLocationAtSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetDrawDebug")]
	public unsafe void SetDrawDebug(bool bShow)
	{
		CheckDestroyed();
		if (!SetDrawDebug_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetDrawDebug");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDrawDebug_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDrawDebug_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDrawDebug_bShow_Offset), 0, SetDrawDebug_bShow_PropertyAddress.Address, bShow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDrawDebug_FunctionAddress, intPtr, SetDrawDebug_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetDefaultUpVector")]
	public unsafe void SetDefaultUpVector(FVector UpVector, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!SetDefaultUpVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetDefaultUpVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultUpVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultUpVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetDefaultUpVector_UpVector_Offset), 0, SetDefaultUpVector_UpVector_PropertyAddress.Address, UpVector);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, SetDefaultUpVector_CoordinateSpace_Offset), 0, SetDefaultUpVector_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultUpVector_FunctionAddress, intPtr, SetDefaultUpVector_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetClosedLoopAtPosition")]
	public unsafe void SetClosedLoopAtPosition(bool bInClosedLoop, float Key, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetClosedLoopAtPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetClosedLoopAtPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetClosedLoopAtPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetClosedLoopAtPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetClosedLoopAtPosition_bInClosedLoop_Offset), 0, SetClosedLoopAtPosition_bInClosedLoop_PropertyAddress.Address, bInClosedLoop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetClosedLoopAtPosition_Key_Offset), 0, SetClosedLoopAtPosition_Key_PropertyAddress.Address, Key);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetClosedLoopAtPosition_bUpdateSpline_Offset), 0, SetClosedLoopAtPosition_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetClosedLoopAtPosition_FunctionAddress, intPtr, SetClosedLoopAtPosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineComponent:SetClosedLoop")]
	public unsafe void SetClosedLoop(bool bInClosedLoop, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!SetClosedLoop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:SetClosedLoop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetClosedLoop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetClosedLoop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetClosedLoop_bInClosedLoop_Offset), 0, SetClosedLoop_bInClosedLoop_PropertyAddress.Address, bInClosedLoop);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetClosedLoop_bUpdateSpline_Offset), 0, SetClosedLoop_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetClosedLoop_FunctionAddress, intPtr, SetClosedLoop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineComponent:RemoveSplinePoint")]
	public unsafe void RemoveSplinePoint(int Index, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!RemoveSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:RemoveSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveSplinePoint_Index_Offset), 0, RemoveSplinePoint_Index_PropertyAddress.Address, Index);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveSplinePoint_bUpdateSpline_Offset), 0, RemoveSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSplinePoint_FunctionAddress, intPtr, RemoveSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:IsClosedLoop")]
	public unsafe bool IsClosedLoop()
	{
		CheckDestroyed();
		if (!IsClosedLoop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:IsClosedLoop");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsClosedLoop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsClosedLoop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsClosedLoop_FunctionAddress, intPtr, IsClosedLoop_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsClosedLoop_ReturnValue_Offset), 0, IsClosedLoop_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetVectorPropertyAtSplinePoint")]
	public unsafe FVector GetVectorPropertyAtSplinePoint(int Index, FName PropertyName)
	{
		CheckDestroyed();
		if (!GetVectorPropertyAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetVectorPropertyAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorPropertyAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorPropertyAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVectorPropertyAtSplinePoint_Index_Offset), 0, GetVectorPropertyAtSplinePoint_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorPropertyAtSplinePoint_PropertyName_Offset), 0, GetVectorPropertyAtSplinePoint_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorPropertyAtSplinePoint_FunctionAddress, intPtr, GetVectorPropertyAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorPropertyAtSplinePoint_ReturnValue_Offset), 0, GetVectorPropertyAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetVectorPropertyAtSplineInputKey")]
	public unsafe FVector GetVectorPropertyAtSplineInputKey(float InKey, FName PropertyName)
	{
		CheckDestroyed();
		if (!GetVectorPropertyAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetVectorPropertyAtSplineInputKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorPropertyAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorPropertyAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetVectorPropertyAtSplineInputKey_InKey_Offset), 0, GetVectorPropertyAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorPropertyAtSplineInputKey_PropertyName_Offset), 0, GetVectorPropertyAtSplineInputKey_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorPropertyAtSplineInputKey_FunctionAddress, intPtr, GetVectorPropertyAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorPropertyAtSplineInputKey_ReturnValue_Offset), 0, GetVectorPropertyAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetUpVectorAtTime")]
	public unsafe FVector GetUpVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetUpVectorAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetUpVectorAtTime");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUpVectorAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUpVectorAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtTime_Time_Offset), 0, GetUpVectorAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtTime_CoordinateSpace_Offset), 0, GetUpVectorAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetUpVectorAtTime_bUseConstantVelocity_Offset), 0, GetUpVectorAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUpVectorAtTime_FunctionAddress, intPtr, GetUpVectorAtTime_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetUpVectorAtTime_ReturnValue_Offset), 0, GetUpVectorAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetUpVectorAtSplinePoint")]
	public unsafe FVector GetUpVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetUpVectorAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetUpVectorAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUpVectorAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUpVectorAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtSplinePoint_PointIndex_Offset), 0, GetUpVectorAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtSplinePoint_CoordinateSpace_Offset), 0, GetUpVectorAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUpVectorAtSplinePoint_FunctionAddress, intPtr, GetUpVectorAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetUpVectorAtSplinePoint_ReturnValue_Offset), 0, GetUpVectorAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetUpVectorAtSplineInputKey")]
	public unsafe FVector GetUpVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetUpVectorAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetUpVectorAtSplineInputKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUpVectorAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUpVectorAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtSplineInputKey_InKey_Offset), 0, GetUpVectorAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtSplineInputKey_CoordinateSpace_Offset), 0, GetUpVectorAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUpVectorAtSplineInputKey_FunctionAddress, intPtr, GetUpVectorAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetUpVectorAtSplineInputKey_ReturnValue_Offset), 0, GetUpVectorAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetUpVectorAtDistanceAlongSpline")]
	public unsafe FVector GetUpVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetUpVectorAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetUpVectorAtDistanceAlongSpline");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUpVectorAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUpVectorAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtDistanceAlongSpline_Distance_Offset), 0, GetUpVectorAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetUpVectorAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetUpVectorAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUpVectorAtDistanceAlongSpline_FunctionAddress, intPtr, GetUpVectorAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetUpVectorAtDistanceAlongSpline_ReturnValue_Offset), 0, GetUpVectorAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTransformAtTime")]
	public unsafe FTransform GetTransformAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false, bool bUseScale = false)
	{
		CheckDestroyed();
		if (!GetTransformAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTransformAtTime");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTransformAtTime_Time_Offset), 0, GetTransformAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTransformAtTime_CoordinateSpace_Offset), 0, GetTransformAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTransformAtTime_bUseConstantVelocity_Offset), 0, GetTransformAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTransformAtTime_bUseScale_Offset), 0, GetTransformAtTime_bUseScale_PropertyAddress.Address, bUseScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransformAtTime_FunctionAddress, intPtr, GetTransformAtTime_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformAtTime_ReturnValue_Offset), 0, GetTransformAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTransformAtSplinePoint")]
	public unsafe FTransform GetTransformAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
	{
		CheckDestroyed();
		if (!GetTransformAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTransformAtSplinePoint");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTransformAtSplinePoint_PointIndex_Offset), 0, GetTransformAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTransformAtSplinePoint_CoordinateSpace_Offset), 0, GetTransformAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTransformAtSplinePoint_bUseScale_Offset), 0, GetTransformAtSplinePoint_bUseScale_PropertyAddress.Address, bUseScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransformAtSplinePoint_FunctionAddress, intPtr, GetTransformAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformAtSplinePoint_ReturnValue_Offset), 0, GetTransformAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTransformAtSplineInputKey")]
	public unsafe FTransform GetTransformAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
	{
		CheckDestroyed();
		if (!GetTransformAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTransformAtSplineInputKey");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTransformAtSplineInputKey_InKey_Offset), 0, GetTransformAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTransformAtSplineInputKey_CoordinateSpace_Offset), 0, GetTransformAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTransformAtSplineInputKey_bUseScale_Offset), 0, GetTransformAtSplineInputKey_bUseScale_PropertyAddress.Address, bUseScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransformAtSplineInputKey_FunctionAddress, intPtr, GetTransformAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformAtSplineInputKey_ReturnValue_Offset), 0, GetTransformAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTransformAtDistanceAlongSpline")]
	public unsafe FTransform GetTransformAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
	{
		CheckDestroyed();
		if (!GetTransformAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTransformAtDistanceAlongSpline");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTransformAtDistanceAlongSpline_Distance_Offset), 0, GetTransformAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTransformAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetTransformAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTransformAtDistanceAlongSpline_bUseScale_Offset), 0, GetTransformAtDistanceAlongSpline_bUseScale_PropertyAddress.Address, bUseScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransformAtDistanceAlongSpline_FunctionAddress, intPtr, GetTransformAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformAtDistanceAlongSpline_ReturnValue_Offset), 0, GetTransformAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTangentAtTime")]
	public unsafe FVector GetTangentAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetTangentAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTangentAtTime");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTangentAtTime_Time_Offset), 0, GetTangentAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTangentAtTime_CoordinateSpace_Offset), 0, GetTangentAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetTangentAtTime_bUseConstantVelocity_Offset), 0, GetTangentAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentAtTime_FunctionAddress, intPtr, GetTangentAtTime_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTangentAtTime_ReturnValue_Offset), 0, GetTangentAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTangentAtSplinePoint")]
	public unsafe FVector GetTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetTangentAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTangentAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplinePoint_PointIndex_Offset), 0, GetTangentAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplinePoint_CoordinateSpace_Offset), 0, GetTangentAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentAtSplinePoint_FunctionAddress, intPtr, GetTangentAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTangentAtSplinePoint_ReturnValue_Offset), 0, GetTangentAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTangentAtSplineInputKey")]
	public unsafe FVector GetTangentAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetTangentAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTangentAtSplineInputKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplineInputKey_InKey_Offset), 0, GetTangentAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplineInputKey_CoordinateSpace_Offset), 0, GetTangentAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentAtSplineInputKey_FunctionAddress, intPtr, GetTangentAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTangentAtSplineInputKey_ReturnValue_Offset), 0, GetTangentAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetTangentAtDistanceAlongSpline")]
	public unsafe FVector GetTangentAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetTangentAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetTangentAtDistanceAlongSpline");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTangentAtDistanceAlongSpline_Distance_Offset), 0, GetTangentAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTangentAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetTangentAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentAtDistanceAlongSpline_FunctionAddress, intPtr, GetTangentAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTangentAtDistanceAlongSpline_ReturnValue_Offset), 0, GetTangentAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetSplinePointType")]
	public unsafe ESplinePointType GetSplinePointType(int PointIndex)
	{
		CheckDestroyed();
		if (!GetSplinePointType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetSplinePointType");
			return ESplinePointType.Linear;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplinePointType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplinePointType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSplinePointType_PointIndex_Offset), 0, GetSplinePointType_PointIndex_PropertyAddress.Address, PointIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplinePointType_FunctionAddress, intPtr, GetSplinePointType_ParamsSize);
		return EnumMarshaler<ESplinePointType>.FromNative(IntPtr.Add(intPtr, GetSplinePointType_ReturnValue_Offset), 0, GetSplinePointType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetSplineLength")]
	public unsafe float GetSplineLength()
	{
		CheckDestroyed();
		if (!GetSplineLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetSplineLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineLength_FunctionAddress, intPtr, GetSplineLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSplineLength_ReturnValue_Offset), 0, GetSplineLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetScaleAtTime")]
	public unsafe FVector GetScaleAtTime(float Time, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetScaleAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetScaleAtTime");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaleAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaleAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetScaleAtTime_Time_Offset), 0, GetScaleAtTime_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetScaleAtTime_bUseConstantVelocity_Offset), 0, GetScaleAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaleAtTime_FunctionAddress, intPtr, GetScaleAtTime_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetScaleAtTime_ReturnValue_Offset), 0, GetScaleAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetScaleAtSplinePoint")]
	public unsafe FVector GetScaleAtSplinePoint(int PointIndex)
	{
		CheckDestroyed();
		if (!GetScaleAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetScaleAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaleAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaleAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetScaleAtSplinePoint_PointIndex_Offset), 0, GetScaleAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaleAtSplinePoint_FunctionAddress, intPtr, GetScaleAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetScaleAtSplinePoint_ReturnValue_Offset), 0, GetScaleAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetScaleAtSplineInputKey")]
	public unsafe FVector GetScaleAtSplineInputKey(float InKey)
	{
		CheckDestroyed();
		if (!GetScaleAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetScaleAtSplineInputKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaleAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaleAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetScaleAtSplineInputKey_InKey_Offset), 0, GetScaleAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaleAtSplineInputKey_FunctionAddress, intPtr, GetScaleAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetScaleAtSplineInputKey_ReturnValue_Offset), 0, GetScaleAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetScaleAtDistanceAlongSpline")]
	public unsafe FVector GetScaleAtDistanceAlongSpline(float Distance)
	{
		CheckDestroyed();
		if (!GetScaleAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetScaleAtDistanceAlongSpline");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScaleAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScaleAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetScaleAtDistanceAlongSpline_Distance_Offset), 0, GetScaleAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScaleAtDistanceAlongSpline_FunctionAddress, intPtr, GetScaleAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetScaleAtDistanceAlongSpline_ReturnValue_Offset), 0, GetScaleAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRotationAtTime")]
	public unsafe FRotator GetRotationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetRotationAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRotationAtTime");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRotationAtTime_Time_Offset), 0, GetRotationAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRotationAtTime_CoordinateSpace_Offset), 0, GetRotationAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetRotationAtTime_bUseConstantVelocity_Offset), 0, GetRotationAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationAtTime_FunctionAddress, intPtr, GetRotationAtTime_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotationAtTime_ReturnValue_Offset), 0, GetRotationAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRotationAtSplinePoint")]
	public unsafe FRotator GetRotationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRotationAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRotationAtSplinePoint");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRotationAtSplinePoint_PointIndex_Offset), 0, GetRotationAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRotationAtSplinePoint_CoordinateSpace_Offset), 0, GetRotationAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationAtSplinePoint_FunctionAddress, intPtr, GetRotationAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotationAtSplinePoint_ReturnValue_Offset), 0, GetRotationAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRotationAtSplineInputKey")]
	public unsafe FRotator GetRotationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRotationAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRotationAtSplineInputKey");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRotationAtSplineInputKey_InKey_Offset), 0, GetRotationAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRotationAtSplineInputKey_CoordinateSpace_Offset), 0, GetRotationAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationAtSplineInputKey_FunctionAddress, intPtr, GetRotationAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotationAtSplineInputKey_ReturnValue_Offset), 0, GetRotationAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRotationAtDistanceAlongSpline")]
	public unsafe FRotator GetRotationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRotationAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRotationAtDistanceAlongSpline");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRotationAtDistanceAlongSpline_Distance_Offset), 0, GetRotationAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRotationAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetRotationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationAtDistanceAlongSpline_FunctionAddress, intPtr, GetRotationAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotationAtDistanceAlongSpline_ReturnValue_Offset), 0, GetRotationAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRollAtTime")]
	public unsafe float GetRollAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetRollAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRollAtTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRollAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRollAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRollAtTime_Time_Offset), 0, GetRollAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRollAtTime_CoordinateSpace_Offset), 0, GetRollAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetRollAtTime_bUseConstantVelocity_Offset), 0, GetRollAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRollAtTime_FunctionAddress, intPtr, GetRollAtTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRollAtTime_ReturnValue_Offset), 0, GetRollAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRollAtSplinePoint")]
	public unsafe float GetRollAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRollAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRollAtSplinePoint");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRollAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRollAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRollAtSplinePoint_PointIndex_Offset), 0, GetRollAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRollAtSplinePoint_CoordinateSpace_Offset), 0, GetRollAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRollAtSplinePoint_FunctionAddress, intPtr, GetRollAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRollAtSplinePoint_ReturnValue_Offset), 0, GetRollAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRollAtSplineInputKey")]
	public unsafe float GetRollAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRollAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRollAtSplineInputKey");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRollAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRollAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRollAtSplineInputKey_InKey_Offset), 0, GetRollAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRollAtSplineInputKey_CoordinateSpace_Offset), 0, GetRollAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRollAtSplineInputKey_FunctionAddress, intPtr, GetRollAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRollAtSplineInputKey_ReturnValue_Offset), 0, GetRollAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRollAtDistanceAlongSpline")]
	public unsafe float GetRollAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRollAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRollAtDistanceAlongSpline");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRollAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRollAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRollAtDistanceAlongSpline_Distance_Offset), 0, GetRollAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRollAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetRollAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRollAtDistanceAlongSpline_FunctionAddress, intPtr, GetRollAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRollAtDistanceAlongSpline_ReturnValue_Offset), 0, GetRollAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRightVectorAtTime")]
	public unsafe FVector GetRightVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetRightVectorAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRightVectorAtTime");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRightVectorAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRightVectorAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtTime_Time_Offset), 0, GetRightVectorAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtTime_CoordinateSpace_Offset), 0, GetRightVectorAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetRightVectorAtTime_bUseConstantVelocity_Offset), 0, GetRightVectorAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRightVectorAtTime_FunctionAddress, intPtr, GetRightVectorAtTime_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRightVectorAtTime_ReturnValue_Offset), 0, GetRightVectorAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRightVectorAtSplinePoint")]
	public unsafe FVector GetRightVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRightVectorAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRightVectorAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRightVectorAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRightVectorAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtSplinePoint_PointIndex_Offset), 0, GetRightVectorAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtSplinePoint_CoordinateSpace_Offset), 0, GetRightVectorAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRightVectorAtSplinePoint_FunctionAddress, intPtr, GetRightVectorAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRightVectorAtSplinePoint_ReturnValue_Offset), 0, GetRightVectorAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRightVectorAtSplineInputKey")]
	public unsafe FVector GetRightVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRightVectorAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRightVectorAtSplineInputKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRightVectorAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRightVectorAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtSplineInputKey_InKey_Offset), 0, GetRightVectorAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtSplineInputKey_CoordinateSpace_Offset), 0, GetRightVectorAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRightVectorAtSplineInputKey_FunctionAddress, intPtr, GetRightVectorAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRightVectorAtSplineInputKey_ReturnValue_Offset), 0, GetRightVectorAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetRightVectorAtDistanceAlongSpline")]
	public unsafe FVector GetRightVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRightVectorAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetRightVectorAtDistanceAlongSpline");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRightVectorAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRightVectorAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtDistanceAlongSpline_Distance_Offset), 0, GetRightVectorAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRightVectorAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetRightVectorAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRightVectorAtDistanceAlongSpline_FunctionAddress, intPtr, GetRightVectorAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRightVectorAtDistanceAlongSpline_ReturnValue_Offset), 0, GetRightVectorAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetNumberOfSplineSegments")]
	public unsafe int GetNumberOfSplineSegments()
	{
		CheckDestroyed();
		if (!GetNumberOfSplineSegments_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetNumberOfSplineSegments");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfSplineSegments_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfSplineSegments_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfSplineSegments_FunctionAddress, intPtr, GetNumberOfSplineSegments_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfSplineSegments_ReturnValue_Offset), 0, GetNumberOfSplineSegments_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetNumberOfSplinePoints")]
	public unsafe int GetNumberOfSplinePoints()
	{
		CheckDestroyed();
		if (!GetNumberOfSplinePoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetNumberOfSplinePoints");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfSplinePoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfSplinePoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfSplinePoints_FunctionAddress, intPtr, GetNumberOfSplinePoints_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfSplinePoints_ReturnValue_Offset), 0, GetNumberOfSplinePoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetLocationAtTime")]
	public unsafe FVector GetLocationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetLocationAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetLocationAtTime");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLocationAtTime_Time_Offset), 0, GetLocationAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAtTime_CoordinateSpace_Offset), 0, GetLocationAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocationAtTime_bUseConstantVelocity_Offset), 0, GetLocationAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAtTime_FunctionAddress, intPtr, GetLocationAtTime_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocationAtTime_ReturnValue_Offset), 0, GetLocationAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetLocationAtSplinePoint")]
	public unsafe FVector GetLocationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLocationAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetLocationAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplinePoint_PointIndex_Offset), 0, GetLocationAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplinePoint_CoordinateSpace_Offset), 0, GetLocationAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAtSplinePoint_FunctionAddress, intPtr, GetLocationAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocationAtSplinePoint_ReturnValue_Offset), 0, GetLocationAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetLocationAtSplineInputKey")]
	public unsafe FVector GetLocationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLocationAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetLocationAtSplineInputKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplineInputKey_InKey_Offset), 0, GetLocationAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplineInputKey_CoordinateSpace_Offset), 0, GetLocationAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAtSplineInputKey_FunctionAddress, intPtr, GetLocationAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocationAtSplineInputKey_ReturnValue_Offset), 0, GetLocationAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetLocationAtDistanceAlongSpline")]
	public unsafe FVector GetLocationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLocationAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetLocationAtDistanceAlongSpline");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLocationAtDistanceAlongSpline_Distance_Offset), 0, GetLocationAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetLocationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAtDistanceAlongSpline_FunctionAddress, intPtr, GetLocationAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocationAtDistanceAlongSpline_ReturnValue_Offset), 0, GetLocationAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetLocationAndTangentAtSplinePoint")]
	public unsafe void GetLocationAndTangentAtSplinePoint(int PointIndex, out FVector Location, out FVector Tangent, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLocationAndTangentAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetLocationAndTangentAtSplinePoint");
			Location = default(FVector);
			Tangent = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAndTangentAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAndTangentAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLocationAndTangentAtSplinePoint_PointIndex_Offset), 0, GetLocationAndTangentAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAndTangentAtSplinePoint_CoordinateSpace_Offset), 0, GetLocationAndTangentAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAndTangentAtSplinePoint_FunctionAddress, intPtr, GetLocationAndTangentAtSplinePoint_ParamsSize);
		Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocationAndTangentAtSplinePoint_Location_Offset), 0, GetLocationAndTangentAtSplinePoint_Location_PropertyAddress.Address);
		Tangent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocationAndTangentAtSplinePoint_Tangent_Offset), 0, GetLocationAndTangentAtSplinePoint_Tangent_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetLeaveTangentAtSplinePoint")]
	public unsafe FVector GetLeaveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLeaveTangentAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetLeaveTangentAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLeaveTangentAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLeaveTangentAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLeaveTangentAtSplinePoint_PointIndex_Offset), 0, GetLeaveTangentAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLeaveTangentAtSplinePoint_CoordinateSpace_Offset), 0, GetLeaveTangentAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLeaveTangentAtSplinePoint_FunctionAddress, intPtr, GetLeaveTangentAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLeaveTangentAtSplinePoint_ReturnValue_Offset), 0, GetLeaveTangentAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetInputKeyAtDistanceAlongSpline")]
	public unsafe float GetInputKeyAtDistanceAlongSpline(float Distance)
	{
		CheckDestroyed();
		if (!GetInputKeyAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetInputKeyAtDistanceAlongSpline");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputKeyAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputKeyAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetInputKeyAtDistanceAlongSpline_Distance_Offset), 0, GetInputKeyAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputKeyAtDistanceAlongSpline_FunctionAddress, intPtr, GetInputKeyAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputKeyAtDistanceAlongSpline_ReturnValue_Offset), 0, GetInputKeyAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetFloatPropertyAtSplinePoint")]
	public unsafe float GetFloatPropertyAtSplinePoint(int Index, FName PropertyName)
	{
		CheckDestroyed();
		if (!GetFloatPropertyAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetFloatPropertyAtSplinePoint");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatPropertyAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatPropertyAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetFloatPropertyAtSplinePoint_Index_Offset), 0, GetFloatPropertyAtSplinePoint_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloatPropertyAtSplinePoint_PropertyName_Offset), 0, GetFloatPropertyAtSplinePoint_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFloatPropertyAtSplinePoint_FunctionAddress, intPtr, GetFloatPropertyAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatPropertyAtSplinePoint_ReturnValue_Offset), 0, GetFloatPropertyAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetFloatPropertyAtSplineInputKey")]
	public unsafe float GetFloatPropertyAtSplineInputKey(float InKey, FName PropertyName)
	{
		CheckDestroyed();
		if (!GetFloatPropertyAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetFloatPropertyAtSplineInputKey");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatPropertyAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatPropertyAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetFloatPropertyAtSplineInputKey_InKey_Offset), 0, GetFloatPropertyAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloatPropertyAtSplineInputKey_PropertyName_Offset), 0, GetFloatPropertyAtSplineInputKey_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFloatPropertyAtSplineInputKey_FunctionAddress, intPtr, GetFloatPropertyAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatPropertyAtSplineInputKey_ReturnValue_Offset), 0, GetFloatPropertyAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetDistanceAlongSplineAtSplinePoint")]
	public unsafe float GetDistanceAlongSplineAtSplinePoint(int PointIndex)
	{
		CheckDestroyed();
		if (!GetDistanceAlongSplineAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetDistanceAlongSplineAtSplinePoint");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDistanceAlongSplineAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDistanceAlongSplineAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetDistanceAlongSplineAtSplinePoint_PointIndex_Offset), 0, GetDistanceAlongSplineAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDistanceAlongSplineAtSplinePoint_FunctionAddress, intPtr, GetDistanceAlongSplineAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDistanceAlongSplineAtSplinePoint_ReturnValue_Offset), 0, GetDistanceAlongSplineAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetDistanceAlongSplineAtSplineInputKey")]
	public unsafe float GetDistanceAlongSplineAtSplineInputKey(float InKey)
	{
		CheckDestroyed();
		if (!GetDistanceAlongSplineAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetDistanceAlongSplineAtSplineInputKey");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDistanceAlongSplineAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDistanceAlongSplineAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDistanceAlongSplineAtSplineInputKey_InKey_Offset), 0, GetDistanceAlongSplineAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, intPtr, GetDistanceAlongSplineAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDistanceAlongSplineAtSplineInputKey_ReturnValue_Offset), 0, GetDistanceAlongSplineAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetDirectionAtTime")]
	public unsafe FVector GetDirectionAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
	{
		CheckDestroyed();
		if (!GetDirectionAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetDirectionAtTime");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectionAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectionAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDirectionAtTime_Time_Offset), 0, GetDirectionAtTime_Time_PropertyAddress.Address, Time);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDirectionAtTime_CoordinateSpace_Offset), 0, GetDirectionAtTime_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetDirectionAtTime_bUseConstantVelocity_Offset), 0, GetDirectionAtTime_bUseConstantVelocity_PropertyAddress.Address, bUseConstantVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDirectionAtTime_FunctionAddress, intPtr, GetDirectionAtTime_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetDirectionAtTime_ReturnValue_Offset), 0, GetDirectionAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetDirectionAtSplinePoint")]
	public unsafe FVector GetDirectionAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetDirectionAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetDirectionAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectionAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectionAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplinePoint_PointIndex_Offset), 0, GetDirectionAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplinePoint_CoordinateSpace_Offset), 0, GetDirectionAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDirectionAtSplinePoint_FunctionAddress, intPtr, GetDirectionAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetDirectionAtSplinePoint_ReturnValue_Offset), 0, GetDirectionAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetDirectionAtSplineInputKey")]
	public unsafe FVector GetDirectionAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetDirectionAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetDirectionAtSplineInputKey");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectionAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectionAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplineInputKey_InKey_Offset), 0, GetDirectionAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplineInputKey_CoordinateSpace_Offset), 0, GetDirectionAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDirectionAtSplineInputKey_FunctionAddress, intPtr, GetDirectionAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetDirectionAtSplineInputKey_ReturnValue_Offset), 0, GetDirectionAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetDirectionAtDistanceAlongSpline")]
	public unsafe FVector GetDirectionAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetDirectionAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetDirectionAtDistanceAlongSpline");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectionAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectionAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDirectionAtDistanceAlongSpline_Distance_Offset), 0, GetDirectionAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDirectionAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetDirectionAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDirectionAtDistanceAlongSpline_FunctionAddress, intPtr, GetDirectionAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetDirectionAtDistanceAlongSpline_ReturnValue_Offset), 0, GetDirectionAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetDefaultUpVector")]
	public unsafe FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetDefaultUpVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetDefaultUpVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultUpVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultUpVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDefaultUpVector_CoordinateSpace_Offset), 0, GetDefaultUpVector_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultUpVector_FunctionAddress, intPtr, GetDefaultUpVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetDefaultUpVector_ReturnValue_Offset), 0, GetDefaultUpVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineComponent:GetArriveTangentAtSplinePoint")]
	public unsafe FVector GetArriveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetArriveTangentAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:GetArriveTangentAtSplinePoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetArriveTangentAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetArriveTangentAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetArriveTangentAtSplinePoint_PointIndex_Offset), 0, GetArriveTangentAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetArriveTangentAtSplinePoint_CoordinateSpace_Offset), 0, GetArriveTangentAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetArriveTangentAtSplinePoint_FunctionAddress, intPtr, GetArriveTangentAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetArriveTangentAtSplinePoint_ReturnValue_Offset), 0, GetArriveTangentAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindUpVectorClosestToWorldLocation")]
	public unsafe FVector FindUpVectorClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!FindUpVectorClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindUpVectorClosestToWorldLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindUpVectorClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindUpVectorClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindUpVectorClosestToWorldLocation_WorldLocation_Offset), 0, FindUpVectorClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindUpVectorClosestToWorldLocation_CoordinateSpace_Offset), 0, FindUpVectorClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindUpVectorClosestToWorldLocation_FunctionAddress, intPtr, FindUpVectorClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindUpVectorClosestToWorldLocation_ReturnValue_Offset), 0, FindUpVectorClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindTransformClosestToWorldLocation")]
	public unsafe FTransform FindTransformClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
	{
		CheckDestroyed();
		if (!FindTransformClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindTransformClosestToWorldLocation");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindTransformClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindTransformClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindTransformClosestToWorldLocation_WorldLocation_Offset), 0, FindTransformClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindTransformClosestToWorldLocation_CoordinateSpace_Offset), 0, FindTransformClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindTransformClosestToWorldLocation_bUseScale_Offset), 0, FindTransformClosestToWorldLocation_bUseScale_PropertyAddress.Address, bUseScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindTransformClosestToWorldLocation_FunctionAddress, intPtr, FindTransformClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, FindTransformClosestToWorldLocation_ReturnValue_Offset), 0, FindTransformClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindTangentClosestToWorldLocation")]
	public unsafe FVector FindTangentClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!FindTangentClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindTangentClosestToWorldLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindTangentClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindTangentClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindTangentClosestToWorldLocation_WorldLocation_Offset), 0, FindTangentClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindTangentClosestToWorldLocation_CoordinateSpace_Offset), 0, FindTangentClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindTangentClosestToWorldLocation_FunctionAddress, intPtr, FindTangentClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindTangentClosestToWorldLocation_ReturnValue_Offset), 0, FindTangentClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindScaleClosestToWorldLocation")]
	public unsafe FVector FindScaleClosestToWorldLocation(FVector WorldLocation)
	{
		CheckDestroyed();
		if (!FindScaleClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindScaleClosestToWorldLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindScaleClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindScaleClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindScaleClosestToWorldLocation_WorldLocation_Offset), 0, FindScaleClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindScaleClosestToWorldLocation_FunctionAddress, intPtr, FindScaleClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindScaleClosestToWorldLocation_ReturnValue_Offset), 0, FindScaleClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindRotationClosestToWorldLocation")]
	public unsafe FRotator FindRotationClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!FindRotationClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindRotationClosestToWorldLocation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindRotationClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindRotationClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindRotationClosestToWorldLocation_WorldLocation_Offset), 0, FindRotationClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindRotationClosestToWorldLocation_CoordinateSpace_Offset), 0, FindRotationClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindRotationClosestToWorldLocation_FunctionAddress, intPtr, FindRotationClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, FindRotationClosestToWorldLocation_ReturnValue_Offset), 0, FindRotationClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindRollClosestToWorldLocation")]
	public unsafe float FindRollClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!FindRollClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindRollClosestToWorldLocation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindRollClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindRollClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindRollClosestToWorldLocation_WorldLocation_Offset), 0, FindRollClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindRollClosestToWorldLocation_CoordinateSpace_Offset), 0, FindRollClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindRollClosestToWorldLocation_FunctionAddress, intPtr, FindRollClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, FindRollClosestToWorldLocation_ReturnValue_Offset), 0, FindRollClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindRightVectorClosestToWorldLocation")]
	public unsafe FVector FindRightVectorClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!FindRightVectorClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindRightVectorClosestToWorldLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindRightVectorClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindRightVectorClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindRightVectorClosestToWorldLocation_WorldLocation_Offset), 0, FindRightVectorClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindRightVectorClosestToWorldLocation_CoordinateSpace_Offset), 0, FindRightVectorClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindRightVectorClosestToWorldLocation_FunctionAddress, intPtr, FindRightVectorClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindRightVectorClosestToWorldLocation_ReturnValue_Offset), 0, FindRightVectorClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindLocationClosestToWorldLocation")]
	public unsafe FVector FindLocationClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!FindLocationClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindLocationClosestToWorldLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindLocationClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindLocationClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindLocationClosestToWorldLocation_WorldLocation_Offset), 0, FindLocationClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindLocationClosestToWorldLocation_CoordinateSpace_Offset), 0, FindLocationClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindLocationClosestToWorldLocation_FunctionAddress, intPtr, FindLocationClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindLocationClosestToWorldLocation_ReturnValue_Offset), 0, FindLocationClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindInputKeyClosestToWorldLocation")]
	public unsafe float FindInputKeyClosestToWorldLocation(FVector WorldLocation)
	{
		CheckDestroyed();
		if (!FindInputKeyClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindInputKeyClosestToWorldLocation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindInputKeyClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindInputKeyClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindInputKeyClosestToWorldLocation_WorldLocation_Offset), 0, FindInputKeyClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindInputKeyClosestToWorldLocation_FunctionAddress, intPtr, FindInputKeyClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, FindInputKeyClosestToWorldLocation_ReturnValue_Offset), 0, FindInputKeyClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SplineComponent:FindDirectionClosestToWorldLocation")]
	public unsafe FVector FindDirectionClosestToWorldLocation(FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!FindDirectionClosestToWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:FindDirectionClosestToWorldLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindDirectionClosestToWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindDirectionClosestToWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindDirectionClosestToWorldLocation_WorldLocation_Offset), 0, FindDirectionClosestToWorldLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, FindDirectionClosestToWorldLocation_CoordinateSpace_Offset), 0, FindDirectionClosestToWorldLocation_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindDirectionClosestToWorldLocation_FunctionAddress, intPtr, FindDirectionClosestToWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindDirectionClosestToWorldLocation_ReturnValue_Offset), 0, FindDirectionClosestToWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.SplineComponent:DivideSplineIntoPolylineRecursive")]
	public unsafe bool DivideSplineIntoPolylineRecursive(float StartDistanceAlongSpline, float EndDistanceAlongSpline, ESplineCoordinateSpace CoordinateSpace, float MaxSquareDistanceFromSpline, out List<FVector> OutPoints)
	{
		CheckDestroyed();
		if (!DivideSplineIntoPolylineRecursive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:DivideSplineIntoPolylineRecursive");
			OutPoints = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DivideSplineIntoPolylineRecursive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DivideSplineIntoPolylineRecursive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_Offset), 0, DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_PropertyAddress.Address, StartDistanceAlongSpline);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_Offset), 0, DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_PropertyAddress.Address, EndDistanceAlongSpline);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, DivideSplineIntoPolylineRecursive_CoordinateSpace_Offset), 0, DivideSplineIntoPolylineRecursive_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_Offset), 0, DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_PropertyAddress.Address, MaxSquareDistanceFromSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, DivideSplineIntoPolylineRecursive_FunctionAddress, intPtr, DivideSplineIntoPolylineRecursive_ParamsSize);
		OutPoints = new TArrayCopyMarshaler<FVector>(1, DivideSplineIntoPolylineRecursive_OutPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, DivideSplineIntoPolylineRecursive_OutPoints_Offset));
		NativeReflection.DestroyValue_InContainer(DivideSplineIntoPolylineRecursive_OutPoints_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DivideSplineIntoPolylineRecursive_ReturnValue_Offset), 0, DivideSplineIntoPolylineRecursive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.SplineComponent:ConvertSplineToPolyLine")]
	public unsafe bool ConvertSplineToPolyLine(ESplineCoordinateSpace CoordinateSpace, float MaxSquareDistanceFromSpline, out List<FVector> OutPoints)
	{
		CheckDestroyed();
		if (!ConvertSplineToPolyLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:ConvertSplineToPolyLine");
			OutPoints = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertSplineToPolyLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertSplineToPolyLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, ConvertSplineToPolyLine_CoordinateSpace_Offset), 0, ConvertSplineToPolyLine_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_Offset), 0, ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_PropertyAddress.Address, MaxSquareDistanceFromSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConvertSplineToPolyLine_FunctionAddress, intPtr, ConvertSplineToPolyLine_ParamsSize);
		OutPoints = new TArrayCopyMarshaler<FVector>(1, ConvertSplineToPolyLine_OutPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertSplineToPolyLine_OutPoints_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertSplineToPolyLine_OutPoints_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConvertSplineToPolyLine_ReturnValue_Offset), 0, ConvertSplineToPolyLine_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.SplineComponent:ConvertSplineSegmentToPolyLine")]
	public unsafe bool ConvertSplineSegmentToPolyLine(int SplinePointStartIndex, ESplineCoordinateSpace CoordinateSpace, float MaxSquareDistanceFromSpline, out List<FVector> OutPoints)
	{
		CheckDestroyed();
		if (!ConvertSplineSegmentToPolyLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:ConvertSplineSegmentToPolyLine");
			OutPoints = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertSplineSegmentToPolyLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertSplineSegmentToPolyLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertSplineSegmentToPolyLine_SplinePointStartIndex_Offset), 0, ConvertSplineSegmentToPolyLine_SplinePointStartIndex_PropertyAddress.Address, SplinePointStartIndex);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, ConvertSplineSegmentToPolyLine_CoordinateSpace_Offset), 0, ConvertSplineSegmentToPolyLine_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_Offset), 0, ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_PropertyAddress.Address, MaxSquareDistanceFromSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConvertSplineSegmentToPolyLine_FunctionAddress, intPtr, ConvertSplineSegmentToPolyLine_ParamsSize);
		OutPoints = new TArrayCopyMarshaler<FVector>(1, ConvertSplineSegmentToPolyLine_OutPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertSplineSegmentToPolyLine_OutPoints_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertSplineSegmentToPolyLine_OutPoints_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConvertSplineSegmentToPolyLine_ReturnValue_Offset), 0, ConvertSplineSegmentToPolyLine_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineComponent:ClearSplinePoints")]
	public unsafe void ClearSplinePoints(bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!ClearSplinePoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:ClearSplinePoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSplinePoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSplinePoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClearSplinePoints_bUpdateSpline_Offset), 0, ClearSplinePoints_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearSplinePoints_FunctionAddress, intPtr, ClearSplinePoints_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:AddSplinePointAtIndex")]
	public unsafe void AddSplinePointAtIndex(FVector Position, int Index, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!AddSplinePointAtIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:AddSplinePointAtIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSplinePointAtIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSplinePointAtIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddSplinePointAtIndex_Position_Offset), 0, AddSplinePointAtIndex_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddSplinePointAtIndex_Index_Offset), 0, AddSplinePointAtIndex_Index_PropertyAddress.Address, Index);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, AddSplinePointAtIndex_CoordinateSpace_Offset), 0, AddSplinePointAtIndex_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSplinePointAtIndex_bUpdateSpline_Offset), 0, AddSplinePointAtIndex_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSplinePointAtIndex_FunctionAddress, intPtr, AddSplinePointAtIndex_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineComponent:AddSplinePoint")]
	public unsafe void AddSplinePoint(FVector Position, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!AddSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:AddSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddSplinePoint_Position_Offset), 0, AddSplinePoint_Position_PropertyAddress.Address, Position);
		EnumMarshaler<ESplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, AddSplinePoint_CoordinateSpace_Offset), 0, AddSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSplinePoint_bUpdateSpline_Offset), 0, AddSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSplinePoint_FunctionAddress, intPtr, AddSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SplineComponent:AddPoints")]
	public unsafe void AddPoints(List<FSplinePoint> Points, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!AddPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:AddPoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSplinePoint>(1, AddPoints_Points_PropertyAddress, CachedMarshalingDelegates<FSplinePoint, FSplinePoint>.FromNative, CachedMarshalingDelegates<FSplinePoint, FSplinePoint>.ToNative).ToNative(IntPtr.Add(intPtr, AddPoints_Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddPoints_bUpdateSpline_Offset), 0, AddPoints_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddPoints_FunctionAddress, intPtr, AddPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddPoints_Points_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SplineComponent:AddPoint")]
	public unsafe void AddPoint(FSplinePoint Point, bool bUpdateSpline = true)
	{
		CheckDestroyed();
		if (!AddPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineComponent:AddPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddPoint_Point_PropertyAddress.Address, intPtr);
		FSplinePoint.ToNative(IntPtr.Add(intPtr, AddPoint_Point_Offset), 0, AddPoint_Point_PropertyAddress.Address, Point);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddPoint_bUpdateSpline_Offset), 0, AddPoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddPoint_FunctionAddress, intPtr, AddPoint_ParamsSize);
	}

	static USplineComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USplineComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USplineComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SplineComponent");
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StationaryEndpoints_PropertyAddress, intPtr, "bStationaryEndpoints");
		StationaryEndpoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStationaryEndpoints");
		StationaryEndpoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStationaryEndpoints", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InputSplinePointsToConstructionScript_PropertyAddress, intPtr, "bInputSplinePointsToConstructionScript");
		InputSplinePointsToConstructionScript_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInputSplinePointsToConstructionScript");
		InputSplinePointsToConstructionScript_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInputSplinePointsToConstructionScript", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebug_PropertyAddress, intPtr, "bDrawDebug");
		DrawDebug_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawDebug");
		DrawDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawDebug", Classes.FBoolProperty);
		DefaultUpVector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultUpVector");
		DefaultUpVector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultUpVector", Classes.FStructProperty);
		UpdateSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSpline");
		UpdateSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSpline_FunctionAddress);
		UpdateSpline_IsValid = UpdateSpline_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:UpdateSpline", UpdateSpline_IsValid);
		SetUpVectorAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUpVectorAtSplinePoint");
		SetUpVectorAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUpVectorAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUpVectorAtSplinePoint_PointIndex_PropertyAddress, SetUpVectorAtSplinePoint_FunctionAddress, "PointIndex");
		SetUpVectorAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetUpVectorAtSplinePoint_FunctionAddress, "PointIndex");
		SetUpVectorAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUpVectorAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUpVectorAtSplinePoint_InUpVector_PropertyAddress, SetUpVectorAtSplinePoint_FunctionAddress, "InUpVector");
		SetUpVectorAtSplinePoint_InUpVector_Offset = NativeReflectionCached.GetPropertyOffset(SetUpVectorAtSplinePoint_FunctionAddress, "InUpVector");
		SetUpVectorAtSplinePoint_InUpVector_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUpVectorAtSplinePoint_FunctionAddress, "InUpVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUpVectorAtSplinePoint_CoordinateSpace_PropertyAddress, SetUpVectorAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetUpVectorAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetUpVectorAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetUpVectorAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUpVectorAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUpVectorAtSplinePoint_bUpdateSpline_PropertyAddress, SetUpVectorAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetUpVectorAtSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetUpVectorAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetUpVectorAtSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUpVectorAtSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetUpVectorAtSplinePoint_IsValid = SetUpVectorAtSplinePoint_FunctionAddress != IntPtr.Zero && SetUpVectorAtSplinePoint_PointIndex_IsValid && SetUpVectorAtSplinePoint_InUpVector_IsValid && SetUpVectorAtSplinePoint_CoordinateSpace_IsValid && SetUpVectorAtSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetUpVectorAtSplinePoint", SetUpVectorAtSplinePoint_IsValid);
		SetUnselectedSplineSegmentColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUnselectedSplineSegmentColor");
		SetUnselectedSplineSegmentColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUnselectedSplineSegmentColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUnselectedSplineSegmentColor_SegmentColor_PropertyAddress, SetUnselectedSplineSegmentColor_FunctionAddress, "SegmentColor");
		SetUnselectedSplineSegmentColor_SegmentColor_Offset = NativeReflectionCached.GetPropertyOffset(SetUnselectedSplineSegmentColor_FunctionAddress, "SegmentColor");
		SetUnselectedSplineSegmentColor_SegmentColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUnselectedSplineSegmentColor_FunctionAddress, "SegmentColor", Classes.FStructProperty);
		SetUnselectedSplineSegmentColor_IsValid = SetUnselectedSplineSegmentColor_FunctionAddress != IntPtr.Zero && SetUnselectedSplineSegmentColor_SegmentColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetUnselectedSplineSegmentColor", SetUnselectedSplineSegmentColor_IsValid);
		SetTangentsAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTangentsAtSplinePoint");
		SetTangentsAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTangentsAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTangentsAtSplinePoint_PointIndex_PropertyAddress, SetTangentsAtSplinePoint_FunctionAddress, "PointIndex");
		SetTangentsAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentsAtSplinePoint_FunctionAddress, "PointIndex");
		SetTangentsAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentsAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTangentsAtSplinePoint_InArriveTangent_PropertyAddress, SetTangentsAtSplinePoint_FunctionAddress, "InArriveTangent");
		SetTangentsAtSplinePoint_InArriveTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentsAtSplinePoint_FunctionAddress, "InArriveTangent");
		SetTangentsAtSplinePoint_InArriveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentsAtSplinePoint_FunctionAddress, "InArriveTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTangentsAtSplinePoint_InLeaveTangent_PropertyAddress, SetTangentsAtSplinePoint_FunctionAddress, "InLeaveTangent");
		SetTangentsAtSplinePoint_InLeaveTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentsAtSplinePoint_FunctionAddress, "InLeaveTangent");
		SetTangentsAtSplinePoint_InLeaveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentsAtSplinePoint_FunctionAddress, "InLeaveTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTangentsAtSplinePoint_CoordinateSpace_PropertyAddress, SetTangentsAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetTangentsAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentsAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetTangentsAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentsAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTangentsAtSplinePoint_bUpdateSpline_PropertyAddress, SetTangentsAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetTangentsAtSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentsAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetTangentsAtSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentsAtSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetTangentsAtSplinePoint_IsValid = SetTangentsAtSplinePoint_FunctionAddress != IntPtr.Zero && SetTangentsAtSplinePoint_PointIndex_IsValid && SetTangentsAtSplinePoint_InArriveTangent_IsValid && SetTangentsAtSplinePoint_InLeaveTangent_IsValid && SetTangentsAtSplinePoint_CoordinateSpace_IsValid && SetTangentsAtSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetTangentsAtSplinePoint", SetTangentsAtSplinePoint_IsValid);
		SetTangentColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTangentColor");
		SetTangentColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTangentColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTangentColor_TangentColor_PropertyAddress, SetTangentColor_FunctionAddress, "TangentColor");
		SetTangentColor_TangentColor_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentColor_FunctionAddress, "TangentColor");
		SetTangentColor_TangentColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentColor_FunctionAddress, "TangentColor", Classes.FStructProperty);
		SetTangentColor_IsValid = SetTangentColor_FunctionAddress != IntPtr.Zero && SetTangentColor_TangentColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetTangentColor", SetTangentColor_IsValid);
		SetTangentAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTangentAtSplinePoint");
		SetTangentAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTangentAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTangentAtSplinePoint_PointIndex_PropertyAddress, SetTangentAtSplinePoint_FunctionAddress, "PointIndex");
		SetTangentAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentAtSplinePoint_FunctionAddress, "PointIndex");
		SetTangentAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTangentAtSplinePoint_InTangent_PropertyAddress, SetTangentAtSplinePoint_FunctionAddress, "InTangent");
		SetTangentAtSplinePoint_InTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentAtSplinePoint_FunctionAddress, "InTangent");
		SetTangentAtSplinePoint_InTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentAtSplinePoint_FunctionAddress, "InTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTangentAtSplinePoint_CoordinateSpace_PropertyAddress, SetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetTangentAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetTangentAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTangentAtSplinePoint_bUpdateSpline_PropertyAddress, SetTangentAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetTangentAtSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetTangentAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetTangentAtSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTangentAtSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetTangentAtSplinePoint_IsValid = SetTangentAtSplinePoint_FunctionAddress != IntPtr.Zero && SetTangentAtSplinePoint_PointIndex_IsValid && SetTangentAtSplinePoint_InTangent_IsValid && SetTangentAtSplinePoint_CoordinateSpace_IsValid && SetTangentAtSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetTangentAtSplinePoint", SetTangentAtSplinePoint_IsValid);
		SetSplinePointType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSplinePointType");
		SetSplinePointType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplinePointType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplinePointType_PointIndex_PropertyAddress, SetSplinePointType_FunctionAddress, "PointIndex");
		SetSplinePointType_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetSplinePointType_FunctionAddress, "PointIndex");
		SetSplinePointType_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplinePointType_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSplinePointType_Type_PropertyAddress, SetSplinePointType_FunctionAddress, "Type");
		SetSplinePointType_Type_Offset = NativeReflectionCached.GetPropertyOffset(SetSplinePointType_FunctionAddress, "Type");
		SetSplinePointType_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplinePointType_FunctionAddress, "Type", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSplinePointType_bUpdateSpline_PropertyAddress, SetSplinePointType_FunctionAddress, "bUpdateSpline");
		SetSplinePointType_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetSplinePointType_FunctionAddress, "bUpdateSpline");
		SetSplinePointType_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplinePointType_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetSplinePointType_IsValid = SetSplinePointType_FunctionAddress != IntPtr.Zero && SetSplinePointType_PointIndex_IsValid && SetSplinePointType_Type_IsValid && SetSplinePointType_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetSplinePointType", SetSplinePointType_IsValid);
		SetSplinePoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSplinePoints");
		SetSplinePoints_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplinePoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplinePoints_Points_PropertyAddress, SetSplinePoints_FunctionAddress, "Points");
		SetSplinePoints_Points_Offset = NativeReflectionCached.GetPropertyOffset(SetSplinePoints_FunctionAddress, "Points");
		SetSplinePoints_Points_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplinePoints_FunctionAddress, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSplinePoints_CoordinateSpace_PropertyAddress, SetSplinePoints_FunctionAddress, "CoordinateSpace");
		SetSplinePoints_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetSplinePoints_FunctionAddress, "CoordinateSpace");
		SetSplinePoints_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplinePoints_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSplinePoints_bUpdateSpline_PropertyAddress, SetSplinePoints_FunctionAddress, "bUpdateSpline");
		SetSplinePoints_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetSplinePoints_FunctionAddress, "bUpdateSpline");
		SetSplinePoints_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplinePoints_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetSplinePoints_IsValid = SetSplinePoints_FunctionAddress != IntPtr.Zero && SetSplinePoints_Points_IsValid && SetSplinePoints_CoordinateSpace_IsValid && SetSplinePoints_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetSplinePoints", SetSplinePoints_IsValid);
		SetSelectedSplineSegmentColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSelectedSplineSegmentColor");
		SetSelectedSplineSegmentColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSelectedSplineSegmentColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSelectedSplineSegmentColor_SegmentColor_PropertyAddress, SetSelectedSplineSegmentColor_FunctionAddress, "SegmentColor");
		SetSelectedSplineSegmentColor_SegmentColor_Offset = NativeReflectionCached.GetPropertyOffset(SetSelectedSplineSegmentColor_FunctionAddress, "SegmentColor");
		SetSelectedSplineSegmentColor_SegmentColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSelectedSplineSegmentColor_FunctionAddress, "SegmentColor", Classes.FStructProperty);
		SetSelectedSplineSegmentColor_IsValid = SetSelectedSplineSegmentColor_FunctionAddress != IntPtr.Zero && SetSelectedSplineSegmentColor_SegmentColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetSelectedSplineSegmentColor", SetSelectedSplineSegmentColor_IsValid);
		SetScaleAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScaleAtSplinePoint");
		SetScaleAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScaleAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScaleAtSplinePoint_PointIndex_PropertyAddress, SetScaleAtSplinePoint_FunctionAddress, "PointIndex");
		SetScaleAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetScaleAtSplinePoint_FunctionAddress, "PointIndex");
		SetScaleAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScaleAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScaleAtSplinePoint_InScaleVector_PropertyAddress, SetScaleAtSplinePoint_FunctionAddress, "InScaleVector");
		SetScaleAtSplinePoint_InScaleVector_Offset = NativeReflectionCached.GetPropertyOffset(SetScaleAtSplinePoint_FunctionAddress, "InScaleVector");
		SetScaleAtSplinePoint_InScaleVector_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScaleAtSplinePoint_FunctionAddress, "InScaleVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScaleAtSplinePoint_bUpdateSpline_PropertyAddress, SetScaleAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetScaleAtSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetScaleAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetScaleAtSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScaleAtSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetScaleAtSplinePoint_IsValid = SetScaleAtSplinePoint_FunctionAddress != IntPtr.Zero && SetScaleAtSplinePoint_PointIndex_IsValid && SetScaleAtSplinePoint_InScaleVector_IsValid && SetScaleAtSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetScaleAtSplinePoint", SetScaleAtSplinePoint_IsValid);
		SetRotationAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRotationAtSplinePoint");
		SetRotationAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRotationAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRotationAtSplinePoint_PointIndex_PropertyAddress, SetRotationAtSplinePoint_FunctionAddress, "PointIndex");
		SetRotationAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetRotationAtSplinePoint_FunctionAddress, "PointIndex");
		SetRotationAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotationAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotationAtSplinePoint_InRotation_PropertyAddress, SetRotationAtSplinePoint_FunctionAddress, "InRotation");
		SetRotationAtSplinePoint_InRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetRotationAtSplinePoint_FunctionAddress, "InRotation");
		SetRotationAtSplinePoint_InRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotationAtSplinePoint_FunctionAddress, "InRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotationAtSplinePoint_CoordinateSpace_PropertyAddress, SetRotationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetRotationAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetRotationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetRotationAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotationAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRotationAtSplinePoint_bUpdateSpline_PropertyAddress, SetRotationAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetRotationAtSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetRotationAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetRotationAtSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRotationAtSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetRotationAtSplinePoint_IsValid = SetRotationAtSplinePoint_FunctionAddress != IntPtr.Zero && SetRotationAtSplinePoint_PointIndex_IsValid && SetRotationAtSplinePoint_InRotation_IsValid && SetRotationAtSplinePoint_CoordinateSpace_IsValid && SetRotationAtSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetRotationAtSplinePoint", SetRotationAtSplinePoint_IsValid);
		SetLocationAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocationAtSplinePoint");
		SetLocationAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocationAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocationAtSplinePoint_PointIndex_PropertyAddress, SetLocationAtSplinePoint_FunctionAddress, "PointIndex");
		SetLocationAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLocationAtSplinePoint_FunctionAddress, "PointIndex");
		SetLocationAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocationAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocationAtSplinePoint_InLocation_PropertyAddress, SetLocationAtSplinePoint_FunctionAddress, "InLocation");
		SetLocationAtSplinePoint_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetLocationAtSplinePoint_FunctionAddress, "InLocation");
		SetLocationAtSplinePoint_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocationAtSplinePoint_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocationAtSplinePoint_CoordinateSpace_PropertyAddress, SetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetLocationAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		SetLocationAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocationAtSplinePoint_bUpdateSpline_PropertyAddress, SetLocationAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetLocationAtSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetLocationAtSplinePoint_FunctionAddress, "bUpdateSpline");
		SetLocationAtSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocationAtSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetLocationAtSplinePoint_IsValid = SetLocationAtSplinePoint_FunctionAddress != IntPtr.Zero && SetLocationAtSplinePoint_PointIndex_IsValid && SetLocationAtSplinePoint_InLocation_IsValid && SetLocationAtSplinePoint_CoordinateSpace_IsValid && SetLocationAtSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetLocationAtSplinePoint", SetLocationAtSplinePoint_IsValid);
		SetDrawDebug_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDrawDebug");
		SetDrawDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDrawDebug_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDrawDebug_bShow_PropertyAddress, SetDrawDebug_FunctionAddress, "bShow");
		SetDrawDebug_bShow_Offset = NativeReflectionCached.GetPropertyOffset(SetDrawDebug_FunctionAddress, "bShow");
		SetDrawDebug_bShow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDrawDebug_FunctionAddress, "bShow", Classes.FBoolProperty);
		SetDrawDebug_IsValid = SetDrawDebug_FunctionAddress != IntPtr.Zero && SetDrawDebug_bShow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetDrawDebug", SetDrawDebug_IsValid);
		SetDefaultUpVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultUpVector");
		SetDefaultUpVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultUpVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultUpVector_UpVector_PropertyAddress, SetDefaultUpVector_FunctionAddress, "UpVector");
		SetDefaultUpVector_UpVector_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultUpVector_FunctionAddress, "UpVector");
		SetDefaultUpVector_UpVector_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultUpVector_FunctionAddress, "UpVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultUpVector_CoordinateSpace_PropertyAddress, SetDefaultUpVector_FunctionAddress, "CoordinateSpace");
		SetDefaultUpVector_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultUpVector_FunctionAddress, "CoordinateSpace");
		SetDefaultUpVector_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultUpVector_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		SetDefaultUpVector_IsValid = SetDefaultUpVector_FunctionAddress != IntPtr.Zero && SetDefaultUpVector_UpVector_IsValid && SetDefaultUpVector_CoordinateSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetDefaultUpVector", SetDefaultUpVector_IsValid);
		SetClosedLoopAtPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetClosedLoopAtPosition");
		SetClosedLoopAtPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetClosedLoopAtPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetClosedLoopAtPosition_bInClosedLoop_PropertyAddress, SetClosedLoopAtPosition_FunctionAddress, "bInClosedLoop");
		SetClosedLoopAtPosition_bInClosedLoop_Offset = NativeReflectionCached.GetPropertyOffset(SetClosedLoopAtPosition_FunctionAddress, "bInClosedLoop");
		SetClosedLoopAtPosition_bInClosedLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClosedLoopAtPosition_FunctionAddress, "bInClosedLoop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetClosedLoopAtPosition_Key_PropertyAddress, SetClosedLoopAtPosition_FunctionAddress, "Key");
		SetClosedLoopAtPosition_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetClosedLoopAtPosition_FunctionAddress, "Key");
		SetClosedLoopAtPosition_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClosedLoopAtPosition_FunctionAddress, "Key", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetClosedLoopAtPosition_bUpdateSpline_PropertyAddress, SetClosedLoopAtPosition_FunctionAddress, "bUpdateSpline");
		SetClosedLoopAtPosition_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetClosedLoopAtPosition_FunctionAddress, "bUpdateSpline");
		SetClosedLoopAtPosition_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClosedLoopAtPosition_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetClosedLoopAtPosition_IsValid = SetClosedLoopAtPosition_FunctionAddress != IntPtr.Zero && SetClosedLoopAtPosition_bInClosedLoop_IsValid && SetClosedLoopAtPosition_Key_IsValid && SetClosedLoopAtPosition_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetClosedLoopAtPosition", SetClosedLoopAtPosition_IsValid);
		SetClosedLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetClosedLoop");
		SetClosedLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(SetClosedLoop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetClosedLoop_bInClosedLoop_PropertyAddress, SetClosedLoop_FunctionAddress, "bInClosedLoop");
		SetClosedLoop_bInClosedLoop_Offset = NativeReflectionCached.GetPropertyOffset(SetClosedLoop_FunctionAddress, "bInClosedLoop");
		SetClosedLoop_bInClosedLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClosedLoop_FunctionAddress, "bInClosedLoop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetClosedLoop_bUpdateSpline_PropertyAddress, SetClosedLoop_FunctionAddress, "bUpdateSpline");
		SetClosedLoop_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(SetClosedLoop_FunctionAddress, "bUpdateSpline");
		SetClosedLoop_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClosedLoop_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		SetClosedLoop_IsValid = SetClosedLoop_FunctionAddress != IntPtr.Zero && SetClosedLoop_bInClosedLoop_IsValid && SetClosedLoop_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:SetClosedLoop", SetClosedLoop_IsValid);
		RemoveSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveSplinePoint");
		RemoveSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSplinePoint_Index_PropertyAddress, RemoveSplinePoint_FunctionAddress, "Index");
		RemoveSplinePoint_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSplinePoint_FunctionAddress, "Index");
		RemoveSplinePoint_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSplinePoint_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSplinePoint_bUpdateSpline_PropertyAddress, RemoveSplinePoint_FunctionAddress, "bUpdateSpline");
		RemoveSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSplinePoint_FunctionAddress, "bUpdateSpline");
		RemoveSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		RemoveSplinePoint_IsValid = RemoveSplinePoint_FunctionAddress != IntPtr.Zero && RemoveSplinePoint_Index_IsValid && RemoveSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:RemoveSplinePoint", RemoveSplinePoint_IsValid);
		IsClosedLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsClosedLoop");
		IsClosedLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(IsClosedLoop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsClosedLoop_ReturnValue_PropertyAddress, IsClosedLoop_FunctionAddress, "ReturnValue");
		IsClosedLoop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsClosedLoop_FunctionAddress, "ReturnValue");
		IsClosedLoop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClosedLoop_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsClosedLoop_IsValid = IsClosedLoop_FunctionAddress != IntPtr.Zero && IsClosedLoop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:IsClosedLoop", IsClosedLoop_IsValid);
		GetVectorPropertyAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVectorPropertyAtSplinePoint");
		GetVectorPropertyAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorPropertyAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorPropertyAtSplinePoint_Index_PropertyAddress, GetVectorPropertyAtSplinePoint_FunctionAddress, "Index");
		GetVectorPropertyAtSplinePoint_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorPropertyAtSplinePoint_FunctionAddress, "Index");
		GetVectorPropertyAtSplinePoint_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorPropertyAtSplinePoint_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorPropertyAtSplinePoint_PropertyName_PropertyAddress, GetVectorPropertyAtSplinePoint_FunctionAddress, "PropertyName");
		GetVectorPropertyAtSplinePoint_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorPropertyAtSplinePoint_FunctionAddress, "PropertyName");
		GetVectorPropertyAtSplinePoint_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorPropertyAtSplinePoint_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorPropertyAtSplinePoint_ReturnValue_PropertyAddress, GetVectorPropertyAtSplinePoint_FunctionAddress, "ReturnValue");
		GetVectorPropertyAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorPropertyAtSplinePoint_FunctionAddress, "ReturnValue");
		GetVectorPropertyAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorPropertyAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorPropertyAtSplinePoint_IsValid = GetVectorPropertyAtSplinePoint_FunctionAddress != IntPtr.Zero && GetVectorPropertyAtSplinePoint_Index_IsValid && GetVectorPropertyAtSplinePoint_PropertyName_IsValid && GetVectorPropertyAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetVectorPropertyAtSplinePoint", GetVectorPropertyAtSplinePoint_IsValid);
		GetVectorPropertyAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVectorPropertyAtSplineInputKey");
		GetVectorPropertyAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorPropertyAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorPropertyAtSplineInputKey_InKey_PropertyAddress, GetVectorPropertyAtSplineInputKey_FunctionAddress, "InKey");
		GetVectorPropertyAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorPropertyAtSplineInputKey_FunctionAddress, "InKey");
		GetVectorPropertyAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorPropertyAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorPropertyAtSplineInputKey_PropertyName_PropertyAddress, GetVectorPropertyAtSplineInputKey_FunctionAddress, "PropertyName");
		GetVectorPropertyAtSplineInputKey_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorPropertyAtSplineInputKey_FunctionAddress, "PropertyName");
		GetVectorPropertyAtSplineInputKey_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorPropertyAtSplineInputKey_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorPropertyAtSplineInputKey_ReturnValue_PropertyAddress, GetVectorPropertyAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetVectorPropertyAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorPropertyAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetVectorPropertyAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorPropertyAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorPropertyAtSplineInputKey_IsValid = GetVectorPropertyAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetVectorPropertyAtSplineInputKey_InKey_IsValid && GetVectorPropertyAtSplineInputKey_PropertyName_IsValid && GetVectorPropertyAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetVectorPropertyAtSplineInputKey", GetVectorPropertyAtSplineInputKey_IsValid);
		GetUpVectorAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUpVectorAtTime");
		GetUpVectorAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUpVectorAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtTime_Time_PropertyAddress, GetUpVectorAtTime_FunctionAddress, "Time");
		GetUpVectorAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtTime_FunctionAddress, "Time");
		GetUpVectorAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtTime_CoordinateSpace_PropertyAddress, GetUpVectorAtTime_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtTime_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtTime_bUseConstantVelocity_PropertyAddress, GetUpVectorAtTime_FunctionAddress, "bUseConstantVelocity");
		GetUpVectorAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtTime_FunctionAddress, "bUseConstantVelocity");
		GetUpVectorAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtTime_ReturnValue_PropertyAddress, GetUpVectorAtTime_FunctionAddress, "ReturnValue");
		GetUpVectorAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtTime_FunctionAddress, "ReturnValue");
		GetUpVectorAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUpVectorAtTime_IsValid = GetUpVectorAtTime_FunctionAddress != IntPtr.Zero && GetUpVectorAtTime_Time_IsValid && GetUpVectorAtTime_CoordinateSpace_IsValid && GetUpVectorAtTime_bUseConstantVelocity_IsValid && GetUpVectorAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetUpVectorAtTime", GetUpVectorAtTime_IsValid);
		GetUpVectorAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUpVectorAtSplinePoint");
		GetUpVectorAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUpVectorAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtSplinePoint_PointIndex_PropertyAddress, GetUpVectorAtSplinePoint_FunctionAddress, "PointIndex");
		GetUpVectorAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtSplinePoint_FunctionAddress, "PointIndex");
		GetUpVectorAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtSplinePoint_CoordinateSpace_PropertyAddress, GetUpVectorAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtSplinePoint_ReturnValue_PropertyAddress, GetUpVectorAtSplinePoint_FunctionAddress, "ReturnValue");
		GetUpVectorAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtSplinePoint_FunctionAddress, "ReturnValue");
		GetUpVectorAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUpVectorAtSplinePoint_IsValid = GetUpVectorAtSplinePoint_FunctionAddress != IntPtr.Zero && GetUpVectorAtSplinePoint_PointIndex_IsValid && GetUpVectorAtSplinePoint_CoordinateSpace_IsValid && GetUpVectorAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetUpVectorAtSplinePoint", GetUpVectorAtSplinePoint_IsValid);
		GetUpVectorAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUpVectorAtSplineInputKey");
		GetUpVectorAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUpVectorAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtSplineInputKey_InKey_PropertyAddress, GetUpVectorAtSplineInputKey_FunctionAddress, "InKey");
		GetUpVectorAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtSplineInputKey_FunctionAddress, "InKey");
		GetUpVectorAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtSplineInputKey_CoordinateSpace_PropertyAddress, GetUpVectorAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtSplineInputKey_ReturnValue_PropertyAddress, GetUpVectorAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetUpVectorAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetUpVectorAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUpVectorAtSplineInputKey_IsValid = GetUpVectorAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetUpVectorAtSplineInputKey_InKey_IsValid && GetUpVectorAtSplineInputKey_CoordinateSpace_IsValid && GetUpVectorAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetUpVectorAtSplineInputKey", GetUpVectorAtSplineInputKey_IsValid);
		GetUpVectorAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUpVectorAtDistanceAlongSpline");
		GetUpVectorAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUpVectorAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtDistanceAlongSpline_Distance_PropertyAddress, GetUpVectorAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetUpVectorAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetUpVectorAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetUpVectorAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetUpVectorAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUpVectorAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetUpVectorAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetUpVectorAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVectorAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetUpVectorAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVectorAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUpVectorAtDistanceAlongSpline_IsValid = GetUpVectorAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetUpVectorAtDistanceAlongSpline_Distance_IsValid && GetUpVectorAtDistanceAlongSpline_CoordinateSpace_IsValid && GetUpVectorAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetUpVectorAtDistanceAlongSpline", GetUpVectorAtDistanceAlongSpline_IsValid);
		GetTransformAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTransformAtTime");
		GetTransformAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtTime_Time_PropertyAddress, GetTransformAtTime_FunctionAddress, "Time");
		GetTransformAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtTime_FunctionAddress, "Time");
		GetTransformAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtTime_CoordinateSpace_PropertyAddress, GetTransformAtTime_FunctionAddress, "CoordinateSpace");
		GetTransformAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtTime_FunctionAddress, "CoordinateSpace");
		GetTransformAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtTime_bUseConstantVelocity_PropertyAddress, GetTransformAtTime_FunctionAddress, "bUseConstantVelocity");
		GetTransformAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtTime_FunctionAddress, "bUseConstantVelocity");
		GetTransformAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtTime_bUseScale_PropertyAddress, GetTransformAtTime_FunctionAddress, "bUseScale");
		GetTransformAtTime_bUseScale_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtTime_FunctionAddress, "bUseScale");
		GetTransformAtTime_bUseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtTime_FunctionAddress, "bUseScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtTime_ReturnValue_PropertyAddress, GetTransformAtTime_FunctionAddress, "ReturnValue");
		GetTransformAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtTime_FunctionAddress, "ReturnValue");
		GetTransformAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformAtTime_IsValid = GetTransformAtTime_FunctionAddress != IntPtr.Zero && GetTransformAtTime_Time_IsValid && GetTransformAtTime_CoordinateSpace_IsValid && GetTransformAtTime_bUseConstantVelocity_IsValid && GetTransformAtTime_bUseScale_IsValid && GetTransformAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTransformAtTime", GetTransformAtTime_IsValid);
		GetTransformAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTransformAtSplinePoint");
		GetTransformAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplinePoint_PointIndex_PropertyAddress, GetTransformAtSplinePoint_FunctionAddress, "PointIndex");
		GetTransformAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplinePoint_FunctionAddress, "PointIndex");
		GetTransformAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplinePoint_CoordinateSpace_PropertyAddress, GetTransformAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetTransformAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetTransformAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplinePoint_bUseScale_PropertyAddress, GetTransformAtSplinePoint_FunctionAddress, "bUseScale");
		GetTransformAtSplinePoint_bUseScale_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplinePoint_FunctionAddress, "bUseScale");
		GetTransformAtSplinePoint_bUseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplinePoint_FunctionAddress, "bUseScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplinePoint_ReturnValue_PropertyAddress, GetTransformAtSplinePoint_FunctionAddress, "ReturnValue");
		GetTransformAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplinePoint_FunctionAddress, "ReturnValue");
		GetTransformAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformAtSplinePoint_IsValid = GetTransformAtSplinePoint_FunctionAddress != IntPtr.Zero && GetTransformAtSplinePoint_PointIndex_IsValid && GetTransformAtSplinePoint_CoordinateSpace_IsValid && GetTransformAtSplinePoint_bUseScale_IsValid && GetTransformAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTransformAtSplinePoint", GetTransformAtSplinePoint_IsValid);
		GetTransformAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTransformAtSplineInputKey");
		GetTransformAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplineInputKey_InKey_PropertyAddress, GetTransformAtSplineInputKey_FunctionAddress, "InKey");
		GetTransformAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplineInputKey_FunctionAddress, "InKey");
		GetTransformAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplineInputKey_CoordinateSpace_PropertyAddress, GetTransformAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetTransformAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetTransformAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplineInputKey_bUseScale_PropertyAddress, GetTransformAtSplineInputKey_FunctionAddress, "bUseScale");
		GetTransformAtSplineInputKey_bUseScale_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplineInputKey_FunctionAddress, "bUseScale");
		GetTransformAtSplineInputKey_bUseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplineInputKey_FunctionAddress, "bUseScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtSplineInputKey_ReturnValue_PropertyAddress, GetTransformAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetTransformAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetTransformAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformAtSplineInputKey_IsValid = GetTransformAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetTransformAtSplineInputKey_InKey_IsValid && GetTransformAtSplineInputKey_CoordinateSpace_IsValid && GetTransformAtSplineInputKey_bUseScale_IsValid && GetTransformAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTransformAtSplineInputKey", GetTransformAtSplineInputKey_IsValid);
		GetTransformAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTransformAtDistanceAlongSpline");
		GetTransformAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtDistanceAlongSpline_Distance_PropertyAddress, GetTransformAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetTransformAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetTransformAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetTransformAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetTransformAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetTransformAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtDistanceAlongSpline_bUseScale_PropertyAddress, GetTransformAtDistanceAlongSpline_FunctionAddress, "bUseScale");
		GetTransformAtDistanceAlongSpline_bUseScale_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtDistanceAlongSpline_FunctionAddress, "bUseScale");
		GetTransformAtDistanceAlongSpline_bUseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtDistanceAlongSpline_FunctionAddress, "bUseScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetTransformAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetTransformAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetTransformAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformAtDistanceAlongSpline_IsValid = GetTransformAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetTransformAtDistanceAlongSpline_Distance_IsValid && GetTransformAtDistanceAlongSpline_CoordinateSpace_IsValid && GetTransformAtDistanceAlongSpline_bUseScale_IsValid && GetTransformAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTransformAtDistanceAlongSpline", GetTransformAtDistanceAlongSpline_IsValid);
		GetTangentAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentAtTime");
		GetTangentAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtTime_Time_PropertyAddress, GetTangentAtTime_FunctionAddress, "Time");
		GetTangentAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtTime_FunctionAddress, "Time");
		GetTangentAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtTime_CoordinateSpace_PropertyAddress, GetTangentAtTime_FunctionAddress, "CoordinateSpace");
		GetTangentAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtTime_FunctionAddress, "CoordinateSpace");
		GetTangentAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtTime_bUseConstantVelocity_PropertyAddress, GetTangentAtTime_FunctionAddress, "bUseConstantVelocity");
		GetTangentAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtTime_FunctionAddress, "bUseConstantVelocity");
		GetTangentAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtTime_ReturnValue_PropertyAddress, GetTangentAtTime_FunctionAddress, "ReturnValue");
		GetTangentAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtTime_FunctionAddress, "ReturnValue");
		GetTangentAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTangentAtTime_IsValid = GetTangentAtTime_FunctionAddress != IntPtr.Zero && GetTangentAtTime_Time_IsValid && GetTangentAtTime_CoordinateSpace_IsValid && GetTangentAtTime_bUseConstantVelocity_IsValid && GetTangentAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTangentAtTime", GetTangentAtTime_IsValid);
		GetTangentAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentAtSplinePoint");
		GetTangentAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplinePoint_PointIndex_PropertyAddress, GetTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetTangentAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetTangentAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplinePoint_CoordinateSpace_PropertyAddress, GetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplinePoint_ReturnValue_PropertyAddress, GetTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetTangentAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetTangentAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTangentAtSplinePoint_IsValid = GetTangentAtSplinePoint_FunctionAddress != IntPtr.Zero && GetTangentAtSplinePoint_PointIndex_IsValid && GetTangentAtSplinePoint_CoordinateSpace_IsValid && GetTangentAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTangentAtSplinePoint", GetTangentAtSplinePoint_IsValid);
		GetTangentAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentAtSplineInputKey");
		GetTangentAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplineInputKey_InKey_PropertyAddress, GetTangentAtSplineInputKey_FunctionAddress, "InKey");
		GetTangentAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplineInputKey_FunctionAddress, "InKey");
		GetTangentAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplineInputKey_CoordinateSpace_PropertyAddress, GetTangentAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplineInputKey_ReturnValue_PropertyAddress, GetTangentAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetTangentAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetTangentAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTangentAtSplineInputKey_IsValid = GetTangentAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetTangentAtSplineInputKey_InKey_IsValid && GetTangentAtSplineInputKey_CoordinateSpace_IsValid && GetTangentAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTangentAtSplineInputKey", GetTangentAtSplineInputKey_IsValid);
		GetTangentAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentAtDistanceAlongSpline");
		GetTangentAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtDistanceAlongSpline_Distance_PropertyAddress, GetTangentAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetTangentAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetTangentAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetTangentAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetTangentAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetTangentAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetTangentAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetTangentAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetTangentAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTangentAtDistanceAlongSpline_IsValid = GetTangentAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetTangentAtDistanceAlongSpline_Distance_IsValid && GetTangentAtDistanceAlongSpline_CoordinateSpace_IsValid && GetTangentAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetTangentAtDistanceAlongSpline", GetTangentAtDistanceAlongSpline_IsValid);
		GetSplinePointType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSplinePointType");
		GetSplinePointType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplinePointType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplinePointType_PointIndex_PropertyAddress, GetSplinePointType_FunctionAddress, "PointIndex");
		GetSplinePointType_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSplinePointType_FunctionAddress, "PointIndex");
		GetSplinePointType_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplinePointType_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSplinePointType_ReturnValue_PropertyAddress, GetSplinePointType_FunctionAddress, "ReturnValue");
		GetSplinePointType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplinePointType_FunctionAddress, "ReturnValue");
		GetSplinePointType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplinePointType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetSplinePointType_IsValid = GetSplinePointType_FunctionAddress != IntPtr.Zero && GetSplinePointType_PointIndex_IsValid && GetSplinePointType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetSplinePointType", GetSplinePointType_IsValid);
		GetSplineLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSplineLength");
		GetSplineLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineLength_ReturnValue_PropertyAddress, GetSplineLength_FunctionAddress, "ReturnValue");
		GetSplineLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineLength_FunctionAddress, "ReturnValue");
		GetSplineLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSplineLength_IsValid = GetSplineLength_FunctionAddress != IntPtr.Zero && GetSplineLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetSplineLength", GetSplineLength_IsValid);
		GetScaleAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaleAtTime");
		GetScaleAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaleAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtTime_Time_PropertyAddress, GetScaleAtTime_FunctionAddress, "Time");
		GetScaleAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtTime_FunctionAddress, "Time");
		GetScaleAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtTime_bUseConstantVelocity_PropertyAddress, GetScaleAtTime_FunctionAddress, "bUseConstantVelocity");
		GetScaleAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtTime_FunctionAddress, "bUseConstantVelocity");
		GetScaleAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtTime_ReturnValue_PropertyAddress, GetScaleAtTime_FunctionAddress, "ReturnValue");
		GetScaleAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtTime_FunctionAddress, "ReturnValue");
		GetScaleAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetScaleAtTime_IsValid = GetScaleAtTime_FunctionAddress != IntPtr.Zero && GetScaleAtTime_Time_IsValid && GetScaleAtTime_bUseConstantVelocity_IsValid && GetScaleAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetScaleAtTime", GetScaleAtTime_IsValid);
		GetScaleAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaleAtSplinePoint");
		GetScaleAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaleAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtSplinePoint_PointIndex_PropertyAddress, GetScaleAtSplinePoint_FunctionAddress, "PointIndex");
		GetScaleAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtSplinePoint_FunctionAddress, "PointIndex");
		GetScaleAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtSplinePoint_ReturnValue_PropertyAddress, GetScaleAtSplinePoint_FunctionAddress, "ReturnValue");
		GetScaleAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtSplinePoint_FunctionAddress, "ReturnValue");
		GetScaleAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetScaleAtSplinePoint_IsValid = GetScaleAtSplinePoint_FunctionAddress != IntPtr.Zero && GetScaleAtSplinePoint_PointIndex_IsValid && GetScaleAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetScaleAtSplinePoint", GetScaleAtSplinePoint_IsValid);
		GetScaleAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaleAtSplineInputKey");
		GetScaleAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaleAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtSplineInputKey_InKey_PropertyAddress, GetScaleAtSplineInputKey_FunctionAddress, "InKey");
		GetScaleAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtSplineInputKey_FunctionAddress, "InKey");
		GetScaleAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtSplineInputKey_ReturnValue_PropertyAddress, GetScaleAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetScaleAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetScaleAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetScaleAtSplineInputKey_IsValid = GetScaleAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetScaleAtSplineInputKey_InKey_IsValid && GetScaleAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetScaleAtSplineInputKey", GetScaleAtSplineInputKey_IsValid);
		GetScaleAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetScaleAtDistanceAlongSpline");
		GetScaleAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScaleAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtDistanceAlongSpline_Distance_PropertyAddress, GetScaleAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetScaleAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetScaleAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScaleAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetScaleAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetScaleAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScaleAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetScaleAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScaleAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetScaleAtDistanceAlongSpline_IsValid = GetScaleAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetScaleAtDistanceAlongSpline_Distance_IsValid && GetScaleAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetScaleAtDistanceAlongSpline", GetScaleAtDistanceAlongSpline_IsValid);
		GetRotationAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRotationAtTime");
		GetRotationAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtTime_Time_PropertyAddress, GetRotationAtTime_FunctionAddress, "Time");
		GetRotationAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtTime_FunctionAddress, "Time");
		GetRotationAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtTime_CoordinateSpace_PropertyAddress, GetRotationAtTime_FunctionAddress, "CoordinateSpace");
		GetRotationAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtTime_FunctionAddress, "CoordinateSpace");
		GetRotationAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtTime_bUseConstantVelocity_PropertyAddress, GetRotationAtTime_FunctionAddress, "bUseConstantVelocity");
		GetRotationAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtTime_FunctionAddress, "bUseConstantVelocity");
		GetRotationAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtTime_ReturnValue_PropertyAddress, GetRotationAtTime_FunctionAddress, "ReturnValue");
		GetRotationAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtTime_FunctionAddress, "ReturnValue");
		GetRotationAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotationAtTime_IsValid = GetRotationAtTime_FunctionAddress != IntPtr.Zero && GetRotationAtTime_Time_IsValid && GetRotationAtTime_CoordinateSpace_IsValid && GetRotationAtTime_bUseConstantVelocity_IsValid && GetRotationAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRotationAtTime", GetRotationAtTime_IsValid);
		GetRotationAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRotationAtSplinePoint");
		GetRotationAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtSplinePoint_PointIndex_PropertyAddress, GetRotationAtSplinePoint_FunctionAddress, "PointIndex");
		GetRotationAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtSplinePoint_FunctionAddress, "PointIndex");
		GetRotationAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtSplinePoint_CoordinateSpace_PropertyAddress, GetRotationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetRotationAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetRotationAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtSplinePoint_ReturnValue_PropertyAddress, GetRotationAtSplinePoint_FunctionAddress, "ReturnValue");
		GetRotationAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtSplinePoint_FunctionAddress, "ReturnValue");
		GetRotationAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotationAtSplinePoint_IsValid = GetRotationAtSplinePoint_FunctionAddress != IntPtr.Zero && GetRotationAtSplinePoint_PointIndex_IsValid && GetRotationAtSplinePoint_CoordinateSpace_IsValid && GetRotationAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRotationAtSplinePoint", GetRotationAtSplinePoint_IsValid);
		GetRotationAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRotationAtSplineInputKey");
		GetRotationAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtSplineInputKey_InKey_PropertyAddress, GetRotationAtSplineInputKey_FunctionAddress, "InKey");
		GetRotationAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtSplineInputKey_FunctionAddress, "InKey");
		GetRotationAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtSplineInputKey_CoordinateSpace_PropertyAddress, GetRotationAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRotationAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRotationAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtSplineInputKey_ReturnValue_PropertyAddress, GetRotationAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRotationAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRotationAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotationAtSplineInputKey_IsValid = GetRotationAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetRotationAtSplineInputKey_InKey_IsValid && GetRotationAtSplineInputKey_CoordinateSpace_IsValid && GetRotationAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRotationAtSplineInputKey", GetRotationAtSplineInputKey_IsValid);
		GetRotationAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRotationAtDistanceAlongSpline");
		GetRotationAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtDistanceAlongSpline_Distance_PropertyAddress, GetRotationAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRotationAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRotationAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetRotationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRotationAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRotationAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetRotationAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRotationAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRotationAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotationAtDistanceAlongSpline_IsValid = GetRotationAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetRotationAtDistanceAlongSpline_Distance_IsValid && GetRotationAtDistanceAlongSpline_CoordinateSpace_IsValid && GetRotationAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRotationAtDistanceAlongSpline", GetRotationAtDistanceAlongSpline_IsValid);
		GetRollAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRollAtTime");
		GetRollAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRollAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtTime_Time_PropertyAddress, GetRollAtTime_FunctionAddress, "Time");
		GetRollAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtTime_FunctionAddress, "Time");
		GetRollAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtTime_CoordinateSpace_PropertyAddress, GetRollAtTime_FunctionAddress, "CoordinateSpace");
		GetRollAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtTime_FunctionAddress, "CoordinateSpace");
		GetRollAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtTime_bUseConstantVelocity_PropertyAddress, GetRollAtTime_FunctionAddress, "bUseConstantVelocity");
		GetRollAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtTime_FunctionAddress, "bUseConstantVelocity");
		GetRollAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtTime_ReturnValue_PropertyAddress, GetRollAtTime_FunctionAddress, "ReturnValue");
		GetRollAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtTime_FunctionAddress, "ReturnValue");
		GetRollAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRollAtTime_IsValid = GetRollAtTime_FunctionAddress != IntPtr.Zero && GetRollAtTime_Time_IsValid && GetRollAtTime_CoordinateSpace_IsValid && GetRollAtTime_bUseConstantVelocity_IsValid && GetRollAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRollAtTime", GetRollAtTime_IsValid);
		GetRollAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRollAtSplinePoint");
		GetRollAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRollAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtSplinePoint_PointIndex_PropertyAddress, GetRollAtSplinePoint_FunctionAddress, "PointIndex");
		GetRollAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtSplinePoint_FunctionAddress, "PointIndex");
		GetRollAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtSplinePoint_CoordinateSpace_PropertyAddress, GetRollAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetRollAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetRollAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtSplinePoint_ReturnValue_PropertyAddress, GetRollAtSplinePoint_FunctionAddress, "ReturnValue");
		GetRollAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtSplinePoint_FunctionAddress, "ReturnValue");
		GetRollAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRollAtSplinePoint_IsValid = GetRollAtSplinePoint_FunctionAddress != IntPtr.Zero && GetRollAtSplinePoint_PointIndex_IsValid && GetRollAtSplinePoint_CoordinateSpace_IsValid && GetRollAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRollAtSplinePoint", GetRollAtSplinePoint_IsValid);
		GetRollAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRollAtSplineInputKey");
		GetRollAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRollAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtSplineInputKey_InKey_PropertyAddress, GetRollAtSplineInputKey_FunctionAddress, "InKey");
		GetRollAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtSplineInputKey_FunctionAddress, "InKey");
		GetRollAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtSplineInputKey_CoordinateSpace_PropertyAddress, GetRollAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRollAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRollAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtSplineInputKey_ReturnValue_PropertyAddress, GetRollAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRollAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRollAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRollAtSplineInputKey_IsValid = GetRollAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetRollAtSplineInputKey_InKey_IsValid && GetRollAtSplineInputKey_CoordinateSpace_IsValid && GetRollAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRollAtSplineInputKey", GetRollAtSplineInputKey_IsValid);
		GetRollAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRollAtDistanceAlongSpline");
		GetRollAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRollAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtDistanceAlongSpline_Distance_PropertyAddress, GetRollAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRollAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRollAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetRollAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRollAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRollAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRollAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetRollAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRollAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRollAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRollAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRollAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRollAtDistanceAlongSpline_IsValid = GetRollAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetRollAtDistanceAlongSpline_Distance_IsValid && GetRollAtDistanceAlongSpline_CoordinateSpace_IsValid && GetRollAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRollAtDistanceAlongSpline", GetRollAtDistanceAlongSpline_IsValid);
		GetRightVectorAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRightVectorAtTime");
		GetRightVectorAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRightVectorAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtTime_Time_PropertyAddress, GetRightVectorAtTime_FunctionAddress, "Time");
		GetRightVectorAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtTime_FunctionAddress, "Time");
		GetRightVectorAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtTime_CoordinateSpace_PropertyAddress, GetRightVectorAtTime_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtTime_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtTime_bUseConstantVelocity_PropertyAddress, GetRightVectorAtTime_FunctionAddress, "bUseConstantVelocity");
		GetRightVectorAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtTime_FunctionAddress, "bUseConstantVelocity");
		GetRightVectorAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtTime_ReturnValue_PropertyAddress, GetRightVectorAtTime_FunctionAddress, "ReturnValue");
		GetRightVectorAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtTime_FunctionAddress, "ReturnValue");
		GetRightVectorAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRightVectorAtTime_IsValid = GetRightVectorAtTime_FunctionAddress != IntPtr.Zero && GetRightVectorAtTime_Time_IsValid && GetRightVectorAtTime_CoordinateSpace_IsValid && GetRightVectorAtTime_bUseConstantVelocity_IsValid && GetRightVectorAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRightVectorAtTime", GetRightVectorAtTime_IsValid);
		GetRightVectorAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRightVectorAtSplinePoint");
		GetRightVectorAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRightVectorAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtSplinePoint_PointIndex_PropertyAddress, GetRightVectorAtSplinePoint_FunctionAddress, "PointIndex");
		GetRightVectorAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtSplinePoint_FunctionAddress, "PointIndex");
		GetRightVectorAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtSplinePoint_CoordinateSpace_PropertyAddress, GetRightVectorAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtSplinePoint_ReturnValue_PropertyAddress, GetRightVectorAtSplinePoint_FunctionAddress, "ReturnValue");
		GetRightVectorAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtSplinePoint_FunctionAddress, "ReturnValue");
		GetRightVectorAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRightVectorAtSplinePoint_IsValid = GetRightVectorAtSplinePoint_FunctionAddress != IntPtr.Zero && GetRightVectorAtSplinePoint_PointIndex_IsValid && GetRightVectorAtSplinePoint_CoordinateSpace_IsValid && GetRightVectorAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRightVectorAtSplinePoint", GetRightVectorAtSplinePoint_IsValid);
		GetRightVectorAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRightVectorAtSplineInputKey");
		GetRightVectorAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRightVectorAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtSplineInputKey_InKey_PropertyAddress, GetRightVectorAtSplineInputKey_FunctionAddress, "InKey");
		GetRightVectorAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtSplineInputKey_FunctionAddress, "InKey");
		GetRightVectorAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtSplineInputKey_CoordinateSpace_PropertyAddress, GetRightVectorAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtSplineInputKey_ReturnValue_PropertyAddress, GetRightVectorAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRightVectorAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRightVectorAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRightVectorAtSplineInputKey_IsValid = GetRightVectorAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetRightVectorAtSplineInputKey_InKey_IsValid && GetRightVectorAtSplineInputKey_CoordinateSpace_IsValid && GetRightVectorAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRightVectorAtSplineInputKey", GetRightVectorAtSplineInputKey_IsValid);
		GetRightVectorAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRightVectorAtDistanceAlongSpline");
		GetRightVectorAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRightVectorAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtDistanceAlongSpline_Distance_PropertyAddress, GetRightVectorAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRightVectorAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRightVectorAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetRightVectorAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRightVectorAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRightVectorAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetRightVectorAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRightVectorAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVectorAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRightVectorAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVectorAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRightVectorAtDistanceAlongSpline_IsValid = GetRightVectorAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetRightVectorAtDistanceAlongSpline_Distance_IsValid && GetRightVectorAtDistanceAlongSpline_CoordinateSpace_IsValid && GetRightVectorAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetRightVectorAtDistanceAlongSpline", GetRightVectorAtDistanceAlongSpline_IsValid);
		GetNumberOfSplineSegments_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfSplineSegments");
		GetNumberOfSplineSegments_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfSplineSegments_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfSplineSegments_ReturnValue_PropertyAddress, GetNumberOfSplineSegments_FunctionAddress, "ReturnValue");
		GetNumberOfSplineSegments_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfSplineSegments_FunctionAddress, "ReturnValue");
		GetNumberOfSplineSegments_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfSplineSegments_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfSplineSegments_IsValid = GetNumberOfSplineSegments_FunctionAddress != IntPtr.Zero && GetNumberOfSplineSegments_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetNumberOfSplineSegments", GetNumberOfSplineSegments_IsValid);
		GetNumberOfSplinePoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfSplinePoints");
		GetNumberOfSplinePoints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfSplinePoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfSplinePoints_ReturnValue_PropertyAddress, GetNumberOfSplinePoints_FunctionAddress, "ReturnValue");
		GetNumberOfSplinePoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfSplinePoints_FunctionAddress, "ReturnValue");
		GetNumberOfSplinePoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfSplinePoints_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfSplinePoints_IsValid = GetNumberOfSplinePoints_FunctionAddress != IntPtr.Zero && GetNumberOfSplinePoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetNumberOfSplinePoints", GetNumberOfSplinePoints_IsValid);
		GetLocationAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAtTime");
		GetLocationAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtTime_Time_PropertyAddress, GetLocationAtTime_FunctionAddress, "Time");
		GetLocationAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtTime_FunctionAddress, "Time");
		GetLocationAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtTime_CoordinateSpace_PropertyAddress, GetLocationAtTime_FunctionAddress, "CoordinateSpace");
		GetLocationAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtTime_FunctionAddress, "CoordinateSpace");
		GetLocationAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtTime_bUseConstantVelocity_PropertyAddress, GetLocationAtTime_FunctionAddress, "bUseConstantVelocity");
		GetLocationAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtTime_FunctionAddress, "bUseConstantVelocity");
		GetLocationAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtTime_ReturnValue_PropertyAddress, GetLocationAtTime_FunctionAddress, "ReturnValue");
		GetLocationAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtTime_FunctionAddress, "ReturnValue");
		GetLocationAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocationAtTime_IsValid = GetLocationAtTime_FunctionAddress != IntPtr.Zero && GetLocationAtTime_Time_IsValid && GetLocationAtTime_CoordinateSpace_IsValid && GetLocationAtTime_bUseConstantVelocity_IsValid && GetLocationAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetLocationAtTime", GetLocationAtTime_IsValid);
		GetLocationAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAtSplinePoint");
		GetLocationAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplinePoint_PointIndex_PropertyAddress, GetLocationAtSplinePoint_FunctionAddress, "PointIndex");
		GetLocationAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplinePoint_FunctionAddress, "PointIndex");
		GetLocationAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplinePoint_CoordinateSpace_PropertyAddress, GetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplinePoint_ReturnValue_PropertyAddress, GetLocationAtSplinePoint_FunctionAddress, "ReturnValue");
		GetLocationAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplinePoint_FunctionAddress, "ReturnValue");
		GetLocationAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocationAtSplinePoint_IsValid = GetLocationAtSplinePoint_FunctionAddress != IntPtr.Zero && GetLocationAtSplinePoint_PointIndex_IsValid && GetLocationAtSplinePoint_CoordinateSpace_IsValid && GetLocationAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetLocationAtSplinePoint", GetLocationAtSplinePoint_IsValid);
		GetLocationAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAtSplineInputKey");
		GetLocationAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplineInputKey_InKey_PropertyAddress, GetLocationAtSplineInputKey_FunctionAddress, "InKey");
		GetLocationAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplineInputKey_FunctionAddress, "InKey");
		GetLocationAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplineInputKey_CoordinateSpace_PropertyAddress, GetLocationAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplineInputKey_ReturnValue_PropertyAddress, GetLocationAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetLocationAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetLocationAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocationAtSplineInputKey_IsValid = GetLocationAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetLocationAtSplineInputKey_InKey_IsValid && GetLocationAtSplineInputKey_CoordinateSpace_IsValid && GetLocationAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetLocationAtSplineInputKey", GetLocationAtSplineInputKey_IsValid);
		GetLocationAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAtDistanceAlongSpline");
		GetLocationAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtDistanceAlongSpline_Distance_PropertyAddress, GetLocationAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetLocationAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetLocationAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetLocationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetLocationAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetLocationAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetLocationAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetLocationAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetLocationAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocationAtDistanceAlongSpline_IsValid = GetLocationAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetLocationAtDistanceAlongSpline_Distance_IsValid && GetLocationAtDistanceAlongSpline_CoordinateSpace_IsValid && GetLocationAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetLocationAtDistanceAlongSpline", GetLocationAtDistanceAlongSpline_IsValid);
		GetLocationAndTangentAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAndTangentAtSplinePoint");
		GetLocationAndTangentAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAndTangentAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAndTangentAtSplinePoint_PointIndex_PropertyAddress, GetLocationAndTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetLocationAndTangentAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAndTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetLocationAndTangentAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAndTangentAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAndTangentAtSplinePoint_Location_PropertyAddress, GetLocationAndTangentAtSplinePoint_FunctionAddress, "Location");
		GetLocationAndTangentAtSplinePoint_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAndTangentAtSplinePoint_FunctionAddress, "Location");
		GetLocationAndTangentAtSplinePoint_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAndTangentAtSplinePoint_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAndTangentAtSplinePoint_Tangent_PropertyAddress, GetLocationAndTangentAtSplinePoint_FunctionAddress, "Tangent");
		GetLocationAndTangentAtSplinePoint_Tangent_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAndTangentAtSplinePoint_FunctionAddress, "Tangent");
		GetLocationAndTangentAtSplinePoint_Tangent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAndTangentAtSplinePoint_FunctionAddress, "Tangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAndTangentAtSplinePoint_CoordinateSpace_PropertyAddress, GetLocationAndTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLocationAndTangentAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAndTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLocationAndTangentAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAndTangentAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		GetLocationAndTangentAtSplinePoint_IsValid = GetLocationAndTangentAtSplinePoint_FunctionAddress != IntPtr.Zero && GetLocationAndTangentAtSplinePoint_PointIndex_IsValid && GetLocationAndTangentAtSplinePoint_Location_IsValid && GetLocationAndTangentAtSplinePoint_Tangent_IsValid && GetLocationAndTangentAtSplinePoint_CoordinateSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetLocationAndTangentAtSplinePoint", GetLocationAndTangentAtSplinePoint_IsValid);
		GetLeaveTangentAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLeaveTangentAtSplinePoint");
		GetLeaveTangentAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLeaveTangentAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLeaveTangentAtSplinePoint_PointIndex_PropertyAddress, GetLeaveTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetLeaveTangentAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLeaveTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetLeaveTangentAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLeaveTangentAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLeaveTangentAtSplinePoint_CoordinateSpace_PropertyAddress, GetLeaveTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLeaveTangentAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLeaveTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLeaveTangentAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLeaveTangentAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLeaveTangentAtSplinePoint_ReturnValue_PropertyAddress, GetLeaveTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetLeaveTangentAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLeaveTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetLeaveTangentAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLeaveTangentAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLeaveTangentAtSplinePoint_IsValid = GetLeaveTangentAtSplinePoint_FunctionAddress != IntPtr.Zero && GetLeaveTangentAtSplinePoint_PointIndex_IsValid && GetLeaveTangentAtSplinePoint_CoordinateSpace_IsValid && GetLeaveTangentAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetLeaveTangentAtSplinePoint", GetLeaveTangentAtSplinePoint_IsValid);
		GetInputKeyAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputKeyAtDistanceAlongSpline");
		GetInputKeyAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputKeyAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputKeyAtDistanceAlongSpline_Distance_PropertyAddress, GetInputKeyAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetInputKeyAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetInputKeyAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputKeyAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetInputKeyAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetInputKeyAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetInputKeyAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetInputKeyAtDistanceAlongSpline_IsValid = GetInputKeyAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetInputKeyAtDistanceAlongSpline_Distance_IsValid && GetInputKeyAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetInputKeyAtDistanceAlongSpline", GetInputKeyAtDistanceAlongSpline_IsValid);
		GetFloatPropertyAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFloatPropertyAtSplinePoint");
		GetFloatPropertyAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatPropertyAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatPropertyAtSplinePoint_Index_PropertyAddress, GetFloatPropertyAtSplinePoint_FunctionAddress, "Index");
		GetFloatPropertyAtSplinePoint_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatPropertyAtSplinePoint_FunctionAddress, "Index");
		GetFloatPropertyAtSplinePoint_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatPropertyAtSplinePoint_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatPropertyAtSplinePoint_PropertyName_PropertyAddress, GetFloatPropertyAtSplinePoint_FunctionAddress, "PropertyName");
		GetFloatPropertyAtSplinePoint_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatPropertyAtSplinePoint_FunctionAddress, "PropertyName");
		GetFloatPropertyAtSplinePoint_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatPropertyAtSplinePoint_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatPropertyAtSplinePoint_ReturnValue_PropertyAddress, GetFloatPropertyAtSplinePoint_FunctionAddress, "ReturnValue");
		GetFloatPropertyAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatPropertyAtSplinePoint_FunctionAddress, "ReturnValue");
		GetFloatPropertyAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatPropertyAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatPropertyAtSplinePoint_IsValid = GetFloatPropertyAtSplinePoint_FunctionAddress != IntPtr.Zero && GetFloatPropertyAtSplinePoint_Index_IsValid && GetFloatPropertyAtSplinePoint_PropertyName_IsValid && GetFloatPropertyAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetFloatPropertyAtSplinePoint", GetFloatPropertyAtSplinePoint_IsValid);
		GetFloatPropertyAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFloatPropertyAtSplineInputKey");
		GetFloatPropertyAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatPropertyAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatPropertyAtSplineInputKey_InKey_PropertyAddress, GetFloatPropertyAtSplineInputKey_FunctionAddress, "InKey");
		GetFloatPropertyAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatPropertyAtSplineInputKey_FunctionAddress, "InKey");
		GetFloatPropertyAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatPropertyAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatPropertyAtSplineInputKey_PropertyName_PropertyAddress, GetFloatPropertyAtSplineInputKey_FunctionAddress, "PropertyName");
		GetFloatPropertyAtSplineInputKey_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatPropertyAtSplineInputKey_FunctionAddress, "PropertyName");
		GetFloatPropertyAtSplineInputKey_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatPropertyAtSplineInputKey_FunctionAddress, "PropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatPropertyAtSplineInputKey_ReturnValue_PropertyAddress, GetFloatPropertyAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetFloatPropertyAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatPropertyAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetFloatPropertyAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatPropertyAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatPropertyAtSplineInputKey_IsValid = GetFloatPropertyAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetFloatPropertyAtSplineInputKey_InKey_IsValid && GetFloatPropertyAtSplineInputKey_PropertyName_IsValid && GetFloatPropertyAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetFloatPropertyAtSplineInputKey", GetFloatPropertyAtSplineInputKey_IsValid);
		GetDistanceAlongSplineAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDistanceAlongSplineAtSplinePoint");
		GetDistanceAlongSplineAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDistanceAlongSplineAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceAlongSplineAtSplinePoint_PointIndex_PropertyAddress, GetDistanceAlongSplineAtSplinePoint_FunctionAddress, "PointIndex");
		GetDistanceAlongSplineAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceAlongSplineAtSplinePoint_FunctionAddress, "PointIndex");
		GetDistanceAlongSplineAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceAlongSplineAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceAlongSplineAtSplinePoint_ReturnValue_PropertyAddress, GetDistanceAlongSplineAtSplinePoint_FunctionAddress, "ReturnValue");
		GetDistanceAlongSplineAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceAlongSplineAtSplinePoint_FunctionAddress, "ReturnValue");
		GetDistanceAlongSplineAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceAlongSplineAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDistanceAlongSplineAtSplinePoint_IsValid = GetDistanceAlongSplineAtSplinePoint_FunctionAddress != IntPtr.Zero && GetDistanceAlongSplineAtSplinePoint_PointIndex_IsValid && GetDistanceAlongSplineAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetDistanceAlongSplineAtSplinePoint", GetDistanceAlongSplineAtSplinePoint_IsValid);
		GetDistanceAlongSplineAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDistanceAlongSplineAtSplineInputKey");
		GetDistanceAlongSplineAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceAlongSplineAtSplineInputKey_InKey_PropertyAddress, GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "InKey");
		GetDistanceAlongSplineAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "InKey");
		GetDistanceAlongSplineAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceAlongSplineAtSplineInputKey_ReturnValue_PropertyAddress, GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDistanceAlongSplineAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDistanceAlongSplineAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDistanceAlongSplineAtSplineInputKey_IsValid = GetDistanceAlongSplineAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetDistanceAlongSplineAtSplineInputKey_InKey_IsValid && GetDistanceAlongSplineAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetDistanceAlongSplineAtSplineInputKey", GetDistanceAlongSplineAtSplineInputKey_IsValid);
		GetDirectionAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDirectionAtTime");
		GetDirectionAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectionAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtTime_Time_PropertyAddress, GetDirectionAtTime_FunctionAddress, "Time");
		GetDirectionAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtTime_FunctionAddress, "Time");
		GetDirectionAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtTime_CoordinateSpace_PropertyAddress, GetDirectionAtTime_FunctionAddress, "CoordinateSpace");
		GetDirectionAtTime_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtTime_FunctionAddress, "CoordinateSpace");
		GetDirectionAtTime_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtTime_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtTime_bUseConstantVelocity_PropertyAddress, GetDirectionAtTime_FunctionAddress, "bUseConstantVelocity");
		GetDirectionAtTime_bUseConstantVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtTime_FunctionAddress, "bUseConstantVelocity");
		GetDirectionAtTime_bUseConstantVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtTime_FunctionAddress, "bUseConstantVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtTime_ReturnValue_PropertyAddress, GetDirectionAtTime_FunctionAddress, "ReturnValue");
		GetDirectionAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtTime_FunctionAddress, "ReturnValue");
		GetDirectionAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirectionAtTime_IsValid = GetDirectionAtTime_FunctionAddress != IntPtr.Zero && GetDirectionAtTime_Time_IsValid && GetDirectionAtTime_CoordinateSpace_IsValid && GetDirectionAtTime_bUseConstantVelocity_IsValid && GetDirectionAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetDirectionAtTime", GetDirectionAtTime_IsValid);
		GetDirectionAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDirectionAtSplinePoint");
		GetDirectionAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectionAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplinePoint_PointIndex_PropertyAddress, GetDirectionAtSplinePoint_FunctionAddress, "PointIndex");
		GetDirectionAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplinePoint_FunctionAddress, "PointIndex");
		GetDirectionAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplinePoint_CoordinateSpace_PropertyAddress, GetDirectionAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplinePoint_ReturnValue_PropertyAddress, GetDirectionAtSplinePoint_FunctionAddress, "ReturnValue");
		GetDirectionAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplinePoint_FunctionAddress, "ReturnValue");
		GetDirectionAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirectionAtSplinePoint_IsValid = GetDirectionAtSplinePoint_FunctionAddress != IntPtr.Zero && GetDirectionAtSplinePoint_PointIndex_IsValid && GetDirectionAtSplinePoint_CoordinateSpace_IsValid && GetDirectionAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetDirectionAtSplinePoint", GetDirectionAtSplinePoint_IsValid);
		GetDirectionAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDirectionAtSplineInputKey");
		GetDirectionAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectionAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplineInputKey_InKey_PropertyAddress, GetDirectionAtSplineInputKey_FunctionAddress, "InKey");
		GetDirectionAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplineInputKey_FunctionAddress, "InKey");
		GetDirectionAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplineInputKey_CoordinateSpace_PropertyAddress, GetDirectionAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplineInputKey_ReturnValue_PropertyAddress, GetDirectionAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDirectionAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDirectionAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirectionAtSplineInputKey_IsValid = GetDirectionAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetDirectionAtSplineInputKey_InKey_IsValid && GetDirectionAtSplineInputKey_CoordinateSpace_IsValid && GetDirectionAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetDirectionAtSplineInputKey", GetDirectionAtSplineInputKey_IsValid);
		GetDirectionAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDirectionAtDistanceAlongSpline");
		GetDirectionAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectionAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtDistanceAlongSpline_Distance_PropertyAddress, GetDirectionAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetDirectionAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetDirectionAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetDirectionAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetDirectionAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetDirectionAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetDirectionAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetDirectionAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetDirectionAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirectionAtDistanceAlongSpline_IsValid = GetDirectionAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetDirectionAtDistanceAlongSpline_Distance_IsValid && GetDirectionAtDistanceAlongSpline_CoordinateSpace_IsValid && GetDirectionAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetDirectionAtDistanceAlongSpline", GetDirectionAtDistanceAlongSpline_IsValid);
		GetDefaultUpVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultUpVector");
		GetDefaultUpVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultUpVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultUpVector_CoordinateSpace_PropertyAddress, GetDefaultUpVector_FunctionAddress, "CoordinateSpace");
		GetDefaultUpVector_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultUpVector_FunctionAddress, "CoordinateSpace");
		GetDefaultUpVector_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultUpVector_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultUpVector_ReturnValue_PropertyAddress, GetDefaultUpVector_FunctionAddress, "ReturnValue");
		GetDefaultUpVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultUpVector_FunctionAddress, "ReturnValue");
		GetDefaultUpVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultUpVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultUpVector_IsValid = GetDefaultUpVector_FunctionAddress != IntPtr.Zero && GetDefaultUpVector_CoordinateSpace_IsValid && GetDefaultUpVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetDefaultUpVector", GetDefaultUpVector_IsValid);
		GetArriveTangentAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetArriveTangentAtSplinePoint");
		GetArriveTangentAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetArriveTangentAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetArriveTangentAtSplinePoint_PointIndex_PropertyAddress, GetArriveTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetArriveTangentAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetArriveTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetArriveTangentAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArriveTangentAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArriveTangentAtSplinePoint_CoordinateSpace_PropertyAddress, GetArriveTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetArriveTangentAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetArriveTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetArriveTangentAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArriveTangentAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArriveTangentAtSplinePoint_ReturnValue_PropertyAddress, GetArriveTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetArriveTangentAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetArriveTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetArriveTangentAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArriveTangentAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetArriveTangentAtSplinePoint_IsValid = GetArriveTangentAtSplinePoint_FunctionAddress != IntPtr.Zero && GetArriveTangentAtSplinePoint_PointIndex_IsValid && GetArriveTangentAtSplinePoint_CoordinateSpace_IsValid && GetArriveTangentAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:GetArriveTangentAtSplinePoint", GetArriveTangentAtSplinePoint_IsValid);
		FindUpVectorClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindUpVectorClosestToWorldLocation");
		FindUpVectorClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindUpVectorClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindUpVectorClosestToWorldLocation_WorldLocation_PropertyAddress, FindUpVectorClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindUpVectorClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindUpVectorClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindUpVectorClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUpVectorClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindUpVectorClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindUpVectorClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindUpVectorClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindUpVectorClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindUpVectorClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUpVectorClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindUpVectorClosestToWorldLocation_ReturnValue_PropertyAddress, FindUpVectorClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindUpVectorClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindUpVectorClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindUpVectorClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUpVectorClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindUpVectorClosestToWorldLocation_IsValid = FindUpVectorClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindUpVectorClosestToWorldLocation_WorldLocation_IsValid && FindUpVectorClosestToWorldLocation_CoordinateSpace_IsValid && FindUpVectorClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindUpVectorClosestToWorldLocation", FindUpVectorClosestToWorldLocation_IsValid);
		FindTransformClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindTransformClosestToWorldLocation");
		FindTransformClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindTransformClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindTransformClosestToWorldLocation_WorldLocation_PropertyAddress, FindTransformClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindTransformClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindTransformClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindTransformClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTransformClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTransformClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindTransformClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindTransformClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindTransformClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindTransformClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTransformClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTransformClosestToWorldLocation_bUseScale_PropertyAddress, FindTransformClosestToWorldLocation_FunctionAddress, "bUseScale");
		FindTransformClosestToWorldLocation_bUseScale_Offset = NativeReflectionCached.GetPropertyOffset(FindTransformClosestToWorldLocation_FunctionAddress, "bUseScale");
		FindTransformClosestToWorldLocation_bUseScale_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTransformClosestToWorldLocation_FunctionAddress, "bUseScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTransformClosestToWorldLocation_ReturnValue_PropertyAddress, FindTransformClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindTransformClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindTransformClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindTransformClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTransformClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindTransformClosestToWorldLocation_IsValid = FindTransformClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindTransformClosestToWorldLocation_WorldLocation_IsValid && FindTransformClosestToWorldLocation_CoordinateSpace_IsValid && FindTransformClosestToWorldLocation_bUseScale_IsValid && FindTransformClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindTransformClosestToWorldLocation", FindTransformClosestToWorldLocation_IsValid);
		FindTangentClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindTangentClosestToWorldLocation");
		FindTangentClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindTangentClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindTangentClosestToWorldLocation_WorldLocation_PropertyAddress, FindTangentClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindTangentClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindTangentClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindTangentClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTangentClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTangentClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindTangentClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindTangentClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindTangentClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindTangentClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTangentClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTangentClosestToWorldLocation_ReturnValue_PropertyAddress, FindTangentClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindTangentClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindTangentClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindTangentClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTangentClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindTangentClosestToWorldLocation_IsValid = FindTangentClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindTangentClosestToWorldLocation_WorldLocation_IsValid && FindTangentClosestToWorldLocation_CoordinateSpace_IsValid && FindTangentClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindTangentClosestToWorldLocation", FindTangentClosestToWorldLocation_IsValid);
		FindScaleClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindScaleClosestToWorldLocation");
		FindScaleClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindScaleClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindScaleClosestToWorldLocation_WorldLocation_PropertyAddress, FindScaleClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindScaleClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindScaleClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindScaleClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindScaleClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindScaleClosestToWorldLocation_ReturnValue_PropertyAddress, FindScaleClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindScaleClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindScaleClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindScaleClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindScaleClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindScaleClosestToWorldLocation_IsValid = FindScaleClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindScaleClosestToWorldLocation_WorldLocation_IsValid && FindScaleClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindScaleClosestToWorldLocation", FindScaleClosestToWorldLocation_IsValid);
		FindRotationClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindRotationClosestToWorldLocation");
		FindRotationClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindRotationClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindRotationClosestToWorldLocation_WorldLocation_PropertyAddress, FindRotationClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindRotationClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindRotationClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindRotationClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRotationClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRotationClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindRotationClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindRotationClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindRotationClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindRotationClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRotationClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRotationClosestToWorldLocation_ReturnValue_PropertyAddress, FindRotationClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindRotationClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindRotationClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindRotationClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRotationClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindRotationClosestToWorldLocation_IsValid = FindRotationClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindRotationClosestToWorldLocation_WorldLocation_IsValid && FindRotationClosestToWorldLocation_CoordinateSpace_IsValid && FindRotationClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindRotationClosestToWorldLocation", FindRotationClosestToWorldLocation_IsValid);
		FindRollClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindRollClosestToWorldLocation");
		FindRollClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindRollClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindRollClosestToWorldLocation_WorldLocation_PropertyAddress, FindRollClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindRollClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindRollClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindRollClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRollClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRollClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindRollClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindRollClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindRollClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindRollClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRollClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRollClosestToWorldLocation_ReturnValue_PropertyAddress, FindRollClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindRollClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindRollClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindRollClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRollClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		FindRollClosestToWorldLocation_IsValid = FindRollClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindRollClosestToWorldLocation_WorldLocation_IsValid && FindRollClosestToWorldLocation_CoordinateSpace_IsValid && FindRollClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindRollClosestToWorldLocation", FindRollClosestToWorldLocation_IsValid);
		FindRightVectorClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindRightVectorClosestToWorldLocation");
		FindRightVectorClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindRightVectorClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindRightVectorClosestToWorldLocation_WorldLocation_PropertyAddress, FindRightVectorClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindRightVectorClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindRightVectorClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindRightVectorClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRightVectorClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRightVectorClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindRightVectorClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindRightVectorClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindRightVectorClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindRightVectorClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRightVectorClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRightVectorClosestToWorldLocation_ReturnValue_PropertyAddress, FindRightVectorClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindRightVectorClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindRightVectorClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindRightVectorClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRightVectorClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindRightVectorClosestToWorldLocation_IsValid = FindRightVectorClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindRightVectorClosestToWorldLocation_WorldLocation_IsValid && FindRightVectorClosestToWorldLocation_CoordinateSpace_IsValid && FindRightVectorClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindRightVectorClosestToWorldLocation", FindRightVectorClosestToWorldLocation_IsValid);
		FindLocationClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindLocationClosestToWorldLocation");
		FindLocationClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindLocationClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindLocationClosestToWorldLocation_WorldLocation_PropertyAddress, FindLocationClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindLocationClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindLocationClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindLocationClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindLocationClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindLocationClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindLocationClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindLocationClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindLocationClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindLocationClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindLocationClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindLocationClosestToWorldLocation_ReturnValue_PropertyAddress, FindLocationClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindLocationClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindLocationClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindLocationClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindLocationClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindLocationClosestToWorldLocation_IsValid = FindLocationClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindLocationClosestToWorldLocation_WorldLocation_IsValid && FindLocationClosestToWorldLocation_CoordinateSpace_IsValid && FindLocationClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindLocationClosestToWorldLocation", FindLocationClosestToWorldLocation_IsValid);
		FindInputKeyClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindInputKeyClosestToWorldLocation");
		FindInputKeyClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindInputKeyClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindInputKeyClosestToWorldLocation_WorldLocation_PropertyAddress, FindInputKeyClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindInputKeyClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindInputKeyClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindInputKeyClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindInputKeyClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindInputKeyClosestToWorldLocation_ReturnValue_PropertyAddress, FindInputKeyClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindInputKeyClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindInputKeyClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindInputKeyClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindInputKeyClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		FindInputKeyClosestToWorldLocation_IsValid = FindInputKeyClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindInputKeyClosestToWorldLocation_WorldLocation_IsValid && FindInputKeyClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindInputKeyClosestToWorldLocation", FindInputKeyClosestToWorldLocation_IsValid);
		FindDirectionClosestToWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindDirectionClosestToWorldLocation");
		FindDirectionClosestToWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(FindDirectionClosestToWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindDirectionClosestToWorldLocation_WorldLocation_PropertyAddress, FindDirectionClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindDirectionClosestToWorldLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindDirectionClosestToWorldLocation_FunctionAddress, "WorldLocation");
		FindDirectionClosestToWorldLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDirectionClosestToWorldLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindDirectionClosestToWorldLocation_CoordinateSpace_PropertyAddress, FindDirectionClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindDirectionClosestToWorldLocation_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(FindDirectionClosestToWorldLocation_FunctionAddress, "CoordinateSpace");
		FindDirectionClosestToWorldLocation_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDirectionClosestToWorldLocation_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindDirectionClosestToWorldLocation_ReturnValue_PropertyAddress, FindDirectionClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindDirectionClosestToWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindDirectionClosestToWorldLocation_FunctionAddress, "ReturnValue");
		FindDirectionClosestToWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDirectionClosestToWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindDirectionClosestToWorldLocation_IsValid = FindDirectionClosestToWorldLocation_FunctionAddress != IntPtr.Zero && FindDirectionClosestToWorldLocation_WorldLocation_IsValid && FindDirectionClosestToWorldLocation_CoordinateSpace_IsValid && FindDirectionClosestToWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:FindDirectionClosestToWorldLocation", FindDirectionClosestToWorldLocation_IsValid);
		DivideSplineIntoPolylineRecursive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DivideSplineIntoPolylineRecursive");
		DivideSplineIntoPolylineRecursive_ParamsSize = NativeReflection.GetFunctionParamsSize(DivideSplineIntoPolylineRecursive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_PropertyAddress, DivideSplineIntoPolylineRecursive_FunctionAddress, "StartDistanceAlongSpline");
		DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_Offset = NativeReflectionCached.GetPropertyOffset(DivideSplineIntoPolylineRecursive_FunctionAddress, "StartDistanceAlongSpline");
		DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(DivideSplineIntoPolylineRecursive_FunctionAddress, "StartDistanceAlongSpline", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_PropertyAddress, DivideSplineIntoPolylineRecursive_FunctionAddress, "EndDistanceAlongSpline");
		DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_Offset = NativeReflectionCached.GetPropertyOffset(DivideSplineIntoPolylineRecursive_FunctionAddress, "EndDistanceAlongSpline");
		DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(DivideSplineIntoPolylineRecursive_FunctionAddress, "EndDistanceAlongSpline", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DivideSplineIntoPolylineRecursive_CoordinateSpace_PropertyAddress, DivideSplineIntoPolylineRecursive_FunctionAddress, "CoordinateSpace");
		DivideSplineIntoPolylineRecursive_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(DivideSplineIntoPolylineRecursive_FunctionAddress, "CoordinateSpace");
		DivideSplineIntoPolylineRecursive_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DivideSplineIntoPolylineRecursive_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_PropertyAddress, DivideSplineIntoPolylineRecursive_FunctionAddress, "MaxSquareDistanceFromSpline");
		DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_Offset = NativeReflectionCached.GetPropertyOffset(DivideSplineIntoPolylineRecursive_FunctionAddress, "MaxSquareDistanceFromSpline");
		DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(DivideSplineIntoPolylineRecursive_FunctionAddress, "MaxSquareDistanceFromSpline", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DivideSplineIntoPolylineRecursive_OutPoints_PropertyAddress, DivideSplineIntoPolylineRecursive_FunctionAddress, "OutPoints");
		DivideSplineIntoPolylineRecursive_OutPoints_Offset = NativeReflectionCached.GetPropertyOffset(DivideSplineIntoPolylineRecursive_FunctionAddress, "OutPoints");
		DivideSplineIntoPolylineRecursive_OutPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(DivideSplineIntoPolylineRecursive_FunctionAddress, "OutPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DivideSplineIntoPolylineRecursive_ReturnValue_PropertyAddress, DivideSplineIntoPolylineRecursive_FunctionAddress, "ReturnValue");
		DivideSplineIntoPolylineRecursive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DivideSplineIntoPolylineRecursive_FunctionAddress, "ReturnValue");
		DivideSplineIntoPolylineRecursive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DivideSplineIntoPolylineRecursive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DivideSplineIntoPolylineRecursive_IsValid = DivideSplineIntoPolylineRecursive_FunctionAddress != IntPtr.Zero && DivideSplineIntoPolylineRecursive_StartDistanceAlongSpline_IsValid && DivideSplineIntoPolylineRecursive_EndDistanceAlongSpline_IsValid && DivideSplineIntoPolylineRecursive_CoordinateSpace_IsValid && DivideSplineIntoPolylineRecursive_MaxSquareDistanceFromSpline_IsValid && DivideSplineIntoPolylineRecursive_OutPoints_IsValid && DivideSplineIntoPolylineRecursive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:DivideSplineIntoPolylineRecursive", DivideSplineIntoPolylineRecursive_IsValid);
		ConvertSplineToPolyLine_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConvertSplineToPolyLine");
		ConvertSplineToPolyLine_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertSplineToPolyLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineToPolyLine_CoordinateSpace_PropertyAddress, ConvertSplineToPolyLine_FunctionAddress, "CoordinateSpace");
		ConvertSplineToPolyLine_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineToPolyLine_FunctionAddress, "CoordinateSpace");
		ConvertSplineToPolyLine_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineToPolyLine_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_PropertyAddress, ConvertSplineToPolyLine_FunctionAddress, "MaxSquareDistanceFromSpline");
		ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineToPolyLine_FunctionAddress, "MaxSquareDistanceFromSpline");
		ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineToPolyLine_FunctionAddress, "MaxSquareDistanceFromSpline", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineToPolyLine_OutPoints_PropertyAddress, ConvertSplineToPolyLine_FunctionAddress, "OutPoints");
		ConvertSplineToPolyLine_OutPoints_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineToPolyLine_FunctionAddress, "OutPoints");
		ConvertSplineToPolyLine_OutPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineToPolyLine_FunctionAddress, "OutPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineToPolyLine_ReturnValue_PropertyAddress, ConvertSplineToPolyLine_FunctionAddress, "ReturnValue");
		ConvertSplineToPolyLine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineToPolyLine_FunctionAddress, "ReturnValue");
		ConvertSplineToPolyLine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineToPolyLine_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ConvertSplineToPolyLine_IsValid = ConvertSplineToPolyLine_FunctionAddress != IntPtr.Zero && ConvertSplineToPolyLine_CoordinateSpace_IsValid && ConvertSplineToPolyLine_MaxSquareDistanceFromSpline_IsValid && ConvertSplineToPolyLine_OutPoints_IsValid && ConvertSplineToPolyLine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:ConvertSplineToPolyLine", ConvertSplineToPolyLine_IsValid);
		ConvertSplineSegmentToPolyLine_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConvertSplineSegmentToPolyLine");
		ConvertSplineSegmentToPolyLine_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertSplineSegmentToPolyLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineSegmentToPolyLine_SplinePointStartIndex_PropertyAddress, ConvertSplineSegmentToPolyLine_FunctionAddress, "SplinePointStartIndex");
		ConvertSplineSegmentToPolyLine_SplinePointStartIndex_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineSegmentToPolyLine_FunctionAddress, "SplinePointStartIndex");
		ConvertSplineSegmentToPolyLine_SplinePointStartIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineSegmentToPolyLine_FunctionAddress, "SplinePointStartIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineSegmentToPolyLine_CoordinateSpace_PropertyAddress, ConvertSplineSegmentToPolyLine_FunctionAddress, "CoordinateSpace");
		ConvertSplineSegmentToPolyLine_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineSegmentToPolyLine_FunctionAddress, "CoordinateSpace");
		ConvertSplineSegmentToPolyLine_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineSegmentToPolyLine_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_PropertyAddress, ConvertSplineSegmentToPolyLine_FunctionAddress, "MaxSquareDistanceFromSpline");
		ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineSegmentToPolyLine_FunctionAddress, "MaxSquareDistanceFromSpline");
		ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineSegmentToPolyLine_FunctionAddress, "MaxSquareDistanceFromSpline", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineSegmentToPolyLine_OutPoints_PropertyAddress, ConvertSplineSegmentToPolyLine_FunctionAddress, "OutPoints");
		ConvertSplineSegmentToPolyLine_OutPoints_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineSegmentToPolyLine_FunctionAddress, "OutPoints");
		ConvertSplineSegmentToPolyLine_OutPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineSegmentToPolyLine_FunctionAddress, "OutPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSplineSegmentToPolyLine_ReturnValue_PropertyAddress, ConvertSplineSegmentToPolyLine_FunctionAddress, "ReturnValue");
		ConvertSplineSegmentToPolyLine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertSplineSegmentToPolyLine_FunctionAddress, "ReturnValue");
		ConvertSplineSegmentToPolyLine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertSplineSegmentToPolyLine_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ConvertSplineSegmentToPolyLine_IsValid = ConvertSplineSegmentToPolyLine_FunctionAddress != IntPtr.Zero && ConvertSplineSegmentToPolyLine_SplinePointStartIndex_IsValid && ConvertSplineSegmentToPolyLine_CoordinateSpace_IsValid && ConvertSplineSegmentToPolyLine_MaxSquareDistanceFromSpline_IsValid && ConvertSplineSegmentToPolyLine_OutPoints_IsValid && ConvertSplineSegmentToPolyLine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:ConvertSplineSegmentToPolyLine", ConvertSplineSegmentToPolyLine_IsValid);
		ClearSplinePoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSplinePoints");
		ClearSplinePoints_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSplinePoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearSplinePoints_bUpdateSpline_PropertyAddress, ClearSplinePoints_FunctionAddress, "bUpdateSpline");
		ClearSplinePoints_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(ClearSplinePoints_FunctionAddress, "bUpdateSpline");
		ClearSplinePoints_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSplinePoints_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		ClearSplinePoints_IsValid = ClearSplinePoints_FunctionAddress != IntPtr.Zero && ClearSplinePoints_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:ClearSplinePoints", ClearSplinePoints_IsValid);
		AddSplinePointAtIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSplinePointAtIndex");
		AddSplinePointAtIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSplinePointAtIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePointAtIndex_Position_PropertyAddress, AddSplinePointAtIndex_FunctionAddress, "Position");
		AddSplinePointAtIndex_Position_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePointAtIndex_FunctionAddress, "Position");
		AddSplinePointAtIndex_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePointAtIndex_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePointAtIndex_Index_PropertyAddress, AddSplinePointAtIndex_FunctionAddress, "Index");
		AddSplinePointAtIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePointAtIndex_FunctionAddress, "Index");
		AddSplinePointAtIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePointAtIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePointAtIndex_CoordinateSpace_PropertyAddress, AddSplinePointAtIndex_FunctionAddress, "CoordinateSpace");
		AddSplinePointAtIndex_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePointAtIndex_FunctionAddress, "CoordinateSpace");
		AddSplinePointAtIndex_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePointAtIndex_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePointAtIndex_bUpdateSpline_PropertyAddress, AddSplinePointAtIndex_FunctionAddress, "bUpdateSpline");
		AddSplinePointAtIndex_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePointAtIndex_FunctionAddress, "bUpdateSpline");
		AddSplinePointAtIndex_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePointAtIndex_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		AddSplinePointAtIndex_IsValid = AddSplinePointAtIndex_FunctionAddress != IntPtr.Zero && AddSplinePointAtIndex_Position_IsValid && AddSplinePointAtIndex_Index_IsValid && AddSplinePointAtIndex_CoordinateSpace_IsValid && AddSplinePointAtIndex_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:AddSplinePointAtIndex", AddSplinePointAtIndex_IsValid);
		AddSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSplinePoint");
		AddSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePoint_Position_PropertyAddress, AddSplinePoint_FunctionAddress, "Position");
		AddSplinePoint_Position_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePoint_FunctionAddress, "Position");
		AddSplinePoint_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePoint_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePoint_CoordinateSpace_PropertyAddress, AddSplinePoint_FunctionAddress, "CoordinateSpace");
		AddSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePoint_FunctionAddress, "CoordinateSpace");
		AddSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePoint_bUpdateSpline_PropertyAddress, AddSplinePoint_FunctionAddress, "bUpdateSpline");
		AddSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePoint_FunctionAddress, "bUpdateSpline");
		AddSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		AddSplinePoint_IsValid = AddSplinePoint_FunctionAddress != IntPtr.Zero && AddSplinePoint_Position_IsValid && AddSplinePoint_CoordinateSpace_IsValid && AddSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:AddSplinePoint", AddSplinePoint_IsValid);
		AddPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPoints");
		AddPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPoints_Points_PropertyAddress, AddPoints_FunctionAddress, "Points");
		AddPoints_Points_Offset = NativeReflectionCached.GetPropertyOffset(AddPoints_FunctionAddress, "Points");
		AddPoints_Points_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoints_FunctionAddress, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPoints_bUpdateSpline_PropertyAddress, AddPoints_FunctionAddress, "bUpdateSpline");
		AddPoints_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(AddPoints_FunctionAddress, "bUpdateSpline");
		AddPoints_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoints_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		AddPoints_IsValid = AddPoints_FunctionAddress != IntPtr.Zero && AddPoints_Points_IsValid && AddPoints_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:AddPoints", AddPoints_IsValid);
		AddPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPoint");
		AddPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPoint_Point_PropertyAddress, AddPoint_FunctionAddress, "Point");
		AddPoint_Point_Offset = NativeReflectionCached.GetPropertyOffset(AddPoint_FunctionAddress, "Point");
		AddPoint_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoint_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPoint_bUpdateSpline_PropertyAddress, AddPoint_FunctionAddress, "bUpdateSpline");
		AddPoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(AddPoint_FunctionAddress, "bUpdateSpline");
		AddPoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		AddPoint_IsValid = AddPoint_FunctionAddress != IntPtr.Zero && AddPoint_Point_IsValid && AddPoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineComponent:AddPoint", AddPoint_IsValid);
	}
}
