using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Synthesis.ModularSynthPresetBank", "Synthesis", UnrealModuleType.EnginePlugin)]
public class UModularSynthPresetBank : UObject
{
	private static bool Presets_IsValid;

	private static FFieldAddress Presets_PropertyAddress;

	private static int Presets_Offset;

	private TArrayReadWriteMarshaler<FModularSynthPresetBankEntry> Presets_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPresetBank:Presets")]
	public TArrayReadWrite<FModularSynthPresetBankEntry> Presets
	{
		get
		{
			CheckDestroyed();
			if (!Presets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.ModularSynthPresetBank:Presets");
				return null;
			}
			if (Presets_MarshalerCached == null)
			{
				Presets_MarshalerCached = new TArrayReadWriteMarshaler<FModularSynthPresetBankEntry>(1, Presets_PropertyAddress, CachedMarshalingDelegates<FModularSynthPresetBankEntry, FModularSynthPresetBankEntry>.FromNative, CachedMarshalingDelegates<FModularSynthPresetBankEntry, FModularSynthPresetBankEntry>.ToNative);
			}
			return Presets_MarshalerCached.FromNative(IntPtr.Add(base.Address, Presets_Offset));
		}
	}

	static UModularSynthPresetBank()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UModularSynthPresetBank)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UModularSynthPresetBank));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Synthesis.ModularSynthPresetBank");
		NativeReflectionCached.GetPropertyRef(ref Presets_PropertyAddress, unrealStruct, "Presets");
		Presets_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Presets");
		Presets_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Presets", Classes.FArrayProperty);
	}
}
