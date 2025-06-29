using System.Collections.Generic;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810565793u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.ActorSoundParameterInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(IActorSoundParameterInterfaceImpl))]
public interface IActorSoundParameterInterface : IInterface
{
	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Engine.ActorSoundParameterInterface:GetActorSoundParams")]
	void GetActorSoundParams(out List<FAudioParameter> Params);
}
