using System;
using BtlShare;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSimpleCharacter")]
public class BGUSimpleCharacter : BGUCharacterCS
{
	public override void InitAllComp()
	{
		BGW_ECSWorld.Get(this).SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		InitialFromTamer();
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DispLibUnitMaterialsManageComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DispLibDBCManageComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		InitialCacheData();
		base.TeamIDDeprecate = 1;
		base.ActorCompContainerCS.RegisterUnitComp<BUS_UnitStateSystem>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PropMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TickRateLogicComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PauseComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_GuidCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TriggerEffectComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TriggerEffectCompSvr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 144, 1024);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SaveInitDataCompSimple>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_MovementSystem>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_StateLibComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BuffComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_TeamIDManageComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BuffDispComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SummonCtrlComp>(-2004844544, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 144, 1024);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_AttackFeedbackComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<b1.BUS_DispMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AbnormalHandleComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SkillInstsComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SkillInstsCompSvr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 144, 1024);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AttrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PhysicalAnimationComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BeAttackedComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_AIComp>(579371008, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BattleBGMCompImpl>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AICompSvr>(579371008, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128, 4096);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CollisionHitMoveComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_MonsterCheatComp>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_DecalComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_AttackFeedbackPerformComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BeAttackedPerformComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_UnitHitVEffectComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MatMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SkillMappingComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_MasterComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PartnerComp>(557056, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_PointSetsComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<b1.BUS_AKMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PhysicsForceComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_RenderTargetMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 1);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CollisionProfileMgr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_AbnormalStateCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_ControllerComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_CheckComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_CustomDepthStencilComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<BUS_SkillSequenceComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SpecialBoneMgrComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BeImmobilizedComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_BattleStateComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_OnlineTamerDebugComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_BattleInfoComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DeadComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DataReplicationSystemClient>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, int.MaxValue, 128);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_DataReplicationSystemSvr>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 132);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_SuperArmorLevelMappingComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_SimpleOverlapComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_QuestRegCollectionCompBase>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitComp<BUS_UnmovableInitializerComp>(1145323520, EActorCompAlterFlag.AlwaysCantMove, (EActorCompRejectFlag)0L);
		base.ActorCompContainerCS.RegisterUnitCompUObj<b1.BUS_FoliageInteractSoundCompImpl>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc.VigourDropId != 0)
		{
			base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_VigourDropperComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		}
		base.ActorCompContainerCS.RegisterUnitComp<BUS_FsmComp>(579371008, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, 128);
		base.ActorCompContainerCS.RegisterUnitComp<b1.BUS_PreloadLogicComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L);
		if (DebugConfig.DebugWidget)
		{
			base.ActorCompContainerCS.AddComp(new BUS_DebugInfoComp());
		}
		base.ActorCompContainerCS.RegisterUnitComp<BUS_OSSCollectComp>(-2004320256, (EActorCompAlterFlag)0L, (EActorCompRejectFlag)0L, int.MaxValue, 2048);
	}

	protected override void InitBGUDataComp(FObjectInitializer initializer)
	{
		base.BGUDataComp = initializer.CreateDefaultSubobject<BUS_SimpleBGUDataComp>(this, B1GlobalFNames.UBGUDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSimpleCharacter");
	}

	static BGUSimpleCharacter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSimpleCharacter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSimpleCharacter));
	}
}
