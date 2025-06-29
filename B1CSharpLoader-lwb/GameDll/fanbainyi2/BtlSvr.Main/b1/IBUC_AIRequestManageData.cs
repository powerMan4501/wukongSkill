using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_AIRequestManageData
{
	AIRequestBase GetActiveAIRequest();

	AIRequestBase GetCachedAIRequest();

	EAIBasicActionState GetLastActionState();

	List<TStrongObjectPtr<AIRequestBase>> GetAIRequestList();
}
