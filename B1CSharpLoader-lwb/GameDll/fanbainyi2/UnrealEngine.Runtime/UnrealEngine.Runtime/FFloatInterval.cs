using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 57352)]
[UMetaPath("/Script/CoreUObject.FloatInterval", "CoreUObject", UnrealModuleType.Engine)]
public struct FFloatInterval : IEquatable<FFloatInterval>
{
	private static bool Min_IsValid;

	private static int Min_Offset;

	[UProperty(Flags = (PropFlags)6755469234274817uL)]
	[UMetaPath("/Script/CoreUObject.FloatInterval:Min")]
	public float Min;

	private static bool Max_IsValid;

	private static int Max_Offset;

	[UProperty(Flags = (PropFlags)6755469234274817uL)]
	[UMetaPath("/Script/CoreUObject.FloatInterval:Max")]
	public float Max;

	private static int FFloatInterval_StructSize;

	public static readonly FFloatInterval Default;

	public FFloatInterval Copy()
	{
		return this;
	}

	static FFloatInterval()
	{
		Default = new FFloatInterval(float.MaxValue, float.MinValue);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFloatInterval)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFloatInterval));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.FloatInterval");
		FFloatInterval_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Min_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Min");
		Min_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Min", Classes.FFloatProperty);
		Max_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Max");
		Max_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Max", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FFloatInterval));
	}

	public FFloatInterval(float min, float max)
	{
		Min = min;
		Max = max;
	}

	public static FFloatInterval operator +(FFloatInterval a, float offset)
	{
		if (a.IsValid())
		{
			a.Min += offset;
			a.Max += offset;
		}
		return a;
	}

	public static FFloatInterval operator -(FFloatInterval a, float offset)
	{
		if (a.IsValid())
		{
			a.Min -= offset;
			a.Max -= offset;
		}
		return a;
	}

	public static bool operator ==(FFloatInterval a, FFloatInterval b)
	{
		if (a.Min == b.Min)
		{
			return a.Max == b.Max;
		}
		return false;
	}

	public static bool operator !=(FFloatInterval a, FFloatInterval b)
	{
		if (a.Min == b.Min)
		{
			return a.Max != b.Max;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FFloatInterval))
		{
			return false;
		}
		return Equals((FFloatInterval)obj);
	}

	public bool Equals(FFloatInterval other)
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

	public float Size()
	{
		return Max - Min;
	}

	public bool IsValid()
	{
		return Min <= Max;
	}

	public bool Contains(float element)
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

	public void Expand(float expandAmount)
	{
		if (IsValid())
		{
			Min -= expandAmount;
			Max += expandAmount;
		}
	}

	public void Include(float x)
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

	public float Interpolate(float alpha)
	{
		if (IsValid())
		{
			return Min + alpha * Size();
		}
		return 0f;
	}

	public FFloatInterval Intersect(FFloatInterval a, FFloatInterval b)
	{
		if (a.IsValid() && b.IsValid())
		{
			return new FFloatInterval(FMath.Max(a.Min, b.Min), FMath.Min(a.Max, b.Max));
		}
		return Default;
	}
}
