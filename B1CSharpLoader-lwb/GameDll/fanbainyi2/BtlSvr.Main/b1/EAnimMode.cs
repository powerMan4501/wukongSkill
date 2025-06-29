using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AnimMode")]
public enum EAnimMode : byte
{
	DefaultAnim,
	PatrolAnim,
	EQSRunAnim,
	ShieldAnim,
	PowerStorageAnim
}
