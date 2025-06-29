using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 59448)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Box", "CoreUObject", UnrealModuleType.Engine)]
public struct FBox : IEquatable<FBox>
{
	private static bool Min_IsValid;

	private static int Min_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.Box:Min")]
	public FVector Min;

	private static bool Max_IsValid;

	private static int Max_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.Box:Max")]
	public FVector Max;

	private static bool IsValid_IsValid;

	private static int IsValid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/CoreUObject.Box:IsValid")]
	private byte isValid;

	private static int FBox_StructSize;

	public bool IsValid
	{
		get
		{
			return isValid != 0;
		}
		set
		{
			isValid = (value ? ((byte)1) : ((byte)0));
		}
	}

	public FVector this[int index]
	{
		get
		{
			return index switch
			{
				0 => Min, 
				1 => Max, 
				_ => throw new IndexOutOfRangeException("Invalid FBox index (" + index + ")"), 
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
				throw new IndexOutOfRangeException("Invalid FBox index (" + index + ")");
			}
		}
	}

	public FBox Copy()
	{
		return this;
	}

	static FBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Box");
		FBox_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Min_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Min");
		Min_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Min", Classes.FStructProperty);
		Max_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Max");
		Max_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Max", Classes.FStructProperty);
		IsValid_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IsValid");
		IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IsValid", Classes.FByteProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FBox));
	}

	public FBox(FVector min, FVector max)
	{
		Min = min;
		Max = max;
		isValid = 1;
	}

	public FBox(FVector[] points)
	{
		Min = (Max = FVector.ZeroVector);
		isValid = 0;
		for (int i = 0; i < points.Length; i++)
		{
			this += points[i];
		}
	}

	public static bool operator ==(FBox a, FBox b)
	{
		if (a.Min == b.Min)
		{
			return a.Max == b.Max;
		}
		return false;
	}

	public static bool operator !=(FBox a, FBox b)
	{
		if (!(a.Min != b.Min))
		{
			return a.Max != b.Max;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FBox))
		{
			return false;
		}
		return Equals((FBox)obj);
	}

	public bool Equals(FBox other)
	{
		if (Min == other.Min)
		{
			return Max == other.Max;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Min.GetHashCode() * 397) ^ Max.GetHashCode()) * 397) ^ isValid.GetHashCode();
	}

	public static FBox operator +(FBox box, FVector other)
	{
		Add(ref box, ref other, out box);
		return box;
	}

	public static FBox Add(FBox box, FVector other)
	{
		Add(ref box, ref other, out box);
		return box;
	}

	public static void Add(ref FBox box, ref FVector other, out FBox result)
	{
		if (box.IsValid)
		{
			result.Min.mX = FMath.Min(box.Min.X, other.X);
			result.Min.mY = FMath.Min(box.Min.Y, other.Y);
			result.Min.mZ = FMath.Min(box.Min.Z, other.Z);
			result.Max.mX = FMath.Max(box.Max.X, other.X);
			result.Max.mY = FMath.Max(box.Max.Y, other.Y);
			result.Max.mZ = FMath.Max(box.Max.Z, other.Z);
			result.isValid = 1;
		}
		else
		{
			result.Min = (result.Max = other);
			result.isValid = 1;
		}
	}

	public static FBox operator +(FBox a, FBox b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FBox Add(FBox a, FBox b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FBox a, ref FBox b, out FBox result)
	{
		result = default(FBox);
		if (a.IsValid && b.IsValid)
		{
			result.Min.X = FMath.Min(a.Min.X, b.Min.X);
			result.Min.Y = FMath.Min(a.Min.Y, b.Min.Y);
			result.Min.Z = FMath.Min(a.Min.Z, b.Min.Z);
			result.Max.X = FMath.Max(a.Max.X, b.Max.X);
			result.Max.Y = FMath.Max(a.Max.Y, b.Max.Y);
			result.Max.Z = FMath.Max(a.Max.Z, b.Max.Z);
			result.isValid = 1;
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

	public float ComputeSquaredDistanceToPoint(FVector point)
	{
		return FVector.ComputeSquaredDistanceFromBoxToPoint(Min, Max, point);
	}

	public FBox ExpandBy(float w)
	{
		return new FBox(Min - new FVector(w, w, w), Max + new FVector(w, w, w));
	}

	public FBox ExpandBy(FVector v)
	{
		return new FBox(Min - v, Max + v);
	}

	public FBox ExpandBy(FVector neg, FVector pos)
	{
		return new FBox(Min - neg, Max + pos);
	}

	public FBox ShiftBy(FVector offset)
	{
		return new FBox(Min + offset, Max + offset);
	}

	public FBox MoveTo(FVector destination)
	{
		FVector fVector = destination - GetCenter();
		return new FBox(Min + fVector, Max + fVector);
	}

	public FVector GetCenter()
	{
		return (Min + Max) * 0.5;
	}

	public void GetCenterAndExtents(out FVector center, out FVector extents)
	{
		extents = GetExtent();
		center = Min + extents;
	}

	public FVector GetClosestPointTo(FVector point)
	{
		FVector result = point;
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
		if (point.Z < Min.Z)
		{
			result.Z = Min.Z;
		}
		else if (point.Z > Max.Z)
		{
			result.Z = Max.Z;
		}
		return result;
	}

	public FVector GetExtent()
	{
		return 0.5 * (Max - Min);
	}

	public FVector GetExtrema(int pointIndex)
	{
		return this[pointIndex];
	}

	public FVector GetSize()
	{
		return Max - Min;
	}

	public float GetVolume()
	{
		return (Max.X - Min.X) * (Max.Y - Min.Y) * (Max.Z - Min.Z);
	}

	public void Init()
	{
		Min = (Max = FVector.ZeroVector);
		isValid = 0;
	}

	public bool Intersect(FBox other)
	{
		if (Min.X > other.Max.X || other.Min.X > Max.X)
		{
			return false;
		}
		if (Min.Y > other.Max.Y || other.Min.Y > Max.Y)
		{
			return false;
		}
		if (Min.Z > other.Max.Z || other.Min.Z > Max.Z)
		{
			return false;
		}
		return true;
	}

	public bool IntersectXY(FBox other)
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

	public FBox Overlap(FBox other)
	{
		if (!Intersect(other))
		{
			return default(FBox);
		}
		FVector min = default(FVector);
		FVector max = default(FVector);
		min.X = FMath.Max(Min.X, other.Min.X);
		max.X = FMath.Min(Max.X, other.Max.X);
		min.Y = FMath.Max(Min.Y, other.Min.Y);
		max.Y = FMath.Min(Max.Y, other.Max.Y);
		min.Z = FMath.Max(Min.Z, other.Min.Z);
		max.Z = FMath.Min(Max.Z, other.Max.Z);
		return new FBox(min, max);
	}

	public FBox InverseTransformBy(FTransform m)
	{
		FVector[] array = new FVector[8]
		{
			Min,
			new FVector(Min.X, Min.Y, Max.Z),
			new FVector(Min.X, Max.Y, Min.Z),
			new FVector(Max.X, Min.Y, Min.Z),
			new FVector(Max.X, Max.Y, Min.Z),
			new FVector(Max.X, Min.Y, Max.Z),
			new FVector(Min.X, Max.Y, Max.Z),
			Max
		};
		FBox result = default(FBox);
		for (int i = 0; i < array.Length; i++)
		{
			FVector4 fVector = m.InverseTransformPosition(array[i]);
			result += (FVector)fVector;
		}
		return result;
	}

	public bool IsInside(FVector v)
	{
		if (v.X > Min.X && v.X < Max.X && v.Y > Min.Y && v.Y < Max.Y && v.Z > Min.Z)
		{
			return v.Z < Max.Z;
		}
		return false;
	}

	public bool IsInsideOrOn(FVector v)
	{
		if (v.X >= Min.X && v.X <= Max.X && v.Y >= Min.Y && v.Y <= Max.Y && v.Z >= Min.Z)
		{
			return v.Z <= Max.Z;
		}
		return false;
	}

	public bool IsInside(FBox other)
	{
		if (IsInside(other.Min))
		{
			return IsInside(other.Max);
		}
		return false;
	}

	public bool IsInsideXY(FVector v)
	{
		if (v.X > Min.X && v.X < Max.X && v.Y > Min.Y)
		{
			return v.Y < Max.Y;
		}
		return false;
	}

	public bool IsInsideXY(FBox other)
	{
		if (IsInsideXY(other.Min))
		{
			return IsInsideXY(other.Max);
		}
		return false;
	}

	public FBox TransformBy(FMatrix m)
	{
		if (!IsValid)
		{
			return default(FBox);
		}
		FVector min = Min;
		FVector max = Max;
		FVector row = m.GetRow(0);
		FVector row2 = m.GetRow(1);
		FVector row3 = m.GetRow(2);
		FVector row4 = m.GetRow(3);
		FVector fVector = new FVector(0.5, 0.5, 0.5);
		FVector v = (max + min) * fVector;
		FVector v2 = (max - min) * fVector;
		FVector fVector2 = FVector.Replicate(v, 0) * row + FVector.Replicate(v, 1) * row2 + FVector.Replicate(v, 2) * row3 + row4;
		FVector abs = (FVector.Replicate(v2, 0) * row).GetAbs();
		abs += (FVector.Replicate(v2, 1) * row2).GetAbs();
		abs += (FVector.Replicate(v2, 2) * row3).GetAbs();
		FVector min2 = fVector2 - abs;
		FVector max2 = fVector2 + abs;
		FBox result = default(FBox);
		result.Min = min2;
		result.Max = max2;
		result.isValid = 1;
		return result;
	}

	public FBox TransformBy(FTransform m)
	{
		return TransformBy(m.ToMatrixWithScale());
	}

	public FBox TransformProjectBy(FMatrix projM)
	{
		FVector[] array = new FVector[8]
		{
			Min,
			new FVector(Min.X, Min.Y, Max.Z),
			new FVector(Min.X, Max.Y, Min.Z),
			new FVector(Max.X, Min.Y, Min.Z),
			new FVector(Max.X, Max.Y, Min.Z),
			new FVector(Max.X, Min.Y, Max.Z),
			new FVector(Min.X, Max.Y, Max.Z),
			Max
		};
		FBox result = default(FBox);
		for (int i = 0; i < array.Length; i++)
		{
			FVector4 fVector = projM.TransformPosition(array[i]);
			result += (FVector)fVector / (double)fVector.W;
		}
		return result;
	}

	public override string ToString()
	{
		string[] obj = new string[7]
		{
			"IsValid=",
			IsValid ? "true" : "false",
			", Min=(",
			null,
			null,
			null,
			null
		};
		FVector min = Min;
		obj[3] = min.ToString();
		obj[4] = "), Max=(";
		min = Max;
		obj[5] = min.ToString();
		obj[6] = ")";
		return string.Concat(obj);
	}

	public static FBox BuildAABB(FVector origin, FVector extent)
	{
		return new FBox(origin - extent, origin + extent);
	}
}
