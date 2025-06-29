using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public static class QuestNodeInstanceFactory
{
	private static Dictionary<string, Func<QuestNodeInstance>> NodeClassDictionary { get; }

	static QuestNodeInstanceFactory()
	{
		NodeClassDictionary = new Dictionary<string, Func<QuestNodeInstance>>();
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.Counter, CreateNodeInstance<QuestNodeInstance_Counter>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.CustomInput, CreateNodeInstance<QuestNodeInstance_CustomInput>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.CustomOutput, CreateNodeInstance<QuestNodeInstance_CustomOutput>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.ExecutionMultiGate, CreateNodeInstance<QuestNodeInstance_ExecutionMultiGate>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.ExecutionSequence, CreateNodeInstance<QuestNodeInstance_ExecutionSequence>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.Finish, CreateNodeInstance<QuestNodeInstance_Finish>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.LevelStream, CreateNodeInstance<QuestNodeInstance_LevelStream>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.Log, CreateNodeInstance<QuestNodeInstance_Log>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.LogicalAnd, CreateNodeInstance<QuestNodeInstance_LogicalAnd>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.LogicalOr, CreateNodeInstance<QuestNodeInstance_LogicalOr>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.NotifyActor, CreateNodeInstance<QuestNodeInstance_NotifyActor>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.ObserveByCondition, CreateNodeInstance<QuestNodeInstance_ObserveByCondition>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.Reroute, CreateNodeInstance<QuestNodeInstance_Reroute>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.Start, CreateNodeInstance<QuestNodeInstance_Start>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SubGraph, CreateNodeInstance<QuestNodeInstance_SubGraph>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.Timer, CreateNodeInstance<QuestNodeInstance_Timer>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.BlendToCamera, CreateNodeInstance<QuestNodeInstance_BlendToCamera>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayLevelSequence, CreateNodeInstance<QuestNodeInstance_PlayLevelSequence>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SwitchCameraGroup, CreateNodeInstance<QuestNodeInstance_SwitchCameraGroup>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.GainItem, CreateNodeInstance<QuestNodeInstance_GainItem>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.GainItemPerformance, CreateNodeInstance<QuestNodeInstance_GainItemPerformance>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.QueryGameState, CreateNodeInstance<QuestNodeInstance_QueryGameState>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PostAkEvent, CreateNodeInstance<QuestNodeInstance_PostAkEvent>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.Teleport, CreateNodeInstance<QuestNodeInstance_Teleport>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.BackToCheckPoint, CreateNodeInstance<QuestNodeInstance_BackToCheckPoint>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SaveArchive, CreateNodeInstance<QuestNodeInstance_SaveArchive>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.AiConversation, CreateNodeInstance<QuestNodeInstance_AiConversation>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayAnimMontage, CreateNodeInstance<QuestNodeInstance_PlayAnimMontage>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.AddBuff, CreateNodeInstance<QuestNodeInstance_AddBuff>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.GamePass, CreateNodeInstance<QuestNodeInstance_GamePass>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SetCameraTransform, CreateNodeInstance<QuestNodeInstance_SetCameraTransform>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SetPlayerRebirthPoint, CreateNodeInstance<QuestNodeInstance_SetPlayerRebirthPoint>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.ObserveOnlineCondition, CreateNodeInstance<QuestNodeInstance_ObserveOnlineCondition>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.TriggerOlineScreenMsg, CreateNodeInstance<QuestNodeInstance_TriggerOlineScreenMsg>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.RunProcessGraph, CreateNodeInstance<QuestNodeInstance_RunProcessGraph>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.RemoveBuff, CreateNodeInstance<QuestNodeInstance_RemoveBuff>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.AwardPrizesRandom, CreateNodeInstance<QuestNodeInstance_AwardPrizesRandom>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SpawnBossTrace, CreateNodeInstance<QuestNodeInstance_SpawnBossTrace>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.UnitTeleport, CreateNodeInstance<QuestNodeInstance_UnitTeleport>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.RaiseAwardProbability, CreateNodeInstance<QuestNodeInstance_RaiseAwardProbability>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SetAwardState, CreateNodeInstance<QuestNodeInstance_SetAwardState>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayerLockTrainDummyTarget, CreateNodeInstance<QuestNodeInstance_PlayerLockTrainDummyTarget>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayerCastSkill, CreateNodeInstance<QuestNodeInstance_PlayerCastSkill>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayerCastMagic, CreateNodeInstance<QuestNodeInstance_PlayerCastMagic>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayerUseItem, CreateNodeInstance<QuestNodeInstance_PlayerUseItem>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayerCondition, CreateNodeInstance<QuestNodeInstance_PlayerCondition>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayerMoveToTrainDummyTarget, CreateNodeInstance<QuestNodeInstance_PlayerMoveToTrainDummyTarget>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.TrainDummyResultReport, CreateNodeInstance<QuestNodeInstance_TrainDummyResultReport>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.QuitGame, CreateNodeInstance<QuestNodeInstance_QuitGame>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.ChallengeSuccess, CreateNodeInstance<QuestNodeInstance_ChallengeSuccess>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.SetInteractState, CreateNodeInstance<QuestNodeInstance_SetInteractState>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.StartWaveSpawnByChallenge, CreateNodeInstance<QuestNodeInstance_StartWaveSpawnByChallenge>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.StopWaveSpawnByChallenge, CreateNodeInstance<QuestNodeInstance_StopWaveSpawnByChallenge>);
		NodeClassDictionary.Add(B1CalliopeDef.QuestNode.PlayDBCEfxToInteract, CreateNodeInstance<QuestNodeInstance_PlayDBCEfxToInteract>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.ObserveRoleData, CreateNodeInstance<TaskNodeInstance_ObserveRoleData>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.ObserveUnitByCondition, CreateNodeInstance<TaskNodeInstance_ObserveUnitByCondition>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.PushTaskStageState, CreateNodeInstance<TaskNodeInstance_PushTaskStage>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.QueryCompoundCondition, CreateNodeInstance<TaskNodeInstance_QueryCompoundCondition>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.ObserveSequence, CreateNodeInstance<TaskNodeInstance_ObserveSequence>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.ChapterClear, CreateNodeInstance<TaskNodeInstance_ChapterClear>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.ObserveUnitsDeadWithOrder, CreateNodeInstance<TaskNodeInstance_ObserveUnitsDeadWithOrder>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.Demo820LevelAward, CreateNodeInstance<TaskNodeInstance_Demo820LevelAward>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.Demo820LevelPass, CreateNodeInstance<TaskNodeInstance_Demo820LevelPass>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.GameLevelPassFinal, CreateNodeInstance<TaskNodeInstance_GameLevelPassFinal>);
		NodeClassDictionary.Add(B1CalliopeDef.TaskNode.PrologueCompleted, CreateNodeInstance<TaskNodeInstance_PrologueCompleted>);
	}

	private static QuestNodeInstance CreateNodeInstance<T>() where T : new()
	{
		return new T() as QuestNodeInstance;
	}

	public static QuestNodeInstance Create(FCalliopeNode Node, UObject InOwner, QuestInstance InParentInstance)
	{
		if (NodeClassDictionary.TryGetValue(Node.NodeClass, out var value))
		{
			QuestNodeInstance questNodeInstance = value();
			questNodeInstance.Owner = InOwner;
			questNodeInstance.Node = Node;
			questNodeInstance.ParentInstance = InParentInstance;
			questNodeInstance.NotifyPostCreate();
			if (questNodeInstance.IsDataValid())
			{
				return questNodeInstance;
			}
			BGW_LogUtil.LogError($"Node : (Class:{Node.NodeClass} Id : {Node.NodeGuid})'s Data is NotValid");
			return null;
		}
		return null;
	}
}
