using System;
using System.Collections.Generic;
using System.Linq;
using BtlB1;
using BtlShare;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GSSkillCastChecker
{
	private enum ECasterType
	{
		Player,
		AI
	}

	private List<int> ValidResIDList = new List<int>();

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_SimpleStateData SimpleStateData { get; set; }

	private IBUC_ActorBasicData ActorBasicData { get; set; }

	private IBUC_AIData AIData { get; set; }

	private IBUC_AttrContainer AttrContainer { get; set; }

	private IBUC_SkillInstsData SkillInstsData { get; set; }

	private IBUC_StaminaData StaminaData { get; set; }

	private IBUC_SkillMappingData SkillMappingData { get; set; }

	private IBUC_ChargeSkillData ChargeSkillData { get; set; }

	private IBUC_TargetInfoData TargetInfoData { get; set; }

	private IBUC_FallDyingData FallDyingData { get; set; }

	private IBUC_ManualSplineMoveData ManualSplineMoveData { get; set; }

	private IBUC_ABPHelperData AnimHumanoidHelperData { get; set; }

	private IBUC_ABPJumpV2Data JumpV2_AnimData { get; set; }

	private IBUC_CloudMoveData CloudMoveData { get; set; }

	private bool AISkipStateJudge { get; set; }

	private bool NeedGetComboTarget { get; set; }

	private bool NeedCheckComboForAI { get; set; }

	private FVector ComboTargetPosition { get; set; }

	private bool UsePursuitAnyWhere { get; set; }

	private bool UseComboCondition { get; set; }

	protected AActor Caster { get; set; }

	private BGUCharacterCS CastCharacter { get; set; }

	protected int SkillID { get; set; }

	protected int OriginSkillID { get; set; }

	private ECasterType CasterType { get; set; }

	protected FUStSkillSDesc SkillSDesc { get; set; }

	protected FUStSkillAIDesc SkillAIDesc { get; set; }

	protected Dictionary<int, FUStTaskStageDesc> AllTaskStageDesc { get; set; }

	private bool IsMagicSkill { get; set; }

	private bool bEmptyStaminaCombo { get; set; }

	private Dictionary<ECanCastSkillResult, Func<bool>> CheckList_ForPlayer { get; }

	private Dictionary<ECanCastSkillResult, Func<bool>> CheckList_ForAI { get; }

	private static GSSkillCastChecker Checker { get; set; }

	private bool bEnableLog => GSGameplayCVar.CVar_EnableSkillCheckerDebug.GetValueInGameThread() == 1;

	public static GSSkillCastChecker Get()
	{
		return Checker ?? (Checker = new GSSkillCastChecker());
	}

	private GSSkillCastChecker()
	{
		CheckList_ForPlayer = new Dictionary<ECanCastSkillResult, Func<bool>>
		{
			{
				ECanCastSkillResult.CCSR_DEAD,
				CheckDead
			},
			{
				ECanCastSkillResult.CCSR_IN_SILENT,
				CheckSilentState
			},
			{
				ECanCastSkillResult.CCSR_OK,
				CheckForceCast
			},
			{
				ECanCastSkillResult.CCSR_STATE,
				CheckState
			},
			{
				ECanCastSkillResult.CCSR_MAGIC_STATE,
				CheckMagicState
			},
			{
				ECanCastSkillResult.CCSR_DODGE_STATE,
				CheckDodgeState
			},
			{
				ECanCastSkillResult.CCSR_NOT_ENOUGH_STAMINA,
				CheckStaminaCost
			},
			{
				ECanCastSkillResult.CCSR_NOT_ENOUGH_ATTR,
				CheckAttributeCost
			},
			{
				ECanCastSkillResult.CCSR_COOLDOWN,
				CheckCoolDown
			},
			{
				ECanCastSkillResult.CCSR_NO_TASKSTAGEFILTER,
				CheckTaskStageFilter
			},
			{
				ECanCastSkillResult.CCSR_IN_LANDPROTECT,
				CheckInJumpLandProtect
			},
			{
				ECanCastSkillResult.CCSR_MOVE_STATE,
				CheckMoveState
			}
		};
		CheckList_ForAI = new Dictionary<ECanCastSkillResult, Func<bool>>
		{
			{
				ECanCastSkillResult.CCSR_DEAD,
				CheckDead
			},
			{
				ECanCastSkillResult.CCSR_STATE,
				CheckState
			},
			{
				ECanCastSkillResult.CCSR_IDLE_STATE,
				CheckIdleState
			},
			{
				ECanCastSkillResult.CCSR_COOLDOWN,
				CheckCoolDown
			},
			{
				ECanCastSkillResult.CCSR_PRECOOLDOWN,
				CheckPreCoolDown
			},
			{
				ECanCastSkillResult.CCSR_INVALID_TARGET,
				CheckTarget
			},
			{
				ECanCastSkillResult.CCSR_COMBO_VALIDSKILLID,
				CheckComboSkill_VALIDSKILLID
			},
			{
				ECanCastSkillResult.CCSR_COMBO_PREFERRANGE,
				CheckComboSkill_PREFERRANGE
			},
			{
				ECanCastSkillResult.CCSR_COMBO_PREFERHEIGHT,
				CheckComboSkill_PREFERHEIGHT
			},
			{
				ECanCastSkillResult.CCSR_COMBO_COMBOCONDITION,
				CheckComboSkill_COMBOCODITION
			},
			{
				ECanCastSkillResult.CCSR_COMBO_ANGLESCORE,
				CheckComboSkill_ANGLESCORE
			}
		};
	}

	public ECanCastSkillResult CheckSkillCastable(AActor SkillCaster, int OriginSkillID, int InSkillID)
	{
		ECanCastSkillResult eCanCastSkillResult = UpdateData(SkillCaster, OriginSkillID, InSkillID);
		if (eCanCastSkillResult == ECanCastSkillResult.CCSR_OK)
		{
			eCanCastSkillResult = CheckSkillCastableInternal();
		}
		Clear();
		return eCanCastSkillResult;
	}

	private ECanCastSkillResult CheckSkillCastableInternal()
	{
		if (CasterType == ECasterType.Player)
		{
			foreach (KeyValuePair<ECanCastSkillResult, Func<bool>> item in CheckList_ForPlayer)
			{
				_ = bEnableLog;
				if (!item.Value())
				{
					_ = bEnableLog;
					return item.Key;
				}
			}
		}
		else if (CasterType == ECasterType.AI)
		{
			foreach (KeyValuePair<ECanCastSkillResult, Func<bool>> item2 in CheckList_ForAI)
			{
				_ = bEnableLog;
				if (!item2.Value())
				{
					_ = bEnableLog;
					return item2.Key;
				}
			}
		}
		_ = bEnableLog;
		return ECanCastSkillResult.CCSR_OK;
	}

	public long QuerySkillCanCast(AActor SkillCaster, int OriginSkillID, int InSkillID, bool AISkipStateJudge, bool NeedGetComboTarget = false, bool NeedCheckComboForAI = false, FVector ComboTargetPosition = default(FVector), bool UsePursuitAnyWhere = false, bool UseComboCondition = false)
	{
		long ResultFlags = 0L;
		ECanCastSkillResult eCanCastSkillResult = UpdateData(SkillCaster, OriginSkillID, InSkillID);
		if (eCanCastSkillResult == ECanCastSkillResult.CCSR_OK)
		{
			this.AISkipStateJudge = AISkipStateJudge;
			this.NeedGetComboTarget = NeedGetComboTarget;
			this.NeedCheckComboForAI = NeedCheckComboForAI;
			this.ComboTargetPosition = ComboTargetPosition;
			this.UsePursuitAnyWhere = UsePursuitAnyWhere;
			this.UseComboCondition = UseComboCondition;
			QuerySkillCanCastInternal(ref ResultFlags);
		}
		else
		{
			ResultFlags |= (long)eCanCastSkillResult;
		}
		Clear();
		return ResultFlags;
	}

	private void QuerySkillCanCastInternal(ref long ResultFlags)
	{
		if (CasterType == ECasterType.Player)
		{
			foreach (KeyValuePair<ECanCastSkillResult, Func<bool>> item in CheckList_ForPlayer)
			{
				_ = bEnableLog;
				if (!item.Value())
				{
					_ = bEnableLog;
					ResultFlags |= (long)item.Key;
				}
			}
		}
		else if (CasterType == ECasterType.AI)
		{
			foreach (KeyValuePair<ECanCastSkillResult, Func<bool>> item2 in CheckList_ForAI)
			{
				_ = bEnableLog;
				if (!item2.Value())
				{
					_ = bEnableLog;
					ResultFlags |= (long)item2.Key;
				}
			}
		}
		if (ResultFlags == 0L)
		{
			ResultFlags |= 1L;
		}
		_ = bEnableLog;
	}

	private ECanCastSkillResult UpdateData(AActor SkillCaster, int InOriginSkillID, int InSkillID)
	{
		Caster = SkillCaster;
		SkillID = InSkillID;
		OriginSkillID = InOriginSkillID;
		if (Caster == null)
		{
			return ECanCastSkillResult.CCSR_OTHER;
		}
		CastCharacter = Caster as BGUCharacterCS;
		if (CastCharacter == null)
		{
			return ECanCastSkillResult.CCSR_OTHER;
		}
		UnitStateData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Caster);
		SimpleStateData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Caster);
		ActorBasicData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(Caster);
		AIData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(Caster);
		AttrContainer = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Caster);
		SkillInstsData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(Caster);
		StaminaData = BGU_DataUtil.GetReadOnlyData<BUC_StaminaData>(Caster);
		SkillMappingData = BGU_DataUtil.GetReadOnlyData<BUC_SkillMappingData>(Caster);
		ChargeSkillData = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(Caster);
		TargetInfoData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(Caster);
		FallDyingData = BGU_DataUtil.GetReadOnlyData<BUC_FallDyingData>(Caster);
		ManualSplineMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ManualSplineMoveData, BUC_ManualSplineMoveData>(Caster);
		AnimHumanoidHelperData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>(Caster);
		JumpV2_AnimData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>(Caster);
		CloudMoveData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(Caster);
		if (UnitStateData == null || SimpleStateData == null || ActorBasicData == null || AIData == null || AttrContainer == null || SkillInstsData == null || StaminaData == null || SkillMappingData == null || ChargeSkillData == null || TargetInfoData == null || FallDyingData == null || ManualSplineMoveData == null || AnimHumanoidHelperData == null)
		{
			return ECanCastSkillResult.CCSR_NULL_DATA;
		}
		SkillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, CastCharacter);
		SkillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		AllTaskStageDesc = BGW_GameDB.GetAllTaskStageDesc();
		if (BGW_LogUtil.LogIfNull(SkillSDesc, "Find SkillSDesc failed, SkillID: {0}", SkillID))
		{
			return ECanCastSkillResult.CCSR_NOSKILL;
		}
		if (SkillSDesc.IsOverlying == EGSYesNo.Yes && BGW_LogUtil.LogIfNull(BGW_GameDB.GetOverlyingSkillSDesc(SkillID), "Find GetOverlyingSkillSDesc failed! SkillID: {0}", SkillID))
		{
			return ECanCastSkillResult.CCSR_NOSKILL;
		}
		if (AIData.IsAI)
		{
			CasterType = ECasterType.AI;
		}
		else
		{
			CasterType = ECasterType.Player;
		}
		IsMagicSkill = false;
		foreach (SpellDesc item in GameDBRuntime.GetTBSpellDesc().List)
		{
			if (item != null && item.SkillId == OriginSkillID)
			{
				if (item.Type == SpellType.HaoMao || item.Type == SpellType.QiShu || item.Type == SpellType.ShenFa)
				{
					IsMagicSkill = true;
				}
				break;
			}
		}
		bEmptyStaminaCombo = GSGameplayCVar.CVar_EmptyStaminaCombo.GetValueInGameThread() != 0;
		return ECanCastSkillResult.CCSR_OK;
	}

	private bool CheckForceCast()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (SkillSDesc.SkillType == ESkillType.NoMontageSkill)
		{
			return false;
		}
		if (ChargeSkillData.IsCastingChargeSkill && SimpleStateData.HasSimpleState(EBGUSimpleState.CanForceAttackInChargeSkill))
		{
			bool flag = false;
			SpellDesc spellDesc = GameDBRuntime.GetTBSpellDesc().List.ToList().Find((SpellDesc Desc) => Desc.SkillId == OriginSkillID);
			if (spellDesc != null && (spellDesc.Type == SpellType.QiShu || spellDesc.Type == SpellType.ShenFa || spellDesc.Type == SpellType.HaoMao))
			{
				flag = true;
			}
			if (!flag)
			{
				return false;
			}
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.ForceSkill))
		{
			return false;
		}
		return true;
	}

	private bool CheckDead()
	{
		if (UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead))
		{
			return false;
		}
		if (FallDyingData.GetFallDyingState() != EFallDyingState.Alive)
		{
			return false;
		}
		return true;
	}

	protected virtual bool ChargeSkillStageCheck()
	{
		if (SkillSDesc.SkillType != ESkillType.ChargeSkillBegin && SkillSDesc.SkillType != ESkillType.ChargeSkillEnd && SkillSDesc.SkillType != ESkillType.RollSkill)
		{
			return SkillSDesc.SkillType != ESkillType.CloudSkill;
		}
		return false;
	}

	private bool CheckSilentState()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Silent))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreRollSkill) && SkillSDesc.SkillType == ESkillType.RollSkill)
		{
			return false;
		}
		List<SpellDesc> list = GameDBRuntime.GetTBSpellDesc().List.ToList();
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreUnitTransSkill))
		{
			SpellDesc spellDesc = list.Find((SpellDesc Desc) => Desc.SkillId == SkillID);
			if (spellDesc != null && spellDesc.Type == SpellType.BianShen)
			{
				return false;
			}
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreSpell))
		{
			SpellDesc spellDesc2 = list.Find((SpellDesc Desc) => Desc.SkillId == OriginSkillID);
			if (spellDesc2 != null && (spellDesc2.Type == SpellType.QiShu || spellDesc2.Type == SpellType.ShenFa || spellDesc2.Type == SpellType.HaoMao))
			{
				return false;
			}
		}
		return true;
	}

	private bool CheckState()
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantAttack))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Silent))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.InPhaseTransition))
		{
			return false;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			return false;
		}
		if (IsMagicSkill)
		{
			return true;
		}
		if (CasterType == ECasterType.AI)
		{
			if (!AISkipStateJudge && !UnitStateData.HasState(EBGUUnitState.InComboWindow) && UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.InComboWindow))
			{
				if (!ChargeSkillData.IsCastingChargeSkill)
				{
					return false;
				}
				if (ChargeSkillData.ChargeSkillStage != EChargeSkillStage.Loop)
				{
					return false;
				}
			}
		}
		else if (UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			if (!UnitStateData.HasState(EBGUUnitState.InItemSkillWindow) && SkillSDesc.SkillType == ESkillType.UseItemSkill)
			{
				return false;
			}
			if (!UnitStateData.HasState(EBGUUnitState.InComboWindow))
			{
				if (ChargeSkillData.IsCastingChargeSkill)
				{
					if (ChargeSkillStageCheck())
					{
						return false;
					}
				}
				else
				{
					if (SkillSDesc.SkillType == ESkillType.HurtSkill)
					{
						return false;
					}
					if (SkillSDesc.SkillType == ESkillType.ChargeSkillBegin)
					{
						return false;
					}
				}
			}
			if (!UnitStateData.HasState(EBGUUnitState.InVigorWindow) && SkillSDesc.SkillType == ESkillType.VigorSkill)
			{
				return false;
			}
			if (!UnitStateData.HasState(EBGUUnitState.InCloudWindow) && SkillSDesc.SkillType == ESkillType.CloudSkill)
			{
				return false;
			}
		}
		return true;
	}

	private bool CheckIdleState()
	{
		if (CasterType == ECasterType.Player)
		{
			return true;
		}
		if (!UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			float OutCurveValue;
			bool floatAnimCurveValue = AnimHumanoidHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.SkillCastTimeRange, out OutCurveValue);
			if (!floatAnimCurveValue || (floatAnimCurveValue && OutCurveValue == 1f))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	private bool CheckMagicState()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (!IsMagicSkill)
		{
			return true;
		}
		if (UnitStateData.HasState(EBGUUnitState.Beatback) && !UnitStateData.HasState(EBGUUnitState.InMagicWindow))
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.InMagicWindow))
		{
			if (!ChargeSkillData.IsCastingChargeSkill)
			{
				return false;
			}
			if (SkillSDesc.SkillType != ESkillType.ChargeSkillBegin && SkillSDesc.SkillType != ESkillType.ChargeSkillEnd)
			{
				return false;
			}
		}
		if (UnitStateData.HasState(EBGUUnitState.InMagicWindow))
		{
			if (SkillInstsData.MagicWindowSkillWhiteList.Count > 0 && !SkillInstsData.MagicWindowSkillWhiteList.Contains(SkillID))
			{
				return false;
			}
			if (SkillInstsData.MagicWindowSkillBlackList.Count > 0 && SkillInstsData.MagicWindowSkillBlackList.Contains(SkillID))
			{
				return false;
			}
		}
		return true;
	}

	private bool CheckDodgeState()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (IsMagicSkill)
		{
			return true;
		}
		if ((UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback)) && SkillSDesc.SkillType == ESkillType.RollSkill && !UnitStateData.HasState(EBGUUnitState.InDodgeWindow))
		{
			return false;
		}
		return true;
	}

	private bool CheckStaminaCost()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (bEmptyStaminaCombo && UnitStateData.HasState(EBGUUnitState.Attacking) && UnitStateData.HasState(EBGUUnitState.InComboWindow) && SkillSDesc.SkillType != ESkillType.ChargeSkillBegin && SkillSDesc.SkillType != ESkillType.ChargeSkillEnd)
		{
			return true;
		}
		if (SkillSDesc.MinAttrCostType1 == EAttrCostType.Stamina)
		{
			BUAttrCostTemplate attrCostTemplate = BGW_EffectTemplateList.Get(CastCharacter).GetAttrCostTemplate(SkillSDesc.MinAttrCostType1);
			if (attrCostTemplate != null && !attrCostTemplate.IsAttrValueEnough(AttrContainer, SkillSDesc.MinAttrCostBase1, SkillSDesc.MinAttrCostRatio1))
			{
				return false;
			}
		}
		if (SkillSDesc.MinAttrCostType2 == EAttrCostType.Stamina)
		{
			BUAttrCostTemplate attrCostTemplate2 = BGW_EffectTemplateList.Get(CastCharacter).GetAttrCostTemplate(SkillSDesc.MinAttrCostType2);
			if (attrCostTemplate2 != null && !attrCostTemplate2.IsAttrValueEnough(AttrContainer, SkillSDesc.MinAttrCostBase2, SkillSDesc.MinAttrCostRatio2))
			{
				return false;
			}
		}
		return true;
	}

	private bool CheckAttributeCost()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (SkillSDesc.MinAttrCostType1 != EAttrCostType.Stamina)
		{
			BUAttrCostTemplate attrCostTemplate = BGW_EffectTemplateList.Get(CastCharacter).GetAttrCostTemplate(SkillSDesc.MinAttrCostType1);
			if (attrCostTemplate != null && !attrCostTemplate.IsAttrValueEnough(AttrContainer, SkillSDesc.MinAttrCostBase1, SkillSDesc.MinAttrCostRatio1))
			{
				BGS_EventCollectionCS.Get(CastCharacter).Evt_BGS_AttrInsuff.Invoke(SkillSDesc.MinAttrCostType1);
				return false;
			}
		}
		if (SkillSDesc.MinAttrCostType2 != EAttrCostType.Stamina)
		{
			BUAttrCostTemplate attrCostTemplate2 = BGW_EffectTemplateList.Get(CastCharacter).GetAttrCostTemplate(SkillSDesc.MinAttrCostType2);
			if (attrCostTemplate2 != null && !attrCostTemplate2.IsAttrValueEnough(AttrContainer, SkillSDesc.MinAttrCostBase2, SkillSDesc.MinAttrCostRatio2))
			{
				BGS_EventCollectionCS.Get(CastCharacter).Evt_BGS_AttrInsuff.Invoke(SkillSDesc.MinAttrCostType2);
				return false;
			}
		}
		return true;
	}

	private bool CheckCoolDown()
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CancelSkillCD))
		{
			return true;
		}
		if (SkillInstsData.GetSkillCooldownTime(SkillID, out var RemainingCooldownTime, out var _))
		{
			return true;
		}
		return RemainingCooldownTime <= 0f;
	}

	private bool CheckPreCoolDown()
	{
		if (CasterType == ECasterType.Player)
		{
			return true;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CancelSkillCD))
		{
			return true;
		}
		if (SkillInstsData.GetSkillCooldownTime(SkillID, out var _, out var RemainingPreCooldownTime))
		{
			return true;
		}
		return RemainingPreCooldownTime <= 0f;
	}

	private bool CheckTarget()
	{
		if (CasterType == ECasterType.AI)
		{
			if (SkillAIDesc == null || SkillAIDesc.TargetResIDList.Length == 0)
			{
				return true;
			}
			AActor aActor = null;
			if (NeedGetComboTarget)
			{
				aActor = TargetInfoData.GetComboTarget().LockTargetActor;
			}
			if (aActor == null)
			{
				aActor = TargetInfoData.GetSkillBaseTarget().LockTargetActor;
			}
			ValidResIDList.Clear();
			string[] array = SkillAIDesc.TargetResIDList.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result))
				{
					ValidResIDList.Add(result);
					continue;
				}
				BGW_LogUtil.LogError("TargetResIDList of SkillAI: " + SkillAIDesc.ID + " error! Unrecognized int!");
				return true;
			}
			if (ValidResIDList.Count > 0)
			{
				if (aActor != null && aActor is BGUCharacterCS)
				{
					int actorResID = BGU_DataUtil.GetActorResID(aActor);
					if (ValidResIDList.Contains(actorResID))
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}
		return true;
	}

	private bool CheckComboSkill_VALIDSKILLID()
	{
		if (CasterType == ECasterType.Player)
		{
			return true;
		}
		if (!NeedCheckComboForAI)
		{
			return true;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, Caster);
		if (skillAIDesc != null && skillSDesc != null && AIData.ComboInfo.MapSkillFeatures.TryGetValue(SkillID, out var _))
		{
			return true;
		}
		return false;
	}

	private bool CheckComboSkill_PREFERRANGE()
	{
		if (CasterType == ECasterType.Player)
		{
			return true;
		}
		if (!NeedCheckComboForAI)
		{
			return true;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, Caster);
		if (skillAIDesc != null && skillSDesc != null)
		{
			FVector location = BGUFuncLibActorTransformCS.BGUGetActorTransform(Caster).GetLocation();
			float num = (ComboTargetPosition - location).Size2D();
			if (((skillAIDesc.PreferRangeMin == -1f || skillAIDesc.PreferRangeMin <= num) && (skillAIDesc.PreferRangeMax == -1f || skillAIDesc.PreferRangeMax >= num)) || UsePursuitAnyWhere)
			{
				return true;
			}
		}
		return false;
	}

	private bool CheckComboSkill_PREFERHEIGHT()
	{
		if (CasterType == ECasterType.Player)
		{
			return true;
		}
		if (!NeedCheckComboForAI)
		{
			return true;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, Caster);
		if (skillAIDesc != null && skillSDesc != null)
		{
			FVector location = BGUFuncLibActorTransformCS.BGUGetActorTransform(Caster).GetLocation();
			float num = FMath.Abs((ComboTargetPosition - location).Z);
			if (skillAIDesc.PreferHeightDis == -1f || skillAIDesc.PreferHeightDis >= num)
			{
				return true;
			}
		}
		return false;
	}

	private bool CheckComboSkill_COMBOCODITION()
	{
		if (CasterType == ECasterType.Player)
		{
			return true;
		}
		if (!NeedCheckComboForAI)
		{
			return true;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, Caster);
		if (skillAIDesc != null && skillSDesc != null)
		{
			bool flag = !AIData.ComboInfo.CurComboHasCastSkillList.Contains(SkillID);
			if (!UseComboCondition || flag)
			{
				return true;
			}
		}
		return false;
	}

	private bool CheckComboSkill_ANGLESCORE()
	{
		if (CasterType == ECasterType.Player)
		{
			return true;
		}
		if (!NeedCheckComboForAI)
		{
			return true;
		}
		FUStSkillAIDesc SkillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, Caster);
		if (SkillAIDesc != null && skillSDesc != null)
		{
			FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(Caster);
			if (!CheckAIAngleScoreIsZero(in SkillAIDesc, fTransform.GetLocation(), fTransform.Rotator(), ComboTargetPosition))
			{
				return true;
			}
		}
		return false;
	}

	private bool CheckMoveState()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			return false;
		}
		int num = 10983;
		if (CloudMoveData != null && CloudMoveData.IsCloudMoveEnabled && !CloudMoveData.CloudSkillList_GetOff.Contains(SkillID) && SkillID != num)
		{
			return false;
		}
		if (CloudMoveData != null && CloudMoveData.IsCloudMoveEnabled && SkillID == num && Caster.GetVelocity() != FVector.ZeroVector)
		{
			return false;
		}
		if (ManualSplineMoveData.IsManuaslSplineMovingWithSpecialAnimation())
		{
			return false;
		}
		return true;
	}

	private bool CheckInJumpLandProtect()
	{
		if (CasterType == ECasterType.AI)
		{
			return true;
		}
		if (JumpV2_AnimData == null)
		{
			return true;
		}
		if (JumpV2_AnimData.bIsInLandCantAttackTime)
		{
			return false;
		}
		return true;
	}

	private bool CheckTaskStageFilter()
	{
		if (CasterType == ECasterType.Player)
		{
			BGUCharacterCS castCharacter = CastCharacter;
			if (castCharacter != null && castCharacter.PlayerState != null)
			{
				IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(castCharacter.GetController());
				if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null)
				{
					foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
					{
						if (quest.Stage == QuestStage.Finished)
						{
							if (!AllTaskStageDesc.ContainsKey(quest.Id))
							{
								return true;
							}
							FUStTaskStageDesc fUStTaskStageDesc = AllTaskStageDesc[quest.Id];
							if (fUStTaskStageDesc == null)
							{
								return true;
							}
							if (new List<string>(fUStTaskStageDesc.FilterSkillID.Split(',')).Find(delegate(string s)
							{
								int.TryParse(s, out var result);
								return result == SkillID;
							}) != null)
							{
								return false;
							}
						}
					}
				}
			}
		}
		return true;
	}

	public void Clear()
	{
		Caster = null;
		SkillID = 0;
		OriginSkillID = 0;
		CastCharacter = null;
		UnitStateData = null;
		SimpleStateData = null;
		ActorBasicData = null;
		AIData = null;
		AttrContainer = null;
		SkillInstsData = null;
		StaminaData = null;
		SkillMappingData = null;
		ChargeSkillData = null;
		TargetInfoData = null;
		FallDyingData = null;
		ManualSplineMoveData = null;
		AnimHumanoidHelperData = null;
		JumpV2_AnimData = null;
		AISkipStateJudge = false;
		NeedGetComboTarget = false;
		NeedCheckComboForAI = false;
		ComboTargetPosition = FVector.ZeroVector;
		UsePursuitAnyWhere = false;
		UseComboCondition = false;
	}

	private bool CheckAIAngleScoreIsZero(in FUStSkillAIDesc SkillAIDesc, FVector OwnerLocation, FRotator OwnerRotation, FVector TargetPosition)
	{
		float num = 0f;
		float num2 = BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(OwnerLocation, OwnerRotation, TargetPosition);
		if (num2 >= 0f && num2 <= 45f)
		{
			num = SkillAIDesc.AngleScoreSector0To45;
		}
		else if (num2 > 45f && num2 <= 90f)
		{
			num = SkillAIDesc.AngleScoreSector45To90;
		}
		else if (num2 > 90f && num2 <= 135f)
		{
			num = SkillAIDesc.AngleScoreSector90To135;
		}
		else if (num2 > 135f && num2 <= 180f)
		{
			num = SkillAIDesc.AngleScoreSector135To180;
		}
		else if (num2 >= -180f && num2 <= -135f)
		{
			num = SkillAIDesc.AngleScoreSector180ToNeg135;
		}
		else if (num2 > -135f && num2 <= -90f)
		{
			num = SkillAIDesc.AngleScoreSectorNeg135ToNeg90;
		}
		else if (num2 > -90f && num2 <= -45f)
		{
			num = SkillAIDesc.AngleScoreSectorNeg90ToNeg45;
		}
		else if (num2 > -45f && num2 <= 0f)
		{
			num = SkillAIDesc.AngleScoreSectorNeg45To0;
		}
		return num == 0f;
	}
}
