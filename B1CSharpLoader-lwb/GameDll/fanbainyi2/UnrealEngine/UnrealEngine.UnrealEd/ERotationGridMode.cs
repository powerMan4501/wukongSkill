using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ERotationGridMode", "UnrealEd", UnrealModuleType.Engine)]
public enum ERotationGridMode
{
	GridMode_DivisionsOf360,
	GridMode_Common
}
