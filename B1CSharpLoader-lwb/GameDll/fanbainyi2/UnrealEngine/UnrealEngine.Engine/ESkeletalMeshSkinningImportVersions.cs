using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESkeletalMeshSkinningImportVersions", "Engine", UnrealModuleType.Engine)]
public enum ESkeletalMeshSkinningImportVersions
{
	Before_Versionning = 0,
	SkeletalMeshBuildRefactor = 1,
	VersionPlusOne = 2,
	LatestVersion = 1
}
