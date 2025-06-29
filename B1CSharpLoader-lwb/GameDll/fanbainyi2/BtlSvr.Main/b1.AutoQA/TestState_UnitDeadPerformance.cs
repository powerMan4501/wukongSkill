using System.Collections.Generic;
using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_UnitDeadPerformance : AutoTestNodeLib.TestState_Node
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

	private readonly int BUFF;

	private string TamerClassName;

	private readonly UClass MonsterClass;

	private readonly UClass TamerClass;

	public TestState_UnitDeadPerformance(UObject WorldContext, string TamerClassName, int DistanceBetween, ACameraActor FrontCam, int BUFF)
	{
		base.WorldContext = WorldContext;
		this.DistanceBetween = DistanceBetween;
		CurrentState = InnerState.FindEnemy_ByUClass;
		this.FrontCam = FrontCam;
		this.BUFF = BUFF;
		this.TamerClassName = TamerClassName;
		UBlueprint uBlueprint = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UBlueprint>(TamerClassName, ELoadResourceType.SyncLoadAndCache);
		if (uBlueprint == null)
		{
			UClass uClass = (TamerClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(TamerClassName, ELoadResourceType.SyncLoadAndCache));
			if (!TamerClass.IsNullOrDestroyed())
			{
				MonsterClass = uClass.ClassDefaultObject.Cast<BUTamerActor>().GetMonsterClass();
			}
		}
		else
		{
			TamerClass = uBlueprint.GeneratedClass;
			MonsterClass = uBlueprint.GeneratedClass.ClassDefaultObject.Cast<BUTamerActor>().GetMonsterClass();
		}
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
			Description = "寻敌中";
			if (TamerClass != null)
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, TamerClass);
				if (allActorsOfClass.Length == 0)
				{
					return AutoTestNodeLib.NodeState.Succeeded;
				}
				Enemy = (allActorsOfClass[0] as BUTamerActor).GetMonster();
				BUS_EventCollectionCS.Get(Enemy).Evt_AIPauseBT.Invoke(P1: true);
				Enemy.StopAnimMontage(null);
				UBGUFunctionLibraryForCS.BGUGetBounds(Enemy.Mesh, out var _, out var BoxExtent);
				MonsterHalfX = BoxExtent.X;
				MonsterHalfY = BoxExtent.Y;
				MonsterHalfZ = BoxExtent.Z;
				Balance = FMath.Max(2f * MonsterHalfX / 16f, 2f * MonsterHalfY / 16f, 2f * MonsterHalfZ / 9f, MonsterHalfY / 8f, MonsterHalfX / 8f);
				Description = $"找到了{Enemy.GetName()}，其身材数据为 半X {MonsterHalfX}，半Y {MonsterHalfY}, 半Z {MonsterHalfZ}";
				TransferState(InnerState.WaitFor_Preload);
				break;
			}
			return AutoTestNodeLib.NodeState.Succeeded;
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
				.GetForwardVector() * 4000.0 + new FVector(actorLocation.X, actorLocation.Y, MonsterHalfZ + 100f);
			Enemy.SetActorLocation(newLocation, bSweep: false, out SweepHitResult, bTeleport: false);
			Description = "怪物矫正位置:" + newLocation.ToString();
			TransferState(InnerState.Cast_Skill_Start);
			break;
		}
		case InnerState.Cast_Skill_Start:
		{
			if (TickCounter < 1)
			{
				Description = "等待怪物稳定";
				break;
			}
			APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
			BGUFunctionLibraryCS.BGUSetAttrValue(Enemy, EBGUAttrFloat.Hp, 1f);
			BGUFunctionLibraryCS.BGUSetAttrValue(Enemy, EBGUAttrFloat.Hp, 1f);
			BGUFunctionLibraryCS.BGURemoveAllBuff(Enemy, EBuffEffectTriggerType.None);
			BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, Enemy, BUFF);
			if (BUFF == 0)
			{
				BUS_EventCollectionCS.Get(Enemy)?.Evt_UnitDead.Invoke(null, EDeadReason.SkillDamage);
			}
			Description = "主角给怪上BUFF";
			TransferState(InnerState.Set_Camera);
			break;
		}
		case InnerState.Set_Camera:
		{
			USceneComponent SocketOwnerComp;
			FVector location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, Enemy, new FName("pelvis"), out SocketOwnerComp).GetLocation();
			FVector fVector = location + new FVector((float)(-1 * DistanceBetween) * Balance, 0.0, (float)DistanceBetween * Balance / 2f);
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
			if (TickCounter == 2 && Enemy != null)
			{
				APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
				if (!Enemy.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetAttrValue(Enemy, EBGUAttrFloat.Hp, 1f);
					BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, Enemy, BUFF);
				}
				if (!Enemy.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetAttrValue(Enemy, EBGUAttrFloat.Hp, 1f);
					BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, Enemy, BUFF);
				}
			}
			if (TickCounter > 20 || Enemy == null)
			{
				Description = "不看了";
				TransferState(InnerState.Kill_Monster);
			}
			else
			{
				Description = "看死亡表现";
			}
			break;
		case InnerState.Kill_Monster:
			if (Enemy != null)
			{
				Enemy.DestroyActor();
			}
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
