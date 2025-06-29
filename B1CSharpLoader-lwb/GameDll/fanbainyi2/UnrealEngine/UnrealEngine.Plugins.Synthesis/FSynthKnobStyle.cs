using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SynthKnobStyle", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSynthKnobStyle
{
	private static bool LargeKnob_IsValid;

	private static int LargeKnob_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SynthKnobStyle:LargeKnob")]
	public FSlateBrush LargeKnob;

	private static bool LargeKnobOverlay_IsValid;

	private static int LargeKnobOverlay_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SynthKnobStyle:LargeKnobOverlay")]
	public FSlateBrush LargeKnobOverlay;

	private static bool MediumKnob_IsValid;

	private static int MediumKnob_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SynthKnobStyle:MediumKnob")]
	public FSlateBrush MediumKnob;

	private static bool MediumKnobOverlay_IsValid;

	private static int MediumKnobOverlay_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SynthKnobStyle:MediumKnobOverlay")]
	public FSlateBrush MediumKnobOverlay;

	private static bool MinValueAngle_IsValid;

	private static int MinValueAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SynthKnobStyle:MinValueAngle")]
	public float MinValueAngle;

	private static bool MaxValueAngle_IsValid;

	private static int MaxValueAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SynthKnobStyle:MaxValueAngle")]
	public float MaxValueAngle;

	private static bool KnobSize_IsValid;

	private static FFieldAddress KnobSize_PropertyAddress;

	private static int KnobSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SynthKnobStyle:KnobSize")]
	public ESynthKnobSize KnobSize;

	private static bool FSynthKnobStyle_IsValid;

	private static int FSynthKnobStyle_StructSize;

	public FSynthKnobStyle Copy()
	{
		return this;
	}

	public static FSynthKnobStyle FromNative(IntPtr nativeBuffer)
	{
		return new FSynthKnobStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSynthKnobStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSynthKnobStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSynthKnobStyle(nativeBuffer + arrayIndex * FSynthKnobStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSynthKnobStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSynthKnobStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSynthKnobStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SynthKnobStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, LargeKnob_Offset), LargeKnob);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, LargeKnobOverlay_Offset), LargeKnobOverlay);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, MediumKnob_Offset), MediumKnob);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, MediumKnobOverlay_Offset), MediumKnobOverlay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinValueAngle_Offset), MinValueAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxValueAngle_Offset), MaxValueAngle);
		EnumMarshaler<ESynthKnobSize>.ToNative(IntPtr.Add(nativeStruct, KnobSize_Offset), 0, KnobSize_PropertyAddress.Address, KnobSize);
	}

	public FSynthKnobStyle(IntPtr nativeStruct)
	{
		if (!FSynthKnobStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SynthKnobStyle");
			LargeKnob = default(FSlateBrush);
			LargeKnobOverlay = default(FSlateBrush);
			MediumKnob = default(FSlateBrush);
			MediumKnobOverlay = default(FSlateBrush);
			MinValueAngle = 0f;
			MaxValueAngle = 0f;
			KnobSize = ESynthKnobSize.Medium;
		}
		else
		{
			LargeKnob = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, LargeKnob_Offset));
			LargeKnobOverlay = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, LargeKnobOverlay_Offset));
			MediumKnob = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, MediumKnob_Offset));
			MediumKnobOverlay = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, MediumKnobOverlay_Offset));
			MinValueAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinValueAngle_Offset));
			MaxValueAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxValueAngle_Offset));
			KnobSize = EnumMarshaler<ESynthKnobSize>.FromNative(IntPtr.Add(nativeStruct, KnobSize_Offset), 0, KnobSize_PropertyAddress.Address);
		}
	}

	static FSynthKnobStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSynthKnobStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSynthKnobStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SynthKnobStyle");
		FSynthKnobStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		LargeKnob_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LargeKnob");
		LargeKnob_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LargeKnob", Classes.FStructProperty);
		LargeKnobOverlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LargeKnobOverlay");
		LargeKnobOverlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LargeKnobOverlay", Classes.FStructProperty);
		MediumKnob_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MediumKnob");
		MediumKnob_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MediumKnob", Classes.FStructProperty);
		MediumKnobOverlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MediumKnobOverlay");
		MediumKnobOverlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MediumKnobOverlay", Classes.FStructProperty);
		MinValueAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinValueAngle");
		MinValueAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinValueAngle", Classes.FFloatProperty);
		MaxValueAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxValueAngle");
		MaxValueAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxValueAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref KnobSize_PropertyAddress, intPtr, "KnobSize");
		KnobSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KnobSize");
		KnobSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KnobSize", Classes.FEnumProperty);
		FSynthKnobStyle_IsValid = intPtr != IntPtr.Zero && LargeKnob_IsValid && LargeKnobOverlay_IsValid && MediumKnob_IsValid && MediumKnobOverlay_IsValid && MinValueAngle_IsValid && MaxValueAngle_IsValid && KnobSize_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SynthKnobStyle", FSynthKnobStyle_IsValid);
	}
}
