using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 6155)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FrameNumber", "CoreUObject", UnrealModuleType.Engine)]
public struct FFrameNumber
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.FrameNumber:Value")]
	public int Value;

	private static bool FFrameNumber_IsValid;

	private static int FFrameNumber_StructSize;

	public FFrameNumber Copy()
	{
		return this;
	}

	public static FFrameNumber FromNative(IntPtr nativeBuffer)
	{
		return new FFrameNumber(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFrameNumber value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFrameNumber FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFrameNumber(nativeBuffer + arrayIndex * FFrameNumber_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFrameNumber value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFrameNumber_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFrameNumber_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameNumber");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		}
	}

	public FFrameNumber(IntPtr nativeStruct)
	{
		if (!FFrameNumber_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FrameNumber");
			Value = 0;
		}
		else
		{
			Value = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FFrameNumber()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFrameNumber)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFrameNumber));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.FrameNumber");
		FFrameNumber_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FIntProperty);
		FFrameNumber_IsValid = intPtr != IntPtr.Zero && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.FrameNumber", FFrameNumber_IsValid);
	}
}
