using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_PreUIPerformanceTest : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		SwitchConfig
	}

	private int TickCounter;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_PreUIPerformanceTest(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = CurrentState.ToString() + " " + TickCounter;
		if (CurrentState == InnerState.SwitchConfig)
		{
			string fullPath = Path.GetFullPath(FPaths.Combine(FPaths.ProjectDir, "Tools/dotTrace"));
			string text = "b1";
			string fullPath2 = Path.GetFullPath(FPaths.ProjectDir);
			FPaths.Combine(fullPath, "DotTrace");
			string arguments = text + " " + fullPath2 + " -1";
			if (UGSFileHelper.DirectoryExists(UIDataTracker.ProfilingDir))
			{
				UGSFileHelper.DeleteDirectory(UIDataTracker.ProfilingDir);
			}
			UGSFileHelper.CreateDirectory(UIDataTracker.ProfilingDir);
			if (UGSFileHelper.DirectoryExists(UIDataTracker.DTTDir))
			{
				UGSFileHelper.DeleteDirectory(UIDataTracker.DTTDir);
			}
			AutoTestHelperLib.RunBat(new ProcessStartInfo("AttachToBuild.bat", arguments)
			{
				WorkingDirectory = fullPath,
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true,
				Verb = "runas"
			}, IsWait: false);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "DebugConfig.DebugReInitRoleCheck 0", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "DebugConfig.IsShowDebugDrawUI 1", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "DebugConfig.DebugDrawTag UI", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "DebugConfig.IsOpenStatGSCustom 1", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "stat unit", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "stat namedevents", null);
			List<UIDataTracker.TraceStatData> list = new List<UIDataTracker.TraceStatData>
			{
				new UIDataTracker.TraceStatData("STAT_UnitGame", "UnitGameTick", 1000f, 5f),
				new UIDataTracker.TraceStatData("STAT_SlateTickTime", "SlateTick", 1f, 5f)
			};
			if (DebugConfig.IsOpenStatGSCustom)
			{
				list.Add(new UIDataTracker.TraceStatData("GS_BGW_UIMgr.OnTick", "UIMgrTick", 1f, 5f));
			}
			UIDataTracker.SetTraceStatDataList(list);
			BGW_UIEventCollection.Get(WorldContext)?.Evt_UI_TryInitDrawDebugUI();
			BGW_UIEventCollection.Get(WorldContext)?.Evt_UI_UITrackerClearData();
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "Trace.Start CPU,Log,Bookmark,Frame,GPU,LoadTime,File,Net,Stats,Counters", null);
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		Description = "进入了异常测试状态，测试脚本有逻辑问题!";
		return AutoTestNodeLib.NodeState.Failed;
	}
}
