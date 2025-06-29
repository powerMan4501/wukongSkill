using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshBooleans_CsExtensions
{
	public static UDynamicMesh ApplyMeshSelfUnion(this UDynamicMesh TargetMesh, FGeometryScriptMeshSelfUnionOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshBooleans.ApplyMeshSelfUnion(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshPlaneSlice(this UDynamicMesh TargetMesh, FTransform CutFrame, FGeometryScriptMeshPlaneSliceOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshBooleans.ApplyMeshPlaneSlice(TargetMesh, CutFrame, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshPlaneCut(this UDynamicMesh TargetMesh, FTransform CutFrame, FGeometryScriptMeshPlaneCutOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshBooleans.ApplyMeshPlaneCut(TargetMesh, CutFrame, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshMirror(this UDynamicMesh TargetMesh, FTransform MirrorFrame, FGeometryScriptMeshMirrorOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshBooleans.ApplyMeshMirror(TargetMesh, MirrorFrame, Options, Debug);
	}

	public static UDynamicMesh ApplyMeshBoolean(this UDynamicMesh TargetMesh, FTransform TargetTransform, UDynamicMesh ToolMesh, FTransform ToolTransform, EGeometryScriptBooleanOperation Operation, FGeometryScriptMeshBooleanOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshBooleans.ApplyMeshBoolean(TargetMesh, TargetTransform, ToolMesh, ToolTransform, Operation, Options, Debug);
	}
}
