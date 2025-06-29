using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_InitThink")]
internal class BAID_InitThink : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor.IsNullOrDestroyed())
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerActor);
		UBehaviorTree currentTree = UGSE_BehaviorTreeFuncLib.GetCurrentTree(BGU_DataUtil.GetUnPersistentReadOnlyData<UBUC_AIComponent>(OwnerActor).AIController);
		FBehaviorTreeNodeData NodeData = default(FBehaviorTreeNodeData);
		NodeData.TaskNodeList = new List<UBTTaskNode>();
		UGSE_BehaviorTreeFuncLib.GetBTTaskNodes(currentTree, out NodeData);
		int count = NodeData.TaskNodeList.Count;
		bUS_GSEventCollection.Evt_OnInitThink.Invoke(currentTree.GetName().ToString(), count);
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_InitThink");
	}

	static BAID_InitThink()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_InitThink)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_InitThink));
	}
}
