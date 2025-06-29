using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 528897)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SlateSound", "SlateCore", UnrealModuleType.Engine)]
public struct FSlateSound
{
	private static bool ResourceObject_IsValid;

	private static int ResourceObject_Offset;

	[UProperty(Flags = (PropFlags)12393764861510149uL)]
	[UMetaPath("/Script/SlateCore.SlateSound:ResourceObject")]
	public UObject ResourceObject;

	private static bool FSlateSound_IsValid;

	private static int FSlateSound_StructSize;

	public FSlateSound Copy()
	{
		return this;
	}

	public static FSlateSound FromNative(IntPtr nativeBuffer)
	{
		return new FSlateSound(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSlateSound value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSlateSound FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSlateSound(nativeBuffer + arrayIndex * FSlateSound_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSlateSound value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSlateSound_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSlateSound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateSound");
		}
		else
		{
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, ResourceObject_Offset), ResourceObject);
		}
	}

	public FSlateSound(IntPtr nativeStruct)
	{
		if (!FSlateSound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateSound");
			ResourceObject = null;
		}
		else
		{
			ResourceObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, ResourceObject_Offset));
		}
	}

	static FSlateSound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSlateSound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSlateSound));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SlateSound");
		FSlateSound_StructSize = NativeReflection.GetStructSize(intPtr);
		ResourceObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ResourceObject");
		ResourceObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ResourceObject", Classes.FObjectProperty);
		FSlateSound_IsValid = intPtr != IntPtr.Zero && ResourceObject_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SlateSound", FSlateSound_IsValid);
	}
}
