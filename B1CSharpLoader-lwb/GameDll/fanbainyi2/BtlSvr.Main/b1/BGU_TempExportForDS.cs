using System;
using b1.BGU.BUActor;
using b1.BGU.BUAnim;
using b1.Plugins.CustomLightSystem;
using b1.UI;
using b1.UI.Comm;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGU_TempExportForDS")]
public class BGU_TempExportForDS : AActor
{
	private static bool BotLifeTimeState_IsValid;

	private static int BotLifeTimeState_Offset;

	private static FFieldAddress BotLifeTimeState_PropertyAddress;

	private static bool BGWTeleportNamedPoint_IsValid;

	private static int BGWTeleportNamedPoint_Offset;

	private static bool ChildActorComponent_IsValid;

	private static int ChildActorComponent_Offset;

	private static bool BANS_GSTimedParticleEffect_IsValid;

	private static int BANS_GSTimedParticleEffect_Offset;

	private static bool BANS_GSEditorHelper_IsValid;

	private static int BANS_GSEditorHelper_Offset;

	private static bool GMTeleportPanel_IsValid;

	private static int GMTeleportPanel_Offset;

	private static bool BUI_GMInfo_Player_IsValid;

	private static int BUI_GMInfo_Player_Offset;

	private static bool BUI_GMInfo_Enemy_IsValid;

	private static int BUI_GMInfo_Enemy_Offset;

	private static bool BGUDebugCircleComponent_IsValid;

	private static int BGUDebugCircleComponent_Offset;

	private static bool BGUPlayerCharacterCS_IsValid;

	private static int BGUPlayerCharacterCS_Offset;

	private static bool BGU_CharacterAI_IsValid;

	private static int BGU_CharacterAI_Offset;

	private static bool BGU_DebugActor_IsValid;

	private static int BGU_DebugActor_Offset;

	private static bool BGUBulletBaseManaged_IsValid;

	private static int BGUBulletBaseManaged_Offset;

	private static bool BUAnimHumanoidCS_SpecialMove_IsValid;

	private static int BUAnimHumanoidCS_SpecialMove_Offset;

	private static bool BUAnimHumanoidCS_Move_IsValid;

	private static int BUAnimHumanoidCS_Move_Offset;

	private static bool BUAnimHumanoidCS_Simple4Dir_IsValid;

	private static int BUAnimHumanoidCS_Simple4Dir_Offset;

	private static bool BUAnimHumanoidCS_PlayerLocomotion_IsValid;

	private static int BUAnimHumanoidCS_PlayerLocomotion_Offset;

	private static bool BUAnimHumanoidCS_MotionMatching_IsValid;

	private static int BUAnimHumanoidCS_MotionMatching_Offset;

	private static bool BUAnimHumanoidCS_MonsterLocomotion_IsValid;

	private static int BUAnimHumanoidCS_MonsterLocomotion_Offset;

	private static bool BUAnimHumanoidCS_MMRetarget_IsValid;

	private static int BUAnimHumanoidCS_MMRetarget_Offset;

	private static bool BUAnimHumanoidCS_FlyControl_IsValid;

	private static int BUAnimHumanoidCS_FlyControl_Offset;

	private static bool BGWDataAsset_BeAttackedHitLevelConfig_IsValid;

	private static int BGWDataAsset_BeAttackedHitLevelConfig_Offset;

	private static bool BGWDataAsset_ProjectileSpawnConfig_IsValid;

	private static int BGWDataAsset_ProjectileSpawnConfig_Offset;

	private static bool BGWDataAsset_ScaleTimeSetting_IsValid;

	private static int BGWDataAsset_ScaleTimeSetting_Offset;

	private static bool BGWDataAsset_BuffSetCurveValueToMeshConfig_IsValid;

	private static int BGWDataAsset_BuffSetCurveValueToMeshConfig_Offset;

	private static bool BED_ComboAsset_IsValid;

	private static int BED_ComboAsset_Offset;

	private static bool BED_BehaviorAsset_IsValid;

	private static int BED_BehaviorAsset_Offset;

	private static bool BGWDataAsset_StateLib_IsValid;

	private static int BGWDataAsset_StateLib_Offset;

	private static bool BED_ComboNode_Reroute_IsValid;

	private static int BED_ComboNode_Reroute_Offset;

	private static bool BED_ComboNode_Start_IsValid;

	private static int BED_ComboNode_Start_Offset;

	private static bool BED_BehaviorNode_Start_IsValid;

	private static int BED_BehaviorNode_Start_Offset;

	private static bool BGWBeAtkPhysAnimDataAsset_IsValid;

	private static int BGWBeAtkPhysAnimDataAsset_Offset;

	private static bool BGP_PlayerStateB1_IsValid;

	private static int BGP_PlayerStateB1_Offset;

	private static bool BED_StateNode_Reroute_IsValid;

	private static int BED_StateNode_Reroute_Offset;

	private static bool BED_StateNode_Initial_IsValid;

	private static int BED_StateNode_Initial_Offset;

	private static bool BGP_PlayerControllerB1_IsValid;

	private static int BGP_PlayerControllerB1_Offset;

	private static bool BPS_PlayerControllerDataCompB1_IsValid;

	private static int BPS_PlayerControllerDataCompB1_Offset;

	private static bool BUS_AttackFeedbackComp_IsValid;

	private static int BUS_AttackFeedbackComp_Offset;

	private static bool BUI_Button_IsValid;

	private static int BUI_Button_Offset;

	private static bool BUS_MovePhysicsTransformCompImpl_IsValid;

	private static int BUS_MovePhysicsTransformCompImpl_Offset;

	private static bool BUS_SkillSequenceComp_IsValid;

	private static int BUS_SkillSequenceComp_Offset;

	private static bool BUS_PlayerCameraSystem_IsValid;

	private static int BUS_PlayerCameraSystem_Offset;

	private static bool BGWDataAsset_SweepCheckDebugCollisionInfoConfig_IsValid;

	private static int BGWDataAsset_SweepCheckDebugCollisionInfoConfig_Offset;

	private static bool BUS_PlayerCameraCompUObj_IsValid;

	private static int BUS_PlayerCameraCompUObj_Offset;

	private static bool BANS_GSNvFlow_IsValid;

	private static int BANS_GSNvFlow_Offset;

	private static bool BANS_GSTrail_IsValid;

	private static int BANS_GSTrail_Offset;

	private static bool BGWDataAsset_PerformerConfig_IsValid;

	private static int BGWDataAsset_PerformerConfig_Offset;

	private static bool DispLibDispWorld_IsValid;

	private static int DispLibDispWorld_Offset;

	private static bool BGUPerformerActor_IsValid;

	private static int BGUPerformerActor_Offset;

	private static bool BED_QuestNode_Start_IsValid;

	private static int BED_QuestNode_Start_Offset;

	private static bool CLSManager_IsValid;

	private static int CLSManager_Offset;

	private static bool BED_BehaviorNode_GameDataCounter_IsValid;

	private static int BED_BehaviorNode_GameDataCounter_Offset;

	private static bool BGURebirthPointBase_IsValid;

	private static int BGURebirthPointBase_Offset;

	private static bool B1X2_DispWorld_IsValid;

	private static int B1X2_DispWorld_Offset;

	private static bool BUAnimShadowInstanceBase_IsValid;

	private static int BUAnimShadowInstanceBase_Offset;

	private static bool RebirthType_IsValid;

	private static int RebirthType_Offset;

	private static FFieldAddress RebirthType_PropertyAddress;

	private static bool IKRigBoneDefinition_IsValid;

	private static int IKRigBoneDefinition_Offset;

	private static bool FEffectInstReq_IsValid;

	private static int FEffectInstReq_Offset;

	private static bool MoveDirectionFive_IsValid;

	private static int MoveDirectionFive_Offset;

	private static FFieldAddress MoveDirectionFive_PropertyAddress;

	private static bool MoveDirection_IsValid;

	private static int MoveDirection_Offset;

	private static FFieldAddress MoveDirection_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BotLifeTimeState")]
	private EBGUBotLifeTimeState BotLifeTimeState
	{
		get
		{
			CheckDestroyed();
			if (!BotLifeTimeState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BotLifeTimeState");
				return EBGUBotLifeTimeState.Idle;
			}
			return EnumMarshaler<EBGUBotLifeTimeState>.FromNative(IntPtr.Add(base.Address, BotLifeTimeState_Offset), 0, BotLifeTimeState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BotLifeTimeState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BotLifeTimeState");
			}
			else
			{
				EnumMarshaler<EBGUBotLifeTimeState>.ToNative(IntPtr.Add(base.Address, BotLifeTimeState_Offset), 0, BotLifeTimeState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWTeleportNamedPoint")]
	private TSubclassOf<BGWTeleportNamedPoint> BGWTeleportNamedPoint
	{
		get
		{
			CheckDestroyed();
			if (!BGWTeleportNamedPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWTeleportNamedPoint");
				return default(TSubclassOf<BGWTeleportNamedPoint>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUActor.BGWTeleportNamedPoint>.FromNative(IntPtr.Add(base.Address, BGWTeleportNamedPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWTeleportNamedPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWTeleportNamedPoint");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUActor.BGWTeleportNamedPoint>.ToNative(IntPtr.Add(base.Address, BGWTeleportNamedPoint_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:ChildActorComponent")]
	private TSubclassOf<UChildActorComponent> ChildActorComponent
	{
		get
		{
			CheckDestroyed();
			if (!ChildActorComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:ChildActorComponent");
				return default(TSubclassOf<UChildActorComponent>);
			}
			return TSubclassOfMarshaler<UChildActorComponent>.FromNative(IntPtr.Add(base.Address, ChildActorComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChildActorComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:ChildActorComponent");
			}
			else
			{
				TSubclassOfMarshaler<UChildActorComponent>.ToNative(IntPtr.Add(base.Address, ChildActorComponent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSTimedParticleEffect")]
	private TSubclassOf<b1.BANS_GSTimedParticleEffect> BANS_GSTimedParticleEffect
	{
		get
		{
			CheckDestroyed();
			if (!BANS_GSTimedParticleEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSTimedParticleEffect");
				return default(TSubclassOf<b1.BANS_GSTimedParticleEffect>);
			}
			return TSubclassOfMarshaler<b1.BANS_GSTimedParticleEffect>.FromNative(IntPtr.Add(base.Address, BANS_GSTimedParticleEffect_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BANS_GSTimedParticleEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSTimedParticleEffect");
			}
			else
			{
				TSubclassOfMarshaler<b1.BANS_GSTimedParticleEffect>.ToNative(IntPtr.Add(base.Address, BANS_GSTimedParticleEffect_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSEditorHelper")]
	private TSubclassOf<b1.BANS_GSEditorHelper> BANS_GSEditorHelper
	{
		get
		{
			CheckDestroyed();
			if (!BANS_GSEditorHelper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSEditorHelper");
				return default(TSubclassOf<b1.BANS_GSEditorHelper>);
			}
			return TSubclassOfMarshaler<b1.BANS_GSEditorHelper>.FromNative(IntPtr.Add(base.Address, BANS_GSEditorHelper_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BANS_GSEditorHelper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSEditorHelper");
			}
			else
			{
				TSubclassOfMarshaler<b1.BANS_GSEditorHelper>.ToNative(IntPtr.Add(base.Address, BANS_GSEditorHelper_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:GMTeleportPanel")]
	private TSubclassOf<b1.UI.BUI_GMTeleportPanel> GMTeleportPanel
	{
		get
		{
			CheckDestroyed();
			if (!GMTeleportPanel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:GMTeleportPanel");
				return default(TSubclassOf<b1.UI.BUI_GMTeleportPanel>);
			}
			return TSubclassOfMarshaler<b1.UI.BUI_GMTeleportPanel>.FromNative(IntPtr.Add(base.Address, GMTeleportPanel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GMTeleportPanel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:GMTeleportPanel");
			}
			else
			{
				TSubclassOfMarshaler<b1.UI.BUI_GMTeleportPanel>.ToNative(IntPtr.Add(base.Address, GMTeleportPanel_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUI_GMInfo_Player")]
	private TSubclassOf<b1.UI.BUI_GMInfo_Player> BUI_GMInfo_Player
	{
		get
		{
			CheckDestroyed();
			if (!BUI_GMInfo_Player_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUI_GMInfo_Player");
				return default(TSubclassOf<b1.UI.BUI_GMInfo_Player>);
			}
			return TSubclassOfMarshaler<b1.UI.BUI_GMInfo_Player>.FromNative(IntPtr.Add(base.Address, BUI_GMInfo_Player_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUI_GMInfo_Player_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUI_GMInfo_Player");
			}
			else
			{
				TSubclassOfMarshaler<b1.UI.BUI_GMInfo_Player>.ToNative(IntPtr.Add(base.Address, BUI_GMInfo_Player_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUI_GMInfo_Enemy")]
	private TSubclassOf<b1.UI.BUI_GMInfo_Enemy> BUI_GMInfo_Enemy
	{
		get
		{
			CheckDestroyed();
			if (!BUI_GMInfo_Enemy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUI_GMInfo_Enemy");
				return default(TSubclassOf<b1.UI.BUI_GMInfo_Enemy>);
			}
			return TSubclassOfMarshaler<b1.UI.BUI_GMInfo_Enemy>.FromNative(IntPtr.Add(base.Address, BUI_GMInfo_Enemy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUI_GMInfo_Enemy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUI_GMInfo_Enemy");
			}
			else
			{
				TSubclassOfMarshaler<b1.UI.BUI_GMInfo_Enemy>.ToNative(IntPtr.Add(base.Address, BUI_GMInfo_Enemy_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGUDebugCircleComponent")]
	private TSubclassOf<UBGUDebugCircleComponent> BGUDebugCircleComponent
	{
		get
		{
			CheckDestroyed();
			if (!BGUDebugCircleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUDebugCircleComponent");
				return default(TSubclassOf<UBGUDebugCircleComponent>);
			}
			return TSubclassOfMarshaler<UBGUDebugCircleComponent>.FromNative(IntPtr.Add(base.Address, BGUDebugCircleComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGUDebugCircleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUDebugCircleComponent");
			}
			else
			{
				TSubclassOfMarshaler<UBGUDebugCircleComponent>.ToNative(IntPtr.Add(base.Address, BGUDebugCircleComponent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGUPlayerCharacterCS")]
	private TSubclassOf<BGUPlayerCharacterCS> BGUPlayerCharacterCS
	{
		get
		{
			CheckDestroyed();
			if (!BGUPlayerCharacterCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUPlayerCharacterCS");
				return default(TSubclassOf<BGUPlayerCharacterCS>);
			}
			return TSubclassOfMarshaler<b1.BGUPlayerCharacterCS>.FromNative(IntPtr.Add(base.Address, BGUPlayerCharacterCS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGUPlayerCharacterCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUPlayerCharacterCS");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGUPlayerCharacterCS>.ToNative(IntPtr.Add(base.Address, BGUPlayerCharacterCS_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGU_CharacterAI")]
	private TSubclassOf<BGU_CharacterAI> BGU_CharacterAI
	{
		get
		{
			CheckDestroyed();
			if (!BGU_CharacterAI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGU_CharacterAI");
				return default(TSubclassOf<BGU_CharacterAI>);
			}
			return TSubclassOfMarshaler<b1.BGU_CharacterAI>.FromNative(IntPtr.Add(base.Address, BGU_CharacterAI_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGU_CharacterAI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGU_CharacterAI");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU_CharacterAI>.ToNative(IntPtr.Add(base.Address, BGU_CharacterAI_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGU_DebugActor")]
	private TSubclassOf<BGU_DebugActor> BGU_DebugActor
	{
		get
		{
			CheckDestroyed();
			if (!BGU_DebugActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGU_DebugActor");
				return default(TSubclassOf<BGU_DebugActor>);
			}
			return TSubclassOfMarshaler<b1.BGU_DebugActor>.FromNative(IntPtr.Add(base.Address, BGU_DebugActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGU_DebugActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGU_DebugActor");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU_DebugActor>.ToNative(IntPtr.Add(base.Address, BGU_DebugActor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGUBulletBaseManaged")]
	private TSubclassOf<BGUBulletBaseManaged> BGUBulletBaseManaged
	{
		get
		{
			CheckDestroyed();
			if (!BGUBulletBaseManaged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUBulletBaseManaged");
				return default(TSubclassOf<BGUBulletBaseManaged>);
			}
			return TSubclassOfMarshaler<b1.BGUBulletBaseManaged>.FromNative(IntPtr.Add(base.Address, BGUBulletBaseManaged_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGUBulletBaseManaged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUBulletBaseManaged");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGUBulletBaseManaged>.ToNative(IntPtr.Add(base.Address, BGUBulletBaseManaged_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_SpecialMove")]
	private TSubclassOf<BUAnimHumanoidCS_SpecialMove> BUAnimHumanoidCS_SpecialMove
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_SpecialMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_SpecialMove");
				return default(TSubclassOf<BUAnimHumanoidCS_SpecialMove>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_SpecialMove>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_SpecialMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_SpecialMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_SpecialMove");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_SpecialMove>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_SpecialMove_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_Move")]
	private TSubclassOf<BUAnimHumanoidCS_Move> BUAnimHumanoidCS_Move
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_Move_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_Move");
				return default(TSubclassOf<BUAnimHumanoidCS_Move>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_Move>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_Move_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_Move_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_Move");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_Move>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_Move_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_Simple4Dir")]
	private TSubclassOf<BUAnimHumanoidCS_Simple4Dir> BUAnimHumanoidCS_Simple4Dir
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_Simple4Dir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_Simple4Dir");
				return default(TSubclassOf<BUAnimHumanoidCS_Simple4Dir>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_Simple4Dir>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_Simple4Dir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_Simple4Dir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_Simple4Dir");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_Simple4Dir>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_Simple4Dir_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_PlayerLocomotion")]
	private TSubclassOf<BUAnimHumanoidCS_PlayerLocomotion> BUAnimHumanoidCS_PlayerLocomotion
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_PlayerLocomotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_PlayerLocomotion");
				return default(TSubclassOf<BUAnimHumanoidCS_PlayerLocomotion>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_PlayerLocomotion>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_PlayerLocomotion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_PlayerLocomotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_PlayerLocomotion");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_PlayerLocomotion>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_PlayerLocomotion_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MotionMatching")]
	private TSubclassOf<BUAnimHumanoidCS_MotionMatching> BUAnimHumanoidCS_MotionMatching
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_MotionMatching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MotionMatching");
				return default(TSubclassOf<BUAnimHumanoidCS_MotionMatching>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_MotionMatching>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_MotionMatching_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_MotionMatching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MotionMatching");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_MotionMatching>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_MotionMatching_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MonsterLocomotion")]
	private TSubclassOf<BUAnimHumanoidCS_MonsterLocomotion> BUAnimHumanoidCS_MonsterLocomotion
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_MonsterLocomotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MonsterLocomotion");
				return default(TSubclassOf<BUAnimHumanoidCS_MonsterLocomotion>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_MonsterLocomotion>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_MonsterLocomotion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_MonsterLocomotion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MonsterLocomotion");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_MonsterLocomotion>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_MonsterLocomotion_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MMRetarget")]
	private TSubclassOf<BUAnimHumanoidCS_MMRetarget> BUAnimHumanoidCS_MMRetarget
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_MMRetarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MMRetarget");
				return default(TSubclassOf<BUAnimHumanoidCS_MMRetarget>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_MMRetarget>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_MMRetarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_MMRetarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_MMRetarget");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_MMRetarget>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_MMRetarget_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_FlyControl")]
	private TSubclassOf<BUAnimHumanoidCS_FlyControl> BUAnimHumanoidCS_FlyControl
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_FlyControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_FlyControl");
				return default(TSubclassOf<BUAnimHumanoidCS_FlyControl>);
			}
			return TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_FlyControl>.FromNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_FlyControl_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimHumanoidCS_FlyControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimHumanoidCS_FlyControl");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGU.BUAnim.BUAnimHumanoidCS_FlyControl>.ToNative(IntPtr.Add(base.Address, BUAnimHumanoidCS_FlyControl_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_BeAttackedHitLevelConfig")]
	private TSubclassOf<BGWDataAsset_BeAttackedHitLevelConfig> BGWDataAsset_BeAttackedHitLevelConfig
	{
		get
		{
			CheckDestroyed();
			if (!BGWDataAsset_BeAttackedHitLevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_BeAttackedHitLevelConfig");
				return default(TSubclassOf<BGWDataAsset_BeAttackedHitLevelConfig>);
			}
			return TSubclassOfMarshaler<b1.BGWDataAsset_BeAttackedHitLevelConfig>.FromNative(IntPtr.Add(base.Address, BGWDataAsset_BeAttackedHitLevelConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWDataAsset_BeAttackedHitLevelConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_BeAttackedHitLevelConfig");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWDataAsset_BeAttackedHitLevelConfig>.ToNative(IntPtr.Add(base.Address, BGWDataAsset_BeAttackedHitLevelConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_ProjectileSpawnConfig")]
	private TSubclassOf<BGWDataAsset_ProjectileSpawnConfig> BGWDataAsset_ProjectileSpawnConfig
	{
		get
		{
			CheckDestroyed();
			if (!BGWDataAsset_ProjectileSpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_ProjectileSpawnConfig");
				return default(TSubclassOf<BGWDataAsset_ProjectileSpawnConfig>);
			}
			return TSubclassOfMarshaler<b1.BGWDataAsset_ProjectileSpawnConfig>.FromNative(IntPtr.Add(base.Address, BGWDataAsset_ProjectileSpawnConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWDataAsset_ProjectileSpawnConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_ProjectileSpawnConfig");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWDataAsset_ProjectileSpawnConfig>.ToNative(IntPtr.Add(base.Address, BGWDataAsset_ProjectileSpawnConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_ScaleTimeSetting")]
	private TSubclassOf<BGWDataAsset_ScaleTimeSetting> BGWDataAsset_ScaleTimeSetting
	{
		get
		{
			CheckDestroyed();
			if (!BGWDataAsset_ScaleTimeSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_ScaleTimeSetting");
				return default(TSubclassOf<BGWDataAsset_ScaleTimeSetting>);
			}
			return TSubclassOfMarshaler<b1.BGWDataAsset_ScaleTimeSetting>.FromNative(IntPtr.Add(base.Address, BGWDataAsset_ScaleTimeSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWDataAsset_ScaleTimeSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_ScaleTimeSetting");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWDataAsset_ScaleTimeSetting>.ToNative(IntPtr.Add(base.Address, BGWDataAsset_ScaleTimeSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_BuffSetCurveValueToMeshConfig")]
	private TSubclassOf<BGWDataAsset_BuffSetCurveValueToMeshConfig> BGWDataAsset_BuffSetCurveValueToMeshConfig
	{
		get
		{
			CheckDestroyed();
			if (!BGWDataAsset_BuffSetCurveValueToMeshConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_BuffSetCurveValueToMeshConfig");
				return default(TSubclassOf<BGWDataAsset_BuffSetCurveValueToMeshConfig>);
			}
			return TSubclassOfMarshaler<b1.BGWDataAsset_BuffSetCurveValueToMeshConfig>.FromNative(IntPtr.Add(base.Address, BGWDataAsset_BuffSetCurveValueToMeshConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWDataAsset_BuffSetCurveValueToMeshConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_BuffSetCurveValueToMeshConfig");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWDataAsset_BuffSetCurveValueToMeshConfig>.ToNative(IntPtr.Add(base.Address, BGWDataAsset_BuffSetCurveValueToMeshConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboAsset")]
	private TSubclassOf<BED_ComboAsset> BED_ComboAsset
	{
		get
		{
			CheckDestroyed();
			if (!BED_ComboAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboAsset");
				return default(TSubclassOf<BED_ComboAsset>);
			}
			return TSubclassOfMarshaler<b1.BED_ComboAsset>.FromNative(IntPtr.Add(base.Address, BED_ComboAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_ComboAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboAsset");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_ComboAsset>.ToNative(IntPtr.Add(base.Address, BED_ComboAsset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorAsset")]
	private TSubclassOf<BED_BehaviorAsset> BED_BehaviorAsset
	{
		get
		{
			CheckDestroyed();
			if (!BED_BehaviorAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorAsset");
				return default(TSubclassOf<BED_BehaviorAsset>);
			}
			return TSubclassOfMarshaler<b1.BED_BehaviorAsset>.FromNative(IntPtr.Add(base.Address, BED_BehaviorAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_BehaviorAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorAsset");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_BehaviorAsset>.ToNative(IntPtr.Add(base.Address, BED_BehaviorAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_StateLib")]
	private TSubclassOf<BGWDataAsset_StateLib> BGWDataAsset_StateLib
	{
		get
		{
			CheckDestroyed();
			if (!BGWDataAsset_StateLib_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_StateLib");
				return default(TSubclassOf<BGWDataAsset_StateLib>);
			}
			return TSubclassOfMarshaler<b1.BGWDataAsset_StateLib>.FromNative(IntPtr.Add(base.Address, BGWDataAsset_StateLib_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWDataAsset_StateLib_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_StateLib");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWDataAsset_StateLib>.ToNative(IntPtr.Add(base.Address, BGWDataAsset_StateLib_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboNode_Reroute")]
	private TSubclassOf<BED_ComboNode_Reroute> BED_ComboNode_Reroute
	{
		get
		{
			CheckDestroyed();
			if (!BED_ComboNode_Reroute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboNode_Reroute");
				return default(TSubclassOf<BED_ComboNode_Reroute>);
			}
			return TSubclassOfMarshaler<b1.BED_ComboNode_Reroute>.FromNative(IntPtr.Add(base.Address, BED_ComboNode_Reroute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_ComboNode_Reroute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboNode_Reroute");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_ComboNode_Reroute>.ToNative(IntPtr.Add(base.Address, BED_ComboNode_Reroute_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboNode_Start")]
	private TSubclassOf<BED_ComboNode_Start> BED_ComboNode_Start
	{
		get
		{
			CheckDestroyed();
			if (!BED_ComboNode_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboNode_Start");
				return default(TSubclassOf<BED_ComboNode_Start>);
			}
			return TSubclassOfMarshaler<b1.BED_ComboNode_Start>.FromNative(IntPtr.Add(base.Address, BED_ComboNode_Start_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_ComboNode_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_ComboNode_Start");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_ComboNode_Start>.ToNative(IntPtr.Add(base.Address, BED_ComboNode_Start_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorNode_Start")]
	private TSubclassOf<b1.BED_BehaviorNode_Start> BED_BehaviorNode_Start
	{
		get
		{
			CheckDestroyed();
			if (!BED_BehaviorNode_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorNode_Start");
				return default(TSubclassOf<b1.BED_BehaviorNode_Start>);
			}
			return TSubclassOfMarshaler<b1.BED_BehaviorNode_Start>.FromNative(IntPtr.Add(base.Address, BED_BehaviorNode_Start_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_BehaviorNode_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorNode_Start");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_BehaviorNode_Start>.ToNative(IntPtr.Add(base.Address, BED_BehaviorNode_Start_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWBeAtkPhysAnimDataAsset")]
	private TSubclassOf<BGWBeAtkPhysAnimDataAsset> BGWBeAtkPhysAnimDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!BGWBeAtkPhysAnimDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWBeAtkPhysAnimDataAsset");
				return default(TSubclassOf<BGWBeAtkPhysAnimDataAsset>);
			}
			return TSubclassOfMarshaler<b1.BGWBeAtkPhysAnimDataAsset>.FromNative(IntPtr.Add(base.Address, BGWBeAtkPhysAnimDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWBeAtkPhysAnimDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWBeAtkPhysAnimDataAsset");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWBeAtkPhysAnimDataAsset>.ToNative(IntPtr.Add(base.Address, BGWBeAtkPhysAnimDataAsset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGP_PlayerStateB1")]
	private TSubclassOf<BGP_PlayerStateB1> BGP_PlayerStateB1
	{
		get
		{
			CheckDestroyed();
			if (!BGP_PlayerStateB1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGP_PlayerStateB1");
				return default(TSubclassOf<BGP_PlayerStateB1>);
			}
			return TSubclassOfMarshaler<b1.BGP_PlayerStateB1>.FromNative(IntPtr.Add(base.Address, BGP_PlayerStateB1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGP_PlayerStateB1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGP_PlayerStateB1");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGP_PlayerStateB1>.ToNative(IntPtr.Add(base.Address, BGP_PlayerStateB1_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_StateNode_Reroute")]
	private TSubclassOf<BED_StateNode_Reroute> BED_StateNode_Reroute
	{
		get
		{
			CheckDestroyed();
			if (!BED_StateNode_Reroute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_StateNode_Reroute");
				return default(TSubclassOf<BED_StateNode_Reroute>);
			}
			return TSubclassOfMarshaler<b1.BED_StateNode_Reroute>.FromNative(IntPtr.Add(base.Address, BED_StateNode_Reroute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_StateNode_Reroute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_StateNode_Reroute");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_StateNode_Reroute>.ToNative(IntPtr.Add(base.Address, BED_StateNode_Reroute_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_StateNode_Initial")]
	private TSubclassOf<BED_StateNode_Initial> BED_StateNode_Initial
	{
		get
		{
			CheckDestroyed();
			if (!BED_StateNode_Initial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_StateNode_Initial");
				return default(TSubclassOf<BED_StateNode_Initial>);
			}
			return TSubclassOfMarshaler<b1.BED_StateNode_Initial>.FromNative(IntPtr.Add(base.Address, BED_StateNode_Initial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_StateNode_Initial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_StateNode_Initial");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_StateNode_Initial>.ToNative(IntPtr.Add(base.Address, BED_StateNode_Initial_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGP_PlayerControllerB1")]
	private TSubclassOf<BGP_PlayerControllerB1> BGP_PlayerControllerB1
	{
		get
		{
			CheckDestroyed();
			if (!BGP_PlayerControllerB1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGP_PlayerControllerB1");
				return default(TSubclassOf<BGP_PlayerControllerB1>);
			}
			return TSubclassOfMarshaler<b1.BGP_PlayerControllerB1>.FromNative(IntPtr.Add(base.Address, BGP_PlayerControllerB1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGP_PlayerControllerB1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGP_PlayerControllerB1");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGP_PlayerControllerB1>.ToNative(IntPtr.Add(base.Address, BGP_PlayerControllerB1_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BPS_PlayerControllerDataCompB1")]
	private TSubclassOf<BPS_PlayerControllerDataCompB1> BPS_PlayerControllerDataCompB1
	{
		get
		{
			CheckDestroyed();
			if (!BPS_PlayerControllerDataCompB1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BPS_PlayerControllerDataCompB1");
				return default(TSubclassOf<BPS_PlayerControllerDataCompB1>);
			}
			return TSubclassOfMarshaler<b1.BPS_PlayerControllerDataCompB1>.FromNative(IntPtr.Add(base.Address, BPS_PlayerControllerDataCompB1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BPS_PlayerControllerDataCompB1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BPS_PlayerControllerDataCompB1");
			}
			else
			{
				TSubclassOfMarshaler<b1.BPS_PlayerControllerDataCompB1>.ToNative(IntPtr.Add(base.Address, BPS_PlayerControllerDataCompB1_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUS_AttackFeedbackComp")]
	private TSubclassOf<BUS_AttackFeedbackComp> BUS_AttackFeedbackComp
	{
		get
		{
			CheckDestroyed();
			if (!BUS_AttackFeedbackComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_AttackFeedbackComp");
				return default(TSubclassOf<BUS_AttackFeedbackComp>);
			}
			return TSubclassOfMarshaler<b1.BUS_AttackFeedbackComp>.FromNative(IntPtr.Add(base.Address, BUS_AttackFeedbackComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUS_AttackFeedbackComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_AttackFeedbackComp");
			}
			else
			{
				TSubclassOfMarshaler<b1.BUS_AttackFeedbackComp>.ToNative(IntPtr.Add(base.Address, BUS_AttackFeedbackComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUI_Button")]
	private TSubclassOf<BUI_Button> BUI_Button
	{
		get
		{
			CheckDestroyed();
			if (!BUI_Button_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUI_Button");
				return default(TSubclassOf<BUI_Button>);
			}
			return TSubclassOfMarshaler<b1.UI.Comm.BUI_Button>.FromNative(IntPtr.Add(base.Address, BUI_Button_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUI_Button_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUI_Button");
			}
			else
			{
				TSubclassOfMarshaler<b1.UI.Comm.BUI_Button>.ToNative(IntPtr.Add(base.Address, BUI_Button_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUS_MovePhysicsTransformCompImpl")]
	private TSubclassOf<BUS_MovePhysicsTransformCompImpl> BUS_MovePhysicsTransformCompImpl
	{
		get
		{
			CheckDestroyed();
			if (!BUS_MovePhysicsTransformCompImpl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_MovePhysicsTransformCompImpl");
				return default(TSubclassOf<BUS_MovePhysicsTransformCompImpl>);
			}
			return TSubclassOfMarshaler<b1.BUS_MovePhysicsTransformCompImpl>.FromNative(IntPtr.Add(base.Address, BUS_MovePhysicsTransformCompImpl_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUS_MovePhysicsTransformCompImpl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_MovePhysicsTransformCompImpl");
			}
			else
			{
				TSubclassOfMarshaler<b1.BUS_MovePhysicsTransformCompImpl>.ToNative(IntPtr.Add(base.Address, BUS_MovePhysicsTransformCompImpl_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUS_SkillSequenceComp")]
	private TSubclassOf<BUS_SkillSequenceComp> BUS_SkillSequenceComp
	{
		get
		{
			CheckDestroyed();
			if (!BUS_SkillSequenceComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_SkillSequenceComp");
				return default(TSubclassOf<BUS_SkillSequenceComp>);
			}
			return TSubclassOfMarshaler<b1.BUS_SkillSequenceComp>.FromNative(IntPtr.Add(base.Address, BUS_SkillSequenceComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUS_SkillSequenceComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_SkillSequenceComp");
			}
			else
			{
				TSubclassOfMarshaler<b1.BUS_SkillSequenceComp>.ToNative(IntPtr.Add(base.Address, BUS_SkillSequenceComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUS_PlayerCameraSystem")]
	private TSubclassOf<BUS_PlayerCameraSystem> BUS_PlayerCameraSystem
	{
		get
		{
			CheckDestroyed();
			if (!BUS_PlayerCameraSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_PlayerCameraSystem");
				return default(TSubclassOf<BUS_PlayerCameraSystem>);
			}
			return TSubclassOfMarshaler<b1.BUS_PlayerCameraSystem>.FromNative(IntPtr.Add(base.Address, BUS_PlayerCameraSystem_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUS_PlayerCameraSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_PlayerCameraSystem");
			}
			else
			{
				TSubclassOfMarshaler<b1.BUS_PlayerCameraSystem>.ToNative(IntPtr.Add(base.Address, BUS_PlayerCameraSystem_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_SweepCheckDebugCollisionInfoConfig")]
	private TSubclassOf<BGWDataAsset_SweepCheckDebugCollisionInfoConfig> BGWDataAsset_SweepCheckDebugCollisionInfoConfig
	{
		get
		{
			CheckDestroyed();
			if (!BGWDataAsset_SweepCheckDebugCollisionInfoConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_SweepCheckDebugCollisionInfoConfig");
				return default(TSubclassOf<BGWDataAsset_SweepCheckDebugCollisionInfoConfig>);
			}
			return TSubclassOfMarshaler<b1.BGWDataAsset_SweepCheckDebugCollisionInfoConfig>.FromNative(IntPtr.Add(base.Address, BGWDataAsset_SweepCheckDebugCollisionInfoConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWDataAsset_SweepCheckDebugCollisionInfoConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_SweepCheckDebugCollisionInfoConfig");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWDataAsset_SweepCheckDebugCollisionInfoConfig>.ToNative(IntPtr.Add(base.Address, BGWDataAsset_SweepCheckDebugCollisionInfoConfig_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUS_PlayerCameraCompUObj")]
	private TSubclassOf<BUS_PlayerCameraCompUObj> BUS_PlayerCameraCompUObj
	{
		get
		{
			CheckDestroyed();
			if (!BUS_PlayerCameraCompUObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_PlayerCameraCompUObj");
				return default(TSubclassOf<BUS_PlayerCameraCompUObj>);
			}
			return TSubclassOfMarshaler<b1.BUS_PlayerCameraCompUObj>.FromNative(IntPtr.Add(base.Address, BUS_PlayerCameraCompUObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUS_PlayerCameraCompUObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUS_PlayerCameraCompUObj");
			}
			else
			{
				TSubclassOfMarshaler<b1.BUS_PlayerCameraCompUObj>.ToNative(IntPtr.Add(base.Address, BUS_PlayerCameraCompUObj_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSNvFlow")]
	private TSubclassOf<b1.BANS_GSNvFlow> BANS_GSNvFlow
	{
		get
		{
			CheckDestroyed();
			if (!BANS_GSNvFlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSNvFlow");
				return default(TSubclassOf<b1.BANS_GSNvFlow>);
			}
			return TSubclassOfMarshaler<b1.BANS_GSNvFlow>.FromNative(IntPtr.Add(base.Address, BANS_GSNvFlow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BANS_GSNvFlow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSNvFlow");
			}
			else
			{
				TSubclassOfMarshaler<b1.BANS_GSNvFlow>.ToNative(IntPtr.Add(base.Address, BANS_GSNvFlow_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSTrail")]
	private TSubclassOf<b1.BANS_GSTrail> BANS_GSTrail
	{
		get
		{
			CheckDestroyed();
			if (!BANS_GSTrail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSTrail");
				return default(TSubclassOf<b1.BANS_GSTrail>);
			}
			return TSubclassOfMarshaler<b1.BANS_GSTrail>.FromNative(IntPtr.Add(base.Address, BANS_GSTrail_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BANS_GSTrail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BANS_GSTrail");
			}
			else
			{
				TSubclassOfMarshaler<b1.BANS_GSTrail>.ToNative(IntPtr.Add(base.Address, BANS_GSTrail_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_PerformerConfig")]
	private TSubclassOf<BGWDataAsset_PerformerConfig> BGWDataAsset_PerformerConfig
	{
		get
		{
			CheckDestroyed();
			if (!BGWDataAsset_PerformerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_PerformerConfig");
				return default(TSubclassOf<BGWDataAsset_PerformerConfig>);
			}
			return TSubclassOfMarshaler<b1.BGWDataAsset_PerformerConfig>.FromNative(IntPtr.Add(base.Address, BGWDataAsset_PerformerConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGWDataAsset_PerformerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGWDataAsset_PerformerConfig");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGWDataAsset_PerformerConfig>.ToNative(IntPtr.Add(base.Address, BGWDataAsset_PerformerConfig_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:DispLibDispWorld")]
	private TSubclassOf<DispLibDispWorld> DispLibDispWorld
	{
		get
		{
			CheckDestroyed();
			if (!DispLibDispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:DispLibDispWorld");
				return default(TSubclassOf<DispLibDispWorld>);
			}
			return TSubclassOfMarshaler<GSDispLib.DispLibDispWorld>.FromNative(IntPtr.Add(base.Address, DispLibDispWorld_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DispLibDispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:DispLibDispWorld");
			}
			else
			{
				TSubclassOfMarshaler<GSDispLib.DispLibDispWorld>.ToNative(IntPtr.Add(base.Address, DispLibDispWorld_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGUPerformerActor")]
	private TSubclassOf<ABGUPerformerActor> BGUPerformerActor
	{
		get
		{
			CheckDestroyed();
			if (!BGUPerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUPerformerActor");
				return default(TSubclassOf<ABGUPerformerActor>);
			}
			return TSubclassOfMarshaler<ABGUPerformerActor>.FromNative(IntPtr.Add(base.Address, BGUPerformerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGUPerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGUPerformerActor");
			}
			else
			{
				TSubclassOfMarshaler<ABGUPerformerActor>.ToNative(IntPtr.Add(base.Address, BGUPerformerActor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_QuestNode_Start")]
	private TSubclassOf<BED_QuestNode_Start> BED_QuestNode_Start
	{
		get
		{
			CheckDestroyed();
			if (!BED_QuestNode_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_QuestNode_Start");
				return default(TSubclassOf<BED_QuestNode_Start>);
			}
			return TSubclassOfMarshaler<b1.BED_QuestNode_Start>.FromNative(IntPtr.Add(base.Address, BED_QuestNode_Start_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_QuestNode_Start_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_QuestNode_Start");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_QuestNode_Start>.ToNative(IntPtr.Add(base.Address, BED_QuestNode_Start_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:CLSManager")]
	private TSubclassOf<ACLSManager> CLSManager
	{
		get
		{
			CheckDestroyed();
			if (!CLSManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:CLSManager");
				return default(TSubclassOf<ACLSManager>);
			}
			return TSubclassOfMarshaler<ACLSManager>.FromNative(IntPtr.Add(base.Address, CLSManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CLSManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:CLSManager");
			}
			else
			{
				TSubclassOfMarshaler<ACLSManager>.ToNative(IntPtr.Add(base.Address, CLSManager_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorNode_GameDataCounter")]
	private TSubclassOf<b1.BED_BehaviorNode_GameDataCounter> BED_BehaviorNode_GameDataCounter
	{
		get
		{
			CheckDestroyed();
			if (!BED_BehaviorNode_GameDataCounter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorNode_GameDataCounter");
				return default(TSubclassOf<b1.BED_BehaviorNode_GameDataCounter>);
			}
			return TSubclassOfMarshaler<b1.BED_BehaviorNode_GameDataCounter>.FromNative(IntPtr.Add(base.Address, BED_BehaviorNode_GameDataCounter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BED_BehaviorNode_GameDataCounter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BED_BehaviorNode_GameDataCounter");
			}
			else
			{
				TSubclassOfMarshaler<b1.BED_BehaviorNode_GameDataCounter>.ToNative(IntPtr.Add(base.Address, BED_BehaviorNode_GameDataCounter_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BGURebirthPointBase")]
	private TSubclassOf<BGURebirthPointBase> BGURebirthPointBase
	{
		get
		{
			CheckDestroyed();
			if (!BGURebirthPointBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGURebirthPointBase");
				return default(TSubclassOf<BGURebirthPointBase>);
			}
			return TSubclassOfMarshaler<b1.BGURebirthPointBase>.FromNative(IntPtr.Add(base.Address, BGURebirthPointBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGURebirthPointBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BGURebirthPointBase");
			}
			else
			{
				TSubclassOfMarshaler<b1.BGURebirthPointBase>.ToNative(IntPtr.Add(base.Address, BGURebirthPointBase_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:B1X2_DispWorld")]
	private TSubclassOf<B1X2_DispWorld> B1X2_DispWorld
	{
		get
		{
			CheckDestroyed();
			if (!B1X2_DispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:B1X2_DispWorld");
				return default(TSubclassOf<B1X2_DispWorld>);
			}
			return TSubclassOfMarshaler<b1.B1X2_DispWorld>.FromNative(IntPtr.Add(base.Address, B1X2_DispWorld_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!B1X2_DispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:B1X2_DispWorld");
			}
			else
			{
				TSubclassOfMarshaler<b1.B1X2_DispWorld>.ToNative(IntPtr.Add(base.Address, B1X2_DispWorld_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:BUAnimShadowInstanceBase")]
	private TSubclassOf<BUAnimShadowInstanceBase> BUAnimShadowInstanceBase
	{
		get
		{
			CheckDestroyed();
			if (!BUAnimShadowInstanceBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimShadowInstanceBase");
				return default(TSubclassOf<BUAnimShadowInstanceBase>);
			}
			return TSubclassOfMarshaler<b1.BUAnimShadowInstanceBase>.FromNative(IntPtr.Add(base.Address, BUAnimShadowInstanceBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BUAnimShadowInstanceBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:BUAnimShadowInstanceBase");
			}
			else
			{
				TSubclassOfMarshaler<b1.BUAnimShadowInstanceBase>.ToNative(IntPtr.Add(base.Address, BUAnimShadowInstanceBase_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:RebirthType")]
	private ERebirthType RebirthType
	{
		get
		{
			CheckDestroyed();
			if (!RebirthType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:RebirthType");
				return ERebirthType.RebirthPoint;
			}
			return EnumMarshaler<ERebirthType>.FromNative(IntPtr.Add(base.Address, RebirthType_Offset), 0, RebirthType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RebirthType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:RebirthType");
			}
			else
			{
				EnumMarshaler<ERebirthType>.ToNative(IntPtr.Add(base.Address, RebirthType_Offset), 0, RebirthType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:IKRigBoneDefinition")]
	private IKRigBoneDefinition IKRigBoneDefinition
	{
		get
		{
			CheckDestroyed();
			if (!IKRigBoneDefinition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:IKRigBoneDefinition");
				return default(IKRigBoneDefinition);
			}
			return BlittableTypeMarshaler<IKRigBoneDefinition>.FromNative(IntPtr.Add(base.Address, IKRigBoneDefinition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IKRigBoneDefinition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:IKRigBoneDefinition");
			}
			else
			{
				BlittableTypeMarshaler<IKRigBoneDefinition>.ToNative(IntPtr.Add(base.Address, IKRigBoneDefinition_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:FEffectInstReq")]
	private FEffectInstReq FEffectInstReq
	{
		get
		{
			CheckDestroyed();
			if (!FEffectInstReq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:FEffectInstReq");
				return default(FEffectInstReq);
			}
			return FEffectInstReq.FromNative(IntPtr.Add(base.Address, FEffectInstReq_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FEffectInstReq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:FEffectInstReq");
			}
			else
			{
				FEffectInstReq.ToNative(IntPtr.Add(base.Address, FEffectInstReq_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:MoveDirectionFive")]
	private EMoveDirectionFive MoveDirectionFive
	{
		get
		{
			CheckDestroyed();
			if (!MoveDirectionFive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:MoveDirectionFive");
				return EMoveDirectionFive.None;
			}
			return EnumMarshaler<EMoveDirectionFive>.FromNative(IntPtr.Add(base.Address, MoveDirectionFive_Offset), 0, MoveDirectionFive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveDirectionFive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:MoveDirectionFive");
			}
			else
			{
				EnumMarshaler<EMoveDirectionFive>.ToNative(IntPtr.Add(base.Address, MoveDirectionFive_Offset), 0, MoveDirectionFive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:MoveDirection")]
	private EMoveDirection MoveDirection
	{
		get
		{
			CheckDestroyed();
			if (!MoveDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:MoveDirection");
				return EMoveDirection.None;
			}
			return EnumMarshaler<EMoveDirection>.FromNative(IntPtr.Add(base.Address, MoveDirection_Offset), 0, MoveDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_TempExportForDS:MoveDirection");
			}
			else
			{
				EnumMarshaler<EMoveDirection>.ToNative(IntPtr.Add(base.Address, MoveDirection_Offset), 0, MoveDirection_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGU_TempExportForDS:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_TempExportForDS:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_TempExportForDS bGU_TempExportForDS = GCHelper.Find<BGU_TempExportForDS>(obj);
		bGU_TempExportForDS.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGU_TempExportForDS");
		NativeReflection.GetPropertyRef(ref BotLifeTimeState_PropertyAddress, intPtr, "BotLifeTimeState");
		BotLifeTimeState_Offset = NativeReflection.GetPropertyOffset(intPtr, "BotLifeTimeState");
		BotLifeTimeState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BotLifeTimeState", Classes.FEnumProperty);
		BGWTeleportNamedPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWTeleportNamedPoint");
		BGWTeleportNamedPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWTeleportNamedPoint", Classes.FClassProperty);
		ChildActorComponent_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChildActorComponent");
		ChildActorComponent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChildActorComponent", Classes.FClassProperty);
		BANS_GSTimedParticleEffect_Offset = NativeReflection.GetPropertyOffset(intPtr, "BANS_GSTimedParticleEffect");
		BANS_GSTimedParticleEffect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BANS_GSTimedParticleEffect", Classes.FClassProperty);
		BANS_GSEditorHelper_Offset = NativeReflection.GetPropertyOffset(intPtr, "BANS_GSEditorHelper");
		BANS_GSEditorHelper_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BANS_GSEditorHelper", Classes.FClassProperty);
		GMTeleportPanel_Offset = NativeReflection.GetPropertyOffset(intPtr, "GMTeleportPanel");
		GMTeleportPanel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GMTeleportPanel", Classes.FClassProperty);
		BUI_GMInfo_Player_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUI_GMInfo_Player");
		BUI_GMInfo_Player_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUI_GMInfo_Player", Classes.FClassProperty);
		BUI_GMInfo_Enemy_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUI_GMInfo_Enemy");
		BUI_GMInfo_Enemy_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUI_GMInfo_Enemy", Classes.FClassProperty);
		BGUDebugCircleComponent_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGUDebugCircleComponent");
		BGUDebugCircleComponent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGUDebugCircleComponent", Classes.FClassProperty);
		BGUPlayerCharacterCS_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGUPlayerCharacterCS");
		BGUPlayerCharacterCS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGUPlayerCharacterCS", Classes.FClassProperty);
		BGU_CharacterAI_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGU_CharacterAI");
		BGU_CharacterAI_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGU_CharacterAI", Classes.FClassProperty);
		BGU_DebugActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGU_DebugActor");
		BGU_DebugActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGU_DebugActor", Classes.FClassProperty);
		BGUBulletBaseManaged_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGUBulletBaseManaged");
		BGUBulletBaseManaged_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGUBulletBaseManaged", Classes.FClassProperty);
		BUAnimHumanoidCS_SpecialMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_SpecialMove");
		BUAnimHumanoidCS_SpecialMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_SpecialMove", Classes.FClassProperty);
		BUAnimHumanoidCS_Move_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_Move");
		BUAnimHumanoidCS_Move_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_Move", Classes.FClassProperty);
		BUAnimHumanoidCS_Simple4Dir_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_Simple4Dir");
		BUAnimHumanoidCS_Simple4Dir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_Simple4Dir", Classes.FClassProperty);
		BUAnimHumanoidCS_PlayerLocomotion_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_PlayerLocomotion");
		BUAnimHumanoidCS_PlayerLocomotion_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_PlayerLocomotion", Classes.FClassProperty);
		BUAnimHumanoidCS_MotionMatching_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_MotionMatching");
		BUAnimHumanoidCS_MotionMatching_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_MotionMatching", Classes.FClassProperty);
		BUAnimHumanoidCS_MonsterLocomotion_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_MonsterLocomotion");
		BUAnimHumanoidCS_MonsterLocomotion_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_MonsterLocomotion", Classes.FClassProperty);
		BUAnimHumanoidCS_MMRetarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_MMRetarget");
		BUAnimHumanoidCS_MMRetarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_MMRetarget", Classes.FClassProperty);
		BUAnimHumanoidCS_FlyControl_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimHumanoidCS_FlyControl");
		BUAnimHumanoidCS_FlyControl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimHumanoidCS_FlyControl", Classes.FClassProperty);
		BGWDataAsset_BeAttackedHitLevelConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWDataAsset_BeAttackedHitLevelConfig");
		BGWDataAsset_BeAttackedHitLevelConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWDataAsset_BeAttackedHitLevelConfig", Classes.FClassProperty);
		BGWDataAsset_ProjectileSpawnConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWDataAsset_ProjectileSpawnConfig");
		BGWDataAsset_ProjectileSpawnConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWDataAsset_ProjectileSpawnConfig", Classes.FClassProperty);
		BGWDataAsset_ScaleTimeSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWDataAsset_ScaleTimeSetting");
		BGWDataAsset_ScaleTimeSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWDataAsset_ScaleTimeSetting", Classes.FClassProperty);
		BGWDataAsset_BuffSetCurveValueToMeshConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWDataAsset_BuffSetCurveValueToMeshConfig");
		BGWDataAsset_BuffSetCurveValueToMeshConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWDataAsset_BuffSetCurveValueToMeshConfig", Classes.FClassProperty);
		BED_ComboAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_ComboAsset");
		BED_ComboAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_ComboAsset", Classes.FClassProperty);
		BED_BehaviorAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_BehaviorAsset");
		BED_BehaviorAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_BehaviorAsset", Classes.FClassProperty);
		BGWDataAsset_StateLib_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWDataAsset_StateLib");
		BGWDataAsset_StateLib_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWDataAsset_StateLib", Classes.FClassProperty);
		BED_ComboNode_Reroute_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_ComboNode_Reroute");
		BED_ComboNode_Reroute_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_ComboNode_Reroute", Classes.FClassProperty);
		BED_ComboNode_Start_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_ComboNode_Start");
		BED_ComboNode_Start_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_ComboNode_Start", Classes.FClassProperty);
		BED_BehaviorNode_Start_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_BehaviorNode_Start");
		BED_BehaviorNode_Start_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_BehaviorNode_Start", Classes.FClassProperty);
		BGWBeAtkPhysAnimDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWBeAtkPhysAnimDataAsset");
		BGWBeAtkPhysAnimDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWBeAtkPhysAnimDataAsset", Classes.FClassProperty);
		BGP_PlayerStateB1_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGP_PlayerStateB1");
		BGP_PlayerStateB1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGP_PlayerStateB1", Classes.FClassProperty);
		BED_StateNode_Reroute_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_StateNode_Reroute");
		BED_StateNode_Reroute_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_StateNode_Reroute", Classes.FClassProperty);
		BED_StateNode_Initial_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_StateNode_Initial");
		BED_StateNode_Initial_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_StateNode_Initial", Classes.FClassProperty);
		BGP_PlayerControllerB1_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGP_PlayerControllerB1");
		BGP_PlayerControllerB1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGP_PlayerControllerB1", Classes.FClassProperty);
		BPS_PlayerControllerDataCompB1_Offset = NativeReflection.GetPropertyOffset(intPtr, "BPS_PlayerControllerDataCompB1");
		BPS_PlayerControllerDataCompB1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BPS_PlayerControllerDataCompB1", Classes.FClassProperty);
		BUS_AttackFeedbackComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUS_AttackFeedbackComp");
		BUS_AttackFeedbackComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUS_AttackFeedbackComp", Classes.FClassProperty);
		BUI_Button_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUI_Button");
		BUI_Button_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUI_Button", Classes.FClassProperty);
		BUS_MovePhysicsTransformCompImpl_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUS_MovePhysicsTransformCompImpl");
		BUS_MovePhysicsTransformCompImpl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUS_MovePhysicsTransformCompImpl", Classes.FClassProperty);
		BUS_SkillSequenceComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUS_SkillSequenceComp");
		BUS_SkillSequenceComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUS_SkillSequenceComp", Classes.FClassProperty);
		BUS_PlayerCameraSystem_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUS_PlayerCameraSystem");
		BUS_PlayerCameraSystem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUS_PlayerCameraSystem", Classes.FClassProperty);
		BGWDataAsset_SweepCheckDebugCollisionInfoConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWDataAsset_SweepCheckDebugCollisionInfoConfig");
		BGWDataAsset_SweepCheckDebugCollisionInfoConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWDataAsset_SweepCheckDebugCollisionInfoConfig", Classes.FClassProperty);
		BUS_PlayerCameraCompUObj_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUS_PlayerCameraCompUObj");
		BUS_PlayerCameraCompUObj_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUS_PlayerCameraCompUObj", Classes.FClassProperty);
		BANS_GSNvFlow_Offset = NativeReflection.GetPropertyOffset(intPtr, "BANS_GSNvFlow");
		BANS_GSNvFlow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BANS_GSNvFlow", Classes.FClassProperty);
		BANS_GSTrail_Offset = NativeReflection.GetPropertyOffset(intPtr, "BANS_GSTrail");
		BANS_GSTrail_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BANS_GSTrail", Classes.FClassProperty);
		BGWDataAsset_PerformerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGWDataAsset_PerformerConfig");
		BGWDataAsset_PerformerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGWDataAsset_PerformerConfig", Classes.FClassProperty);
		DispLibDispWorld_Offset = NativeReflection.GetPropertyOffset(intPtr, "DispLibDispWorld");
		DispLibDispWorld_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DispLibDispWorld", Classes.FClassProperty);
		BGUPerformerActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGUPerformerActor");
		BGUPerformerActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGUPerformerActor", Classes.FClassProperty);
		BED_QuestNode_Start_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_QuestNode_Start");
		BED_QuestNode_Start_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_QuestNode_Start", Classes.FClassProperty);
		CLSManager_Offset = NativeReflection.GetPropertyOffset(intPtr, "CLSManager");
		CLSManager_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CLSManager", Classes.FClassProperty);
		BED_BehaviorNode_GameDataCounter_Offset = NativeReflection.GetPropertyOffset(intPtr, "BED_BehaviorNode_GameDataCounter");
		BED_BehaviorNode_GameDataCounter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BED_BehaviorNode_GameDataCounter", Classes.FClassProperty);
		BGURebirthPointBase_Offset = NativeReflection.GetPropertyOffset(intPtr, "BGURebirthPointBase");
		BGURebirthPointBase_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BGURebirthPointBase", Classes.FClassProperty);
		B1X2_DispWorld_Offset = NativeReflection.GetPropertyOffset(intPtr, "B1X2_DispWorld");
		B1X2_DispWorld_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "B1X2_DispWorld", Classes.FClassProperty);
		BUAnimShadowInstanceBase_Offset = NativeReflection.GetPropertyOffset(intPtr, "BUAnimShadowInstanceBase");
		BUAnimShadowInstanceBase_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BUAnimShadowInstanceBase", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref RebirthType_PropertyAddress, intPtr, "RebirthType");
		RebirthType_Offset = NativeReflection.GetPropertyOffset(intPtr, "RebirthType");
		RebirthType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RebirthType", Classes.FEnumProperty);
		IKRigBoneDefinition_Offset = NativeReflection.GetPropertyOffset(intPtr, "IKRigBoneDefinition");
		IKRigBoneDefinition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IKRigBoneDefinition", Classes.FStructProperty);
		FEffectInstReq_Offset = NativeReflection.GetPropertyOffset(intPtr, "FEffectInstReq");
		FEffectInstReq_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FEffectInstReq", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref MoveDirectionFive_PropertyAddress, intPtr, "MoveDirectionFive");
		MoveDirectionFive_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveDirectionFive");
		MoveDirectionFive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveDirectionFive", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveDirection_PropertyAddress, intPtr, "MoveDirection");
		MoveDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveDirection");
		MoveDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveDirection", Classes.FEnumProperty);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_TempExportForDS:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGU_TempExportForDS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_TempExportForDS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_TempExportForDS));
	}
}
