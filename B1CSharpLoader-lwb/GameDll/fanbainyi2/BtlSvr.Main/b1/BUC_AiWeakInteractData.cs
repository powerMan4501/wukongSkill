using UnrealEngine.Runtime;

namespace b1;

internal class BUC_AiWeakInteractData : b1.IBUC_AiWeakInteractData
{
	public bool TaskConditionSuccess;

	public EAiWeakInteractCheckType AiWeakInteractCheckType { get; set; }

	public int InteractTriggerRadius { get; set; }

	public int InteractTriggerAngle { get; set; }

	public int AiConversationID { get; set; }

	public FVector OwnerLocation { get; set; }

	public bool EnableTaskStageCondition { get; set; }

	public int TaskStageID { get; set; }

	public EStageStatus TaskStageStatus { get; set; }
}
