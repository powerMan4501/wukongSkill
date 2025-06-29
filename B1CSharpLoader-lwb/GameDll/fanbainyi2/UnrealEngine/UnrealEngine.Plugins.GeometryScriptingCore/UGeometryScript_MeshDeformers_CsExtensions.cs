using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_MeshDeformers_CsExtensions
{
	public static UDynamicMesh ApplyTwistWarpToMesh(this UDynamicMesh TargetMesh, FGeometryScriptTwistWarpOptions Options, FTransform TwistOrientation, float TwistAngle, float TwistExtent, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDeformers.ApplyTwistWarpToMesh(TargetMesh, Options, TwistOrientation, TwistAngle, TwistExtent, Debug);
	}

	public static UDynamicMesh ApplyPerlinNoiseToMesh(this UDynamicMesh TargetMesh, FGeometryScriptPerlinNoiseOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDeformers.ApplyPerlinNoiseToMesh(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ApplyMathWarpToMesh(this UDynamicMesh TargetMesh, FTransform WarpOrientation, EGeometryScriptMathWarpType WarpType, FGeometryScriptMathWarpOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDeformers.ApplyMathWarpToMesh(TargetMesh, WarpOrientation, WarpType, Options, Debug);
	}

	public static UDynamicMesh ApplyIterativeSmoothingToMesh(this UDynamicMesh TargetMesh, FGeometryScriptIterativeMeshSmoothingOptions Options, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDeformers.ApplyIterativeSmoothingToMesh(TargetMesh, Options, Debug);
	}

	public static UDynamicMesh ApplyFlareWarpToMesh(this UDynamicMesh TargetMesh, FGeometryScriptFlareWarpOptions Options, FTransform FlareOrientation, float FlarePercentX, float FlarePercentY, float FlareExtent, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDeformers.ApplyFlareWarpToMesh(TargetMesh, Options, FlareOrientation, FlarePercentX, FlarePercentY, FlareExtent, Debug);
	}

	public static UDynamicMesh ApplyDisplaceFromTextureMap(this UDynamicMesh TargetMesh, UTexture2D Texture, FGeometryScriptDisplaceFromTextureOptions Options, int UVLayer, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDeformers.ApplyDisplaceFromTextureMap(TargetMesh, Texture, Options, UVLayer, Debug);
	}

	public static UDynamicMesh ApplyBendWarpToMesh(this UDynamicMesh TargetMesh, FGeometryScriptBendWarpOptions Options, FTransform BendOrientation, float BendAngle, float BendExtent, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_MeshDeformers.ApplyBendWarpToMesh(TargetMesh, Options, BendOrientation, BendAngle, BendExtent, Debug);
	}
}
