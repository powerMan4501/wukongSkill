using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ScrollBorderStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FScrollBorderStyle
{
	private static bool TopShadowBrush_IsValid;

	private static int TopShadowBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBorderStyle:TopShadowBrush")]
	public FSlateBrush TopShadowBrush;

	private static bool BottomShadowBrush_IsValid;

	private static int BottomShadowBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBorderStyle:BottomShadowBrush")]
	public FSlateBrush BottomShadowBrush;

	private static bool FScrollBorderStyle_IsValid;

	private static int FScrollBorderStyle_StructSize;

	public FScrollBorderStyle Copy()
	{
		return this;
	}

	public static FScrollBorderStyle FromNative(IntPtr nativeBuffer)
	{
		return new FScrollBorderStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScrollBorderStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScrollBorderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScrollBorderStyle(nativeBuffer + arrayIndex * FScrollBorderStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScrollBorderStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScrollBorderStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScrollBorderStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ScrollBorderStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, TopShadowBrush_Offset), TopShadowBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BottomShadowBrush_Offset), BottomShadowBrush);
	}

	public FScrollBorderStyle(IntPtr nativeStruct)
	{
		if (!FScrollBorderStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ScrollBorderStyle");
			TopShadowBrush = default(FSlateBrush);
			BottomShadowBrush = default(FSlateBrush);
		}
		else
		{
			TopShadowBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, TopShadowBrush_Offset));
			BottomShadowBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BottomShadowBrush_Offset));
		}
	}

	static FScrollBorderStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScrollBorderStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScrollBorderStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.ScrollBorderStyle");
		FScrollBorderStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		TopShadowBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TopShadowBrush");
		TopShadowBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TopShadowBrush", Classes.FStructProperty);
		BottomShadowBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BottomShadowBrush");
		BottomShadowBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BottomShadowBrush", Classes.FStructProperty);
		FScrollBorderStyle_IsValid = intPtr != IntPtr.Zero && TopShadowBrush_IsValid && BottomShadowBrush_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ScrollBorderStyle", FScrollBorderStyle_IsValid);
	}
}
