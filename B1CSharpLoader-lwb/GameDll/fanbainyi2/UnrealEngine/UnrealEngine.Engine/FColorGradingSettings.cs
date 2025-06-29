using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ColorGradingSettings", "Engine", UnrealModuleType.Engine)]
public struct FColorGradingSettings
{
	private static bool Global_IsValid;

	private static int Global_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.ColorGradingSettings:Global")]
	public FColorGradePerRangeSettings Global;

	private static bool Shadows_IsValid;

	private static int Shadows_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.ColorGradingSettings:Shadows")]
	public FColorGradePerRangeSettings Shadows;

	private static bool Midtones_IsValid;

	private static int Midtones_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.ColorGradingSettings:Midtones")]
	public FColorGradePerRangeSettings Midtones;

	private static bool Highlights_IsValid;

	private static int Highlights_Offset;

	[UProperty(Flags = (PropFlags)4503676936781829uL)]
	[UMetaPath("/Script/Engine.ColorGradingSettings:Highlights")]
	public FColorGradePerRangeSettings Highlights;

	private static bool ShadowsMax_IsValid;

	private static int ShadowsMax_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradingSettings:ShadowsMax")]
	public float ShadowsMax;

	private static bool HighlightsMin_IsValid;

	private static int HighlightsMin_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradingSettings:HighlightsMin")]
	public float HighlightsMin;

	private static bool HighlightsMax_IsValid;

	private static int HighlightsMax_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradingSettings:HighlightsMax")]
	public float HighlightsMax;

	private static bool FColorGradingSettings_IsValid;

	private static int FColorGradingSettings_StructSize;

	public FColorGradingSettings Copy()
	{
		return this;
	}

	public static FColorGradingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FColorGradingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FColorGradingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FColorGradingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FColorGradingSettings(nativeBuffer + arrayIndex * FColorGradingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FColorGradingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FColorGradingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FColorGradingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ColorGradingSettings");
			return;
		}
		FColorGradePerRangeSettings.ToNative(IntPtr.Add(nativeStruct, Global_Offset), Global);
		FColorGradePerRangeSettings.ToNative(IntPtr.Add(nativeStruct, Shadows_Offset), Shadows);
		FColorGradePerRangeSettings.ToNative(IntPtr.Add(nativeStruct, Midtones_Offset), Midtones);
		FColorGradePerRangeSettings.ToNative(IntPtr.Add(nativeStruct, Highlights_Offset), Highlights);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ShadowsMax_Offset), ShadowsMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HighlightsMin_Offset), HighlightsMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HighlightsMax_Offset), HighlightsMax);
	}

	public FColorGradingSettings(IntPtr nativeStruct)
	{
		if (!FColorGradingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ColorGradingSettings");
			Global = default(FColorGradePerRangeSettings);
			Shadows = default(FColorGradePerRangeSettings);
			Midtones = default(FColorGradePerRangeSettings);
			Highlights = default(FColorGradePerRangeSettings);
			ShadowsMax = 0f;
			HighlightsMin = 0f;
			HighlightsMax = 0f;
		}
		else
		{
			Global = FColorGradePerRangeSettings.FromNative(IntPtr.Add(nativeStruct, Global_Offset));
			Shadows = FColorGradePerRangeSettings.FromNative(IntPtr.Add(nativeStruct, Shadows_Offset));
			Midtones = FColorGradePerRangeSettings.FromNative(IntPtr.Add(nativeStruct, Midtones_Offset));
			Highlights = FColorGradePerRangeSettings.FromNative(IntPtr.Add(nativeStruct, Highlights_Offset));
			ShadowsMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ShadowsMax_Offset));
			HighlightsMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HighlightsMin_Offset));
			HighlightsMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HighlightsMax_Offset));
		}
	}

	static FColorGradingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FColorGradingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FColorGradingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ColorGradingSettings");
		FColorGradingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Global_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Global");
		Global_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Global", Classes.FStructProperty);
		Shadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shadows");
		Shadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shadows", Classes.FStructProperty);
		Midtones_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Midtones");
		Midtones_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Midtones", Classes.FStructProperty);
		Highlights_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Highlights");
		Highlights_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Highlights", Classes.FStructProperty);
		ShadowsMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowsMax");
		ShadowsMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowsMax", Classes.FFloatProperty);
		HighlightsMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighlightsMin");
		HighlightsMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighlightsMin", Classes.FFloatProperty);
		HighlightsMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighlightsMax");
		HighlightsMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighlightsMax", Classes.FFloatProperty);
		FColorGradingSettings_IsValid = intPtr != IntPtr.Zero && Global_IsValid && Shadows_IsValid && Midtones_IsValid && Highlights_IsValid && ShadowsMax_IsValid && HighlightsMin_IsValid && HighlightsMax_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ColorGradingSettings", FColorGradingSettings_IsValid);
	}
}
