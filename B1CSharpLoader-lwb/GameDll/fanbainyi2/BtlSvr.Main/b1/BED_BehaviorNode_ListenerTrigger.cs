using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_ListenerTrigger")]
public class BED_BehaviorNode_ListenerTrigger : BED_BehaviorNode
{
	public override EBehaviorNodeSide NodeSide => EBehaviorNodeSide.LeftNode;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeCategory("ListenerTrigger");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_ListenerTrigger");
	}

	static BED_BehaviorNode_ListenerTrigger()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_ListenerTrigger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_ListenerTrigger));
	}
}
