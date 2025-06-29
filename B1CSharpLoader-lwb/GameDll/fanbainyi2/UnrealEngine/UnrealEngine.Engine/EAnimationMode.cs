using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAnimationMode", "Engine", UnrealModuleType.Engine)]
public enum EAnimationMode
{
	AnimationBlueprint,
	AnimationSingleNode,
	AnimationCustomMode
}
