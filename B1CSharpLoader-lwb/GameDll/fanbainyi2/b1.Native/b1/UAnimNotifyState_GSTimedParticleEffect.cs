using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809578656uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotifyState_GSTimedParticleEffect", "b1", UnrealModuleType.Game)]
public class UAnimNotifyState_GSTimedParticleEffect : UAnimNotifyState_TimedParticleEffect
{
	private static bool InstanceParameters_IsValid;

	private static FFieldAddress InstanceParameters_PropertyAddress;

	private static int InstanceParameters_Offset;

	private TArrayReadOnlyMarshaler<FParticleSysParam> InstanceParameters_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSTimedParticleEffect:InstanceParameters")]
	public TArrayReadOnly<FParticleSysParam> InstanceParameters
	{
		get
		{
			CheckDestroyed();
			if (!InstanceParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSTimedParticleEffect:InstanceParameters");
				return null;
			}
			if (InstanceParameters_MarshalerCached == null)
			{
				InstanceParameters_MarshalerCached = new TArrayReadOnlyMarshaler<FParticleSysParam>(1, InstanceParameters_PropertyAddress, CachedMarshalingDelegates<FParticleSysParam, FParticleSysParam>.FromNative, CachedMarshalingDelegates<FParticleSysParam, FParticleSysParam>.ToNative);
			}
			return InstanceParameters_MarshalerCached.FromNative(IntPtr.Add(base.Address, InstanceParameters_Offset));
		}
	}

	static UAnimNotifyState_GSTimedParticleEffect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_GSTimedParticleEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_GSTimedParticleEffect));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.AnimNotifyState_GSTimedParticleEffect");
		NativeReflectionCached.GetPropertyRef(ref InstanceParameters_PropertyAddress, unrealStruct, "InstanceParameters");
		InstanceParameters_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InstanceParameters");
		InstanceParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InstanceParameters", Classes.FArrayProperty);
	}
}
