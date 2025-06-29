using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 24584)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.InterpCurvePointQuat")]
public struct FInterpCurvePointQuat : IEquatable<FInterpCurvePointQuat>
{
	private static bool InVal_IsValid;

	private static int InVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointQuat:InVal")]
	public float InVal;

	private long padding1;

	private int padding2;

	private static bool OutVal_IsValid;

	private static int OutVal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointQuat:OutVal")]
	public FQuat OutVal;

	private static bool ArriveTangent_IsValid;

	private static int ArriveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointQuat:ArriveTangent")]
	public FQuat ArriveTangent;

	private static bool LeaveTangent_IsValid;

	private static int LeaveTangent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274309uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointQuat:LeaveTangent")]
	public FQuat LeaveTangent;

	private static bool InterpMode_IsValid;

	private static FFieldAddress InterpMode_PropertyAddress;

	private static int InterpMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.InterpCurvePointQuat:InterpMode")]
	public EInterpCurveMode InterpMode;

	private int padding3;

	private static int FInterpCurvePointQuat_StructSize;

	public FInterpCurvePointQuat Copy()
	{
		return this;
	}

	static FInterpCurvePointQuat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInterpCurvePointQuat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInterpCurvePointQuat));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.InterpCurvePointQuat");
		FInterpCurvePointQuat_StructSize = NativeReflection.GetStructSize(unrealStruct);
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
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FInterpCurvePointQuat));
	}

	public FInterpCurvePointQuat(float inVal, FQuat outVal)
	{
		InVal = inVal;
		OutVal = outVal;
		ArriveTangent = default(FQuat);
		LeaveTangent = default(FQuat);
		InterpMode = EInterpCurveMode.Linear;
		padding1 = (padding2 = (padding3 = 0));
	}

	public FInterpCurvePointQuat(float inVal, FQuat outVal, FQuat arriveTangent, FQuat leaveTangent, EInterpCurveMode interpMode)
	{
		InVal = inVal;
		OutVal = outVal;
		ArriveTangent = arriveTangent;
		LeaveTangent = leaveTangent;
		InterpMode = interpMode;
		padding1 = (padding2 = (padding3 = 0));
	}

	public bool IsCurveKey()
	{
		if (InterpMode != EInterpCurveMode.CurveAuto && InterpMode != EInterpCurveMode.CurveAutoClamped && InterpMode != EInterpCurveMode.CurveUser)
		{
			return InterpMode == EInterpCurveMode.CurveBreak;
		}
		return true;
	}

	public static bool operator ==(FInterpCurvePointQuat a, FInterpCurvePointQuat b)
	{
		if (a.InVal == b.InVal && a.OutVal == b.OutVal && a.ArriveTangent == b.ArriveTangent && a.LeaveTangent == b.LeaveTangent)
		{
			return a.InterpMode == b.InterpMode;
		}
		return false;
	}

	public static bool operator !=(FInterpCurvePointQuat a, FInterpCurvePointQuat b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FInterpCurvePointQuat))
		{
			return false;
		}
		return Equals((FInterpCurvePointQuat)obj);
	}

	public bool Equals(FInterpCurvePointQuat other)
	{
		return this == other;
	}

	public override int GetHashCode()
	{
		return (((((((InVal.GetHashCode() * 397) ^ OutVal.GetHashCode()) * 397) ^ ArriveTangent.GetHashCode()) * 397) ^ LeaveTangent.GetHashCode()) * 397) ^ InterpMode.GetHashCode();
	}
}
