using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Party;

[UEnum]
[UMetaPath("/Script/Party.EApprovalAction", "Party", UnrealModuleType.EnginePlugin)]
public enum EApprovalAction
{
	Approve,
	Enqueue,
	EnqueueAndStartBeacon,
	Deny
}
