using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USourceEffectMidSideSpreaderPreset : USoundEffectSourcePreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderPreset:Settings")]
	public FSourceEffectMidSideSpreaderSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectMidSideSpreaderPreset:Settings");
				return default(FSourceEffectMidSideSpreaderSettings);
			}
			return FSourceEffectMidSideSpreaderSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectMidSideSpreaderPreset:Settings");
			}
			else
			{
				FSourceEffectMidSideSpreaderSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderPreset:SetSettings")]
	public unsafe void SetSettings(FSourceEffectMidSideSpreaderSettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectMidSideSpreaderPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSourceEffectMidSideSpreaderSettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	static USourceEffectMidSideSpreaderPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USourceEffectMidSideSpreaderPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USourceEffectMidSideSpreaderPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SourceEffectMidSideSpreaderPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectMidSideSpreaderPreset:SetSettings", SetSettings_IsValid);
	}
}
