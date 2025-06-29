using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/Engine.VoiceSettings", "Engine", UnrealModuleType.Engine)]
public struct FVoiceSettings
{
	private static bool ComponentToAttachTo_IsValid;

	private static int ComponentToAttachTo_Offset;

	[UProperty(Flags = (PropFlags)7881369141641741uL)]
	[UMetaPath("/Script/Engine.VoiceSettings:ComponentToAttachTo")]
	public USceneComponent ComponentToAttachTo;

	private static bool AttenuationSettings_IsValid;

	private static int AttenuationSettings_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.VoiceSettings:AttenuationSettings")]
	public USoundAttenuation AttenuationSettings;

	private static bool SourceEffectChain_IsValid;

	private static int SourceEffectChain_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.VoiceSettings:SourceEffectChain")]
	public USoundEffectSourcePresetChain SourceEffectChain;

	private static bool FVoiceSettings_IsValid;

	private static int FVoiceSettings_StructSize;

	public FVoiceSettings Copy()
	{
		return this;
	}

	public static FVoiceSettings FromNative(IntPtr nativeBuffer)
	{
		return new FVoiceSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVoiceSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVoiceSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVoiceSettings(nativeBuffer + arrayIndex * FVoiceSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVoiceSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVoiceSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVoiceSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VoiceSettings");
			return;
		}
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(nativeStruct, ComponentToAttachTo_Offset), ComponentToAttachTo);
		UObjectMarshaler<USoundAttenuation>.ToNative(IntPtr.Add(nativeStruct, AttenuationSettings_Offset), AttenuationSettings);
		UObjectMarshaler<USoundEffectSourcePresetChain>.ToNative(IntPtr.Add(nativeStruct, SourceEffectChain_Offset), SourceEffectChain);
	}

	public FVoiceSettings(IntPtr nativeStruct)
	{
		if (!FVoiceSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.VoiceSettings");
			ComponentToAttachTo = null;
			AttenuationSettings = null;
			SourceEffectChain = null;
		}
		else
		{
			ComponentToAttachTo = UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(nativeStruct, ComponentToAttachTo_Offset));
			AttenuationSettings = UObjectMarshaler<USoundAttenuation>.FromNative(IntPtr.Add(nativeStruct, AttenuationSettings_Offset));
			SourceEffectChain = UObjectMarshaler<USoundEffectSourcePresetChain>.FromNative(IntPtr.Add(nativeStruct, SourceEffectChain_Offset));
		}
	}

	static FVoiceSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVoiceSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVoiceSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.VoiceSettings");
		FVoiceSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentToAttachTo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentToAttachTo");
		ComponentToAttachTo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentToAttachTo", Classes.FObjectProperty);
		AttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationSettings");
		AttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationSettings", Classes.FObjectProperty);
		SourceEffectChain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceEffectChain");
		SourceEffectChain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceEffectChain", Classes.FObjectProperty);
		FVoiceSettings_IsValid = intPtr != IntPtr.Zero && ComponentToAttachTo_IsValid && AttenuationSettings_IsValid && SourceEffectChain_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.VoiceSettings", FVoiceSettings_IsValid);
	}
}
