using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.FsmSolverType")]
public enum EFsmSolverType : byte
{
	Normal,
	FriendlyBattleNpc,
	AssistantPartner,
	GroupAi,
	SummonAi,
	NeutralAnimalBattle,
	NeutralAnimalEscape
}
