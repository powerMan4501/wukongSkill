using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public static class BGUSkillPreviewHelper
{
	public static Dictionary<int, List<UnitZBBInfo>> ZBBSectorCollector(List<UnitZBBInfo> ZBBInfo)
	{
		Dictionary<int, List<UnitZBBInfo>> dictionary = new Dictionary<int, List<UnitZBBInfo>>();
		for (int i = 0; i < ZBBInfo.Count; i++)
		{
			FVector position = ZBBInfo[i].Position;
			int num = (int)(FMath.Acos(position.X / FMath.Sqrt(position.X * position.X + position.Y * position.Y)) * 180f / (float)Math.PI) / 45;
			if (ZBBInfo[i].Position.Y < 0f)
			{
				num = 7 - num;
			}
			if (!dictionary.ContainsKey(num))
			{
				List<UnitZBBInfo> value = new List<UnitZBBInfo>();
				dictionary.Add(num, value);
			}
			UnitZBBInfo unitZBBInfo = default(UnitZBBInfo);
			unitZBBInfo = ZBBInfo[i];
			dictionary[num].Add(unitZBBInfo);
		}
		return dictionary;
	}
}
