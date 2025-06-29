using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.FrameRateChangedPayload", "Engine", UnrealModuleType.Engine)]
public struct FFrameRateChangedPayload
{
	private static bool PreviousFrameRate_IsValid;

	private static int PreviousFrameRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/Engine.FrameRateChangedPayload:PreviousFrameRate")]
	public FFrameRate PreviousFrameRate;

	private static bool FFrameRateChangedPayload_IsValid;

	private static int FFrameRateChangedPayload_StructSize;

	public FFrameRateChangedPayload Copy()
	{
		return this;
	}

	public static FFrameRateChangedPayload FromNative(IntPtr nativeBuffer)
	{
		return new FFrameRateChangedPayload(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFrameRateChangedPayload value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFrameRateChangedPayload FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFrameRateChangedPayload(nativeBuffer + arrayIndex * FFrameRateChangedPayload_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFrameRateChangedPayload value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFrameRateChangedPayload_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFrameRateChangedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FrameRateChangedPayload");
		}
		else
		{
			BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(nativeStruct, PreviousFrameRate_Offset), PreviousFrameRate);
		}
	}

	public FFrameRateChangedPayload(IntPtr nativeStruct)
	{
		if (!FFrameRateChangedPayload_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FrameRateChangedPayload");
			PreviousFrameRate = default(FFrameRate);
		}
		else
		{
			PreviousFrameRate = BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(nativeStruct, PreviousFrameRate_Offset));
		}
	}

	static FFrameRateChangedPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFrameRateChangedPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFrameRateChangedPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FrameRateChangedPayload");
		FFrameRateChangedPayload_StructSize = NativeReflection.GetStructSize(intPtr);
		PreviousFrameRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreviousFrameRate");
		PreviousFrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreviousFrameRate", Classes.FStructProperty);
		FFrameRateChangedPayload_IsValid = intPtr != IntPtr.Zero && PreviousFrameRate_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.FrameRateChangedPayload", FFrameRateChangedPayload_IsValid);
	}
}
