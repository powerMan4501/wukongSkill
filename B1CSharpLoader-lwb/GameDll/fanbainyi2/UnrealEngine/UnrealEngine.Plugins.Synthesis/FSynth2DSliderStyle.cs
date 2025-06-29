using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.Synth2DSliderStyle", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSynth2DSliderStyle
{
	private static bool NormalThumbImage_IsValid;

	private static int NormalThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSliderStyle:NormalThumbImage")]
	public FSlateBrush NormalThumbImage;

	private static bool DisabledThumbImage_IsValid;

	private static int DisabledThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSliderStyle:DisabledThumbImage")]
	public FSlateBrush DisabledThumbImage;

	private static bool NormalBarImage_IsValid;

	private static int NormalBarImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSliderStyle:NormalBarImage")]
	public FSlateBrush NormalBarImage;

	private static bool DisabledBarImage_IsValid;

	private static int DisabledBarImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSliderStyle:DisabledBarImage")]
	public FSlateBrush DisabledBarImage;

	private static bool BackgroundImage_IsValid;

	private static int BackgroundImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSliderStyle:BackgroundImage")]
	public FSlateBrush BackgroundImage;

	private static bool BarThickness_IsValid;

	private static int BarThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSliderStyle:BarThickness")]
	public float BarThickness;

	private static bool FSynth2DSliderStyle_IsValid;

	private static int FSynth2DSliderStyle_StructSize;

	public FSynth2DSliderStyle Copy()
	{
		return this;
	}

	public static FSynth2DSliderStyle FromNative(IntPtr nativeBuffer)
	{
		return new FSynth2DSliderStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSynth2DSliderStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSynth2DSliderStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSynth2DSliderStyle(nativeBuffer + arrayIndex * FSynth2DSliderStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSynth2DSliderStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSynth2DSliderStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSynth2DSliderStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.Synth2DSliderStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, NormalThumbImage_Offset), NormalThumbImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DisabledThumbImage_Offset), DisabledThumbImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, NormalBarImage_Offset), NormalBarImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DisabledBarImage_Offset), DisabledBarImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImage_Offset), BackgroundImage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BarThickness_Offset), BarThickness);
	}

	public FSynth2DSliderStyle(IntPtr nativeStruct)
	{
		if (!FSynth2DSliderStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.Synth2DSliderStyle");
			NormalThumbImage = default(FSlateBrush);
			DisabledThumbImage = default(FSlateBrush);
			NormalBarImage = default(FSlateBrush);
			DisabledBarImage = default(FSlateBrush);
			BackgroundImage = default(FSlateBrush);
			BarThickness = 0f;
		}
		else
		{
			NormalThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, NormalThumbImage_Offset));
			DisabledThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DisabledThumbImage_Offset));
			NormalBarImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, NormalBarImage_Offset));
			DisabledBarImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DisabledBarImage_Offset));
			BackgroundImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImage_Offset));
			BarThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BarThickness_Offset));
		}
	}

	static FSynth2DSliderStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSynth2DSliderStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSynth2DSliderStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.Synth2DSliderStyle");
		FSynth2DSliderStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		NormalThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalThumbImage");
		NormalThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalThumbImage", Classes.FStructProperty);
		DisabledThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisabledThumbImage");
		DisabledThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisabledThumbImage", Classes.FStructProperty);
		NormalBarImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalBarImage");
		NormalBarImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalBarImage", Classes.FStructProperty);
		DisabledBarImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisabledBarImage");
		DisabledBarImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisabledBarImage", Classes.FStructProperty);
		BackgroundImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImage");
		BackgroundImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImage", Classes.FStructProperty);
		BarThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarThickness");
		BarThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarThickness", Classes.FFloatProperty);
		FSynth2DSliderStyle_IsValid = intPtr != IntPtr.Zero && NormalThumbImage_IsValid && DisabledThumbImage_IsValid && NormalBarImage_IsValid && DisabledBarImage_IsValid && BackgroundImage_IsValid && BarThickness_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.Synth2DSliderStyle", FSynth2DSliderStyle_IsValid);
	}
}
