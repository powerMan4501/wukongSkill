using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SegmentedControlStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FSegmentedControlStyle
{
	private static bool ControlStyle_IsValid;

	private static int ControlStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SegmentedControlStyle:ControlStyle")]
	public FCheckBoxStyle ControlStyle;

	private static bool FirstControlStyle_IsValid;

	private static int FirstControlStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SegmentedControlStyle:FirstControlStyle")]
	public FCheckBoxStyle FirstControlStyle;

	private static bool LastControlStyle_IsValid;

	private static int LastControlStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SegmentedControlStyle:LastControlStyle")]
	public FCheckBoxStyle LastControlStyle;

	private static bool BackgroundBrush_IsValid;

	private static int BackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SegmentedControlStyle:BackgroundBrush")]
	public FSlateBrush BackgroundBrush;

	private static bool UniformPadding_IsValid;

	private static int UniformPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.SegmentedControlStyle:UniformPadding")]
	public FMargin UniformPadding;

	private static bool FSegmentedControlStyle_IsValid;

	private static int FSegmentedControlStyle_StructSize;

	public FSegmentedControlStyle Copy()
	{
		return this;
	}

	public static FSegmentedControlStyle FromNative(IntPtr nativeBuffer)
	{
		return new FSegmentedControlStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSegmentedControlStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSegmentedControlStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSegmentedControlStyle(nativeBuffer + arrayIndex * FSegmentedControlStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSegmentedControlStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSegmentedControlStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSegmentedControlStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SegmentedControlStyle");
			return;
		}
		FCheckBoxStyle.ToNative(IntPtr.Add(nativeStruct, ControlStyle_Offset), ControlStyle);
		FCheckBoxStyle.ToNative(IntPtr.Add(nativeStruct, FirstControlStyle_Offset), FirstControlStyle);
		FCheckBoxStyle.ToNative(IntPtr.Add(nativeStruct, LastControlStyle_Offset), LastControlStyle);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset), BackgroundBrush);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, UniformPadding_Offset), UniformPadding);
	}

	public FSegmentedControlStyle(IntPtr nativeStruct)
	{
		if (!FSegmentedControlStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SegmentedControlStyle");
			ControlStyle = default(FCheckBoxStyle);
			FirstControlStyle = default(FCheckBoxStyle);
			LastControlStyle = default(FCheckBoxStyle);
			BackgroundBrush = default(FSlateBrush);
			UniformPadding = default(FMargin);
		}
		else
		{
			ControlStyle = FCheckBoxStyle.FromNative(IntPtr.Add(nativeStruct, ControlStyle_Offset));
			FirstControlStyle = FCheckBoxStyle.FromNative(IntPtr.Add(nativeStruct, FirstControlStyle_Offset));
			LastControlStyle = FCheckBoxStyle.FromNative(IntPtr.Add(nativeStruct, LastControlStyle_Offset));
			BackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundBrush_Offset));
			UniformPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, UniformPadding_Offset));
		}
	}

	static FSegmentedControlStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSegmentedControlStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSegmentedControlStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SegmentedControlStyle");
		FSegmentedControlStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		ControlStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlStyle");
		ControlStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlStyle", Classes.FStructProperty);
		FirstControlStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FirstControlStyle");
		FirstControlStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FirstControlStyle", Classes.FStructProperty);
		LastControlStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastControlStyle");
		LastControlStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastControlStyle", Classes.FStructProperty);
		BackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundBrush");
		BackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundBrush", Classes.FStructProperty);
		UniformPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UniformPadding");
		UniformPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UniformPadding", Classes.FStructProperty);
		FSegmentedControlStyle_IsValid = intPtr != IntPtr.Zero && ControlStyle_IsValid && FirstControlStyle_IsValid && LastControlStyle_IsValid && BackgroundBrush_IsValid && UniformPadding_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SegmentedControlStyle", FSegmentedControlStyle_IsValid);
	}
}
