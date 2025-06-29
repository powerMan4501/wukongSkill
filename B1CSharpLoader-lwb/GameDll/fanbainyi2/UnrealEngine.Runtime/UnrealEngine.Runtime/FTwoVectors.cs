using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 59448)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.TwoVectors", "CoreUObject", UnrealModuleType.Engine)]
public struct FTwoVectors : IEquatable<FTwoVectors>
{
	private static bool v1_IsValid;

	private static int v1_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.TwoVectors:v1")]
	public FVector V1;

	private static bool v2_IsValid;

	private static int v2_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.TwoVectors:v2")]
	public FVector V2;

	private static int FTwoVectors_StructSize;

	public double this[int index]
	{
		get
		{
			return index switch
			{
				0 => V1.mX, 
				1 => V2.mX, 
				2 => V1.mY, 
				3 => V2.mY, 
				4 => V1.mZ, 
				5 => V2.mZ, 
				_ => throw new IndexOutOfRangeException("Invalid FTwoVectors index (" + index + ")"), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				V1.mX = value;
				break;
			case 1:
				V2.mX = value;
				break;
			case 2:
				V1.mY = value;
				break;
			case 3:
				V2.mY = value;
				break;
			case 4:
				V1.mZ = value;
				break;
			case 5:
				V2.mZ = value;
				break;
			default:
				throw new IndexOutOfRangeException("Invalid FTwoVectors index (" + index + ")");
			}
		}
	}

	public FTwoVectors Copy()
	{
		return this;
	}

	static FTwoVectors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTwoVectors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTwoVectors));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.TwoVectors");
		FTwoVectors_StructSize = NativeReflection.GetStructSize(unrealStruct);
		v1_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "v1");
		v1_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "v1", Classes.FStructProperty);
		v2_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "v2");
		v2_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "v2", Classes.FStructProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FTwoVectors));
	}

	public FTwoVectors(FVector v1, FVector v2)
	{
		V1 = v1;
		V2 = v2;
	}

	public static FTwoVectors operator +(FTwoVectors a, FTwoVectors b)
	{
		a.V1 += b.V1;
		a.V2 += b.V2;
		return a;
	}

	public static FTwoVectors operator -(FTwoVectors a, FTwoVectors b)
	{
		a.V1 -= b.V1;
		a.V2 -= b.V2;
		return a;
	}

	public static FTwoVectors operator *(double scale, FTwoVectors a)
	{
		a.V1 *= scale;
		a.V2 *= scale;
		return a;
	}

	public static FTwoVectors operator *(FTwoVectors a, double scale)
	{
		a.V1 *= scale;
		a.V2 *= scale;
		return a;
	}

	public static FTwoVectors operator /(FTwoVectors a, double scale)
	{
		double num = 1.0 / scale;
		a.V1 *= num;
		a.V2 *= num;
		return a;
	}

	public static FTwoVectors operator *(FTwoVectors a, FTwoVectors b)
	{
		a.V1 *= b.V1;
		a.V2 *= b.V2;
		return a;
	}

	public static FTwoVectors operator /(FTwoVectors a, FTwoVectors b)
	{
		a.V1 /= b.V1;
		a.V2 /= b.V2;
		return a;
	}

	public static FTwoVectors operator -(FTwoVectors a)
	{
		a.V1 = -a.V1;
		a.V2 = -a.V2;
		return a;
	}

	public static bool operator ==(FTwoVectors a, FTwoVectors b)
	{
		if (a.V1 == b.V1)
		{
			return a.V2 == b.V2;
		}
		return false;
	}

	public static bool operator !=(FTwoVectors a, FTwoVectors b)
	{
		if (!(a.V1 != b.V1))
		{
			return a.V2 != b.V2;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FTwoVectors))
		{
			return false;
		}
		return Equals((FTwoVectors)obj);
	}

	public bool Equals(FTwoVectors other)
	{
		if (V1 == other.V1)
		{
			return V2 == other.V2;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (V1.GetHashCode() * 397) ^ V2.GetHashCode();
	}

	public bool Equals(FTwoVectors v, double tolerance)
	{
		if (V1.Equals(v.V1, tolerance))
		{
			return V2.Equals(v.V2, tolerance);
		}
		return false;
	}

	public double GetMax()
	{
		double val = FMath.Max(FMath.Max(V1.X, V1.Y), V1.Z);
		double val2 = FMath.Max(FMath.Max(V2.X, V2.Y), V2.Z);
		return FMath.Max(val, val2);
	}

	public double GetMin()
	{
		double val = FMath.Min(FMath.Min(V1.X, V1.Y), V1.Z);
		double val2 = FMath.Min(FMath.Min(V2.X, V2.Y), V2.Z);
		return FMath.Min(val, val2);
	}

	public override string ToString()
	{
		string[] obj = new string[5] { "V1=(", null, null, null, null };
		FVector v = V1;
		obj[1] = v.ToString();
		obj[2] = ") V2=(";
		v = V2;
		obj[3] = v.ToString();
		obj[4] = ")";
		return string.Concat(obj);
	}
}
