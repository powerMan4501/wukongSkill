using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("试玩版通关")]
[USharpPath("/Script/b1-Managed.BED_TaskNode_Demo820LevelPass")]
public class BED_TaskNode_Demo820LevelPass : BED_TaskNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.Demo820LevelPass;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_Demo820LevelPass");
	}

	static BED_TaskNode_Demo820LevelPass()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_Demo820LevelPass)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_Demo820LevelPass));
	}
}
