using System;
using BtlShare;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGU_CharacterAI")]
public class BGU_CharacterAI : BGUCharacterCS
{
	private static bool GuidComp_IsValid;

	private static int GuidComp_Offset;

	private static bool ConfigInfoComp_IsValid;

	private static int ConfigInfoComp_Offset;

	private static bool ExtendConfigComp_IsValid;

	private static int ExtendConfigComp_Offset;

	private static bool OnRep_PlayerStateCS_IsValid;

	private static IntPtr OnRep_PlayerStateCS_FunctionAddress;

	private static int OnRep_PlayerStateCS_ParamsSize;

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_CharacterAI:GuidComp")]
	public BUS_GuidComp GuidComp
	{
		get
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_CharacterAI:GuidComp");
				return null;
			}
			return UObjectMarshaler<BUS_GuidComp>.FromNative(IntPtr.Add(base.Address, GuidComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuidComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_CharacterAI:GuidComp");
			}
			else
			{
				UObjectMarshaler<BUS_GuidComp>.ToNative(IntPtr.Add(base.Address, GuidComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_CharacterAI:ConfigInfoComp")]
	public BUS_ConfigInfoComp ConfigInfoComp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_CharacterAI:ConfigInfoComp");
				return null;
			}
			return UObjectMarshaler<BUS_ConfigInfoComp>.FromNative(IntPtr.Add(base.Address, ConfigInfoComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigInfoComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_CharacterAI:ConfigInfoComp");
			}
			else
			{
				UObjectMarshaler<BUS_ConfigInfoComp>.ToNative(IntPtr.Add(base.Address, ConfigInfoComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_CharacterAI:ExtendConfigComp")]
	public BUS_ExtendConfigComp ExtendConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ExtendConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_CharacterAI:ExtendConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ExtendConfigComp>.FromNative(IntPtr.Add(base.Address, ExtendConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtendConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_CharacterAI:ExtendConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ExtendConfigComp>.ToNative(IntPtr.Add(base.Address, ExtendConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ConfigInfoComp = initializer.CreateDefaultSubobject<BUS_ConfigInfoComp>(this, B1GlobalFNames.ConfigInfoComp);
		ConfigInfoComp.bDisableDataConvert = true;
		ExtendConfigComp = initializer.CreateDefaultSubobject<BUS_ExtendConfigComp>(this, B1GlobalFNames.ExtendConfigComp);
		ExtendConfigComp.bDisableDataConvert = true;
		GuidComp = initializer.CreateDefaultSubobject<BUS_GuidComp>(this, B1GlobalFNames.GuidSystem);
	}

	public override void InitAllComp()
	{
		BGW_ECSWorld.Get(this).SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		InitialFromTamer();
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DispLibUnitMaterialsManageComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DispLibDBCManageComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		InitialCacheData();
		bool flag = BGW_GameDB.GetGroupAIDesc(GetResID()) != null;
		base.TeamIDDeprecate = 1;
		base.ActorCompContainerCS.RegisterUnitComp<BUS_UnitStateSystem>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PropMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TickRateLogicComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PauseComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_GuidCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TriggerEffectComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TriggerEffectCompSvr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 144, 1024);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SweepCheckHitComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SaveInitDataCompSimple>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_HardMoveCompImpl>(-2139095040, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_PatrolCompImpl>(8945664, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_EnvironmentInteractionMgrComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_GlideMoveComp>(int.MinValue, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		if (base.ActorCompContainerCS.CheckCanAddComp(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L))
		{
			base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_PlayerMovementSystem>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		else
		{
			base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_MovementSystem>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SpeedCtrlComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_ABPHelperComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_StateLibComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BuffComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_EquipComp>(-2004877312, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TeamIDManageComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BuffDispComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_FootStepCompImpl>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SummonCtrlComp>(-2004844544, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 144, 1024);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_ArmorCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PlayerTransComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PlayerTransOssCollectComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_TransPlayerDataBindComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_TransEnergyComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_AttackFeedbackComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<b1.BUS_DispMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AbnormalHandleComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SkillInstsComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SkillInstsCompSvr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 144, 1024);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_RebirthComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_DistanceCheckComp>(8945664, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_UnitSceneItemComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_ProjectileCtrComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_StaminaComp>(int.MinValue, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AttrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AttrRpcReportComp>(int.MinValue, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PhysicalAnimationComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 1);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BeAttackedComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_WeaponManagerComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		if (flag)
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_GroupAICompImpl>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_IntimidateCompImpl>(557056, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_AIComp>(579371008, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BattleBGMCompImpl>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AICompSvr>(579371008, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128, 4096);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MotionMatchingHelperComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CollisionHitMoveComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_MonsterCheatComp>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_DecalComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AttackFeedbackPerformComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BeAttackedPerformComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MandatoryAITaskComp>(8945664, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_UnitHitVEffectComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MatMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_JumpComp>(int.MinValue, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SkillMappingComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_HairMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		if (base.ActorCompContainerCS.CheckCanAddComp(-2004877312, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L))
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PassiveSkillComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		else if (BGW_GameDB.GetUnitPassiveSkillInfoExtendDesc(GetResID()) != null)
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PassiveSkillComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		if (base.ActorCompContainerCS.CheckCanAddComp(int.MinValue, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L))
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_EnvironmentMaskComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		else if (BGW_GameDB.GetUnitEnvMaskConfigDesc(GetResID()) != null)
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_EnvironmentMaskComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CustomTimeDilationComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 3, 12);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SummonBehaviorComp>(8945664, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MasterComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PartnerComp>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_EscapeComp>(0, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PointSetsComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<b1.BUS_AKMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PhysicsForceComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PriorityActionInitiatorComp>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DashWallComp>(278528, EActorCompAlterFlag.DashWall, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_ModularCtrlComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_MovePhysicsTransformCompImpl>(278528, EActorCompAlterFlag.MovePhysicsTransform, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_FXDetachCompImpl>(278528, EActorCompAlterFlag.FXDetach, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_InteractInfoCollectionComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PartMgrComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CliffFallComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_RootMotionFollowComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AnimationSyncHostComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AnimationSyncGuestComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MontageSectionCtrlComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_RenderTargetMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CollisionProfileMgr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AbnormalStateCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PotentialEnergyCompImpl>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PreciseDodgeComp>(-2004877312, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PhysicalMoveComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_LandingComp>(1145323520, EActorCompAlterFlag.Fly, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_FallingCompl>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 4096);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PhantomRushComp>(-2139095040, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_CharacterModularCompImpl>(-2139095040, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SplineFlyMoveComp>(1145323520, EActorCompAlterFlag.Fly, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_ImpactActionComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_ControllerComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MagicFieldParamComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BarSockComp>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_CheckComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BTCheckComp>(8945664, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_TransitionPhaseComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BehaviorGraphComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 128);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CustomDepthStencilComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_SkillSequenceComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_TalentComp>(-2004877312, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AIConversationCompl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_FacialAnimComp>(1145323520, EActorCompAlterFlag.Facial, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_FlyCtrlCompImpl>(67108864, EActorCompAlterFlag.Fly, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SpecialBoneMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BeImmobilizedComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BattleStateComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BattleAICooperativeCompl>(16384, EActorCompAlterFlag.CoopAI, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_MagicallyChangeComp>(1145323520, EActorCompAlterFlag.MagicallyChange, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_OnlineTamerDebugComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PigsyStoryComp>(1145323520, EActorCompAlterFlag.PigsyStory, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BattleInfoComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DeadComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DataReplicationSystemClient>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, int.MaxValue, 128);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DataReplicationSystemSvr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 132);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_FaBaoManagerComp>(-2139095040, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SuperArmorLevelMappingComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_UnitDestructibleManagerComp>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AINodeComp>(579371008, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AssistantAIComp>(1145323520, EActorCompAlterFlag.AssistantAI, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SimpleOverlapComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_QuestRegCollectionCompBase>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_UnmovableInitializerComp>(1145323520, EActorCompAlterFlag.AlwaysCantMove, (EActorCompRejectFlag)0L);
		if (BGUFuncLibMap.IsPartyLevel(base.World))
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PartyRoomControlComp>(int.MinValue, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 16);
		}
		base.ActorCompContainerCS.RegisterUnitComp<BUS_MonatgeSyncSystemServer>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 128, 4096);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_MonatgeSyncSystemClient>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 1, 4096);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PointLightManagerComp>(1145323520, EActorCompAlterFlag.PointLight, (EActorCompRejectFlag)0L, 16);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AttachedNiagaraMgr>(8945664, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 16);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DetonateComp>(134217728, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 16);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DamageTransferComp>(1145323520, EActorCompAlterFlag.DamageTransfer, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<b1.BUS_FoliageInteractSoundCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc.VigourDropId != 0)
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_VigourDropperComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_JumpToPositionComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_IronBodyComp>(-859553792, EActorCompAlterFlag.IronBody, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SealingSpellComp>(-2004877312, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_CastImmobilizeComp>(-2139095040, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_FsmComp>(579371008, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		if (base.bCanAsPerformer)
		{
			base.ActorCompContainerCS.RegisterUnitComp<BUS_PerformerComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		if (base.bCanAsNPC)
		{
			base.ActorCompContainerCS.RegisterUnitComp<BUS_NPCShowComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
			base.ActorCompContainerCS.RegisterUnitComp<BUS_NPCConfigInfoCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
			base.ActorCompContainerCS.RegisterUnitComp<BUS_NPCAnimComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_PlayerCameraSystem>(-2013265920, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, int.MaxValue, 2048);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PreloadLogicComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_GlobalFXSystem>(16384, EActorCompAlterFlag.GlobalFX, (EActorCompRejectFlag)0L);
		if (DebugConfig.DebugWidget)
		{
			base.ActorCompContainerCS.AddComp(new BUS_DebugInfoComp());
		}
		if (base.bCanAsFollowPartner)
		{
			base.ActorCompContainerCS.RegisterUnitComp<BUS_AiInteractComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		if (base.bBossRoomMonster)
		{
			base.ActorCompContainerCS.RegisterUnitComp<BUS_BossControlComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		base.ActorCompContainerCS.RegisterUnitComp<BUS_InteractCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_OSSCollectComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, int.MaxValue, 2048);
		if (!UGSE_EngineFuncLib.IsDedicateServer(UGSE_EngineFuncLib.GetWorldFromObj(this)))
		{
			base.ActorCompContainerCS.RegisterUnitCompUObj<b1.BUS_UIControlSystemV2>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 1, 2048);
			base.ActorCompContainerCS.RegisterUnitComp<BUS_UnitBarInfoComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf, 1, 2048);
		}
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DispLibWEFMComp>(-2004320256, (EActorCompAlterFlag)0L, EActorCompRejectFlag.TianbingPerf);
	}

	[USharpPath("/Script/b1-Managed.BGU_CharacterAI:OnRep_PlayerStateCS")]
	protected override void OnRep_PlayerStateCS_Implementation()
	{
		base.OnRep_PlayerStateCS_Implementation();
		BUS_EventCollectionCS.Get(this).Evt_OnRep_PlayerState.Invoke();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGU_CharacterAI:OnRep_PlayerStateCS")]
	private static void OnRep_PlayerStateCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGU_CharacterAI bGU_CharacterAI = GCHelper.Find<BGU_CharacterAI>(obj);
		bGU_CharacterAI.OnRep_PlayerStateCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGU_CharacterAI");
		GuidComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuidComp");
		GuidComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuidComp", Classes.FObjectProperty);
		ConfigInfoComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConfigInfoComp");
		ConfigInfoComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConfigInfoComp", Classes.FObjectProperty);
		ExtendConfigComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtendConfigComp");
		ExtendConfigComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtendConfigComp", Classes.FObjectProperty);
		OnRep_PlayerStateCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRep_PlayerStateCS");
		OnRep_PlayerStateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PlayerStateCS_FunctionAddress);
		OnRep_PlayerStateCS_IsValid = OnRep_PlayerStateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGU_CharacterAI:OnRep_PlayerStateCS", OnRep_PlayerStateCS_IsValid);
	}

	static BGU_CharacterAI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_CharacterAI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_CharacterAI));
	}
}
