using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_LoadingBase")]
public class BED_FSMNode_GI_LoadingBase : BED_FSMNode
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_GI_LoadingBase");
	}

	static BED_FSMNode_GI_LoadingBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_GI_LoadingBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_GI_LoadingBase));
	}
}
