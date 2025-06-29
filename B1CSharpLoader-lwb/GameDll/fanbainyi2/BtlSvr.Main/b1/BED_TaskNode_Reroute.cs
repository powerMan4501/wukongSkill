using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Reroute")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_Reroute")]
public class BED_TaskNode_Reroute : BED_TaskNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Reroute;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_Reroute");
	}

	static BED_TaskNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_Reroute));
	}
}
