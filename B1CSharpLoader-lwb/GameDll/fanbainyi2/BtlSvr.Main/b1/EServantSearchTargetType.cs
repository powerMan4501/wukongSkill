using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ServantSearchTargetType")]
public enum EServantSearchTargetType : byte
{
	None,
	CatchPlayer,
	SyncMaster,
	ByPerception,
	SyncSummoner
}
