using System;
using System.Diagnostics;
using UnrealEngine.Runtime;

namespace b1;

public class GSRotation : IDisposable
{
	private float _pitch;

	private float _yaw;

	private float _roll;

	public float Pitch
	{
		get
		{
			return _pitch;
		}
		set
		{
			_pitch = value;
			bValueRotatorMatch = false;
		}
	}

	public float Yaw
	{
		get
		{
			return _yaw;
		}
		set
		{
			_yaw = value;
			bValueRotatorMatch = false;
		}
	}

	public float Roll
	{
		get
		{
			return _roll;
		}
		set
		{
			_roll = value;
			bValueRotatorMatch = false;
		}
	}

	private bool bValueRotatorMatch { get; set; }

	private FRotator MappingRotator { get; set; }

	private bool bCreateByPool { get; set; }

	public GSRotation()
	{
		MappingRotator = FRotator.ZeroRotator;
		bValueRotatorMatch = true;
	}

	public static GSRotation CreateByPool()
	{
		return new GSRotation
		{
			bCreateByPool = true
		};
	}

	public void SetValue(FRotator Rotation)
	{
		Pitch = Rotation.Pitch;
		Yaw = Rotation.Yaw;
		Roll = Rotation.Roll;
	}

	public void SetValue(GSRotation Rotation)
	{
		Pitch = Rotation.Pitch;
		Yaw = Rotation.Yaw;
		Roll = Rotation.Roll;
	}

	public void SetValue(float InPitch, float InYaw, float InRoll)
	{
		Pitch = InPitch;
		Yaw = InYaw;
		Roll = InRoll;
	}

	public static GSRotation operator +(GSRotation A, GSRotation B)
	{
		GSRotation gSRotation = new GSRotation();
		gSRotation.SetValue(A.Pitch + B.Pitch, A.Yaw + B.Yaw, A.Roll + B.Roll);
		return gSRotation;
	}

	public static GSRotation operator -(GSRotation A, GSRotation B)
	{
		return new GSRotation
		{
			Pitch = A.Pitch - B.Pitch,
			Yaw = A.Yaw - B.Yaw,
			Roll = A.Roll - B.Roll
		};
	}

	public static GSRotation operator *(GSRotation r, float Scale)
	{
		GSRotation gSRotation = new GSRotation();
		gSRotation.SetValue(r.Pitch * Scale, r.Yaw * Scale, r.Roll * Scale);
		return gSRotation;
	}

	public GSLocation Vector()
	{
		FMath.SinCos(out var scalarSin, out var scalarCos, FMath.DegreesToRadians(Pitch));
		FMath.SinCos(out var scalarSin2, out var scalarCos2, FMath.DegreesToRadians(Yaw));
		GSLocation gSLocation = GSLocationPool.New();
		gSLocation.SetValue(scalarCos * scalarCos2, scalarCos * scalarSin2, scalarSin);
		return gSLocation;
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN()
	{
		if (ContainsNaN())
		{
			FMath.LogOrEnsureNanError("GSRotation contains NaN: " + ToString());
			SetValue(FRotator.ZeroRotator);
		}
	}

	public bool ContainsNaN()
	{
		if (FMath.IsFinite(Pitch) && FMath.IsFinite(Yaw))
		{
			return !FMath.IsFinite(Roll);
		}
		return true;
	}

	public GSRotation Add(float deltaPitch, float deltaYaw, float deltaRoll)
	{
		Yaw += deltaYaw;
		Pitch += deltaPitch;
		Roll += deltaRoll;
		return this;
	}

	public bool IsNearlyZero(float Tolerance = 0.0001f)
	{
		if (FMath.Abs(FRotator.NormalizeAxis(Pitch)) <= Tolerance && FMath.Abs(FRotator.NormalizeAxis(Yaw)) <= Tolerance)
		{
			return FMath.Abs(FRotator.NormalizeAxis(Roll)) <= Tolerance;
		}
		return false;
	}

	public GSRotation Clamp()
	{
		FRotator.ClampAxis(Pitch);
		FRotator.ClampAxis(Yaw);
		FRotator.ClampAxis(Roll);
		return this;
	}

	public GSRotation Normalize()
	{
		Pitch = FRotator.NormalizeAxis(Pitch);
		Yaw = FRotator.NormalizeAxis(Yaw);
		Roll = FRotator.NormalizeAxis(Roll);
		return this;
	}

	public GSRotation GetNormalized()
	{
		Normalize();
		return this;
	}

	public FRotator ToRotator()
	{
		if (!bValueRotatorMatch)
		{
			MappingRotator = new FRotator(Pitch, Yaw, Roll);
			bValueRotatorMatch = true;
		}
		return MappingRotator;
	}

	public void Dispose()
	{
		if (bCreateByPool)
		{
			GSRotationPool.Return(this);
		}
	}

	public override string ToString()
	{
		return $"Pitch:{Pitch:F3}\t Yaw:{Yaw:F3}\t Roll:{Roll:F3}";
	}
}
