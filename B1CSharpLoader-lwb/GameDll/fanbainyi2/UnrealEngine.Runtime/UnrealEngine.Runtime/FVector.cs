using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[Serializable]
[UStruct(Flags = 4254776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Vector", "CoreUObject", UnrealModuleType.Engine)]
public struct FVector : IEquatable<FVector>
{
	private struct FClusterMovedHereToMakeCompile
	{
		public FVector ClusterPosAccum;

		public int ClusterSize;
	}

	private const double VECTOR_CONTRAST_TOLERANCE = 9.999999747378752E-05;

	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:X")]
	public double mX;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:Y")]
	public double mY;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector:Z")]
	public double mZ;

	private static int FVector_StructSize;

	public static readonly FVector ZeroVector;

	public static readonly FVector OneVector;

	public static readonly FVector UpVector;

	public static readonly FVector ForwardVector;

	public static readonly FVector RightVector;

	public float X
	{
		get
		{
			return (float)mX;
		}
		set
		{
			mX = value;
		}
	}

	public float Y
	{
		get
		{
			return (float)mY;
		}
		set
		{
			mY = value;
		}
	}

	public float Z
	{
		get
		{
			return (float)mZ;
		}
		set
		{
			mZ = value;
		}
	}

	public double this[int index]
	{
		get
		{
			return index switch
			{
				0 => mX, 
				1 => mY, 
				2 => mZ, 
				_ => throw new IndexOutOfRangeException("Invalid FVector index (" + index + ")"), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				mX = value;
				break;
			case 1:
				mY = value;
				break;
			case 2:
				mZ = value;
				break;
			default:
				throw new IndexOutOfRangeException("Invalid FVector index (" + index + ")");
			}
		}
	}

	public FVector Copy()
	{
		return this;
	}

	static FVector()
	{
		ZeroVector = new FVector(0.0, 0.0, 0.0);
		OneVector = new FVector(1.0, 1.0, 1.0);
		UpVector = new FVector(0.0, 0.0, 1.0);
		ForwardVector = new FVector(1.0, 0.0, 0.0);
		RightVector = new FVector(0.0, 1.0, 0.0);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Vector");
		FVector_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mX");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mX", Classes.FDoubleProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mY");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mY", Classes.FDoubleProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mZ");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mZ", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FVector));
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN()
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError("FVector contains NaN: " + ToString());
			this = ZeroVector;
		}
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN(string message)
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError(message + ": FVector contains NaN: " + ToString());
			this = ZeroVector;
		}
	}

	public FVector(float value)
	{
		mX = value;
		mY = value;
		mZ = value;
	}

	public FVector(double value)
	{
		mX = value;
		mY = value;
		mZ = value;
	}

	public FVector(double x, double y, double z)
	{
		mX = x;
		mY = y;
		mZ = z;
	}

	public FVector(FVector2D v, double z)
	{
		mX = v.mX;
		mY = v.mY;
		mZ = z;
	}

	public FVector(FVector4 v)
	{
		mX = v.mX;
		mY = v.mY;
		mZ = v.mZ;
	}

	public FVector(FLinearColor color)
	{
		mX = color.R;
		mY = color.G;
		mZ = color.B;
	}

	public FVector(FIntVector vector)
	{
		mX = vector.X;
		mY = vector.Y;
		mZ = vector.Z;
	}

	public FVector(FIntPoint a)
	{
		mX = a.X;
		mY = a.Y;
		mZ = 0.0;
	}

	public static FVector operator ^(FVector a, FVector b)
	{
		CrossProduct(ref a, ref b, out a);
		return a;
	}

	public static FVector CrossProduct(FVector a, FVector b)
	{
		CrossProduct(ref a, ref b, out a);
		return a;
	}

	public static FVector CrossProduct(ref FVector a, ref FVector b)
	{
		CrossProduct(ref a, ref b, out var result);
		return result;
	}

	public static void CrossProduct(ref FVector a, ref FVector b, out FVector result)
	{
		double num = a.mY * b.mZ - a.mZ * b.mY;
		double num2 = a.mZ * b.mX - a.mX * b.mZ;
		double num3 = a.mX * b.mY - a.mY * b.mX;
		result.mX = num;
		result.mY = num2;
		result.mZ = num3;
	}

	public static float operator |(FVector a, FVector b)
	{
		return DotProduct(ref a, ref b);
	}

	public static float DotProduct(FVector a, FVector b)
	{
		return DotProduct(ref a, ref b);
	}

	public static float DotProduct(ref FVector a, ref FVector b)
	{
		DotProduct(ref a, ref b, out var result);
		return result;
	}

	public static void DotProduct(ref FVector a, ref FVector b, out float result)
	{
		result = a.X * b.X + a.Y * b.Y + a.Z * b.Z;
	}

	public static FVector operator +(FVector a, FVector b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FVector Add(FVector a, FVector b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FVector a, ref FVector b, out FVector result)
	{
		result.mX = a.mX + b.mX;
		result.mY = a.mY + b.mY;
		result.mZ = a.mZ + b.mZ;
	}

	public static FVector operator -(FVector a, FVector b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static FVector Subtract(FVector a, FVector b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref FVector a, ref FVector b, out FVector result)
	{
		result.mX = a.mX - b.mX;
		result.mY = a.mY - b.mY;
		result.mZ = a.mZ - b.mZ;
	}

	public static FVector operator -(FVector v, double bias)
	{
		Subtract(ref v, bias, out v);
		return v;
	}

	public static void Subtract(ref FVector v, double bias, out FVector result)
	{
		result.mX = v.mX - bias;
		result.mY = v.mY - bias;
		result.mZ = v.mZ - bias;
	}

	public static FVector operator +(FVector v, double bias)
	{
		Add(ref v, bias, out v);
		return v;
	}

	public static void Add(ref FVector v, double bias, out FVector result)
	{
		result.mX = v.mX + bias;
		result.mY = v.mY + bias;
		result.mZ = v.mZ + bias;
	}

	public static FVector operator *(double scale, FVector v)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FVector operator *(FVector v, double scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static void Multiply(ref FVector v, double scale, out FVector result)
	{
		result.mX = v.mX * scale;
		result.mY = v.mY * scale;
		result.mZ = v.mZ * scale;
	}

	public static FVector operator /(FVector v, double scale)
	{
		Divide(ref v, scale, out v);
		return v;
	}

	public static void Divide(ref FVector v, double scale, out FVector result)
	{
		double num = 1.0 / scale;
		result.mX = v.mX * num;
		result.mY = v.mY * num;
		result.mZ = v.mZ * num;
	}

	public static FVector operator *(FVector a, FVector b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static FVector Multiply(FVector a, FVector b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static void Multiply(ref FVector a, ref FVector b, out FVector result)
	{
		result.mX = a.mX * b.mX;
		result.mY = a.mY * b.mY;
		result.mZ = a.mZ * b.mZ;
	}

	public static FVector operator /(FVector a, FVector b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static FVector Divide(FVector a, FVector b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static void Divide(ref FVector a, ref FVector b, out FVector result)
	{
		result.mX = a.mX / b.mX;
		result.mY = a.mY / b.mY;
		result.mZ = a.mZ / b.mZ;
	}

	public static bool operator ==(FVector a, FVector b)
	{
		if ((double)FMath.Abs(a.X - b.X) <= 9.999999747378752E-05 && (double)FMath.Abs(a.Y - b.Y) <= 9.999999747378752E-05)
		{
			return (double)FMath.Abs(a.Z - b.Z) <= 9.999999747378752E-05;
		}
		return false;
	}

	public static bool operator !=(FVector a, FVector b)
	{
		if (!((double)FMath.Abs(a.X - b.X) > 9.999999747378752E-05) && !((double)FMath.Abs(a.Y - b.Y) > 9.999999747378752E-05))
		{
			return (double)FMath.Abs(a.Z - b.Z) > 9.999999747378752E-05;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FVector))
		{
			return false;
		}
		return Equals((FVector)obj);
	}

	public bool Equals(FVector other)
	{
		if (X == other.X && Y == other.Y)
		{
			return Z == other.Z;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((X.GetHashCode() * 397) ^ Y.GetHashCode()) * 397) ^ Z.GetHashCode();
	}

	public bool Equals(FVector v, double tolerance)
	{
		if ((double)FMath.Abs(X - v.X) <= tolerance && (double)FMath.Abs(Y - v.Y) <= tolerance)
		{
			return (double)FMath.Abs(Z - v.Z) <= tolerance;
		}
		return false;
	}

	public bool AllComponentsEqual(double tolerance = 9.999999747378752E-05)
	{
		if ((double)FMath.Abs(X - Y) <= tolerance && (double)FMath.Abs(X - Z) <= tolerance)
		{
			return (double)FMath.Abs(Y - Z) <= tolerance;
		}
		return false;
	}

	public static FVector operator -(FVector v)
	{
		v.X = 0f - v.X;
		v.Y = 0f - v.Y;
		v.Z = 0f - v.Z;
		return v;
	}

	public double Component(int index)
	{
		return this[index];
	}

	public double GetComponentForAxis(EAxis axis)
	{
		return axis switch
		{
			EAxis.X => mX, 
			EAxis.Y => mY, 
			EAxis.Z => mZ, 
			_ => 0.0, 
		};
	}

	public void SetComponentForAxis(EAxis axis, double component)
	{
		switch (axis)
		{
		case EAxis.X:
			mX = component;
			break;
		case EAxis.Y:
			mY = component;
			break;
		case EAxis.Z:
			mZ = component;
			break;
		}
	}

	public void Set(double x, double y, double z)
	{
		mX = x;
		mY = y;
		mZ = z;
	}

	public double GetMax()
	{
		return FMath.Max(FMath.Max(X, Y), Z);
	}

	public double GetAbsMax()
	{
		return FMath.Max(FMath.Max(FMath.Abs(X), FMath.Abs(Y)), FMath.Abs(Z));
	}

	public double GetMin()
	{
		return FMath.Min(FMath.Min(X, Y), Z);
	}

	public double GetAbsMin()
	{
		return FMath.Min(FMath.Min(FMath.Abs(X), FMath.Abs(Y)), FMath.Abs(Z));
	}

	public FVector ComponentMin(FVector other)
	{
		ComponentMin(ref this, ref other, out other);
		return other;
	}

	public static FVector ComponentMin(FVector a, FVector b)
	{
		ComponentMin(ref a, ref b, out a);
		return a;
	}

	public static void ComponentMin(ref FVector a, ref FVector b, out FVector result)
	{
		result.mX = FMath.Min(a.mX, b.mX);
		result.mY = FMath.Min(a.mY, b.mY);
		result.mZ = FMath.Min(a.mZ, b.mZ);
	}

	public FVector ComponentMax(FVector other)
	{
		ComponentMax(ref this, ref other, out other);
		return other;
	}

	public static FVector ComponentMax(FVector a, FVector b)
	{
		ComponentMin(ref a, ref b, out a);
		return a;
	}

	public static void ComponentMax(ref FVector a, ref FVector b, out FVector result)
	{
		result.mX = FMath.Max(a.mX, b.mX);
		result.mY = FMath.Max(a.mY, b.mY);
		result.mZ = FMath.Max(a.mZ, b.mZ);
	}

	public FVector GetAbs()
	{
		return new FVector(FMath.Abs(X), FMath.Abs(Y), FMath.Abs(Z));
	}

	public float Size()
	{
		return FMath.Sqrt(X * X + Y * Y + Z * Z);
	}

	public double SizeSquared()
	{
		return X * X + Y * Y + Z * Z;
	}

	public float Size2D()
	{
		return FMath.Sqrt(X * X + Y * Y);
	}

	public double SizeSquared2D()
	{
		return X * X + Y * Y;
	}

	public bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
	{
		if ((double)FMath.Abs(X) <= tolerance && (double)FMath.Abs(Y) <= tolerance)
		{
			return (double)FMath.Abs(Z) <= tolerance;
		}
		return false;
	}

	public bool IsZero()
	{
		if (X == 0f && Y == 0f)
		{
			return Z == 0f;
		}
		return false;
	}

	public bool Normalize(double tolerance = 9.99999993922529E-09)
	{
		double num = mX * mX + mY * mY + mZ * mZ;
		if (num > tolerance)
		{
			double num2 = FMath.InvSqrt(num);
			mX *= num2;
			mY *= num2;
			mZ *= num2;
			return true;
		}
		return false;
	}

	public bool IsNormalized()
	{
		return FMath.Abs(1.0 - SizeSquared()) < 0.009999999776482582;
	}

	public void ToDirectionAndLength(out FVector dir, out float length)
	{
		length = Size();
		if (length > 1E-08f)
		{
			float num = 1f / length;
			dir = new FVector(X * num, Y * num, Z * num);
		}
		else
		{
			dir = ZeroVector;
		}
	}

	public FVector GetSignVector()
	{
		return new FVector(FMath.DoubleSelect(X, 1.0, -1.0), FMath.DoubleSelect(Y, 1.0, -1.0), FMath.DoubleSelect(Z, 1.0, -1.0));
	}

	public FVector Projection()
	{
		double num = 1f / Z;
		return new FVector((double)X * num, (double)Y * num, 1.0);
	}

	public FVector GetUnsafeNormal()
	{
		double num = FMath.InvSqrt(X * X + Y * Y + Z * Z);
		return new FVector((double)X * num, (double)Y * num, (double)Z * num);
	}

	public FVector GridSnap(double gridSz)
	{
		return new FVector(FMath.GridSnap(X, gridSz), FMath.GridSnap(Y, gridSz), FMath.GridSnap(Z, gridSz));
	}

	public FVector BoundToCube(double radius)
	{
		return new FVector(FMath.Clamp(X, 0.0 - radius, radius), FMath.Clamp(Y, 0.0 - radius, radius), FMath.Clamp(Z, 0.0 - radius, radius));
	}

	public FVector BoundToBox(FVector min, FVector max)
	{
		return new FVector(FMath.Clamp(X, min.X, max.X), FMath.Clamp(Y, min.Y, max.Y), FMath.Clamp(Z, min.Z, max.Z));
	}

	public FVector GetClampedToSize(double min, double max)
	{
		double num = Size();
		FVector fVector = ((num > 9.99999993922529E-09) ? (this / num) : ZeroVector);
		num = FMath.Clamp(num, min, max);
		return num * fVector;
	}

	public FVector GetClampedToSize2D(double min, double max)
	{
		double num = Size2D();
		FVector fVector = ((num > 9.99999993922529E-09) ? (this / num) : ZeroVector);
		num = FMath.Clamp(num, min, max);
		return new FVector(num * (double)fVector.X, num * (double)fVector.Y, Z);
	}

	public FVector GetClampedToMaxSize(double maxSize)
	{
		if (maxSize < 9.999999747378752E-05)
		{
			return ZeroVector;
		}
		double num = SizeSquared();
		if (num > FMath.Square(maxSize))
		{
			double num2 = maxSize * FMath.InvSqrt(num);
			return new FVector((double)X * num2, (double)Y * num2, (double)Z * num2);
		}
		return this;
	}

	public FVector GetClampedToMaxSize2D(double maxSize)
	{
		if (maxSize < 9.999999747378752E-05)
		{
			return new FVector(0.0, 0.0, Z);
		}
		double num = SizeSquared2D();
		if (num > FMath.Square(maxSize))
		{
			double num2 = maxSize * FMath.InvSqrt(num);
			return new FVector((double)X * num2, (double)Y * num2, Z);
		}
		return this;
	}

	public void AddBounded(FVector v, double radius = 32767.0)
	{
		this = (this + v).BoundToCube(radius);
	}

	public FVector Reciprocal()
	{
		FVector result = default(FVector);
		if (mX != 0.0)
		{
			result.mX = 1.0 / mX;
		}
		else
		{
			result.mX = 3.3999999521443642E+38;
		}
		if (mY != 0.0)
		{
			result.mY = 1.0 / mY;
		}
		else
		{
			result.mY = 3.3999999521443642E+38;
		}
		if (mZ != 0.0)
		{
			result.mZ = 1.0 / mZ;
		}
		else
		{
			result.mZ = 3.3999999521443642E+38;
		}
		return result;
	}

	public bool IsUniform(double tolerance = 9.999999747378752E-05)
	{
		return AllComponentsEqual(tolerance);
	}

	public FVector MirrorByVector(FVector mirrorNormal)
	{
		return this - mirrorNormal * (2f * (this | mirrorNormal));
	}

	public FVector MirrorByPlane(FPlane plane)
	{
		return this - plane * (2.0 * plane.PlaneDot(this));
	}

	public FVector RotateAngleAxis(double angleDeg, FVector axis)
	{
		FMath.SinCos(out var scalarSin, out var scalarCos, FMath.DegreesToRadians(angleDeg));
		double num = axis.X * axis.X;
		double num2 = axis.Y * axis.Y;
		double num3 = axis.Z * axis.Z;
		double num4 = axis.X * axis.Y;
		double num5 = axis.Y * axis.Z;
		double num6 = axis.Z * axis.X;
		double num7 = (double)axis.X * scalarSin;
		double num8 = (double)axis.Y * scalarSin;
		double num9 = (double)axis.Z * scalarSin;
		double num10 = 1.0 - scalarCos;
		return new FVector((num10 * num + scalarCos) * (double)X + (num10 * num4 - num9) * (double)Y + (num10 * num6 + num8) * (double)Z, (num10 * num4 + num9) * (double)X + (num10 * num2 + scalarCos) * (double)Y + (num10 * num5 - num7) * (double)Z, (num10 * num6 - num8) * (double)X + (num10 * num5 + num7) * (double)Y + (num10 * num3 + scalarCos) * (double)Z);
	}

	public FVector GetSafeNormal(double tolerance = 9.99999993922529E-09)
	{
		double num = X * X + Y * Y + Z * Z;
		if (num == 1.0)
		{
			return this;
		}
		if (num < tolerance)
		{
			return ZeroVector;
		}
		double num2 = FMath.InvSqrt(num);
		return new FVector((double)X * num2, (double)Y * num2, (double)Z * num2);
	}

	public FVector GetSafeNormal2D(double tolerance = 9.99999993922529E-09)
	{
		double num = X * X + Y * Y;
		if (num == 1.0)
		{
			if (Z == 0f)
			{
				return this;
			}
			return new FVector(X, Y, 0.0);
		}
		if (num < tolerance)
		{
			return ZeroVector;
		}
		double num2 = FMath.InvSqrt(num);
		return new FVector((double)X * num2, (double)Y * num2, 0.0);
	}

	public float CosineAngle2D(FVector b)
	{
		FVector fVector = this;
		fVector.Z = 0f;
		b.Z = 0f;
		fVector.Normalize();
		b.Normalize();
		return fVector | b;
	}

	public FVector ProjectOnTo(FVector a)
	{
		return a * ((this | a) / (a | a));
	}

	public FVector ProjectOnToNormal(FVector normal)
	{
		return normal * (this | normal);
	}

	public FRotator ToOrientationRotator()
	{
		return new FRotator
		{
			Yaw = FMath.Atan2(Y, X) * (180f / (float)Math.PI),
			Pitch = FMath.Atan2(Z, FMath.Sqrt(X * X + Y * Y)) * (180f / (float)Math.PI),
			Roll = 0f
		};
	}

	public FQuat ToOrientationQuat()
	{
		float num = FMath.Atan2(Y, X);
		float num2 = FMath.Atan2(Z, FMath.Sqrt(X * X + Y * Y));
		FMath.SinCos(out var scalarSin, out var scalarCos, num2 * 0.5f);
		FMath.SinCos(out var scalarSin2, out var scalarCos2, num * 0.5f);
		return new FQuat
		{
			X = scalarSin * scalarSin2,
			Y = (0f - scalarSin) * scalarCos2,
			Z = scalarCos * scalarSin2,
			W = scalarCos * scalarCos2
		};
	}

	public FRotator Rotation()
	{
		return ToOrientationRotator();
	}

	public void FindBestAxisVectors(out FVector axis1, FVector axis2)
	{
		double num = FMath.Abs(X);
		double num2 = FMath.Abs(Y);
		double num3 = FMath.Abs(Z);
		if (num3 > num && num3 > num2)
		{
			axis1 = new FVector(1.0, 0.0, 0.0);
		}
		else
		{
			axis1 = new FVector(0.0, 0.0, 1.0);
		}
		axis1 = (axis1 - this * (axis1 | this)).GetSafeNormal();
		axis2 = axis1 ^ this;
	}

	public void UnwindEuler()
	{
		X = FMath.UnwindDegrees(X);
		Y = FMath.UnwindDegrees(Y);
		Z = FMath.UnwindDegrees(Z);
	}

	public bool ContainsNaN()
	{
		if (FMath.IsFinite(X) && FMath.IsFinite(Y))
		{
			return !FMath.IsFinite(Z);
		}
		return true;
	}

	public bool IsUnit(double lengthSquaredTolerance = 9.999999747378752E-05)
	{
		return FMath.Abs(1.0 - SizeSquared()) < lengthSquaredTolerance;
	}

	public override string ToString()
	{
		string text = "000.000";
		return "X=" + X.ToString(text) + " Y=" + Y.ToString(text) + " Z=" + Z.ToString(text);
	}

	public string ToCompactString()
	{
		string text = "0.00";
		if (IsNearlyZero())
		{
			return "V(0)";
		}
		string text2 = "V(";
		bool flag = true;
		if (!FMath.IsNearlyZero(X))
		{
			text2 = text2 + "X=" + X.ToString(text);
			flag = false;
		}
		if (!FMath.IsNearlyZero(Y))
		{
			if (!flag)
			{
				text2 += ", ";
			}
			text2 = text2 + "Y=" + X.ToString(text);
			flag = false;
		}
		if (!FMath.IsNearlyZero(Z))
		{
			if (!flag)
			{
				text2 += ", ";
			}
			text2 = text2 + "Z=" + X.ToString(text);
			flag = false;
		}
		return text2 + ")";
	}

	public bool InitFromString(string sourceString)
	{
		float num = (Z = 0f);
		float x = (Y = num);
		X = x;
		if (FParse.Value(sourceString, "X=", ref mX) && FParse.Value(sourceString, "Y=", ref mY))
		{
			return FParse.Value(sourceString, "Z=", ref mZ);
		}
		return false;
	}

	public FVector2D UnitCartesianToSpherical()
	{
		double x = FMath.Acos(Z / Size());
		double y = FMath.Atan2(Y, X);
		return new FVector2D(x, y);
	}

	public double HeadingAngle()
	{
		FVector fVector = this;
		fVector.Z = 0f;
		fVector = fVector.GetSafeNormal();
		double num = FMath.Acos(fVector.X);
		if (fVector.Y < 0f)
		{
			num *= -1.0;
		}
		return num;
	}

	public static void CreateOrthonormalBasis(ref FVector xAxis, ref FVector yAxis, ref FVector zAxis)
	{
		xAxis -= (xAxis | zAxis) / (zAxis | zAxis) * zAxis;
		yAxis -= (yAxis | zAxis) / (zAxis | zAxis) * zAxis;
		if (xAxis.SizeSquared() < 9.999999439624929E-11)
		{
			xAxis = yAxis ^ zAxis;
		}
		if (yAxis.SizeSquared() < 9.999999439624929E-11)
		{
			yAxis = xAxis ^ zAxis;
		}
		xAxis.Normalize();
		yAxis.Normalize();
		zAxis.Normalize();
	}

	public static bool PointsAreSame(FVector p, FVector q)
	{
		double num = p.X - q.X;
		if (num > -1.9999999494757503E-05 && num < 1.9999999494757503E-05)
		{
			num = p.Y - q.Y;
			if (num > -1.9999999494757503E-05 && num < 1.9999999494757503E-05)
			{
				num = p.Z - q.Z;
				if (num > -1.9999999494757503E-05 && num < 1.9999999494757503E-05)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static bool PointsAreNear(FVector point1, FVector point2, double dist)
	{
		if (FMath.Abs((double)(point1.X - point2.X)) >= dist)
		{
			return false;
		}
		if (FMath.Abs((double)(point1.Y - point2.Y)) >= dist)
		{
			return false;
		}
		if (FMath.Abs((double)(point1.Z - point2.Z)) >= dist)
		{
			return false;
		}
		return true;
	}

	public static double PointPlaneDist(FVector point, FVector planeBase, FVector planeNormal)
	{
		return (point - planeBase) | planeNormal;
	}

	public static FVector PointPlaneProject(FVector point, FPlane plane)
	{
		return point - plane.PlaneDot(point) * plane;
	}

	public static FVector PointPlaneProject(FVector point, FVector a, FVector b, FVector c)
	{
		FPlane fPlane = new FPlane(a, b, c);
		return point - fPlane.PlaneDot(point) * fPlane;
	}

	public static FVector PointPlaneProject(FVector point, FVector planeBase, FVector planeNormal)
	{
		return point - PointPlaneDist(point, planeBase, planeNormal) * planeNormal;
	}

	public static FVector VectorPlaneProject(FVector v, FVector planeNormal)
	{
		return v - v.ProjectOnToNormal(planeNormal);
	}

	public static float Dist(FVector v1, FVector v2)
	{
		return FMath.Sqrt(DistSquared(v1, v2));
	}

	public static float Distance(FVector v1, FVector v2)
	{
		return Dist(v1, v2);
	}

	public static float DistXY(FVector v1, FVector v2)
	{
		return (float)FMath.Sqrt(DistSquaredXY(v1, v2));
	}

	public static float Dist2D(FVector v1, FVector v2)
	{
		return DistXY(v1, v2);
	}

	public static float DistSquared(FVector v1, FVector v2)
	{
		return FMath.Square(v2.X - v1.X) + FMath.Square(v2.Y - v1.Y) + FMath.Square(v2.Z - v1.Z);
	}

	public static double DistSquaredXY(FVector v1, FVector v2)
	{
		return FMath.Square(v2.X - v1.X) + FMath.Square(v2.Y - v1.Y);
	}

	public static double DistSquared2D(FVector v1, FVector v2)
	{
		return DistSquaredXY(v1, v2);
	}

	public static double BoxPushOut(FVector normal, FVector size)
	{
		return FMath.Abs(normal.X * size.X) + FMath.Abs(normal.Y * size.Y) + FMath.Abs(normal.Z * size.Z);
	}

	public static bool Parallel(FVector normal1, FVector normal2, double parallelCosineThreshold = 0.999845027923584)
	{
		return FMath.Abs((double)(normal1 | normal2)) >= parallelCosineThreshold;
	}

	public static bool Coincident(FVector normal1, FVector normal2, double parallelCosineThreshold = 0.999845027923584)
	{
		return (double)(normal1 | normal2) >= parallelCosineThreshold;
	}

	public static bool Orthogonal(FVector normal1, FVector normal2, double orthogonalCosineThreshold = 0.017455000430345535)
	{
		return FMath.Abs((double)(normal1 | normal2)) <= orthogonalCosineThreshold;
	}

	public static bool Coplanar(FVector base1, FVector normal1, FVector base2, FVector normal2, double parallelCosineThreshold = 0.999845027923584)
	{
		if (!Parallel(normal1, normal2, parallelCosineThreshold))
		{
			return false;
		}
		if (PointPlaneDist(base2, base1, normal1) > 0.10000000149011612)
		{
			return false;
		}
		return true;
	}

	public static double Triple(FVector X, FVector Y, FVector Z)
	{
		return X.X * (Y.Y * Z.Z - Y.Z * Z.Y) + X.Y * (Y.Z * Z.X - Y.X * Z.Z) + X.Z * (Y.X * Z.Y - Y.Y * Z.X);
	}

	public static double EvaluateBezier(FVector[] controlPoints, int numPoints, out FVector[] points)
	{
		points = new FVector[numPoints];
		double num = 1f / (float)(numPoints - 1);
		FVector fVector = controlPoints[0];
		FVector fVector2 = controlPoints[1];
		FVector fVector3 = controlPoints[2];
		FVector fVector4 = controlPoints[3];
		FVector fVector5 = fVector;
		FVector fVector6 = 3.0 * (fVector2 - fVector);
		FVector fVector7 = 3.0 * (fVector3 - 2.0 * fVector2 + fVector);
		FVector fVector8 = fVector4 - 3.0 * fVector3 + 3.0 * fVector2 - fVector;
		FVector fVector9 = fVector5;
		FVector fVector10 = fVector6 * num + fVector7 * num * num + fVector8 * num * num * num;
		FVector fVector11 = 2.0 * fVector7 * num * num + 6.0 * fVector8 * num * num * num;
		FVector fVector12 = 6.0 * fVector8 * num * num * num;
		double num2 = 0.0;
		FVector v = fVector;
		points[0] = fVector;
		for (int i = 1; i < numPoints; i++)
		{
			fVector9 += fVector10;
			fVector10 += fVector11;
			fVector11 += fVector12;
			num2 += (double)Dist(fVector9, v);
			v = fVector9;
			points[i] = fVector9;
		}
		return num2;
	}

	public static FVector RadiansToDegrees(FVector radVector)
	{
		return radVector * 57.2957763671875;
	}

	public static FVector DegreesToRadians(FVector degVector)
	{
		return degVector * 0.01745329238474369;
	}

	public static void GenerateClusterCenters(List<FVector> clusters, FVector[] points, int numIterations, int numConnectionsToBeValid)
	{
		if (points.Length == 0 || clusters.Count == 0)
		{
			return;
		}
		FClusterMovedHereToMakeCompile[] array = new FClusterMovedHereToMakeCompile[clusters.Count];
		for (int i = 0; i < numIterations; i++)
		{
			foreach (FVector fVector in points)
			{
				int num = -1;
				double num2 = 3.3999999521443642E+38;
				for (int k = 0; k < clusters.Count; k++)
				{
					double num3 = (fVector - clusters[k]).SizeSquared();
					if (num3 < num2)
					{
						num2 = num3;
						num = k;
					}
				}
				if (num != -1)
				{
					array[num].ClusterPosAccum += fVector;
					array[num].ClusterSize++;
				}
			}
			for (int l = 0; l < clusters.Count; l++)
			{
				if (array[l].ClusterSize > 0)
				{
					clusters[l] = array[l].ClusterPosAccum / array[l].ClusterSize;
				}
			}
		}
		for (int m = 0; m < array.Length; m++)
		{
			if (array[m].ClusterSize < numConnectionsToBeValid)
			{
				clusters.RemoveAt(m);
			}
		}
	}

	public static float ComputeSquaredDistanceFromBoxToPoint(FVector mins, FVector maxs, FVector point)
	{
		float num = 0f;
		if (point.X < mins.X)
		{
			num += FMath.Square(point.X - mins.X);
		}
		else if (point.X > maxs.X)
		{
			num += FMath.Square(point.X - maxs.X);
		}
		if (point.Y < mins.Y)
		{
			num += FMath.Square(point.Y - mins.Y);
		}
		else if (point.Y > maxs.Y)
		{
			num += FMath.Square(point.Y - maxs.Y);
		}
		if (point.Z < mins.Z)
		{
			num += FMath.Square(point.Z - mins.Z);
		}
		else if (point.Z > maxs.Z)
		{
			num += FMath.Square(point.Z - maxs.Z);
		}
		return num;
	}

	public static FVector Replicate(FVector v, int index)
	{
		double num = v[index];
		return new FVector(num, num, num);
	}

	public static FVector VectorDot3(FVector a, FVector b)
	{
		float num = DotProduct(ref a, ref b);
		return new FVector(num, num, num);
	}
}
