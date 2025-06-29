using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TressFX.AnimationResetPositionPeriod", "TressFX", UnrealModuleType.GamePlugin)]
public struct FAnimationResetPositionPeriod
{
	private static bool Start_IsValid;

	private static int Start_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.AnimationResetPositionPeriod:Start")]
	public float Start;

	private static bool End_IsValid;

	private static int End_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.AnimationResetPositionPeriod:End")]
	public float End;

	private static bool FAnimationResetPositionPeriod_IsValid;

	private static int FAnimationResetPositionPeriod_StructSize;

	public FAnimationResetPositionPeriod Copy()
	{
		return this;
	}

	public static FAnimationResetPositionPeriod FromNative(IntPtr nativeBuffer)
	{
		return new FAnimationResetPositionPeriod(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimationResetPositionPeriod value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimationResetPositionPeriod FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimationResetPositionPeriod(nativeBuffer + arrayIndex * FAnimationResetPositionPeriod_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimationResetPositionPeriod value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimationResetPositionPeriod_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimationResetPositionPeriod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.AnimationResetPositionPeriod");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Start_Offset), Start);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, End_Offset), End);
	}

	public FAnimationResetPositionPeriod(IntPtr nativeStruct)
	{
		if (!FAnimationResetPositionPeriod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.AnimationResetPositionPeriod");
			Start = 0f;
			End = 0f;
		}
		else
		{
			Start = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Start_Offset));
			End = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, End_Offset));
		}
	}

	static FAnimationResetPositionPeriod()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimationResetPositionPeriod)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimationResetPositionPeriod));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TressFX.AnimationResetPositionPeriod");
		FAnimationResetPositionPeriod_StructSize = NativeReflection.GetStructSize(intPtr);
		Start_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Start");
		Start_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Start", Classes.FFloatProperty);
		End_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "End");
		End_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "End", Classes.FFloatProperty);
		FAnimationResetPositionPeriod_IsValid = intPtr != IntPtr.Zero && Start_IsValid && End_IsValid;
		NativeReflection.LogStructIsValid("/Script/TressFX.AnimationResetPositionPeriod", FAnimationResetPositionPeriod_IsValid);
	}
}
