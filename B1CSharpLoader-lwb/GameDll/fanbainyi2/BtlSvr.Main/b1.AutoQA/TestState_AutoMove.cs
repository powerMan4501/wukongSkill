using System;
using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_AutoMove : AutoTestNodeLib.TestState_Node
{
	public enum InnerState
	{
		WaitingForSequenceBegin,
		WatchingSequence,
		RegisterCommands,
		RunningAutoMove,
		TestFinish
	}

	private BIS_AutoTestManagerV2.AtpConfigStruct AtpConfigValues;

	private string AutoMoveInstancesConfigPath = "BGWDataAsset_AutoMoveMonitorsConfig'/Game/00Main/DataAsset/AutoMovement/DA_AutoMoveInstancesConfig.DA_AutoMoveInstancesConfig'";

	private List<FAutoMoveMonitorConfigItem> AutoMoveModes;

	private List<FAutoMoveMonitorConfigItem> AutoMovePatterns;

	private InnerState CurrentTestState;

	private FTimerHandle TestTick;

	private AActor EnemyActor;

	private int TickCounter;

	public TestState_AutoMove(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
		BIS_AutoTestManagerV2.Get(WorldContext).LoadATPConfig();
		AtpConfigValues = BIS_AutoTestManagerV2.Get(WorldContext).GetAtpConfigValues;
		InitAutoMoveCmdParams();
	}

	private int GetAutoMoveCaptureModeIndex()
	{
		if (AtpConfigValues == null || AutoMoveModes.Count == 0)
		{
			AutoTestLoggerLib.QALogError(WorldContext, "[ET] 'AptConfigValues' or 'AutoMoveModes' is null");
			return 0;
		}
		int result = 0;
		for (int i = 0; i < AutoMoveModes.Count; i++)
		{
			string text = AtpConfigValues.AutoMoveCaptureMode.Trim();
			string value = AutoMoveModes[i].Desc.Trim();
			if (text.Equals(value))
			{
				result = i;
				break;
			}
		}
		return result;
	}

	private int GetAutoMoveMotionPatternIndex()
	{
		if (IsAutoMoveSimpleTest())
		{
			return 0;
		}
		if (AtpConfigValues == null || AutoMovePatterns.Count == 0)
		{
			AutoTestLoggerLib.QALogError(WorldContext, "[ET] 'AptConfigValues' or 'AutoMovePatterns' is null");
			return 0;
		}
		int result = 0;
		for (int i = 0; i < AutoMovePatterns.Count; i++)
		{
			string text = AtpConfigValues.TargetMap.Trim();
			string value = AutoMovePatterns[i].Desc.Trim();
			if (text.Equals(value))
			{
				result = i;
				break;
			}
		}
		return result;
	}

	private bool IsAutoMoveSimpleTest()
	{
		if (AtpConfigValues != null)
		{
			return AtpConfigValues.AutoMoveSimpleTest;
		}
		return false;
	}

	private bool IsAutoMoveSparsePointsEnabled()
	{
		if (AtpConfigValues != null)
		{
			return AtpConfigValues.AutoMoveEnableSparsePoints;
		}
		return true;
	}

	private bool IsAutoMoveEnemyAIEnabled()
	{
		if (AtpConfigValues != null)
		{
			return AtpConfigValues.AutoMoveEnableEnemyAI;
		}
		return true;
	}

	private int GetAutoMoveStartPointIndex()
	{
		int result = 0;
		int.TryParse(AtpConfigValues.AutoMoveStartPointIndex.Trim(), out result);
		return result;
	}

	private void InitAutoMoveCmdParams()
	{
		BGWDataAsset_AutoMoveMonitorsConfig bGWDataAsset_AutoMoveMonitorsConfig = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<BGWDataAsset_AutoMoveMonitorsConfig>(AutoMoveInstancesConfigPath, ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_AutoMoveMonitorsConfig != null)
		{
			AutoMoveModes = bGWDataAsset_AutoMoveMonitorsConfig.AutoMoveCaptureModes.ToList();
			AutoMovePatterns = bGWDataAsset_AutoMoveMonitorsConfig.AutoMoveMotionPatterns.ToList();
		}
	}

	private void TransferState(InnerState NextState)
	{
		CurrentTestState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		AutoTestLoggerLib.QALogInfo(WorldContext, $"测试状态: {CurrentTestState.ToString()}, TickCount: {TickCounter}");
		switch (CurrentTestState)
		{
		case InnerState.WaitingForSequenceBegin:
			Description = "WaitingForSequenceBegin";
			if (BGS_EventCollectionCS.Get(WorldContext).Evt_QueryIsPlayingCameraMovie.Invoke() || TickCounter > 0)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "DisableAllScreenMessages", null);
				TransferState(InnerState.WatchingSequence);
			}
			break;
		case InnerState.WatchingSequence:
			Description = "WatchingSequence";
			if (BGS_EventCollectionCS.Get(WorldContext).Evt_QueryIsPlayingCameraMovie.Invoke())
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.Invincible", null);
			}
			else
			{
				TransferState(InnerState.RegisterCommands);
			}
			break;
		case InnerState.RegisterCommands:
		{
			Description = "RegisterCommands";
			string[] array = AtpConfigValues.AdditionalConsoleCmds.Trim().Split(';');
			foreach (string text in array)
			{
				if (text.IndexOf("slomo", StringComparison.OrdinalIgnoreCase) >= 0)
				{
					USystemLibrary.ExecuteConsoleCommand(WorldContext, text, null);
					AutoTestLoggerLib.QALogInfo(WorldContext, "Internally execute cmd: " + text);
					break;
				}
			}
			int autoMoveCaptureModeIndex = GetAutoMoveCaptureModeIndex();
			int autoMoveMotionPatternIndex = GetAutoMoveMotionPatternIndex();
			int autoMoveStartPointIndex = GetAutoMoveStartPointIndex();
			int num = (IsAutoMoveSparsePointsEnabled() ? 1 : 0);
			int num2 = (IsAutoMoveEnemyAIEnabled() ? 1 : 0);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.SkipAllPlaySequenceNode 1", null);
			AutoTestLoggerLib.QALogInfo(WorldContext, $"b.EnableAutoMove {autoMoveCaptureModeIndex} {autoMoveMotionPatternIndex} {num} {num2}");
			USystemLibrary.ExecuteConsoleCommand(WorldContext, $"b.EnableAutoMove {autoMoveCaptureModeIndex} {autoMoveMotionPatternIndex} {num} {num2}", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.AutoMove.Init", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, $"b.DebugAutoMove.Goto {autoMoveStartPointIndex}", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.DebugAutoMove.Resume", null);
			TransferState(InnerState.RunningAutoMove);
			break;
		}
		case InnerState.RunningAutoMove:
			Description = "性能数据采集中";
			break;
		case InnerState.TestFinish:
			Description = "漫游场景，采集性能数据完成";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "未定义状态";
			break;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
