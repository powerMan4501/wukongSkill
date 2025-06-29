using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EQuartzCommandDelegateSubType", "Engine", UnrealModuleType.Engine)]
public enum EQuartzCommandDelegateSubType : byte
{
	CommandOnFailedToQueue,
	CommandOnQueued,
	CommandOnCanceled,
	CommandOnAboutToStart,
	CommandOnStarted,
	Count
}
