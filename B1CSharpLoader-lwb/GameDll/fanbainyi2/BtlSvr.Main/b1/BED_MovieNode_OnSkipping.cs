using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("跳过后")]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_MovieNode_OnSkipping")]
internal class BED_MovieNode_OnSkipping : b1.BED_MovieNode_Event
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.OnSkipping;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_OnSkipping");
	}

	static BED_MovieNode_OnSkipping()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_OnSkipping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_OnSkipping));
	}
}
