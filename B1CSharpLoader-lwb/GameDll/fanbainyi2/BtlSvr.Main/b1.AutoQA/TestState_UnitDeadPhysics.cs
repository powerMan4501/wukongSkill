using System.Collections.Generic;
using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_UnitDeadPhysics : AutoTestNodeLib.TestState_Node
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

	private readonly ACameraActor Camera;

	private readonly ACameraActor BackCam;

	private readonly ACameraActor LeftCam;

	private float Balance;

	private readonly AStaticMeshActor PosActor;

	private string TamerClassName;

	private readonly UClass MonsterClass;

	private readonly UClass TamerClass;

	private int DistanceToWall;

	private int StiffLevel;

	private EHitActionDir HitActionDir;

	public TestState_UnitDeadPhysics(UObject WorldContext, string TamerClassName, int DistanceBetween, ACameraActor Camera, AStaticMeshActor PosActor, int DistanceToWall, int StiffLevel, EHitActionDir HitActionDir)
	{
		base.WorldContext = WorldContext;
		this.DistanceBetween = DistanceBetween;
		CurrentState = InnerState.FindEnemy_ByUClass;
		this.Camera = Camera;
		this.PosActor = PosActor;
		this.DistanceToWall = DistanceToWall;
		this.StiffLevel = StiffLevel;
		this.HitActionDir = HitActionDir;
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
				AActor[] array = allActorsOfClass;
				foreach (AActor aActor in array)
				{
					BGUCharacterCS bGUCharacterCS = (aActor as BUTamerActor)?.GetMonster();
					if (bGUCharacterCS != null)
					{
						TamerActor = aActor as BUTamerActor;
						Enemy = bGUCharacterCS;
					}
				}
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
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
			firstLocalPlayerController.GetControlledPawn();
			FVector fVector = PosActor.GetActorLocation() + new FVector((float)(-1 * DistanceBetween) * Balance, (float)(-1 * DistanceBetween) * Balance, (float)DistanceBetween * Balance);
			Camera.SetActorLocation(fVector, bSweep: false, out var _, bTeleport: false);
			Camera.SetActorRotation(UMathLibrary.FindLookAtRotation(fVector, PosActor.GetActorLocation()), bTeleportPhysics: false);
			firstLocalPlayerController.SetViewTargetWithBlend(Camera);
			Description = "重置主角位置为00点，设置最短定身时间为4000ms";
			TransferState(InnerState.Set_Monster);
			break;
		}
		case InnerState.Set_Monster:
		{
			FVector destLocation = PosActor.GetActorLocation() - new FVector(DistanceToWall, 0.0, 0.0);
			Enemy.Teleport(destLocation, UMathLibrary.FindLookAtRotation(Enemy.GetActorLocation(), Enemy.GetActorLocation() + new FVector(-1000.0, 0.0, 0.0)));
			Description = "怪物矫正位置:" + destLocation.ToString();
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
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
			firstLocalPlayerController.GetControlledPawn();
			BGUFunctionLibraryCS.BGUSetAttrValue(Enemy, EBGUAttrFloat.Hp, 1f);
			BGUFunctionLibraryCS.BGURemoveAllBuff(Enemy, EBuffEffectTriggerType.None);
			FEffectInstReq effectInstReq = new FEffectInstReq(firstLocalPlayerController.GetControlledPawn());
			effectInstReq.HitActionDir = HitActionDir;
			BUS_EventCollectionCS.Get(Enemy)?.Evt_UnitDead.Invoke(firstLocalPlayerController.GetControlledPawn(), EDeadReason.SkillDamage, -1, StiffLevel, null, effectInstReq);
			Description = "主角把怪打死";
			TransferState(InnerState.Cast_Skill_Monitor);
			break;
		}
		case InnerState.Cast_Skill_Monitor:
			if (TickCounter > 20)
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
		{
			string finalGuid = TamerActor.GetFinalGuid();
			BGS_EventCollectionCS.Get(WorldContext)?.Evt_RequestDestroyUnit.Invoke(finalGuid);
			Description = "销毁当前怪物";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
