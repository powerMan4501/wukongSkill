using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BED_FSMNode_Transit")]
public class BED_FSMNode_Transit : BED_FSMNode_SubGraph
{
	protected override ECalliopeNodeStyle GetNodeStyle()
	{
		return ECalliopeNodeStyle.Transit;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_Transit");
	}

	static BED_FSMNode_Transit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_Transit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_Transit));
	}
}
