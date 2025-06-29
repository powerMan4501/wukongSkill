using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Action")]
internal class BED_BehaviorNode_Action : BED_BehaviorNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.Action;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_Action");
	}

	static BED_BehaviorNode_Action()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_Action)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_Action));
	}
}
