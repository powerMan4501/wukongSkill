using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USourceEffectEnvelopeFollowerPreset : USoundEffectSourcePreset
{
	private static bool Settings_IsValid;

	private static int Settings_Offset;

	private static bool UnregisterEnvelopeFollowerListener_IsValid;

	private static IntPtr UnregisterEnvelopeFollowerListener_FunctionAddress;

	private static int UnregisterEnvelopeFollowerListener_ParamsSize;

	private static bool UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_IsValid;

	private static FFieldAddress UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_PropertyAddress;

	private static int UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset;

	private static bool SetSettings_IsValid;

	private static IntPtr SetSettings_FunctionAddress;

	private static int SetSettings_ParamsSize;

	private static bool SetSettings_InSettings_IsValid;

	private static FFieldAddress SetSettings_InSettings_PropertyAddress;

	private static int SetSettings_InSettings_Offset;

	private static bool RegisterEnvelopeFollowerListener_IsValid;

	private static IntPtr RegisterEnvelopeFollowerListener_FunctionAddress;

	private static int RegisterEnvelopeFollowerListener_ParamsSize;

	private static bool RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_IsValid;

	private static FFieldAddress RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_PropertyAddress;

	private static int RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:Settings")]
	public FSourceEffectEnvelopeFollowerSettings Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:Settings");
				return default(FSourceEffectEnvelopeFollowerSettings);
			}
			return FSourceEffectEnvelopeFollowerSettings.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:Settings");
			}
			else
			{
				FSourceEffectEnvelopeFollowerSettings.ToNative(IntPtr.Add(base.Address, Settings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:UnregisterEnvelopeFollowerListener")]
	public unsafe void UnregisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener)
	{
		CheckDestroyed();
		if (!UnregisterEnvelopeFollowerListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:UnregisterEnvelopeFollowerListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterEnvelopeFollowerListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterEnvelopeFollowerListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnvelopeFollowerListener>.ToNative(IntPtr.Add(intPtr, UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset), 0, UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_PropertyAddress.Address, EnvelopeFollowerListener);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterEnvelopeFollowerListener_FunctionAddress, intPtr, UnregisterEnvelopeFollowerListener_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:SetSettings")]
	public unsafe void SetSettings(FSourceEffectEnvelopeFollowerSettings InSettings)
	{
		CheckDestroyed();
		if (!SetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:SetSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSettings_InSettings_PropertyAddress.Address, intPtr);
		FSourceEffectEnvelopeFollowerSettings.ToNative(IntPtr.Add(intPtr, SetSettings_InSettings_Offset), 0, SetSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSettings_FunctionAddress, intPtr, SetSettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:RegisterEnvelopeFollowerListener")]
	public unsafe void RegisterEnvelopeFollowerListener(UEnvelopeFollowerListener EnvelopeFollowerListener)
	{
		CheckDestroyed();
		if (!RegisterEnvelopeFollowerListener_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:RegisterEnvelopeFollowerListener");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterEnvelopeFollowerListener_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterEnvelopeFollowerListener_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEnvelopeFollowerListener>.ToNative(IntPtr.Add(intPtr, RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset), 0, RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_PropertyAddress.Address, EnvelopeFollowerListener);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterEnvelopeFollowerListener_FunctionAddress, intPtr, RegisterEnvelopeFollowerListener_ParamsSize);
	}

	static USourceEffectEnvelopeFollowerPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USourceEffectEnvelopeFollowerPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USourceEffectEnvelopeFollowerPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Settings", Classes.FStructProperty);
		UnregisterEnvelopeFollowerListener_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnregisterEnvelopeFollowerListener");
		UnregisterEnvelopeFollowerListener_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterEnvelopeFollowerListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_PropertyAddress, UnregisterEnvelopeFollowerListener_FunctionAddress, "EnvelopeFollowerListener");
		UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterEnvelopeFollowerListener_FunctionAddress, "EnvelopeFollowerListener");
		UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterEnvelopeFollowerListener_FunctionAddress, "EnvelopeFollowerListener", Classes.FObjectProperty);
		UnregisterEnvelopeFollowerListener_IsValid = UnregisterEnvelopeFollowerListener_FunctionAddress != IntPtr.Zero && UnregisterEnvelopeFollowerListener_EnvelopeFollowerListener_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:UnregisterEnvelopeFollowerListener", UnregisterEnvelopeFollowerListener_IsValid);
		SetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSettings");
		SetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSettings_InSettings_PropertyAddress, SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetSettings_FunctionAddress, "InSettings");
		SetSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetSettings_IsValid = SetSettings_FunctionAddress != IntPtr.Zero && SetSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:SetSettings", SetSettings_IsValid);
		RegisterEnvelopeFollowerListener_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterEnvelopeFollowerListener");
		RegisterEnvelopeFollowerListener_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterEnvelopeFollowerListener_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_PropertyAddress, RegisterEnvelopeFollowerListener_FunctionAddress, "EnvelopeFollowerListener");
		RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_Offset = NativeReflectionCached.GetPropertyOffset(RegisterEnvelopeFollowerListener_FunctionAddress, "EnvelopeFollowerListener");
		RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterEnvelopeFollowerListener_FunctionAddress, "EnvelopeFollowerListener", Classes.FObjectProperty);
		RegisterEnvelopeFollowerListener_IsValid = RegisterEnvelopeFollowerListener_FunctionAddress != IntPtr.Zero && RegisterEnvelopeFollowerListener_EnvelopeFollowerListener_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SourceEffectEnvelopeFollowerPreset:RegisterEnvelopeFollowerListener", RegisterEnvelopeFollowerListener_IsValid);
	}
}
