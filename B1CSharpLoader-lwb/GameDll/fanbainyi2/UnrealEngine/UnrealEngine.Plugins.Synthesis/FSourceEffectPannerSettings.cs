using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectPannerSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectPannerSettings
{
	private static bool Spread_IsValid;

	private static int Spread_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectPannerSettings:Spread")]
	public float Spread;

	private static bool Pan_IsValid;

	private static int Pan_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectPannerSettings:Pan")]
	public float Pan;

	private static bool FSourceEffectPannerSettings_IsValid;

	private static int FSourceEffectPannerSettings_StructSize;

	public FSourceEffectPannerSettings Copy()
	{
		return this;
	}

	public static FSourceEffectPannerSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectPannerSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectPannerSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectPannerSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectPannerSettings(nativeBuffer + arrayIndex * FSourceEffectPannerSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectPannerSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectPannerSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectPannerSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectPannerSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Spread_Offset), Spread);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Pan_Offset), Pan);
	}

	public FSourceEffectPannerSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectPannerSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectPannerSettings");
			Spread = 0f;
			Pan = 0f;
		}
		else
		{
			Spread = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Spread_Offset));
			Pan = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Pan_Offset));
		}
	}

	static FSourceEffectPannerSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectPannerSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectPannerSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectPannerSettings");
		FSourceEffectPannerSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Spread_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Spread");
		Spread_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Spread", Classes.FFloatProperty);
		Pan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pan");
		Pan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pan", Classes.FFloatProperty);
		FSourceEffectPannerSettings_IsValid = intPtr != IntPtr.Zero && Spread_IsValid && Pan_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectPannerSettings", FSourceEffectPannerSettings_IsValid);
	}
}
