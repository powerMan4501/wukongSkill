using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Desc")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_SkillNode_Desc")]
internal class BED_SkillNode_Desc : b1.BED_SkillNode
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.SkillNode.Desc;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_SkillNode_Desc");
	}

	static BED_SkillNode_Desc()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_SkillNode_Desc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_SkillNode_Desc));
	}
}
