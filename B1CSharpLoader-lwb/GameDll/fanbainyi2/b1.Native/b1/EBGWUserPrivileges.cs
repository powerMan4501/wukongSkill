using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWUserPrivileges", "b1", UnrealModuleType.Game)]
public enum EBGWUserPrivileges : byte
{
	CanPlay,
	CanPlayOnline,
	CanCommunicateOnline,
	CanUseUserGeneratedContent,
	CanUserCrossPlay
}
