using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSkillSelectHelperActor")]
public class BGUSkillSelectHelperActor : BGUActorBaseCS
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_SkillSelectHelperActorComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SkillSelectHelperActorDataComp>(this, B1GlobalFNames.SkillSelectHelperActorDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSkillSelectHelperActor");
	}

	static BGUSkillSelectHelperActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSkillSelectHelperActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSkillSelectHelperActor));
	}
}
