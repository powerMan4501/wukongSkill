using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshSimplification_CsExtensions
{
	public static UDynamicMesh ApplySimplifyToVertexCount(this UDynamicMesh TargetMesh, int VertexCount, FGeometryScriptSimplifyMeshOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSimplification.ApplySimplifyToVertexCount(TargetMesh, VertexCount, Options, Debug);
	}

	public static UDynamicMesh ApplySimplifyToTriangleCount(this UDynamicMesh TargetMesh, int TriangleCount, FGeometryScriptSimplifyMeshOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSimplification.ApplySimplifyToTriangleCount(TargetMesh, TriangleCount, Options, Debug);
	}

	public static UDynamicMesh ApplySimplifyToTolerance(this UDynamicMesh TargetMesh, float Tolerance, FGeometryScriptSimplifyMeshOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSimplification.ApplySimplifyToTolerance(TargetMesh, Tolerance, Options, Debug);
	}

	public static UDynamicMesh ApplySimplifyToPolygroupTopology(this UDynamicMesh TargetMesh, FGeometryScriptPolygroupSimplifyOptions Options, FGeometryScriptGroupLayer GroupLayer, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSimplification.ApplySimplifyToPolygroupTopology(TargetMesh, Options, GroupLayer, Debug);
	}

	public static UDynamicMesh ApplySimplifyToPlanar(this UDynamicMesh TargetMesh, FGeometryScriptPlanarSimplifyOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSimplification.ApplySimplifyToPlanar(TargetMesh, Options, Debug);
	}
}
