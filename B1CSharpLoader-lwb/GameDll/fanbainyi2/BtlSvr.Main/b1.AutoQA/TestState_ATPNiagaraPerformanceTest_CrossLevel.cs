using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_ATPNiagaraPerformanceTest_CrossLevel : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		ReadLocalConfig,
		AddTest,
		Done
	}

	private int TickCounter;

	private AutoTestHelperLib.BGWDataAsset_TamerListConfig TamerList;

	private TArrayReadWrite<int> SkillIDBlackList;

	private int StartIndex;

	private InnerState CurrentState;

	private string StartFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/NiagaraPerformanceStart.csv";

	private string CompleteFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/NiagaraPerformanceComplete.csv";

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_ATPNiagaraPerformanceTest_CrossLevel(UObject WorldContext, AutoTestHelperLib.BGWDataAsset_TamerListConfig TamerList, TArrayReadWrite<int> SkillIDBlackList)
	{
		base.WorldContext = WorldContext;
		this.TamerList = TamerList;
		this.SkillIDBlackList = SkillIDBlackList;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.ReadLocalConfig:
			if (File.Exists(StartFilePath))
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "继续上次的ATPNiagaraPerformanceTest");
				StartIndex = File.ReadAllLines(StartFilePath).Length;
			}
			else
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "开始一次新的ATPNiagaraPerformanceTest");
				StartIndex = 0;
			}
			TransferState(InnerState.AddTest);
			Description = "完成了配置的读取";
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.AddTest:
		{
			string text = null;
			if (StartIndex > TamerList.TamerList.Count - 1)
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
				text = TamerList.TamerList[StartIndex];
			}
			List<AutoTestNodeLib.TestState_Node> list3 = new List<AutoTestNodeLib.TestState_Node>();
			list3.Add(new TestState_CrossLevel_QuickTeleport(WorldContext));
			list3.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "b.LockHP"));
			list3.Add(new TestState_TextRecord(WorldContext, StartFilePath, text));
			list3.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "b.Invisible"));
			list3.Add(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(WorldContext, text));
			list3.Add(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(WorldContext));
			list3.Add(new TestState_UnitCastAllSkill(WorldContext, text, isPlayer: false, 0, SkillIDBlackList.ToList(), OpenTrace: false, WaitPreLoadAndShaderCompiling: true, SkipSpawnTamerFail: true));
			list3.Add(new TestState_TextRecord(WorldContext, CompleteFilePath, text));
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
