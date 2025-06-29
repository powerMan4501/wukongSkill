using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EReloadPackagesInteractionMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EReloadPackagesInteractionMode
{
	Interactive,
	AssumePositive,
	AssumeNegative
}
