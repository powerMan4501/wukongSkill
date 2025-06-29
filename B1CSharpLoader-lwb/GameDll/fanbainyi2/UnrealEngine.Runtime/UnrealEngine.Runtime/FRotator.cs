using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4254776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Rotator", "CoreUObject", UnrealModuleType.Engine)]
public struct FRotator : IEquatable<FRotator>
{
	private static bool Pitch_IsValid;

	private static int Pitch_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Rotator:Pitch")]
	public double mPitch;

	private static bool Yaw_IsValid;

	private static int Yaw_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Rotator:Yaw")]
	public double mYaw;

	private static bool Roll_IsValid;

	private static int Roll_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.Rotator:Roll")]
	public double mRoll;

	private static int FRotator_StructSize;

	public static readonly FRotator ZeroRotator;

	public float Pitch
	{
		get
		{
			return (float)mPitch;
		}
		set
		{
			mPitch = value;
		}
	}

	public float Yaw
	{
		get
		{
			return (float)mYaw;
		}
		set
		{
			mYaw = value;
		}
	}

	public float Roll
	{
		get
		{
			return (float)mRoll;
		}
		set
		{
			mRoll = value;
		}
	}

	public FRotator Copy()
	{
		return this;
	}

	static FRotator()
	{
		ZeroRotator = new FRotator(0.0, 0.0, 0.0);
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRotator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRotator));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Rotator");
		FRotator_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Pitch_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mPitch");
		Pitch_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mPitch", Classes.FDoubleProperty);
		Yaw_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mYaw");
		Yaw_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mYaw", Classes.FDoubleProperty);
		Roll_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mRoll");
		Roll_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mRoll", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FRotator));
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN()
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError("FRotator contains NaN: " + ToString());
			this = ZeroRotator;
		}
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN(string message)
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError(message + ": FRotator contains NaN: " + ToString());
			this = ZeroRotator;
		}
	}

	public FRotator(double f)
	{
		mPitch = f;
		mYaw = f;
		mRoll = f;
	}

	public FRotator(double pitch, double yaw, double roll)
	{
		mPitch = pitch;
		mYaw = yaw;
		mRoll = roll;
	}

	public FRotator(FQuat quat)
	{
		this = quat.Rotator();
	}

	public static FRotator operator +(FRotator a, FRotator b)
	{
		return new FRotator(a.Pitch + b.Pitch, a.Yaw + b.Yaw, a.Roll + b.Roll);
	}

	public static FRotator operator -(FRotator a, FRotator b)
	{
		return new FRotator(a.Pitch - b.Pitch, a.Yaw - b.Yaw, a.Roll - b.Roll);
	}

	public static FRotator operator *(double scale, FRotator r)
	{
		return r * scale;
	}

	public static FRotator operator *(FRotator r, double scale)
	{
		return new FRotator((double)r.Pitch * scale, (double)r.Yaw * scale, (double)r.Roll * scale);
	}

	public static bool operator ==(FRotator a, FRotator b)
	{
		if (a.Pitch == b.Pitch && a.Yaw == b.Yaw)
		{
			return a.Roll == b.Roll;
		}
		return false;
	}

	public static bool operator !=(FRotator a, FRotator b)
	{
		if (a.Pitch == b.Pitch && a.Yaw == b.Yaw)
		{
			return a.Roll == b.Roll;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FRotator))
		{
			return false;
		}
		return Equals((FRotator)obj);
	}

	public bool Equals(FRotator other)
	{
		if (Pitch == other.Pitch && Yaw == other.Yaw)
		{
			return Roll == other.Roll;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Pitch.GetHashCode() * 397) ^ Yaw.GetHashCode()) * 397) ^ Roll.GetHashCode();
	}

	public bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
	{
		if ((double)FMath.Abs(NormalizeAxis(Pitch)) <= tolerance && (double)FMath.Abs(NormalizeAxis(Yaw)) <= tolerance)
		{
			return (double)FMath.Abs(NormalizeAxis(Roll)) <= tolerance;
		}
		return false;
	}

	public bool IsZero()
	{
		if (ClampAxis(Pitch) == 0f && ClampAxis(Yaw) == 0f)
		{
			return ClampAxis(Roll) == 0f;
		}
		return false;
	}

	public bool Equals(FRotator other, double tolerance = 9.999999747378752E-05)
	{
		if ((double)FMath.Abs(NormalizeAxis(Pitch - other.Pitch)) <= tolerance && (double)FMath.Abs(NormalizeAxis(Yaw - other.Yaw)) <= tolerance)
		{
			return (double)FMath.Abs(NormalizeAxis(Roll - other.Roll)) <= tolerance;
		}
		return false;
	}

	public FRotator Add(double deltaPitch, double deltaYaw, double deltaRoll)
	{
		mYaw += deltaYaw;
		mPitch += deltaPitch;
		mRoll += deltaRoll;
		return this;
	}

	public FRotator GetInverse()
	{
		return Quaternion().Inverse().Rotator();
	}

	public FRotator GridSnap(FRotator rotGrid)
	{
		return new FRotator(FMath.GridSnap(Pitch, rotGrid.Pitch), FMath.GridSnap(Yaw, rotGrid.Yaw), FMath.GridSnap(Roll, rotGrid.Roll));
	}

	public FVector Vector()
	{
		FMath.SinCos(out double scalarSin, out double scalarCos, (double)FMath.DegreesToRadians(Pitch));
		FMath.SinCos(out double scalarSin2, out double scalarCos2, (double)FMath.DegreesToRadians(Yaw));
		return new FVector(scalarCos * scalarCos2, scalarCos * scalarSin2, scalarSin);
	}

	public FQuat Quaternion()
	{
		float num = (float)Math.PI / 180f / 2f;
		FMath.SinCos(out var scalarSin, out var scalarCos, Pitch * num);
		FMath.SinCos(out var scalarSin2, out var scalarCos2, Yaw * num);
		FMath.SinCos(out var scalarSin3, out var scalarCos3, Roll * num);
		return new FQuat
		{
			X = scalarCos3 * scalarSin * scalarSin2 - scalarSin3 * scalarCos * scalarCos2,
			Y = (0f - scalarCos3) * scalarSin * scalarCos2 - scalarSin3 * scalarCos * scalarSin2,
			Z = scalarCos3 * scalarCos * scalarSin2 - scalarSin3 * scalarSin * scalarCos2,
			W = scalarCos3 * scalarCos * scalarCos2 + scalarSin3 * scalarSin * scalarSin2
		};
	}

	public FVector Euler()
	{
		return new FVector(Roll, Pitch, Yaw);
	}

	public FVector RotateVector(FVector v)
	{
		return FMatrix.CreateRotation(this).TransformVector(v);
	}

	public FVector UnrotateVector(FVector v)
	{
		return FMatrix.CreateRotation(this).GetTransposed().TransformVector(v);
	}

	public FRotator Clamp()
	{
		return new FRotator(ClampAxis(Pitch), ClampAxis(Yaw), ClampAxis(Roll));
	}

	public FRotator GetNormalized()
	{
		FRotator result = this;
		result.Normalize();
		return result;
	}

	public FRotator GetDenormalized()
	{
		FRotator result = this;
		result.Pitch = ClampAxis(result.Pitch);
		result.Yaw = ClampAxis(result.Yaw);
		result.Roll = ClampAxis(result.Roll);
		return result;
	}

	public double GetComponentForAxis(EAxis axis)
	{
		return axis switch
		{
			EAxis.X => Roll, 
			EAxis.Y => Pitch, 
			EAxis.Z => Yaw, 
			_ => 0.0, 
		};
	}

	public void SetComponentForAxis(EAxis axis, float component)
	{
		switch (axis)
		{
		case EAxis.X:
			Roll = component;
			break;
		case EAxis.Y:
			Pitch = component;
			break;
		case EAxis.Z:
			Yaw = component;
			break;
		}
	}

	public void Normalize()
	{
		Pitch = NormalizeAxis(Pitch);
		Yaw = NormalizeAxis(Yaw);
		Roll = NormalizeAxis(Roll);
	}

	public void GetWindingAndRemainder(out FRotator winding, out FRotator remainder)
	{
		winding = default(FRotator);
		remainder = default(FRotator);
		remainder.Yaw = NormalizeAxis(Yaw);
		winding.Yaw = Yaw - remainder.Yaw;
		remainder.Pitch = NormalizeAxis(Pitch);
		winding.Pitch = Pitch - remainder.Pitch;
		remainder.Roll = NormalizeAxis(Roll);
		winding.Roll = Roll - remainder.Roll;
	}

	public double GetManhattanDistance(FRotator rotator)
	{
		return FMath.Abs(Yaw - rotator.Yaw) + FMath.Abs(Pitch - rotator.Pitch) + FMath.Abs(Roll - rotator.Roll);
	}

	public FRotator GetEquivalentRotator()
	{
		return new FRotator(180f - Pitch, Yaw + 180f, Roll + 180f);
	}

	public void SetClosestToMe(ref FRotator makeClosest)
	{
		FRotator equivalentRotator = makeClosest.GetEquivalentRotator();
		double manhattanDistance = GetManhattanDistance(makeClosest);
		if (GetManhattanDistance(equivalentRotator) < manhattanDistance)
		{
			makeClosest = equivalentRotator;
		}
	}

	public override string ToString()
	{
		return "P=" + Pitch + " Y=" + Yaw + " R=" + Roll;
	}

	public string ToCompactString()
	{
		string text = "0.00";
		if (IsNearlyZero())
		{
			return "R(0)";
		}
		string text2 = "R(";
		bool flag = true;
		if (!FMath.IsNearlyZero(Pitch))
		{
			text2 = text2 + "P=" + Pitch.ToString(text);
			flag = false;
		}
		if (!FMath.IsNearlyZero(Yaw))
		{
			if (!flag)
			{
				text2 += ", ";
			}
			text2 = text2 + "Y=" + Yaw.ToString(text);
			flag = false;
		}
		if (!FMath.IsNearlyZero(Roll))
		{
			if (!flag)
			{
				text2 += ", ";
			}
			text2 = text2 + "R=" + Roll.ToString(text);
			flag = false;
		}
		return text2 + ")";
	}

	public bool InitFromString(string sourceString)
	{
		float num = (Roll = 0f);
		float pitch = (Yaw = num);
		Pitch = pitch;
		if (FParse.Value(sourceString, "P=", ref mPitch) && FParse.Value(sourceString, "Y=", ref mYaw))
		{
			return FParse.Value(sourceString, "R=", ref mRoll);
		}
		return false;
	}

	public bool ContainsNaN()
	{
		if (FMath.IsFinite(Pitch) && FMath.IsFinite(Yaw))
		{
			return !FMath.IsFinite(Roll);
		}
		return true;
	}

	public static float ClampAxis(float angle)
	{
		angle = FMath.Fmod(angle, 360f);
		if (angle < 0f)
		{
			angle += 360f;
		}
		return angle;
	}

	public static double ClampAxis(double angle)
	{
		angle = FMath.Dmod(angle, 360.0);
		if (angle < 0.0)
		{
			angle += 360.0;
		}
		return angle;
	}

	public static float NormalizeAxis(float angle)
	{
		angle = ClampAxis(angle);
		if (angle > 180f)
		{
			angle -= 360f;
		}
		return angle;
	}

	public static double NormalizeAxis(double angle)
	{
		angle = ClampAxis(angle);
		if (angle > 180.0)
		{
			angle -= 360.0;
		}
		return angle;
	}

	public static byte CompressAxisToByte(double angle)
	{
		return (byte)(FMath.RoundToInt(angle * 256.0 / 360.0) & 0xFF);
	}

	public static double DecompressAxisFromByte(byte angle)
	{
		return (float)(int)angle * 360f / 256f;
	}

	public static ushort CompressAxisToShort(double angle)
	{
		return (ushort)(FMath.RoundToInt(angle * 65536.0 / 360.0) & 0xFFFF);
	}

	public static double DecompressAxisFromShort(ushort angle)
	{
		return (float)(int)angle * 360f / 65536f;
	}

	public static FRotator MakeFromEuler(FVector euler)
	{
		return new FRotator(euler.Y, euler.Z, euler.X);
	}

	public static FRotator Lerp(FRotator a, FRotator b, double alpha)
	{
		return FMath.Lerp(a, b, alpha);
	}

	public static FRotator LerpRange(FRotator a, FRotator b, double alpha)
	{
		return FMath.LerpRange(a, b, alpha);
	}
}
