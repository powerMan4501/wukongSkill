using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.PostProcessSource")]
public enum EPostProcessSource : byte
{
	None,
	Buff,
	AnimNotify,
	ReservedAfterReset,
	IntervalTrigger
}
