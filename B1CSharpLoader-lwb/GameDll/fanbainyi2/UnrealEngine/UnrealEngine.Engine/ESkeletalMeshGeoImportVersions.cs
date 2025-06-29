using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESkeletalMeshGeoImportVersions", "Engine", UnrealModuleType.Engine)]
public enum ESkeletalMeshGeoImportVersions
{
	Before_Versionning = 0,
	SkeletalMeshBuildRefactor = 1,
	VersionPlusOne = 2,
	LatestVersion = 1
}
