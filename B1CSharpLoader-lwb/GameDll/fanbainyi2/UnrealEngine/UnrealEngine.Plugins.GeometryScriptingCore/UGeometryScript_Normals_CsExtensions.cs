using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_Normals_CsExtensions
{
	public static UDynamicMesh SetPerVertexNormals(this UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Normals.SetPerVertexNormals(TargetMesh, Debug);
	}

	public static UDynamicMesh SetPerFaceNormals(this UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Normals.SetPerFaceNormals(TargetMesh, Debug);
	}

	public static UDynamicMesh SetMeshTriangleNormals(this UDynamicMesh TargetMesh, int TriangleID, FGeometryScriptTriangle Normals, out bool bIsValidTriangle, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_Normals.SetMeshTriangleNormals(TargetMesh, TriangleID, Normals, out bIsValidTriangle, bDeferChangeNotifications);
	}

	public static UDynamicMesh RecomputeNormals(this UDynamicMesh TargetMesh, FGeometryScriptCalculateNormalsOptions CalculateOptions, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Normals.RecomputeNormals(TargetMesh, CalculateOptions, Debug);
	}

	public static UDynamicMesh FlipNormals(this UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Normals.FlipNormals(TargetMesh, Debug);
	}

	public static UDynamicMesh ComputeTangents(this UDynamicMesh TargetMesh, FGeometryScriptTangentsOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Normals.ComputeTangents(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ComputeSplitNormals(this UDynamicMesh TargetMesh, FGeometryScriptSplitNormalsOptions SplitOptions, FGeometryScriptCalculateNormalsOptions CalculateOptions, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Normals.ComputeSplitNormals(TargetMesh, SplitOptions, CalculateOptions, Debug);
	}

	public static UDynamicMesh AutoRepairNormals(this UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Normals.AutoRepairNormals(TargetMesh, Debug);
	}
}
