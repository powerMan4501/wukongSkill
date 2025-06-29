using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

public class SpawnedTamerStrategy : TamerStrategyBase
{
	public override void OnAfterAnimTick(float DeltaTime)
	{
		foreach (ETamerPhase key in base.TamersSortByPhase.Keys)
		{
			if (TamerStrategyBase.CurrentFrameHandleCount >= 1)
			{
				break;
			}
			bool flag = false;
			if ((uint)(key - 2) <= 1u || key == ETamerPhase.PreBegunPlay)
			{
				flag = true;
			}
			if (key == ETamerPhase.Spawned || key == ETamerPhase.Dead)
			{
				foreach (FTamerRef item in base.TamersSortByPhase[key].ToList())
				{
					if (item.IsMonsterDestroyed())
					{
						base.NeedUnregisterTamers.Add(item);
					}
				}
			}
			if (!flag)
			{
				continue;
			}
			using List<FTamerRef>.Enumerator enumerator2 = base.TamersSortByPhase[key].ToList().GetEnumerator();
			if (enumerator2.MoveNext())
			{
				enumerator2.Current.IncrementalSpawnUnit(base.Owner);
				TamerStrategyBase.CurrentFrameHandleCount++;
			}
		}
		if (base.LogTime >= base.LogIntervalSecond)
		{
			foreach (ETamerPhase key2 in base.TamersSortByPhase.Keys)
			{
				foreach (FTamerRef item2 in base.TamersSortByPhase[key2])
				{
					if (item2.Phase != ETamerPhase.UnLoaded)
					{
						FLinearColor color = FLinearColor.White;
						switch (item2.Phase)
						{
						case ETamerPhase.Loaded:
							color = FLinearColor.Gray;
							break;
						case ETamerPhase.Visible:
							color = FLinearColor.Yellow;
							break;
						case ETamerPhase.PreBegunPlay:
							color = FLinearColor.YellowGreen;
							break;
						case ETamerPhase.Spawned:
							color = FLinearColor.Green;
							break;
						case ETamerPhase.Dead:
							color = FLinearColor.Red;
							break;
						}
						item2.DrawDebugString($"Summon {item2.TamerGuid}：\n Phase:{item2.Phase}", base.LogIntervalSecond, color);
					}
				}
			}
			base.LogTime = 0f;
		}
		else
		{
			base.LogTime += DeltaTime;
		}
	}
}
