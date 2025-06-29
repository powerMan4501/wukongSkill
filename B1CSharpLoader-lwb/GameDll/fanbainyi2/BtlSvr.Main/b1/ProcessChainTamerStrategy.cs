using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class ProcessChainTamerStrategy : TamerStrategyBase
{
	public const uint FrameMod = 100000u;

	private FTamerProcessorContext Context;

	private FTamerProcessorBase HeadProcessor { get; set; }

	private FTamerProcessorBase CalcDistanceProcessor { get; set; }

	protected override void PostInitial()
	{
		HeadProcessor = FTamerProcessorFactory.GetInstance(EProcessorSequence.Head);
		HeadProcessor.Initial();
		CalcDistanceProcessor = FTamerProcessorFactory.GetInstance(EProcessorSequence.CalcDistance);
		Context = new FTamerProcessorContext();
		Context.Owner = base.Owner;
	}

	public override void OnTick(float DeltaTime)
	{
		PreProcess(DeltaTime);
		GSThreadPool.Instance.QueueFastTask(default(GSThreadPool.TaskData), ThreadTick, null);
	}

	private void ThreadTick(object State)
	{
		try
		{
			List<FTamerRef> TamerList = new List<FTamerRef>();
			foreach (ETamerPhase key in Context.TamersSortByPhase.Keys)
			{
				if (key <= ETamerPhase.UnLoaded || key > ETamerPhase.Dead)
				{
					continue;
				}
				foreach (FTamerRef item in Context.TamersSortByPhase[key])
				{
					if (!item.HasSpawnRuleFlag(ETamerSpawnRule.BlockingSpawn))
					{
						Context.CurrentProcessedTamer = item;
						CalcDistanceProcessor.NotifyProcess(ref Context);
						Insert2TamerList(item);
					}
				}
			}
			foreach (FTamerRef item2 in TamerList)
			{
				Context.CurrentProcessedTamer = item2;
				HeadProcessor.NotifyProcess(ref Context);
				if (Context.CanBreakProcessChain())
				{
					break;
				}
			}
			void Insert2TamerList(FTamerRef TamerRef)
			{
				for (int i = 0; i < TamerList.Count; i++)
				{
					float lastScore = TamerList[i].LastScore;
					if (TamerRef.LastScore >= lastScore)
					{
						TamerList.Insert(i, TamerRef);
						return;
					}
				}
				TamerList.Add(TamerRef);
			}
		}
		catch (Exception)
		{
		}
	}

	public override void OnAfterAnimTick(float DeltaTime)
	{
		GSThreadPool.Instance.GameThread_FlushFastTasks();
		PostProcess(DeltaTime);
	}

	private void PreProcess(float DeltaTime)
	{
		Context.Cleanup();
		Context.DeltaTime = DeltaTime;
		Context.CountLimitPerFrame = 1 - TamerStrategyBase.CurrentFrameHandleCount;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		if (firstLocalPlayerController.IsNullOrDestroyed())
		{
			firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		}
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(firstLocalPlayerController.GetControlledPawn() as BGUCharacterCS);
		Context.AllPlayerLocation2Ds.Add(new FVector2D(v));
		Context.AllPlayerLocationZs.Add(v.Z);
		Context.bCanBack2Load = base.bCanBack2Load;
		Context.bUseOnlyList = base.bUseOnlyList;
		foreach (ETamerPhase key in base.TamersSortByPhase.Keys)
		{
			if (!Context.TamersSortByPhase.ContainsKey(key))
			{
				Context.TamersSortByPhase.Add(key, new List<FTamerRef>());
			}
			Context.TamersSortByPhase[key].AddRange(base.TamersSortByPhase[key]);
		}
		Context.TamerVisibleDictionary.Clear();
		if (!base.LineTraceManager.GetAndCleanAsyncLineTraceResult(out var OutVisibleTamers, out var OutInvisibleTamers))
		{
			return;
		}
		if (OutVisibleTamers != null)
		{
			foreach (int item in OutVisibleTamers)
			{
				Context.TamerVisibleDictionary[item] = true;
			}
		}
		if (OutInvisibleTamers == null)
		{
			return;
		}
		foreach (int item2 in OutInvisibleTamers)
		{
			Context.TamerVisibleDictionary[item2] = false;
		}
	}

	private void PostProcess(float DeltaTime)
	{
		if (GSGameplayCVar.CVar_TamerAsyncTraceEnable.GetValueInGameThread() == 1 && Context.AllPlayerLocation2Ds.Count > 0)
		{
			FVector inPlayerLocation = new FVector(Context.AllPlayerLocation2Ds[0], Context.AllPlayerLocationZs[0]);
			base.LineTraceManager.StartAsyncLineTrace(inPlayerLocation, Context.Result.NeedLineTraceTamers);
		}
		FTamerStrategyResult result = Context.Result;
		int num = 0;
		foreach (FTamerRef incrementalSpawnTamer in result.IncrementalSpawnTamers)
		{
			if (num >= 1)
			{
				break;
			}
			result.RemoveDelayDestroyTamer(incrementalSpawnTamer);
			if (!incrementalSpawnTamer.HasSpawnRuleFlag(ETamerSpawnRule.NeverSpawn))
			{
				incrementalSpawnTamer.IncrementalSpawnUnit(base.Owner);
			}
			num++;
		}
		num = 0;
		foreach (FTamerRef back2LoadTamer in result.Back2LoadTamers)
		{
			if (result.Back2LoadNoDelayTamers.Contains(back2LoadTamer))
			{
				result.RemoveDelayDestroyTamer(back2LoadTamer);
				continue;
			}
			if (!result.TamerDelayDestroyTimes.ContainsKey(back2LoadTamer))
			{
				result.MarkTamerDelayDestroyTime(back2LoadTamer, FTamerStrategyPreDefines.DefaultDelayDestroyTime);
			}
			num++;
		}
		foreach (FTamerRef back2LoadNoDelayTamer in result.Back2LoadNoDelayTamers)
		{
			back2LoadNoDelayTamer.TurnBack2Loaded();
		}
		num = 0;
		foreach (FTamerRef item in result.TamerDelayDestroyTimes.Keys.ToList())
		{
			if (item.SpawnRuleFlags != ETamerSpawnRule.Normal)
			{
				result.RemoveDelayDestroyTamer(item);
				continue;
			}
			float num2 = result.TamerDelayDestroyTimes[item];
			num2 -= DeltaTime;
			result.MarkTamerDelayDestroyTime(item, num2);
			if (num < 10 && num2 <= 0f)
			{
				result.RemoveDelayDestroyTamer(item);
				item.TurnBack2Loaded();
				num++;
			}
		}
		foreach (KeyValuePair<FTamerRef, EUnitPreloadLevel> preloadTamer in result.PreloadTamers)
		{
			preloadTamer.Key.SetPreloadLevel(preloadTamer.Value);
		}
		foreach (KeyValuePair<FTamerRef, ETamerPreloadLevel> item2 in result.PreloadTamersForMonsterClass)
		{
			item2.Key.SetTamerPreloadLevel(item2.Value);
		}
		foreach (KeyValuePair<FTamerRef, bool> item3 in result.ChangeLODDictionary)
		{
			item3.Key.SetLODVisible(item3.Value);
		}
		foreach (FTamerRef blockingSpawnTamer in result.BlockingSpawnTamerList)
		{
			if (blockingSpawnTamer.Phase > ETamerPhase.UnLoaded && blockingSpawnTamer.Phase < ETamerPhase.Dead && blockingSpawnTamer.InstancePtr.IsValid())
			{
				while (blockingSpawnTamer.Phase != ETamerPhase.Spawned && blockingSpawnTamer.IncrementalSpawnUnit(base.Owner))
				{
				}
			}
		}
		base.CurrentFrameDelayDestroyCount = result.TamerDelayDestroyTimes.Count;
		if (base.LogTime >= base.LogIntervalSecond)
		{
			foreach (KeyValuePair<ETamerPhase, HashSet<FTamerRef>> item4 in base.TamersSortByPhase)
			{
				ETamerPhase key = item4.Key;
				if (key == ETamerPhase.UnLoaded)
				{
					continue;
				}
				foreach (FTamerRef item5 in item4.Value)
				{
					if (key == ETamerPhase.Spawned)
					{
						item5.RequestUpdateLocation();
					}
				}
			}
		}
		if (base.LogTime >= base.LogIntervalSecond)
		{
			base.LogTime = 0f;
		}
		else
		{
			base.LogTime += DeltaTime;
		}
	}

	protected override void PostAddTamer(FTamerRef InTamer)
	{
		base.PostAddTamer(InTamer);
		if (B1Global.GIsBossRushMode)
		{
			InTamer.SetPreloadLevel(EUnitPreloadLevel.Top);
		}
	}

	public override void Destroy()
	{
		base.Destroy();
		Context.Cleanup();
		Context = null;
		HeadProcessor = null;
	}
}
