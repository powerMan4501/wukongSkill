using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public class UResonanceAudioBlueprintFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetGlobalReverbPreset_IsValid;

	private static IntPtr SetGlobalReverbPreset_FunctionAddress;

	private static int SetGlobalReverbPreset_ParamsSize;

	private static bool SetGlobalReverbPreset_InPreset_IsValid;

	private static FFieldAddress SetGlobalReverbPreset_InPreset_PropertyAddress;

	private static int SetGlobalReverbPreset_InPreset_Offset;

	private static bool GetGlobalReverbPreset_IsValid;

	private static IntPtr GetGlobalReverbPreset_FunctionAddress;

	private static int GetGlobalReverbPreset_ParamsSize;

	private static bool GetGlobalReverbPreset_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalReverbPreset_ReturnValue_PropertyAddress;

	private static int GetGlobalReverbPreset_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary:SetGlobalReverbPreset")]
	public unsafe static void SetGlobalReverbPreset(UResonanceAudioReverbPluginPreset InPreset)
	{
		if (!SetGlobalReverbPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary:SetGlobalReverbPreset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGlobalReverbPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGlobalReverbPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UResonanceAudioReverbPluginPreset>.ToNative(IntPtr.Add(intPtr, SetGlobalReverbPreset_InPreset_Offset), 0, SetGlobalReverbPreset_InPreset_PropertyAddress.Address, InPreset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetGlobalReverbPreset_FunctionAddress, intPtr, SetGlobalReverbPreset_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary:GetGlobalReverbPreset")]
	public unsafe static UResonanceAudioReverbPluginPreset GetGlobalReverbPreset()
	{
		if (!GetGlobalReverbPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary:GetGlobalReverbPreset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalReverbPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalReverbPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGlobalReverbPreset_FunctionAddress, intPtr, GetGlobalReverbPreset_ParamsSize);
		return UObjectMarshaler<UResonanceAudioReverbPluginPreset>.FromNative(IntPtr.Add(intPtr, GetGlobalReverbPreset_ReturnValue_Offset), 0, GetGlobalReverbPreset_ReturnValue_PropertyAddress.Address);
	}

	static UResonanceAudioBlueprintFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UResonanceAudioBlueprintFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UResonanceAudioBlueprintFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary");
		SetGlobalReverbPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGlobalReverbPreset");
		SetGlobalReverbPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGlobalReverbPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalReverbPreset_InPreset_PropertyAddress, SetGlobalReverbPreset_FunctionAddress, "InPreset");
		SetGlobalReverbPreset_InPreset_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalReverbPreset_FunctionAddress, "InPreset");
		SetGlobalReverbPreset_InPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalReverbPreset_FunctionAddress, "InPreset", Classes.FObjectProperty);
		SetGlobalReverbPreset_IsValid = SetGlobalReverbPreset_FunctionAddress != IntPtr.Zero && SetGlobalReverbPreset_InPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary:SetGlobalReverbPreset", SetGlobalReverbPreset_IsValid);
		GetGlobalReverbPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalReverbPreset");
		GetGlobalReverbPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalReverbPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalReverbPreset_ReturnValue_PropertyAddress, GetGlobalReverbPreset_FunctionAddress, "ReturnValue");
		GetGlobalReverbPreset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalReverbPreset_FunctionAddress, "ReturnValue");
		GetGlobalReverbPreset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalReverbPreset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGlobalReverbPreset_IsValid = GetGlobalReverbPreset_FunctionAddress != IntPtr.Zero && GetGlobalReverbPreset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ResonanceAudio.ResonanceAudioBlueprintFunctionLibrary:GetGlobalReverbPreset", GetGlobalReverbPreset_IsValid);
	}
}
