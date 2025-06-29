using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.TalentState")]
public enum TalentState : byte
{
	NotLearn,
	HasLearn,
	MaxLearn
}
