using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshVoxelProcessing_CsExtensions
{
	public static UDynamicMesh ApplyMeshSolidify(this UDynamicMesh TargetMesh, FGeometryScriptSolidifyOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshVoxelProcessing.ApplyMeshSolidify(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshMorphology(this UDynamicMesh TargetMesh, FGeometryScriptMorphologyOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshVoxelProcessing.ApplyMeshMorphology(TargetMesh, Options, Debug);
	}
}
