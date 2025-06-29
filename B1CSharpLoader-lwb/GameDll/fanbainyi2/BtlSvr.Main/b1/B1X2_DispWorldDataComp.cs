using System;
using UnrealEngine.Runtime;

namespace b1;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.B1X2_DispWorldDataComp")]
internal class B1X2_DispWorldDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
	}

	internal void Reset()
	{
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.B1X2_DispWorldDataComp");
	}

	static B1X2_DispWorldDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.B1X2_DispWorldDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.B1X2_DispWorldDataComp));
	}
}
