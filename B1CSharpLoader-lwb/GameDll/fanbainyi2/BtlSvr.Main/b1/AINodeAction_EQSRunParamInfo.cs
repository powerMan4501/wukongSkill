using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;

namespace b1;

public class AINodeAction_EQSRunParamInfo : IAINodeActionInfo
{
	public float AcceptableRadius { get; set; }

	public bool IncludeSelfRadius { get; set; }

	public UEnvQuery EQSTemplate { get; set; }

	public EBGUMoveAIType MoveAIType { get; set; }

	public EAIMoveSpeedType SpeedRateType { get; set; }

	public UCurveFloat SpeedRateDistanceCurve { get; set; }

	public bool EnableRangeAcceptableRadius { get; set; }

	public float MinAcceptableRadius { get; set; }

	public float MaxAcceptableRadius { get; set; }

	public bool bEnableContinuousPathFinding { get; set; }

	public float ContinuousPathFindingRadiusThreshold { get; set; }

	public GSTurnSkillConfig TurnSkillConfig { get; set; } = new GSTurnSkillConfig();

	public float AutoUpdatePathTime { get; set; }

	public bool EnableDebug { get; set; }

	public bool EnableLeisure { get; set; }

	public float IntervalTime { get; set; }

	public bool EnableDrawLineDebug { get; set; }

	public List<FGSLeisureWithWeight> LeisureList { get; set; } = new List<FGSLeisureWithWeight>();

	public AINodeAction_EQSRunParamInfo()
	{
	}

	public AINodeAction_EQSRunParamInfo(FEQSRunParamInfo BPParam)
	{
		AcceptableRadius = BPParam.AcceptableRadius;
		IncludeSelfRadius = BPParam.IncludeSelfRadius;
		EQSTemplate = BPParam.EQSTemplate;
		MoveAIType = BPParam.MoveAIType;
		SpeedRateType = BPParam.SpeedRateType;
		SpeedRateDistanceCurve = BPParam.SpeedRateDistanceCurve;
		EnableRangeAcceptableRadius = BPParam.EnableRangeAcceptableRadius;
		MinAcceptableRadius = BPParam.MinAcceptableRadius;
		MaxAcceptableRadius = BPParam.MaxAcceptableRadius;
		bEnableContinuousPathFinding = BPParam.bEnableContinuousPathFinding;
		ContinuousPathFindingRadiusThreshold = BPParam.ContinuousPathFindingRadiusThreshold;
		AutoUpdatePathTime = BPParam.AutoUpdatePathTime;
		EnableDebug = BPParam.EnableDebug;
		EnableLeisure = BPParam.EnableLeisure;
		IntervalTime = BPParam.IntervalTime;
		LeisureList = BPParam.LeisureList;
		EnableDrawLineDebug = BPParam.EnableDrawLineDebug;
	}
}
