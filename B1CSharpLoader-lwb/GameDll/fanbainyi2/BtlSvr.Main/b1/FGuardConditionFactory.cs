using System.Collections.Generic;
using CommB1;
using GurCalliopeState;

namespace b1;

public static class FGuardConditionFactory
{
	private static readonly Dictionary<EGuardConditionType, Stack<FGuardConditionBase>> Available = new Dictionary<EGuardConditionType, Stack<FGuardConditionBase>>();

	public static FGuardConditionBase CreateInstance(EGuardConditionType InInstanceKey)
	{
		return InInstanceKey switch
		{
			EGuardConditionType.CompositeAnd => new FGuardCondition_CompositeAnd(), 
			EGuardConditionType.CompositeOr => new FGuardCondition_CompositeOr(), 
			EGuardConditionType.PlayerAlive => new FGuardCondition_PlayerAlive(), 
			EGuardConditionType.PlayerDead => new FGuardCondition_PlayerDead(), 
			EGuardConditionType.PlayerRebirth => new FGuardCondition_PlayerRebirth(), 
			EGuardConditionType.InteractRebirthPoint => new FGuardCondition_InteractRebirthPoint(), 
			EGuardConditionType.InAbnormalState => new FGuardCondition_InAbnormalState(), 
			EGuardConditionType.CloseToMonster => new FGuardCondition_CloseToMonster(), 
			EGuardConditionType.PlayerAttr => new FGuardCondition_PlayerAttr(), 
			EGuardConditionType.CurrentMap => new FGuardCondition_CurrentMap(), 
			EGuardConditionType.EnterOverlap => new FGuardCondition_EnterOverlap(), 
			EGuardConditionType.InOverlapBox => new FGuardCondition_InOverlapBox(), 
			EGuardConditionType.NotInOverlapBox => new FGuardCondition_NotInOverlapBox(), 
			EGuardConditionType.InteractorEnd => new FGuardCondition_InteractorEnd(), 
			EGuardConditionType.InteractorTimeOver => new FGuardCondition_InteractorTimeOver(), 
			EGuardConditionType.InteractorInOverlap => new FGuardCondition_InteractorInOverlap(), 
			EGuardConditionType.GameStateCondition => new FGuardCondition_GameStateCondition(), 
			EGuardConditionType.ActionsAllFinish => new FGuardCondition_ActionsAllFinish(), 
			EGuardConditionType.CheckTimeInOverlap => new FGuardCondition_CheckTimeInOverlap(), 
			EGuardConditionType.CheckTimeOutOverlap => new FGuardCondition_CheckTimeOutOverlap(), 
			EGuardConditionType.NotPlayingSeq => new FGuardCondition_NotPlayingSeq(), 
			EGuardConditionType.SequencePlayed => new FGuardCondition_SequencePlayed(), 
			EGuardConditionType.TaskStage => new FGuardCondition_TaskStage(), 
			EGuardConditionType.GamePlayCount => new FGuardCondition_GamePlayerCount(), 
			EGuardConditionType.ConsumedItem => new FGuardCondition_ConsumedItem(), 
			EGuardConditionType.GainItem => new FGuardCondition_GainItem(), 
			EGuardConditionType.OwningItem => new FGuardCondition_OwningItem(), 
			EGuardConditionType.UnownedEnoughItem => new FGuardCondition_UnownedItem(), 
			EGuardConditionType.InteractionRecord => new FGuardCondition_InteractionRecord(), 
			EGuardConditionType.InteractionEnd => new FGuardCondition_InteractionEnd(), 
			EGuardConditionType.UnitActive => new FGuardCondition_UnitActive(), 
			EGuardConditionType.UnitInActive => new FGuardCondition_UnitInActive(), 
			EGuardConditionType.UnitsDead => new FGuardCondition_UnitsDead(), 
			EGuardConditionType.GroupUnitDead => new FGuardCondition_GroupUnitDead(), 
			EGuardConditionType.Countdown => new FGuardCondition_Countdown(), 
			EGuardConditionType.UnitsAlive => new FGuardCondition_UnitsAlive(), 
			EGuardConditionType.WaveEnd => new FGuardCondition_WaveEnd(), 
			EGuardConditionType.HasBuff => new FGuardCondition_HasBuff(), 
			EGuardConditionType.KillOrder => new FGuardCondition_KillOrder(), 
			EGuardConditionType.Time => new FGuardCondition_Time(), 
			EGuardConditionType.UnitsTransStage => new FGuardCondition_UnitsTransStage(), 
			EGuardConditionType.NpcActionFinished => new FGuardCondition_NpcActionFinished(), 
			EGuardConditionType.NPCReach => new FGuardCondition_NPCReach(), 
			EGuardConditionType.AiConversationChainEnd => new FGuardCondition_AiConversationChainEnd(), 
			EGuardConditionType.DetectUnit => new FGuardCondition_DetectUnit(), 
			EGuardConditionType.CircusInteractorEnd => new FGuardCondition_CircusInteractorEnd(), 
			EGuardConditionType.CircusEnterOverlap => new FGuardCondition_CircusEnterOverlap(), 
			EGuardConditionType.LearnTalent => new FGuardCondition_LearnTalent(), 
			EGuardConditionType.OpenUIPage => new FGuardCondition_OpenUIPage(), 
			EGuardConditionType.DropUIConfirm => new FGuardCondition_DropUIConfirm(), 
			EGuardConditionType.FinishGuideGroup => new FGuardCondition_FinishGuideGroup(), 
			EGuardConditionType.ObserveSequence => new FGuardCondition_ObserveSequence(), 
			EGuardConditionType.UIFinishBattle => new FGuardCondition_UIFinishBattle(), 
			EGuardConditionType.PlayerCloudMove => new FGuardCondition_PlayerCloudMove(), 
			EGuardConditionType.PlayerTransAsFox => new FGuardCondition_PlayerTransAsFox(), 
			EGuardConditionType.UnlockMap => new FGuardCondition_UnlockMap(), 
			_ => null, 
		};
	}

	public static FGuardConditionBase New(EGuardConditionType InGuardConditionType)
	{
		if (Available.TryGetValue(InGuardConditionType, out var value) && value.Count > 0)
		{
			return value.Pop();
		}
		FGuardConditionBase fGuardConditionBase = CreateInstance(InGuardConditionType);
		if (fGuardConditionBase != null)
		{
			fGuardConditionBase.bCreateByPool = true;
			return fGuardConditionBase;
		}
		return null;
	}

	public static FGuardConditionBase New(CalliopeCustom_CompositeTransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (IdleCondition.IsUseCompositeCondition)
		{
			EGuardConditionType? eGuardConditionType = null;
			switch ((EConditionalRelation)(byte)IdleCondition.ConditionalRelation)
			{
			case EConditionalRelation.And:
				eGuardConditionType = EGuardConditionType.CompositeAnd;
				break;
			case EConditionalRelation.Or:
				eGuardConditionType = EGuardConditionType.CompositeOr;
				break;
			}
			if (eGuardConditionType.HasValue)
			{
				FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
				fGuardConditionBase.Initial(IdleCondition, InPsmNodeInstance);
				return fGuardConditionBase;
			}
			return null;
		}
		return New(IdleCondition.Single, InPsmNodeInstance);
	}

	public static FGuardConditionBase New(CalliopeCustom_CompositeTransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (BattleCondition.IsUseCompositeCondition)
		{
			EGuardConditionType? eGuardConditionType = null;
			switch ((EConditionalRelation)(byte)BattleCondition.ConditionalRelation)
			{
			case EConditionalRelation.And:
				eGuardConditionType = EGuardConditionType.CompositeAnd;
				break;
			case EConditionalRelation.Or:
				eGuardConditionType = EGuardConditionType.CompositeOr;
				break;
			}
			if (eGuardConditionType.HasValue)
			{
				FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
				fGuardConditionBase.Initial(BattleCondition, InPsmNodeInstance);
				return fGuardConditionBase;
			}
			return null;
		}
		return New(BattleCondition.Single, InPsmNodeInstance);
	}

	public static FGuardConditionBase New(CalliopeCustom_CompositeTransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (GroupCondition.IsUseCompositeCondition)
		{
			EGuardConditionType? eGuardConditionType = null;
			switch ((EConditionalRelation)(byte)GroupCondition.ConditionalRelation)
			{
			case EConditionalRelation.And:
				eGuardConditionType = EGuardConditionType.CompositeAnd;
				break;
			case EConditionalRelation.Or:
				eGuardConditionType = EGuardConditionType.CompositeOr;
				break;
			}
			if (eGuardConditionType.HasValue)
			{
				FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
				fGuardConditionBase.Initial(GroupCondition, InPsmNodeInstance);
				return fGuardConditionBase;
			}
			return null;
		}
		return New(GroupCondition.Single, InPsmNodeInstance);
	}

	public static FGuardConditionBase New(CalliopeCustom_CompositeTransitionCondition_State StateCondition)
	{
		if (StateCondition.IsUseCompositeCondition)
		{
			EGuardConditionType? eGuardConditionType = null;
			switch ((EConditionalRelation)(byte)StateCondition.ConditionalRelation)
			{
			case EConditionalRelation.And:
				eGuardConditionType = EGuardConditionType.CompositeAnd;
				break;
			case EConditionalRelation.Or:
				eGuardConditionType = EGuardConditionType.CompositeOr;
				break;
			}
			if (eGuardConditionType.HasValue)
			{
				FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
				fGuardConditionBase.Initial(StateCondition);
				return fGuardConditionBase;
			}
			return null;
		}
		return New(StateCondition.Single);
	}

	public static FGuardConditionBase New(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		EGuardConditionType? eGuardConditionType = null;
		switch ((ETransitionConditionType_Idle)(byte)IdleCondition.ConditionType)
		{
		case ETransitionConditionType_Idle.EnterOverlap:
			eGuardConditionType = EGuardConditionType.EnterOverlap;
			break;
		case ETransitionConditionType_Idle.InOverlapBox:
			eGuardConditionType = EGuardConditionType.InOverlapBox;
			break;
		case ETransitionConditionType_Idle.NotInOverlapBox:
			eGuardConditionType = EGuardConditionType.NotInOverlapBox;
			break;
		case ETransitionConditionType_Idle.InteractorEnd:
			eGuardConditionType = EGuardConditionType.InteractorEnd;
			break;
		case ETransitionConditionType_Idle.InteractorInOverlap:
			eGuardConditionType = EGuardConditionType.InteractorInOverlap;
			break;
		case ETransitionConditionType_Idle.GameStateCondition:
			eGuardConditionType = EGuardConditionType.GameStateCondition;
			break;
		case ETransitionConditionType_Idle.ActionsAllFinish:
			eGuardConditionType = EGuardConditionType.ActionsAllFinish;
			break;
		case ETransitionConditionType_Idle.InteractorTimeOver:
			eGuardConditionType = EGuardConditionType.InteractorTimeOver;
			break;
		case ETransitionConditionType_Idle.CheckTimeInOverlap:
			eGuardConditionType = EGuardConditionType.CheckTimeInOverlap;
			break;
		case ETransitionConditionType_Idle.CheckTimeOutOverlap:
			eGuardConditionType = EGuardConditionType.CheckTimeOutOverlap;
			break;
		case ETransitionConditionType_Idle.TaskStage:
			eGuardConditionType = EGuardConditionType.TaskStage;
			break;
		case ETransitionConditionType_Idle.ConsumedItem:
			eGuardConditionType = EGuardConditionType.ConsumedItem;
			break;
		case ETransitionConditionType_Idle.OwningItem:
			eGuardConditionType = EGuardConditionType.OwningItem;
			break;
		case ETransitionConditionType_Idle.InteractionRecord:
			eGuardConditionType = EGuardConditionType.InteractionRecord;
			break;
		case ETransitionConditionType_Idle.InteractionEnd:
			eGuardConditionType = EGuardConditionType.InteractionEnd;
			break;
		case ETransitionConditionType_Idle.UnitActive:
			eGuardConditionType = EGuardConditionType.UnitActive;
			break;
		case ETransitionConditionType_Idle.NpcActionFinished:
			eGuardConditionType = EGuardConditionType.NpcActionFinished;
			break;
		case ETransitionConditionType_Idle.NPCReach:
			eGuardConditionType = EGuardConditionType.NPCReach;
			break;
		case ETransitionConditionType_Idle.AiConversationChainEnd:
			eGuardConditionType = EGuardConditionType.AiConversationChainEnd;
			break;
		case ETransitionConditionType_Idle.UnownedEnoughItem:
			eGuardConditionType = EGuardConditionType.UnownedEnoughItem;
			break;
		case ETransitionConditionType_Idle.UnitInActive:
			eGuardConditionType = EGuardConditionType.UnitInActive;
			break;
		case ETransitionConditionType_Idle.PlayerCloudMove:
			eGuardConditionType = EGuardConditionType.PlayerCloudMove;
			break;
		case ETransitionConditionType_Idle.PlayerTransAsFox:
			eGuardConditionType = EGuardConditionType.PlayerTransAsFox;
			break;
		}
		if (eGuardConditionType.HasValue)
		{
			FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
			fGuardConditionBase.Initial(IdleCondition, InPsmNodeInstance);
			return fGuardConditionBase;
		}
		return null;
	}

	public static FGuardConditionBase New(CalliopeCustom_CompositeTransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		if (GuideCondition.IsUseCompositeCondition)
		{
			EGuardConditionType? eGuardConditionType = null;
			switch ((EConditionalRelation)(byte)GuideCondition.ConditionalRelation)
			{
			case EConditionalRelation.And:
				eGuardConditionType = EGuardConditionType.CompositeAnd;
				break;
			case EConditionalRelation.Or:
				eGuardConditionType = EGuardConditionType.CompositeOr;
				break;
			}
			if (eGuardConditionType.HasValue)
			{
				FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
				fGuardConditionBase.Initial(GuideCondition, InPsmNodeInstance);
				return fGuardConditionBase;
			}
			return null;
		}
		return New(GuideCondition.Single, InPsmNodeInstance);
	}

	public static FGuardConditionBase New(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		EGuardConditionType? eGuardConditionType = null;
		switch ((ETransitionConditionType_Guide)(byte)GuideCondition.ConditionType)
		{
		case ETransitionConditionType_Guide.EnterOverlap:
			eGuardConditionType = EGuardConditionType.EnterOverlap;
			break;
		case ETransitionConditionType_Guide.InOverlapBox:
			eGuardConditionType = EGuardConditionType.InOverlapBox;
			break;
		case ETransitionConditionType_Guide.NotInOverlapBox:
			eGuardConditionType = EGuardConditionType.NotInOverlapBox;
			break;
		case ETransitionConditionType_Guide.InAbnormalState:
			eGuardConditionType = EGuardConditionType.InAbnormalState;
			break;
		case ETransitionConditionType_Guide.InteractRebirthPoint:
			eGuardConditionType = EGuardConditionType.InteractRebirthPoint;
			break;
		case ETransitionConditionType_Guide.PlayerDead:
			eGuardConditionType = EGuardConditionType.PlayerDead;
			break;
		case ETransitionConditionType_Guide.PlayerRebirth:
			eGuardConditionType = EGuardConditionType.PlayerRebirth;
			break;
		case ETransitionConditionType_Guide.UnitDead:
			eGuardConditionType = EGuardConditionType.UnitsDead;
			break;
		case ETransitionConditionType_Guide.GainItem:
			eGuardConditionType = EGuardConditionType.GainItem;
			break;
		case ETransitionConditionType_Guide.PlayerAttr:
			eGuardConditionType = EGuardConditionType.PlayerAttr;
			break;
		case ETransitionConditionType_Guide.UnitActive:
			eGuardConditionType = EGuardConditionType.UnitActive;
			break;
		case ETransitionConditionType_Guide.CloseToMonster:
			eGuardConditionType = EGuardConditionType.CloseToMonster;
			break;
		case ETransitionConditionType_Guide.TaskStage:
			eGuardConditionType = EGuardConditionType.TaskStage;
			break;
		case ETransitionConditionType_Guide.CurrentMap:
			eGuardConditionType = EGuardConditionType.CurrentMap;
			break;
		case ETransitionConditionType_Guide.NotPlayingSeq:
			eGuardConditionType = EGuardConditionType.NotPlayingSeq;
			break;
		case ETransitionConditionType_Guide.LearnTalent:
			eGuardConditionType = EGuardConditionType.LearnTalent;
			break;
		case ETransitionConditionType_Guide.OpenUIPage:
			eGuardConditionType = EGuardConditionType.OpenUIPage;
			break;
		case ETransitionConditionType_Guide.DropUIConfirm:
			eGuardConditionType = EGuardConditionType.DropUIConfirm;
			break;
		case ETransitionConditionType_Guide.FinishGuideGroup:
			eGuardConditionType = EGuardConditionType.FinishGuideGroup;
			break;
		case ETransitionConditionType_Guide.ObserveSequence:
			eGuardConditionType = EGuardConditionType.ObserveSequence;
			break;
		case ETransitionConditionType_Guide.OwningItem:
			eGuardConditionType = EGuardConditionType.OwningItem;
			break;
		case ETransitionConditionType_Guide.OldPlayerForUnlockMap:
		case ETransitionConditionType_Guide.NewPlayerForUnlockMap:
			eGuardConditionType = EGuardConditionType.UnlockMap;
			break;
		}
		if (eGuardConditionType.HasValue)
		{
			FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
			fGuardConditionBase.Initial(GuideCondition, InPsmNodeInstance);
			return fGuardConditionBase;
		}
		return null;
	}

	public static FGuardConditionBase New(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		EGuardConditionType? eGuardConditionType = null;
		switch ((ETransitionConditionType_Battle)(byte)BattleCondition.ConditionType)
		{
		case ETransitionConditionType_Battle.None:
			eGuardConditionType = EGuardConditionType.None;
			break;
		case ETransitionConditionType_Battle.UnitsDead:
			eGuardConditionType = EGuardConditionType.UnitsDead;
			break;
		case ETransitionConditionType_Battle.WaveEnd:
			eGuardConditionType = EGuardConditionType.WaveEnd;
			break;
		case ETransitionConditionType_Battle.HasBuff:
			eGuardConditionType = EGuardConditionType.HasBuff;
			break;
		case ETransitionConditionType_Battle.KillOrder:
			eGuardConditionType = EGuardConditionType.KillOrder;
			break;
		case ETransitionConditionType_Battle.UnitsTransStage:
			eGuardConditionType = EGuardConditionType.UnitsTransStage;
			break;
		case ETransitionConditionType_Battle.UnitsAlive:
			eGuardConditionType = EGuardConditionType.UnitsAlive;
			break;
		case ETransitionConditionType_Battle.GroupUnitDead:
			eGuardConditionType = EGuardConditionType.GroupUnitDead;
			break;
		case ETransitionConditionType_Battle.Countdown:
			eGuardConditionType = EGuardConditionType.Countdown;
			break;
		case ETransitionConditionType_Battle.NotInOverlapBox:
			eGuardConditionType = EGuardConditionType.NotInOverlapBox;
			break;
		case ETransitionConditionType_Battle.InOverlapBox:
			eGuardConditionType = EGuardConditionType.InOverlapBox;
			break;
		case ETransitionConditionType_Battle.UIBattleFinish:
			eGuardConditionType = EGuardConditionType.UIFinishBattle;
			break;
		case ETransitionConditionType_Battle.PlayerAlive:
			eGuardConditionType = EGuardConditionType.PlayerAlive;
			break;
		case ETransitionConditionType_Battle.PlayerDead:
			eGuardConditionType = EGuardConditionType.PlayerDead;
			break;
		}
		if (eGuardConditionType.HasValue)
		{
			FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
			fGuardConditionBase.Initial(BattleCondition, InPsmNodeInstance);
			return fGuardConditionBase;
		}
		return null;
	}

	public static FGuardConditionBase New(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		EGuardConditionType? eGuardConditionType = null;
		switch ((ETransitionConditionType_Group)(byte)GroupCondition.ConditionType)
		{
		case ETransitionConditionType_Group.EnterOverlap:
			eGuardConditionType = EGuardConditionType.EnterOverlap;
			break;
		case ETransitionConditionType_Group.InOverlapBox:
			eGuardConditionType = EGuardConditionType.InOverlapBox;
			break;
		case ETransitionConditionType_Group.NotInOverlapBox:
			eGuardConditionType = EGuardConditionType.NotInOverlapBox;
			break;
		case ETransitionConditionType_Group.InteractorEnd:
			eGuardConditionType = EGuardConditionType.InteractorEnd;
			break;
		case ETransitionConditionType_Group.InteractorInOverlap:
			eGuardConditionType = EGuardConditionType.InteractorInOverlap;
			break;
		case ETransitionConditionType_Group.GameStateCondition:
			eGuardConditionType = EGuardConditionType.GameStateCondition;
			break;
		case ETransitionConditionType_Group.InteractorTimeOver:
			eGuardConditionType = EGuardConditionType.InteractorTimeOver;
			break;
		case ETransitionConditionType_Group.UnitsDead:
			eGuardConditionType = EGuardConditionType.UnitsDead;
			break;
		case ETransitionConditionType_Group.WaveEnd:
			eGuardConditionType = EGuardConditionType.WaveEnd;
			break;
		case ETransitionConditionType_Group.HasBuff:
			eGuardConditionType = EGuardConditionType.HasBuff;
			break;
		case ETransitionConditionType_Group.KillOrder:
			eGuardConditionType = EGuardConditionType.KillOrder;
			break;
		case ETransitionConditionType_Group.SequencePlayed:
			eGuardConditionType = EGuardConditionType.SequencePlayed;
			break;
		case ETransitionConditionType_Group.TaskStage:
			eGuardConditionType = EGuardConditionType.TaskStage;
			break;
		case ETransitionConditionType_Group.UnitsAlive:
			eGuardConditionType = EGuardConditionType.UnitsAlive;
			break;
		case ETransitionConditionType_Group.UIBattleFinish:
			eGuardConditionType = EGuardConditionType.UIFinishBattle;
			break;
		}
		if (eGuardConditionType.HasValue)
		{
			FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
			fGuardConditionBase.Initial(GroupCondition, InPsmNodeInstance);
			return fGuardConditionBase;
		}
		return null;
	}

	private static FGuardConditionBase New(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		EGuardConditionType? eGuardConditionType = null;
		switch ((ETransitionConditionType_State)(byte)StateCondition.ConditionType)
		{
		case ETransitionConditionType_State.EnterOverlap:
			eGuardConditionType = EGuardConditionType.EnterOverlap;
			break;
		case ETransitionConditionType_State.InOverlapBox:
			eGuardConditionType = EGuardConditionType.InOverlapBox;
			break;
		case ETransitionConditionType_State.NotInOverlapBox:
			eGuardConditionType = EGuardConditionType.NotInOverlapBox;
			break;
		case ETransitionConditionType_State.InteractorEnd:
			eGuardConditionType = EGuardConditionType.InteractorEnd;
			break;
		case ETransitionConditionType_State.InteractorTimeOver:
			eGuardConditionType = EGuardConditionType.InteractorTimeOver;
			break;
		case ETransitionConditionType_State.UnitsDead:
			eGuardConditionType = EGuardConditionType.UnitsDead;
			break;
		case ETransitionConditionType_State.WaveEnd:
			eGuardConditionType = EGuardConditionType.WaveEnd;
			break;
		case ETransitionConditionType_State.HasBuff:
			eGuardConditionType = EGuardConditionType.HasBuff;
			break;
		case ETransitionConditionType_State.SequencePlayed:
			eGuardConditionType = EGuardConditionType.SequencePlayed;
			break;
		case ETransitionConditionType_State.TaskStage:
			eGuardConditionType = EGuardConditionType.TaskStage;
			break;
		case ETransitionConditionType_State.GamePlayCount:
			eGuardConditionType = EGuardConditionType.GamePlayCount;
			break;
		case ETransitionConditionType_State.CircusInteractorEnd:
			eGuardConditionType = EGuardConditionType.CircusInteractorEnd;
			break;
		case ETransitionConditionType_State.CircusEnterOverlap:
			eGuardConditionType = EGuardConditionType.CircusEnterOverlap;
			break;
		}
		if (eGuardConditionType.HasValue)
		{
			FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
			fGuardConditionBase.Initial(StateCondition);
			return fGuardConditionBase;
		}
		return null;
	}

	public static FGuardConditionBase New(CalliopeCustom_DetectUnitCondition DetectUnitCondition)
	{
		if (DetectUnitCondition.Conditions.Count > 1)
		{
			EGuardConditionType? eGuardConditionType = null;
			switch ((EConditionalRelation)(byte)DetectUnitCondition.ConditionalRelation)
			{
			case EConditionalRelation.And:
				eGuardConditionType = EGuardConditionType.CompositeAnd;
				break;
			case EConditionalRelation.Or:
				eGuardConditionType = EGuardConditionType.CompositeOr;
				break;
			}
			if (eGuardConditionType.HasValue)
			{
				FGuardConditionBase fGuardConditionBase = New(eGuardConditionType.Value);
				fGuardConditionBase.Initial(DetectUnitCondition);
				return fGuardConditionBase;
			}
		}
		else if (DetectUnitCondition.Conditions.Count == 1)
		{
			return New((EDetectedUnitType)DetectUnitCondition.UnitType, DetectUnitCondition.SmartUnitGuid, DetectUnitCondition.Conditions[0]);
		}
		return null;
	}

	public static FGuardConditionBase New(EDetectedUnitType InUnitType, string InUnitGuid, CalliopeCustom_DetectCondition InDetectCondition)
	{
		FGuardConditionBase fGuardConditionBase = New(EGuardConditionType.DetectUnit);
		fGuardConditionBase.Initial(InUnitType, InUnitGuid, InDetectCondition);
		return fGuardConditionBase;
	}

	public static void Return(FGuardConditionBase InCondition)
	{
		if (InCondition.bCreateByPool)
		{
			InCondition.NotifyClean();
			EGuardConditionType conditionType = InCondition.ConditionType;
			if (!Available.ContainsKey(conditionType))
			{
				Available.Add(conditionType, new Stack<FGuardConditionBase>());
			}
			Available[conditionType].Push(InCondition);
		}
	}
}
