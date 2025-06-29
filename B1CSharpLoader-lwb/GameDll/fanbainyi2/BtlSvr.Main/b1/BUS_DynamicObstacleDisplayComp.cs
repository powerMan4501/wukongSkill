using b1.Plugins.DonAINavigation;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_DynamicObstacleDisplayComp : BUS_StateMachineCompBase
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
			UShapeComponent obj = BGU_DataUtil.GetReadOnlyData<b1.IBUC_DynamicObstacleConfigData, b1.BUC_DynamicObstacleConfigData>(InOwner.GetOwner())?.CollisionComp;
			obj?.SetCollisionEnabled(ECollisionEnabled.QueryAndPhysics);
			UGSE_NavigationFuncLib.SetCollisionNavAreaClass(obj, UClass.GetClass<UNavArea_Obstacle>());
			UDonNavigationHelper.OnUpdateDynamicCollision(obj, bDebug: false);
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
			UShapeComponent obj = BGU_DataUtil.GetReadOnlyData<b1.IBUC_DynamicObstacleConfigData, b1.BUC_DynamicObstacleConfigData>(InOwner.GetOwner())?.CollisionComp;
			obj?.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			UGSE_NavigationFuncLib.SetCollisionNavAreaClass(obj, UClass.GetClass<UNavArea_Default>());
			UDonNavigationHelper.OnUpdateDynamicCollision(obj, bDebug: false);
		}
	}

	private b1.BUC_DynamicObstacleConfigData DynamicObstacleConfigData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		DynamicObstacleConfigData = RequireWritableData<b1.BUC_DynamicObstacleConfigData>();
		DynamicObstacleConfigData.CollisionComp = GetOwner().GetComponentByClass<UShapeComponent>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.DynamicObstacle;
		GSStateBase gSStateBase = AddState(typeof(EnableState), 1);
		GSStateBase gSStateBase2 = AddState(typeof(DisableState), 0);
		base.InitialState = (DynamicObstacleConfigData.bDefaultEnable ? gSStateBase : gSStateBase2);
	}
}
