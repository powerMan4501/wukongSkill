using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USubmixEffectMultibandCompressorPreset : USoundEffectSubmixPreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

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

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:Settings")]
	public FSubmixEffectMultibandCompressorSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:Settings");
				return default(FSubmixEffectMultibandCompressorSettings);
			}
			return FSubmixEffectMultibandCompressorSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:Settings");
			}
			else
			{
				FSubmixEffectMultibandCompressorSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectMultibandCompressorSettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectMultibandCompressorSettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetExternalSubmix")]
	public unsafe void SetExternalSubmix(USoundSubmix Submix)
	{
		CheckDestroyed();
		if (!SetExternalSubmix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetExternalSubmix");
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
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetAudioBus")]
	public unsafe void SetAudioBus(UAudioBus AudioBus)
	{
		CheckDestroyed();
		if (!SetAudioBus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetAudioBus");
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
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:ResetKey")]
	public unsafe void ResetKey()
	{
		CheckDestroyed();
		if (!ResetKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:ResetKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetKey_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetKey_FunctionAddress, argsSize: ResetKey_ParamsSize);
	}

	static USubmixEffectMultibandCompressorPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectMultibandCompressorPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectMultibandCompressorPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SubmixEffectMultibandCompressorPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetSettings", SetSettings_IsValid);
		SetExternalSubmix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetExternalSubmix");
		SetExternalSubmix_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExternalSubmix_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExternalSubmix_Submix_PropertyAddress, SetExternalSubmix_FunctionAddress, "Submix");
		SetExternalSubmix_Submix_Offset = NativeReflectionCached.GetPropertyOffset(SetExternalSubmix_FunctionAddress, "Submix");
		SetExternalSubmix_Submix_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExternalSubmix_FunctionAddress, "Submix", Classes.FObjectProperty);
		SetExternalSubmix_IsValid = SetExternalSubmix_FunctionAddress != IntPtr.Zero && SetExternalSubmix_Submix_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetExternalSubmix", SetExternalSubmix_IsValid);
		SetAudioBus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioBus");
		SetAudioBus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioBus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBus_AudioBus_PropertyAddress, SetAudioBus_FunctionAddress, "AudioBus");
		SetAudioBus_AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBus_FunctionAddress, "AudioBus");
		SetAudioBus_AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBus_FunctionAddress, "AudioBus", Classes.FObjectProperty);
		SetAudioBus_IsValid = SetAudioBus_FunctionAddress != IntPtr.Zero && SetAudioBus_AudioBus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:SetAudioBus", SetAudioBus_IsValid);
		ResetKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetKey");
		ResetKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetKey_FunctionAddress);
		ResetKey_IsValid = ResetKey_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectMultibandCompressorPreset:ResetKey", ResetKey_IsValid);
	}
}
