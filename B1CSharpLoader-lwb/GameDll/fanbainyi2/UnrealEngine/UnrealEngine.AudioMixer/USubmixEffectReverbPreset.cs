using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SubmixEffectReverbPreset", "AudioMixer", UnrealModuleType.Engine)]
public class USubmixEffectReverbPreset : USoundEffectSubmixPreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettingsWithReverbEffect_IsValid;

	private static IntPtr SetSettingsWithReverbEffect_FunctionAddress;

	private static int SetSettingsWithReverbEffect_ParamsSize;

	private static bool SetSettingsWithReverbEffect_InReverbEffect_IsValid;

	private static FFieldAddress SetSettingsWithReverbEffect_InReverbEffect_PropertyAddress;

	private static int SetSettingsWithReverbEffect_InReverbEffect_Offset;

	private static bool SetSettingsWithReverbEffect_WetLevel_IsValid;

	private static FFieldAddress SetSettingsWithReverbEffect_WetLevel_PropertyAddress;

	private static int SetSettingsWithReverbEffect_WetLevel_Offset;

	private static bool SetSettingsWithReverbEffect_DryLevel_IsValid;

	private static FFieldAddress SetSettingsWithReverbEffect_DryLevel_PropertyAddress;

	private static int SetSettingsWithReverbEffect_DryLevel_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbPreset:Settings")]
	public FSubmixEffectReverbSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SubmixEffectReverbPreset:Settings");
				return default(FSubmixEffectReverbSettings);
			}
			return FSubmixEffectReverbSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SubmixEffectReverbPreset:Settings");
			}
			else
			{
				FSubmixEffectReverbSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbPreset:SetSettingsWithReverbEffect")]
	public unsafe void SetSettingsWithReverbEffect(UReverbEffect InReverbEffect, float WetLevel, float DryLevel = 0f)
	{
		CheckDestroyed();
		if (!SetSettingsWithReverbEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SubmixEffectReverbPreset:SetSettingsWithReverbEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettingsWithReverbEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettingsWithReverbEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UReverbEffect>.ToNative(IntPtr.Add(intPtr, SetSettingsWithReverbEffect_InReverbEffect_Offset), 0, SetSettingsWithReverbEffect_InReverbEffect_PropertyAddress.Address, InReverbEffect);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSettingsWithReverbEffect_WetLevel_Offset), 0, SetSettingsWithReverbEffect_WetLevel_PropertyAddress.Address, WetLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSettingsWithReverbEffect_DryLevel_Offset), 0, SetSettingsWithReverbEffect_DryLevel_PropertyAddress.Address, DryLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettingsWithReverbEffect_FunctionAddress, intPtr, SetSettingsWithReverbEffect_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectReverbSettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SubmixEffectReverbPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectReverbSettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	static USubmixEffectReverbPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectReverbPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectReverbPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AudioMixer.SubmixEffectReverbPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettingsWithReverbEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettingsWithReverbEffect");
		SetSettingsWithReverbEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettingsWithReverbEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettingsWithReverbEffect_InReverbEffect_PropertyAddress, SetSettingsWithReverbEffect_FunctionAddress, "InReverbEffect");
		SetSettingsWithReverbEffect_InReverbEffect_Offset = NativeReflectionCached.GetPropertyOffset(SetSettingsWithReverbEffect_FunctionAddress, "InReverbEffect");
		SetSettingsWithReverbEffect_InReverbEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettingsWithReverbEffect_FunctionAddress, "InReverbEffect", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSettingsWithReverbEffect_WetLevel_PropertyAddress, SetSettingsWithReverbEffect_FunctionAddress, "WetLevel");
		SetSettingsWithReverbEffect_WetLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSettingsWithReverbEffect_FunctionAddress, "WetLevel");
		SetSettingsWithReverbEffect_WetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettingsWithReverbEffect_FunctionAddress, "WetLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSettingsWithReverbEffect_DryLevel_PropertyAddress, SetSettingsWithReverbEffect_FunctionAddress, "DryLevel");
		SetSettingsWithReverbEffect_DryLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSettingsWithReverbEffect_FunctionAddress, "DryLevel");
		SetSettingsWithReverbEffect_DryLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettingsWithReverbEffect_FunctionAddress, "DryLevel", Classes.FFloatProperty);
		SetSettingsWithReverbEffect_IsValid = SetSettingsWithReverbEffect_FunctionAddress != IntPtr.Zero && SetSettingsWithReverbEffect_InReverbEffect_IsValid && SetSettingsWithReverbEffect_WetLevel_IsValid && SetSettingsWithReverbEffect_DryLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SubmixEffectReverbPreset:SetSettingsWithReverbEffect", SetSettingsWithReverbEffect_IsValid);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SubmixEffectReverbPreset:SetSettings", SetSettings_IsValid);
	}
}
