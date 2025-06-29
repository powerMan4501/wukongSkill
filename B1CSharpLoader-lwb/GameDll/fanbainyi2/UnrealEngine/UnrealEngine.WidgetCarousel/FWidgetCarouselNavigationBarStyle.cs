using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.WidgetCarousel;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle", "WidgetCarousel", UnrealModuleType.Engine)]
public struct FWidgetCarouselNavigationBarStyle
{
	private static bool HighlightBrush_IsValid;

	private static int HighlightBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:HighlightBrush")]
	public FSlateBrush HighlightBrush;

	private static bool LeftButtonStyle_IsValid;

	private static int LeftButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:LeftButtonStyle")]
	public FButtonStyle LeftButtonStyle;

	private static bool CenterButtonStyle_IsValid;

	private static int CenterButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:CenterButtonStyle")]
	public FButtonStyle CenterButtonStyle;

	private static bool RightButtonStyle_IsValid;

	private static int RightButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle:RightButtonStyle")]
	public FButtonStyle RightButtonStyle;

	private static bool FWidgetCarouselNavigationBarStyle_IsValid;

	private static int FWidgetCarouselNavigationBarStyle_StructSize;

	public FWidgetCarouselNavigationBarStyle Copy()
	{
		return this;
	}

	public static FWidgetCarouselNavigationBarStyle FromNative(IntPtr nativeBuffer)
	{
		return new FWidgetCarouselNavigationBarStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWidgetCarouselNavigationBarStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWidgetCarouselNavigationBarStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWidgetCarouselNavigationBarStyle(nativeBuffer + arrayIndex * FWidgetCarouselNavigationBarStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWidgetCarouselNavigationBarStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWidgetCarouselNavigationBarStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWidgetCarouselNavigationBarStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HighlightBrush_Offset), HighlightBrush);
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, LeftButtonStyle_Offset), LeftButtonStyle);
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, CenterButtonStyle_Offset), CenterButtonStyle);
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, RightButtonStyle_Offset), RightButtonStyle);
	}

	public FWidgetCarouselNavigationBarStyle(IntPtr nativeStruct)
	{
		if (!FWidgetCarouselNavigationBarStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle");
			HighlightBrush = default(FSlateBrush);
			LeftButtonStyle = default(FButtonStyle);
			CenterButtonStyle = default(FButtonStyle);
			RightButtonStyle = default(FButtonStyle);
		}
		else
		{
			HighlightBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HighlightBrush_Offset));
			LeftButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, LeftButtonStyle_Offset));
			CenterButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, CenterButtonStyle_Offset));
			RightButtonStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, RightButtonStyle_Offset));
		}
	}

	static FWidgetCarouselNavigationBarStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWidgetCarouselNavigationBarStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWidgetCarouselNavigationBarStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle");
		FWidgetCarouselNavigationBarStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		HighlightBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighlightBrush");
		HighlightBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighlightBrush", Classes.FStructProperty);
		LeftButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftButtonStyle");
		LeftButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftButtonStyle", Classes.FStructProperty);
		CenterButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CenterButtonStyle");
		CenterButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CenterButtonStyle", Classes.FStructProperty);
		RightButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightButtonStyle");
		RightButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightButtonStyle", Classes.FStructProperty);
		FWidgetCarouselNavigationBarStyle_IsValid = intPtr != IntPtr.Zero && HighlightBrush_IsValid && LeftButtonStyle_IsValid && CenterButtonStyle_IsValid && RightButtonStyle_IsValid;
		NativeReflection.LogStructIsValid("/Script/WidgetCarousel.WidgetCarouselNavigationBarStyle", FWidgetCarouselNavigationBarStyle_IsValid);
	}
}
