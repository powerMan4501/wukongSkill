using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 59448)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Vector4", "CoreUObject", UnrealModuleType.Engine)]
public struct FVector4 : IEquatable<FVector4>
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector4:X")]
	public double mX;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector4:Y")]
	public double mY;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector4:Z")]
	public double mZ;

	private static bool W_IsValid;

	private static int W_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector4:W")]
	public double mW;

	private static int FVector4_StructSize;

	public static readonly FVector4 ZeroVector;

	public static readonly FVector4 OneVector;

	public static readonly FVector4 UpVector;

	public static readonly FVector4 ForwardVector;

	public static readonly FVector4 RightVector;

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

	public float W
	{
		get
		{
			return (float)mW;
		}
		set
		{
			mW = value;
		}
	}

	public double this[int index]
	{
		get
		{
			return index switch
			{
				0 => X, 
				1 => Y, 
				2 => Z, 
				3 => W, 
				_ => throw new IndexOutOfRangeException("Invalid FVector4 index (" + index + ")"), 
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
			case 3:
				mW = value;
				break;
			default:
				throw new IndexOutOfRangeException("Invalid FVector4 index (" + index + ")");
			}
		}
	}

	public FVector4 Copy()
	{
		return this;
	}

	static FVector4()
	{
		ZeroVector = new FVector4(0.0, 0.0, 0.0, 0.0);
		OneVector = new FVector4(1.0, 1.0, 1.0, 1.0);
		UpVector = new FVector4(0.0, 0.0, 1.0);
		ForwardVector = new FVector4(1.0);
		RightVector = new FVector4(0.0, 1.0);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVector4)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVector4));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Vector4");
		FVector4_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mX");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mX", Classes.FDoubleProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mY");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mY", Classes.FDoubleProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mZ");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mZ", Classes.FDoubleProperty);
		W_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mW");
		W_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mW", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FVector4));
	}

	public FVector4(FVector vector, double w = 1.0)
	{
		mX = vector.mX;
		mY = vector.mY;
		mZ = vector.mZ;
		mW = w;
	}

	public FVector4(FLinearColor color)
	{
		mX = color.R;
		mY = color.G;
		mZ = color.B;
		mW = color.A;
	}

	public FVector4(double x = 0.0, double y = 0.0, double z = 0.0, double w = 0.0)
	{
		mX = x;
		mY = y;
		mZ = z;
		mW = w;
	}

	public FVector4(FVector2D xy, FVector2D zw)
	{
		mX = xy.X;
		mY = xy.Y;
		mZ = zw.X;
		mW = zw.Y;
	}

	public static implicit operator FVector(FVector4 v)
	{
		return new FVector(v);
	}

	public static implicit operator FVector4(FVector v)
	{
		return new FVector4(v);
	}

	public static explicit operator FPlane(FVector4 v)
	{
		return new FPlane(v);
	}

	public static FVector4 operator -(FVector4 v)
	{
		return new FVector4(0f - v.X, 0f - v.Y, 0f - v.Z, 0f - v.W);
	}

	public static FVector4 operator +(FVector4 a, FVector4 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FVector4 Add(FVector4 a, FVector4 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FVector4 a, ref FVector4 b, out FVector4 result)
	{
		result.mX = a.mX + b.mX;
		result.mY = a.mY + b.mY;
		result.mZ = a.mZ + b.mZ;
		result.mW = a.mW + b.mW;
	}

	public static FVector4 operator -(FVector4 a, FVector4 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static FVector4 Subtract(FVector4 a, FVector4 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref FVector4 a, ref FVector4 b, out FVector4 result)
	{
		result.mX = a.mX - b.mX;
		result.mY = a.mY - b.mY;
		result.mZ = a.mZ - b.mZ;
		result.mW = a.mW - b.mW;
	}

	public static FVector4 operator -(FVector4 v, double bias)
	{
		Subtract(ref v, bias, out v);
		return v;
	}

	public static void Subtract(ref FVector4 v, double bias, out FVector4 result)
	{
		result.mX = v.mX - bias;
		result.mY = v.mY - bias;
		result.mZ = v.mZ - bias;
		result.mW = v.mW - bias;
	}

	public static FVector4 operator +(FVector4 v, double bias)
	{
		Add(ref v, bias, out v);
		return v;
	}

	public static void Add(ref FVector4 v, double bias, out FVector4 result)
	{
		result.mX = v.mX + bias;
		result.mY = v.mY + bias;
		result.mZ = v.mZ + bias;
		result.mW = v.mW + bias;
	}

	public static FVector4 operator *(double scale, FVector4 v)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FVector4 operator *(FVector4 v, double scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static void Multiply(ref FVector4 v, double scale, out FVector4 result)
	{
		result.mX = v.mX * scale;
		result.mY = v.mY * scale;
		result.mZ = v.mZ * scale;
		result.mW = v.mW * scale;
	}

	public static FVector4 operator /(FVector4 v, double scale)
	{
		Divide(ref v, scale, out v);
		return v;
	}

	public static void Divide(ref FVector4 v, double scale, out FVector4 result)
	{
		double num = 1.0 / scale;
		result.mX = v.mX * num;
		result.mY = v.mY * num;
		result.mZ = v.mZ * num;
		result.mW = v.mW * num;
	}

	public static FVector4 operator *(FVector4 a, FVector4 b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static FVector4 Multiply(FVector4 a, FVector4 b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static void Multiply(ref FVector4 a, ref FVector4 b, out FVector4 result)
	{
		result.mX = a.mX * b.mX;
		result.mY = a.mY * b.mY;
		result.mZ = a.mZ * b.mZ;
		result.mW = a.mW * b.mW;
	}

	public static FVector4 operator /(FVector4 a, FVector4 b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static FVector4 Divide(FVector4 a, FVector4 b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static void Divide(ref FVector4 a, ref FVector4 b, out FVector4 result)
	{
		result.mX = a.mX / b.mX;
		result.mY = a.mY / b.mY;
		result.mZ = a.mZ / b.mZ;
		result.mW = a.mW / b.mW;
	}

	public static bool operator ==(FVector4 a, FVector4 b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W != b.W;
		}
		return false;
	}

	public static bool operator !=(FVector4 a, FVector4 b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W != b.W;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FVector4))
		{
			return false;
		}
		return Equals((FVector4)obj);
	}

	public bool Equals(FVector4 other)
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

	public static double Dot3(FVector4 a, FVector4 b)
	{
		return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
	}

	public static double Dot4(FVector4 a, FVector4 b)
	{
		return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
	}

	public static FVector4 operator ^(FVector4 a, FVector4 b)
	{
		return new FVector4(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
	}

	public double Component(int index)
	{
		return this[index];
	}

	public bool Equals(FVector4 v, double tolerance = 9.999999747378752E-05)
	{
		if ((double)FMath.Abs(X - v.X) <= tolerance && (double)FMath.Abs(Y - v.Y) <= tolerance && (double)FMath.Abs(Z - v.Z) <= tolerance)
		{
			return (double)FMath.Abs(W - v.W) <= tolerance;
		}
		return false;
	}

	public bool IsUnit3(double lengthSquaredTolerance = 9.999999747378752E-05)
	{
		return FMath.Abs(1.0 - SizeSquared3()) < lengthSquaredTolerance;
	}

	public override string ToString()
	{
		string text = "000.000";
		return "X=" + X.ToString(text) + " Y=" + Y.ToString(text) + " Z=" + Z.ToString(text) + " W=" + W.ToString(text);
	}

	public bool InitFromString(string sourceString)
	{
		float num = (Z = 0f);
		float x = (Y = num);
		X = x;
		W = 1f;
		bool result = FParse.Value(sourceString, "X=", ref mX) && FParse.Value(sourceString, "Y=", ref mY) && FParse.Value(sourceString, "Z=", ref mZ);
		FParse.Value(sourceString, "W=", ref mW);
		return result;
	}

	public FVector4 GetSafeNormal(double tolerance = 9.99999993922529E-09)
	{
		double num = X * X + Y * Y + Z * Z;
		if (num > tolerance)
		{
			double num2 = FMath.InvSqrt(num);
			return new FVector4((double)X * num2, (double)Y * num2, (double)Z * num2);
		}
		return ZeroVector;
	}

	public FVector4 GetUnsafeNormal3()
	{
		double num = FMath.InvSqrt(X * X + Y * Y + Z * Z);
		return new FVector4((double)X * num, (double)Y * num, (double)Z * num);
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
		float num3 = 0.5f;
		FMath.SinCos(out var scalarSin, out var scalarCos, num2 * num3);
		FMath.SinCos(out var scalarSin2, out var scalarCos2, num * num3);
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

	public void Set(double x, double y, double z, double w)
	{
		mX = x;
		mY = y;
		mZ = z;
		mW = w;
	}

	public double Size3()
	{
		return FMath.Sqrt(X * X + Y * Y + Z * Z);
	}

	public double SizeSquared3()
	{
		return X * X + Y * Y + Z * Z;
	}

	public double Size()
	{
		return FMath.Sqrt(X * X + Y * Y + Z * Z + W * W);
	}

	public double SizeSquared()
	{
		return X * X + Y * Y + Z * Z + W * W;
	}

	public bool ContainsNaN()
	{
		if (FMath.IsFinite(X) && FMath.IsFinite(Y) && FMath.IsFinite(Z))
		{
			return !FMath.IsFinite(W);
		}
		return true;
	}

	public bool IsNearlyZero3(double tolerance = 9.999999747378752E-05)
	{
		if ((double)FMath.Abs(X) <= tolerance && (double)FMath.Abs(Y) <= tolerance)
		{
			return (double)FMath.Abs(Z) <= tolerance;
		}
		return false;
	}

	public FVector4 Reflect3(FVector4 normal)
	{
		return 2.0 * Dot3(this, normal) * normal - this;
	}

	public void FindBestAxisVectors3(FVector4 axis1, FVector4 axis2)
	{
		double num = FMath.Abs(X);
		double num2 = FMath.Abs(Y);
		double num3 = FMath.Abs(Z);
		axis1 = ((!(num3 > num) || !(num3 > num2)) ? new FVector4(0.0, 0.0, 1.0) : new FVector4(1.0));
		axis1 = (axis1 - this * Dot3(axis1, this)).GetSafeNormal();
		axis2 = axis1 ^ this;
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
}
