using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPlayOnPakFileMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EPlayOnPakFileMode
{
	NoPak,
	PakNoCompress,
	PakCompress
}
