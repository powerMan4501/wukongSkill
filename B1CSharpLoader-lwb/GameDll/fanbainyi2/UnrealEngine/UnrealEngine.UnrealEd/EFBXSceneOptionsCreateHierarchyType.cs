using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.EFBXSceneOptionsCreateHierarchyType", "UnrealEd", UnrealModuleType.Engine)]
public enum EFBXSceneOptionsCreateHierarchyType : byte
{
	FBXSOCHT_CreateLevelActors,
	FBXSOCHT_CreateActorComponents,
	FBXSOCHT_CreateBlueprint
}
