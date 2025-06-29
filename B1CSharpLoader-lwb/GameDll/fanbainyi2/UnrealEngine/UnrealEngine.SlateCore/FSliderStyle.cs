using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SliderStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FSliderStyle
{
	private static bool NormalBarImage_IsValid;

	private static int NormalBarImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SliderStyle:NormalBarImage")]
	public FSlateBrush NormalBarImage;

	private static bool HoveredBarImage_IsValid;

	private static int HoveredBarImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SliderStyle:HoveredBarImage")]
	public FSlateBrush HoveredBarImage;

	private static bool DisabledBarImage_IsValid;

	private static int DisabledBarImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SliderStyle:DisabledBarImage")]
	public FSlateBrush DisabledBarImage;

	private static bool NormalThumbImage_IsValid;

	private static int NormalThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SliderStyle:NormalThumbImage")]
	public FSlateBrush NormalThumbImage;

	private static bool HoveredThumbImage_IsValid;

	private static int HoveredThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SliderStyle:HoveredThumbImage")]
	public FSlateBrush HoveredThumbImage;

	private static bool DisabledThumbImage_IsValid;

	private static int DisabledThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SliderStyle:DisabledThumbImage")]
	public FSlateBrush DisabledThumbImage;

	private static bool BarThickness_IsValid;

	private static int BarThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SliderStyle:BarThickness")]
	public float BarThickness;

	private static bool FSliderStyle_IsValid;

	private static int FSliderStyle_StructSize;

	public FSliderStyle Copy()
	{
		return this;
	}

	public static FSliderStyle FromNative(IntPtr nativeBuffer)
	{
		return new FSliderStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSliderStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSliderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSliderStyle(nativeBuffer + arrayIndex * FSliderStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSliderStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSliderStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSliderStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SliderStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, NormalBarImage_Offset), NormalBarImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HoveredBarImage_Offset), HoveredBarImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DisabledBarImage_Offset), DisabledBarImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, NormalThumbImage_Offset), NormalThumbImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HoveredThumbImage_Offset), HoveredThumbImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DisabledThumbImage_Offset), DisabledThumbImage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BarThickness_Offset), BarThickness);
	}

	public FSliderStyle(IntPtr nativeStruct)
	{
		if (!FSliderStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SliderStyle");
			NormalBarImage = default(FSlateBrush);
			HoveredBarImage = default(FSlateBrush);
			DisabledBarImage = default(FSlateBrush);
			NormalThumbImage = default(FSlateBrush);
			HoveredThumbImage = default(FSlateBrush);
			DisabledThumbImage = default(FSlateBrush);
			BarThickness = 0f;
		}
		else
		{
			NormalBarImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, NormalBarImage_Offset));
			HoveredBarImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HoveredBarImage_Offset));
			DisabledBarImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DisabledBarImage_Offset));
			NormalThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, NormalThumbImage_Offset));
			HoveredThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HoveredThumbImage_Offset));
			DisabledThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DisabledThumbImage_Offset));
			BarThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BarThickness_Offset));
		}
	}

	static FSliderStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSliderStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSliderStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SliderStyle");
		FSliderStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		NormalBarImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalBarImage");
		NormalBarImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalBarImage", Classes.FStructProperty);
		HoveredBarImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredBarImage");
		HoveredBarImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredBarImage", Classes.FStructProperty);
		DisabledBarImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisabledBarImage");
		DisabledBarImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisabledBarImage", Classes.FStructProperty);
		NormalThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalThumbImage");
		NormalThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalThumbImage", Classes.FStructProperty);
		HoveredThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredThumbImage");
		HoveredThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredThumbImage", Classes.FStructProperty);
		DisabledThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisabledThumbImage");
		DisabledThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisabledThumbImage", Classes.FStructProperty);
		BarThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarThickness");
		BarThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarThickness", Classes.FFloatProperty);
		FSliderStyle_IsValid = intPtr != IntPtr.Zero && NormalBarImage_IsValid && HoveredBarImage_IsValid && DisabledBarImage_IsValid && NormalThumbImage_IsValid && HoveredThumbImage_IsValid && DisabledThumbImage_IsValid && BarThickness_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SliderStyle", FSliderStyle_IsValid);
	}
}
