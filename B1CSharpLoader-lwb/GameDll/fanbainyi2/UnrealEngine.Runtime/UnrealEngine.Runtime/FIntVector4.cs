using System;

namespace UnrealEngine.Runtime;

public struct FIntVector4 : IEquatable<FIntVector4>
{
	public int X;

	public int Y;

	public int Z;

	public int W;

	public static readonly FIntVector4 ZeroValue = new FIntVector4(0, 0, 0, 0);

	public static readonly FIntVector4 NoneValue = new FIntVector4(-1, -1, -1, -1);

	public int this[int index]
	{
		get
		{
			return index switch
			{
				0 => X, 
				1 => Y, 
				2 => Z, 
				3 => W, 
				_ => throw new IndexOutOfRangeException("Invalid FIntVector4 index (" + index + ")"), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				X = value;
				break;
			case 1:
				Y = value;
				break;
			case 2:
				Z = value;
				break;
			case 3:
				W = value;
				break;
			default:
				throw new IndexOutOfRangeException("Invalid FIntVector4 index (" + index + ")");
			}
		}
	}

	public FIntVector4(int x, int y, int z, int w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public FIntVector4(int value)
	{
		X = (Y = (Z = (W = value)));
	}

	public FIntVector4(FVector4 vector)
	{
		X = FMath.TruncToInt(vector.X);
		Y = FMath.TruncToInt(vector.Y);
		Z = FMath.TruncToInt(vector.Z);
		W = FMath.TruncToInt(vector.W);
	}

	public static bool operator ==(FIntVector4 a, FIntVector4 b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W == b.W;
		}
		return false;
	}

	public static bool operator !=(FIntVector4 a, FIntVector4 b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W != b.W;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FIntVector4))
		{
			return false;
		}
		return Equals((FIntVector4)obj);
	}

	public bool Equals(FIntVector4 other)
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

	public static FIntVector4 operator *(int scale, FIntVector4 v)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FIntVector4 operator *(FIntVector4 v, int scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FIntVector4 Multiply(FIntVector4 v, int scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static void Multiply(ref FIntVector4 v, int scale, out FIntVector4 result)
	{
		result.X = v.X * scale;
		result.Y = v.Y * scale;
		result.Z = v.Z * scale;
		result.W = v.W * scale;
	}

	public static FIntVector4 operator /(FIntVector4 v, int divisor)
	{
		Divide(ref v, divisor, out v);
		return v;
	}

	public static FIntVector4 Divide(FIntVector4 v, int divisor)
	{
		Divide(ref v, divisor, out v);
		return v;
	}

	public static void Divide(ref FIntVector4 v, int divisor, out FIntVector4 result)
	{
		result.X = v.X / divisor;
		result.Y = v.Y / divisor;
		result.Z = v.Z / divisor;
		result.W = v.W / divisor;
	}

	public static FIntVector4 operator +(FIntVector4 a, FIntVector4 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FIntVector4 Add(FIntVector4 a, FIntVector4 b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FIntVector4 a, ref FIntVector4 b, out FIntVector4 result)
	{
		result.X = a.X + b.X;
		result.Y = a.Y + b.Y;
		result.Z = a.Z + b.Z;
		result.W = a.W + b.W;
	}

	public static FIntVector4 operator -(FIntVector4 a, FIntVector4 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static FIntVector4 Subtract(FIntVector4 a, FIntVector4 b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref FIntVector4 a, ref FIntVector4 b, out FIntVector4 result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
		result.Z = a.Z - b.Z;
		result.W = a.W - b.W;
	}

	public bool IsZero()
	{
		return this == ZeroValue;
	}

	public float GetMax()
	{
		return FMath.Max(FMath.Max(FMath.Max(X, Y), Z), W);
	}

	public float GetMin()
	{
		return FMath.Min(FMath.Min(FMath.Min(X, Y), Z), W);
	}

	public int Size()
	{
		long num = X;
		long num2 = Y;
		long num3 = Z;
		long num4 = W;
		return (int)FMath.Sqrt(num * num + num2 * num2 + num3 * num3 + num4 * num4);
	}

	public override string ToString()
	{
		return "X=" + X + " Y=" + Y + " Z=" + Z + " W=" + W;
	}

	public static FIntVector4 DivideAndRoundUp(FIntVector4 lhs, int divisor)
	{
		return new FIntVector4(FMath.DivideAndRoundUp(lhs.X, divisor), FMath.DivideAndRoundUp(lhs.Y, divisor), FMath.DivideAndRoundUp(lhs.Z, divisor), FMath.DivideAndRoundUp(lhs.W, divisor));
	}

	public static int Num()
	{
		return 4;
	}
}
