using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EAIAttentionFeatureType")]
public enum EAIAttentionFeatureType : byte
{
	None,
	NearestEnemy,
	SkillArea,
	StandInSkillArea,
	SkillCastRange,
	AttackableEnemy
}
