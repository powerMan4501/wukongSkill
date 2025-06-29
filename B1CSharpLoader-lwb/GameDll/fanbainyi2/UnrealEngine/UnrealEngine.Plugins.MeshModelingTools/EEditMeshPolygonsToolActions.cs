using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EEditMeshPolygonsToolActions", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EEditMeshPolygonsToolActions
{
	NoAction,
	AcceptCurrent,
	CancelCurrent,
	Extrude,
	PushPull,
	Offset,
	Inset,
	Outset,
	BevelFaces,
	InsertEdge,
	InsertEdgeLoop,
	Complete,
	PlaneCut,
	Merge,
	Delete,
	CutFaces,
	RecalculateNormals,
	FlipNormals,
	Retriangulate,
	Decompose,
	Disconnect,
	Duplicate,
	CollapseEdge,
	WeldEdges,
	StraightenEdge,
	FillHole,
	BevelEdges,
	PlanarProjectionUV,
	SimplifyByGroups,
	PokeSingleFace,
	SplitSingleEdge,
	FlipSingleEdge,
	CollapseSingleEdge
}
