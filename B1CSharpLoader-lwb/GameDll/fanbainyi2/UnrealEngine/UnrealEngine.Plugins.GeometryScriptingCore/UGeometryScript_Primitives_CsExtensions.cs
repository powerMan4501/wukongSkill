using System.Collections.Generic;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

public static class UGeometryScript_Primitives_CsExtensions
{
	public static UDynamicMesh AppendTriangulatedPolygon(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, bool bAllowSelfIntersections, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendTriangulatedPolygon(TargetMesh, PrimitiveOptions, Transform, PolygonVertices, bAllowSelfIntersections, Debug);
	}

	public static UDynamicMesh AppendTorus(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, FGeometryScriptRevolveOptions RevolveOptions, float MajorRadius, float MinorRadius, int MajorSteps, int MinorSteps, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendTorus(TargetMesh, PrimitiveOptions, Transform, RevolveOptions, MajorRadius, MinorRadius, MajorSteps, MinorSteps, Origin, Debug);
	}

	public static UDynamicMesh AppendSpiralRevolvePolygon(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, FGeometryScriptRevolveOptions RevolveOptions, float Radius, int Steps, float RisePerRevolution, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendSpiralRevolvePolygon(TargetMesh, PrimitiveOptions, Transform, PolygonVertices, RevolveOptions, Radius, Steps, RisePerRevolution, Debug);
	}

	public static UDynamicMesh AppendSphereLatLong(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, int StepsPhi, int StepsTheta, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendSphereLatLong(TargetMesh, PrimitiveOptions, Transform, Radius, StepsPhi, StepsTheta, Origin, Debug);
	}

	public static UDynamicMesh AppendSphereBox(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, int StepsX, int StepsY, int StepsZ, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendSphereBox(TargetMesh, PrimitiveOptions, Transform, Radius, StepsX, StepsY, StepsZ, Origin, Debug);
	}

	public static UDynamicMesh AppendSimpleSweptPolygon(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, List<FVector> SweepPath, bool bLoop, bool bCapped, float StartScale, float EndScale, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendSimpleSweptPolygon(TargetMesh, PrimitiveOptions, Transform, PolygonVertices, SweepPath, bLoop, bCapped, StartScale, EndScale, Debug);
	}

	public static UDynamicMesh AppendSimpleExtrudePolygon(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, float Height, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendSimpleExtrudePolygon(TargetMesh, PrimitiveOptions, Transform, PolygonVertices, Height, HeightSteps, bCapped, Origin, Debug);
	}

	public static UDynamicMesh AppendRoundRectangleXY(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, float CornerRadius, int StepsWidth, int StepsHeight, int StepsRound, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendRoundRectangleXY(TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, CornerRadius, StepsWidth, StepsHeight, StepsRound, Debug);
	}

	public static UDynamicMesh AppendRoundRectangle_Compatibility_5_0(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, float CornerRadius, int StepsWidth, int StepsHeight, int StepsRound, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendRoundRectangle_Compatibility_5_0(TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, CornerRadius, StepsWidth, StepsHeight, StepsRound, Debug);
	}

	public static UDynamicMesh AppendRevolvePolygon(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PolygonVertices, FGeometryScriptRevolveOptions RevolveOptions, float Radius, int Steps, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendRevolvePolygon(TargetMesh, PrimitiveOptions, Transform, PolygonVertices, RevolveOptions, Radius, Steps, Debug);
	}

	public static UDynamicMesh AppendRevolvePath(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, List<FVector2D> PathVertices, FGeometryScriptRevolveOptions RevolveOptions, int Steps, bool bCapped, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendRevolvePath(TargetMesh, PrimitiveOptions, Transform, PathVertices, RevolveOptions, Steps, bCapped, Debug);
	}

	public static UDynamicMesh AppendRectangleXY(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, int StepsWidth, int StepsHeight, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendRectangleXY(TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, StepsWidth, StepsHeight, Debug);
	}

	public static UDynamicMesh AppendRectangle_Compatibility_5_0(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, int StepsWidth, int StepsHeight, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendRectangle_Compatibility_5_0(TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, StepsWidth, StepsHeight, Debug);
	}

	public static UDynamicMesh AppendLinearStairs(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float StepWidth, float StepHeight, float StepDepth, int NumSteps, bool bFloating, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendLinearStairs(TargetMesh, PrimitiveOptions, Transform, StepWidth, StepHeight, StepDepth, NumSteps, bFloating, Debug);
	}

	public static UDynamicMesh AppendDisc(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, int AngleSteps, int SpokeSteps, float StartAngle, float EndAngle, float HoleRadius, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendDisc(TargetMesh, PrimitiveOptions, Transform, Radius, AngleSteps, SpokeSteps, StartAngle, EndAngle, HoleRadius, Debug);
	}

	public static UDynamicMesh AppendCylinder(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, float Height, int RadialSteps, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendCylinder(TargetMesh, PrimitiveOptions, Transform, Radius, Height, RadialSteps, HeightSteps, bCapped, Origin, Debug);
	}

	public static UDynamicMesh AppendCurvedStairs(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float StepWidth, float StepHeight, float InnerRadius, float CurveAngle, int NumSteps, bool bFloating, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendCurvedStairs(TargetMesh, PrimitiveOptions, Transform, StepWidth, StepHeight, InnerRadius, CurveAngle, NumSteps, bFloating, Debug);
	}

	public static UDynamicMesh AppendCone(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float BaseRadius, float TopRadius, float Height, int RadialSteps, int HeightSteps, bool bCapped, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendCone(TargetMesh, PrimitiveOptions, Transform, BaseRadius, TopRadius, Height, RadialSteps, HeightSteps, bCapped, Origin, Debug);
	}

	public static UDynamicMesh AppendCapsule(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float Radius, float LineLength, int HemisphereSteps, int CircleSteps, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendCapsule(TargetMesh, PrimitiveOptions, Transform, Radius, LineLength, HemisphereSteps, CircleSteps, Origin, Debug);
	}

	public static UDynamicMesh AppendBox(this UDynamicMesh TargetMesh, FGeometryScriptPrimitiveOptions PrimitiveOptions, FTransform Transform, float DimensionX, float DimensionY, float DimensionZ, int StepsX, int StepsY, int StepsZ, EGeometryScriptPrimitiveOriginMode Origin, UGeometryScriptDebug Debug)
	{
		return UGeometryScript_Primitives.AppendBox(TargetMesh, PrimitiveOptions, Transform, DimensionX, DimensionY, DimensionZ, StepsX, StepsY, StepsZ, Origin, Debug);
	}
}
