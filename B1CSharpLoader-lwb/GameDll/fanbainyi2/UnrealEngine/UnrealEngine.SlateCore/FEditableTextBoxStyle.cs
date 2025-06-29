using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EditableTextBoxStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FEditableTextBoxStyle
{
	private static bool BackgroundImageNormal_IsValid;

	private static int BackgroundImageNormal_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:BackgroundImageNormal")]
	public FSlateBrush BackgroundImageNormal;

	private static bool BackgroundImageHovered_IsValid;

	private static int BackgroundImageHovered_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:BackgroundImageHovered")]
	public FSlateBrush BackgroundImageHovered;

	private static bool BackgroundImageFocused_IsValid;

	private static int BackgroundImageFocused_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:BackgroundImageFocused")]
	public FSlateBrush BackgroundImageFocused;

	private static bool BackgroundImageReadOnly_IsValid;

	private static int BackgroundImageReadOnly_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:BackgroundImageReadOnly")]
	public FSlateBrush BackgroundImageReadOnly;

	private static bool Padding_IsValid;

	private static int Padding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:Padding")]
	public FMargin Padding;

	private static bool Font_IsValid;

	private static int Font_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:Font")]
	public FSlateFontInfo Font;

	private static bool ForegroundColor_IsValid;

	private static int ForegroundColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:ForegroundColor")]
	public FSlateColor ForegroundColor;

	private static bool BackgroundColor_IsValid;

	private static int BackgroundColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:BackgroundColor")]
	public FSlateColor BackgroundColor;

	private static bool ReadOnlyForegroundColor_IsValid;

	private static int ReadOnlyForegroundColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:ReadOnlyForegroundColor")]
	public FSlateColor ReadOnlyForegroundColor;

	private static bool FocusedForegroundColor_IsValid;

	private static int FocusedForegroundColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:FocusedForegroundColor")]
	public FSlateColor FocusedForegroundColor;

	private static bool HScrollBarPadding_IsValid;

	private static int HScrollBarPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:HScrollBarPadding")]
	public FMargin HScrollBarPadding;

	private static bool VScrollBarPadding_IsValid;

	private static int VScrollBarPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:VScrollBarPadding")]
	public FMargin VScrollBarPadding;

	private static bool ScrollBarStyle_IsValid;

	private static int ScrollBarStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.EditableTextBoxStyle:ScrollBarStyle")]
	public FScrollBarStyle ScrollBarStyle;

	private static bool FEditableTextBoxStyle_IsValid;

	private static int FEditableTextBoxStyle_StructSize;

	public FEditableTextBoxStyle Copy()
	{
		return this;
	}

	public static FEditableTextBoxStyle FromNative(IntPtr nativeBuffer)
	{
		return new FEditableTextBoxStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditableTextBoxStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditableTextBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditableTextBoxStyle(nativeBuffer + arrayIndex * FEditableTextBoxStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditableTextBoxStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditableTextBoxStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditableTextBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.EditableTextBoxStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImageNormal_Offset), BackgroundImageNormal);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImageHovered_Offset), BackgroundImageHovered);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImageFocused_Offset), BackgroundImageFocused);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImageReadOnly_Offset), BackgroundImageReadOnly);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, Padding_Offset), Padding);
		FSlateFontInfo.ToNative(IntPtr.Add(nativeStruct, Font_Offset), Font);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, ForegroundColor_Offset), ForegroundColor);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, BackgroundColor_Offset), BackgroundColor);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, ReadOnlyForegroundColor_Offset), ReadOnlyForegroundColor);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, FocusedForegroundColor_Offset), FocusedForegroundColor);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, HScrollBarPadding_Offset), HScrollBarPadding);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, VScrollBarPadding_Offset), VScrollBarPadding);
		FScrollBarStyle.ToNative(IntPtr.Add(nativeStruct, ScrollBarStyle_Offset), ScrollBarStyle);
	}

	public FEditableTextBoxStyle(IntPtr nativeStruct)
	{
		if (!FEditableTextBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.EditableTextBoxStyle");
			BackgroundImageNormal = default(FSlateBrush);
			BackgroundImageHovered = default(FSlateBrush);
			BackgroundImageFocused = default(FSlateBrush);
			BackgroundImageReadOnly = default(FSlateBrush);
			Padding = default(FMargin);
			Font = default(FSlateFontInfo);
			ForegroundColor = default(FSlateColor);
			BackgroundColor = default(FSlateColor);
			ReadOnlyForegroundColor = default(FSlateColor);
			FocusedForegroundColor = default(FSlateColor);
			HScrollBarPadding = default(FMargin);
			VScrollBarPadding = default(FMargin);
			ScrollBarStyle = default(FScrollBarStyle);
		}
		else
		{
			BackgroundImageNormal = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImageNormal_Offset));
			BackgroundImageHovered = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImageHovered_Offset));
			BackgroundImageFocused = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImageFocused_Offset));
			BackgroundImageReadOnly = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImageReadOnly_Offset));
			Padding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, Padding_Offset));
			Font = FSlateFontInfo.FromNative(IntPtr.Add(nativeStruct, Font_Offset));
			ForegroundColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, ForegroundColor_Offset));
			BackgroundColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, BackgroundColor_Offset));
			ReadOnlyForegroundColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, ReadOnlyForegroundColor_Offset));
			FocusedForegroundColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, FocusedForegroundColor_Offset));
			HScrollBarPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, HScrollBarPadding_Offset));
			VScrollBarPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, VScrollBarPadding_Offset));
			ScrollBarStyle = FScrollBarStyle.FromNative(IntPtr.Add(nativeStruct, ScrollBarStyle_Offset));
		}
	}

	static FEditableTextBoxStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditableTextBoxStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditableTextBoxStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.EditableTextBoxStyle");
		FEditableTextBoxStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		BackgroundImageNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImageNormal");
		BackgroundImageNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImageNormal", Classes.FStructProperty);
		BackgroundImageHovered_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImageHovered");
		BackgroundImageHovered_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImageHovered", Classes.FStructProperty);
		BackgroundImageFocused_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImageFocused");
		BackgroundImageFocused_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImageFocused", Classes.FStructProperty);
		BackgroundImageReadOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImageReadOnly");
		BackgroundImageReadOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImageReadOnly", Classes.FStructProperty);
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FStructProperty);
		ForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForegroundColor");
		ForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForegroundColor", Classes.FStructProperty);
		BackgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundColor");
		BackgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundColor", Classes.FStructProperty);
		ReadOnlyForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReadOnlyForegroundColor");
		ReadOnlyForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReadOnlyForegroundColor", Classes.FStructProperty);
		FocusedForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusedForegroundColor");
		FocusedForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusedForegroundColor", Classes.FStructProperty);
		HScrollBarPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HScrollBarPadding");
		HScrollBarPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HScrollBarPadding", Classes.FStructProperty);
		VScrollBarPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VScrollBarPadding");
		VScrollBarPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VScrollBarPadding", Classes.FStructProperty);
		ScrollBarStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrollBarStyle");
		ScrollBarStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrollBarStyle", Classes.FStructProperty);
		FEditableTextBoxStyle_IsValid = intPtr != IntPtr.Zero && BackgroundImageNormal_IsValid && BackgroundImageHovered_IsValid && BackgroundImageFocused_IsValid && BackgroundImageReadOnly_IsValid && Padding_IsValid && Font_IsValid && ForegroundColor_IsValid && BackgroundColor_IsValid && ReadOnlyForegroundColor_IsValid && FocusedForegroundColor_IsValid && HScrollBarPadding_IsValid && VScrollBarPadding_IsValid && ScrollBarStyle_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.EditableTextBoxStyle", FEditableTextBoxStyle_IsValid);
	}
}
