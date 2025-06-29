using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4254776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Plane", "CoreUObject", UnrealModuleType.Engine)]
public struct FPlane : IEquatable<FPlane>
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:X")]
	public double X;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:Y")]
	public double Y;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:Z")]
	public double Z;

	private static bool W_IsValid;

	private static int W_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Plane:W")]
	public double W;

	private static int FPlane_StructSize;

	public FPlane Copy()
	{
		return this;
	}

	static FPlane()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPlane)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPlane));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Plane");
		FPlane_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "X", Classes.FDoubleProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Y", Classes.FDoubleProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Z");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Z", Classes.FDoubleProperty);
		W_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "W");
		W_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "W", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FPlane));
	}

	public FPlane(FVector4 v)
	{
		X = v.X;
		Y = v.Y;
		Z = v.Z;
		W = v.W;
	}

	public FPlane(double x, double y, double z, double w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public FPlane(FVector normal, double w)
	{
		X = normal.X;
		Y = normal.Y;
		Z = normal.Z;
		W = w;
	}

	public FPlane(FVector planeBase, FVector planeNormal)
	{
		X = planeNormal.X;
		Y = planeNormal.Y;
		Z = planeNormal.Z;
		W = planeBase | planeNormal;
	}

	public FPlane(FVector a, FVector b, FVector c)
	{
		FVector safeNormal = ((b - a) ^ (c - a)).GetSafeNormal();
		X = safeNormal.X;
		Y = safeNormal.Y;
		Z = safeNormal.Z;
		W = a | safeNormal;
	}

	public static implicit operator FVector(FPlane plane)
	{
		return new FVector(plane.X, plane.Y, plane.Z);
	}

	public double PlaneDot(FVector p)
	{
		return X * (double)p.X + Y * (double)p.Y + Z * (double)p.Z - W;
	}

	public bool Normalize(double tolerance = 9.99999993922529E-09)
	{
		double num = X * X + Y * Y + Z * Z;
		if (num > tolerance)
		{
			double num2 = FMath.InvSqrt(num);
			X *= num2;
			Y *= num2;
			Z *= num2;
			W *= num2;
			return true;
		}
		return false;
	}

	public FPlane Flip()
	{
		return new FPlane(0.0 - X, 0.0 - Y, 0.0 - Z, 0.0 - W);
	}

	public FPlane TransformBy(FMatrix m)
	{
		FMatrix ta = m.TransposeAdjoint();
		double detM = m.Determinant();
		return TransformByUsingAdjointT(m, detM, ta);
	}

	public FPlane TransformByUsingAdjointT(FMatrix m, double detM, FMatrix ta)
	{
		FVector planeNormal = ta.TransformVector(this).GetSafeNormal();
		if (detM < 0.0)
		{
			planeNormal *= -1.0;
		}
		return new FPlane(m.TransformPosition(this * W), planeNormal);
	}

	public static bool operator ==(FPlane a, FPlane b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W == b.W;
		}
		return false;
	}

	public static bool operator !=(FPlane a, FPlane b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W != b.W;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FPlane))
		{
			return false;
		}
		return Equals((FPlane)obj);
	}

	public bool Equals(FPlane other)
	{
		if (X == other.X && Y == other.Y && Z == other.Z)
		{
			return W == other.W;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((X.GetHashCode() * 397) ^ Y.GetHashCode()) * 397) ^ Z.GetHashCode()) * 397) ^ W.GetHashCode();
	}

	public bool Equals(FPlane other, double tolerance = 9.999999747378752E-05)
	{
		if (FMath.Abs(X - other.X) < tolerance && FMath.Abs(Y - other.Y) < tolerance && FMath.Abs(Z - other.Z) < tolerance)
		{
			return FMath.Abs(W - other.W) < tolerance;
		}
		return false;
	}

	public static double operator |(FPlane a, FPlane b)
	{
		return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
	}

	public static FVector operator ^(FPlane a, FPlane b)
	{
		return (FVector)a ^ (FVector)b;
	}

	public static FPlane operator +(FPlane a, FPlane b)
	{
		return new FPlane(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
	}

	public static FPlane operator -(FPlane a, FPlane b)
	{
		return new FPlane(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
	}

	public static FPlane operator /(FPlane plane, int scale)
	{
		double num = 1f / (float)scale;
		return new FPlane(plane.X * num, plane.Y * num, plane.Z * num, plane.W * num);
	}

	public static FPlane operator *(double scale, FPlane plane)
	{
		return plane * scale;
	}

	public static FPlane operator *(FPlane plane, double scale)
	{
		return new FPlane(plane.X * scale, plane.Y * scale, plane.Z * scale, plane.W * scale);
	}

	public static FPlane operator *(FPlane a, FPlane b)
	{
		return new FPlane(a.X * b.X, a.Y * b.Y, a.Z * b.Z, a.W * b.W);
	}
}
