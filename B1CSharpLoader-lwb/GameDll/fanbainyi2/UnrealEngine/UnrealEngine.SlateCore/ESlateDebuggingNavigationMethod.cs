using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.ESlateDebuggingNavigationMethod", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateDebuggingNavigationMethod
{
	Unknown,
	Explicit,
	CustomDelegateBound,
	CustomDelegateUnbound,
	NextOrPrevious,
	HitTestGrid
}
