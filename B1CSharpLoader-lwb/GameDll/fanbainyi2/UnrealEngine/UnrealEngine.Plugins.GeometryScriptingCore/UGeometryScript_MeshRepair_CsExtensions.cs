using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshRepair_CsExtensions
{
	public static UDynamicMesh WeldMeshEdges(this UDynamicMesh TargetMesh, FGeometryScriptWeldEdgesOptions WeldOptions, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshRepair.WeldMeshEdges(TargetMesh, WeldOptions, Debug);
	}

	public static UDynamicMesh RemoveSmallComponents(this UDynamicMesh TargetMesh, FGeometryScriptRemoveSmallComponentOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshRepair.RemoveSmallComponents(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh RemoveHiddenTriangles(this UDynamicMesh TargetMesh, FGeometryScriptRemoveHiddenTrianglesOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshRepair.RemoveHiddenTriangles(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh FillAllMeshHoles(this UDynamicMesh TargetMesh, FGeometryScriptFillHolesOptions FillOptions, out int NumFilledHoles, out int NumFailedHoleFills, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshRepair.FillAllMeshHoles(TargetMesh, FillOptions, out NumFilledHoles, out NumFailedHoleFills, Debug);
	}

	public static UDynamicMesh CompactMesh(this UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshRepair.CompactMesh(TargetMesh, Debug);
	}
}
