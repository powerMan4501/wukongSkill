using System.Collections.Generic;

namespace b1;

public static class ExtendDic
{
	public static FSpawnActorInfo FindByActorGuid(this List<FSpawnActorInfo> List, string InActorGuid)
	{
		foreach (FSpawnActorInfo item in List)
		{
			if (item.ActorGuid == InActorGuid)
			{
				return item;
			}
		}
		return null;
	}
}
