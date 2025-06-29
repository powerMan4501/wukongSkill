using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_UVs_CsExtensions
{
	public static UDynamicMesh TranslateMeshUVs(this UDynamicMesh TargetMesh, int UVSetIndex, FVector2D Translation, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.TranslateMeshUVs(TargetMesh, UVSetIndex, Translation, Debug);
	}

	public static UDynamicMesh SetNumUVSets(this UDynamicMesh TargetMesh, int NumUVSets, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.SetNumUVSets(TargetMesh, NumUVSets, Debug);
	}

	public static UDynamicMesh SetMeshUVsFromPlanarProjection(this UDynamicMesh TargetMesh, int UVSetIndex, FTransform PlaneTransform, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.SetMeshUVsFromPlanarProjection(TargetMesh, UVSetIndex, PlaneTransform, Debug);
	}

	public static UDynamicMesh SetMeshUVsFromCylinderProjection(this UDynamicMesh TargetMesh, int UVSetIndex, FTransform CylinderTransform, float SplitAngle, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.SetMeshUVsFromCylinderProjection(TargetMesh, UVSetIndex, CylinderTransform, SplitAngle, Debug);
	}

	public static UDynamicMesh SetMeshUVsFromBoxProjection(this UDynamicMesh TargetMesh, int UVSetIndex, FTransform BoxTransform, int MinIslandTriCount, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.SetMeshUVsFromBoxProjection(TargetMesh, UVSetIndex, BoxTransform, MinIslandTriCount, Debug);
	}

	public static UDynamicMesh SetMeshTriangleUVs(this UDynamicMesh TargetMesh, int UVSetIndex, int TriangleID, FGeometryScriptUVTriangle UVs, out bool bIsValidTriangle, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_UVs.SetMeshTriangleUVs(TargetMesh, UVSetIndex, TriangleID, UVs, out bIsValidTriangle, bDeferChangeNotifications);
	}

	public static UDynamicMesh ScaleMeshUVs(this UDynamicMesh TargetMesh, int UVSetIndex, FVector2D Scale, FVector2D ScaleOrigin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.ScaleMeshUVs(TargetMesh, UVSetIndex, Scale, ScaleOrigin, Debug);
	}

	public static UDynamicMesh RotateMeshUVs(this UDynamicMesh TargetMesh, int UVSetIndex, float RotationAngle, FVector2D RotationOrigin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.RotateMeshUVs(TargetMesh, UVSetIndex, RotationAngle, RotationOrigin, Debug);
	}

	public static UDynamicMesh RepackMeshUVs(this UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptRepackUVsOptions RepackOptions, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.RepackMeshUVs(TargetMesh, UVSetIndex, RepackOptions, Debug);
	}

	public static UDynamicMesh RecomputeMeshUVs(this UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptRecomputeUVsOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.RecomputeMeshUVs(TargetMesh, UVSetIndex, Options, Debug);
	}

	public static UDynamicMesh CopyUVSet(this UDynamicMesh TargetMesh, int FromUVSet, int ToUVSet, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.CopyUVSet(TargetMesh, FromUVSet, ToUVSet, Debug);
	}

	public static UDynamicMesh AutoGenerateXAtlasMeshUVs(this UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptXAtlasOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.AutoGenerateXAtlasMeshUVs(TargetMesh, UVSetIndex, Options, Debug);
	}

	public static UDynamicMesh AutoGeneratePatchBuilderMeshUVs(this UDynamicMesh TargetMesh, int UVSetIndex, FGeometryScriptPatchBuilderOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_UVs.AutoGeneratePatchBuilderMeshUVs(TargetMesh, UVSetIndex, Options, Debug);
	}
}
