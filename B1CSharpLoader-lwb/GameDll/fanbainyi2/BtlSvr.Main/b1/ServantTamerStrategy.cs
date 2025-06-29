using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

public class ServantTamerStrategy : TamerStrategyBase
{
	protected override void PostAddTamer(FTamerRef InTamer)
	{
		if (InTamer.ServantInstance != null)
		{
			InTamer.ServantInstance.ActualPhase = EServantPhase.Tamer;
			InTamer.ServantInstance.Owner = base.Owner;
		}
	}

	protected override void PostTamerPhaseChanged(FTamerRef InTamer, ETamerPhase OldPhase, ETamerPhase NewPhase)
	{
		FServantInstanceBase servantInstance = InTamer.ServantInstance;
		if (servantInstance == null)
		{
			return;
		}
		if (servantInstance.ActualPhase < EServantPhase.Unit)
		{
			switch (NewPhase)
			{
			case ETamerPhase.Loaded:
				servantInstance.ActualPhase = EServantPhase.Tamer;
				break;
			case ETamerPhase.Visible:
				servantInstance.ActualPhase = EServantPhase.BeginSpawnActor;
				break;
			case ETamerPhase.PreBegunPlay:
				servantInstance.ActualPhase = EServantPhase.ECSPreBeginPlayFinished;
				break;
			case ETamerPhase.Spawned:
				servantInstance.ActualPhase = EServantPhase.Unit;
				break;
			case ETamerPhase.ServerWaitingAuthorityECSBeginPlay:
			case ETamerPhase.ClientWaitingChannelAndAuthRoleReady:
				break;
			}
		}
		else if (NewPhase == ETamerPhase.Dead)
		{
			servantInstance.ActualPhase = EServantPhase.Destroyed;
		}
	}

	public override void OnAfterAnimTick(float DeltaTime)
	{
		foreach (ETamerPhase key in base.TamersSortByPhase.Keys)
		{
			if (TamerStrategyBase.CurrentFrameHandleCount >= 1)
			{
				break;
			}
			foreach (FTamerRef item in base.TamersSortByPhase[key].ToList())
			{
				FServantInstanceBase servantInstance = item.ServantInstance;
				if (servantInstance == null)
				{
					continue;
				}
				servantInstance.NotifyTickPhase(DeltaTime);
				switch (servantInstance.ActualPhase)
				{
				case EServantPhase.Tamer:
				case EServantPhase.BeginSpawnActor:
				case EServantPhase.ECSPreBeginPlayFinished:
					if (servantInstance.ExpectPhase > servantInstance.ActualPhase)
					{
						item.IncrementalSpawnUnit(base.Owner);
						TamerStrategyBase.CurrentFrameHandleCount++;
					}
					break;
				case EServantPhase.Unit:
					if (servantInstance.ExpectPhase == EServantPhase.LifeOver)
					{
						item.TriggerServantDead();
						servantInstance.ActualPhase = EServantPhase.LifeOver;
					}
					break;
				case EServantPhase.Destroyed:
					base.NeedUnregisterTamers.Add(item);
					break;
				}
				if (TamerStrategyBase.CurrentFrameHandleCount >= 1)
				{
					break;
				}
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
