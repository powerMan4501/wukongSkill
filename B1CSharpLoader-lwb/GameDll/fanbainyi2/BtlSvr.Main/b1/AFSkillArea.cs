using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AFSkillArea")]
public class AFSkillArea : AttentionFeatureBase
{
	public int TeamID;

	public float DurationTime;

	public FRectParam RectParam;

	public FSectorParam SectorParam;

	public FRoundParam RoundParam;

	public FVector BaseLoc;

	public float ExecuteTime;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.FeatureType = EAIAttentionFeatureType.SkillArea;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AFSkillArea");
	}

	static AFSkillArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AFSkillArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFSkillArea));
	}
}
