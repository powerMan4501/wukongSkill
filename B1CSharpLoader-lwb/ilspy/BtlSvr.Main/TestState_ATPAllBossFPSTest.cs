using System.Collections.Generic;
using System.IO;
using System.Linq;
using b1;
using b1.AutoQA;
using b1.BGW;
using UnrealEngine.Runtime;

public class TestState_ATPAllBossFPSTest : AutoTestNodeLib.TestState_Node
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

	private InnerState CurrentState;

	private string StartFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/BossFPSTestStart.csv";

	private string CompleteFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/BossFPSTestComplete.csv";

	private string RecordFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/BossFPSRecord.csv";

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_ATPAllBossFPSTest(UObject WorldContext, string TamerListConfigPath, bool QuitBiuPerUnit)
	{
		base.WorldContext = WorldContext;
		TamerListConfig = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<AutoTestHelperLib.BGWDataAsset_TamerListConfig>(TamerListConfigPath, ELoadResourceType.SyncLoadAndCache);
		this.QuitBiuPerUnit = QuitBiuPerUnit;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.ReadLocalConfig:
			if (File.Exists(StartFilePath))
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "继续上次的BossFPSTest");
				StartIndex = File.ReadAllLines(StartFilePath).Length;
			}
			else
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "开始一次新的BossFPSTest");
				StartIndex = 0;
			}
			TransferState(InnerState.AddTest);
			Description = "完成了配置的读取";
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.AddTest:
		{
			string text = null;
			if (StartIndex > TamerListConfig.TamerList.Count - 1)
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
			List<AutoTestNodeLib.TestState_Node> list3 = new List<AutoTestNodeLib.TestState_Node>
			{
				new AutoTestNodeLib.TestState_Wait(WorldContext, 60),
				new AutoTestNodeLib.TestState_Invincible(WorldContext),
				new TestState_TextRecord(WorldContext, StartFilePath, text),
				new AutoTestNodeLib.TestState_GenerateUnitFromTamer(WorldContext, text),
				new TestState_AdjustRoleData(WorldContext, BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(text, ELoadResourceType.SyncLoadAndCache)),
				new AutoTestNodeLib.TestState_Wait(WorldContext, 10),
				new TestState_RecordFPStart(WorldContext),
				new AutoTestNodeLib.TestState_AutoBattle(WorldContext, BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(text, ELoadResourceType.SyncLoadAndCache), AutoTestNodeLib.AutoBattleExitCondition.KillTarget),
				new TestState_RecordFPS2File(WorldContext, RecordFilePath, text),
				new TestState_TextRecord(WorldContext, CompleteFilePath, text)
			};
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
