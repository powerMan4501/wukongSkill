using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("序章完成")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_PrologueCompleted")]
public class BED_TaskNode_PrologueCompleted : BED_TaskNode
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.PrologueCompleted;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_PrologueCompleted");
	}

	static BED_TaskNode_PrologueCompleted()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_PrologueCompleted)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_PrologueCompleted));
	}
}
