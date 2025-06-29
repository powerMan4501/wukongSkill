using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.GroupPatrolType")]
public enum EGroupPatrolType : byte
{
	None,
	Leader,
	Member
}
