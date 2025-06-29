using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset", "AudioMixer", UnrealModuleType.Engine)]
public class USubmixEffectDynamicsProcessorPreset : USoundEffectSubmixPreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_Settings_IsValid;

	private static FFieldAddress SetSettings_Settings_PropertyAddress;

	private static int SetSettings_Settings_Offset;

	private static bool SetExternalSubmix_IsValid;

	private static IntPtr SetExternalSubmix_FunctionAddress;

	private static int SetExternalSubmix_ParamsSize;

	private static bool SetExternalSubmix_Submix_IsValid;

	private static FFieldAddress SetExternalSubmix_Submix_PropertyAddress;

	private static int SetExternalSubmix_Submix_Offset;

	private static bool SetAudioBus_IsValid;

	private static IntPtr SetAudioBus_FunctionAddress;

	private static int SetAudioBus_ParamsSize;

	private static bool SetAudioBus_AudioBus_IsValid;

	private static FFieldAddress SetAudioBus_AudioBus_PropertyAddress;

	private static int SetAudioBus_AudioBus_Offset;

	private static bool ResetKey_IsValid;

	private static IntPtr ResetKey_FunctionAddress;

	private static int ResetKey_ParamsSize;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:Settings")]
	public FSubmixEffectDynamicsProcessorSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:Settings");
				return default(FSubmixEffectDynamicsProcessorSettings);
			}
			return FSubmixEffectDynamicsProcessorSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:Settings");
			}
			else
			{
				FSubmixEffectDynamicsProcessorSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectDynamicsProcessorSettings Settings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_Settings_PropertyAddress.Address, intPtr);
		FSubmixEffectDynamicsProcessorSettings.ToNative(IntPtr.Add(intPtr, SetSettings_Settings_Offset), 0, SetSettings_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetExternalSubmix")]
	public unsafe void SetExternalSubmix(USoundSubmix Submix)
	{
		CheckDestroyed();
		if (!SetExternalSubmix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetExternalSubmix");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExternalSubmix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExternalSubmix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, SetExternalSubmix_Submix_Offset), 0, SetExternalSubmix_Submix_PropertyAddress.Address, Submix);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetExternalSubmix_FunctionAddress, intPtr, SetExternalSubmix_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetAudioBus")]
	public unsafe void SetAudioBus(UAudioBus AudioBus)
	{
		CheckDestroyed();
		if (!SetAudioBus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetAudioBus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioBus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioBus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(intPtr, SetAudioBus_AudioBus_Offset), 0, SetAudioBus_AudioBus_PropertyAddress.Address, AudioBus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioBus_FunctionAddress, intPtr, SetAudioBus_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:ResetKey")]
	public unsafe void ResetKey()
	{
		CheckDestroyed();
		if (!ResetKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:ResetKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetKey_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetKey_FunctionAddress, argsSize: ResetKey_ParamsSize);
	}

	static USubmixEffectDynamicsProcessorPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectDynamicsProcessorPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectDynamicsProcessorPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_Settings_PropertyAddress, SetSettings_FunctionAddress, "Settings");
		SetSettings_Settings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "Settings");
		SetSettings_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "Settings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_Settings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetSettings", SetSettings_IsValid);
		SetExternalSubmix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetExternalSubmix");
		SetExternalSubmix_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExternalSubmix_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExternalSubmix_Submix_PropertyAddress, SetExternalSubmix_FunctionAddress, "Submix");
		SetExternalSubmix_Submix_Offset = NativeReflectionCached.GetPropertyOffset(SetExternalSubmix_FunctionAddress, "Submix");
		SetExternalSubmix_Submix_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExternalSubmix_FunctionAddress, "Submix", Classes.FObjectProperty);
		SetExternalSubmix_IsValid = SetExternalSubmix_FunctionAddress != IntPtr.Zero && SetExternalSubmix_Submix_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetExternalSubmix", SetExternalSubmix_IsValid);
		SetAudioBus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioBus");
		SetAudioBus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioBus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBus_AudioBus_PropertyAddress, SetAudioBus_FunctionAddress, "AudioBus");
		SetAudioBus_AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBus_FunctionAddress, "AudioBus");
		SetAudioBus_AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBus_FunctionAddress, "AudioBus", Classes.FObjectProperty);
		SetAudioBus_IsValid = SetAudioBus_FunctionAddress != IntPtr.Zero && SetAudioBus_AudioBus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:SetAudioBus", SetAudioBus_IsValid);
		ResetKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetKey");
		ResetKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetKey_FunctionAddress);
		ResetKey_IsValid = ResetKey_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset:ResetKey", ResetKey_IsValid);
	}
}
