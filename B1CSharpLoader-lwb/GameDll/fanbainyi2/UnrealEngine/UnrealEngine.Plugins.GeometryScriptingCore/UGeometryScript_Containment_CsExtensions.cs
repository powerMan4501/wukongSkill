using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_Containment_CsExtensions
{
	public static UDynamicMesh ComputeMeshSweptHull(this UDynamicMesh TargetMesh, ref UDynamicMesh CopyToMesh, out UDynamicMesh CopyToMeshOut, FTransform ProjectionFrame, FGeometryScriptSweptHullOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Containment.ComputeMeshSweptHull(TargetMesh, ref CopyToMesh, out CopyToMeshOut, ProjectionFrame, Options, Debug);
	}

	public static UDynamicMesh ComputeMeshConvexHull(this UDynamicMesh TargetMesh, ref UDynamicMesh CopyToMesh, out UDynamicMesh CopyToMeshOut, FGeometryScriptConvexHullOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Containment.ComputeMeshConvexHull(TargetMesh, ref CopyToMesh, out CopyToMeshOut, Options, Debug);
	}
}
