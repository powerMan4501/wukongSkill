using System.Collections.Generic;
using BtlShare;

namespace b1;

public interface IBUC_AIAttentionData
{
	AttentionFeatureBase GetFeatureByType(EAIAttentionFeatureType FeatureType);

	Dictionary<int, List<BaseActionMsg>> GetValidSkillBADic();

	FCurThinkInfo GetCurThinkInfo();

	List<AFSkillArea> GetSkillAreaFeatureList();

	Dictionary<EAIBasicActionType, EAIRequestType> GetBA2ReqDic();
}
