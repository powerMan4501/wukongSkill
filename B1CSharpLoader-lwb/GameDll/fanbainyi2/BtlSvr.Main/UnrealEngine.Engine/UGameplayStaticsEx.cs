using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public class UGameplayStaticsEx
{
	public static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldCtx, UParticleSystem EmitterTemplate, ref FTransform Transform)
	{
		return UGameplayStatics.SpawnEmitterAtLocation(WorldCtx, EmitterTemplate, Transform.GetLocation(), Transform.GetRotation().Rotator(), Transform.GetScale3D(), bAutoDestroy: true, EPSCPoolMethod.None, bAutoActivateSystem: true);
	}

	public static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate, USceneComponent AttachToComponent, FName AttachName, ref FTransform Transform, EAttachLocation LocationType)
	{
		return UGameplayStatics.SpawnEmitterAttached(EmitterTemplate, AttachToComponent, AttachName, Transform.GetLocation(), Transform.GetRotation().Rotator(), Transform.GetScale3D(), LocationType, bAutoDestroy: true, EPSCPoolMethod.None, bAutoActivate: true);
	}
}
