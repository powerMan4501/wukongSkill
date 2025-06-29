using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 59448)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.IntPoint", "CoreUObject", UnrealModuleType.Engine)]
public struct FIntPoint : IEquatable<FIntPoint>
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntPoint:X")]
	public int X;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntPoint:Y")]
	public int Y;

	private static int FIntPoint_StructSize;

	public static readonly FIntPoint ZeroValue;

	public static readonly FIntPoint NoneValue;

	public int this[int index]
	{
		get
		{
			return index switch
			{
				0 => X, 
				1 => Y, 
				_ => throw new IndexOutOfRangeException("Invalid FIntPoint index (" + index + ")"), 
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
			default:
				throw new IndexOutOfRangeException("Invalid FIntPoint index (" + index + ")");
			}
		}
	}

	public FIntPoint Copy()
	{
		return this;
	}

	static FIntPoint()
	{
		ZeroValue = new FIntPoint(0, 0);
		NoneValue = new FIntPoint(-1, -1);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIntPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIntPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.IntPoint");
		FIntPoint_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "X", Classes.FIntProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Y", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FIntPoint));
	}

	public FIntPoint(int x, int y)
	{
		X = x;
		Y = y;
	}

	public static bool operator ==(FIntPoint a, FIntPoint b)
	{
		if (a.X == b.X)
		{
			return a.Y == b.Y;
		}
		return false;
	}

	public static bool operator !=(FIntPoint a, FIntPoint b)
	{
		if (a.X == b.X)
		{
			return a.Y != b.Y;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FIntPoint))
		{
			return false;
		}
		return Equals((FIntPoint)obj);
	}

	public bool Equals(FIntPoint other)
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

	public static FIntPoint operator *(int scale, FIntPoint v)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FIntPoint operator *(FIntPoint v, int scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FIntPoint Multiply(FIntPoint v, int scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static void Multiply(ref FIntPoint v, int scale, out FIntPoint result)
	{
		result.X = v.X * scale;
		result.Y = v.Y * scale;
	}

	public static FIntPoint operator /(FIntPoint v, int divisor)
	{
		Divide(ref v, divisor, out v);
		return v;
	}

	public static FIntPoint Divide(FIntPoint v, int divisor)
	{
		Divide(ref v, divisor, out v);
		return v;
	}

	public static void Divide(ref FIntPoint v, int divisor, out FIntPoint result)
	{
		result.X = v.X / divisor;
		result.Y = v.Y / divisor;
	}

	public static FIntPoint operator +(FIntPoint a, FIntPoint b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FIntPoint Add(FIntPoint a, FIntPoint b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FIntPoint a, ref FIntPoint b, out FIntPoint result)
	{
		result.X = a.X + b.X;
		result.Y = a.Y + b.Y;
	}

	public static FIntPoint operator -(FIntPoint a, FIntPoint b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static FIntPoint Subtract(FIntPoint a, FIntPoint b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref FIntPoint a, ref FIntPoint b, out FIntPoint result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
	}

	public static FIntPoint operator /(FIntPoint a, FIntPoint b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static FIntPoint Divide(FIntPoint a, FIntPoint b)
	{
		Divide(ref a, ref b, out a);
		return a;
	}

	public static void Divide(ref FIntPoint a, ref FIntPoint b, out FIntPoint result)
	{
		result.X = a.X / b.X;
		result.Y = a.Y / b.Y;
	}

	public FIntPoint ComponentMin(FIntPoint other)
	{
		return new FIntPoint(FMath.Min(X, other.X), FMath.Min(Y, other.Y));
	}

	public FIntPoint ComponentMax(FIntPoint other)
	{
		return new FIntPoint(FMath.Max(X, other.X), FMath.Max(Y, other.Y));
	}

	public int GetMax()
	{
		return FMath.Max(X, Y);
	}

	public int GetMin()
	{
		return FMath.Min(X, Y);
	}

	public int Size()
	{
		long num = X;
		long num2 = Y;
		return (int)FMath.Sqrt(num * num + num2 * num2);
	}

	public int SizeSquared()
	{
		return X * X + Y * Y;
	}

	public override string ToString()
	{
		return "X=" + X + " Y=" + Y;
	}

	public static FIntPoint DivideAndRoundUp(FIntPoint lhs, int divisor)
	{
		return new FIntPoint(FMath.DivideAndRoundUp(lhs.X, divisor), FMath.DivideAndRoundUp(lhs.Y, divisor));
	}

	public static FIntPoint DivideAndRoundUp(FIntPoint lhs, FIntPoint divisor)
	{
		return new FIntPoint(FMath.DivideAndRoundUp(lhs.X, divisor.X), FMath.DivideAndRoundUp(lhs.Y, divisor.Y));
	}

	public static FIntPoint DivideAndRoundDown(FIntPoint lhs, int divisor)
	{
		return new FIntPoint(FMath.DivideAndRoundDown(lhs.X, divisor), FMath.DivideAndRoundDown(lhs.Y, divisor));
	}

	public static int Num()
	{
		return 2;
	}
}
