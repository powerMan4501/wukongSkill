using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USourceEffectBitCrusherPreset : USoundEffectSourcePreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_Settings_IsValid;

	private static FFieldAddress SetSettings_Settings_PropertyAddress;

	private static int SetSettings_Settings_Offset;

	private static bool SetSampleRateModulator_IsValid;

	private static IntPtr SetSampleRateModulator_FunctionAddress;

	private static int SetSampleRateModulator_ParamsSize;

	private static bool SetSampleRateModulator_Modulator_IsValid;

	private static FFieldAddress SetSampleRateModulator_Modulator_PropertyAddress;

	private static int SetSampleRateModulator_Modulator_Offset;

	private static bool SetSampleRate_IsValid;

	private static IntPtr SetSampleRate_FunctionAddress;

	private static int SetSampleRate_ParamsSize;

	private static bool SetSampleRate_SampleRate_IsValid;

	private static FFieldAddress SetSampleRate_SampleRate_PropertyAddress;

	private static int SetSampleRate_SampleRate_Offset;

	private static bool SetModulationSettings_IsValid;

	private static IntPtr SetModulationSettings_FunctionAddress;

	private static int SetModulationSettings_ParamsSize;

	private static bool SetModulationSettings_ModulationSettings_IsValid;

	private static FFieldAddress SetModulationSettings_ModulationSettings_PropertyAddress;

	private static int SetModulationSettings_ModulationSettings_Offset;

	private static bool SetBits_IsValid;

	private static IntPtr SetBits_FunctionAddress;

	private static int SetBits_ParamsSize;

	private static bool SetBits_Bits_IsValid;

	private static FFieldAddress SetBits_Bits_PropertyAddress;

	private static int SetBits_Bits_Offset;

	private static bool SetBitModulator_IsValid;

	private static IntPtr SetBitModulator_FunctionAddress;

	private static int SetBitModulator_ParamsSize;

	private static bool SetBitModulator_Modulator_IsValid;

	private static FFieldAddress SetBitModulator_Modulator_PropertyAddress;

	private static int SetBitModulator_Modulator_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset:Settings")]
	public FSourceEffectBitCrusherSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:Settings");
				return default(FSourceEffectBitCrusherSettings);
			}
			return FSourceEffectBitCrusherSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:Settings");
			}
			else
			{
				FSourceEffectBitCrusherSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSettings")]
	public unsafe void SetSettings(FSourceEffectBitCrusherBaseSettings Settings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_Settings_PropertyAddress.Address, intPtr);
		FSourceEffectBitCrusherBaseSettings.ToNative(IntPtr.Add(intPtr, SetSettings_Settings_Offset), 0, SetSettings_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSampleRateModulator")]
	public unsafe void SetSampleRateModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetSampleRateModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSampleRateModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSampleRateModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSampleRateModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetSampleRateModulator_Modulator_Offset), 0, SetSampleRateModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSampleRateModulator_FunctionAddress, intPtr, SetSampleRateModulator_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSampleRate")]
	public unsafe void SetSampleRate(float SampleRate)
	{
		CheckDestroyed();
		if (!SetSampleRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSampleRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSampleRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSampleRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSampleRate_SampleRate_Offset), 0, SetSampleRate_SampleRate_PropertyAddress.Address, SampleRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSampleRate_FunctionAddress, intPtr, SetSampleRate_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset:SetModulationSettings")]
	public unsafe void SetModulationSettings(FSourceEffectBitCrusherSettings ModulationSettings)
	{
		CheckDestroyed();
		if (!SetModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:SetModulationSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModulationSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModulationSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetModulationSettings_ModulationSettings_PropertyAddress.Address, intPtr);
		FSourceEffectBitCrusherSettings.ToNative(IntPtr.Add(intPtr, SetModulationSettings_ModulationSettings_Offset), 0, SetModulationSettings_ModulationSettings_PropertyAddress.Address, ModulationSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModulationSettings_FunctionAddress, intPtr, SetModulationSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset:SetBits")]
	public unsafe void SetBits(float Bits)
	{
		CheckDestroyed();
		if (!SetBits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:SetBits");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBits_Bits_Offset), 0, SetBits_Bits_PropertyAddress.Address, Bits);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBits_FunctionAddress, intPtr, SetBits_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherPreset:SetBitModulator")]
	public unsafe void SetBitModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetBitModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectBitCrusherPreset:SetBitModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBitModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBitModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetBitModulator_Modulator_Offset), 0, SetBitModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBitModulator_FunctionAddress, intPtr, SetBitModulator_ParamsSize);
	}

	static USourceEffectBitCrusherPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USourceEffectBitCrusherPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USourceEffectBitCrusherPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SourceEffectBitCrusherPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_Settings_PropertyAddress, SetSettings_FunctionAddress, "Settings");
		SetSettings_Settings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "Settings");
		SetSettings_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "Settings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_Settings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSettings", SetSettings_IsValid);
		SetSampleRateModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSampleRateModulator");
		SetSampleRateModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSampleRateModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSampleRateModulator_Modulator_PropertyAddress, SetSampleRateModulator_FunctionAddress, "Modulator");
		SetSampleRateModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetSampleRateModulator_FunctionAddress, "Modulator");
		SetSampleRateModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSampleRateModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetSampleRateModulator_IsValid = SetSampleRateModulator_FunctionAddress != IntPtr.Zero && SetSampleRateModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSampleRateModulator", SetSampleRateModulator_IsValid);
		SetSampleRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSampleRate");
		SetSampleRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSampleRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSampleRate_SampleRate_PropertyAddress, SetSampleRate_FunctionAddress, "SampleRate");
		SetSampleRate_SampleRate_Offset = NativeReflectionCached.GetPropertyOffset(SetSampleRate_FunctionAddress, "SampleRate");
		SetSampleRate_SampleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSampleRate_FunctionAddress, "SampleRate", Classes.FFloatProperty);
		SetSampleRate_IsValid = SetSampleRate_FunctionAddress != IntPtr.Zero && SetSampleRate_SampleRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectBitCrusherPreset:SetSampleRate", SetSampleRate_IsValid);
		SetModulationSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModulationSettings");
		SetModulationSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModulationSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModulationSettings_ModulationSettings_PropertyAddress, SetModulationSettings_FunctionAddress, "ModulationSettings");
		SetModulationSettings_ModulationSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetModulationSettings_FunctionAddress, "ModulationSettings");
		SetModulationSettings_ModulationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModulationSettings_FunctionAddress, "ModulationSettings", Classes.FStructProperty);
		SetModulationSettings_IsValid = SetModulationSettings_FunctionAddress != IntPtr.Zero && SetModulationSettings_ModulationSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectBitCrusherPreset:SetModulationSettings", SetModulationSettings_IsValid);
		SetBits_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBits");
		SetBits_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBits_Bits_PropertyAddress, SetBits_FunctionAddress, "Bits");
		SetBits_Bits_Offset = NativeReflectionCached.GetPropertyOffset(SetBits_FunctionAddress, "Bits");
		SetBits_Bits_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBits_FunctionAddress, "Bits", Classes.FFloatProperty);
		SetBits_IsValid = SetBits_FunctionAddress != IntPtr.Zero && SetBits_Bits_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectBitCrusherPreset:SetBits", SetBits_IsValid);
		SetBitModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBitModulator");
		SetBitModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBitModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBitModulator_Modulator_PropertyAddress, SetBitModulator_FunctionAddress, "Modulator");
		SetBitModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetBitModulator_FunctionAddress, "Modulator");
		SetBitModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBitModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetBitModulator_IsValid = SetBitModulator_FunctionAddress != IntPtr.Zero && SetBitModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectBitCrusherPreset:SetBitModulator", SetBitModulator_IsValid);
	}
}
