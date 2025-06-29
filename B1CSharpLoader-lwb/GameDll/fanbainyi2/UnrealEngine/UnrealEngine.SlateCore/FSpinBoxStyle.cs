using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SpinBoxStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FSpinBoxStyle
{
	private static bool BackgroundBrush_IsValid;

	private static int BackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:BackgroundBrush")]
	public FSlateBrush BackgroundBrush;

	private static bool ActiveBackgroundBrush_IsValid;

	private static int ActiveBackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:ActiveBackgroundBrush")]
	public FSlateBrush ActiveBackgroundBrush;

	private static bool HoveredBackgroundBrush_IsValid;

	private static int HoveredBackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:HoveredBackgroundBrush")]
	public FSlateBrush HoveredBackgroundBrush;

	private static bool ActiveFillBrush_IsValid;

	private static int ActiveFillBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:ActiveFillBrush")]
	public FSlateBrush ActiveFillBrush;

	private static bool HoveredFillBrush_IsValid;

	private static int HoveredFillBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:HoveredFillBrush")]
	public FSlateBrush HoveredFillBrush;

	private static bool InactiveFillBrush_IsValid;

	private static int InactiveFillBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:InactiveFillBrush")]
	public FSlateBrush InactiveFillBrush;

	private static bool ArrowsImage_IsValid;

	private static int ArrowsImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:ArrowsImage")]
	public FSlateBrush ArrowsImage;

	private static bool TextPadding_IsValid;

	private static int TextPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:TextPadding")]
	public FMargin TextPadding;

	private static bool InsetPadding_IsValid;

	private static int InsetPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.SpinBoxStyle:InsetPadding")]
	public FMargin InsetPadding;

	private static bool FSpinBoxStyle_IsValid;

	private static int FSpinBoxStyle_StructSize;

	public FSpinBoxStyle Copy()
	{
		return this;
	}

	public static FSpinBoxStyle FromNative(IntPtr nativeBuffer)
	{
		return new FSpinBoxStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpinBoxStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpinBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpinBoxStyle(nativeBuffer + arrayIndex * FSpinBoxStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpinBoxStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSpinBoxStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSpinBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SpinBoxStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset), BackgroundBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ActiveBackgroundBrush_Offset), ActiveBackgroundBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HoveredBackgroundBrush_Offset), HoveredBackgroundBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ActiveFillBrush_Offset), ActiveFillBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HoveredFillBrush_Offset), HoveredFillBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, InactiveFillBrush_Offset), InactiveFillBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ArrowsImage_Offset), ArrowsImage);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, TextPadding_Offset), TextPadding);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, InsetPadding_Offset), InsetPadding);
	}

	public FSpinBoxStyle(IntPtr nativeStruct)
	{
		if (!FSpinBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SpinBoxStyle");
			BackgroundBrush = default(FSlateBrush);
			ActiveBackgroundBrush = default(FSlateBrush);
			HoveredBackgroundBrush = default(FSlateBrush);
			ActiveFillBrush = default(FSlateBrush);
			HoveredFillBrush = default(FSlateBrush);
			InactiveFillBrush = default(FSlateBrush);
			ArrowsImage = default(FSlateBrush);
			TextPadding = default(FMargin);
			InsetPadding = default(FMargin);
		}
		else
		{
			BackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset));
			ActiveBackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ActiveBackgroundBrush_Offset));
			HoveredBackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HoveredBackgroundBrush_Offset));
			ActiveFillBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ActiveFillBrush_Offset));
			HoveredFillBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HoveredFillBrush_Offset));
			InactiveFillBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, InactiveFillBrush_Offset));
			ArrowsImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ArrowsImage_Offset));
			TextPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, TextPadding_Offset));
			InsetPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, InsetPadding_Offset));
		}
	}

	static FSpinBoxStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSpinBoxStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpinBoxStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SpinBoxStyle");
		FSpinBoxStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		BackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundBrush");
		BackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundBrush", Classes.FStructProperty);
		ActiveBackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveBackgroundBrush");
		ActiveBackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveBackgroundBrush", Classes.FStructProperty);
		HoveredBackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredBackgroundBrush");
		HoveredBackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredBackgroundBrush", Classes.FStructProperty);
		ActiveFillBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveFillBrush");
		ActiveFillBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveFillBrush", Classes.FStructProperty);
		HoveredFillBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredFillBrush");
		HoveredFillBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredFillBrush", Classes.FStructProperty);
		InactiveFillBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InactiveFillBrush");
		InactiveFillBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InactiveFillBrush", Classes.FStructProperty);
		ArrowsImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrowsImage");
		ArrowsImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrowsImage", Classes.FStructProperty);
		TextPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextPadding");
		TextPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextPadding", Classes.FStructProperty);
		InsetPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InsetPadding");
		InsetPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InsetPadding", Classes.FStructProperty);
		FSpinBoxStyle_IsValid = intPtr != IntPtr.Zero && BackgroundBrush_IsValid && ActiveBackgroundBrush_IsValid && HoveredBackgroundBrush_IsValid && ActiveFillBrush_IsValid && HoveredFillBrush_IsValid && InactiveFillBrush_IsValid && ArrowsImage_IsValid && TextPadding_IsValid && InsetPadding_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SpinBoxStyle", FSpinBoxStyle_IsValid);
	}
}
