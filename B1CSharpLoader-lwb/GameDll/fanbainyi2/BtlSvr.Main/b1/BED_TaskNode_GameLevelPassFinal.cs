using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("最终结局通关（已废除）")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_GameLevelPassFinal")]
public class BED_TaskNode_GameLevelPassFinal : BED_TaskNode
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.GameLevelPassFinal;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_GameLevelPassFinal");
	}

	static BED_TaskNode_GameLevelPassFinal()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_GameLevelPassFinal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_GameLevelPassFinal));
	}
}
