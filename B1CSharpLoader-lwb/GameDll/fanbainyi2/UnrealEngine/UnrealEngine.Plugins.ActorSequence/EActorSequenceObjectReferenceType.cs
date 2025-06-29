using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ActorSequence;

[UEnum]
[UMetaPath("/Script/ActorSequence.EActorSequenceObjectReferenceType", "ActorSequence", UnrealModuleType.EnginePlugin)]
public enum EActorSequenceObjectReferenceType
{
	ContextActor,
	ExternalActor,
	Component
}
