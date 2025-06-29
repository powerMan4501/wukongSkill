using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ContinueBehaviorType")]
public enum EContinueBehaviorType : byte
{
	None,
	Skill,
	Beatback,
	AnimationSyncing
}
