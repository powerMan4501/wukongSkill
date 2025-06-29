using System;
using UnrealEngine.Runtime;

namespace b1;

public class GSLocation : IDisposable
{
	private float _x;

	private float _y;

	private float _z;

	public static readonly GSLocation ZeroVector = new GSLocation(0f, 0f, 0f);

	public static readonly GSLocation OneVector = new GSLocation(1f, 1f, 1f);

	public static readonly GSLocation UpVector = new GSLocation(0f, 0f, 1f);

	public static readonly GSLocation ForwardVector = new GSLocation(1f, 0f, 0f);

	public static readonly GSLocation RightVector = new GSLocation(0f, 1f, 0f);

	public float X
	{
		get
		{
			return _x;
		}
		set
		{
			_x = value;
			bValueVectorMatch = false;
		}
	}

	public float Y
	{
		get
		{
			return _y;
		}
		set
		{
			_y = value;
			bValueVectorMatch = false;
		}
	}

	public float Z
	{
		get
		{
			return _z;
		}
		set
		{
			_z = value;
			bValueVectorMatch = false;
		}
	}

	private bool bValueVectorMatch { get; set; }

	private FVector MappingVector { get; set; }

	private bool bCreateByPool { get; set; }

	public GSLocation()
	{
		MappingVector = FVector.ZeroVector;
		bValueVectorMatch = true;
		bCreateByPool = false;
	}

	private GSLocation(float InX, float InY, float InZ)
	{
		X = InX;
		Y = InY;
		Z = InZ;
	}

	public static GSLocation CreateByPool()
	{
		return new GSLocation
		{
			bCreateByPool = true
		};
	}

	public static GSLocation operator +(in GSLocation A, in GSLocation B)
	{
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.X = A.X + B.X;
		gSLocation.Y = A.Y + B.Y;
		gSLocation.Z = A.Z + B.Z;
		return gSLocation;
	}

	public static GSLocation operator +(in GSLocation A, in FVector B)
	{
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.X = A.X + B.X;
		gSLocation.Y = A.Y + B.Y;
		gSLocation.Z = A.Z + B.Z;
		return gSLocation;
	}

	public static GSLocation operator +(in FVector A, in GSLocation B)
	{
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.X = A.X + B.X;
		gSLocation.Y = A.Y + B.Y;
		gSLocation.Z = A.Z + B.Z;
		return gSLocation;
	}

	public static GSLocation operator -(GSLocation v)
	{
		v.X = 0f - v.X;
		v.Y = 0f - v.Y;
		v.Z = 0f - v.Z;
		return v;
	}

	public static GSLocation operator -(in GSLocation A, in FVector B)
	{
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.X = A.X - B.X;
		gSLocation.Y = A.Y - B.Y;
		gSLocation.Z = A.Z - B.Z;
		return gSLocation;
	}

	public static GSLocation operator -(in GSLocation A, in GSLocation B)
	{
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.X = A.X - B.X;
		gSLocation.Y = A.Y - B.Y;
		gSLocation.Z = A.Z - B.Z;
		return gSLocation;
	}

	public static GSLocation operator *(GSLocation Location, float Scale)
	{
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.X = Location.X * Scale;
		gSLocation.Y = Location.Y * Scale;
		gSLocation.Z = Location.Z * Scale;
		return gSLocation;
	}

	public static GSLocation operator *(float Scale, GSLocation Location)
	{
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.X = Location.X * Scale;
		gSLocation.Y = Location.Y * Scale;
		gSLocation.Z = Location.Z * Scale;
		return gSLocation;
	}

	public static GSLocation operator /(in GSLocation Location, float Scale)
	{
		GSLocation gSLocation = GSLocationPool.New();
		float num = 1f / Scale;
		gSLocation.X = Location.X * num;
		gSLocation.Y = Location.Y * num;
		gSLocation.Z = Location.Z * num;
		return gSLocation;
	}

	public static float operator |(GSLocation a, GSLocation b)
	{
		return DotProduct(ref a, ref b);
	}

	public static GSLocation operator ^(GSLocation a, GSLocation b)
	{
		CrossProduct(ref a, ref b, out var Result);
		return Result;
	}

	public void SetValue(FVector InLocation)
	{
		X = InLocation.X;
		Y = InLocation.Y;
		Z = InLocation.Z;
	}

	public void SetValue(GSLocation InLocation)
	{
		X = InLocation.X;
		Y = InLocation.Y;
		Z = InLocation.Z;
	}

	public void SetValue(float InX, float InY, float InZ)
	{
		X = InX;
		Y = InY;
		Z = InZ;
	}

	public void SetValue(float InValue)
	{
		X = InValue;
		Y = InValue;
		Z = InValue;
	}

	public bool IsNearlyZero(float Tolerance = 0.0001f)
	{
		if (FMath.Abs(X) <= Tolerance && FMath.Abs(Y) <= Tolerance)
		{
			return FMath.Abs(Z) <= Tolerance;
		}
		return false;
	}

	public GSRotation ToOrientationRotator()
	{
		GSRotation gSRotation = GSRotationPool.New();
		gSRotation.Yaw = FMath.Atan2(Y, X) * (180f / (float)Math.PI);
		gSRotation.Pitch = FMath.Atan2(Z, FMath.Sqrt(X * X + Y * Y)) * (180f / (float)Math.PI);
		gSRotation.Roll = 0f;
		return gSRotation;
	}

	public GSRotation Rotation()
	{
		return ToOrientationRotator();
	}

	public GSLocation RotateAngleAxis(float AngleDeg, GSLocation Axis)
	{
		FMath.SinCos(out var scalarSin, out var scalarCos, FMath.DegreesToRadians(AngleDeg));
		float num = Axis.X * Axis.X;
		float num2 = Axis.Y * Axis.Y;
		float num3 = Axis.Z * Axis.Z;
		float num4 = Axis.X * Axis.Y;
		float num5 = Axis.Y * Axis.Z;
		float num6 = Axis.Z * Axis.X;
		float num7 = Axis.X * scalarSin;
		float num8 = Axis.Y * scalarSin;
		float num9 = Axis.Z * scalarSin;
		float num10 = 1f - scalarCos;
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.SetValue((num10 * num + scalarCos) * X + (num10 * num4 - num9) * Y + (num10 * num6 + num8) * Z, (num10 * num4 + num9) * X + (num10 * num2 + scalarCos) * Y + (num10 * num5 - num7) * Z, (num10 * num6 - num8) * X + (num10 * num5 + num7) * Y + (num10 * num3 + scalarCos) * Z);
		return gSLocation;
	}

	public bool Normalize(float Tolerance = 1E-08f)
	{
		float num = X * X + Y * Y + Z * Z;
		if (num > Tolerance)
		{
			float num2 = FMath.InvSqrt(num);
			X *= num2;
			Y *= num2;
			Z *= num2;
			return true;
		}
		return false;
	}

	public GSLocation GetSafeNormal(float tolerance = 1E-08f)
	{
		GSLocation gSLocation = GSLocationPool.New();
		float num = X * X + Y * Y + Z * Z;
		if (Math.Abs(num - 1f) < tolerance)
		{
			return this;
		}
		if (num < tolerance)
		{
			return gSLocation;
		}
		float num2 = FMath.InvSqrt(num);
		gSLocation.SetValue(X * num2, Y * num2, Z * num2);
		return gSLocation;
	}

	public GSLocation GetSafeNormal2D(float Tolerance = 1E-08f)
	{
		GSLocation gSLocation = GSLocationPool.New();
		float num = X * X + Y * Y;
		if (Math.Abs(num - 1f) < Tolerance)
		{
			if (Z == 0f)
			{
				return this;
			}
			gSLocation.SetValue(X, Y, 0f);
			return gSLocation;
		}
		if (num < Tolerance)
		{
			return gSLocation;
		}
		float num2 = FMath.InvSqrt(num);
		gSLocation.SetValue(X * num2, Y * num2, 0f);
		return gSLocation;
	}

	public float Size()
	{
		return FMath.Sqrt(X * X + Y * Y + Z * Z);
	}

	public float Size2D()
	{
		return FMath.Sqrt(X * X + Y * Y);
	}

	public float SizeSquared()
	{
		return X * X + Y * Y + Z * Z;
	}

	public static float Dist(GSLocation v1, GSLocation v2)
	{
		return FMath.Sqrt(DistSquared(v1, v2));
	}

	public static float Distance(GSLocation v1, GSLocation v2)
	{
		return Dist(v1, v2);
	}

	public static float DistXY(GSLocation v1, GSLocation v2)
	{
		return FMath.Sqrt(DistSquaredXY(v1, v2));
	}

	public static float Dist2D(GSLocation v1, GSLocation v2)
	{
		return DistXY(v1, v2);
	}

	public static float DistSquared(GSLocation v1, GSLocation v2)
	{
		return FMath.Square(v2.X - v1.X) + FMath.Square(v2.Y - v1.Y) + FMath.Square(v2.Z - v1.Z);
	}

	public static float DistSquaredXY(GSLocation v1, GSLocation v2)
	{
		return FMath.Square(v2.X - v1.X) + FMath.Square(v2.Y - v1.Y);
	}

	public static GSLocation CrossProduct(GSLocation a, GSLocation b)
	{
		CrossProduct(ref a, ref b, out a);
		return a;
	}

	public static GSLocation CrossProduct(ref GSLocation A, ref GSLocation B)
	{
		CrossProduct(ref A, ref B, out var Result);
		return Result;
	}

	public static void CrossProduct(ref GSLocation A, ref GSLocation b, out GSLocation Result)
	{
		Result = GSLocationPool.New();
		float x = A.Y * b.Z - A.Z * b.Y;
		float y = A.Z * b.X - A.X * b.Z;
		float z = A.X * b.Y - A.Y * b.X;
		Result.X = x;
		Result.Y = y;
		Result.Z = z;
	}

	public static float DotProduct(GSLocation A, FVector B)
	{
		return A.X * B.X + A.Y * B.Y + A.Z * B.Z;
	}

	public static float DotProduct(GSLocation A, GSLocation B)
	{
		return DotProduct(ref A, ref B);
	}

	public static float DotProductNormalize(GSLocation A, GSLocation B)
	{
		return DotProduct(A.GetSafeNormal(), B.GetSafeNormal());
	}

	public static float DotProduct(ref GSLocation A, ref GSLocation B)
	{
		DotProduct(ref A, ref B, out var Result);
		return Result;
	}

	public static void DotProduct(ref GSLocation A, ref GSLocation B, out float Result)
	{
		Result = A.X * B.X + A.Y * B.Y + A.Z * B.Z;
	}

	public FVector ToVector()
	{
		if (!bValueVectorMatch)
		{
			MappingVector = new FVector(X, Y, Z);
			bValueVectorMatch = true;
		}
		return MappingVector;
	}

	public override string ToString()
	{
		return $"X = {X:F3}\tY = {Y:F3}\tZ = {Z:F3}";
	}

	public void Dispose()
	{
		if (bCreateByPool)
		{
			GSLocationPool.Return(this);
		}
	}
}
