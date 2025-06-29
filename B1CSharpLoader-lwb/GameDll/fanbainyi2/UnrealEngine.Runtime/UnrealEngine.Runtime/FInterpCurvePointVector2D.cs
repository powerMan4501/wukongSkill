using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 24584)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurvePointVector2D", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurvePointVector2D : IEquatable<FInterpCurvePointVector2D>
{
	private static bool InVal_IsValid;

	private static int InVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector2D:InVal")]
	public float mInVal;

	private static bool OutVal_IsValid;

	private static int OutVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector2D:OutVal")]
	public FVector2D OutVal;

	private static bool ArriveTangent_IsValid;

	private static int ArriveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector2D:ArriveTangent")]
	public FVector2D ArriveTangent;

	private static bool LeaveTangent_IsValid;

	private static int LeaveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector2D:LeaveTangent")]
	public FVector2D LeaveTangent;

	private static bool InterpMode_IsValid;

	private static FFieldAddress InterpMode_PropertyAddress;

	private static int InterpMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointVector2D:InterpMode")]
	public EInterpCurveMode InterpMode;

	private static int FInterpCurvePointVector2D_StructSize;

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

	public FInterpCurvePointVector2D Copy()
	{
		return this;
	}

	static FInterpCurvePointVector2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurvePointVector2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurvePointVector2D));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurvePointVector2D");
		FInterpCurvePointVector2D_StructSize = NativeReflection.GetStructSize(unrealStruct);
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
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FInterpCurvePointVector2D));
	}

	public FInterpCurvePointVector2D(float inVal, FVector2D outVal)
	{
		mInVal = inVal;
		OutVal = outVal;
		ArriveTangent = default(FVector2D);
		LeaveTangent = default(FVector2D);
		InterpMode = EInterpCurveMode.Linear;
	}

	public FInterpCurvePointVector2D(float inVal, FVector2D outVal, FVector2D arriveTangent, FVector2D leaveTangent, EInterpCurveMode interpMode)
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

	public static bool operator ==(FInterpCurvePointVector2D a, FInterpCurvePointVector2D b)
	{
		if (a.InVal == b.InVal && a.OutVal == b.OutVal && a.ArriveTangent == b.ArriveTangent && a.LeaveTangent == b.LeaveTangent)
		{
			return a.InterpMode == b.InterpMode;
		}
		return false;
	}

	public static bool operator !=(FInterpCurvePointVector2D a, FInterpCurvePointVector2D b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FInterpCurvePointVector2D))
		{
			return false;
		}
		return Equals((FInterpCurvePointVector2D)obj);
	}

	public bool Equals(FInterpCurvePointVector2D other)
	{
		return this == other;
	}

	public override int GetHashCode()
	{
		return (((((((InVal.GetHashCode() * 397) ^ OutVal.GetHashCode()) * 397) ^ ArriveTangent.GetHashCode()) * 397) ^ LeaveTangent.GetHashCode()) * 397) ^ InterpMode.GetHashCode();
	}
}
