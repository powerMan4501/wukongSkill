using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 8)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FloatRange", "CoreUObject", UnrealModuleType.Engine)]
public struct FFloatRange : IEquatable<FFloatRange>
{
	private static bool LowerBound_IsValid;

	private static int LowerBound_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/CoreUObject.FloatRange:LowerBound")]
	public FFloatRangeBound LowerBound;

	private static bool UpperBound_IsValid;

	private static int UpperBound_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/CoreUObject.FloatRange:UpperBound")]
	public FFloatRangeBound UpperBound;

	private static bool FFloatRange_IsValid;

	private static int FFloatRange_StructSize;

	public FFloatRange Copy()
	{
		return this;
	}

	static FFloatRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFloatRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFloatRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.FloatRange");
		FFloatRange_StructSize = NativeReflection.GetStructSize(intPtr);
		LowerBound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowerBound");
		LowerBound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowerBound", Classes.FStructProperty);
		UpperBound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpperBound");
		UpperBound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpperBound", Classes.FStructProperty);
		FFloatRange_IsValid = intPtr != IntPtr.Zero && LowerBound_IsValid && UpperBound_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.FloatRange", FFloatRange_IsValid);
		NativeReflection.ValidateBlittableStructSize(intPtr, typeof(FFloatRange));
	}

	public FFloatRange(float a)
	{
		LowerBound = FFloatRangeBound.Inclusive(a);
		UpperBound = FFloatRangeBound.Inclusive(a);
	}

	public FFloatRange(float a, float b)
	{
		LowerBound = FFloatRangeBound.Inclusive(a);
		UpperBound = FFloatRangeBound.Exclusive(b);
	}

	public FFloatRange(FFloatRangeBound lowerBound, FFloatRangeBound upperBound)
	{
		LowerBound = lowerBound;
		UpperBound = upperBound;
	}

	public static bool operator ==(FFloatRange a, FFloatRange b)
	{
		if (a.LowerBound == b.LowerBound)
		{
			return a.UpperBound == b.UpperBound;
		}
		return false;
	}

	public static bool operator !=(FFloatRange a, FFloatRange b)
	{
		if (!(a.LowerBound != b.LowerBound))
		{
			return a.UpperBound != b.UpperBound;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FFloatRange))
		{
			return false;
		}
		return Equals((FFloatRange)obj);
	}

	public bool Equals(FFloatRange other)
	{
		if (LowerBound == other.LowerBound)
		{
			return UpperBound == other.UpperBound;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (LowerBound.GetHashCode() * 397) ^ UpperBound.GetHashCode();
	}

	public bool Adjoins(FFloatRange other)
	{
		if (IsEmpty() || other.IsEmpty())
		{
			return false;
		}
		if (!UpperBound.IsOpen() && !other.LowerBound.IsOpen() && UpperBound.GetValue() == other.LowerBound.GetValue())
		{
			if (!UpperBound.IsInclusive() || !other.LowerBound.IsExclusive())
			{
				if (UpperBound.IsExclusive())
				{
					return other.LowerBound.IsInclusive();
				}
				return false;
			}
			return true;
		}
		if (!other.UpperBound.IsOpen() && !LowerBound.IsOpen() && other.UpperBound.GetValue() == LowerBound.GetValue())
		{
			if (!other.UpperBound.IsInclusive() || !LowerBound.IsExclusive())
			{
				if (other.UpperBound.IsExclusive())
				{
					return LowerBound.IsInclusive();
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public bool Conjoins(FFloatRange x, FFloatRange y)
	{
		if (x.Overlaps(y))
		{
			return false;
		}
		if (Adjoins(x))
		{
			return Adjoins(y);
		}
		return false;
	}

	public bool Contains(float element)
	{
		if (FFloatRangeBound.MinLower(LowerBound, new FFloatRangeBound(element)) == LowerBound)
		{
			return FFloatRangeBound.MaxUpper(UpperBound, new FFloatRangeBound(element)) == UpperBound;
		}
		return false;
	}

	public bool Contains(FFloatRange other)
	{
		if (FFloatRangeBound.MinLower(LowerBound, other.LowerBound) == LowerBound)
		{
			return FFloatRangeBound.MaxUpper(UpperBound, other.UpperBound) == UpperBound;
		}
		return false;
	}

	public bool Contiguous(FFloatRange other)
	{
		if (!Overlaps(other))
		{
			return Adjoins(other);
		}
		return true;
	}

	public FFloatRangeBound GetLowerBound()
	{
		return LowerBound;
	}

	public void SetLowerBound(FFloatRangeBound newLowerBound)
	{
		LowerBound = newLowerBound;
	}

	public void SetLowerBoundValue(float newLowerBoundValue)
	{
		LowerBound.SetValue(newLowerBoundValue);
	}

	public float GetLowerBoundValue()
	{
		return LowerBound.GetValue();
	}

	public FFloatRangeBound GetUpperBound()
	{
		return UpperBound;
	}

	public void SetUpperBound(FFloatRangeBound newUpperBound)
	{
		UpperBound = newUpperBound;
	}

	public void SetUpperBoundValue(float newUpperBoundValue)
	{
		UpperBound.SetValue(newUpperBoundValue);
	}

	public float GetUpperBoundValue()
	{
		return UpperBound.GetValue();
	}

	public bool HasLowerBound()
	{
		return LowerBound.IsClosed();
	}

	public bool HasUpperBound()
	{
		return UpperBound.IsClosed();
	}

	public bool IsDegenerate()
	{
		if (LowerBound.IsInclusive())
		{
			return LowerBound == UpperBound;
		}
		return false;
	}

	public bool IsEmpty()
	{
		if (LowerBound.IsClosed() && UpperBound.IsClosed())
		{
			if (LowerBound.GetValue() > UpperBound.GetValue())
			{
				return true;
			}
			if (LowerBound.GetValue() == UpperBound.GetValue())
			{
				if (!LowerBound.IsExclusive())
				{
					return UpperBound.IsExclusive();
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public bool Overlaps(FFloatRange other)
	{
		if (IsEmpty() || other.IsEmpty())
		{
			return false;
		}
		bool num = UpperBound.IsOpen() || other.LowerBound.IsOpen();
		bool flag = LowerBound.IsOpen() || other.UpperBound.IsOpen();
		bool flag2 = true;
		bool flag3 = true;
		if (!num)
		{
			bool flag4 = UpperBound.GetValue() > other.LowerBound.GetValue();
			bool flag5 = UpperBound.GetValue() >= other.LowerBound.GetValue();
			flag2 = ((UpperBound.IsInclusive() && other.LowerBound.IsInclusive()) ? flag5 : flag4);
		}
		if (!flag)
		{
			bool flag6 = LowerBound.GetValue() < other.UpperBound.GetValue();
			bool flag7 = LowerBound.GetValue() <= other.UpperBound.GetValue();
			flag3 = ((LowerBound.IsInclusive() && other.UpperBound.IsInclusive()) ? flag7 : flag6);
		}
		return flag2 && flag3;
	}

	public float Size()
	{
		return UpperBound.GetValue() - LowerBound.GetValue();
	}

	public FFloatRange[] Split(float element)
	{
		if (!Contains(element))
		{
			return new FFloatRange[1] { this };
		}
		return new FFloatRange[2]
		{
			new FFloatRange(LowerBound, FFloatRangeBound.Exclusive(element)),
			new FFloatRange(FFloatRangeBound.Inclusive(element), UpperBound)
		};
	}

	public static FFloatRange[] Difference(FFloatRange x, FFloatRange y)
	{
		if (x.Overlaps(y))
		{
			FFloatRange fFloatRange = new FFloatRange(x.LowerBound, FFloatRangeBound.FlipInclusion(y.LowerBound));
			FFloatRange fFloatRange2 = new FFloatRange(FFloatRangeBound.FlipInclusion(y.UpperBound), x.UpperBound);
			if (!fFloatRange.IsEmpty())
			{
				if (fFloatRange2.IsEmpty())
				{
					return new FFloatRange[1] { fFloatRange };
				}
				return new FFloatRange[2] { fFloatRange, fFloatRange2 };
			}
			if (!fFloatRange2.IsEmpty())
			{
				return new FFloatRange[1] { fFloatRange2 };
			}
			return new FFloatRange[0];
		}
		return new FFloatRange[1] { x };
	}

	public static FFloatRange Hull(FFloatRange x, FFloatRange y)
	{
		if (x.IsEmpty())
		{
			return y;
		}
		if (y.IsEmpty())
		{
			return x;
		}
		return new FFloatRange(FFloatRangeBound.MinLower(x.LowerBound, y.LowerBound), FFloatRangeBound.MaxUpper(x.UpperBound, y.UpperBound));
	}

	public static FFloatRange Hull(FFloatRange[] ranges)
	{
		if (ranges == null || ranges.Length == 0)
		{
			return Empty();
		}
		FFloatRange fFloatRange = ranges[0];
		for (int i = 0; i < ranges.Length; i++)
		{
			fFloatRange = Hull(fFloatRange, ranges[i]);
		}
		return fFloatRange;
	}

	public static FFloatRange Intersection(FFloatRange x, FFloatRange y)
	{
		if (x.IsEmpty())
		{
			return Empty();
		}
		if (y.IsEmpty())
		{
			return Empty();
		}
		return new FFloatRange(FFloatRangeBound.MaxLower(x.LowerBound, y.LowerBound), FFloatRangeBound.MinUpper(x.UpperBound, y.UpperBound));
	}

	public static FFloatRange Intersection(FFloatRange[] ranges)
	{
		if (ranges == null || ranges.Length == 0)
		{
			return Empty();
		}
		FFloatRange fFloatRange = ranges[0];
		for (int i = 0; i < ranges.Length; i++)
		{
			fFloatRange = Intersection(fFloatRange, ranges[i]);
		}
		return fFloatRange;
	}

	public static FFloatRange[] Union(FFloatRange x, FFloatRange y)
	{
		if (x.Contains(y))
		{
			return new FFloatRange[1]
			{
				new FFloatRange(FFloatRangeBound.MinLower(x.LowerBound, y.LowerBound), FFloatRangeBound.MaxUpper(x.UpperBound, y.UpperBound))
			};
		}
		if (!x.IsEmpty())
		{
			if (y.IsEmpty())
			{
				return new FFloatRange[1] { x };
			}
			return new FFloatRange[2] { x, y };
		}
		if (!y.IsEmpty())
		{
			return new FFloatRange[1] { y };
		}
		return new FFloatRange[0];
	}

	public static FFloatRange All()
	{
		return new FFloatRange(FFloatRangeBound.Open(), FFloatRangeBound.Open());
	}

	public static FFloatRange AtLeast(float value)
	{
		return new FFloatRange(FFloatRangeBound.Inclusive(value), FFloatRangeBound.Open());
	}

	public static FFloatRange AtMost(float value)
	{
		return new FFloatRange(FFloatRangeBound.Open(), FFloatRangeBound.Inclusive(value));
	}

	public static FFloatRange Empty()
	{
		return new FFloatRange(FFloatRangeBound.Exclusive(0f), FFloatRangeBound.Exclusive(0f));
	}

	public static FFloatRange Exclusive(float min, float max)
	{
		return new FFloatRange(FFloatRangeBound.Exclusive(min), FFloatRangeBound.Exclusive(max));
	}

	public static FFloatRange GreaterThan(float value)
	{
		return new FFloatRange(FFloatRangeBound.Exclusive(value), FFloatRangeBound.Open());
	}

	public static FFloatRange Inclusive(float min, float max)
	{
		return new FFloatRange(FFloatRangeBound.Inclusive(min), FFloatRangeBound.Inclusive(max));
	}

	public static FFloatRange LessThan(float value)
	{
		return new FFloatRange(FFloatRangeBound.Open(), FFloatRangeBound.Exclusive(value));
	}
}
