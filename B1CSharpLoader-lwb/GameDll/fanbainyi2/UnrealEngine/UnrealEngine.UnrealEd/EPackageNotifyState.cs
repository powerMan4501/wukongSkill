using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPackageNotifyState", "UnrealEd", UnrealModuleType.Engine)]
public enum EPackageNotifyState
{
	NS_Updating,
	NS_BalloonPrompted,
	NS_DialogPrompted,
	NS_PendingPrompt,
	NS_PendingWarning
}
