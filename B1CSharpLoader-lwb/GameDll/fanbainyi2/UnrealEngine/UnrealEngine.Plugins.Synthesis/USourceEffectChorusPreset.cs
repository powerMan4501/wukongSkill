using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USourceEffectChorusPreset : USoundEffectSourcePreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetWetModulator_IsValid;

	private static IntPtr SetWetModulator_FunctionAddress;

	private static int SetWetModulator_ParamsSize;

	private static bool SetWetModulator_Modulator_IsValid;

	private static FFieldAddress SetWetModulator_Modulator_PropertyAddress;

	private static int SetWetModulator_Modulator_Offset;

	private static bool SetWet_IsValid;

	private static IntPtr SetWet_FunctionAddress;

	private static int SetWet_ParamsSize;

	private static bool SetWet_WetAmount_IsValid;

	private static FFieldAddress SetWet_WetAmount_PropertyAddress;

	private static int SetWet_WetAmount_Offset;

	private static bool SetSpreadModulator_IsValid;

	private static IntPtr SetSpreadModulator_FunctionAddress;

	private static int SetSpreadModulator_ParamsSize;

	private static bool SetSpreadModulator_Modulator_IsValid;

	private static FFieldAddress SetSpreadModulator_Modulator_PropertyAddress;

	private static int SetSpreadModulator_Modulator_Offset;

	private static bool SetSpread_IsValid;

	private static IntPtr SetSpread_FunctionAddress;

	private static int SetSpread_ParamsSize;

	private static bool SetSpread_Spread_IsValid;

	private static FFieldAddress SetSpread_Spread_PropertyAddress;

	private static int SetSpread_Spread_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_Settings_IsValid;

	private static FFieldAddress SetSettings_Settings_PropertyAddress;

	private static int SetSettings_Settings_Offset;

	private static bool SetModulationSettings_IsValid;

	private static IntPtr SetModulationSettings_FunctionAddress;

	private static int SetModulationSettings_ParamsSize;

	private static bool SetModulationSettings_ModulationSettings_IsValid;

	private static FFieldAddress SetModulationSettings_ModulationSettings_PropertyAddress;

	private static int SetModulationSettings_ModulationSettings_Offset;

	private static bool SetFrequencyModulator_IsValid;

	private static IntPtr SetFrequencyModulator_FunctionAddress;

	private static int SetFrequencyModulator_ParamsSize;

	private static bool SetFrequencyModulator_Modulator_IsValid;

	private static FFieldAddress SetFrequencyModulator_Modulator_PropertyAddress;

	private static int SetFrequencyModulator_Modulator_Offset;

	private static bool SetFrequency_IsValid;

	private static IntPtr SetFrequency_FunctionAddress;

	private static int SetFrequency_ParamsSize;

	private static bool SetFrequency_Frequency_IsValid;

	private static FFieldAddress SetFrequency_Frequency_PropertyAddress;

	private static int SetFrequency_Frequency_Offset;

	private static bool SetFeedbackModulator_IsValid;

	private static IntPtr SetFeedbackModulator_FunctionAddress;

	private static int SetFeedbackModulator_ParamsSize;

	private static bool SetFeedbackModulator_Modulator_IsValid;

	private static FFieldAddress SetFeedbackModulator_Modulator_PropertyAddress;

	private static int SetFeedbackModulator_Modulator_Offset;

	private static bool SetFeedback_IsValid;

	private static IntPtr SetFeedback_FunctionAddress;

	private static int SetFeedback_ParamsSize;

	private static bool SetFeedback_Feedback_IsValid;

	private static FFieldAddress SetFeedback_Feedback_PropertyAddress;

	private static int SetFeedback_Feedback_Offset;

	private static bool SetDryModulator_IsValid;

	private static IntPtr SetDryModulator_FunctionAddress;

	private static int SetDryModulator_ParamsSize;

	private static bool SetDryModulator_Modulator_IsValid;

	private static FFieldAddress SetDryModulator_Modulator_PropertyAddress;

	private static int SetDryModulator_Modulator_Offset;

	private static bool SetDry_IsValid;

	private static IntPtr SetDry_FunctionAddress;

	private static int SetDry_ParamsSize;

	private static bool SetDry_DryAmount_IsValid;

	private static FFieldAddress SetDry_DryAmount_PropertyAddress;

	private static int SetDry_DryAmount_Offset;

	private static bool SetDepthModulator_IsValid;

	private static IntPtr SetDepthModulator_FunctionAddress;

	private static int SetDepthModulator_ParamsSize;

	private static bool SetDepthModulator_Modulator_IsValid;

	private static FFieldAddress SetDepthModulator_Modulator_PropertyAddress;

	private static int SetDepthModulator_Modulator_Offset;

	private static bool SetDepth_IsValid;

	private static IntPtr SetDepth_FunctionAddress;

	private static int SetDepth_ParamsSize;

	private static bool SetDepth_Depth_IsValid;

	private static FFieldAddress SetDepth_Depth_PropertyAddress;

	private static int SetDepth_Depth_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:Settings")]
	public FSourceEffectChorusSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectChorusPreset:Settings");
				return default(FSourceEffectChorusSettings);
			}
			return FSourceEffectChorusSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectChorusPreset:Settings");
			}
			else
			{
				FSourceEffectChorusSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetWetModulator")]
	public unsafe void SetWetModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetWetModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetWetModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWetModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWetModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetWetModulator_Modulator_Offset), 0, SetWetModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWetModulator_FunctionAddress, intPtr, SetWetModulator_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetWet")]
	public unsafe void SetWet(float WetAmount)
	{
		CheckDestroyed();
		if (!SetWet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetWet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWet_WetAmount_Offset), 0, SetWet_WetAmount_PropertyAddress.Address, WetAmount);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWet_FunctionAddress, intPtr, SetWet_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetSpreadModulator")]
	public unsafe void SetSpreadModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetSpreadModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetSpreadModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpreadModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpreadModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetSpreadModulator_Modulator_Offset), 0, SetSpreadModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpreadModulator_FunctionAddress, intPtr, SetSpreadModulator_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetSpread")]
	public unsafe void SetSpread(float Spread)
	{
		CheckDestroyed();
		if (!SetSpread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetSpread");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSpread_Spread_Offset), 0, SetSpread_Spread_PropertyAddress.Address, Spread);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpread_FunctionAddress, intPtr, SetSpread_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetSettings")]
	public unsafe void SetSettings(FSourceEffectChorusBaseSettings Settings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_Settings_PropertyAddress.Address, intPtr);
		FSourceEffectChorusBaseSettings.ToNative(IntPtr.Add(intPtr, SetSettings_Settings_Offset), 0, SetSettings_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetModulationSettings")]
	public unsafe void SetModulationSettings(FSourceEffectChorusSettings ModulationSettings)
	{
		CheckDestroyed();
		if (!SetModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetModulationSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModulationSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModulationSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetModulationSettings_ModulationSettings_PropertyAddress.Address, intPtr);
		FSourceEffectChorusSettings.ToNative(IntPtr.Add(intPtr, SetModulationSettings_ModulationSettings_Offset), 0, SetModulationSettings_ModulationSettings_PropertyAddress.Address, ModulationSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModulationSettings_FunctionAddress, intPtr, SetModulationSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetFrequencyModulator")]
	public unsafe void SetFrequencyModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetFrequencyModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetFrequencyModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrequencyModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrequencyModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetFrequencyModulator_Modulator_Offset), 0, SetFrequencyModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrequencyModulator_FunctionAddress, intPtr, SetFrequencyModulator_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetFrequency")]
	public unsafe void SetFrequency(float Frequency)
	{
		CheckDestroyed();
		if (!SetFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrequency_Frequency_Offset), 0, SetFrequency_Frequency_PropertyAddress.Address, Frequency);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrequency_FunctionAddress, intPtr, SetFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetFeedbackModulator")]
	public unsafe void SetFeedbackModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetFeedbackModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetFeedbackModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFeedbackModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFeedbackModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetFeedbackModulator_Modulator_Offset), 0, SetFeedbackModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFeedbackModulator_FunctionAddress, intPtr, SetFeedbackModulator_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetFeedback")]
	public unsafe void SetFeedback(float Feedback)
	{
		CheckDestroyed();
		if (!SetFeedback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetFeedback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFeedback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFeedback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFeedback_Feedback_Offset), 0, SetFeedback_Feedback_PropertyAddress.Address, Feedback);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFeedback_FunctionAddress, intPtr, SetFeedback_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetDryModulator")]
	public unsafe void SetDryModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetDryModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetDryModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDryModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDryModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetDryModulator_Modulator_Offset), 0, SetDryModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDryModulator_FunctionAddress, intPtr, SetDryModulator_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetDry")]
	public unsafe void SetDry(float DryAmount)
	{
		CheckDestroyed();
		if (!SetDry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetDry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDry_DryAmount_Offset), 0, SetDry_DryAmount_PropertyAddress.Address, DryAmount);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDry_FunctionAddress, intPtr, SetDry_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetDepthModulator")]
	public unsafe void SetDepthModulator(USoundModulatorBase Modulator)
	{
		CheckDestroyed();
		if (!SetDepthModulator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetDepthModulator");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDepthModulator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDepthModulator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundModulatorBase>.ToNative(IntPtr.Add(intPtr, SetDepthModulator_Modulator_Offset), 0, SetDepthModulator_Modulator_PropertyAddress.Address, Modulator);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDepthModulator_FunctionAddress, intPtr, SetDepthModulator_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusPreset:SetDepth")]
	public unsafe void SetDepth(float Depth)
	{
		CheckDestroyed();
		if (!SetDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectChorusPreset:SetDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDepth_Depth_Offset), 0, SetDepth_Depth_PropertyAddress.Address, Depth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDepth_FunctionAddress, intPtr, SetDepth_ParamsSize);
	}

	static USourceEffectChorusPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USourceEffectChorusPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USourceEffectChorusPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SourceEffectChorusPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetWetModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWetModulator");
		SetWetModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWetModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWetModulator_Modulator_PropertyAddress, SetWetModulator_FunctionAddress, "Modulator");
		SetWetModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetWetModulator_FunctionAddress, "Modulator");
		SetWetModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWetModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetWetModulator_IsValid = SetWetModulator_FunctionAddress != IntPtr.Zero && SetWetModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetWetModulator", SetWetModulator_IsValid);
		SetWet_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWet");
		SetWet_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWet_WetAmount_PropertyAddress, SetWet_FunctionAddress, "WetAmount");
		SetWet_WetAmount_Offset = NativeReflectionCached.GetPropertyOffset(SetWet_FunctionAddress, "WetAmount");
		SetWet_WetAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWet_FunctionAddress, "WetAmount", Classes.FFloatProperty);
		SetWet_IsValid = SetWet_FunctionAddress != IntPtr.Zero && SetWet_WetAmount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetWet", SetWet_IsValid);
		SetSpreadModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpreadModulator");
		SetSpreadModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpreadModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpreadModulator_Modulator_PropertyAddress, SetSpreadModulator_FunctionAddress, "Modulator");
		SetSpreadModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetSpreadModulator_FunctionAddress, "Modulator");
		SetSpreadModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpreadModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetSpreadModulator_IsValid = SetSpreadModulator_FunctionAddress != IntPtr.Zero && SetSpreadModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetSpreadModulator", SetSpreadModulator_IsValid);
		SetSpread_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpread");
		SetSpread_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpread_Spread_PropertyAddress, SetSpread_FunctionAddress, "Spread");
		SetSpread_Spread_Offset = NativeReflectionCached.GetPropertyOffset(SetSpread_FunctionAddress, "Spread");
		SetSpread_Spread_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpread_FunctionAddress, "Spread", Classes.FFloatProperty);
		SetSpread_IsValid = SetSpread_FunctionAddress != IntPtr.Zero && SetSpread_Spread_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetSpread", SetSpread_IsValid);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_Settings_PropertyAddress, SetSettings_FunctionAddress, "Settings");
		SetSettings_Settings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "Settings");
		SetSettings_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "Settings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_Settings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetSettings", SetSettings_IsValid);
		SetModulationSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModulationSettings");
		SetModulationSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModulationSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModulationSettings_ModulationSettings_PropertyAddress, SetModulationSettings_FunctionAddress, "ModulationSettings");
		SetModulationSettings_ModulationSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetModulationSettings_FunctionAddress, "ModulationSettings");
		SetModulationSettings_ModulationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModulationSettings_FunctionAddress, "ModulationSettings", Classes.FStructProperty);
		SetModulationSettings_IsValid = SetModulationSettings_FunctionAddress != IntPtr.Zero && SetModulationSettings_ModulationSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetModulationSettings", SetModulationSettings_IsValid);
		SetFrequencyModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrequencyModulator");
		SetFrequencyModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrequencyModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrequencyModulator_Modulator_PropertyAddress, SetFrequencyModulator_FunctionAddress, "Modulator");
		SetFrequencyModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetFrequencyModulator_FunctionAddress, "Modulator");
		SetFrequencyModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrequencyModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetFrequencyModulator_IsValid = SetFrequencyModulator_FunctionAddress != IntPtr.Zero && SetFrequencyModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetFrequencyModulator", SetFrequencyModulator_IsValid);
		SetFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrequency");
		SetFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrequency_Frequency_PropertyAddress, SetFrequency_FunctionAddress, "Frequency");
		SetFrequency_Frequency_Offset = NativeReflectionCached.GetPropertyOffset(SetFrequency_FunctionAddress, "Frequency");
		SetFrequency_Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrequency_FunctionAddress, "Frequency", Classes.FFloatProperty);
		SetFrequency_IsValid = SetFrequency_FunctionAddress != IntPtr.Zero && SetFrequency_Frequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetFrequency", SetFrequency_IsValid);
		SetFeedbackModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFeedbackModulator");
		SetFeedbackModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFeedbackModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFeedbackModulator_Modulator_PropertyAddress, SetFeedbackModulator_FunctionAddress, "Modulator");
		SetFeedbackModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetFeedbackModulator_FunctionAddress, "Modulator");
		SetFeedbackModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFeedbackModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetFeedbackModulator_IsValid = SetFeedbackModulator_FunctionAddress != IntPtr.Zero && SetFeedbackModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetFeedbackModulator", SetFeedbackModulator_IsValid);
		SetFeedback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFeedback");
		SetFeedback_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFeedback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFeedback_Feedback_PropertyAddress, SetFeedback_FunctionAddress, "Feedback");
		SetFeedback_Feedback_Offset = NativeReflectionCached.GetPropertyOffset(SetFeedback_FunctionAddress, "Feedback");
		SetFeedback_Feedback_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFeedback_FunctionAddress, "Feedback", Classes.FFloatProperty);
		SetFeedback_IsValid = SetFeedback_FunctionAddress != IntPtr.Zero && SetFeedback_Feedback_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetFeedback", SetFeedback_IsValid);
		SetDryModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDryModulator");
		SetDryModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDryModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDryModulator_Modulator_PropertyAddress, SetDryModulator_FunctionAddress, "Modulator");
		SetDryModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetDryModulator_FunctionAddress, "Modulator");
		SetDryModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDryModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetDryModulator_IsValid = SetDryModulator_FunctionAddress != IntPtr.Zero && SetDryModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetDryModulator", SetDryModulator_IsValid);
		SetDry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDry");
		SetDry_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDry_DryAmount_PropertyAddress, SetDry_FunctionAddress, "DryAmount");
		SetDry_DryAmount_Offset = NativeReflectionCached.GetPropertyOffset(SetDry_FunctionAddress, "DryAmount");
		SetDry_DryAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDry_FunctionAddress, "DryAmount", Classes.FFloatProperty);
		SetDry_IsValid = SetDry_FunctionAddress != IntPtr.Zero && SetDry_DryAmount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetDry", SetDry_IsValid);
		SetDepthModulator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDepthModulator");
		SetDepthModulator_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDepthModulator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDepthModulator_Modulator_PropertyAddress, SetDepthModulator_FunctionAddress, "Modulator");
		SetDepthModulator_Modulator_Offset = NativeReflectionCached.GetPropertyOffset(SetDepthModulator_FunctionAddress, "Modulator");
		SetDepthModulator_Modulator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDepthModulator_FunctionAddress, "Modulator", Classes.FObjectProperty);
		SetDepthModulator_IsValid = SetDepthModulator_FunctionAddress != IntPtr.Zero && SetDepthModulator_Modulator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetDepthModulator", SetDepthModulator_IsValid);
		SetDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDepth");
		SetDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDepth_Depth_PropertyAddress, SetDepth_FunctionAddress, "Depth");
		SetDepth_Depth_Offset = NativeReflectionCached.GetPropertyOffset(SetDepth_FunctionAddress, "Depth");
		SetDepth_Depth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDepth_FunctionAddress, "Depth", Classes.FFloatProperty);
		SetDepth_IsValid = SetDepth_FunctionAddress != IntPtr.Zero && SetDepth_Depth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectChorusPreset:SetDepth", SetDepth_IsValid);
	}
}
