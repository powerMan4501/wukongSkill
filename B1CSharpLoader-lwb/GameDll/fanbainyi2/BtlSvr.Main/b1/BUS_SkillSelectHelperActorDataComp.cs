using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SkillSelectHelperActorDataComp")]
public class BUS_SkillSelectHelperActorDataComp : BUS_ActorBaseDataComp
{
	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SkillSelectHelperActorDataComp");
	}

	static BUS_SkillSelectHelperActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SkillSelectHelperActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SkillSelectHelperActorDataComp));
	}
}
