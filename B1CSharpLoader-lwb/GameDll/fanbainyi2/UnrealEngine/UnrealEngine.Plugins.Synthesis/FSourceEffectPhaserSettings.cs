using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectPhaserSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectPhaserSettings
{
	private static bool WetLevel_IsValid;

	private static int WetLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectPhaserSettings:WetLevel")]
	public float WetLevel;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectPhaserSettings:Frequency")]
	public float Frequency;

	private static bool Feedback_IsValid;

	private static int Feedback_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectPhaserSettings:Feedback")]
	public float Feedback;

	private static bool LFOType_IsValid;

	private static FFieldAddress LFOType_PropertyAddress;

	private static int LFOType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectPhaserSettings:LFOType")]
	public EPhaserLFOType LFOType;

	private static bool UseQuadraturePhase_IsValid;

	private static FFieldAddress UseQuadraturePhase_PropertyAddress;

	private static int UseQuadraturePhase_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectPhaserSettings:UseQuadraturePhase")]
	public bool UseQuadraturePhase;

	private static bool FSourceEffectPhaserSettings_IsValid;

	private static int FSourceEffectPhaserSettings_StructSize;

	public FSourceEffectPhaserSettings Copy()
	{
		return this;
	}

	public static FSourceEffectPhaserSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectPhaserSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectPhaserSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectPhaserSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectPhaserSettings(nativeBuffer + arrayIndex * FSourceEffectPhaserSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectPhaserSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectPhaserSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectPhaserSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectPhaserSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WetLevel_Offset), WetLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Feedback_Offset), Feedback);
		EnumMarshaler<EPhaserLFOType>.ToNative(IntPtr.Add(nativeStruct, LFOType_Offset), 0, LFOType_PropertyAddress.Address, LFOType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseQuadraturePhase_Offset), 0, UseQuadraturePhase_PropertyAddress.Address, UseQuadraturePhase);
	}

	public FSourceEffectPhaserSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectPhaserSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectPhaserSettings");
			WetLevel = 0f;
			Frequency = 0f;
			Feedback = 0f;
			LFOType = EPhaserLFOType.Sine;
			UseQuadraturePhase = false;
		}
		else
		{
			WetLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WetLevel_Offset));
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			Feedback = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Feedback_Offset));
			LFOType = EnumMarshaler<EPhaserLFOType>.FromNative(IntPtr.Add(nativeStruct, LFOType_Offset), 0, LFOType_PropertyAddress.Address);
			UseQuadraturePhase = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseQuadraturePhase_Offset), 0, UseQuadraturePhase_PropertyAddress.Address);
		}
	}

	static FSourceEffectPhaserSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectPhaserSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectPhaserSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectPhaserSettings");
		FSourceEffectPhaserSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		WetLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetLevel");
		WetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetLevel", Classes.FFloatProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		Feedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Feedback");
		Feedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Feedback", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LFOType_PropertyAddress, intPtr, "LFOType");
		LFOType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFOType");
		LFOType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFOType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UseQuadraturePhase_PropertyAddress, intPtr, "UseQuadraturePhase");
		UseQuadraturePhase_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseQuadraturePhase");
		UseQuadraturePhase_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseQuadraturePhase", Classes.FBoolProperty);
		FSourceEffectPhaserSettings_IsValid = intPtr != IntPtr.Zero && WetLevel_IsValid && Frequency_IsValid && Feedback_IsValid && LFOType_IsValid && UseQuadraturePhase_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectPhaserSettings", FSourceEffectPhaserSettings_IsValid);
	}
}
