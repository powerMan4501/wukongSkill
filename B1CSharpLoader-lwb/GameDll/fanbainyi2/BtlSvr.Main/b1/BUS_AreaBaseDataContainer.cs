using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AreaBaseDataContainer")]
public class BUS_AreaBaseDataContainer : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<BUC_AreaBasicData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AreaBaseDataContainer");
	}

	static BUS_AreaBaseDataContainer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AreaBaseDataContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AreaBaseDataContainer));
	}
}
