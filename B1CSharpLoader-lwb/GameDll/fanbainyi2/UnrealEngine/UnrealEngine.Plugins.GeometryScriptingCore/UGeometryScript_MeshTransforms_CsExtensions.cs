using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshTransforms_CsExtensions
{
	public static UDynamicMesh TranslateMesh(this UDynamicMesh TargetMesh, FVector Translation, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshTransforms.TranslateMesh(TargetMesh, Translation, Debug);
	}

	public static UDynamicMesh TransformMesh(this UDynamicMesh TargetMesh, FTransform Transform, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshTransforms.TransformMesh(TargetMesh, Transform, Debug);
	}

	public static UDynamicMesh ScaleMesh(this UDynamicMesh TargetMesh, FVector Scale, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshTransforms.ScaleMesh(TargetMesh, Scale, Debug);
	}
}
