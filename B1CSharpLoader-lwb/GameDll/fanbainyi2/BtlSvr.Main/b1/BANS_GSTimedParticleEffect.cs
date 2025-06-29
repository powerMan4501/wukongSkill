using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Timed Particle Effect")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSTimedParticleEffect")]
internal class BANS_GSTimedParticleEffect : UAnimNotifyState_GSTimedParticleEffect
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTimedParticleEffect");
	}

	static BANS_GSTimedParticleEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSTimedParticleEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSTimedParticleEffect));
	}
}
