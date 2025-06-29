using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 24584)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurvePointFloat", "CoreUObject", UnrealModuleType.Engine)]
public struct FInterpCurvePointFloat : IEquatable<FInterpCurvePointFloat>
{
	private static bool InVal_IsValid;

	private static int InVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointFloat:InVal")]
	public float InVal;

	private static bool OutVal_IsValid;

	private static int OutVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointFloat:OutVal")]
	public float OutVal;

	private static bool ArriveTangent_IsValid;

	private static int ArriveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointFloat:ArriveTangent")]
	public float ArriveTangent;

	private static bool LeaveTangent_IsValid;

	private static int LeaveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointFloat:LeaveTangent")]
	public float LeaveTangent;

	private static bool InterpMode_IsValid;

	private static FFieldAddress InterpMode_PropertyAddress;

	private static int InterpMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointFloat:InterpMode")]
	public EInterpCurveMode InterpMode;

	private static int FInterpCurvePointFloat_StructSize;

	public FInterpCurvePointFloat Copy()
	{
		return this;
	}

	static FInterpCurvePointFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurvePointFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurvePointFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurvePointFloat");
		FInterpCurvePointFloat_StructSize = NativeReflection.GetStructSize(unrealStruct);
		InVal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InVal");
		InVal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InVal", Classes.FFloatProperty);
		OutVal_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OutVal");
		OutVal_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OutVal", Classes.FStructProperty);
		ArriveTangent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ArriveTangent");
		ArriveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ArriveTangent", Classes.FStructProperty);
		LeaveTangent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LeaveTangent");
		LeaveTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LeaveTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpMode_PropertyAddress, unrealStruct, "InterpMode");
		InterpMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InterpMode");
		InterpMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InterpMode", Classes.FByteProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FInterpCurvePointFloat));
	}

	public FInterpCurvePointFloat(float inVal, float outVal)
	{
		InVal = inVal;
		OutVal = outVal;
		ArriveTangent = 0f;
		LeaveTangent = 0f;
		InterpMode = EInterpCurveMode.Linear;
	}

	public FInterpCurvePointFloat(float inVal, float outVal, float arriveTangent, float leaveTangent, EInterpCurveMode interpMode)
	{
		InVal = inVal;
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

	public static bool operator ==(FInterpCurvePointFloat a, FInterpCurvePointFloat b)
	{
		if (a.InVal == b.InVal && a.OutVal == b.OutVal && a.ArriveTangent == b.ArriveTangent && a.LeaveTangent == b.LeaveTangent)
		{
			return a.InterpMode == b.InterpMode;
		}
		return false;
	}

	public static bool operator !=(FInterpCurvePointFloat a, FInterpCurvePointFloat b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FInterpCurvePointFloat))
		{
			return false;
		}
		return Equals((FInterpCurvePointFloat)obj);
	}

	public bool Equals(FInterpCurvePointFloat other)
	{
		return this == other;
	}

	public override int GetHashCode()
	{
		return (((((((InVal.GetHashCode() * 397) ^ OutVal.GetHashCode()) * 397) ^ ArriveTangent.GetHashCode()) * 397) ^ LeaveTangent.GetHashCode()) * 397) ^ InterpMode.GetHashCode();
	}
}
