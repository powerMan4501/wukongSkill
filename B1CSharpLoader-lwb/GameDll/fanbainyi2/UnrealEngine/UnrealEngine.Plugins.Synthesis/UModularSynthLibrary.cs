using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Synthesis.ModularSynthLibrary", "Synthesis", UnrealModuleType.EnginePlugin)]
public class UModularSynthLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool AddModularSynthPresetToBankAsset_IsValid;

	private static IntPtr AddModularSynthPresetToBankAsset_FunctionAddress;

	private static int AddModularSynthPresetToBankAsset_ParamsSize;

	private static bool AddModularSynthPresetToBankAsset_InBank_IsValid;

	private static FFieldAddress AddModularSynthPresetToBankAsset_InBank_PropertyAddress;

	private static int AddModularSynthPresetToBankAsset_InBank_Offset;

	private static bool AddModularSynthPresetToBankAsset_Preset_IsValid;

	private static FFieldAddress AddModularSynthPresetToBankAsset_Preset_PropertyAddress;

	private static int AddModularSynthPresetToBankAsset_Preset_Offset;

	private static bool AddModularSynthPresetToBankAsset_PresetName_IsValid;

	private static FFieldAddress AddModularSynthPresetToBankAsset_PresetName_PropertyAddress;

	private static int AddModularSynthPresetToBankAsset_PresetName_Offset;

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/Synthesis.ModularSynthLibrary:AddModularSynthPresetToBankAsset")]
	public unsafe static void AddModularSynthPresetToBankAsset(UModularSynthPresetBank InBank, FModularSynthPreset Preset, string PresetName)
	{
		if (!AddModularSynthPresetToBankAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthLibrary:AddModularSynthPresetToBankAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddModularSynthPresetToBankAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddModularSynthPresetToBankAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UModularSynthPresetBank>.ToNative(IntPtr.Add(intPtr, AddModularSynthPresetToBankAsset_InBank_Offset), 0, AddModularSynthPresetToBankAsset_InBank_PropertyAddress.Address, InBank);
		NativeReflection.InitializeValue_InContainer(AddModularSynthPresetToBankAsset_Preset_PropertyAddress.Address, intPtr);
		FModularSynthPreset.ToNative(IntPtr.Add(intPtr, AddModularSynthPresetToBankAsset_Preset_Offset), 0, AddModularSynthPresetToBankAsset_Preset_PropertyAddress.Address, Preset);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddModularSynthPresetToBankAsset_PresetName_Offset), 0, AddModularSynthPresetToBankAsset_PresetName_PropertyAddress.Address, PresetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddModularSynthPresetToBankAsset_FunctionAddress, intPtr, AddModularSynthPresetToBankAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddModularSynthPresetToBankAsset_Preset_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddModularSynthPresetToBankAsset_PresetName_PropertyAddress.Address, intPtr);
	}

	static UModularSynthLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UModularSynthLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UModularSynthLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Synthesis.ModularSynthLibrary");
		AddModularSynthPresetToBankAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddModularSynthPresetToBankAsset");
		AddModularSynthPresetToBankAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddModularSynthPresetToBankAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddModularSynthPresetToBankAsset_InBank_PropertyAddress, AddModularSynthPresetToBankAsset_FunctionAddress, "InBank");
		AddModularSynthPresetToBankAsset_InBank_Offset = NativeReflectionCached.GetPropertyOffset(AddModularSynthPresetToBankAsset_FunctionAddress, "InBank");
		AddModularSynthPresetToBankAsset_InBank_IsValid = NativeReflectionCached.ValidatePropertyClass(AddModularSynthPresetToBankAsset_FunctionAddress, "InBank", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddModularSynthPresetToBankAsset_Preset_PropertyAddress, AddModularSynthPresetToBankAsset_FunctionAddress, "Preset");
		AddModularSynthPresetToBankAsset_Preset_Offset = NativeReflectionCached.GetPropertyOffset(AddModularSynthPresetToBankAsset_FunctionAddress, "Preset");
		AddModularSynthPresetToBankAsset_Preset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddModularSynthPresetToBankAsset_FunctionAddress, "Preset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddModularSynthPresetToBankAsset_PresetName_PropertyAddress, AddModularSynthPresetToBankAsset_FunctionAddress, "PresetName");
		AddModularSynthPresetToBankAsset_PresetName_Offset = NativeReflectionCached.GetPropertyOffset(AddModularSynthPresetToBankAsset_FunctionAddress, "PresetName");
		AddModularSynthPresetToBankAsset_PresetName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddModularSynthPresetToBankAsset_FunctionAddress, "PresetName", Classes.FStrProperty);
		AddModularSynthPresetToBankAsset_IsValid = AddModularSynthPresetToBankAsset_FunctionAddress != IntPtr.Zero && AddModularSynthPresetToBankAsset_InBank_IsValid && AddModularSynthPresetToBankAsset_Preset_IsValid && AddModularSynthPresetToBankAsset_PresetName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthLibrary:AddModularSynthPresetToBankAsset", AddModularSynthPresetToBankAsset_IsValid);
	}
}
