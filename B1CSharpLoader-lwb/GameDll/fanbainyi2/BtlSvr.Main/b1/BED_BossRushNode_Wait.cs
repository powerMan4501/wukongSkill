using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("等待开始（Wait）")]
[USharpPath("/Script/b1-Managed.BED_BossRushNode_Wait")]
public class BED_BossRushNode_Wait : BED_BossRushNode_TemplateBase
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.BossRushNode.Wait;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BossRushNode_Wait");
	}

	static BED_BossRushNode_Wait()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BossRushNode_Wait)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BossRushNode_Wait));
	}
}
