using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 59448)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.IntVector", "CoreUObject", UnrealModuleType.Engine)]
public struct FIntVector : IEquatable<FIntVector>
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntVector:X")]
	public int X;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntVector:Y")]
	public int Y;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntVector:Z")]
	public int Z;

	private static int FIntVector_StructSize;

	public static readonly FIntVector ZeroValue;

	public static readonly FIntVector NoneValue;

	public int this[int index]
	{
		get
		{
			return index switch
			{
				0 => X, 
				1 => Y, 
				2 => Z, 
				_ => throw new IndexOutOfRangeException("Invalid FIntVector index (" + index + ")"), 
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
			default:
				throw new IndexOutOfRangeException("Invalid FIntVector index (" + index + ")");
			}
		}
	}

	public FIntVector Copy()
	{
		return this;
	}

	static FIntVector()
	{
		ZeroValue = new FIntVector(0, 0, 0);
		NoneValue = new FIntVector(-1, -1, -1);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIntVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIntVector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.IntVector");
		FIntVector_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "X", Classes.FIntProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Y", Classes.FIntProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Z");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Z", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FIntVector));
	}

	public FIntVector(int x, int y, int z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public FIntVector(int value)
	{
		X = (Y = (Z = value));
	}

	public FIntVector(FVector vector)
	{
		X = FMath.TruncToInt(vector.X);
		Y = FMath.TruncToInt(vector.Y);
		Z = FMath.TruncToInt(vector.Z);
	}

	public static bool operator ==(FIntVector a, FIntVector b)
	{
		if (a.X == b.X && a.Y == b.Y)
		{
			return a.Z == b.Z;
		}
		return false;
	}

	public static bool operator !=(FIntVector a, FIntVector b)
	{
		if (a.X == b.X && a.Y == b.Y)
		{
			return a.Z != b.Z;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FIntVector))
		{
			return false;
		}
		return Equals((FIntVector)obj);
	}

	public bool Equals(FIntVector other)
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

	public static FIntVector operator *(int scale, FIntVector v)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FIntVector operator *(FIntVector v, int scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static FIntVector Multiply(FIntVector v, int scale)
	{
		Multiply(ref v, scale, out v);
		return v;
	}

	public static void Multiply(ref FIntVector v, int scale, out FIntVector result)
	{
		result.X = v.X * scale;
		result.Y = v.Y * scale;
		result.Z = v.Z * scale;
	}

	public static FIntVector operator /(FIntVector v, int divisor)
	{
		Divide(ref v, divisor, out v);
		return v;
	}

	public static FIntVector Divide(FIntVector v, int divisor)
	{
		Divide(ref v, divisor, out v);
		return v;
	}

	public static void Divide(ref FIntVector v, int divisor, out FIntVector result)
	{
		result.X = v.X / divisor;
		result.Y = v.Y / divisor;
		result.Z = v.Z / divisor;
	}

	public static FIntVector operator +(FIntVector a, FIntVector b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FIntVector Add(FIntVector a, FIntVector b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FIntVector a, ref FIntVector b, out FIntVector result)
	{
		result.X = a.X + b.X;
		result.Y = a.Y + b.Y;
		result.Z = a.Z + b.Z;
	}

	public static FIntVector operator -(FIntVector a, FIntVector b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static FIntVector Subtract(FIntVector a, FIntVector b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref FIntVector a, ref FIntVector b, out FIntVector result)
	{
		result.X = a.X - b.X;
		result.Y = a.Y - b.Y;
		result.Z = a.Z - b.Z;
	}

	public bool IsZero()
	{
		return this == ZeroValue;
	}

	public float GetMax()
	{
		return FMath.Max(FMath.Max(X, Y), Z);
	}

	public float GetMin()
	{
		return FMath.Min(FMath.Min(X, Y), Z);
	}

	public int Size()
	{
		long num = X;
		long num2 = Y;
		long num3 = Z;
		return (int)FMath.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	public override string ToString()
	{
		return "X=" + X + " Y=" + Y + " Z=" + Z;
	}

	public static FIntVector DivideAndRoundUp(FIntVector lhs, int divisor)
	{
		return new FIntVector(FMath.DivideAndRoundUp(lhs.X, divisor), FMath.DivideAndRoundUp(lhs.Y, divisor), FMath.DivideAndRoundUp(lhs.Z, divisor));
	}

	public static int Num()
	{
		return 3;
	}
}
