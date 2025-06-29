using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 36920)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Box2D", "CoreUObject", UnrealModuleType.Engine)]
public struct FBox2D : IEquatable<FBox2D>
{
	private static bool Min_IsValid;

	private static int Min_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.Box2D:Min")]
	public FVector2D Min;

	private static bool Max_IsValid;

	private static int Max_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.Box2D:Max")]
	public FVector2D Max;

	private static bool bIsValid_IsValid;

	private static int bIsValid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/CoreUObject.Box2D:bIsValid")]
	private byte bIsValid;

	private static bool FBox2D_IsValid;

	private static int FBox2D_StructSize;

	public bool IsValid
	{
		get
		{
			return bIsValid != 0;
		}
		set
		{
			bIsValid = (value ? ((byte)1) : ((byte)0));
		}
	}

	public FVector2D this[int index]
	{
		get
		{
			return index switch
			{
				0 => Min, 
				1 => Max, 
				_ => throw new IndexOutOfRangeException("Invalid FBox2D index (" + index + ")"), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				Min = value;
				break;
			case 1:
				Max = value;
				break;
			default:
				throw new IndexOutOfRangeException("Invalid FBox2D index (" + index + ")");
			}
		}
	}

	public FBox2D Copy()
	{
		return this;
	}

	static FBox2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBox2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBox2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.Box2D");
		FBox2D_StructSize = NativeReflection.GetStructSize(intPtr);
		Min_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Min");
		Min_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Min", Classes.FStructProperty);
		Max_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Max");
		Max_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Max", Classes.FStructProperty);
		bIsValid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsValid");
		bIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsValid", Classes.FByteProperty);
		FBox2D_IsValid = intPtr != IntPtr.Zero && Min_IsValid && Max_IsValid && bIsValid_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.Box2D", FBox2D_IsValid);
	}

	public FBox2D(FVector2D min, FVector2D max)
	{
		Min = min;
		Max = max;
		bIsValid = 1;
	}

	public static bool operator ==(FBox2D a, FBox2D b)
	{
		if (a.Min == b.Min)
		{
			return a.Max == b.Max;
		}
		return false;
	}

	public static bool operator !=(FBox2D a, FBox2D b)
	{
		if (!(a.Min != b.Min))
		{
			return a.Max != b.Max;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FBox2D))
		{
			return false;
		}
		return Equals((FBox2D)obj);
	}

	public bool Equals(FBox2D other)
	{
		if (Min == other.Min)
		{
			return Max == other.Max;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Min.GetHashCode() * 397) ^ Max.GetHashCode()) * 397) ^ bIsValid.GetHashCode();
	}

	public static FBox2D operator +(FBox2D box, FVector2D other)
	{
		Add(ref box, ref other, out box);
		return box;
	}

	public static FBox2D Add(FBox2D box, FVector2D other)
	{
		Add(ref box, ref other, out box);
		return box;
	}

	public static void Add(ref FBox2D box, ref FVector2D other, out FBox2D result)
	{
		result = default(FBox2D);
		if (box.IsValid)
		{
			result.Min.X = FMath.Min(box.Min.X, other.X);
			result.Min.Y = FMath.Min(box.Min.Y, other.Y);
			result.Max.X = FMath.Max(box.Max.X, other.X);
			result.Max.Y = FMath.Max(box.Max.Y, other.Y);
			result.bIsValid = 1;
		}
		else
		{
			result.Min = (result.Max = other);
			result.bIsValid = 1;
		}
	}

	public static FBox2D operator +(FBox2D a, FBox2D b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FBox2D Add(FBox2D a, FBox2D b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FBox2D a, ref FBox2D b, out FBox2D result)
	{
		result = default(FBox2D);
		if (a.IsValid && b.IsValid)
		{
			result.Min.X = FMath.Min(a.Min.X, b.Min.X);
			result.Min.Y = FMath.Min(a.Min.Y, b.Min.Y);
			result.Max.X = FMath.Max(a.Max.X, b.Max.X);
			result.Max.Y = FMath.Max(a.Max.Y, b.Max.Y);
			result.bIsValid = 1;
		}
		else if (b.IsValid)
		{
			result = b;
		}
		else
		{
			result = a;
		}
	}

	public double ComputeSquaredDistanceToPoint(FVector2D point)
	{
		double num = 0.0;
		if (point.X < Min.X)
		{
			num += (double)FMath.Square(point.X - Min.X);
		}
		else if (point.X > Max.X)
		{
			num += (double)FMath.Square(point.X - Max.X);
		}
		if (point.Y < Min.Y)
		{
			num += (double)FMath.Square(point.Y - Min.Y);
		}
		else if (point.Y > Max.Y)
		{
			num += (double)FMath.Square(point.Y - Max.Y);
		}
		return num;
	}

	public FBox2D ExpandBy(float w)
	{
		return new FBox2D(Min - new FVector2D(w, w), Max + new FVector2D(w, w));
	}

	public double GetArea()
	{
		return (Max.X - Min.X) * (Max.Y - Min.Y);
	}

	public FVector2D GetCenter()
	{
		return (Min + Max) * 0.5;
	}

	public void GetCenterAndExtents(out FVector2D center, out FVector2D extents)
	{
		extents = GetExtent();
		center = Min + extents;
	}

	public FVector2D GetClosestPointTo(FVector2D point)
	{
		FVector2D result = point;
		if (point.X < Min.X)
		{
			result.X = Min.X;
		}
		else if (point.X > Max.X)
		{
			result.X = Max.X;
		}
		if (point.Y < Min.Y)
		{
			result.Y = Min.Y;
		}
		else if (point.Y > Max.Y)
		{
			result.Y = Max.Y;
		}
		return result;
	}

	public FVector2D GetExtent()
	{
		return 0.5 * (Max - Min);
	}

	public FVector2D GetSize()
	{
		return Max - Min;
	}

	public void Init()
	{
		Min = (Max = FVector2D.ZeroVector);
		bIsValid = 0;
	}

	public bool Intersect(FBox2D other)
	{
		if (Min.X > other.Max.X || other.Min.X > Max.X)
		{
			return false;
		}
		if (Min.Y > other.Max.Y || other.Min.Y > Max.Y)
		{
			return false;
		}
		return true;
	}

	public bool IsInside(FVector2D testPoint)
	{
		if (testPoint.X > Min.X && testPoint.X < Max.X && testPoint.Y > Min.Y)
		{
			return testPoint.Y < Max.Y;
		}
		return false;
	}

	public bool IsInside(FBox2D other)
	{
		if (IsInside(other.Min))
		{
			return IsInside(other.Max);
		}
		return false;
	}

	public FBox2D ShiftBy(FVector2D offset)
	{
		return new FBox2D(Min + offset, Max + offset);
	}

	public override string ToString()
	{
		string[] obj = new string[7]
		{
			"bIsValid=",
			IsValid ? "true" : "false",
			", Min=(",
			null,
			null,
			null,
			null
		};
		FVector2D min = Min;
		obj[3] = min.ToString();
		obj[4] = "), Max=(";
		min = Max;
		obj[5] = min.ToString();
		obj[6] = ")";
		return string.Concat(obj);
	}
}
