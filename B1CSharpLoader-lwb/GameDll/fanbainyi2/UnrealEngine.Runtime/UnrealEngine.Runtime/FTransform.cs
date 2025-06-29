using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 16)]
[UStruct(Flags = 24584)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Transform", "CoreUObject", UnrealModuleType.Engine)]
public struct FTransform : IEquatable<FTransform>
{
	private const string logTransform = "LogTransform";

	private const double ZeroAnimWeightThresh = 1E-05;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)4503669437366277uL)]
	[UMetaPath("/Script/CoreUObject.Transform:Rotation")]
	public FQuat Rotation;

	private static bool Translation_IsValid;

	private static int Translation_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.Transform:Translation")]
	public FVector Translation;

	private double SIMDAlign0;

	private static bool Scale3D_IsValid;

	private static int Scale3D_Offset;

	[UProperty(Flags = (PropFlags)6755469251051525uL)]
	[UMetaPath("/Script/CoreUObject.Transform:Scale3D")]
	public FVector Scale3D;

	private double SIMDAlign1;

	private static int FTransform_StructSize;

	public static readonly FTransform Identity;

	public static readonly FTransform Default;

	public FTransform Copy()
	{
		return this;
	}

	static FTransform()
	{
		Identity = new FTransform(new FQuat(0.0, 0.0, 0.0, 1.0), new FVector(0f), new FVector(1f));
		Default = Identity;
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Transform");
		FTransform_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Rotation", Classes.FStructProperty);
		Translation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Translation");
		Translation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Translation", Classes.FStructProperty);
		Scale3D_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Scale3D");
		Scale3D_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Scale3D", Classes.FStructProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FTransform));
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN_Scale3D()
	{
		if (Scale3D.ContainsNaN())
		{
			FMath.LogOrEnsureNanError("FTransform Scale3D contains NaN: " + Scale3D.ToString());
			Scale3D = FVector.OneVector;
		}
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN_Translate()
	{
		if (Translation.ContainsNaN())
		{
			FMath.LogOrEnsureNanError("FTransform Translation contains NaN: " + Translation.ToString());
			Translation = FVector.ZeroVector;
		}
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN_Rotate()
	{
		if (Rotation.ContainsNaN())
		{
			FMath.LogOrEnsureNanError("FTransform Rotation contains NaN: " + Rotation.ToString());
			Rotation = FQuat.Identity;
		}
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheckNaN_All()
	{
	}

	[Conditional("DEBUG")]
	public void DiagnosticCheck_IsValid()
	{
		if (!IsValid())
		{
			FMath.LogOrEnsureNanError("FTransform transform is not valid: " + ToHumanReadableString());
		}
	}

	public FTransform(FVector translation)
	{
		Rotation = FQuat.Identity;
		Translation = translation;
		Scale3D = FVector.OneVector;
		SIMDAlign0 = 0.0;
		SIMDAlign1 = 0.0;
	}

	public FTransform(FQuat rotation)
	{
		Rotation = rotation;
		Translation = FVector.ZeroVector;
		Scale3D = FVector.OneVector;
		SIMDAlign0 = 0.0;
		SIMDAlign1 = 0.0;
	}

	public FTransform(FRotator rotation)
	{
		Rotation = rotation.Quaternion();
		Translation = FVector.ZeroVector;
		Scale3D = FVector.OneVector;
		SIMDAlign0 = 0.0;
		SIMDAlign1 = 0.0;
	}

	public FTransform(FQuat rotation, FVector translation)
		: this(rotation, translation, FVector.OneVector)
	{
	}

	public FTransform(FQuat rotation, FVector translation, FVector scale3D)
	{
		Rotation = rotation;
		Translation = translation;
		Scale3D = scale3D;
		SIMDAlign0 = 0.0;
		SIMDAlign1 = 0.0;
	}

	public FTransform(FRotator rotation, FVector translation)
		: this(rotation, translation, FVector.OneVector)
	{
	}

	public FTransform(FRotator rotation, FVector translation, FVector scale3D)
	{
		Rotation = rotation.Quaternion();
		Translation = translation;
		Scale3D = scale3D;
		SIMDAlign0 = 0.0;
		SIMDAlign1 = 0.0;
	}

	public FTransform(FMatrix matrix)
	{
		this = default(FTransform);
		SetFromMatrix(matrix);
	}

	public FTransform(FVector x, FVector y, FVector z, FVector translation)
	{
		this = default(FTransform);
		SetFromMatrix(new FMatrix(x, y, z, translation));
	}

	public void DebugPrint()
	{
		FMessage.Log("LogTransform", ELogVerbosity.Log, ToHumanReadableString());
	}

	public bool DebugEqualMatrix(FMatrix matrix)
	{
		FTransform other = new FTransform(matrix);
		if (!Equals(other, 9.999999747378752E-05))
		{
			if (!Scale3D.Equals(other.Scale3D, 0.009999999776482582))
			{
				FVector scale3D = other.Scale3D;
				FMessage.Log("LogTransform", ELogVerbosity.Log, "Matrix(S)\t" + scale3D.ToString());
				scale3D = Scale3D;
				FMessage.Log("LogTransform", ELogVerbosity.Log, "VQS(S)\t" + scale3D.ToString());
			}
			if (!Rotation.Equals(other.Rotation))
			{
				FQuat rotation = other.Rotation;
				FMessage.Log("LogTransform", ELogVerbosity.Log, "Matrix(R)\t" + rotation.ToString());
				rotation = Rotation;
				FMessage.Log("LogTransform", ELogVerbosity.Log, "VQS(R)\t" + rotation.ToString());
			}
			if (!Translation.Equals(other.Translation, 0.009999999776482582))
			{
				FVector scale3D = other.Translation;
				FMessage.Log("LogTransform", ELogVerbosity.Log, "Matrix(T)\t" + scale3D.ToString());
				scale3D = Translation;
				FMessage.Log("LogTransform", ELogVerbosity.Log, "VQS(T)\t" + scale3D.ToString());
			}
			return false;
		}
		return true;
	}

	public string ToHumanReadableString()
	{
		FRotator fRotator = GetRotation().Rotator();
		FVector translation = GetTranslation();
		FVector scale3D = GetScale3D();
		return "Rotation: Pitch " + fRotator.Pitch + " Yaw " + fRotator.Yaw + " Roll " + fRotator.Roll + "\r\nTranslation: " + translation.X + " " + translation.Y + " " + translation.Z + "\r\nScale3D: " + scale3D.X + " " + scale3D.Y + " " + scale3D.Z;
	}

	public override string ToString()
	{
		FRotator fRotator = GetRotation().Rotator();
		FVector translation = GetTranslation();
		FVector scale3D = GetScale3D();
		return translation.X + "," + translation.Y + "," + translation.Z + "|" + fRotator.Pitch + "," + fRotator.Yaw + "," + fRotator.Roll + "|" + scale3D.X + "," + scale3D.Y + "," + scale3D.Z;
	}

	public FMatrix ToMatrixWithScale()
	{
		FMatrix result = default(FMatrix);
		result.M41 = Translation.X;
		result.M42 = Translation.Y;
		result.M43 = Translation.Z;
		double num = Rotation.X + Rotation.X;
		double num2 = Rotation.Y + Rotation.Y;
		double num3 = Rotation.Z + Rotation.Z;
		double num4 = (double)Rotation.X * num;
		double num5 = (double)Rotation.Y * num2;
		double num6 = (double)Rotation.Z * num3;
		result.M11 = (1.0 - (num5 + num6)) * (double)Scale3D.X;
		result.M22 = (1.0 - (num4 + num6)) * (double)Scale3D.Y;
		result.M33 = (1.0 - (num4 + num5)) * (double)Scale3D.Z;
		double num7 = (double)Rotation.Y * num3;
		double num8 = (double)Rotation.W * num;
		result.M32 = (num7 - num8) * (double)Scale3D.Z;
		result.M23 = (num7 + num8) * (double)Scale3D.Y;
		double num9 = (double)Rotation.X * num2;
		double num10 = (double)Rotation.W * num3;
		result.M21 = (num9 - num10) * (double)Scale3D.Y;
		result.M12 = (num9 + num10) * (double)Scale3D.X;
		double num11 = (double)Rotation.X * num3;
		double num12 = (double)Rotation.W * num2;
		result.M31 = (num11 + num12) * (double)Scale3D.Z;
		result.M13 = (num11 - num12) * (double)Scale3D.X;
		result.M14 = 0.0;
		result.M24 = 0.0;
		result.M34 = 0.0;
		result.M44 = 1.0;
		return result;
	}

	public FMatrix ToInverseMatrixWithScale()
	{
		return ToMatrixWithScale().Inverse();
	}

	public FTransform Inverse()
	{
		FQuat fQuat = Rotation.Inverse();
		FVector safeScaleReciprocal = GetSafeScaleReciprocal(Scale3D);
		FVector translation = fQuat * (safeScaleReciprocal * -Translation);
		return new FTransform(fQuat, translation, safeScaleReciprocal);
	}

	public FMatrix ToMatrixNoScale()
	{
		FMatrix result = default(FMatrix);
		result.M41 = Translation.X;
		result.M42 = Translation.Y;
		result.M43 = Translation.Z;
		double num = Rotation.X + Rotation.X;
		double num2 = Rotation.Y + Rotation.Y;
		double num3 = Rotation.Z + Rotation.Z;
		double num4 = (double)Rotation.X * num;
		double num5 = (double)Rotation.Y * num2;
		double num6 = (double)Rotation.Z * num3;
		result.M11 = 1.0 - (num5 + num6);
		result.M22 = 1.0 - (num4 + num6);
		result.M33 = 1.0 - (num4 + num5);
		double num7 = (double)Rotation.Y * num3;
		double num8 = (double)Rotation.W * num;
		result.M32 = num7 - num8;
		result.M23 = num7 + num8;
		double num9 = (double)Rotation.X * num2;
		double num10 = (double)Rotation.W * num3;
		result.M21 = num9 - num10;
		result.M12 = num9 + num10;
		double num11 = (double)Rotation.X * num3;
		double num12 = (double)Rotation.W * num2;
		result.M31 = num11 + num12;
		result.M13 = num11 - num12;
		result.M14 = 0.0;
		result.M24 = 0.0;
		result.M34 = 0.0;
		result.M44 = 1.0;
		return result;
	}

	public void Blend(FTransform atom1, FTransform atom2, float alpha)
	{
		if ((double)alpha <= 1E-05)
		{
			this = atom1;
			return;
		}
		if ((double)alpha >= 0.99999)
		{
			this = atom2;
			return;
		}
		Translation = FMath.Lerp(atom1.Translation, atom2.Translation, alpha);
		Scale3D = FMath.Lerp(atom1.Scale3D, atom2.Scale3D, alpha);
		Rotation = FQuat.FastLerp(atom1.Rotation, atom2.Rotation, alpha);
		Rotation.Normalize();
	}

	public void BlendWith(FTransform otherAtom, float alpha)
	{
		if ((double)alpha > 1E-05)
		{
			if ((double)alpha >= 0.99999)
			{
				this = otherAtom;
				return;
			}
			Translation = FMath.Lerp(Translation, otherAtom.Translation, alpha);
			Scale3D = FMath.Lerp(Scale3D, otherAtom.Scale3D, alpha);
			Rotation = FQuat.FastLerp(Rotation, otherAtom.Rotation, alpha);
			Rotation.Normalize();
		}
	}

	public static bool operator ==(FTransform a, FTransform b)
	{
		if (a.Rotation == b.Rotation && a.Translation == b.Translation)
		{
			return a.Scale3D == b.Scale3D;
		}
		return false;
	}

	public static bool operator !=(FTransform a, FTransform b)
	{
		if (!(a.Rotation != b.Rotation) && !(a.Translation != b.Translation))
		{
			return a.Scale3D != b.Scale3D;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FTransform))
		{
			return false;
		}
		return Equals((FTransform)obj);
	}

	public bool Equals(FTransform other)
	{
		if (Rotation == other.Rotation && Translation == other.Translation)
		{
			return Scale3D == other.Scale3D;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Rotation.GetHashCode() * 397) ^ Translation.GetHashCode()) * 397) ^ Scale3D.GetHashCode();
	}

	public static FTransform operator +(FTransform a, FTransform b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static FTransform Add(FTransform a, FTransform b)
	{
		Add(ref a, ref b, out a);
		return a;
	}

	public static void Add(ref FTransform a, ref FTransform b, out FTransform result)
	{
		result.Translation = a.Translation + b.Translation;
		result.Rotation = a.Rotation + b.Rotation;
		result.Scale3D = a.Scale3D + b.Scale3D;
		result.SIMDAlign0 = 0.0;
		result.SIMDAlign1 = 0.0;
	}

	public static FTransform operator *(float scale, FTransform t)
	{
		Multiply(ref t, scale, out t);
		return t;
	}

	public static FTransform operator *(FTransform t, float scale)
	{
		Multiply(ref t, scale, out t);
		return t;
	}

	public static void Multiply(ref FTransform t, float scale, out FTransform result)
	{
		result.Translation = t.Translation * scale;
		result.Rotation = t.Rotation * scale;
		result.Scale3D = t.Scale3D * scale;
		result.SIMDAlign0 = 0.0;
		result.SIMDAlign1 = 0.0;
	}

	public static FTransform operator *(FTransform a, FTransform b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static FTransform Multiply(FTransform a, FTransform b)
	{
		Multiply(ref a, ref b, out a);
		return a;
	}

	public static void Multiply(ref FTransform a, ref FTransform b, out FTransform result)
	{
		if (AnyHasNegativeScale(a.Scale3D, b.Scale3D))
		{
			MultiplyUsingMatrixWithScale(out result, ref a, ref b);
			return;
		}
		result.Rotation = b.Rotation * a.Rotation;
		result.Scale3D = a.Scale3D * b.Scale3D;
		result.Translation = b.Rotation * (b.Scale3D * a.Translation) + b.Translation;
		result.SIMDAlign0 = 0.0;
		result.SIMDAlign1 = 0.0;
	}

	private static void MultiplyUsingMatrixWithScale(out FTransform outTransform, ref FTransform a, ref FTransform b)
	{
		FMatrix aMatrix = a.ToMatrixWithScale();
		FMatrix bMatrix = b.ToMatrixWithScale();
		FVector desiredScale = a.Scale3D * b.Scale3D;
		ConstructTransformFromMatrixWithDesiredScale(ref aMatrix, ref bMatrix, ref desiredScale, out outTransform);
	}

	private static void ConstructTransformFromMatrixWithDesiredScale(ref FMatrix aMatrix, ref FMatrix bMatrix, ref FVector desiredScale, out FTransform outTransform)
	{
		FMatrix m = aMatrix * bMatrix;
		m.RemoveScaling();
		FVector signVector = desiredScale.GetSignVector();
		m.SetAxis(0, signVector.X * m.GetScaledAxis(EAxis.X));
		m.SetAxis(1, signVector.Y * m.GetScaledAxis(EAxis.Y));
		m.SetAxis(2, signVector.Z * m.GetScaledAxis(EAxis.Z));
		FQuat rotation = new FQuat(m);
		rotation.Normalize();
		outTransform.Scale3D = desiredScale;
		outTransform.Rotation = rotation;
		outTransform.Translation = m.GetOrigin();
		outTransform.SIMDAlign0 = 0.0;
		outTransform.SIMDAlign1 = 0.0;
	}

	private static void GetRelativeTransformUsingMatrixWithScale(out FTransform outTransform, ref FTransform baseTransform, ref FTransform relativeTransform)
	{
		FMatrix aMatrix = baseTransform.ToMatrixWithScale();
		FMatrix bMatrix = relativeTransform.ToMatrixWithScale().Inverse();
		FVector safeScaleReciprocal = GetSafeScaleReciprocal(relativeTransform.Scale3D);
		FVector desiredScale = baseTransform.Scale3D * safeScaleReciprocal;
		ConstructTransformFromMatrixWithDesiredScale(ref aMatrix, ref bMatrix, ref desiredScale, out outTransform);
	}

	public static FTransform operator *(FTransform t, FQuat q)
	{
		Multiply(ref t, ref q, out t);
		return t;
	}

	public static FTransform Multiply(FTransform t, FQuat q)
	{
		Multiply(ref t, ref q, out t);
		return t;
	}

	public static void Multiply(ref FTransform t, ref FQuat q, out FTransform result)
	{
		FTransform b = new FTransform(q, FVector.ZeroVector, FVector.OneVector);
		Multiply(ref t, ref b, out result);
	}

	public static bool AnyHasNegativeScale(FVector scale3D, FVector otherScale3D)
	{
		if (!(scale3D.X < 0f) && !(scale3D.Y < 0f) && !(scale3D.Z < 0f) && !(otherScale3D.X < 0f) && !(otherScale3D.Y < 0f))
		{
			return otherScale3D.Z < 0f;
		}
		return true;
	}

	public void ScaleTranslation(FVector scale3D)
	{
		Translation *= scale3D;
	}

	public void ScaleTranslation(double scale)
	{
		Translation *= scale;
	}

	public void RemoveScaling(double tolerance = 9.99999993922529E-09)
	{
		Scale3D = new FVector(1.0, 1.0, 1.0);
		Rotation.Normalize();
	}

	public double GetMaximumAxisScale()
	{
		return Scale3D.GetAbsMax();
	}

	public double GetMinimumAxisScale()
	{
		return Scale3D.GetAbsMin();
	}

	public FTransform GetRelativeTransform(FTransform other)
	{
		FTransform outTransform = default(FTransform);
		if (AnyHasNegativeScale(Scale3D, other.GetScale3D()))
		{
			GetRelativeTransformUsingMatrixWithScale(out outTransform, ref this, ref other);
		}
		else
		{
			FVector safeScaleReciprocal = GetSafeScaleReciprocal(other.Scale3D);
			outTransform.Scale3D = Scale3D * safeScaleReciprocal;
			if (!other.Rotation.IsNormalized())
			{
				return Identity;
			}
			FQuat fQuat = other.Rotation.Inverse();
			outTransform.Rotation = fQuat * Rotation;
			outTransform.Translation = fQuat * (Translation - other.Translation) * safeScaleReciprocal;
		}
		outTransform.SIMDAlign0 = 0.0;
		outTransform.SIMDAlign1 = 0.0;
		return outTransform;
	}

	public FTransform GetRelativeTransformReverse(FTransform other)
	{
		FVector safeScaleReciprocal = GetSafeScaleReciprocal(Scale3D);
		FTransform result = default(FTransform);
		result.Scale3D = other.Scale3D * safeScaleReciprocal;
		result.Rotation = other.Rotation * Rotation.Inverse();
		result.Translation = other.Translation - result.Scale3D * (result.Rotation * Translation);
		result.SIMDAlign0 = 0.0;
		result.SIMDAlign1 = 0.0;
		return result;
	}

	public void SetToRelativeTransform(FTransform parentTransform)
	{
		FVector safeScaleReciprocal = GetSafeScaleReciprocal(parentTransform.Scale3D);
		FQuat fQuat = parentTransform.Rotation.Inverse();
		Scale3D *= safeScaleReciprocal;
		Translation = fQuat * (Translation - parentTransform.Translation) * safeScaleReciprocal;
		Rotation = fQuat * Rotation;
	}

	public FVector4 TransformFVector4(FVector4 v)
	{
		FVector4 fVector = new FVector4(Rotation.RotateVector(Scale3D * (FVector)v), 0.0);
		if (v.W == 1f)
		{
			return fVector + new FVector4(Translation);
		}
		return fVector;
	}

	public FVector4 TransformFVector4NoScale(FVector4 v)
	{
		FVector4 fVector = new FVector4(Rotation.RotateVector(v), 0.0);
		if (v.W == 1f)
		{
			return fVector + new FVector4(Translation);
		}
		return fVector;
	}

	public FVector TransformPosition(FVector v)
	{
		return Rotation.RotateVector(Scale3D * v) + Translation;
	}

	public FVector TransformPositionNoScale(FVector v)
	{
		return Rotation.RotateVector(v) + Translation;
	}

	public FVector InverseTransformPosition(FVector v)
	{
		return Rotation.UnrotateVector(v - Translation) * GetSafeScaleReciprocal(Scale3D);
	}

	public FVector InverseTransformPositionNoScale(FVector v)
	{
		return Rotation.UnrotateVector(v - Translation);
	}

	public FVector GetUnitAxis(EAxis InAxis)
	{
		return InAxis switch
		{
			EAxis.X => TransformVectorNoScale(FVector.ForwardVector), 
			EAxis.Y => TransformVectorNoScale(FVector.RightVector), 
			_ => TransformVectorNoScale(FVector.UpVector), 
		};
	}

	public FVector TransformVector(FVector v)
	{
		return Rotation.RotateVector(Scale3D * v);
	}

	public FVector TransformVectorNoScale(FVector v)
	{
		return Rotation.RotateVector(v);
	}

	public FVector InverseTransformVector(FVector v)
	{
		return Rotation.UnrotateVector(v) * GetSafeScaleReciprocal(Scale3D);
	}

	public FVector InverseTransformVectorNoScale(FVector v)
	{
		return Rotation.UnrotateVector(v);
	}

	public FQuat TransformRotation(FQuat q)
	{
		return GetRotation() * q;
	}

	public FQuat InverseTransformRotation(FQuat q)
	{
		return GetRotation().Inverse() * q;
	}

	public FTransform GetScaled(double scale)
	{
		FTransform result = this;
		result.Scale3D *= scale;
		return result;
	}

	public FTransform GetScaled(FVector scale)
	{
		FTransform result = this;
		result.Scale3D *= scale;
		return result;
	}

	public FVector GetScaledAxis(EAxis axis)
	{
		return axis switch
		{
			EAxis.X => TransformVectorNoScale(new FVector(1.0, 0.0, 0.0)), 
			EAxis.Y => TransformVectorNoScale(new FVector(0.0, 1.0, 0.0)), 
			EAxis.Z => TransformVectorNoScale(new FVector(0.0, 0.0, 1.0)), 
			_ => throw new ArgumentOutOfRangeException(), 
		};
	}

	public void Mirror(EAxis mirrorAxis, EAxis flipAxis)
	{
		FMatrix fromMatrix = ToMatrixWithScale();
		fromMatrix.Mirror(mirrorAxis, flipAxis);
		SetFromMatrix(fromMatrix);
	}

	public static FVector GetSafeScaleReciprocal(FVector scale, double tolerance = 9.99999993922529E-09)
	{
		FVector result = default(FVector);
		if ((double)FMath.Abs(scale.X) <= tolerance)
		{
			result.X = 0f;
		}
		else
		{
			result.X = 1f / scale.X;
		}
		if ((double)FMath.Abs(scale.Y) <= tolerance)
		{
			result.Y = 0f;
		}
		else
		{
			result.Y = 1f / scale.Y;
		}
		if ((double)FMath.Abs(scale.Z) <= tolerance)
		{
			result.Z = 0f;
		}
		else
		{
			result.Z = 1f / scale.Z;
		}
		return result;
	}

	public FVector GetLocation()
	{
		return GetTranslation();
	}

	public FRotator Rotator()
	{
		return Rotation.Rotator();
	}

	public double GetDeterminant()
	{
		return Scale3D.X * Scale3D.Y * Scale3D.Z;
	}

	public void SetLocation(FVector origin)
	{
		Translation = origin;
	}

	public bool ContainsNaN()
	{
		if (!Translation.ContainsNaN() && !Rotation.ContainsNaN())
		{
			return Scale3D.ContainsNaN();
		}
		return true;
	}

	public bool IsValid()
	{
		if (ContainsNaN())
		{
			return false;
		}
		if (!Rotation.IsNormalized())
		{
			return false;
		}
		return true;
	}

	private bool Private_RotationEquals(FQuat rotation, double tolerance = 9.999999747378752E-05)
	{
		return Rotation.Equals(rotation, tolerance);
	}

	private bool Private_TranslationEquals(FVector translation, double tolerance = 9.999999747378752E-05)
	{
		return Translation.Equals(translation, tolerance);
	}

	private bool Private_Scale3DEquals(FVector scale3D, double tolerance = 9.999999747378752E-05)
	{
		return Scale3D.Equals(scale3D, tolerance);
	}

	public static bool AreRotationsEqual(FTransform a, FTransform b, double tolerance = 9.999999747378752E-05)
	{
		return a.Private_RotationEquals(b.Rotation, tolerance);
	}

	public static bool AreTranslationsEqual(FTransform a, FTransform b, double tolerance = 9.999999747378752E-05)
	{
		return a.Private_TranslationEquals(b.Translation, tolerance);
	}

	public static bool AreScale3DsEqual(FTransform a, FTransform b, double tolerance = 9.999999747378752E-05)
	{
		return a.Private_Scale3DEquals(b.Scale3D, tolerance);
	}

	public bool RotationEquals(FTransform other, double tolerance = 9.999999747378752E-05)
	{
		return AreRotationsEqual(this, other, tolerance);
	}

	public bool TranslationEquals(FTransform other, double tolerance = 9.999999747378752E-05)
	{
		return AreTranslationsEqual(this, other, tolerance);
	}

	public bool Scale3DEquals(FTransform other, double tolerance = 9.999999747378752E-05)
	{
		return AreScale3DsEqual(this, other, tolerance);
	}

	public bool Equals(FTransform other, double tolerance = 9.999999747378752E-05)
	{
		if (Private_TranslationEquals(other.Translation, tolerance) && Private_RotationEquals(other.Rotation, tolerance))
		{
			return Private_Scale3DEquals(other.Scale3D, tolerance);
		}
		return false;
	}

	public bool EqualsNoScale(FTransform other, double tolerance = 9.999999747378752E-05)
	{
		if (Private_TranslationEquals(other.Translation, tolerance))
		{
			return Private_RotationEquals(other.Rotation, tolerance);
		}
		return false;
	}

	public void SetComponents(FQuat rotation, FVector translation, FVector scale3D)
	{
		Rotation = rotation;
		Translation = translation;
		Scale3D = scale3D;
	}

	public void SetIdentity()
	{
		Rotation = FQuat.Identity;
		Translation = FVector.ZeroVector;
		Scale3D = new FVector(1.0, 1.0, 1.0);
	}

	public void MultiplyScale3D(FVector scale3DMultiplier)
	{
		Scale3D *= scale3DMultiplier;
	}

	public void SetTranslation(FVector newTranslation)
	{
		Translation = newTranslation;
	}

	public void CopyTranslation(FTransform other)
	{
		Translation = other.Translation;
	}

	public void ConcatenateRotation(FQuat deltaRotation)
	{
		Rotation *= deltaRotation;
	}

	public void AddToTranslation(FVector deltaTranslation)
	{
		Translation += deltaTranslation;
	}

	public static FVector AddTranslations(FTransform a, FTransform b)
	{
		return a.Translation + b.Translation;
	}

	public static FVector SubtractTranslations(FTransform a, FTransform b)
	{
		return a.Translation - b.Translation;
	}

	public void SetRotation(FQuat newRotation)
	{
		Rotation = newRotation;
	}

	public void CopyRotation(FTransform other)
	{
		Rotation = other.Rotation;
	}

	public void SetScale3D(FVector newScale3D)
	{
		Scale3D = newScale3D;
	}

	public void CopyScale3D(FTransform other)
	{
		Scale3D = other.Scale3D;
	}

	public void SetTranslationAndScale3D(FVector newTranslation, FVector newScale3D)
	{
		Translation = newTranslation;
		Scale3D = newScale3D;
	}

	public void Accumulate(FTransform sourceAtom)
	{
		if (FMath.Square(sourceAtom.Rotation.W) < 1f)
		{
			Rotation = sourceAtom.Rotation * Rotation;
		}
		Translation += sourceAtom.Translation;
		Scale3D *= sourceAtom.Scale3D;
	}

	public void Accumulate(FTransform atom, float blendWeight)
	{
		FTransform fTransform = atom * blendWeight;
		if (FMath.Square(fTransform.Rotation.W) < 1f)
		{
			Rotation = fTransform.Rotation * Rotation;
		}
		Translation += fTransform.Translation;
		Scale3D *= fTransform.Scale3D;
	}

	public void AccumulateWithShortestRotation(FTransform deltaAtom, float blendWeight)
	{
		FTransform fTransform = deltaAtom * blendWeight;
		if ((fTransform.Rotation | Rotation) < 0f)
		{
			Rotation.X -= fTransform.Rotation.X;
			Rotation.Y -= fTransform.Rotation.Y;
			Rotation.Z -= fTransform.Rotation.Z;
			Rotation.W -= fTransform.Rotation.W;
		}
		else
		{
			Rotation.X += fTransform.Rotation.X;
			Rotation.Y += fTransform.Rotation.Y;
			Rotation.Z += fTransform.Rotation.Z;
			Rotation.W += fTransform.Rotation.W;
		}
		Translation += fTransform.Translation;
		Scale3D += fTransform.Scale3D;
	}

	public void AccumulateWithAdditiveScale(FTransform atom, float blendWeight)
	{
		FVector oneVector = FVector.OneVector;
		FTransform fTransform = atom * blendWeight;
		if (FMath.Square(fTransform.Rotation.W) < 1f)
		{
			Rotation = fTransform.Rotation * Rotation;
		}
		Translation += fTransform.Translation;
		Scale3D *= oneVector + fTransform.Scale3D;
	}

	public void LerpTranslationScale3D(FTransform sourceAtom1, FTransform sourceAtom2, double alpha)
	{
		Translation = FMath.Lerp(sourceAtom1.Translation, sourceAtom2.Translation, alpha);
		Scale3D = FMath.Lerp(sourceAtom1.Scale3D, sourceAtom2.Scale3D, alpha);
	}

	public void NormalizeRotation()
	{
		Rotation.Normalize();
	}

	public bool IsRotationNormalized()
	{
		return Rotation.IsNormalized();
	}

	public static void BlendFromIdentityAndAccumulate(ref FTransform finalAtom, ref FTransform sourceAtom, float blendWeight)
	{
		FTransform atom = new FTransform(FQuat.Identity, FVector.ZeroVector, FVector.ZeroVector);
		FVector oneVector = FVector.OneVector;
		if ((double)blendWeight < 0.99999)
		{
			sourceAtom.Blend(atom, sourceAtom, blendWeight);
		}
		if (FMath.Square(sourceAtom.Rotation.W) < 1f)
		{
			finalAtom.Rotation = sourceAtom.Rotation * finalAtom.Rotation;
		}
		finalAtom.Translation += sourceAtom.Translation;
		finalAtom.Scale3D *= oneVector + sourceAtom.Scale3D;
	}

	public FQuat GetRotation()
	{
		return Rotation;
	}

	public FVector GetTranslation()
	{
		return Translation;
	}

	public FVector GetScale3D()
	{
		return Scale3D;
	}

	public void CopyRotationPart(FTransform srcBA)
	{
		Rotation = srcBA.Rotation;
		Scale3D = srcBA.Scale3D;
	}

	public void CopyTranslationAndScale3D(FTransform srcBA)
	{
		Translation = srcBA.Translation;
		Scale3D = srcBA.Scale3D;
	}

	public void SetFromMatrix(FMatrix matrix)
	{
		FMatrix m = matrix;
		Scale3D = m.ExtractScaling();
		if (matrix.Determinant() < 0.0)
		{
			Scale3D.X *= -1f;
			m.SetAxis(0, -m.GetScaledAxis(EAxis.X));
		}
		Rotation = new FQuat(m);
		Translation = matrix.GetOrigin();
		Rotation.Normalize();
	}
}
