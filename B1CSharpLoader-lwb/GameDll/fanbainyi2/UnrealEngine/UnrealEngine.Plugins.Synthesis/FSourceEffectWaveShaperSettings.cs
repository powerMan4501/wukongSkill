using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectWaveShaperSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectWaveShaperSettings
{
	private static bool Amount_IsValid;

	private static int Amount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectWaveShaperSettings:Amount")]
	public float Amount;

	private static bool OutputGainDb_IsValid;

	private static int OutputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectWaveShaperSettings:OutputGainDb")]
	public float OutputGainDb;

	private static bool FSourceEffectWaveShaperSettings_IsValid;

	private static int FSourceEffectWaveShaperSettings_StructSize;

	public FSourceEffectWaveShaperSettings Copy()
	{
		return this;
	}

	public static FSourceEffectWaveShaperSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectWaveShaperSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectWaveShaperSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectWaveShaperSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectWaveShaperSettings(nativeBuffer + arrayIndex * FSourceEffectWaveShaperSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectWaveShaperSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectWaveShaperSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectWaveShaperSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectWaveShaperSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Amount_Offset), Amount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset), OutputGainDb);
	}

	public FSourceEffectWaveShaperSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectWaveShaperSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectWaveShaperSettings");
			Amount = 0f;
			OutputGainDb = 0f;
		}
		else
		{
			Amount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Amount_Offset));
			OutputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset));
		}
	}

	static FSourceEffectWaveShaperSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectWaveShaperSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectWaveShaperSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectWaveShaperSettings");
		FSourceEffectWaveShaperSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Amount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Amount");
		Amount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Amount", Classes.FFloatProperty);
		OutputGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputGainDb");
		OutputGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputGainDb", Classes.FFloatProperty);
		FSourceEffectWaveShaperSettings_IsValid = intPtr != IntPtr.Zero && Amount_IsValid && OutputGainDb_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectWaveShaperSettings", FSourceEffectWaveShaperSettings_IsValid);
	}
}
