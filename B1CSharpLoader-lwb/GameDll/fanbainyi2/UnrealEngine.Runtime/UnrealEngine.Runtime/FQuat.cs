using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[Serializable]
[UStruct(Flags = 4219960)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Quat", "CoreUObject", UnrealModuleType.Engine)]
public struct FQuat : IEquatable<FQuat>
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Quat:X")]
	public double mX;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Quat:Y")]
	public double mY;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Quat:Z")]
	public double mZ;

	private static bool W_IsValid;

	private static int W_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Quat:W")]
	public double mW;

	private static int FQuat_StructSize;

	public static readonly FQuat Identity;

	public float X
	{
		get
		{
			return (float)mX;
		}
		set
		{
			mX = value;
		}
	}

	public float Y
	{
		get
		{
			return (float)mY;
		}
		set
		{
			mY = value;
		}
	}

	public float Z
	{
		get
		{
			return (float)mZ;
		}
		set
		{
			mZ = value;
		}
	}

	public float W
	{
		get
		{
			return (float)mW;
		}
		set
		{
			mW = value;
		}
	}

	public FQuat Copy()
	{
		return this;
	}

	static FQuat()
	{
		Identity = new FQuat(0.0, 0.0, 0.0, 1.0);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Quat");
		FQuat_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mX");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mX", Classes.FDoubleProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mY");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mY", Classes.FDoubleProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mZ");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mZ", Classes.FDoubleProperty);
		W_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mW");
		W_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mW", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FQuat));
	}

	public FQuat(double x, double y, double z, double w)
	{
		mX = x;
		mY = y;
		mZ = z;
		mW = w;
	}

	public FQuat(FQuat q)
	{
		mX = q.mX;
		mY = q.mY;
		mZ = q.mZ;
		mW = q.mW;
	}

	public FQuat(FMatrix m)
	{
		if (m.GetScaledAxis(EAxis.X).IsNearlyZero() || m.GetScaledAxis(EAxis.Y).IsNearlyZero() || m.GetScaledAxis(EAxis.Z).IsNearlyZero())
		{
			this = Identity;
			return;
		}
		if (!FMessage.Ensure(FMath.Abs(1.0 - m.GetScaledAxis(EAxis.X).SizeSquared()) <= 9.999999747378752E-05 && FMath.Abs(1.0 - m.GetScaledAxis(EAxis.Y).SizeSquared()) <= 9.999999747378752E-05 && FMath.Abs(1.0 - m.GetScaledAxis(EAxis.Z).SizeSquared()) <= 9.999999747378752E-05, "Make sure the Rotation part of the Matrix is unit length."))
		{
			this = Identity;
			return;
		}
		double num = m[0, 0] + m[1, 1] + m[2, 2];
		double num3;
		if (num > 0.0)
		{
			double num2 = FMath.InvSqrt(num + 1.0);
			mW = 0.5 * (1.0 / num2);
			num3 = 0.5 * num2;
			mX = (m[1, 2] - m[2, 1]) * num3;
			mY = (m[2, 0] - m[0, 2]) * num3;
			mZ = (m[0, 1] - m[1, 0]) * num3;
			return;
		}
		int num4 = 0;
		if (m[1, 1] > m[0, 0])
		{
			num4 = 1;
		}
		if (m[2, 2] > m[num4, num4])
		{
			num4 = 2;
		}
		int[] obj = new int[3] { 1, 2, 0 };
		int num5 = obj[num4];
		int num6 = obj[num5];
		num3 = m[num4, num4] - m[num5, num5] - m[num6, num6] + 1.0;
		double num7 = FMath.InvSqrt(num3);
		double[] array = new double[4];
		array[num4] = 0.5 * (1.0 / num7);
		num3 = 0.5 * num7;
		array[3] = (m[num5, num6] - m[num6, num5]) * num3;
		array[num5] = (m[num4, num5] + m[num5, num4]) * num3;
		array[num6] = (m[num4, num6] + m[num6, num4]) * num3;
		mX = array[0];
		mY = array[1];
		mZ = array[2];
		mW = array[3];
	}

	public FQuat(FRotator r)
	{
		this = r.Quaternion();
	}

	public FQuat(FVector axis, double angleRad)
	{
		double value = 0.5 * angleRad;
		FMath.SinCos(out var scalarSin, out var scalarCos, value);
		mX = scalarSin * axis.mX;
		mY = scalarSin * axis.mY;
		mZ = scalarSin * axis.mZ;
		mW = scalarCos;
	}

	public static FQuat operator +(FQuat a, FQuat b)
	{
		a.X += b.X;
		a.Y += b.Y;
		a.Z += b.Z;
		a.W += b.W;
		return a;
	}

	public static FQuat operator -(FQuat a, FQuat b)
	{
		a.X -= b.X;
		a.Y -= b.Y;
		a.Z -= b.Z;
		a.W -= b.W;
		return a;
	}

	public static FQuat operator *(FQuat a, FQuat b)
	{
		FQuat result = default(FQuat);
		float x = a.X;
		float y = a.Y;
		float z = a.Z;
		float w = a.W;
		float x2 = b.X;
		float y2 = b.Y;
		float z2 = b.Z;
		float w2 = b.W;
		float num = y * z2 - z * y2;
		float num2 = z * x2 - x * z2;
		float num3 = x * y2 - y * x2;
		float num4 = x * x2 + y * y2 + z * z2;
		result.X = x * w2 + x2 * w + num;
		result.Y = y * w2 + y2 * w + num2;
		result.Z = z * w2 + z2 * w + num3;
		result.W = w * w2 - num4;
		return result;
	}

	public static FQuat operator *(float scale, FQuat q)
	{
		return q * scale;
	}

	public static FQuat operator *(FQuat q, float scale)
	{
		q.X *= scale;
		q.Y *= scale;
		q.Z *= scale;
		q.W *= scale;
		return q;
	}

	public static FQuat operator /(float scale, FQuat q)
	{
		return q / scale;
	}

	public static FQuat operator /(FQuat q, float scale)
	{
		float num = 1f / scale;
		q.X *= num;
		q.Y *= num;
		q.Z *= num;
		q.W *= num;
		return q;
	}

	public static FQuat operator /(FQuat a, FQuat b)
	{
		FQuat result = default(FQuat);
		float x = a.X;
		float y = a.Y;
		float z = a.Z;
		float w = a.W;
		float num = b.X * b.X + b.Y * b.Y + b.Z * b.Z + b.W * b.W;
		float num2 = 1f / num;
		float num3 = (0f - b.X) * num2;
		float num4 = (0f - b.Y) * num2;
		float num5 = (0f - b.Z) * num2;
		float num6 = b.W * num2;
		float num7 = y * num5 - z * num4;
		float num8 = z * num3 - x * num5;
		float num9 = x * num4 - y * num3;
		float num10 = x * num3 + y * num4 + z * num5;
		result.X = x * num6 + num3 * w + num7;
		result.Y = y * num6 + num4 * w + num8;
		result.Z = z * num6 + num5 * w + num9;
		result.W = w * num6 - num10;
		return result;
	}

	public static FVector operator *(FQuat q, FVector v)
	{
		return q.RotateVector(v);
	}

	public static FMatrix operator *(FQuat q, FMatrix m)
	{
		FMatrix result = default(FMatrix);
		FQuat fQuat = q.Inverse();
		for (int i = 0; i < 4; i++)
		{
			FQuat fQuat2 = new FQuat(m[i, 0], m[i, 1], m[i, 2], m[i, 3]);
			FQuat fQuat3 = q * fQuat2 * fQuat;
			result[i, 0] = fQuat3.X;
			result[i, 1] = fQuat3.Y;
			result[i, 2] = fQuat3.Z;
			result[i, 3] = fQuat3.W;
		}
		return result;
	}

	public static float operator |(FQuat a, FQuat b)
	{
		return a.X * b.X + a.Y * b.Y + a.Z * b.Z + a.W * b.W;
	}

	public static bool operator ==(FQuat a, FQuat b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W == b.W;
		}
		return false;
	}

	public static bool operator !=(FQuat a, FQuat b)
	{
		if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
		{
			return a.W != b.W;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FQuat))
		{
			return false;
		}
		return Equals((FQuat)obj);
	}

	public bool Equals(FQuat other)
	{
		if (X == other.X && Y == other.Y && Z == other.Z)
		{
			return W == other.W;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((X.GetHashCode() * 397) ^ Y.GetHashCode()) * 397) ^ Z.GetHashCode()) * 397) ^ W.GetHashCode();
	}

	public bool Equals(FQuat other, double tolerance = 9.999999747378752E-05)
	{
		if (!((double)FMath.Abs(X - other.X) <= tolerance) || !((double)FMath.Abs(Y - other.Y) <= tolerance) || !((double)FMath.Abs(Z - other.Z) <= tolerance) || !((double)FMath.Abs(W - other.W) <= tolerance))
		{
			if ((double)FMath.Abs(X + other.X) <= tolerance && (double)FMath.Abs(Y + other.Y) <= tolerance && (double)FMath.Abs(Z + other.Z) <= tolerance)
			{
				return (double)FMath.Abs(W + other.W) <= tolerance;
			}
			return false;
		}
		return true;
	}

	public bool IsIdentity(double tolerance = 9.99999993922529E-09)
	{
		return Equals(Identity, tolerance);
	}

	public static FQuat MakeFromEuler(FVector euler)
	{
		return FRotator.MakeFromEuler(euler).Quaternion();
	}

	public FVector Euler()
	{
		return Rotator().Euler();
	}

	public void Normalize(float tolerance = 1E-08f)
	{
		float num = X * X + Y * Y + Z * Z + W * W;
		if (num >= tolerance)
		{
			float num2 = FMath.InvSqrt(num);
			X *= num2;
			Y *= num2;
			Z *= num2;
			W *= num2;
		}
		else
		{
			this = Identity;
		}
	}

	public FQuat GetNormalized(float tolerance = 1E-08f)
	{
		FQuat result = this;
		result.Normalize(tolerance);
		return result;
	}

	public bool IsNormalized()
	{
		return FMath.Abs(1.0 - SizeSquared()) < 0.009999999776482582;
	}

	public double Size()
	{
		return FMath.Sqrt(X * X + Y * Y + Z * Z + W * W);
	}

	public double SizeSquared()
	{
		return X * X + Y * Y + Z * Z + W * W;
	}

	public double GetAngle()
	{
		return 2.0 * (double)FMath.Acos(W);
	}

	public void ToAxisAndAngle(out FVector axis, out double angle)
	{
		angle = GetAngle();
		axis = GetRotationAxis();
	}

	public void ToSwingTwist(FVector twistAxis, out FQuat swing, out FQuat twist)
	{
		FVector fVector = FVector.DotProduct(twistAxis, new FVector(X, Y, Z)) * twistAxis;
		twist = new FQuat(fVector.X, fVector.Y, fVector.Z, W);
		if (twist.SizeSquared() == 0.0)
		{
			twist = Identity;
		}
		else
		{
			twist.Normalize();
		}
		swing = this * twist.Inverse();
	}

	public FVector RotateVector(FVector v)
	{
		FVector a = new FVector(X, Y, Z);
		FVector fVector = 2.0 * FVector.CrossProduct(a, v);
		return v + W * fVector + FVector.CrossProduct(a, fVector);
	}

	public FVector UnrotateVector(FVector v)
	{
		FVector a = new FVector(0f - X, 0f - Y, 0f - Z);
		FVector fVector = 2.0 * FVector.CrossProduct(a, v);
		return v + W * fVector + FVector.CrossProduct(a, fVector);
	}

	public FQuat Log()
	{
		FQuat result = new FQuat
		{
			W = 0f
		};
		if (FMath.Abs(W) < 1f)
		{
			float num = FMath.Acos(W);
			float num2 = FMath.Sin(num);
			if (FMath.Abs(num2) >= 1E-08f)
			{
				float num3 = num / num2;
				result.X = num3 * X;
				result.Y = num3 * Y;
				result.Z = num3 * Z;
				return result;
			}
		}
		result.X = X;
		result.Y = Y;
		result.Z = Z;
		return result;
	}

	public FQuat Exp()
	{
		float num = FMath.Sqrt(X * X + Y * Y + Z * Z);
		float num2 = FMath.Sin(num);
		FQuat result = new FQuat
		{
			W = FMath.Cos(num)
		};
		if (FMath.Abs(num2) >= 1E-08f)
		{
			float num3 = num2 / num;
			result.X = num3 * X;
			result.Y = num3 * Y;
			result.Z = num3 * Z;
		}
		else
		{
			result.X = X;
			result.Y = Y;
			result.Z = Z;
		}
		return result;
	}

	public FQuat Inverse()
	{
		return new FQuat(0f - X, 0f - Y, 0f - Z, W);
	}

	public void EnforceShortestArcWith(FQuat other)
	{
		float num = FMath.FloatSelect(other | this, 1f, -1f);
		X *= num;
		Y *= num;
		Z *= num;
		W *= num;
	}

	public FVector GetAxisX()
	{
		return RotateVector(new FVector(1.0, 0.0, 0.0));
	}

	public FVector GetAxisY()
	{
		return RotateVector(new FVector(0.0, 1.0, 0.0));
	}

	public FVector GetAxisZ()
	{
		return RotateVector(new FVector(0.0, 0.0, 1.0));
	}

	public FVector GetForwardVector()
	{
		return GetAxisX();
	}

	public FVector GetRightVector()
	{
		return GetAxisY();
	}

	public FVector GetUpVector()
	{
		return GetAxisZ();
	}

	public FVector Vector()
	{
		return GetAxisX();
	}

	public FRotator Rotator()
	{
		float num = Z * X - W * Y;
		float y = 2f * (W * Z + X * Y);
		float x = 1f - 2f * (FMath.Square(Y) + FMath.Square(Z));
		FRotator result = default(FRotator);
		if (num < -0.4999995f)
		{
			result.Pitch = -90f;
			result.Yaw = FMath.Atan2(y, x) * (180f / (float)Math.PI);
			result.Roll = FRotator.NormalizeAxis(0f - result.Yaw - 2f * FMath.Atan2(X, W) * (180f / (float)Math.PI));
		}
		else if (num > 0.4999995f)
		{
			result.Pitch = 90f;
			result.Yaw = FMath.Atan2(y, x) * (180f / (float)Math.PI);
			result.Roll = FRotator.NormalizeAxis(result.Yaw - 2f * FMath.Atan2(X, W) * (180f / (float)Math.PI));
		}
		else
		{
			result.Pitch = FMath.FastAsin(2f * num) * (180f / (float)Math.PI);
			result.Yaw = FMath.Atan2(y, x) * (180f / (float)Math.PI);
			result.Roll = FMath.Atan2(-2f * (W * X + Y * Z), 1f - 2f * (FMath.Square(X) + FMath.Square(Y))) * (180f / (float)Math.PI);
		}
		return result;
	}

	public FVector GetRotationAxis()
	{
		double num = FMath.Sqrt(FMath.Max(1f - W * W, 0f));
		if (num >= 9.999999747378752E-05)
		{
			return new FVector((double)X / num, (double)Y / num, (double)Z / num);
		}
		return new FVector(1.0, 0.0, 0.0);
	}

	public double AngularDistance(FQuat q)
	{
		double num = X * q.X + Y * q.Y + Z * q.Z + W * q.W;
		return FMath.Acos(2.0 * num * num - 1.0);
	}

	public bool ContainsNaN()
	{
		if (FMath.IsFinite(X) && FMath.IsFinite(Y) && FMath.IsFinite(Z))
		{
			return !FMath.IsFinite(W);
		}
		return true;
	}

	public override string ToString()
	{
		return "X=" + X + " Y=" + Y + " Z=" + Z + " W=" + W;
	}

	public bool InitFromString(string sourceString)
	{
		float num = (Z = 0f);
		float x = (Y = num);
		X = x;
		W = 1f;
		if (FParse.Value(sourceString, "X=", ref mX) && FParse.Value(sourceString, "Y=", ref mY) && FParse.Value(sourceString, "Z=", ref mZ))
		{
			return FParse.Value(sourceString, "W=", ref mW);
		}
		return false;
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN()
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError("FQuat contains NaN: " + ToString());
			this = Identity;
		}
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN(string message)
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError(message + ": FQuat contains NaN: " + ToString());
			this = Identity;
		}
	}

	private static FQuat FindBetween_Helper(FVector a, FVector b, double normAB)
	{
		double num = normAB + (double)FVector.DotProduct(a, b);
		FQuat result;
		if (num >= 9.999999974752427E-07 * normAB)
		{
			result = new FQuat(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X, num);
		}
		else
		{
			num = 0.0;
			result = ((FMath.Abs(a.X) > FMath.Abs(a.Y)) ? new FQuat(0f - a.Z, 0.0, a.X, num) : new FQuat(0.0, 0f - a.Z, a.Y, num));
		}
		result.Normalize();
		return result;
	}

	public static FQuat FindBetween(FVector vector1, FVector vector2)
	{
		return FindBetweenVectors(vector1, vector2);
	}

	public static FQuat FindBetweenNormals(FVector normal1, FVector normal2)
	{
		return FindBetween_Helper(normal1, normal2, 1.0);
	}

	public static FQuat FindBetweenVectors(FVector vector1, FVector vector2)
	{
		double normAB = FMath.Sqrt(vector1.SizeSquared() * vector2.SizeSquared());
		return FindBetween_Helper(vector1, vector2, normAB);
	}

	public static double Error(FQuat q1, FQuat q2)
	{
		double value = FMath.Abs(q1.X * q2.X + q1.Y * q2.Y + q1.Z * q2.Z + q1.W * q2.W);
		if (!(FMath.Abs(value) < 0.9999998807907104))
		{
			return 0.0;
		}
		return FMath.Acos(value) * 0.31830987334251404;
	}

	public static double ErrorAutoNormalize(FQuat a, FQuat b)
	{
		FQuat q = a;
		q.Normalize();
		FQuat q2 = b;
		q2.Normalize();
		return Error(q, q2);
	}

	public static FQuat FastLerp(FQuat a, FQuat b, float alpha)
	{
		float num = FMath.FloatSelect(a | b, 1f, -1f);
		return b * alpha + a * (num * (1f - alpha));
	}

	public static FQuat FastBilerp(FQuat p00, FQuat p10, FQuat p01, FQuat p11, float fracX, float fracY)
	{
		return FastLerp(FastLerp(p00, p10, fracX), FastLerp(p01, p11, fracX), fracY);
	}

	public static FQuat Slerp_NotNormalized(FQuat quat1, FQuat quat2, float slerp)
	{
		float num = quat1.X * quat2.X + quat1.Y * quat2.Y + quat1.Z * quat2.Z + quat1.W * quat2.W;
		float num2 = FMath.FloatSelect(num, num, 0f - num);
		float num5;
		float num6;
		if (num2 < 0.9999f)
		{
			float num3 = FMath.Acos(num2);
			float num4 = 1f / FMath.Sin(num3);
			num5 = FMath.Sin((1f - slerp) * num3) * num4;
			num6 = FMath.Sin(slerp * num3) * num4;
		}
		else
		{
			num5 = 1f - slerp;
			num6 = slerp;
		}
		num6 = FMath.FloatSelect(num, num6, 0f - num6);
		return new FQuat
		{
			X = num5 * quat1.X + num6 * quat2.X,
			Y = num5 * quat1.Y + num6 * quat2.Y,
			Z = num5 * quat1.Z + num6 * quat2.Z,
			W = num5 * quat1.W + num6 * quat2.W
		};
	}

	public static FQuat Slerp(FQuat Quat1, FQuat Quat2, float Slerp)
	{
		return Slerp_NotNormalized(Quat1, Quat2, Slerp).GetNormalized();
	}

	public static FQuat SlerpFullPath_NotNormalized(FQuat quat1, FQuat quat2, float alpha)
	{
		float num = FMath.Acos(FMath.Clamp(quat1 | quat2, -1f, 1f));
		if (FMath.Abs(num) < 0.0001f)
		{
			return quat1;
		}
		float num2 = FMath.Sin(num);
		float num3 = 1f / num2;
		float num4 = FMath.Sin((1f - alpha) * num) * num3;
		float num5 = FMath.Sin(alpha * num) * num3;
		return quat1 * num4 + quat2 * num5;
	}

	public static FQuat SlerpFullPath(FQuat quat1, FQuat quat2, float alpha)
	{
		return SlerpFullPath_NotNormalized(quat1, quat2, alpha).GetNormalized();
	}

	public static FQuat Squad(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float alpha)
	{
		FQuat quat3 = Slerp_NotNormalized(quat1, quat2, alpha);
		FQuat quat4 = SlerpFullPath_NotNormalized(tang1, tang2, alpha);
		return SlerpFullPath(quat3, quat4, 2f * alpha * (1f - alpha));
	}

	public static FQuat SquadFullPath(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float alpha)
	{
		FQuat quat3 = SlerpFullPath_NotNormalized(quat1, quat2, alpha);
		FQuat quat4 = SlerpFullPath_NotNormalized(tang1, tang2, alpha);
		return SlerpFullPath(quat3, quat4, 2f * alpha * (1f - alpha));
	}

	public static void CalcTangents(FQuat prevP, FQuat p, FQuat nextP, double tension, out FQuat tan)
	{
		FQuat fQuat = p.Inverse();
		FQuat fQuat2 = (fQuat * prevP).Log();
		FQuat fQuat3 = (fQuat * nextP).Log();
		FQuat fQuat4 = (fQuat2 + fQuat3) * -0.5f;
		tan = p * fQuat4.Exp();
	}

	public static FQuat Lerp(FQuat a, FQuat b, float alpha)
	{
		return Slerp(a, b, alpha);
	}

	public static FQuat BiLerp(FQuat p00, FQuat p10, FQuat p01, FQuat p11, float fracX, float fracY)
	{
		return Lerp(Slerp_NotNormalized(p00, p10, fracX), Slerp_NotNormalized(p01, p11, fracX), fracY);
	}

	public static FQuat CubicInterp(FQuat p0, FQuat t0, FQuat p1, FQuat t1, float a)
	{
		return Squad(p0, t0, p1, t1, a);
	}
}
