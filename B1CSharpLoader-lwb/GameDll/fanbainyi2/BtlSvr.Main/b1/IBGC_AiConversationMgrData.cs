namespace b1;

public interface IBGC_AiConversationMgrData
{
	BGUNarrator GetNarrator();

	bool bIsAiConversationChainEnd(uint ChainRootID);

	bool bIsAiConversationChainEnd_CPG(uint ChainRootID);

	uint GetLast_ChainRootID();

	uint GetLast_AiConversationReqID();

	bool GetLast_bPocessSuccess();

	bool bHasAiConversationPlaying();

	int GetLast_AiConversationDescID();
}
