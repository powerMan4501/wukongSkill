using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_GOAPData
{
	List<AISkillInfo> GetValidSkillInfoList();

	List<AIActionElem> GetExecutableActionElemList();

	List<AIActionElem> GetExecutingActionElemList();

	List<AIFeatureElem> GetValidFeatureElemList();

	List<AIElement> GetAllRootElemList();

	List<AIActionElem> GetAllUpdateActionList();

	List<TStrongObjectPtr<AFSkillArea>> GetSkillAreaFeatureList();

	List<ActionProcessBase> GetActionProcessList();
}
