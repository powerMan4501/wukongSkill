using System;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_FSMNode_PS_TransactionBase")]
public class BED_FSMNode_PS_TransactionBase : BED_FSMNode
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_PS_TransactionBase");
	}

	static BED_FSMNode_PS_TransactionBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_PS_TransactionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_PS_TransactionBase));
	}
}
