using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ProgressBarStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FProgressBarStyle
{
	private static bool BackgroundImage_IsValid;

	private static int BackgroundImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ProgressBarStyle:BackgroundImage")]
	public FSlateBrush BackgroundImage;

	private static bool FillImage_IsValid;

	private static int FillImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ProgressBarStyle:FillImage")]
	public FSlateBrush FillImage;

	private static bool MarqueeImage_IsValid;

	private static int MarqueeImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ProgressBarStyle:MarqueeImage")]
	public FSlateBrush MarqueeImage;

	private static bool EnableFillAnimation_IsValid;

	private static FFieldAddress EnableFillAnimation_PropertyAddress;

	private static int EnableFillAnimation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ProgressBarStyle:EnableFillAnimation")]
	public bool EnableFillAnimation;

	private static bool FProgressBarStyle_IsValid;

	private static int FProgressBarStyle_StructSize;

	public FProgressBarStyle Copy()
	{
		return this;
	}

	public static FProgressBarStyle FromNative(IntPtr nativeBuffer)
	{
		return new FProgressBarStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProgressBarStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProgressBarStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProgressBarStyle(nativeBuffer + arrayIndex * FProgressBarStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProgressBarStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FProgressBarStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FProgressBarStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ProgressBarStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImage_Offset), BackgroundImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, FillImage_Offset), FillImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, MarqueeImage_Offset), MarqueeImage);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableFillAnimation_Offset), 0, EnableFillAnimation_PropertyAddress.Address, EnableFillAnimation);
	}

	public FProgressBarStyle(IntPtr nativeStruct)
	{
		if (!FProgressBarStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ProgressBarStyle");
			BackgroundImage = default(FSlateBrush);
			FillImage = default(FSlateBrush);
			MarqueeImage = default(FSlateBrush);
			EnableFillAnimation = false;
		}
		else
		{
			BackgroundImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImage_Offset));
			FillImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, FillImage_Offset));
			MarqueeImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, MarqueeImage_Offset));
			EnableFillAnimation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableFillAnimation_Offset), 0, EnableFillAnimation_PropertyAddress.Address);
		}
	}

	static FProgressBarStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FProgressBarStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProgressBarStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.ProgressBarStyle");
		FProgressBarStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		BackgroundImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImage");
		BackgroundImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImage", Classes.FStructProperty);
		FillImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FillImage");
		FillImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FillImage", Classes.FStructProperty);
		MarqueeImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MarqueeImage");
		MarqueeImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MarqueeImage", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableFillAnimation_PropertyAddress, intPtr, "EnableFillAnimation");
		EnableFillAnimation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableFillAnimation");
		EnableFillAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableFillAnimation", Classes.FBoolProperty);
		FProgressBarStyle_IsValid = intPtr != IntPtr.Zero && BackgroundImage_IsValid && FillImage_IsValid && MarqueeImage_IsValid && EnableFillAnimation_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ProgressBarStyle", FProgressBarStyle_IsValid);
	}
}
