using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ScrollBoxStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FScrollBoxStyle
{
	private static bool BarThickness_IsValid;

	private static int BarThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ScrollBoxStyle:BarThickness")]
	public float BarThickness;

	private static bool TopShadowBrush_IsValid;

	private static int TopShadowBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBoxStyle:TopShadowBrush")]
	public FSlateBrush TopShadowBrush;

	private static bool BottomShadowBrush_IsValid;

	private static int BottomShadowBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBoxStyle:BottomShadowBrush")]
	public FSlateBrush BottomShadowBrush;

	private static bool LeftShadowBrush_IsValid;

	private static int LeftShadowBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBoxStyle:LeftShadowBrush")]
	public FSlateBrush LeftShadowBrush;

	private static bool RightShadowBrush_IsValid;

	private static int RightShadowBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBoxStyle:RightShadowBrush")]
	public FSlateBrush RightShadowBrush;

	private static bool FScrollBoxStyle_IsValid;

	private static int FScrollBoxStyle_StructSize;

	public FScrollBoxStyle Copy()
	{
		return this;
	}

	public static FScrollBoxStyle FromNative(IntPtr nativeBuffer)
	{
		return new FScrollBoxStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScrollBoxStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScrollBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScrollBoxStyle(nativeBuffer + arrayIndex * FScrollBoxStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScrollBoxStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScrollBoxStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScrollBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ScrollBoxStyle");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BarThickness_Offset), BarThickness);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, TopShadowBrush_Offset), TopShadowBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BottomShadowBrush_Offset), BottomShadowBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, LeftShadowBrush_Offset), LeftShadowBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, RightShadowBrush_Offset), RightShadowBrush);
	}

	public FScrollBoxStyle(IntPtr nativeStruct)
	{
		if (!FScrollBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ScrollBoxStyle");
			BarThickness = 0f;
			TopShadowBrush = default(FSlateBrush);
			BottomShadowBrush = default(FSlateBrush);
			LeftShadowBrush = default(FSlateBrush);
			RightShadowBrush = default(FSlateBrush);
		}
		else
		{
			BarThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BarThickness_Offset));
			TopShadowBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, TopShadowBrush_Offset));
			BottomShadowBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BottomShadowBrush_Offset));
			LeftShadowBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, LeftShadowBrush_Offset));
			RightShadowBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, RightShadowBrush_Offset));
		}
	}

	static FScrollBoxStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScrollBoxStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScrollBoxStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.ScrollBoxStyle");
		FScrollBoxStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		BarThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarThickness");
		BarThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarThickness", Classes.FFloatProperty);
		TopShadowBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TopShadowBrush");
		TopShadowBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TopShadowBrush", Classes.FStructProperty);
		BottomShadowBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BottomShadowBrush");
		BottomShadowBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BottomShadowBrush", Classes.FStructProperty);
		LeftShadowBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftShadowBrush");
		LeftShadowBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftShadowBrush", Classes.FStructProperty);
		RightShadowBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightShadowBrush");
		RightShadowBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightShadowBrush", Classes.FStructProperty);
		FScrollBoxStyle_IsValid = intPtr != IntPtr.Zero && BarThickness_IsValid && TopShadowBrush_IsValid && BottomShadowBrush_IsValid && LeftShadowBrush_IsValid && RightShadowBrush_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ScrollBoxStyle", FScrollBoxStyle_IsValid);
	}
}
