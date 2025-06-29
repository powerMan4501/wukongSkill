using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSubmixEffectConvolutionReverbSettings
{
	private static bool Bypass_IsValid;

	private static FFieldAddress Bypass_PropertyAddress;

	private static int Bypass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbSettings:bBypass")]
	public bool Bypass;

	private static bool MixInputChannelFormatToImpulseResponseFormat_IsValid;

	private static FFieldAddress MixInputChannelFormatToImpulseResponseFormat_PropertyAddress;

	private static int MixInputChannelFormatToImpulseResponseFormat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbSettings:bMixInputChannelFormatToImpulseResponseFormat")]
	public bool MixInputChannelFormatToImpulseResponseFormat;

	private static bool MixReverbOutputToOutputChannelFormat_IsValid;

	private static FFieldAddress MixReverbOutputToOutputChannelFormat_PropertyAddress;

	private static int MixReverbOutputToOutputChannelFormat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbSettings:bMixReverbOutputToOutputChannelFormat")]
	public bool MixReverbOutputToOutputChannelFormat;

	private static bool SurroundRearChannelBleedDb_IsValid;

	private static int SurroundRearChannelBleedDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbSettings:SurroundRearChannelBleedDb")]
	public float SurroundRearChannelBleedDb;

	private static bool InvertRearChannelBleedPhase_IsValid;

	private static FFieldAddress InvertRearChannelBleedPhase_PropertyAddress;

	private static int InvertRearChannelBleedPhase_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbSettings:bInvertRearChannelBleedPhase")]
	public bool InvertRearChannelBleedPhase;

	private static bool SurroundRearChannelFlip_IsValid;

	private static FFieldAddress SurroundRearChannelFlip_PropertyAddress;

	private static int SurroundRearChannelFlip_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectConvolutionReverbSettings:bSurroundRearChannelFlip")]
	public bool SurroundRearChannelFlip;

	private static bool FSubmixEffectConvolutionReverbSettings_IsValid;

	private static int FSubmixEffectConvolutionReverbSettings_StructSize;

	public FSubmixEffectConvolutionReverbSettings Copy()
	{
		return this;
	}

	public static FSubmixEffectConvolutionReverbSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectConvolutionReverbSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectConvolutionReverbSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectConvolutionReverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectConvolutionReverbSettings(nativeBuffer + arrayIndex * FSubmixEffectConvolutionReverbSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectConvolutionReverbSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectConvolutionReverbSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectConvolutionReverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address, Bypass);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MixInputChannelFormatToImpulseResponseFormat_Offset), 0, MixInputChannelFormatToImpulseResponseFormat_PropertyAddress.Address, MixInputChannelFormatToImpulseResponseFormat);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MixReverbOutputToOutputChannelFormat_Offset), 0, MixReverbOutputToOutputChannelFormat_PropertyAddress.Address, MixReverbOutputToOutputChannelFormat);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SurroundRearChannelBleedDb_Offset), SurroundRearChannelBleedDb);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InvertRearChannelBleedPhase_Offset), 0, InvertRearChannelBleedPhase_PropertyAddress.Address, InvertRearChannelBleedPhase);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SurroundRearChannelFlip_Offset), 0, SurroundRearChannelFlip_PropertyAddress.Address, SurroundRearChannelFlip);
	}

	public FSubmixEffectConvolutionReverbSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectConvolutionReverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectConvolutionReverbSettings");
			Bypass = false;
			MixInputChannelFormatToImpulseResponseFormat = false;
			MixReverbOutputToOutputChannelFormat = false;
			SurroundRearChannelBleedDb = 0f;
			InvertRearChannelBleedPhase = false;
			SurroundRearChannelFlip = false;
		}
		else
		{
			Bypass = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address);
			MixInputChannelFormatToImpulseResponseFormat = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MixInputChannelFormatToImpulseResponseFormat_Offset), 0, MixInputChannelFormatToImpulseResponseFormat_PropertyAddress.Address);
			MixReverbOutputToOutputChannelFormat = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MixReverbOutputToOutputChannelFormat_Offset), 0, MixReverbOutputToOutputChannelFormat_PropertyAddress.Address);
			SurroundRearChannelBleedDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SurroundRearChannelBleedDb_Offset));
			InvertRearChannelBleedPhase = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InvertRearChannelBleedPhase_Offset), 0, InvertRearChannelBleedPhase_PropertyAddress.Address);
			SurroundRearChannelFlip = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SurroundRearChannelFlip_Offset), 0, SurroundRearChannelFlip_PropertyAddress.Address);
		}
	}

	static FSubmixEffectConvolutionReverbSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectConvolutionReverbSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectConvolutionReverbSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SubmixEffectConvolutionReverbSettings");
		FSubmixEffectConvolutionReverbSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Bypass_PropertyAddress, intPtr, "bBypass");
		Bypass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBypass");
		Bypass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBypass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MixInputChannelFormatToImpulseResponseFormat_PropertyAddress, intPtr, "bMixInputChannelFormatToImpulseResponseFormat");
		MixInputChannelFormatToImpulseResponseFormat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMixInputChannelFormatToImpulseResponseFormat");
		MixInputChannelFormatToImpulseResponseFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMixInputChannelFormatToImpulseResponseFormat", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MixReverbOutputToOutputChannelFormat_PropertyAddress, intPtr, "bMixReverbOutputToOutputChannelFormat");
		MixReverbOutputToOutputChannelFormat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMixReverbOutputToOutputChannelFormat");
		MixReverbOutputToOutputChannelFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMixReverbOutputToOutputChannelFormat", Classes.FBoolProperty);
		SurroundRearChannelBleedDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SurroundRearChannelBleedDb");
		SurroundRearChannelBleedDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SurroundRearChannelBleedDb", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InvertRearChannelBleedPhase_PropertyAddress, intPtr, "bInvertRearChannelBleedPhase");
		InvertRearChannelBleedPhase_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInvertRearChannelBleedPhase");
		InvertRearChannelBleedPhase_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInvertRearChannelBleedPhase", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SurroundRearChannelFlip_PropertyAddress, intPtr, "bSurroundRearChannelFlip");
		SurroundRearChannelFlip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSurroundRearChannelFlip");
		SurroundRearChannelFlip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSurroundRearChannelFlip", Classes.FBoolProperty);
		FSubmixEffectConvolutionReverbSettings_IsValid = intPtr != IntPtr.Zero && Bypass_IsValid && MixInputChannelFormatToImpulseResponseFormat_IsValid && MixReverbOutputToOutputChannelFormat_IsValid && SurroundRearChannelBleedDb_IsValid && InvertRearChannelBleedPhase_IsValid && SurroundRearChannelFlip_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SubmixEffectConvolutionReverbSettings", FSubmixEffectConvolutionReverbSettings_IsValid);
	}
}
