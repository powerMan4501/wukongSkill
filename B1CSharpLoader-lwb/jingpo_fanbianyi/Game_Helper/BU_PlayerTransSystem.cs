using System.Collections.Generic;
using b1;
using b1.Plugins.TressFX;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace Game_Helper;

public class BU_PlayerTransSystem : BaseGameHelper
{
	private BUTamerActor bossTamerActor;

	private BGUCharacterCS bossAActor;

	public bool isInTrans = false;

	private bool StartTrans;

	public static bool IsReleasingSkills;

	private int fistSkill = 0;

	private float ActorScale3D;

	public EState_MM eState_MM;

	public static bool IsInit;

	public bool IsRuning { get; set; }

	public void OnInitialize()
	{
	}

	public void OnTick(float DeltTime, int TickGroup)
	{
		if (!IsRuning)
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
			BGUFunctionLibraryCS.BGUAddBuff((AActor)(object)bossAActor, (AActor)(object)bossAActor, 412108, (EBuffSourceType)0, -1f);
			UObject defaultObject = UClass.GetClass<BGWDataAsset_MagicallyChangeConfig>().GetDefaultObject();
			BGWDataAsset_MagicallyChangeConfig val = (BGWDataAsset_MagicallyChangeConfig)(object)((defaultObject is BGWDataAsset_MagicallyChangeConfig) ? defaultObject : null);
			MagicallyChangeConfigA(val, bossTamerActor);
			MyUtils.GetControlledPawn().SetActorScale3D(new FVector(ActorScale3D));
			BGUFunctionLibraryCS.CastMagicallyChangeSkill((AActor)MyUtils.GetControlledPawn(), val, fistSkill, 0);
			SetCamera();
			SkillBossAActor();
		}
		else if ((UObject)(object)bossTamerActor != null && (UObject)(object)bossTamerActor.GetMonster() != null)
		{
			bossAActor = bossTamerActor.GetMonster();
			if ((UObject)(object)bossAActor != null && !((UObject)(object)bossAActor).GetFullName((UObject)null).ToString().Contains("jsds"))
			{
			}
		}
	}

	public void StartRun()
	{
		IsRuning = true;
	}

	public void StopRun()
	{
		IsRuning = false;
	}

	private BUTamerActor SpawnActor(string UClassPath, FVector location)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		APawn controlledPawn = MyUtils.GetControlledPawn();
		UClass uClass = MyUtils.LoadAsset<UClass>(UClassPath);
		BUTamerActor result = null;
		if (uClass != null)
		{
			UObject classDefaultObject = uClass.ClassDefaultObject;
			result = (BUTamerActor)(object)((classDefaultObject is BUTamerActor) ? classDefaultObject : null);
			if ((UObject)(object)result != null)
			{
				FUnitGuidData unitFixedGuid = result.ConfigInfoComp.UnitFixedGuid;
				unitFixedGuid.GameplayTagGuid.TagName = FName.None;
				result.ConfigInfoComp.UnitFixedGuid = unitFixedGuid;
			}
			UWorld world = MyUtils.GetWorld();
			AActor aActor = BGUFunctionLibraryCS.BGUSpawnActor(world, (TSubclassOf<AActor>)uClass, location, new FRotator(0.0, 0.0, 0.0));
			result = (BUTamerActor)(object)((aActor is BUTamerActor) ? aActor : null);
		}
		return result;
	}

	public bool SpawnActor(string UClassPath, int skill, float Scale3D, EState_MM eStateMM)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
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
		APawn controlledPawn = MyUtils.GetControlledPawn();
		BGUPlayerCharacterCS val = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		if ((UObject)(object)val != null)
		{
			BUS_EventCollectionCS.Get((AActor)(object)val).Evt_EnableCustomFOV.Invoke(true);
			val.FollowCamera.FieldOfView = 90f;
			USpringArmComponent component = GetComponent(val);
			component.AttachTo(((ACharacter)(object)val).Mesh, new FName("CAMERA_LOCK"), EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
			component.SetRelativeScale3D(new FVector(1f));
			component.TargetArmLength = 900f;
			component.DoCollisionTest = false;
			component.UsePawnControlRotation = true;
			component.EnableCameraRotationLag = true;
			val.FollowCamera.AttachTo(component, FName.None, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
			val.FollowCamera.SetRelativeLocation(default(FVector), bSweep: false, out var _, bTeleport: true);
		}
	}

	public static void Init()
	{
		if (Tools.BU_PlayerTransSystem != null)
		{
			Tools.BU_PlayerTransSystem.isInTrans = false;
		}
		APawn controlledPawn = MyUtils.GetControlledPawn();
		BGUPlayerCharacterCS val = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
		BUS_EventCollectionCS.Get((AActor)(object)val).Evt_EnableCustomFOV.Invoke(false);
		val.FollowCamera.AttachTo((USceneComponent)(object)val.CameraBoom1, FName.None, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: false);
		UGSE_CharacterFuncLib.SetMontagePlayRate((ACharacter)(object)val, 1f);
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
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
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
		foreach (UActorComponent item2 in monster.GetComponentsByClass(MyUtils.LoadAsset<UClass>("/Script/TressFX.TressFXComponent")))
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
