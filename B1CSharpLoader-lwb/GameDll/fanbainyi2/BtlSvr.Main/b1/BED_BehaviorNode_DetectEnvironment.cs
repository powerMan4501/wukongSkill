using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Placeable(false)]
[DisplayName("检测当前环境")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectEnvironment")]
internal class BED_BehaviorNode_DetectEnvironment : BED_BehaviorNode_Condition
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.DetectEnvironment;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_DetectEnvironment");
	}

	static BED_BehaviorNode_DetectEnvironment()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_DetectEnvironment)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_DetectEnvironment));
	}
}
