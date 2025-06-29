using System;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_GlobalBase")]
public class BED_FSMNode_GI_GlobalBase : BED_FSMNode
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_GI_GlobalBase");
	}

	static BED_FSMNode_GI_GlobalBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_GI_GlobalBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_GI_GlobalBase));
	}
}
