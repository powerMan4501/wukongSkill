using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TortoiseMoveMgrActorDataComp")]
public class BUS_TortoiseMoveMgrActorDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_TortoiseMoveMgrActorData>();
		CreateDataClass<BUC_QuestTortoiseCtrlData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_TortoiseMoveMgrActorDataComp");
	}

	static BUS_TortoiseMoveMgrActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_TortoiseMoveMgrActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_TortoiseMoveMgrActorDataComp));
	}
}
