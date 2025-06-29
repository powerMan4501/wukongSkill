using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EditableTextStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FEditableTextStyle
{
	private static bool Font_IsValid;

	private static int Font_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/SlateCore.EditableTextStyle:Font")]
	public FSlateFontInfo Font;

	private static bool ColorAndOpacity_IsValid;

	private static int ColorAndOpacity_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextStyle:ColorAndOpacity")]
	public FSlateColor ColorAndOpacity;

	private static bool BackgroundImageSelected_IsValid;

	private static int BackgroundImageSelected_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextStyle:BackgroundImageSelected")]
	public FSlateBrush BackgroundImageSelected;

	private static bool BackgroundImageComposing_IsValid;

	private static int BackgroundImageComposing_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextStyle:BackgroundImageComposing")]
	public FSlateBrush BackgroundImageComposing;

	private static bool CaretImage_IsValid;

	private static int CaretImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextStyle:CaretImage")]
	public FSlateBrush CaretImage;

	private static bool FEditableTextStyle_IsValid;

	private static int FEditableTextStyle_StructSize;

	public FEditableTextStyle Copy()
	{
		return this;
	}

	public static FEditableTextStyle FromNative(IntPtr nativeBuffer)
	{
		return new FEditableTextStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditableTextStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditableTextStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditableTextStyle(nativeBuffer + arrayIndex * FEditableTextStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditableTextStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditableTextStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditableTextStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.EditableTextStyle");
			return;
		}
		FSlateFontInfo.ToNative(IntPtr.Add(nativeStruct, Font_Offset), Font);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, ColorAndOpacity_Offset), ColorAndOpacity);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImageSelected_Offset), BackgroundImageSelected);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImageComposing_Offset), BackgroundImageComposing);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, CaretImage_Offset), CaretImage);
	}

	public FEditableTextStyle(IntPtr nativeStruct)
	{
		if (!FEditableTextStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.EditableTextStyle");
			Font = default(FSlateFontInfo);
			ColorAndOpacity = default(FSlateColor);
			BackgroundImageSelected = default(FSlateBrush);
			BackgroundImageComposing = default(FSlateBrush);
			CaretImage = default(FSlateBrush);
		}
		else
		{
			Font = FSlateFontInfo.FromNative(IntPtr.Add(nativeStruct, Font_Offset));
			ColorAndOpacity = FSlateColor.FromNative(IntPtr.Add(nativeStruct, ColorAndOpacity_Offset));
			BackgroundImageSelected = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImageSelected_Offset));
			BackgroundImageComposing = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImageComposing_Offset));
			CaretImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, CaretImage_Offset));
		}
	}

	static FEditableTextStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditableTextStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditableTextStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.EditableTextStyle");
		FEditableTextStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FStructProperty);
		ColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorAndOpacity");
		ColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorAndOpacity", Classes.FStructProperty);
		BackgroundImageSelected_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImageSelected");
		BackgroundImageSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImageSelected", Classes.FStructProperty);
		BackgroundImageComposing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImageComposing");
		BackgroundImageComposing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImageComposing", Classes.FStructProperty);
		CaretImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaretImage");
		CaretImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaretImage", Classes.FStructProperty);
		FEditableTextStyle_IsValid = intPtr != IntPtr.Zero && Font_IsValid && ColorAndOpacity_IsValid && BackgroundImageSelected_IsValid && BackgroundImageComposing_IsValid && CaretImage_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.EditableTextStyle", FEditableTextStyle_IsValid);
	}
}
