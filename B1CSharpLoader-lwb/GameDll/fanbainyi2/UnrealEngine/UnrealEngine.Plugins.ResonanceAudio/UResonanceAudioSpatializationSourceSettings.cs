using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UClass(Flags = (ClassFlags)810553508uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public class UResonanceAudioSpatializationSourceSettings : USpatializationPluginSourceSettingsBase
{
	private static bool SetSoundSourceSpread_IsValid;

	private static IntPtr SetSoundSourceSpread_FunctionAddress;

	private static int SetSoundSourceSpread_ParamsSize;

	private static bool SetSoundSourceSpread_InSpread_IsValid;

	private static FFieldAddress SetSoundSourceSpread_InSpread_PropertyAddress;

	private static int SetSoundSourceSpread_InSpread_Offset;

	private static bool SetSoundSourceDirectivity_IsValid;

	private static IntPtr SetSoundSourceDirectivity_FunctionAddress;

	private static int SetSoundSourceDirectivity_ParamsSize;

	private static bool SetSoundSourceDirectivity_InPattern_IsValid;

	private static FFieldAddress SetSoundSourceDirectivity_InPattern_PropertyAddress;

	private static int SetSoundSourceDirectivity_InPattern_Offset;

	private static bool SetSoundSourceDirectivity_InSharpness_IsValid;

	private static FFieldAddress SetSoundSourceDirectivity_InSharpness_PropertyAddress;

	private static int SetSoundSourceDirectivity_InSharpness_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings:SetSoundSourceSpread")]
	public unsafe void SetSoundSourceSpread(float InSpread)
	{
		CheckDestroyed();
		if (!SetSoundSourceSpread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings:SetSoundSourceSpread");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSoundSourceSpread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSoundSourceSpread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSoundSourceSpread_InSpread_Offset), 0, SetSoundSourceSpread_InSpread_PropertyAddress.Address, InSpread);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSoundSourceSpread_FunctionAddress, intPtr, SetSoundSourceSpread_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings:SetSoundSourceDirectivity")]
	public unsafe void SetSoundSourceDirectivity(float InPattern, float InSharpness)
	{
		CheckDestroyed();
		if (!SetSoundSourceDirectivity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings:SetSoundSourceDirectivity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSoundSourceDirectivity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSoundSourceDirectivity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSoundSourceDirectivity_InPattern_Offset), 0, SetSoundSourceDirectivity_InPattern_PropertyAddress.Address, InPattern);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSoundSourceDirectivity_InSharpness_Offset), 0, SetSoundSourceDirectivity_InSharpness_PropertyAddress.Address, InSharpness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSoundSourceDirectivity_FunctionAddress, intPtr, SetSoundSourceDirectivity_ParamsSize);
	}

	static UResonanceAudioSpatializationSourceSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UResonanceAudioSpatializationSourceSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UResonanceAudioSpatializationSourceSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings");
		SetSoundSourceSpread_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSoundSourceSpread");
		SetSoundSourceSpread_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoundSourceSpread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoundSourceSpread_InSpread_PropertyAddress, SetSoundSourceSpread_FunctionAddress, "InSpread");
		SetSoundSourceSpread_InSpread_Offset = NativeReflectionCached.GetPropertyOffset(SetSoundSourceSpread_FunctionAddress, "InSpread");
		SetSoundSourceSpread_InSpread_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoundSourceSpread_FunctionAddress, "InSpread", Classes.FFloatProperty);
		SetSoundSourceSpread_IsValid = SetSoundSourceSpread_FunctionAddress != IntPtr.Zero && SetSoundSourceSpread_InSpread_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings:SetSoundSourceSpread", SetSoundSourceSpread_IsValid);
		SetSoundSourceDirectivity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSoundSourceDirectivity");
		SetSoundSourceDirectivity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoundSourceDirectivity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoundSourceDirectivity_InPattern_PropertyAddress, SetSoundSourceDirectivity_FunctionAddress, "InPattern");
		SetSoundSourceDirectivity_InPattern_Offset = NativeReflectionCached.GetPropertyOffset(SetSoundSourceDirectivity_FunctionAddress, "InPattern");
		SetSoundSourceDirectivity_InPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoundSourceDirectivity_FunctionAddress, "InPattern", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSoundSourceDirectivity_InSharpness_PropertyAddress, SetSoundSourceDirectivity_FunctionAddress, "InSharpness");
		SetSoundSourceDirectivity_InSharpness_Offset = NativeReflectionCached.GetPropertyOffset(SetSoundSourceDirectivity_FunctionAddress, "InSharpness");
		SetSoundSourceDirectivity_InSharpness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoundSourceDirectivity_FunctionAddress, "InSharpness", Classes.FFloatProperty);
		SetSoundSourceDirectivity_IsValid = SetSoundSourceDirectivity_FunctionAddress != IntPtr.Zero && SetSoundSourceDirectivity_InPattern_IsValid && SetSoundSourceDirectivity_InSharpness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings:SetSoundSourceDirectivity", SetSoundSourceDirectivity_IsValid);
	}
}
