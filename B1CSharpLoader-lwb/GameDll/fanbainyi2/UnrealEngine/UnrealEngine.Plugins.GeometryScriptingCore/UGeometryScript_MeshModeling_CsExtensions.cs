using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshModeling_CsExtensions
{
	public static UDynamicMesh ApplyMeshShell(this UDynamicMesh TargetMesh, FGeometryScriptMeshOffsetOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshModeling.ApplyMeshShell(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshPolygroupBevel(this UDynamicMesh TargetMesh, FGeometryScriptMeshBevelOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshModeling.ApplyMeshPolygroupBevel(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshOffset(this UDynamicMesh TargetMesh, FGeometryScriptMeshOffsetOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshModeling.ApplyMeshOffset(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshExtrude(this UDynamicMesh TargetMesh, FGeometryScriptMeshExtrudeOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshModeling.ApplyMeshExtrude(TargetMesh, Options, Debug);
	}
}
