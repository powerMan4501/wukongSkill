using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_Polygroups_CsExtensions
{
	public static UDynamicMesh SetNumExtendedPolygroupLayers(this UDynamicMesh TargetMesh, int NumLayers, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.SetNumExtendedPolygroupLayers(TargetMesh, NumLayers, Debug);
	}

	public static UDynamicMesh GetTrianglesInPolygroup(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int PolygroupID, ref FGeometryScriptIndexList TriangleIDsOut)
	{
		return UGeometryScript_Polygroups.GetTrianglesInPolygroup(TargetMesh, GroupLayer, PolygroupID, ref TriangleIDsOut);
	}

	public static int GetTrianglePolygroupID(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int TriangleID, out bool bIsValidTriangle)
	{
		return UGeometryScript_Polygroups.GetTrianglePolygroupID(TargetMesh, GroupLayer, TriangleID, out bIsValidTriangle);
	}

	public static UDynamicMesh GetPolygroupIDsInMesh(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, ref FGeometryScriptIndexList PolygroupIDsOut)
	{
		return UGeometryScript_Polygroups.GetPolygroupIDsInMesh(TargetMesh, GroupLayer, ref PolygroupIDsOut);
	}

	public static UDynamicMesh GetAllTrianglePolygroupIDs(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, ref FGeometryScriptIndexList PolygroupIDsOut)
	{
		return UGeometryScript_Polygroups.GetAllTrianglePolygroupIDs(TargetMesh, GroupLayer, ref PolygroupIDsOut);
	}

	public static UDynamicMesh EnablePolygroups(this UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.EnablePolygroups(TargetMesh, Debug);
	}

	public static UDynamicMesh DeleteTrianglesInPolygroup(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int PolygroupID, out int NumDeleted, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.DeleteTrianglesInPolygroup(TargetMesh, GroupLayer, PolygroupID, out NumDeleted, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh CopyPolygroupsLayer(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer FromGroupLayer, FGeometryScriptGroupLayer ToGroupLayer, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.CopyPolygroupsLayer(TargetMesh, FromGroupLayer, ToGroupLayer, Debug);
	}

	public static UDynamicMesh ConvertUVIslandsToPolygroups(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int UVLayer, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.ConvertUVIslandsToPolygroups(TargetMesh, GroupLayer, UVLayer, Debug);
	}

	public static UDynamicMesh ConvertComponentsToPolygroups(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.ConvertComponentsToPolygroups(TargetMesh, GroupLayer, Debug);
	}

	public static UDynamicMesh ComputePolygroupsFromAngleThreshold(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, float CreaseAngle, int MinGroupSize, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.ComputePolygroupsFromAngleThreshold(TargetMesh, GroupLayer, CreaseAngle, MinGroupSize, Debug);
	}

	public static UDynamicMesh ClearPolygroups(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int ClearValue, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Polygroups.ClearPolygroups(TargetMesh, GroupLayer, ClearValue, Debug);
	}
}
