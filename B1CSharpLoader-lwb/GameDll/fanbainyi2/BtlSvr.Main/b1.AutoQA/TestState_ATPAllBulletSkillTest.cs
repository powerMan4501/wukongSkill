using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_ATPAllBulletSkillTest : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		ReadLocalConfig,
		AddTest,
		Done
	}

	private int TickCounter;

	private BGWDataAsset_TamerAndBulletSkillIDConfig BulletSkillIDConfig;

	private bool QuitEditorPerUnit;

	private int StartIndex;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_ATPAllBulletSkillTest(UObject WorldContext, string BulletSkillIDConfigPath, bool QuitEditorPerUnit)
	{
		base.WorldContext = WorldContext;
		BGWDataAsset_TamerAndBulletSkillIDConfig bulletSkillIDConfig = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<BGWDataAsset_TamerAndBulletSkillIDConfig>(BulletSkillIDConfigPath, ELoadResourceType.SyncLoadAndCache);
		BulletSkillIDConfig = bulletSkillIDConfig;
		this.QuitEditorPerUnit = QuitEditorPerUnit;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.ReadLocalConfig:
			TransferState(InnerState.AddTest);
			Description = "完成了配置的读取";
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.AddTest:
		{
			BUTamerActor bUTamerActor = null;
			List<int> list = new List<int>();
			if (StartIndex > BulletSkillIDConfig.BulletSkillTestInfos.Count - 1)
			{
				Description = "测试完成（没有不通过的，完美收工）";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			bUTamerActor = BulletSkillIDConfig.BulletSkillTestInfos[StartIndex].TamerActor;
			foreach (int skillID in BulletSkillIDConfig.BulletSkillTestInfos[StartIndex].SkillIDList)
			{
				list.Add(skillID);
			}
			List<AutoTestNodeLib.TestState_Node> list2 = new List<AutoTestNodeLib.TestState_Node>();
			list2.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "b.LockHP"));
			list2.Add(new TestState_CrossLevel_QuickTeleport(WorldContext));
			list2.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "b.LockHP"));
			list2.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "b.Invisible"));
			if (!bUTamerActor.IsNullOrDestroyed())
			{
				list2.Add(new AutoTestNodeLib.TestState_GenerateUnitFromTamer(WorldContext, bUTamerActor.GetClass()));
				list2.Add(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(WorldContext));
				list2.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "b.LockHP"));
				List<int> list3 = BGUFuncLibAICS.BGUGetUnitAllSkillID(bUTamerActor);
				foreach (int item in list)
				{
					list3.Remove(item);
				}
				List<int> list4 = new List<int>();
				foreach (int item2 in list3)
				{
					list4.Add(item2);
				}
				list2.Add(new TestState_UnitCastAllSkill(WorldContext, bUTamerActor.GetClass(), isPlayer: false, 0, list4, OpenTrace: true));
			}
			if (QuitEditorPerUnit)
			{
				list2.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "b.QAGenError"));
				list2.Add(new AutoTestNodeLib.TestState_ConsoleCommand(WorldContext, "quit"));
			}
			list2.Reverse();
			foreach (AutoTestNodeLib.TestState_Node item3 in list2)
			{
				StateStack.Push(item3);
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
