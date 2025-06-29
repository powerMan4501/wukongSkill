using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETransitionType", "Engine", UnrealModuleType.Engine)]
public enum ETransitionType
{
	None,
	Paused,
	Loading,
	Saving,
	Connecting,
	Precaching,
	WaitingToConnect
}
