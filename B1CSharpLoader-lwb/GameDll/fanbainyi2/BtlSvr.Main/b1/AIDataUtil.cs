using System;

namespace b1;

public static class AIDataUtil
{
	public static void FOR_GET_VALID_SKILL_ID<T>(int UniResID, T p1, Action<T, int> method)
	{
		int i = UniResID * 100 + 1;
		for (int num = UniResID * 100 + 99; i <= num; i++)
		{
			if (BGW_GameDB.GetSkillAIDesc(i) != null)
			{
				method(p1, i);
			}
		}
	}
}
