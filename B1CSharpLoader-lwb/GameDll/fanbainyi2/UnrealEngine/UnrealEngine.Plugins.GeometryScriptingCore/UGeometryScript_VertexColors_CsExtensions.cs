using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_VertexColors_CsExtensions
{
	public static UDynamicMesh SetMeshPerVertexColors(this UDynamicMesh TargetMesh, FGeometryScriptColorList VertexColorList, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_VertexColors.SetMeshPerVertexColors(TargetMesh, VertexColorList, Debug);
	}

	public static UDynamicMesh SetMeshConstantVertexColor(this UDynamicMesh TargetMesh, FLinearColor Color, FGeometryScriptColorFlags Flags, bool bClearExisting, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_VertexColors.SetMeshConstantVertexColor(TargetMesh, Color, Flags, bClearExisting, Debug);
	}
}
