using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SplitterStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FSplitterStyle
{
	private static bool HandleNormalBrush_IsValid;

	private static int HandleNormalBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SplitterStyle:HandleNormalBrush")]
	public FSlateBrush HandleNormalBrush;

	private static bool HandleHighlightBrush_IsValid;

	private static int HandleHighlightBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SplitterStyle:HandleHighlightBrush")]
	public FSlateBrush HandleHighlightBrush;

	private static bool FSplitterStyle_IsValid;

	private static int FSplitterStyle_StructSize;

	public FSplitterStyle Copy()
	{
		return this;
	}

	public static FSplitterStyle FromNative(IntPtr nativeBuffer)
	{
		return new FSplitterStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSplitterStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSplitterStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSplitterStyle(nativeBuffer + arrayIndex * FSplitterStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSplitterStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSplitterStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSplitterStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SplitterStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HandleNormalBrush_Offset), HandleNormalBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HandleHighlightBrush_Offset), HandleHighlightBrush);
	}

	public FSplitterStyle(IntPtr nativeStruct)
	{
		if (!FSplitterStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SplitterStyle");
			HandleNormalBrush = default(FSlateBrush);
			HandleHighlightBrush = default(FSlateBrush);
		}
		else
		{
			HandleNormalBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HandleNormalBrush_Offset));
			HandleHighlightBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HandleHighlightBrush_Offset));
		}
	}

	static FSplitterStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSplitterStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSplitterStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SplitterStyle");
		FSplitterStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		HandleNormalBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HandleNormalBrush");
		HandleNormalBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HandleNormalBrush", Classes.FStructProperty);
		HandleHighlightBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HandleHighlightBrush");
		HandleHighlightBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HandleHighlightBrush", Classes.FStructProperty);
		FSplitterStyle_IsValid = intPtr != IntPtr.Zero && HandleNormalBrush_IsValid && HandleHighlightBrush_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SplitterStyle", FSplitterStyle_IsValid);
	}
}
