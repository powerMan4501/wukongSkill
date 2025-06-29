using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 528897)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SlateColor", "SlateCore", UnrealModuleType.Engine)]
public struct FSlateColor
{
	private static bool SpecifiedColor_IsValid;

	private static int SpecifiedColor_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/SlateCore.SlateColor:SpecifiedColor")]
	public FLinearColor SpecifiedColor;

	private static bool ColorUseRule_IsValid;

	private static FFieldAddress ColorUseRule_PropertyAddress;

	private static int ColorUseRule_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/SlateCore.SlateColor:ColorUseRule")]
	public ESlateColorStylingMode ColorUseRule;

	private static bool FSlateColor_IsValid;

	private static int FSlateColor_StructSize;

	public FSlateColor Copy()
	{
		return this;
	}

	public static FSlateColor FromNative(IntPtr nativeBuffer)
	{
		return new FSlateColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSlateColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSlateColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSlateColor(nativeBuffer + arrayIndex * FSlateColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSlateColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSlateColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSlateColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateColor");
			return;
		}
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, SpecifiedColor_Offset), SpecifiedColor);
		EnumMarshaler<ESlateColorStylingMode>.ToNative(IntPtr.Add(nativeStruct, ColorUseRule_Offset), 0, ColorUseRule_PropertyAddress.Address, ColorUseRule);
	}

	public FSlateColor(IntPtr nativeStruct)
	{
		if (!FSlateColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateColor");
			SpecifiedColor = default(FLinearColor);
			ColorUseRule = ESlateColorStylingMode.UseColor_Specified;
		}
		else
		{
			SpecifiedColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, SpecifiedColor_Offset));
			ColorUseRule = EnumMarshaler<ESlateColorStylingMode>.FromNative(IntPtr.Add(nativeStruct, ColorUseRule_Offset), 0, ColorUseRule_PropertyAddress.Address);
		}
	}

	static FSlateColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSlateColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSlateColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SlateColor");
		FSlateColor_StructSize = NativeReflection.GetStructSize(intPtr);
		SpecifiedColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpecifiedColor");
		SpecifiedColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpecifiedColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ColorUseRule_PropertyAddress, intPtr, "ColorUseRule");
		ColorUseRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorUseRule");
		ColorUseRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorUseRule", Classes.FEnumProperty);
		FSlateColor_IsValid = intPtr != IntPtr.Zero && SpecifiedColor_IsValid && ColorUseRule_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SlateColor", FSlateColor_IsValid);
	}
}
