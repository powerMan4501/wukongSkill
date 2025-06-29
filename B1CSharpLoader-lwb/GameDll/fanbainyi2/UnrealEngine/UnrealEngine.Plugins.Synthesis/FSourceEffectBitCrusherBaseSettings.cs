using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherBaseSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectBitCrusherBaseSettings
{
	private static bool SampleRate_IsValid;

	private static int SampleRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherBaseSettings:SampleRate")]
	public float SampleRate;

	private static bool BitDepth_IsValid;

	private static int BitDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherBaseSettings:BitDepth")]
	public float BitDepth;

	private static bool FSourceEffectBitCrusherBaseSettings_IsValid;

	private static int FSourceEffectBitCrusherBaseSettings_StructSize;

	public FSourceEffectBitCrusherBaseSettings Copy()
	{
		return this;
	}

	public static FSourceEffectBitCrusherBaseSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectBitCrusherBaseSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectBitCrusherBaseSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectBitCrusherBaseSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectBitCrusherBaseSettings(nativeBuffer + arrayIndex * FSourceEffectBitCrusherBaseSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectBitCrusherBaseSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectBitCrusherBaseSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectBitCrusherBaseSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectBitCrusherBaseSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SampleRate_Offset), SampleRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BitDepth_Offset), BitDepth);
	}

	public FSourceEffectBitCrusherBaseSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectBitCrusherBaseSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectBitCrusherBaseSettings");
			SampleRate = 0f;
			BitDepth = 0f;
		}
		else
		{
			SampleRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SampleRate_Offset));
			BitDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BitDepth_Offset));
		}
	}

	static FSourceEffectBitCrusherBaseSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectBitCrusherBaseSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectBitCrusherBaseSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectBitCrusherBaseSettings");
		FSourceEffectBitCrusherBaseSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		SampleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SampleRate");
		SampleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SampleRate", Classes.FFloatProperty);
		BitDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BitDepth");
		BitDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BitDepth", Classes.FFloatProperty);
		FSourceEffectBitCrusherBaseSettings_IsValid = intPtr != IntPtr.Zero && SampleRate_IsValid && BitDepth_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectBitCrusherBaseSettings", FSourceEffectBitCrusherBaseSettings_IsValid);
	}
}
