using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USubmixEffectFlexiverbPreset : USoundEffectSubmixPreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbPreset:Settings")]
	public FSubmixEffectFlexiverbSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectFlexiverbPreset:Settings");
				return default(FSubmixEffectFlexiverbSettings);
			}
			return FSubmixEffectFlexiverbSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SubmixEffectFlexiverbPreset:Settings");
			}
			else
			{
				FSubmixEffectFlexiverbSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFlexiverbPreset:SetSettings")]
	public unsafe void SetSettings(FSubmixEffectFlexiverbSettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SubmixEffectFlexiverbPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSubmixEffectFlexiverbSettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	static USubmixEffectFlexiverbPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USubmixEffectFlexiverbPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USubmixEffectFlexiverbPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SubmixEffectFlexiverbPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SubmixEffectFlexiverbPreset:SetSettings", SetSettings_IsValid);
	}
}
