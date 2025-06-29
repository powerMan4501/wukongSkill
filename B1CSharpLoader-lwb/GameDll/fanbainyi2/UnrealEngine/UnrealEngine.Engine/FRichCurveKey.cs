using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 59907)]
[BlueprintType]
[UMetaPath("/Script/Engine.RichCurveKey", "Engine", UnrealModuleType.Engine)]
public struct FRichCurveKey
{
	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RichCurveKey:Time")]
	public float Time;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RichCurveKey:Value")]
	public float Value;

	private static bool FRichCurveKey_IsValid;

	private static int FRichCurveKey_StructSize;

	public FRichCurveKey Copy()
	{
		return this;
	}

	public static FRichCurveKey FromNative(IntPtr nativeBuffer)
	{
		return new FRichCurveKey(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRichCurveKey value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRichCurveKey FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRichCurveKey(nativeBuffer + arrayIndex * FRichCurveKey_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRichCurveKey value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRichCurveKey_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRichCurveKey_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RichCurveKey");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FRichCurveKey(IntPtr nativeStruct)
	{
		if (!FRichCurveKey_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RichCurveKey");
			Time = 0f;
			Value = 0f;
		}
		else
		{
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FRichCurveKey()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRichCurveKey)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRichCurveKey));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.RichCurveKey");
		FRichCurveKey_StructSize = NativeReflection.GetStructSize(intPtr);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		FRichCurveKey_IsValid = intPtr != IntPtr.Zero && Time_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.RichCurveKey", FRichCurveKey_IsValid);
	}
}
