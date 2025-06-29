using System.Collections.Generic;
using b1.Plugins.DonAINavigation;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestDynamicObstacleComp : BUS_StateMachineCompBase
{
	public class EnableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_Enabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Disable, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestDynamicObstacleComp bUS_QuestDynamicObstacleComp)
			{
				bUS_QuestDynamicObstacleComp.EnableCollision();
			}
		}
	}

	public class DisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DynamicObstacleTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Enable, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
			base.ReactionDictionary.Add(BGW_FlowUtils.DynamicObstacleTag.Event_Disable, OnEnterAction);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestDynamicObstacleComp bUS_QuestDynamicObstacleComp)
			{
				bUS_QuestDynamicObstacleComp.DisableCollision();
			}
		}
	}

	private BUC_QuestDynamicObstacleData DynamicObstacleData { get; set; }

	private List<TWeakObject<UPrimitiveComponent>> CollisionComponents { get; } = new List<TWeakObject<UPrimitiveComponent>>();

	public override void OnAttach()
	{
		base.OnAttach();
		DynamicObstacleData = RequireWritableData<BUC_QuestDynamicObstacleData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.DynamicObstacle;
		GSStateBase gSStateBase = AddState(typeof(EnableState), 1);
		GSStateBase gSStateBase2 = AddState(typeof(DisableState), 0);
		base.InitialState = (DynamicObstacleData.bAutoEnable ? gSStateBase : gSStateBase2);
		CollisionComponents.Clear();
		List<UActorComponent> componentsByClass = base.Owner.GetComponentsByClass(UClass.GetClass(typeof(UShapeComponent)));
		foreach (UActorComponent item in componentsByClass)
		{
			if (item is UShapeComponent obj)
			{
				CollisionComponents.Add(new TWeakObject<UPrimitiveComponent>(obj));
			}
		}
		componentsByClass.Clear();
		componentsByClass = base.Owner.GetComponentsByClass(UClass.GetClass(typeof(UMeshComponent)));
		foreach (UActorComponent item2 in componentsByClass)
		{
			if (item2.ComponentHasTag(B1GlobalFNames.DynamicObstacleMesh) && item2 is UPrimitiveComponent obj2)
			{
				CollisionComponents.Add(new TWeakObject<UPrimitiveComponent>(obj2));
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		CollisionComponents.Clear();
		base.OnEndPlay(EndPlayReason);
	}

	private void EnableCollision()
	{
		foreach (TWeakObject<UPrimitiveComponent> collisionComponent in CollisionComponents)
		{
			if (collisionComponent.IsValid())
			{
				UPrimitiveComponent uPrimitiveComponent = collisionComponent.Get();
				uPrimitiveComponent?.SetCollisionEnabled(ECollisionEnabled.QueryAndPhysics);
				if (uPrimitiveComponent is UShapeComponent collision)
				{
					UGSE_NavigationFuncLib.SetCollisionNavAreaClass(collision, UClass.GetClass<UNavArea_Obstacle>());
				}
				UDonNavigationHelper.OnUpdateDynamicCollision(uPrimitiveComponent, DynamicObstacleData.bEnableDebug);
			}
		}
		DynamicObstacleData.bEnable = true;
		WriteLog("Enable DynamicObstacle");
		DynamicObstacleData.Evt_EnableDynamicObstacle();
	}

	private void DisableCollision()
	{
		foreach (TWeakObject<UPrimitiveComponent> collisionComponent in CollisionComponents)
		{
			if (collisionComponent.IsValid())
			{
				UPrimitiveComponent uPrimitiveComponent = collisionComponent.Get();
				uPrimitiveComponent?.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				if (uPrimitiveComponent is UShapeComponent collision)
				{
					UGSE_NavigationFuncLib.SetCollisionNavAreaClass(collision, UClass.GetClass<UNavArea_Default>());
				}
				UDonNavigationHelper.OnUpdateDynamicCollision(uPrimitiveComponent, DynamicObstacleData.bEnableDebug);
			}
		}
		DynamicObstacleData.bEnable = false;
		WriteLog("Disable DynamicObstacle");
		DynamicObstacleData.Evt_DisableDynamicObstacle();
	}

	public override void OnBeginPlay()
	{
		base.BGWEventCollection.Evt_BGW_DynamicObstaclePreload(DynamicObstacleData.PerformID);
	}
}
