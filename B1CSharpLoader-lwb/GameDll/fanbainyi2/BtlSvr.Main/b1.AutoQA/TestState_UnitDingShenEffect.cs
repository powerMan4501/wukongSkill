using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_UnitDingShenEffect : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		FindEnemy_ByUClass,
		Pause_BT,
		WaitFor_Preload,
		Set_Player,
		Set_Monster,
		Set_Camera,
		Cast_Skill_Start,
		Cast_Skill_Monitor,
		Kill_Monster
	}

	private InnerState CurrentState;

	private BGUCharacterCS Enemy;

	private readonly UClass Class;

	private readonly int DistanceBetween;

	private List<int> AllSkillID;

	private int CurrentIndexID = -1;

	private int TickCounter;

	private AActor NiagaraStatUI;

	private bool WaitSkillEffect;

	private int CurrentWaitCounter;

	private float MonsterHalfX;

	private float MonsterHalfY;

	private float MonsterHalfZ;

	private BUTamerActor TamerActor;

	private readonly ACameraActor FrontCam;

	private readonly ACameraActor BackCam;

	private readonly ACameraActor LeftCam;

	private float Balance;

	public TestState_UnitDingShenEffect(UObject WorldContext, UClass Class, int DistanceBetween, ACameraActor FrontCam)
	{
		base.WorldContext = WorldContext;
		TamerActor = Class.ClassDefaultObject.Cast<BUTamerActor>();
		if (TamerActor == null)
		{
			this.Class = Class;
		}
		else
		{
			this.Class = TamerActor.GetMonsterClass();
		}
		this.DistanceBetween = DistanceBetween;
		CurrentState = InnerState.FindEnemy_ByUClass;
		this.FrontCam = FrontCam;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		FHitResult SweepHitResult;
		switch (CurrentState)
		{
		case InnerState.FindEnemy_ByUClass:
		{
			Description = "寻敌中";
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, Class);
			if (allActorsOfClass.Length == 0)
			{
				throw new Exception("在UnitCastAllSkill节点中，未能找到" + Class.GetName());
			}
			Enemy = allActorsOfClass[0] as BGUCharacterCS;
			BUS_EventCollectionCS.Get(Enemy).Evt_AIPauseBT.Invoke(P1: true);
			Enemy.StopAnimMontage(null);
			UBGUFunctionLibraryForCS.BGUGetBounds(Enemy.Mesh, out var _, out var BoxExtent);
			MonsterHalfX = BoxExtent.X;
			MonsterHalfY = BoxExtent.Y;
			MonsterHalfZ = BoxExtent.Z;
			Balance = FMath.Max(2f * MonsterHalfX / 16f, 2f * MonsterHalfY / 16f, 2f * MonsterHalfZ / 9f, MonsterHalfY / 8f, MonsterHalfX / 8f);
			Description = $"找到了{Class.GetName()}，其身材数据为 半X {MonsterHalfX}，半Y {MonsterHalfY}, 半Z {MonsterHalfZ}";
			TransferState(InnerState.Pause_BT);
			break;
		}
		case InnerState.Pause_BT:
			if (TickCounter > 30)
			{
				Description = "已经等了很久，强行进入下一阶段，防止卡住";
				TransferState(InnerState.WaitFor_Preload);
			}
			else if (BGUFunctionLibraryCS.BGUHasUnitState(Enemy, EBGUUnitState.Attacking))
			{
				Description = "等待怪物暂停自主AI中";
			}
			else
			{
				Description = "怪物已经暂停自主AI了";
				TransferState(InnerState.WaitFor_Preload);
			}
			break;
		case InnerState.WaitFor_Preload:
			StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(WorldContext));
			Description = "等待预加载完成中";
			TransferState(InnerState.Set_Player);
			break;
		case InnerState.Set_Player:
		{
			APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
			BUC_CastImmobilizeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_CastImmobilizeData>(controlledPawn);
			int actorResID = BGU_DataUtil.GetActorResID(controlledPawn);
			unPersistentReadOnlyData.ImmobilizeConfigCache[actorResID].MinimalDurationMs = 4000;
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.teleportToPosition 0 0 100", null);
			Description = "重置主角位置为00点，设置最短定身时间为4000ms";
			TransferState(InnerState.Set_Monster);
			break;
		}
		case InnerState.Set_Monster:
		{
			FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
			FVector newLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorRotation()
				.GetForwardVector() * 4000.0 + new FVector(actorLocation.X, actorLocation.Y, MonsterHalfZ);
			if (TickCounter == 1)
			{
				Enemy.SetActorLocation(newLocation, bSweep: false, out SweepHitResult, bTeleport: false);
				Description = "怪物矫正位置:" + newLocation.ToString();
				break;
			}
			Enemy.SetActorRotation(UMathLibrary.FindLookAtRotation(Enemy.GetActorLocation(), actorLocation), bTeleportPhysics: false);
			AutoTestHelperLib.CameraLockTarget(WorldContext, Enemy);
			Description = "主角锁定怪物";
			TransferState(InnerState.Cast_Skill_Start);
			break;
		}
		case InnerState.Cast_Skill_Start:
			if (TickCounter < 3)
			{
				Description = "等待怪物稳定";
				break;
			}
			BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn())?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10518, ECastSkillSourceType.QA));
			Description = "主角释放定身";
			TransferState(InnerState.Set_Camera);
			break;
		case InnerState.Set_Camera:
		{
			USceneComponent SocketOwnerComp;
			FVector location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, Enemy, new FName("pelvis"), out SocketOwnerComp).GetLocation();
			FVector fVector = location + new FVector((float)(-1 * DistanceBetween) * Balance, 0.0, 0.0);
			if (TickCounter == 1)
			{
				FrontCam.SetActorLocation(fVector, bSweep: false, out SweepHitResult, bTeleport: false);
				Description = "矫正相机位置:" + fVector.ToString();
				break;
			}
			FrontCam.SetActorRotation(UMathLibrary.FindLookAtRotation(fVector, location), bTeleportPhysics: false);
			UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).SetViewTargetWithBlend(FrontCam);
			Description = "切到拍照相机";
			TransferState(InnerState.Cast_Skill_Monitor);
			break;
		}
		case InnerState.Cast_Skill_Monitor:
			if (TickCounter == 1 || TickCounter == 2)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "Shot filename=" + Class.GetName() + ".png", UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext));
			}
			if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Enemy, EBGUSimpleState.Immobilizing))
			{
				Description = "等待定身结束";
				break;
			}
			Description = "定身已经结束";
			TransferState(InnerState.Kill_Monster);
			break;
		case InnerState.Kill_Monster:
			Enemy.DestroyActor();
			Description = "销毁当前怪物";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
