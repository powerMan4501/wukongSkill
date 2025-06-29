namespace UnrealEngine.Runtime;

[UEnum]
[UMetaPath("/Script/GameplayTags.EGameplayTagQueryExprType", "GameplayTags", UnrealModuleType.Engine)]
public enum EGameplayTagQueryExprType
{
	Undefined,
	AnyTagsMatch,
	AllTagsMatch,
	NoTagsMatch,
	AnyExprMatch,
	AllExprMatch,
	NoExprMatch
}
