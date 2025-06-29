using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.MeshDescriptionBase", "MeshDescription", UnrealModuleType.Engine)]
public class UMeshDescriptionBase : UObject
{
	private static bool SetVertexPosition_IsValid;

	private static IntPtr SetVertexPosition_FunctionAddress;

	private static int SetVertexPosition_ParamsSize;

	private static bool SetVertexPosition_VertexID_IsValid;

	private static FFieldAddress SetVertexPosition_VertexID_PropertyAddress;

	private static int SetVertexPosition_VertexID_Offset;

	private static bool SetVertexPosition_Position_IsValid;

	private static FFieldAddress SetVertexPosition_Position_PropertyAddress;

	private static int SetVertexPosition_Position_Offset;

	private static bool SetPolygonVertexInstances_IsValid;

	private static IntPtr SetPolygonVertexInstances_FunctionAddress;

	private static int SetPolygonVertexInstances_ParamsSize;

	private static bool SetPolygonVertexInstances_PolygonID_IsValid;

	private static FFieldAddress SetPolygonVertexInstances_PolygonID_PropertyAddress;

	private static int SetPolygonVertexInstances_PolygonID_Offset;

	private static bool SetPolygonVertexInstances_VertexInstanceIDs_IsValid;

	private static FFieldAddress SetPolygonVertexInstances_VertexInstanceIDs_PropertyAddress;

	private static int SetPolygonVertexInstances_VertexInstanceIDs_Offset;

	private static bool SetPolygonPolygonGroup_IsValid;

	private static IntPtr SetPolygonPolygonGroup_FunctionAddress;

	private static int SetPolygonPolygonGroup_ParamsSize;

	private static bool SetPolygonPolygonGroup_PolygonID_IsValid;

	private static FFieldAddress SetPolygonPolygonGroup_PolygonID_PropertyAddress;

	private static int SetPolygonPolygonGroup_PolygonID_Offset;

	private static bool SetPolygonPolygonGroup_PolygonGroupID_IsValid;

	private static FFieldAddress SetPolygonPolygonGroup_PolygonGroupID_PropertyAddress;

	private static int SetPolygonPolygonGroup_PolygonGroupID_Offset;

	private static bool ReversePolygonFacing_IsValid;

	private static IntPtr ReversePolygonFacing_FunctionAddress;

	private static int ReversePolygonFacing_ParamsSize;

	private static bool ReversePolygonFacing_PolygonID_IsValid;

	private static FFieldAddress ReversePolygonFacing_PolygonID_PropertyAddress;

	private static int ReversePolygonFacing_PolygonID_Offset;

	private static bool ReserveNewVertices_IsValid;

	private static IntPtr ReserveNewVertices_FunctionAddress;

	private static int ReserveNewVertices_ParamsSize;

	private static bool ReserveNewVertices_NumberOfNewVertices_IsValid;

	private static FFieldAddress ReserveNewVertices_NumberOfNewVertices_PropertyAddress;

	private static int ReserveNewVertices_NumberOfNewVertices_Offset;

	private static bool ReserveNewVertexInstances_IsValid;

	private static IntPtr ReserveNewVertexInstances_FunctionAddress;

	private static int ReserveNewVertexInstances_ParamsSize;

	private static bool ReserveNewVertexInstances_NumberOfNewVertexInstances_IsValid;

	private static FFieldAddress ReserveNewVertexInstances_NumberOfNewVertexInstances_PropertyAddress;

	private static int ReserveNewVertexInstances_NumberOfNewVertexInstances_Offset;

	private static bool ReserveNewTriangles_IsValid;

	private static IntPtr ReserveNewTriangles_FunctionAddress;

	private static int ReserveNewTriangles_ParamsSize;

	private static bool ReserveNewTriangles_NumberOfNewTriangles_IsValid;

	private static FFieldAddress ReserveNewTriangles_NumberOfNewTriangles_PropertyAddress;

	private static int ReserveNewTriangles_NumberOfNewTriangles_Offset;

	private static bool ReserveNewPolygons_IsValid;

	private static IntPtr ReserveNewPolygons_FunctionAddress;

	private static int ReserveNewPolygons_ParamsSize;

	private static bool ReserveNewPolygons_NumberOfNewPolygons_IsValid;

	private static FFieldAddress ReserveNewPolygons_NumberOfNewPolygons_PropertyAddress;

	private static int ReserveNewPolygons_NumberOfNewPolygons_Offset;

	private static bool ReserveNewPolygonGroups_IsValid;

	private static IntPtr ReserveNewPolygonGroups_FunctionAddress;

	private static int ReserveNewPolygonGroups_ParamsSize;

	private static bool ReserveNewPolygonGroups_NumberOfNewPolygonGroups_IsValid;

	private static FFieldAddress ReserveNewPolygonGroups_NumberOfNewPolygonGroups_PropertyAddress;

	private static int ReserveNewPolygonGroups_NumberOfNewPolygonGroups_Offset;

	private static bool ReserveNewEdges_IsValid;

	private static IntPtr ReserveNewEdges_FunctionAddress;

	private static int ReserveNewEdges_ParamsSize;

	private static bool ReserveNewEdges_NumberOfNewEdges_IsValid;

	private static FFieldAddress ReserveNewEdges_NumberOfNewEdges_PropertyAddress;

	private static int ReserveNewEdges_NumberOfNewEdges_Offset;

	private static bool IsVertexValid_IsValid;

	private static IntPtr IsVertexValid_FunctionAddress;

	private static int IsVertexValid_ParamsSize;

	private static bool IsVertexValid_VertexID_IsValid;

	private static FFieldAddress IsVertexValid_VertexID_PropertyAddress;

	private static int IsVertexValid_VertexID_Offset;

	private static bool IsVertexValid_ReturnValue_IsValid;

	private static FFieldAddress IsVertexValid_ReturnValue_PropertyAddress;

	private static int IsVertexValid_ReturnValue_Offset;

	private static bool IsVertexOrphaned_IsValid;

	private static IntPtr IsVertexOrphaned_FunctionAddress;

	private static int IsVertexOrphaned_ParamsSize;

	private static bool IsVertexOrphaned_VertexID_IsValid;

	private static FFieldAddress IsVertexOrphaned_VertexID_PropertyAddress;

	private static int IsVertexOrphaned_VertexID_Offset;

	private static bool IsVertexOrphaned_ReturnValue_IsValid;

	private static FFieldAddress IsVertexOrphaned_ReturnValue_PropertyAddress;

	private static int IsVertexOrphaned_ReturnValue_Offset;

	private static bool IsVertexInstanceValid_IsValid;

	private static IntPtr IsVertexInstanceValid_FunctionAddress;

	private static int IsVertexInstanceValid_ParamsSize;

	private static bool IsVertexInstanceValid_VertexInstanceID_IsValid;

	private static FFieldAddress IsVertexInstanceValid_VertexInstanceID_PropertyAddress;

	private static int IsVertexInstanceValid_VertexInstanceID_Offset;

	private static bool IsVertexInstanceValid_ReturnValue_IsValid;

	private static FFieldAddress IsVertexInstanceValid_ReturnValue_PropertyAddress;

	private static int IsVertexInstanceValid_ReturnValue_Offset;

	private static bool IsTriangleValid_IsValid;

	private static IntPtr IsTriangleValid_FunctionAddress;

	private static int IsTriangleValid_ParamsSize;

	private static bool IsTriangleValid_TriangleID_IsValid;

	private static FFieldAddress IsTriangleValid_TriangleID_PropertyAddress;

	private static int IsTriangleValid_TriangleID_Offset;

	private static bool IsTriangleValid_ReturnValue_IsValid;

	private static FFieldAddress IsTriangleValid_ReturnValue_PropertyAddress;

	private static int IsTriangleValid_ReturnValue_Offset;

	private static bool IsTrianglePartOfNgon_IsValid;

	private static IntPtr IsTrianglePartOfNgon_FunctionAddress;

	private static int IsTrianglePartOfNgon_ParamsSize;

	private static bool IsTrianglePartOfNgon_TriangleID_IsValid;

	private static FFieldAddress IsTrianglePartOfNgon_TriangleID_PropertyAddress;

	private static int IsTrianglePartOfNgon_TriangleID_Offset;

	private static bool IsTrianglePartOfNgon_ReturnValue_IsValid;

	private static FFieldAddress IsTrianglePartOfNgon_ReturnValue_PropertyAddress;

	private static int IsTrianglePartOfNgon_ReturnValue_Offset;

	private static bool IsPolygonValid_IsValid;

	private static IntPtr IsPolygonValid_FunctionAddress;

	private static int IsPolygonValid_ParamsSize;

	private static bool IsPolygonValid_PolygonID_IsValid;

	private static FFieldAddress IsPolygonValid_PolygonID_PropertyAddress;

	private static int IsPolygonValid_PolygonID_Offset;

	private static bool IsPolygonValid_ReturnValue_IsValid;

	private static FFieldAddress IsPolygonValid_ReturnValue_PropertyAddress;

	private static int IsPolygonValid_ReturnValue_Offset;

	private static bool IsPolygonGroupValid_IsValid;

	private static IntPtr IsPolygonGroupValid_FunctionAddress;

	private static int IsPolygonGroupValid_ParamsSize;

	private static bool IsPolygonGroupValid_PolygonGroupID_IsValid;

	private static FFieldAddress IsPolygonGroupValid_PolygonGroupID_PropertyAddress;

	private static int IsPolygonGroupValid_PolygonGroupID_Offset;

	private static bool IsPolygonGroupValid_ReturnValue_IsValid;

	private static FFieldAddress IsPolygonGroupValid_ReturnValue_PropertyAddress;

	private static int IsPolygonGroupValid_ReturnValue_Offset;

	private static bool IsEmpty_IsValid;

	private static IntPtr IsEmpty_FunctionAddress;

	private static int IsEmpty_ParamsSize;

	private static bool IsEmpty_ReturnValue_IsValid;

	private static FFieldAddress IsEmpty_ReturnValue_PropertyAddress;

	private static int IsEmpty_ReturnValue_Offset;

	private static bool IsEdgeValid_IsValid;

	private static IntPtr IsEdgeValid_FunctionAddress;

	private static int IsEdgeValid_ParamsSize;

	private static bool IsEdgeValid_EdgeID_IsValid;

	private static FFieldAddress IsEdgeValid_EdgeID_PropertyAddress;

	private static int IsEdgeValid_EdgeID_Offset;

	private static bool IsEdgeValid_ReturnValue_IsValid;

	private static FFieldAddress IsEdgeValid_ReturnValue_PropertyAddress;

	private static int IsEdgeValid_ReturnValue_Offset;

	private static bool IsEdgeInternalToPolygon_IsValid;

	private static IntPtr IsEdgeInternalToPolygon_FunctionAddress;

	private static int IsEdgeInternalToPolygon_ParamsSize;

	private static bool IsEdgeInternalToPolygon_EdgeID_IsValid;

	private static FFieldAddress IsEdgeInternalToPolygon_EdgeID_PropertyAddress;

	private static int IsEdgeInternalToPolygon_EdgeID_Offset;

	private static bool IsEdgeInternalToPolygon_PolygonID_IsValid;

	private static FFieldAddress IsEdgeInternalToPolygon_PolygonID_PropertyAddress;

	private static int IsEdgeInternalToPolygon_PolygonID_Offset;

	private static bool IsEdgeInternalToPolygon_ReturnValue_IsValid;

	private static FFieldAddress IsEdgeInternalToPolygon_ReturnValue_PropertyAddress;

	private static int IsEdgeInternalToPolygon_ReturnValue_Offset;

	private static bool IsEdgeInternal_IsValid;

	private static IntPtr IsEdgeInternal_FunctionAddress;

	private static int IsEdgeInternal_ParamsSize;

	private static bool IsEdgeInternal_EdgeID_IsValid;

	private static FFieldAddress IsEdgeInternal_EdgeID_PropertyAddress;

	private static int IsEdgeInternal_EdgeID_Offset;

	private static bool IsEdgeInternal_ReturnValue_IsValid;

	private static FFieldAddress IsEdgeInternal_ReturnValue_PropertyAddress;

	private static int IsEdgeInternal_ReturnValue_Offset;

	private static bool GetVertexVertexInstances_IsValid;

	private static IntPtr GetVertexVertexInstances_FunctionAddress;

	private static int GetVertexVertexInstances_ParamsSize;

	private static bool GetVertexVertexInstances_VertexID_IsValid;

	private static FFieldAddress GetVertexVertexInstances_VertexID_PropertyAddress;

	private static int GetVertexVertexInstances_VertexID_Offset;

	private static bool GetVertexVertexInstances_OutVertexInstanceIDs_IsValid;

	private static FFieldAddress GetVertexVertexInstances_OutVertexInstanceIDs_PropertyAddress;

	private static int GetVertexVertexInstances_OutVertexInstanceIDs_Offset;

	private static bool GetVertexPosition_IsValid;

	private static IntPtr GetVertexPosition_FunctionAddress;

	private static int GetVertexPosition_ParamsSize;

	private static bool GetVertexPosition_VertexID_IsValid;

	private static FFieldAddress GetVertexPosition_VertexID_PropertyAddress;

	private static int GetVertexPosition_VertexID_Offset;

	private static bool GetVertexPosition_ReturnValue_IsValid;

	private static FFieldAddress GetVertexPosition_ReturnValue_PropertyAddress;

	private static int GetVertexPosition_ReturnValue_Offset;

	private static bool GetVertexPairEdge_IsValid;

	private static IntPtr GetVertexPairEdge_FunctionAddress;

	private static int GetVertexPairEdge_ParamsSize;

	private static bool GetVertexPairEdge_VertexID0_IsValid;

	private static FFieldAddress GetVertexPairEdge_VertexID0_PropertyAddress;

	private static int GetVertexPairEdge_VertexID0_Offset;

	private static bool GetVertexPairEdge_VertexID1_IsValid;

	private static FFieldAddress GetVertexPairEdge_VertexID1_PropertyAddress;

	private static int GetVertexPairEdge_VertexID1_Offset;

	private static bool GetVertexPairEdge_ReturnValue_IsValid;

	private static FFieldAddress GetVertexPairEdge_ReturnValue_PropertyAddress;

	private static int GetVertexPairEdge_ReturnValue_Offset;

	private static bool GetVertexInstanceVertex_IsValid;

	private static IntPtr GetVertexInstanceVertex_FunctionAddress;

	private static int GetVertexInstanceVertex_ParamsSize;

	private static bool GetVertexInstanceVertex_VertexInstanceID_IsValid;

	private static FFieldAddress GetVertexInstanceVertex_VertexInstanceID_PropertyAddress;

	private static int GetVertexInstanceVertex_VertexInstanceID_Offset;

	private static bool GetVertexInstanceVertex_ReturnValue_IsValid;

	private static FFieldAddress GetVertexInstanceVertex_ReturnValue_PropertyAddress;

	private static int GetVertexInstanceVertex_ReturnValue_Offset;

	private static bool GetVertexInstancePairEdge_IsValid;

	private static IntPtr GetVertexInstancePairEdge_FunctionAddress;

	private static int GetVertexInstancePairEdge_ParamsSize;

	private static bool GetVertexInstancePairEdge_VertexInstanceID0_IsValid;

	private static FFieldAddress GetVertexInstancePairEdge_VertexInstanceID0_PropertyAddress;

	private static int GetVertexInstancePairEdge_VertexInstanceID0_Offset;

	private static bool GetVertexInstancePairEdge_VertexInstanceID1_IsValid;

	private static FFieldAddress GetVertexInstancePairEdge_VertexInstanceID1_PropertyAddress;

	private static int GetVertexInstancePairEdge_VertexInstanceID1_Offset;

	private static bool GetVertexInstancePairEdge_ReturnValue_IsValid;

	private static FFieldAddress GetVertexInstancePairEdge_ReturnValue_PropertyAddress;

	private static int GetVertexInstancePairEdge_ReturnValue_Offset;

	private static bool GetVertexInstanceForTriangleVertex_IsValid;

	private static IntPtr GetVertexInstanceForTriangleVertex_FunctionAddress;

	private static int GetVertexInstanceForTriangleVertex_ParamsSize;

	private static bool GetVertexInstanceForTriangleVertex_TriangleID_IsValid;

	private static FFieldAddress GetVertexInstanceForTriangleVertex_TriangleID_PropertyAddress;

	private static int GetVertexInstanceForTriangleVertex_TriangleID_Offset;

	private static bool GetVertexInstanceForTriangleVertex_VertexID_IsValid;

	private static FFieldAddress GetVertexInstanceForTriangleVertex_VertexID_PropertyAddress;

	private static int GetVertexInstanceForTriangleVertex_VertexID_Offset;

	private static bool GetVertexInstanceForTriangleVertex_ReturnValue_IsValid;

	private static FFieldAddress GetVertexInstanceForTriangleVertex_ReturnValue_PropertyAddress;

	private static int GetVertexInstanceForTriangleVertex_ReturnValue_Offset;

	private static bool GetVertexInstanceForPolygonVertex_IsValid;

	private static IntPtr GetVertexInstanceForPolygonVertex_FunctionAddress;

	private static int GetVertexInstanceForPolygonVertex_ParamsSize;

	private static bool GetVertexInstanceForPolygonVertex_PolygonID_IsValid;

	private static FFieldAddress GetVertexInstanceForPolygonVertex_PolygonID_PropertyAddress;

	private static int GetVertexInstanceForPolygonVertex_PolygonID_Offset;

	private static bool GetVertexInstanceForPolygonVertex_VertexID_IsValid;

	private static FFieldAddress GetVertexInstanceForPolygonVertex_VertexID_PropertyAddress;

	private static int GetVertexInstanceForPolygonVertex_VertexID_Offset;

	private static bool GetVertexInstanceForPolygonVertex_ReturnValue_IsValid;

	private static FFieldAddress GetVertexInstanceForPolygonVertex_ReturnValue_PropertyAddress;

	private static int GetVertexInstanceForPolygonVertex_ReturnValue_Offset;

	private static bool GetVertexInstanceCount_IsValid;

	private static IntPtr GetVertexInstanceCount_FunctionAddress;

	private static int GetVertexInstanceCount_ParamsSize;

	private static bool GetVertexInstanceCount_ReturnValue_IsValid;

	private static FFieldAddress GetVertexInstanceCount_ReturnValue_PropertyAddress;

	private static int GetVertexInstanceCount_ReturnValue_Offset;

	private static bool GetVertexInstanceConnectedTriangles_IsValid;

	private static IntPtr GetVertexInstanceConnectedTriangles_FunctionAddress;

	private static int GetVertexInstanceConnectedTriangles_ParamsSize;

	private static bool GetVertexInstanceConnectedTriangles_VertexInstanceID_IsValid;

	private static FFieldAddress GetVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress;

	private static int GetVertexInstanceConnectedTriangles_VertexInstanceID_Offset;

	private static bool GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_IsValid;

	private static FFieldAddress GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress;

	private static int GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_Offset;

	private static bool GetVertexInstanceConnectedPolygons_IsValid;

	private static IntPtr GetVertexInstanceConnectedPolygons_FunctionAddress;

	private static int GetVertexInstanceConnectedPolygons_ParamsSize;

	private static bool GetVertexInstanceConnectedPolygons_VertexInstanceID_IsValid;

	private static FFieldAddress GetVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress;

	private static int GetVertexInstanceConnectedPolygons_VertexInstanceID_Offset;

	private static bool GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_IsValid;

	private static FFieldAddress GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress;

	private static int GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_Offset;

	private static bool GetVertexCount_IsValid;

	private static IntPtr GetVertexCount_FunctionAddress;

	private static int GetVertexCount_ParamsSize;

	private static bool GetVertexCount_ReturnValue_IsValid;

	private static FFieldAddress GetVertexCount_ReturnValue_PropertyAddress;

	private static int GetVertexCount_ReturnValue_Offset;

	private static bool GetVertexConnectedTriangles_IsValid;

	private static IntPtr GetVertexConnectedTriangles_FunctionAddress;

	private static int GetVertexConnectedTriangles_ParamsSize;

	private static bool GetVertexConnectedTriangles_VertexID_IsValid;

	private static FFieldAddress GetVertexConnectedTriangles_VertexID_PropertyAddress;

	private static int GetVertexConnectedTriangles_VertexID_Offset;

	private static bool GetVertexConnectedTriangles_OutConnectedTriangleIDs_IsValid;

	private static FFieldAddress GetVertexConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress;

	private static int GetVertexConnectedTriangles_OutConnectedTriangleIDs_Offset;

	private static bool GetVertexConnectedPolygons_IsValid;

	private static IntPtr GetVertexConnectedPolygons_FunctionAddress;

	private static int GetVertexConnectedPolygons_ParamsSize;

	private static bool GetVertexConnectedPolygons_VertexID_IsValid;

	private static FFieldAddress GetVertexConnectedPolygons_VertexID_PropertyAddress;

	private static int GetVertexConnectedPolygons_VertexID_Offset;

	private static bool GetVertexConnectedPolygons_OutConnectedPolygonIDs_IsValid;

	private static FFieldAddress GetVertexConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress;

	private static int GetVertexConnectedPolygons_OutConnectedPolygonIDs_Offset;

	private static bool GetVertexConnectedEdges_IsValid;

	private static IntPtr GetVertexConnectedEdges_FunctionAddress;

	private static int GetVertexConnectedEdges_ParamsSize;

	private static bool GetVertexConnectedEdges_VertexID_IsValid;

	private static FFieldAddress GetVertexConnectedEdges_VertexID_PropertyAddress;

	private static int GetVertexConnectedEdges_VertexID_Offset;

	private static bool GetVertexConnectedEdges_OutEdgeIDs_IsValid;

	private static FFieldAddress GetVertexConnectedEdges_OutEdgeIDs_PropertyAddress;

	private static int GetVertexConnectedEdges_OutEdgeIDs_Offset;

	private static bool GetVertexAdjacentVertices_IsValid;

	private static IntPtr GetVertexAdjacentVertices_FunctionAddress;

	private static int GetVertexAdjacentVertices_ParamsSize;

	private static bool GetVertexAdjacentVertices_VertexID_IsValid;

	private static FFieldAddress GetVertexAdjacentVertices_VertexID_PropertyAddress;

	private static int GetVertexAdjacentVertices_VertexID_Offset;

	private static bool GetVertexAdjacentVertices_OutAdjacentVertexIDs_IsValid;

	private static FFieldAddress GetVertexAdjacentVertices_OutAdjacentVertexIDs_PropertyAddress;

	private static int GetVertexAdjacentVertices_OutAdjacentVertexIDs_Offset;

	private static bool GetTriangleVertices_IsValid;

	private static IntPtr GetTriangleVertices_FunctionAddress;

	private static int GetTriangleVertices_ParamsSize;

	private static bool GetTriangleVertices_TriangleID_IsValid;

	private static FFieldAddress GetTriangleVertices_TriangleID_PropertyAddress;

	private static int GetTriangleVertices_TriangleID_Offset;

	private static bool GetTriangleVertices_OutVertexIDs_IsValid;

	private static FFieldAddress GetTriangleVertices_OutVertexIDs_PropertyAddress;

	private static int GetTriangleVertices_OutVertexIDs_Offset;

	private static bool GetTriangleVertexInstances_IsValid;

	private static IntPtr GetTriangleVertexInstances_FunctionAddress;

	private static int GetTriangleVertexInstances_ParamsSize;

	private static bool GetTriangleVertexInstances_TriangleID_IsValid;

	private static FFieldAddress GetTriangleVertexInstances_TriangleID_PropertyAddress;

	private static int GetTriangleVertexInstances_TriangleID_Offset;

	private static bool GetTriangleVertexInstances_OutVertexInstanceIDs_IsValid;

	private static FFieldAddress GetTriangleVertexInstances_OutVertexInstanceIDs_PropertyAddress;

	private static int GetTriangleVertexInstances_OutVertexInstanceIDs_Offset;

	private static bool GetTriangleVertexInstance_IsValid;

	private static IntPtr GetTriangleVertexInstance_FunctionAddress;

	private static int GetTriangleVertexInstance_ParamsSize;

	private static bool GetTriangleVertexInstance_TriangleID_IsValid;

	private static FFieldAddress GetTriangleVertexInstance_TriangleID_PropertyAddress;

	private static int GetTriangleVertexInstance_TriangleID_Offset;

	private static bool GetTriangleVertexInstance_Index_IsValid;

	private static FFieldAddress GetTriangleVertexInstance_Index_PropertyAddress;

	private static int GetTriangleVertexInstance_Index_Offset;

	private static bool GetTriangleVertexInstance_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleVertexInstance_ReturnValue_PropertyAddress;

	private static int GetTriangleVertexInstance_ReturnValue_Offset;

	private static bool GetTrianglePolygonGroup_IsValid;

	private static IntPtr GetTrianglePolygonGroup_FunctionAddress;

	private static int GetTrianglePolygonGroup_ParamsSize;

	private static bool GetTrianglePolygonGroup_TriangleID_IsValid;

	private static FFieldAddress GetTrianglePolygonGroup_TriangleID_PropertyAddress;

	private static int GetTrianglePolygonGroup_TriangleID_Offset;

	private static bool GetTrianglePolygonGroup_ReturnValue_IsValid;

	private static FFieldAddress GetTrianglePolygonGroup_ReturnValue_PropertyAddress;

	private static int GetTrianglePolygonGroup_ReturnValue_Offset;

	private static bool GetTrianglePolygon_IsValid;

	private static IntPtr GetTrianglePolygon_FunctionAddress;

	private static int GetTrianglePolygon_ParamsSize;

	private static bool GetTrianglePolygon_TriangleID_IsValid;

	private static FFieldAddress GetTrianglePolygon_TriangleID_PropertyAddress;

	private static int GetTrianglePolygon_TriangleID_Offset;

	private static bool GetTrianglePolygon_ReturnValue_IsValid;

	private static FFieldAddress GetTrianglePolygon_ReturnValue_PropertyAddress;

	private static int GetTrianglePolygon_ReturnValue_Offset;

	private static bool GetTriangleEdges_IsValid;

	private static IntPtr GetTriangleEdges_FunctionAddress;

	private static int GetTriangleEdges_ParamsSize;

	private static bool GetTriangleEdges_TriangleID_IsValid;

	private static FFieldAddress GetTriangleEdges_TriangleID_PropertyAddress;

	private static int GetTriangleEdges_TriangleID_Offset;

	private static bool GetTriangleEdges_OutEdgeIDs_IsValid;

	private static FFieldAddress GetTriangleEdges_OutEdgeIDs_PropertyAddress;

	private static int GetTriangleEdges_OutEdgeIDs_Offset;

	private static bool GetTriangleCount_IsValid;

	private static IntPtr GetTriangleCount_FunctionAddress;

	private static int GetTriangleCount_ParamsSize;

	private static bool GetTriangleCount_ReturnValue_IsValid;

	private static FFieldAddress GetTriangleCount_ReturnValue_PropertyAddress;

	private static int GetTriangleCount_ReturnValue_Offset;

	private static bool GetTriangleAdjacentTriangles_IsValid;

	private static IntPtr GetTriangleAdjacentTriangles_FunctionAddress;

	private static int GetTriangleAdjacentTriangles_ParamsSize;

	private static bool GetTriangleAdjacentTriangles_TriangleID_IsValid;

	private static FFieldAddress GetTriangleAdjacentTriangles_TriangleID_PropertyAddress;

	private static int GetTriangleAdjacentTriangles_TriangleID_Offset;

	private static bool GetTriangleAdjacentTriangles_OutTriangleIDs_IsValid;

	private static FFieldAddress GetTriangleAdjacentTriangles_OutTriangleIDs_PropertyAddress;

	private static int GetTriangleAdjacentTriangles_OutTriangleIDs_Offset;

	private static bool GetPolygonVertices_IsValid;

	private static IntPtr GetPolygonVertices_FunctionAddress;

	private static int GetPolygonVertices_ParamsSize;

	private static bool GetPolygonVertices_PolygonID_IsValid;

	private static FFieldAddress GetPolygonVertices_PolygonID_PropertyAddress;

	private static int GetPolygonVertices_PolygonID_Offset;

	private static bool GetPolygonVertices_OutVertexIDs_IsValid;

	private static FFieldAddress GetPolygonVertices_OutVertexIDs_PropertyAddress;

	private static int GetPolygonVertices_OutVertexIDs_Offset;

	private static bool GetPolygonVertexInstances_IsValid;

	private static IntPtr GetPolygonVertexInstances_FunctionAddress;

	private static int GetPolygonVertexInstances_ParamsSize;

	private static bool GetPolygonVertexInstances_PolygonID_IsValid;

	private static FFieldAddress GetPolygonVertexInstances_PolygonID_PropertyAddress;

	private static int GetPolygonVertexInstances_PolygonID_Offset;

	private static bool GetPolygonVertexInstances_OutVertexInstanceIDs_IsValid;

	private static FFieldAddress GetPolygonVertexInstances_OutVertexInstanceIDs_PropertyAddress;

	private static int GetPolygonVertexInstances_OutVertexInstanceIDs_Offset;

	private static bool GetPolygonTriangles_IsValid;

	private static IntPtr GetPolygonTriangles_FunctionAddress;

	private static int GetPolygonTriangles_ParamsSize;

	private static bool GetPolygonTriangles_PolygonID_IsValid;

	private static FFieldAddress GetPolygonTriangles_PolygonID_PropertyAddress;

	private static int GetPolygonTriangles_PolygonID_Offset;

	private static bool GetPolygonTriangles_OutTriangleIDs_IsValid;

	private static FFieldAddress GetPolygonTriangles_OutTriangleIDs_PropertyAddress;

	private static int GetPolygonTriangles_OutTriangleIDs_Offset;

	private static bool GetPolygonPolygonGroup_IsValid;

	private static IntPtr GetPolygonPolygonGroup_FunctionAddress;

	private static int GetPolygonPolygonGroup_ParamsSize;

	private static bool GetPolygonPolygonGroup_PolygonID_IsValid;

	private static FFieldAddress GetPolygonPolygonGroup_PolygonID_PropertyAddress;

	private static int GetPolygonPolygonGroup_PolygonID_Offset;

	private static bool GetPolygonPolygonGroup_ReturnValue_IsValid;

	private static FFieldAddress GetPolygonPolygonGroup_ReturnValue_PropertyAddress;

	private static int GetPolygonPolygonGroup_ReturnValue_Offset;

	private static bool GetPolygonPerimeterEdges_IsValid;

	private static IntPtr GetPolygonPerimeterEdges_FunctionAddress;

	private static int GetPolygonPerimeterEdges_ParamsSize;

	private static bool GetPolygonPerimeterEdges_PolygonID_IsValid;

	private static FFieldAddress GetPolygonPerimeterEdges_PolygonID_PropertyAddress;

	private static int GetPolygonPerimeterEdges_PolygonID_Offset;

	private static bool GetPolygonPerimeterEdges_OutEdgeIDs_IsValid;

	private static FFieldAddress GetPolygonPerimeterEdges_OutEdgeIDs_PropertyAddress;

	private static int GetPolygonPerimeterEdges_OutEdgeIDs_Offset;

	private static bool GetPolygonInternalEdges_IsValid;

	private static IntPtr GetPolygonInternalEdges_FunctionAddress;

	private static int GetPolygonInternalEdges_ParamsSize;

	private static bool GetPolygonInternalEdges_PolygonID_IsValid;

	private static FFieldAddress GetPolygonInternalEdges_PolygonID_PropertyAddress;

	private static int GetPolygonInternalEdges_PolygonID_Offset;

	private static bool GetPolygonInternalEdges_OutEdgeIDs_IsValid;

	private static FFieldAddress GetPolygonInternalEdges_OutEdgeIDs_PropertyAddress;

	private static int GetPolygonInternalEdges_OutEdgeIDs_Offset;

	private static bool GetPolygonGroupPolygons_IsValid;

	private static IntPtr GetPolygonGroupPolygons_FunctionAddress;

	private static int GetPolygonGroupPolygons_ParamsSize;

	private static bool GetPolygonGroupPolygons_PolygonGroupID_IsValid;

	private static FFieldAddress GetPolygonGroupPolygons_PolygonGroupID_PropertyAddress;

	private static int GetPolygonGroupPolygons_PolygonGroupID_Offset;

	private static bool GetPolygonGroupPolygons_OutPolygonIDs_IsValid;

	private static FFieldAddress GetPolygonGroupPolygons_OutPolygonIDs_PropertyAddress;

	private static int GetPolygonGroupPolygons_OutPolygonIDs_Offset;

	private static bool GetPolygonGroupCount_IsValid;

	private static IntPtr GetPolygonGroupCount_FunctionAddress;

	private static int GetPolygonGroupCount_ParamsSize;

	private static bool GetPolygonGroupCount_ReturnValue_IsValid;

	private static FFieldAddress GetPolygonGroupCount_ReturnValue_PropertyAddress;

	private static int GetPolygonGroupCount_ReturnValue_Offset;

	private static bool GetPolygonCount_IsValid;

	private static IntPtr GetPolygonCount_FunctionAddress;

	private static int GetPolygonCount_ParamsSize;

	private static bool GetPolygonCount_ReturnValue_IsValid;

	private static FFieldAddress GetPolygonCount_ReturnValue_PropertyAddress;

	private static int GetPolygonCount_ReturnValue_Offset;

	private static bool GetPolygonAdjacentPolygons_IsValid;

	private static IntPtr GetPolygonAdjacentPolygons_FunctionAddress;

	private static int GetPolygonAdjacentPolygons_ParamsSize;

	private static bool GetPolygonAdjacentPolygons_PolygonID_IsValid;

	private static FFieldAddress GetPolygonAdjacentPolygons_PolygonID_PropertyAddress;

	private static int GetPolygonAdjacentPolygons_PolygonID_Offset;

	private static bool GetPolygonAdjacentPolygons_OutPolygonIDs_IsValid;

	private static FFieldAddress GetPolygonAdjacentPolygons_OutPolygonIDs_PropertyAddress;

	private static int GetPolygonAdjacentPolygons_OutPolygonIDs_Offset;

	private static bool GetNumVertexVertexInstances_IsValid;

	private static IntPtr GetNumVertexVertexInstances_FunctionAddress;

	private static int GetNumVertexVertexInstances_ParamsSize;

	private static bool GetNumVertexVertexInstances_VertexID_IsValid;

	private static FFieldAddress GetNumVertexVertexInstances_VertexID_PropertyAddress;

	private static int GetNumVertexVertexInstances_VertexID_Offset;

	private static bool GetNumVertexVertexInstances_ReturnValue_IsValid;

	private static FFieldAddress GetNumVertexVertexInstances_ReturnValue_PropertyAddress;

	private static int GetNumVertexVertexInstances_ReturnValue_Offset;

	private static bool GetNumVertexInstanceConnectedTriangles_IsValid;

	private static IntPtr GetNumVertexInstanceConnectedTriangles_FunctionAddress;

	private static int GetNumVertexInstanceConnectedTriangles_ParamsSize;

	private static bool GetNumVertexInstanceConnectedTriangles_VertexInstanceID_IsValid;

	private static FFieldAddress GetNumVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress;

	private static int GetNumVertexInstanceConnectedTriangles_VertexInstanceID_Offset;

	private static bool GetNumVertexInstanceConnectedTriangles_ReturnValue_IsValid;

	private static FFieldAddress GetNumVertexInstanceConnectedTriangles_ReturnValue_PropertyAddress;

	private static int GetNumVertexInstanceConnectedTriangles_ReturnValue_Offset;

	private static bool GetNumVertexInstanceConnectedPolygons_IsValid;

	private static IntPtr GetNumVertexInstanceConnectedPolygons_FunctionAddress;

	private static int GetNumVertexInstanceConnectedPolygons_ParamsSize;

	private static bool GetNumVertexInstanceConnectedPolygons_VertexInstanceID_IsValid;

	private static FFieldAddress GetNumVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress;

	private static int GetNumVertexInstanceConnectedPolygons_VertexInstanceID_Offset;

	private static bool GetNumVertexInstanceConnectedPolygons_ReturnValue_IsValid;

	private static FFieldAddress GetNumVertexInstanceConnectedPolygons_ReturnValue_PropertyAddress;

	private static int GetNumVertexInstanceConnectedPolygons_ReturnValue_Offset;

	private static bool GetNumVertexConnectedTriangles_IsValid;

	private static IntPtr GetNumVertexConnectedTriangles_FunctionAddress;

	private static int GetNumVertexConnectedTriangles_ParamsSize;

	private static bool GetNumVertexConnectedTriangles_VertexID_IsValid;

	private static FFieldAddress GetNumVertexConnectedTriangles_VertexID_PropertyAddress;

	private static int GetNumVertexConnectedTriangles_VertexID_Offset;

	private static bool GetNumVertexConnectedTriangles_ReturnValue_IsValid;

	private static FFieldAddress GetNumVertexConnectedTriangles_ReturnValue_PropertyAddress;

	private static int GetNumVertexConnectedTriangles_ReturnValue_Offset;

	private static bool GetNumVertexConnectedPolygons_IsValid;

	private static IntPtr GetNumVertexConnectedPolygons_FunctionAddress;

	private static int GetNumVertexConnectedPolygons_ParamsSize;

	private static bool GetNumVertexConnectedPolygons_VertexID_IsValid;

	private static FFieldAddress GetNumVertexConnectedPolygons_VertexID_PropertyAddress;

	private static int GetNumVertexConnectedPolygons_VertexID_Offset;

	private static bool GetNumVertexConnectedPolygons_ReturnValue_IsValid;

	private static FFieldAddress GetNumVertexConnectedPolygons_ReturnValue_PropertyAddress;

	private static int GetNumVertexConnectedPolygons_ReturnValue_Offset;

	private static bool GetNumVertexConnectedEdges_IsValid;

	private static IntPtr GetNumVertexConnectedEdges_FunctionAddress;

	private static int GetNumVertexConnectedEdges_ParamsSize;

	private static bool GetNumVertexConnectedEdges_VertexID_IsValid;

	private static FFieldAddress GetNumVertexConnectedEdges_VertexID_PropertyAddress;

	private static int GetNumVertexConnectedEdges_VertexID_Offset;

	private static bool GetNumVertexConnectedEdges_ReturnValue_IsValid;

	private static FFieldAddress GetNumVertexConnectedEdges_ReturnValue_PropertyAddress;

	private static int GetNumVertexConnectedEdges_ReturnValue_Offset;

	private static bool GetNumPolygonVertices_IsValid;

	private static IntPtr GetNumPolygonVertices_FunctionAddress;

	private static int GetNumPolygonVertices_ParamsSize;

	private static bool GetNumPolygonVertices_PolygonID_IsValid;

	private static FFieldAddress GetNumPolygonVertices_PolygonID_PropertyAddress;

	private static int GetNumPolygonVertices_PolygonID_Offset;

	private static bool GetNumPolygonVertices_ReturnValue_IsValid;

	private static FFieldAddress GetNumPolygonVertices_ReturnValue_PropertyAddress;

	private static int GetNumPolygonVertices_ReturnValue_Offset;

	private static bool GetNumPolygonTriangles_IsValid;

	private static IntPtr GetNumPolygonTriangles_FunctionAddress;

	private static int GetNumPolygonTriangles_ParamsSize;

	private static bool GetNumPolygonTriangles_PolygonID_IsValid;

	private static FFieldAddress GetNumPolygonTriangles_PolygonID_PropertyAddress;

	private static int GetNumPolygonTriangles_PolygonID_Offset;

	private static bool GetNumPolygonTriangles_ReturnValue_IsValid;

	private static FFieldAddress GetNumPolygonTriangles_ReturnValue_PropertyAddress;

	private static int GetNumPolygonTriangles_ReturnValue_Offset;

	private static bool GetNumPolygonInternalEdges_IsValid;

	private static IntPtr GetNumPolygonInternalEdges_FunctionAddress;

	private static int GetNumPolygonInternalEdges_ParamsSize;

	private static bool GetNumPolygonInternalEdges_PolygonID_IsValid;

	private static FFieldAddress GetNumPolygonInternalEdges_PolygonID_PropertyAddress;

	private static int GetNumPolygonInternalEdges_PolygonID_Offset;

	private static bool GetNumPolygonInternalEdges_ReturnValue_IsValid;

	private static FFieldAddress GetNumPolygonInternalEdges_ReturnValue_PropertyAddress;

	private static int GetNumPolygonInternalEdges_ReturnValue_Offset;

	private static bool GetNumPolygonGroupPolygons_IsValid;

	private static IntPtr GetNumPolygonGroupPolygons_FunctionAddress;

	private static int GetNumPolygonGroupPolygons_ParamsSize;

	private static bool GetNumPolygonGroupPolygons_PolygonGroupID_IsValid;

	private static FFieldAddress GetNumPolygonGroupPolygons_PolygonGroupID_PropertyAddress;

	private static int GetNumPolygonGroupPolygons_PolygonGroupID_Offset;

	private static bool GetNumPolygonGroupPolygons_ReturnValue_IsValid;

	private static FFieldAddress GetNumPolygonGroupPolygons_ReturnValue_PropertyAddress;

	private static int GetNumPolygonGroupPolygons_ReturnValue_Offset;

	private static bool GetNumEdgeConnectedTriangles_IsValid;

	private static IntPtr GetNumEdgeConnectedTriangles_FunctionAddress;

	private static int GetNumEdgeConnectedTriangles_ParamsSize;

	private static bool GetNumEdgeConnectedTriangles_EdgeID_IsValid;

	private static FFieldAddress GetNumEdgeConnectedTriangles_EdgeID_PropertyAddress;

	private static int GetNumEdgeConnectedTriangles_EdgeID_Offset;

	private static bool GetNumEdgeConnectedTriangles_ReturnValue_IsValid;

	private static FFieldAddress GetNumEdgeConnectedTriangles_ReturnValue_PropertyAddress;

	private static int GetNumEdgeConnectedTriangles_ReturnValue_Offset;

	private static bool GetNumEdgeConnectedPolygons_IsValid;

	private static IntPtr GetNumEdgeConnectedPolygons_FunctionAddress;

	private static int GetNumEdgeConnectedPolygons_ParamsSize;

	private static bool GetNumEdgeConnectedPolygons_EdgeID_IsValid;

	private static FFieldAddress GetNumEdgeConnectedPolygons_EdgeID_PropertyAddress;

	private static int GetNumEdgeConnectedPolygons_EdgeID_Offset;

	private static bool GetNumEdgeConnectedPolygons_ReturnValue_IsValid;

	private static FFieldAddress GetNumEdgeConnectedPolygons_ReturnValue_PropertyAddress;

	private static int GetNumEdgeConnectedPolygons_ReturnValue_Offset;

	private static bool GetEdgeVertices_IsValid;

	private static IntPtr GetEdgeVertices_FunctionAddress;

	private static int GetEdgeVertices_ParamsSize;

	private static bool GetEdgeVertices_EdgeID_IsValid;

	private static FFieldAddress GetEdgeVertices_EdgeID_PropertyAddress;

	private static int GetEdgeVertices_EdgeID_Offset;

	private static bool GetEdgeVertices_OutVertexIDs_IsValid;

	private static FFieldAddress GetEdgeVertices_OutVertexIDs_PropertyAddress;

	private static int GetEdgeVertices_OutVertexIDs_Offset;

	private static bool GetEdgeVertex_IsValid;

	private static IntPtr GetEdgeVertex_FunctionAddress;

	private static int GetEdgeVertex_ParamsSize;

	private static bool GetEdgeVertex_EdgeID_IsValid;

	private static FFieldAddress GetEdgeVertex_EdgeID_PropertyAddress;

	private static int GetEdgeVertex_EdgeID_Offset;

	private static bool GetEdgeVertex_VertexNumber_IsValid;

	private static FFieldAddress GetEdgeVertex_VertexNumber_PropertyAddress;

	private static int GetEdgeVertex_VertexNumber_Offset;

	private static bool GetEdgeVertex_ReturnValue_IsValid;

	private static FFieldAddress GetEdgeVertex_ReturnValue_PropertyAddress;

	private static int GetEdgeVertex_ReturnValue_Offset;

	private static bool GetEdgeCount_IsValid;

	private static IntPtr GetEdgeCount_FunctionAddress;

	private static int GetEdgeCount_ParamsSize;

	private static bool GetEdgeCount_ReturnValue_IsValid;

	private static FFieldAddress GetEdgeCount_ReturnValue_PropertyAddress;

	private static int GetEdgeCount_ReturnValue_Offset;

	private static bool GetEdgeConnectedTriangles_IsValid;

	private static IntPtr GetEdgeConnectedTriangles_FunctionAddress;

	private static int GetEdgeConnectedTriangles_ParamsSize;

	private static bool GetEdgeConnectedTriangles_EdgeID_IsValid;

	private static FFieldAddress GetEdgeConnectedTriangles_EdgeID_PropertyAddress;

	private static int GetEdgeConnectedTriangles_EdgeID_Offset;

	private static bool GetEdgeConnectedTriangles_OutConnectedTriangleIDs_IsValid;

	private static FFieldAddress GetEdgeConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress;

	private static int GetEdgeConnectedTriangles_OutConnectedTriangleIDs_Offset;

	private static bool GetEdgeConnectedPolygons_IsValid;

	private static IntPtr GetEdgeConnectedPolygons_FunctionAddress;

	private static int GetEdgeConnectedPolygons_ParamsSize;

	private static bool GetEdgeConnectedPolygons_EdgeID_IsValid;

	private static FFieldAddress GetEdgeConnectedPolygons_EdgeID_PropertyAddress;

	private static int GetEdgeConnectedPolygons_EdgeID_Offset;

	private static bool GetEdgeConnectedPolygons_OutConnectedPolygonIDs_IsValid;

	private static FFieldAddress GetEdgeConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress;

	private static int GetEdgeConnectedPolygons_OutConnectedPolygonIDs_Offset;

	private static bool Empty_IsValid;

	private static IntPtr Empty_FunctionAddress;

	private static int Empty_ParamsSize;

	private static bool DeleteVertexInstance_IsValid;

	private static IntPtr DeleteVertexInstance_FunctionAddress;

	private static int DeleteVertexInstance_ParamsSize;

	private static bool DeleteVertexInstance_VertexInstanceID_IsValid;

	private static FFieldAddress DeleteVertexInstance_VertexInstanceID_PropertyAddress;

	private static int DeleteVertexInstance_VertexInstanceID_Offset;

	private static bool DeleteVertexInstance_OrphanedVertices_IsValid;

	private static FFieldAddress DeleteVertexInstance_OrphanedVertices_PropertyAddress;

	private static int DeleteVertexInstance_OrphanedVertices_Offset;

	private static bool DeleteVertex_IsValid;

	private static IntPtr DeleteVertex_FunctionAddress;

	private static int DeleteVertex_ParamsSize;

	private static bool DeleteVertex_VertexID_IsValid;

	private static FFieldAddress DeleteVertex_VertexID_PropertyAddress;

	private static int DeleteVertex_VertexID_Offset;

	private static bool DeleteTriangle_IsValid;

	private static IntPtr DeleteTriangle_FunctionAddress;

	private static int DeleteTriangle_ParamsSize;

	private static bool DeleteTriangle_TriangleID_IsValid;

	private static FFieldAddress DeleteTriangle_TriangleID_PropertyAddress;

	private static int DeleteTriangle_TriangleID_Offset;

	private static bool DeleteTriangle_OrphanedEdges_IsValid;

	private static FFieldAddress DeleteTriangle_OrphanedEdges_PropertyAddress;

	private static int DeleteTriangle_OrphanedEdges_Offset;

	private static bool DeleteTriangle_OrphanedVertexInstances_IsValid;

	private static FFieldAddress DeleteTriangle_OrphanedVertexInstances_PropertyAddress;

	private static int DeleteTriangle_OrphanedVertexInstances_Offset;

	private static bool DeleteTriangle_OrphanedPolygonGroupsPtr_IsValid;

	private static FFieldAddress DeleteTriangle_OrphanedPolygonGroupsPtr_PropertyAddress;

	private static int DeleteTriangle_OrphanedPolygonGroupsPtr_Offset;

	private static bool DeletePolygonGroup_IsValid;

	private static IntPtr DeletePolygonGroup_FunctionAddress;

	private static int DeletePolygonGroup_ParamsSize;

	private static bool DeletePolygonGroup_PolygonGroupID_IsValid;

	private static FFieldAddress DeletePolygonGroup_PolygonGroupID_PropertyAddress;

	private static int DeletePolygonGroup_PolygonGroupID_Offset;

	private static bool DeletePolygon_IsValid;

	private static IntPtr DeletePolygon_FunctionAddress;

	private static int DeletePolygon_ParamsSize;

	private static bool DeletePolygon_PolygonID_IsValid;

	private static FFieldAddress DeletePolygon_PolygonID_PropertyAddress;

	private static int DeletePolygon_PolygonID_Offset;

	private static bool DeletePolygon_OrphanedEdges_IsValid;

	private static FFieldAddress DeletePolygon_OrphanedEdges_PropertyAddress;

	private static int DeletePolygon_OrphanedEdges_Offset;

	private static bool DeletePolygon_OrphanedVertexInstances_IsValid;

	private static FFieldAddress DeletePolygon_OrphanedVertexInstances_PropertyAddress;

	private static int DeletePolygon_OrphanedVertexInstances_Offset;

	private static bool DeletePolygon_OrphanedPolygonGroups_IsValid;

	private static FFieldAddress DeletePolygon_OrphanedPolygonGroups_PropertyAddress;

	private static int DeletePolygon_OrphanedPolygonGroups_Offset;

	private static bool DeleteEdge_IsValid;

	private static IntPtr DeleteEdge_FunctionAddress;

	private static int DeleteEdge_ParamsSize;

	private static bool DeleteEdge_EdgeID_IsValid;

	private static FFieldAddress DeleteEdge_EdgeID_PropertyAddress;

	private static int DeleteEdge_EdgeID_Offset;

	private static bool DeleteEdge_OrphanedVertices_IsValid;

	private static FFieldAddress DeleteEdge_OrphanedVertices_PropertyAddress;

	private static int DeleteEdge_OrphanedVertices_Offset;

	private static bool CreateVertexWithID_IsValid;

	private static IntPtr CreateVertexWithID_FunctionAddress;

	private static int CreateVertexWithID_ParamsSize;

	private static bool CreateVertexWithID_VertexID_IsValid;

	private static FFieldAddress CreateVertexWithID_VertexID_PropertyAddress;

	private static int CreateVertexWithID_VertexID_Offset;

	private static bool CreateVertexInstanceWithID_IsValid;

	private static IntPtr CreateVertexInstanceWithID_FunctionAddress;

	private static int CreateVertexInstanceWithID_ParamsSize;

	private static bool CreateVertexInstanceWithID_VertexInstanceID_IsValid;

	private static FFieldAddress CreateVertexInstanceWithID_VertexInstanceID_PropertyAddress;

	private static int CreateVertexInstanceWithID_VertexInstanceID_Offset;

	private static bool CreateVertexInstanceWithID_VertexID_IsValid;

	private static FFieldAddress CreateVertexInstanceWithID_VertexID_PropertyAddress;

	private static int CreateVertexInstanceWithID_VertexID_Offset;

	private static bool CreateVertexInstance_IsValid;

	private static IntPtr CreateVertexInstance_FunctionAddress;

	private static int CreateVertexInstance_ParamsSize;

	private static bool CreateVertexInstance_VertexID_IsValid;

	private static FFieldAddress CreateVertexInstance_VertexID_PropertyAddress;

	private static int CreateVertexInstance_VertexID_Offset;

	private static bool CreateVertexInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateVertexInstance_ReturnValue_PropertyAddress;

	private static int CreateVertexInstance_ReturnValue_Offset;

	private static bool CreateVertex_IsValid;

	private static IntPtr CreateVertex_FunctionAddress;

	private static int CreateVertex_ParamsSize;

	private static bool CreateVertex_ReturnValue_IsValid;

	private static FFieldAddress CreateVertex_ReturnValue_PropertyAddress;

	private static int CreateVertex_ReturnValue_Offset;

	private static bool CreateTriangleWithID_IsValid;

	private static IntPtr CreateTriangleWithID_FunctionAddress;

	private static int CreateTriangleWithID_ParamsSize;

	private static bool CreateTriangleWithID_TriangleID_IsValid;

	private static FFieldAddress CreateTriangleWithID_TriangleID_PropertyAddress;

	private static int CreateTriangleWithID_TriangleID_Offset;

	private static bool CreateTriangleWithID_PolygonGroupID_IsValid;

	private static FFieldAddress CreateTriangleWithID_PolygonGroupID_PropertyAddress;

	private static int CreateTriangleWithID_PolygonGroupID_Offset;

	private static bool CreateTriangleWithID_VertexInstanceIDs_IsValid;

	private static FFieldAddress CreateTriangleWithID_VertexInstanceIDs_PropertyAddress;

	private static int CreateTriangleWithID_VertexInstanceIDs_Offset;

	private static bool CreateTriangleWithID_NewEdgeIDs_IsValid;

	private static FFieldAddress CreateTriangleWithID_NewEdgeIDs_PropertyAddress;

	private static int CreateTriangleWithID_NewEdgeIDs_Offset;

	private static bool CreateTriangle_IsValid;

	private static IntPtr CreateTriangle_FunctionAddress;

	private static int CreateTriangle_ParamsSize;

	private static bool CreateTriangle_PolygonGroupID_IsValid;

	private static FFieldAddress CreateTriangle_PolygonGroupID_PropertyAddress;

	private static int CreateTriangle_PolygonGroupID_Offset;

	private static bool CreateTriangle_VertexInstanceIDs_IsValid;

	private static FFieldAddress CreateTriangle_VertexInstanceIDs_PropertyAddress;

	private static int CreateTriangle_VertexInstanceIDs_Offset;

	private static bool CreateTriangle_NewEdgeIDs_IsValid;

	private static FFieldAddress CreateTriangle_NewEdgeIDs_PropertyAddress;

	private static int CreateTriangle_NewEdgeIDs_Offset;

	private static bool CreateTriangle_ReturnValue_IsValid;

	private static FFieldAddress CreateTriangle_ReturnValue_PropertyAddress;

	private static int CreateTriangle_ReturnValue_Offset;

	private static bool CreatePolygonWithID_IsValid;

	private static IntPtr CreatePolygonWithID_FunctionAddress;

	private static int CreatePolygonWithID_ParamsSize;

	private static bool CreatePolygonWithID_PolygonID_IsValid;

	private static FFieldAddress CreatePolygonWithID_PolygonID_PropertyAddress;

	private static int CreatePolygonWithID_PolygonID_Offset;

	private static bool CreatePolygonWithID_PolygonGroupID_IsValid;

	private static FFieldAddress CreatePolygonWithID_PolygonGroupID_PropertyAddress;

	private static int CreatePolygonWithID_PolygonGroupID_Offset;

	private static bool CreatePolygonWithID_VertexInstanceIDs_IsValid;

	private static FFieldAddress CreatePolygonWithID_VertexInstanceIDs_PropertyAddress;

	private static int CreatePolygonWithID_VertexInstanceIDs_Offset;

	private static bool CreatePolygonWithID_NewEdgeIDs_IsValid;

	private static FFieldAddress CreatePolygonWithID_NewEdgeIDs_PropertyAddress;

	private static int CreatePolygonWithID_NewEdgeIDs_Offset;

	private static bool CreatePolygonGroupWithID_IsValid;

	private static IntPtr CreatePolygonGroupWithID_FunctionAddress;

	private static int CreatePolygonGroupWithID_ParamsSize;

	private static bool CreatePolygonGroupWithID_PolygonGroupID_IsValid;

	private static FFieldAddress CreatePolygonGroupWithID_PolygonGroupID_PropertyAddress;

	private static int CreatePolygonGroupWithID_PolygonGroupID_Offset;

	private static bool CreatePolygonGroup_IsValid;

	private static IntPtr CreatePolygonGroup_FunctionAddress;

	private static int CreatePolygonGroup_ParamsSize;

	private static bool CreatePolygonGroup_ReturnValue_IsValid;

	private static FFieldAddress CreatePolygonGroup_ReturnValue_PropertyAddress;

	private static int CreatePolygonGroup_ReturnValue_Offset;

	private static bool CreatePolygon_IsValid;

	private static IntPtr CreatePolygon_FunctionAddress;

	private static int CreatePolygon_ParamsSize;

	private static bool CreatePolygon_PolygonGroupID_IsValid;

	private static FFieldAddress CreatePolygon_PolygonGroupID_PropertyAddress;

	private static int CreatePolygon_PolygonGroupID_Offset;

	private static bool CreatePolygon_VertexInstanceIDs_IsValid;

	private static FFieldAddress CreatePolygon_VertexInstanceIDs_PropertyAddress;

	private static int CreatePolygon_VertexInstanceIDs_Offset;

	private static bool CreatePolygon_NewEdgeIDs_IsValid;

	private static FFieldAddress CreatePolygon_NewEdgeIDs_PropertyAddress;

	private static int CreatePolygon_NewEdgeIDs_Offset;

	private static bool CreatePolygon_ReturnValue_IsValid;

	private static FFieldAddress CreatePolygon_ReturnValue_PropertyAddress;

	private static int CreatePolygon_ReturnValue_Offset;

	private static bool CreateEdgeWithID_IsValid;

	private static IntPtr CreateEdgeWithID_FunctionAddress;

	private static int CreateEdgeWithID_ParamsSize;

	private static bool CreateEdgeWithID_EdgeID_IsValid;

	private static FFieldAddress CreateEdgeWithID_EdgeID_PropertyAddress;

	private static int CreateEdgeWithID_EdgeID_Offset;

	private static bool CreateEdgeWithID_VertexID0_IsValid;

	private static FFieldAddress CreateEdgeWithID_VertexID0_PropertyAddress;

	private static int CreateEdgeWithID_VertexID0_Offset;

	private static bool CreateEdgeWithID_VertexID1_IsValid;

	private static FFieldAddress CreateEdgeWithID_VertexID1_PropertyAddress;

	private static int CreateEdgeWithID_VertexID1_Offset;

	private static bool CreateEdge_IsValid;

	private static IntPtr CreateEdge_FunctionAddress;

	private static int CreateEdge_ParamsSize;

	private static bool CreateEdge_VertexID0_IsValid;

	private static FFieldAddress CreateEdge_VertexID0_PropertyAddress;

	private static int CreateEdge_VertexID0_Offset;

	private static bool CreateEdge_VertexID1_IsValid;

	private static FFieldAddress CreateEdge_VertexID1_PropertyAddress;

	private static int CreateEdge_VertexID1_Offset;

	private static bool CreateEdge_ReturnValue_IsValid;

	private static FFieldAddress CreateEdge_ReturnValue_PropertyAddress;

	private static int CreateEdge_ReturnValue_Offset;

	private static bool ComputePolygonTriangulation_IsValid;

	private static IntPtr ComputePolygonTriangulation_FunctionAddress;

	private static int ComputePolygonTriangulation_ParamsSize;

	private static bool ComputePolygonTriangulation_PolygonID_IsValid;

	private static FFieldAddress ComputePolygonTriangulation_PolygonID_PropertyAddress;

	private static int ComputePolygonTriangulation_PolygonID_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:SetVertexPosition")]
	public unsafe void SetVertexPosition(FVertexID VertexID, FVector Position)
	{
		CheckDestroyed();
		if (!SetVertexPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:SetVertexPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVertexPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVertexPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetVertexPosition_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, SetVertexPosition_VertexID_Offset), 0, SetVertexPosition_VertexID_PropertyAddress.Address, VertexID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVertexPosition_Position_Offset), 0, SetVertexPosition_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVertexPosition_FunctionAddress, intPtr, SetVertexPosition_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:SetPolygonVertexInstances")]
	public unsafe void SetPolygonVertexInstances(FPolygonID PolygonID, List<FVertexInstanceID> VertexInstanceIDs)
	{
		CheckDestroyed();
		if (!SetPolygonVertexInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:SetPolygonVertexInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPolygonVertexInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPolygonVertexInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPolygonVertexInstances_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, SetPolygonVertexInstances_PolygonID_Offset), 0, SetPolygonVertexInstances_PolygonID_PropertyAddress.Address, PolygonID);
		new TArrayCopyMarshaler<FVertexInstanceID>(1, SetPolygonVertexInstances_VertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).ToNative(IntPtr.Add(intPtr, SetPolygonVertexInstances_VertexInstanceIDs_Offset), VertexInstanceIDs);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPolygonVertexInstances_FunctionAddress, intPtr, SetPolygonVertexInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPolygonVertexInstances_VertexInstanceIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:SetPolygonPolygonGroup")]
	public unsafe void SetPolygonPolygonGroup(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID)
	{
		CheckDestroyed();
		if (!SetPolygonPolygonGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:SetPolygonPolygonGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPolygonPolygonGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPolygonPolygonGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPolygonPolygonGroup_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, SetPolygonPolygonGroup_PolygonID_Offset), 0, SetPolygonPolygonGroup_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InitializeValue_InContainer(SetPolygonPolygonGroup_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, SetPolygonPolygonGroup_PolygonGroupID_Offset), 0, SetPolygonPolygonGroup_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPolygonPolygonGroup_FunctionAddress, intPtr, SetPolygonPolygonGroup_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ReversePolygonFacing")]
	public unsafe void ReversePolygonFacing(FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!ReversePolygonFacing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ReversePolygonFacing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReversePolygonFacing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReversePolygonFacing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReversePolygonFacing_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, ReversePolygonFacing_PolygonID_Offset), 0, ReversePolygonFacing_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReversePolygonFacing_FunctionAddress, intPtr, ReversePolygonFacing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ReserveNewVertices")]
	public unsafe void ReserveNewVertices(int NumberOfNewVertices)
	{
		CheckDestroyed();
		if (!ReserveNewVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ReserveNewVertices");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReserveNewVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReserveNewVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReserveNewVertices_NumberOfNewVertices_Offset), 0, ReserveNewVertices_NumberOfNewVertices_PropertyAddress.Address, NumberOfNewVertices);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReserveNewVertices_FunctionAddress, intPtr, ReserveNewVertices_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ReserveNewVertexInstances")]
	public unsafe void ReserveNewVertexInstances(int NumberOfNewVertexInstances)
	{
		CheckDestroyed();
		if (!ReserveNewVertexInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ReserveNewVertexInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReserveNewVertexInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReserveNewVertexInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReserveNewVertexInstances_NumberOfNewVertexInstances_Offset), 0, ReserveNewVertexInstances_NumberOfNewVertexInstances_PropertyAddress.Address, NumberOfNewVertexInstances);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReserveNewVertexInstances_FunctionAddress, intPtr, ReserveNewVertexInstances_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ReserveNewTriangles")]
	public unsafe void ReserveNewTriangles(int NumberOfNewTriangles)
	{
		CheckDestroyed();
		if (!ReserveNewTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ReserveNewTriangles");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReserveNewTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReserveNewTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReserveNewTriangles_NumberOfNewTriangles_Offset), 0, ReserveNewTriangles_NumberOfNewTriangles_PropertyAddress.Address, NumberOfNewTriangles);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReserveNewTriangles_FunctionAddress, intPtr, ReserveNewTriangles_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ReserveNewPolygons")]
	public unsafe void ReserveNewPolygons(int NumberOfNewPolygons)
	{
		CheckDestroyed();
		if (!ReserveNewPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ReserveNewPolygons");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReserveNewPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReserveNewPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReserveNewPolygons_NumberOfNewPolygons_Offset), 0, ReserveNewPolygons_NumberOfNewPolygons_PropertyAddress.Address, NumberOfNewPolygons);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReserveNewPolygons_FunctionAddress, intPtr, ReserveNewPolygons_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ReserveNewPolygonGroups")]
	public unsafe void ReserveNewPolygonGroups(int NumberOfNewPolygonGroups)
	{
		CheckDestroyed();
		if (!ReserveNewPolygonGroups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ReserveNewPolygonGroups");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReserveNewPolygonGroups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReserveNewPolygonGroups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReserveNewPolygonGroups_NumberOfNewPolygonGroups_Offset), 0, ReserveNewPolygonGroups_NumberOfNewPolygonGroups_PropertyAddress.Address, NumberOfNewPolygonGroups);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReserveNewPolygonGroups_FunctionAddress, intPtr, ReserveNewPolygonGroups_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ReserveNewEdges")]
	public unsafe void ReserveNewEdges(int NumberOfNewEdges)
	{
		CheckDestroyed();
		if (!ReserveNewEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ReserveNewEdges");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReserveNewEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReserveNewEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReserveNewEdges_NumberOfNewEdges_Offset), 0, ReserveNewEdges_NumberOfNewEdges_PropertyAddress.Address, NumberOfNewEdges);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReserveNewEdges_FunctionAddress, intPtr, ReserveNewEdges_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsVertexValid")]
	public unsafe bool IsVertexValid(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!IsVertexValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsVertexValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVertexValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVertexValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsVertexValid_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, IsVertexValid_VertexID_Offset), 0, IsVertexValid_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVertexValid_FunctionAddress, intPtr, IsVertexValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVertexValid_ReturnValue_Offset), 0, IsVertexValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsVertexOrphaned")]
	public unsafe bool IsVertexOrphaned(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!IsVertexOrphaned_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsVertexOrphaned");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVertexOrphaned_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVertexOrphaned_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsVertexOrphaned_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, IsVertexOrphaned_VertexID_Offset), 0, IsVertexOrphaned_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVertexOrphaned_FunctionAddress, intPtr, IsVertexOrphaned_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVertexOrphaned_ReturnValue_Offset), 0, IsVertexOrphaned_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsVertexInstanceValid")]
	public unsafe bool IsVertexInstanceValid(FVertexInstanceID VertexInstanceID)
	{
		CheckDestroyed();
		if (!IsVertexInstanceValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsVertexInstanceValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVertexInstanceValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVertexInstanceValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsVertexInstanceValid_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, IsVertexInstanceValid_VertexInstanceID_Offset), 0, IsVertexInstanceValid_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVertexInstanceValid_FunctionAddress, intPtr, IsVertexInstanceValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVertexInstanceValid_ReturnValue_Offset), 0, IsVertexInstanceValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsTriangleValid")]
	public unsafe bool IsTriangleValid(FTriangleID TriangleID)
	{
		CheckDestroyed();
		if (!IsTriangleValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsTriangleValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTriangleValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTriangleValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTriangleValid_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, IsTriangleValid_TriangleID_Offset), 0, IsTriangleValid_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTriangleValid_FunctionAddress, intPtr, IsTriangleValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTriangleValid_ReturnValue_Offset), 0, IsTriangleValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsTrianglePartOfNgon")]
	public unsafe bool IsTrianglePartOfNgon(FTriangleID TriangleID)
	{
		CheckDestroyed();
		if (!IsTrianglePartOfNgon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsTrianglePartOfNgon");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTrianglePartOfNgon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTrianglePartOfNgon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTrianglePartOfNgon_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, IsTrianglePartOfNgon_TriangleID_Offset), 0, IsTrianglePartOfNgon_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTrianglePartOfNgon_FunctionAddress, intPtr, IsTrianglePartOfNgon_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTrianglePartOfNgon_ReturnValue_Offset), 0, IsTrianglePartOfNgon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsPolygonValid")]
	public unsafe bool IsPolygonValid(FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!IsPolygonValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsPolygonValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPolygonValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPolygonValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsPolygonValid_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, IsPolygonValid_PolygonID_Offset), 0, IsPolygonValid_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPolygonValid_FunctionAddress, intPtr, IsPolygonValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPolygonValid_ReturnValue_Offset), 0, IsPolygonValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsPolygonGroupValid")]
	public unsafe bool IsPolygonGroupValid(FPolygonGroupID PolygonGroupID)
	{
		CheckDestroyed();
		if (!IsPolygonGroupValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsPolygonGroupValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPolygonGroupValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPolygonGroupValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsPolygonGroupValid_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, IsPolygonGroupValid_PolygonGroupID_Offset), 0, IsPolygonGroupValid_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPolygonGroupValid_FunctionAddress, intPtr, IsPolygonGroupValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPolygonGroupValid_ReturnValue_Offset), 0, IsPolygonGroupValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsEmpty")]
	public unsafe bool IsEmpty()
	{
		CheckDestroyed();
		if (!IsEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEmpty_FunctionAddress, intPtr, IsEmpty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEmpty_ReturnValue_Offset), 0, IsEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsEdgeValid")]
	public unsafe bool IsEdgeValid(FEdgeID EdgeID)
	{
		CheckDestroyed();
		if (!IsEdgeValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsEdgeValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEdgeValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEdgeValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsEdgeValid_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, IsEdgeValid_EdgeID_Offset), 0, IsEdgeValid_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEdgeValid_FunctionAddress, intPtr, IsEdgeValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEdgeValid_ReturnValue_Offset), 0, IsEdgeValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsEdgeInternalToPolygon")]
	public unsafe bool IsEdgeInternalToPolygon(FEdgeID EdgeID, FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!IsEdgeInternalToPolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsEdgeInternalToPolygon");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEdgeInternalToPolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEdgeInternalToPolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsEdgeInternalToPolygon_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, IsEdgeInternalToPolygon_EdgeID_Offset), 0, IsEdgeInternalToPolygon_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InitializeValue_InContainer(IsEdgeInternalToPolygon_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, IsEdgeInternalToPolygon_PolygonID_Offset), 0, IsEdgeInternalToPolygon_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEdgeInternalToPolygon_FunctionAddress, intPtr, IsEdgeInternalToPolygon_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEdgeInternalToPolygon_ReturnValue_Offset), 0, IsEdgeInternalToPolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:IsEdgeInternal")]
	public unsafe bool IsEdgeInternal(FEdgeID EdgeID)
	{
		CheckDestroyed();
		if (!IsEdgeInternal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:IsEdgeInternal");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEdgeInternal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEdgeInternal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsEdgeInternal_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, IsEdgeInternal_EdgeID_Offset), 0, IsEdgeInternal_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEdgeInternal_FunctionAddress, intPtr, IsEdgeInternal_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEdgeInternal_ReturnValue_Offset), 0, IsEdgeInternal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexVertexInstances")]
	public unsafe void GetVertexVertexInstances(FVertexID VertexID, out List<FVertexInstanceID> OutVertexInstanceIDs)
	{
		CheckDestroyed();
		if (!GetVertexVertexInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexVertexInstances");
			OutVertexInstanceIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexVertexInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexVertexInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexVertexInstances_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexVertexInstances_VertexID_Offset), 0, GetVertexVertexInstances_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexVertexInstances_FunctionAddress, intPtr, GetVertexVertexInstances_ParamsSize);
		OutVertexInstanceIDs = new TArrayCopyMarshaler<FVertexInstanceID>(1, GetVertexVertexInstances_OutVertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).FromNative(IntPtr.Add(intPtr, GetVertexVertexInstances_OutVertexInstanceIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetVertexVertexInstances_OutVertexInstanceIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexPosition")]
	public unsafe FVector GetVertexPosition(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!GetVertexPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexPosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexPosition_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexPosition_VertexID_Offset), 0, GetVertexPosition_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexPosition_FunctionAddress, intPtr, GetVertexPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVertexPosition_ReturnValue_Offset), 0, GetVertexPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexPairEdge")]
	public unsafe FEdgeID GetVertexPairEdge(FVertexID VertexID0, FVertexID VertexID1)
	{
		CheckDestroyed();
		if (!GetVertexPairEdge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexPairEdge");
			return default(FEdgeID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexPairEdge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexPairEdge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexPairEdge_VertexID0_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexPairEdge_VertexID0_Offset), 0, GetVertexPairEdge_VertexID0_PropertyAddress.Address, VertexID0);
		NativeReflection.InitializeValue_InContainer(GetVertexPairEdge_VertexID1_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexPairEdge_VertexID1_Offset), 0, GetVertexPairEdge_VertexID1_PropertyAddress.Address, VertexID1);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexPairEdge_FunctionAddress, intPtr, GetVertexPairEdge_ParamsSize);
		return FEdgeID.FromNative(IntPtr.Add(intPtr, GetVertexPairEdge_ReturnValue_Offset), 0, GetVertexPairEdge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceVertex")]
	public unsafe FVertexID GetVertexInstanceVertex(FVertexInstanceID VertexInstanceID)
	{
		CheckDestroyed();
		if (!GetVertexInstanceVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceVertex");
			return default(FVertexID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstanceVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstanceVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceVertex_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceVertex_VertexInstanceID_Offset), 0, GetVertexInstanceVertex_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstanceVertex_FunctionAddress, intPtr, GetVertexInstanceVertex_ParamsSize);
		return FVertexID.FromNative(IntPtr.Add(intPtr, GetVertexInstanceVertex_ReturnValue_Offset), 0, GetVertexInstanceVertex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstancePairEdge")]
	public unsafe FEdgeID GetVertexInstancePairEdge(FVertexInstanceID VertexInstanceID0, FVertexInstanceID VertexInstanceID1)
	{
		CheckDestroyed();
		if (!GetVertexInstancePairEdge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstancePairEdge");
			return default(FEdgeID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstancePairEdge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstancePairEdge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexInstancePairEdge_VertexInstanceID0_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetVertexInstancePairEdge_VertexInstanceID0_Offset), 0, GetVertexInstancePairEdge_VertexInstanceID0_PropertyAddress.Address, VertexInstanceID0);
		NativeReflection.InitializeValue_InContainer(GetVertexInstancePairEdge_VertexInstanceID1_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetVertexInstancePairEdge_VertexInstanceID1_Offset), 0, GetVertexInstancePairEdge_VertexInstanceID1_PropertyAddress.Address, VertexInstanceID1);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstancePairEdge_FunctionAddress, intPtr, GetVertexInstancePairEdge_ParamsSize);
		return FEdgeID.FromNative(IntPtr.Add(intPtr, GetVertexInstancePairEdge_ReturnValue_Offset), 0, GetVertexInstancePairEdge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceForTriangleVertex")]
	public unsafe FVertexInstanceID GetVertexInstanceForTriangleVertex(FTriangleID TriangleID, FVertexID VertexID)
	{
		CheckDestroyed();
		if (!GetVertexInstanceForTriangleVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceForTriangleVertex");
			return default(FVertexInstanceID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstanceForTriangleVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstanceForTriangleVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceForTriangleVertex_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceForTriangleVertex_TriangleID_Offset), 0, GetVertexInstanceForTriangleVertex_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceForTriangleVertex_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceForTriangleVertex_VertexID_Offset), 0, GetVertexInstanceForTriangleVertex_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstanceForTriangleVertex_FunctionAddress, intPtr, GetVertexInstanceForTriangleVertex_ParamsSize);
		return FVertexInstanceID.FromNative(IntPtr.Add(intPtr, GetVertexInstanceForTriangleVertex_ReturnValue_Offset), 0, GetVertexInstanceForTriangleVertex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceForPolygonVertex")]
	public unsafe FVertexInstanceID GetVertexInstanceForPolygonVertex(FPolygonID PolygonID, FVertexID VertexID)
	{
		CheckDestroyed();
		if (!GetVertexInstanceForPolygonVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceForPolygonVertex");
			return default(FVertexInstanceID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstanceForPolygonVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstanceForPolygonVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceForPolygonVertex_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceForPolygonVertex_PolygonID_Offset), 0, GetVertexInstanceForPolygonVertex_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceForPolygonVertex_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceForPolygonVertex_VertexID_Offset), 0, GetVertexInstanceForPolygonVertex_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstanceForPolygonVertex_FunctionAddress, intPtr, GetVertexInstanceForPolygonVertex_ParamsSize);
		return FVertexInstanceID.FromNative(IntPtr.Add(intPtr, GetVertexInstanceForPolygonVertex_ReturnValue_Offset), 0, GetVertexInstanceForPolygonVertex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceCount")]
	public unsafe int GetVertexInstanceCount()
	{
		CheckDestroyed();
		if (!GetVertexInstanceCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstanceCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstanceCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstanceCount_FunctionAddress, intPtr, GetVertexInstanceCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetVertexInstanceCount_ReturnValue_Offset), 0, GetVertexInstanceCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceConnectedTriangles")]
	public unsafe void GetVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID, out List<FTriangleID> OutConnectedTriangleIDs)
	{
		CheckDestroyed();
		if (!GetVertexInstanceConnectedTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceConnectedTriangles");
			OutConnectedTriangleIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstanceConnectedTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstanceConnectedTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceConnectedTriangles_VertexInstanceID_Offset), 0, GetVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstanceConnectedTriangles_FunctionAddress, intPtr, GetVertexInstanceConnectedTriangles_ParamsSize);
		OutConnectedTriangleIDs = new TArrayCopyMarshaler<FTriangleID>(1, GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress, CachedMarshalingDelegates<FTriangleID, FTriangleID>.FromNative, CachedMarshalingDelegates<FTriangleID, FTriangleID>.ToNative).FromNative(IntPtr.Add(intPtr, GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceConnectedPolygons")]
	public unsafe void GetVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID, out List<FPolygonID> OutConnectedPolygonIDs)
	{
		CheckDestroyed();
		if (!GetVertexInstanceConnectedPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceConnectedPolygons");
			OutConnectedPolygonIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexInstanceConnectedPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexInstanceConnectedPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetVertexInstanceConnectedPolygons_VertexInstanceID_Offset), 0, GetVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexInstanceConnectedPolygons_FunctionAddress, intPtr, GetVertexInstanceConnectedPolygons_ParamsSize);
		OutConnectedPolygonIDs = new TArrayCopyMarshaler<FPolygonID>(1, GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress, CachedMarshalingDelegates<FPolygonID, FPolygonID>.FromNative, CachedMarshalingDelegates<FPolygonID, FPolygonID>.ToNative).FromNative(IntPtr.Add(intPtr, GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexCount")]
	public unsafe int GetVertexCount()
	{
		CheckDestroyed();
		if (!GetVertexCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexCount_FunctionAddress, intPtr, GetVertexCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetVertexCount_ReturnValue_Offset), 0, GetVertexCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedTriangles")]
	public unsafe void GetVertexConnectedTriangles(FVertexID VertexID, out List<FTriangleID> OutConnectedTriangleIDs)
	{
		CheckDestroyed();
		if (!GetVertexConnectedTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedTriangles");
			OutConnectedTriangleIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexConnectedTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexConnectedTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexConnectedTriangles_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexConnectedTriangles_VertexID_Offset), 0, GetVertexConnectedTriangles_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexConnectedTriangles_FunctionAddress, intPtr, GetVertexConnectedTriangles_ParamsSize);
		OutConnectedTriangleIDs = new TArrayCopyMarshaler<FTriangleID>(1, GetVertexConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress, CachedMarshalingDelegates<FTriangleID, FTriangleID>.FromNative, CachedMarshalingDelegates<FTriangleID, FTriangleID>.ToNative).FromNative(IntPtr.Add(intPtr, GetVertexConnectedTriangles_OutConnectedTriangleIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetVertexConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedPolygons")]
	public unsafe void GetVertexConnectedPolygons(FVertexID VertexID, out List<FPolygonID> OutConnectedPolygonIDs)
	{
		CheckDestroyed();
		if (!GetVertexConnectedPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedPolygons");
			OutConnectedPolygonIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexConnectedPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexConnectedPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexConnectedPolygons_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexConnectedPolygons_VertexID_Offset), 0, GetVertexConnectedPolygons_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexConnectedPolygons_FunctionAddress, intPtr, GetVertexConnectedPolygons_ParamsSize);
		OutConnectedPolygonIDs = new TArrayCopyMarshaler<FPolygonID>(1, GetVertexConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress, CachedMarshalingDelegates<FPolygonID, FPolygonID>.FromNative, CachedMarshalingDelegates<FPolygonID, FPolygonID>.ToNative).FromNative(IntPtr.Add(intPtr, GetVertexConnectedPolygons_OutConnectedPolygonIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetVertexConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedEdges")]
	public unsafe void GetVertexConnectedEdges(FVertexID VertexID, out List<FEdgeID> OutEdgeIDs)
	{
		CheckDestroyed();
		if (!GetVertexConnectedEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedEdges");
			OutEdgeIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexConnectedEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexConnectedEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexConnectedEdges_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexConnectedEdges_VertexID_Offset), 0, GetVertexConnectedEdges_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexConnectedEdges_FunctionAddress, intPtr, GetVertexConnectedEdges_ParamsSize);
		OutEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, GetVertexConnectedEdges_OutEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, GetVertexConnectedEdges_OutEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetVertexConnectedEdges_OutEdgeIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetVertexAdjacentVertices")]
	public unsafe void GetVertexAdjacentVertices(FVertexID VertexID, out List<FVertexID> OutAdjacentVertexIDs)
	{
		CheckDestroyed();
		if (!GetVertexAdjacentVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetVertexAdjacentVertices");
			OutAdjacentVertexIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexAdjacentVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexAdjacentVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVertexAdjacentVertices_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetVertexAdjacentVertices_VertexID_Offset), 0, GetVertexAdjacentVertices_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexAdjacentVertices_FunctionAddress, intPtr, GetVertexAdjacentVertices_ParamsSize);
		OutAdjacentVertexIDs = new TArrayCopyMarshaler<FVertexID>(1, GetVertexAdjacentVertices_OutAdjacentVertexIDs_PropertyAddress, CachedMarshalingDelegates<FVertexID, FVertexID>.FromNative, CachedMarshalingDelegates<FVertexID, FVertexID>.ToNative).FromNative(IntPtr.Add(intPtr, GetVertexAdjacentVertices_OutAdjacentVertexIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetVertexAdjacentVertices_OutAdjacentVertexIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertices")]
	public unsafe void GetTriangleVertices(FTriangleID TriangleID, out List<FVertexID> OutVertexIDs)
	{
		CheckDestroyed();
		if (!GetTriangleVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertices");
			OutVertexIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleVertices_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetTriangleVertices_TriangleID_Offset), 0, GetTriangleVertices_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriangleVertices_FunctionAddress, intPtr, GetTriangleVertices_ParamsSize);
		OutVertexIDs = new TArrayCopyMarshaler<FVertexID>(1, GetTriangleVertices_OutVertexIDs_PropertyAddress, CachedMarshalingDelegates<FVertexID, FVertexID>.FromNative, CachedMarshalingDelegates<FVertexID, FVertexID>.ToNative).FromNative(IntPtr.Add(intPtr, GetTriangleVertices_OutVertexIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetTriangleVertices_OutVertexIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertexInstances")]
	public unsafe void GetTriangleVertexInstances(FTriangleID TriangleID, out List<FVertexInstanceID> OutVertexInstanceIDs)
	{
		CheckDestroyed();
		if (!GetTriangleVertexInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertexInstances");
			OutVertexInstanceIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleVertexInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleVertexInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleVertexInstances_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetTriangleVertexInstances_TriangleID_Offset), 0, GetTriangleVertexInstances_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriangleVertexInstances_FunctionAddress, intPtr, GetTriangleVertexInstances_ParamsSize);
		OutVertexInstanceIDs = new TArrayCopyMarshaler<FVertexInstanceID>(1, GetTriangleVertexInstances_OutVertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).FromNative(IntPtr.Add(intPtr, GetTriangleVertexInstances_OutVertexInstanceIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetTriangleVertexInstances_OutVertexInstanceIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertexInstance")]
	public unsafe FVertexInstanceID GetTriangleVertexInstance(FTriangleID TriangleID, int Index)
	{
		CheckDestroyed();
		if (!GetTriangleVertexInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertexInstance");
			return default(FVertexInstanceID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleVertexInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleVertexInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleVertexInstance_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetTriangleVertexInstance_TriangleID_Offset), 0, GetTriangleVertexInstance_TriangleID_PropertyAddress.Address, TriangleID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTriangleVertexInstance_Index_Offset), 0, GetTriangleVertexInstance_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriangleVertexInstance_FunctionAddress, intPtr, GetTriangleVertexInstance_ParamsSize);
		return FVertexInstanceID.FromNative(IntPtr.Add(intPtr, GetTriangleVertexInstance_ReturnValue_Offset), 0, GetTriangleVertexInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTrianglePolygonGroup")]
	public unsafe FPolygonGroupID GetTrianglePolygonGroup(FTriangleID TriangleID)
	{
		CheckDestroyed();
		if (!GetTrianglePolygonGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTrianglePolygonGroup");
			return default(FPolygonGroupID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrianglePolygonGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrianglePolygonGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTrianglePolygonGroup_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetTrianglePolygonGroup_TriangleID_Offset), 0, GetTrianglePolygonGroup_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTrianglePolygonGroup_FunctionAddress, intPtr, GetTrianglePolygonGroup_ParamsSize);
		return FPolygonGroupID.FromNative(IntPtr.Add(intPtr, GetTrianglePolygonGroup_ReturnValue_Offset), 0, GetTrianglePolygonGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTrianglePolygon")]
	public unsafe FPolygonID GetTrianglePolygon(FTriangleID TriangleID)
	{
		CheckDestroyed();
		if (!GetTrianglePolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTrianglePolygon");
			return default(FPolygonID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrianglePolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrianglePolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTrianglePolygon_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetTrianglePolygon_TriangleID_Offset), 0, GetTrianglePolygon_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTrianglePolygon_FunctionAddress, intPtr, GetTrianglePolygon_ParamsSize);
		return FPolygonID.FromNative(IntPtr.Add(intPtr, GetTrianglePolygon_ReturnValue_Offset), 0, GetTrianglePolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTriangleEdges")]
	public unsafe void GetTriangleEdges(FTriangleID TriangleID, out List<FEdgeID> OutEdgeIDs)
	{
		CheckDestroyed();
		if (!GetTriangleEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTriangleEdges");
			OutEdgeIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleEdges_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetTriangleEdges_TriangleID_Offset), 0, GetTriangleEdges_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriangleEdges_FunctionAddress, intPtr, GetTriangleEdges_ParamsSize);
		OutEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, GetTriangleEdges_OutEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, GetTriangleEdges_OutEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetTriangleEdges_OutEdgeIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTriangleCount")]
	public unsafe int GetTriangleCount()
	{
		CheckDestroyed();
		if (!GetTriangleCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTriangleCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriangleCount_FunctionAddress, intPtr, GetTriangleCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTriangleCount_ReturnValue_Offset), 0, GetTriangleCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetTriangleAdjacentTriangles")]
	public unsafe void GetTriangleAdjacentTriangles(FTriangleID TriangleID, out List<FTriangleID> OutTriangleIDs)
	{
		CheckDestroyed();
		if (!GetTriangleAdjacentTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetTriangleAdjacentTriangles");
			OutTriangleIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTriangleAdjacentTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTriangleAdjacentTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTriangleAdjacentTriangles_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, GetTriangleAdjacentTriangles_TriangleID_Offset), 0, GetTriangleAdjacentTriangles_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTriangleAdjacentTriangles_FunctionAddress, intPtr, GetTriangleAdjacentTriangles_ParamsSize);
		OutTriangleIDs = new TArrayCopyMarshaler<FTriangleID>(1, GetTriangleAdjacentTriangles_OutTriangleIDs_PropertyAddress, CachedMarshalingDelegates<FTriangleID, FTriangleID>.FromNative, CachedMarshalingDelegates<FTriangleID, FTriangleID>.ToNative).FromNative(IntPtr.Add(intPtr, GetTriangleAdjacentTriangles_OutTriangleIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetTriangleAdjacentTriangles_OutTriangleIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonVertices")]
	public unsafe void GetPolygonVertices(FPolygonID PolygonID, out List<FVertexID> OutVertexIDs)
	{
		CheckDestroyed();
		if (!GetPolygonVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonVertices");
			OutVertexIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonVertices_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetPolygonVertices_PolygonID_Offset), 0, GetPolygonVertices_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonVertices_FunctionAddress, intPtr, GetPolygonVertices_ParamsSize);
		OutVertexIDs = new TArrayCopyMarshaler<FVertexID>(1, GetPolygonVertices_OutVertexIDs_PropertyAddress, CachedMarshalingDelegates<FVertexID, FVertexID>.FromNative, CachedMarshalingDelegates<FVertexID, FVertexID>.ToNative).FromNative(IntPtr.Add(intPtr, GetPolygonVertices_OutVertexIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetPolygonVertices_OutVertexIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonVertexInstances")]
	public unsafe void GetPolygonVertexInstances(FPolygonID PolygonID, out List<FVertexInstanceID> OutVertexInstanceIDs)
	{
		CheckDestroyed();
		if (!GetPolygonVertexInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonVertexInstances");
			OutVertexInstanceIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonVertexInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonVertexInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonVertexInstances_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetPolygonVertexInstances_PolygonID_Offset), 0, GetPolygonVertexInstances_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonVertexInstances_FunctionAddress, intPtr, GetPolygonVertexInstances_ParamsSize);
		OutVertexInstanceIDs = new TArrayCopyMarshaler<FVertexInstanceID>(1, GetPolygonVertexInstances_OutVertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).FromNative(IntPtr.Add(intPtr, GetPolygonVertexInstances_OutVertexInstanceIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetPolygonVertexInstances_OutVertexInstanceIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonTriangles")]
	public unsafe void GetPolygonTriangles(FPolygonID PolygonID, out List<FTriangleID> OutTriangleIDs)
	{
		CheckDestroyed();
		if (!GetPolygonTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonTriangles");
			OutTriangleIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonTriangles_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetPolygonTriangles_PolygonID_Offset), 0, GetPolygonTriangles_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonTriangles_FunctionAddress, intPtr, GetPolygonTriangles_ParamsSize);
		OutTriangleIDs = new TArrayCopyMarshaler<FTriangleID>(1, GetPolygonTriangles_OutTriangleIDs_PropertyAddress, CachedMarshalingDelegates<FTriangleID, FTriangleID>.FromNative, CachedMarshalingDelegates<FTriangleID, FTriangleID>.ToNative).FromNative(IntPtr.Add(intPtr, GetPolygonTriangles_OutTriangleIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetPolygonTriangles_OutTriangleIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonPolygonGroup")]
	public unsafe FPolygonGroupID GetPolygonPolygonGroup(FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!GetPolygonPolygonGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonPolygonGroup");
			return default(FPolygonGroupID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonPolygonGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonPolygonGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonPolygonGroup_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetPolygonPolygonGroup_PolygonID_Offset), 0, GetPolygonPolygonGroup_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonPolygonGroup_FunctionAddress, intPtr, GetPolygonPolygonGroup_ParamsSize);
		return FPolygonGroupID.FromNative(IntPtr.Add(intPtr, GetPolygonPolygonGroup_ReturnValue_Offset), 0, GetPolygonPolygonGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonPerimeterEdges")]
	public unsafe void GetPolygonPerimeterEdges(FPolygonID PolygonID, out List<FEdgeID> OutEdgeIDs)
	{
		CheckDestroyed();
		if (!GetPolygonPerimeterEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonPerimeterEdges");
			OutEdgeIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonPerimeterEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonPerimeterEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonPerimeterEdges_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetPolygonPerimeterEdges_PolygonID_Offset), 0, GetPolygonPerimeterEdges_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonPerimeterEdges_FunctionAddress, intPtr, GetPolygonPerimeterEdges_ParamsSize);
		OutEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, GetPolygonPerimeterEdges_OutEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, GetPolygonPerimeterEdges_OutEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetPolygonPerimeterEdges_OutEdgeIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonInternalEdges")]
	public unsafe void GetPolygonInternalEdges(FPolygonID PolygonID, out List<FEdgeID> OutEdgeIDs)
	{
		CheckDestroyed();
		if (!GetPolygonInternalEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonInternalEdges");
			OutEdgeIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonInternalEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonInternalEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonInternalEdges_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetPolygonInternalEdges_PolygonID_Offset), 0, GetPolygonInternalEdges_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonInternalEdges_FunctionAddress, intPtr, GetPolygonInternalEdges_ParamsSize);
		OutEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, GetPolygonInternalEdges_OutEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, GetPolygonInternalEdges_OutEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetPolygonInternalEdges_OutEdgeIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonGroupPolygons")]
	public unsafe void GetPolygonGroupPolygons(FPolygonGroupID PolygonGroupID, out List<FPolygonID> OutPolygonIDs)
	{
		CheckDestroyed();
		if (!GetPolygonGroupPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonGroupPolygons");
			OutPolygonIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonGroupPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonGroupPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonGroupPolygons_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, GetPolygonGroupPolygons_PolygonGroupID_Offset), 0, GetPolygonGroupPolygons_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonGroupPolygons_FunctionAddress, intPtr, GetPolygonGroupPolygons_ParamsSize);
		OutPolygonIDs = new TArrayCopyMarshaler<FPolygonID>(1, GetPolygonGroupPolygons_OutPolygonIDs_PropertyAddress, CachedMarshalingDelegates<FPolygonID, FPolygonID>.FromNative, CachedMarshalingDelegates<FPolygonID, FPolygonID>.ToNative).FromNative(IntPtr.Add(intPtr, GetPolygonGroupPolygons_OutPolygonIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetPolygonGroupPolygons_OutPolygonIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonGroupCount")]
	public unsafe int GetPolygonGroupCount()
	{
		CheckDestroyed();
		if (!GetPolygonGroupCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonGroupCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonGroupCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonGroupCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonGroupCount_FunctionAddress, intPtr, GetPolygonGroupCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPolygonGroupCount_ReturnValue_Offset), 0, GetPolygonGroupCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonCount")]
	public unsafe int GetPolygonCount()
	{
		CheckDestroyed();
		if (!GetPolygonCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonCount_FunctionAddress, intPtr, GetPolygonCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPolygonCount_ReturnValue_Offset), 0, GetPolygonCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetPolygonAdjacentPolygons")]
	public unsafe void GetPolygonAdjacentPolygons(FPolygonID PolygonID, out List<FPolygonID> OutPolygonIDs)
	{
		CheckDestroyed();
		if (!GetPolygonAdjacentPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetPolygonAdjacentPolygons");
			OutPolygonIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygonAdjacentPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygonAdjacentPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPolygonAdjacentPolygons_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetPolygonAdjacentPolygons_PolygonID_Offset), 0, GetPolygonAdjacentPolygons_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPolygonAdjacentPolygons_FunctionAddress, intPtr, GetPolygonAdjacentPolygons_ParamsSize);
		OutPolygonIDs = new TArrayCopyMarshaler<FPolygonID>(1, GetPolygonAdjacentPolygons_OutPolygonIDs_PropertyAddress, CachedMarshalingDelegates<FPolygonID, FPolygonID>.FromNative, CachedMarshalingDelegates<FPolygonID, FPolygonID>.ToNative).FromNative(IntPtr.Add(intPtr, GetPolygonAdjacentPolygons_OutPolygonIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetPolygonAdjacentPolygons_OutPolygonIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexVertexInstances")]
	public unsafe int GetNumVertexVertexInstances(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!GetNumVertexVertexInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexVertexInstances");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVertexVertexInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVertexVertexInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumVertexVertexInstances_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetNumVertexVertexInstances_VertexID_Offset), 0, GetNumVertexVertexInstances_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVertexVertexInstances_FunctionAddress, intPtr, GetNumVertexVertexInstances_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVertexVertexInstances_ReturnValue_Offset), 0, GetNumVertexVertexInstances_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexInstanceConnectedTriangles")]
	public unsafe int GetNumVertexInstanceConnectedTriangles(FVertexInstanceID VertexInstanceID)
	{
		CheckDestroyed();
		if (!GetNumVertexInstanceConnectedTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexInstanceConnectedTriangles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVertexInstanceConnectedTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVertexInstanceConnectedTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetNumVertexInstanceConnectedTriangles_VertexInstanceID_Offset), 0, GetNumVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVertexInstanceConnectedTriangles_FunctionAddress, intPtr, GetNumVertexInstanceConnectedTriangles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVertexInstanceConnectedTriangles_ReturnValue_Offset), 0, GetNumVertexInstanceConnectedTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexInstanceConnectedPolygons")]
	public unsafe int GetNumVertexInstanceConnectedPolygons(FVertexInstanceID VertexInstanceID)
	{
		CheckDestroyed();
		if (!GetNumVertexInstanceConnectedPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexInstanceConnectedPolygons");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVertexInstanceConnectedPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVertexInstanceConnectedPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, GetNumVertexInstanceConnectedPolygons_VertexInstanceID_Offset), 0, GetNumVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVertexInstanceConnectedPolygons_FunctionAddress, intPtr, GetNumVertexInstanceConnectedPolygons_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVertexInstanceConnectedPolygons_ReturnValue_Offset), 0, GetNumVertexInstanceConnectedPolygons_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedTriangles")]
	public unsafe int GetNumVertexConnectedTriangles(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!GetNumVertexConnectedTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedTriangles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVertexConnectedTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVertexConnectedTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumVertexConnectedTriangles_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetNumVertexConnectedTriangles_VertexID_Offset), 0, GetNumVertexConnectedTriangles_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVertexConnectedTriangles_FunctionAddress, intPtr, GetNumVertexConnectedTriangles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVertexConnectedTriangles_ReturnValue_Offset), 0, GetNumVertexConnectedTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedPolygons")]
	public unsafe int GetNumVertexConnectedPolygons(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!GetNumVertexConnectedPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedPolygons");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVertexConnectedPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVertexConnectedPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumVertexConnectedPolygons_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetNumVertexConnectedPolygons_VertexID_Offset), 0, GetNumVertexConnectedPolygons_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVertexConnectedPolygons_FunctionAddress, intPtr, GetNumVertexConnectedPolygons_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVertexConnectedPolygons_ReturnValue_Offset), 0, GetNumVertexConnectedPolygons_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedEdges")]
	public unsafe int GetNumVertexConnectedEdges(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!GetNumVertexConnectedEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedEdges");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVertexConnectedEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVertexConnectedEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumVertexConnectedEdges_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, GetNumVertexConnectedEdges_VertexID_Offset), 0, GetNumVertexConnectedEdges_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVertexConnectedEdges_FunctionAddress, intPtr, GetNumVertexConnectedEdges_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVertexConnectedEdges_ReturnValue_Offset), 0, GetNumVertexConnectedEdges_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonVertices")]
	public unsafe int GetNumPolygonVertices(FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!GetNumPolygonVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonVertices");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumPolygonVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumPolygonVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumPolygonVertices_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetNumPolygonVertices_PolygonID_Offset), 0, GetNumPolygonVertices_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumPolygonVertices_FunctionAddress, intPtr, GetNumPolygonVertices_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumPolygonVertices_ReturnValue_Offset), 0, GetNumPolygonVertices_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonTriangles")]
	public unsafe int GetNumPolygonTriangles(FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!GetNumPolygonTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonTriangles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumPolygonTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumPolygonTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumPolygonTriangles_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetNumPolygonTriangles_PolygonID_Offset), 0, GetNumPolygonTriangles_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumPolygonTriangles_FunctionAddress, intPtr, GetNumPolygonTriangles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumPolygonTriangles_ReturnValue_Offset), 0, GetNumPolygonTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonInternalEdges")]
	public unsafe int GetNumPolygonInternalEdges(FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!GetNumPolygonInternalEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonInternalEdges");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumPolygonInternalEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumPolygonInternalEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumPolygonInternalEdges_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, GetNumPolygonInternalEdges_PolygonID_Offset), 0, GetNumPolygonInternalEdges_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumPolygonInternalEdges_FunctionAddress, intPtr, GetNumPolygonInternalEdges_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumPolygonInternalEdges_ReturnValue_Offset), 0, GetNumPolygonInternalEdges_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonGroupPolygons")]
	public unsafe int GetNumPolygonGroupPolygons(FPolygonGroupID PolygonGroupID)
	{
		CheckDestroyed();
		if (!GetNumPolygonGroupPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonGroupPolygons");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumPolygonGroupPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumPolygonGroupPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumPolygonGroupPolygons_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, GetNumPolygonGroupPolygons_PolygonGroupID_Offset), 0, GetNumPolygonGroupPolygons_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumPolygonGroupPolygons_FunctionAddress, intPtr, GetNumPolygonGroupPolygons_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumPolygonGroupPolygons_ReturnValue_Offset), 0, GetNumPolygonGroupPolygons_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumEdgeConnectedTriangles")]
	public unsafe int GetNumEdgeConnectedTriangles(FEdgeID EdgeID)
	{
		CheckDestroyed();
		if (!GetNumEdgeConnectedTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumEdgeConnectedTriangles");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumEdgeConnectedTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumEdgeConnectedTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumEdgeConnectedTriangles_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, GetNumEdgeConnectedTriangles_EdgeID_Offset), 0, GetNumEdgeConnectedTriangles_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumEdgeConnectedTriangles_FunctionAddress, intPtr, GetNumEdgeConnectedTriangles_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumEdgeConnectedTriangles_ReturnValue_Offset), 0, GetNumEdgeConnectedTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetNumEdgeConnectedPolygons")]
	public unsafe int GetNumEdgeConnectedPolygons(FEdgeID EdgeID)
	{
		CheckDestroyed();
		if (!GetNumEdgeConnectedPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetNumEdgeConnectedPolygons");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumEdgeConnectedPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumEdgeConnectedPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumEdgeConnectedPolygons_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, GetNumEdgeConnectedPolygons_EdgeID_Offset), 0, GetNumEdgeConnectedPolygons_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumEdgeConnectedPolygons_FunctionAddress, intPtr, GetNumEdgeConnectedPolygons_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumEdgeConnectedPolygons_ReturnValue_Offset), 0, GetNumEdgeConnectedPolygons_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetEdgeVertices")]
	public unsafe void GetEdgeVertices(FEdgeID EdgeID, out List<FVertexID> OutVertexIDs)
	{
		CheckDestroyed();
		if (!GetEdgeVertices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetEdgeVertices");
			OutVertexIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEdgeVertices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEdgeVertices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEdgeVertices_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, GetEdgeVertices_EdgeID_Offset), 0, GetEdgeVertices_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEdgeVertices_FunctionAddress, intPtr, GetEdgeVertices_ParamsSize);
		OutVertexIDs = new TArrayCopyMarshaler<FVertexID>(1, GetEdgeVertices_OutVertexIDs_PropertyAddress, CachedMarshalingDelegates<FVertexID, FVertexID>.FromNative, CachedMarshalingDelegates<FVertexID, FVertexID>.ToNative).FromNative(IntPtr.Add(intPtr, GetEdgeVertices_OutVertexIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetEdgeVertices_OutVertexIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetEdgeVertex")]
	public unsafe FVertexID GetEdgeVertex(FEdgeID EdgeID, int VertexNumber)
	{
		CheckDestroyed();
		if (!GetEdgeVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetEdgeVertex");
			return default(FVertexID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEdgeVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEdgeVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEdgeVertex_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, GetEdgeVertex_EdgeID_Offset), 0, GetEdgeVertex_EdgeID_PropertyAddress.Address, EdgeID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetEdgeVertex_VertexNumber_Offset), 0, GetEdgeVertex_VertexNumber_PropertyAddress.Address, VertexNumber);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEdgeVertex_FunctionAddress, intPtr, GetEdgeVertex_ParamsSize);
		return FVertexID.FromNative(IntPtr.Add(intPtr, GetEdgeVertex_ReturnValue_Offset), 0, GetEdgeVertex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetEdgeCount")]
	public unsafe int GetEdgeCount()
	{
		CheckDestroyed();
		if (!GetEdgeCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetEdgeCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEdgeCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEdgeCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEdgeCount_FunctionAddress, intPtr, GetEdgeCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetEdgeCount_ReturnValue_Offset), 0, GetEdgeCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetEdgeConnectedTriangles")]
	public unsafe void GetEdgeConnectedTriangles(FEdgeID EdgeID, out List<FTriangleID> OutConnectedTriangleIDs)
	{
		CheckDestroyed();
		if (!GetEdgeConnectedTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetEdgeConnectedTriangles");
			OutConnectedTriangleIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEdgeConnectedTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEdgeConnectedTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEdgeConnectedTriangles_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, GetEdgeConnectedTriangles_EdgeID_Offset), 0, GetEdgeConnectedTriangles_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEdgeConnectedTriangles_FunctionAddress, intPtr, GetEdgeConnectedTriangles_ParamsSize);
		OutConnectedTriangleIDs = new TArrayCopyMarshaler<FTriangleID>(1, GetEdgeConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress, CachedMarshalingDelegates<FTriangleID, FTriangleID>.FromNative, CachedMarshalingDelegates<FTriangleID, FTriangleID>.ToNative).FromNative(IntPtr.Add(intPtr, GetEdgeConnectedTriangles_OutConnectedTriangleIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetEdgeConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:GetEdgeConnectedPolygons")]
	public unsafe void GetEdgeConnectedPolygons(FEdgeID EdgeID, out List<FPolygonID> OutConnectedPolygonIDs)
	{
		CheckDestroyed();
		if (!GetEdgeConnectedPolygons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:GetEdgeConnectedPolygons");
			OutConnectedPolygonIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEdgeConnectedPolygons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEdgeConnectedPolygons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEdgeConnectedPolygons_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, GetEdgeConnectedPolygons_EdgeID_Offset), 0, GetEdgeConnectedPolygons_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEdgeConnectedPolygons_FunctionAddress, intPtr, GetEdgeConnectedPolygons_ParamsSize);
		OutConnectedPolygonIDs = new TArrayCopyMarshaler<FPolygonID>(1, GetEdgeConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress, CachedMarshalingDelegates<FPolygonID, FPolygonID>.FromNative, CachedMarshalingDelegates<FPolygonID, FPolygonID>.ToNative).FromNative(IntPtr.Add(intPtr, GetEdgeConnectedPolygons_OutConnectedPolygonIDs_Offset));
		NativeReflection.DestroyValue_InContainer(GetEdgeConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:Empty")]
	public unsafe void Empty()
	{
		CheckDestroyed();
		if (!Empty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:Empty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Empty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Empty_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Empty_FunctionAddress, argsSize: Empty_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:DeleteVertexInstance")]
	public unsafe void DeleteVertexInstance(FVertexInstanceID VertexInstanceID, out List<FVertexID> OrphanedVertices)
	{
		CheckDestroyed();
		if (!DeleteVertexInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:DeleteVertexInstance");
			OrphanedVertices = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteVertexInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteVertexInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeleteVertexInstance_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, DeleteVertexInstance_VertexInstanceID_Offset), 0, DeleteVertexInstance_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteVertexInstance_FunctionAddress, intPtr, DeleteVertexInstance_ParamsSize);
		OrphanedVertices = new TArrayCopyMarshaler<FVertexID>(1, DeleteVertexInstance_OrphanedVertices_PropertyAddress, CachedMarshalingDelegates<FVertexID, FVertexID>.FromNative, CachedMarshalingDelegates<FVertexID, FVertexID>.ToNative).FromNative(IntPtr.Add(intPtr, DeleteVertexInstance_OrphanedVertices_Offset));
		NativeReflection.DestroyValue_InContainer(DeleteVertexInstance_OrphanedVertices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:DeleteVertex")]
	public unsafe void DeleteVertex(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!DeleteVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:DeleteVertex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeleteVertex_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, DeleteVertex_VertexID_Offset), 0, DeleteVertex_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteVertex_FunctionAddress, intPtr, DeleteVertex_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:DeleteTriangle")]
	public unsafe void DeleteTriangle(FTriangleID TriangleID, out List<FEdgeID> OrphanedEdges, out List<FVertexInstanceID> OrphanedVertexInstances, out List<FPolygonGroupID> OrphanedPolygonGroupsPtr)
	{
		CheckDestroyed();
		if (!DeleteTriangle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:DeleteTriangle");
			OrphanedEdges = null;
			OrphanedVertexInstances = null;
			OrphanedPolygonGroupsPtr = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteTriangle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteTriangle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeleteTriangle_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, DeleteTriangle_TriangleID_Offset), 0, DeleteTriangle_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteTriangle_FunctionAddress, intPtr, DeleteTriangle_ParamsSize);
		OrphanedEdges = new TArrayCopyMarshaler<FEdgeID>(1, DeleteTriangle_OrphanedEdges_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, DeleteTriangle_OrphanedEdges_Offset));
		NativeReflection.DestroyValue_InContainer(DeleteTriangle_OrphanedEdges_PropertyAddress.Address, intPtr);
		OrphanedVertexInstances = new TArrayCopyMarshaler<FVertexInstanceID>(1, DeleteTriangle_OrphanedVertexInstances_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).FromNative(IntPtr.Add(intPtr, DeleteTriangle_OrphanedVertexInstances_Offset));
		NativeReflection.DestroyValue_InContainer(DeleteTriangle_OrphanedVertexInstances_PropertyAddress.Address, intPtr);
		OrphanedPolygonGroupsPtr = new TArrayCopyMarshaler<FPolygonGroupID>(1, DeleteTriangle_OrphanedPolygonGroupsPtr_PropertyAddress, CachedMarshalingDelegates<FPolygonGroupID, FPolygonGroupID>.FromNative, CachedMarshalingDelegates<FPolygonGroupID, FPolygonGroupID>.ToNative).FromNative(IntPtr.Add(intPtr, DeleteTriangle_OrphanedPolygonGroupsPtr_Offset));
		NativeReflection.DestroyValue_InContainer(DeleteTriangle_OrphanedPolygonGroupsPtr_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:DeletePolygonGroup")]
	public unsafe void DeletePolygonGroup(FPolygonGroupID PolygonGroupID)
	{
		CheckDestroyed();
		if (!DeletePolygonGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:DeletePolygonGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeletePolygonGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeletePolygonGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeletePolygonGroup_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, DeletePolygonGroup_PolygonGroupID_Offset), 0, DeletePolygonGroup_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeletePolygonGroup_FunctionAddress, intPtr, DeletePolygonGroup_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:DeletePolygon")]
	public unsafe void DeletePolygon(FPolygonID PolygonID, out List<FEdgeID> OrphanedEdges, out List<FVertexInstanceID> OrphanedVertexInstances, out List<FPolygonGroupID> OrphanedPolygonGroups)
	{
		CheckDestroyed();
		if (!DeletePolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:DeletePolygon");
			OrphanedEdges = null;
			OrphanedVertexInstances = null;
			OrphanedPolygonGroups = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeletePolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeletePolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeletePolygon_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, DeletePolygon_PolygonID_Offset), 0, DeletePolygon_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeletePolygon_FunctionAddress, intPtr, DeletePolygon_ParamsSize);
		OrphanedEdges = new TArrayCopyMarshaler<FEdgeID>(1, DeletePolygon_OrphanedEdges_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, DeletePolygon_OrphanedEdges_Offset));
		NativeReflection.DestroyValue_InContainer(DeletePolygon_OrphanedEdges_PropertyAddress.Address, intPtr);
		OrphanedVertexInstances = new TArrayCopyMarshaler<FVertexInstanceID>(1, DeletePolygon_OrphanedVertexInstances_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).FromNative(IntPtr.Add(intPtr, DeletePolygon_OrphanedVertexInstances_Offset));
		NativeReflection.DestroyValue_InContainer(DeletePolygon_OrphanedVertexInstances_PropertyAddress.Address, intPtr);
		OrphanedPolygonGroups = new TArrayCopyMarshaler<FPolygonGroupID>(1, DeletePolygon_OrphanedPolygonGroups_PropertyAddress, CachedMarshalingDelegates<FPolygonGroupID, FPolygonGroupID>.FromNative, CachedMarshalingDelegates<FPolygonGroupID, FPolygonGroupID>.ToNative).FromNative(IntPtr.Add(intPtr, DeletePolygon_OrphanedPolygonGroups_Offset));
		NativeReflection.DestroyValue_InContainer(DeletePolygon_OrphanedPolygonGroups_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:DeleteEdge")]
	public unsafe void DeleteEdge(FEdgeID EdgeID, out List<FVertexID> OrphanedVertices)
	{
		CheckDestroyed();
		if (!DeleteEdge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:DeleteEdge");
			OrphanedVertices = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteEdge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteEdge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeleteEdge_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, DeleteEdge_EdgeID_Offset), 0, DeleteEdge_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteEdge_FunctionAddress, intPtr, DeleteEdge_ParamsSize);
		OrphanedVertices = new TArrayCopyMarshaler<FVertexID>(1, DeleteEdge_OrphanedVertices_PropertyAddress, CachedMarshalingDelegates<FVertexID, FVertexID>.FromNative, CachedMarshalingDelegates<FVertexID, FVertexID>.ToNative).FromNative(IntPtr.Add(intPtr, DeleteEdge_OrphanedVertices_Offset));
		NativeReflection.DestroyValue_InContainer(DeleteEdge_OrphanedVertices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateVertexWithID")]
	public unsafe void CreateVertexWithID(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!CreateVertexWithID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateVertexWithID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateVertexWithID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateVertexWithID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateVertexWithID_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, CreateVertexWithID_VertexID_Offset), 0, CreateVertexWithID_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateVertexWithID_FunctionAddress, intPtr, CreateVertexWithID_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateVertexInstanceWithID")]
	public unsafe void CreateVertexInstanceWithID(FVertexInstanceID VertexInstanceID, FVertexID VertexID)
	{
		CheckDestroyed();
		if (!CreateVertexInstanceWithID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateVertexInstanceWithID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateVertexInstanceWithID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateVertexInstanceWithID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateVertexInstanceWithID_VertexInstanceID_PropertyAddress.Address, intPtr);
		FVertexInstanceID.ToNative(IntPtr.Add(intPtr, CreateVertexInstanceWithID_VertexInstanceID_Offset), 0, CreateVertexInstanceWithID_VertexInstanceID_PropertyAddress.Address, VertexInstanceID);
		NativeReflection.InitializeValue_InContainer(CreateVertexInstanceWithID_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, CreateVertexInstanceWithID_VertexID_Offset), 0, CreateVertexInstanceWithID_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateVertexInstanceWithID_FunctionAddress, intPtr, CreateVertexInstanceWithID_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateVertexInstance")]
	public unsafe FVertexInstanceID CreateVertexInstance(FVertexID VertexID)
	{
		CheckDestroyed();
		if (!CreateVertexInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateVertexInstance");
			return default(FVertexInstanceID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateVertexInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateVertexInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateVertexInstance_VertexID_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, CreateVertexInstance_VertexID_Offset), 0, CreateVertexInstance_VertexID_PropertyAddress.Address, VertexID);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateVertexInstance_FunctionAddress, intPtr, CreateVertexInstance_ParamsSize);
		return FVertexInstanceID.FromNative(IntPtr.Add(intPtr, CreateVertexInstance_ReturnValue_Offset), 0, CreateVertexInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateVertex")]
	public unsafe FVertexID CreateVertex()
	{
		CheckDestroyed();
		if (!CreateVertex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateVertex");
			return default(FVertexID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateVertex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateVertex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateVertex_FunctionAddress, intPtr, CreateVertex_ParamsSize);
		return FVertexID.FromNative(IntPtr.Add(intPtr, CreateVertex_ReturnValue_Offset), 0, CreateVertex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateTriangleWithID")]
	public unsafe void CreateTriangleWithID(FTriangleID TriangleID, FPolygonGroupID PolygonGroupID, List<FVertexInstanceID> VertexInstanceIDs, out List<FEdgeID> NewEdgeIDs)
	{
		CheckDestroyed();
		if (!CreateTriangleWithID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateTriangleWithID");
			NewEdgeIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTriangleWithID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTriangleWithID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateTriangleWithID_TriangleID_PropertyAddress.Address, intPtr);
		FTriangleID.ToNative(IntPtr.Add(intPtr, CreateTriangleWithID_TriangleID_Offset), 0, CreateTriangleWithID_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InitializeValue_InContainer(CreateTriangleWithID_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, CreateTriangleWithID_PolygonGroupID_Offset), 0, CreateTriangleWithID_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		new TArrayCopyMarshaler<FVertexInstanceID>(1, CreateTriangleWithID_VertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).ToNative(IntPtr.Add(intPtr, CreateTriangleWithID_VertexInstanceIDs_Offset), VertexInstanceIDs);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateTriangleWithID_FunctionAddress, intPtr, CreateTriangleWithID_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTriangleWithID_VertexInstanceIDs_PropertyAddress.Address, intPtr);
		NewEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, CreateTriangleWithID_NewEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, CreateTriangleWithID_NewEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(CreateTriangleWithID_NewEdgeIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateTriangle")]
	public unsafe FTriangleID CreateTriangle(FPolygonGroupID PolygonGroupID, List<FVertexInstanceID> VertexInstanceIDs, out List<FEdgeID> NewEdgeIDs)
	{
		CheckDestroyed();
		if (!CreateTriangle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateTriangle");
			NewEdgeIDs = null;
			return default(FTriangleID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTriangle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTriangle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateTriangle_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, CreateTriangle_PolygonGroupID_Offset), 0, CreateTriangle_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		new TArrayCopyMarshaler<FVertexInstanceID>(1, CreateTriangle_VertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).ToNative(IntPtr.Add(intPtr, CreateTriangle_VertexInstanceIDs_Offset), VertexInstanceIDs);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateTriangle_FunctionAddress, intPtr, CreateTriangle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateTriangle_VertexInstanceIDs_PropertyAddress.Address, intPtr);
		NewEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, CreateTriangle_NewEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, CreateTriangle_NewEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(CreateTriangle_NewEdgeIDs_PropertyAddress.Address, intPtr);
		return FTriangleID.FromNative(IntPtr.Add(intPtr, CreateTriangle_ReturnValue_Offset), 0, CreateTriangle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonWithID")]
	public unsafe void CreatePolygonWithID(FPolygonID PolygonID, FPolygonGroupID PolygonGroupID, out List<FVertexInstanceID> VertexInstanceIDs, out List<FEdgeID> NewEdgeIDs)
	{
		CheckDestroyed();
		if (!CreatePolygonWithID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonWithID");
			VertexInstanceIDs = null;
			NewEdgeIDs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePolygonWithID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePolygonWithID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreatePolygonWithID_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, CreatePolygonWithID_PolygonID_Offset), 0, CreatePolygonWithID_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InitializeValue_InContainer(CreatePolygonWithID_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, CreatePolygonWithID_PolygonGroupID_Offset), 0, CreatePolygonWithID_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePolygonWithID_FunctionAddress, intPtr, CreatePolygonWithID_ParamsSize);
		VertexInstanceIDs = new TArrayCopyMarshaler<FVertexInstanceID>(1, CreatePolygonWithID_VertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).FromNative(IntPtr.Add(intPtr, CreatePolygonWithID_VertexInstanceIDs_Offset));
		NativeReflection.DestroyValue_InContainer(CreatePolygonWithID_VertexInstanceIDs_PropertyAddress.Address, intPtr);
		NewEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, CreatePolygonWithID_NewEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, CreatePolygonWithID_NewEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(CreatePolygonWithID_NewEdgeIDs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonGroupWithID")]
	public unsafe void CreatePolygonGroupWithID(FPolygonGroupID PolygonGroupID)
	{
		CheckDestroyed();
		if (!CreatePolygonGroupWithID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonGroupWithID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePolygonGroupWithID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePolygonGroupWithID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreatePolygonGroupWithID_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, CreatePolygonGroupWithID_PolygonGroupID_Offset), 0, CreatePolygonGroupWithID_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePolygonGroupWithID_FunctionAddress, intPtr, CreatePolygonGroupWithID_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonGroup")]
	public unsafe FPolygonGroupID CreatePolygonGroup()
	{
		CheckDestroyed();
		if (!CreatePolygonGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonGroup");
			return default(FPolygonGroupID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePolygonGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePolygonGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePolygonGroup_FunctionAddress, intPtr, CreatePolygonGroup_ParamsSize);
		return FPolygonGroupID.FromNative(IntPtr.Add(intPtr, CreatePolygonGroup_ReturnValue_Offset), 0, CreatePolygonGroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreatePolygon")]
	public unsafe FPolygonID CreatePolygon(FPolygonGroupID PolygonGroupID, out List<FVertexInstanceID> VertexInstanceIDs, out List<FEdgeID> NewEdgeIDs)
	{
		CheckDestroyed();
		if (!CreatePolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreatePolygon");
			VertexInstanceIDs = null;
			NewEdgeIDs = null;
			return default(FPolygonID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreatePolygon_PolygonGroupID_PropertyAddress.Address, intPtr);
		FPolygonGroupID.ToNative(IntPtr.Add(intPtr, CreatePolygon_PolygonGroupID_Offset), 0, CreatePolygon_PolygonGroupID_PropertyAddress.Address, PolygonGroupID);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePolygon_FunctionAddress, intPtr, CreatePolygon_ParamsSize);
		VertexInstanceIDs = new TArrayCopyMarshaler<FVertexInstanceID>(1, CreatePolygon_VertexInstanceIDs_PropertyAddress, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.FromNative, CachedMarshalingDelegates<FVertexInstanceID, FVertexInstanceID>.ToNative).FromNative(IntPtr.Add(intPtr, CreatePolygon_VertexInstanceIDs_Offset));
		NativeReflection.DestroyValue_InContainer(CreatePolygon_VertexInstanceIDs_PropertyAddress.Address, intPtr);
		NewEdgeIDs = new TArrayCopyMarshaler<FEdgeID>(1, CreatePolygon_NewEdgeIDs_PropertyAddress, CachedMarshalingDelegates<FEdgeID, FEdgeID>.FromNative, CachedMarshalingDelegates<FEdgeID, FEdgeID>.ToNative).FromNative(IntPtr.Add(intPtr, CreatePolygon_NewEdgeIDs_Offset));
		NativeReflection.DestroyValue_InContainer(CreatePolygon_NewEdgeIDs_PropertyAddress.Address, intPtr);
		return FPolygonID.FromNative(IntPtr.Add(intPtr, CreatePolygon_ReturnValue_Offset), 0, CreatePolygon_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateEdgeWithID")]
	public unsafe void CreateEdgeWithID(FEdgeID EdgeID, FVertexID VertexID0, FVertexID VertexID1)
	{
		CheckDestroyed();
		if (!CreateEdgeWithID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateEdgeWithID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateEdgeWithID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateEdgeWithID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateEdgeWithID_EdgeID_PropertyAddress.Address, intPtr);
		FEdgeID.ToNative(IntPtr.Add(intPtr, CreateEdgeWithID_EdgeID_Offset), 0, CreateEdgeWithID_EdgeID_PropertyAddress.Address, EdgeID);
		NativeReflection.InitializeValue_InContainer(CreateEdgeWithID_VertexID0_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, CreateEdgeWithID_VertexID0_Offset), 0, CreateEdgeWithID_VertexID0_PropertyAddress.Address, VertexID0);
		NativeReflection.InitializeValue_InContainer(CreateEdgeWithID_VertexID1_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, CreateEdgeWithID_VertexID1_Offset), 0, CreateEdgeWithID_VertexID1_PropertyAddress.Address, VertexID1);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateEdgeWithID_FunctionAddress, intPtr, CreateEdgeWithID_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:CreateEdge")]
	public unsafe FEdgeID CreateEdge(FVertexID VertexID0, FVertexID VertexID1)
	{
		CheckDestroyed();
		if (!CreateEdge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:CreateEdge");
			return default(FEdgeID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateEdge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateEdge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateEdge_VertexID0_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, CreateEdge_VertexID0_Offset), 0, CreateEdge_VertexID0_PropertyAddress.Address, VertexID0);
		NativeReflection.InitializeValue_InContainer(CreateEdge_VertexID1_PropertyAddress.Address, intPtr);
		FVertexID.ToNative(IntPtr.Add(intPtr, CreateEdge_VertexID1_Offset), 0, CreateEdge_VertexID1_PropertyAddress.Address, VertexID1);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateEdge_FunctionAddress, intPtr, CreateEdge_ParamsSize);
		return FEdgeID.FromNative(IntPtr.Add(intPtr, CreateEdge_ReturnValue_Offset), 0, CreateEdge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MeshDescription.MeshDescriptionBase:ComputePolygonTriangulation")]
	public unsafe void ComputePolygonTriangulation(FPolygonID PolygonID)
	{
		CheckDestroyed();
		if (!ComputePolygonTriangulation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MeshDescription.MeshDescriptionBase:ComputePolygonTriangulation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputePolygonTriangulation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputePolygonTriangulation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ComputePolygonTriangulation_PolygonID_PropertyAddress.Address, intPtr);
		FPolygonID.ToNative(IntPtr.Add(intPtr, ComputePolygonTriangulation_PolygonID_Offset), 0, ComputePolygonTriangulation_PolygonID_PropertyAddress.Address, PolygonID);
		NativeReflection.InvokeFunctionOptimized(base.Address, ComputePolygonTriangulation_FunctionAddress, intPtr, ComputePolygonTriangulation_ParamsSize);
	}

	static UMeshDescriptionBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMeshDescriptionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMeshDescriptionBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MeshDescription.MeshDescriptionBase");
		SetVertexPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVertexPosition");
		SetVertexPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVertexPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_VertexID_PropertyAddress, SetVertexPosition_FunctionAddress, "VertexID");
		SetVertexPosition_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "VertexID");
		SetVertexPosition_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexPosition_Position_PropertyAddress, SetVertexPosition_FunctionAddress, "Position");
		SetVertexPosition_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexPosition_FunctionAddress, "Position");
		SetVertexPosition_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexPosition_FunctionAddress, "Position", Classes.FStructProperty);
		SetVertexPosition_IsValid = SetVertexPosition_FunctionAddress != IntPtr.Zero && SetVertexPosition_VertexID_IsValid && SetVertexPosition_Position_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:SetVertexPosition", SetVertexPosition_IsValid);
		SetPolygonVertexInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPolygonVertexInstances");
		SetPolygonVertexInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPolygonVertexInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPolygonVertexInstances_PolygonID_PropertyAddress, SetPolygonVertexInstances_FunctionAddress, "PolygonID");
		SetPolygonVertexInstances_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygonVertexInstances_FunctionAddress, "PolygonID");
		SetPolygonVertexInstances_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygonVertexInstances_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygonVertexInstances_VertexInstanceIDs_PropertyAddress, SetPolygonVertexInstances_FunctionAddress, "VertexInstanceIDs");
		SetPolygonVertexInstances_VertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygonVertexInstances_FunctionAddress, "VertexInstanceIDs");
		SetPolygonVertexInstances_VertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygonVertexInstances_FunctionAddress, "VertexInstanceIDs", Classes.FArrayProperty);
		SetPolygonVertexInstances_IsValid = SetPolygonVertexInstances_FunctionAddress != IntPtr.Zero && SetPolygonVertexInstances_PolygonID_IsValid && SetPolygonVertexInstances_VertexInstanceIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:SetPolygonVertexInstances", SetPolygonVertexInstances_IsValid);
		SetPolygonPolygonGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPolygonPolygonGroup");
		SetPolygonPolygonGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPolygonPolygonGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPolygonPolygonGroup_PolygonID_PropertyAddress, SetPolygonPolygonGroup_FunctionAddress, "PolygonID");
		SetPolygonPolygonGroup_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygonPolygonGroup_FunctionAddress, "PolygonID");
		SetPolygonPolygonGroup_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygonPolygonGroup_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPolygonPolygonGroup_PolygonGroupID_PropertyAddress, SetPolygonPolygonGroup_FunctionAddress, "PolygonGroupID");
		SetPolygonPolygonGroup_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(SetPolygonPolygonGroup_FunctionAddress, "PolygonGroupID");
		SetPolygonPolygonGroup_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPolygonPolygonGroup_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		SetPolygonPolygonGroup_IsValid = SetPolygonPolygonGroup_FunctionAddress != IntPtr.Zero && SetPolygonPolygonGroup_PolygonID_IsValid && SetPolygonPolygonGroup_PolygonGroupID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:SetPolygonPolygonGroup", SetPolygonPolygonGroup_IsValid);
		ReversePolygonFacing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReversePolygonFacing");
		ReversePolygonFacing_ParamsSize = NativeReflection.GetFunctionParamsSize(ReversePolygonFacing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReversePolygonFacing_PolygonID_PropertyAddress, ReversePolygonFacing_FunctionAddress, "PolygonID");
		ReversePolygonFacing_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(ReversePolygonFacing_FunctionAddress, "PolygonID");
		ReversePolygonFacing_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(ReversePolygonFacing_FunctionAddress, "PolygonID", Classes.FStructProperty);
		ReversePolygonFacing_IsValid = ReversePolygonFacing_FunctionAddress != IntPtr.Zero && ReversePolygonFacing_PolygonID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ReversePolygonFacing", ReversePolygonFacing_IsValid);
		ReserveNewVertices_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReserveNewVertices");
		ReserveNewVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(ReserveNewVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReserveNewVertices_NumberOfNewVertices_PropertyAddress, ReserveNewVertices_FunctionAddress, "NumberOfNewVertices");
		ReserveNewVertices_NumberOfNewVertices_Offset = NativeReflectionCached.GetPropertyOffset(ReserveNewVertices_FunctionAddress, "NumberOfNewVertices");
		ReserveNewVertices_NumberOfNewVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(ReserveNewVertices_FunctionAddress, "NumberOfNewVertices", Classes.FIntProperty);
		ReserveNewVertices_IsValid = ReserveNewVertices_FunctionAddress != IntPtr.Zero && ReserveNewVertices_NumberOfNewVertices_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ReserveNewVertices", ReserveNewVertices_IsValid);
		ReserveNewVertexInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReserveNewVertexInstances");
		ReserveNewVertexInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(ReserveNewVertexInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReserveNewVertexInstances_NumberOfNewVertexInstances_PropertyAddress, ReserveNewVertexInstances_FunctionAddress, "NumberOfNewVertexInstances");
		ReserveNewVertexInstances_NumberOfNewVertexInstances_Offset = NativeReflectionCached.GetPropertyOffset(ReserveNewVertexInstances_FunctionAddress, "NumberOfNewVertexInstances");
		ReserveNewVertexInstances_NumberOfNewVertexInstances_IsValid = NativeReflectionCached.ValidatePropertyClass(ReserveNewVertexInstances_FunctionAddress, "NumberOfNewVertexInstances", Classes.FIntProperty);
		ReserveNewVertexInstances_IsValid = ReserveNewVertexInstances_FunctionAddress != IntPtr.Zero && ReserveNewVertexInstances_NumberOfNewVertexInstances_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ReserveNewVertexInstances", ReserveNewVertexInstances_IsValid);
		ReserveNewTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReserveNewTriangles");
		ReserveNewTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(ReserveNewTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReserveNewTriangles_NumberOfNewTriangles_PropertyAddress, ReserveNewTriangles_FunctionAddress, "NumberOfNewTriangles");
		ReserveNewTriangles_NumberOfNewTriangles_Offset = NativeReflectionCached.GetPropertyOffset(ReserveNewTriangles_FunctionAddress, "NumberOfNewTriangles");
		ReserveNewTriangles_NumberOfNewTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(ReserveNewTriangles_FunctionAddress, "NumberOfNewTriangles", Classes.FIntProperty);
		ReserveNewTriangles_IsValid = ReserveNewTriangles_FunctionAddress != IntPtr.Zero && ReserveNewTriangles_NumberOfNewTriangles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ReserveNewTriangles", ReserveNewTriangles_IsValid);
		ReserveNewPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReserveNewPolygons");
		ReserveNewPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(ReserveNewPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReserveNewPolygons_NumberOfNewPolygons_PropertyAddress, ReserveNewPolygons_FunctionAddress, "NumberOfNewPolygons");
		ReserveNewPolygons_NumberOfNewPolygons_Offset = NativeReflectionCached.GetPropertyOffset(ReserveNewPolygons_FunctionAddress, "NumberOfNewPolygons");
		ReserveNewPolygons_NumberOfNewPolygons_IsValid = NativeReflectionCached.ValidatePropertyClass(ReserveNewPolygons_FunctionAddress, "NumberOfNewPolygons", Classes.FIntProperty);
		ReserveNewPolygons_IsValid = ReserveNewPolygons_FunctionAddress != IntPtr.Zero && ReserveNewPolygons_NumberOfNewPolygons_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ReserveNewPolygons", ReserveNewPolygons_IsValid);
		ReserveNewPolygonGroups_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReserveNewPolygonGroups");
		ReserveNewPolygonGroups_ParamsSize = NativeReflection.GetFunctionParamsSize(ReserveNewPolygonGroups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReserveNewPolygonGroups_NumberOfNewPolygonGroups_PropertyAddress, ReserveNewPolygonGroups_FunctionAddress, "NumberOfNewPolygonGroups");
		ReserveNewPolygonGroups_NumberOfNewPolygonGroups_Offset = NativeReflectionCached.GetPropertyOffset(ReserveNewPolygonGroups_FunctionAddress, "NumberOfNewPolygonGroups");
		ReserveNewPolygonGroups_NumberOfNewPolygonGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(ReserveNewPolygonGroups_FunctionAddress, "NumberOfNewPolygonGroups", Classes.FIntProperty);
		ReserveNewPolygonGroups_IsValid = ReserveNewPolygonGroups_FunctionAddress != IntPtr.Zero && ReserveNewPolygonGroups_NumberOfNewPolygonGroups_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ReserveNewPolygonGroups", ReserveNewPolygonGroups_IsValid);
		ReserveNewEdges_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReserveNewEdges");
		ReserveNewEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(ReserveNewEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReserveNewEdges_NumberOfNewEdges_PropertyAddress, ReserveNewEdges_FunctionAddress, "NumberOfNewEdges");
		ReserveNewEdges_NumberOfNewEdges_Offset = NativeReflectionCached.GetPropertyOffset(ReserveNewEdges_FunctionAddress, "NumberOfNewEdges");
		ReserveNewEdges_NumberOfNewEdges_IsValid = NativeReflectionCached.ValidatePropertyClass(ReserveNewEdges_FunctionAddress, "NumberOfNewEdges", Classes.FIntProperty);
		ReserveNewEdges_IsValid = ReserveNewEdges_FunctionAddress != IntPtr.Zero && ReserveNewEdges_NumberOfNewEdges_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ReserveNewEdges", ReserveNewEdges_IsValid);
		IsVertexValid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsVertexValid");
		IsVertexValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVertexValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVertexValid_VertexID_PropertyAddress, IsVertexValid_FunctionAddress, "VertexID");
		IsVertexValid_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(IsVertexValid_FunctionAddress, "VertexID");
		IsVertexValid_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVertexValid_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsVertexValid_ReturnValue_PropertyAddress, IsVertexValid_FunctionAddress, "ReturnValue");
		IsVertexValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVertexValid_FunctionAddress, "ReturnValue");
		IsVertexValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVertexValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVertexValid_IsValid = IsVertexValid_FunctionAddress != IntPtr.Zero && IsVertexValid_VertexID_IsValid && IsVertexValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsVertexValid", IsVertexValid_IsValid);
		IsVertexOrphaned_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsVertexOrphaned");
		IsVertexOrphaned_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVertexOrphaned_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVertexOrphaned_VertexID_PropertyAddress, IsVertexOrphaned_FunctionAddress, "VertexID");
		IsVertexOrphaned_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(IsVertexOrphaned_FunctionAddress, "VertexID");
		IsVertexOrphaned_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVertexOrphaned_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsVertexOrphaned_ReturnValue_PropertyAddress, IsVertexOrphaned_FunctionAddress, "ReturnValue");
		IsVertexOrphaned_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVertexOrphaned_FunctionAddress, "ReturnValue");
		IsVertexOrphaned_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVertexOrphaned_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVertexOrphaned_IsValid = IsVertexOrphaned_FunctionAddress != IntPtr.Zero && IsVertexOrphaned_VertexID_IsValid && IsVertexOrphaned_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsVertexOrphaned", IsVertexOrphaned_IsValid);
		IsVertexInstanceValid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsVertexInstanceValid");
		IsVertexInstanceValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVertexInstanceValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVertexInstanceValid_VertexInstanceID_PropertyAddress, IsVertexInstanceValid_FunctionAddress, "VertexInstanceID");
		IsVertexInstanceValid_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(IsVertexInstanceValid_FunctionAddress, "VertexInstanceID");
		IsVertexInstanceValid_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVertexInstanceValid_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsVertexInstanceValid_ReturnValue_PropertyAddress, IsVertexInstanceValid_FunctionAddress, "ReturnValue");
		IsVertexInstanceValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVertexInstanceValid_FunctionAddress, "ReturnValue");
		IsVertexInstanceValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVertexInstanceValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVertexInstanceValid_IsValid = IsVertexInstanceValid_FunctionAddress != IntPtr.Zero && IsVertexInstanceValid_VertexInstanceID_IsValid && IsVertexInstanceValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsVertexInstanceValid", IsVertexInstanceValid_IsValid);
		IsTriangleValid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsTriangleValid");
		IsTriangleValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTriangleValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTriangleValid_TriangleID_PropertyAddress, IsTriangleValid_FunctionAddress, "TriangleID");
		IsTriangleValid_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(IsTriangleValid_FunctionAddress, "TriangleID");
		IsTriangleValid_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriangleValid_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTriangleValid_ReturnValue_PropertyAddress, IsTriangleValid_FunctionAddress, "ReturnValue");
		IsTriangleValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTriangleValid_FunctionAddress, "ReturnValue");
		IsTriangleValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTriangleValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTriangleValid_IsValid = IsTriangleValid_FunctionAddress != IntPtr.Zero && IsTriangleValid_TriangleID_IsValid && IsTriangleValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsTriangleValid", IsTriangleValid_IsValid);
		IsTrianglePartOfNgon_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsTrianglePartOfNgon");
		IsTrianglePartOfNgon_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTrianglePartOfNgon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTrianglePartOfNgon_TriangleID_PropertyAddress, IsTrianglePartOfNgon_FunctionAddress, "TriangleID");
		IsTrianglePartOfNgon_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(IsTrianglePartOfNgon_FunctionAddress, "TriangleID");
		IsTrianglePartOfNgon_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTrianglePartOfNgon_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTrianglePartOfNgon_ReturnValue_PropertyAddress, IsTrianglePartOfNgon_FunctionAddress, "ReturnValue");
		IsTrianglePartOfNgon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTrianglePartOfNgon_FunctionAddress, "ReturnValue");
		IsTrianglePartOfNgon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTrianglePartOfNgon_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTrianglePartOfNgon_IsValid = IsTrianglePartOfNgon_FunctionAddress != IntPtr.Zero && IsTrianglePartOfNgon_TriangleID_IsValid && IsTrianglePartOfNgon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsTrianglePartOfNgon", IsTrianglePartOfNgon_IsValid);
		IsPolygonValid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsPolygonValid");
		IsPolygonValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPolygonValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPolygonValid_PolygonID_PropertyAddress, IsPolygonValid_FunctionAddress, "PolygonID");
		IsPolygonValid_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(IsPolygonValid_FunctionAddress, "PolygonID");
		IsPolygonValid_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPolygonValid_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPolygonValid_ReturnValue_PropertyAddress, IsPolygonValid_FunctionAddress, "ReturnValue");
		IsPolygonValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPolygonValid_FunctionAddress, "ReturnValue");
		IsPolygonValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPolygonValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPolygonValid_IsValid = IsPolygonValid_FunctionAddress != IntPtr.Zero && IsPolygonValid_PolygonID_IsValid && IsPolygonValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsPolygonValid", IsPolygonValid_IsValid);
		IsPolygonGroupValid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsPolygonGroupValid");
		IsPolygonGroupValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPolygonGroupValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPolygonGroupValid_PolygonGroupID_PropertyAddress, IsPolygonGroupValid_FunctionAddress, "PolygonGroupID");
		IsPolygonGroupValid_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(IsPolygonGroupValid_FunctionAddress, "PolygonGroupID");
		IsPolygonGroupValid_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPolygonGroupValid_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPolygonGroupValid_ReturnValue_PropertyAddress, IsPolygonGroupValid_FunctionAddress, "ReturnValue");
		IsPolygonGroupValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPolygonGroupValid_FunctionAddress, "ReturnValue");
		IsPolygonGroupValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPolygonGroupValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPolygonGroupValid_IsValid = IsPolygonGroupValid_FunctionAddress != IntPtr.Zero && IsPolygonGroupValid_PolygonGroupID_IsValid && IsPolygonGroupValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsPolygonGroupValid", IsPolygonGroupValid_IsValid);
		IsEmpty_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEmpty");
		IsEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEmpty_ReturnValue_PropertyAddress, IsEmpty_FunctionAddress, "ReturnValue");
		IsEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEmpty_FunctionAddress, "ReturnValue");
		IsEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEmpty_IsValid = IsEmpty_FunctionAddress != IntPtr.Zero && IsEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsEmpty", IsEmpty_IsValid);
		IsEdgeValid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEdgeValid");
		IsEdgeValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEdgeValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEdgeValid_EdgeID_PropertyAddress, IsEdgeValid_FunctionAddress, "EdgeID");
		IsEdgeValid_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(IsEdgeValid_FunctionAddress, "EdgeID");
		IsEdgeValid_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEdgeValid_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEdgeValid_ReturnValue_PropertyAddress, IsEdgeValid_FunctionAddress, "ReturnValue");
		IsEdgeValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEdgeValid_FunctionAddress, "ReturnValue");
		IsEdgeValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEdgeValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEdgeValid_IsValid = IsEdgeValid_FunctionAddress != IntPtr.Zero && IsEdgeValid_EdgeID_IsValid && IsEdgeValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsEdgeValid", IsEdgeValid_IsValid);
		IsEdgeInternalToPolygon_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEdgeInternalToPolygon");
		IsEdgeInternalToPolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEdgeInternalToPolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEdgeInternalToPolygon_EdgeID_PropertyAddress, IsEdgeInternalToPolygon_FunctionAddress, "EdgeID");
		IsEdgeInternalToPolygon_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(IsEdgeInternalToPolygon_FunctionAddress, "EdgeID");
		IsEdgeInternalToPolygon_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEdgeInternalToPolygon_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEdgeInternalToPolygon_PolygonID_PropertyAddress, IsEdgeInternalToPolygon_FunctionAddress, "PolygonID");
		IsEdgeInternalToPolygon_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(IsEdgeInternalToPolygon_FunctionAddress, "PolygonID");
		IsEdgeInternalToPolygon_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEdgeInternalToPolygon_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEdgeInternalToPolygon_ReturnValue_PropertyAddress, IsEdgeInternalToPolygon_FunctionAddress, "ReturnValue");
		IsEdgeInternalToPolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEdgeInternalToPolygon_FunctionAddress, "ReturnValue");
		IsEdgeInternalToPolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEdgeInternalToPolygon_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEdgeInternalToPolygon_IsValid = IsEdgeInternalToPolygon_FunctionAddress != IntPtr.Zero && IsEdgeInternalToPolygon_EdgeID_IsValid && IsEdgeInternalToPolygon_PolygonID_IsValid && IsEdgeInternalToPolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsEdgeInternalToPolygon", IsEdgeInternalToPolygon_IsValid);
		IsEdgeInternal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEdgeInternal");
		IsEdgeInternal_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEdgeInternal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEdgeInternal_EdgeID_PropertyAddress, IsEdgeInternal_FunctionAddress, "EdgeID");
		IsEdgeInternal_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(IsEdgeInternal_FunctionAddress, "EdgeID");
		IsEdgeInternal_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEdgeInternal_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEdgeInternal_ReturnValue_PropertyAddress, IsEdgeInternal_FunctionAddress, "ReturnValue");
		IsEdgeInternal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEdgeInternal_FunctionAddress, "ReturnValue");
		IsEdgeInternal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEdgeInternal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEdgeInternal_IsValid = IsEdgeInternal_FunctionAddress != IntPtr.Zero && IsEdgeInternal_EdgeID_IsValid && IsEdgeInternal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:IsEdgeInternal", IsEdgeInternal_IsValid);
		GetVertexVertexInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexVertexInstances");
		GetVertexVertexInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexVertexInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexVertexInstances_VertexID_PropertyAddress, GetVertexVertexInstances_FunctionAddress, "VertexID");
		GetVertexVertexInstances_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexVertexInstances_FunctionAddress, "VertexID");
		GetVertexVertexInstances_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexVertexInstances_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexVertexInstances_OutVertexInstanceIDs_PropertyAddress, GetVertexVertexInstances_FunctionAddress, "OutVertexInstanceIDs");
		GetVertexVertexInstances_OutVertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexVertexInstances_FunctionAddress, "OutVertexInstanceIDs");
		GetVertexVertexInstances_OutVertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexVertexInstances_FunctionAddress, "OutVertexInstanceIDs", Classes.FArrayProperty);
		GetVertexVertexInstances_IsValid = GetVertexVertexInstances_FunctionAddress != IntPtr.Zero && GetVertexVertexInstances_VertexID_IsValid && GetVertexVertexInstances_OutVertexInstanceIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexVertexInstances", GetVertexVertexInstances_IsValid);
		GetVertexPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexPosition");
		GetVertexPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPosition_VertexID_PropertyAddress, GetVertexPosition_FunctionAddress, "VertexID");
		GetVertexPosition_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPosition_FunctionAddress, "VertexID");
		GetVertexPosition_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPosition_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPosition_ReturnValue_PropertyAddress, GetVertexPosition_FunctionAddress, "ReturnValue");
		GetVertexPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPosition_FunctionAddress, "ReturnValue");
		GetVertexPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexPosition_IsValid = GetVertexPosition_FunctionAddress != IntPtr.Zero && GetVertexPosition_VertexID_IsValid && GetVertexPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexPosition", GetVertexPosition_IsValid);
		GetVertexPairEdge_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexPairEdge");
		GetVertexPairEdge_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexPairEdge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPairEdge_VertexID0_PropertyAddress, GetVertexPairEdge_FunctionAddress, "VertexID0");
		GetVertexPairEdge_VertexID0_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPairEdge_FunctionAddress, "VertexID0");
		GetVertexPairEdge_VertexID0_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPairEdge_FunctionAddress, "VertexID0", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPairEdge_VertexID1_PropertyAddress, GetVertexPairEdge_FunctionAddress, "VertexID1");
		GetVertexPairEdge_VertexID1_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPairEdge_FunctionAddress, "VertexID1");
		GetVertexPairEdge_VertexID1_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPairEdge_FunctionAddress, "VertexID1", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexPairEdge_ReturnValue_PropertyAddress, GetVertexPairEdge_FunctionAddress, "ReturnValue");
		GetVertexPairEdge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexPairEdge_FunctionAddress, "ReturnValue");
		GetVertexPairEdge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexPairEdge_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexPairEdge_IsValid = GetVertexPairEdge_FunctionAddress != IntPtr.Zero && GetVertexPairEdge_VertexID0_IsValid && GetVertexPairEdge_VertexID1_IsValid && GetVertexPairEdge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexPairEdge", GetVertexPairEdge_IsValid);
		GetVertexInstanceVertex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstanceVertex");
		GetVertexInstanceVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstanceVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceVertex_VertexInstanceID_PropertyAddress, GetVertexInstanceVertex_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceVertex_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceVertex_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceVertex_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceVertex_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceVertex_ReturnValue_PropertyAddress, GetVertexInstanceVertex_FunctionAddress, "ReturnValue");
		GetVertexInstanceVertex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceVertex_FunctionAddress, "ReturnValue");
		GetVertexInstanceVertex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceVertex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexInstanceVertex_IsValid = GetVertexInstanceVertex_FunctionAddress != IntPtr.Zero && GetVertexInstanceVertex_VertexInstanceID_IsValid && GetVertexInstanceVertex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceVertex", GetVertexInstanceVertex_IsValid);
		GetVertexInstancePairEdge_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstancePairEdge");
		GetVertexInstancePairEdge_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstancePairEdge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstancePairEdge_VertexInstanceID0_PropertyAddress, GetVertexInstancePairEdge_FunctionAddress, "VertexInstanceID0");
		GetVertexInstancePairEdge_VertexInstanceID0_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstancePairEdge_FunctionAddress, "VertexInstanceID0");
		GetVertexInstancePairEdge_VertexInstanceID0_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstancePairEdge_FunctionAddress, "VertexInstanceID0", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstancePairEdge_VertexInstanceID1_PropertyAddress, GetVertexInstancePairEdge_FunctionAddress, "VertexInstanceID1");
		GetVertexInstancePairEdge_VertexInstanceID1_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstancePairEdge_FunctionAddress, "VertexInstanceID1");
		GetVertexInstancePairEdge_VertexInstanceID1_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstancePairEdge_FunctionAddress, "VertexInstanceID1", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstancePairEdge_ReturnValue_PropertyAddress, GetVertexInstancePairEdge_FunctionAddress, "ReturnValue");
		GetVertexInstancePairEdge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstancePairEdge_FunctionAddress, "ReturnValue");
		GetVertexInstancePairEdge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstancePairEdge_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexInstancePairEdge_IsValid = GetVertexInstancePairEdge_FunctionAddress != IntPtr.Zero && GetVertexInstancePairEdge_VertexInstanceID0_IsValid && GetVertexInstancePairEdge_VertexInstanceID1_IsValid && GetVertexInstancePairEdge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstancePairEdge", GetVertexInstancePairEdge_IsValid);
		GetVertexInstanceForTriangleVertex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstanceForTriangleVertex");
		GetVertexInstanceForTriangleVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstanceForTriangleVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceForTriangleVertex_TriangleID_PropertyAddress, GetVertexInstanceForTriangleVertex_FunctionAddress, "TriangleID");
		GetVertexInstanceForTriangleVertex_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceForTriangleVertex_FunctionAddress, "TriangleID");
		GetVertexInstanceForTriangleVertex_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceForTriangleVertex_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceForTriangleVertex_VertexID_PropertyAddress, GetVertexInstanceForTriangleVertex_FunctionAddress, "VertexID");
		GetVertexInstanceForTriangleVertex_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceForTriangleVertex_FunctionAddress, "VertexID");
		GetVertexInstanceForTriangleVertex_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceForTriangleVertex_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceForTriangleVertex_ReturnValue_PropertyAddress, GetVertexInstanceForTriangleVertex_FunctionAddress, "ReturnValue");
		GetVertexInstanceForTriangleVertex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceForTriangleVertex_FunctionAddress, "ReturnValue");
		GetVertexInstanceForTriangleVertex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceForTriangleVertex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexInstanceForTriangleVertex_IsValid = GetVertexInstanceForTriangleVertex_FunctionAddress != IntPtr.Zero && GetVertexInstanceForTriangleVertex_TriangleID_IsValid && GetVertexInstanceForTriangleVertex_VertexID_IsValid && GetVertexInstanceForTriangleVertex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceForTriangleVertex", GetVertexInstanceForTriangleVertex_IsValid);
		GetVertexInstanceForPolygonVertex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstanceForPolygonVertex");
		GetVertexInstanceForPolygonVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstanceForPolygonVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceForPolygonVertex_PolygonID_PropertyAddress, GetVertexInstanceForPolygonVertex_FunctionAddress, "PolygonID");
		GetVertexInstanceForPolygonVertex_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceForPolygonVertex_FunctionAddress, "PolygonID");
		GetVertexInstanceForPolygonVertex_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceForPolygonVertex_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceForPolygonVertex_VertexID_PropertyAddress, GetVertexInstanceForPolygonVertex_FunctionAddress, "VertexID");
		GetVertexInstanceForPolygonVertex_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceForPolygonVertex_FunctionAddress, "VertexID");
		GetVertexInstanceForPolygonVertex_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceForPolygonVertex_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceForPolygonVertex_ReturnValue_PropertyAddress, GetVertexInstanceForPolygonVertex_FunctionAddress, "ReturnValue");
		GetVertexInstanceForPolygonVertex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceForPolygonVertex_FunctionAddress, "ReturnValue");
		GetVertexInstanceForPolygonVertex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceForPolygonVertex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVertexInstanceForPolygonVertex_IsValid = GetVertexInstanceForPolygonVertex_FunctionAddress != IntPtr.Zero && GetVertexInstanceForPolygonVertex_PolygonID_IsValid && GetVertexInstanceForPolygonVertex_VertexID_IsValid && GetVertexInstanceForPolygonVertex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceForPolygonVertex", GetVertexInstanceForPolygonVertex_IsValid);
		GetVertexInstanceCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstanceCount");
		GetVertexInstanceCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstanceCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceCount_ReturnValue_PropertyAddress, GetVertexInstanceCount_FunctionAddress, "ReturnValue");
		GetVertexInstanceCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceCount_FunctionAddress, "ReturnValue");
		GetVertexInstanceCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetVertexInstanceCount_IsValid = GetVertexInstanceCount_FunctionAddress != IntPtr.Zero && GetVertexInstanceCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceCount", GetVertexInstanceCount_IsValid);
		GetVertexInstanceConnectedTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstanceConnectedTriangles");
		GetVertexInstanceConnectedTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstanceConnectedTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress, GetVertexInstanceConnectedTriangles_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceConnectedTriangles_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceConnectedTriangles_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceConnectedTriangles_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceConnectedTriangles_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress, GetVertexInstanceConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs");
		GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs");
		GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs", Classes.FArrayProperty);
		GetVertexInstanceConnectedTriangles_IsValid = GetVertexInstanceConnectedTriangles_FunctionAddress != IntPtr.Zero && GetVertexInstanceConnectedTriangles_VertexInstanceID_IsValid && GetVertexInstanceConnectedTriangles_OutConnectedTriangleIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceConnectedTriangles", GetVertexInstanceConnectedTriangles_IsValid);
		GetVertexInstanceConnectedPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexInstanceConnectedPolygons");
		GetVertexInstanceConnectedPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexInstanceConnectedPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress, GetVertexInstanceConnectedPolygons_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceConnectedPolygons_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceConnectedPolygons_FunctionAddress, "VertexInstanceID");
		GetVertexInstanceConnectedPolygons_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceConnectedPolygons_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress, GetVertexInstanceConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs");
		GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexInstanceConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs");
		GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexInstanceConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs", Classes.FArrayProperty);
		GetVertexInstanceConnectedPolygons_IsValid = GetVertexInstanceConnectedPolygons_FunctionAddress != IntPtr.Zero && GetVertexInstanceConnectedPolygons_VertexInstanceID_IsValid && GetVertexInstanceConnectedPolygons_OutConnectedPolygonIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexInstanceConnectedPolygons", GetVertexInstanceConnectedPolygons_IsValid);
		GetVertexCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexCount");
		GetVertexCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexCount_ReturnValue_PropertyAddress, GetVertexCount_FunctionAddress, "ReturnValue");
		GetVertexCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexCount_FunctionAddress, "ReturnValue");
		GetVertexCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetVertexCount_IsValid = GetVertexCount_FunctionAddress != IntPtr.Zero && GetVertexCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexCount", GetVertexCount_IsValid);
		GetVertexConnectedTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexConnectedTriangles");
		GetVertexConnectedTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexConnectedTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexConnectedTriangles_VertexID_PropertyAddress, GetVertexConnectedTriangles_FunctionAddress, "VertexID");
		GetVertexConnectedTriangles_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexConnectedTriangles_FunctionAddress, "VertexID");
		GetVertexConnectedTriangles_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexConnectedTriangles_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress, GetVertexConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs");
		GetVertexConnectedTriangles_OutConnectedTriangleIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs");
		GetVertexConnectedTriangles_OutConnectedTriangleIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs", Classes.FArrayProperty);
		GetVertexConnectedTriangles_IsValid = GetVertexConnectedTriangles_FunctionAddress != IntPtr.Zero && GetVertexConnectedTriangles_VertexID_IsValid && GetVertexConnectedTriangles_OutConnectedTriangleIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedTriangles", GetVertexConnectedTriangles_IsValid);
		GetVertexConnectedPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexConnectedPolygons");
		GetVertexConnectedPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexConnectedPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexConnectedPolygons_VertexID_PropertyAddress, GetVertexConnectedPolygons_FunctionAddress, "VertexID");
		GetVertexConnectedPolygons_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexConnectedPolygons_FunctionAddress, "VertexID");
		GetVertexConnectedPolygons_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexConnectedPolygons_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress, GetVertexConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs");
		GetVertexConnectedPolygons_OutConnectedPolygonIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs");
		GetVertexConnectedPolygons_OutConnectedPolygonIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs", Classes.FArrayProperty);
		GetVertexConnectedPolygons_IsValid = GetVertexConnectedPolygons_FunctionAddress != IntPtr.Zero && GetVertexConnectedPolygons_VertexID_IsValid && GetVertexConnectedPolygons_OutConnectedPolygonIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedPolygons", GetVertexConnectedPolygons_IsValid);
		GetVertexConnectedEdges_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexConnectedEdges");
		GetVertexConnectedEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexConnectedEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexConnectedEdges_VertexID_PropertyAddress, GetVertexConnectedEdges_FunctionAddress, "VertexID");
		GetVertexConnectedEdges_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexConnectedEdges_FunctionAddress, "VertexID");
		GetVertexConnectedEdges_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexConnectedEdges_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexConnectedEdges_OutEdgeIDs_PropertyAddress, GetVertexConnectedEdges_FunctionAddress, "OutEdgeIDs");
		GetVertexConnectedEdges_OutEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexConnectedEdges_FunctionAddress, "OutEdgeIDs");
		GetVertexConnectedEdges_OutEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexConnectedEdges_FunctionAddress, "OutEdgeIDs", Classes.FArrayProperty);
		GetVertexConnectedEdges_IsValid = GetVertexConnectedEdges_FunctionAddress != IntPtr.Zero && GetVertexConnectedEdges_VertexID_IsValid && GetVertexConnectedEdges_OutEdgeIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexConnectedEdges", GetVertexConnectedEdges_IsValid);
		GetVertexAdjacentVertices_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVertexAdjacentVertices");
		GetVertexAdjacentVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexAdjacentVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexAdjacentVertices_VertexID_PropertyAddress, GetVertexAdjacentVertices_FunctionAddress, "VertexID");
		GetVertexAdjacentVertices_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexAdjacentVertices_FunctionAddress, "VertexID");
		GetVertexAdjacentVertices_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexAdjacentVertices_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexAdjacentVertices_OutAdjacentVertexIDs_PropertyAddress, GetVertexAdjacentVertices_FunctionAddress, "OutAdjacentVertexIDs");
		GetVertexAdjacentVertices_OutAdjacentVertexIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexAdjacentVertices_FunctionAddress, "OutAdjacentVertexIDs");
		GetVertexAdjacentVertices_OutAdjacentVertexIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexAdjacentVertices_FunctionAddress, "OutAdjacentVertexIDs", Classes.FArrayProperty);
		GetVertexAdjacentVertices_IsValid = GetVertexAdjacentVertices_FunctionAddress != IntPtr.Zero && GetVertexAdjacentVertices_VertexID_IsValid && GetVertexAdjacentVertices_OutAdjacentVertexIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetVertexAdjacentVertices", GetVertexAdjacentVertices_IsValid);
		GetTriangleVertices_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTriangleVertices");
		GetTriangleVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleVertices_TriangleID_PropertyAddress, GetTriangleVertices_FunctionAddress, "TriangleID");
		GetTriangleVertices_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleVertices_FunctionAddress, "TriangleID");
		GetTriangleVertices_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleVertices_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleVertices_OutVertexIDs_PropertyAddress, GetTriangleVertices_FunctionAddress, "OutVertexIDs");
		GetTriangleVertices_OutVertexIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleVertices_FunctionAddress, "OutVertexIDs");
		GetTriangleVertices_OutVertexIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleVertices_FunctionAddress, "OutVertexIDs", Classes.FArrayProperty);
		GetTriangleVertices_IsValid = GetTriangleVertices_FunctionAddress != IntPtr.Zero && GetTriangleVertices_TriangleID_IsValid && GetTriangleVertices_OutVertexIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertices", GetTriangleVertices_IsValid);
		GetTriangleVertexInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTriangleVertexInstances");
		GetTriangleVertexInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleVertexInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleVertexInstances_TriangleID_PropertyAddress, GetTriangleVertexInstances_FunctionAddress, "TriangleID");
		GetTriangleVertexInstances_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleVertexInstances_FunctionAddress, "TriangleID");
		GetTriangleVertexInstances_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleVertexInstances_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleVertexInstances_OutVertexInstanceIDs_PropertyAddress, GetTriangleVertexInstances_FunctionAddress, "OutVertexInstanceIDs");
		GetTriangleVertexInstances_OutVertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleVertexInstances_FunctionAddress, "OutVertexInstanceIDs");
		GetTriangleVertexInstances_OutVertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleVertexInstances_FunctionAddress, "OutVertexInstanceIDs", Classes.FArrayProperty);
		GetTriangleVertexInstances_IsValid = GetTriangleVertexInstances_FunctionAddress != IntPtr.Zero && GetTriangleVertexInstances_TriangleID_IsValid && GetTriangleVertexInstances_OutVertexInstanceIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertexInstances", GetTriangleVertexInstances_IsValid);
		GetTriangleVertexInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTriangleVertexInstance");
		GetTriangleVertexInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleVertexInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleVertexInstance_TriangleID_PropertyAddress, GetTriangleVertexInstance_FunctionAddress, "TriangleID");
		GetTriangleVertexInstance_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleVertexInstance_FunctionAddress, "TriangleID");
		GetTriangleVertexInstance_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleVertexInstance_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleVertexInstance_Index_PropertyAddress, GetTriangleVertexInstance_FunctionAddress, "Index");
		GetTriangleVertexInstance_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleVertexInstance_FunctionAddress, "Index");
		GetTriangleVertexInstance_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleVertexInstance_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleVertexInstance_ReturnValue_PropertyAddress, GetTriangleVertexInstance_FunctionAddress, "ReturnValue");
		GetTriangleVertexInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleVertexInstance_FunctionAddress, "ReturnValue");
		GetTriangleVertexInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleVertexInstance_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTriangleVertexInstance_IsValid = GetTriangleVertexInstance_FunctionAddress != IntPtr.Zero && GetTriangleVertexInstance_TriangleID_IsValid && GetTriangleVertexInstance_Index_IsValid && GetTriangleVertexInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTriangleVertexInstance", GetTriangleVertexInstance_IsValid);
		GetTrianglePolygonGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTrianglePolygonGroup");
		GetTrianglePolygonGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrianglePolygonGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygonGroup_TriangleID_PropertyAddress, GetTrianglePolygonGroup_FunctionAddress, "TriangleID");
		GetTrianglePolygonGroup_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygonGroup_FunctionAddress, "TriangleID");
		GetTrianglePolygonGroup_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygonGroup_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygonGroup_ReturnValue_PropertyAddress, GetTrianglePolygonGroup_FunctionAddress, "ReturnValue");
		GetTrianglePolygonGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygonGroup_FunctionAddress, "ReturnValue");
		GetTrianglePolygonGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygonGroup_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTrianglePolygonGroup_IsValid = GetTrianglePolygonGroup_FunctionAddress != IntPtr.Zero && GetTrianglePolygonGroup_TriangleID_IsValid && GetTrianglePolygonGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTrianglePolygonGroup", GetTrianglePolygonGroup_IsValid);
		GetTrianglePolygon_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTrianglePolygon");
		GetTrianglePolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrianglePolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygon_TriangleID_PropertyAddress, GetTrianglePolygon_FunctionAddress, "TriangleID");
		GetTrianglePolygon_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygon_FunctionAddress, "TriangleID");
		GetTrianglePolygon_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygon_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygon_ReturnValue_PropertyAddress, GetTrianglePolygon_FunctionAddress, "ReturnValue");
		GetTrianglePolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygon_FunctionAddress, "ReturnValue");
		GetTrianglePolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygon_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTrianglePolygon_IsValid = GetTrianglePolygon_FunctionAddress != IntPtr.Zero && GetTrianglePolygon_TriangleID_IsValid && GetTrianglePolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTrianglePolygon", GetTrianglePolygon_IsValid);
		GetTriangleEdges_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTriangleEdges");
		GetTriangleEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleEdges_TriangleID_PropertyAddress, GetTriangleEdges_FunctionAddress, "TriangleID");
		GetTriangleEdges_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleEdges_FunctionAddress, "TriangleID");
		GetTriangleEdges_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleEdges_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleEdges_OutEdgeIDs_PropertyAddress, GetTriangleEdges_FunctionAddress, "OutEdgeIDs");
		GetTriangleEdges_OutEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleEdges_FunctionAddress, "OutEdgeIDs");
		GetTriangleEdges_OutEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleEdges_FunctionAddress, "OutEdgeIDs", Classes.FArrayProperty);
		GetTriangleEdges_IsValid = GetTriangleEdges_FunctionAddress != IntPtr.Zero && GetTriangleEdges_TriangleID_IsValid && GetTriangleEdges_OutEdgeIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTriangleEdges", GetTriangleEdges_IsValid);
		GetTriangleCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTriangleCount");
		GetTriangleCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleCount_ReturnValue_PropertyAddress, GetTriangleCount_FunctionAddress, "ReturnValue");
		GetTriangleCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleCount_FunctionAddress, "ReturnValue");
		GetTriangleCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTriangleCount_IsValid = GetTriangleCount_FunctionAddress != IntPtr.Zero && GetTriangleCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTriangleCount", GetTriangleCount_IsValid);
		GetTriangleAdjacentTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTriangleAdjacentTriangles");
		GetTriangleAdjacentTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTriangleAdjacentTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleAdjacentTriangles_TriangleID_PropertyAddress, GetTriangleAdjacentTriangles_FunctionAddress, "TriangleID");
		GetTriangleAdjacentTriangles_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleAdjacentTriangles_FunctionAddress, "TriangleID");
		GetTriangleAdjacentTriangles_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleAdjacentTriangles_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTriangleAdjacentTriangles_OutTriangleIDs_PropertyAddress, GetTriangleAdjacentTriangles_FunctionAddress, "OutTriangleIDs");
		GetTriangleAdjacentTriangles_OutTriangleIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetTriangleAdjacentTriangles_FunctionAddress, "OutTriangleIDs");
		GetTriangleAdjacentTriangles_OutTriangleIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTriangleAdjacentTriangles_FunctionAddress, "OutTriangleIDs", Classes.FArrayProperty);
		GetTriangleAdjacentTriangles_IsValid = GetTriangleAdjacentTriangles_FunctionAddress != IntPtr.Zero && GetTriangleAdjacentTriangles_TriangleID_IsValid && GetTriangleAdjacentTriangles_OutTriangleIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetTriangleAdjacentTriangles", GetTriangleAdjacentTriangles_IsValid);
		GetPolygonVertices_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonVertices");
		GetPolygonVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonVertices_PolygonID_PropertyAddress, GetPolygonVertices_FunctionAddress, "PolygonID");
		GetPolygonVertices_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonVertices_FunctionAddress, "PolygonID");
		GetPolygonVertices_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonVertices_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonVertices_OutVertexIDs_PropertyAddress, GetPolygonVertices_FunctionAddress, "OutVertexIDs");
		GetPolygonVertices_OutVertexIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonVertices_FunctionAddress, "OutVertexIDs");
		GetPolygonVertices_OutVertexIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonVertices_FunctionAddress, "OutVertexIDs", Classes.FArrayProperty);
		GetPolygonVertices_IsValid = GetPolygonVertices_FunctionAddress != IntPtr.Zero && GetPolygonVertices_PolygonID_IsValid && GetPolygonVertices_OutVertexIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonVertices", GetPolygonVertices_IsValid);
		GetPolygonVertexInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonVertexInstances");
		GetPolygonVertexInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonVertexInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonVertexInstances_PolygonID_PropertyAddress, GetPolygonVertexInstances_FunctionAddress, "PolygonID");
		GetPolygonVertexInstances_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonVertexInstances_FunctionAddress, "PolygonID");
		GetPolygonVertexInstances_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonVertexInstances_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonVertexInstances_OutVertexInstanceIDs_PropertyAddress, GetPolygonVertexInstances_FunctionAddress, "OutVertexInstanceIDs");
		GetPolygonVertexInstances_OutVertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonVertexInstances_FunctionAddress, "OutVertexInstanceIDs");
		GetPolygonVertexInstances_OutVertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonVertexInstances_FunctionAddress, "OutVertexInstanceIDs", Classes.FArrayProperty);
		GetPolygonVertexInstances_IsValid = GetPolygonVertexInstances_FunctionAddress != IntPtr.Zero && GetPolygonVertexInstances_PolygonID_IsValid && GetPolygonVertexInstances_OutVertexInstanceIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonVertexInstances", GetPolygonVertexInstances_IsValid);
		GetPolygonTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonTriangles");
		GetPolygonTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonTriangles_PolygonID_PropertyAddress, GetPolygonTriangles_FunctionAddress, "PolygonID");
		GetPolygonTriangles_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonTriangles_FunctionAddress, "PolygonID");
		GetPolygonTriangles_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonTriangles_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonTriangles_OutTriangleIDs_PropertyAddress, GetPolygonTriangles_FunctionAddress, "OutTriangleIDs");
		GetPolygonTriangles_OutTriangleIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonTriangles_FunctionAddress, "OutTriangleIDs");
		GetPolygonTriangles_OutTriangleIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonTriangles_FunctionAddress, "OutTriangleIDs", Classes.FArrayProperty);
		GetPolygonTriangles_IsValid = GetPolygonTriangles_FunctionAddress != IntPtr.Zero && GetPolygonTriangles_PolygonID_IsValid && GetPolygonTriangles_OutTriangleIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonTriangles", GetPolygonTriangles_IsValid);
		GetPolygonPolygonGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonPolygonGroup");
		GetPolygonPolygonGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonPolygonGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonPolygonGroup_PolygonID_PropertyAddress, GetPolygonPolygonGroup_FunctionAddress, "PolygonID");
		GetPolygonPolygonGroup_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonPolygonGroup_FunctionAddress, "PolygonID");
		GetPolygonPolygonGroup_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonPolygonGroup_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonPolygonGroup_ReturnValue_PropertyAddress, GetPolygonPolygonGroup_FunctionAddress, "ReturnValue");
		GetPolygonPolygonGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonPolygonGroup_FunctionAddress, "ReturnValue");
		GetPolygonPolygonGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonPolygonGroup_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPolygonPolygonGroup_IsValid = GetPolygonPolygonGroup_FunctionAddress != IntPtr.Zero && GetPolygonPolygonGroup_PolygonID_IsValid && GetPolygonPolygonGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonPolygonGroup", GetPolygonPolygonGroup_IsValid);
		GetPolygonPerimeterEdges_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonPerimeterEdges");
		GetPolygonPerimeterEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonPerimeterEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonPerimeterEdges_PolygonID_PropertyAddress, GetPolygonPerimeterEdges_FunctionAddress, "PolygonID");
		GetPolygonPerimeterEdges_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonPerimeterEdges_FunctionAddress, "PolygonID");
		GetPolygonPerimeterEdges_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonPerimeterEdges_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonPerimeterEdges_OutEdgeIDs_PropertyAddress, GetPolygonPerimeterEdges_FunctionAddress, "OutEdgeIDs");
		GetPolygonPerimeterEdges_OutEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonPerimeterEdges_FunctionAddress, "OutEdgeIDs");
		GetPolygonPerimeterEdges_OutEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonPerimeterEdges_FunctionAddress, "OutEdgeIDs", Classes.FArrayProperty);
		GetPolygonPerimeterEdges_IsValid = GetPolygonPerimeterEdges_FunctionAddress != IntPtr.Zero && GetPolygonPerimeterEdges_PolygonID_IsValid && GetPolygonPerimeterEdges_OutEdgeIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonPerimeterEdges", GetPolygonPerimeterEdges_IsValid);
		GetPolygonInternalEdges_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonInternalEdges");
		GetPolygonInternalEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonInternalEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonInternalEdges_PolygonID_PropertyAddress, GetPolygonInternalEdges_FunctionAddress, "PolygonID");
		GetPolygonInternalEdges_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonInternalEdges_FunctionAddress, "PolygonID");
		GetPolygonInternalEdges_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonInternalEdges_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonInternalEdges_OutEdgeIDs_PropertyAddress, GetPolygonInternalEdges_FunctionAddress, "OutEdgeIDs");
		GetPolygonInternalEdges_OutEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonInternalEdges_FunctionAddress, "OutEdgeIDs");
		GetPolygonInternalEdges_OutEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonInternalEdges_FunctionAddress, "OutEdgeIDs", Classes.FArrayProperty);
		GetPolygonInternalEdges_IsValid = GetPolygonInternalEdges_FunctionAddress != IntPtr.Zero && GetPolygonInternalEdges_PolygonID_IsValid && GetPolygonInternalEdges_OutEdgeIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonInternalEdges", GetPolygonInternalEdges_IsValid);
		GetPolygonGroupPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonGroupPolygons");
		GetPolygonGroupPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonGroupPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonGroupPolygons_PolygonGroupID_PropertyAddress, GetPolygonGroupPolygons_FunctionAddress, "PolygonGroupID");
		GetPolygonGroupPolygons_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonGroupPolygons_FunctionAddress, "PolygonGroupID");
		GetPolygonGroupPolygons_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonGroupPolygons_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonGroupPolygons_OutPolygonIDs_PropertyAddress, GetPolygonGroupPolygons_FunctionAddress, "OutPolygonIDs");
		GetPolygonGroupPolygons_OutPolygonIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonGroupPolygons_FunctionAddress, "OutPolygonIDs");
		GetPolygonGroupPolygons_OutPolygonIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonGroupPolygons_FunctionAddress, "OutPolygonIDs", Classes.FArrayProperty);
		GetPolygonGroupPolygons_IsValid = GetPolygonGroupPolygons_FunctionAddress != IntPtr.Zero && GetPolygonGroupPolygons_PolygonGroupID_IsValid && GetPolygonGroupPolygons_OutPolygonIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonGroupPolygons", GetPolygonGroupPolygons_IsValid);
		GetPolygonGroupCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonGroupCount");
		GetPolygonGroupCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonGroupCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonGroupCount_ReturnValue_PropertyAddress, GetPolygonGroupCount_FunctionAddress, "ReturnValue");
		GetPolygonGroupCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonGroupCount_FunctionAddress, "ReturnValue");
		GetPolygonGroupCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonGroupCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPolygonGroupCount_IsValid = GetPolygonGroupCount_FunctionAddress != IntPtr.Zero && GetPolygonGroupCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonGroupCount", GetPolygonGroupCount_IsValid);
		GetPolygonCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonCount");
		GetPolygonCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonCount_ReturnValue_PropertyAddress, GetPolygonCount_FunctionAddress, "ReturnValue");
		GetPolygonCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonCount_FunctionAddress, "ReturnValue");
		GetPolygonCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPolygonCount_IsValid = GetPolygonCount_FunctionAddress != IntPtr.Zero && GetPolygonCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonCount", GetPolygonCount_IsValid);
		GetPolygonAdjacentPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPolygonAdjacentPolygons");
		GetPolygonAdjacentPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygonAdjacentPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonAdjacentPolygons_PolygonID_PropertyAddress, GetPolygonAdjacentPolygons_FunctionAddress, "PolygonID");
		GetPolygonAdjacentPolygons_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonAdjacentPolygons_FunctionAddress, "PolygonID");
		GetPolygonAdjacentPolygons_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonAdjacentPolygons_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygonAdjacentPolygons_OutPolygonIDs_PropertyAddress, GetPolygonAdjacentPolygons_FunctionAddress, "OutPolygonIDs");
		GetPolygonAdjacentPolygons_OutPolygonIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygonAdjacentPolygons_FunctionAddress, "OutPolygonIDs");
		GetPolygonAdjacentPolygons_OutPolygonIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygonAdjacentPolygons_FunctionAddress, "OutPolygonIDs", Classes.FArrayProperty);
		GetPolygonAdjacentPolygons_IsValid = GetPolygonAdjacentPolygons_FunctionAddress != IntPtr.Zero && GetPolygonAdjacentPolygons_PolygonID_IsValid && GetPolygonAdjacentPolygons_OutPolygonIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetPolygonAdjacentPolygons", GetPolygonAdjacentPolygons_IsValid);
		GetNumVertexVertexInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVertexVertexInstances");
		GetNumVertexVertexInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVertexVertexInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexVertexInstances_VertexID_PropertyAddress, GetNumVertexVertexInstances_FunctionAddress, "VertexID");
		GetNumVertexVertexInstances_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexVertexInstances_FunctionAddress, "VertexID");
		GetNumVertexVertexInstances_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexVertexInstances_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexVertexInstances_ReturnValue_PropertyAddress, GetNumVertexVertexInstances_FunctionAddress, "ReturnValue");
		GetNumVertexVertexInstances_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexVertexInstances_FunctionAddress, "ReturnValue");
		GetNumVertexVertexInstances_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexVertexInstances_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVertexVertexInstances_IsValid = GetNumVertexVertexInstances_FunctionAddress != IntPtr.Zero && GetNumVertexVertexInstances_VertexID_IsValid && GetNumVertexVertexInstances_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexVertexInstances", GetNumVertexVertexInstances_IsValid);
		GetNumVertexInstanceConnectedTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVertexInstanceConnectedTriangles");
		GetNumVertexInstanceConnectedTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVertexInstanceConnectedTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexInstanceConnectedTriangles_VertexInstanceID_PropertyAddress, GetNumVertexInstanceConnectedTriangles_FunctionAddress, "VertexInstanceID");
		GetNumVertexInstanceConnectedTriangles_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexInstanceConnectedTriangles_FunctionAddress, "VertexInstanceID");
		GetNumVertexInstanceConnectedTriangles_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexInstanceConnectedTriangles_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexInstanceConnectedTriangles_ReturnValue_PropertyAddress, GetNumVertexInstanceConnectedTriangles_FunctionAddress, "ReturnValue");
		GetNumVertexInstanceConnectedTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexInstanceConnectedTriangles_FunctionAddress, "ReturnValue");
		GetNumVertexInstanceConnectedTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexInstanceConnectedTriangles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVertexInstanceConnectedTriangles_IsValid = GetNumVertexInstanceConnectedTriangles_FunctionAddress != IntPtr.Zero && GetNumVertexInstanceConnectedTriangles_VertexInstanceID_IsValid && GetNumVertexInstanceConnectedTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexInstanceConnectedTriangles", GetNumVertexInstanceConnectedTriangles_IsValid);
		GetNumVertexInstanceConnectedPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVertexInstanceConnectedPolygons");
		GetNumVertexInstanceConnectedPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVertexInstanceConnectedPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexInstanceConnectedPolygons_VertexInstanceID_PropertyAddress, GetNumVertexInstanceConnectedPolygons_FunctionAddress, "VertexInstanceID");
		GetNumVertexInstanceConnectedPolygons_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexInstanceConnectedPolygons_FunctionAddress, "VertexInstanceID");
		GetNumVertexInstanceConnectedPolygons_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexInstanceConnectedPolygons_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexInstanceConnectedPolygons_ReturnValue_PropertyAddress, GetNumVertexInstanceConnectedPolygons_FunctionAddress, "ReturnValue");
		GetNumVertexInstanceConnectedPolygons_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexInstanceConnectedPolygons_FunctionAddress, "ReturnValue");
		GetNumVertexInstanceConnectedPolygons_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexInstanceConnectedPolygons_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVertexInstanceConnectedPolygons_IsValid = GetNumVertexInstanceConnectedPolygons_FunctionAddress != IntPtr.Zero && GetNumVertexInstanceConnectedPolygons_VertexInstanceID_IsValid && GetNumVertexInstanceConnectedPolygons_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexInstanceConnectedPolygons", GetNumVertexInstanceConnectedPolygons_IsValid);
		GetNumVertexConnectedTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVertexConnectedTriangles");
		GetNumVertexConnectedTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVertexConnectedTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexConnectedTriangles_VertexID_PropertyAddress, GetNumVertexConnectedTriangles_FunctionAddress, "VertexID");
		GetNumVertexConnectedTriangles_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexConnectedTriangles_FunctionAddress, "VertexID");
		GetNumVertexConnectedTriangles_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexConnectedTriangles_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexConnectedTriangles_ReturnValue_PropertyAddress, GetNumVertexConnectedTriangles_FunctionAddress, "ReturnValue");
		GetNumVertexConnectedTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexConnectedTriangles_FunctionAddress, "ReturnValue");
		GetNumVertexConnectedTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexConnectedTriangles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVertexConnectedTriangles_IsValid = GetNumVertexConnectedTriangles_FunctionAddress != IntPtr.Zero && GetNumVertexConnectedTriangles_VertexID_IsValid && GetNumVertexConnectedTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedTriangles", GetNumVertexConnectedTriangles_IsValid);
		GetNumVertexConnectedPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVertexConnectedPolygons");
		GetNumVertexConnectedPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVertexConnectedPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexConnectedPolygons_VertexID_PropertyAddress, GetNumVertexConnectedPolygons_FunctionAddress, "VertexID");
		GetNumVertexConnectedPolygons_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexConnectedPolygons_FunctionAddress, "VertexID");
		GetNumVertexConnectedPolygons_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexConnectedPolygons_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexConnectedPolygons_ReturnValue_PropertyAddress, GetNumVertexConnectedPolygons_FunctionAddress, "ReturnValue");
		GetNumVertexConnectedPolygons_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexConnectedPolygons_FunctionAddress, "ReturnValue");
		GetNumVertexConnectedPolygons_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexConnectedPolygons_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVertexConnectedPolygons_IsValid = GetNumVertexConnectedPolygons_FunctionAddress != IntPtr.Zero && GetNumVertexConnectedPolygons_VertexID_IsValid && GetNumVertexConnectedPolygons_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedPolygons", GetNumVertexConnectedPolygons_IsValid);
		GetNumVertexConnectedEdges_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVertexConnectedEdges");
		GetNumVertexConnectedEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVertexConnectedEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexConnectedEdges_VertexID_PropertyAddress, GetNumVertexConnectedEdges_FunctionAddress, "VertexID");
		GetNumVertexConnectedEdges_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexConnectedEdges_FunctionAddress, "VertexID");
		GetNumVertexConnectedEdges_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexConnectedEdges_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumVertexConnectedEdges_ReturnValue_PropertyAddress, GetNumVertexConnectedEdges_FunctionAddress, "ReturnValue");
		GetNumVertexConnectedEdges_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVertexConnectedEdges_FunctionAddress, "ReturnValue");
		GetNumVertexConnectedEdges_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVertexConnectedEdges_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVertexConnectedEdges_IsValid = GetNumVertexConnectedEdges_FunctionAddress != IntPtr.Zero && GetNumVertexConnectedEdges_VertexID_IsValid && GetNumVertexConnectedEdges_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumVertexConnectedEdges", GetNumVertexConnectedEdges_IsValid);
		GetNumPolygonVertices_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumPolygonVertices");
		GetNumPolygonVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumPolygonVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonVertices_PolygonID_PropertyAddress, GetNumPolygonVertices_FunctionAddress, "PolygonID");
		GetNumPolygonVertices_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonVertices_FunctionAddress, "PolygonID");
		GetNumPolygonVertices_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonVertices_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonVertices_ReturnValue_PropertyAddress, GetNumPolygonVertices_FunctionAddress, "ReturnValue");
		GetNumPolygonVertices_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonVertices_FunctionAddress, "ReturnValue");
		GetNumPolygonVertices_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonVertices_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumPolygonVertices_IsValid = GetNumPolygonVertices_FunctionAddress != IntPtr.Zero && GetNumPolygonVertices_PolygonID_IsValid && GetNumPolygonVertices_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonVertices", GetNumPolygonVertices_IsValid);
		GetNumPolygonTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumPolygonTriangles");
		GetNumPolygonTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumPolygonTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonTriangles_PolygonID_PropertyAddress, GetNumPolygonTriangles_FunctionAddress, "PolygonID");
		GetNumPolygonTriangles_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonTriangles_FunctionAddress, "PolygonID");
		GetNumPolygonTriangles_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonTriangles_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonTriangles_ReturnValue_PropertyAddress, GetNumPolygonTriangles_FunctionAddress, "ReturnValue");
		GetNumPolygonTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonTriangles_FunctionAddress, "ReturnValue");
		GetNumPolygonTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonTriangles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumPolygonTriangles_IsValid = GetNumPolygonTriangles_FunctionAddress != IntPtr.Zero && GetNumPolygonTriangles_PolygonID_IsValid && GetNumPolygonTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonTriangles", GetNumPolygonTriangles_IsValid);
		GetNumPolygonInternalEdges_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumPolygonInternalEdges");
		GetNumPolygonInternalEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumPolygonInternalEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonInternalEdges_PolygonID_PropertyAddress, GetNumPolygonInternalEdges_FunctionAddress, "PolygonID");
		GetNumPolygonInternalEdges_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonInternalEdges_FunctionAddress, "PolygonID");
		GetNumPolygonInternalEdges_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonInternalEdges_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonInternalEdges_ReturnValue_PropertyAddress, GetNumPolygonInternalEdges_FunctionAddress, "ReturnValue");
		GetNumPolygonInternalEdges_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonInternalEdges_FunctionAddress, "ReturnValue");
		GetNumPolygonInternalEdges_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonInternalEdges_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumPolygonInternalEdges_IsValid = GetNumPolygonInternalEdges_FunctionAddress != IntPtr.Zero && GetNumPolygonInternalEdges_PolygonID_IsValid && GetNumPolygonInternalEdges_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonInternalEdges", GetNumPolygonInternalEdges_IsValid);
		GetNumPolygonGroupPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumPolygonGroupPolygons");
		GetNumPolygonGroupPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumPolygonGroupPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonGroupPolygons_PolygonGroupID_PropertyAddress, GetNumPolygonGroupPolygons_FunctionAddress, "PolygonGroupID");
		GetNumPolygonGroupPolygons_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonGroupPolygons_FunctionAddress, "PolygonGroupID");
		GetNumPolygonGroupPolygons_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonGroupPolygons_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumPolygonGroupPolygons_ReturnValue_PropertyAddress, GetNumPolygonGroupPolygons_FunctionAddress, "ReturnValue");
		GetNumPolygonGroupPolygons_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumPolygonGroupPolygons_FunctionAddress, "ReturnValue");
		GetNumPolygonGroupPolygons_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumPolygonGroupPolygons_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumPolygonGroupPolygons_IsValid = GetNumPolygonGroupPolygons_FunctionAddress != IntPtr.Zero && GetNumPolygonGroupPolygons_PolygonGroupID_IsValid && GetNumPolygonGroupPolygons_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumPolygonGroupPolygons", GetNumPolygonGroupPolygons_IsValid);
		GetNumEdgeConnectedTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumEdgeConnectedTriangles");
		GetNumEdgeConnectedTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumEdgeConnectedTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumEdgeConnectedTriangles_EdgeID_PropertyAddress, GetNumEdgeConnectedTriangles_FunctionAddress, "EdgeID");
		GetNumEdgeConnectedTriangles_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumEdgeConnectedTriangles_FunctionAddress, "EdgeID");
		GetNumEdgeConnectedTriangles_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumEdgeConnectedTriangles_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumEdgeConnectedTriangles_ReturnValue_PropertyAddress, GetNumEdgeConnectedTriangles_FunctionAddress, "ReturnValue");
		GetNumEdgeConnectedTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumEdgeConnectedTriangles_FunctionAddress, "ReturnValue");
		GetNumEdgeConnectedTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumEdgeConnectedTriangles_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumEdgeConnectedTriangles_IsValid = GetNumEdgeConnectedTriangles_FunctionAddress != IntPtr.Zero && GetNumEdgeConnectedTriangles_EdgeID_IsValid && GetNumEdgeConnectedTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumEdgeConnectedTriangles", GetNumEdgeConnectedTriangles_IsValid);
		GetNumEdgeConnectedPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumEdgeConnectedPolygons");
		GetNumEdgeConnectedPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumEdgeConnectedPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumEdgeConnectedPolygons_EdgeID_PropertyAddress, GetNumEdgeConnectedPolygons_FunctionAddress, "EdgeID");
		GetNumEdgeConnectedPolygons_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(GetNumEdgeConnectedPolygons_FunctionAddress, "EdgeID");
		GetNumEdgeConnectedPolygons_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumEdgeConnectedPolygons_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumEdgeConnectedPolygons_ReturnValue_PropertyAddress, GetNumEdgeConnectedPolygons_FunctionAddress, "ReturnValue");
		GetNumEdgeConnectedPolygons_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumEdgeConnectedPolygons_FunctionAddress, "ReturnValue");
		GetNumEdgeConnectedPolygons_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumEdgeConnectedPolygons_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumEdgeConnectedPolygons_IsValid = GetNumEdgeConnectedPolygons_FunctionAddress != IntPtr.Zero && GetNumEdgeConnectedPolygons_EdgeID_IsValid && GetNumEdgeConnectedPolygons_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetNumEdgeConnectedPolygons", GetNumEdgeConnectedPolygons_IsValid);
		GetEdgeVertices_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEdgeVertices");
		GetEdgeVertices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEdgeVertices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeVertices_EdgeID_PropertyAddress, GetEdgeVertices_FunctionAddress, "EdgeID");
		GetEdgeVertices_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeVertices_FunctionAddress, "EdgeID");
		GetEdgeVertices_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeVertices_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeVertices_OutVertexIDs_PropertyAddress, GetEdgeVertices_FunctionAddress, "OutVertexIDs");
		GetEdgeVertices_OutVertexIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeVertices_FunctionAddress, "OutVertexIDs");
		GetEdgeVertices_OutVertexIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeVertices_FunctionAddress, "OutVertexIDs", Classes.FArrayProperty);
		GetEdgeVertices_IsValid = GetEdgeVertices_FunctionAddress != IntPtr.Zero && GetEdgeVertices_EdgeID_IsValid && GetEdgeVertices_OutVertexIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetEdgeVertices", GetEdgeVertices_IsValid);
		GetEdgeVertex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEdgeVertex");
		GetEdgeVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEdgeVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeVertex_EdgeID_PropertyAddress, GetEdgeVertex_FunctionAddress, "EdgeID");
		GetEdgeVertex_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeVertex_FunctionAddress, "EdgeID");
		GetEdgeVertex_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeVertex_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeVertex_VertexNumber_PropertyAddress, GetEdgeVertex_FunctionAddress, "VertexNumber");
		GetEdgeVertex_VertexNumber_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeVertex_FunctionAddress, "VertexNumber");
		GetEdgeVertex_VertexNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeVertex_FunctionAddress, "VertexNumber", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeVertex_ReturnValue_PropertyAddress, GetEdgeVertex_FunctionAddress, "ReturnValue");
		GetEdgeVertex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeVertex_FunctionAddress, "ReturnValue");
		GetEdgeVertex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeVertex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEdgeVertex_IsValid = GetEdgeVertex_FunctionAddress != IntPtr.Zero && GetEdgeVertex_EdgeID_IsValid && GetEdgeVertex_VertexNumber_IsValid && GetEdgeVertex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetEdgeVertex", GetEdgeVertex_IsValid);
		GetEdgeCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEdgeCount");
		GetEdgeCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEdgeCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeCount_ReturnValue_PropertyAddress, GetEdgeCount_FunctionAddress, "ReturnValue");
		GetEdgeCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeCount_FunctionAddress, "ReturnValue");
		GetEdgeCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetEdgeCount_IsValid = GetEdgeCount_FunctionAddress != IntPtr.Zero && GetEdgeCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetEdgeCount", GetEdgeCount_IsValid);
		GetEdgeConnectedTriangles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEdgeConnectedTriangles");
		GetEdgeConnectedTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEdgeConnectedTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeConnectedTriangles_EdgeID_PropertyAddress, GetEdgeConnectedTriangles_FunctionAddress, "EdgeID");
		GetEdgeConnectedTriangles_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeConnectedTriangles_FunctionAddress, "EdgeID");
		GetEdgeConnectedTriangles_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeConnectedTriangles_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeConnectedTriangles_OutConnectedTriangleIDs_PropertyAddress, GetEdgeConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs");
		GetEdgeConnectedTriangles_OutConnectedTriangleIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs");
		GetEdgeConnectedTriangles_OutConnectedTriangleIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeConnectedTriangles_FunctionAddress, "OutConnectedTriangleIDs", Classes.FArrayProperty);
		GetEdgeConnectedTriangles_IsValid = GetEdgeConnectedTriangles_FunctionAddress != IntPtr.Zero && GetEdgeConnectedTriangles_EdgeID_IsValid && GetEdgeConnectedTriangles_OutConnectedTriangleIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetEdgeConnectedTriangles", GetEdgeConnectedTriangles_IsValid);
		GetEdgeConnectedPolygons_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEdgeConnectedPolygons");
		GetEdgeConnectedPolygons_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEdgeConnectedPolygons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeConnectedPolygons_EdgeID_PropertyAddress, GetEdgeConnectedPolygons_FunctionAddress, "EdgeID");
		GetEdgeConnectedPolygons_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeConnectedPolygons_FunctionAddress, "EdgeID");
		GetEdgeConnectedPolygons_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeConnectedPolygons_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEdgeConnectedPolygons_OutConnectedPolygonIDs_PropertyAddress, GetEdgeConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs");
		GetEdgeConnectedPolygons_OutConnectedPolygonIDs_Offset = NativeReflectionCached.GetPropertyOffset(GetEdgeConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs");
		GetEdgeConnectedPolygons_OutConnectedPolygonIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEdgeConnectedPolygons_FunctionAddress, "OutConnectedPolygonIDs", Classes.FArrayProperty);
		GetEdgeConnectedPolygons_IsValid = GetEdgeConnectedPolygons_FunctionAddress != IntPtr.Zero && GetEdgeConnectedPolygons_EdgeID_IsValid && GetEdgeConnectedPolygons_OutConnectedPolygonIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:GetEdgeConnectedPolygons", GetEdgeConnectedPolygons_IsValid);
		Empty_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Empty");
		Empty_ParamsSize = NativeReflection.GetFunctionParamsSize(Empty_FunctionAddress);
		Empty_IsValid = Empty_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:Empty", Empty_IsValid);
		DeleteVertexInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteVertexInstance");
		DeleteVertexInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteVertexInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertexInstance_VertexInstanceID_PropertyAddress, DeleteVertexInstance_FunctionAddress, "VertexInstanceID");
		DeleteVertexInstance_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertexInstance_FunctionAddress, "VertexInstanceID");
		DeleteVertexInstance_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertexInstance_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertexInstance_OrphanedVertices_PropertyAddress, DeleteVertexInstance_FunctionAddress, "OrphanedVertices");
		DeleteVertexInstance_OrphanedVertices_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertexInstance_FunctionAddress, "OrphanedVertices");
		DeleteVertexInstance_OrphanedVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertexInstance_FunctionAddress, "OrphanedVertices", Classes.FArrayProperty);
		DeleteVertexInstance_IsValid = DeleteVertexInstance_FunctionAddress != IntPtr.Zero && DeleteVertexInstance_VertexInstanceID_IsValid && DeleteVertexInstance_OrphanedVertices_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:DeleteVertexInstance", DeleteVertexInstance_IsValid);
		DeleteVertex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteVertex");
		DeleteVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteVertex_VertexID_PropertyAddress, DeleteVertex_FunctionAddress, "VertexID");
		DeleteVertex_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteVertex_FunctionAddress, "VertexID");
		DeleteVertex_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteVertex_FunctionAddress, "VertexID", Classes.FStructProperty);
		DeleteVertex_IsValid = DeleteVertex_FunctionAddress != IntPtr.Zero && DeleteVertex_VertexID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:DeleteVertex", DeleteVertex_IsValid);
		DeleteTriangle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteTriangle");
		DeleteTriangle_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteTriangle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangle_TriangleID_PropertyAddress, DeleteTriangle_FunctionAddress, "TriangleID");
		DeleteTriangle_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangle_FunctionAddress, "TriangleID");
		DeleteTriangle_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangle_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangle_OrphanedEdges_PropertyAddress, DeleteTriangle_FunctionAddress, "OrphanedEdges");
		DeleteTriangle_OrphanedEdges_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangle_FunctionAddress, "OrphanedEdges");
		DeleteTriangle_OrphanedEdges_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangle_FunctionAddress, "OrphanedEdges", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangle_OrphanedVertexInstances_PropertyAddress, DeleteTriangle_FunctionAddress, "OrphanedVertexInstances");
		DeleteTriangle_OrphanedVertexInstances_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangle_FunctionAddress, "OrphanedVertexInstances");
		DeleteTriangle_OrphanedVertexInstances_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangle_FunctionAddress, "OrphanedVertexInstances", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTriangle_OrphanedPolygonGroupsPtr_PropertyAddress, DeleteTriangle_FunctionAddress, "OrphanedPolygonGroupsPtr");
		DeleteTriangle_OrphanedPolygonGroupsPtr_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTriangle_FunctionAddress, "OrphanedPolygonGroupsPtr");
		DeleteTriangle_OrphanedPolygonGroupsPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTriangle_FunctionAddress, "OrphanedPolygonGroupsPtr", Classes.FArrayProperty);
		DeleteTriangle_IsValid = DeleteTriangle_FunctionAddress != IntPtr.Zero && DeleteTriangle_TriangleID_IsValid && DeleteTriangle_OrphanedEdges_IsValid && DeleteTriangle_OrphanedVertexInstances_IsValid && DeleteTriangle_OrphanedPolygonGroupsPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:DeleteTriangle", DeleteTriangle_IsValid);
		DeletePolygonGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeletePolygonGroup");
		DeletePolygonGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(DeletePolygonGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeletePolygonGroup_PolygonGroupID_PropertyAddress, DeletePolygonGroup_FunctionAddress, "PolygonGroupID");
		DeletePolygonGroup_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(DeletePolygonGroup_FunctionAddress, "PolygonGroupID");
		DeletePolygonGroup_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeletePolygonGroup_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		DeletePolygonGroup_IsValid = DeletePolygonGroup_FunctionAddress != IntPtr.Zero && DeletePolygonGroup_PolygonGroupID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:DeletePolygonGroup", DeletePolygonGroup_IsValid);
		DeletePolygon_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeletePolygon");
		DeletePolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(DeletePolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeletePolygon_PolygonID_PropertyAddress, DeletePolygon_FunctionAddress, "PolygonID");
		DeletePolygon_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(DeletePolygon_FunctionAddress, "PolygonID");
		DeletePolygon_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeletePolygon_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeletePolygon_OrphanedEdges_PropertyAddress, DeletePolygon_FunctionAddress, "OrphanedEdges");
		DeletePolygon_OrphanedEdges_Offset = NativeReflectionCached.GetPropertyOffset(DeletePolygon_FunctionAddress, "OrphanedEdges");
		DeletePolygon_OrphanedEdges_IsValid = NativeReflectionCached.ValidatePropertyClass(DeletePolygon_FunctionAddress, "OrphanedEdges", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeletePolygon_OrphanedVertexInstances_PropertyAddress, DeletePolygon_FunctionAddress, "OrphanedVertexInstances");
		DeletePolygon_OrphanedVertexInstances_Offset = NativeReflectionCached.GetPropertyOffset(DeletePolygon_FunctionAddress, "OrphanedVertexInstances");
		DeletePolygon_OrphanedVertexInstances_IsValid = NativeReflectionCached.ValidatePropertyClass(DeletePolygon_FunctionAddress, "OrphanedVertexInstances", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeletePolygon_OrphanedPolygonGroups_PropertyAddress, DeletePolygon_FunctionAddress, "OrphanedPolygonGroups");
		DeletePolygon_OrphanedPolygonGroups_Offset = NativeReflectionCached.GetPropertyOffset(DeletePolygon_FunctionAddress, "OrphanedPolygonGroups");
		DeletePolygon_OrphanedPolygonGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(DeletePolygon_FunctionAddress, "OrphanedPolygonGroups", Classes.FArrayProperty);
		DeletePolygon_IsValid = DeletePolygon_FunctionAddress != IntPtr.Zero && DeletePolygon_PolygonID_IsValid && DeletePolygon_OrphanedEdges_IsValid && DeletePolygon_OrphanedVertexInstances_IsValid && DeletePolygon_OrphanedPolygonGroups_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:DeletePolygon", DeletePolygon_IsValid);
		DeleteEdge_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteEdge");
		DeleteEdge_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteEdge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteEdge_EdgeID_PropertyAddress, DeleteEdge_FunctionAddress, "EdgeID");
		DeleteEdge_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteEdge_FunctionAddress, "EdgeID");
		DeleteEdge_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteEdge_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteEdge_OrphanedVertices_PropertyAddress, DeleteEdge_FunctionAddress, "OrphanedVertices");
		DeleteEdge_OrphanedVertices_Offset = NativeReflectionCached.GetPropertyOffset(DeleteEdge_FunctionAddress, "OrphanedVertices");
		DeleteEdge_OrphanedVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteEdge_FunctionAddress, "OrphanedVertices", Classes.FArrayProperty);
		DeleteEdge_IsValid = DeleteEdge_FunctionAddress != IntPtr.Zero && DeleteEdge_EdgeID_IsValid && DeleteEdge_OrphanedVertices_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:DeleteEdge", DeleteEdge_IsValid);
		CreateVertexWithID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateVertexWithID");
		CreateVertexWithID_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateVertexWithID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateVertexWithID_VertexID_PropertyAddress, CreateVertexWithID_FunctionAddress, "VertexID");
		CreateVertexWithID_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(CreateVertexWithID_FunctionAddress, "VertexID");
		CreateVertexWithID_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVertexWithID_FunctionAddress, "VertexID", Classes.FStructProperty);
		CreateVertexWithID_IsValid = CreateVertexWithID_FunctionAddress != IntPtr.Zero && CreateVertexWithID_VertexID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateVertexWithID", CreateVertexWithID_IsValid);
		CreateVertexInstanceWithID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateVertexInstanceWithID");
		CreateVertexInstanceWithID_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateVertexInstanceWithID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateVertexInstanceWithID_VertexInstanceID_PropertyAddress, CreateVertexInstanceWithID_FunctionAddress, "VertexInstanceID");
		CreateVertexInstanceWithID_VertexInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(CreateVertexInstanceWithID_FunctionAddress, "VertexInstanceID");
		CreateVertexInstanceWithID_VertexInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVertexInstanceWithID_FunctionAddress, "VertexInstanceID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVertexInstanceWithID_VertexID_PropertyAddress, CreateVertexInstanceWithID_FunctionAddress, "VertexID");
		CreateVertexInstanceWithID_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(CreateVertexInstanceWithID_FunctionAddress, "VertexID");
		CreateVertexInstanceWithID_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVertexInstanceWithID_FunctionAddress, "VertexID", Classes.FStructProperty);
		CreateVertexInstanceWithID_IsValid = CreateVertexInstanceWithID_FunctionAddress != IntPtr.Zero && CreateVertexInstanceWithID_VertexInstanceID_IsValid && CreateVertexInstanceWithID_VertexID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateVertexInstanceWithID", CreateVertexInstanceWithID_IsValid);
		CreateVertexInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateVertexInstance");
		CreateVertexInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateVertexInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateVertexInstance_VertexID_PropertyAddress, CreateVertexInstance_FunctionAddress, "VertexID");
		CreateVertexInstance_VertexID_Offset = NativeReflectionCached.GetPropertyOffset(CreateVertexInstance_FunctionAddress, "VertexID");
		CreateVertexInstance_VertexID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVertexInstance_FunctionAddress, "VertexID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateVertexInstance_ReturnValue_PropertyAddress, CreateVertexInstance_FunctionAddress, "ReturnValue");
		CreateVertexInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateVertexInstance_FunctionAddress, "ReturnValue");
		CreateVertexInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVertexInstance_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateVertexInstance_IsValid = CreateVertexInstance_FunctionAddress != IntPtr.Zero && CreateVertexInstance_VertexID_IsValid && CreateVertexInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateVertexInstance", CreateVertexInstance_IsValid);
		CreateVertex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateVertex");
		CreateVertex_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateVertex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateVertex_ReturnValue_PropertyAddress, CreateVertex_FunctionAddress, "ReturnValue");
		CreateVertex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateVertex_FunctionAddress, "ReturnValue");
		CreateVertex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateVertex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateVertex_IsValid = CreateVertex_FunctionAddress != IntPtr.Zero && CreateVertex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateVertex", CreateVertex_IsValid);
		CreateTriangleWithID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateTriangleWithID");
		CreateTriangleWithID_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTriangleWithID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangleWithID_TriangleID_PropertyAddress, CreateTriangleWithID_FunctionAddress, "TriangleID");
		CreateTriangleWithID_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangleWithID_FunctionAddress, "TriangleID");
		CreateTriangleWithID_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangleWithID_FunctionAddress, "TriangleID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangleWithID_PolygonGroupID_PropertyAddress, CreateTriangleWithID_FunctionAddress, "PolygonGroupID");
		CreateTriangleWithID_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangleWithID_FunctionAddress, "PolygonGroupID");
		CreateTriangleWithID_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangleWithID_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangleWithID_VertexInstanceIDs_PropertyAddress, CreateTriangleWithID_FunctionAddress, "VertexInstanceIDs");
		CreateTriangleWithID_VertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangleWithID_FunctionAddress, "VertexInstanceIDs");
		CreateTriangleWithID_VertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangleWithID_FunctionAddress, "VertexInstanceIDs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangleWithID_NewEdgeIDs_PropertyAddress, CreateTriangleWithID_FunctionAddress, "NewEdgeIDs");
		CreateTriangleWithID_NewEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangleWithID_FunctionAddress, "NewEdgeIDs");
		CreateTriangleWithID_NewEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangleWithID_FunctionAddress, "NewEdgeIDs", Classes.FArrayProperty);
		CreateTriangleWithID_IsValid = CreateTriangleWithID_FunctionAddress != IntPtr.Zero && CreateTriangleWithID_TriangleID_IsValid && CreateTriangleWithID_PolygonGroupID_IsValid && CreateTriangleWithID_VertexInstanceIDs_IsValid && CreateTriangleWithID_NewEdgeIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateTriangleWithID", CreateTriangleWithID_IsValid);
		CreateTriangle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateTriangle");
		CreateTriangle_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTriangle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangle_PolygonGroupID_PropertyAddress, CreateTriangle_FunctionAddress, "PolygonGroupID");
		CreateTriangle_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangle_FunctionAddress, "PolygonGroupID");
		CreateTriangle_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangle_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangle_VertexInstanceIDs_PropertyAddress, CreateTriangle_FunctionAddress, "VertexInstanceIDs");
		CreateTriangle_VertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangle_FunctionAddress, "VertexInstanceIDs");
		CreateTriangle_VertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangle_FunctionAddress, "VertexInstanceIDs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangle_NewEdgeIDs_PropertyAddress, CreateTriangle_FunctionAddress, "NewEdgeIDs");
		CreateTriangle_NewEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangle_FunctionAddress, "NewEdgeIDs");
		CreateTriangle_NewEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangle_FunctionAddress, "NewEdgeIDs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTriangle_ReturnValue_PropertyAddress, CreateTriangle_FunctionAddress, "ReturnValue");
		CreateTriangle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTriangle_FunctionAddress, "ReturnValue");
		CreateTriangle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTriangle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateTriangle_IsValid = CreateTriangle_FunctionAddress != IntPtr.Zero && CreateTriangle_PolygonGroupID_IsValid && CreateTriangle_VertexInstanceIDs_IsValid && CreateTriangle_NewEdgeIDs_IsValid && CreateTriangle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateTriangle", CreateTriangle_IsValid);
		CreatePolygonWithID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreatePolygonWithID");
		CreatePolygonWithID_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePolygonWithID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygonWithID_PolygonID_PropertyAddress, CreatePolygonWithID_FunctionAddress, "PolygonID");
		CreatePolygonWithID_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygonWithID_FunctionAddress, "PolygonID");
		CreatePolygonWithID_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygonWithID_FunctionAddress, "PolygonID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygonWithID_PolygonGroupID_PropertyAddress, CreatePolygonWithID_FunctionAddress, "PolygonGroupID");
		CreatePolygonWithID_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygonWithID_FunctionAddress, "PolygonGroupID");
		CreatePolygonWithID_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygonWithID_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygonWithID_VertexInstanceIDs_PropertyAddress, CreatePolygonWithID_FunctionAddress, "VertexInstanceIDs");
		CreatePolygonWithID_VertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygonWithID_FunctionAddress, "VertexInstanceIDs");
		CreatePolygonWithID_VertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygonWithID_FunctionAddress, "VertexInstanceIDs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygonWithID_NewEdgeIDs_PropertyAddress, CreatePolygonWithID_FunctionAddress, "NewEdgeIDs");
		CreatePolygonWithID_NewEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygonWithID_FunctionAddress, "NewEdgeIDs");
		CreatePolygonWithID_NewEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygonWithID_FunctionAddress, "NewEdgeIDs", Classes.FArrayProperty);
		CreatePolygonWithID_IsValid = CreatePolygonWithID_FunctionAddress != IntPtr.Zero && CreatePolygonWithID_PolygonID_IsValid && CreatePolygonWithID_PolygonGroupID_IsValid && CreatePolygonWithID_VertexInstanceIDs_IsValid && CreatePolygonWithID_NewEdgeIDs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonWithID", CreatePolygonWithID_IsValid);
		CreatePolygonGroupWithID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreatePolygonGroupWithID");
		CreatePolygonGroupWithID_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePolygonGroupWithID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygonGroupWithID_PolygonGroupID_PropertyAddress, CreatePolygonGroupWithID_FunctionAddress, "PolygonGroupID");
		CreatePolygonGroupWithID_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygonGroupWithID_FunctionAddress, "PolygonGroupID");
		CreatePolygonGroupWithID_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygonGroupWithID_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		CreatePolygonGroupWithID_IsValid = CreatePolygonGroupWithID_FunctionAddress != IntPtr.Zero && CreatePolygonGroupWithID_PolygonGroupID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonGroupWithID", CreatePolygonGroupWithID_IsValid);
		CreatePolygonGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreatePolygonGroup");
		CreatePolygonGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePolygonGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygonGroup_ReturnValue_PropertyAddress, CreatePolygonGroup_FunctionAddress, "ReturnValue");
		CreatePolygonGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygonGroup_FunctionAddress, "ReturnValue");
		CreatePolygonGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygonGroup_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreatePolygonGroup_IsValid = CreatePolygonGroup_FunctionAddress != IntPtr.Zero && CreatePolygonGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreatePolygonGroup", CreatePolygonGroup_IsValid);
		CreatePolygon_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreatePolygon");
		CreatePolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygon_PolygonGroupID_PropertyAddress, CreatePolygon_FunctionAddress, "PolygonGroupID");
		CreatePolygon_PolygonGroupID_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygon_FunctionAddress, "PolygonGroupID");
		CreatePolygon_PolygonGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygon_FunctionAddress, "PolygonGroupID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygon_VertexInstanceIDs_PropertyAddress, CreatePolygon_FunctionAddress, "VertexInstanceIDs");
		CreatePolygon_VertexInstanceIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygon_FunctionAddress, "VertexInstanceIDs");
		CreatePolygon_VertexInstanceIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygon_FunctionAddress, "VertexInstanceIDs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygon_NewEdgeIDs_PropertyAddress, CreatePolygon_FunctionAddress, "NewEdgeIDs");
		CreatePolygon_NewEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygon_FunctionAddress, "NewEdgeIDs");
		CreatePolygon_NewEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygon_FunctionAddress, "NewEdgeIDs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePolygon_ReturnValue_PropertyAddress, CreatePolygon_FunctionAddress, "ReturnValue");
		CreatePolygon_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreatePolygon_FunctionAddress, "ReturnValue");
		CreatePolygon_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePolygon_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreatePolygon_IsValid = CreatePolygon_FunctionAddress != IntPtr.Zero && CreatePolygon_PolygonGroupID_IsValid && CreatePolygon_VertexInstanceIDs_IsValid && CreatePolygon_NewEdgeIDs_IsValid && CreatePolygon_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreatePolygon", CreatePolygon_IsValid);
		CreateEdgeWithID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateEdgeWithID");
		CreateEdgeWithID_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateEdgeWithID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateEdgeWithID_EdgeID_PropertyAddress, CreateEdgeWithID_FunctionAddress, "EdgeID");
		CreateEdgeWithID_EdgeID_Offset = NativeReflectionCached.GetPropertyOffset(CreateEdgeWithID_FunctionAddress, "EdgeID");
		CreateEdgeWithID_EdgeID_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEdgeWithID_FunctionAddress, "EdgeID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEdgeWithID_VertexID0_PropertyAddress, CreateEdgeWithID_FunctionAddress, "VertexID0");
		CreateEdgeWithID_VertexID0_Offset = NativeReflectionCached.GetPropertyOffset(CreateEdgeWithID_FunctionAddress, "VertexID0");
		CreateEdgeWithID_VertexID0_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEdgeWithID_FunctionAddress, "VertexID0", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEdgeWithID_VertexID1_PropertyAddress, CreateEdgeWithID_FunctionAddress, "VertexID1");
		CreateEdgeWithID_VertexID1_Offset = NativeReflectionCached.GetPropertyOffset(CreateEdgeWithID_FunctionAddress, "VertexID1");
		CreateEdgeWithID_VertexID1_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEdgeWithID_FunctionAddress, "VertexID1", Classes.FStructProperty);
		CreateEdgeWithID_IsValid = CreateEdgeWithID_FunctionAddress != IntPtr.Zero && CreateEdgeWithID_EdgeID_IsValid && CreateEdgeWithID_VertexID0_IsValid && CreateEdgeWithID_VertexID1_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateEdgeWithID", CreateEdgeWithID_IsValid);
		CreateEdge_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateEdge");
		CreateEdge_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateEdge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateEdge_VertexID0_PropertyAddress, CreateEdge_FunctionAddress, "VertexID0");
		CreateEdge_VertexID0_Offset = NativeReflectionCached.GetPropertyOffset(CreateEdge_FunctionAddress, "VertexID0");
		CreateEdge_VertexID0_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEdge_FunctionAddress, "VertexID0", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEdge_VertexID1_PropertyAddress, CreateEdge_FunctionAddress, "VertexID1");
		CreateEdge_VertexID1_Offset = NativeReflectionCached.GetPropertyOffset(CreateEdge_FunctionAddress, "VertexID1");
		CreateEdge_VertexID1_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEdge_FunctionAddress, "VertexID1", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEdge_ReturnValue_PropertyAddress, CreateEdge_FunctionAddress, "ReturnValue");
		CreateEdge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateEdge_FunctionAddress, "ReturnValue");
		CreateEdge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEdge_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateEdge_IsValid = CreateEdge_FunctionAddress != IntPtr.Zero && CreateEdge_VertexID0_IsValid && CreateEdge_VertexID1_IsValid && CreateEdge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:CreateEdge", CreateEdge_IsValid);
		ComputePolygonTriangulation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ComputePolygonTriangulation");
		ComputePolygonTriangulation_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputePolygonTriangulation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputePolygonTriangulation_PolygonID_PropertyAddress, ComputePolygonTriangulation_FunctionAddress, "PolygonID");
		ComputePolygonTriangulation_PolygonID_Offset = NativeReflectionCached.GetPropertyOffset(ComputePolygonTriangulation_FunctionAddress, "PolygonID");
		ComputePolygonTriangulation_PolygonID_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputePolygonTriangulation_FunctionAddress, "PolygonID", Classes.FStructProperty);
		ComputePolygonTriangulation_IsValid = ComputePolygonTriangulation_FunctionAddress != IntPtr.Zero && ComputePolygonTriangulation_PolygonID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MeshDescription.MeshDescriptionBase:ComputePolygonTriangulation", ComputePolygonTriangulation_IsValid);
	}
}
