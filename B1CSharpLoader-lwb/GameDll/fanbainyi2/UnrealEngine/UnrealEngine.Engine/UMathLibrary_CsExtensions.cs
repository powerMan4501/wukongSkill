using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UMathLibrary_CsExtensions
{
	public static double VSizeXYSquared(this FVector A)
	{
		return UMathLibrary.VSizeXYSquared(A);
	}

	public static double VSizeXY(this FVector A)
	{
		return UMathLibrary.VSizeXY(A);
	}

	public static double VSizeSquared(this FVector A)
	{
		return UMathLibrary.VSizeSquared(A);
	}

	public static double VSize2DSquared(this FVector2D A)
	{
		return UMathLibrary.VSize2DSquared(A);
	}

	public static double VSize2D(this FVector2D A)
	{
		return UMathLibrary.VSize2D(A);
	}

	public static double VSize(this FVector A)
	{
		return UMathLibrary.VSize(A);
	}

	public static FVector VLerp(this FVector A, FVector B, float Alpha)
	{
		return UMathLibrary.VLerp(A, B, Alpha);
	}

	public static FVector VInterpTo_Constant(this FVector Current, FVector Target, float DeltaTime, float InterpSpeed)
	{
		return UMathLibrary.VInterpTo_Constant(Current, Target, DeltaTime, InterpSpeed);
	}

	public static FVector VInterpTo(this FVector Current, FVector Target, float DeltaTime, float InterpSpeed)
	{
		return UMathLibrary.VInterpTo(Current, Target, DeltaTime, InterpSpeed);
	}

	public static FVector VectorSpringInterp(this FVector Current, FVector Target, ref FVectorSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass, float TargetVelocityAmount, bool bClamp, FVector MinValue, FVector MaxValue, bool bInitializeFromTarget)
	{
		return UMathLibrary.VectorSpringInterp(Current, Target, ref SpringState, Stiffness, CriticalDampingFactor, DeltaTime, Mass, TargetVelocityAmount, bClamp, MinValue, MaxValue, bInitializeFromTarget);
	}

	public static void Vector_UnwindEuler(this ref FVector A)
	{
		UMathLibrary.Vector_UnwindEuler(ref A);
	}

	public static FVector2D Vector_UnitCartesianToSpherical(this FVector A)
	{
		return UMathLibrary.Vector_UnitCartesianToSpherical(A);
	}

	public static FVector Vector_ToRadians(this FVector A)
	{
		return UMathLibrary.Vector_ToRadians(A);
	}

	public static FVector Vector_ToDegrees(this FVector A)
	{
		return UMathLibrary.Vector_ToDegrees(A);
	}

	public static FVector Vector_SnappedToGrid(this FVector InVect, float InGridSize)
	{
		return UMathLibrary.Vector_SnappedToGrid(InVect, InGridSize);
	}

	public static void Vector_Set(this ref FVector A, double X, double Y, double Z)
	{
		UMathLibrary.Vector_Set(ref A, X, Y, Z);
	}

	public static FVector Vector_Reciprocal(this FVector A)
	{
		return UMathLibrary.Vector_Reciprocal(A);
	}

	public static FVector Vector_ProjectOnToNormal(this FVector V, FVector InNormal)
	{
		return UMathLibrary.Vector_ProjectOnToNormal(V, InNormal);
	}

	public static FVector Vector_NormalUnsafe(this FVector A)
	{
		return UMathLibrary.Vector_NormalUnsafe(A);
	}

	public static void Vector_Normalize(this ref FVector A, float Tolerance = 0f)
	{
		UMathLibrary.Vector_Normalize(ref A, Tolerance);
	}

	public static FVector Vector_Normal2D(this FVector A, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Vector_Normal2D(A, Tolerance);
	}

	public static FVector Vector_MirrorByPlane(this FVector A, FPlane InPlane)
	{
		return UMathLibrary.Vector_MirrorByPlane(A, InPlane);
	}

	public static bool Vector_IsZero(this FVector A)
	{
		return UMathLibrary.Vector_IsZero(A);
	}

	public static bool Vector_IsUnit(this FVector A, float SquaredLenthTolerance = 0.0001f)
	{
		return UMathLibrary.Vector_IsUnit(A, SquaredLenthTolerance);
	}

	public static bool Vector_IsUniform(this FVector A, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Vector_IsUniform(A, Tolerance);
	}

	public static bool Vector_IsNormal(this FVector A)
	{
		return UMathLibrary.Vector_IsNormal(A);
	}

	public static bool Vector_IsNearlyZero(this FVector A, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Vector_IsNearlyZero(A, Tolerance);
	}

	public static bool Vector_IsNAN(this FVector A)
	{
		return UMathLibrary.Vector_IsNAN(A);
	}

	public static double Vector_HeadingAngle(this FVector A)
	{
		return UMathLibrary.Vector_HeadingAngle(A);
	}

	public static FVector Vector_GetSignVector(this FVector A)
	{
		return UMathLibrary.Vector_GetSignVector(A);
	}

	public static FVector Vector_GetProjection(this FVector A)
	{
		return UMathLibrary.Vector_GetProjection(A);
	}

	public static double Vector_GetAbsMin(this FVector A)
	{
		return UMathLibrary.Vector_GetAbsMin(A);
	}

	public static double Vector_GetAbsMax(this FVector A)
	{
		return UMathLibrary.Vector_GetAbsMax(A);
	}

	public static FVector Vector_GetAbs(this FVector A)
	{
		return UMathLibrary.Vector_GetAbs(A);
	}

	public static double Vector_DistanceSquared(this FVector V1, FVector V2)
	{
		return UMathLibrary.Vector_DistanceSquared(V1, V2);
	}

	public static double Vector_Distance2DSquared(this FVector V1, FVector V2)
	{
		return UMathLibrary.Vector_Distance2DSquared(V1, V2);
	}

	public static double Vector_Distance2D(this FVector V1, FVector V2)
	{
		return UMathLibrary.Vector_Distance2D(V1, V2);
	}

	public static double Vector_Distance(this FVector V1, FVector V2)
	{
		return UMathLibrary.Vector_Distance(V1, V2);
	}

	public static double Vector_CosineAngle2D(this FVector A, FVector B)
	{
		return UMathLibrary.Vector_CosineAngle2D(A, B);
	}

	public static FVector Vector_ComponentMin(this FVector A, FVector B)
	{
		return UMathLibrary.Vector_ComponentMin(A, B);
	}

	public static FVector Vector_ComponentMax(this FVector A, FVector B)
	{
		return UMathLibrary.Vector_ComponentMax(A, B);
	}

	public static FVector Vector_ClampSizeMax2D(this FVector A, double Max)
	{
		return UMathLibrary.Vector_ClampSizeMax2D(A, Max);
	}

	public static FVector Vector_ClampSizeMax(this FVector A, double Max)
	{
		return UMathLibrary.Vector_ClampSizeMax(A, Max);
	}

	public static FVector Vector_ClampSize2D(this FVector A, double Min, double Max)
	{
		return UMathLibrary.Vector_ClampSize2D(A, Min, Max);
	}

	public static FVector Vector_BoundedToCube(this FVector InVect, float InRadius)
	{
		return UMathLibrary.Vector_BoundedToCube(InVect, InRadius);
	}

	public static FVector Vector_BoundedToBox(this FVector InVect, FVector InBoxMin, FVector InBoxMax)
	{
		return UMathLibrary.Vector_BoundedToBox(InVect, InBoxMin, InBoxMax);
	}

	public static void Vector_Assign(this ref FVector A, FVector InVector)
	{
		UMathLibrary.Vector_Assign(ref A, InVector);
	}

	public static void Vector_AddBounded(this ref FVector A, FVector InAddVect, float InRadius)
	{
		UMathLibrary.Vector_AddBounded(ref A, InAddVect, InRadius);
	}

	public static double Vector4_SizeSquared3(this FVector4 A)
	{
		return UMathLibrary.Vector4_SizeSquared3(A);
	}

	public static double Vector4_SizeSquared(this FVector4 A)
	{
		return UMathLibrary.Vector4_SizeSquared(A);
	}

	public static double Vector4_Size3(this FVector4 A)
	{
		return UMathLibrary.Vector4_Size3(A);
	}

	public static double Vector4_Size(this FVector4 A)
	{
		return UMathLibrary.Vector4_Size(A);
	}

	public static void Vector4_Set(this ref FVector4 A, double X, double Y, double Z, double W)
	{
		UMathLibrary.Vector4_Set(ref A, X, Y, Z, W);
	}

	public static FVector4 Vector4_NormalUnsafe3(this FVector4 A)
	{
		return UMathLibrary.Vector4_NormalUnsafe3(A);
	}

	public static void Vector4_Normalize3(this ref FVector4 A, float Tolerance = 0f)
	{
		UMathLibrary.Vector4_Normalize3(ref A, Tolerance);
	}

	public static FVector4 Vector4_Normal3(this FVector4 A, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Vector4_Normal3(A, Tolerance);
	}

	public static FVector4 Vector4_Negated(this FVector4 A)
	{
		return UMathLibrary.Vector4_Negated(A);
	}

	public static FVector4 Vector4_MirrorByVector3(this FVector4 Direction, FVector4 SurfaceNormal)
	{
		return UMathLibrary.Vector4_MirrorByVector3(Direction, SurfaceNormal);
	}

	public static bool Vector4_IsZero(this FVector4 A)
	{
		return UMathLibrary.Vector4_IsZero(A);
	}

	public static bool Vector4_IsUnit3(this FVector4 A, float SquaredLenthTolerance = 0.0001f)
	{
		return UMathLibrary.Vector4_IsUnit3(A, SquaredLenthTolerance);
	}

	public static bool Vector4_IsNormal3(this FVector4 A)
	{
		return UMathLibrary.Vector4_IsNormal3(A);
	}

	public static bool Vector4_IsNearlyZero3(this FVector4 A, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Vector4_IsNearlyZero3(A, Tolerance);
	}

	public static bool Vector4_IsNAN(this FVector4 A)
	{
		return UMathLibrary.Vector4_IsNAN(A);
	}

	public static double Vector4_DotProduct3(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.Vector4_DotProduct3(A, B);
	}

	public static double Vector4_DotProduct(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.Vector4_DotProduct(A, B);
	}

	public static FVector4 Vector4_CrossProduct3(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.Vector4_CrossProduct3(A, B);
	}

	public static void Vector4_Assign(this ref FVector4 A, FVector4 InVector)
	{
		UMathLibrary.Vector4_Assign(ref A, InVector);
	}

	public static FVector2D Vector2DInterpTo_Constant(this FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed)
	{
		return UMathLibrary.Vector2DInterpTo_Constant(Current, Target, DeltaTime, InterpSpeed);
	}

	public static FVector2D Vector2DInterpTo(this FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed)
	{
		return UMathLibrary.Vector2DInterpTo(Current, Target, DeltaTime, InterpSpeed);
	}

	public static FRotator TransformRotation(this FTransform T, FRotator Rotation)
	{
		return UMathLibrary.TransformRotation(T, Rotation);
	}

	public static FVector TransformLocation(this FTransform T, FVector Location)
	{
		return UMathLibrary.TransformLocation(T, Location);
	}

	public static FVector TransformDirection(this FTransform T, FVector Direction)
	{
		return UMathLibrary.TransformDirection(T, Direction);
	}

	public static float Transform_Determinant(this FTransform Transform)
	{
		return UMathLibrary.Transform_Determinant(Transform);
	}

	public static FVector2D ToSign2D(this FVector2D A)
	{
		return UMathLibrary.ToSign2D(A);
	}

	public static FVector2D ToRounded2D(this FVector2D A)
	{
		return UMathLibrary.ToRounded2D(A);
	}

	public static void ToDirectionAndLength2D(this FVector2D A, out FVector2D OutDir, out double OutLength)
	{
		UMathLibrary.ToDirectionAndLength2D(A, out OutDir, out OutLength);
	}

	public static FTransform TLerp(this FTransform A, FTransform B, float Alpha, ELerpInterpolationMode InterpMode = ELerpInterpolationMode.QuatInterp)
	{
		return UMathLibrary.TLerp(A, B, Alpha, InterpMode);
	}

	public static FTransform TInterpTo(this FTransform Current, FTransform Target, float DeltaTime, float InterpSpeed)
	{
		return UMathLibrary.TInterpTo(Current, Target, DeltaTime, InterpSpeed);
	}

	public static FVector Subtract_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.Subtract_VectorVector(A, B);
	}

	public static FVector Subtract_VectorInt(this FVector A, int B)
	{
		return UMathLibrary.Subtract_VectorInt(A, B);
	}

	public static FVector Subtract_VectorFloat(this FVector A, double B)
	{
		return UMathLibrary.Subtract_VectorFloat(A, B);
	}

	public static FVector4 Subtract_Vector4Vector4(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.Subtract_Vector4Vector4(A, B);
	}

	public static FVector2D Subtract_Vector2DVector2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.Subtract_Vector2DVector2D(A, B);
	}

	public static FVector2D Subtract_Vector2DFloat(this FVector2D A, double B)
	{
		return UMathLibrary.Subtract_Vector2DFloat(A, B);
	}

	public static FQuat Subtract_QuatQuat(this FQuat A, FQuat B)
	{
		return UMathLibrary.Subtract_QuatQuat(A, B);
	}

	public static FLinearColor Subtract_LinearColorLinearColor(this FLinearColor A, FLinearColor B)
	{
		return UMathLibrary.Subtract_LinearColorLinearColor(A, B);
	}

	public static FIntPoint Subtract_IntPointIntPoint(this FIntPoint A, FIntPoint B)
	{
		return UMathLibrary.Subtract_IntPointIntPoint(A, B);
	}

	public static FIntPoint Subtract_IntPointInt(this FIntPoint A, int B)
	{
		return UMathLibrary.Subtract_IntPointInt(A, B);
	}

	public static FVector Spherical2DToUnitCartesian(this FVector2D A)
	{
		return UMathLibrary.Spherical2DToUnitCartesian(A);
	}

	public static void Set2D(this ref FVector2D A, double X, double Y)
	{
		UMathLibrary.Set2D(ref A, X, Y);
	}

	public static FRotator RotatorFromAxisAndAngle(this FVector Axis, float Angle)
	{
		return UMathLibrary.RotatorFromAxisAndAngle(Axis, Angle);
	}

	public static FVector RotateAngleAxis(this FVector InVect, float AngleDeg, FVector Axis)
	{
		return UMathLibrary.RotateAngleAxis(InVect, AngleDeg, Axis);
	}

	public static FRotator RLerp(this FRotator A, FRotator B, float Alpha, bool bShortestPath)
	{
		return UMathLibrary.RLerp(A, B, Alpha, bShortestPath);
	}

	public static void RGBToHSV_Vector(this FLinearColor RGB, out FLinearColor HSV)
	{
		UMathLibrary.RGBToHSV_Vector(RGB, out HSV);
	}

	public static void RGBToHSV(this FLinearColor InColor, out float H, out float S, out float V, out float A)
	{
		UMathLibrary.RGBToHSV(InColor, out H, out S, out V, out A);
	}

	public static FLinearColor RGBLinearToHSV(this FLinearColor RGB)
	{
		return UMathLibrary.RGBLinearToHSV(RGB);
	}

	public static FVector RandomPointInBoundingBox(this FVector Center, FVector HalfSize)
	{
		return UMathLibrary.RandomPointInBoundingBox(Center, HalfSize);
	}

	public static FQuat QuaternionSpringInterp(this FQuat Current, FQuat Target, ref FQuaternionSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass = 1f, float TargetVelocityAmount = 1f, bool bInitializeFromTarget = false)
	{
		return UMathLibrary.QuaternionSpringInterp(Current, Target, ref SpringState, Stiffness, CriticalDampingFactor, DeltaTime, Mass, TargetVelocityAmount, bInitializeFromTarget);
	}

	public static FVector Quat_VectorUp(this FQuat Q)
	{
		return UMathLibrary.Quat_VectorUp(Q);
	}

	public static FVector Quat_VectorRight(this FQuat Q)
	{
		return UMathLibrary.Quat_VectorRight(Q);
	}

	public static FVector Quat_VectorForward(this FQuat Q)
	{
		return UMathLibrary.Quat_VectorForward(Q);
	}

	public static FVector Quat_UnrotateVector(this FQuat Q, FVector V)
	{
		return UMathLibrary.Quat_UnrotateVector(Q, V);
	}

	public static float Quat_SizeSquared(this FQuat Q)
	{
		return UMathLibrary.Quat_SizeSquared(Q);
	}

	public static float Quat_Size(this FQuat Q)
	{
		return UMathLibrary.Quat_Size(Q);
	}

	public static void Quat_SetFromEuler(this ref FQuat Q, FVector Euler)
	{
		UMathLibrary.Quat_SetFromEuler(ref Q, Euler);
	}

	public static void Quat_SetComponents(this ref FQuat Q, float X, float Y, float Z, float W)
	{
		UMathLibrary.Quat_SetComponents(ref Q, X, Y, Z, W);
	}

	public static FRotator Quat_Rotator(this FQuat Q)
	{
		return UMathLibrary.Quat_Rotator(Q);
	}

	public static FVector Quat_RotateVector(this FQuat Q, FVector V)
	{
		return UMathLibrary.Quat_RotateVector(Q, V);
	}

	public static FQuat Quat_Normalized(this FQuat Q, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Quat_Normalized(Q, Tolerance);
	}

	public static void Quat_Normalize(this ref FQuat Q, float Tolerance = 0.0001f)
	{
		UMathLibrary.Quat_Normalize(ref Q, Tolerance);
	}

	public static FQuat Quat_Log(this FQuat Q)
	{
		return UMathLibrary.Quat_Log(Q);
	}

	public static bool Quat_IsNormalized(this FQuat Q)
	{
		return UMathLibrary.Quat_IsNormalized(Q);
	}

	public static bool Quat_IsNonFinite(this FQuat Q)
	{
		return UMathLibrary.Quat_IsNonFinite(Q);
	}

	public static bool Quat_IsIdentity(this FQuat Q, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Quat_IsIdentity(Q, Tolerance);
	}

	public static bool Quat_IsFinite(this FQuat Q)
	{
		return UMathLibrary.Quat_IsFinite(Q);
	}

	public static FQuat Quat_Inversed(this FQuat Q)
	{
		return UMathLibrary.Quat_Inversed(Q);
	}

	public static FVector Quat_GetRotationAxis(this FQuat Q)
	{
		return UMathLibrary.Quat_GetRotationAxis(Q);
	}

	public static FVector Quat_GetAxisZ(this FQuat Q)
	{
		return UMathLibrary.Quat_GetAxisZ(Q);
	}

	public static FVector Quat_GetAxisY(this FQuat Q)
	{
		return UMathLibrary.Quat_GetAxisY(Q);
	}

	public static FVector Quat_GetAxisX(this FQuat Q)
	{
		return UMathLibrary.Quat_GetAxisX(Q);
	}

	public static float Quat_GetAngle(this FQuat Q)
	{
		return UMathLibrary.Quat_GetAngle(Q);
	}

	public static FQuat Quat_Exp(this FQuat Q)
	{
		return UMathLibrary.Quat_Exp(Q);
	}

	public static FVector Quat_Euler(this FQuat Q)
	{
		return UMathLibrary.Quat_Euler(Q);
	}

	public static void Quat_EnforceShortestArcWith(this ref FQuat A, FQuat B)
	{
		UMathLibrary.Quat_EnforceShortestArcWith(ref A, B);
	}

	public static float Quat_AngularDistance(this FQuat A, FQuat B)
	{
		return UMathLibrary.Quat_AngularDistance(A, B);
	}

	public static FVector ProjectVectorOnToVector(this FVector V, FVector Target)
	{
		return UMathLibrary.ProjectVectorOnToVector(V, Target);
	}

	public static FVector ProjectVectorOnToPlane(this FVector V, FVector PlaneNormal)
	{
		return UMathLibrary.ProjectVectorOnToPlane(V, PlaneNormal);
	}

	public static FVector ProjectPointOnToPlane(this FVector Point, FVector PlaneBase, FVector PlaneNormal)
	{
		return UMathLibrary.ProjectPointOnToPlane(Point, PlaneBase, PlaneNormal);
	}

	public static bool NotEqualExactly_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.NotEqualExactly_VectorVector(A, B);
	}

	public static bool NotEqualExactly_Vector4Vector4(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.NotEqualExactly_Vector4Vector4(A, B);
	}

	public static bool NotEqualExactly_Vector2DVector2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.NotEqualExactly_Vector2DVector2D(A, B);
	}

	public static bool NotEqual_VectorVector(this FVector A, FVector B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.NotEqual_VectorVector(A, B, ErrorTolerance);
	}

	public static bool NotEqual_Vector4Vector4(this FVector4 A, FVector4 B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.NotEqual_Vector4Vector4(A, B, ErrorTolerance);
	}

	public static bool NotEqual_Vector2DVector2D(this FVector2D A, FVector2D B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.NotEqual_Vector2DVector2D(A, B, ErrorTolerance);
	}

	public static bool NotEqual_RotatorRotator(this FRotator A, FRotator B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.NotEqual_RotatorRotator(A, B, ErrorTolerance);
	}

	public static bool NotEqual_QuatQuat(this FQuat A, FQuat B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.NotEqual_QuatQuat(A, B, ErrorTolerance);
	}

	public static bool NotEqual_MatrixMatrix(this FMatrix A, FMatrix B, float Tolerance = 0.0001f)
	{
		return UMathLibrary.NotEqual_MatrixMatrix(A, B, Tolerance);
	}

	public static bool NotEqual_LinearColorLinearColor(this FLinearColor A, FLinearColor B)
	{
		return UMathLibrary.NotEqual_LinearColorLinearColor(A, B);
	}

	public static bool NotEqual_IntPointIntPoint(this FIntPoint A, FIntPoint B)
	{
		return UMathLibrary.NotEqual_IntPointIntPoint(A, B);
	}

	public static FVector2D NormalSafe2D(this FVector2D A, float Tolerance = 0f)
	{
		return UMathLibrary.NormalSafe2D(A, Tolerance);
	}

	public static FRotator NormalizedDeltaRotator(this FRotator A, FRotator B)
	{
		return UMathLibrary.NormalizedDeltaRotator(A, B);
	}

	public static void Normalize2D(this ref FVector2D A, float Tolerance = 0f)
	{
		UMathLibrary.Normalize2D(ref A, Tolerance);
	}

	public static FVector2D Normal2D(this FVector2D A)
	{
		return UMathLibrary.Normal2D(A);
	}

	public static FVector Normal(this FVector A, float Tolerance = 0.0001f)
	{
		return UMathLibrary.Normal(A, Tolerance);
	}

	public static FVector NegateVector(this FVector A)
	{
		return UMathLibrary.NegateVector(A);
	}

	public static FRotator NegateRotator(this FRotator A)
	{
		return UMathLibrary.NegateRotator(A);
	}

	public static FVector2D Negated2D(this FVector2D A)
	{
		return UMathLibrary.Negated2D(A);
	}

	public static bool NearlyEqual_TransformTransform(this FTransform A, FTransform B, float LocationTolerance = 0.0001f, float RotationTolerance = 0.0001f, float Scale3DTolerance = 0.0001f)
	{
		return UMathLibrary.NearlyEqual_TransformTransform(A, B, LocationTolerance, RotationTolerance, Scale3DTolerance);
	}

	public static FVector Multiply_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.Multiply_VectorVector(A, B);
	}

	public static FVector Multiply_VectorInt(this FVector A, int B)
	{
		return UMathLibrary.Multiply_VectorInt(A, B);
	}

	public static FVector Multiply_VectorFloat(this FVector A, double B)
	{
		return UMathLibrary.Multiply_VectorFloat(A, B);
	}

	public static FVector4 Multiply_Vector4Vector4(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.Multiply_Vector4Vector4(A, B);
	}

	public static FVector2D Multiply_Vector2DVector2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.Multiply_Vector2DVector2D(A, B);
	}

	public static FVector2D Multiply_Vector2DFloat(this FVector2D A, double B)
	{
		return UMathLibrary.Multiply_Vector2DFloat(A, B);
	}

	public static FRotator Multiply_RotatorInt(this FRotator A, int B)
	{
		return UMathLibrary.Multiply_RotatorInt(A, B);
	}

	public static FRotator Multiply_RotatorFloat(this FRotator A, float B)
	{
		return UMathLibrary.Multiply_RotatorFloat(A, B);
	}

	public static FQuat Multiply_QuatQuat(this FQuat A, FQuat B)
	{
		return UMathLibrary.Multiply_QuatQuat(A, B);
	}

	public static FMatrix Multiply_MatrixMatrix(this FMatrix A, FMatrix B)
	{
		return UMathLibrary.Multiply_MatrixMatrix(A, B);
	}

	public static FMatrix Multiply_MatrixFloat(this FMatrix A, double B)
	{
		return UMathLibrary.Multiply_MatrixFloat(A, B);
	}

	public static FLinearColor Multiply_LinearColorLinearColor(this FLinearColor A, FLinearColor B)
	{
		return UMathLibrary.Multiply_LinearColorLinearColor(A, B);
	}

	public static FLinearColor Multiply_LinearColorFloat(this FLinearColor A, float B)
	{
		return UMathLibrary.Multiply_LinearColorFloat(A, B);
	}

	public static FIntPoint Multiply_IntPointIntPoint(this FIntPoint A, FIntPoint B)
	{
		return UMathLibrary.Multiply_IntPointIntPoint(A, B);
	}

	public static FIntPoint Multiply_IntPointInt(this FIntPoint A, int B)
	{
		return UMathLibrary.Multiply_IntPointInt(A, B);
	}

	public static void MinAreaRectangle(this UWorld WorldContextObject, List<FVector> InPoints, FVector SampleSurfaceNormal, out FVector OutRectCenter, out FRotator OutRectRotation, out float OutRectLengthX, out float OutRectLengthY, bool bDebugDraw = false)
	{
		UMathLibrary.MinAreaRectangle(WorldContextObject, InPoints, SampleSurfaceNormal, out OutRectCenter, out OutRectRotation, out OutRectLengthX, out OutRectLengthY, bDebugDraw);
	}

	public static FVector4 Matrix_TransformVector4(this FMatrix M, FVector4 V)
	{
		return UMathLibrary.Matrix_TransformVector4(M, V);
	}

	public static FVector4 Matrix_TransformVector(this FMatrix M, FVector V)
	{
		return UMathLibrary.Matrix_TransformVector(M, V);
	}

	public static FVector4 Matrix_TransformPosition(this FMatrix M, FVector V)
	{
		return UMathLibrary.Matrix_TransformPosition(M, V);
	}

	public static FQuat Matrix_ToQuat(this FMatrix M)
	{
		return UMathLibrary.Matrix_ToQuat(M);
	}

	public static void Matrix_SetOrigin(this ref FMatrix M, FVector NewOrigin)
	{
		UMathLibrary.Matrix_SetOrigin(ref M, NewOrigin);
	}

	public static void Matrix_SetColumn(this ref FMatrix M, EMatrixColumns Column, FVector Value)
	{
		UMathLibrary.Matrix_SetColumn(ref M, Column, Value);
	}

	public static void Matrix_SetAxis(this ref FMatrix M, EAxisType Axis, FVector AxisVector)
	{
		UMathLibrary.Matrix_SetAxis(ref M, Axis, AxisVector);
	}

	public static FMatrix Matrix_ScaleTranslation(this FMatrix M, FVector Scale3D)
	{
		return UMathLibrary.Matrix_ScaleTranslation(M, Scale3D);
	}

	public static FMatrix Matrix_RemoveTranslation(this FMatrix M)
	{
		return UMathLibrary.Matrix_RemoveTranslation(M);
	}

	public static void Matrix_RemoveScaling(this ref FMatrix M, float Tolerance = 0f)
	{
		UMathLibrary.Matrix_RemoveScaling(ref M, Tolerance);
	}

	public static FMatrix Matrix_Mirror(this FMatrix M, EAxisType MirrorAxis, EAxisType FlipAxis)
	{
		return UMathLibrary.Matrix_Mirror(M, MirrorAxis, FlipAxis);
	}

	public static FVector Matrix_InverseTransformVector(this FMatrix M, FVector V)
	{
		return UMathLibrary.Matrix_InverseTransformVector(M, V);
	}

	public static FVector Matrix_InverseTransformPosition(this FMatrix M, FVector V)
	{
		return UMathLibrary.Matrix_InverseTransformPosition(M, V);
	}

	public static FVector Matrix_GetUnitAxis(this FMatrix M, EAxisType Axis)
	{
		return UMathLibrary.Matrix_GetUnitAxis(M, Axis);
	}

	public static void Matrix_GetUnitAxes(this FMatrix M, out FVector X, out FVector Y, out FVector Z)
	{
		UMathLibrary.Matrix_GetUnitAxes(M, out X, out Y, out Z);
	}

	public static FMatrix Matrix_GetTransposed(this FMatrix M)
	{
		return UMathLibrary.Matrix_GetTransposed(M);
	}

	public static FMatrix Matrix_GetTransposeAdjoint(this FMatrix M)
	{
		return UMathLibrary.Matrix_GetTransposeAdjoint(M);
	}

	public static FVector Matrix_GetScaleVector(this FMatrix M, float Tolerance = 0f)
	{
		return UMathLibrary.Matrix_GetScaleVector(M, Tolerance);
	}

	public static FVector Matrix_GetScaledAxis(this FMatrix M, EAxisType Axis)
	{
		return UMathLibrary.Matrix_GetScaledAxis(M, Axis);
	}

	public static void Matrix_GetScaledAxes(this FMatrix M, out FVector X, out FVector Y, out FVector Z)
	{
		UMathLibrary.Matrix_GetScaledAxes(M, out X, out Y, out Z);
	}

	public static float Matrix_GetRotDeterminant(this FMatrix M)
	{
		return UMathLibrary.Matrix_GetRotDeterminant(M);
	}

	public static FRotator Matrix_GetRotator(this FMatrix M)
	{
		return UMathLibrary.Matrix_GetRotator(M);
	}

	public static FVector Matrix_GetOrigin(this FMatrix InMatrix)
	{
		return UMathLibrary.Matrix_GetOrigin(InMatrix);
	}

	public static float Matrix_GetMaximumAxisScale(this FMatrix M)
	{
		return UMathLibrary.Matrix_GetMaximumAxisScale(M);
	}

	public static FMatrix Matrix_GetMatrixWithoutScale(this FMatrix M, float Tolerance = 0f)
	{
		return UMathLibrary.Matrix_GetMatrixWithoutScale(M, Tolerance);
	}

	public static FMatrix Matrix_GetInverse(this FMatrix M)
	{
		return UMathLibrary.Matrix_GetInverse(M);
	}

	public static bool Matrix_GetFrustumTopPlane(this FMatrix M, out FPlane OutPlane)
	{
		return UMathLibrary.Matrix_GetFrustumTopPlane(M, out OutPlane);
	}

	public static bool Matrix_GetFrustumRightPlane(this FMatrix M, out FPlane OutPlane)
	{
		return UMathLibrary.Matrix_GetFrustumRightPlane(M, out OutPlane);
	}

	public static bool Matrix_GetFrustumNearPlane(this FMatrix M, out FPlane OutPlane)
	{
		return UMathLibrary.Matrix_GetFrustumNearPlane(M, out OutPlane);
	}

	public static bool Matrix_GetFrustumLeftPlane(this FMatrix M, out FPlane OutPlane)
	{
		return UMathLibrary.Matrix_GetFrustumLeftPlane(M, out OutPlane);
	}

	public static bool Matrix_GetFrustumFarPlane(this FMatrix M, out FPlane OutPlane)
	{
		return UMathLibrary.Matrix_GetFrustumFarPlane(M, out OutPlane);
	}

	public static bool Matrix_GetFrustumBottomPlane(this FMatrix M, out FPlane OutPlane)
	{
		return UMathLibrary.Matrix_GetFrustumBottomPlane(M, out OutPlane);
	}

	public static float Matrix_GetDeterminant(this FMatrix M)
	{
		return UMathLibrary.Matrix_GetDeterminant(M);
	}

	public static FVector Matrix_GetColumn(this FMatrix M, EMatrixColumns Column)
	{
		return UMathLibrary.Matrix_GetColumn(M, Column);
	}

	public static bool Matrix_ContainsNaN(this FMatrix M)
	{
		return UMathLibrary.Matrix_ContainsNaN(M);
	}

	public static FMatrix Matrix_ConcatenateTranslation(this FMatrix M, FVector Translation)
	{
		return UMathLibrary.Matrix_ConcatenateTranslation(M, Translation);
	}

	public static FMatrix Matrix_ApplyScale(this FMatrix M, float Scale)
	{
		return UMathLibrary.Matrix_ApplyScale(M, Scale);
	}

	public static FTransform MakeRelativeTransform(this FTransform A, FTransform RelativeTo)
	{
		return UMathLibrary.MakeRelativeTransform(A, RelativeTo);
	}

	public static FLinearColor LinearColorLerpUsingHSV(this FLinearColor A, FLinearColor B, float Alpha)
	{
		return UMathLibrary.LinearColorLerpUsingHSV(A, B, Alpha);
	}

	public static FLinearColor LinearColorLerp(this FLinearColor A, FLinearColor B, float Alpha)
	{
		return UMathLibrary.LinearColorLerp(A, B, Alpha);
	}

	public static FColor LinearColor_ToRGBE(this FLinearColor InLinearColor)
	{
		return UMathLibrary.LinearColor_ToRGBE(InLinearColor);
	}

	public static FLinearColor LinearColor_ToNewOpacity(this FLinearColor InColor, float InOpacity)
	{
		return UMathLibrary.LinearColor_ToNewOpacity(InColor, InOpacity);
	}

	public static void LinearColor_SetTemperature(this ref FLinearColor InOutColor, float InTemperature)
	{
		UMathLibrary.LinearColor_SetTemperature(ref InOutColor, InTemperature);
	}

	public static void LinearColor_SetRGBA(this ref FLinearColor InOutColor, float R, float G, float B, float A = 1f)
	{
		UMathLibrary.LinearColor_SetRGBA(ref InOutColor, R, G, B, A);
	}

	public static void LinearColor_SetRandomHue(this ref FLinearColor InOutColor)
	{
		UMathLibrary.LinearColor_SetRandomHue(ref InOutColor);
	}

	public static void LinearColor_SetFromSRGB(this ref FLinearColor InOutColor, FColor InSRGB)
	{
		UMathLibrary.LinearColor_SetFromSRGB(ref InOutColor, InSRGB);
	}

	public static void LinearColor_SetFromPow22(this ref FLinearColor InOutColor, FColor InColor)
	{
		UMathLibrary.LinearColor_SetFromPow22(ref InOutColor, InColor);
	}

	public static void LinearColor_SetFromHSV(this ref FLinearColor InOutColor, float H, float S, float V, float A = 1f)
	{
		UMathLibrary.LinearColor_SetFromHSV(ref InOutColor, H, S, V, A);
	}

	public static void LinearColor_Set(this ref FLinearColor InOutColor, FLinearColor InColor)
	{
		UMathLibrary.LinearColor_Set(ref InOutColor, InColor);
	}

	public static FColor LinearColor_QuantizeRound(this FLinearColor InColor)
	{
		return UMathLibrary.LinearColor_QuantizeRound(InColor);
	}

	public static bool LinearColor_IsNearEqual(this FLinearColor A, FLinearColor B, float Tolerance = 0.0001f)
	{
		return UMathLibrary.LinearColor_IsNearEqual(A, B, Tolerance);
	}

	public static float LinearColor_GetMin(this FLinearColor InColor)
	{
		return UMathLibrary.LinearColor_GetMin(InColor);
	}

	public static float LinearColor_GetMax(this FLinearColor InColor)
	{
		return UMathLibrary.LinearColor_GetMax(InColor);
	}

	public static float LinearColor_GetLuminance(this FLinearColor InColor)
	{
		return UMathLibrary.LinearColor_GetLuminance(InColor);
	}

	public static float LinearColor_Distance(this FLinearColor C1, FLinearColor C2)
	{
		return UMathLibrary.LinearColor_Distance(C1, C2);
	}

	public static FLinearColor LinearColor_Desaturated(this FLinearColor InColor, float InDesaturation)
	{
		return UMathLibrary.LinearColor_Desaturated(InColor, InDesaturation);
	}

	public static FVector LessLess_VectorRotator(this FVector A, FRotator B)
	{
		return UMathLibrary.LessLess_VectorRotator(A, B);
	}

	public static bool IsZero2D(this FVector2D A)
	{
		return UMathLibrary.IsZero2D(A);
	}

	public static bool IsNearlyZero2D(this FVector2D A, float Tolerance = 0.0001f)
	{
		return UMathLibrary.IsNearlyZero2D(A, Tolerance);
	}

	public static FTransform InvertTransform(this FTransform T)
	{
		return UMathLibrary.InvertTransform(T);
	}

	public static FRotator InverseTransformRotation(this FTransform T, FRotator Rotation)
	{
		return UMathLibrary.InverseTransformRotation(T, Rotation);
	}

	public static FVector InverseTransformLocation(this FTransform T, FVector Location)
	{
		return UMathLibrary.InverseTransformLocation(T, Location);
	}

	public static FVector InverseTransformDirection(this FTransform T, FVector Direction)
	{
		return UMathLibrary.InverseTransformDirection(T, Direction);
	}

	public static FLinearColor HSVToRGBLinear(this FLinearColor HSV)
	{
		return UMathLibrary.HSVToRGBLinear(HSV);
	}

	public static void HSVToRGB_Vector(this FLinearColor HSV, out FLinearColor RGB)
	{
		UMathLibrary.HSVToRGB_Vector(HSV, out RGB);
	}

	public static FVector GreaterGreater_VectorRotator(this FVector A, FRotator B)
	{
		return UMathLibrary.GreaterGreater_VectorRotator(A, B);
	}

	public static void GetYawPitchFromVector(this FVector InVec, out float Yaw, out float Pitch)
	{
		UMathLibrary.GetYawPitchFromVector(InVec, out Yaw, out Pitch);
	}

	public static FVector GetUpVector(this FRotator InRot)
	{
		return UMathLibrary.GetUpVector(InRot);
	}

	public static FVector2D GetRotated2D(this FVector2D A, float AngleDeg)
	{
		return UMathLibrary.GetRotated2D(A, AngleDeg);
	}

	public static FVector GetRightVector(this FRotator InRot)
	{
		return UMathLibrary.GetRightVector(InRot);
	}

	public static FVector GetReflectionVector(this FVector Direction, FVector SurfaceNormal)
	{
		return UMathLibrary.GetReflectionVector(Direction, SurfaceNormal);
	}

	public static double GetMinElement(this FVector A)
	{
		return UMathLibrary.GetMinElement(A);
	}

	public static double GetMin2D(this FVector2D A)
	{
		return UMathLibrary.GetMin2D(A);
	}

	public static double GetMaxElement(this FVector A)
	{
		return UMathLibrary.GetMaxElement(A);
	}

	public static double GetMax2D(this FVector2D A)
	{
		return UMathLibrary.GetMax2D(A);
	}

	public static FVector GetForwardVector(this FRotator InRot)
	{
		return UMathLibrary.GetForwardVector(InRot);
	}

	public static FVector GetDirectionUnitVector(this FVector From, FVector To)
	{
		return UMathLibrary.GetDirectionUnitVector(From, To);
	}

	public static void GetAzimuthAndElevation(this FVector InDirection, FTransform ReferenceFrame, out float Azimuth, out float Elevation)
	{
		UMathLibrary.GetAzimuthAndElevation(InDirection, ReferenceFrame, out Azimuth, out Elevation);
	}

	public static void GetAxes(this FRotator A, out FVector X, out FVector Y, out FVector Z)
	{
		UMathLibrary.GetAxes(A, out X, out Y, out Z);
	}

	public static double GetAbsMax2D(this FVector2D A)
	{
		return UMathLibrary.GetAbsMax2D(A);
	}

	public static FVector2D GetAbs2D(this FVector2D A)
	{
		return UMathLibrary.GetAbs2D(A);
	}

	public static FIntVector FTruncVector(this FVector InVector)
	{
		return UMathLibrary.FTruncVector(InVector);
	}

	public static bool EqualExactly_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.EqualExactly_VectorVector(A, B);
	}

	public static bool EqualExactly_Vector4Vector4(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.EqualExactly_Vector4Vector4(A, B);
	}

	public static bool EqualExactly_Vector2DVector2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.EqualExactly_Vector2DVector2D(A, B);
	}

	public static bool EqualEqual_VectorVector(this FVector A, FVector B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.EqualEqual_VectorVector(A, B, ErrorTolerance);
	}

	public static bool EqualEqual_Vector4Vector4(this FVector4 A, FVector4 B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.EqualEqual_Vector4Vector4(A, B, ErrorTolerance);
	}

	public static bool EqualEqual_Vector2DVector2D(this FVector2D A, FVector2D B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.EqualEqual_Vector2DVector2D(A, B, ErrorTolerance);
	}

	public static bool EqualEqual_TransformTransform(this FTransform A, FTransform B)
	{
		return UMathLibrary.EqualEqual_TransformTransform(A, B);
	}

	public static bool EqualEqual_RotatorRotator(this FRotator A, FRotator B, float ErrorTolerance = 0.0001f)
	{
		return UMathLibrary.EqualEqual_RotatorRotator(A, B, ErrorTolerance);
	}

	public static bool EqualEqual_QuatQuat(this FQuat A, FQuat B, float Tolerance = 0.0001f)
	{
		return UMathLibrary.EqualEqual_QuatQuat(A, B, Tolerance);
	}

	public static bool EqualEqual_MatrixMatrix(this FMatrix A, FMatrix B, float Tolerance = 0.0001f)
	{
		return UMathLibrary.EqualEqual_MatrixMatrix(A, B, Tolerance);
	}

	public static bool EqualEqual_LinearColorLinearColor(this FLinearColor A, FLinearColor B)
	{
		return UMathLibrary.EqualEqual_LinearColorLinearColor(A, B);
	}

	public static bool Equal_IntPointIntPoint(this FIntPoint A, FIntPoint B)
	{
		return UMathLibrary.Equal_IntPointIntPoint(A, B);
	}

	public static double DotProduct2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.DotProduct2D(A, B);
	}

	public static double Dot_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.Dot_VectorVector(A, B);
	}

	public static FVector Divide_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.Divide_VectorVector(A, B);
	}

	public static FVector Divide_VectorInt(this FVector A, int B = 1)
	{
		return UMathLibrary.Divide_VectorInt(A, B);
	}

	public static FVector Divide_VectorFloat(this FVector A, double B = 1.0)
	{
		return UMathLibrary.Divide_VectorFloat(A, B);
	}

	public static FVector4 Divide_Vector4Vector4(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.Divide_Vector4Vector4(A, B);
	}

	public static FVector2D Divide_Vector2DVector2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.Divide_Vector2DVector2D(A, B);
	}

	public static FVector2D Divide_Vector2DFloat(this FVector2D A, double B = 1.0)
	{
		return UMathLibrary.Divide_Vector2DFloat(A, B);
	}

	public static FLinearColor Divide_LinearColorLinearColor(this FLinearColor A, FLinearColor B)
	{
		return UMathLibrary.Divide_LinearColorLinearColor(A, B);
	}

	public static FIntPoint Divide_IntPointIntPoint(this FIntPoint A, FIntPoint B)
	{
		return UMathLibrary.Divide_IntPointIntPoint(A, B);
	}

	public static FIntPoint Divide_IntPointInt(this FIntPoint A, int B)
	{
		return UMathLibrary.Divide_IntPointInt(A, B);
	}

	public static double DistanceSquared2D(this FVector2D V1, FVector2D V2)
	{
		return UMathLibrary.DistanceSquared2D(V1, V2);
	}

	public static double Distance2D(this FVector2D V1, FVector2D V2)
	{
		return UMathLibrary.Distance2D(V1, V2);
	}

	public static double CrossProduct2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.CrossProduct2D(A, B);
	}

	public static FVector Cross_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.Cross_VectorVector(A, B);
	}

	public static FVector2D Conv_VectorToVector2D(this FVector InVector)
	{
		return UMathLibrary.Conv_VectorToVector2D(InVector);
	}

	public static FTransform Conv_VectorToTransform(this FVector InLocation)
	{
		return UMathLibrary.Conv_VectorToTransform(InLocation);
	}

	public static FRotator Conv_VectorToRotator(this FVector InVec)
	{
		return UMathLibrary.Conv_VectorToRotator(InVec);
	}

	public static FQuat Conv_VectorToQuaternion(this FVector InVec)
	{
		return UMathLibrary.Conv_VectorToQuaternion(InVec);
	}

	public static FLinearColor Conv_VectorToLinearColor(this FVector InVec)
	{
		return UMathLibrary.Conv_VectorToLinearColor(InVec);
	}

	public static FVector Conv_Vector4ToVector(this FVector4 InVector4)
	{
		return UMathLibrary.Conv_Vector4ToVector(InVector4);
	}

	public static FRotator Conv_Vector4ToRotator(this FVector4 InVec)
	{
		return UMathLibrary.Conv_Vector4ToRotator(InVec);
	}

	public static FQuat Conv_Vector4ToQuaternion(this FVector4 InVec)
	{
		return UMathLibrary.Conv_Vector4ToQuaternion(InVec);
	}

	public static FVector Conv_Vector2DToVector(this FVector2D InVector2D, float Z = 0f)
	{
		return UMathLibrary.Conv_Vector2DToVector(InVector2D, Z);
	}

	public static FIntPoint Conv_Vector2DToIntPoint(this FVector2D InVector2D)
	{
		return UMathLibrary.Conv_Vector2DToIntPoint(InVector2D);
	}

	public static FMatrix Conv_TransformToMatrix(this FTransform Transform)
	{
		return UMathLibrary.Conv_TransformToMatrix(Transform);
	}

	public static FVector Conv_RotatorToVector(this FRotator InRot)
	{
		return UMathLibrary.Conv_RotatorToVector(InRot);
	}

	public static FTransform Conv_RotatorToTransform(this FRotator InRotator)
	{
		return UMathLibrary.Conv_RotatorToTransform(InRotator);
	}

	public static FQuat Conv_RotatorToQuaternion(this FRotator InRot)
	{
		return UMathLibrary.Conv_RotatorToQuaternion(InRot);
	}

	public static FTransform Conv_MatrixToTransform(this FMatrix InMatrix)
	{
		return UMathLibrary.Conv_MatrixToTransform(InMatrix);
	}

	public static FRotator Conv_MatrixToRotator(this FMatrix InMatrix)
	{
		return UMathLibrary.Conv_MatrixToRotator(InMatrix);
	}

	public static FVector Conv_LinearColorToVector(this FLinearColor InLinearColor)
	{
		return UMathLibrary.Conv_LinearColorToVector(InLinearColor);
	}

	public static FColor Conv_LinearColorToColor(this FLinearColor InLinearColor, bool InUseSRGB = true)
	{
		return UMathLibrary.Conv_LinearColorToColor(InLinearColor, InUseSRGB);
	}

	public static FVector2D Conv_IntPointToVector2D(this FIntPoint InIntPoint)
	{
		return UMathLibrary.Conv_IntPointToVector2D(InIntPoint);
	}

	public static FTransform ComposeTransforms(this FTransform A, FTransform B)
	{
		return UMathLibrary.ComposeTransforms(A, B);
	}

	public static FRotator ComposeRotators(this FRotator A, FRotator B)
	{
		return UMathLibrary.ComposeRotators(A, B);
	}

	public static FVector ClampVectorSize(this FVector A, double Min, double Max)
	{
		return UMathLibrary.ClampVectorSize(A, Min, Max);
	}

	public static FVector2D ClampAxes2D(this FVector2D A, double MinAxisVal, double MaxAxisVal)
	{
		return UMathLibrary.ClampAxes2D(A, MinAxisVal, MaxAxisVal);
	}

	public static FLinearColor CInterpTo(this FLinearColor Current, FLinearColor Target, float DeltaTime, float InterpSpeed)
	{
		return UMathLibrary.CInterpTo(Current, Target, DeltaTime, InterpSpeed);
	}

	public static FVector Add_VectorVector(this FVector A, FVector B)
	{
		return UMathLibrary.Add_VectorVector(A, B);
	}

	public static FVector Add_VectorInt(this FVector A, int B)
	{
		return UMathLibrary.Add_VectorInt(A, B);
	}

	public static FVector Add_VectorFloat(this FVector A, double B)
	{
		return UMathLibrary.Add_VectorFloat(A, B);
	}

	public static FVector4 Add_Vector4Vector4(this FVector4 A, FVector4 B)
	{
		return UMathLibrary.Add_Vector4Vector4(A, B);
	}

	public static FVector2D Add_Vector2DVector2D(this FVector2D A, FVector2D B)
	{
		return UMathLibrary.Add_Vector2DVector2D(A, B);
	}

	public static FVector2D Add_Vector2DFloat(this FVector2D A, double B)
	{
		return UMathLibrary.Add_Vector2DFloat(A, B);
	}

	public static FQuat Add_QuatQuat(this FQuat A, FQuat B)
	{
		return UMathLibrary.Add_QuatQuat(A, B);
	}

	public static FMatrix Add_MatrixMatrix(this FMatrix A, FMatrix B)
	{
		return UMathLibrary.Add_MatrixMatrix(A, B);
	}

	public static FLinearColor Add_LinearColorLinearColor(this FLinearColor A, FLinearColor B)
	{
		return UMathLibrary.Add_LinearColorLinearColor(A, B);
	}

	public static FIntPoint Add_IntPointIntPoint(this FIntPoint A, FIntPoint B)
	{
		return UMathLibrary.Add_IntPointIntPoint(A, B);
	}

	public static FIntPoint Add_IntPointInt(this FIntPoint A, int B)
	{
		return UMathLibrary.Add_IntPointInt(A, B);
	}
}
