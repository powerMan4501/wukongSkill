using System.Collections.Generic;

namespace b1;

public interface IBUC_HeroSwitchData
{
	EPartnerAssistState CurPartnerAssistState { get; }

	EntitySharedRefList PartnerRefList { get; }

	EntitySharedRef LeaderRef { get; }

	List<int> PartnerBuff { get; }

	bool IsAllPartnerDied();
}
