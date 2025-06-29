using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshComparison_CsExtensions
{
	public static UDynamicMesh MeasureDistancesBetweenMeshes(this UDynamicMesh TargetMesh, UDynamicMesh OtherMesh, FGeometryScriptMeasureMeshDistanceOptions Options, out double MaxDistance, out double MinDistance, out double AverageDistance, out double RootMeanSqrDeviation, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshComparison.MeasureDistancesBetweenMeshes(TargetMesh, OtherMesh, Options, out MaxDistance, out MinDistance, out AverageDistance, out RootMeanSqrDeviation, Debug);
	}

	public static UDynamicMesh IsSameMeshAs(this UDynamicMesh TargetMesh, UDynamicMesh OtherMesh, FGeometryScriptIsSameMeshOptions Options, out bool bIsSameMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshComparison.IsSameMeshAs(TargetMesh, OtherMesh, Options, out bIsSameMesh, Debug);
	}

	public static UDynamicMesh IsIntersectingMesh(this UDynamicMesh TargetMesh, FTransform TargetTransform, UDynamicMesh OtherMesh, FTransform OtherTransform, out bool bIsIntersecting, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshComparison.IsIntersectingMesh(TargetMesh, TargetTransform, OtherMesh, OtherTransform, out bIsIntersecting, Debug);
	}
}
