using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public static class MovieNodeInstanceFactory
{
	private static Dictionary<string, TSubclassOf<MovieNodeInstance>> NodeClassDictionary { get; }

	static MovieNodeInstanceFactory()
	{
		NodeClassDictionary = new Dictionary<string, TSubclassOf<MovieNodeInstance>>();
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.Start, UClass.GetClass<MovieNodeInstance_Start>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.Finish, UClass.GetClass<MovieNodeInstance_Finish>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.BeforePlay, UClass.GetClass<MovieNodeInstance_BeforePlay>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PreRoll, UClass.GetClass<MovieNodeInstance_PreRoll>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.AfterPlay, UClass.GetClass<MovieNodeInstance_AfterPlay>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.OnSkipping, UClass.GetClass<MovieNodeInstance_OnSkipping>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.Cut, UClass.GetClass<MovieNodeInstance_Cut>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.Timer, UClass.GetClass<MovieNodeInstance_Timer>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.Delay, UClass.GetClass<MovieNodeInstance_Delay>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerExitPhasePerformance, UClass.GetClass<b1.MovieNodeInstance_PerformerExitPhasePerformance>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerSetTransform, UClass.GetClass<MovieNodeInstance_PerformerSetTransform>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerPostEvent, UClass.GetClass<MovieNodeInstance_PerformerPostEvent>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerAddBuff, UClass.GetClass<MovieNodeInstance_PerformerAddBuff>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerRemoveBuff, UClass.GetClass<MovieNodeInstance_PerformerRemoveBuff>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerTriggerSkillEffect, UClass.GetClass<MovieNodeInstance_PerformerTriggerSkillEffect>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerCatchTarget, UClass.GetClass<MovieNodeInstance_PerformerCatchTarget>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerStopWaiting, UClass.GetClass<MovieNodeInstance_PerformerStopWaiting>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerSetHiddenInGame, UClass.GetClass<MovieNodeInstance_PerformerSetHiddenInGame>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PlayEnd, UClass.GetClass<MovieNodeInstance_PlayEnd>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PlayerBlendPosition, UClass.GetClass<MovieNodeInstance_PlayerBlendPosition>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.ClearPlayerStates, UClass.GetClass<MovieNodeInstance_ClearPlayerStates>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PlayerLockTarget, UClass.GetClass<MovieNodeInstance_PlayerLockTarget>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PerformerSyncTransformToRefObj, UClass.GetClass<MovieNodeInstance_PerformerSyncTransformToRefObj>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.CustomEvent, UClass.GetClass<MovieNodeInstance_CustomEvent>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.GiveBackControlRight, UClass.GetClass<MovieNodeInstance_GiveBackControlRight>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.GiveBackControlRightForMonster, UClass.GetClass<MovieNodeInstance_GiveBackControlRightForMonster>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.LoadOrUnloadStreamingLevel, UClass.GetClass<MovieNodeInstance_LoadOrUnloadStreamingLevel>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.ShowOrHiddenStreamingLevel, UClass.GetClass<MovieNodeInstance_ShowOrHiddenStreamingLevel>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PlayFromMarkedFrame, UClass.GetClass<MovieNodeInstance_PlayFromMarkedFrame>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.WarmingUp, UClass.GetClass<MovieNodeInstance_WarmingUp>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.ActivateOrDeactivateStreamingSource, UClass.GetClass<MovieNodeInstance_ManipulateStreamingSource>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.SetStreamingManagerViewSource, UClass.GetClass<MovieNodeInstance_SetStreamingManagerViewSource>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.SetStreamingLevelStateInfo, UClass.GetClass<MovieNodeInstance_SetStreamingLevelStateInfo>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.ConditionQuery, UClass.GetClass<MovieNodeInstance_ConditionQuery>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.PlayerSetCloudMoveEnabled, UClass.GetClass<MovieNodeInstance_PlayerSetCloudMoveEnabled>());
		NodeClassDictionary.Add(B1CalliopeDef.MovieNode.Transformation, UClass.GetClass<MovieNodeInstance_Transformation>());
	}

	public static MovieNodeInstance Create(FCalliopeNode Node, UObject Outer = null)
	{
		if (NodeClassDictionary.TryGetValue(Node.NodeClass, out var value))
		{
			MovieNodeInstance movieNodeInstance = UObject.NewObject<MovieNodeInstance>(Outer, value.Value, default(FName), EObjectFlags.NoFlags, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
			movieNodeInstance.ParentInstance = Outer as MovieInstance;
			movieNodeInstance.Node = Node;
			movieNodeInstance.PostCreate();
			if (movieNodeInstance.IsDataValid())
			{
				return movieNodeInstance;
			}
			BGW_LogUtil.LogError($"Node : (Class:{Node.NodeClass} Id : {Node.NodeGuid})'s Data is NotValid");
			return null;
		}
		BGW_LogUtil.LogError($"Node : (Class:{Node.NodeClass} Id : {Node.NodeGuid})'s Class is not Exist");
		return null;
	}
}
