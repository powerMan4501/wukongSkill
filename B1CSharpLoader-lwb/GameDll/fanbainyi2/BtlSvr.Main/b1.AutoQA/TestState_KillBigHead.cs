using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_KillBigHead : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		FindEnemy_ByName,
		FindEnemy_ByUClass,
		FindEnemy_ByBattleState,
		FindEnemy_InRadius,
		ApproachAndAttack_Enemy
	}

	private int TickCounter;

	private InnerState CurrentState;

	private BGUCharacterCS EnemyUnit;

	private BUTamerActor EnemyTamer;

	private readonly string ActorName;

	private readonly string ActorLevel;

	private readonly UClass Class;

	private AutoTestNodeLib.AutoBattleExitCondition ExitCondition;

	private string[] ExtraArgs;

	private int Radius;

	public TestState_KillBigHead(UObject WorldContext, BGUCharacterCS EnemyUnit, AutoTestNodeLib.AutoBattleExitCondition ExitCondition = AutoTestNodeLib.AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
	{
		base.WorldContext = WorldContext;
		this.EnemyUnit = EnemyUnit;
		this.ExitCondition = ExitCondition;
		this.ExtraArgs = ExtraArgs;
		CurrentState = InnerState.ApproachAndAttack_Enemy;
	}

	public TestState_KillBigHead(UObject WorldContext, BUTamerActor EnemyTamer, AutoTestNodeLib.AutoBattleExitCondition ExitCondition = AutoTestNodeLib.AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
	{
		base.WorldContext = WorldContext;
		this.EnemyTamer = EnemyTamer;
		this.ExitCondition = ExitCondition;
		this.ExtraArgs = ExtraArgs;
		CurrentState = InnerState.ApproachAndAttack_Enemy;
	}

	public TestState_KillBigHead(UObject WorldContext, string ActorName, AutoTestNodeLib.AutoBattleExitCondition ExitCondition = AutoTestNodeLib.AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
	{
		base.WorldContext = WorldContext;
		this.ActorName = ActorName;
		ActorLevel = null;
		this.ExitCondition = ExitCondition;
		this.ExtraArgs = ExtraArgs;
		CurrentState = InnerState.FindEnemy_ByName;
	}

	public TestState_KillBigHead(UObject WorldContext, string ActorName, string ActorLevel, AutoTestNodeLib.AutoBattleExitCondition ExitCondition = AutoTestNodeLib.AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
	{
		base.WorldContext = WorldContext;
		this.ActorName = ActorName;
		this.ActorLevel = ActorLevel;
		this.ExitCondition = ExitCondition;
		this.ExtraArgs = ExtraArgs;
		CurrentState = InnerState.FindEnemy_ByName;
	}

	public TestState_KillBigHead(UObject WorldContext, UClass Class, AutoTestNodeLib.AutoBattleExitCondition ExitCondition = AutoTestNodeLib.AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
	{
		base.WorldContext = WorldContext;
		BUTamerActor bUTamerActor = Class.ClassDefaultObject.Cast<BUTamerActor>();
		if (bUTamerActor == null)
		{
			this.Class = Class;
		}
		else
		{
			this.Class = bUTamerActor.GetMonsterClass();
		}
		this.ExitCondition = ExitCondition;
		this.ExtraArgs = ExtraArgs;
		CurrentState = InnerState.FindEnemy_ByUClass;
	}

	public TestState_KillBigHead(UObject WorldContext, AutoTestNodeLib.AutoBattleExitCondition ExitCondition = AutoTestNodeLib.AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
	{
		base.WorldContext = WorldContext;
		this.ExitCondition = ExitCondition;
		this.ExtraArgs = ExtraArgs;
		CurrentState = InnerState.FindEnemy_ByBattleState;
	}

	public TestState_KillBigHead(UObject WorldContext, int Radius, AutoTestNodeLib.AutoBattleExitCondition ExitCondition = AutoTestNodeLib.AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
	{
		base.WorldContext = WorldContext;
		this.Radius = Radius;
		this.ExitCondition = ExitCondition;
		this.ExtraArgs = ExtraArgs;
		CurrentState = InnerState.FindEnemy_InRadius;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		BGUCharacterCS EnemyUnit;
		switch (CurrentState)
		{
		case InnerState.FindEnemy_ByName:
		{
			BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContext);
			foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
			{
				if (bGUCharacterCS.GetName() == ActorName && (ActorLevel == null || bGUCharacterCS.GetLevel().GetOutermost().GetName()
					.Contains(ActorLevel)))
				{
					this.EnemyUnit = bGUCharacterCS;
					Description = $"找到了{ActorName}";
					TransferState(InnerState.ApproachAndAttack_Enemy);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			BUTamerActor[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(WorldContext);
			foreach (BUTamerActor bUTamerActor in allActorsOfClass2)
			{
				if (bUTamerActor.GetName() == ActorName && (ActorLevel == null || bUTamerActor.GetLevel().GetOutermost().GetName()
					.Contains(ActorLevel)))
				{
					EnemyTamer = bUTamerActor;
					Description = $"找到了{ActorName}";
					TransferState(InnerState.ApproachAndAttack_Enemy);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			Description = "在AutoBattle节点中，未能找到" + ActorName + "，请检查策划是否修改了该区域的种怪情况";
			return AutoTestNodeLib.NodeState.Failed;
		}
		case InnerState.FindEnemy_ByUClass:
		{
			AActor[] allActorsOfClass3 = UGameplayStatics.GetAllActorsOfClass(WorldContext, Class);
			if (allActorsOfClass3.Length == 0)
			{
				Description = "在AutoBattle节点中，未能找到" + Class.ToString() + "，请检查策划是否修改了该区域的种怪情况";
				return AutoTestNodeLib.NodeState.Failed;
			}
			this.EnemyUnit = allActorsOfClass3[0] as BGUCharacterCS;
			EnemyTamer = allActorsOfClass3[0] as BUTamerActor;
			Description = $"找到了{allActorsOfClass3[0].GetName()}";
			TransferState(InnerState.ApproachAndAttack_Enemy);
			break;
		}
		case InnerState.FindEnemy_ByBattleState:
			Description = "寻找对自己有仇恨的敌人中";
			if (AutoTestHelperLib.FindNearbyUnit(WorldContext, 3000, out EnemyUnit))
			{
				if (AutoTestHelperLib.IsUnitInBattle(EnemyUnit))
				{
					this.EnemyUnit = EnemyUnit;
					Description = $"找到了{this.EnemyUnit.GetName()}";
					TransferState(InnerState.ApproachAndAttack_Enemy);
					break;
				}
				Description = EnemyUnit.GetName() + " 在身边，但并不敌对";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			Description = "身边没有敌人";
			return AutoTestNodeLib.NodeState.Succeeded;
		case InnerState.FindEnemy_InRadius:
			Description = "寻找对自己有仇恨的敌人中";
			if (AutoTestHelperLib.FindNearbyUnit(WorldContext, Radius, out EnemyUnit))
			{
				this.EnemyUnit = EnemyUnit;
				Description = $"找到了{this.EnemyUnit.GetName()}";
				TransferState(InnerState.ApproachAndAttack_Enemy);
				break;
			}
			Description = "身边没有敌人";
			return AutoTestNodeLib.NodeState.Succeeded;
		case InnerState.ApproachAndAttack_Enemy:
			if ((ExitCondition & AutoTestNodeLib.AutoBattleExitCondition.SequenceBegin) != 0)
			{
				if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
				{
					Description = "侦测到播片";
					return AutoTestNodeLib.NodeState.Succeeded;
				}
			}
			else if (this.EnemyUnit == null)
			{
				this.EnemyUnit = EnemyTamer.GetMonster();
				if (this.EnemyUnit == null)
				{
					Description = "Tamer还未创生Unit，需要往Tamer方向走走";
					AutoTestHelperLib.RunToPosition(WorldContext, EnemyTamer.GetActorLocation());
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			else if ((ExitCondition & AutoTestNodeLib.AutoBattleExitCondition.HealthPercent) != 0)
			{
				float num = BGUFunctionLibraryCS.BGUGetFloatAttr(this.EnemyUnit, EBGUAttrFloat.Hp) / BGUFunctionLibraryCS.BGUGetFloatAttr(this.EnemyUnit, EBGUAttrFloat.HpMax);
				if (num <= float.Parse(ExtraArgs[0]))
				{
					Description = "目标怪物满足了血量条件：小于" + float.Parse(ExtraArgs[0]);
					return AutoTestNodeLib.NodeState.Succeeded;
				}
				AutoTestLoggerLib.QALogInfo(WorldContext, "目标怪物血量百分比为" + num);
			}
			if (!BGUFunctionLibraryCS.BGUHasUnitState(this.EnemyUnit, EBGUUnitState.Dead))
			{
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(this.EnemyUnit, EBGUSimpleState.CantShowBlood))
				{
					Description = $"目标{this.EnemyUnit.GetName()}血条已经隐藏";
					return AutoTestNodeLib.NodeState.Succeeded;
				}
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EBGUSimpleState.InAnimationSyncing))
				{
					Description = $"主角正在被抓投";
					return AutoTestNodeLib.NodeState.Running;
				}
				if (!BGUFunctionLibraryCS.BGUIsEnemyTeam(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), this.EnemyUnit))
				{
					Description = $"目标{this.EnemyUnit.GetName()}已转换为中立阵营";
					return AutoTestNodeLib.NodeState.Succeeded;
				}
				AutoTestHelperLib.ApproachAndAttack(WorldContext, this.EnemyUnit);
				Description = $"试图击杀{this.EnemyUnit.GetName()}中";
				return AutoTestNodeLib.NodeState.Running;
			}
			if ((ExitCondition & AutoTestNodeLib.AutoBattleExitCondition.KillTarget) == 0)
			{
				Description = "未能满足预定的退出条件" + ExitCondition.ToString() + "，怪物被击杀掉了";
				return AutoTestNodeLib.NodeState.Failed;
			}
			Description = $"目标{this.EnemyUnit.GetName()}已被击杀";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
