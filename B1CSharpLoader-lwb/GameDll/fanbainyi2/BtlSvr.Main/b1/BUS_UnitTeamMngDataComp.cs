using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_UnitTeamMngDataComp")]
internal class BUS_UnitTeamMngDataComp : BUS_ActorBaseDataComp
{
	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		CreateDataClass<b1.BUC_UnitTeamMngConfigData>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_UnitTeamMngDataComp");
	}

	static BUS_UnitTeamMngDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_UnitTeamMngDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_UnitTeamMngDataComp));
	}
}
