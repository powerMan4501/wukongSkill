using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.Calliope;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GeneralTamerStrategy : TamerStrategyBase
{
	private const float DistanceForSpawnMeter = 150f;

	private const float DistanceForActorBeginPlayMeter = 100f;

	private const float DistanceForUnloadMeter = 200f;

	private const float ZOffsetSpawnLimitMeter = 50f;

	private const float ZOffsetUnloadLimitMeter = 100f;

	private const uint FrameMod = 100000u;

	private static Dictionary<string, FUStTamerStrategyConfigDesc> TamerCustomDistMap { get; } = new Dictionary<string, FUStTamerStrategyConfigDesc>();

	private static List<FVector2D> AllPlayerLocation2Ds { get; } = new List<FVector2D>();

	private static List<float> AllPlayerLocationZs { get; } = new List<float>();

	public FFrameInfo LastAllReturnFrame { get; set; }

	private ECollisionChannel AsyncTraceChannel { get; set; }

	private Dictionary<int, FAsyncLineTraceReq> LineTraceParamCached { get; set; } = new Dictionary<int, FAsyncLineTraceReq>();

	private Dictionary<int, uint> ReqIDFrameIndexDictionary { get; } = new Dictionary<int, uint>();

	private Dictionary<uint, FFrameInfo> FrameInfoMap { get; } = new Dictionary<uint, FFrameInfo>();

	private FFrameInfo CurrentPrintFrame { get; set; }

	private FFrameInfo CurrentFrame { get; set; }

	protected override void PostInitial()
	{
		if (BGW_GameDB.GetAllTamerStrategyConfigDesc(out var TamerStrategyConfigDescList))
		{
			foreach (FUStTamerStrategyConfigDesc item in TamerStrategyConfigDescList)
			{
				if (!TamerCustomDistMap.ContainsKey(item.UnitGuid))
				{
					TamerCustomDistMap.Add(item.UnitGuid, item);
				}
			}
		}
		AsyncTraceChannel = ECollisionChannel.ECC_Camera;
	}

	public override void OnAfterAnimTick(float DeltaTime)
	{
		AllPlayerLocation2Ds.Clear();
		AllPlayerLocationZs.Clear();
		List<BGUCharacterCS> allPlayerActors = BGU_UnrealWorldUtil.GetAllPlayerActors(base.Owner);
		foreach (BGUCharacterCS item in allPlayerActors)
		{
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(item);
			AllPlayerLocation2Ds.Add(new FVector2D(v));
			AllPlayerLocationZs.Add(v.Z);
		}
		if (allPlayerActors.Count == 0)
		{
			return;
		}
		TickForAsyncTrace(DeltaTime);
		foreach (ETamerPhase key in base.TamersSortByPhase.Keys)
		{
			if (TamerStrategyBase.CurrentFrameHandleCount >= 1)
			{
				break;
			}
			foreach (FTamerRef item2 in base.TamersSortByPhase[key].ToList())
			{
				bool bCanIncrementalSpawn = false;
				bool bCanBack2Loaded = false;
				bool bCanDrawDebugString = true;
				string DebugString = "";
				if (item2.GetActualResetType() == EBGUResetType.Destroy || item2.NPCShowState == EGsNPCShowState.Hide)
				{
					if (key == ETamerPhase.Visible || (uint)(key - 6) <= 1u)
					{
						bCanBack2Loaded = true;
					}
				}
				else if (base.bUseOnlyList)
				{
					if (item2.HasSpawnRuleFlag(ETamerSpawnRule.OnlySpawn))
					{
						if ((uint)(key - 2) <= 1u || key == ETamerPhase.PreBegunPlay)
						{
							bCanIncrementalSpawn = true;
						}
					}
					else if (key == ETamerPhase.Visible || (uint)(key - 6) <= 1u)
					{
						bCanBack2Loaded = true;
					}
				}
				else if (item2.HasSpawnRuleFlag(ETamerSpawnRule.NeverSpawn))
				{
					if (key == ETamerPhase.Visible || (uint)(key - 6) <= 1u)
					{
						bCanBack2Loaded = true;
					}
				}
				else
				{
					DistanceCheck(item2, key, ref bCanIncrementalSpawn, ref bCanBack2Loaded, ref bCanDrawDebugString, ref DebugString);
				}
				if (base.LogTime >= base.LogIntervalSecond && item2.Phase != ETamerPhase.UnLoaded && bCanDrawDebugString)
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
					item2.DrawDebugString($"{item2.TamerGuid}：\n Phase:{item2.Phase} {DebugString}", base.LogIntervalSecond, color);
				}
				if (bCanBack2Loaded)
				{
					item2.TurnBack2Loaded();
					TamerStrategyBase.CurrentFrameHandleCount++;
					break;
				}
				if (bCanIncrementalSpawn)
				{
					item2.IncrementalSpawnUnit(base.Owner);
					TamerStrategyBase.CurrentFrameHandleCount++;
					break;
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

	private void DistanceCheck(FTamerRef TamerRef, ETamerPhase Phase, ref bool bCanIncrementalSpawn, ref bool bCanBack2Loaded, ref bool bCanDrawDebugString, ref string DebugString)
	{
		float num = -1f;
		float num2 = -1f;
		foreach (FVector2D allPlayerLocation2D in AllPlayerLocation2Ds)
		{
			float num3 = (TamerRef.Location2D - allPlayerLocation2D).Size() / 100f;
			num = ((!(num < 0f)) ? Math.Min(num3, num) : num3);
		}
		foreach (float allPlayerLocationZ in AllPlayerLocationZs)
		{
			float num4 = Math.Abs(TamerRef.LocationZ - allPlayerLocationZ) / 100f;
			num2 = ((!(num2 < 0f)) ? Math.Min(num4, num2) : num4);
		}
		float num5 = 150f;
		float num6 = 100f;
		float num7 = 200f;
		float num8 = 50f;
		float num9 = 100f;
		if (TamerCustomDistMap.TryGetValue(TamerRef.TamerGuid, out var value))
		{
			num6 = value.BattleDist;
			num5 = value.VisibleDist;
			num7 = value.DestroyDist;
			num8 = value.BattleZOffset;
			num9 = value.DestroyZOffset;
		}
		switch (Phase)
		{
		case ETamerPhase.Loaded:
			bCanIncrementalSpawn = num <= num5 && num2 <= num8;
			break;
		case ETamerPhase.Visible:
			bCanIncrementalSpawn = num <= num6 && num2 <= num8;
			bCanBack2Loaded = num >= num7 || num2 > num9;
			break;
		case ETamerPhase.PreBegunPlay:
			bCanIncrementalSpawn = num <= num6 && num2 <= num8;
			bCanBack2Loaded = num >= num7 || num2 > num9;
			break;
		case ETamerPhase.Spawned:
			bCanBack2Loaded = num >= num7 || num2 > num9;
			break;
		}
		if (base.LogTime >= base.LogIntervalSecond)
		{
			bCanDrawDebugString = TamerRef.Phase != ETamerPhase.UnLoaded && num <= num7;
			if (bCanDrawDebugString)
			{
				DebugString = $"Dist:{num} ZOffset:{num2}";
			}
		}
	}

	private void TickForAsyncTrace(float DeltaTime)
	{
		uint num = 1u;
		if (CurrentFrame != null)
		{
			num = (CurrentFrame.FrameIndex + 1) % 100000;
		}
		CurrentFrame = FFrameInfoPool.New();
		CurrentFrame.FrameIndex = num;
		FrameInfoMap.Add(num, CurrentFrame);
		if (CurrentPrintFrame == null)
		{
			CurrentPrintFrame = CurrentFrame;
		}
		else if (CurrentPrintFrame.IsAllReturn())
		{
			LastAllReturnFrame = CurrentPrintFrame;
			uint num2 = CurrentFrame.FrameIndex;
			if (num2 < CurrentPrintFrame.FrameIndex)
			{
				num2 += 100000;
			}
			LastAllReturnFrame.FrameReturnInterval = (int)(num2 - CurrentPrintFrame.FrameIndex);
			FrameInfoMap.Remove(CurrentPrintFrame.FrameIndex);
			CurrentPrintFrame = FrameInfoMap[(CurrentPrintFrame.FrameIndex + 1) % 100000];
		}
	}
}
