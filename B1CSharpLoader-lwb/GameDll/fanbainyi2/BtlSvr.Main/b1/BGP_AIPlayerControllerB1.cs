using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_AIPlayerControllerB1")]
public class BGP_AIPlayerControllerB1 : BGP_AIPlayerControllerCS
{
	private BGP_PlayerStateB1 PlayerStateB1 => base.PlayerState as BGP_PlayerStateB1;

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BPS_PlayerControllerDataCompB1>(this, B1GlobalFNames.PlayerControllerDataCompB1);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGP_AIPlayerControllerB1");
	}

	static BGP_AIPlayerControllerB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_AIPlayerControllerB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_AIPlayerControllerB1));
	}
}
