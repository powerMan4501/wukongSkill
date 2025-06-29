using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_ATPAllUnitDeadPhysicsTest : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		ReadLocalConfig,
		AddTest,
		Done
	}

	private int TickCounter;

	private readonly AutoTestHelperLib.BGWDataAsset_TamerListConfig TamerListConfig;

	private readonly bool QuitBiuPerUnit;

	private int StartIndex;

	private TArrayReadWrite<UnitDeadPhysicsConfig> Configs;

	private InnerState CurrentState;

	public int DistanceBetween { get; set; }

	private string StartFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/UnitDeadTestStart.csv";

	private string CompleteFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/UnitDeadTestComplete.csv";

	private string RecordFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/UnitDeadRecord.csv";

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_ATPAllUnitDeadPhysicsTest(UObject WorldContext, AutoTestHelperLib.BGWDataAsset_TamerListConfig TamerListConfig, bool QuitBiuPerUnit, int DistanceBetween, TArrayReadWrite<UnitDeadPhysicsConfig> configs)
	{
		this.DistanceBetween = DistanceBetween;
		base.WorldContext = WorldContext;
		this.TamerListConfig = TamerListConfig;
		this.QuitBiuPerUnit = QuitBiuPerUnit;
		Configs = configs;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.ReadLocalConfig:
			if (File.Exists(StartFilePath))
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "继续上次的UnitDeadTest");
				StartIndex = File.ReadAllLines(StartFilePath).Length;
			}
			else
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "开始一次新的UnitDeadTest");
				StartIndex = 0;
			}
			TransferState(InnerState.AddTest);
			Description = "完成了配置的读取";
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.AddTest:
		{
			string text = null;
			if (StartIndex >= TamerListConfig.TamerList.Count)
			{
				List<string> list = File.ReadAllLines(StartFilePath).ToList();
				List<string> list2 = File.ReadAllLines(CompleteFilePath).ToList();
				if (list.Count == list2.Count)
				{
					Description = "测试完成（没有不通过的，完美收工）";
					return AutoTestNodeLib.NodeState.Succeeded;
				}
				foreach (string Line in list)
				{
					if (!list2.Contains(Line) && list.Count((string item) => item == Line) <= 3)
					{
						text = Line;
						break;
					}
				}
				if (text == null)
				{
					Description = "测试完成（能试的已经都试过了）";
					return AutoTestNodeLib.NodeState.Succeeded;
				}
			}
			else
			{
				text = TamerListConfig.TamerList[StartIndex];
			}
			ACameraActor aCameraActor = null;
			ACameraActor camera = null;
			AStaticMeshActor posActor = null;
			AStaticMeshActor posActor2 = null;
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(WorldContext);
			foreach (AActor aActor in allActorsOfClass)
			{
				if (aActor.GetName() == "CameraActor_2" && aActor.GetLevel().GetOutermost().GetName()
					.Contains("DeadRoom"))
				{
					aCameraActor = aActor as ACameraActor;
				}
				if (aActor.GetName() == "CameraActor_0" && aActor.GetLevel().GetOutermost().GetName()
					.Contains("DeadRoom"))
				{
					camera = aActor as ACameraActor;
				}
				if (aActor.GetName() == "StaticMeshActor_11" && aActor.GetLevel().GetOutermost().GetName()
					.Contains("DeadRoom"))
				{
					posActor = aActor as AStaticMeshActor;
				}
				if (aActor.GetName() == "StaticMeshActor_9" && aActor.GetLevel().GetOutermost().GetName()
					.Contains("DeadRoom"))
				{
					posActor2 = aActor as AStaticMeshActor;
				}
			}
			_ = aCameraActor == null;
			List<AutoTestNodeLib.TestState_Node> list3 = new List<AutoTestNodeLib.TestState_Node>();
			list3.Add(new AutoTestNodeLib.TestState_Invincible(WorldContext));
			list3.Add(new TestState_TextRecord(WorldContext, StartFilePath, text));
			list3.Add(new TestState_RecordUnitDeadtart(WorldContext));
			StartIndex = Math.Min(TamerListConfig.TamerList.Count - 1, StartIndex);
			foreach (UnitDeadPhysicsConfig config in Configs)
			{
				list3.Add(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(WorldContext, text));
				list3.Add(new TestState_UnitDeadPhysics(WorldContext, TamerListConfig.TamerList[StartIndex], DistanceBetween, aCameraActor, posActor, config.DistanceToWall, config.StiffLevel, config.HitActionDir));
			}
			foreach (UnitDeadPhysicsConfig config2 in Configs)
			{
				list3.Add(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(WorldContext, text));
				list3.Add(new TestState_UnitDeadPhysics(WorldContext, TamerListConfig.TamerList[StartIndex], DistanceBetween, camera, posActor2, 0, config2.StiffLevel, config2.HitActionDir));
			}
			list3.Add(new TestState_RecordUnitDead2File(WorldContext, RecordFilePath, text));
			list3.Add(new TestState_TextRecord(WorldContext, CompleteFilePath, text));
			if (QuitBiuPerUnit)
			{
				list3.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "quit"));
			}
			list3.Reverse();
			foreach (AutoTestNodeLib.TestState_Node item in list3)
			{
				StateStack.Push(item);
			}
			StartIndex++;
			Description = "注册了一个新的待测项";
			return AutoTestNodeLib.NodeState.Running;
		}
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
	}
}
