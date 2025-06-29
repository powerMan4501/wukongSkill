using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AFStandInSkillArea")]
public class AFStandInSkillArea : AttentionFeatureBase
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.FeatureType = EAIAttentionFeatureType.StandInSkillArea;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AFStandInSkillArea");
	}

	static AFStandInSkillArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AFStandInSkillArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFStandInSkillArea));
	}
}
