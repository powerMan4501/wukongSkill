using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 57352)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.BoxSphereBounds", "CoreUObject", UnrealModuleType.Engine)]
public struct FBoxSphereBounds : IEquatable<FBoxSphereBounds>
{
	private static bool Origin_IsValid;

	private static int Origin_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.BoxSphereBounds:Origin")]
	public FVector Origin;

	private static bool BoxExtent_IsValid;

	private static int BoxExtent_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.BoxSphereBounds:BoxExtent")]
	public FVector BoxExtent;

	private static bool SphereRadius_IsValid;

	private static int SphereRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.BoxSphereBounds:SphereRadius")]
	public double mSphereRadius;

	private static int FBoxSphereBounds_StructSize;

	public float SphereRadius
	{
		get
		{
			return (float)mSphereRadius;
		}
		set
		{
			mSphereRadius = value;
		}
	}

	public FBoxSphereBounds Copy()
	{
		return this;
	}

	static FBoxSphereBounds()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBoxSphereBounds)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBoxSphereBounds));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.BoxSphereBounds");
		FBoxSphereBounds_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Origin_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Origin");
		Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Origin", Classes.FStructProperty);
		BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BoxExtent");
		BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BoxExtent", Classes.FStructProperty);
		SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mSphereRadius");
		SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mSphereRadius", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FBoxSphereBounds));
	}

	public FBoxSphereBounds(FVector origin, FVector boxExtent, double sphereRadius)
	{
		Origin = origin;
		BoxExtent = boxExtent;
		mSphereRadius = sphereRadius;
	}

	public FBoxSphereBounds(FBox box, FSphere sphere)
	{
		box.GetCenterAndExtents(out Origin, out BoxExtent);
		mSphereRadius = FMath.Min(BoxExtent.Size(), (double)(sphere.Center - Origin).Size() + sphere.W);
	}

	public FBoxSphereBounds(FBox box)
	{
		box.GetCenterAndExtents(out Origin, out BoxExtent);
		mSphereRadius = BoxExtent.Size();
	}

	public FBoxSphereBounds(FSphere sphere)
	{
		Origin = sphere.Center;
		BoxExtent = new FVector(sphere.W);
		mSphereRadius = sphere.W;
	}

	public FBoxSphereBounds(FVector[] points)
	{
		FBox fBox = default(FBox);
		for (uint num = 0u; num < points.Length; num++)
		{
			fBox += points[num];
		}
		fBox.GetCenterAndExtents(out Origin, out BoxExtent);
		mSphereRadius = 0.0;
		for (uint num2 = 0u; num2 < points.Length; num2++)
		{
			SphereRadius = FMath.Max(SphereRadius, (points[num2] - Origin).Size());
		}
	}

	public static FBoxSphereBounds operator +(FBoxSphereBounds a, FBoxSphereBounds b)
	{
		FBox box = default(FBox);
		box += a.Origin - a.BoxExtent;
		box += a.Origin + a.BoxExtent;
		box += b.Origin - b.BoxExtent;
		box += b.Origin + b.BoxExtent;
		FBoxSphereBounds result = new FBoxSphereBounds(box);
		result.SphereRadius = FMath.Min(result.SphereRadius, FMath.Max((a.Origin - result.Origin).Size() + a.SphereRadius, (b.Origin - result.Origin).Size() + b.SphereRadius));
		return result;
	}

	public static bool operator ==(FBoxSphereBounds a, FBoxSphereBounds b)
	{
		if (a.Origin == b.Origin && a.BoxExtent == b.BoxExtent)
		{
			return a.SphereRadius == b.SphereRadius;
		}
		return false;
	}

	public static bool operator !=(FBoxSphereBounds a, FBoxSphereBounds b)
	{
		if (!(a.Origin != b.Origin) && !(a.BoxExtent != b.BoxExtent))
		{
			return a.SphereRadius != b.SphereRadius;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FBoxSphereBounds))
		{
			return false;
		}
		return Equals((FBoxSphereBounds)obj);
	}

	public bool Equals(FBoxSphereBounds other)
	{
		if (Origin == other.Origin && BoxExtent == other.BoxExtent)
		{
			return SphereRadius == other.SphereRadius;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Origin.GetHashCode() * 397) ^ BoxExtent.GetHashCode()) * 397) ^ SphereRadius.GetHashCode();
	}

	public double ComputeSquaredDistanceFromBoxToPoint(FVector point)
	{
		FVector mins = Origin - BoxExtent;
		FVector maxs = Origin + BoxExtent;
		return FVector.ComputeSquaredDistanceFromBoxToPoint(mins, maxs, point);
	}

	public static bool SpheresIntersect(FBoxSphereBounds a, FBoxSphereBounds b, double tolerance = 9.999999747378752E-05)
	{
		return (a.Origin - b.Origin).SizeSquared() <= FMath.Square(FMath.Max(0.0, (double)(a.SphereRadius + b.SphereRadius) + tolerance));
	}

	public static bool BoxesIntersect(FBoxSphereBounds a, FBoxSphereBounds b)
	{
		return a.GetBox().Intersect(b.GetBox());
	}

	public FBox GetBox()
	{
		return new FBox(Origin - BoxExtent, Origin + BoxExtent);
	}

	public FVector GetBoxExtrema(uint extrema)
	{
		if (extrema != 0)
		{
			return Origin + BoxExtent;
		}
		return Origin - BoxExtent;
	}

	public FSphere GetSphere()
	{
		return new FSphere(Origin, SphereRadius);
	}

	public FBoxSphereBounds ExpandBy(double expandAmount)
	{
		return new FBoxSphereBounds(Origin, BoxExtent + expandAmount, (double)SphereRadius + expandAmount);
	}

	public FBoxSphereBounds TransformBy(FMatrix m)
	{
		FBoxSphereBounds result = default(FBoxSphereBounds);
		FVector origin = Origin;
		FVector boxExtent = BoxExtent;
		FVector row = m.GetRow(0);
		FVector row2 = m.GetRow(1);
		FVector row3 = m.GetRow(2);
		FVector row4 = m.GetRow(3);
		FVector origin2 = FVector.Replicate(origin, 0) * row;
		origin2 += FVector.Replicate(origin, 1) * row2;
		origin2 += FVector.Replicate(origin, 2) * row3;
		origin2 += row4;
		FVector abs = (FVector.Replicate(boxExtent, 0) * row).GetAbs();
		abs += (FVector.Replicate(boxExtent, 1) * row2).GetAbs();
		abs = (result.BoxExtent = abs + (FVector.Replicate(boxExtent, 2) * row3).GetAbs());
		result.Origin = origin2;
		FVector fVector = row * row;
		fVector += row2 * row2;
		fVector += row3 * row3;
		result.SphereRadius = FMath.Sqrt((float)FVector.ComponentMax(FVector.ComponentMax(fVector, FVector.Replicate(fVector, 1)), FVector.Replicate(fVector, 2))[0]) * SphereRadius;
		float val = FMath.Sqrt(FVector.DotProduct(abs, abs));
		result.SphereRadius = FMath.Min(result.SphereRadius, val);
		return result;
	}

	public FBoxSphereBounds TransformBy(FTransform m)
	{
		FMatrix m2 = m.ToMatrixWithScale();
		return TransformBy(m2);
	}

	public override string ToString()
	{
		string[] obj = new string[7] { "Origin=", null, null, null, null, null, null };
		FVector origin = Origin;
		obj[1] = origin.ToString();
		obj[2] = ", BoxExtent=(";
		origin = BoxExtent;
		obj[3] = origin.ToString();
		obj[4] = "), SphereRadius=(";
		obj[5] = SphereRadius.ToString();
		obj[6] = ")";
		return string.Concat(obj);
	}

	public FBoxSphereBounds Union(FBoxSphereBounds a, FBoxSphereBounds b)
	{
		FBox box = default(FBox);
		box += a.Origin - a.BoxExtent;
		box += a.Origin + a.BoxExtent;
		box += b.Origin - b.BoxExtent;
		box += b.Origin + b.BoxExtent;
		FBoxSphereBounds result = new FBoxSphereBounds(box);
		result.SphereRadius = FMath.Min(result.SphereRadius, FMath.Max((a.Origin - result.Origin).Size() + a.SphereRadius, (b.Origin - result.Origin).Size() + b.SphereRadius));
		return result;
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN()
	{
		if (Origin.ContainsNaN())
		{
			FVector origin = Origin;
			FMath.LogOrEnsureNanError("Origin contains NaN: " + origin.ToString());
			Origin = FVector.ZeroVector;
		}
		if (BoxExtent.ContainsNaN())
		{
			FVector origin = BoxExtent;
			FMath.LogOrEnsureNanError("BoxExtent contains NaN: " + origin.ToString());
			BoxExtent = FVector.ZeroVector;
		}
		if (FMath.IsNaN(SphereRadius) || !FMath.IsFinite(SphereRadius))
		{
			FMath.LogOrEnsureNanError("SphereRadius contains NaN: " + SphereRadius);
			SphereRadius = 0f;
		}
	}

	public bool ContainsNaN()
	{
		if (!Origin.ContainsNaN() && !BoxExtent.ContainsNaN())
		{
			return !FMath.IsFinite(SphereRadius);
		}
		return true;
	}
}
