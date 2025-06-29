using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AIRequestManageData : IBUC_AIRequestManageData
{
	public List<TStrongObjectPtr<AIRequestBase>> AIRequestList = new List<TStrongObjectPtr<AIRequestBase>>();

	public List<TStrongObjectPtr<AIRequestBase>> CachedRequestList = new List<TStrongObjectPtr<AIRequestBase>>();

	public EAIBasicActionState LastActionState { get; set; }

	public void Init()
	{
	}

	public AIRequestBase GetCachedAIRequest()
	{
		if (CachedRequestList.Count > 0)
		{
			return CachedRequestList[0].Get();
		}
		return null;
	}

	public AIRequestBase GetActiveAIRequest()
	{
		if (AIRequestList.Count > 0)
		{
			return AIRequestList[0].Get();
		}
		return null;
	}

	public EAIBasicActionState GetLastActionState()
	{
		return LastActionState;
	}

	public List<TStrongObjectPtr<AIRequestBase>> GetAIRequestList()
	{
		return AIRequestList;
	}

	public void SetLastActionState(EAIBasicActionState ActionState)
	{
		LastActionState = ActionState;
	}
}
