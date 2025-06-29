using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_UnitPicTaker : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		FindEnemy_ByUClass,
		Pause_BT,
		WaitFor_Preload,
		Set_Player,
		Set_Monster,
		Set_Camera_Front,
		Set_Camera_Back,
		Set_Camera_Left,
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

	private FVector Pelvis;

	public TestState_UnitPicTaker(UObject WorldContext, UClass Class, int DistanceBetween, ACameraActor FrontCam, ACameraActor BackCam, ACameraActor LeftCam)
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
		this.BackCam = BackCam;
		this.LeftCam = LeftCam;
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
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			Enemy = allActorsOfClass[0] as BGUCharacterCS;
			BUS_EventCollectionCS.Get(Enemy).Evt_AIPauseBT.Invoke(P1: true);
			Enemy.StopAnimMontage(null);
			Enemy.GetController().StopMovement();
			Enemy.Mesh.SetAnimClass(null);
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
				Enemy.StopAnimMontage(null);
				Enemy.GetController().StopMovement();
				Enemy.Mesh.SetAnimClass(null);
				Description = "已经等了很久，强行进入下一阶段，防止卡住";
				TransferState(InnerState.WaitFor_Preload);
			}
			else if (BGUFunctionLibraryCS.BGUHasUnitState(Enemy, EBGUUnitState.Attacking))
			{
				Description = "等待怪物暂停自主AI中";
			}
			else
			{
				Enemy.StopAnimMontage(null);
				Enemy.GetController().StopMovement();
				Enemy.Mesh.SetAnimClass(null);
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
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.teleportToPosition 4000 0 -4900", null);
			Description = "把主角扔远点儿";
			TransferState(InnerState.Set_Monster);
			break;
		}
		case InnerState.Set_Monster:
		{
			FVector target = new FVector(0.0, 0.0, 100.0);
			FVector newLocation = new FVector(4000.0, 0.0, MonsterHalfZ);
			if (TickCounter == 1)
			{
				Enemy.SetActorLocation(newLocation, bSweep: false, out SweepHitResult, bTeleport: false);
				Description = "怪物矫正位置:" + newLocation.ToString();
				break;
			}
			Enemy.StopAnimMontage(null);
			Enemy.GetController().StopMovement();
			Enemy.SetActorRotation(UMathLibrary.FindLookAtRotation(Enemy.GetActorLocation(), target), bTeleportPhysics: false);
			Description = "怪物矫正朝向";
			TransferState(InnerState.Set_Camera_Front);
			break;
		}
		case InnerState.Set_Camera_Front:
		{
			if (TickCounter < 3)
			{
				Enemy.StopAnimMontage(null);
				Enemy.GetController().StopMovement();
				Description = "等待怪物稳定";
				break;
			}
			Pelvis = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, Enemy, new FName("pelvis"), out var _).GetLocation();
			FVector fVector2 = Pelvis + new FVector((float)(-1 * DistanceBetween) * Balance, 0.0, 0.0);
			if (TickCounter == 3)
			{
				FrontCam.SetActorLocation(fVector2, bSweep: false, out SweepHitResult, bTeleport: false);
				Description = "矫正相机位置:" + fVector2.ToString();
			}
			else if (TickCounter == 4)
			{
				FrontCam.SetActorRotation(UMathLibrary.FindLookAtRotation(fVector2, Enemy.GetActorLocation()), bTeleportPhysics: false);
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).SetViewTargetWithBlend(FrontCam);
				Description = "切到拍照相机";
			}
			else
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "Shot filename=" + Class.GetName() + ".png", UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext));
				Description = "拍照完成";
				TransferState(InnerState.Set_Camera_Back);
			}
			break;
		}
		case InnerState.Set_Camera_Back:
		{
			Pelvis = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, Enemy, new FName("pelvis"), out var _).GetLocation();
			FVector fVector3 = Pelvis + new FVector((float)DistanceBetween * Balance, 0.0, 0.0);
			if (TickCounter == 1)
			{
				BackCam.SetActorLocation(fVector3, bSweep: false, out SweepHitResult, bTeleport: false);
				Description = "矫正相机位置:" + fVector3.ToString();
			}
			else if (TickCounter == 2)
			{
				BackCam.SetActorRotation(UMathLibrary.FindLookAtRotation(fVector3, Enemy.GetActorLocation()), bTeleportPhysics: false);
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).SetViewTargetWithBlend(BackCam);
				Description = "切到拍照相机";
			}
			else
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "Shot filename=" + Class.GetName() + ".png", UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext));
				Description = "拍照完成";
				TransferState(InnerState.Set_Camera_Left);
			}
			break;
		}
		case InnerState.Set_Camera_Left:
		{
			Pelvis = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, Enemy, new FName("pelvis"), out var _).GetLocation();
			FVector fVector = Pelvis + new FVector(0.0, (float)DistanceBetween * Balance, 0.0);
			if (TickCounter == 1)
			{
				LeftCam.SetActorLocation(fVector, bSweep: false, out SweepHitResult, bTeleport: false);
				Description = "矫正相机位置:" + fVector.ToString();
			}
			else if (TickCounter == 2)
			{
				LeftCam.SetActorRotation(UMathLibrary.FindLookAtRotation(fVector, Enemy.GetActorLocation()), bTeleportPhysics: false);
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).SetViewTargetWithBlend(LeftCam);
				Description = "切到拍照相机";
			}
			else
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "Shot filename=" + Class.GetName() + ".png", UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext));
				Description = "拍照完成";
				TransferState(InnerState.Kill_Monster);
			}
			break;
		}
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
