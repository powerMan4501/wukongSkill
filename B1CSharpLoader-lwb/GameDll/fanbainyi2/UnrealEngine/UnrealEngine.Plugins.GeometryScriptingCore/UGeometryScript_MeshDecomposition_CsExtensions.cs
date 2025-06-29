using System.Collections.Generic;
using UnrealEngine.GeometryFramework;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshDecomposition_CsExtensions
{
	public static UDynamicMesh SplitMeshByPolygroups(this UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, out List<UDynamicMesh> ComponentMeshes, out List<int> ComponentPolygroups, UDynamicMeshPool MeshPool, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDecomposition.SplitMeshByPolygroups(TargetMesh, GroupLayer, out ComponentMeshes, out ComponentPolygroups, MeshPool, Debug);
	}

	public static UDynamicMesh SplitMeshByMaterialIDs(this UDynamicMesh TargetMesh, out List<UDynamicMesh> ComponentMeshes, out List<int> ComponentMaterialIDs, UDynamicMeshPool MeshPool, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDecomposition.SplitMeshByMaterialIDs(TargetMesh, out ComponentMeshes, out ComponentMaterialIDs, MeshPool, Debug);
	}

	public static UDynamicMesh SplitMeshByComponents(this UDynamicMesh TargetMesh, out List<UDynamicMesh> ComponentMeshes, UDynamicMeshPool MeshPool, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDecomposition.SplitMeshByComponents(TargetMesh, out ComponentMeshes, MeshPool, Debug);
	}

	public static UDynamicMesh GetSubMeshFromMesh(this UDynamicMesh TargetMesh, ref UDynamicMesh StoreToSubmesh, FGeometryScriptIndexList TriangleList, out UDynamicMesh StoreToSubmeshOut, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDecomposition.GetSubMeshFromMesh(TargetMesh, ref StoreToSubmesh, TriangleList, out StoreToSubmeshOut, Debug);
	}

	public static UDynamicMesh CopyMeshToMesh(this UDynamicMesh CopyFromMesh, ref UDynamicMesh CopyToMesh, out UDynamicMesh CopyToMeshOut, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDecomposition.CopyMeshToMesh(CopyFromMesh, ref CopyToMesh, out CopyToMeshOut, Debug);
	}
}
