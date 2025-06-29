using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshSpatial_CsExtensions
{
	public static void ResetBVH(this ref FGeometryScriptDynamicMeshBVH ResetBVH)
	{
		UGeometryScript_MeshSpatial.ResetBVH(ref ResetBVH);
	}

	public static UDynamicMesh RebuildBVHForMesh(this UDynamicMesh TargetMesh, ref FGeometryScriptDynamicMeshBVH UpdateBVH, bool bOnlyIfInvalid, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSpatial.RebuildBVHForMesh(TargetMesh, ref UpdateBVH, bOnlyIfInvalid, Debug);
	}

	public static UDynamicMesh IsPointInsideMesh(this UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH QueryBVH, FVector QueryPoint, FGeometryScriptSpatialQueryOptions Options, out bool bIsInside, out EGeometryScriptContainmentOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSpatial.IsPointInsideMesh(TargetMesh, QueryBVH, QueryPoint, Options, out bIsInside, out Outcome, Debug);
	}

	public static UDynamicMesh IsBVHValidForMesh(this UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH TestBVH, out bool bIsValid, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSpatial.IsBVHValidForMesh(TargetMesh, TestBVH, out bIsValid, Debug);
	}

	public static UDynamicMesh FindNearestRayIntersectionWithMesh(this UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH QueryBVH, FVector RayOrigin, FVector RayDirection, FGeometryScriptSpatialQueryOptions Options, out FGeometryScriptRayHitResult HitResult, out EGeometryScriptSearchOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSpatial.FindNearestRayIntersectionWithMesh(TargetMesh, QueryBVH, RayOrigin, RayDirection, Options, out HitResult, out Outcome, Debug);
	}

	public static UDynamicMesh FindNearestPointOnMesh(this UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH QueryBVH, FVector QueryPoint, FGeometryScriptSpatialQueryOptions Options, out FGeometryScriptTrianglePoint NearestResult, out EGeometryScriptSearchOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSpatial.FindNearestPointOnMesh(TargetMesh, QueryBVH, QueryPoint, Options, out NearestResult, out Outcome, Debug);
	}

	public static UDynamicMesh BuildBVHForMesh(this UDynamicMesh TargetMesh, out FGeometryScriptDynamicMeshBVH OutputBVH, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshSpatial.BuildBVHForMesh(TargetMesh, out OutputBVH, Debug);
	}
}
