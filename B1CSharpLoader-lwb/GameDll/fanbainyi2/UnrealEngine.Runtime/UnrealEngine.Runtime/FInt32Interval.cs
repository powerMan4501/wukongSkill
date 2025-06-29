using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 57352)]
[UMetaPath("/Script/CoreUObject.Int32Interval", "CoreUObject", UnrealModuleType.Engine)]
public struct FInt32Interval : IEquatable<FInt32Interval>
{
	private static bool Min_IsValid;

	private static int Min_Offset;

	[UProperty(Flags = (PropFlags)6755469234274817uL)]
	[UMetaPath("/Script/CoreUObject.Int32Interval:Min")]
	public int Min;

	private static bool Max_IsValid;

	private static int Max_Offset;

	[UProperty(Flags = (PropFlags)6755469234274817uL)]
	[UMetaPath("/Script/CoreUObject.Int32Interval:Max")]
	public int Max;

	private static int FInt32Interval_StructSize;

	public static readonly FInt32Interval Default;

	public FInt32Interval Copy()
	{
		return this;
	}

	static FInt32Interval()
	{
		Default = new FInt32Interval(int.MaxValue, int.MinValue);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInt32Interval)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInt32Interval));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Int32Interval");
		FInt32Interval_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Min_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Min");
		Min_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Min", Classes.FIntProperty);
		Max_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Max");
		Max_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Max", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FInt32Interval));
	}

	public FInt32Interval(int min, int max)
	{
		Min = min;
		Max = max;
	}

	public static FInt32Interval operator +(FInt32Interval a, int offset)
	{
		if (a.IsValid())
		{
			a.Min += offset;
			a.Max += offset;
		}
		return a;
	}

	public static FInt32Interval operator -(FInt32Interval a, int offset)
	{
		if (a.IsValid())
		{
			a.Min -= offset;
			a.Max -= offset;
		}
		return a;
	}

	public static bool operator ==(FInt32Interval a, FInt32Interval b)
	{
		if (a.Min == b.Min)
		{
			return a.Max == b.Max;
		}
		return false;
	}

	public static bool operator !=(FInt32Interval a, FInt32Interval b)
	{
		if (a.Min == b.Min)
		{
			return a.Max != b.Max;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FInt32Interval))
		{
			return false;
		}
		return Equals((FInt32Interval)obj);
	}

	public bool Equals(FInt32Interval other)
	{
		if (Min == other.Min)
		{
			return Max == other.Max;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Min.GetHashCode() * 397) ^ Max.GetHashCode();
	}

	public int Size()
	{
		return Max - Min;
	}

	public bool IsValid()
	{
		return Min <= Max;
	}

	public bool Contains(int element)
	{
		if (IsValid())
		{
			if (element >= Min)
			{
				return element <= Max;
			}
			return false;
		}
		return false;
	}

	public void Expand(int expandAmount)
	{
		if (IsValid())
		{
			Min -= expandAmount;
			Max += expandAmount;
		}
	}

	public void Include(int x)
	{
		if (!IsValid())
		{
			Min = x;
			Max = x;
			return;
		}
		if (x < Min)
		{
			Min = x;
		}
		if (x > Max)
		{
			Max = x;
		}
	}

	public int Interpolate(float alpha)
	{
		if (IsValid())
		{
			return Min + (int)(alpha * (float)Size());
		}
		return 0;
	}

	public FInt32Interval Intersect(FInt32Interval a, FInt32Interval b)
	{
		if (a.IsValid() && b.IsValid())
		{
			return new FInt32Interval(FMath.Max(a.Min, b.Min), FMath.Min(a.Max, b.Max));
		}
		return Default;
	}
}
