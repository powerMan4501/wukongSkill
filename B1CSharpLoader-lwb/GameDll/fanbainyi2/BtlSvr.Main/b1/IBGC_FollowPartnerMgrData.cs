using System.Collections.Generic;
using b1.ECS;

namespace b1;

public interface IBGC_FollowPartnerMgrData
{
	string FollowPartnerGUID { get; }

	int CurrentUseFollowPartnerConfigID { get; }

	float WeakAiInteractConversationTimer { get; }

	BGWDataAsset_FollowPartnerDisplayConfig FollowPartnerDisplayConfig { get; }

	List<string> WeakAiInteractGUIDList { get; }

	bool SeqHiddenFlag { get; }

	void GetLastEnterInteractArea(out Entity InteractEntity, out int Step);

	int GetInteractAreaStep(Entity InteractEntity);
}
