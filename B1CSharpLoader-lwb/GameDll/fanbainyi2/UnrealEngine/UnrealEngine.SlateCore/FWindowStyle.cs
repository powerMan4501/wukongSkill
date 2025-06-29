using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.WindowStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FWindowStyle
{
	private static bool MinimizeButtonStyle_IsValid;

	private static int MinimizeButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:MinimizeButtonStyle")]
	public FButtonStyle MinimizeButtonStyle;

	private static bool MaximizeButtonStyle_IsValid;

	private static int MaximizeButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:MaximizeButtonStyle")]
	public FButtonStyle MaximizeButtonStyle;

	private static bool RestoreButtonStyle_IsValid;

	private static int RestoreButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:RestoreButtonStyle")]
	public FButtonStyle RestoreButtonStyle;

	private static bool CloseButtonStyle_IsValid;

	private static int CloseButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:CloseButtonStyle")]
	public FButtonStyle CloseButtonStyle;

	private static bool TitleTextStyle_IsValid;

	private static int TitleTextStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:TitleTextStyle")]
	public FTextBlockStyle TitleTextStyle;

	private static bool ActiveTitleBrush_IsValid;

	private static int ActiveTitleBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:ActiveTitleBrush")]
	public FSlateBrush ActiveTitleBrush;

	private static bool InactiveTitleBrush_IsValid;

	private static int InactiveTitleBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:InactiveTitleBrush")]
	public FSlateBrush InactiveTitleBrush;

	private static bool FlashTitleBrush_IsValid;

	private static int FlashTitleBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:FlashTitleBrush")]
	public FSlateBrush FlashTitleBrush;

	private static bool BackgroundColor_IsValid;

	private static int BackgroundColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:BackgroundColor")]
	public FSlateColor BackgroundColor;

	private static bool OutlineBrush_IsValid;

	private static int OutlineBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:OutlineBrush")]
	public FSlateBrush OutlineBrush;

	private static bool OutlineColor_IsValid;

	private static int OutlineColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:OutlineColor")]
	public FSlateColor OutlineColor;

	private static bool BorderBrush_IsValid;

	private static int BorderBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:BorderBrush")]
	public FSlateBrush BorderBrush;

	private static bool BorderColor_IsValid;

	private static int BorderColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:BorderColor")]
	public FSlateColor BorderColor;

	private static bool BackgroundBrush_IsValid;

	private static int BackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:BackgroundBrush")]
	public FSlateBrush BackgroundBrush;

	private static bool ChildBackgroundBrush_IsValid;

	private static int ChildBackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:ChildBackgroundBrush")]
	public FSlateBrush ChildBackgroundBrush;

	private static bool WindowCornerRadius_IsValid;

	private static int WindowCornerRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:WindowCornerRadius")]
	public int WindowCornerRadius;

	private static bool BorderPadding_IsValid;

	private static int BorderPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.WindowStyle:BorderPadding")]
	public FMargin BorderPadding;

	private static bool FWindowStyle_IsValid;

	private static int FWindowStyle_StructSize;

	public FWindowStyle Copy()
	{
		return this;
	}

	public static FWindowStyle FromNative(IntPtr nativeBuffer)
	{
		return new FWindowStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWindowStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWindowStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWindowStyle(nativeBuffer + arrayIndex * FWindowStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWindowStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWindowStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWindowStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.WindowStyle");
			return;
		}
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, MinimizeButtonStyle_Offset), MinimizeButtonStyle);
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, MaximizeButtonStyle_Offset), MaximizeButtonStyle);
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, RestoreButtonStyle_Offset), RestoreButtonStyle);
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, CloseButtonStyle_Offset), CloseButtonStyle);
		FTextBlockStyle.ToNative(IntPtr.Add(nativeStruct, TitleTextStyle_Offset), TitleTextStyle);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ActiveTitleBrush_Offset), ActiveTitleBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, InactiveTitleBrush_Offset), InactiveTitleBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, FlashTitleBrush_Offset), FlashTitleBrush);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, BackgroundColor_Offset), BackgroundColor);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, OutlineBrush_Offset), OutlineBrush);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, OutlineColor_Offset), OutlineColor);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BorderBrush_Offset), BorderBrush);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, BorderColor_Offset), BorderColor);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset), BackgroundBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ChildBackgroundBrush_Offset), ChildBackgroundBrush);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, WindowCornerRadius_Offset), WindowCornerRadius);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, BorderPadding_Offset), BorderPadding);
	}

	public FWindowStyle(IntPtr nativeStruct)
	{
		if (!FWindowStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.WindowStyle");
			MinimizeButtonStyle = default(FButtonStyle);
			MaximizeButtonStyle = default(FButtonStyle);
			RestoreButtonStyle = default(FButtonStyle);
			CloseButtonStyle = default(FButtonStyle);
			TitleTextStyle = default(FTextBlockStyle);
			ActiveTitleBrush = default(FSlateBrush);
			InactiveTitleBrush = default(FSlateBrush);
			FlashTitleBrush = default(FSlateBrush);
			BackgroundColor = default(FSlateColor);
			OutlineBrush = default(FSlateBrush);
			OutlineColor = default(FSlateColor);
			BorderBrush = default(FSlateBrush);
			BorderColor = default(FSlateColor);
			BackgroundBrush = default(FSlateBrush);
			ChildBackgroundBrush = default(FSlateBrush);
			WindowCornerRadius = 0;
			BorderPadding = default(FMargin);
		}
		else
		{
			MinimizeButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, MinimizeButtonStyle_Offset));
			MaximizeButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, MaximizeButtonStyle_Offset));
			RestoreButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, RestoreButtonStyle_Offset));
			CloseButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, CloseButtonStyle_Offset));
			TitleTextStyle = FTextBlockStyle.FromNative(IntPtr.Add(nativeStruct, TitleTextStyle_Offset));
			ActiveTitleBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ActiveTitleBrush_Offset));
			InactiveTitleBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, InactiveTitleBrush_Offset));
			FlashTitleBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, FlashTitleBrush_Offset));
			BackgroundColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, BackgroundColor_Offset));
			OutlineBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, OutlineBrush_Offset));
			OutlineColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, OutlineColor_Offset));
			BorderBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BorderBrush_Offset));
			BorderColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, BorderColor_Offset));
			BackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset));
			ChildBackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ChildBackgroundBrush_Offset));
			WindowCornerRadius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, WindowCornerRadius_Offset));
			BorderPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, BorderPadding_Offset));
		}
	}

	static FWindowStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWindowStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWindowStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.WindowStyle");
		FWindowStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		MinimizeButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimizeButtonStyle");
		MinimizeButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimizeButtonStyle", Classes.FStructProperty);
		MaximizeButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximizeButtonStyle");
		MaximizeButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximizeButtonStyle", Classes.FStructProperty);
		RestoreButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RestoreButtonStyle");
		RestoreButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RestoreButtonStyle", Classes.FStructProperty);
		CloseButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloseButtonStyle");
		CloseButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloseButtonStyle", Classes.FStructProperty);
		TitleTextStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TitleTextStyle");
		TitleTextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TitleTextStyle", Classes.FStructProperty);
		ActiveTitleBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveTitleBrush");
		ActiveTitleBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveTitleBrush", Classes.FStructProperty);
		InactiveTitleBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InactiveTitleBrush");
		InactiveTitleBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InactiveTitleBrush", Classes.FStructProperty);
		FlashTitleBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FlashTitleBrush");
		FlashTitleBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FlashTitleBrush", Classes.FStructProperty);
		BackgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundColor");
		BackgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundColor", Classes.FStructProperty);
		OutlineBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutlineBrush");
		OutlineBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutlineBrush", Classes.FStructProperty);
		OutlineColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutlineColor");
		OutlineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutlineColor", Classes.FStructProperty);
		BorderBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BorderBrush");
		BorderBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BorderBrush", Classes.FStructProperty);
		BorderColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BorderColor");
		BorderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BorderColor", Classes.FStructProperty);
		BackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundBrush");
		BackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundBrush", Classes.FStructProperty);
		ChildBackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChildBackgroundBrush");
		ChildBackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChildBackgroundBrush", Classes.FStructProperty);
		WindowCornerRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindowCornerRadius");
		WindowCornerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindowCornerRadius", Classes.FIntProperty);
		BorderPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BorderPadding");
		BorderPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BorderPadding", Classes.FStructProperty);
		FWindowStyle_IsValid = intPtr != IntPtr.Zero && MinimizeButtonStyle_IsValid && MaximizeButtonStyle_IsValid && RestoreButtonStyle_IsValid && CloseButtonStyle_IsValid && TitleTextStyle_IsValid && ActiveTitleBrush_IsValid && InactiveTitleBrush_IsValid && FlashTitleBrush_IsValid && BackgroundColor_IsValid && OutlineBrush_IsValid && OutlineColor_IsValid && BorderBrush_IsValid && BorderColor_IsValid && BackgroundBrush_IsValid && ChildBackgroundBrush_IsValid && WindowCornerRadius_IsValid && BorderPadding_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.WindowStyle", FWindowStyle_IsValid);
	}
}
