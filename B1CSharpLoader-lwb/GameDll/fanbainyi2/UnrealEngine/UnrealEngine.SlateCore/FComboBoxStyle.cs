using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ComboBoxStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FComboBoxStyle
{
	private static bool ComboButtonStyle_IsValid;

	private static int ComboButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ComboBoxStyle:ComboButtonStyle")]
	public FComboButtonStyle ComboButtonStyle;

	private static bool PressedSlateSound_IsValid;

	private static int PressedSlateSound_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SlateCore.ComboBoxStyle:PressedSlateSound")]
	public FSlateSound PressedSlateSound;

	private static bool SelectionChangeSlateSound_IsValid;

	private static int SelectionChangeSlateSound_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SlateCore.ComboBoxStyle:SelectionChangeSlateSound")]
	public FSlateSound SelectionChangeSlateSound;

	private static bool ContentPadding_IsValid;

	private static int ContentPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ComboBoxStyle:ContentPadding")]
	public FMargin ContentPadding;

	private static bool MenuRowPadding_IsValid;

	private static int MenuRowPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ComboBoxStyle:MenuRowPadding")]
	public FMargin MenuRowPadding;

	private static bool FComboBoxStyle_IsValid;

	private static int FComboBoxStyle_StructSize;

	public FComboBoxStyle Copy()
	{
		return this;
	}

	public static FComboBoxStyle FromNative(IntPtr nativeBuffer)
	{
		return new FComboBoxStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComboBoxStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComboBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComboBoxStyle(nativeBuffer + arrayIndex * FComboBoxStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComboBoxStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FComboBoxStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FComboBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ComboBoxStyle");
			return;
		}
		FComboButtonStyle.ToNative(IntPtr.Add(nativeStruct, ComboButtonStyle_Offset), ComboButtonStyle);
		FSlateSound.ToNative(IntPtr.Add(nativeStruct, PressedSlateSound_Offset), PressedSlateSound);
		FSlateSound.ToNative(IntPtr.Add(nativeStruct, SelectionChangeSlateSound_Offset), SelectionChangeSlateSound);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, ContentPadding_Offset), ContentPadding);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, MenuRowPadding_Offset), MenuRowPadding);
	}

	public FComboBoxStyle(IntPtr nativeStruct)
	{
		if (!FComboBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ComboBoxStyle");
			ComboButtonStyle = default(FComboButtonStyle);
			PressedSlateSound = default(FSlateSound);
			SelectionChangeSlateSound = default(FSlateSound);
			ContentPadding = default(FMargin);
			MenuRowPadding = default(FMargin);
		}
		else
		{
			ComboButtonStyle = FComboButtonStyle.FromNative(IntPtr.Add(nativeStruct, ComboButtonStyle_Offset));
			PressedSlateSound = FSlateSound.FromNative(IntPtr.Add(nativeStruct, PressedSlateSound_Offset));
			SelectionChangeSlateSound = FSlateSound.FromNative(IntPtr.Add(nativeStruct, SelectionChangeSlateSound_Offset));
			ContentPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, ContentPadding_Offset));
			MenuRowPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, MenuRowPadding_Offset));
		}
	}

	static FComboBoxStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FComboBoxStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComboBoxStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.ComboBoxStyle");
		FComboBoxStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		ComboButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComboButtonStyle");
		ComboButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComboButtonStyle", Classes.FStructProperty);
		PressedSlateSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressedSlateSound");
		PressedSlateSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressedSlateSound", Classes.FStructProperty);
		SelectionChangeSlateSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectionChangeSlateSound");
		SelectionChangeSlateSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectionChangeSlateSound", Classes.FStructProperty);
		ContentPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContentPadding");
		ContentPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContentPadding", Classes.FStructProperty);
		MenuRowPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MenuRowPadding");
		MenuRowPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MenuRowPadding", Classes.FStructProperty);
		FComboBoxStyle_IsValid = intPtr != IntPtr.Zero && ComboButtonStyle_IsValid && PressedSlateSound_IsValid && SelectionChangeSlateSound_IsValid && ContentPadding_IsValid && MenuRowPadding_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ComboBoxStyle", FComboBoxStyle_IsValid);
	}
}
