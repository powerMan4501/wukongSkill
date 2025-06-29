using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CameraLensEffectInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ICameraLensEffectInterfaceImpl))]
public interface ICameraLensEffectInterface : IInterface
{
	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterface:GetPrimaryParticleComponent")]
	UFXSystemComponent GetPrimaryParticleComponent();

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterface:GetParticleComponents")]
	List<UFXSystemComponent> GetParticleComponents();
}
