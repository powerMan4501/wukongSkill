using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TaskCollectionState")]
public enum ETaskCollectionState : byte
{
	Default,
	Activated,
	Finished
}
