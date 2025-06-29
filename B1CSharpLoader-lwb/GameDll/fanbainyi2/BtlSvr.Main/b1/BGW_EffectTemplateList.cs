using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_EffectTemplateList : GameInstanceSystemBase
{
	public Dictionary<EBuffAndSkillEffectType, BUEffectTemplate> EffectTemplatesCS;

	private Dictionary<EInteractType, BUInteractTypeTemplate> InteractTypeTemplates;

	private Dictionary<EInteractAction, BUInteractActionTemplate> InteractActionTemplates;

	private Dictionary<EMatchingPosType, BUMatchingPosTypeTemplate> MatchingPosTypeTemplates;

	private Dictionary<EAttrCostType, BUAttrCostTemplate> AttrCostTemplates;

	private Dictionary<EInputActionType, BUInputActionTemplate> InputActionTemplate;

	private Dictionary<ESmartSelectTargetType, BUSkillSelectTargetTemplate> SkillSelectTargetTemplate;

	private Dictionary<ESmartSelectShapeType, BUSkillSelectShapeTemplate> SkillSelectShapeTemplate;

	private Dictionary<EFixFunctionType, BUFixFunctionTemplate> FixFunctionTemplates;

	private Dictionary<b1.EDataInitTemplateFilter, List<Func<Entity, ECSDataInitTemplate>>> ECSDataInitMap;

	private Dictionary<EChangeMatUnitAttrType, BUChangeMaterialUnitAttrTemplate> ChangeMaterialUnitAttrTemplate;

	private static readonly string AlwaysCantMoveStr = EActorCompRejectFlag.AlwaysCantMove.ToString();

	public static BGW_EffectTemplateList Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_EffectTemplateList>(WorldContext);
	}

	public override void OnInit()
	{
		InitEffectTemplates();
		InitInteractTypeTemplates();
		InitInteractActionTemplates();
		InitMatchingPosTypeTemplates();
		InitAttrCostTemplates();
		InitInputActionTemplates();
		InitChangeMaterialUnitAttrTemplates();
		InitSkillSelectTargetTemplates();
		InitSkillSelectShapeTemplates();
		InitFixFunctionTemplates();
		InitDataInitTemplates();
	}

	private void InitEffectTemplates()
	{
		EffectTemplatesCS = new Dictionary<EBuffAndSkillEffectType, BUEffectTemplate>();
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SkillDamage, new BUEffectNormalDamage());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AddAttr, new BUEffectAddAttr());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.RecoverAttr, new BUEffectRecoverAttr());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.RemoveBuff, new BUEffectRemoveBuff());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetSimpleState, new BUEffectSetSimpleState());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.Sucide, new BUEffectSucide());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DragFarCamera, new BUEffectDragFarCamera());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AddBuffByBone, new BUEffectAddBuffByBone());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.Teleport, new BUEffectTeleport());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ResetSkillCd, new BUEffectResetSkillCD());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AwakePartner, new BUEffectAwakePartner());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SpawnProjectile, new BUEffectSpawnProjectile());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchBullet, new BUEffectSwitchBullet());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchEnvironment, new BUEffectSwitchCLSEnvironment());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TriggerScreenEffect, new BUEffectTriggerScreenEffect());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.EnableCollisionChanel, new BUEffectEnableCollisionChanel());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TriggerHidden, new BUEffectInvisible());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.PauseAi, new BUEffectPauseAI());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.CleanBulletCtrable, new BUEffectDestroyAllCtrableBullet());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SummonUnit, new BUEffectSummonUnit());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DestroyBullet, new BUEffectBulletDestroy());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DestroyFireProjectile, new BUEffectDestroyFireProjectile());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BulletSwitchSelf, new BUEffectBulletSwitchSelf());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchBehaviorTree, new BUEffectSwitchBehaviourTree());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.HideOrShowMesh, new BUEffectHideOrShowMesh());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.HiddenBloodBar, new BUEffectHiddenBloodBar());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ChangeMoveSpeed, new BUEffectChangeMoveSpd());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DrawLineToTarget, new BUEffectDrawLineToTarget());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BulletsSimpleSpawn, new BUEffectSpawnBullets());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BulletAutoAttack, new BUEffectBulletAutoAttack());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BulletScopeMonitor, new BUEffectBulletScopeMonitor());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SpawnEmitter, new BUEffectSpawnEmitter());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AddBuff, new BUEffectAddBuff());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetMatsParamAdvanced, new BUEffectSetMatsParamAdvanced());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetMatsLayerParamAdvanced, new BUEffectSetMatsLayerParamAdvanced());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchPlayerCamInfoId, new BUEffectSwitchPlayerCamInfoId());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ModifyCollisionHitWeight, new BUEffectModifyCollisionHitWeight());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SpawnGhostActor, new BUEffectSpawnGhostActor());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchCollisionHitMove, new BUEffectSwitchCollisionHitMove());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TriggerChargeNextStage, new BUEffectTriggerChargeNextStage());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AddBuffByBuffGroupTotalLayers, new BUEffectAddBuffByBuffGroupTotalLayers());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TimeScale, new BUEffectTimeScaleEvent());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.MoveToPoint, new BUEffectMoveToPoint());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TriggerPassiveSkill, new BUEffectTriggerPassiveSkill());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TriggerTttbFeedback, new BUEffectTriggerTTTBFeedBack());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.CallSummonUseSkill, new BUEffectCallSummonUseSkill());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ScalingBulletSpd, new BUEffectScalingBulletSpd());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SpawnFxbyDispConfigWithEmitterInfo, new BUEffectSpawnFXByDispConfigWithEmitterInfo());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DropAttrItem, new BUEffectDropAttrItem());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchTeamId, new BUEffectSwitchTeamID());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.EscapeAfterDeath, new BUEffectEscapeAfterDeath());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchStateLib, new BUEffectSwitchStateLib());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.InitiatePriorityAction, new BUEffectInitiatePriorityAction());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BeginModularSimulation, new BUEffectBeginModularSimulation());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DetachModularParts, new BUEffectDetachModularParts());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DestroyModularParts, new BUEffectDestroyModularParts());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.RestoreModularParts, new BUEffectRestoreModularParts());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.InterruptRestoreModularParts, new BUEffectInterruptRestoreModularParts());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ModularBreakDown, new BUEffectModularBreakDown());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.PlayCameraShake, new BUEffectPlayCameraShake());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetStaminaRecoverMul, new BUEffectSetStaminaRecoverMul());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DestroyProjectileById, new BUEffectDestroyProjectileByID());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.CostAttr, new BUEffectCostAttr());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetPartRuleId, new BUEffectSetPartRuleID());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetPartActive, new BUEffectSetPartActive());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ActivateWeapons, new BUEffectActivateWeapons());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DeactivateWeapons, new BUEffectDeactivateWeapons());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ToggleWeaponStatus, new BUEffectToggleWeaponStatus());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchCollisionProfile, new BUEffectSwitchCollisionProfile());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AccumulateAbnormalValue, new BUEffectAccumulateAbnormalValue());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DecreaseAbnormalAccValue, new BUEffectDecreaseAbnormalAccValue());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.RemoveAbnormalFinalEffectByStep, new BUEffectRemoveAbnormalFinalEffectByStep());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ClearAbnormalState, new BUEffectClearAbnormalState());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SummonRecall, new BUEffectSummonRecall());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.RecoveryPartDamageValue, new BUEffectRecoveryPartDamageValue());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.FrozenFracture, new BUEffectFrozenFracture());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DoFreshMultiTarget, new BUEffectDoFreshMultiTarget());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.HitDestructibleActor, new BUEffectHitDestructibleActor());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.EnableAssistCollision, new BUEffectEnableTTTBAssistCollision());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.RemoveBuffByCategory, new BUEffectRemoveBuffByCategory());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DestroyAllSummons, new BUEffectDestroyAllSummons());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.KjlrandomLightning, new BUEffectPCSEW_KJLRandomLightning());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TauntTarget, new BUEffectTauntTarget());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.EnablePreciseDodge, new BUEffectEnablePreciseDodge());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ModifyCooldown, new BUEffectModifyCooldown());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DisableCapsuleCollision, new BUEffectDisableCapsuleCollision());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DisableMeshCollision, new BUEffectDisableMeshCollision());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DisableGravity, new BUEffectDisableGravity());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.CostPlayerTransEnergy, new BUEffectCostPlayerTransEnergy());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetPhantomRushConfig, new BUEffectSetPhantomRushConfig());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DestroySummonsById, new BUEffectDestroySummonsByID());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetUnitBattleBgm, new BUEffectSetBattleBGM());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetBgmState, new BUEffectSetBGMState());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ForceLockTarget, new BUEffectForceLockTarget());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AddAllSummonLifeTime, new BUEffectAddAllSummonLifeTime());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ImmuneHardMove, new BUEffectImmuneHardMove());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SuperArmorLevelModify, new BUEffectSuperArmorLevelModify());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.FilterBuff, new BUEffectFilterBuff());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.FilterSkillEffect, new BUEffectFilterSkillEffect());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BulletHitBack, new BUEffectBulletHitBack());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetLockPartHp, new BUEffectSetLockPartHP());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BulletSwitchSelfNoImmediately, new BUEffectBulletSwitchSelfNoImmediately());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DisableInteract, new BUEffectDisableInteract());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.NeverIntoBattle, new BUEffectNeverIntoBattle());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.IncreasePevalue, new BUEffectIncreasePEValue());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ClearPevalue, new BUEffectClearPEValue());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchPeconfig, new BUEffectSwitchPEConfig());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetBgmSwitchPaused, new BUEffectSetBGMSwitchPaused());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AssistBreakFrozen, new BUEffectAssistBreakFrozen());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchCameraGroup, new BUEffectSwitchCameraGroup());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchSkillCameraGroup, new BUEffectSwitchSkillCameraGroup());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchTransMusic, new BUEffectSwitchTransMusic());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.CastProjectileLifeOver, new BUEffectCastProjectileLifeOver());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DisableCameraLockPoint, new BUEffectDisableCameraLockPoint());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DisableAutoLockPoint, new BUEffectDisableAutoLockPoint());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AddPhysicsImpulse, new BUEffectAddPhysicsImpulse());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ThrowUpDeadUnit, new BUEffectThrowUpDeadUnit());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetMpcParamByFloatCurve, new BUEffectSetMPCParamByFloatCurve());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ApplyIllusionEquipOverride, new BUEffectApplyIllusionEquipOverride());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.AddPostProcessMaterial, new BUEffectAddPostProcessMaterial());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.FixHpByRate, new BUEffectFixHpByRate());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchBulletAndSmartSelectTarget, new BUEffectSwitchBulletAndSmartSelectTarget());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.InheritedHpByRate, new BUEffectInheritedHpByRate());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetPreciseCompRelativeScale, new BUEffectSetPreciseCompRelativeScale());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchFreeCameraMode, new BUEffectSwitchFreeCameraMode());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.RelieveImmobilized, new BUEffectRelieveImmobilized());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.EnterSpiderSilkEntangle, new BUEffectEnterSpiderSilkEntangle());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetGmcustomTimeDilation, new BUEffectSetGmcustomTimeDilation());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.PlayerTrans, new BUEffectPlayerTrans());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.MagicallyChange, new BUEffectMagicallyChange());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.MagicallyChangeRecover, new BUEffectMagicallyChangeRecover());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.BreakCloudMove, new BUEffectBreakCloudMove());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.DecreaseLifeSavingHairCoolDown, new BUEffectDecreaseLifeSavingHairCoolDown());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ActiveExtLifeSavingHair, new BUEffectActiveExtLifeSavingHair());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetHitMoveUnmovable, new BUEffectSetHitMoveUnmovable());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SetEnableVigourDropManually, new BUEffectSetEnableVigourDropManually());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.SwitchAttackerAbnormalDispId, new BUEffectSwitchAttackerAbnormalDispID());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.TriggerProjectileReaction, new BUEffectTriggerProjectileReaction());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.MultiTargetBulletSwitchToBackNestProjectile, new BUEffectMultiTargetBulletSwitchToBackNestProjectile());
		EffectTemplatesCS.Add(EBuffAndSkillEffectType.ResetSealingSpell, new BUEffectResetSealingSpell());
	}

	private void InitInteractTypeTemplates()
	{
		InteractTypeTemplates = new Dictionary<EInteractType, BUInteractTypeTemplate>();
		InteractTypeTemplates.Add(EInteractType.RebirthPoint, new b1.BUITRebirthPoint());
		InteractTypeTemplates.Add(EInteractType.StandardObj, new b1.BUITStandardObj());
		InteractTypeTemplates.Add(EInteractType.DropItem, new b1.BUITDropItem());
		InteractTypeTemplates.Add(EInteractType.TaskNpc, new b1.BUITTaskNpc());
		InteractTypeTemplates.Add(EInteractType.Rescue, new b1.BUITRescue());
		InteractTypeTemplates.Add(EInteractType.Collection, new b1.BUITCollection());
		InteractTypeTemplates.Add(EInteractType.MeditationPoint, new b1.BUITMeditationPoint());
		InteractTypeTemplates.Add(EInteractType.RequireItem, new b1.BUITRequireItem());
		InteractTypeTemplates.Add(EInteractType.Focus, new b1.BUITFocus());
		InteractTypeTemplates.Add(EInteractType.NotForPlayer, new b1.BUITNotForPlayer());
		InteractTypeTemplates.Add(EInteractType.StrangeBox, new b1.BUITStrangeBox());
		InteractTypeTemplates.Add(EInteractType.Cricket, new b1.BUITCricket());
		InteractTypeTemplates.Add(EInteractType.None, new b1.BUITNone());
	}

	private void InitInteractActionTemplates()
	{
		InteractActionTemplates = new Dictionary<EInteractAction, BUInteractActionTemplate>();
		InteractActionTemplates.Add(EInteractAction.None, new b1.BUIANone());
		InteractActionTemplates.Add(EInteractAction.DummyMeshAnim, new b1.BUIADummyMeshAnim());
		InteractActionTemplates.Add(EInteractAction.RebirthPoint, new b1.BUIARebirthPoint());
		InteractActionTemplates.Add(EInteractAction.Meditation, new b1.BUIAMeditation());
		InteractActionTemplates.Add(EInteractAction.SkillAndBuff, new b1.BUIASkillAndBuff());
		InteractActionTemplates.Add(EInteractAction.ComplexSkill, new b1.BUIAComplexSkill());
		InteractActionTemplates.Add(EInteractAction.Montage, new b1.BUIAMontage());
		InteractActionTemplates.Add(EInteractAction.ComplexMontage, new b1.BUIAComplexMontage());
		InteractActionTemplates.Add(EInteractAction.Dialogue, new b1.BUIADialogue());
		InteractActionTemplates.Add(EInteractAction.Seq, new b1.BUIASeq());
		InteractActionTemplates.Add(EInteractAction.ToolNpc, new b1.BUIAToolNpc());
		InteractActionTemplates.Add(EInteractAction.LoopMontage, new b1.BUIALoopMontage());
		InteractActionTemplates.Add(EInteractAction.LongPressRescue, new b1.BUIALongPressRescue());
		InteractActionTemplates.Add(EInteractAction.PartyRoom, new b1.BUIPartyRoom());
		InteractActionTemplates.Add(EInteractAction.OnlineTeleport, new b1.BUIOnlineTeleport());
		InteractActionTemplates.Add(EInteractAction.OpenUi, new b1.BUIAOpenUI());
		InteractActionTemplates.Add(EInteractAction.StrangeBox, new b1.BUIAStrangeBox());
		InteractActionTemplates.Add(EInteractAction.EnterSplineMove, new b1.BUIAEnterSplineMove());
		InteractActionTemplates.Add(EInteractAction.DaShengEquipOpen, new b1.BUIADaShengEquipOpen());
		InteractActionTemplates.Add(EInteractAction.XiShuaiSpecial, new b1.BUIAXiShuaiSpecial());
		InteractActionTemplates.Add(EInteractAction.Echo, new b1.BUIAEcho());
	}

	private void InitMatchingPosTypeTemplates()
	{
		MatchingPosTypeTemplates = new Dictionary<EMatchingPosType, BUMatchingPosTypeTemplate>();
		MatchingPosTypeTemplates.Add(EMatchingPosType.InterpolationLiner, new b1.BUMPTInterpolationLiner());
		MatchingPosTypeTemplates.Add(EMatchingPosType.FlyTrajectoryUseBezier, new b1.BUMPTFlyTrajectoryUseBezier());
	}

	private void InitAttrCostTemplates()
	{
		AttrCostTemplates = new Dictionary<EAttrCostType, BUAttrCostTemplate>();
		AttrCostTemplates.Add(EAttrCostType.Hp, new BUACHPCost());
		AttrCostTemplates.Add(EAttrCostType.Mp, new BUACMPCost());
		AttrCostTemplates.Add(EAttrCostType.Stamina, new BUACStaminaCost());
		AttrCostTemplates.Add(EAttrCostType.BloodBottleNum, new BUACBloodBottleNumCost());
		AttrCostTemplates.Add(EAttrCostType.SpecialEnergy, new BUACSpecialEnergyCost());
		AttrCostTemplates.Add(EAttrCostType.PotentialEnergy, new BUACPECost());
		AttrCostTemplates.Add(EAttrCostType.TransEnergy, new BUATransEnergy());
		AttrCostTemplates.Add(EAttrCostType.FabaoEnergy, new BUAFabaoEnergy());
		AttrCostTemplates.Add(EAttrCostType.VigorEnergy, new BUAVigorEnergy());
	}

	private void InitInputActionTemplates()
	{
		InputActionTemplate = new Dictionary<EInputActionType, BUInputActionTemplate>
		{
			{
				EInputActionType.LightAttack,
				new b1.BUIALightAttack()
			},
			{
				EInputActionType.HeavyAttack,
				new b1.BUIAHeavyAttack()
			},
			{
				EInputActionType.CameraLock,
				new b1.BUIACameraLock()
			},
			{
				EInputActionType.SpinMode,
				new b1.BUIASpinMode()
			},
			{
				EInputActionType.CameraLockPointHide,
				new b1.BUIACameraLockPointHide()
			},
			{
				EInputActionType.CameraModeSwitch,
				new b1.BUIACameraModeSwitch()
			},
			{
				EInputActionType.CameraG4SpotTurn,
				new b1.BUIACameraG4SpotTurn()
			},
			{
				EInputActionType.SwitchMoveSpeedState,
				new b1.BUIASwitchMoveSpeedState()
			},
			{
				EInputActionType.Interact,
				new b1.BUIAInteract()
			},
			{
				EInputActionType.Move,
				new b1.BUIAMove()
			},
			{
				EInputActionType.ViewportRotate,
				new b1.BUIAViewportRotate()
			},
			{
				EInputActionType.CastItemSkill,
				new b1.BUIACastItemSkill()
			},
			{
				EInputActionType.Dodge,
				new b1.BUIADodge()
			},
			{
				EInputActionType.Jump,
				new b1.BUIAJump()
			},
			{
				EInputActionType.AxisCameraLockSwitchTarget,
				new b1.BUIAAxisCameraLockSwitchTarget()
			},
			{
				EInputActionType.UseShortcutItem,
				new b1.BUIAShortcutItem()
			},
			{
				EInputActionType.UseSkillByType,
				new b1.BUIAUseSkillByType()
			},
			{
				EInputActionType.CastFaBaoSkill,
				new b1.BUIACastFaBaoSkill()
			},
			{
				EInputActionType.MoveFinish,
				new b1.BUIAMoveFinish()
			},
			{
				EInputActionType.SwitchWeaponPoseHeavy,
				new b1.BUIASwitchWeaponPoseHeavy()
			},
			{
				EInputActionType.SwitchWeaponPoseProp,
				new b1.BUIASwitchWeaponPoseProp()
			},
			{
				EInputActionType.SwitchWeaponPosePoke,
				new b1.BUIASwitchWeaponPosePoke()
			},
			{
				EInputActionType.Unfreeze,
				new b1.BUIAUnfreeze()
			},
			{
				EInputActionType.UseVigorSkill,
				new b1.BUIAUseVigorSkill()
			},
			{
				EInputActionType.CloudLift,
				new b1.BUIACloudLift()
			},
			{
				EInputActionType.CloudFreeLook,
				new b1.BUIACloudFreeLook()
			},
			{
				EInputActionType.ToggleCloudMove,
				new b1.BUIAToggleCloudMove()
			},
			{
				EInputActionType.OpenMap,
				new b1.BUIAOpenMap()
			}
		};
	}

	private void InitChangeMaterialUnitAttrTemplates()
	{
		ChangeMaterialUnitAttrTemplate = new Dictionary<EChangeMatUnitAttrType, BUChangeMaterialUnitAttrTemplate>();
		ChangeMaterialUnitAttrTemplate.Add(EChangeMatUnitAttrType.Velocity, new BUCMUAVelocity());
	}

	private void InitSkillSelectTargetTemplates()
	{
		SkillSelectTargetTemplate = new Dictionary<ESmartSelectTargetType, BUSkillSelectTargetTemplate>();
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.None, new BUSkillSelectTargetTemplate());
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.SstSelf, new BUSkillSelectTargetTemplate());
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.SstQuality, new b1.BUSkillSelectTargetByQuality());
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.SstElite, new b1.BUSkillSelectTargetByQuality());
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.SstSimple, new b1.BUSkillSelectTargetByDistance());
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.SstQuantity, new b1.BUSkillSelectTargetByQuantity());
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.SstMeleeAutoLock, new b1.BUSkillSelectTargetByMeleeAutoLock());
		SkillSelectTargetTemplate.Add(ESmartSelectTargetType.SstCameraLock, new b1.BUSSkillSelectTargetByCameraLock());
	}

	private void InitSkillSelectShapeTemplates()
	{
		SkillSelectShapeTemplate = new Dictionary<ESmartSelectShapeType, BUSkillSelectShapeTemplate>();
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssFixedCircle, new BUSkillSelectShapeFixedCircle());
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssSector, new BUSkillSelectShapeSector());
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssArrow, new BUSkillSelectShapeArrow());
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssRectangle, new BUSkillSelectShapeRectangle());
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssInCircle, new BUSkillSelectShapeInCircle());
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssCircle, new BUSkillSelectShapeCircle());
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssArrowToCircle, new BUSkillSelectShapeArrowToCircle());
		SkillSelectShapeTemplate.Add(ESmartSelectShapeType.SssShootUi, new BUSkillSelectShapeShootUI());
	}

	private void InitFixFunctionTemplates()
	{
		FixFunctionTemplates = new Dictionary<EFixFunctionType, BUFixFunctionTemplate>();
		FixFunctionTemplates.Add(EFixFunctionType.AttrBaseModifyAttr, new BUFFAttrBaseModifyAttr());
		FixFunctionTemplates.Add(EFixFunctionType.AttrBaseAbsModifyAttr, new BUFFAttrBaseAbsModifyAttr());
		FixFunctionTemplates.Add(EFixFunctionType.PlayerCountAttr, new BUFFPlayerCountAttr());
		FixFunctionTemplates.Add(EFixFunctionType.PlayerDashengTalentAttr, new BUFFPlayerDashengTalentAttr());
		FixFunctionTemplates.Add(EFixFunctionType.PlayerWinePartnerAttr, new BUFFPlayerWinePartnerAttr());
		FixFunctionTemplates.Add(EFixFunctionType.AttrMulModifyAttr, new BUFFAttrMulModifyAttr());
	}

	private void InitDataInitTemplates()
	{
		ECSDataInitMap = new Dictionary<b1.EDataInitTemplateFilter, List<Func<Entity, ECSDataInitTemplate>>>();
		ECSDataInitMap.Add(b1.EDataInitTemplateFilter.Monster, new List<Func<Entity, ECSDataInitTemplate>>
		{
			(Entity Entity) => new MonsterAttrInitAttr(Entity, 128)
		});
		ECSDataInitMap.Add(b1.EDataInitTemplateFilter.PlayerWukong, new List<Func<Entity, ECSDataInitTemplate>>
		{
			(Entity Entity) => new PlayerWukongAttrDataInit(Entity, 128),
			(Entity Entity) => new PlayerWukongSkillCDInit(Entity, 128)
		});
		ECSDataInitMap.Add(b1.EDataInitTemplateFilter.PlayerTransForm, new List<Func<Entity, ECSDataInitTemplate>>
		{
			(Entity Entity) => new PlayerTransAttrDataInit(Entity, 128),
			(Entity Entity) => new PlayerTransEquipDataInit(Entity, 128)
		});
		ECSDataInitMap.Add(b1.EDataInitTemplateFilter.ECSActor, new List<Func<Entity, ECSDataInitTemplate>>
		{
			(Entity Entity) => new ECSDataConvertTemplate(Entity, int.MaxValue)
		});
		ECSDataInitMap.Add(b1.EDataInitTemplateFilter.AlwaysCantMoveActor, new List<Func<Entity, ECSDataInitTemplate>>
		{
			(Entity Entity) => new AlwaysCantMoveActorInit(Entity, int.MaxValue)
		});
	}

	public BUFixFunctionTemplate GetFixFunctionTemplate(EFixFunctionType FixFunctionType)
	{
		if (FixFunctionTemplates.TryGetValue(FixFunctionType, out var value))
		{
			return value;
		}
		return null;
	}

	public BUInteractTypeTemplate GetInteractTypeTemplate(EInteractType InteractType)
	{
		if (InteractTypeTemplates.TryGetValue(InteractType, out var value))
		{
			return value;
		}
		return null;
	}

	public BUInteractActionTemplate GetInteractActionTemplate(EInteractAction InteractType)
	{
		if (InteractActionTemplates.TryGetValue(InteractType, out var value))
		{
			return value;
		}
		return null;
	}

	public BUMatchingPosTypeTemplate GetMatchingPosTypeTemplate(EMatchingPosType MatchingPosType)
	{
		if (MatchingPosTypeTemplates.TryGetValue(MatchingPosType, out var value))
		{
			return value;
		}
		return null;
	}

	public BUAttrCostTemplate GetAttrCostTemplate(EAttrCostType AttrCostType)
	{
		if (AttrCostTemplates.TryGetValue(AttrCostType, out var value))
		{
			return value;
		}
		return null;
	}

	public BUInputActionTemplate GetInputActionTemplate(EInputActionType InputActionType)
	{
		if (InputActionTemplate.TryGetValue(InputActionType, out var value))
		{
			return value;
		}
		return null;
	}

	public BUSkillSelectTargetTemplate GetSkillSelectTargetTemplate(ESmartSelectTargetType SelectTargetType)
	{
		if (SkillSelectTargetTemplate.TryGetValue(SelectTargetType, out var value))
		{
			return value;
		}
		return null;
	}

	public BUSkillSelectShapeTemplate GetSkillSelectShapeTemplate(ESmartSelectShapeType SelectShapeType)
	{
		if (SkillSelectShapeTemplate.TryGetValue(SelectShapeType, out var value))
		{
			return value;
		}
		return null;
	}

	public List<ECSDataInitTemplate> AllocatECSDataInitTemplate(AActor Owner)
	{
		int actorNetRole = BGUFuncLibReplication.GetActorNetRole(Owner);
		Entity entity = ECSExtension.ToEntity(Owner);
		List<ECSDataInitTemplate> list = new List<ECSDataInitTemplate>();
		int dataInitTemplateFilter = GetDataInitTemplateFilter(entity);
		for (int num = 1; num < 32; num <<= 1)
		{
			if ((num & dataInitTemplateFilter) > 0 && ECSDataInitMap != null && ECSDataInitMap.TryGetValue((b1.EDataInitTemplateFilter)num, out var value))
			{
				foreach (Func<Entity, ECSDataInitTemplate> item in value)
				{
					ECSDataInitTemplate eCSDataInitTemplate = item(entity);
					if ((eCSDataInitTemplate.FilterNetRole & actorNetRole) > 0)
					{
						list.Add(eCSDataInitTemplate);
					}
				}
			}
		}
		return list;
	}

	private int GetDataInitTemplateFilter(Entity Entity)
	{
		AActor aActor = ECSExtension.ToActor(Entity);
		int num = 8;
		if (aActor != null)
		{
			BGUPlayerCharacterCS bGUPlayerCharacterCS = ECSExtension.ToActor(Entity) as BGUPlayerCharacterCS;
			if (bGUPlayerCharacterCS != null)
			{
				bool flag = false;
				BUS_ConfigInfoComp playerConfigInfoComp = bGUPlayerCharacterCS.PlayerConfigInfoComp;
				int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
				if (playerConfigInfoComp != null && playerConfigInfoComp.UnitCDesc.ResID == commLogicCfgValue)
				{
					flag = true;
				}
				num = ((!flag) ? (num | 4) : (num | 2));
			}
			else
			{
				ABGUCharacter aBGUCharacter = ECSExtension.ToActor(Entity) as ABGUCharacter;
				if (aBGUCharacter != null)
				{
					num |= 1;
					if (aBGUCharacter.GetComponentByClass(UClass.GetClass<BUS_ConfigInfoComp>()) is BUS_ConfigInfoComp bUS_ConfigInfoComp && bUS_ConfigInfoComp.FlagConfig.MonsterRejectTags.TryGetValue(AlwaysCantMoveStr, out var _))
					{
						num |= 0x10;
					}
				}
			}
		}
		return num;
	}

	public BUChangeMaterialUnitAttrTemplate GetChangeMaterialUnitAttrTemplate(EChangeMatUnitAttrType AttrType)
	{
		if (ChangeMaterialUnitAttrTemplate.TryGetValue(AttrType, out var value))
		{
			return value;
		}
		return null;
	}
}
