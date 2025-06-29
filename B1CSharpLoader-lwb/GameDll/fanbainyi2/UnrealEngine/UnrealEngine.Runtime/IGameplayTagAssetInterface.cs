namespace UnrealEngine.Runtime;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface", "GameplayTags", UnrealModuleType.Engine, InterfaceImpl = typeof(IGameplayTagAssetInterfaceImpl))]
public interface IGameplayTagAssetInterface : IInterface
{
	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:HasMatchingGameplayTag")]
	bool HasMatchingGameplayTag(FGameplayTag TagToCheck);

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:HasAnyMatchingGameplayTags")]
	bool HasAnyMatchingGameplayTags(FGameplayTagContainer TagContainer);

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:HasAllMatchingGameplayTags")]
	bool HasAllMatchingGameplayTags(FGameplayTagContainer TagContainer);

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/GameplayTags.GameplayTagAssetInterface:GetOwnedGameplayTags")]
	void GetOwnedGameplayTags(out FGameplayTagContainer TagContainer);
}
