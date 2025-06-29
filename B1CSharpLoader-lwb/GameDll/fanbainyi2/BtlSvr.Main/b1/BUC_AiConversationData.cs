using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1;

public class BUC_AiConversationData : IPersistentECSData
{
	public string OwnerGUID;

	public List<int> AIConversationEvntIDList;

	public bool InterruptAiConversationWhenIntoBattle;

	public Dictionary<EAiConversationEventType, List<int>> AiConversationMap;

	public FAC_OverDistanceInterruption OverDistanceInterruption;

	public FAC_ListenerStateCheckInterruption ListenerStateCheckData;

	public BUC_AiConversationData()
	{
		AIConversationEvntIDList = new List<int>();
		AiConversationMap = new Dictionary<EAiConversationEventType, List<int>>();
	}
}
