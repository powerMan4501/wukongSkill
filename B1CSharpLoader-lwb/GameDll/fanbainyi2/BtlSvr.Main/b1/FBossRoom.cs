using System.Collections.Generic;

namespace b1;

public class FBossRoom
{
	public Dictionary<string, bool> BossBattleState { get; } = new Dictionary<string, bool>();

	public bool IsInBossRoom(string Monster)
	{
		return BossBattleState.ContainsKey(Monster);
	}

	public bool IsAllLeaveBattle()
	{
		bool result = true;
		foreach (KeyValuePair<string, bool> item in BossBattleState)
		{
			if (item.Value)
			{
				result = false;
				break;
			}
		}
		return result;
	}
}
