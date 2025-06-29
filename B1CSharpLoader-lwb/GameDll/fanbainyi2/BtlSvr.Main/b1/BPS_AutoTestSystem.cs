using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_AutoTestSystem : PlayerControllerSystemBase
{
	private BUS_GSEventCollection BE { get; set; }

	private IAINodeActionInfo MoveToActionInfo { get; set; }

	private IAINodeActionInfo EQSRunActionInfo { get; set; }

	private IAINodeActionInfo ComboActionInfo { get; set; }

	private BPC_AutoTestData AutoTestData { get; set; }

	private int TickCount { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
	}

	public override void LateBeginPlay()
	{
		base.LateBeginPlay();
		CopyDataAssetToActionInfo();
		AutoTestData = RequireWritablePlayerStateData<BPC_AutoTestData>();
		BPS_GSEventCollection playerEventCollection = GetPlayerEventCollection();
		if (playerEventCollection != null)
		{
			playerEventCollection.Evt_BPS_MoveToPos += new Del_MoveToAction(MoveToPos);
			playerEventCollection.Evt_BPS_EQSRun += new Del_EQSRunAction(EQSRun);
			playerEventCollection.Evt_BPS_Combo += new Del_ComboAction(Combo);
			playerEventCollection.Evt_BPS_StopCurrentAction += new Del_Void(StopCurrentAction);
			playerEventCollection.Evt_BPS_ActionNodeFinish += new Del_ActionNodeFinish(ActionNodeFinish);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		AutoTestData.Timer += DeltaTime;
		bool flag = false;
		if (AutoTestData.Timer != 0f && AutoTestData.Timer > AutoTestData.MaxActionTime)
		{
			flag = true;
		}
		if (AutoTestData.CurrentActionType == EAINodeActionType.MoveTo)
		{
			TickCount++;
			if (TickCount % 100 == 0)
			{
				BE.Evt_TriggerJumpSkill.Invoke(ESkillDirection.Forward, default(FVector2D));
			}
		}
		if (AutoTestData.CurrentActionType == EAINodeActionType.MoveTo)
		{
			if (AutoTestData.CurrentAutoMoveMode == EAutoMoveMode.SimpleMove)
			{
				if (flag)
				{
					AutoTestData.CurrentActionType = EAINodeActionType.None;
				}
			}
			else if (AutoTestData.CurrentAutoMoveMode == EAutoMoveMode.ForcedMove && flag)
			{
				AutoTestData.CurrentActionType = EAINodeActionType.None;
				StopCurrentAction();
				GetPlayerEventCollection().Evt_BPS_MoveToActionTimeOut.Invoke(AutoTestData.CurrentTargetLocation);
			}
		}
		else if (AutoTestData.CurrentActionType == EAINodeActionType.EQSRun)
		{
			if (AutoTestData.CurrentAutoMoveMode == EAutoMoveMode.SimpleMove)
			{
				if (flag)
				{
					AutoTestData.CurrentActionType = EAINodeActionType.None;
				}
			}
			else if (AutoTestData.CurrentAutoMoveMode == EAutoMoveMode.ForcedMove && flag)
			{
				AutoTestData.CurrentActionType = EAINodeActionType.None;
				StopCurrentAction();
				GetPlayerEventCollection().Evt_BPS_EQSRunActionTimeOut.Invoke(AutoTestData.CurrentTargetLocation);
			}
		}
		else if (AutoTestData.CurrentActionType == EAINodeActionType.Combo && flag)
		{
			AutoTestData.CurrentActionType = EAINodeActionType.None;
			StopCurrentAction();
			GetPlayerEventCollection().Evt_BPS_ComboActionTimeOut.Invoke(AutoTestData.CurEnemy);
		}
	}

	public void CopyDataAssetToActionInfo()
	{
		BGWDataAsset_AutoTestMoveToConfig bGWDataAsset_AutoTestMoveToConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_AutoTestMoveToConfig>("BGWDataAsset_AutoTestMoveToConfig'/Game/00Main/DataAsset/Player/Wukong/AutoTestMoveToWuKong.AutoTestMoveToWuKong'", ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_AutoTestMoveToConfig != null)
		{
			MoveToActionInfo = new AINodeAction_MoveToParamInfo
			{
				MaxMoveTime = bGWDataAsset_AutoTestMoveToConfig.MaxMoveTime,
				AcceptableRadius = bGWDataAsset_AutoTestMoveToConfig.AcceptableRadius,
				IncludeSelfRadius = bGWDataAsset_AutoTestMoveToConfig.IncludeSelfRadius,
				IncludeTargetRadius = bGWDataAsset_AutoTestMoveToConfig.IncludeTargetRadius,
				BTTargetType = bGWDataAsset_AutoTestMoveToConfig.BTTargetType,
				MoveAIType = bGWDataAsset_AutoTestMoveToConfig.MoveAIType,
				SpeedRateType = bGWDataAsset_AutoTestMoveToConfig.SpeedRateType,
				SpeedRateDistanceCurve = bGWDataAsset_AutoTestMoveToConfig.SpeedRateDistanceCurve,
				EnableRangeAcceptableRadius = bGWDataAsset_AutoTestMoveToConfig.EnableRangeAcceptableRadius,
				MinAcceptableRadius = bGWDataAsset_AutoTestMoveToConfig.MinAcceptableRadius,
				MaxAcceptableRadius = bGWDataAsset_AutoTestMoveToConfig.MaxAcceptableRadius
			};
		}
		BGWDataAsset_AutoTestEQSRunConfig bGWDataAsset_AutoTestEQSRunConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_AutoTestEQSRunConfig>("BGWDataAsset_AutoTestEQSRunConfig'/Game/00Main/DataAsset/Player/Wukong/AutoTestEQSRunWuKong.AutoTestEQSRunWuKong'", ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_AutoTestEQSRunConfig != null)
		{
			EQSRunActionInfo = new AINodeAction_EQSRunParamInfo
			{
				AcceptableRadius = bGWDataAsset_AutoTestEQSRunConfig.AcceptableRadius,
				IncludeSelfRadius = bGWDataAsset_AutoTestEQSRunConfig.IncludeSelfRadius,
				EQSTemplate = bGWDataAsset_AutoTestEQSRunConfig.EQSTemplate,
				MoveAIType = bGWDataAsset_AutoTestEQSRunConfig.MoveAIType,
				SpeedRateType = bGWDataAsset_AutoTestEQSRunConfig.SpeedRateType,
				SpeedRateDistanceCurve = bGWDataAsset_AutoTestEQSRunConfig.SpeedRateDistanceCurve,
				EnableRangeAcceptableRadius = bGWDataAsset_AutoTestEQSRunConfig.EnableRangeAcceptableRadius,
				MinAcceptableRadius = bGWDataAsset_AutoTestEQSRunConfig.MinAcceptableRadius,
				MaxAcceptableRadius = bGWDataAsset_AutoTestEQSRunConfig.MaxAcceptableRadius,
				AutoUpdatePathTime = bGWDataAsset_AutoTestEQSRunConfig.AutoUpdatePathTime,
				EnableLeisure = bGWDataAsset_AutoTestEQSRunConfig.EnableLeisure,
				IntervalTime = bGWDataAsset_AutoTestEQSRunConfig.IntervalTime,
				LeisureList = bGWDataAsset_AutoTestEQSRunConfig.LeisureList.ToList()
			};
		}
		BGWDataAsset_AutoTestComboConfig bGWDataAsset_AutoTestComboConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_AutoTestComboConfig>("BGWDataAsset_AutoTestComboConfig'/Game/00Main/DataAsset/Player/Wukong/AutoTestComboWuIKong.AutoTestComboWuIKong'", ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_AutoTestComboConfig != null)
		{
			ComboActionInfo = new AINodeAction_ComboParamInfo
			{
				SkillSourceType = bGWDataAsset_AutoTestComboConfig.SkillSourceType,
				PursuitAnyWhere = bGWDataAsset_AutoTestComboConfig.PursuitAnyWhere,
				PursuitInAllSkill = bGWDataAsset_AutoTestComboConfig.PursuitInAllSkill,
				PursuitRangePos = bGWDataAsset_AutoTestComboConfig.PursuitRangePos,
				SpeedRateType = bGWDataAsset_AutoTestComboConfig.SpeedRateType,
				MotionMatchingMoveMode = bGWDataAsset_AutoTestComboConfig.MotionMatchingMoveMode,
				MoveAIType = bGWDataAsset_AutoTestComboConfig.MoveAIType,
				MoveAcceptableRadiusType = bGWDataAsset_AutoTestComboConfig.MoveAcceptableRadiusType,
				BeginRotateAngle = bGWDataAsset_AutoTestComboConfig.BeginRotateAngle,
				IsUseSkillForTurn = bGWDataAsset_AutoTestComboConfig.IsUseSkillForTurn,
				IsUseSkillForMove = bGWDataAsset_AutoTestComboConfig.IsUseSkillForMove,
				BeginMoveDistanceWhenUseSkill = bGWDataAsset_AutoTestComboConfig.BeginMoveDistanceWhenUseSkill,
				EnableInterruptReduceCBNum = bGWDataAsset_AutoTestComboConfig.EnableInterruptReduceCBNum,
				NeedTraceHitTargetBefore = bGWDataAsset_AutoTestComboConfig.NeedTraceHitTargetBefore,
				EnableForceComboRelation = bGWDataAsset_AutoTestComboConfig.EnableForceComboRelation,
				EnableComboCondition = bGWDataAsset_AutoTestComboConfig.EnableComboCondition,
				TraceDistance = bGWDataAsset_AutoTestComboConfig.TraceDistance,
				TraceTypeQuery = bGWDataAsset_AutoTestComboConfig.TraceTypeQuery,
				IsGetTopRandomSkill = bGWDataAsset_AutoTestComboConfig.IsGetTopRandomSkill,
				TopRandomSkillPercent = bGWDataAsset_AutoTestComboConfig.TopRandomSkillPercent,
				IsGetAdvanceComboLength = bGWDataAsset_AutoTestComboConfig.IsGetAdvanceComboLength,
				bCanBeForceAbort = bGWDataAsset_AutoTestComboConfig.bCanBeForceAbort,
				bCanBeInterruptedByHRCounterattack = bGWDataAsset_AutoTestComboConfig.bCanBeInterruptedByHRCounterattack,
				UseSocketDirection = bGWDataAsset_AutoTestComboConfig.UseSocketDirection,
				DirectionBaseSocket = bGWDataAsset_AutoTestComboConfig.DirectionBaseSocket,
				ForwardSocket = bGWDataAsset_AutoTestComboConfig.ForwardSocket,
				RightSocket = bGWDataAsset_AutoTestComboConfig.RightSocket,
				SkillConfigMode = bGWDataAsset_AutoTestComboConfig.SkillConfigMode,
				AvoidObstacleSectionNum = bGWDataAsset_AutoTestComboConfig.AvoidObstacleSectionNum,
				SectionsStartAngle = bGWDataAsset_AutoTestComboConfig.SectionsStartAngle,
				IntervalAngle = bGWDataAsset_AutoTestComboConfig.IntervalAngle,
				SkillArray = bGWDataAsset_AutoTestComboConfig.SkillArray.ToList(),
				ComboSkillNumInfo = bGWDataAsset_AutoTestComboConfig.ComboSkillNumInfo.ToList(),
				SingleDirectionSkills = bGWDataAsset_AutoTestComboConfig.SingleDirectionSkills.ToList(),
				AvoidObstacleSections = bGWDataAsset_AutoTestComboConfig.AvoidObstacleSections.ToList()
			};
		}
	}

	public void MoveToPos(FVector TargetLocation, bool IsForvedMove, float MaxTime)
	{
		if (IsForvedMove)
		{
			AutoTestData.MaxActionTime = MaxTime;
		}
		AutoTestData.Timer = 0f;
		AutoTestData.CurrentTargetLocation = TargetLocation;
		AutoTestData.IsForced = IsForvedMove;
		AutoTestData.CurrentAutoMoveMode = (IsForvedMove ? EAutoMoveMode.ForcedMove : EAutoMoveMode.SimpleMove);
		AINodeAction_MoveToParamInfo obj = MoveToActionInfo as AINodeAction_MoveToParamInfo;
		obj.BTTargetType = EBTTargetType.Location;
		obj.TargetLocation = TargetLocation;
		MoveToAINode();
	}

	public void EQSRun(UEnvQuery EnvQuery, float MaxTime)
	{
		AutoTestData.MaxActionTime = MaxTime;
		AutoTestData.Timer = 0f;
		AINodeAction_EQSRunParamInfo obj = EQSRunActionInfo as AINodeAction_EQSRunParamInfo;
		AutoTestData.MaxActionTime = MaxTime;
		obj.EQSTemplate = EnvQuery;
		EQSRunAINode();
	}

	public void Combo(float MaxTime, AActor Enemy)
	{
		AutoTestData.MaxActionTime = MaxTime;
		AutoTestData.Timer = 0f;
		AutoTestData.CurEnemy = Enemy;
		BE.Evt_AICatchTarget.Invoke(Enemy, ETargetSourceType.Target_AutoTest, SkipWakeUp: true);
		ComboAINode();
	}

	public void MoveToAINode()
	{
		AutoTestData.CurrentActionType = EAINodeActionType.MoveTo;
		BE.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.MoveTo, MoveToActionInfo);
	}

	public void EQSRunAINode()
	{
		AutoTestData.CurrentActionType = EAINodeActionType.EQSRun;
		BE.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.EQSRun, EQSRunActionInfo);
	}

	public void ComboAINode()
	{
		AutoTestData.CurrentActionType = EAINodeActionType.Combo;
		BE.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.Combo, ComboActionInfo);
	}

	public void ActionNodeFinish(EAINodeActionType ActionType)
	{
		float timer = AutoTestData.Timer;
		switch (ActionType)
		{
		case EAINodeActionType.MoveTo:
			MoveToPos(AutoTestData.CurrentTargetLocation, AutoTestData.IsForced, AutoTestData.MaxActionTime);
			AutoTestData.Timer = timer;
			break;
		case EAINodeActionType.Combo:
			Combo(AutoTestData.MaxActionTime, AutoTestData.CurEnemy);
			AutoTestData.Timer = timer;
			break;
		case EAINodeActionType.EQSRun:
			break;
		}
	}

	public void StopCurrentAction()
	{
		AutoTestData.CurrentActionType = EAINodeActionType.None;
		BE.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.None, ComboActionInfo);
	}
}
