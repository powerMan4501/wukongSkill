using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshSubdivide_CsExtensions
{
	public static UDynamicMesh ApplyUniformTessellation(this UDynamicMesh TargetMesh, int TessellationLevel, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSubdivide.ApplyUniformTessellation(TargetMesh, TessellationLevel, Debug);
	}

	public static UDynamicMesh ApplyPNTessellation(this UDynamicMesh TargetMesh, FGeometryScriptPNTessellateOptions Options, int TessellationLevel, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSubdivide.ApplyPNTessellation(TargetMesh, Options, TessellationLevel, Debug);
	}
}
