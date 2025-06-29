using System.Collections.Generic;
using BtlB1;
using BtlShare;
using GurCalliopeState;
using UnrealEngine.Runtime;

namespace b1;

public class FDetectConditionForCheck
{
	public EDetectedElementType DetectedElementType;

	public EBGUSimpleState SimpleState;

	public EBGUUnitState UnitState;

	public int BuffId;

	public int BuffLayer;

	public EBGUAttrFloat AttrFloatType;

	public EValueCompareOperations CompareOperation;

	public float CompareValue;

	public EAbnormalStateType AbnormalStateType;

	public EBGUFSMStateName FsmState;

	public int SkillId;

	public EValueCompareOperations DistanceCompareOperations;

	public float DistanceCompareValue;

	public FGameplayTag CustomFsmState;

	public int CompareValueInt;

	public ERotationBaseDirection BaseDirection;

	public float MinYawAngle;

	public float MaxYawAngle;

	public List<int> SkillIdList;

	public FTamerFamilyMatchChildInfo MatchInfo;

	public int ResId;

	public float SuccessRate;

	public bool bReverseCondition;

	public int DeadUnitNum;

	public EValueCompareOperationType OperationType;

	public int GamePlusCount;

	public ESceneItemSurfaceType SurfaceType;

	public FDetectConditionForCheck(CalliopeCustom_DetectCondition DetectCondition)
	{
		DetectedElementType = (EDetectedElementType)DetectCondition.DetectedElementType;
		switch (DetectedElementType)
		{
		case EDetectedElementType.SimpleState:
			SimpleState = (EBGUSimpleState)DetectCondition.SimpleState.SimpleState;
			break;
		case EDetectedElementType.UnitState:
			UnitState = (EBGUUnitState)DetectCondition.UnitState.UnitState;
			break;
		case EDetectedElementType.HasBuff:
			BuffId = DetectCondition.HasBuff.BuffId;
			break;
		case EDetectedElementType.UnitAttr:
			AttrFloatType = (EBGUAttrFloat)DetectCondition.UnitAttr.AttrFloatType;
			CompareOperation = (EValueCompareOperations)DetectCondition.UnitAttr.CompareOperation;
			CompareValue = DetectCondition.UnitAttr.CompareValue;
			break;
		case EDetectedElementType.FsmState:
			FsmState = (EBGUFSMStateName)DetectCondition.FsmState.FsmState;
			break;
		case EDetectedElementType.SkillCoolDown:
			SkillId = DetectCondition.SkillCoolDown.SkillId;
			break;
		case EDetectedElementType.DistanceFromTarget:
			DistanceCompareOperations = (EValueCompareOperations)DetectCondition.DistanceFromTarget.DistanceCompareOperations;
			DistanceCompareValue = DetectCondition.DistanceFromTarget.DistanceCompareValue;
			break;
		case EDetectedElementType.DistanceFromMaster:
			DistanceCompareOperations = (EValueCompareOperations)DetectCondition.DistanceFromMaster.DistanceCompareOperations;
			DistanceCompareValue = DetectCondition.DistanceFromMaster.DistanceCompareValue;
			break;
		case EDetectedElementType.SkillCanCast:
			SkillId = DetectCondition.SkillCanCast.SkillId;
			break;
		case EDetectedElementType.CustomFsmState:
			CustomFsmState = GameplayTagExtension.MakeGameplayTag(DetectCondition.CustomFsmState.CustomFsmState);
			break;
		case EDetectedElementType.LastBeAttackedStiffLevel:
			CompareOperation = (EValueCompareOperations)DetectCondition.LastBeAttackedStiffLevel.CompareOperation;
			CompareValueInt = DetectCondition.LastBeAttackedStiffLevel.CompareValueInt;
			break;
		case EDetectedElementType.CurrentBeAttackedStiffLevel:
			CompareOperation = (EValueCompareOperations)DetectCondition.CurrentBeAttackedStiffLevel.CompareOperation;
			CompareValueInt = DetectCondition.CurrentBeAttackedStiffLevel.CompareValueInt;
			break;
		case EDetectedElementType.ActorYawRotation:
			BaseDirection = (ERotationBaseDirection)DetectCondition.ActorYawRotation.BaseDirection;
			MinYawAngle = DetectCondition.ActorYawRotation.MinYawAngle;
			MaxYawAngle = DetectCondition.ActorYawRotation.MaxYawAngle;
			break;
		case EDetectedElementType.GlobalCastSkillCount:
			SkillId = DetectCondition.GlobalCastSkillCount.SkillId;
			CompareOperation = (EValueCompareOperations)DetectCondition.GlobalCastSkillCount.CompareOperation;
			CompareValueInt = DetectCondition.GlobalCastSkillCount.CompareValueInt;
			break;
		case EDetectedElementType.AbnormalState:
			AbnormalStateType = (EAbnormalStateType)DetectCondition.AbnormalState.AbnormalStateType;
			break;
		case EDetectedElementType.DurCastSkill:
			SkillIdList = new List<int>(DetectCondition.DurCastSkill.SkillIdList);
			break;
		case EDetectedElementType.CurSkillCostDmgNum:
			CompareOperation = (EValueCompareOperations)DetectCondition.CurSkillCostDmgNum.CompareOperation;
			CompareValueInt = DetectCondition.CurSkillCostDmgNum.CompareValueInt;
			break;
		case EDetectedElementType.SocketUnitsDead:
			MatchInfo = BED_CalliopeFuncLib.Deserialize(DetectCondition.SocketUnitsDead.MatchInfo);
			break;
		case EDetectedElementType.DistanceFromNearestPlayer:
			CompareOperation = (EValueCompareOperations)DetectCondition.DistanceFromNearestPlayer.CompareOperation;
			CompareValueInt = DetectCondition.DistanceFromNearestPlayer.CompareValueInt;
			break;
		case EDetectedElementType.SpecifyResIdUnitsDead:
			ResId = DetectCondition.SpecifyResIdUnitsDead.ResId;
			break;
		case EDetectedElementType.FamilySpecifyUnitAttr:
			MatchInfo = BED_CalliopeFuncLib.Deserialize(DetectCondition.FamilySpecifyUnitAttr.MatchInfo);
			AttrFloatType = (EBGUAttrFloat)DetectCondition.FamilySpecifyUnitAttr.AttrFloatType;
			CompareOperation = (EValueCompareOperations)DetectCondition.FamilySpecifyUnitAttr.CompareOperation;
			CompareValue = DetectCondition.FamilySpecifyUnitAttr.CompareValue;
			break;
		case EDetectedElementType.Random:
			SuccessRate = DetectCondition.Random.SuccessRate;
			break;
		case EDetectedElementType.FamilyUnitAliveNum:
			MatchInfo = BED_CalliopeFuncLib.Deserialize(DetectCondition.FamilyUnitAliveNum.MatchInfo);
			CompareOperation = (EValueCompareOperations)DetectCondition.FamilyUnitAliveNum.CompareOperation;
			DeadUnitNum = DetectCondition.FamilyUnitAliveNum.AliveUnitNum;
			break;
		case EDetectedElementType.TargetInAngleRange:
			MinYawAngle = DetectCondition.TargetInAngleRange.MinYawAngle;
			MaxYawAngle = DetectCondition.TargetInAngleRange.MaxYawAngle;
			break;
		case EDetectedElementType.CompareBuffLayer:
			BuffId = DetectCondition.CompareBuffLayer.BuffId;
			BuffLayer = DetectCondition.CompareBuffLayer.BuffLayer;
			OperationType = (EValueCompareOperationType)DetectCondition.CompareBuffLayer.OperationType;
			break;
		case EDetectedElementType.CompareGamePlusCount:
			GamePlusCount = DetectCondition.CompareGamePlusCount.GamePlusCount;
			OperationType = (EValueCompareOperationType)DetectCondition.CompareGamePlusCount.OperationType;
			break;
		case EDetectedElementType.CheckSurfaceType:
			SurfaceType = (ESceneItemSurfaceType)DetectCondition.CheckSurfaceType.SurfaceType;
			break;
		case EDetectedElementType.PlayerLeisureOverTime:
			CompareValue = DetectCondition.PlayerLeisureOverTime.PlayerLeisureOverTime;
			break;
		}
		bReverseCondition = DetectCondition.IsReverseCondition;
	}

	public FDetectConditionForCheck(EBGUAttrFloat InAttrFloatType, EValueCompareOperations InCompareOperation, float InCompareValue, bool IsReverseCondition)
	{
		DetectedElementType = EDetectedElementType.UnitAttr;
		AttrFloatType = InAttrFloatType;
		CompareOperation = InCompareOperation;
		CompareValue = InCompareValue;
		bReverseCondition = IsReverseCondition;
	}
}
