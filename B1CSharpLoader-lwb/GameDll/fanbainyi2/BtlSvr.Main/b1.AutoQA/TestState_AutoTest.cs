using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_AutoTest : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Runing,
		End,
		Error
	}

	private InnerState CurrentState;

	private List<string> CaseNameList = new List<string>();

	private b1.AutoQA.CrossLevel_AutoTest_Template CurCase;

	private int CaseIdx;

	public TestState_AutoTest(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public void AddCase(string CaseName)
	{
		CaseNameList.Add(CaseName);
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
	}

	private string GetCurCaseName()
	{
		if (CaseIdx >= 0 && CaseIdx < CaseNameList.Count)
		{
			return CaseNameList[CaseIdx];
		}
		return string.Empty;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.Runing:
			if (CurCase != null)
			{
				CaseState caseState = CurCase.GetCaseState();
				string testLabel = CurCase.TestLabel;
				switch (caseState)
				{
				case CaseState.Pending:
					CurCase.RunTest();
					Description = "开始执行" + testLabel;
					break;
				case CaseState.Running:
					Description = testLabel + "执行中";
					break;
				case CaseState.Succeeded:
					Description = testLabel + "执行完成";
					CaseIdx++;
					if (string.IsNullOrEmpty(GetCurCaseName()))
					{
						TransferState(InnerState.End);
					}
					break;
				default:
					Description = testLabel + "执行失败";
					TransferState(InnerState.Error);
					break;
				}
			}
			else
			{
				string curCaseName = GetCurCaseName();
				foreach (b1.AutoQA.CrossLevel_AutoTest_Template testCase in BIS_AutoTestManagerV2.Get(WorldContext).TestCaseList)
				{
					if (testCase.TestLabel == curCaseName)
					{
						CurCase = testCase;
						break;
					}
				}
				if (CurCase != null)
				{
					Description = "获取" + curCaseName + " Template 成功！";
				}
				else
				{
					Description = "获取" + curCaseName + " Template 失败！";
					TransferState(InnerState.Error);
				}
			}
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.End:
			Description = "执行结束";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
	}
}
