using System;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("播放结束后")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_AfterPlay")]
internal class BED_MovieNode_AfterPlay : b1.BED_MovieNode_Event
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.AfterPlay;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_AfterPlay");
	}

	static BED_MovieNode_AfterPlay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_AfterPlay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_AfterPlay));
	}
}
