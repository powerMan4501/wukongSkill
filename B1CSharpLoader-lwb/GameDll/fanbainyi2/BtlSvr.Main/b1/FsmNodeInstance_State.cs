using System;
using System.Collections.Generic;
using System.IO;
using b1.EventDelDefine;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FsmNodeInstance_State : FsmNodeInstance
{
	public FGameplayTag StateTag { get; private set; }

	public string AssetPath { get; set; }

	private bool bHasSubFsm { get; set; }

	public FCalliopeGraph SubGraph { get; set; }

	public FsmSubInstance SubInstance { get; private set; }

	public List<TransitionGuard> Guards { get; } = new List<TransitionGuard>();

	public List<FName> CustomEnterEvents { get; } = new List<FName>();

	public List<FGameplayTag> CustomExitEvents { get; } = new List<FGameplayTag>();

	public FStateNodeChildActorControl ChildActorCollection { get; set; }

	public Dictionary<TransitionGuard, FBossPhaseInfo> GuardBossPhaseInfos { get; } = new Dictionary<TransitionGuard, FBossPhaseInfo>();

	protected override void OnInitialize()
	{
		FFsmGraphCacheData graphCacheData = base.ParentInstance.GetGraphCacheData();
		StateCustom_Single stateCustom_SingleCache = graphCacheData.GetStateCustom_SingleCache(base.Node);
		StateTag = graphCacheData.GetNodeStateTag(base.Node);
		string text = ((!base.ParentInstance.FsmData.SubMachineOverrideMap.TryGetValue(StateTag, out text)) ? stateCustom_SingleCache.SubStateMachinePath : Path.Combine(Path.GetDirectoryName(text) ?? string.Empty, Path.GetFileNameWithoutExtension(text)).Replace("\\", "/"));
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = text;
			AssetPath = text2 + "." + Path.GetFileNameWithoutExtension(text2);
			SubGraph = GameplayTagExtension.LoadGraph(text, bUseCache: true);
			if (SubGraph != null)
			{
				if (SubInstance == null)
				{
					SubInstance = FsmSubInstance.Create(this);
				}
				bHasSubFsm = true;
			}
		}
		else
		{
			bHasSubFsm = false;
		}
		foreach (CalliopeCustom_DetectUnitCondition detectUnitCondition in stateCustom_SingleCache.DetectUnitConditions)
		{
			TransitionGuard transitionGuard = new TransitionGuard(detectUnitCondition);
			Guards.Add(transitionGuard);
			GuardBossPhaseInfos.Add(transitionGuard, BED_CalliopeFuncLib.Deserialize(detectUnitCondition.BossPhaseInfo));
		}
		foreach (CalliopeCustom_CompositeTransitionCondition_State otherCondition in stateCustom_SingleCache.OtherConditions)
		{
			TransitionGuard transitionGuard2 = new TransitionGuard(otherCondition);
			Guards.Add(transitionGuard2);
			GuardBossPhaseInfos.Add(transitionGuard2, BED_CalliopeFuncLib.Deserialize(otherCondition.BossPhaseInfo));
		}
		foreach (string customEnterEvent in stateCustom_SingleCache.CustomEnterEvents)
		{
			CustomEnterEvents.Add(FNameExtension.ToFName(customEnterEvent));
		}
		foreach (string customExitEvent in stateCustom_SingleCache.CustomExitEvents)
		{
			CustomExitEvents.Add(GameplayTagExtension.MakeGameplayTag(customExitEvent));
		}
		if (stateCustom_SingleCache.ChildActorCollection == null)
		{
			return;
		}
		ChildActorCollection = new FStateNodeChildActorControl
		{
			JJSObstacleCollection = new List<FStateNodeChildActorControlJJSObstacle>()
		};
		foreach (CalliopeCustom_StateNodeChildActorControlJJSObstacle item2 in stateCustom_SingleCache.ChildActorCollection.JjsobstacleCollection)
		{
			FStateNodeChildActorControlJJSObstacle item = new FStateNodeChildActorControlJJSObstacle
			{
				Nickname = GameplayTagExtension.MakeGameplayTag(item2.Nickname),
				State = (EDynamicObstacleState)item2.State
			};
			ChildActorCollection.JJSObstacleCollection.Add(item);
		}
	}

	protected override void OnExecuteNode()
	{
		SetObjStateOnBeginning();
		if (bHasSubFsm)
		{
			if (SubInstance == null)
			{
				SubInstance = FsmSubInstance.Create(this);
			}
			if (SubInstance == null)
			{
				return;
			}
			SubInstance.Start();
		}
		AfterEnterNode();
	}

	protected override void OnExecuteNode_Custom(FName CustomEvent)
	{
		SetObjStateOnBeginning();
		if (bHasSubFsm)
		{
			if (SubInstance == null)
			{
				SubInstance = FsmSubInstance.Create(this);
			}
			if (SubInstance == null)
			{
				return;
			}
			SubInstance.Start_Custom(CustomEvent);
		}
		AfterEnterNode();
	}

	private void SetObjStateOnBeginning()
	{
		if (ChildActorCollection.JJSObstacleCollection == null)
		{
			return;
		}
		IBGC_CircusControlData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CircusControlData>(UGameplayStatics.GetGameState(base.ParentInstance.Owner));
		new List<string>();
		foreach (FStateNodeChildActorControlJJSObstacle JJSConfig in ChildActorCollection.JJSObstacleCollection)
		{
			readOnlyData.TravelCircus(base.ParentInstance.Owner, delegate(CircusMember TreeNode)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.ParentInstance.Owner, TreeNode.ActorGuid);
				if (actorByGuid != null)
				{
					BUS_EventCollectionCS.Get(actorByGuid).Evt_SwitchJJSObstacleState.Invoke(JJSConfig.State == EDynamicObstacleState.Opened);
				}
			}, delegate(CircusMember TreeNode)
			{
				List<string> nickName = TreeNode.NickName;
				FName tagName = JJSConfig.Nickname.TagName;
				return nickName.Contains(tagName.ToString());
			});
		}
	}

	protected override void OnNodeBack2History(bool bDeepHistory)
	{
		SetObjStateOnBeginning();
		if (bHasSubFsm)
		{
			if (SubInstance == null)
			{
				SubInstance = FsmSubInstance.Create(this);
				if (SubInstance == null)
				{
					return;
				}
				SubInstance?.Start();
			}
			else
			{
				SubInstance.Back2History(bDeepHistory);
			}
		}
		AfterEnterNode();
	}

	private void OnTransition(FGameplayTag EventTag)
	{
		if (GameplayTagExtension.EqualTo(EventTag, BGW_FlowUtils.NormalAIFsmEventTag.CommonReset))
		{
			ExitNode();
		}
		else if (GameplayTagExtension.EqualTo(EventTag, BGW_FlowUtils.NormalAIFsmEventTag.ExitAll))
		{
			ExitNode();
		}
		else if (base.OutEdges.Count > 0)
		{
			foreach (KeyValuePair<FName, (Guid, FName)> outEdge in base.OutEdges)
			{
				if (GameplayTagExtension.EqualTo(EventTag, outEdge.Key))
				{
					ExitNode();
					ExecuteNextNode(outEdge.Value.Item1, outEdge.Value.Item2);
					break;
				}
			}
		}
		if (bHasSubFsm)
		{
			SubInstance?.Evt_NotifyStateTransition(EventTag);
		}
	}

	private void OnTick(float InDeltaTime)
	{
		if (Guards.Count > 0)
		{
			foreach (TransitionGuard guard in Guards)
			{
				guard.OnTick(InDeltaTime);
			}
		}
		if (Guards.Count > 0)
		{
			foreach (TransitionGuard guard2 in Guards)
			{
				if (!guard2.IsSuccess())
				{
					continue;
				}
				{
					foreach (KeyValuePair<FName, (Guid, FName)> outEdge in base.OutEdges)
					{
						if (outEdge.Key == guard2.GuardPinName)
						{
							if (GuardBossPhaseInfos.TryGetValue(guard2, out var value))
							{
								base.ParentInstance.PhaseComp?.Transition(value);
							}
							ExitNode();
							ExecuteNextNode(outEdge.Value.Item1, outEdge.Value.Item2);
							break;
						}
					}
					return;
				}
			}
		}
		if (bHasSubFsm)
		{
			SubInstance?.OnTick(InDeltaTime);
		}
	}

	private void AfterEnterNode()
	{
		foreach (TransitionGuard guard in Guards)
		{
			guard.Start(base.ParentInstance.Owner);
		}
		base.ParentInstance.OnEnterState(StateTag);
		FsmInstance parentInstance = base.ParentInstance;
		parentInstance.Evt_NotifyStateTransition = (Del_Void_FGameplayTag)Delegate.Combine(parentInstance.Evt_NotifyStateTransition, new Del_Void_FGameplayTag(OnTransition));
		FsmInstance parentInstance2 = base.ParentInstance;
		parentInstance2.Evt_NotifyStateTick = (Del_Void_Float)Delegate.Combine(parentInstance2.Evt_NotifyStateTick, new Del_Void_Float(OnTick));
	}

	private void ExitNode()
	{
		foreach (TransitionGuard guard in Guards)
		{
			guard.Stop();
		}
		if (bHasSubFsm)
		{
			SubInstance?.ExitFsm();
		}
		base.ParentInstance.OnExitState(StateTag);
		base.ParentInstance.TemplateAsset.DeactivateNode(base.Node.NodeGuid);
		FsmInstance parentInstance = base.ParentInstance;
		parentInstance.Evt_NotifyStateTransition = (Del_Void_FGameplayTag)Delegate.Remove(parentInstance.Evt_NotifyStateTransition, new Del_Void_FGameplayTag(OnTransition));
		FsmInstance parentInstance2 = base.ParentInstance;
		parentInstance2.Evt_NotifyStateTick = (Del_Void_Float)Delegate.Remove(parentInstance2.Evt_NotifyStateTick, new Del_Void_Float(OnTick));
	}

	protected override void Shutdown()
	{
		if (bHasSubFsm)
		{
			SubInstance.Shutdown();
			base.ParentInstance.RemoveSubInstance(SubInstance);
			SubInstance = null;
		}
	}

	protected override void OnForceExitNode()
	{
		ExitNode();
	}
}
