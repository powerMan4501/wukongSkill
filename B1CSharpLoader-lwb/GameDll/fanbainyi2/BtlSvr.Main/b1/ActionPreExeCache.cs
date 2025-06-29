using System.Collections.Generic;
using BtlShare;

namespace b1;

public class ActionPreExeCache
{
	public List<AISkillInfo> SkillInfoList;

	public FUStAIActionFilter FilterDesc;

	public ActionPreExeCache()
	{
		SkillInfoList = new List<AISkillInfo>();
	}

	public void Clear()
	{
		SkillInfoList.Clear();
		FilterDesc = null;
	}
}
