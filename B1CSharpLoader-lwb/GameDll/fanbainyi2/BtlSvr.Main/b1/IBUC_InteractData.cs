using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_InteractData
{
	int InteractiveUnitID { get; }

	int RewardDropID { get; }

	int DefalutInteractiveGroupID { get; }

	Entity TriggerInteractPlayerEntity { get; }

	EBGUInteractUnitState InteractUnitState { get; }

	EInteractUIState InteractUIState { get; }

	FVector IconSockVector { get; }

	bool bSpecialIcon { get; }

	bool bMuteSubtitle { get; }

	float CD { get; }

	Dictionary<string, TWeakObject<UCameraComponent>> CameraComps { get; }

	EInteractConstraint InteractConstraint { get; }

	int ActionGroupID { get; }

	int InteractCounter { get; }

	int ShopID { get; }

	string InteractTipOverride { get; }

	float InteractinputTime { get; }

	bool bIsNPC { get; }

	int AiConversationNeedToPlay { get; }

	bool bIsInteracting { get; }

	List<FUStInteractionMappingDesc> ActionList { get; }

	FUStInteractiveUnitCommDesc InteractiveUnitCommDesc { get; }

	List<int> InteractFuncList { get; }

	float RemainingInteractTime { get; }

	float BlendOutTimer { get; }
}
