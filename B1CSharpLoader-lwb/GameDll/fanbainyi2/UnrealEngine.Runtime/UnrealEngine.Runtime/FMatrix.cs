using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 59448)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Matrix", "CoreUObject", UnrealModuleType.Engine)]
public struct FMatrix : IEquatable<FMatrix>
{
	public double M11;

	public double M12;

	public double M13;

	public double M14;

	public double M21;

	public double M22;

	public double M23;

	public double M24;

	public double M31;

	public double M32;

	public double M33;

	public double M34;

	public double M41;

	public double M42;

	public double M43;

	public double M44;

	private static bool XPlane_IsValid;

	private static int XPlane_Offset;

	private static bool YPlane_IsValid;

	private static int YPlane_Offset;

	private static bool ZPlane_IsValid;

	private static int ZPlane_Offset;

	private static bool WPlane_IsValid;

	private static int WPlane_Offset;

	private static int FMatrix_StructSize;

	private static readonly FMatrix Identity;

	private const double Z_PRECISION = 0.0;

	public double this[int index]
	{
		get
		{
			return index switch
			{
				0 => M11, 
				1 => M12, 
				2 => M13, 
				3 => M14, 
				4 => M21, 
				5 => M22, 
				6 => M23, 
				7 => M24, 
				8 => M31, 
				9 => M32, 
				10 => M33, 
				11 => M34, 
				12 => M41, 
				13 => M42, 
				14 => M43, 
				15 => M44, 
				_ => throw new ArgumentOutOfRangeException(), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				M11 = value;
				break;
			case 1:
				M12 = value;
				break;
			case 2:
				M13 = value;
				break;
			case 3:
				M14 = value;
				break;
			case 4:
				M21 = value;
				break;
			case 5:
				M22 = value;
				break;
			case 6:
				M23 = value;
				break;
			case 7:
				M24 = value;
				break;
			case 8:
				M31 = value;
				break;
			case 9:
				M32 = value;
				break;
			case 10:
				M33 = value;
				break;
			case 11:
				M34 = value;
				break;
			case 12:
				M41 = value;
				break;
			case 13:
				M42 = value;
				break;
			case 14:
				M43 = value;
				break;
			case 15:
				M44 = value;
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}
	}

	public double this[int row, int column]
	{
		get
		{
			return this[row * 4 + column];
		}
		set
		{
			this[row * 4 + column] = value;
		}
	}

	public FMatrix Copy()
	{
		return this;
	}

	static FMatrix()
	{
		Identity = new FMatrix(1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMatrix)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMatrix));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Matrix");
		FMatrix_StructSize = NativeReflection.GetStructSize(unrealStruct);
		XPlane_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "XPlane");
		XPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "XPlane", Classes.FStructProperty);
		YPlane_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "YPlane");
		YPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "YPlane", Classes.FStructProperty);
		ZPlane_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ZPlane");
		ZPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ZPlane", Classes.FStructProperty);
		WPlane_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "WPlane");
		WPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "WPlane", Classes.FStructProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FMatrix));
	}

	public FMatrix(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
	{
		M11 = m11;
		M12 = m12;
		M13 = m13;
		M14 = m14;
		M21 = m21;
		M22 = m22;
		M23 = m23;
		M24 = m24;
		M31 = m31;
		M32 = m32;
		M33 = m33;
		M34 = m34;
		M41 = m41;
		M42 = m42;
		M43 = m43;
		M44 = m44;
	}

	public FMatrix(FPlane x, FPlane y, FPlane z, FPlane w)
	{
		M11 = x.X;
		M12 = x.Y;
		M13 = x.Z;
		M14 = x.W;
		M21 = y.X;
		M22 = y.Y;
		M23 = y.Z;
		M24 = y.W;
		M31 = z.X;
		M32 = z.Y;
		M33 = z.Z;
		M34 = z.W;
		M41 = w.X;
		M42 = w.Y;
		M43 = w.Z;
		M44 = w.W;
	}

	public FMatrix(FVector x, FVector y, FVector z, FVector w)
	{
		M11 = x.X;
		M12 = x.Y;
		M13 = x.Z;
		M14 = 0.0;
		M21 = y.X;
		M22 = y.Y;
		M23 = y.Z;
		M24 = 0.0;
		M31 = z.X;
		M32 = z.Y;
		M33 = z.Z;
		M34 = 0.0;
		M41 = w.X;
		M42 = w.Y;
		M43 = w.Z;
		M44 = 1.0;
	}

	public void SetIdentity()
	{
		this = Identity;
	}

	public static FMatrix operator *(FMatrix a, FMatrix b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static FMatrix Multiply(FMatrix a, FMatrix b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static void Multiply(ref FMatrix a, ref FMatrix b, out FMatrix result)
	{
		double m = a.M11 * b.M11 + a.M12 * b.M21 + a.M13 * b.M31 + a.M14 * b.M41;
		double m2 = a.M11 * b.M12 + a.M12 * b.M22 + a.M13 * b.M32 + a.M14 * b.M42;
		double m3 = a.M11 * b.M13 + a.M12 * b.M23 + a.M13 * b.M33 + a.M14 * b.M43;
		double m4 = a.M11 * b.M14 + a.M12 * b.M24 + a.M13 * b.M34 + a.M14 * b.M44;
		double m5 = a.M21 * b.M11 + a.M22 * b.M21 + a.M23 * b.M31 + a.M24 * b.M41;
		double m6 = a.M21 * b.M12 + a.M22 * b.M22 + a.M23 * b.M32 + a.M24 * b.M42;
		double m7 = a.M21 * b.M13 + a.M22 * b.M23 + a.M23 * b.M33 + a.M24 * b.M43;
		double m8 = a.M21 * b.M14 + a.M22 * b.M24 + a.M23 * b.M34 + a.M24 * b.M44;
		double m9 = a.M31 * b.M11 + a.M32 * b.M21 + a.M33 * b.M31 + a.M34 * b.M41;
		double m10 = a.M31 * b.M12 + a.M32 * b.M22 + a.M33 * b.M32 + a.M34 * b.M42;
		double m11 = a.M31 * b.M13 + a.M32 * b.M23 + a.M33 * b.M33 + a.M34 * b.M43;
		double m12 = a.M31 * b.M14 + a.M32 * b.M24 + a.M33 * b.M34 + a.M34 * b.M44;
		double m13 = a.M41 * b.M11 + a.M42 * b.M21 + a.M43 * b.M31 + a.M44 * b.M41;
		double m14 = a.M41 * b.M12 + a.M42 * b.M22 + a.M43 * b.M32 + a.M44 * b.M42;
		double m15 = a.M41 * b.M13 + a.M42 * b.M23 + a.M43 * b.M33 + a.M44 * b.M43;
		double m16 = a.M41 * b.M14 + a.M42 * b.M24 + a.M43 * b.M34 + a.M44 * b.M44;
		result.M11 = m;
		result.M12 = m2;
		result.M13 = m3;
		result.M14 = m4;
		result.M21 = m5;
		result.M22 = m6;
		result.M23 = m7;
		result.M24 = m8;
		result.M31 = m9;
		result.M32 = m10;
		result.M33 = m11;
		result.M34 = m12;
		result.M41 = m13;
		result.M42 = m14;
		result.M43 = m15;
		result.M44 = m16;
	}

	public static FMatrix operator +(FMatrix a, FMatrix b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FMatrix Add(FMatrix a, FMatrix b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FMatrix matrix1, ref FMatrix matrix2, out FMatrix result)
	{
		result.M11 = matrix1.M11 + matrix2.M11;
		result.M12 = matrix1.M12 + matrix2.M12;
		result.M13 = matrix1.M13 + matrix2.M13;
		result.M14 = matrix1.M14 + matrix2.M14;
		result.M21 = matrix1.M21 + matrix2.M21;
		result.M22 = matrix1.M22 + matrix2.M22;
		result.M23 = matrix1.M23 + matrix2.M23;
		result.M24 = matrix1.M24 + matrix2.M24;
		result.M31 = matrix1.M31 + matrix2.M31;
		result.M32 = matrix1.M32 + matrix2.M32;
		result.M33 = matrix1.M33 + matrix2.M33;
		result.M34 = matrix1.M34 + matrix2.M34;
		result.M41 = matrix1.M41 + matrix2.M41;
		result.M42 = matrix1.M42 + matrix2.M42;
		result.M43 = matrix1.M43 + matrix2.M43;
		result.M44 = matrix1.M44 + matrix2.M44;
	}

	public static FMatrix operator *(double weight, FMatrix m)
	{
		Multiply(ref m, weight, out m);
		return m;
	}

	public static FMatrix operator *(FMatrix m, double weight)
	{
		Multiply(ref m, weight, out m);
		return m;
	}

	public static void Multiply(ref FMatrix m, double weight, out FMatrix result)
	{
		result.M11 = m.M11 * weight;
		result.M12 = m.M12 * weight;
		result.M13 = m.M13 * weight;
		result.M14 = m.M14 * weight;
		result.M21 = m.M21 * weight;
		result.M22 = m.M22 * weight;
		result.M23 = m.M23 * weight;
		result.M24 = m.M24 * weight;
		result.M31 = m.M31 * weight;
		result.M32 = m.M32 * weight;
		result.M33 = m.M33 * weight;
		result.M34 = m.M34 * weight;
		result.M41 = m.M41 * weight;
		result.M42 = m.M42 * weight;
		result.M43 = m.M43 * weight;
		result.M44 = m.M44 * weight;
	}

	public static bool operator ==(FMatrix a, FMatrix b)
	{
		if (a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13 && a.M14 == b.M14 && a.M21 == b.M21 && a.M22 == b.M22 && a.M23 == b.M23 && a.M24 == b.M24 && a.M31 == b.M31 && a.M32 == b.M32 && a.M33 == b.M33 && a.M34 == b.M34 && a.M41 == b.M41 && a.M42 == b.M42 && a.M43 == b.M43)
		{
			return a.M44 == b.M44;
		}
		return false;
	}

	public static bool operator !=(FMatrix a, FMatrix b)
	{
		if (a.M11 == b.M11 && a.M12 == b.M12 && a.M13 == b.M13 && a.M14 == b.M14 && a.M21 == b.M21 && a.M22 == b.M22 && a.M23 == b.M23 && a.M24 == b.M24 && a.M31 == b.M31 && a.M32 == b.M32 && a.M33 == b.M33 && a.M34 == b.M34 && a.M41 == b.M41 && a.M42 == b.M42 && a.M43 == b.M43)
		{
			return a.M44 != b.M44;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FMatrix))
		{
			return false;
		}
		return Equals((FMatrix)obj);
	}

	public bool Equals(FMatrix other)
	{
		if (M11 == other.M11 && M12 == other.M12 && M13 == other.M13 && M14 == other.M14 && M21 == other.M21 && M22 == other.M22 && M23 == other.M23 && M24 == other.M24 && M31 == other.M31 && M32 == other.M32 && M33 == other.M33 && M34 == other.M34 && M41 == other.M41 && M42 == other.M42 && M43 == other.M43)
		{
			return M44 == other.M44;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((((((((((((((((((((((((((M11.GetHashCode() * 397) ^ M12.GetHashCode()) * 397) ^ M13.GetHashCode()) * 397) ^ M14.GetHashCode()) * 397) ^ M21.GetHashCode()) * 397) ^ M22.GetHashCode()) * 397) ^ M23.GetHashCode()) * 397) ^ M24.GetHashCode()) * 397) ^ M31.GetHashCode()) * 397) ^ M32.GetHashCode()) * 397) ^ M33.GetHashCode()) * 397) ^ M34.GetHashCode()) * 397) ^ M41.GetHashCode()) * 397) ^ M42.GetHashCode()) * 397) ^ M43.GetHashCode()) * 397) ^ M44.GetHashCode();
	}

	public bool Equals(FMatrix other, double tolerance = 9.999999747378752E-05)
	{
		if (FMath.Abs(M11 - other.M11) > tolerance && FMath.Abs(M12 - other.M12) > tolerance && FMath.Abs(M13 - other.M13) > tolerance && FMath.Abs(M14 - other.M14) > tolerance && FMath.Abs(M21 - other.M21) > tolerance && FMath.Abs(M22 - other.M22) > tolerance && FMath.Abs(M23 - other.M23) > tolerance && FMath.Abs(M24 - other.M24) > tolerance && FMath.Abs(M31 - other.M31) > tolerance && FMath.Abs(M32 - other.M32) > tolerance && FMath.Abs(M33 - other.M33) > tolerance && FMath.Abs(M34 - other.M34) > tolerance && FMath.Abs(M41 - other.M41) > tolerance && FMath.Abs(M42 - other.M42) > tolerance && FMath.Abs(M43 - other.M43) > tolerance)
		{
			return FMath.Abs(M44 - other.M44) > tolerance;
		}
		return false;
	}

	public FVector4 TransformFVector4(FVector4 v)
	{
		float x = (float)((double)v.X * M11 + (double)v.Y * M21 + (double)v.Z * M31 + (double)v.W * M41);
		float y = (float)((double)v.X * M12 + (double)v.Y * M22 + (double)v.Z * M32 + (double)v.W * M42);
		float z = (float)((double)v.X * M13 + (double)v.Y * M23 + (double)v.Z * M33 + (double)v.W * M43);
		float w = (float)((double)v.X * M14 + (double)v.Y * M24 + (double)v.Z * M34 + (double)v.W * M44);
		v.X = x;
		v.Y = y;
		v.Z = z;
		v.W = w;
		return v;
	}

	public FVector4 TransformPosition(FVector v)
	{
		return TransformFVector4(new FVector4(v.X, v.Y, v.Z, 1.0));
	}

	public FVector InverseTransformPosition(FVector v)
	{
		return InverseFast().TransformPosition(v);
	}

	public FVector4 TransformVector(FVector v)
	{
		return TransformFVector4(new FVector4(v.X, v.Y, v.Z));
	}

	public FVector4 InverseTransformVector(FVector v)
	{
		return InverseFast().TransformVector(v);
	}

	public FMatrix GetTransposed()
	{
		FMatrix result = default(FMatrix);
		result.M11 = M11;
		result.M12 = M21;
		result.M13 = M31;
		result.M14 = M41;
		result.M21 = M12;
		result.M22 = M22;
		result.M23 = M32;
		result.M24 = M42;
		result.M31 = M13;
		result.M32 = M23;
		result.M33 = M33;
		result.M34 = M43;
		result.M41 = M14;
		result.M42 = M24;
		result.M43 = M34;
		result.M44 = M44;
		return result;
	}

	public double Determinant()
	{
		return M11 * (M22 * (M33 * M44 - M34 * M43) - M32 * (M23 * M44 - M24 * M43) + M42 * (M23 * M34 - M24 * M33)) - M21 * (M12 * (M33 * M44 - M34 * M43) - M32 * (M13 * M44 - M14 * M43) + M42 * (M13 * M34 - M14 * M33)) + M31 * (M12 * (M23 * M44 - M24 * M43) - M22 * (M13 * M44 - M14 * M43) + M42 * (M13 * M24 - M14 * M23)) - M41 * (M12 * (M23 * M34 - M24 * M33) - M22 * (M13 * M34 - M14 * M33) + M32 * (M13 * M24 - M14 * M23));
	}

	public double RotDeterminant()
	{
		return M11 * (M22 * M33 - M23 * M32) - M21 * (M12 * M33 - M13 * M32) + M31 * (M12 * M23 - M13 * M22);
	}

	public FMatrix InverseFast()
	{
		VectorMatrixInverse(out var result, ref this);
		return result;
	}

	private static void VectorMatrixInverse(out FMatrix result, ref FMatrix matrix)
	{
		double m = matrix.M11;
		double m2 = matrix.M12;
		double m3 = matrix.M13;
		double m4 = matrix.M14;
		double m5 = matrix.M21;
		double m6 = matrix.M22;
		double m7 = matrix.M23;
		double m8 = matrix.M24;
		double m9 = matrix.M31;
		double m10 = matrix.M32;
		double m11 = matrix.M33;
		double m12 = matrix.M34;
		double m13 = matrix.M41;
		double m14 = matrix.M42;
		double m15 = matrix.M43;
		double m16 = matrix.M44;
		double num = m11 * m16 - m12 * m15;
		double num2 = m10 * m16 - m12 * m14;
		double num3 = m10 * m15 - m11 * m14;
		double num4 = m9 * m16 - m12 * m13;
		double num5 = m9 * m15 - m11 * m13;
		double num6 = m9 * m14 - m10 * m13;
		double num7 = m6 * num - m7 * num2 + m8 * num3;
		double num8 = 0.0 - (m5 * num - m7 * num4 + m8 * num5);
		double num9 = m5 * num2 - m6 * num4 + m8 * num6;
		double num10 = 0.0 - (m5 * num3 - m6 * num5 + m7 * num6);
		double num11 = 1.0 / (m * num7 + m2 * num8 + m3 * num9 + m4 * num10);
		result.M11 = num7 * num11;
		result.M21 = num8 * num11;
		result.M31 = num9 * num11;
		result.M41 = num10 * num11;
		result.M12 = (0.0 - (m2 * num - m3 * num2 + m4 * num3)) * num11;
		result.M22 = (m * num - m3 * num4 + m4 * num5) * num11;
		result.M32 = (0.0 - (m * num2 - m2 * num4 + m4 * num6)) * num11;
		result.M42 = (m * num3 - m2 * num5 + m3 * num6) * num11;
		double num12 = m7 * m16 - m8 * m15;
		double num13 = m6 * m16 - m8 * m14;
		double num14 = m6 * m15 - m7 * m14;
		double num15 = m5 * m16 - m8 * m13;
		double num16 = m5 * m15 - m7 * m13;
		double num17 = m5 * m14 - m6 * m13;
		result.M13 = (m2 * num12 - m3 * num13 + m4 * num14) * num11;
		result.M23 = (0.0 - (m * num12 - m3 * num15 + m4 * num16)) * num11;
		result.M33 = (m * num13 - m2 * num15 + m4 * num17) * num11;
		result.M43 = (0.0 - (m * num14 - m2 * num16 + m3 * num17)) * num11;
		double num18 = m7 * m12 - m8 * m11;
		double num19 = m6 * m12 - m8 * m10;
		double num20 = m6 * m11 - m7 * m10;
		double num21 = m5 * m12 - m8 * m9;
		double num22 = m5 * m11 - m7 * m9;
		double num23 = m5 * m10 - m6 * m9;
		result.M14 = (0.0 - (m2 * num18 - m3 * num19 + m4 * num20)) * num11;
		result.M24 = (m * num18 - m3 * num21 + m4 * num22) * num11;
		result.M34 = (0.0 - (m * num19 - m2 * num21 + m4 * num23)) * num11;
		result.M44 = (m * num20 - m2 * num22 + m3 * num23) * num11;
	}

	public FMatrix Inverse()
	{
		if (GetScaledAxis(EAxis.X).IsNearlyZero(9.99999993922529E-09) && GetScaledAxis(EAxis.Y).IsNearlyZero(9.99999993922529E-09) && GetScaledAxis(EAxis.Z).IsNearlyZero(9.99999993922529E-09))
		{
			return Identity;
		}
		if (Determinant() == 0.0)
		{
			return Identity;
		}
		VectorMatrixInverse(out var result, ref this);
		return result;
	}

	public FMatrix TransposeAdjoint()
	{
		FMatrix result = default(FMatrix);
		result.M11 = M22 * M33 - M23 * M32;
		result.M12 = M23 * M31 - M21 * M33;
		result.M13 = M21 * M32 - M22 * M31;
		result.M14 = 0.0;
		result.M21 = M32 * M13 - M33 * M12;
		result.M22 = M33 * M11 - M31 * M13;
		result.M23 = M31 * M12 - M32 * M11;
		result.M24 = 0.0;
		result.M31 = M12 * M23 - M13 * M22;
		result.M32 = M13 * M21 - M11 * M23;
		result.M33 = M11 * M22 - M12 * M21;
		result.M34 = 0.0;
		result.M41 = 0.0;
		result.M42 = 0.0;
		result.M43 = 0.0;
		result.M44 = 1.0;
		return result;
	}

	public void RemoveScaling(double tolerance = 9.99999993922529E-09)
	{
		double num = M11 * M11 + M12 * M12 + M13 * M13;
		double num2 = M21 * M21 + M22 * M22 + M23 * M23;
		double num3 = M31 * M31 + M32 * M32 + M33 * M33;
		double num4 = FMath.DoubleSelect(num - tolerance, FMath.InvSqrt(num), 1.0);
		double num5 = FMath.DoubleSelect(num2 - tolerance, FMath.InvSqrt(num2), 1.0);
		double num6 = FMath.DoubleSelect(num3 - tolerance, FMath.InvSqrt(num3), 1.0);
		M11 *= num4;
		M12 *= num4;
		M13 *= num4;
		M21 *= num5;
		M22 *= num5;
		M23 *= num5;
		M31 *= num6;
		M32 *= num6;
		M33 *= num6;
	}

	public FMatrix GetMatrixWithoutScale(double tolerance = 9.99999993922529E-09)
	{
		FMatrix result = this;
		result.RemoveScaling(tolerance);
		return result;
	}

	public FVector ExtractScaling(double tolerance = 9.99999993922529E-09)
	{
		FVector result = new FVector(0.0, 0.0, 0.0);
		double num = M11 * M11 + M12 * M12 + M13 * M13;
		double num2 = M21 * M21 + M22 * M22 + M23 * M23;
		double num3 = M31 * M31 + M32 * M32 + M33 * M33;
		if (num > tolerance)
		{
			double num4 = (result[0] = FMath.Sqrt(num));
			double num6 = 1.0 / num4;
			M11 *= num6;
			M12 *= num6;
			M13 *= num6;
		}
		else
		{
			result[0] = 0.0;
		}
		if (num2 > tolerance)
		{
			double num7 = (result[1] = FMath.Sqrt(num2));
			double num9 = 1.0 / num7;
			M21 *= num9;
			M22 *= num9;
			M23 *= num9;
		}
		else
		{
			result[1] = 0.0;
		}
		if (num3 > tolerance)
		{
			double num10 = (result[2] = FMath.Sqrt(num3));
			double num12 = 1.0 / num10;
			M31 *= num12;
			M32 *= num12;
			M33 *= num12;
		}
		else
		{
			result[2] = 0.0;
		}
		return result;
	}

	public FVector GetScaleVector(double tolerance = 9.99999993922529E-09)
	{
		FVector result = new FVector(1.0, 1.0, 1.0);
		for (int i = 0; i < 3; i++)
		{
			double num = this[i, 0] * this[i, 0] + this[i, 1] * this[i, 1] + this[i, 2] * this[i, 2];
			if (num > tolerance)
			{
				result[i] = FMath.Sqrt(num);
			}
			else
			{
				result[i] = 0.0;
			}
		}
		return result;
	}

	public FMatrix RemoveTranslation()
	{
		FMatrix result = this;
		result.M41 = 0.0;
		result.M42 = 0.0;
		result.M43 = 0.0;
		return result;
	}

	public FMatrix ConcatTranslation(FVector translation)
	{
		FMatrix result = this;
		result.M41 += translation.X;
		result.M42 += translation.Y;
		result.M43 += translation.Z;
		return result;
	}

	public bool ContainsNaN()
	{
		for (int i = 0; i < 4; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (!FMath.IsFinite(this[i, j]))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void ScaleTranslation(FVector scale3D)
	{
		M41 *= scale3D.X;
		M42 *= scale3D.Y;
		M43 *= scale3D.Z;
	}

	public double GetMaximumAxisScale()
	{
		return FMath.Sqrt(FMath.Max(GetScaledAxis(EAxis.X).SizeSquared(), FMath.Max(GetScaledAxis(EAxis.Y).SizeSquared(), GetScaledAxis(EAxis.Z).SizeSquared())));
	}

	public FMatrix ApplyScale(double scale)
	{
		return new FMatrix(scale, 0.0, 0.0, 0.0, 0.0, scale, 0.0, 0.0, 0.0, 0.0, scale, 0.0, 0.0, 0.0, 0.0, 1.0) * this;
	}

	public FVector GetOrigin()
	{
		return new FVector(M41, M42, M43);
	}

	public FVector GetScaledAxis(EAxis axis)
	{
		return axis switch
		{
			EAxis.X => new FVector(M11, M12, M13), 
			EAxis.Y => new FVector(M21, M22, M23), 
			EAxis.Z => new FVector(M31, M32, M33), 
			_ => throw new ArgumentOutOfRangeException(), 
		};
	}

	public void GetScaledAxes(out FVector X, out FVector Y, out FVector Z)
	{
		X.mX = M11;
		X.mY = M12;
		X.mZ = M13;
		Y.mX = M21;
		Y.mY = M22;
		Y.mZ = M23;
		Z.mX = M31;
		Z.mY = M32;
		Z.mZ = M33;
	}

	public FVector GetUnitAxis(EAxis axis)
	{
		return GetScaledAxis(axis).GetSafeNormal();
	}

	public void GetUnitAxes(out FVector X, out FVector Y, out FVector Z)
	{
		GetScaledAxes(out X, out Y, out Z);
	}

	public void SetAxis(int i, FVector axis)
	{
		this[i, 0] = axis.X;
		this[i, 1] = axis.Y;
		this[i, 2] = axis.Z;
	}

	public void SetOrigin(FVector newOrigin)
	{
		M41 = newOrigin.X;
		M42 = newOrigin.Y;
		M43 = newOrigin.Z;
	}

	public void SetAxes(FVector? axis0 = null, FVector? axis1 = null, FVector? axis2 = null, FVector? origin = null)
	{
		if (axis0.HasValue)
		{
			FVector value = axis0.Value;
			M11 = value.X;
			M12 = value.Y;
			M13 = value.Z;
		}
		if (axis1.HasValue)
		{
			FVector value2 = axis1.Value;
			M21 = value2.X;
			M22 = value2.Y;
			M23 = value2.Z;
		}
		if (axis2.HasValue)
		{
			FVector value3 = axis2.Value;
			M31 = value3.X;
			M32 = value3.Y;
			M33 = value3.Z;
		}
		if (origin.HasValue)
		{
			FVector value4 = origin.Value;
			M41 = value4.X;
			M42 = value4.Y;
			M43 = value4.Z;
		}
	}

	public FVector GetRow(int i)
	{
		return new FVector(this[i, 0], this[i, 1], this[i, 2]);
	}

	public FVector GetColumn(int i)
	{
		return new FVector(this[0, i], this[1, i], this[2, i]);
	}

	public FRotator Rotator()
	{
		FVector scaledAxis = GetScaledAxis(EAxis.X);
		FVector scaledAxis2 = GetScaledAxis(EAxis.Y);
		FVector scaledAxis3 = GetScaledAxis(EAxis.Z);
		FRotator fRotator = new FRotator(FMath.Atan2(scaledAxis.Z, FMath.Sqrt(FMath.Square(scaledAxis.X) + FMath.Square(scaledAxis.Y))) * 180f / (float)Math.PI, FMath.Atan2(scaledAxis.Y, scaledAxis.X) * 180f / (float)Math.PI, 0.0);
		FVector scaledAxis4 = CreateRotation(fRotator).GetScaledAxis(EAxis.Y);
		fRotator.Roll = FMath.Atan2(scaledAxis3 | scaledAxis4, scaledAxis2 | scaledAxis4) * 180f / (float)Math.PI;
		return fRotator;
	}

	public FQuat ToQuat()
	{
		return new FQuat(this);
	}

	private static bool MakeFrustumPlane(double a, double b, double c, double d, out FPlane plane)
	{
		double num = a * a + b * b + c * c;
		if (num > 9.999999439624929E-11)
		{
			double num2 = FMath.InvSqrt(num);
			plane = new FPlane((0.0 - a) * num2, (0.0 - b) * num2, (0.0 - c) * num2, d * num2);
			return true;
		}
		plane = default(FPlane);
		return false;
	}

	public bool GetFrustumNearPlane(out FPlane plane)
	{
		return MakeFrustumPlane(M13, M23, M33, M43, out plane);
	}

	public bool GetFrustumFarPlane(out FPlane plane)
	{
		return MakeFrustumPlane(M14 - M13, M24 - M23, M34 - M33, M44 - M43, out plane);
	}

	public bool GetFrustumLeftPlane(out FPlane plane)
	{
		return MakeFrustumPlane(M14 + M11, M24 + M21, M34 + M31, M44 + M41, out plane);
	}

	public bool GetFrustumRightPlane(out FPlane plane)
	{
		return MakeFrustumPlane(M14 - M11, M24 - M21, M34 - M31, M44 - M41, out plane);
	}

	public bool GetFrustumTopPlane(out FPlane plane)
	{
		return MakeFrustumPlane(M14 - M12, M24 - M22, M34 - M32, M44 - M42, out plane);
	}

	public bool GetFrustumBottomPlane(out FPlane plane)
	{
		return MakeFrustumPlane(M14 + M12, M24 + M22, M34 + M32, M44 + M42, out plane);
	}

	public void Mirror(EAxis mirrorAxis, EAxis flipAxis)
	{
		switch (mirrorAxis)
		{
		case EAxis.X:
			M11 *= -1.0;
			M21 *= -1.0;
			M31 *= -1.0;
			M41 *= -1.0;
			break;
		case EAxis.Y:
			M12 *= -1.0;
			M22 *= -1.0;
			M32 *= -1.0;
			M42 *= -1.0;
			break;
		case EAxis.Z:
			M13 *= -1.0;
			M23 *= -1.0;
			M33 *= -1.0;
			M43 *= -1.0;
			break;
		}
		switch (flipAxis)
		{
		case EAxis.X:
			M11 *= -1.0;
			M12 *= -1.0;
			M13 *= -1.0;
			break;
		case EAxis.Y:
			M21 *= -1.0;
			M22 *= -1.0;
			M23 *= -1.0;
			break;
		case EAxis.Z:
			M31 *= -1.0;
			M32 *= -1.0;
			M33 *= -1.0;
			break;
		}
	}

	public override string ToString()
	{
		string text = "000.000";
		return "[" + M11.ToString(text) + " " + M12.ToString(text) + " " + M13.ToString(text) + " " + M14.ToString(text) + "] [" + M21.ToString(text) + " " + M22.ToString(text) + " " + M23.ToString(text) + " " + M24.ToString(text) + "] [" + M31.ToString(text) + " " + M32.ToString(text) + " " + M33.ToString(text) + " " + M34.ToString(text) + "] [" + M41.ToString(text) + " " + M42.ToString(text) + " " + M43.ToString(text) + " " + M44.ToString(text) + "]";
	}

	public void DebugPrint()
	{
		FMessage.Log("LogUnrealMath", ELogVerbosity.Log, ToString());
	}

	public unsafe uint ComputeHash()
	{
		uint num = 0u;
		for (int i = 0; i < 16; i++)
		{
			double num2 = this[i];
			num ^= *(uint*)(&num2);
		}
		return num;
	}

	public void To3x4MatrixTranspose(ref FMatrix result)
	{
		result[0] = this[0];
		result[1] = this[4];
		result[2] = this[8];
		result[3] = this[12];
		result[4] = this[1];
		result[5] = this[5];
		result[6] = this[9];
		result[7] = this[13];
		result[8] = this[2];
		result[9] = this[6];
		result[10] = this[10];
		result[11] = this[14];
	}

	public static double[] Inverse4x4(ref FMatrix src)
	{
		double[] dst = new double[16];
		Inverse4x4(ref dst, ref src);
		return dst;
	}

	public static void Inverse4x4(ref double[] dst, ref FMatrix src)
	{
		double num = src[0];
		double num2 = src[1];
		double num3 = src[2];
		double num4 = src[3];
		double num5 = src[4];
		double num6 = src[5];
		double num7 = src[6];
		double num8 = src[7];
		double num9 = src[8];
		double num10 = src[9];
		double num11 = src[10];
		double num12 = src[11];
		double num13 = src[12];
		double num14 = src[13];
		double num15 = src[14];
		double num16 = src[15];
		double[] array = new double[16]
		{
			num6 * num11 * num16 - num6 * num12 * num15 - num10 * num7 * num16 + num10 * num8 * num15 + num14 * num7 * num12 - num14 * num8 * num11,
			(0.0 - num2) * num11 * num16 + num2 * num12 * num15 + num10 * num3 * num16 - num10 * num4 * num15 - num14 * num3 * num12 + num14 * num4 * num11,
			num2 * num7 * num16 - num2 * num8 * num15 - num6 * num3 * num16 + num6 * num4 * num15 + num14 * num3 * num8 - num14 * num4 * num7,
			(0.0 - num2) * num7 * num12 + num2 * num8 * num11 + num6 * num3 * num12 - num6 * num4 * num11 - num10 * num3 * num8 + num10 * num4 * num7,
			(0.0 - num5) * num11 * num16 + num5 * num12 * num15 + num9 * num7 * num16 - num9 * num8 * num15 - num13 * num7 * num12 + num13 * num8 * num11,
			num * num11 * num16 - num * num12 * num15 - num9 * num3 * num16 + num9 * num4 * num15 + num13 * num3 * num12 - num13 * num4 * num11,
			(0.0 - num) * num7 * num16 + num * num8 * num15 + num5 * num3 * num16 - num5 * num4 * num15 - num13 * num3 * num8 + num13 * num4 * num7,
			num * num7 * num12 - num * num8 * num11 - num5 * num3 * num12 + num5 * num4 * num11 + num9 * num3 * num8 - num9 * num4 * num7,
			num5 * num10 * num16 - num5 * num12 * num14 - num9 * num6 * num16 + num9 * num8 * num14 + num13 * num6 * num12 - num13 * num8 * num10,
			(0.0 - num) * num10 * num16 + num * num12 * num14 + num9 * num2 * num16 - num9 * num4 * num14 - num13 * num2 * num12 + num13 * num4 * num10,
			num * num6 * num16 - num * num8 * num14 - num5 * num2 * num16 + num5 * num4 * num14 + num13 * num2 * num8 - num13 * num4 * num6,
			(0.0 - num) * num6 * num12 + num * num8 * num10 + num5 * num2 * num12 - num5 * num4 * num10 - num9 * num2 * num8 + num9 * num4 * num6,
			(0.0 - num5) * num10 * num15 + num5 * num11 * num14 + num9 * num6 * num15 - num9 * num7 * num14 - num13 * num6 * num11 + num13 * num7 * num10,
			num * num10 * num15 - num * num11 * num14 - num9 * num2 * num15 + num9 * num3 * num14 + num13 * num2 * num11 - num13 * num3 * num10,
			(0.0 - num) * num6 * num15 + num * num7 * num14 + num5 * num2 * num15 - num5 * num3 * num14 - num13 * num2 * num7 + num13 * num3 * num6,
			num * num6 * num11 - num * num7 * num10 - num5 * num2 * num11 + num5 * num3 * num10 + num9 * num2 * num7 - num9 * num3 * num6
		};
		double num17 = num * array[0] + num2 * array[4] + num3 * array[8] + num4 * array[12];
		if (num17 != 0.0)
		{
			num17 = 1.0 / num17;
		}
		if (dst == null || dst.Length < 16)
		{
			dst = new double[16];
		}
		for (int i = 0; i < 16; i++)
		{
			dst[i] = array[i] * num17;
		}
	}

	public static FMatrix CreateRotationTranslation(FRotator rot, FVector origin)
	{
		FMath.SinCos(out double scalarSin, out double scalarCos, (double)FMath.DegreesToRadians(rot.Pitch));
		FMath.SinCos(out double scalarSin2, out double scalarCos2, (double)FMath.DegreesToRadians(rot.Yaw));
		FMath.SinCos(out double scalarSin3, out double scalarCos3, (double)FMath.DegreesToRadians(rot.Roll));
		FMatrix result = default(FMatrix);
		result.M11 = scalarCos * scalarCos2;
		result.M12 = scalarCos * scalarSin2;
		result.M13 = scalarSin;
		result.M14 = 0.0;
		result.M21 = scalarSin3 * scalarSin * scalarCos2 - scalarCos3 * scalarSin2;
		result.M22 = scalarSin3 * scalarSin * scalarSin2 + scalarCos3 * scalarCos2;
		result.M23 = (0.0 - scalarSin3) * scalarCos;
		result.M24 = 0.0;
		result.M31 = 0.0 - (scalarCos3 * scalarSin * scalarCos2 + scalarSin3 * scalarSin2);
		result.M32 = scalarCos2 * scalarSin3 - scalarCos3 * scalarSin * scalarSin2;
		result.M33 = scalarCos3 * scalarCos;
		result.M34 = 0.0;
		result.M41 = origin.X;
		result.M42 = origin.Y;
		result.M43 = origin.Z;
		result.M44 = 1.0;
		return result;
	}

	public static FMatrix CreateRotation(FRotator rot)
	{
		return CreateRotationTranslation(rot, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationX(FVector xAxis)
	{
		FVector safeNormal = xAxis.GetSafeNormal();
		FVector safeNormal2 = (((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0)) ^ safeNormal).GetSafeNormal();
		FVector z = safeNormal ^ safeNormal2;
		return new FMatrix(safeNormal, safeNormal2, z, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationY(FVector yAxis)
	{
		FVector safeNormal = yAxis.GetSafeNormal();
		FVector safeNormal2 = (((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0)) ^ safeNormal).GetSafeNormal();
		return new FMatrix(safeNormal ^ safeNormal2, safeNormal, safeNormal2, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationZ(FVector zAxis)
	{
		FVector safeNormal = zAxis.GetSafeNormal();
		FVector safeNormal2 = (((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0)) ^ safeNormal).GetSafeNormal();
		FVector y = safeNormal ^ safeNormal2;
		return new FMatrix(safeNormal2, y, safeNormal, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationXY(FVector xAxis, FVector yAxis)
	{
		FVector safeNormal = xAxis.GetSafeNormal();
		FVector fVector = yAxis.GetSafeNormal();
		if (FMath.IsNearlyEqual(FMath.Abs(safeNormal | fVector), 1f))
		{
			fVector = ((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0));
		}
		FVector safeNormal2 = (safeNormal ^ fVector).GetSafeNormal();
		FVector y = safeNormal2 ^ safeNormal;
		return new FMatrix(safeNormal, y, safeNormal2, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationXZ(FVector xAxis, FVector zAxis)
	{
		FVector safeNormal = xAxis.GetSafeNormal();
		FVector fVector = zAxis.GetSafeNormal();
		if (FMath.IsNearlyEqual(FMath.Abs(safeNormal | fVector), 1f))
		{
			fVector = ((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0));
		}
		FVector safeNormal2 = (fVector ^ safeNormal).GetSafeNormal();
		FVector z = safeNormal ^ safeNormal2;
		return new FMatrix(safeNormal, safeNormal2, z, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationYX(FVector yAxis, FVector xAxis)
	{
		FVector safeNormal = yAxis.GetSafeNormal();
		FVector fVector = xAxis.GetSafeNormal();
		if (FMath.IsNearlyEqual(FMath.Abs(safeNormal | fVector), 1f))
		{
			fVector = ((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0));
		}
		FVector safeNormal2 = (fVector ^ safeNormal).GetSafeNormal();
		return new FMatrix(safeNormal ^ safeNormal2, safeNormal, safeNormal2, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationYZ(FVector yAxis, FVector zAxis)
	{
		FVector safeNormal = yAxis.GetSafeNormal();
		FVector fVector = zAxis.GetSafeNormal();
		if (FMath.IsNearlyEqual(FMath.Abs(safeNormal | fVector), 1f))
		{
			fVector = ((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0));
		}
		FVector safeNormal2 = (safeNormal ^ fVector).GetSafeNormal();
		return new FMatrix(z: safeNormal2 ^ safeNormal, x: safeNormal2, y: safeNormal, w: FVector.ZeroVector);
	}

	public static FMatrix CreateRotationZX(FVector zAxis, FVector xAxis)
	{
		FVector safeNormal = zAxis.GetSafeNormal();
		FVector fVector = xAxis.GetSafeNormal();
		if (FMath.IsNearlyEqual(FMath.Abs(safeNormal | fVector), 1f))
		{
			fVector = ((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0));
		}
		FVector safeNormal2 = (safeNormal ^ fVector).GetSafeNormal();
		return new FMatrix(safeNormal2 ^ safeNormal, safeNormal2, safeNormal, FVector.ZeroVector);
	}

	public static FMatrix CreateRotationZY(FVector zAxis, FVector yAxis)
	{
		FVector safeNormal = zAxis.GetSafeNormal();
		FVector fVector = yAxis.GetSafeNormal();
		if (FMath.IsNearlyEqual(FMath.Abs(safeNormal | fVector), 1f))
		{
			fVector = ((FMath.Abs(safeNormal.Z) < 0.9999f) ? new FVector(0.0, 0.0, 1.0) : new FVector(1.0, 0.0, 0.0));
		}
		FVector safeNormal2 = (fVector ^ safeNormal).GetSafeNormal();
		FVector y = safeNormal ^ safeNormal2;
		return new FMatrix(safeNormal2, y, safeNormal, FVector.ZeroVector);
	}

	public static FMatrix CreateTranslation(FVector v)
	{
		return new FMatrix(1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, v.X, v.Y, v.Z, 1.0);
	}

	public static FMatrix CreateScale(double scale)
	{
		return new FMatrix(scale, 0.0, 0.0, 0.0, 0.0, scale, 0.0, 0.0, 0.0, 0.0, scale, 0.0, 0.0, 0.0, 0.0, 1.0);
	}

	public static FMatrix CreateScale(FVector scale)
	{
		return new FMatrix(scale.X, 0.0, 0.0, 0.0, 0.0, scale.Y, 0.0, 0.0, 0.0, 0.0, scale.Z, 0.0, 0.0, 0.0, 0.0, 1.0);
	}

	private static void GetSinCos(out double s, out double c, double degrees)
	{
		if (degrees == 0.0)
		{
			s = 0.0;
			c = 1.0;
		}
		else if (degrees == 90.0)
		{
			s = 1.0;
			c = 0.0;
		}
		else if (degrees == 180.0)
		{
			s = 0.0;
			c = -1.0;
		}
		else if (degrees == 270.0)
		{
			s = -1.0;
			c = 0.0;
		}
		else
		{
			FMath.SinCos(out s, out c, FMath.DegreesToRadians(degrees));
		}
	}

	public static FMatrix CreateScaleRotationTranslation(FVector scale, FRotator rot, FVector origin)
	{
		GetSinCos(out var s, out var c, rot.Pitch);
		GetSinCos(out var s2, out var c2, rot.Yaw);
		GetSinCos(out var s3, out var c3, rot.Roll);
		FMatrix result = default(FMatrix);
		result.M11 = c * c2 * (double)scale.X;
		result.M12 = c * s2 * (double)scale.X;
		result.M13 = s * (double)scale.X;
		result.M14 = 0.0;
		result.M21 = (s3 * s * c2 - c3 * s2) * (double)scale.Y;
		result.M22 = (s3 * s * s2 + c3 * c2) * (double)scale.Y;
		result.M23 = (0.0 - s3) * c * (double)scale.Y;
		result.M24 = 0.0;
		result.M31 = (0.0 - (c3 * s * c2 + s3 * s2)) * (double)scale.Z;
		result.M32 = (c2 * s3 - c3 * s * s2) * (double)scale.Z;
		result.M33 = c3 * c * (double)scale.Z;
		result.M34 = 0.0;
		result.M41 = origin.X;
		result.M42 = origin.Y;
		result.M43 = origin.Z;
		result.M44 = 1.0;
		return result;
	}

	public static FMatrix CreateQuatRotationTranslation(FQuat q, FVector origin)
	{
		double num = q.X + q.X;
		double num2 = q.Y + q.Y;
		double num3 = q.Z + q.Z;
		double num4 = (double)q.X * num;
		double num5 = (double)q.X * num2;
		double num6 = (double)q.X * num3;
		double num7 = (double)q.Y * num2;
		double num8 = (double)q.Y * num3;
		double num9 = (double)q.Z * num3;
		double num10 = (double)q.W * num;
		double num11 = (double)q.W * num2;
		double num12 = (double)q.W * num3;
		FMatrix result = default(FMatrix);
		result.M11 = 1.0 - (num7 + num9);
		result.M21 = num5 - num12;
		result.M31 = num6 + num11;
		result.M41 = origin.X;
		result.M12 = num5 + num12;
		result.M22 = 1.0 - (num4 + num9);
		result.M32 = num8 - num10;
		result.M42 = origin.Y;
		result.M13 = num6 - num11;
		result.M23 = num8 + num10;
		result.M33 = 1.0 - (num4 + num7);
		result.M43 = origin.Z;
		result.M14 = 0.0;
		result.M24 = 0.0;
		result.M34 = 0.0;
		result.M44 = 1.0;
		return result;
	}

	public static FMatrix CreateQuatRotation(FQuat q)
	{
		return CreateQuatRotationTranslation(q, FVector.ZeroVector);
	}

	public static FMatrix CreateInverseRotation(FRotator rot)
	{
		FMatrix fMatrix = new FMatrix(FMath.Cos(rot.Yaw * (float)Math.PI / 180f), 0f - FMath.Sin(rot.Yaw * (float)Math.PI / 180f), 0.0, 0.0, FMath.Sin(rot.Yaw * (float)Math.PI / 180f), FMath.Cos(rot.Yaw * (float)Math.PI / 180f), 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0);
		FMatrix fMatrix2 = new FMatrix(FMath.Cos(rot.Pitch * (float)Math.PI / 180f), 0.0, 0f - FMath.Sin(rot.Pitch * (float)Math.PI / 180f), 0.0, 0.0, 1.0, 0.0, 0.0, FMath.Sin(rot.Pitch * (float)Math.PI / 180f), 0.0, FMath.Cos(rot.Pitch * (float)Math.PI / 180f), 0.0, 0.0, 0.0, 0.0, 1.0);
		FMatrix fMatrix3 = new FMatrix(1.0, 0.0, 0.0, 0.0, 0.0, FMath.Cos(rot.Roll * (float)Math.PI / 180f), FMath.Sin(rot.Roll * (float)Math.PI / 180f), 0.0, 0.0, 0f - FMath.Sin(rot.Roll * (float)Math.PI / 180f), FMath.Cos(rot.Roll * (float)Math.PI / 180f), 0.0, 0.0, 0.0, 0.0, 1.0);
		return fMatrix * fMatrix2 * fMatrix3;
	}

	public static FMatrix CreateRotationAboutPoint(FRotator rot, FVector origin)
	{
		FMatrix result = CreateRotationTranslation(rot, origin);
		FVector fVector = new FVector(result.M11, result.M21, result.M31);
		FVector fVector2 = new FVector(result.M12, result.M22, result.M32);
		FVector fVector3 = new FVector(result.M13, result.M23, result.M33);
		result.M41 -= fVector | origin;
		result.M42 -= fVector2 | origin;
		result.M43 -= fVector3 | origin;
		return result;
	}

	public static FMatrix CreateRotationAboutPoint(FQuat rot, FVector origin)
	{
		return CreateRotationAboutPoint(rot.Rotator(), origin);
	}

	public static FMatrix CreateMirror(FPlane plane)
	{
		return new FMatrix(-2.0 * plane.X * plane.X + 1.0, -2.0 * plane.Y * plane.X, -2.0 * plane.Z * plane.X, 0.0, -2.0 * plane.X * plane.Y, -2.0 * plane.Y * plane.Y + 1.0, -2.0 * plane.Z * plane.Y, 0.0, -2.0 * plane.X * plane.Z, -2.0 * plane.Y * plane.Z, -2.0 * plane.Z * plane.Z + 1.0, 0.0, 2.0 * plane.X * plane.W, 2.0 * plane.Y * plane.W, 2.0 * plane.Z * plane.W, 1.0);
	}

	public static FMatrix CreateOrtho(double width, double height, double zScale, double zOffset)
	{
		return new FMatrix((width != 0.0) ? (1.0 / width) : 1.0, 0.0, 0.0, 0.0, 0.0, (height != 0.0) ? (1.0 / height) : 1.0, 0.0, 0.0, 0.0, 0.0, zScale, 0.0, 0.0, 0.0, zOffset * zScale, 1.0);
	}

	public static FMatrix ReversedZOrtho(double width, double height, double zScale, double zOffset)
	{
		return new FMatrix((width != 0.0) ? (1.0 / width) : 1.0, 0.0, 0.0, 0.0, 0.0, (height != 0.0) ? (1.0 / height) : 1.0, 0.0, 0.0, 0.0, 0.0, 0.0 - zScale, 0.0, 0.0, 0.0, 1.0 - zOffset * zScale, 1.0);
	}

	public static FMatrix CreatePerspective(double halfFOVX, double halfFOVY, double multFOVX, double multFOVY, double minZ, double maxZ)
	{
		return new FMatrix(multFOVX / FMath.Tan(halfFOVX), 0.0, 0.0, 0.0, 0.0, multFOVY / FMath.Tan(halfFOVY), 0.0, 0.0, 0.0, 0.0, (minZ == maxZ) ? 1.0 : (maxZ / (maxZ - minZ)), 1.0, 0.0, 0.0, (0.0 - minZ) * ((minZ == maxZ) ? 1.0 : (maxZ / (maxZ - minZ))), 0.0);
	}

	public static FMatrix CreatePerspective(double halfFOV, double width, double height, double minZ, double maxZ)
	{
		return new FMatrix(1.0 / FMath.Tan(halfFOV), 0.0, 0.0, 0.0, 0.0, width / FMath.Tan(halfFOV) / height, 0.0, 0.0, 0.0, 0.0, (minZ == maxZ) ? 1.0 : (maxZ / (maxZ - minZ)), 1.0, 0.0, 0.0, (0.0 - minZ) * ((minZ == maxZ) ? 1.0 : (maxZ / (maxZ - minZ))), 0.0);
	}

	public static FMatrix CreatePerspective(double halfFOV, double width, double height, double minZ)
	{
		return new FMatrix(1.0 / FMath.Tan(halfFOV), 0.0, 0.0, 0.0, 0.0, width / FMath.Tan(halfFOV) / height, 0.0, 0.0, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0, (0.0 - minZ) * 1.0, 0.0);
	}

	public static FMatrix CreateReversedZPerspective(double halfFOVX, double halfFOVY, double multFOVX, double multFOVY, double minZ, double maxZ)
	{
		return new FMatrix(multFOVX / FMath.Tan(halfFOVX), 0.0, 0.0, 0.0, 0.0, multFOVY / FMath.Tan(halfFOVY), 0.0, 0.0, 0.0, 0.0, (minZ == maxZ) ? 0.0 : (minZ / (minZ - maxZ)), 1.0, 0.0, 0.0, (minZ == maxZ) ? minZ : ((0.0 - maxZ) * minZ / (minZ - maxZ)), 0.0);
	}

	public static FMatrix CreateReversedZPerspective(double halfFOV, double width, double height, double minZ, double maxZ)
	{
		return new FMatrix(1.0 / FMath.Tan(halfFOV), 0.0, 0.0, 0.0, 0.0, width / FMath.Tan(halfFOV) / height, 0.0, 0.0, 0.0, 0.0, (minZ == maxZ) ? 0.0 : (minZ / (minZ - maxZ)), 1.0, 0.0, 0.0, (minZ == maxZ) ? minZ : ((0.0 - maxZ) * minZ / (minZ - maxZ)), 0.0);
	}

	public static FMatrix CreateReversedZPerspective(double halfFOV, double width, double height, double minZ)
	{
		return new FMatrix(1.0 / FMath.Tan(halfFOV), 0.0, 0.0, 0.0, 0.0, width / FMath.Tan(halfFOV) / height, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, minZ, 0.0);
	}

	public static FMatrix CreateClipProjection(FMatrix srcProjMat, FPlane plane)
	{
		FMatrix result = srcProjMat;
		FPlane fPlane = new FPlane(sgn(plane.X) / srcProjMat.M11, sgn(plane.Y) / srcProjMat.M22, 1.0, (0.0 - (1.0 - srcProjMat.M33)) / srcProjMat.M43);
		FPlane fPlane2 = plane * (1.0 / (plane | fPlane));
		result.M13 = fPlane2.X;
		result.M23 = fPlane2.Y;
		result.M33 = fPlane2.Z;
		result.M43 = 0.0 - fPlane2.W;
		return result;
	}

	private static double sgn(double a)
	{
		if (a > 0.0)
		{
			return 1.0;
		}
		if (a < 0.0)
		{
			return -1.0;
		}
		return 0.0;
	}
}
