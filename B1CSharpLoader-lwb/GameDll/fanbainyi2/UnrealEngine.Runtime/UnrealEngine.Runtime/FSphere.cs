using System;

namespace UnrealEngine.Runtime;

public struct FSphere : IEquatable<FSphere>
{
	public FVector Center;

	public double W;

	public FSphere(FVector v, double w)
	{
		Center = v;
		W = w;
	}

	public FSphere(FVector[] pts)
	{
		if (pts.Length != 0)
		{
			FBox fBox = new FBox(pts);
			this = new FSphere((fBox.Min + fBox.Max) / 2.0, 0.0);
			for (int i = 0; i < pts.Length; i++)
			{
				double num = FVector.DistSquared(pts[i], Center);
				if (num > W)
				{
					W = num;
				}
			}
		}
		else
		{
			this = default(FSphere);
		}
	}

	public bool Equals(FSphere other, double tolerance = 9.999999747378752E-05)
	{
		if (Center.Equals(other.Center, tolerance))
		{
			return FMath.Abs(W - other.W) <= tolerance;
		}
		return false;
	}

	public bool IsInside(FSphere other, double tolerance = 9.999999747378752E-05)
	{
		if (W > other.W + tolerance)
		{
			return false;
		}
		return (Center - other.Center).SizeSquared() <= FMath.Square(other.W + tolerance - W);
	}

	public bool IsInside(FVector v, double tolerance = 9.999999747378752E-05)
	{
		return (Center - v).SizeSquared() <= FMath.Square(W + tolerance);
	}

	public bool Intersects(FSphere other, double tolerance = 9.999999747378752E-05)
	{
		return (Center - other.Center).SizeSquared() <= FMath.Square(FMath.Max(0.0, other.W + W + tolerance));
	}

	public FSphere TransformBy(FMatrix m)
	{
		FSphere result = default(FSphere);
		result.Center = m.TransformPosition(Center);
		FVector fVector = new FVector(m[0, 0], m[0, 1], m[0, 2]);
		FVector fVector2 = new FVector(m[1, 0], m[1, 1], m[1, 2]);
		FVector fVector3 = new FVector(m[2, 0], m[2, 1], m[2, 2]);
		result.W = (double)FMath.Sqrt(FMath.Max(fVector | fVector, FMath.Max(fVector2 | fVector2, fVector3 | fVector3))) * W;
		return result;
	}

	public FSphere TransformBy(FTransform m)
	{
		FSphere result = default(FSphere);
		result.Center = m.TransformPosition(Center);
		result.W = m.GetMaximumAxisScale() * W;
		return result;
	}

	public double GetVolume()
	{
		return 4.188790321350098 * (W * W * W);
	}

	public static FSphere operator +(FSphere a, FSphere b)
	{
		if (a.W == 0.0)
		{
			a = b;
		}
		else if (a.IsInside(b))
		{
			a = b;
		}
		else if (!b.IsInside(a))
		{
			FVector fVector = b.Center - a.Center;
			FVector fVector2 = fVector;
			fVector2.Normalize();
			double w = ((double)fVector.Size() + b.W + a.W) * 0.5;
			FVector fVector3 = b.Center + fVector2 * b.W;
			FVector fVector4 = a.Center - fVector2 * a.W;
			FVector center = (fVector3 + fVector4) * 0.5;
			FSphere fSphere = default(FSphere);
			fSphere.Center = center;
			fSphere.W = w;
			a = fSphere;
		}
		return a;
	}

	public static bool operator ==(FSphere a, FSphere b)
	{
		if (a.Center == b.Center)
		{
			return a.W == b.W;
		}
		return false;
	}

	public static bool operator !=(FSphere a, FSphere b)
	{
		if (!(a.Center != b.Center))
		{
			return a.W != b.W;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FSphere))
		{
			return false;
		}
		return Equals((FSphere)obj);
	}

	public bool Equals(FSphere other)
	{
		if (Center == other.Center)
		{
			return W == other.W;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Center.GetHashCode() * 397) ^ W.GetHashCode();
	}
}
