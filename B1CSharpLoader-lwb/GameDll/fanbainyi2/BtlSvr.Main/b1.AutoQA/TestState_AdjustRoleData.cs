using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_AdjustRoleData : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		FindEnemy_ByUClass,
		AdjustRoleData
	}

	private InnerState CurrentState;

	private BGUCharacterCS Enemy;

	private readonly TStrongObjectPtr<UClass> _Class = new TStrongObjectPtr<UClass>();

	private readonly int DistanceBetween;

	private List<int> AllSkillID;

	private int CurrentIndexID = -1;

	private int TickCounter;

	private AActor NiagaraStatUI;

	private bool WaitSkillEffect;

	private int CurrentWaitCounter;

	private UClass Class
	{
		get
		{
			return _Class.Get();
		}
		set
		{
			_Class.Set(value);
		}
	}

	public TestState_AdjustRoleData(UObject WorldContext, UClass Class)
	{
		base.WorldContext = WorldContext;
		UBlueprint uBlueprint = Class.Cast<UBlueprint>();
		if (uBlueprint != null)
		{
			this.Class = uBlueprint.GeneratedClass.ClassDefaultObject.Cast<BUTamerActor>().GetMonsterClass();
		}
		else
		{
			BUTamerActor bUTamerActor = Class.ClassDefaultObject.Cast<BUTamerActor>();
			if (bUTamerActor != null)
			{
				this.Class = bUTamerActor.GetMonsterClass();
			}
			else
			{
				this.Class = Class;
			}
		}
		CurrentState = InnerState.FindEnemy_ByUClass;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.FindEnemy_ByUClass:
		{
			Description = "寻敌中";
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, Class);
			if (allActorsOfClass.Length == 0)
			{
				throw new Exception("在TestState_AdjustRoleData节点中，未能找到" + Class.GetName());
			}
			Enemy = allActorsOfClass[0] as BGUCharacterCS;
			Description = "找到了" + Class.GetName();
			Class = null;
			_Class.Dispose();
			TransferState(InnerState.AdjustRoleData);
			TickCounter++;
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.AdjustRoleData:
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((Enemy != null) ? Enemy.GetFinalBattleInfoExtendID() : (-1));
			if (unitBattleInfoExtendDesc != null)
			{
				int num = unitBattleInfoExtendDesc.LevelNumericalStrength + 1;
				BGUFunctionLibraryManaged.RunScriptGM($"ReInitRoleData {num}", WorldContext);
				Description = $"读取了套装{num}";
			}
			else
			{
				Description = "读取套装失败，找不到EnemyBattleInfoExtendDesc";
			}
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
	}
}
