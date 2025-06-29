using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("试玩版获取奖励")]
[USharpPath("/Script/b1-Managed.BED_TaskNode_Demo820LevelAward")]
public class BED_TaskNode_Demo820LevelAward : BED_TaskNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.Demo820LevelAward;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_Demo820LevelAward");
	}

	static BED_TaskNode_Demo820LevelAward()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_Demo820LevelAward)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_Demo820LevelAward));
	}
}
