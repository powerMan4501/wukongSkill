using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo")]
public struct FMovieTriggerRelationInfo
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo:TriggerType")]
	public EMovieTriggerType TriggerType;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo:bHasMultiActor")]
	public bool bHasMultiActor;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo:Monsters")]
	public List<string> Monsters;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo:ActorGuid")]
	public string ActorGuid;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo:Location")]
	public FVector Location;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo:TaskStageStatus")]
	public EStageStatus TaskStageStatus;

	[UProperty]
	[USharpPath("/Script/b1-Managed.MovieTriggerRelationInfo:TaskStage")]
	public int TaskStage;

	private static int MovieTriggerRelationInfo_StructSize;

	private static int MovieTriggerRelationInfo_IsValid;

	private static bool TriggerType_IsValid;

	private static int TriggerType_Offset;

	private static FFieldAddress TriggerType_PropertyAddress;

	private static bool bHasMultiActor_IsValid;

	private static int bHasMultiActor_Offset;

	private static FFieldAddress bHasMultiActor_PropertyAddress;

	private static bool Monsters_IsValid;

	private static int Monsters_Offset;

	private static FFieldAddress Monsters_PropertyAddress;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	private static bool Location_IsValid;

	private static int Location_Offset;

	private static bool TaskStageStatus_IsValid;

	private static int TaskStageStatus_Offset;

	private static FFieldAddress TaskStageStatus_PropertyAddress;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	public static FMovieTriggerRelationInfo? TryCreateRelationInfo(FTransitionCondition_Idle IdleCondition, BED_ProcessAsset ProcessAsset)
	{
		FMovieTriggerRelationInfo value = default(FMovieTriggerRelationInfo);
		switch (IdleCondition.ConditionType)
		{
		case ETransitionConditionType_Idle.EnterOverlap:
			value.TriggerType = EMovieTriggerType.Overlap;
			break;
		case ETransitionConditionType_Idle.InteractorEnd:
			value.TriggerType = EMovieTriggerType.Interactor;
			break;
		case ETransitionConditionType_Idle.InteractorInOverlap:
			value.TriggerType = EMovieTriggerType.Overlap;
			break;
		case ETransitionConditionType_Idle.InteractorTimeOver:
			value.TriggerType = EMovieTriggerType.Interactor;
			break;
		case ETransitionConditionType_Idle.CheckTimeInOverlap:
			value.TriggerType = EMovieTriggerType.Overlap;
			break;
		case ETransitionConditionType_Idle.TaskStage:
			value.TriggerType = EMovieTriggerType.TaskStage;
			break;
		case ETransitionConditionType_Idle.InteractionEnd:
			value.TriggerType = EMovieTriggerType.Interactor;
			break;
		case ETransitionConditionType_Idle.UnitActive:
			value.TriggerType = EMovieTriggerType.Unit;
			break;
		case ETransitionConditionType_Idle.NpcActionFinished:
			value.TriggerType = EMovieTriggerType.NPC;
			break;
		case ETransitionConditionType_Idle.NPCReach:
			value.TriggerType = EMovieTriggerType.NPC;
			break;
		case ETransitionConditionType_Idle.UnitInActive:
			value.TriggerType = EMovieTriggerType.Unit;
			break;
		}
		if (value.TriggerType == EMovieTriggerType.None)
		{
			return null;
		}
		switch (value.TriggerType)
		{
		case EMovieTriggerType.Overlap:
			foreach (FGsManagedOverlap item in ProcessAsset.CalliopeParameters.OverlapCollection)
			{
				if (!(item.ConfigGuid == IdleCondition.Overlap.ConfigGuid))
				{
					continue;
				}
				value.ActorGuid = item.ActorGuid;
				TSoftObject<AActor> actor = item.Actor;
				if (!actor.IsNull)
				{
					actor = item.Actor;
					AActor aActor2 = actor.LoadSynchronous();
					if (aActor2 != null)
					{
						value.Location = aActor2.GetActorLocation();
					}
				}
				break;
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case EMovieTriggerType.Interactor:
			foreach (FGsManagedInteractor item2 in ProcessAsset.CalliopeParameters.InteractorCollection)
			{
				if (!(item2.ConfigGuid == IdleCondition.Interactor.ConfigGuid))
				{
					continue;
				}
				value.ActorGuid = item2.ActorGuid;
				TSoftObject<AActor> actor = item2.Actor;
				if (!actor.IsNull)
				{
					actor = item2.Actor;
					AActor aActor = actor.LoadSynchronous();
					if (aActor != null)
					{
						value.Location = aActor.GetActorLocation();
					}
				}
				break;
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case EMovieTriggerType.Unit:
			foreach (FGsManagedUnit item3 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (item3.ConfigGuid == IdleCondition.Unit.ConfigGuid)
				{
					value.ActorGuid = item3.ActorGuid;
				}
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case EMovieTriggerType.NPC:
			foreach (FGsManagedNPCUnit item4 in ProcessAsset.CalliopeParameters.NPCUnitCollection)
			{
				if (item4.ConfigGuid == IdleCondition.NPCUnit.ConfigGuid)
				{
					value.ActorGuid = item4.ActorGuid;
				}
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case EMovieTriggerType.TaskStage:
			foreach (FGsManagedTaskStage item5 in ProcessAsset.CalliopeParameters.TaskStageCollection)
			{
				if (item5.ConfigGuid == IdleCondition.TaskStage.ConfigGuid)
				{
					value.TaskStage = item5.TaskStage;
					value.TaskStageStatus = IdleCondition.TaskStageStatus;
				}
			}
			break;
		}
		return value;
	}

	public static FMovieTriggerRelationInfo? TryCreateRelationInfo(FTransitionCondition_Battle BattleCondition, BED_ProcessAsset ProcessAsset)
	{
		FMovieTriggerRelationInfo value = default(FMovieTriggerRelationInfo);
		switch (BattleCondition.ConditionType)
		{
		case ETransitionConditionType_Battle.UnitsDead:
			if (BattleCondition.UnitList.ConfigGuides.Count == 0)
			{
				return null;
			}
			value.TriggerType = EMovieTriggerType.Unit;
			if (BattleCondition.UnitList.ConfigGuides.Count > 1)
			{
				value.bHasMultiActor = true;
				value.Monsters = new List<string>();
			}
			foreach (FGsManagedUnit ManagedUnit3 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (value.bHasMultiActor)
				{
					if (BattleCondition.UnitList.ConfigGuides.Any((Guid p) => p == ManagedUnit3.ConfigGuid))
					{
						value.Monsters.Add(ManagedUnit3.ActorGuid);
					}
				}
				else if (BattleCondition.UnitList.ConfigGuides[0] == ManagedUnit3.ConfigGuid)
				{
					value.ActorGuid = ManagedUnit3.ActorGuid;
					break;
				}
			}
			if (!value.bHasMultiActor && string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Battle.WaveEnd:
			value.TriggerType = EMovieTriggerType.Spawner;
			foreach (FGsManagedSpawner item in ProcessAsset.CalliopeParameters.SpawnerCollection)
			{
				if (!(item.ConfigGuid == BattleCondition.UnitSpawner.ConfigGuid))
				{
					continue;
				}
				value.ActorGuid = item.ActorGuid;
				TSoftObject<AActor> actor = item.Actor;
				if (!actor.IsNull)
				{
					actor = item.Actor;
					AActor aActor = actor.LoadSynchronous();
					if (aActor != null)
					{
						value.Location = aActor.GetActorLocation();
					}
				}
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Battle.HasBuff:
			value.TriggerType = EMovieTriggerType.Unit;
			foreach (FGsManagedUnit item2 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (item2.ConfigGuid == BattleCondition.Unit.ConfigGuid)
				{
					value.ActorGuid = item2.ActorGuid;
				}
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Battle.KillOrder:
			if (BattleCondition.UnitKillOrder.ConfigGuides.Count == 0)
			{
				return null;
			}
			value.TriggerType = EMovieTriggerType.Unit;
			if (BattleCondition.UnitKillOrder.ConfigGuides.Count > 1)
			{
				value.bHasMultiActor = true;
				value.Monsters = new List<string>();
			}
			foreach (FGsManagedUnit ManagedUnit2 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (value.bHasMultiActor)
				{
					if (BattleCondition.UnitKillOrder.ConfigGuides.Any((Guid p) => p == ManagedUnit2.ConfigGuid))
					{
						value.Monsters.Add(ManagedUnit2.ActorGuid);
					}
				}
				else if (BattleCondition.UnitKillOrder.ConfigGuides[0] == ManagedUnit2.ConfigGuid)
				{
					value.ActorGuid = ManagedUnit2.ActorGuid;
					break;
				}
			}
			if (!value.bHasMultiActor && string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Battle.UnitsAlive:
			if (BattleCondition.UnitList.ConfigGuides.Count == 0)
			{
				return null;
			}
			value.TriggerType = EMovieTriggerType.Unit;
			if (BattleCondition.UnitList.ConfigGuides.Count > 1)
			{
				value.bHasMultiActor = true;
				value.Monsters = new List<string>();
			}
			foreach (FGsManagedUnit ManagedUnit in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (value.bHasMultiActor)
				{
					if (BattleCondition.UnitList.ConfigGuides.Any((Guid p) => p == ManagedUnit.ConfigGuid))
					{
						value.Monsters.Add(ManagedUnit.ActorGuid);
					}
				}
				else if (BattleCondition.UnitList.ConfigGuides[0] == ManagedUnit.ConfigGuid)
				{
					value.ActorGuid = ManagedUnit.ActorGuid;
					break;
				}
			}
			if (!value.bHasMultiActor && string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		}
		if (value.TriggerType == EMovieTriggerType.None)
		{
			return null;
		}
		switch (value.TriggerType)
		{
		case EMovieTriggerType.Unit:
			foreach (FGsManagedUnit item3 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (item3.ConfigGuid == BattleCondition.Unit.ConfigGuid)
				{
					value.ActorGuid = item3.ActorGuid;
				}
			}
			break;
		}
		return value;
	}

	public static FMovieTriggerRelationInfo? TryCreateRelationInfo(FTransitionCondition_Group GroupCondition, BED_ProcessAsset ProcessAsset)
	{
		FMovieTriggerRelationInfo value = default(FMovieTriggerRelationInfo);
		switch (GroupCondition.ConditionType)
		{
		case ETransitionConditionType_Group.EnterOverlap:
			value.TriggerType = EMovieTriggerType.Overlap;
			break;
		case ETransitionConditionType_Group.InteractorEnd:
			value.TriggerType = EMovieTriggerType.Interactor;
			break;
		case ETransitionConditionType_Group.InteractorInOverlap:
			value.TriggerType = EMovieTriggerType.Overlap;
			break;
		case ETransitionConditionType_Group.InteractorTimeOver:
			value.TriggerType = EMovieTriggerType.Interactor;
			break;
		case ETransitionConditionType_Group.UnitsDead:
			if (GroupCondition.UnitList.ConfigGuides.Count == 0)
			{
				return null;
			}
			value.TriggerType = EMovieTriggerType.Unit;
			if (GroupCondition.UnitList.ConfigGuides.Count > 1)
			{
				value.bHasMultiActor = true;
				value.Monsters = new List<string>();
			}
			foreach (FGsManagedUnit ManagedUnit2 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (value.bHasMultiActor)
				{
					if (GroupCondition.UnitList.ConfigGuides.Any((Guid p) => p == ManagedUnit2.ConfigGuid))
					{
						value.Monsters.Add(ManagedUnit2.ActorGuid);
					}
				}
				else if (GroupCondition.UnitList.ConfigGuides[0] == ManagedUnit2.ConfigGuid)
				{
					value.ActorGuid = ManagedUnit2.ActorGuid;
					break;
				}
			}
			if (!value.bHasMultiActor && string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Group.WaveEnd:
			value.TriggerType = EMovieTriggerType.Spawner;
			foreach (FGsManagedSpawner item in ProcessAsset.CalliopeParameters.SpawnerCollection)
			{
				if (!(item.ConfigGuid == GroupCondition.UnitSpawner.ConfigGuid))
				{
					continue;
				}
				value.ActorGuid = item.ActorGuid;
				TSoftObject<AActor> actor = item.Actor;
				if (!actor.IsNull)
				{
					actor = item.Actor;
					AActor aActor = actor.LoadSynchronous();
					if (aActor != null)
					{
						value.Location = aActor.GetActorLocation();
					}
				}
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Group.HasBuff:
			value.TriggerType = EMovieTriggerType.Unit;
			foreach (FGsManagedUnit item2 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (item2.ConfigGuid == GroupCondition.Unit.ConfigGuid)
				{
					value.ActorGuid = item2.ActorGuid;
				}
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Group.KillOrder:
			if (GroupCondition.UnitKillOrder.ConfigGuides.Count == 0)
			{
				return null;
			}
			value.TriggerType = EMovieTriggerType.Unit;
			if (GroupCondition.UnitKillOrder.ConfigGuides.Count > 1)
			{
				value.bHasMultiActor = true;
				value.Monsters = new List<string>();
			}
			foreach (FGsManagedUnit ManagedUnit3 in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (value.bHasMultiActor)
				{
					if (GroupCondition.UnitKillOrder.ConfigGuides.Any((Guid p) => p == ManagedUnit3.ConfigGuid))
					{
						value.Monsters.Add(ManagedUnit3.ActorGuid);
					}
				}
				else if (GroupCondition.UnitKillOrder.ConfigGuides[0] == ManagedUnit3.ConfigGuid)
				{
					value.ActorGuid = ManagedUnit3.ActorGuid;
					break;
				}
			}
			if (!value.bHasMultiActor && string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case ETransitionConditionType_Group.UnitsAlive:
			if (GroupCondition.UnitList.ConfigGuides.Count == 0)
			{
				return null;
			}
			value.TriggerType = EMovieTriggerType.Unit;
			if (GroupCondition.UnitList.ConfigGuides.Count > 1)
			{
				value.bHasMultiActor = true;
				value.Monsters = new List<string>();
			}
			foreach (FGsManagedUnit ManagedUnit in ProcessAsset.CalliopeParameters.UnitCollection)
			{
				if (value.bHasMultiActor)
				{
					if (GroupCondition.UnitList.ConfigGuides.Any((Guid p) => p == ManagedUnit.ConfigGuid))
					{
						value.Monsters.Add(ManagedUnit.ActorGuid);
					}
				}
				else if (GroupCondition.UnitList.ConfigGuides[0] == ManagedUnit.ConfigGuid)
				{
					value.ActorGuid = ManagedUnit.ActorGuid;
					break;
				}
			}
			if (!value.bHasMultiActor && string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		}
		if (value.TriggerType == EMovieTriggerType.None)
		{
			return null;
		}
		switch (value.TriggerType)
		{
		case EMovieTriggerType.Overlap:
			foreach (FGsManagedOverlap item3 in ProcessAsset.CalliopeParameters.OverlapCollection)
			{
				if (!(item3.ConfigGuid == GroupCondition.Overlap.ConfigGuid))
				{
					continue;
				}
				value.ActorGuid = item3.ActorGuid;
				TSoftObject<AActor> actor = item3.Actor;
				if (!actor.IsNull)
				{
					actor = item3.Actor;
					AActor aActor3 = actor.LoadSynchronous();
					if (aActor3 != null)
					{
						value.Location = aActor3.GetActorLocation();
					}
				}
				break;
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		case EMovieTriggerType.Interactor:
			foreach (FGsManagedInteractor item4 in ProcessAsset.CalliopeParameters.InteractorCollection)
			{
				if (!(item4.ConfigGuid == GroupCondition.Interactor.ConfigGuid))
				{
					continue;
				}
				value.ActorGuid = item4.ActorGuid;
				TSoftObject<AActor> actor = item4.Actor;
				if (!actor.IsNull)
				{
					actor = item4.Actor;
					AActor aActor2 = actor.LoadSynchronous();
					if (aActor2 != null)
					{
						value.Location = aActor2.GetActorLocation();
					}
				}
				break;
			}
			if (string.IsNullOrEmpty(value.ActorGuid))
			{
				return null;
			}
			break;
		}
		return value;
	}

	public static FMovieTriggerRelationInfo? TryCreateRelationInfo(FObserveActorInfo ObserveActorInfo, BED_TaskAsset TaskAsset)
	{
		FMovieTriggerRelationInfo RelationInfo = default(FMovieTriggerRelationInfo);
		switch (ObserveActorInfo.ConditionType)
		{
		case EObserveConditionType.PlayerEnterArea:
		case EObserveConditionType.PlayerLeaveArea:
		case EObserveConditionType.PlayerPenetrateArea:
			RelationInfo.TriggerType = EMovieTriggerType.Overlap;
			break;
		case EObserveConditionType.PlayerInteractBegin:
		case EObserveConditionType.PlayerInteractBreak:
		case EObserveConditionType.PlayerInteractEnd:
		case EObserveConditionType.PlayerInteractTimeEnd:
			RelationInfo.TriggerType = EMovieTriggerType.Interactor;
			break;
		case EObserveConditionType.WakeUp:
		case EObserveConditionType.UnitDead:
		case EObserveConditionType.UnitDestroy:
		case EObserveConditionType.UnitActive:
		case EObserveConditionType.UnitInActive:
		case EObserveConditionType.UnitAttr:
		case EObserveConditionType.SimpleState:
		case EObserveConditionType.UnitState:
		case EObserveConditionType.HasBuff:
			RelationInfo.TriggerType = EMovieTriggerType.Unit;
			break;
		case EObserveConditionType.SpawnUnitAllDead:
			RelationInfo.TriggerType = EMovieTriggerType.Spawner;
			break;
		}
		if (RelationInfo.TriggerType == EMovieTriggerType.None)
		{
			return null;
		}
		Guid ConfigGuid = ObserveActorInfo.ObservedPlayerOrUnitOrActor.ConfigGuid;
		if (ConfigGuid == Guid.Empty)
		{
			return null;
		}
		FMovieTriggerRelationInfo? result;
		foreach (FGsManagedOverlap item in TaskAsset.CalliopeParameters.OverlapCollection)
		{
			result = TryFillRelationActor(item.ConfigGuid, item.ActorGuid, item.Actor);
			if (!result.HasValue)
			{
				continue;
			}
			result = RelationInfo;
			goto IL_0373;
		}
		foreach (FGsManagedDynamicObstacle item2 in TaskAsset.CalliopeParameters.DynamicObstacleCollection)
		{
			if (!TryFillRelationActor(item2.ConfigGuid, item2.ActorGuid, item2.Actor).HasValue)
			{
				continue;
			}
			result = RelationInfo;
			goto IL_0373;
		}
		foreach (FGsManagedInteractor item3 in TaskAsset.CalliopeParameters.InteractorCollection)
		{
			if (!TryFillRelationActor(item3.ConfigGuid, item3.ActorGuid, item3.Actor).HasValue)
			{
				continue;
			}
			result = RelationInfo;
			goto IL_0373;
		}
		foreach (FGsManagedUnit item4 in TaskAsset.CalliopeParameters.UnitCollection)
		{
			if (!TryFillRelationActor(item4.ConfigGuid, item4.ActorGuid, item4.Tamer).HasValue)
			{
				continue;
			}
			result = RelationInfo;
			goto IL_0373;
		}
		foreach (FGsManagedSpawner item5 in TaskAsset.CalliopeParameters.SpawnerCollection)
		{
			if (!TryFillRelationActor(item5.ConfigGuid, item5.ActorGuid, item5.Actor).HasValue)
			{
				continue;
			}
			result = RelationInfo;
			goto IL_0373;
		}
		foreach (FGsManagedNPCUnit item6 in TaskAsset.CalliopeParameters.NPCUnitCollection)
		{
			if (!TryFillRelationActor(item6.ConfigGuid, item6.ActorGuid, item6.Tamer).HasValue)
			{
				continue;
			}
			result = RelationInfo;
			goto IL_0373;
		}
		return RelationInfo;
		IL_0373:
		return result;
		FMovieTriggerRelationInfo? TryFillRelationActor(Guid ObjConfigGuid, string ActorGuid, TSoftObject<AActor> ActorPtr)
		{
			if (ObjConfigGuid == ConfigGuid)
			{
				RelationInfo.ActorGuid = ActorGuid;
				if (!ActorPtr.IsNull)
				{
					AActor aActor = ActorPtr.LoadSynchronous();
					if (aActor != null)
					{
						RelationInfo.Location = aActor.GetActorLocation();
					}
				}
				return RelationInfo;
			}
			return null;
		}
	}

	public static FMovieTriggerRelationInfo? TryCreateRelationInfo(BED_TaskNode_ObserveUnitsDeadWithOrder ObserveUnitsDeadWithOrder, BED_TaskAsset TaskAsset)
	{
		FMovieTriggerRelationInfo value = default(FMovieTriggerRelationInfo);
		if (ObserveUnitsDeadWithOrder.UnitList.ConfigGuides.Count == 0)
		{
			return null;
		}
		value.TriggerType = EMovieTriggerType.Unit;
		if (ObserveUnitsDeadWithOrder.UnitList.ConfigGuides.Count > 1)
		{
			value.bHasMultiActor = true;
			value.Monsters = new List<string>();
		}
		foreach (FGsManagedUnit ManagedUnit in TaskAsset.CalliopeParameters.UnitCollection)
		{
			if (value.bHasMultiActor)
			{
				if (ObserveUnitsDeadWithOrder.UnitList.ConfigGuides.Any((Guid p) => p == ManagedUnit.ConfigGuid))
				{
					value.Monsters.Add(ManagedUnit.ActorGuid);
				}
			}
			else if (ObserveUnitsDeadWithOrder.UnitList.ConfigGuides[0] == ManagedUnit.ConfigGuid)
			{
				value.ActorGuid = ManagedUnit.ActorGuid;
				break;
			}
		}
		if (!value.bHasMultiActor && string.IsNullOrEmpty(value.ActorGuid))
		{
			return null;
		}
		return value;
	}

	public List<FMovieTriggerRelationInfo> ConvertTaskStageRelation2Other(in Dictionary<int, List<FMovieTriggerRelationInfo>> TaskStageActivedRelationInfos, in Dictionary<int, List<FMovieTriggerRelationInfo>> TaskStageFinishedRelationInfos)
	{
		if (TaskStageActivedRelationInfos == null || TaskStageFinishedRelationInfos == null)
		{
			return null;
		}
		List<FMovieTriggerRelationInfo> value = null;
		if (TriggerType == EMovieTriggerType.TaskStage)
		{
			switch (TaskStageStatus)
			{
			case EStageStatus.Activated:
				if (TaskStageActivedRelationInfos.TryGetValue(TaskStage, out value))
				{
					return value;
				}
				break;
			case EStageStatus.Finished:
				if (TaskStageFinishedRelationInfos.TryGetValue(TaskStage, out value))
				{
					return value;
				}
				break;
			}
		}
		return null;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"TriggerType:{TriggerType}");
		switch (TriggerType)
		{
		case EMovieTriggerType.Overlap:
			stringBuilder.Append($"\t Overlap:{ActorGuid} Location:{Location}");
			break;
		case EMovieTriggerType.Interactor:
			stringBuilder.Append($"\t Interactor:{ActorGuid} Location:{Location}");
			break;
		case EMovieTriggerType.Unit:
			if (bHasMultiActor)
			{
				stringBuilder.Append("\tUnits:\t");
				foreach (string monster in Monsters)
				{
					stringBuilder.Append(" " + monster + " ");
				}
			}
			else
			{
				stringBuilder.Append("\t Unit:" + ActorGuid);
			}
			break;
		case EMovieTriggerType.NPC:
			stringBuilder.Append("\t NPC:" + ActorGuid);
			break;
		case EMovieTriggerType.Spawner:
			stringBuilder.Append($"\t Spawner:{ActorGuid} Location:{Location}");
			break;
		}
		return stringBuilder.ToString();
	}

	public FMovieTriggerRelationInfo Copy()
	{
		FMovieTriggerRelationInfo result = this;
		if (Monsters != null)
		{
			result.Monsters = new List<string>(Monsters);
		}
		return result;
	}

	public static FMovieTriggerRelationInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMovieTriggerRelationInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieTriggerRelationInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieTriggerRelationInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieTriggerRelationInfo(IntPtr.Add(nativeBuffer, arrayIndex * MovieTriggerRelationInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieTriggerRelationInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MovieTriggerRelationInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MovieTriggerRelationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieTriggerRelationInfo");
			return;
		}
		EnumMarshaler<EMovieTriggerType>.ToNative(IntPtr.Add(nativeStruct, TriggerType_Offset), 0, TriggerType_PropertyAddress.Address, TriggerType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bHasMultiActor_Offset), 0, bHasMultiActor_PropertyAddress.Address, bHasMultiActor);
		new TArrayCopyMarshaler<string>(1, Monsters_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, Monsters_Offset), Monsters);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		EnumMarshaler<EStageStatus>.ToNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address, TaskStageStatus);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
	}

	public FMovieTriggerRelationInfo(IntPtr nativeStruct)
	{
		if (MovieTriggerRelationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieTriggerRelationInfo");
			TriggerType = EMovieTriggerType.None;
			bHasMultiActor = false;
			Monsters = null;
			ActorGuid = null;
			Location = default(FVector);
			TaskStageStatus = EStageStatus.Default;
			TaskStage = 0;
		}
		else
		{
			TriggerType = EnumMarshaler<EMovieTriggerType>.FromNative(IntPtr.Add(nativeStruct, TriggerType_Offset), 0, TriggerType_PropertyAddress.Address);
			bHasMultiActor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bHasMultiActor_Offset), 0, bHasMultiActor_PropertyAddress.Address);
			Monsters = new TArrayCopyMarshaler<string>(1, Monsters_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, Monsters_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			TaskStageStatus = EnumMarshaler<EStageStatus>.FromNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address);
			TaskStage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MovieTriggerRelationInfo");
		MovieTriggerRelationInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TriggerType_PropertyAddress, intPtr, "TriggerType");
		TriggerType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerType");
		TriggerType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bHasMultiActor_PropertyAddress, intPtr, "bHasMultiActor");
		bHasMultiActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHasMultiActor");
		bHasMultiActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHasMultiActor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Monsters_PropertyAddress, intPtr, "Monsters");
		Monsters_Offset = NativeReflection.GetPropertyOffset(intPtr, "Monsters");
		Monsters_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Monsters", Classes.FArrayProperty);
		ActorGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		Location_Offset = NativeReflection.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStatus_PropertyAddress, intPtr, "TaskStageStatus");
		TaskStageStatus_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageStatus");
		TaskStageStatus_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageStatus", Classes.FEnumProperty);
		TaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStage", Classes.FIntProperty);
		MovieTriggerRelationInfo_IsValid = ((intPtr != IntPtr.Zero && TriggerType_IsValid && bHasMultiActor_IsValid && Monsters_IsValid && ActorGuid_IsValid && Location_IsValid && TaskStageStatus_IsValid && TaskStage_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MovieTriggerRelationInfo", (byte)MovieTriggerRelationInfo_IsValid != 0);
	}

	static FMovieTriggerRelationInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMovieTriggerRelationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieTriggerRelationInfo));
	}
}
