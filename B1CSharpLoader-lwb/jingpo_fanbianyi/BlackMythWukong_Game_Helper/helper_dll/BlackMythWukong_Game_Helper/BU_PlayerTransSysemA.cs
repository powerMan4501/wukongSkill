using System;
using System.Reflection;
using b1;
using b1.BGW;
using BtlShare;
using Diana.Common;
using HarmonyLib;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

public class BU_PlayerTransSysemA : SystemBase
{
	[HarmonyPatch]
	public class hook_TickInputForMoving
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("BUS_PlayerInputActionComp:TickInputForMoving", (Type[])null, (Type[])null);
		}

		private static void Postfix(in FVector MoveInputAxis, float DeltaTime)
		{
			if ((MoveInputAxis.X == 0f && MoveInputAxis.Y == 0f) || !isinTransformState || !((UObject)(object)boss != null) || !((UObject)(object)boss.GetMonster() != null))
			{
				return;
			}
			APawn controlledPawn = MyUtils.GetControlledPawn();
			if (controlledPawn == null)
			{
				return;
			}
			BGUCharacterCS monster = boss.GetMonster();
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)controlledPawn);
			if (firstLocalPlayerController == null)
			{
				return;
			}
			float num = 400f;
			if (!(firstLocalPlayerController.PlayerCameraManager == null))
			{
				FVector fVector = firstLocalPlayerController.PlayerCameraManager.GetActorForwardVector() * MoveInputAxis.Y;
				FVector fVector2 = firstLocalPlayerController.PlayerCameraManager.GetActorRightVector() * MoveInputAxis.X;
				FVector fVector3 = fVector + fVector2;
				FVector fVector4 = ((AActor)(object)monster).GetActorLocation() + fVector3 * num;
				FVector actorLocation = ((AActor)(object)monster).GetActorLocation();
				FRotator fRotator = UMathLibrary.FindLookAtRotation(actorLocation, fVector4);
				fRotator.Roll = 0f;
				fRotator.Pitch = 0f;
				if (BGUFunctionLibraryCS.BGUGetTarget(player) != null)
				{
					changeActorRotation();
				}
				else
				{
					FRotator actorRotation = controlledPawn.GetActorRotation();
					((AActor)(object)monster).SetActorRotation(MathLib.Lerp(ref actorRotation, ref fRotator, DeltaTime), bTeleportPhysics: false);
				}
				BGUFuncLibAICS.BGURequestAIMoveToLocationWithMM((AActor)(object)monster, fVector4, EAIMoveSpeedType.SPRINT, 2f, EBGUMoveAIType.None, IncludeSelfRadius: true, IncludeTargetRadius: true, EState_MM.LockRun);
			}
		}
	}

	public static TB_BossInfoA TBBossInfoA;

	public static BossInfoA BossInfo;

	public static float bossScale3D;

	public static APawn player;

	private static BUTamerActor boss;

	private static BGUCharacterCS bossActor;

	private static FTamerRef tamerRef;

	public static float PlayerActorLocationZ;

	public static bool isinTransformState;

	public static bool startTransforming;

	private static float DelayToSetBossTarget;

	private static float delayTime;

	[HarmonyPatch(typeof(BUS_AIComp), "SetBT")]
	[HarmonyPrefix]
	private static bool SetBT(BUS_AIComp __instance, UBehaviorTree BT)
	{
		if (__instance != null && __instance.GetOwner() == GetbossActor())
		{
			return false;
		}
		return true;
	}

	public override void OnAttach()
	{
		TBBossInfoA = GlobalObjectMgr.Get<TB_BossInfoA>();
		SetRun(isRun: true);
	}

	public override void OnTick(float DeltTime, int TickGroup)
	{
		if (!IsRun)
		{
			return;
		}
		if (startTransforming)
		{
			delayTime += DeltTime;
			if (delayTime > 0.5f)
			{
				delayTime = 0f;
				startTransforming = false;
				PlayerActorLocationZ = player.GetActorLocation().Z;
				SpawnTransFormBoss();
			}
		}
		if (player != null)
		{
			if (isinTransformState)
			{
				if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(player, EBGUSimpleState.IgnoreRollSkill))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.IgnoreRollSkill, IsRemove: false);
				}
				if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(player, EBGUSimpleState.ImmueDamage))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.ImmueDamage, IsRemove: false);
				}
			}
			else
			{
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(player, EBGUSimpleState.IgnoreRollSkill))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.IgnoreRollSkill, IsRemove: true);
				}
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(player, EBGUSimpleState.ImmueDamage))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.ImmueDamage, IsRemove: true);
				}
			}
		}
		if (!((UObject)(object)boss != null) || !((UObject)(object)boss.GetMonster() != null) || ((UObject)(object)boss.GetMonster()).IsNullOrDestroyed())
		{
			return;
		}
		if ((UObject)(object)bossActor == null)
		{
			bossActor = boss.GetMonster();
			return;
		}
		if (((ACharacter)(object)bossActor).Mesh != null)
		{
			((AActor)(object)bossActor).SetActorRotation(player.GetActorRotation(), bTeleportPhysics: true);
			HanlePlayerTransformState();
		}
		BGUFunctionLibraryCS.BGUAddBuff((AActor)(object)bossActor, (AActor)(object)bossActor, 412108, EBuffSourceType.GM, -1f);
		if (DelayToSetBossTarget > 0f)
		{
			DelayToSetBossTarget -= DeltTime;
		}
		else if (DelayToSetBossTarget <= 0f)
		{
			if (BGUFunctionLibraryCS.BGUGetTarget(player) != null)
			{
				BUS_EventCollectionCS.Get((AActor)(object)bossActor).Evt_AICatchTarget.Invoke(BGUFunctionLibraryCS.BGUGetTarget(player), ETargetSourceType.Target_AssignPlayerAsTarget);
			}
			else
			{
				BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline: false, (AActor)(object)bossActor, new UnitLockTargetInfo(BGUFunctionLibraryCS.BGUGetTarget(player), ETargetSourceType.CameraLockUpdate));
			}
		}
		FVector actorLocation = ((AActor)(object)bossActor).GetActorLocation();
		actorLocation.Z = PlayerActorLocationZ + 100f;
		player.Teleport(actorLocation + ((AActor)(object)bossActor).GetActorForwardVector() * -40.0, ((AActor)(object)bossActor).GetActorRotation());
		BUS_EventCollectionCS.Get((AActor)player).Evt_BuffAllRemove.Invoke((EBuffEffectTriggerType)0, true);
		BUS_EventCollectionCS.Get((AActor)player).Evt_SetPlayerCameraParam.Invoke((EPlayerCameraTableParamType)8, 70f);
		if (!isinTransformState)
		{
		}
	}

	public void bsA(int bossId, float scale3D)
	{
		player = MyUtils.GetControlledPawn();
		if (player == null || !IsRun)
		{
			return;
		}
		if (TBBossInfoA.bossInfoDic.TryGetValue(bossId, out var value) && BossInfo == null)
		{
			BossInfo = value;
		}
		if (BossInfo != null)
		{
			bossScale3D = scale3D;
			isinTransformState = !isinTransformState;
			if (isinTransformState)
			{
				startTransforming = true;
				UGSE_AnimFuncLib.StopAllMontages((AActor)player, 0f);
			}
			else
			{
				SpawnTransFormBoss();
			}
		}
	}

	public static void SetBossInfo(BossInfoA Info)
	{
		BossInfo = Info;
	}

	public static AActor GetbossActor()
	{
		return (AActor)(object)bossActor;
	}

	public static void SpawnTransFormBoss()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get((AActor)player);
		bUS_GSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_PauseAnims, isinTransformState);
		bUS_GSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Actor_ActorHiddenInGame, isinTransformState);
		if (isinTransformState)
		{
			player.SetActorEnableCollision(bNewActorEnableCollision: false);
		}
		if ((UObject)(object)boss == null)
		{
			if (BossInfo != null)
			{
				DelayToSetBossTarget = 2f;
				UWorld world = player.World;
				UClass uClass = BGW_PreloadAssetMgr.Get((UObject)player.World).TryGetCachedResourceObj<UClass>(BossInfo.AssetPath, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Default, (Action<int, UObject>)null, -1, -1);
				AActor aActor = BGUFunctionLibraryCS.BGUSpawnActor(world, uClass, player.GetActorLocation(), player.GetActorRotation());
				boss = aActor as BUTamerActor;
				tamerRef = boss.CurrentRef;
				tamerRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
				tamerRef.ResetLocationCache();
				tamerRef.TamerTransform = player.GetActorTransform();
				FieldInfo field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
				tamerRef.OverrideResetType = (EBGUResetType)3;
				tamerRef.GroupOverrideResetType = (EBGUResetType)3;
				field.SetValue(tamerRef, ETamerPhase.Loaded);
				((ABGUTamerBase)boss).TamerType = (ETamerType)2;
				tamerRef.ResetLocationCache();
				tamerRef.TamerTransform = player.GetActorTransform();
				tamerRef.TamerTransform.Scale3D = new FVector(bossScale3D);
				Console.WriteLine("Trans GUID " + tamerRef.TamerGuid);
			}
		}
		else
		{
			HanlePlayerTransformState();
		}
	}

	private static void HanlePlayerTransformState()
	{
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.IgnoreRollSkill, !isinTransformState);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(player, EBGUSimpleState.ImmueDamage, !isinTransformState);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, EBGUSimpleState.CantBeLock, IsRemove: false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, EBGUSimpleState.CantBeDead, IsRemove: false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, EBGUSimpleState.CantShowBlood, IsRemove: false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, EBGUSimpleState.IgnoreBattleInfoInUnitBar, IsRemove: false);
		BGUPlayerCharacterCS bGUPlayerCharacterCS = MyUtils.GetControlledPawn() as BGUPlayerCharacterCS;
		UGSE_AnimFuncLib.StopAllMontages((AActor)(object)bossActor, 0f);
		ACharacter aCharacter = player as ACharacter;
		aCharacter.CharacterMovement.GravityScale = ((!isinTransformState) ? 4 : 0);
		if ((UObject)(object)bGUPlayerCharacterCS != null)
		{
			bGUPlayerCharacterCS.FollowCamera.FieldOfView = (isinTransformState ? 80 : 65);
		}
		BUS_EventCollectionCS.Get((AActor)player).Evt_EnableCustomFOV.Invoke(P1: true);
		changeCameraBoom1Component(isinTransformState ? ((ACharacter)(object)bossActor).Mesh : player.GetRootComponent());
		if (isinTransformState)
		{
			BUS_EventCollectionCS.Get((AActor)player).Evt_BuffAllRemove.Invoke((EBuffEffectTriggerType)0, true);
			return;
		}
		player.Teleport(((AActor)(object)bossActor).GetActorLocation(), ((AActor)(object)bossActor).GetActorRotation());
		((AActor)(object)bossActor).SetActorEnableCollision(bNewActorEnableCollision: false);
		BUS_EventCollectionCS.Get((AActor)player).Evt_PlayerResetRecoverTalent.Invoke();
		BUS_EventCollectionCS.Get((AActor)player).Evt_PlayerResetRecoverEquipAndSuitTalent.Invoke();
		BGS_EventCollectionCS.Get(player.World).Evt_UnregisterTamer.Invoke(boss.CurrentRef);
		boss = null;
		bossActor = null;
		tamerRef = null;
		player.SetActorEnableCollision(bNewActorEnableCollision: true);
		BUS_EventCollectionCS.Get((AActor)player).Evt_SetBoolProperty.Invoke(EPropType.Actor_ActorHiddenInGame, Value: false);
		BGUFunctionLibraryCS.BGUAddBuff(player, player, 699, EBuffSourceType.AutoTest, 100f);
	}

	private static void changeCameraBoom1Component(USceneComponent Mesh)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = MyUtils.GetControlledPawn() as BGUPlayerCharacterCS;
		((USceneComponent)(object)bGUPlayerCharacterCS.CameraBoom1).DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, bCallModify: true);
		((USceneComponent)(object)bGUPlayerCharacterCS.CameraBoom1).AttachToComponent(Mesh, new FName("pelvis"), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
	}

	public static void changeActorRotation()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)player.World);
		if (!(firstLocalPlayerController == null))
		{
			FRotator cameraRotation = firstLocalPlayerController.PlayerCameraManager.GetCameraRotation();
			cameraRotation.Pitch = 0f;
			cameraRotation.Roll = 0f;
			((AActor)(object)boss.GetMonster()).SetActorRotation(cameraRotation, bTeleportPhysics: true);
		}
	}
}
