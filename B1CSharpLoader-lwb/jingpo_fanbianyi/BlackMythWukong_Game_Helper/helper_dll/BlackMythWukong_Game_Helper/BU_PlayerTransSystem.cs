using System;
using System.Collections.Generic;
using System.Reflection;
using b1;
using b1.Plugins.TressFX;
using BtlShare;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

public class BU_PlayerTransSystem : SystemBase
{
	[HarmonyPatch]
	public class Hook_BUS_MagicallyChangeComp_Reset
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("b1.BUS_MagicallyChangeComp:Reset", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static bool Prefix(BUS_MagicallyChangeComp __instance)
		{
			BU_PlayerTransSystem bU_PlayerTransSystem = GlobalObjectMgr.Get<BU_PlayerTransSystem>();
			if (bU_PlayerTransSystem != null)
			{
				if (bU_PlayerTransSystem.isInTrans && !IsInit && __instance.GetOwner() == MyUtils.GetControlledPawn())
				{
					IsReleasingSkills = false;
					return false;
				}
				IsReleasingSkills = false;
				bU_PlayerTransSystem.Init();
				return true;
			}
			return true;
		}
	}

	[HarmonyPatch]
	public class HookBUS_MagicallyChangeComp
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("b1.BUS_MagicallyChangeComp:OnTriggerVigorSkill", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static void Prefix(ref int VigorSkillID)
		{
			Console.WriteLine($"{VigorSkillID}");
		}
	}

	private BUTamerActor bossTamerActor;

	private BGUCharacterCS bossAActor;

	public bool isInTrans = false;

	private bool StartTrans;

	public static bool IsReleasingSkills;

	public static bool IsInit;

	private int fistSkill = 0;

	private float ActorScale3D;

	public EState_MM eState_MM;

	public override void OnAttach()
	{
		SetRun(isRun: true);
	}

	public override void OnTick(float DeltTime, int TickGroup)
	{
		if (!IsRun)
		{
			return;
		}
		if ((UObject)(object)bossAActor != null && StartTrans)
		{
			StartTrans = false;
			if (bossAActor.GetTeamIDInCS() != 1)
			{
				bossAActor.SetTeamIDInCS(1);
			}
			((ACharacter)(object)bossAActor).CharacterMovement.GravityScale = 0f;
			((ACharacter)(object)bossAActor).CharacterMovement.SetMovementMode(EMovementMode.MOVE_Flying, 0);
			((AActor)(object)bossAActor).SetActorHiddenInGame(bNewHidden: true);
			((ACharacter)(object)bossAActor).Mesh.SetVisibility(bNewVisibility: false, bPropagateToChildren: true);
			BGUFunctionLibraryCS.BGUAddBuff((AActor)(object)bossAActor, (AActor)(object)bossAActor, 412108, EBuffSourceType.GM, -1f);
			BGWDataAsset_MagicallyChangeConfig config = UClass.GetClass<BGWDataAsset_MagicallyChangeConfig>().GetDefaultObject() as BGWDataAsset_MagicallyChangeConfig;
			MagicallyChangeConfigA(config, bossTamerActor);
			MyUtils.GetControlledPawn().SetActorScale3D(new FVector(ActorScale3D));
			BGUFunctionLibraryCS.CastMagicallyChangeSkill(MyUtils.GetControlledPawn(), config, fistSkill, 0);
			SetCamera();
			SkillBossAActor();
		}
		else if ((UObject)(object)bossTamerActor != null && (UObject)(object)bossTamerActor.GetMonster() != null)
		{
			bossAActor = bossTamerActor.GetMonster();
		}
	}

	private BUTamerActor SpawnActor(string UClassPath, FVector location)
	{
		APawn controlledPawn = MyUtils.GetControlledPawn();
		UClass uClass = MyUtils.LoadAsset<UClass>(UClassPath);
		BUTamerActor result = null;
		if (uClass != null)
		{
			result = uClass.ClassDefaultObject as BUTamerActor;
			if ((UObject)(object)result != null)
			{
				FUnitGuidData unitFixedGuid = result.ConfigInfoComp.UnitFixedGuid;
				unitFixedGuid.GameplayTagGuid.TagName = FName.None;
				result.ConfigInfoComp.UnitFixedGuid = unitFixedGuid;
			}
			UWorld world = MyUtils.GetWorld();
			result = BGUFunctionLibraryCS.BGUSpawnActor(world, uClass, location, new FRotator(0.0, 0.0, 0.0)) as BUTamerActor;
		}
		return result;
	}

	public bool SpawnActor(string UClassPath, int skill, float Scale3D, EState_MM eStateMM)
	{
		if (IsReleasingSkills)
		{
			return false;
		}
		isInTrans = !isInTrans;
		if (isInTrans)
		{
			IsReleasingSkills = true;
			StartTrans = true;
			fistSkill = skill;
			ActorScale3D = Scale3D;
			eState_MM = eStateMM;
			bossTamerActor = SpawnActor(UClassPath, MyUtils.GetControlledPawn().GetActorLocation() + new FVector(0.0, 0.0, -2000.0));
		}
		else
		{
			IsInit = true;
			Init();
		}
		return true;
	}

	public void SkillBossAActor()
	{
		if ((UObject)(object)bossAActor != null && (UObject)(object)bossTamerActor != null)
		{
			((AActor)(object)bossTamerActor).DestroyActor();
			bossTamerActor = null;
			bossAActor = null;
		}
	}

	private static void SetCamera()
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = MyUtils.GetControlledPawn() as BGUPlayerCharacterCS;
		if ((UObject)(object)bGUPlayerCharacterCS != null)
		{
			BUS_EventCollectionCS.Get((AActor)(object)bGUPlayerCharacterCS).Evt_EnableCustomFOV.Invoke(P1: true);
			bGUPlayerCharacterCS.FollowCamera.FieldOfView = 90f;
			USpringArmComponent component = GetComponent(bGUPlayerCharacterCS);
			component.AttachTo(((ACharacter)(object)bGUPlayerCharacterCS).Mesh, new FName("CAMERA_LOCK"), EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
			component.SetRelativeScale3D(new FVector(1f));
			component.TargetArmLength = 900f;
			component.DoCollisionTest = false;
			component.UsePawnControlRotation = true;
			component.EnableCameraRotationLag = true;
			bGUPlayerCharacterCS.FollowCamera.AttachTo(component, FName.None, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
			bGUPlayerCharacterCS.FollowCamera.SetRelativeLocation(default(FVector), bSweep: false, out var _, bTeleport: true);
		}
	}

	public void Init()
	{
		isInTrans = false;
		BGUPlayerCharacterCS bGUPlayerCharacterCS = MyUtils.GetControlledPawn() as BGUPlayerCharacterCS;
		BUS_EventCollectionCS.Get((AActor)(object)bGUPlayerCharacterCS).Evt_EnableCustomFOV.Invoke(P1: false);
		bGUPlayerCharacterCS.FollowCamera.AttachTo((USceneComponent)(object)bGUPlayerCharacterCS.CameraBoom1, FName.None, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
		UGSE_CharacterFuncLib.SetMontagePlayRate((ACharacter)(object)bGUPlayerCharacterCS, 1f);
		MyUtils.GetControlledPawn().SetActorScale3D(new FVector(1f));
	}

	private static USpringArmComponent GetComponent(BGUPlayerCharacterCS PlayerCharacter)
	{
		foreach (UActorComponent item in ((AActor)(object)PlayerCharacter).GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USpringArmComponent>()))
		{
			if (item != (UObject)(object)PlayerCharacter.CameraBoom1)
			{
				return item as USpringArmComponent;
			}
		}
		return UGSE_ActorFuncLib.AddComponentByClass((AActor)(object)PlayerCharacter, (TSubclassOf<UActorComponent>)UClass.GetClass<USpringArmComponent>(), true, default(FTransform), false) as USpringArmComponent;
	}

	private void MagicallyChangeConfigA(BGWDataAsset_MagicallyChangeConfig config, BUTamerActor bUTamerActor)
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		if (((UObject)(object)config == null) | ((UObject)(object)bUTamerActor == null))
		{
			return;
		}
		config.TamerAssetPath = ((UObject)(object)bUTamerActor).PathName;
		ACharacter monster = (ACharacter)(object)bUTamerActor.GetMonster();
		config.CapsuleHalfHeight = monster.CapsuleComponent.GetUnscaledCapsuleHalfHeight();
		config.CapsuleRadius = monster.CapsuleComponent.GetUnscaledCapsuleRadius();
		config.SKMesh = monster.Mesh.SkeletalMesh;
		config.ABPClass = monster.Mesh.AnimClass;
		USkeletalMesh sKMesh = config.SKMesh;
		config.PhysicsAsset = ((sKMesh != null) ? sKMesh.PhysicsAsset : null);
		config.TFXConfig.Clear();
		foreach (UActorComponent item2 in ((AActor)monster).GetComponentsByClass((TSubclassOf<UActorComponent>)MyUtils.LoadAsset<UClass>("/Script/TressFX.TressFXComponent")))
		{
			UTressFXComponent val = (UTressFXComponent)(object)((item2 is UTressFXComponent) ? item2 : null);
			if ((UObject)(object)val != null)
			{
				FMagicallyChangeConfig_TFXConfig item = new FMagicallyChangeConfig_TFXConfig
				{
					TFXAsset = val.Asset,
					HairMaterial = val.HairMaterial,
					ShadeSettings = val.ShadeSettings,
					LodScreenSize = val.LodScreenSize,
					bEnableSimulation = val.EnableSimulation
				};
				config.TFXConfig.Add(item);
			}
		}
		config.Weapons.SetValues(bUTamerActor.ConfigInfoComp.UnitCDesc.Weapons);
		config.InteractBones.Clear();
		foreach (KeyValuePair<FName, FBoneUseForDispMap> item3 in bUTamerActor.ConfigInfoComp.DispInteractBoneMap)
		{
			config.InteractBones.Add(item3.Value);
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bUTamerActor.ConfigInfoComp.UnitCDesc.ResID);
		if (unitCommDesc != null)
		{
			int defaultBattleInfoExtendID = unitCommDesc.DefaultBattleInfoExtendID;
			int overrideID = bUTamerActor.ConfigInfoComp.UnitCDesc.OverrideID;
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((overrideID > 0) ? overrideID : defaultBattleInfoExtendID);
			if (unitBattleInfoExtendDesc != null)
			{
				config.Override_AbnormalDispID_Attacker = unitBattleInfoExtendDesc.AbnormalDispAttackerID;
				config.Override_AbnormalDispID_Victim = unitBattleInfoExtendDesc.AbnormalDispVictimID;
			}
		}
	}
}
