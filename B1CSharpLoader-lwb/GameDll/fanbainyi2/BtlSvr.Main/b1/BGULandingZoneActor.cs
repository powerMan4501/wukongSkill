using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGULandingZoneActor")]
public class BGULandingZoneActor : BGU_EQSPointRecorderActor
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_LandingZoneComp>();
	}

	protected override void CreateDataContainer(FObjectInitializer Initializer)
	{
		base.DataComp = Initializer.CreateDefaultSubobject<BUS_LandingZoneDataComp>(this, B1GlobalFNames.LandingZoneDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGULandingZoneActor");
	}

	static BGULandingZoneActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGULandingZoneActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGULandingZoneActor));
	}
}
