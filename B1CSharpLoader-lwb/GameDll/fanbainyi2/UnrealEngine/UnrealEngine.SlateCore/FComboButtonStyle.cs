using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ComboButtonStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FComboButtonStyle
{
	private static bool ButtonStyle_IsValid;

	private static int ButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:ButtonStyle")]
	public FButtonStyle ButtonStyle;

	private static bool DownArrowImage_IsValid;

	private static int DownArrowImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:DownArrowImage")]
	public FSlateBrush DownArrowImage;

	private static bool ShadowOffset_IsValid;

	private static int ShadowOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:ShadowOffset")]
	public FVector2D ShadowOffset;

	private static bool ShadowColorAndOpacity_IsValid;

	private static int ShadowColorAndOpacity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:ShadowColorAndOpacity")]
	public FLinearColor ShadowColorAndOpacity;

	private static bool MenuBorderBrush_IsValid;

	private static int MenuBorderBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:MenuBorderBrush")]
	public FSlateBrush MenuBorderBrush;

	private static bool MenuBorderPadding_IsValid;

	private static int MenuBorderPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:MenuBorderPadding")]
	public FMargin MenuBorderPadding;

	private static bool ContentPadding_IsValid;

	private static int ContentPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:ContentPadding")]
	public FMargin ContentPadding;

	private static bool DownArrowPadding_IsValid;

	private static int DownArrowPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:DownArrowPadding")]
	public FMargin DownArrowPadding;

	private static bool DownArrowAlign_IsValid;

	private static FFieldAddress DownArrowAlign_PropertyAddress;

	private static int DownArrowAlign_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ComboButtonStyle:DownArrowAlign")]
	public EVerticalAlignment DownArrowAlign;

	private static bool FComboButtonStyle_IsValid;

	private static int FComboButtonStyle_StructSize;

	public FComboButtonStyle Copy()
	{
		return this;
	}

	public static FComboButtonStyle FromNative(IntPtr nativeBuffer)
	{
		return new FComboButtonStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComboButtonStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComboButtonStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComboButtonStyle(nativeBuffer + arrayIndex * FComboButtonStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComboButtonStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FComboButtonStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FComboButtonStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ComboButtonStyle");
			return;
		}
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, ButtonStyle_Offset), ButtonStyle);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DownArrowImage_Offset), DownArrowImage);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ShadowOffset_Offset), ShadowOffset);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, ShadowColorAndOpacity_Offset), ShadowColorAndOpacity);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, MenuBorderBrush_Offset), MenuBorderBrush);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, MenuBorderPadding_Offset), MenuBorderPadding);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, ContentPadding_Offset), ContentPadding);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, DownArrowPadding_Offset), DownArrowPadding);
		EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(nativeStruct, DownArrowAlign_Offset), 0, DownArrowAlign_PropertyAddress.Address, DownArrowAlign);
	}

	public FComboButtonStyle(IntPtr nativeStruct)
	{
		if (!FComboButtonStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ComboButtonStyle");
			ButtonStyle = default(FButtonStyle);
			DownArrowImage = default(FSlateBrush);
			ShadowOffset = default(FVector2D);
			ShadowColorAndOpacity = default(FLinearColor);
			MenuBorderBrush = default(FSlateBrush);
			MenuBorderPadding = default(FMargin);
			ContentPadding = default(FMargin);
			DownArrowPadding = default(FMargin);
			DownArrowAlign = EVerticalAlignment.VAlign_Fill;
		}
		else
		{
			ButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, ButtonStyle_Offset));
			DownArrowImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DownArrowImage_Offset));
			ShadowOffset = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ShadowOffset_Offset));
			ShadowColorAndOpacity = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, ShadowColorAndOpacity_Offset));
			MenuBorderBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, MenuBorderBrush_Offset));
			MenuBorderPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, MenuBorderPadding_Offset));
			ContentPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, ContentPadding_Offset));
			DownArrowPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, DownArrowPadding_Offset));
			DownArrowAlign = EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(nativeStruct, DownArrowAlign_Offset), 0, DownArrowAlign_PropertyAddress.Address);
		}
	}

	static FComboButtonStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FComboButtonStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComboButtonStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.ComboButtonStyle");
		FComboButtonStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		ButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ButtonStyle");
		ButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ButtonStyle", Classes.FStructProperty);
		DownArrowImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DownArrowImage");
		DownArrowImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DownArrowImage", Classes.FStructProperty);
		ShadowOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowOffset");
		ShadowOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowOffset", Classes.FStructProperty);
		ShadowColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowColorAndOpacity");
		ShadowColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowColorAndOpacity", Classes.FStructProperty);
		MenuBorderBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuBorderBrush");
		MenuBorderBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuBorderBrush", Classes.FStructProperty);
		MenuBorderPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuBorderPadding");
		MenuBorderPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuBorderPadding", Classes.FStructProperty);
		ContentPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContentPadding");
		ContentPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContentPadding", Classes.FStructProperty);
		DownArrowPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DownArrowPadding");
		DownArrowPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DownArrowPadding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DownArrowAlign_PropertyAddress, intPtr, "DownArrowAlign");
		DownArrowAlign_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DownArrowAlign");
		DownArrowAlign_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DownArrowAlign", Classes.FByteProperty);
		FComboButtonStyle_IsValid = intPtr != IntPtr.Zero && ButtonStyle_IsValid && DownArrowImage_IsValid && ShadowOffset_IsValid && ShadowColorAndOpacity_IsValid && MenuBorderBrush_IsValid && MenuBorderPadding_IsValid && ContentPadding_IsValid && DownArrowPadding_IsValid && DownArrowAlign_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ComboButtonStyle", FComboButtonStyle_IsValid);
	}
}
