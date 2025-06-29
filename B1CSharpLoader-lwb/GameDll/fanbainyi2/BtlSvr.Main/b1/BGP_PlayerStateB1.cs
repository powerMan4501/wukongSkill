using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGP_PlayerStateB1")]
public class BGP_PlayerStateB1 : BGP_PlayerStateCS
{
	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.CreateDataContainer(initializer);
		base.BGPDataComp = initializer.CreateDefaultSubobject<BPS_PlayerStateDataCompB1>(this, B1GlobalFNames.PlayerStateDataCompB1);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGP_PlayerStateB1");
	}

	static BGP_PlayerStateB1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGP_PlayerStateB1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGP_PlayerStateB1));
	}
}
