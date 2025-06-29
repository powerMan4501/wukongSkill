using CommB1;

namespace b1;

public static class PlayerCollectionHelper
{
	public static bool IsFirstSight(ReadOnlyRoleDataCS roleDataCS, int unitId, int overrideId = 0)
	{
		int cardIdByCardIndex = GameDBRuntime.GetCardIdByCardIndex(unitId, overrideId);
		if (cardIdByCardIndex == 0)
		{
			BGW_LogUtil.LogError($"GetCardIdByCardIndex Failed unitId:{unitId} overrideId:{overrideId}");
			return false;
		}
		foreach (ReadOnlyMonsterCollection monsterCollection in roleDataCS.Collection.MonsterCollectionList)
		{
			if (cardIdByCardIndex == monsterCollection.Id)
			{
				return false;
			}
		}
		return true;
	}
}
