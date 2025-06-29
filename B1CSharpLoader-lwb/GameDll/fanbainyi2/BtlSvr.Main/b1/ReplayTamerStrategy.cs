using UnrealEngine.Runtime;

namespace b1;

public class ReplayTamerStrategy : TamerStrategyBase
{
	public override void OnAfterAnimTick(float DeltaTime)
	{
		foreach (ETamerPhase key in base.TamersSortByPhase.Keys)
		{
			_ = key;
			if (TamerStrategyBase.CurrentFrameHandleCount >= 1)
			{
				break;
			}
		}
		if (base.LogTime >= base.LogIntervalSecond)
		{
			foreach (ETamerPhase key2 in base.TamersSortByPhase.Keys)
			{
				foreach (FTamerRef item in base.TamersSortByPhase[key2])
				{
					if (item.Phase != ETamerPhase.UnLoaded)
					{
						FLinearColor color = FLinearColor.White;
						switch (item.Phase)
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
						item.DrawDebugString($"Summon {item.TamerGuid}：\n Phase:{item.Phase}", base.LogIntervalSecond, color);
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
