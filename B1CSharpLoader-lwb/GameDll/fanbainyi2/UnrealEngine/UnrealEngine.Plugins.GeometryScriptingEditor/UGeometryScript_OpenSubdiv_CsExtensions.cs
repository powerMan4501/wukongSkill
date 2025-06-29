using UnrealEngine.GeometryFramework;
using UnrealEngine.Plugins.GeometryScriptingCore;

namespace UnrealEngine.Plugins.GeometryScriptingEditor;

public static class UGeometryScript_OpenSubdiv_CsExtensions
{
	public static UDynamicMesh ApplyTriangleLoopSubD(this UDynamicMesh FromDynamicMesh, int Subdivisions, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_OpenSubdiv.ApplyTriangleLoopSubD(FromDynamicMesh, Subdivisions, Debug);
	}

	public static UDynamicMesh ApplyPolygroupCatmullClarkSubD(this UDynamicMesh FromDynamicMesh, int Subdivisions, FGeometryScriptGroupLayer GroupLayer, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_OpenSubdiv.ApplyPolygroupCatmullClarkSubD(FromDynamicMesh, Subdivisions, GroupLayer, Debug);
	}
}
