using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 8)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Int32Range", "CoreUObject", UnrealModuleType.Engine)]
public struct FInt32Range : IEquatable<FInt32Range>
{
	private static bool LowerBound_IsValid;

	private static int LowerBound_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/CoreUObject.Int32Range:LowerBound")]
	public FInt32RangeBound LowerBound;

	private static bool UpperBound_IsValid;

	private static int UpperBound_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/CoreUObject.Int32Range:UpperBound")]
	public FInt32RangeBound UpperBound;

	private static bool FInt32Range_IsValid;

	private static int FInt32Range_StructSize;

	public FInt32Range Copy()
	{
		return this;
	}

	static FInt32Range()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInt32Range)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInt32Range));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.Int32Range");
		FInt32Range_StructSize = NativeReflection.GetStructSize(intPtr);
		LowerBound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowerBound");
		LowerBound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowerBound", Classes.FStructProperty);
		UpperBound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpperBound");
		UpperBound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpperBound", Classes.FStructProperty);
		FInt32Range_IsValid = intPtr != IntPtr.Zero && LowerBound_IsValid && UpperBound_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.Int32Range", FInt32Range_IsValid);
		NativeReflection.ValidateBlittableStructSize(intPtr, typeof(FInt32Range));
	}

	public FInt32Range(int a)
	{
		LowerBound = FInt32RangeBound.Inclusive(a);
		UpperBound = FInt32RangeBound.Inclusive(a);
	}

	public FInt32Range(int a, int b)
	{
		LowerBound = FInt32RangeBound.Inclusive(a);
		UpperBound = FInt32RangeBound.Exclusive(b);
	}

	public FInt32Range(FInt32RangeBound lowerBound, FInt32RangeBound upperBound)
	{
		LowerBound = lowerBound;
		UpperBound = upperBound;
	}

	public static bool operator ==(FInt32Range a, FInt32Range b)
	{
		if (a.LowerBound == b.LowerBound)
		{
			return a.UpperBound == b.UpperBound;
		}
		return false;
	}

	public static bool operator !=(FInt32Range a, FInt32Range b)
	{
		if (!(a.LowerBound != b.LowerBound))
		{
			return a.UpperBound != b.UpperBound;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FInt32Range))
		{
			return false;
		}
		return Equals((FInt32Range)obj);
	}

	public bool Equals(FInt32Range other)
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

	public bool Adjoins(FInt32Range other)
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

	public bool Conjoins(FInt32Range x, FInt32Range y)
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

	public bool Contains(int element)
	{
		if (FInt32RangeBound.MinLower(LowerBound, new FInt32RangeBound(element)) == LowerBound)
		{
			return FInt32RangeBound.MaxUpper(UpperBound, new FInt32RangeBound(element)) == UpperBound;
		}
		return false;
	}

	public bool Contains(FInt32Range other)
	{
		if (FInt32RangeBound.MinLower(LowerBound, other.LowerBound) == LowerBound)
		{
			return FInt32RangeBound.MaxUpper(UpperBound, other.UpperBound) == UpperBound;
		}
		return false;
	}

	public bool Contiguous(FInt32Range other)
	{
		if (!Overlaps(other))
		{
			return Adjoins(other);
		}
		return true;
	}

	public FInt32RangeBound GetLowerBound()
	{
		return LowerBound;
	}

	public void SetLowerBound(FInt32RangeBound newLowerBound)
	{
		LowerBound = newLowerBound;
	}

	public void SetLowerBoundValue(int newLowerBoundValue)
	{
		LowerBound.SetValue(newLowerBoundValue);
	}

	public int GetLowerBoundValue()
	{
		return LowerBound.GetValue();
	}

	public FInt32RangeBound GetUpperBound()
	{
		return UpperBound;
	}

	public void SetUpperBound(FInt32RangeBound newUpperBound)
	{
		UpperBound = newUpperBound;
	}

	public void SetUpperBoundValue(int newUpperBoundValue)
	{
		UpperBound.SetValue(newUpperBoundValue);
	}

	public int GetUpperBoundValue()
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

	public bool Overlaps(FInt32Range other)
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

	public int Size()
	{
		return UpperBound.GetValue() - LowerBound.GetValue();
	}

	public FInt32Range[] Split(int element)
	{
		if (!Contains(element))
		{
			return new FInt32Range[1] { this };
		}
		return new FInt32Range[2]
		{
			new FInt32Range(LowerBound, FInt32RangeBound.Exclusive(element)),
			new FInt32Range(FInt32RangeBound.Inclusive(element), UpperBound)
		};
	}

	public static FInt32Range[] Difference(FInt32Range x, FInt32Range y)
	{
		if (x.Overlaps(y))
		{
			FInt32Range fInt32Range = new FInt32Range(x.LowerBound, FInt32RangeBound.FlipInclusion(y.LowerBound));
			FInt32Range fInt32Range2 = new FInt32Range(FInt32RangeBound.FlipInclusion(y.UpperBound), x.UpperBound);
			if (!fInt32Range.IsEmpty())
			{
				if (fInt32Range2.IsEmpty())
				{
					return new FInt32Range[1] { fInt32Range };
				}
				return new FInt32Range[2] { fInt32Range, fInt32Range2 };
			}
			if (!fInt32Range2.IsEmpty())
			{
				return new FInt32Range[1] { fInt32Range2 };
			}
			return new FInt32Range[0];
		}
		return new FInt32Range[1] { x };
	}

	public static FInt32Range Hull(FInt32Range x, FInt32Range y)
	{
		if (x.IsEmpty())
		{
			return y;
		}
		if (y.IsEmpty())
		{
			return x;
		}
		return new FInt32Range(FInt32RangeBound.MinLower(x.LowerBound, y.LowerBound), FInt32RangeBound.MaxUpper(x.UpperBound, y.UpperBound));
	}

	public static FInt32Range Hull(FInt32Range[] ranges)
	{
		if (ranges == null || ranges.Length == 0)
		{
			return Empty();
		}
		FInt32Range fInt32Range = ranges[0];
		for (int i = 0; i < ranges.Length; i++)
		{
			fInt32Range = Hull(fInt32Range, ranges[i]);
		}
		return fInt32Range;
	}

	public static FInt32Range Intersection(FInt32Range x, FInt32Range y)
	{
		if (x.IsEmpty())
		{
			return Empty();
		}
		if (y.IsEmpty())
		{
			return Empty();
		}
		return new FInt32Range(FInt32RangeBound.MaxLower(x.LowerBound, y.LowerBound), FInt32RangeBound.MinUpper(x.UpperBound, y.UpperBound));
	}

	public static FInt32Range Intersection(FInt32Range[] ranges)
	{
		if (ranges == null || ranges.Length == 0)
		{
			return Empty();
		}
		FInt32Range fInt32Range = ranges[0];
		for (int i = 0; i < ranges.Length; i++)
		{
			fInt32Range = Intersection(fInt32Range, ranges[i]);
		}
		return fInt32Range;
	}

	public static FInt32Range[] Union(FInt32Range x, FInt32Range y)
	{
		if (x.Contains(y))
		{
			return new FInt32Range[1]
			{
				new FInt32Range(FInt32RangeBound.MinLower(x.LowerBound, y.LowerBound), FInt32RangeBound.MaxUpper(x.UpperBound, y.UpperBound))
			};
		}
		if (!x.IsEmpty())
		{
			if (y.IsEmpty())
			{
				return new FInt32Range[1] { x };
			}
			return new FInt32Range[2] { x, y };
		}
		if (!y.IsEmpty())
		{
			return new FInt32Range[1] { y };
		}
		return new FInt32Range[0];
	}

	public static FInt32Range All()
	{
		return new FInt32Range(FInt32RangeBound.Open(), FInt32RangeBound.Open());
	}

	public static FInt32Range AtLeast(int value)
	{
		return new FInt32Range(FInt32RangeBound.Inclusive(value), FInt32RangeBound.Open());
	}

	public static FInt32Range AtMost(int value)
	{
		return new FInt32Range(FInt32RangeBound.Open(), FInt32RangeBound.Inclusive(value));
	}

	public static FInt32Range Empty()
	{
		return new FInt32Range(FInt32RangeBound.Exclusive(0), FInt32RangeBound.Exclusive(0));
	}

	public static FInt32Range Exclusive(int min, int max)
	{
		return new FInt32Range(FInt32RangeBound.Exclusive(min), FInt32RangeBound.Exclusive(max));
	}

	public static FInt32Range GreaterThan(int value)
	{
		return new FInt32Range(FInt32RangeBound.Exclusive(value), FInt32RangeBound.Open());
	}

	public static FInt32Range Inclusive(int min, int max)
	{
		return new FInt32Range(FInt32RangeBound.Inclusive(min), FInt32RangeBound.Inclusive(max));
	}

	public static FInt32Range LessThan(int value)
	{
		return new FInt32Range(FInt32RangeBound.Open(), FInt32RangeBound.Exclusive(value));
	}
}
