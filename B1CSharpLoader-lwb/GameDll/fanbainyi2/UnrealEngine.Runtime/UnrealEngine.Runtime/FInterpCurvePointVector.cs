using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 24584)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurvePointVector", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurvePointVector : IEquatable<FInterpCurvePointVector>
{
	private static bool InVal_IsValid;

	private static int InVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector:InVal")]
	public float mInVal;

	private static bool OutVal_IsValid;

	private static int OutVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector:OutVal")]
	public FVector OutVal;

	private static bool ArriveTangent_IsValid;

	private static int ArriveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector:ArriveTangent")]
	public FVector ArriveTangent;

	private static bool LeaveTangent_IsValid;

	private static int LeaveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector:LeaveTangent")]
	public FVector LeaveTangent;

	private static bool InterpMode_IsValid;

	private static FFieldAddress InterpMode_PropertyAddress;

	private static int InterpMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector:InterpMode")]
	public EInterpCurveMode InterpMode;

	private static int FInterpCurvePointVector_StructSize;

	public float InVal
	{
		get
		{
			return mInVal;
		}
		set
		{
			mInVal = value;
		}
	}

	public FInterpCurvePointVector Copy()
	{
		return this;
	}

	static FInterpCurvePointVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurvePointVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurvePointVector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurvePointVector");
		FInterpCurvePointVector_StructSize = NativeReflection.GetStructSize(unrealStruct);
		InVal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "mInVal");
		InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "mInVal", Classes.FFloatProperty);
		OutVal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutVal");
		OutVal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutVal", Classes.FStructProperty);
		ArriveTangent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ArriveTangent");
		ArriveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ArriveTangent", Classes.FStructProperty);
		LeaveTangent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LeaveTangent");
		LeaveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LeaveTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpMode_PropertyAddress, unrealStruct, "InterpMode");
		InterpMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InterpMode");
		InterpMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InterpMode", Classes.FByteProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FInterpCurvePointVector));
	}

	public FInterpCurvePointVector(float inVal, FVector outVal)
	{
		mInVal = inVal;
		OutVal = outVal;
		ArriveTangent = default(FVector);
		LeaveTangent = default(FVector);
		InterpMode = EInterpCurveMode.Linear;
	}

	public FInterpCurvePointVector(float inVal, FVector outVal, FVector arriveTangent, FVector leaveTangent, EInterpCurveMode interpMode)
	{
		mInVal = inVal;
		OutVal = outVal;
		ArriveTangent = arriveTangent;
		LeaveTangent = leaveTangent;
		InterpMode = interpMode;
	}

	public bool IsCurveKey()
	{
		if (InterpMode != EInterpCurveMode.CurveAuto && InterpMode != EInterpCurveMode.CurveAutoClamped && InterpMode != EInterpCurveMode.CurveUser)
		{
			return InterpMode == EInterpCurveMode.CurveBreak;
		}
		return true;
	}

	public static bool operator ==(FInterpCurvePointVector a, FInterpCurvePointVector b)
	{
		if (a.InVal == b.InVal && a.OutVal == b.OutVal && a.ArriveTangent == b.ArriveTangent && a.LeaveTangent == b.LeaveTangent)
		{
			return a.InterpMode == b.InterpMode;
		}
		return false;
	}

	public static bool operator !=(FInterpCurvePointVector a, FInterpCurvePointVector b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FInterpCurvePointVector))
		{
			return false;
		}
		return Equals((FInterpCurvePointVector)obj);
	}

	public bool Equals(FInterpCurvePointVector other)
	{
		return this == other;
	}

	public override int GetHashCode()
	{
		return (((((((InVal.GetHashCode() * 397) ^ OutVal.GetHashCode()) * 397) ^ ArriveTangent.GetHashCode()) * 397) ^ LeaveTangent.GetHashCode()) * 397) ^ InterpMode.GetHashCode();
	}
}
