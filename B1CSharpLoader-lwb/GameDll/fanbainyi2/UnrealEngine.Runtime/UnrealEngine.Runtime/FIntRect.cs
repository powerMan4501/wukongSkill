using System;

namespace UnrealEngine.Runtime;

public struct FIntRect : IEquatable<FIntRect>
{
	public FIntPoint Min;

	public FIntPoint Max;

	public FIntPoint this[int index]
	{
		get
		{
			return index switch
			{
				0 => Min, 
				1 => Max, 
				_ => throw new IndexOutOfRangeException("Invalid FIntRect index (" + index + ")"), 
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
				throw new IndexOutOfRangeException("Invalid FIntRect index (" + index + ")");
			}
		}
	}

	public FIntRect(int x0, int y0, int x1, int y1)
	{
		Min.X = x0;
		Min.Y = y0;
		Max.X = x1;
		Max.Y = y1;
	}

	public FIntRect(FIntPoint min, FIntPoint max)
	{
		Min = min;
		Max = max;
	}

	public static bool operator ==(FIntRect a, FIntRect b)
	{
		if (a.Min == b.Min)
		{
			return a.Max == b.Max;
		}
		return false;
	}

	public static bool operator !=(FIntRect a, FIntRect b)
	{
		if (!(a.Min != b.Min))
		{
			return a.Max != b.Max;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FIntRect))
		{
			return false;
		}
		return Equals((FIntRect)obj);
	}

	public bool Equals(FIntRect other)
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

	public static FIntRect operator *(int scale, FIntRect rect)
	{
		Multiply(ref rect, scale, out rect);
		return rect;
	}

	public static FIntRect operator *(FIntRect rect, int scale)
	{
		Multiply(ref rect, scale, out rect);
		return rect;
	}

	public static FIntRect Multiply(FIntRect rect, int scale)
	{
		Multiply(ref rect, scale, out rect);
		return rect;
	}

	public static void Multiply(ref FIntRect rect, int scale, out FIntRect result)
	{
		result.Min = rect.Min * scale;
		result.Max = rect.Max * scale;
	}

	public static FIntRect operator /(FIntRect rect, int scale)
	{
		Divide(ref rect, scale, out rect);
		return rect;
	}

	public static FIntRect Divide(FIntRect rect, int scale)
	{
		Divide(ref rect, scale, out rect);
		return rect;
	}

	public static void Divide(ref FIntRect rect, int scale, out FIntRect result)
	{
		result.Min = rect.Min / scale;
		result.Max = rect.Max / scale;
	}

	public static FIntRect operator +(FIntRect rect, FIntPoint point)
	{
		Add(ref rect, ref point, out rect);
		return rect;
	}

	public static FIntRect Add(FIntRect rect, FIntPoint point)
	{
		Add(ref rect, ref point, out rect);
		return rect;
	}

	public static void Add(ref FIntRect rect, ref FIntPoint point, out FIntRect result)
	{
		result.Min = rect.Min + point;
		result.Max = rect.Max + point;
	}

	public static FIntRect operator -(FIntRect rect, FIntPoint point)
	{
		Subtract(ref rect, ref point, out rect);
		return rect;
	}

	public static FIntRect Subtract(FIntRect rect, FIntPoint point)
	{
		Subtract(ref rect, ref point, out rect);
		return rect;
	}

	public static void Subtract(ref FIntRect rect, ref FIntPoint point, out FIntRect result)
	{
		result.Min = rect.Min - point;
		result.Max = rect.Max - point;
	}

	public static FIntRect operator +(FIntRect a, FIntRect b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FIntRect Add(FIntRect a, FIntRect b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FIntRect a, ref FIntRect b, out FIntRect result)
	{
		result.Min = a.Min + b.Min;
		result.Max = a.Max + b.Max;
	}

	public static FIntRect operator -(FIntRect a, FIntRect b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static FIntRect Subtract(FIntRect a, FIntRect b)
	{
		Subtract(ref a, ref b, out a);
		return a;
	}

	public static void Subtract(ref FIntRect a, ref FIntRect b, out FIntRect result)
	{
		result.Min = a.Min - b.Min;
		result.Max = a.Max - b.Max;
	}

	public int Area()
	{
		return (Max.X - Min.X) * (Max.Y - Min.Y);
	}

	public FIntRect Bottom(int height)
	{
		return new FIntRect(Min.X, FMath.Max(Min.Y, Max.Y - height), Max.X, Max.Y);
	}

	public void Clip(FIntRect other)
	{
		Min.X = FMath.Max(Min.X, other.Min.X);
		Min.Y = FMath.Max(Min.Y, other.Min.Y);
		Max.X = FMath.Min(Max.X, other.Max.X);
		Max.Y = FMath.Min(Max.Y, other.Max.Y);
		Max.X = FMath.Max(Min.X, Max.X);
		Max.Y = FMath.Max(Min.Y, Max.Y);
	}

	public void Union(FIntRect other)
	{
		Min.X = FMath.Min(Min.X, other.Min.X);
		Min.Y = FMath.Min(Min.Y, other.Min.Y);
		Max.X = FMath.Max(Max.X, other.Max.X);
		Max.Y = FMath.Max(Max.Y, other.Max.Y);
	}

	public bool Contains(FIntPoint point)
	{
		if (point.X >= Min.X && point.X < Max.X && point.Y >= Min.Y)
		{
			return point.Y < Max.Y;
		}
		return false;
	}

	public void GetCenterAndExtents(out FIntPoint center, out FIntPoint extent)
	{
		extent.X = (Max.X - Min.X) / 2;
		extent.Y = (Max.Y - Min.Y) / 2;
		center.X = Min.X + extent.X;
		center.Y = Min.Y + extent.Y;
	}

	public int Height()
	{
		return Max.Y - Min.Y;
	}

	public void InflateRect(int amount)
	{
		Min.X -= amount;
		Min.Y -= amount;
		Max.X += amount;
		Max.Y += amount;
	}

	public void Include(FIntPoint point)
	{
		Min.X = FMath.Min(Min.X, point.X);
		Min.Y = FMath.Min(Min.Y, point.Y);
		Max.X = FMath.Max(Max.X, point.X);
		Max.Y = FMath.Max(Max.Y, point.Y);
	}

	public FIntRect Inner(FIntPoint shrink)
	{
		return new FIntRect(Min + shrink, Max - shrink);
	}

	public FIntRect Right(int width)
	{
		return new FIntRect(FMath.Max(Min.X, Max.X - width), Min.Y, Max.X, Max.Y);
	}

	public FIntRect Scale(float fraction)
	{
		FVector2D fVector2D = new FVector2D(Min.X, Min.Y) * fraction;
		FVector2D fVector2D2 = new FVector2D(Max.X, Max.Y) * fraction;
		return new FIntRect(FMath.FloorToInt(fVector2D.X), FMath.FloorToInt(fVector2D.Y), FMath.CeilToInt(fVector2D2.X), FMath.CeilToInt(fVector2D2.Y));
	}

	public FIntPoint Size()
	{
		return new FIntPoint(Max.X - Min.X, Max.Y - Min.Y);
	}

	public override string ToString()
	{
		string[] obj = new string[5] { "Min=(", null, null, null, null };
		FIntPoint min = Min;
		obj[1] = min.ToString();
		obj[2] = ") Max=(";
		min = Max;
		obj[3] = min.ToString();
		obj[4] = ")";
		return string.Concat(obj);
	}

	public int Width()
	{
		return Max.X - Min.X;
	}

	public bool IsEmpty()
	{
		if (Width() == 0)
		{
			return Height() == 0;
		}
		return false;
	}

	public static FIntRect DivideAndRoundUp(FIntRect lhs, int div)
	{
		return DivideAndRoundUp(lhs, new FIntPoint(div, div));
	}

	public static FIntRect DivideAndRoundUp(FIntRect lhs, FIntPoint div)
	{
		return new FIntRect(lhs.Min / div, FIntPoint.DivideAndRoundUp(lhs.Max, div));
	}

	public static int Num()
	{
		return 2;
	}
}
