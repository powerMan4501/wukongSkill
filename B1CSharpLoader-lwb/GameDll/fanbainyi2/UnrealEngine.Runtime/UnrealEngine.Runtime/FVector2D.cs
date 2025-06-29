using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4254776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Vector2D", "CoreUObject", UnrealModuleType.Engine)]
public struct FVector2D : IEquatable<FVector2D>
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector2D:X")]
	public double mX;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Vector2D:Y")]
	public double mY;

	private static int FVector2D_StructSize;

	public static readonly FVector2D ZeroVector;

	public static readonly FVector2D UnitVector;

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

	public double this[int index]
	{
		get
		{
			return index switch
			{
				0 => X, 
				1 => Y, 
				_ => throw new IndexOutOfRangeException("Invalid FVector2D index (" + index + ")"), 
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
			default:
				throw new IndexOutOfRangeException("Invalid FVector2D index (" + index + ")");
			}
		}
	}

	public FVector2D Copy()
	{
		return this;
	}

	static FVector2D()
	{
		ZeroVector = new FVector2D(0.0, 0.0);
		UnitVector = new FVector2D(1.0, 1.0);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVector2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVector2D));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Vector2D");
		FVector2D_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mX");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mX", Classes.FDoubleProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mY");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mY", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FVector2D));
	}

	public FVector2D(double x, double y)
	{
		mX = x;
		mY = y;
	}

	public FVector2D(FIntPoint pos)
	{
		mX = pos.X;
		mY = pos.Y;
	}

	public FVector2D(FVector v)
	{
		mX = v.mX;
		mY = v.mY;
	}

	public static FVector2D operator +(FVector2D a, FVector2D b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FVector2D Add(FVector2D a, FVector2D b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FVector2D a, ref FVector2D b, out FVector2D result)
	{
		result.mX = a.mX + b.mX;
		result.mY = a.mY + b.mY;
	}

	public static FVector2D operator -(FVector2D a, FVector2D b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static FVector2D Subtract(FVector2D a, FVector2D b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref FVector2D a, ref FVector2D b, out FVector2D result)
	{
		result.mX = a.mX - b.mX;
		result.mY = a.mY - b.mY;
	}

	public static FVector2D operator *(double scale, FVector2D v)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FVector2D operator *(FVector2D v, double scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FVector2D Multiply(FVector2D v, double scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static void Multiply(ref FVector2D v, double scale, out FVector2D result)
	{
		result.mX = v.mX * scale;
		result.mY = v.mY * scale;
	}

	public static FVector2D operator /(FVector2D v, double scale)
	{
		Divide(ref v, scale, out v);
		return v;
	}

	public static FVector2D Divide(FVector2D v, double scale)
	{
		Divide(ref v, scale, out v);
		return v;
	}

	public static void Divide(ref FVector2D v, double scale, out FVector2D result)
	{
		double num = 1.0 / scale;
		result.mX = v.mX * num;
		result.mY = v.mY * num;
	}

	public static FVector2D operator +(FVector2D v, double f)
	{
		Add(ref v, f, out v);
		return v;
	}

	public static FVector2D Add(FVector2D v, double f)
	{
		Add(ref v, f, out v);
		return v;
	}

	public static void Add(ref FVector2D v, double f, out FVector2D result)
	{
		result.mX = v.mX + f;
		result.mY = v.mY + f;
	}

	public static FVector2D operator -(FVector2D v, double f)
	{
		Subtract(ref v, f, out v);
		return v;
	}

	public static FVector2D Subtract(FVector2D v, double f)
	{
		Subtract(ref v, f, out v);
		return v;
	}

	public static void Subtract(ref FVector2D v, double f, out FVector2D result)
	{
		result.mX = v.mX - f;
		result.mY = v.mY - f;
	}

	public static FVector2D operator *(FVector2D a, FVector2D b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static FVector2D Multiply(FVector2D a, FVector2D b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static void Multiply(ref FVector2D a, ref FVector2D b, out FVector2D result)
	{
		result.mX = a.mX * (double)b.X;
		result.mY = a.mY * (double)b.Y;
	}

	public static FVector2D operator /(FVector2D a, FVector2D b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static FVector2D Divide(FVector2D a, FVector2D b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static void Divide(ref FVector2D a, ref FVector2D b, out FVector2D result)
	{
		result.mX = a.mX / b.mX;
		result.mY = a.mY / b.mY;
	}

	public static double operator |(FVector2D a, FVector2D b)
	{
		return DotProduct(ref a, ref b);
	}

	public static float DotProduct(FVector2D a, FVector2D b)
	{
		return DotProduct(ref a, ref b);
	}

	public static float DotProduct(ref FVector2D a, ref FVector2D b)
	{
		DotProduct(ref a, ref b, out var result);
		return result;
	}

	public static void DotProduct(ref FVector2D a, ref FVector2D b, out float result)
	{
		result = a.X * b.X + a.Y * b.Y;
	}

	public static double operator ^(FVector2D a, FVector2D b)
	{
		CrossProduct(ref a, ref b, out var result);
		return result;
	}

	public static float CrossProduct(FVector2D a, FVector2D b)
	{
		CrossProduct(ref a, ref b, out var result);
		return (float)result;
	}

	public static double CrossProduct(ref FVector2D a, ref FVector2D b)
	{
		CrossProduct(ref a, ref b, out var result);
		return result;
	}

	public static void CrossProduct(ref FVector2D a, ref FVector2D b, out double result)
	{
		result = a.X * b.Y - a.Y * b.X;
	}

	public static bool operator ==(FVector2D a, FVector2D b)
	{
		if (a.X == b.X)
		{
			return a.Y == b.Y;
		}
		return false;
	}

	public static bool operator !=(FVector2D a, FVector2D b)
	{
		if (a.X == b.X)
		{
			return a.Y != b.Y;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FVector2D))
		{
			return false;
		}
		return Equals((FVector2D)obj);
	}

	public bool Equals(FVector2D other)
	{
		if (X == other.X)
		{
			return Y == other.Y;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (X.GetHashCode() * 397) ^ Y.GetHashCode();
	}

	public bool Equals(FVector2D v, double tolerance)
	{
		if ((double)FMath.Abs(X - v.X) <= tolerance)
		{
			return (double)FMath.Abs(Y - v.Y) <= tolerance;
		}
		return false;
	}

	public static bool operator >(FVector2D a, FVector2D b)
	{
		if (a.X > b.X)
		{
			return a.Y > b.Y;
		}
		return false;
	}

	public static bool operator <(FVector2D a, FVector2D b)
	{
		if (a.X < b.X)
		{
			return a.Y < b.Y;
		}
		return false;
	}

	public static bool operator >=(FVector2D a, FVector2D b)
	{
		if (a.X >= b.X)
		{
			return a.Y >= b.Y;
		}
		return false;
	}

	public static bool operator <=(FVector2D a, FVector2D b)
	{
		if (a.X <= b.X)
		{
			return a.Y <= b.Y;
		}
		return false;
	}

	public static FVector2D operator -(FVector2D v)
	{
		v.X = 0f - v.X;
		v.Y = 0f - v.Y;
		return v;
	}

	public double Component(int index)
	{
		return this[index];
	}

	public static float DistSquared(FVector2D v1, FVector2D v2)
	{
		return FMath.Square(v2.X - v1.X) + FMath.Square(v2.Y - v1.Y);
	}

	public static float Distance(FVector2D v1, FVector2D v2)
	{
		return FMath.Sqrt(DistSquared(v1, v2));
	}

	public void Set(int x, int y)
	{
		X = x;
		Y = y;
	}

	public double GetMax()
	{
		return FMath.Max(X, Y);
	}

	public double GetAbsMax()
	{
		return FMath.Max(FMath.Abs(X), FMath.Abs(Y));
	}

	public double GetMin()
	{
		return FMath.Min(X, Y);
	}

	public float Size()
	{
		return FMath.Sqrt(X * X + Y * Y);
	}

	public float SizeSquared()
	{
		return X * X + Y * Y;
	}

	public FVector2D GetRotated(double angleDeg)
	{
		FMath.SinCos(out var scalarSin, out var scalarCos, FMath.DegreesToRadians(angleDeg));
		return new FVector2D(scalarCos * (double)X - scalarSin * (double)Y, scalarSin * (double)X + scalarCos * (double)Y);
	}

	public FVector2D GetSafeNormal(double tolerance = 9.99999993922529E-09)
	{
		double num = X * X + Y * Y;
		if (num > tolerance)
		{
			double num2 = FMath.InvSqrt(num);
			return new FVector2D((double)X * num2, (double)Y * num2);
		}
		return new FVector2D(0.0, 0.0);
	}

	public void Normalize(double tolerance = 9.99999993922529E-09)
	{
		double num = X * X + Y * Y;
		if (num > tolerance)
		{
			double num2 = FMath.InvSqrt(num);
			mX *= num2;
			mY *= num2;
		}
		else
		{
			mX = 0.0;
			mY = 0.0;
		}
	}

	public bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
	{
		if ((double)FMath.Abs(X) <= tolerance)
		{
			return (double)FMath.Abs(Y) <= tolerance;
		}
		return false;
	}

	public void ToDirectionAndLength(out FVector2D dir, out double length)
	{
		length = Size();
		if (length > 9.99999993922529E-09)
		{
			double num = 1.0 / length;
			dir = new FVector2D((double)X * num, (double)Y * num);
		}
		else
		{
			dir = ZeroVector;
		}
	}

	public bool IsZero()
	{
		if (X == 0f)
		{
			return Y == 0f;
		}
		return false;
	}

	public FIntPoint IntPoint()
	{
		return new FIntPoint(FMath.RoundToInt(X), FMath.RoundToInt(Y));
	}

	public FVector2D RoundToVector()
	{
		return new FVector2D(FMath.RoundToInt(X), FMath.RoundToInt(Y));
	}

	public FVector2D ClampAxes(double minAxisVal, double maxAxisVal)
	{
		return new FVector2D(FMath.Clamp(X, minAxisVal, maxAxisVal), FMath.Clamp(Y, minAxisVal, maxAxisVal));
	}

	public FVector2D GetSignVector()
	{
		return new FVector2D(FMath.DoubleSelect(X, 1.0, -1.0), FMath.DoubleSelect(Y, 10.0, -1.0));
	}

	public FVector2D GetAbs()
	{
		return new FVector2D(FMath.Abs(X), FMath.Abs(Y));
	}

	public override string ToString()
	{
		string text = "000.000";
		return "X=" + X.ToString(text) + " Y=" + Y.ToString(text);
	}

	public bool InitFromString(string sourceString)
	{
		float x = (Y = 0f);
		X = x;
		if (FParse.Value(sourceString, "X=", ref mX))
		{
			return FParse.Value(sourceString, "Y=", ref mY);
		}
		return false;
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN()
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError("FVector2D contains NaN: " + ToString());
			this = ZeroVector;
		}
	}

	public bool ContainsNaN()
	{
		if (FMath.IsFinite(X))
		{
			return !FMath.IsFinite(Y);
		}
		return true;
	}

	public FVector SphericalToUnitCartesian()
	{
		double num = FMath.Sin(X);
		return new FVector((double)FMath.Cos(Y) * num, (double)FMath.Sin(Y) * num, FMath.Cos(X));
	}
}
