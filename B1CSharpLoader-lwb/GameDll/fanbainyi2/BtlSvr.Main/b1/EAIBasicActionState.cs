using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EAIBasicActionState")]
public enum EAIBasicActionState : byte
{
	None,
	Executing,
	Finish,
	ErrorRequestType,
	SkillNotFound,
	RequestNoFound,
	WaitingAbort,
	Aborted
}
