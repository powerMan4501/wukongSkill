using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundMix", "Engine", UnrealModuleType.Engine)]
public class USoundMix : UObject
{
	private static bool SoundClassEffects_IsValid;

	private static FFieldAddress SoundClassEffects_PropertyAddress;

	private static int SoundClassEffects_Offset;

	private TArrayReadOnlyMarshaler<FSoundClassAdjuster> SoundClassEffects_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.SoundMix:SoundClassEffects")]
	public TArrayReadOnly<FSoundClassAdjuster> SoundClassEffects
	{
		get
		{
			CheckDestroyed();
			if (!SoundClassEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundMix:SoundClassEffects");
				return null;
			}
			if (SoundClassEffects_MarshalerCached == null)
			{
				SoundClassEffects_MarshalerCached = new TArrayReadOnlyMarshaler<FSoundClassAdjuster>(1, SoundClassEffects_PropertyAddress, CachedMarshalingDelegates<FSoundClassAdjuster, FSoundClassAdjuster>.FromNative, CachedMarshalingDelegates<FSoundClassAdjuster, FSoundClassAdjuster>.ToNative);
			}
			return SoundClassEffects_MarshalerCached.FromNative(IntPtr.Add(base.Address, SoundClassEffects_Offset));
		}
	}

	static USoundMix()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundMix)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundMix));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundMix");
		NativeReflectionCached.GetPropertyRef(ref SoundClassEffects_PropertyAddress, unrealStruct, "SoundClassEffects");
		SoundClassEffects_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SoundClassEffects");
		SoundClassEffects_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SoundClassEffects", Classes.FArrayProperty);
	}
}
