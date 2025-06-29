using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_Materials_CsExtensions
{
	public static UDynamicMesh SetTriangleMaterialID(this UDynamicMesh TargetMesh, int TriangleID, int MaterialID, out bool bIsValidTriangle, bool bDeferChangeNotifications = false)
	{
		return UGeometryScript_Materials.SetTriangleMaterialID(TargetMesh, TriangleID, MaterialID, out bIsValidTriangle, bDeferChangeNotifications);
	}

	public static UDynamicMesh SetPolygroupMaterialID(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int PolygroupID, int MaterialID, out bool bIsValidPolygroupID, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Materials.SetPolygroupMaterialID(TargetMesh, GroupLayer, PolygroupID, MaterialID, out bIsValidPolygroupID, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh SetAllTriangleMaterialIDs(this UDynamicMesh TargetMesh, out FGeometryScriptIndexList TriangleMaterialIDList, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Materials.SetAllTriangleMaterialIDs(TargetMesh, out TriangleMaterialIDList, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh RemapMaterialIDs(this UDynamicMesh TargetMesh, int FromMaterialID, int ToMaterialID, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Materials.RemapMaterialIDs(TargetMesh, FromMaterialID, ToMaterialID, Debug);
	}

	public static int GetTriangleMaterialID(this UDynamicMesh TargetMesh, int TriangleID, out bool bIsValidTriangle)
	{
		return UGeometryScript_Materials.GetTriangleMaterialID(TargetMesh, TriangleID, out bIsValidTriangle);
	}

	public static int GetMaxMaterialID(this UDynamicMesh TargetMesh, out bool bHasMaterialIDs)
	{
		return UGeometryScript_Materials.GetMaxMaterialID(TargetMesh, out bHasMaterialIDs);
	}

	public static UDynamicMesh GetAllTriangleMaterialIDs(this UDynamicMesh TargetMesh, out FGeometryScriptIndexList MaterialIDList, out bool bHasMaterialIDs)
	{
		return UGeometryScript_Materials.GetAllTriangleMaterialIDs(TargetMesh, out MaterialIDList, out bHasMaterialIDs);
	}

	public static UDynamicMesh EnableMaterialIDs(this UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Materials.EnableMaterialIDs(TargetMesh, Debug);
	}

	public static UDynamicMesh DeleteTrianglesByMaterialID(this UDynamicMesh TargetMesh, int MaterialID, out int NumDeleted, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Materials.DeleteTrianglesByMaterialID(TargetMesh, MaterialID, out NumDeleted, bDeferChangeNotifications, Debug);
	}

	public static UDynamicMesh CompactMaterialIDs(this UDynamicMesh TargetMesh, List<UMaterialInterface> SourceMaterialList, out List<UMaterialInterface> CompactedMaterialList, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Materials.CompactMaterialIDs(TargetMesh, SourceMaterialList, out CompactedMaterialList, Debug);
	}

	public static UDynamicMesh ClearMaterialIDs(this UDynamicMesh TargetMesh, int ClearValue, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Materials.ClearMaterialIDs(TargetMesh, ClearValue, Debug);
	}
}
