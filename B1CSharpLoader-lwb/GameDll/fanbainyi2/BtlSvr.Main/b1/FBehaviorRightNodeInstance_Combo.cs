using System.Linq;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FBehaviorRightNodeInstance_Combo : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.Combo;

	private BehaviorCustom_Combo CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_Combo();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		base.BUSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.Combo, new AINodeAction_ComboParamInfo
		{
			ComboTargetType = (EComboTargetType)CustomData.ComboTargetType,
			SkillSourceType = (EZatoichiSkillSourceType)CustomData.SkillSourceType,
			ForceCastSkillAfterPursuitFailed = CustomData.ForceCastSkillAfterPursuitFailed,
			PursuitAnyWhere = CustomData.PursuitAnyWhere,
			PursuitInAllSkill = CustomData.PursuitInAllSkill,
			PursuitRangePos = CustomData.PursuitRangePos,
			SpeedRateType = (EAIMoveSpeedType)CustomData.SpeedRateType,
			MotionMatchingMoveMode = (EState_MM)CustomData.MotionMatchingMoveMode,
			MoveAIType = (EBGUMoveAIType)CustomData.MoveAIType,
			MoveAcceptableRadiusType = (EBGUMoveAcceptableRadiusType)CustomData.MoveAcceptableRadiusType,
			BeginRotateAngle = CustomData.BeginRotateAngle,
			IsUseSkillForTurn = CustomData.IsUseSkillForTurn,
			IsUseSkillForMove = CustomData.IsUseSkillForMove,
			BeginMoveDistanceWhenUseSkill = CustomData.BeginMoveDistanceWhenUseSkill,
			EnableInterruptReduceCBNum = CustomData.EnableInterruptReduceCBNum,
			NeedTraceHitTargetBefore = CustomData.NeedTraceHitTargetBefore,
			EnableForceComboRelation = CustomData.EnableForceComboRelation,
			EnableComboCondition = CustomData.EnableComboCondition,
			TraceDistance = CustomData.TraceDistance,
			TraceTypeQuery = (ETraceTypeQuery)CustomData.TraceTypeQuery,
			IsGetTopRandomSkill = CustomData.IsGetTopRandomSkill,
			TopRandomSkillPercent = CustomData.TopRandomSkillPercent,
			IsGetAdvanceComboLength = CustomData.IsGetAdvanceComboLength,
			bCanBeForceAbort = CustomData.IsCanBeForceAbort,
			bCanBeInterruptedByHRCounterattack = false,
			UseSocketDirection = CustomData.UseSocketDirection,
			DirectionBaseSocket = new FName(CustomData.DirectionBaseSocket),
			ForwardSocket = new FName(CustomData.ForwardSocket),
			RightSocket = new FName(CustomData.RightSocket),
			SkillConfigMode = (EEscapeSkillConfigMode)CustomData.SkillConfigMode,
			AvoidObstacleSectionNum = CustomData.AvoidObstacleSectionNum,
			SectionsStartAngle = CustomData.SectionsStartAngle,
			IntervalAngle = CustomData.IntervalAngle,
			SkillArray = CustomData.SkillArray.Select((BehaviorCustom_ComboSkill comboSkill) => new FComboSkill
			{
				SkillID = comboSkill.SkillId.ToList()
			}).ToList(),
			ComboSkillNumInfo = CustomData.ComboSkillNumInfo.Select((BehaviorCustom_ComboSkillNumInfo comboSkillNumInfo) => new FComboSkillNumInfo
			{
				ComboNum = comboSkillNumInfo.ComboNum,
				ComboPercenRatio = comboSkillNumInfo.ComboPercentRatio
			}).ToList(),
			SingleDirectionSkills = CustomData.SingleDirectionSkills.ToList(),
			AvoidObstacleSections = CustomData.AvoidObstacleSections.Select((BehaviorCustom_AvoidObstacleSection avoidObstacleSection) => new FAvoidObstacleSection
			{
				StartAngle = avoidObstacleSection.StartAngle,
				EndAngle = avoidObstacleSection.EndAngle,
				SkillList = avoidObstacleSection.SkillList.ToList()
			}).ToList()
		});
	}
}
