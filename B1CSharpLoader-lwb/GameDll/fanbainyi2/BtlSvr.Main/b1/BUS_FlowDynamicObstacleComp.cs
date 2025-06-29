using b1.CppExport;
using b1.Plugins.DonAINavigation;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FlowDynamicObstacleComp : BUS_QuestCompBase
{
	private BUC_FlowDynamicObstacleData DynamicObstacleData { get; set; }

	private UShapeComponent CollisionComponent { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		DynamicObstacleData = RequireWritableData<BUC_FlowDynamicObstacleData>();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		CollisionComponent = base.Owner.GetComponentByClass<UShapeComponent>();
		if (DynamicObstacleData.bAutoEnable)
		{
			EnableCollision();
		}
		else
		{
			DisableCollision();
		}
	}

	protected override void NotifyFromGraph(GameplayTagContainerRef NotifyTags)
	{
		base.NotifyFromGraph(NotifyTags);
		if (NotifyTags.HasTag(BGW_FlowUtils.CommonTag.Enable) || NotifyTags.HasTag(BGW_FlowUtils.DynamicObstacleTag.Event_Enable))
		{
			EnableCollision();
		}
		else if (NotifyTags.HasTag(BGW_FlowUtils.CommonTag.Disable) || NotifyTags.HasTag(BGW_FlowUtils.DynamicObstacleTag.Event_Disable))
		{
			DisableCollision();
		}
	}

	private void EnableCollision()
	{
		CollisionComponent?.SetCollisionEnabled(ECollisionEnabled.QueryAndPhysics);
		UGSE_NavigationFuncLib.SetCollisionNavAreaClass(CollisionComponent, UClass.GetClass<UNavArea_Obstacle>());
		DynamicObstacleData.bEnable = true;
		WriteLog("Enable DynamicObstacle");
		UDonNavigationHelper.OnUpdateDynamicCollision(CollisionComponent, DynamicObstacleData.bEnableDebug);
	}

	private void DisableCollision()
	{
		CollisionComponent?.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		UGSE_NavigationFuncLib.SetCollisionNavAreaClass(CollisionComponent, UClass.GetClass<UNavArea_Default>());
		DynamicObstacleData.bEnable = false;
		WriteLog("Disable DynamicObstacle");
		UDonNavigationHelper.OnUpdateDynamicCollision(CollisionComponent, DynamicObstacleData.bEnableDebug);
	}
}
