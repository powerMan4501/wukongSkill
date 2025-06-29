using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BED_FSMNode_ConditionBase")]
public class BED_FSMNode_ConditionBase : BED_FSMNode
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.OutputPins.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_ConditionBase");
	}

	static BED_FSMNode_ConditionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_ConditionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_ConditionBase));
	}
}
