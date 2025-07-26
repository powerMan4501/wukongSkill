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

namespace Game_Helper;

public class BU_PlayerTransSysemA : BaseGameHelper
{
	[HarmonyPatch]
	public class hookTickInputForMoving
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
				if (BGUFunctionLibraryCS.BGUGetTarget((AActor)player) != null)
				{
					changeActorRotation();
				}
				else
				{
					FRotator actorRotation = controlledPawn.GetActorRotation();
					((AActor)(object)monster).SetActorRotation(MathLib.Lerp(ref actorRotation, ref fRotator, DeltaTime), bTeleportPhysics: false);
				}
				BGUFuncLibAICS.BGURequestAIMoveToLocationWithMM((AActor)(object)monster, fVector4, (EAIMoveSpeedType)2, 2f, (EBGUMoveAIType)0, true, true, (EState_MM)7);
			}
		}
	}

	public static Tools.BossInfo BossInfo;

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

	public bool IsRuning { get; set; }

	[HarmonyPatch(typeof(BUS_AIComp), "SetBT")]
	[HarmonyPrefix]
	private static bool SetBT(BUS_AIComp __instance, UBehaviorTree BT)
	{
		if ((UObject)(object)__instance != null && ((UActorCompBaseUObj)__instance).GetOwner() == GetbossActor())
		{
			return false;
		}
		return true;
	}

	public void OnInitialize()
	{
	}

	public void OnTick(float DeltTime, int TickGroup)
	{
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		if (!IsRuning)
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
				if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState((AActor)player, (EBGUSimpleState)105))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)player, (EBGUSimpleState)105, false);
				}
				if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState((AActor)player, (EBGUSimpleState)1))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)player, (EBGUSimpleState)1, false);
				}
			}
			else
			{
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState((AActor)player, (EBGUSimpleState)105))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)player, (EBGUSimpleState)105, true);
				}
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState((AActor)player, (EBGUSimpleState)1))
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)player, (EBGUSimpleState)1, true);
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
		BGUFunctionLibraryCS.BGUAddBuff((AActor)(object)bossActor, (AActor)(object)bossActor, 412108, (EBuffSourceType)0, -1f);
		if (DelayToSetBossTarget > 0f)
		{
			DelayToSetBossTarget -= DeltTime;
		}
		else if (DelayToSetBossTarget <= 0f)
		{
			if (BGUFunctionLibraryCS.BGUGetTarget((AActor)player) != null)
			{
				BUS_EventCollectionCS.Get((AActor)(object)bossActor).Evt_AICatchTarget.Invoke(BGUFunctionLibraryCS.BGUGetTarget((AActor)player), (ETargetSourceType)25, false);
			}
			else
			{
				BGUFunctionLibraryCS.BGUSetTargetInfo(false, (AActor)(object)bossActor, new UnitLockTargetInfo(BGUFunctionLibraryCS.BGUGetTarget((AActor)player), (ETargetSourceType)1, (ELockTargetWayType)1, "", ""));
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

	public static void bs(int bossId, float scale3D)
	{
		if (Tools.bossInfoDic.TryGetValue(bossId, out var value))
		{
			BossInfo = value;
			bossScale3D = scale3D;
		}
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

	public void bsA(int bossId, float scale3D)
	{
		if (Tools.bossInfoDic.TryGetValue(bossId, out var value))
		{
			BossInfo = value;
			bossScale3D = scale3D;
		}
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

	public static void SetBossInfo(Tools.BossInfo Info)
	{
		BossInfo = Info;
	}

	public static AActor GetbossActor()
	{
		return (AActor)(object)bossActor;
	}

	public static void SpawnTransFormBoss()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		BUS_GSEventCollection val = BUS_EventCollectionCS.Get((AActor)player);
		val.Evt_SetBoolProperty.Invoke((EPropType)102, isinTransformState, 0u, 0u, false);
		val.Evt_SetBoolProperty.Invoke((EPropType)302, isinTransformState, 0u, 0u, false);
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
				UClass uClass = BGW_PreloadAssetMgr.Get((UObject)player.World).TryGetCachedResourceObj<UClass>(BossInfo.AssetPath, (ELoadResourceType)1, (EAssetPriority)0, (Action<int, UObject>)null, -1, -1);
				AActor aActor = BGUFunctionLibraryCS.BGUSpawnActor(world, (TSubclassOf<AActor>)uClass, player.GetActorLocation(), player.GetActorRotation());
				boss = (BUTamerActor)(object)((aActor is BUTamerActor) ? aActor : null);
				tamerRef = boss.CurrentRef;
				tamerRef.AddSpawnRuleFlag((ETamerSpawnRule)4);
				tamerRef.ResetLocationCache();
				tamerRef.TamerTransform = player.GetActorTransform();
				FieldInfo field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
				tamerRef.OverrideResetType = (EBGUResetType)3;
				tamerRef.GroupOverrideResetType = (EBGUResetType)3;
				field.SetValue(tamerRef, (object)(ETamerPhase)2);
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
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)player, (EBGUSimpleState)105, !isinTransformState);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)player, (EBGUSimpleState)1, !isinTransformState);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, (EBGUSimpleState)30, false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, (EBGUSimpleState)15, false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, (EBGUSimpleState)102, false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)(object)bossActor, (EBGUSimpleState)135, false);
		APawn controlledPawn = MyUtils.GetControlledPawn();
		BGUPlayerCharacterCS val = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		UGSE_AnimFuncLib.StopAllMontages((AActor)(object)bossActor, 0f);
		ACharacter aCharacter = player as ACharacter;
		aCharacter.CharacterMovement.GravityScale = ((!isinTransformState) ? 4 : 0);
		if ((UObject)(object)val != null)
		{
			val.FollowCamera.FieldOfView = (isinTransformState ? 80 : 65);
		}
		BUS_EventCollectionCS.Get((AActor)player).Evt_EnableCustomFOV.Invoke(true);
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
		BGS_EventCollectionCS.Get((UObject)player.World).Evt_UnregisterTamer.Invoke(boss.CurrentRef);
		boss = null;
		bossActor = null;
		tamerRef = null;
		player.SetActorEnableCollision(bNewActorEnableCollision: true);
		BUS_EventCollectionCS.Get((AActor)player).Evt_SetBoolProperty.Invoke((EPropType)302, false, 0u, 0u, false);
		BGUFunctionLibraryCS.BGUAddBuff((AActor)player, (AActor)player, 699, (EBuffSourceType)1, 100f);
	}

	private static void changeCameraBoom1Component(USceneComponent Mesh)
	{
		APawn controlledPawn = MyUtils.GetControlledPawn();
		BGUPlayerCharacterCS val = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		((USceneComponent)(object)val.CameraBoom1).DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, bCallModify: true);
		((USceneComponent)(object)val.CameraBoom1).AttachToComponent(Mesh, new FName("pelvis"), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: true);
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

	public void StartRun()
	{
		player = MyUtils.GetControlledPawn();
		IsRuning = true;
	}

	public void StopRun()
	{
		IsRuning = false;
	}
}
