namespace UnrealEngine.Runtime;

[UEnum]
[UMetaPath("/Script/GameplayTags.EGameplayTagSourceType", "GameplayTags", UnrealModuleType.Engine)]
public enum EGameplayTagSourceType
{
	Native,
	DefaultTagList,
	TagList,
	RestrictedTagList,
	DataTable,
	Invalid
}
