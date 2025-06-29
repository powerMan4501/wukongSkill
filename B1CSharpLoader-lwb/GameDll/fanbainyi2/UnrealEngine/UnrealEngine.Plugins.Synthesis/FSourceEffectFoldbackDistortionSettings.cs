using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectFoldbackDistortionSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectFoldbackDistortionSettings
{
	private static bool InputGainDb_IsValid;

	private static int InputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFoldbackDistortionSettings:InputGainDb")]
	public float InputGainDb;

	private static bool ThresholdDb_IsValid;

	private static int ThresholdDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFoldbackDistortionSettings:ThresholdDb")]
	public float ThresholdDb;

	private static bool OutputGainDb_IsValid;

	private static int OutputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFoldbackDistortionSettings:OutputGainDb")]
	public float OutputGainDb;

	private static bool FSourceEffectFoldbackDistortionSettings_IsValid;

	private static int FSourceEffectFoldbackDistortionSettings_StructSize;

	public FSourceEffectFoldbackDistortionSettings Copy()
	{
		return this;
	}

	public static FSourceEffectFoldbackDistortionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectFoldbackDistortionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectFoldbackDistortionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectFoldbackDistortionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectFoldbackDistortionSettings(nativeBuffer + arrayIndex * FSourceEffectFoldbackDistortionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectFoldbackDistortionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectFoldbackDistortionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectFoldbackDistortionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectFoldbackDistortionSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InputGainDb_Offset), InputGainDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset), ThresholdDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset), OutputGainDb);
	}

	public FSourceEffectFoldbackDistortionSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectFoldbackDistortionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectFoldbackDistortionSettings");
			InputGainDb = 0f;
			ThresholdDb = 0f;
			OutputGainDb = 0f;
		}
		else
		{
			InputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InputGainDb_Offset));
			ThresholdDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset));
			OutputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset));
		}
	}

	static FSourceEffectFoldbackDistortionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectFoldbackDistortionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectFoldbackDistortionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectFoldbackDistortionSettings");
		FSourceEffectFoldbackDistortionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		InputGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputGainDb");
		InputGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputGainDb", Classes.FFloatProperty);
		ThresholdDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThresholdDb");
		ThresholdDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThresholdDb", Classes.FFloatProperty);
		OutputGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputGainDb");
		OutputGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputGainDb", Classes.FFloatProperty);
		FSourceEffectFoldbackDistortionSettings_IsValid = intPtr != IntPtr.Zero && InputGainDb_IsValid && ThresholdDb_IsValid && OutputGainDb_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectFoldbackDistortionSettings", FSourceEffectFoldbackDistortionSettings_IsValid);
	}
}
